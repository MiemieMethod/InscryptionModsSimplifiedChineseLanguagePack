using BepInEx;
using DiskCardGame;
using HarmonyLib;
using Infiniscryption.P03KayceeRun;
using Infiniscryption.P03KayceeRun.Cards;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Localizing;
using InscryptionAPI.Pelts;
using Sirenix.Serialization.Utilities;
using System;
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


        private void Awake()
        {
            Logger.LogInfo($"Loaded {Name}!");
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
    }
}
