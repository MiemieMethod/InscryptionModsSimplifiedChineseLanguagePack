using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using DiskCardGame;
using HarmonyLib;
using InscryptionAPI.Ascension;
using UnityEngine;

namespace SimplifiedChineseLanguagePack
{
    [HarmonyPatch]
    internal static class AscensionSetupCompatibility
    {
        private static bool installed;
        private static Func<CardTemple> p03ScreenState;
        private static Func<CardTemple> magnificusScreenState;
        private const BindingFlags DeclaredMethods = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance | BindingFlags.DeclaredOnly;

        internal static void Initialize()
        {
            if (installed) return;
            var harmony = new Harmony(SimplifiedChineseLanguagePackPlugin.GUID + ".ascension_setup");
            harmony.PatchAll(typeof(AscensionSetupCompatibility));
            foreach (Assembly assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                PatchOptional(harmony, assembly, "Infiniscryption.PackManagement.UserInterface.PackIcon", "OnCursorExit", prefix: nameof(SetupIconCanExit));
                PatchOptional(harmony, assembly, "CustomSideDeck.SideDeckIcon", "OnCursorExit", prefix: nameof(SetupIconCanExit));
                PatchOptional(harmony, assembly, "GrimoraMod.AscensionRelatedPatches", "InitializeGrimoraSaveData", transpiler: nameof(RefreshGrimoraStarterLookup));
                PatchOptional(harmony, assembly, "KCMLoadouts.Plugin+SelectLoadoutScreen", "ShowPage", transpiler: nameof(AvoidRepeatedLoadoutCallbacks));
                InstallDefaultDeckGuard(harmony, assembly, "Infiniscryption.P03KayceeRun.Patchers.ScreenManagement", "Infiniscryption.P03KayceeRun.Patchers.P03AscensionSaveData", ref p03ScreenState, nameof(P03CanSetDefaultDeck));
                InstallDefaultDeckGuard(harmony, assembly, "MagnificusMod.KayceeStorage", "MagnificusMod.KayceeFixes", ref magnificusScreenState, nameof(MagnificusCanSetDefaultDeck));
                InstallMagnificusDeckFilter(harmony, assembly);
            }
            installed = true;
        }

        private static void PatchOptional(Harmony harmony, Assembly assembly, string typeName, string methodName, string prefix = null, string transpiler = null)
        {
            try
            {
                MethodInfo method = assembly.GetType(typeName, false)?.GetMethod(methodName, DeclaredMethods);
                if (method == null) return;
                harmony.Patch(method,
                    prefix: prefix == null ? null : new HarmonyMethod(typeof(AscensionSetupCompatibility), prefix),
                    transpiler: transpiler == null ? null : new HarmonyMethod(typeof(AscensionSetupCompatibility), transpiler));
            }
            catch (Exception error)
            {
                Debug.LogWarning($"Setup compatibility: could not patch {typeName}.{methodName}: {error.Message}");
            }
        }

        private static void InstallDefaultDeckGuard(Harmony harmony, Assembly assembly, string stateTypeName, string patchTypeName, ref Func<CardTemple> readState, string prefix)
        {
            try
            {
                MethodInfo getter = assembly.GetType(stateTypeName, false)?.GetProperty("ScreenState", DeclaredMethods)?.GetGetMethod(true);
                if (getter == null || getter.ReturnType != typeof(CardTemple)) return;
                readState = (Func<CardTemple>)Delegate.CreateDelegate(typeof(Func<CardTemple>), getter);
                PatchOptional(harmony, assembly, patchTypeName, "FixStarters", prefix: prefix);
            }
            catch (Exception error)
            {
                Debug.LogWarning($"Setup compatibility: could not read {stateTypeName}.ScreenState: {error.Message}");
            }
        }

        private static void InstallMagnificusDeckFilter(Harmony harmony, Assembly assembly)
        {
            try
            {
                Type starters = assembly.GetType("MagnificusMod.KayceeFixes+StarterDecks", false);
                if (starters == null) return;
                // Find the deck-list callback without depending on the compiler's
                // generated display-class number. Do not patch its card predicates.
                foreach (Type closure in starters.GetNestedTypes(BindingFlags.Public | BindingFlags.NonPublic))
                foreach (MethodInfo method in closure.GetMethods(DeclaredMethods))
                {
                    if (method.Name.StartsWith("<RegisterStarterDecks>", StringComparison.Ordinal) &&
                        method.ReturnType == typeof(List<StarterDeckManager.FullStarterDeck>))
                        harmony.Patch(method, transpiler: new HarmonyMethod(typeof(AscensionSetupCompatibility), nameof(AllowOrdinaryStarterTitles)));
                }
            }
            catch (Exception error)
            {
                Debug.LogWarning($"Setup compatibility: could not patch Magnificus starter-deck filtering: {error.Message}");
            }
        }

        [HarmonyPatch(typeof(AscensionMenuScreens), nameof(AscensionMenuScreens.TransitionToGame))]
        [HarmonyPrefix]
        [HarmonyPriority(Priority.Last)]
        [HarmonyAfter("cyantist.inscryption.api", "zorro.inscryption.infiniscryption.p03kayceerun", "zorro.inscryption.infiniscryption.packmanager")]
        private static void RefreshMissingStarterDeck(bool newRun)
        {
            if (!newRun) return;
            AscensionSaveData data = AscensionSaveData.Data;
            if (data == null) return;
            // The API refreshes temple-filtered decks when its deck picker opens.
            // P03 level 1 skips that screen, leaving the previous temple's list.
            // Run after default-deck selection and pack filtering, and rebuild
            // only a missing lookup; preserve the player's selected deck ID.
            GetStarterDeckForNewRun(data.currentStarterDeck);
        }

        private static StarterDeckInfo GetStarterDeckForNewRun(string deckId)
        {
            if (string.IsNullOrEmpty(deckId)) return null;
            StarterDeckInfo info = StarterDecksUtil.GetInfo(deckId);
            if (info != null) return info;
            StarterDeckManager.SyncDeckList();
            return StarterDecksUtil.GetInfo(deckId);
        }

        private static IEnumerable<CodeInstruction> RefreshGrimoraStarterLookup(IEnumerable<CodeInstruction> instructions)
        {
            // Grimora creates its run inside an earlier prefix and skips the
            // native method. Retry at that lookup, after it chooses its default.
            return ReplaceCalls(instructions, typeof(StarterDecksUtil).GetMethod(nameof(StarterDecksUtil.GetInfo)),
                nameof(GetStarterDeckForNewRun), 1);
        }

        private static bool P03CanSetDefaultDeck(bool newRun)
        {
            if (!newRun) return true;
            CardTemple temple = p03ScreenState();
            return temple == CardTemple.Nature || temple == CardTemple.Tech;
        }

        private static bool MagnificusCanSetDefaultDeck(bool newRun)
        {
            if (!newRun) return true;
            CardTemple temple = magnificusScreenState();
            // Both mods otherwise write "Vanilla" for every foreign temple,
            // overwriting the other mod's selected default depending on patch order.
            return temple == CardTemple.Nature || temple == CardTemple.Wizard;
        }

        private static IEnumerable<CodeInstruction> AllowOrdinaryStarterTitles(IEnumerable<CodeInstruction> instructions)
        {
            var codes = instructions.ToList();
            MethodInfo split = typeof(string).GetMethod(nameof(string.Split), new[] { typeof(char[]) });
            MethodInfo parse = typeof(int).GetMethod(nameof(int.Parse), new[] { typeof(string) });
            var matches = new List<int>();
            for (int i = 0; i + 3 < codes.Count; i++)
                if (codes[i].Calls(split) && codes[i + 1].opcode == OpCodes.Ldc_I4_1 &&
                    codes[i + 2].opcode == OpCodes.Ldelem_Ref && codes[i + 3].Calls(parse)) matches.Add(i);
            if (matches.Count != 1)
            {
                Debug.LogWarning("Setup compatibility: Magnificus starter-title parser has changed; leaving it untouched.");
                return codes;
            }
            int index = matches[0];
            codes[index].opcode = OpCodes.Call;
            codes[index].operand = typeof(AscensionSetupCompatibility).GetMethod(nameof(GetMagnificusUnlockLevel), DeclaredMethods);
            for (int i = 1; i <= 3; i++)
            {
                // Keep branch labels and exception-block boundaries in place.
                codes[index + i].opcode = OpCodes.Nop;
                codes[index + i].operand = null;
            }
            return codes;
        }

        private static int GetMagnificusUnlockLevel(string title, char[] separators)
        {
            if (string.IsNullOrEmpty(title)) return 0;
            string[] parts = title.Split(separators);
            // Only Magnificus uses "title;level". Other mods' decks keep their
            // own API unlock checks instead of requiring this private format.
            return parts.Length > 1 && int.TryParse(parts[1], out int level) ? level : 0;
        }

        private static IEnumerable<CodeInstruction> AvoidRepeatedLoadoutCallbacks(IEnumerable<CodeInstruction> instructions)
        {
            return ReplaceCalls(instructions, typeof(Delegate).GetMethod(nameof(Delegate.Combine), new[] { typeof(Delegate), typeof(Delegate) }),
                nameof(CombineLoadoutCallbackOnce), 2);
        }

        private static Delegate CombineLoadoutCallbackOnce(Delegate existing, Delegate callback)
        {
            if (existing != null)
                foreach (Delegate handler in existing.GetInvocationList())
                    if (handler.Equals(callback)) return existing;
            return Delegate.Combine(existing, callback);
        }

        private static IEnumerable<CodeInstruction> ReplaceCalls(IEnumerable<CodeInstruction> instructions, MethodInfo original, string replacement, int expectedCount)
        {
            var codes = instructions.ToList();
            var matches = codes.Where(code => code.Calls(original)).ToList();
            if (matches.Count != expectedCount)
            {
                Debug.LogWarning($"Setup compatibility: {replacement} expected {expectedCount} calls, found {matches.Count}; leaving the method untouched.");
                return codes;
            }
            MethodInfo method = typeof(AscensionSetupCompatibility).GetMethod(replacement, DeclaredMethods);
            foreach (CodeInstruction code in matches)
            {
                code.opcode = OpCodes.Call;
                code.operand = method;
            }
            return codes;
        }

        private static bool SetupIconCanExit(Component __instance)
        {
            // CursorExit can run one frame after the setup page is hidden. The
            // original callback excludes inactive parents, dereferences null,
            // and prevents InteractionCursor from ever releasing the old icon.
            return __instance != null && __instance.gameObject.activeInHierarchy &&
                __instance.GetComponentInParent<AscensionRunSetupScreenBase>() != null;
        }
    }
}
