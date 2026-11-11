using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using DiskCardGame;
using HarmonyLib;
using InscryptionAPI.Localizing;

namespace SimplifiedChineseLanguagePack
{
    internal static class MultilingualTranslationRuntime
    {
        private sealed class Registration
        {
            internal string Id;
            internal string EnglishString;
            internal string EnglishStringFormatted;
            internal readonly Dictionary<Language, string> Values = new();
        }

        private sealed class LanguageRegistration
        {
            internal Action Register;
            internal Action<IEnumerable<CardInfo>> PostRegister;
            internal Action<string> RegisterGeneratedName;
            internal int GeneratedNameCount;
            internal readonly HashSet<(string, string, string, string, int, int, string, string)> RegisteredCards = new();
            internal HashSet<(string, string, string, string, int, int, string, string)> PendingCards;
            internal bool StaticDone;
            internal bool PostDone;
            internal bool Running;
        }

        private static readonly Dictionary<string, Registration> RegistrationsByEnglish = new(StringComparer.Ordinal);
        private static readonly Dictionary<string, Registration> RegistrationsById = new(StringComparer.Ordinal);
        private static readonly List<Registration> Registrations = new();
        private static readonly Dictionary<string, Localization.Translation> TranslationsByEnglish = new(StringComparer.Ordinal);
        private static readonly Dictionary<string, Localization.Translation> TranslationsById = new(StringComparer.Ordinal);
        private static readonly HashSet<Localization.Translation> IndexedRows = new();
        private static readonly Dictionary<Language, LanguageRegistration> Languages = new();
        private static readonly HashSet<Language> RequiredOfficialLanguages = new() { Language.ChineseSimplified };
        private static readonly HashSet<string> GeneratedNameSet = new(StringComparer.Ordinal);
        private static readonly List<string> GeneratedNames = new();
        private static bool registeringCard;
        private static int indexedLookupScope;
        private static List<Localization.Translation> indexedTranslations;
        private static int indexedTranslationCount;
        private static int indexedTranslationVersion;
        private static readonly FieldInfo TranslationListVersion = AccessTools.Field(typeof(List<Localization.Translation>), "_version");
        private static readonly MethodInfo NativeTranslate = AccessTools.Method(typeof(Localization), "TranslateToLanguage", new[] { typeof(Language), typeof(string), typeof(string) });
        private static bool initialized;
        private static bool loadingLanguages;
        private static bool ready;

        internal static void Initialize()
        {
            if (initialized)
            {
                EnsureCurrentIndex();
                return;
            }

            initialized = true;
            LocalizationManager.OnLanguageLoaded += OnLanguageLoaded;
            RememberOfficialLanguage(Localization.CurrentLanguage);
            LoadOfficialLanguages();
            RebuildIndex();

            // Registered mod strings use the index; native strings retain the
            // game's normal lookup and gender handling.
            var harmony = new Harmony(SimplifiedChineseLanguagePackPlugin.GUID + ".multilingual_runtime");
            harmony.Patch(
                AccessTools.Method(typeof(Localization), "TranslateToLanguage", new[] { typeof(Language), typeof(string), typeof(string) }),
                prefix: new HarmonyMethod(typeof(MultilingualTranslationRuntime), nameof(RegisteredTranslationPrefix)));
            harmony.Patch(
                AccessTools.PropertySetter(typeof(Localization), nameof(Localization.CurrentLanguage)),
                postfix: new HarmonyMethod(typeof(MultilingualTranslationRuntime), nameof(CurrentLanguageChangedPostfix)));
        }

        internal static void RegisterLanguage(Language language, Action register, Action<IEnumerable<CardInfo>> postRegister, Action<string> registerGeneratedName = null)
        {
            if (!Languages.ContainsKey(language))
            {
                Languages[language] = new LanguageRegistration
                {
                    Register = register,
                    PostRegister = postRegister,
                    RegisterGeneratedName = registerGeneratedName,
                    StaticDone = register == null,
                    PostDone = postRegister == null
                };
            }
        }

        internal static void EnsureSelectedLanguage()
        {
            EnsureLanguage(Localization.CurrentLanguage);
        }

        internal static void MarkReady()
        {
            ready = true;
            EnsureSelectedLanguage();
        }

        internal static void RegisterGeneratedCardName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return;
            }
            if (GeneratedNameSet.Add(name))
            {
                GeneratedNames.Add(name);
            }
            foreach (LanguageRegistration registration in Languages.Values)
            {
                if (registration.StaticDone && !registration.Running)
                {
                    ReplayGeneratedNames(registration);
                }
            }
        }

        private static void ReplayGeneratedNames(LanguageRegistration registration)
        {
            if (registration.RegisterGeneratedName == null)
            {
                return;
            }
            while (registration.GeneratedNameCount < GeneratedNames.Count)
            {
                // The global list is append-only and already deduplicated.
                // A new fusion name must not rescan every previous fusion.
                registration.RegisterGeneratedName(GeneratedNames[registration.GeneratedNameCount]);
                registration.GeneratedNameCount++;
            }
        }

        private static void EnsureLanguage(Language language)
        {
            if (!Languages.TryGetValue(language, out LanguageRegistration registration) || registration.Running)
            {
                return;
            }
            if (registration.StaticDone && (!ready || registration.PostDone) &&
                (registration.RegisterGeneratedName == null || registration.GeneratedNameCount == GeneratedNames.Count))
            {
                return;
            }

            registration.Running = true;
            try
            {
                if (!registration.StaticDone)
                {
                    registration.Register();
                    registration.StaticDone = true;
                }
                if (ready && !registration.PostDone)
                {
                    RunPostRegistration(registration, null);
                    registration.PostDone = true;
                }
                ReplayGeneratedNames(registration);
            }
            finally
            {
                // Failed actions can be retried; successful dictionaries never
                // run twice when the player returns to a language.
                registration.Running = false;
            }
        }

        private static void CurrentLanguageChangedPostfix(Language __0)
        {
            if (Languages.TryGetValue(__0, out LanguageRegistration registration) && registration.PostRegister != null)
            {
                registration.PostDone = false;
                // A newly selected language can have newer external name or
                // ability translations. Refresh its snapshots once on selection.
                registration.RegisteredCards.Clear();
            }
            EnsureLanguage(__0);
        }

        internal static void CardListChanged()
        {
            foreach (LanguageRegistration registration in Languages.Values)
            {
                if (registration.PostRegister != null) registration.PostDone = false;
            }
            // API subscribers may sync repeatedly while building a card list.
            // Refresh once on the next lookup, after that batch has finished.
        }

        internal static void EnsureCardTranslations(CardInfo card, string localizedName = null)
        {
            Language language = Localization.CurrentLanguage;
            if (!ready || registeringCard || card == null ||
                !Languages.TryGetValue(language, out LanguageRegistration registration) ||
                registration.Running || registration.PostRegister == null)
            {
                return;
            }
            EnsureLanguage(language);
            registeringCard = true;
            indexedLookupScope++;
            try
            {
                // Observe the card actually entering play, including later mods
                // and external localized-name getters, rather than its startup prototype.
                var signature = (card.name, card.displayedName, card.DisplayedNameEnglish, localizedName ?? card.DisplayedNameLocalized,
                    card.Attack, card.Health, string.Join(",", card.Abilities ?? new List<Ability>()), card.description);
                if (!registration.RegisteredCards.Contains(signature))
                {
                    RunPostRegistration(registration, new[] { card });
                    registration.RegisteredCards.Add(signature);
                }
            }
            finally
            {
                indexedLookupScope--;
                registeringCard = false;
            }
        }

        private static void RunPostRegistration(LanguageRegistration registration, IEnumerable<CardInfo> source)
        {
            bool wasRunning = registration.Running;
            registration.Running = true;
            registration.PendingCards = new();
            indexedLookupScope++;
            try
            {
                registration.PostRegister(source);
                // Commit only after the whole callback succeeds. A failed
                // registration must remain eligible for retry.
                registration.RegisteredCards.UnionWith(registration.PendingCards);
            }
            finally
            {
                indexedLookupScope--;
                registration.PendingCards = null;
                registration.Running = wasRunning;
            }
        }

        internal static bool IncludeCardForPostRegistration(Language language, string name, string displayedName,
            string englishName, string localizedName, int attack, int health, IEnumerable<Ability> abilities, string description)
        {
            if (!Languages.TryGetValue(language, out LanguageRegistration registration) || registration.PendingCards == null)
            {
                return true;
            }
            var signature = (name, displayedName, englishName, localizedName, attack, health,
                string.Join(",", abilities ?? Array.Empty<Ability>()), description);
            // CardLoader and CardManager copy CardInfo objects frequently.
            // Translation keys depend on their data, not their object identity.
            return !registration.RegisteredCards.Contains(signature) && registration.PendingCards.Add(signature);
        }

        internal static void Register(string pluginGUID, string id, string englishString, string translatedString, Language language)
        {
            if (string.IsNullOrEmpty(englishString) && string.IsNullOrEmpty(id))
            {
                return;
            }

            Initialize();
            if (RememberOfficialLanguage(language)) LoadOfficialLanguages();
            EnsureCurrentIndex();
            string formatted = string.IsNullOrEmpty(englishString) ? null : Localization.FormatString(englishString);
            Registration registration = FindRegistration(formatted, id);
            if (registration == null)
            {
                registration = new Registration
                {
                    Id = id,
                    EnglishString = englishString,
                    EnglishStringFormatted = formatted
                };
                Registrations.Add(registration);
            }

            if (formatted != null)
            {
                RegistrationsByEnglish[formatted] = registration;
            }
            if (!string.IsNullOrEmpty(id))
            {
                RegistrationsById[id] = registration;
                if (string.IsNullOrEmpty(registration.Id))
                {
                    registration.Id = id;
                }
            }

            registration.Values[language] = translatedString;
            Localization.Translation translation = GetOrCreateTranslation(registration);
            translation.values[language] = translatedString;
        }

        internal static string TranslateToLanguage(string text, Language language, string id = null)
        {
            if (language == Localization.CurrentLanguage)
            {
                return !string.IsNullOrEmpty(id) ? Localization.TranslateWithID(id) : Localization.Translate(text);
            }
            Initialize();
            if (RememberOfficialLanguage(language)) LoadOfficialLanguages();
            // Explicit-language setup must use the same game method and patches,
            // including gender, empty values and ID fallback, without changing options.
            return (string)NativeTranslate.Invoke(null, new object[] { language, string.IsNullOrEmpty(id) ? text : null, id });
        }

        private static bool RememberOfficialLanguage(Language language)
        {
            return language >= Language.French && language <= Language.ChineseTraditional &&
                RequiredOfficialLanguages.Add(language);
        }

        private static void LoadOfficialLanguages()
        {
            if (loadingLanguages)
            {
                return;
            }

            loadingLanguages = true;
            try
            {
                // Load a native column before overriding it: the CSV reader uses
                // Dictionary.Add. Unused languages can wait until requested,
                // leaving more address space for the 32-bit game's resources.
                foreach (Language language in RequiredOfficialLanguages.ToArray())
                {
                    Localization.TryLoadLanguage(language);
                }
            }
            finally
            {
                loadingLanguages = false;
            }
        }

        private static void OnLanguageLoaded(Language language)
        {
            if (loadingLanguages)
            {
                return;
            }

            RememberOfficialLanguage(language);
            // A table reset also discards columns used by earlier registrations.
            // Restore those native columns before replaying their overrides.
            LoadOfficialLanguages();
            EnsureCurrentIndex();
        }

        private static void ReplayRegistrations()
        {
            foreach (Registration registration in Registrations)
            {
                Localization.Translation translation = GetOrCreateTranslation(registration);
                foreach (KeyValuePair<Language, string> value in registration.Values)
                {
                    translation.values[value.Key] = value.Value;
                }
            }
        }

        private static void EnsureCurrentIndex()
        {
            List<Localization.Translation> translations = Localization.Translations;
            if (translations.Count == 0)
            {
                LoadOfficialLanguages();
                translations = Localization.Translations;
            }
            int version = TranslationListVersion == null ? translations.Count : (int)TranslationListVersion.GetValue(translations);
            if (!ReferenceEquals(indexedTranslations, translations) || indexedTranslationVersion != version)
            {
                // Removing/replacing one row is an external edit, not a reset.
                // A clear and refill can also leave the same list size behind.
                bool reset = indexedTranslations != null && IndexedRows.Count > 0 &&
                    !translations.Any(translation => IndexedRows.Contains(translation));
                RebuildIndex();
                if (reset)
                {
                    ReplayRegistrations();
                }
            }
        }

        private static void RebuildIndex()
        {
            TranslationsByEnglish.Clear();
            TranslationsById.Clear();
            IndexedRows.Clear();
            SimplifiedChineseLanguagePackPlugin.Translations.Clear();
            indexedTranslations = Localization.Translations;
            foreach (Localization.Translation translation in indexedTranslations)
            {
                if (translation == null)
                {
                    continue;
                }
                IndexedRows.Add(translation);

                string formatted = translation.englishStringFormatted;
                if (formatted == null && translation.englishString != null)
                {
                    formatted = Localization.FormatString(translation.englishString);
                    translation.englishStringFormatted = formatted;
                }
                // The game's Find selects the first matching row.
                if (formatted != null && !TranslationsByEnglish.ContainsKey(formatted))
                {
                    TranslationsByEnglish[formatted] = translation;
                    SimplifiedChineseLanguagePackPlugin.Translations[formatted] = translation;
                }
                if (!string.IsNullOrEmpty(translation.id) && !TranslationsById.ContainsKey(translation.id))
                {
                    TranslationsById[translation.id] = translation;
                }
            }
            indexedTranslationCount = indexedTranslations.Count;
            indexedTranslationVersion = TranslationListVersion == null ? indexedTranslationCount : (int)TranslationListVersion.GetValue(indexedTranslations);
        }

        private static Registration FindRegistration(string formatted, string id)
        {
            if (formatted != null && RegistrationsByEnglish.TryGetValue(formatted, out Registration byEnglish))
            {
                return byEnglish;
            }
            if (!string.IsNullOrEmpty(id) && RegistrationsById.TryGetValue(id, out Registration byId))
            {
                return byId;
            }
            return null;
        }

        private static Localization.Translation GetOrCreateTranslation(Registration registration)
        {
            Localization.Translation translation = null;
            if (registration.EnglishStringFormatted != null)
            {
                TranslationsByEnglish.TryGetValue(registration.EnglishStringFormatted, out translation);
            }
            if (translation == null && !string.IsNullOrEmpty(registration.Id))
            {
                TranslationsById.TryGetValue(registration.Id, out translation);
            }
            if (translation == null)
            {
                translation = new Localization.Translation
                {
                    id = registration.Id,
                    englishString = registration.EnglishString,
                    englishStringFormatted = registration.EnglishStringFormatted,
                    values = new Dictionary<Language, string>(),
                    femaleGenderValues = new Dictionary<Language, string>()
                };
                indexedTranslations.Add(translation);
                IndexedRows.Add(translation);
                indexedTranslationCount = indexedTranslations.Count;
                indexedTranslationVersion = TranslationListVersion == null ? indexedTranslationCount : (int)TranslationListVersion.GetValue(indexedTranslations);
            }

            translation.values ??= new Dictionary<Language, string>();
            translation.femaleGenderValues ??= new Dictionary<Language, string>();
            if (registration.EnglishStringFormatted != null)
            {
                TranslationsByEnglish[registration.EnglishStringFormatted] = translation;
                SimplifiedChineseLanguagePackPlugin.Translations[registration.EnglishStringFormatted] = translation;
            }
            if (!string.IsNullOrEmpty(registration.Id))
            {
                TranslationsById[registration.Id] = translation;
            }
            return translation;
        }

        private static string NormalizeLineBreaks(string value)
        {
            return value.Replace("<br>", "\n");
        }

        private static bool RegisteredTranslationPrefix(Language language, string englishText, string id, ref string __result)
        {
            if (language == Language.English)
            {
                return true;
            }

            if (language == Localization.CurrentLanguage) EnsureLanguage(language);

            string formatted = englishText == null ? null : Localization.FormatString(englishText);
            string lookupId = englishText == null ? id : null;
            Registration registration = FindRegistration(formatted, lookupId);
            if (registration == null || !registration.Values.ContainsKey(language))
            {
                if (TryTranslateCardAbilityText(language, englishText, formatted, out string abilityText))
                {
                    __result = abilityText;
                    return false;
                }
                if (indexedLookupScope > 0)
                {
                    // Our own snapshot/batch reads include untranslated names.
                    // Native List.Find would scan every generated dialogue for
                    // each miss. Use the live row index only within that work;
                    // keep normal game lookups and native name getters intact.
                    EnsureCurrentIndex();
                    if (!TryGetCurrentTranslation(language, formatted, lookupId, out string indexedValue))
                    {
                        indexedValue = string.IsNullOrEmpty(englishText) && string.IsNullOrEmpty(id)
                            ? string.Empty : englishText;
                    }
                    __result = indexedValue;
                    return false;
                }
                return true;
            }
            EnsureCurrentIndex();
            if (TryGetCurrentTranslation(language, formatted, lookupId, out string value))
            {
                __result = value;
                return false;
            }
            return true;
        }

        private static bool TryGetCurrentTranslation(Language language, string formatted, string lookupId, out string result)
        {
            result = null;
            Localization.Translation translation = null;
            if (formatted != null)
            {
                TranslationsByEnglish.TryGetValue(formatted, out translation);
            }
            else if (!string.IsNullOrEmpty(lookupId))
            {
                TranslationsById.TryGetValue(lookupId, out translation);
            }
            if (translation != null && (formatted != null
                ? translation.englishStringFormatted != formatted : translation.id != lookupId))
            {
                // A row's key can be edited without changing the List version.
                RebuildIndex();
                return TryGetCurrentTranslation(language, formatted, lookupId, out result);
            }
            // The game table is authoritative. A later mod can change or clear
            // its value; our replay copy must never mask that current value.
            if (translation?.values == null || !translation.values.TryGetValue(language, out string value) ||
                string.IsNullOrEmpty(value) || value == translation.englishString)
            {
                return false;
            }

            // Preserve the original short-circuit: the save is consulted only
            // when this language has a female variant and the primary differs.
            if (translation.femaleGenderValues != null &&
                translation.femaleGenderValues.TryGetValue(language, out string femaleValue) &&
                !SaveManager.SaveFile.MalePlayerAvatar)
            {
                value = femaleValue;
            }
            result = NormalizeLineBreaks(value);
            return true;
        }

        private static readonly (string Separator, string Suffix)[] CardAbilityPatterns =
        {
            (" has been blessed with ", "!"),
            (" has been burdened with ", "!"),
            (" is now free of its ", "...")
        };

        private static bool TryTranslateCardAbilityText(Language language, string text, string formatted, out string result)
        {
            result = null;
            if (string.IsNullOrEmpty(text) || !text.StartsWith("Your", StringComparison.OrdinalIgnoreCase)) return false;
            foreach (var pattern in CardAbilityPatterns)
            {
                if (!text.EndsWith(pattern.Suffix, StringComparison.Ordinal)) continue;
                int searchFrom = text.Length - pattern.Suffix.Length;
                while (searchFrom > 0)
                {
                    int separator = text.LastIndexOf(pattern.Separator, searchFrom - 1, StringComparison.OrdinalIgnoreCase);
                    if (separator < 0) break;
                    searchFrom = separator;
                    int start = separator + pattern.Separator.Length;
                    int length = text.Length - pattern.Suffix.Length - start;
                    if (length <= 0) continue;
                    string ability = text.Substring(start, length);
                    if (ability == "{0}") return false;
                    string template = text.Substring(0, start) + "{0}" + pattern.Suffix;
                    string templateKey = Localization.FormatString(template);
                    Registration registration = FindRegistration(templateKey, null);
                    if (registration == null || !registration.Values.ContainsKey(language)) continue;

                    EnsureCurrentIndex();
                    // An explicit sentence supplied (or cleared) by another mod
                    // takes priority over our generic ability slot.
                    if (TranslationsByEnglish.TryGetValue(formatted, out Localization.Translation exact) &&
                        exact.values != null && exact.values.ContainsKey(language)) return false;
                    if (!TryGetCurrentTranslation(language, templateKey, null, out string translated)) return false;
                    result = translated.Replace("{0}", TranslateToLanguage(ability, language));
                    return true;
                }
            }
            return false;
        }
    }
}
