using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch74
    {
        public static void RegisterTranslations()
        {
            RegisterWhistleWindAbnormalSigilsOne();
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

        private static void RegisterWhistleWindAbnormalSigilsOne()
        {
            // 得寸进尺
            AddTranslation("Aggravating", "激众");
            // 当[creature]在场上时，所有敌对造物获得1点力量。
            AddTranslation("While this card is on the board, all opposing creatures gain 1 Power.", "[creature]在局，则敌诸物威益一。");
            // 我的野兽被你造物的存在激怒了。
            AddTranslation("My beasts are incensed by your creature's presence.", "我之兽因汝物在而怒。");
            // 炼金术士
            AddTranslation("Alchemist", "炼者");
            // 消耗2点能量以弃掉当前手牌，并抽取等同于弃牌数量的牌。
            AddTranslation("Pay 2 Energy to discard your current hand and draw cards equal to the amount you discarded.", "费能二，以弃今手，而引等数之牌。");
            // 无数承诺的永恒信念。
            AddTranslation("The unending faith of countless promises.", "众诺不穷之信也。");
            // [creature]洗掉了你的手牌替换为新牌！
            AddTranslation("[creature] replaces your hand with a new one!", "[creature]易汝手以新手！");
            // 吸纳者
            AddTranslation("Assimilator", "并纳者");
            // 当[creature]杀死其他卡牌时，它将获得1点力量和1点生命。
            AddTranslation("When this card kills an opposing card, it gains 1 Power and 1 Health.", "[creature]杀敌牌，则威命各益一。");
            // 从万物汲取。
            AddTranslation("From the many, one.", "众归于一。");
            // [creature]使受害者成为自己的一部分。
            AddTranslation("[creature] makes its victim a part of itself.", "[creature]并所害者于己。");
            // 匠心独运
            AddTranslation("Barreler", "辟道");
            // 在持牌人的回合结束时，[creature]将按印记标注的方向移动到场地末端，同时移动途中遇到的任何卡牌。
            AddTranslation("At the end of the owner's turn, this card moves in the sigil's direction to the end of the board, moving any cards in the way.", "持牌者合终，[creature]循印所志而移至局尽，途有诸牌皆徙之。");
            // 创造房间。
            AddTranslation("Make room.", "辟处。");
            // [creature]移动到场地末端，同时抛掷任何挡道的造物。
            AddTranslation("[creature] moves to the end of the board, tossing anything in its way.", "[creature]移至局尽，而掷诸挡道者。");
            // 捆绑打击
            AddTranslation("Binding Strike", "缚击");
            // 当[creature]攻击造物时，施加等同于该卡牌两倍力量的束缚。
            AddTranslation("When [creature] strikes an opposing creature, inflict Bind equal to twice this card's Power.", "[creature]击敌物，则加缚，其数倍此牌之威而二。");
            // 你的野兽落在狼群后面。
            AddTranslation("Your beast falls behind the pack.", "汝兽落群后矣。");
            // 死敌
            AddTranslation("Bitter Enemies", "深仇");
            // 场上每有一张带有此印记的卡牌，[creature]获得1点力量。
            AddTranslation("This card gains 1 Power for each other card on the board that also bears this sigil.", "局中每别有一牌亦负此印，[creature]威益一。");
            // 怨恨显露出来。
            AddTranslation("A bitter grudge laid bare.", "深憾既著。");
            // 血魔
            AddTranslation("Bloodfiend", "血魅");
            // 当[creature]造成伤害时，其获得1点生命值。
            AddTranslation("When this card deals damage, it gains 1 Health.", "[creature]出伤，则命益一。");
            // 被诅咒的恶魔。
            AddTranslation("Accursed fiend.", "被诅之魅。");
            // [creature]吸取新鲜的生命！
            AddTranslation("[creature] sucks out fresh life!", "[creature]啜新生矣！");
            // 血之函
            AddTranslation("Bloodletter", "血引");
            // 当[creature]受到非致命攻击时，从攻击者身上吸取1点生命值。
            AddTranslation("When a [creature] is struck with a nonfatal attack, absorb 1 Health from the striker.", "[creature]见非致命之击，则吸击者一命。");
            // 血液流动温暖，充满甘甜活力。
            AddTranslation("The blood runs warm with sweet vitality.", "血行而温，甘其生也。");
            // [creature]吸收养分！
            AddTranslation("[creature] absorbs nutrients!", "[creature]吸其养矣！");
            // 母巢
            AddTranslation("Broodmother", "孳母");
            // 当[creature]受到攻击时，在你的手上创造一只幼蛛。[define:wstl_spiderling]
            AddTranslation("When [creature] is struck, create a Spiderling in your hand. [define:wstl_spiderling]", "[creature]见击，则汝手中生一幼蛛。[define:wstl_spiderling]");
            // 一只小蜘蛛躲在你手里。
            AddTranslation("A small spider takes refuge in your hand.", "有小蛛避于汝手。");
            // [creature]掉落了一只小蜘蛛！
            AddTranslation("[creature] drops a spiderling!", "[creature]落一幼蛛！");
            // 交响乐指挥
            AddTranslation("Conductor", "指乐者");
            // 当[creature]在场上时，此印记的效果会在接下来的3个回合中不断改变。
            AddTranslation("The effect of this sigil will change over the next 3 turns while this card is on the board.", "[creature]在局，则此印之效于后三区回合更易。");
            // 从破碎和毁灭中，最美的演出起始。
            AddTranslation("From break and ruin, the most beautiful performance begins.", "破败之中，美奏始焉。");
            // [creature]演奏寂静的交响乐。
            AddTranslation("[creature] plays a quiet symphony.", "[creature]奏其静乐。");
            // 模仿者
            AddTranslation("Copycat", "拟者");
            // [creature]将转变为第一个对位它的造物的副本。
            AddTranslation("[creature] will transform into a copy of the first creature that opposes it.", "[creature]将化为初与之对位者之副。");
            // 近乎完美的模仿。
            AddTranslation("A near perfect impersonation.", "几全之拟也。");
            // [creature]试图模仿对位的造物。
            AddTranslation("[creature] tries to mimick the opposing creature.", "[creature]尝拟其对物。");
            // 校正者
            AddTranslation("Corrector", "校者");
            // 当[creature]被抽取时，根据其花费成本随机更改其属性值。
            AddTranslation("When [creature] is drawn, randomly change its stats according to its total play cost.", "[creature]既引，则随其总直而偶易其数。");
            // 如何平衡。
            AddTranslation("How balanced.", "均矣。");
            // [creature]属性被强制“修正”。
            AddTranslation("[creature] stats are forcefully 'corrected'.", "[creature]之数见强校矣。");
            // 无所畏惧
            AddTranslation("Courageous", "勇");
            // 与[creature]相邻的造物会损失至多2点生命值。每损失1点生命值，受影响的造物就会获得1点力量。此效果不会消灭卡牌。
            AddTranslation("Creatures adjacent to this card lose up to 2 Health. For each point of Heath lost, the affected creature gains 1 Power. This effect cannot kill cards.", "与[creature]相邻之物，命至多损二；每损一命，则威益一。此效不至杀牌。");
            // 生命只属于那些不惧怕死亡的人。
            AddTranslation("Life is only given to those who don't fear death.", "命惟授不惧死者。");
            // 诅咒
            AddTranslation("Cursed", "诅");
            // 当[creature]死亡时，杀死此牌的牌会变成这张卡牌的副本。
            AddTranslation("When [creature] dies, the killer transforms into a copy of this card.", "[creature]死，则杀之者化为此牌之副。");
            // 诅咒有增无减。
            AddTranslation("The curse continues unabated.", "诅延而不息。");
            // [creature]将会继续诅咒。
            AddTranslation("[creature] passes the curse on.", "[creature]传其诅矣。");
            // 循环器
            AddTranslation("Cycler", "环行者");
            // 在持牌人的回合结束时，[creature]会向印记标注的方向移动，在场上持牌人一侧循环。
            AddTranslation("At the end of the owner's turn, this card moves in the sigil's direction, looping around the owner's side of the board.", "持牌者合终，[creature]循印所志而移，环行于其主场侧。");
            // 一个永无止境的循环。
            AddTranslation("A never-ending cycle.", "无竟之环。");
            // [creature]移动到一个新的空间，绕过场地的边缘。
            AddTranslation("[creature] moves to a new space, going around its side of the board.", "[creature]移于新位，而循其侧而转。");
            // 虚伪王座
            AddTranslation("False Throne", "假座");
            // 每回合限一次，消耗1点生命值然后选定一个造物，然后在你手中创建一个免费的、未更改的副本。
            AddTranslation("Once per turn, pay 1 Health to give Neutered to a chosen creature, then create a free, unaltered copy of it in your hand.", "每合一次，费一命，使所择一物得绝育印，而后于汝手中生其无费未改之副。");
            // 一个简单的小魔术。
            AddTranslation("A simple little magic trick.", "小术耳。");
            // [creature]给被选中的造物一份仿制品。
            AddTranslation("[creature] gives a false present to the chosen creature.", "[creature]以伪赠授所择者。");
            // 旗手力量
            AddTranslation("Flag Bearer", "旗手");
            // 当[creature]在场上时，相邻的造物获得2点生命值。
            AddTranslation("While this card is on the board, adjacent creatures gain 2 Health.", "[creature]在局，则邻物命益二。");
            // 士气高涨。
            AddTranslation("Morale runs high.", "气正盛也。");
            // 冰霜统领
            AddTranslation("Ruler of Frost", "霜主");
            // 每回合限一次，消耗2根骨头选择一个场上位置。如果位置为空，则创建一块冰块。否则，如果这张牌可以杀死占位牌，将其变成一颗冰封之心。冰封之心具有：0点力量，2点生命，高跳。
            AddTranslation("Once per turn, pay 2 Bones to choose a space on the board. If the space is empty, create a Block of Ice. Otherwise, if this card can kill the occupying card, transform it into a Frozen Heart.", "每合一次，费二骨择局上一位。其位若空，则生冰块；不然，若此牌能杀所居者，则化之为冰心。");
            // 冰雪女王挥了挥手，挡住了去路。
            AddTranslation("With a wave of her hand, the Snow Queen blocked the path.", "雪后挥手，而塞其途。");
            // [creature]冻结了路径。
            AddTranslation("[creature] freezes the path.", "[creature]冰其途矣。");
            // 冰封之心
            AddTranslation("Frozen Heart", "冰心");
            // 杀死[creature]的牌获得2点生命值。
            AddTranslation("When [creature] dies, the killer gains 2 Health.", "[creature]死，则杀之者命益二。");
            // 春天来了，玫瑰花开了。
            AddTranslation("Spring arrives with blossoming roses.", "春至而玫开。");
            // [creature]释放温暖的生命。
            AddTranslation("[creature] releases warm life.", "[creature]释其温生。");
            // 园丁
            AddTranslation("Gardener", "圃者");
            // 当一张同盟卡牌被杀死时，在其位置创建一颗树苗。[define:wstl_parasiteTreeSapling]
            AddTranslation("When an allied card is killed, create a Sapling in their place. [define:wstl_parasiteTreeSapling]", "一盟牌死，则其位生一树苗。[define:wstl_parasiteTreeSapling]");
            // 它们增殖并变得完整。你能感觉到吗？
            AddTranslation("They proliferate and become whole. Can you feel it?", "其滋殖而成全，汝能觉乎？");
            // 一棵小树从死亡的卡牌尸体上长了出来。
            AddTranslation("A sapling grows out of the dead card's corpse.", "有树苗出于死牌之尸。");
            // 赠礼者
            AddTranslation("Gift Giver", "与礼者");
            // 放置[creature]时，你获得一张随机的牌。
            AddTranslation("When [creature] is played, create a random card in your hand.", "[creature]既陈，则汝手中生一偶牌。");
            // 一个给你的礼物。
            AddTranslation("A gift for you.", "以礼与汝。");
            // [creature]有一个礼物要给你！
            AddTranslation("[creature] has a gift for you!", "[creature]有礼与汝！");
        }
    }
}
