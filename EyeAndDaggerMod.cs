using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class EyeAndDaggerMod
    {
        public static void RegisterTranslations()
        {
            // 特制匕首
            AddTranslation("Dagger", "匕首");
            // 开局使玩家拥有匕首而不是钳子（注意与KCMLoadouts模组同时使用时可能引发问题）。
            AddTranslation("Grants the player a starting dagger instead of a pair of pliers", "局始使玩家得匕首，不得钳。");
            // 山羊眼
            AddTranslation("Goat Eye", "羊目");
            // 授予山羊眼效果。
            AddTranslation("Grants the goat eye effect.", "授羊目之效。");
        }

        private static void AddTranslation(string english, string classical)
        {
            ClassicChineseLanguagePackPlugin.Translate(
                ClassicChineseLanguagePackPlugin.GUID,
                null,
                english,
                classical,
                Language.ChineseSimplified);
        }
    }
}
