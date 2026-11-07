using HarmonyLib;
using UnityEngine;
using UIText = UnityEngine.UI.Text;

namespace SimplifiedChineseLanguagePack
{
    // Unity copies serialized fields when a mod clones an already localized
    // button. LocalizeFont.originalFont is not serialized, so preserve its
    // source separately instead of treating the copied regional face as English.
    internal sealed class LegacyFontSource : MonoBehaviour
    {
        [SerializeField] internal Font Original;
        [SerializeField] internal Font Applied;
    }

    [HarmonyPatch]
    internal static class LegacyFontLocalization
    {
        [HarmonyPatch(typeof(LocalizeFont), "Awake")]
        [HarmonyPrefix]
        [HarmonyPriority(Priority.First)]
        private static void RestoreClonedSource(LocalizeFont __instance)
        {
            LegacyFontSource source = __instance.GetComponent<LegacyFontSource>();
            if (source == null || source.Original == null || source.Applied == null)
            {
                return;
            }
            UIText text = __instance.GetComponent<UIText>();
            // An intentional font change made by the cloning mod takes priority.
            if (text != null && text.font == source.Applied && text.font != source.Original)
            {
                text.font = source.Original;
            }
        }

        [HarmonyPatch(typeof(LocalizeFont), "Awake")]
        [HarmonyPostfix]
        private static void AfterAwake(LocalizeFont __instance)
        {
            RememberSource(__instance);
        }

        [HarmonyPatch(typeof(LocalizeFont), nameof(LocalizeFont.ChangeFontForLanguage))]
        [HarmonyPostfix]
        private static void AfterLanguageSelection(LocalizeFont __instance)
        {
            RememberSource(__instance);
        }

        private static void RememberSource(LocalizeFont __instance)
        {
            UIText text = __instance.GetComponent<UIText>();
            Font original = __instance.originalFont;
            if (text == null || original == null)
            {
                return;
            }
            LegacyFontSource source = __instance.GetComponent<LegacyFontSource>();
            if (source == null)
            {
                if (text.font == original)
                {
                    return;
                }
                source = __instance.gameObject.AddComponent<LegacyFontSource>();
            }
            source.Original = original;
            source.Applied = text.font;
        }
    }
}
