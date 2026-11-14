using System;
using System.Reflection;
using InscryptionAPI.Pelts;

namespace SimplifiedChineseLanguagePack
{
    internal static class PeltDialogueLocalization
    {
        private static readonly Func<PeltManager.PeltData, string> GetTierName = FindTierNameGetter();

        private static Func<PeltManager.PeltData, string> FindTierNameGetter()
        {
            // Older APIs (including 2.14.3) have neither peltTierName nor
            // generated trader dialogue. Do not bind either newer member in IL.
            MethodInfo method = typeof(PeltManager).GetMethod("GetTierNameFromData", BindingFlags.Public | BindingFlags.Static,
                null, new[] { typeof(PeltManager.PeltData) }, null);
            return method == null ? null : (Func<PeltManager.PeltData, string>)Delegate.CreateDelegate(typeof(Func<PeltManager.PeltData, string>), method);
        }

        internal static bool TryGetTierName(PeltManager.PeltData peltData, out string name)
        {
            // The API's own getter preserves custom tier names and its fallback
            // spelling, so translation keys match the dialogue it generates.
            name = GetTierName?.Invoke(peltData);
            return name != null;
        }
    }
}
