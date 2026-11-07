using System;
using HarmonyLib;
using InscryptionAPI.Ascension;
using InscryptionAPI.Card;
using DiskCardGame;

namespace SimplifiedChineseLanguagePack
{
    [HarmonyPatch]
    internal static class ModLocalizationPatches
    {
        [HarmonyPatch(typeof(CardManager), nameof(CardManager.SyncCardList))]
        [HarmonyPostfix]
        private static void CardManager_SyncCardList_Postfix()
        {
            MultilingualTranslationRuntime.CardListChanged();
        }

        [HarmonyPatch(typeof(Card), nameof(Card.RenderCard))]
        [HarmonyPrefix]
        [HarmonyPriority(Priority.Last)]
        private static void Card_RenderCard_Prefix(Card __instance)
        {
            MultilingualTranslationRuntime.EnsureCardTranslations(__instance.Info);
        }

        [HarmonyPatch(typeof(CardInfo), nameof(CardInfo.DisplayedNameLocalized), MethodType.Getter)]
        [HarmonyPostfix]
        [HarmonyPriority(Priority.Last)]
        private static void CardInfo_DisplayedNameLocalized_Postfix(CardInfo __instance, string __result)
        {
            // Some sequencers insert a freshly modified deck card's name into
            // dialogue before any Card renderer exists for it.
            MultilingualTranslationRuntime.EnsureCardTranslations(__instance, __result);
        }

        [HarmonyPatch(typeof(ChallengeDisplayerPlus), nameof(ChallengeDisplayerPlus.DisplayText))]
        [HarmonyPrefix]
        private static void ChallengeDisplayerPlus_DisplayText_Prefix(ref string dependency, ref string incompatibility)
        {
            // The API has already localized each challenge name before joining
            // this text. Translate the surrounding sentence for any combination.
            dependency = TranslateChallengeList(dependency, "Depends on: ");
            incompatibility = TranslateChallengeList(incompatibility, "Incompatible with: ");
        }

        private static string TranslateChallengeList(string text, string prefix)
        {
            if (string.IsNullOrEmpty(text) || !text.StartsWith(prefix, StringComparison.Ordinal))
            {
                return text;
            }

            string englishPattern = prefix + "{0}";
            string translatedPattern = Localization.Translate(englishPattern);
            if (translatedPattern == englishPattern)
            {
                return text;
            }
            return string.Format(translatedPattern, text.Substring(prefix.Length));
        }
    }
}
