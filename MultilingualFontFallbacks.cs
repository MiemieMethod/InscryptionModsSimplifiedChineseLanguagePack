using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using HarmonyLib;
using TMPro;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;
using UIText = UnityEngine.UI.Text;

namespace SimplifiedChineseLanguagePack
{
    [HarmonyPatch]
    internal static class MultilingualFontFallbacks
    {
        private static readonly Dictionary<Language, Dictionary<(TMP_FontAsset Source, TMP_FontAsset Primary), TMP_FontAsset>> LocalizedFonts = new();
        private static readonly Dictionary<Font, TMP_FontAsset> DynamicFonts = new();
        private static readonly Dictionary<TMP_FontAsset, TMP_FontAsset> SourceFonts = new();
        private static readonly Dictionary<TMP_FontAsset, TMP_FontAsset> PixelFallbacks = new();
        private static readonly Dictionary<TMP_FontAsset, TMP_FontAsset> WesternSansFallbacks = new();
        private static readonly Dictionary<TMP_FontAsset, TMP_FontAsset> SymbolFallbacks = new();
        private static readonly Dictionary<TMP_FontAsset, TMP_FontAsset> PixelSymbolFallbacks = new();
        private static readonly HashSet<Font> FailedFonts = new();
        private static readonly Dictionary<Language, Font> RegionalFonts = new();
        private static readonly ConditionalWeakTable<UIText, LegacyFontSelection> LegacyFonts = new();
        private static Font westernPixelFont;
        private static readonly Regex LegacyRichTextTags = new(@"</?(?:b|i)>|</?(?:size|color|material)(?:=[^>]+)?>", RegexOptions.IgnoreCase);

        private sealed class LegacyFontSelection
        {
            internal Font Primary;
            internal Font Fallback;
            internal bool Updating;
        }

        [HarmonyPatch(typeof(FontReplacementData), nameof(FontReplacementData.GetReplacement), new[] { typeof(TMP_FontAsset), typeof(Language) })]
        [HarmonyPrefix]
        private static void GetReplacementPrefix(ref TMP_FontAsset fontToReplace)
        {
            // A component can ask to localize its already localized font when
            // the player changes languages. Resolve our clone to its original
            // source before the game's normal language selection runs.
            if (fontToReplace != null && SourceFonts.TryGetValue(fontToReplace, out TMP_FontAsset source))
            {
                fontToReplace = source;
            }
        }

        [HarmonyPatch(typeof(FontReplacementData), nameof(FontReplacementData.GetReplacement), new[] { typeof(TMP_FontAsset), typeof(Language) })]
        [HarmonyPostfix]
        private static void GetReplacementPostfix(TMP_FontAsset fontToReplace, Language language, ref TMP_FontAsset __result)
        {
            if (__result == null || !NeedsExpandedFont(language) || FontReplacementData.instance == null)
            {
                return;
            }

            if (!LocalizedFonts.TryGetValue(language, out var fonts))
            {
                fonts = new Dictionary<(TMP_FontAsset Source, TMP_FontAsset Primary), TMP_FontAsset>();
                LocalizedFonts.Add(language, fonts);
            }
            var key = (fontToReplace, __result);
            if (fonts.TryGetValue(key, out TMP_FontAsset localized))
            {
                __result = localized;
                return;
            }

            var replacements = FontReplacementData.instance.languageFontReplacements.Find(entry => entry.languages.Contains(language));
            TMP_FontAsset primary = __result;
            FontReplacement replacement = replacements?.fontReplacements.Find(entry => entry.TMPFont == primary);

            Font sourceFont = replacement?.Font;
            Font regionalSans = GetRegionalFont(language);
            if (sourceFont == null || !sourceFont.dynamic)
            {
                // Bitmap TMP faces can contain fewer glyphs than their legacy
                // UI equivalents. Keep their existing glyphs as the primary;
                // only missing characters use the regional fallback.
                sourceFont = regionalSans;
            }
            TMP_FontAsset expanded = MultilingualFontAssets.GetForOriginal(primary);
            // TC deliberately follows the user's CJK.txt. Western loanwords
            // can need Latin letters outside it, such as the macron in Pūkeko.
            // The official JP sans asset includes complete Latin blocks.
            string expandedSuffix = IsCjkLanguage(language) ? GetRegionalSuffix(language) : "JP";
            TMP_FontAsset regionalExpanded = MultilingualFontAssets.Get("NotoSans_" + expandedSuffix);
            if (!IsCjkLanguage(language) && regionalExpanded != null)
            {
                regionalExpanded = GetScaledFallback(primary, regionalExpanded, WesternSansFallbacks);
            }
            TMP_FontAsset fallback = expanded != null && replacement != null && sourceFont == replacement.Font
                ? null
                : sourceFont == regionalSans ? regionalExpanded ?? GetDynamicFont(sourceFont) : GetDynamicFont(sourceFont);
            TMP_FontAsset secondary = sourceFont == regionalSans ? null : regionalExpanded ?? GetDynamicFont(regionalSans);
            TMP_FontAsset westernPixel = expanded == null && !IsCjkLanguage(language)
                ? GetPixelFallback(primary) : null;
            TMP_FontAsset symbols = MultilingualFontAssets.Get("LiberationSans SDF");
            TMP_FontAsset pixelSymbols = MultilingualFontAssets.Get("PixelLocale");
            if (expanded == null && fallback == null && secondary == null && westernPixel == null && symbols == null && pixelSymbols == null)
            {
                return;
            }

            // Keep regional fallback lists separate when languages share a
            // primary font, so they cannot select another region's CJK glyphs.
            // The baked asset retains every original glyph metric and all of
            // the game's tuned face/material settings. Its enlarged atlas adds
            // the official font's available glyphs for complete Unicode blocks.
            localized = UnityEngine.Object.Instantiate(expanded ?? primary);
            localized.name = primary.name + " " + language;
            localized.fallbackFontAssetTable = primary.fallbackFontAssetTable == null
                ? new List<TMP_FontAsset>()
                : new List<TMP_FontAsset>(primary.fallbackFontAssetTable);
            // Marksman has no vector source in the game and lacks Turkish
            // dotted/dotless I. The game's other pixel face supplies these;
            // its regional Noto fonts do not contain those Latin glyphs.
            if (westernPixel != null)
            {
                localized.fallbackFontAssetTable.Add(westernPixel);
            }
            if (fallback != null && fallback != expanded)
            {
                localized.fallbackFontAssetTable.Add(fallback);
            }
            // Script fonts themselves omit a few characters, including the
            // official Traditional Chinese Adder name. The regional sans face
            // covers these without substituting another language's glyph style.
            if (secondary != null && secondary != expanded && secondary != fallback)
            {
                localized.fallbackFontAssetTable.Add(secondary);
            }
            // Glitched dialogue uses extended Latin letters and currency
            // symbols. The game's default sans face supplies most of them;
            // its PixelLocale bitmap supplies the remaining native symbols.
            if (symbols != null)
            {
                localized.fallbackFontAssetTable.Add(GetScaledFallback(primary, symbols, SymbolFallbacks));
            }
            if (pixelSymbols != null)
            {
                localized.fallbackFontAssetTable.Add(GetScaledFallback(primary, pixelSymbols, PixelSymbolFallbacks));
            }
            fonts.Add(key, localized);
            fonts.Add((fontToReplace, localized), localized);
            SourceFonts.Add(localized, fontToReplace);
            __result = localized;
        }

        private static TMP_FontAsset GetPixelFallback(TMP_FontAsset primary)
        {
            TMP_FontAsset pixel = MultilingualFontAssets.Get("MINECRAFT");
            if (pixel == null)
            {
                return null;
            }
            return GetScaledFallback(primary, pixel, PixelFallbacks);
        }

        private static TMP_FontAsset GetScaledFallback(TMP_FontAsset primary, TMP_FontAsset source, Dictionary<TMP_FontAsset, TMP_FontAsset> cache)
        {
            if (cache.TryGetValue(primary, out TMP_FontAsset cached))
            {
                return cached;
            }
            var primaryFace = primary.faceInfo;
            var fallbackFace = source.faceInfo;
            if (primaryFace.pointSize <= 0 || primaryFace.capLine <= 0 || primaryFace.scale <= 0 ||
                fallbackFace.pointSize <= 0 || fallbackFace.capLine <= 0 || fallbackFace.scale <= 0)
            {
                return source;
            }

            // Official faces have different cap heights at the same displayed
            // size. Normalize only this fallback instance so
            // added letters match the native line; the baked asset stays exact.
            float height = primaryFace.capLine * primaryFace.scale / primaryFace.pointSize;
            TMP_FontAsset fallback = UnityEngine.Object.Instantiate(source);
            fallback.name = source.name + " for " + primary.name;
            fallbackFace.scale = height * fallbackFace.pointSize / fallbackFace.capLine;
            fallback.faceInfo = fallbackFace;
            fallback.ReadFontAssetDefinition();
            cache.Add(primary, fallback);
            return fallback;
        }

        private static TMP_FontAsset GetDynamicFont(Font sourceFont)
        {
            if (sourceFont == null || FailedFonts.Contains(sourceFont))
            {
                return null;
            }
            if (!DynamicFonts.TryGetValue(sourceFont, out TMP_FontAsset font))
            {
                font = TMP_FontAsset.CreateFontAsset(sourceFont, 48, 5, GlyphRenderMode.SDFAA, 1024, 1024, AtlasPopulationMode.Dynamic, true);
                if (font == null)
                {
                    FailedFonts.Add(sourceFont);
                    return null;
                }
                font.name = sourceFont.name + " Mod Glyphs";
                DynamicFonts.Add(sourceFont, font);
            }
            return font;
        }

        private static bool NeedsExpandedFont(Language language)
        {
            return language == Language.French || language == Language.German || language == Language.Italian ||
                   language == Language.Spanish || language == Language.BrazilianPortuguese || language == Language.Russian ||
                   language == Language.Turkish || language == Language.ChineseTraditional || language == Language.Japanese ||
                   language == Language.Korean;
        }

        private static bool IsCjkLanguage(Language language)
        {
            return language == Language.ChineseTraditional || language == Language.Japanese || language == Language.Korean;
        }

        private static Font GetRegionalFont(Language language)
        {
            if (!RegionalFonts.TryGetValue(language, out Font font))
            {
                // The TC sans font also contains the Latin, Cyrillic, and
                // numbering characters absent from several native atlases.
                string suffix = GetRegionalSuffix(language);
                font = Resources.Load<Font>("fonts/3d scene fonts/altlanguage/NotoSans_" + suffix);
                if (font != null)
                {
                    RegionalFonts.Add(language, font);
                }
            }
            return font;
        }

        private static string GetRegionalSuffix(Language language)
        {
            return language == Language.Japanese ? "JP" : language == Language.Korean ? "KR" : "TC";
        }

        [HarmonyPatch(typeof(UIText), nameof(UIText.text), MethodType.Setter)]
        [HarmonyPostfix]
        private static void LegacyTextChangedPostfix(UIText __instance)
        {
            EnsureLegacyCharacters(__instance);
        }

        [HarmonyPatch(typeof(UIText), nameof(UIText.font), MethodType.Setter)]
        [HarmonyPostfix]
        private static void LegacyFontChangedPostfix(UIText __instance)
        {
            if (__instance == null)
            {
                return;
            }
            LegacyFontSelection selection = LegacyFonts.GetValue(__instance, _ => new LegacyFontSelection());
            if (selection.Updating)
            {
                return;
            }
            // An external font assignment is a new native choice, including
            // when it happens to be the same font as our temporary fallback.
            selection.Primary = __instance.font;
            selection.Fallback = null;
            EnsureLegacyCharacters(__instance);
        }

        private static void EnsureLegacyCharacters(UIText text)
        {
            if (text == null || text.font == null)
            {
                return;
            }
            LegacyFontSelection selection = LegacyFonts.GetValue(text, _ => new LegacyFontSelection());
            if (selection.Updating)
            {
                return;
            }
            if (text.font != selection.Fallback)
            {
                selection.Primary = text.font;
            }
            Font desired = selection.Primary;
            if (desired == null)
            {
                return;
            }
            string visibleText = text.supportRichText ? LegacyRichTextTags.Replace(text.text ?? string.Empty, string.Empty) : text.text;
            if (NeedsExpandedFont(Localization.CurrentLanguage) && HasMissingCharacters(desired, visibleText))
            {
                // LocalizeUI may run before LocalizeFont.Awake captures the
                // English font, or before its Start-time language selection.
                // Wait for the native regional face and font-size modifier;
                // an early fallback would become the remembered original.
                LocalizeFont localizer = text.GetComponent<LocalizeFont>();
                if (localizer != null && (localizer.originalFont == null ||
                    desired != FontReplacementData.GetReplacement(localizer.originalFont, Localization.CurrentLanguage)))
                {
                    return;
                }
                Font fallback = GetRegionalFont(Localization.CurrentLanguage);
                if (fallback != null && !HasMissingCharacters(fallback, visibleText))
                {
                    desired = fallback;
                }
                else if (!IsCjkLanguage(Localization.CurrentLanguage))
                {
                    if (westernPixelFont == null)
                    {
                        westernPixelFont = Resources.Load<Font>("fonts/pixel art fonts/MINECRAFT");
                    }
                    if (westernPixelFont != null && !HasMissingCharacters(westernPixelFont, visibleText))
                    {
                        desired = westernPixelFont;
                    }
                }
                if (desired == selection.Primary)
                {
                    // Leshy's dialogue uses legacy UI.Text rather than TMP.
                    // Its combined official bitmap face includes the currency
                    // and extended Latin symbols used by glitched messages.
                    Font symbols = MultilingualFontAssets.GetLegacy();
                    if (symbols != null && !HasMissingCharacters(symbols, visibleText))
                    {
                        desired = symbols;
                    }
                }
            }
            selection.Fallback = desired == selection.Primary ? null : desired;
            if (text.font == desired)
            {
                return;
            }
            // Legacy Unity UI fonts cannot have a TMP fallback list. Change the
            // font only for a string its native font cannot draw, then restore
            // the native pixel face when the next string fits its alphabet.
            // Keep font size, wrapping, spacing, and the text itself unchanged.
            selection.Updating = true;
            try
            {
                text.font = desired;
            }
            finally
            {
                selection.Updating = false;
            }
        }

        private static bool HasMissingCharacters(Font font, string text)
        {
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }
            foreach (char character in text)
            {
                if (!char.IsControl(character) && !char.IsWhiteSpace(character) &&
                    char.GetUnicodeCategory(character) != UnicodeCategory.Format && !font.HasCharacter(character))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
