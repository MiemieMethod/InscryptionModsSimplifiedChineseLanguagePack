using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch102
    {
        public static void RegisterTranslations()
        {
            RegisterInGameCardCreatorThree();
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

        private static void RegisterInGameCardCreatorThree()
        {
            string[] gemTypesEn = { "orange", "blue", "green" };
            string[] gemTypes = { "橙", "蓝", "绿" };
            for (int index = 0; index < gemTypesEn.Length; index++)
            {
                // {color}宝石
                AddTranslation(gemTypesEn[index] + " gem", gemTypes[index] + "玉");
                // {color}宝石成本。
                AddTranslation("A cost of a [c:bR]" + gemTypesEn[index] + " gem[c:].", "[c:bR]" + gemTypes[index] + "玉[c:]之费。");
            }
            // 手牌数
            AddTranslation("CardsInHand", "手牌数");
            // 虱子
            AddTranslation("lice", "虱");
            // 简单
            AddTranslation("simple", "简");
            // 中等
            AddTranslation("intermediate", "中");
            // 高级
            AddTranslation("advanced", "繁");
            // 常规卡牌。
            AddTranslation("A [c:bR]regular[c:] card.", "[c:bR]常[c:]牌。");
            // 稀有卡牌。
            AddTranslation("A [c:bR]rare[c:] card.", "[c:bR]罕[c:]牌。");
            // 隐藏卡牌。
            AddTranslation("A [c:bR]hidden[c:] card.", "[c:bR]隐[c:]牌。");
            // 松鼠族群
            AddTranslation("squirrel tribe", "松鼠族");
            // 鸟类族群
            AddTranslation("bird tribe", "鸟族");
            // 犬类族群
            AddTranslation("canine tribe", "犬族");
            // 有蹄类族群
            AddTranslation("hooved tribe", "蹄族");
            // 爬行类族群
            AddTranslation("reptile tribe", "鳞族");
            // 昆虫类族群
            AddTranslation("insect tribe", "虫族");
        }
    }
}
