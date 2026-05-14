using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch70
    {
        public static void RegisterTranslations()
        {
            RegisterPostP03ModsOne();
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

        private static void RegisterPostP03ModsOne()
        {
            // 只有毛皮
            AddTranslation("Pelts Only", "惟皮");
            // 所有卡牌选择节点都将替换为猎人和毛皮商。
            AddTranslation("All Card Choices are replaced with either Trapper or Trader.", "诸牌择之节点，皆易为猎夫或易皮者。");
            // 死亡卡
            AddTranslation("Deathcards", "死牌");
            // 你可以在冒险过程中找到过去挑战者的死亡卡。
            AddTranslation("You may find past challengers' deathcards during your run", "汝于局中或得先前角者之死牌。");
            // 死亡卡创建
            AddTranslation("Deathcard Creation", "造死牌");
            // 如果你在这场冒险中失败了，你可以创建一张死亡卡。
            AddTranslation("You will create a deathcard if you lose", "若汝败此局，则将造一死牌。");
            // 永久战败之死
            AddTranslation("Perma Death on die", "死则永亡");
            // 如果你卡组中的任意卡牌在战斗中被杀死，其将从你的牌组中被永久移除（即便有不死之虫也是如此）。
            AddTranslation("All card are removed from your deck if killed.", "凡汝牌列之牌，战死则永出其列。");
            // 永久献祭之死
            AddTranslation("Perma Death on sacrifice", "祀则永亡");
            // 如果你卡组中的任意卡牌被你献祭过，其将从你的牌组中被永久移除（即便有生生不息也是如此）。
            AddTranslation("All card are removed from your deck if sacrificed.", "凡汝牌列之牌，既见祀则永出其列。");
            // 锤子
            AddTranslation("Hammer", "槌");
            // 你可以使用锤子销毁自己的卡牌。
            AddTranslation("You may use the hammer to destroy your own cards", "汝可用槌毁己牌。");
            // 更好的图腾
            AddTranslation("Better Totems", "良图腾");
            // 木雕师不会再给你低强度等级印记的图腾。
            AddTranslation("The Woodcarver will no longer give you totems with weak sigils", "刻木妪不复与汝以弱印之图腾。");
            // 特制匕首
            AddTranslation("Dagger", "匕首");
            // 开局使玩家拥有匕首而不是钳子（注意与KCMLoadouts模组同时使用时可能引发问题）。
            AddTranslation("Grants the player a starting dagger instead of a pair of pliers", "局始使玩家得匕首，不得钳。");
            // 山羊眼
            AddTranslation("Goat Eye", "羊目");
            // 授予山羊眼效果。
            AddTranslation("Grants the goat eye effect.", "授羊目之效。");
            // 更少的副牌
            AddTranslation("Smaller Side Deck", "小副牌列");
            // 你的副牌组的牌减少2张。
            AddTranslation("Remove 2 cards from your side deck.", "汝副牌列减二牌。");
            // 被掠食者咬伤
            AddTranslation("Bitten By Predator", "为掠者所噬");
            // 这张牌被掠食者咬伤。
            AddTranslation("This card was bitten by a predator", "此牌为掠者所噬。");
            // 弓与箭
            AddTranslation("Bow and Arrow", "弓矢");
            // 捕获
            AddTranslation("Capture", "执");
            // 尖刺陷阱
            AddTranslation("Spike Trap", "棘阱");
        }
    }
}
