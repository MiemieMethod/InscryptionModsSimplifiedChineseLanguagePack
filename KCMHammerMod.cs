using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class KCMHammerMod
    {
        public static void RegisterTranslations()
        {
            // 锤子
            AddTranslation("Hammer", "槌");
            // 你可以使用锤子销毁自己的卡牌。
            AddTranslation("You may use the hammer to destroy your own cards", "汝可用槌毁己牌。");
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
