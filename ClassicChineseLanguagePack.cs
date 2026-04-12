using APIPlugin;
using BepInEx;
using DiskCardGame;
using HarmonyLib;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Localizing;
using InscryptionAPI.Pelts;
using System;
using System.Collections.ObjectModel;
using System.Reflection;
using Sirenix.Serialization.Utilities;
using TMPro;
using UnityEngine;
using static InscryptionAPI.Card.TribeManager;
using GracesGames.Common.Scripts;
using UnityEngine.SocialPlatforms.Impl;

namespace ClassicChineseLanguagePack
{

    [BepInDependency(InscryptionAPIPlugin.ModGUID)]
    [BepInPlugin(GUID, Name, Version)]
    public class ClassicChineseLanguagePackPlugin : BaseUnityPlugin
    {
        public const string GUID = "miemiemethod.inscryption.mods_classic_chinese_language_pack";
        public const string Name = "ClassicChineseLanguagePack";
        private const string Version = "1.0.0";

        public static bool FontLoaded = false;
        public static bool LanguageLoaded = false;
        public static Dictionary<string, Localization.Translation> Translations = new();
        public static AssetBundle FontBundle;

        private void Awake()
        {
            Logger.LogInfo($"Loaded {Name}!");
            Localization.TryLoadLanguage(Language.ChineseSimplified);
            RegisterTranslations();
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GUID);
        }

        private void Start()
        {
            PostRegisterTranslations();
        }

        [HarmonyPatch]
        internal static class Patches
        {
            [HarmonyPatch(typeof(FontReplacementData), nameof(FontReplacementData.Initialize))]
            [HarmonyPostfix]
            private static void FontReplacementData_Initialize()
            {
                if (!FontLoaded)
                {
                    FixSimplifiedChineseFonts();
                    FontLoaded = true;
                }
            }
        }

        public static void Translate(string pluginGUID, string id, string englishString, string translatedString,
            Language language)
        {
            Localization.Translation translation;
            string formattedEnglishString = Localization.FormatString(englishString);
            if (formattedEnglishString != null && Translations.TryGetValue(formattedEnglishString, out translation))
            {
            }
            else
            {
                translation = new Localization.Translation
                {
                    id = id,
                    englishString = englishString,
                    englishStringFormatted = formattedEnglishString,
                    values = new Dictionary<Language, string>(),
                    femaleGenderValues = new Dictionary<Language, string>()
                };
                Translations[formattedEnglishString] = translation;
                Localization.Translations.Add(translation);
            }

            if (translation.values.ContainsKey(language))
            {
                translation.values[language] = translatedString;
            }
            else
            {
                translation.values.Add(language, translatedString);
            }
        }

        private static void RegisterTranslations()
        {
            foreach (var t in Localization.Translations)
            {
                Translations[t.englishStringFormatted] = t;
            }

            var stopwatch = System.Diagnostics.Stopwatch.StartNew();
            InscryptionVanilla.RegisterTranslations();
            stopwatch.Stop();
            Debug.Log($"RegisterTranslations 执行时间: {stopwatch.ElapsedMilliseconds} ms");
            LanguageLoaded = true;
        }

        private static void PostRegisterTranslations()
        {
            Debug.Log("Post Register Translations");

            Debug.Log("Post Register Translations Ended");
        }

        private static void FixSimplifiedChineseFonts()
        {
            Debug.Log("Fixing Simplified Chinese Fonts");
            FontReplacement DAGGERSQUAREReplacement =
                Resources.Load<FontReplacement>("data/localization/fontreplacement/DAGGERSQUARE_to_SC-SANS");
            FontReplacement MISC3DReplacement =
                Resources.Load<FontReplacement>("data/localization/fontreplacement/MISC3D_to_SC-SCRIPT");
            if (FontBundle == null)
            {
                string[] foundBundles =
                    Directory.GetFiles(Paths.PluginPath, "chinese_font", SearchOption.AllDirectories);
                if (foundBundles.Length > 0)
                {
                    string bundlePath = foundBundles[0];
                    var bundle = AssetBundle.LoadFromFile(bundlePath);
                    if (bundle == null)
                    {
                        Debug.LogError("字体AssetBundle加载失败！");
                        return;
                    }

                    FontBundle = bundle;
                }
                else
                {
                    Debug.LogError("字体AssetBundle加载失败！");
                    return;
                }
            }

            TMP_FontAsset NotoSans =
                FontBundle.LoadAsset<TMP_FontAsset>("assets/textmesh pro/fonts/notosans_sc sdf.asset");
            TMP_FontAsset NotoSerif =
                FontBundle.LoadAsset<TMP_FontAsset>("assets/textmesh pro/fonts/notoserif_sc sdf.asset");
            SetPrivateTMPFont(DAGGERSQUAREReplacement, NotoSans);
            SetPrivateTMPFont(MISC3DReplacement, NotoSerif);
        }

        private static void SetPrivateTMPFont(FontReplacement replacement, TMP_FontAsset fontAsset)
        {
            if (replacement == null)
            {
                Debug.LogError("FontReplacement为空，无法设置字体！");
                return;
            }

            var type = typeof(FontReplacement);
            var field = type.GetField("replacementTMPFont", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null)
            {
                Debug.LogError("找不到replacementTMPFont字段，无法替换字体！");
                return;
            }

            field.SetValue(replacement, fontAsset);
            Debug.Log($"成功替换{replacement.name}的TMP字体为{fontAsset.name}");
        }
    }

    public class InscryptionVanilla
    {
        public static void RegisterTranslations()
        {
            Debug.Log("Registering Translations for Inscryption");
        }
    }
}