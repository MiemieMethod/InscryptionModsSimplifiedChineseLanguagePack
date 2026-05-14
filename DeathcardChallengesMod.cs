using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class DeathcardChallengesMod
    {
        public static void RegisterTranslations()
        {
            // 死亡卡
            AddTranslation("Deathcards", "死牌");
            // 你可以在冒险过程中找到过去挑战者的死亡卡。
            AddTranslation("You may find past challengers' deathcards during your run", "汝于局中或得先前角者之死牌。");
            // 死亡卡创建
            AddTranslation("Deathcard Creation", "造死牌");
            // 如果你在这场冒险中失败了，你可以创建一张死亡卡。
            AddTranslation("You will create a deathcard if you lose", "若汝败此局，则将造一死牌。");
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
