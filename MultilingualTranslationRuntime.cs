using System;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using DiskCardGame;
using HarmonyLib;
using InscryptionAPI.Card;
using InscryptionAPI.Localizing;
using CardSignature = System.ValueTuple<string, string, string, string, int, int, string, System.ValueTuple<string>>;

namespace SimplifiedChineseLanguagePack
{
    internal static class MultilingualTranslationRuntime
    {
        private sealed class Registration
        {
            internal string Id;
            internal string EnglishString;
            internal string EnglishStringFormatted;
            internal Language Language;
            internal string Value;
            internal Localization.Translation Row;
            internal string PreviousValue;
            internal bool HadPreviousValue;
            internal bool CreatedRow;
            internal bool Persistent;
            internal int References;
        }

        private sealed class LanguageRegistration
        {
            internal Action Register;
            internal Action<IEnumerable<CardInfo>> PostRegister;
            internal Action<string> RegisterGeneratedName;
            internal Action Clear;
            internal HashSet<CardSignature> RegisteredCards = new();
            internal HashSet<CardSignature> PendingCards;
            internal TransientBatch PrototypeBatch;
            internal bool StaticDone;
            internal bool PostDone;
            internal bool Running;
            internal bool Failed;
            internal bool FailureReported;
        }

        private sealed class TransientBatch
        {
            internal readonly TranslationSet<Registration> Entries = new();
            internal readonly HashSet<CardSignature> Cards = new();
            internal string GeneratedName;
            internal LinkedListNode<TransientBatch> Node;
        }

        // Only recent live modifications need extra format-before-translate
        // rows. The current prototypes retain their own post-registration rows.
        private const int TransientBatchLimit = 256;
        private const int TransientEvictionCount = 32;
        private static readonly LinkedList<TransientBatch> TransientBatches = new();
        private static readonly Dictionary<CardSignature, TransientBatch> TransientCards = new();
        private static readonly Dictionary<string, TransientBatch> GeneratedNames = new(StringComparer.Ordinal);
        private static TransientBatch currentBatch;
        private static Language activeLanguage;
        internal static event Action<Language> LanguageChanging;

        private static readonly TranslationDictionary<string, Registration> RegistrationsByEnglish = new(StringComparer.Ordinal);
        private static readonly TranslationDictionary<string, Registration> RegistrationsById = new(StringComparer.Ordinal);
        private static readonly List<Registration> Registrations = new();
        private static readonly TranslationSet<Registration> RemovalEntries = new();
        private static readonly TranslationSet<Localization.Translation> RemovalRows = new();
        private static readonly List<string> RemovalKeys = new();
        private static readonly TranslationDictionary<string, Localization.Translation> TranslationsByEnglish = new(StringComparer.Ordinal);
        private static readonly TranslationDictionary<string, Localization.Translation> TranslationsById = new(StringComparer.Ordinal);
        private static TranslationDictionary<string, Localization.Translation> publicTranslations;
        private static readonly TranslationSet<Localization.Translation> IndexedRows = new();
        private static readonly Dictionary<Language, LanguageRegistration> Languages = new();
        private static bool registeringCard;
        private static bool registeringGeneratedName;
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
            activeLanguage = Localization.CurrentLanguage;
            LocalizationManager.OnLanguageLoaded += OnLanguageLoaded;
            LoadOfficialLanguage(activeLanguage);
            RebuildIndex();

            // Registered mod strings use the index; native strings retain the
            // game's normal lookup and gender handling.
            var harmony = new Harmony(SimplifiedChineseLanguagePackPlugin.GUID + ".multilingual_runtime");
            harmony.Patch(
                AccessTools.Method(typeof(Localization), "TranslateToLanguage", new[] { typeof(Language), typeof(string), typeof(string) }),
                prefix: new HarmonyMethod(typeof(MultilingualTranslationRuntime), nameof(RegisteredTranslationPrefix)));
            harmony.Patch(
                AccessTools.PropertySetter(typeof(Localization), nameof(Localization.CurrentLanguage)),
                prefix: new HarmonyMethod(typeof(MultilingualTranslationRuntime), nameof(CurrentLanguageChangingPrefix)),
                postfix: new HarmonyMethod(typeof(MultilingualTranslationRuntime), nameof(CurrentLanguageChangedPostfix)));
        }

        internal static void RegisterLanguage(Language language, Action register, Action<IEnumerable<CardInfo>> postRegister, Action<string> registerGeneratedName = null, Action clear = null)
        {
            if (!Languages.ContainsKey(language))
            {
                Languages[language] = new LanguageRegistration
                {
                    Register = register,
                    PostRegister = postRegister,
                    RegisterGeneratedName = registerGeneratedName,
                    Clear = clear,
                    StaticDone = register == null,
                    PostDone = postRegister == null
                };
            }
        }

        internal static void EnsureSelectedLanguage()
        {
            SelectLanguage(Localization.CurrentLanguage);
            EnsureLanguage(Localization.CurrentLanguage);
        }

        internal static void MarkReady()
        {
            // A startup dependency may become available after all plugins Awake.
            // Retry once at this lifecycle boundary, never on every text lookup.
            if (!ready && Languages.TryGetValue(Localization.CurrentLanguage, out var registration)) registration.Failed = false;
            ready = true;
            EnsureSelectedLanguage();
        }

        internal static bool RegisterGeneratedCardName(string name)
        {
            if (string.IsNullOrEmpty(name) || registeringCard || registeringGeneratedName)
            {
                return false;
            }
            EnsureSelectedLanguage();
            if (!Languages.TryGetValue(activeLanguage, out var registration) ||
                registration.Failed || !registration.StaticDone || registration.RegisterGeneratedName == null) return false;
            // The native localized-name getter can register a saved fusion
            // while a full prototype callback is capturing its card names.
            // Keep those rows alive with that snapshot as well as the LRU.
            TransientBatch parentBatch = currentBatch;
            if (GeneratedNames.TryGetValue(name, out var cached))
            {
                Touch(cached);
                RetainBatchEntries(parentBatch, cached);
                return cached.Entries.Count > 0;
            }
            var batch = new TransientBatch { GeneratedName = name };
            currentBatch = batch;
            registeringGeneratedName = true;
            try
            {
                registration.RegisterGeneratedName(name);
                CommitBatch(batch);
                RetainBatchEntries(parentBatch, batch);
                return batch.Entries.Count > 0;
            }
            catch (Exception exception)
            {
                SuspendRegistration(registration, activeLanguage, "合成卡名称", exception);
                return false;
            }
            finally
            {
                registeringGeneratedName = false;
                currentBatch = parentBatch;
                if (batch.Node == null) DiscardBatches(new[] { batch });
            }
        }

        private static void RetainBatchEntries(TransientBatch owner, TransientBatch source)
        {
            if (owner == null) return;
            foreach (Registration entry in source.Entries)
                if (owner.Entries.Add(entry)) entry.References++;
        }

        private static void EnsureLanguage(Language language)
        {
            if (!Languages.TryGetValue(language, out LanguageRegistration registration) || registration.Running || registration.Failed)
            {
                return;
            }
            if (registration.StaticDone && (!ready || registration.PostDone))
            {
                return;
            }

            registration.Running = true;
            try
            {
                if (!registration.StaticDone)
                {
                    registration.Clear?.Invoke();
                    registration.Register();
                    registration.StaticDone = true;
                }
                if (ready && !registration.PostDone)
                {
                    RunPostRegistration(registration, null);
                    registration.PostDone = true;
                }
                registration.FailureReported = false;
            }
            catch (Exception exception)
            {
                SuspendRegistration(registration, language, registration.StaticDone ? "卡牌翻译" : "静态翻译", exception);
            }
            finally
            {
                registration.Running = false;
            }
        }

        private static void SuspendRegistration(LanguageRegistration registration, Language language, string stage, Exception exception)
        {
            registration.Failed = true;
            if (registration.FailureReported) return;
            registration.FailureReported = true;
            UnityEngine.Debug.LogError($"{language} 的{stage}注册失败，已暂停重复尝试，保留已注册译文及原版翻译。\n{exception}");
        }

        private static void CurrentLanguageChangingPrefix(Language __0)
        {
            SelectLanguage(__0);
        }

        private static void CurrentLanguageChangedPostfix(Language __0)
        {
            EnsureLanguage(__0);
        }

        private static void SelectLanguage(Language language)
        {
            if (activeLanguage == language) return;
            RemoveRegistrations(Registrations);
            if (Languages.TryGetValue(activeLanguage, out var previous))
            {
                previous.Clear?.Invoke();
                previous.RegisteredCards.Clear();
                previous.RegisteredCards = new();
                previous.PrototypeBatch?.Entries.Clear();
                previous.PrototypeBatch?.Cards.Clear();
                previous.PrototypeBatch = null;
                previous.StaticDone = previous.Register == null;
                previous.PostDone = previous.PostRegister == null;
                previous.Failed = false;
                previous.FailureReported = false;
            }
            foreach (TransientBatch batch in TransientBatches)
            {
                batch.Entries.Clear();
                batch.Cards.Clear();
                batch.Node = null;
            }
            TransientBatches.Clear();
            TransientCards.Clear();
            GeneratedNames.Clear();
            activeLanguage = language;
            LanguageChanging?.Invoke(language);
            // Unity's non-compacting Mono heap otherwise allocates the next
            // full locale while the retired one still occupies its pages.
            // Collect after all old ownership links are cleared, before the
            // game's setter loads the next locale and our callbacks rebuild it.
            GC.Collect();
        }

        internal static void CardListChanged()
        {
            if (Languages.TryGetValue(activeLanguage, out var registration))
            {
                if (registration.PostRegister != null) registration.PostDone = false;
                // Changed card data can repair a failed dynamic batch, but a
                // missing static dependency cannot be repaired by rendering cards.
                if (registration.StaticDone) registration.Failed = false;
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
            if (registration.Failed || !registration.StaticDone) return;
            registeringCard = true;
            indexedLookupScope++;
            try
            {
                // Observe the card actually entering play, including later mods
                // and external localized-name getters, rather than its startup prototype.
                CardSignature signature = GetCardSignature(card, localizedName);
                if (registration.RegisteredCards.Contains(signature)) return;
                if (TransientCards.TryGetValue(signature, out var cached))
                {
                    Touch(cached);
                    return;
                }
                var batch = new TransientBatch();
                currentBatch = batch;
                try
                {
                    RunPostRegistration(registration, new[] { card });
                    batch.Cards.Add(signature);
                    CommitBatch(batch);
                }
                finally
                {
                    currentBatch = null;
                    if (batch.Node == null) DiscardBatches(new[] { batch });
                }
            }
            catch (Exception exception)
            {
                SuspendRegistration(registration, language, "卡牌翻译", exception);
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
            TransientBatch previousBatch = currentBatch;
            TransientBatch previousPrototypes = registration.PrototypeBatch;
            HashSet<CardSignature> previousCards = registration.RegisteredCards;
            bool replacingPrototypes = false;
            bool completed = false;
            indexedLookupScope++;
            try
            {
                if (source == null)
                {
                    // A sync can replace prototypes during a run or save/load.
                    // Their rows belong to the current snapshot, not the entire
                    // session. Unchanged syncs still skip per-card registration.
                    replacingPrototypes = previousPrototypes == null || PrototypesChanged(registration);
                    if (replacingPrototypes) registration.RegisteredCards = new();
                    currentBatch = replacingPrototypes ? new TransientBatch() : previousPrototypes;
                }
                registration.PendingCards = new();
                registration.PostRegister(source);
                // Commit only after the whole callback succeeds. Failed cards
                // can retry when the card list or selected language changes.
                if (source == null)
                {
                    registration.RegisteredCards.UnionWith(registration.PendingCards);
                    registration.PrototypeBatch = currentBatch;
                    if (replacingPrototypes && previousPrototypes != null) DiscardBatches(new[] { previousPrototypes });
                }
                else currentBatch.Cards.UnionWith(registration.PendingCards);
                completed = true;
            }
            finally
            {
                if (source == null)
                {
                    if (!completed && replacingPrototypes)
                    {
                        registration.RegisteredCards = previousCards;
                        if (currentBatch != null && currentBatch != previousBatch) DiscardBatches(new[] { currentBatch });
                    }
                    currentBatch = previousBatch;
                }
                indexedLookupScope--;
                registration.PendingCards = null;
                registration.Running = wasRunning;
            }
        }

        private static CardSignature GetCardSignature(CardInfo card, string localizedName = null)
        {
            return (card.name, card.displayedName, card.DisplayedNameEnglish, localizedName ?? card.DisplayedNameLocalized,
                card.Attack, card.Health, string.Join(",", card.Abilities ?? new List<Ability>()), card.description);
        }

        private static bool PrototypesChanged(LanguageRegistration registration)
        {
            var current = new HashSet<CardSignature>();
            foreach (CardInfo card in CardManager.AllCardsCopy)
            {
                if (card == null) continue;
                CardSignature signature = GetCardSignature(card);
                if (!registration.RegisteredCards.Contains(signature)) return true;
                current.Add(signature);
            }
            return !registration.RegisteredCards.SetEquals(current);
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

        private static void Touch(TransientBatch batch)
        {
            TransientBatches.Remove(batch.Node);
            TransientBatches.AddLast(batch.Node);
        }

        private static void CommitBatch(TransientBatch batch)
        {
            batch.Node = TransientBatches.AddLast(batch);
            foreach (var signature in batch.Cards) TransientCards[signature] = batch;
            if (batch.GeneratedName != null) GeneratedNames[batch.GeneratedName] = batch;
            if (TransientBatches.Count <= TransientBatchLimit) return;
            // Amortize removal from the game's List across several cards. No
            // full-table scan for every new name or every translation row.
            var expired = new List<TransientBatch>();
            for (int i = 0; i < TransientEvictionCount; i++)
            {
                expired.Add(TransientBatches.First.Value);
                TransientBatches.RemoveFirst();
            }
            DiscardBatches(expired);
        }

        private static void DiscardBatches(IEnumerable<TransientBatch> batches)
        {
            var expired = new TranslationSet<Registration>();
            foreach (var batch in batches)
            {
                foreach (var signature in batch.Cards)
                    if (TransientCards.TryGetValue(signature, out var owner) && owner == batch) TransientCards.Remove(signature);
                if (batch.GeneratedName != null) GeneratedNames.Remove(batch.GeneratedName);
                foreach (var entry in batch.Entries)
                {
                    entry.References--;
                    if (!entry.Persistent && entry.References == 0) expired.Add(entry);
                }
                batch.Entries.Clear();
                batch.Cards.Clear();
                batch.Node = null;
            }
            RemoveRegistrations(expired);
            expired.Clear();
        }

        private static void RemoveRegistrations(IEnumerable<Registration> entries)
        {
            // Reuse the scratch storage across language changes. Clearing its
            // contents releases the rows without repeatedly allocating large
            // tables in Mono's non-compacting heap.
            var removed = RemovalEntries;
            foreach (Registration entry in entries) removed.Add(entry);
            if (removed.Count == 0) return;
            var rows = RemovalRows;
            try
            {
                foreach (var entry in removed)
                {
                    var row = entry.Row;
                    // Another mod may have edited the live row after us. Only
                    // undo values we still own; never restore a stale shadow copy.
                    bool sameKey = row != null && (entry.EnglishStringFormatted != null
                        ? row.englishStringFormatted == entry.EnglishStringFormatted : row.id == entry.Id);
                    if (sameKey && row.values != null && row.values.TryGetValue(entry.Language, out var value) && value == entry.Value)
                    {
                        if (entry.HadPreviousValue) row.values[entry.Language] = entry.PreviousValue;
                        else row.values.Remove(entry.Language);
                    }
                    if (sameKey && entry.CreatedRow && row.values?.Count == 0 && (row.femaleGenderValues == null || row.femaleGenderValues.Count == 0)) rows.Add(row);
                }
                RemoveRegistrationKeys(RegistrationsByEnglish, removed);
                RemoveRegistrationKeys(RegistrationsById, removed);
                Registrations.RemoveAll(removed.Contains);
                if (Localization.Translations.RemoveAll(rows.Contains) > 0) RebuildIndex();
            }
            finally
            {
                // Even an interrupted cleanup must not retain a whole locale
                // through scratch tables or a temporary key snapshot.
                removed.Clear();
                rows.Clear();
                RemovalKeys.Clear();
            }
        }

        private static void RemoveRegistrationKeys(TranslationDictionary<string, Registration> index, TranslationSet<Registration> removed)
        {
            foreach (var pair in index)
                if (removed.Contains(pair.Value)) TranslationStorage.Add(RemovalKeys, pair.Key);
            foreach (string key in RemovalKeys) index.Remove(key);
            RemovalKeys.Clear();
        }

        internal static void Register(string pluginGUID, string id, string englishString, string translatedString, Language language)
        {
            if (language != Localization.CurrentLanguage || language == Language.English ||
                (string.IsNullOrEmpty(englishString) && string.IsNullOrEmpty(id)))
            {
                return;
            }

            Initialize();
            // Complete the native column before our overrides; its CSV loader
            // uses Dictionary.Add. Do not preload other languages here.
            LoadOfficialLanguage(language);
            EnsureCurrentIndex();
            string formatted = string.IsNullOrEmpty(englishString) ? null : Localization.FormatString(englishString);
            Registration registration = FindRegistration(formatted, id);
            if (registration == null)
            {
                registration = new Registration
                {
                    Id = id,
                    EnglishString = englishString,
                    EnglishStringFormatted = formatted,
                    Language = language
                };
                TranslationStorage.Add(Registrations, registration);
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

            if (currentBatch == null) registration.Persistent = true;
            else if (currentBatch.Entries.Add(registration)) registration.References++;
            Localization.Translation translation = GetOrCreateTranslation(registration);
            registration.Value = translatedString;
            translation.values[language] = translatedString;
        }

        internal static string TranslateToLanguage(string text, Language language, string id = null)
        {
            if (language == Localization.CurrentLanguage)
            {
                return !string.IsNullOrEmpty(id) ? Localization.TranslateWithID(id) : Localization.Translate(text);
            }
            Initialize();
            LoadOfficialLanguage(language);
            // Explicit-language setup must use the same game method and patches,
            // including gender, empty values and ID fallback, without changing options.
            return (string)NativeTranslate.Invoke(null, new object[] { language, string.IsNullOrEmpty(id) ? text : null, id });
        }

        private static void LoadOfficialLanguage(Language language)
        {
            if (loadingLanguages || language < Language.French || language > Language.ChineseTraditional)
            {
                return;
            }

            loadingLanguages = true;
            try
            {
                Localization.TryLoadLanguage(language);
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

            // A true table reset needs only the selected column before replay.
            LoadOfficialLanguage(activeLanguage);
            EnsureCurrentIndex();
        }

        private static void ReplayRegistrations()
        {
            foreach (Registration registration in Registrations)
            {
                Localization.Translation translation = GetOrCreateTranslation(registration);
                translation.values[registration.Language] = registration.Value;
            }
        }

        private static void EnsureCurrentIndex()
        {
            List<Localization.Translation> translations = Localization.Translations;
            if (translations.Count == 0)
            {
                LoadOfficialLanguage(activeLanguage);
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
                    PublishTranslation(formatted, translation);
                }
                if (!string.IsNullOrEmpty(translation.id) && !TranslationsById.ContainsKey(translation.id))
                {
                    TranslationsById[translation.id] = translation;
                }
            }
            indexedTranslationCount = indexedTranslations.Count;
            indexedTranslationVersion = TranslationListVersion == null ? indexedTranslationCount : (int)TranslationListVersion.GetValue(indexedTranslations);
        }

        private static void PublishTranslation(string key, Localization.Translation translation)
        {
            // Preserve the public dictionary's identity for other plugins.
            if (publicTranslations == null || !ReferenceEquals(publicTranslations.Data, SimplifiedChineseLanguagePackPlugin.Translations))
                publicTranslations = new TranslationDictionary<string, Localization.Translation>(SimplifiedChineseLanguagePackPlugin.Translations);
            publicTranslations[key] = translation;
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
            bool created = translation == null;
            if (created)
            {
                translation = new Localization.Translation
                {
                    id = registration.Id,
                    englishString = registration.EnglishString,
                    englishStringFormatted = registration.EnglishStringFormatted
                };
                TranslationStorage.Add(indexedTranslations, translation);
                IndexedRows.Add(translation);
                indexedTranslationCount = indexedTranslations.Count;
                indexedTranslationVersion = TranslationListVersion == null ? indexedTranslationCount : (int)TranslationListVersion.GetValue(indexedTranslations);
            }

            translation.values ??= new Dictionary<Language, string>();
            translation.femaleGenderValues ??= new Dictionary<Language, string>();
            if (!ReferenceEquals(registration.Row, translation))
            {
                registration.Row = translation;
                registration.CreatedRow = created;
                registration.HadPreviousValue = translation.values.TryGetValue(registration.Language, out registration.PreviousValue);
            }
            if (registration.EnglishStringFormatted != null)
            {
                TranslationsByEnglish[registration.EnglishStringFormatted] = translation;
                PublishTranslation(registration.EnglishStringFormatted, translation);
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

            if (language == Localization.CurrentLanguage) EnsureSelectedLanguage();

            string formatted = englishText == null ? null : Localization.FormatString(englishText);
            string lookupId = englishText == null ? id : null;
            Registration registration = FindRegistration(formatted, lookupId);
            if (registration == null || registration.Language != language)
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
                    if (registration == null || registration.Language != language) continue;

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
