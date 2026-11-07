using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using HarmonyLib;
using UnityEngine;

namespace SimplifiedChineseLanguagePack
{
    internal static class AchievementLocalization
    {
        private sealed class NativeText
        {
            internal string Name;
            internal string Description;
            internal HashSet<string> CachedNames;
            internal HashSet<string> CachedDescriptions;
        }

        private static readonly Dictionary<Achievement, NativeText> NativeTexts = new();
        private static PropertyInfo achievementId;
        private static bool installed;

        internal static void Initialize()
        {
            if (installed) return;
            Type definition = AppDomain.CurrentDomain.GetAssemblies()
                .Select(assembly => assembly.GetType("Infiniscryption.Achievements.ModdedAchievementManager+AchievementDefinition", false))
                .FirstOrDefault(type => type != null);
            if (definition == null) return;

            achievementId = definition.GetProperty("ID");
            MethodInfo nameGetter = definition.GetProperty("EnglishName")?.GetGetMethod();
            MethodInfo descriptionGetter = definition.GetProperty("EnglishDescription")?.GetGetMethod();
            if (achievementId == null || nameGetter == null || descriptionGetter == null) return;

            try
            {
                ReadNativeSources();
                if (NativeTexts.Count == 0) return;
                var harmony = new Harmony(SimplifiedChineseLanguagePackPlugin.GUID + ".achievements");
                harmony.Patch(nameGetter, postfix: new HarmonyMethod(typeof(AchievementLocalization), nameof(NamePostfix)));
                harmony.Patch(descriptionGetter, postfix: new HarmonyMethod(typeof(AchievementLocalization), nameof(DescriptionPostfix)));
                installed = true;
                Debug.Log("成就名称与描述的语言切换修复已安装，原版成就数：" + NativeTexts.Count);
            }
            catch (Exception exception)
            {
                Debug.LogWarning("无法安装成就语言切换修复：" + exception);
            }
        }

        private static void ReadNativeSources()
        {
            // Achievement_t translates in its constructor. Achievements then
            // caches those localized fields as EnglishName/EnglishDescription.
            // Read the actual game's constructor arguments without rerunning its
            // initializer, changing language, or modifying platform achievement data.
            var instructions = PatchProcessor.GetOriginalInstructions(typeof(AchievementsList).TypeInitializer)
                .Where(instruction => instruction.opcode != OpCodes.Nop).ToList();
            for (int i = 3; i < instructions.Count; i++)
            {
                if (instructions[i].opcode != OpCodes.Newobj ||
                    instructions[i].operand is not ConstructorInfo constructor || constructor.DeclaringType != typeof(Achievement_t) ||
                    instructions[i - 2].opcode != OpCodes.Ldstr || instructions[i - 1].opcode != OpCodes.Ldstr)
                {
                    continue;
                }
                Achievement_t native = AchievementsList.m_Achievements.FirstOrDefault(entry =>
                    instructions[i - 3].LoadsConstant(entry.m_eAchievementID));
                if (native == null) continue;
                string name = (string)instructions[i - 2].operand;
                string description = (string)instructions[i - 1].operand;
                NativeTexts[native.m_eAchievementID] = new NativeText
                {
                    Name = name,
                    Description = description,
                    CachedNames = NativeVariants(name, native.m_strName),
                    CachedDescriptions = NativeVariants(description, native.m_strDescription)
                };
            }
        }

        private static HashSet<string> NativeVariants(string english, string cached)
        {
            var values = new HashSet<string>(StringComparer.Ordinal) { english };
            if (!string.IsNullOrEmpty(cached)) values.Add(cached);
            string key = Localization.FormatString(english);
            Localization.Translation translation = Localization.Translations.FirstOrDefault(row => row != null && row.englishStringFormatted == key);
            if (translation != null)
            {
                foreach (string value in translation.values.Values)
                {
                    if (!string.IsNullOrEmpty(value)) values.Add(value);
                }
            }
            return values;
        }

        private static void NamePostfix(object __instance, ref string __result)
        {
            if (NativeTexts.TryGetValue((Achievement)achievementId.GetValue(__instance), out NativeText text) &&
                text.CachedNames.Contains(__result))
            {
                __result = text.Name;
            }
        }

        private static void DescriptionPostfix(object __instance, ref string __result)
        {
            if (NativeTexts.TryGetValue((Achievement)achievementId.GetValue(__instance), out NativeText text) &&
                text.CachedDescriptions.Contains(__result))
            {
                // The badge and popup already call Localization.Translate.
                // Give them a stable English key for the current language lookup.
                // Custom achievements and later custom text edits pass through.
                __result = text.Description;
            }
        }
    }
}
