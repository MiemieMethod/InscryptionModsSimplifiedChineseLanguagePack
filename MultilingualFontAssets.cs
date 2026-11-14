using System;
using System.Collections.Generic;
using System.IO;
using BepInEx;
using TMPro;
using UnityEngine;

namespace SimplifiedChineseLanguagePack
{
    internal static class MultilingualFontAssets
    {
        private static readonly Dictionary<string, WeakReference<TMP_FontAsset>> Fonts = new(StringComparer.OrdinalIgnoreCase);
        private static readonly HashSet<string> MissingFonts = new(StringComparer.OrdinalIgnoreCase);
        private static AssetBundle bundle;
        private static bool searched;
        private static WeakReference<Font> legacyFont;

        internal static TMP_FontAsset GetForOriginal(TMP_FontAsset original)
        {
            if (original == null)
            {
                return null;
            }
            string name = original.name;
            string path;
            switch (name)
            {
                case "DAGGERSQUARE": case "GARBAGESCHRIFT": case "HEAVYWEIGHT": case "VICIOUSHUNGER":
                    path = "fonts/3d scene fonts/" + name;
                    break;
                case "NotoSans_JP": case "NotoSans_KR": case "NotoSans_TC":
                case "NotoSerif_TC": case "ShipporiMincho_JP": case "Stylish_KR":
                    path = "fonts/3d scene fonts/altlanguage/" + name;
                    break;
                case "LiberationSans SDF":
                    path = "fonts & materials/" + name;
                    break;
                case "MINECRAFT":
                    path = "fonts/pixel art fonts/" + name;
                    break;
                default:
                    return null;
            }
            // A mod's custom font may reuse an official name. Its glyph layout
            // and material are not interchangeable with the official asset.
            return Resources.Load<TMP_FontAsset>(path) == original ? Get(name) : null;
        }

        internal static TMP_FontAsset Get(string originalName)
        {
            if (string.IsNullOrEmpty(originalName) || MissingFonts.Contains(originalName))
            {
                return null;
            }
            TMP_FontAsset font = null;
            if (Fonts.TryGetValue(originalName, out var cached) && cached.TryGetTarget(out font) && font != null)
            {
                return font;
            }
            EnsureBundle();
            if (bundle != null)
            {
                string path = "assets/textmesh pro/fonts/" + originalName.ToLowerInvariant() + " expanded.asset";
                font = bundle.LoadAsset<TMP_FontAsset>(path);
            }
            if (font == null)
            {
                MissingFonts.Add(originalName);
                return null;
            }
            font.ReadFontAssetDefinition();
            ReleaseStaticAtlasCopies(font);
            Fonts[originalName] = new WeakReference<TMP_FontAsset>(font);
            return font;
        }

        internal static void ReleaseStaticAtlasCopies(TMP_FontAsset font)
        {
            if (font == null || font.atlasPopulationMode != AtlasPopulationMode.Static) return;
            // A static atlas is rendered by the GPU. Retaining its CPU pixels
            // doubles the cost of large CJK pages without adding any characters.
            foreach (Texture2D atlas in font.atlasTextures)
            {
                if (atlas != null && atlas.isReadable) atlas.Apply(false, true);
            }
        }

        internal static Font GetLegacy()
        {
            if (legacyFont != null && legacyFont.TryGetTarget(out Font cached) && cached != null) return cached;
            EnsureBundle();
            if (bundle != null)
            {
                Font font = bundle.LoadAsset<Font>("assets/textmesh pro/fonts/pixellocale multilingual legacy.fontsettings");
                if (font != null) legacyFont = new WeakReference<Font>(font);
                return font;
            }
            return null;
        }

        private static void EnsureBundle()
        {
            if (!searched)
            {
                searched = true;
                foreach (string path in Directory.GetFiles(Paths.PluginPath, "multilingual_fonts", SearchOption.AllDirectories))
                {
                    bundle = AssetBundle.LoadFromFile(path);
                    if (bundle != null)
                    {
                        break;
                    }
                    Debug.LogWarning("Could not load expanded font assets: " + path);
                }
            }
        }
    }
}
