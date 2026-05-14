using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch44
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchEight();
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

        private static void RegisterAllTheSigilsBatchEight()
        {
            // 丧钟
            AddTranslation("Deathbell", "丧钟");
            // 每个回合开始时，[creature]会消亡。
            AddTranslation("At the start of the battle phase, [creature] perishes.", "战阶始，[creature]即灭。");
            // 顺时针
            AddTranslation("Clockwise", "顺时");
            // 当一张[creature]被打出时，场上所有卡牌顺时针移动一格。
            AddTranslation("When [creature] is played, move all cards on the board clockwise.", "[creature]既陈，局上诸牌皆顺时移一格。");
            // 顽固不化
            AddTranslation("Stubborn", "固");
            // [creature]不能交换其属性。
            AddTranslation("[creature] may not have its stats swapped.", "[creature]不得易其数。");
            // 每回合结束时，若场上存在一张[creature]，则将场上的所有卡牌顺时针移动一格。
            AddTranslation("At the end of each turn [creature] is on the board, move all cards on the board clockwise.", "每合终，若[creature]在局，则局上诸牌皆顺时移一格。");
            // 稍纵即逝
            AddTranslation("Fleeting", "暂");
            // 一张[creature]将在回合结束时被弃置。
            AddTranslation("At the end of the turn [creature] will be discarded from your hand.", "合终，[creature]自汝手见弃。");
            // 灵魂链接
            AddTranslation("Soul Link", "同魂");
            // 当[creature]消亡时，所有其他带有此印记的友方卡牌也将随之消亡。
            AddTranslation("When [creature] perishes, all other allied cards bearing this sigil perish as well.", "[creature]灭，则余有此印之友牌皆灭。");
            // 空洞抽取
            AddTranslation("Hollow Draw", "虚引");
            // 当[creature]被打出时，弃掉你手中最早抽到的卡牌，重新抽一张牌。
            AddTranslation("When [creature] is played, discard the oldest card in your hand, draw a card.", "[creature]既陈，弃汝手中最先所引之牌，而更引一牌。");
            // 空洞弹幕
            AddTranslation("Hollow Barrage", "虚霰");
            // 当[creature]被打出时，场上所有卡牌受到1点伤害。
            AddTranslation("When [creature] is played, all cards take 1 damage.", "[creature]既陈，局上诸牌皆受一伤。");
            // 宝石恐惧
            AddTranslation("Gem Phobic", "惧玉");
            // 若[creature]的持有者场上拥有任何玛珂牌，[creature]将消亡。
            AddTranslation("If [creature]'s owner controls a Mox card, [creature] perishes.", "若[creature]之主持有玛珂牌，[creature]即灭。");
            // 鲁莽
            AddTranslation("Foolhardy", "妄");
            // [creature]不能从任何事件中获得修改。
            AddTranslation("[creature] may not recieve modifications from any source.", "[creature]不得受任何改益。");
            // 跳跃者
            AddTranslation("Jumper", "跃");
            // 在持牌人的回合结束时，[creature]会自行向印记标注的方向移动至第一个空位。
            AddTranslation("At the end of the owner's turn, [creature] will move itself to the first empty space in the direction inscribed in the sigil.", "持牌者合终，[creature]自循印所志之向移至其首空位。");
            // 冲刺狂人
            AddTranslation("Super Sprinter", "疾趋");
            // 在持牌人的回合结束时，[creature]会尽可能地向印记标注的方向移动。
            AddTranslation("At the end of the owner's turn, [creature] will move itself as far as possible in the direction inscribed in the sigil.", "持牌者合终，[creature]尽所能循印所志而移。");
            // 蛋之艺术
            AddTranslation("Eggist", "生卵");
            // 当打出[creature]时，在每个相邻的空位上各创建一个蛋。
            AddTranslation("When [creature] is played, an Egg is created on each empty adjacent space.", "[creature]既陈，其邻空位各生一卵。");
            // 唤林者
            AddTranslation("Fir Caller", "召杉");
            // 当[creature]被打出时，在持牌人的每个空位上创造一个大冷杉。
            AddTranslation("When [creature] is played, a Fir is created in each of the owner's spaces.", "[creature]既陈，持牌者诸空位各生一杉。");
            // 浮光掠影
            AddTranslation("Flipper", "易数");
            // 在持牌人回合结束时，[creature]会交换其属性。
            AddTranslation("At the end of the owner's turn, [creature] swaps its stats.", "持牌者合终，[creature]易其数。");
            // 消逝之手
            AddTranslation("Fleeting Draw", "暂引");
            // 当一张[creature]被打出时，获得一张带有稍纵即逝印记的牌。
            AddTranslation("When [creature] is played, draw 1 card with Fleeting.", "[creature]既陈，则引一有暂印之牌。");
            // 流浪者
            AddTranslation("Outcast", "还列");
            // 回合结束时，[creature]会被洗入你的牌组。
            AddTranslation("At the end of the turn, [creature] is shuffled into the deck.", "合终，[creature]还入汝牌列而乱之。");
            // 空洞中继
            AddTranslation("Hollow Repeater", "虚继");
            // 当[creature]消亡时，该卡牌上所有上场时触发的印记将被激活。
            AddTranslation("When [creature] perishes, all On Play sigils on that card are activated.", "[creature]灭，则此牌上凡陈时所发之印皆启。");
            // 买一送一
            AddTranslation("Replenish", "续引");
            // 当一张[creature]被抽到时，再抽一张牌。
            AddTranslation("When [creature] is drawn, draw a card.", "[creature]既引，更引一牌。");
            // 目标交换器
            AddTranslation("Target Swap", "易数指");
            // 放置[creature]时，持牌人选择一张牌：该牌的力量和生命数值将被交换。
            AddTranslation("When [creature] is played, Target a Card: the card's stats are swapped.", "[creature]既陈，择一牌而易其威命。");
            // 祭祀生长
            AddTranslation("Sacrificial Growth", "祀长");
            // 当[creature]被献祭时，它将成长为更强大的形态。
            AddTranslation("When [creature] is sacrificed, it will grow into a more powerful form.", "[creature]见祀，则长为益强之形。");
            // 红宝石易形
            AddTranslation("Ruby Transformer", "红玉化");
            // 若[creature]的持牌人场上拥有红宝石玛珂，[creature]将转变为另一种形态；否则[creature]将转变为其基础形态。
            AddTranslation("If [creature]'s owner controls a Ruby Mox, [creature] will be transformed; otherwise [creature] will transform into its base form.", "若[creature]之主持红玉玛珂，则[creature]化其异形；不然，则反其本形。");
            // 宝石增益
            AddTranslation("Gemify", "玉益");
            // [creature]根据进场时持牌人拥有宝石获得增益。橙色：增加1点力量；绿色：增加2点生命；蓝色：降低花费成本。
            AddTranslation("[creature] gains buffs based on moxes in play on the owner's side. Orange is 1 Power. Green is 2 Health. Blue is lower Cost.", "[creature]视其主持局中诸玛珂而受益：橙则威益一，绿则命益二，蓝则直降。");
            // 尸体
            AddTranslation("Corpse", "尸");
            // 测试卡牌
            AddTranslation("TestCard", "试牌");
        }
    }
}
