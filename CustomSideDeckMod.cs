using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class CustomSideDeckMod
    {
        public static void RegisterTranslations()
        {
            // 模组作者应该如何处理副牌组的卡牌背面，不添加自己的自定义卡背面。如果启用，将根据副牌的卡面自动生成唯一的卡牌背面纹理。否则，将使用默认的松鼠卡背纹理。
            AddTranslation("How the mod should handle side deck card backs for side decks that don't add their own custom card back. If enabled, automatically generates a unique card back based on the side deck's main card's portrait. Otherwise, the default squirrel back will be used.", "凡副牌未自益其卡背者，模组当何以处之：若启，则因副牌主卡之像自成一异卡背；不然，则用常松鼠之背。");
            // 是否自动添加所有自定义副牌组的水生版本。不推荐。
            AddTranslation("Whether to automatically add an Aqua version of all custom side decks. Buggy, not recommended.", "是否自益诸自定义副牌之水生本。有疵，不荐。");
            // 即使松鼠鱼挑战未开启，是否应将水生松鼠和标记为“仅水生”的自定义副牌组显示为选项。
            AddTranslation("Whether or not Aquasquirrels and custom side decks marked as `CSDIsAqua` should be shown as options even when the Squirrel Fish challenge isn't on.", "纵潜袭松鼠之角竞未启，水松鼠与标为`CSDIsAqua`之副牌，是否亦显为可选。");
            // 选择副牌组
            AddTranslation("Select Side Deck", "择副牌");
            // 配置副牌组
            AddTranslation("Configure Side Deck", "调副牌");
            //  / 包含{0}张卡牌
            AddTranslation("\nContains {0} cards", "\n含{0}牌");
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
