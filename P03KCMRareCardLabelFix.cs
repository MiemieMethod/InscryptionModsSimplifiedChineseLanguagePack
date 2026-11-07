using BepInEx;
using DiskCardGame;
using HarmonyLib;
using Infiniscryption.P03KayceeRun;
using Infiniscryption.P03KayceeRun.Cards;
using Infiniscryption.P03KayceeRun.Patchers;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Localizing;
using InscryptionAPI.Pelts;
using Sirenix.Serialization.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using TMPro;
using Unity.Audio;
using UnityEngine;

namespace SimplifiedChineseLanguagePack
{

    [BepInDependency(InscryptionAPIPlugin.ModGUID)]
    [BepInDependency(SimplifiedChineseLanguagePackPlugin.GUID)]
    [BepInDependency(P03Plugin.PluginGuid)]
    [BepInPlugin(GUID, Name, Version)]
    public class P03KCMRareCardLabelFixPlugin : BaseUnityPlugin
    {
        public const string GUID = "miemiemethod.inscryption.p03_kcm_rare_card_label_fix";
        public const string Name = "P03KCMRareCardLabelFix";
        private const string Version = "1.1.0";

        private static readonly HashSet<string> RegisteredMycoCardNames = new();
        private static readonly HashSet<TMP_FontAsset> ReportedLabelFonts = new();
        private static readonly HashSet<string> ReportedLabelErrors = new();

        private void Awake()
        {
            Logger.LogInfo($"Loaded {Name}!");
            try
            {
                new Harmony(GUID).PatchAll(typeof(Patches));
                Debug.Log("P03稀有卡名称字体修复补丁已安装，等待卡牌渲染。");
            }
            catch (Exception exception)
            {
                Debug.LogError("P03稀有卡名称字体修复补丁安装失败：" + exception);
                throw;
            }
        }

        [HarmonyPatch]
        internal static class Patches
        {
            [HarmonyPatch(typeof(DiscCardColorAppearance), nameof(DiscCardColorAppearance.ApplyAppearance))]
            [HarmonyPostfix]
            private static void DiscCardColorAppearance_ApplyAppearance_Postfix(DiscCardColorAppearance __instance)
            {
                if (__instance.Card != null && __instance.NameTextColor.HasValue)
                {
                    RestoreLabelFontTexture(__instance.Card.StatsLayer as DiskRenderStatsLayer);
                }
            }

            [HarmonyPatch(typeof(RenderStatsLayer), nameof(RenderStatsLayer.RenderCard))]
            [HarmonyPrefix]
            [HarmonyAfter(P03Plugin.PluginGuid)]
            private static void RenderStatsLayer_RenderCard_Prefix(RenderStatsLayer __instance)
            {
                var appearance = __instance.GetComponentInParent<DiscCardColorAppearance>();
                if (appearance != null && appearance.NameTextColor.HasValue)
                {
                    RestoreLabelFontTexture(__instance as DiskRenderStatsLayer);
                }
            }

            [HarmonyPatch(typeof(Infiniscryption.P03KayceeRun.Patchers.CardChoiceGenerator), "GenerateMycoCard")]
            [HarmonyPostfix]
            private static void CardChoiceGenerator_GenerateMycoCard_Postfix(CardInfo __result)
            {
                RegisterMycoCardNames(__result);
            }

            [HarmonyPatch(typeof(CardInfo), nameof(CardInfo.DisplayedNameLocalized), MethodType.Getter)]
            [HarmonyPrefix]
            private static void CardInfo_DisplayedNameLocalized_Prefix(CardInfo __instance)
            {
                // Saved fusion cards bypass GenerateMycoCard. Register before
                // the native getter translates the name, including its first read.
                if (__instance.name == "P03KCM_FAILED_EXPERIMENT")
                {
                    RegisterMycoCardNames(__instance);
                }
            }
        }

        private static void RestoreLabelFontTexture(DiskRenderStatsLayer layer)
        {
            if (layer == null)
            {
                return;
            }
            if (layer.labelText == null || layer.labelText.font == null)
            {
                ReportLabelError("未找到卡牌名称的文本组件或字体。");
                return;
            }

            TMP_FontAsset font = layer.labelText.font;
            // The unlocalized bitmap has black glyphs. P03's matching white
            // atlas must remain in use until the label selects a localized font.
            if (font == Resources.Load<TMP_FontAsset>("fonts/3d scene fonts/HEAVYWEIGHT"))
            {
                return;
            }
            Texture atlas = font.atlasTexture;
            Material fontMaterial = layer.labelText.fontMaterial;
            Material rendererMaterial = layer.labelText.renderer?.material;
            if (atlas == null || fontMaterial == null || rendererMaterial == null)
            {
                ReportLabelError("字体 " + font.name + " 缺少字图或卡牌名称材质。");
                return;
            }

            // P03 writes its fixed English atlas in ApplyAppearance and in its
            // RenderCard prefix. Restore this label's own atlas after each write,
            // before RenderCard queues the render. Keep P03's colors and shaders.
            fontMaterial.mainTexture = atlas;
            rendererMaterial.mainTexture = atlas;
            if (ReportedLabelFonts.Add(font))
            {
                string message = Localization.CurrentLanguage == Language.ChineseSimplified
                    ? "P03稀有卡名称中文显示修复成功！"
                    : "P03稀有卡名称显示修复成功！";
                Debug.Log(message + " 字体：" + font.name + "，语言：" + Localization.CurrentLanguage);
            }
        }

        private static void ReportLabelError(string message)
        {
            if (ReportedLabelErrors.Add(message))
            {
                Debug.LogError("P03稀有卡名称显示修复失败：" + message);
            }
        }

        private static void RegisterMycoCardNames(CardInfo card)
        {
            if (card == null || card.mods == null)
            {
                return;
            }

            for (int i = card.mods.Count - 1; i >= 0; i--)
            {
                string nameReplacement = card.mods[i]?.nameReplacement;
                if (string.IsNullOrEmpty(nameReplacement)) continue;
                if (RegisteredMycoCardNames.Contains(nameReplacement)) return;
                if (TryTranslateMycoCardName(nameReplacement, out string translatedName))
                {
                    RegisterMycoCardTranslations(nameReplacement, translatedName);
                    MultilingualTranslationRuntime.RegisterGeneratedCardName(nameReplacement);
                    return;
                }
            }
        }

        private static bool TryTranslateMycoCardName(string name, out string translatedName)
        {
            translatedName = null;
            int separator = name.IndexOf('-');
            if (separator <= 0 || separator >= name.Length - 1)
            {
                return false;
            }

            string left = name.Substring(0, separator);
            string right = name.Substring(separator + 1);
            if (!P03InKayceesModMod.CardParts.TryGetValue(left, out string translatedLeft) ||
                !P03InKayceesModMod.CardParts.TryGetValue(right, out string translatedRight))
            {
                return false;
            }

            translatedName = translatedLeft + translatedRight;
            return true;
        }

        private static void RegisterMycoCardTranslations(string name, string translatedName)
        {
            if (!RegisteredMycoCardNames.Add(name))
            {
                return;
            }

            TranslateCardName(name, translatedName);
            if (name.ToLowerInvariant().Contains("skel-e"))
            {
                TranslateCardName("Skel-E-" + name.Replace(" ", "-"), translatedName + "骷髅");
            }
            else
            {
                TranslateCardName("Skele " + name, translatedName + "外骨骼");
            }
            TranslateCardName("Beta " + name, translatedName + "测试版");
            TranslateCardName("Lesser " + name, "幼小" + translatedName);
            TranslateCardName("Elder " + name, "长老" + translatedName);
            for (int score = 0; score <= 100; score++)
            {
                string suffix = score.ToString() + ".0";
                TranslateCardName(name + " " + suffix, translatedName + " " + suffix);
            }
        }

        private static void TranslateCardName(string name, string translatedName)
        {
            SimplifiedChineseLanguagePackPlugin.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, name, translatedName, Language.ChineseSimplified);
        }
    }
}
