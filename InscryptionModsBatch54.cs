using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch54
    {
        public static void RegisterTranslations()
        {
            RegisterP03InKayceesBatchOne();
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

        private static void RegisterP03InKayceesBatchOne()
        {
            // 双重死亡
            AddTranslation("Double Death", "再死");
            // 爆头射击
            AddTranslation("Head Shot", "枭首");
            // [creature]可免疫死神之触、臭臭印记和火焰的效果。
            AddTranslation("[creature] is immune to the effects of Touch of Death, Stinky, and fire.", "[creature]不受死触、恶臭与火之效。");
            // 如果[creature]持牌人未打出玛珂容器，则[creature]会阵亡。
            AddTranslation("If [creature]'s owner controls no Gem Vessels, [creature] perishes.", "若[creature]之主持无玉皿，则[creature]死。");
            // 加密货币矿机
            AddTranslation("Mine Cryptocurrency", "采密币");
            // 当[creature]作为管道的一部分时，将会生成加密货币。
            AddTranslation("When part of a conduit, [creature] will generate cryptocurrency.", "当[creature]处渠中，则生密币。");
            // 盖章文件
            AddTranslation("Stamp Paperwork", "印牍");
            // 消耗1点能量为这份文件盖章，确认其已妥善归档并准备进入下一流程。
            AddTranslation("Pay 1 Energy to stamp this paperwork as properly filed and ready for further processing.", "费一能，以印此牍，使之既录，可更行其事。");
            // 强力打击
            AddTranslation("Big Strike", "并击");
            // [creature]会攻击对面所有路线上的卡牌，如果对面没有卡牌则会攻击正中间路线。
            AddTranslation("[creature] attacks all cards in all lanes opposing it, or attacks just the center opposing lane if there are no cards it can attack.", "[creature]攻其对之诸列诸牌；若无可攻者，则独攻中央对列。");
            // 多元宇宙炸弹传花
            AddTranslation("Multiverse Bomb Latch", "诸界爆弹遗契");
            // [creature]阵亡时，其持牌人需在任意宇宙中选定一个造物继承多元宇宙引爆器印记
            AddTranslation("When [creature] perishes, its owner chooses a creature in any universe to gain the Multiverse Detonator sigil.", "[creature]死，则其主持择诸界一物，受诸界引爆印契。");
            // 多元宇宙脆骨传花
            AddTranslation("Multiverse Brittle Latch", "诸界脆骨遗契");
            // [creature]阵亡时，其持牌人需在任意宇宙中选定一个造物继承脆骨印记。
            AddTranslation("When [creature] perishes, its owner chooses a creature in any universe to gain the Brittle sigil.", "[creature]死，则其主持择诸界一物，受脆骨印契。");
            // 多元宇宙引爆器
            AddTranslation("Multiverse Detonator", "诸界引爆");
            // 当[creature]死亡时，所有平行宇宙中相邻的卡牌都会受到10点伤害
            AddTranslation("When [creature] dies, all adjacent cards in all universes are dealt 10 damage", "[creature]死，则诸界邻牌皆受十伤。");
            // 多元宇宙燃油满溢
            AddTranslation("Multiverse Full of Oil", "诸界盈油");
            // 当[creature]死亡时，每个宇宙中其左右两侧及正对面的造物都会获得3点生命值。
            AddTranslation("When [creature] dies, it adds 3 health to the creature on either side and across from it in every universe.", "[creature]死，则诸界中其两旁与其对之物皆命益三。");
            // 多重宇宙满载
            AddTranslation("Multiverse Fully Loaded", "诸界满载");
            // [creature]死亡时，会在其所在平行宇宙的对应位置留下永久的+1攻击力加成。
            AddTranslation("When [creature] dies, it leaves a permanent +1 attack bonus in the lane it occupied in every universe.", "[creature]死，则诸界中其所居列皆遗永久益威一之效。");
            // 多元宇宙守护者
            AddTranslation("Multiverse Guardian", "诸界守者");
            // 当任意宇宙中的对手造物被放置在一个空位对面时，[creature]会移动至该空位。
            AddTranslation("When an opposing creature is placed opposite to an empty space in any universe, [creature] will move to that empty space.", "诸界中，敌物若陈于一空位之对，则[creature]移于彼空位。");
            // 多元宇宙钻地龙
            AddTranslation("Multiverse Burrower", "诸界潜龙");
            // 当一个空位可能受到攻击时，[creature]会穿越多元宇宙移动至该位置承受攻击。
            AddTranslation("When an empty space would be struck, [creature] will cross universes to move to that space to receive the strike instead.", "若诸界有空位将受击，则[creature]越界移于彼，代受其击。");
            // 多元宇宙空无管道
            AddTranslation("Multiverse Null Conduit", "诸界虚渠");
            // 由[creature]构成的回路将在所有宇宙中同时生效
            AddTranslation("Circuits completed by [creature] are completed in every universe.", "[creature]所成回路，诸界皆成。");
            // 多元宇宙高跳
            AddTranslation("Multiverse Mighty Leap", "诸界高跃");
            // [creature]会跨越多元宇宙拦截该路径上发生的所有攻击
            AddTranslation("[creature] will leap across universes to block attacks that occur in this lane in any universe.", "[creature]跃越诸界，以御诸界中此列所至之攻。");
            // 多元宇宙哨兵
            AddTranslation("Multiverse Sentry", "诸界哨兵");
            // 任何造物在任意宇宙中进入[creature]对面的位置时，均会受到1点伤害。
            AddTranslation("When a creature moves into the space opposing [creature] in any universe, they are dealt 1 damage.", "任一界有物入[creature]对位，则彼受一伤。");
            // 多元宇宙坚盾传花
            AddTranslation("Multiverse Shield Latch", "诸界微铠遗契");
            // [creature]阵亡时，其持牌人可选择任意宇宙中的造物继承纳米铠甲印记。
            AddTranslation("When [creature] perishes, its owner chooses a creature in any universe to gain the Nano Armor sigil.", "[creature]死，则其主持择诸界一物，受微铠印契。");
            // 多元宇宙冲刺能手
            AddTranslation("Multiverse Sprinter", "诸界驰者");
            // 持牌人回合结束时，[creature]将跃迁至下一个宇宙。
            AddTranslation("At the end of the owner's turn, [creature] will move to the next universe.", "持牌者合终，[creature]跃于次界。");
            // 多重宇宙打击
            AddTranslation("Multiverse Strike", "诸界击");
            // [creature]会攻击除自身所在宇宙外所有平行宇宙中的对应位置
            AddTranslation("[creature] will strike each opposing space in every universe other than its own.", "[creature]攻诸界中凡非其本界之对位。");
            // 多元宇宙至尊玛珂
            AddTranslation("Multiverse Great Mox", "诸界至尊玛珂");
            // 当打出[creature]时，所有平行宇宙中持牌人侧牌桌都将获得绿、橙、蓝宝石各一颗
            AddTranslation("When [creature] is played, a Green, Orange, and Blue Gem is provided to the owner's side in every universe.", "[creature]既陈，则诸界中其主持之侧，皆得绿、橙、蓝玉各一。");
            // 多元宇宙囤积狂
            AddTranslation("Multiverse Hoarder", "诸界藏者");
            // 使用[creature]时，你可以从多元宇宙中搜寻一张已消亡且能穿越多元宇宙的卡牌。
            AddTranslation("When [creature] is played, you may search the multiverse for a card that has perished that is capable of traversing the multiverse.", "[creature]既陈，汝可于诸界求一已死而能越界之牌。");
        }
    }
}
