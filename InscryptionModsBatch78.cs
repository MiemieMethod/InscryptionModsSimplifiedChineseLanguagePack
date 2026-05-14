using DiskCardGame;
using UnityEngine;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch78
    {
        public static void RegisterTranslations()
        {
            RegisterWhistleWindLobotomyOne();
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

        private static void RegisterWhistleWindLobotomyOne()
        {
            // 附录12，第二节 - 状态效果{0}
            AddTranslation("APPENDIX XII, SUBSECTION II - STATUS EFFECTS {0}", "附编十二，第二节——诸状{0}");
            // 你没有卡牌可以选择。
            AddTranslation("There are no cards you can choose.", "无可择之牌。");
            // 你不能瞄准空气。
            AddTranslation("You can't target the air.", "不得指虚空。");
            // 你必须从其他卡牌中选择一张。
            AddTranslation("You must choose one of your other cards.", "汝须择他牌之一。");
            // 它已经锁上了...
            AddTranslation("It's already latched...", "其已见契矣……");
            // 传花母本
            AddTranslation("LatchParent", "遗契母本");
            // 井中爬出的异物归入了你的旅队。你对身后井口的阵阵哀嚎置若罔闻，只管催着队伍加速赶路。
            AddTranslation("The creature rises from the well and joins your caravan. Ignoring the cries from the well, you hastily continue on.", "井中有物出，而入汝旅队。汝弗顾井中之号，亟驱众而前。");
            // 你可选择1张加入己方队伍，其余个体将永沉于渊，被彻底遗忘。
            AddTranslation("You may choose [c:bR]1[c:] to join you. The others will remain submerged and forgotten.", "汝可择[c:bR]1[c:]以从己。其余则永沈于渊，而为人忘。");
            // 虔敬
            AddTranslation("Adoration", "钦慕");
            // 持牌人回合开始时，若“溶解之爱”生命值为1，则吸收相邻史莱姆卡牌的生命值，直至“溶解之爱”恢复至最大生命值。
            AddTranslation("At the start of the owner's turn, if Melting Love is at 1 Health, absorb the Health of adjacent Slime cards until Melting Love is at max Health.", "其主合始，若“溶爱”惟一命，则吸邻胶牌之命，至“溶爱”复其极。");
            // 下
            AddTranslation("Down", "下");
            // 蒙受恩泽之人啊，当称颂欢歌。因我与你们同在。
            AddTranslation("[c:bR]Ye who are full of blessings, rejoice. For I am with ye.[c:]", "[c:bR]尔既蒙祐，可乐也。盖我与尔偕。[c:]");
            // 无人能挡我登神之路。
            AddTranslation("[c:bR]Thou cannot stop my ascension.[c:]", "[c:bR]汝不能遏我之升。[c:]");
            // 宿命之刻已至，我将为你指明道路。
            AddTranslation("[c:bR]The time has come again. I will be thy guide.[c:]", "[c:bR]时复至矣，我将为汝导。[c:]");
            // 起来吧，我的仆从，欢唱着迎接我的到来。
            AddTranslation("[c:bR]Rise, my servants. Rise and serve me.[c:]", "[c:bR]起，我仆也。起而事我。[c:]");
            // 除我之外，你不得信奉任何神明。
            AddTranslation("[c:bR]Thou shalt have no other gods before me.[c:]", "[c:bR]汝于我前，毋有他神。[c:]");
            // 时钟之轮，正缓缓驶向救赎彼岸。
            AddTranslation("The hands of the Clock move towards salvation.", "钟针徐趋于救。");
            // 待到那一日降临，来找到我。
            AddTranslation("[c:bR]When the day comes, find me.[c:]", "[c:bR]其日既至，来求我。[c:]");
            // 渡你脱出毁灭，于终末将你重塑。
            AddTranslation("[c:bR]I will save your life from destruction and raise you from the end of the world.[c:]", "[c:bR]我将拯汝于毁，而举汝自终末。[c:]");
            // 赐福
            AddTranslation("Bless", "祐");
            // 每当疫医通过治愈印记成功治疗其他卡牌时，其自身形态将会发生改变。
            AddTranslation("Whenever Plague Doctor successfully heals another card using the Healer sigil, it changes its appearance.", "疫医凡以医印疗他牌而成，则变其形。");
            // 盲怒
            AddTranslation("Blind Rage", "瞽怒");
            // 愤怒侍从在攻击时将瞄准场上的随机位置，优先考虑已有卡牌的空间。
            AddTranslation("Servant of Wrath will target a random space on the board when attacking, prioritising occupied spaces.", "忿之侍攻时，偶指局中一位，先取有牌者。");
            // [数据删除]
            AddTranslation("CENSORED", "[削档]");
            // 每当[数据删除]击杀敌方卡牌时，将一张携带有该被击杀卡牌的攻击力、族群及印记的[数据删除]置入你的手牌。
            AddTranslation("Whenver CENSORED kills a card, create a CENSORED in your hand with the killed card's Power, tribes, and sigils.", "凡[削档]杀一牌，则汝手中生一[削档]，具彼牌之威、属与印。");
            // 和谐
            AddTranslation("Concord", "和");
            // 当阳卡牌与阴卡牌相邻时，激活特殊能力。
            AddTranslation("When Yang is adjacent to Yin, activate a special sequence.", "阳牌邻阴牌，则发异序。");
            // 懦夫
            AddTranslation("Cowardly", "怯");
            // 若场上存在非地形友方卡牌，胆小的猫咪将变形为更强形态；反之，则变形为弱化形态。
            AddTranslation("If there is an non-Structure ally card on the board, Scaredy Cat transforms into a stronger forme. Otherwise transform into a weaker forme.", "局中若有非地形之友牌，则怯猫化为强形；不然，则化为弱形。");
            // 绛红血痕
            AddTranslation("Crimson Scar", "绛痕");
            // 当又大又可能很坏的狼与小红帽雇佣兵中任意一方登场时，另一方将获得 1 点攻击力；且二者同时在场期间，彼此会将对方列为唯一攻击目标。
            AddTranslation("Big and Will Be Bad Wolf and Red Hooded Mercenary will gain 1 Power when their counterpart is played on the board. While they're on the board, target them exclusively.", "“大而将恶之狼”与“红兜佣者”，其对者既陈，则威益一；二者并在局，则各专指其对。");
            // 黑森林的怪物
            AddTranslation("Monster in the Black Forest", "黑林之怪");
            // “从前，有三只鸟儿栖息在苍翠密林，日子过得安宁祥和……”
            AddTranslation("'Once upon a time, three birds lived happily in the lush forest...'", "“昔有三鸟，安居茂林……”");
            // 三鸟合一，化作一体，却仍徒劳地在林间徘徊，寻觅着那所谓的怪物。
            AddTranslation("The three birds, now one, wandered vainly looking for the monster.", "三鸟今合为一，而犹徒行于林，求彼所谓怪者。");
            // 使徒
            AddTranslation("Apostle", "使徒");
            // “汝将舍弃肉身，重获新生。”
            AddTranslation("'Thou wilt abandon flesh and be born again.'", "“汝将舍肌，而复生。”");
            // 巨眼
            AddTranslation("Big Eyes", "巨目");
            // 此卡牌在场期间，场上所有单位均不受力量变动效果影响。
            AddTranslation("While this card is on the board, all creatures on the board are unaffected by Power-changing effects.", "此牌在局，则局上诸物皆不受易威之效。");
            // 此卡牌在场期间，场上所有单位均不受力量变动效果影响。当生命值达到80/60/40时，永久禁用此效果，然后切换阶段。
            AddTranslation("While this card is on the board, all creatures on the board are unaffected by Power-changing effects. Upon reaching 80/60/40 Health, permanently disable this effect then switch phase.", "此牌在局，则局上诸物皆不受易威之效。命至80/60/40，则永废此效，而易其阶段。");
            // 忏悔与救赎
            AddTranslation("Confession and Pentinence", "忏与赎");
            // 怀坚定之心，持不渝之信。
            AddTranslation("Keep faith with unwavering resolve.", "执志不挠，而守其信。");
            // 怀坚定之心，持不渝之信。
            AddTranslation("[c:bG]Keep faith with unwavering resolve.[c:]", "[c:bG]执志不挠，而守其信。[c:]");
            // 光耀
            AddTranslation("Dazzling", "耀");
            // 此卡牌打出的下一回合，可为场上至多3张其他卡牌施加附魔状态。
            AddTranslation("The turn after this card is played, inflict up to 3 other cards on the board with Enchanted.", "此牌既陈之一合后，可使局上他牌至三受附魔。");
            // 如飞蛾扑火，趋之若鹜。
            AddTranslation("Like moths to a flame.", "如蛾赴火。");
            // 长臂
            AddTranslation("Long Arms", "长臂");
            // 此卡牌免疫所有状态异常。
            AddTranslation("This card is immune to status ailments.", "此牌不受诸异状。");
            // 此卡牌免疫所有状态异常。当生命值达到80/60/40时，永久禁用此效果，然后切换阶段。
            AddTranslation("This card is immune to status ailments. Upon reaching 80/60/40 Health, permanently disable this effect then switch phase.", "此牌不受诸异状。命至80/60/40，则永废此效，而易其阶段。");
            // 灭罪
            AddTranslation("Misdeeds Not Allowed", "禁恶");
            // 此卡牌每次受到伤害，在持牌人回合结束前获得1点攻击力。
            AddTranslation("Whenever this card takes damage, gain 1 Power until the end of the owner's turn.", "此牌凡受伤，则威益一，至其主合终。");
            // 小喙
            AddTranslation("Small Beak", "小喙");
            // 回合开始时，随机选定场上一条战线。下一回合开始时，消灭该战线内所有卡牌，此牌除外。
            AddTranslation("At the start of the turn, target a random lane on the board.  At the start of the next turn, kill all cards in the targeted lane, excluding this card.", "合始，偶指局中一列。次合始，尽杀其列诸牌，此牌除外。");
            // 回合开始时，随机选定场上一条战线。下一回合开始时，消灭该战线内所有卡牌，此牌除外。当生命值达到80/60/40时，永久禁用此效果，然后切换阶段。
            AddTranslation("At the start of the turn, target a random lane on the board.  At the start of the next turn, kill all cards in the targeted lane, excluding this card. Upon reaching 80/60/40 Health, permanently disable this effect then switch phase.", "合始，偶指局中一列。次合始，尽杀其列诸牌，此牌除外。命至80/60/40，则永废此效，而易其阶段。");
            // 时间机器
            AddTranslation("Time Machine", "时机");
            // 结束当前战斗或阶段，随后将此牌移出玩家牌库。玩家必须从3张按战力筛选的卡牌中，额外选择1张移出牌库。
            AddTranslation("End the current battle or phase then remove this card from the player's deck. The player must choose an additional card from a selection of 3 to remove from their deck. Selection is based on card power.", "终今战若今阶段，而后去此牌于戏徒牌列。戏徒更须于按牌威所选之三牌中，择一并去之。");
            // 闭上你的双眼，数到十吧。
            AddTranslation("Close your eyes and count to ten.", "阖汝目，而数至十。");
            // 终焉救世主
            AddTranslation("True Saviour", "真救主");
            // “吾之过往，无处安放，无人知晓。”
            AddTranslation("'My story is nowhere, unknown to all.'", "“吾之往事，无所寄，亦无人知。”");
            // 吾即是死亡，亦是生机；既是深渊，亦是曙光。
            AddTranslation("[c:bR]I am death and life. Darkness and light.[c:]", "[c:bR]我即死与生、幽与明也。[c:]");
            // 谬判天平
            AddTranslation("Unjust Scale", "枉衡");
            // 持牌人回合结束时，此牌将对其余所有卡牌施加1层罪孽；持牌人回合开始时，此牌将消灭所有叠加3层及以上罪孽的其他卡牌。
            AddTranslation("At the end of the owner's turn, inflict 1 Sin on all other cards. At the start of owner's turn, kill all other cards with 3+ Sin.", "其主合终，此牌加罪一于他诸牌；其主合始，此牌杀凡有罪三以上之他牌。");
            // 快攻
            AddTranslation("Quick Draw", "先发");
            // 早起的鸟儿有虫吃。
            AddTranslation("The early bird gets the worm.", "先飞之鸟得虫。");
            // 带有此印记的卡牌上场1回合后，将转变为另一种形态。
            AddTranslation("A card bearing this sigil will transform into an alternate forme after 1 turn on the board.", "负此印之牌在局一合，则化为异形。");
            // 精准裁决
            AddTranslation("Marksman", "中的");
            // 你的野兽将精准地发起攻击。
            AddTranslation("Your beast strikes with precision.", "汝兽发击甚精。");
            // 为特殊能力增加规则书条目。
            AddTranslation("Adding rulebook entries for special abilities.", "为异技增律书条。");
            // 所有模组卡牌已禁用，添加标准教学兔兔作为备用方案，以防止出现异常。
            AddTranslation("All mod cards are disabled, adding Standard Training-Dummy Rabbit as a fallback to prevent issues.", "诸补缀牌皆禁，乃加“标准习击兔”为后备，以防有失。");
            // 米拉贝尔
            AddTranslation("Mirabelle", "米拉贝尔");
            // 普西
            AddTranslation("Poussey", "普西");
            // 干细胞-642
            AddTranslation("Stemcell-642", "干细胞-642");
            // 诺亚
            AddTranslation("Noah", "诺亚");
            // 和弓
            AddTranslation("Yumi", "优米");
            // 夏天
            AddTranslation("Summer", "夏");
        }
    }
}
