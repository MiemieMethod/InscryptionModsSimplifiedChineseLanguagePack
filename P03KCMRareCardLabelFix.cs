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
        private const string Version = "1.0.0";

        private static readonly HashSet<string> RegisteredMycoCardNames = new();

        private void Awake()
        {
            Logger.LogInfo($"Loaded {Name}!");
            new Harmony(GUID).PatchAll(typeof(Patches));
            if (SimplifiedChineseLanguagePackPlugin.FontBundle == null)
            {
                string bundlePath = Path.Combine(Paths.PluginPath, "MiemieMethod-Simplified_Chinese_Language_Pack_for_Mods", "chinese_font");
                var bundle = AssetBundle.LoadFromFile(bundlePath);
                if (bundle == null)
                {
                    Debug.LogError("字体AssetBundle加载失败！");
                    return;
                }
                SimplifiedChineseLanguagePackPlugin.FontBundle = bundle;
            }
            TMP_FontAsset NotoSerif = SimplifiedChineseLanguagePackPlugin.FontBundle.LoadAsset<TMP_FontAsset>("assets/textmesh pro/fonts/notoserif_sc sdf.asset");
            var prop = typeof(DiscCardColorAppearance).GetProperty("WhiteTextTexture", BindingFlags.Static | BindingFlags.NonPublic);
            if (prop != null)
            {
                prop.SetValue(null, NotoSerif.material.mainTexture);
                Debug.Log("P03稀有卡名称中文显示修复成功！");
            }
            else
            {
                Debug.LogError("未找到WhiteTextTexture字段！");
            }
        }

        [HarmonyPatch]
        internal static class Patches
        {
            [HarmonyPatch(typeof(Infiniscryption.P03KayceeRun.Patchers.CardChoiceGenerator), "GenerateMycoCard")]
            [HarmonyPostfix]
            private static void CardChoiceGenerator_GenerateMycoCard_Postfix(CardInfo __result)
            {
                if (__result == null || __result.mods == null)
                {
                    return;
                }

                for (int i = __result.mods.Count - 1; i >= 0; i--)
                {
                    string nameReplacement = __result.mods[i].nameReplacement;
                    if (!string.IsNullOrEmpty(nameReplacement) && TryTranslateMycoCardName(nameReplacement, out string translatedName))
                    {
                        RegisterMycoCardTranslations(nameReplacement, translatedName);
                        return;
                    }
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
