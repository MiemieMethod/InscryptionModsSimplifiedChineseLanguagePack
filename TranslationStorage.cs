using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace SimplifiedChineseLanguagePack
{
    // Unity 2019 uses a conservative GC. A hash value can resemble an address
    // inside a discarded, large backing array and keep every row in it alive.
    // Keep the framework collections and their semantics, but clear the old
    // reference storage after a successful resize. Only growth uses reflection.
    internal static class TranslationStorage
    {
        private static class ListStorage<T>
        {
            internal static readonly FieldInfo Items = typeof(List<T>).GetField("_items", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        internal static void Add<T>(List<T> list, T value)
        {
            if (list.Count < list.Capacity)
            {
                list.Add(value);
                return;
            }
            var retired = ListStorage<T>.Items?.GetValue(list) as Array;
            list.Add(value);
            if (retired != null && retired.Length != list.Capacity) Array.Clear(retired, 0, retired.Length);
        }
    }

    internal sealed class TranslationDictionary<TKey, TValue> : IEnumerable<KeyValuePair<TKey, TValue>>
    {
        private static readonly FieldInfo Entries = typeof(Dictionary<TKey, TValue>).GetField("entries", BindingFlags.Instance | BindingFlags.NonPublic)
            ?? typeof(Dictionary<TKey, TValue>).GetField("_entries", BindingFlags.Instance | BindingFlags.NonPublic);
        internal Dictionary<TKey, TValue> Data { get; }
        private int capacity;

        internal TranslationDictionary(IEqualityComparer<TKey> comparer)
            : this(new Dictionary<TKey, TValue>(comparer)) { }

        internal TranslationDictionary(Dictionary<TKey, TValue> data)
        {
            Data = data;
            capacity = Entries == null ? int.MaxValue : (Entries.GetValue(data) as Array)?.Length ?? 0;
        }

        public int Count => Data.Count;

        internal TValue this[TKey key]
        {
            get => Data[key];
            set
            {
                if (Data.Count < capacity)
                {
                    Data[key] = value;
                    return;
                }
                var retired = Entries?.GetValue(Data) as Array;
                Data[key] = value;
                var current = Entries?.GetValue(Data) as Array;
                capacity = current?.Length ?? int.MaxValue;
                if (retired != null && !ReferenceEquals(retired, current)) Array.Clear(retired, 0, retired.Length);
            }
        }

        internal bool ContainsKey(TKey key) => Data.ContainsKey(key);
        internal bool TryGetValue(TKey key, out TValue value) => Data.TryGetValue(key, out value);
        internal bool Remove(TKey key) => Data.Remove(key);
        internal void Clear() => Data.Clear();
        public Dictionary<TKey, TValue>.Enumerator GetEnumerator() => Data.GetEnumerator();
        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }

    internal sealed class TranslationSet<T> : IEnumerable<T>
    {
        private static readonly FieldInfo Slots = typeof(HashSet<T>).GetField("_slots", BindingFlags.Instance | BindingFlags.NonPublic)
            ?? typeof(HashSet<T>).GetField("_entries", BindingFlags.Instance | BindingFlags.NonPublic);
        private readonly HashSet<T> data = new();
        private int capacity = Slots == null ? int.MaxValue : 0;

        internal TranslationSet() { }

        public int Count => data.Count;
        internal bool Add(T value)
        {
            if (data.Count < capacity) return data.Add(value);
            var retired = Slots?.GetValue(data) as Array;
            bool added = data.Add(value);
            var current = Slots?.GetValue(data) as Array;
            capacity = current?.Length ?? int.MaxValue;
            if (retired != null && !ReferenceEquals(retired, current)) Array.Clear(retired, 0, retired.Length);
            return added;
        }

        internal bool Contains(T value) => data.Contains(value);
        internal void Clear() => data.Clear();
        public HashSet<T>.Enumerator GetEnumerator() => data.GetEnumerator();
        IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
