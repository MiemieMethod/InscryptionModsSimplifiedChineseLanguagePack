using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch25
    {
        public static void RegisterTranslations()
        {
            RegisterOriginalModifiedMod();
            RegisterCustomSideDeckMod();
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

        private static void RegisterOriginalModifiedMod()
        {
            // 阿米巴松鼠
            AddTranslation("Amoeba Squirrel", "阿米巴松鼠");
            // 恼人水松鼠
            AddTranslation("Annoying Aquasquirrel", "烦水松鼠");
            // 献祭之石
            AddTranslation("Bloody Stone", "血石");
            // 自爆水松鼠
            AddTranslation("Explosion Aquasquirrel", "爆水松鼠");
            // 自爆松鼠
            AddTranslation("Explosion Squirrel", "爆松鼠");
            // 杀手蜂
            AddTranslation("Killer Bee", "杀蜂");
            // 优质松鼠
            AddTranslation("Quality Squirrel", "良松鼠");
            // 高跳松鼠
            AddTranslation("Reach Squirrel", "跃松鼠");
            // 可祭磐石
            AddTranslation("Sacrificable Boulder", "可祀磐");
            // 长尾松鼠
            AddTranslation("Tail Squirrel", "尾松鼠");
            // 鹰
            AddTranslation("Hawk", "鹰");
            // 凶猛的鹰。最有效的制空手段之一。
            AddTranslation("The vicious hawk. One of the most effective flying attackers.", "鹰猛，飞攻之尤效者。");
            // 鲑鱼
            AddTranslation("Salmon", "鲑");
            // 健壮的鲑鱼。它能逆流快速游动。
            AddTranslation("The athletic salmon. It swims quickly upstream.", "鲑健，溯流甚疾。");
            // 松鼠球
            AddTranslation("Squirrel Ball", "松鼠球");
            // 奇特的松鼠球。滚动时会留下几只迷途松鼠。
            AddTranslation("The peculiar squirrel ball. When it rolls, it leaves behind some stray squirrels.", "松鼠球甚奇，滚则遗数迷松鼠。");
            // 红宝石松鼠
            AddTranslation("Ruby Squirrel", "红玉松鼠");
            // 绿宝石松鼠
            AddTranslation("Emerald Squirrel", "绿玉松鼠");
            // 蓝宝石松鼠
            AddTranslation("Sapphire Squirrel", "蓝玉松鼠");
        }

        private static void RegisterCustomSideDeckMod()
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
            for (int point = 0; point <= 100; point++)
            {
                // 当前副牌组：<color=#eef4c6>{point}</color>挑战点数
                AddTranslation("CURRENT SIDE DECK: <color=#eef4c6>" + point.ToString() + "</color> Challenge Points", "今副牌：<color=#eef4c6>" + point.ToString() + "</color>挑战点");
                // 当前副牌组：<color=#eef4c6>+{point}</color>挑战点数
                AddTranslation("CURRENT SIDE DECK: <color=#eef4c6>+" + point.ToString() + "</color> Challenge Points", "今副牌：<color=#eef4c6>+" + point.ToString() + "</color>挑战点");
                // 总挑战点数：<color=#eef4c6>{point}</color>
                AddTranslation("Total Challenge Points: <color=#eef4c6>" + point.ToString() + "</color>", "总挑战点：<color=#eef4c6>" + point.ToString() + "</color>");
            }

            // 包含{0}张卡牌
            AddTranslation("\nContains {0} cards", "\n含{0}牌");
        }
    }
}
