using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class LesserSideDeckMod
    {
        public static void RegisterTranslations()
        {
            // 更少的副牌
            AddTranslation("Smaller Side Deck", "小副牌列");
            // 你的副牌组的牌减少2张。
            AddTranslation("Remove 2 cards from your side deck.", "汝副牌列减二牌。");
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
