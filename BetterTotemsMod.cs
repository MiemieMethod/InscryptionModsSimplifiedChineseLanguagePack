using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class BetterTotemsMod
    {
        public static void RegisterTranslations()
        {
            // 更好的图腾
            AddTranslation("Better Totems", "良图腾");
            // 木雕师不会再给你低强度等级印记的图腾。
            AddTranslation("The Woodcarver will no longer give you totems with weak sigils", "刻木妪不复与汝以弱印之图腾。");
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
