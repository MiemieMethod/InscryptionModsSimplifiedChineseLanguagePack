using System.Runtime.CompilerServices;
using DiskCardGame;
using GBC;
using HarmonyLib;

namespace SimplifiedChineseLanguagePack
{
    [HarmonyPatch]
    internal static class AscensionMenuLocalization
    {
        private static readonly ConditionalWeakTable<PixelText, RunLabel> RunLabels = new();

        private sealed class RunLabel
        {
            internal string Source;
            internal string Key;
        }

        [HarmonyPatch(typeof(AscensionStartScreen), "Start")]
        [HarmonyPostfix]
        [HarmonyPriority(Priority.Last)]
        private static void LocalizeBothContinueButtons(AscensionStartScreen __instance)
        {
            PixelText newRun = __instance.newRunText.GetComponentInChildren<PixelText>(true);
            if (newRun != null && RunLabels.TryGetValue(newRun, out RunLabel label) && label.Key == "NEW LESHY RUN")
            {
                // P03 changes only the currently active child of Continue.
                // Its enabled/disabled partner must carry the same identifier.
                __instance.continueRunText.GetComponentInChildren<PixelText>(true)?.SetText("- CONTINUE LESHY RUN -", false);
                __instance.continueRunDisabledText.GetComponentInChildren<PixelText>(true)?.SetText("- CONTINUE LESHY RUN -", false);
            }
        }

        [HarmonyPatch(typeof(PixelText), nameof(PixelText.SetText))]
        [HarmonyPrefix]
        [HarmonyPriority(Priority.First)]
        private static void RememberRunLabel(PixelText __instance, string text)
        {
            RunLabels.Remove(__instance);
            // Only these mod-created Ascension buttons use display text as an
            // identifier. Dialogue, card labels and other menus keep the normal
            // PixelText.Text behaviour, even if their text happens to match.
            if (IsRunLabel(text) && __instance.GetComponentInParent<AscensionStartScreen>() != null)
            {
                RunLabels.Add(__instance, new RunLabel { Source = text, Key = text.Substring(2, text.Length - 4) });
            }
        }

        [HarmonyPatch(typeof(PixelText), nameof(PixelText.SetText))]
        [HarmonyPostfix]
        [HarmonyPriority(Priority.Last)]
        private static void DisplayRunLabel(PixelText __instance)
        {
            if (RunLabels.TryGetValue(__instance, out RunLabel label))
            {
                // SetText is also called after LocalizeUI.Awake, so relying on
                // that one-time localization misses the Continue button.
                __instance.mainText.text = "- " + Localization.ToUpper(Localization.Translate(label.Key)) + " -";
            }
        }

        [HarmonyPatch(typeof(PixelText), nameof(PixelText.Text), MethodType.Getter)]
        [HarmonyPostfix]
        private static void ReadRunIdentifier(PixelText __instance, ref string __result)
        {
            // Grimora and Magnificus filter buttons with StartsWith/EndsWith,
            // then select a temple by stripping the English label on click.
            // Preserve exactly what they passed to SetText for those reads;
            // Unity's Text renderer still draws the localized mainText above.
            // Copies passed to another button's SetText localize independently.
            if (RunLabels.TryGetValue(__instance, out RunLabel label))
            {
                __result = label.Source;
            }
        }

        private static bool IsRunLabel(string text)
        {
            return text is "- NEW LESHY RUN -" or "- CONTINUE LESHY RUN -" or
                "- NEW GRIMORA RUN -" or "- CONTINUE GRIMORA RUN -" or
                "- NEW P03 RUN -" or "- CONTINUE P03 RUN -" or
                "- NEW MAGNIFICUS RUN -";
        }
    }
}
