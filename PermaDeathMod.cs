using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class PermaDeathMod
    {
        public static void RegisterTranslations()
        {
            // 永久战败之死
            AddTranslation("Perma Death on die", "死则永亡");
            // 如果你卡组中的任意卡牌在战斗中被杀死，其将从你的牌组中被永久移除（即便有不死之虫也是如此）。
            AddTranslation("All card are removed from your deck if killed.", "凡汝牌列之牌，战死则永出其列。");
            // 永久献祭之死
            AddTranslation("Perma Death on sacrifice", "祀则永亡");
            // 如果你卡组中的任意卡牌被你献祭过，其将从你的牌组中被永久移除（即便有生生不息也是如此）。
            AddTranslation("All card are removed from your deck if sacrificed.", "凡汝牌列之牌，既见祀则永出其列。");
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
