using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch75
    {
        public static void RegisterTranslations()
        {
            RegisterWhistleWindAbnormalSigilsTwo();
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

        private static void RegisterWhistleWindAbnormalSigilsTwo()
        {
            // 贪婪之愈
            AddTranslation("Greedy Healing", "贪愈");
            // 在持有者的回合结束时，[creature]获得2点生命值。如果两回合内[creature]没有受到攻击，它将死亡。
            AddTranslation("At the end of its owner's turn, this card gains 2 Health. If 2 turns pass without this card taking damage, it will die.", "其主合终，[creature]命益二；二合不见伤，则死。");
            // 你的野兽有过量生命。
            AddTranslation("Your beast has Health in excess.", "汝兽命过盈矣。");
            // [creature]给予自己更多生命！
            AddTranslation("[creature] gives itself more Health!", "[creature]自益其命！");
            // 粉碎机
            AddTranslation("Grinder", "磨者");
            // [creature]将获得为放置它而献祭的造物属性。
            AddTranslation("This card gains the stats of the creatures sacrificed to play it.", "[creature]得其所由祀而陈之物之数。");
            // 现在一切都会好起来的。
            AddTranslation("Now everything will be just fine.", "今万事将善矣。");
            // 团队治疗师
            AddTranslation("Group Healer", "群疗者");
            // 在持牌人的回合开始时，[creature]将治愈所有受伤盟友1点生命。
            AddTranslation("At the start of its owner's turn, this card will heal all allies that have taken damage by 1 Health.", "持牌者合始，[creature]疗诸伤友各一命。");
            // 你只会拖延不可避免的事情。
            AddTranslation("You only delay the inevitable.", "汝徒缓其必至耳。");
            // [creature]能治愈所有的盟友。
            AddTranslation("[creature] heals all its friends.", "[creature]疗其诸友。");
            // 治疗师
            AddTranslation("Healer", "疗者");
            // 在持牌人回合结束时，其可以选择一张其他卡牌，恢复该牌2点生命。
            AddTranslation("At the end of your turn, you may choose one of your other cards to heal by 2 Health.", "持牌者合终，可择他牌之一，疗之二命。");
            // 永远不要低估治疗师的重要性。
            AddTranslation("Never underestimate the importance of a healer.", "毋轻疗者之重。");
            // [creature]治愈被选中的造物！
            AddTranslation("[creature] heals the chosen creature!", "[creature]疗所择之物！");
            // 高度紧张
            AddTranslation("High-Strung", "劲张");
            // 在当前回合结束时，[creature]将获得的匆忙值等于对位卡牌力量的两倍。
            AddTranslation("At the end of the current turn, this card gains Haste equal to twice the opposing card's Power.", "今合终，[creature]得疾，其数倍对牌之威而二。");
            // 偶像
            AddTranslation("Idol", "偶");
            // 当[creature]在场上时，所有敌对造物都会失去1点力量。
            AddTranslation("While this card is on the board, all opposing creatures lose 1 Power.", "[creature]在局，则敌诸物威减一。");
            // 我的野兽听命于你。
            AddTranslation("My beasts defer to you.", "我之兽皆从汝。");
            // 偏左打击
            AddTranslation("Left-Veering Strike", "左偏击");
            // [creature]的攻击将始终在正常位置左侧一格。
            AddTranslation("[creature] will strike the opposing space to the left of the space across from it.", "[creature]常击其正对之左位。");
            // 偏右打击
            AddTranslation("Right-Veering Strike", "右偏击");
            // [creature]的攻击将始终在正常位置右侧一格。
            AddTranslation("[creature] will strike the opposing space to the right of the space across from it.", "[creature]常击其正对之右位。");
            // 孤独
            AddTranslation("Lonely", "孤");
            // 除非已经存在一张带有卵石的牌，否则选择在场一张牌以获得1个卵石，然后[creature]将回到你手中。如果带有卵石的卡牌死亡，所有友方卡牌将受到1点额外伤害，直到选择新牌为止。
            AddTranslation("Choose a card on the board to gain 1 Pebble unless a card with Pebble already exists, then return this card to your hand. If a card with Pebble dies, all ally cards receive 1 additional damage until a new card is chosen.", "若局中未有卵石印，则择一牌使得卵石，而后[creature]归汝手。若负卵石之牌死，则诸友牌皆多受一伤，至更择新牌。");
            // 留下来一位朋友。
            AddTranslation("A friend to stay.", "留一友焉。");
            // 烈士
            AddTranslation("Martyr", "死义");
            // 当[creature]死亡时，所有友方造物获得2点生命并失去所有负面状态效果。
            AddTranslation("When [creature] dies, all allied creatures gain 2 Health and lose any negative status effects.", "[creature]死，则诸友物命益二，并去其诸负效。");
            // 无私的死亡，净化你造物的邪恶。
            AddTranslation("A selfless death to cleanse your beasts of evil.", "无私之死，以涤汝诸物之秽。");
            // [creature]的死亡会净化你的其他造物！
            AddTranslation("[creature]'s death cleanses your other creatures!", "[creature]之死净汝他物矣！");
            // 荨麻衣
            AddTranslation("Nettle Clothes", "荨衣");
            // 当放置[creature]时，用随机的兄弟卡牌填补场上持牌人一侧的所有空位。[creature]获得每个友方兄弟卡牌的首个印记。
            AddTranslation("When this card is played, fill all empty spaces on the owner's side of the board with random Brothers. This card gains the first sigil of each allied Brother.", "[creature]既陈，则其主场侧诸空位尽满以偶兄弟；[creature]并得诸友兄弟之首印。");
            // 这些衣服一定会让我们恢复快乐的时光。
            AddTranslation("These clothes will surely restore our happy days.", "此衣必使我等乐时复还。");
            // [creature]带出了它的家人！
            AddTranslation("[creature] brings out its family!", "[creature]引其家人矣！");
            // 绝育
            AddTranslation("Neutered", "绝育");
            // [creature]的力量降低至0。在持牌人的回合开始时，此印记将被删除。
            AddTranslation("[creature] has its Power reduced to 0. At the start of the owner's turn, remove this sigil.", "[creature]之威降为零；其主合始，此印乃去。");
            // 绝育激转
            AddTranslation("Neutered Latch", "绝育遗契");
            // 每回合限一次，消耗[sigilcost:2根骨头]选择一个造物来获得绝育印记，然后将此印记的激活成本增加1根骨头。
            AddTranslation("Once per turn, pay [sigilcost:2 Bones] to choose a creature to gain the Neutered sigil, then increase this sigil's activation cost by 1 Bone.", "每合一次，费[sigilcost:2 Bones]择一物使得绝育印，而后此印启直益骨一。");
            // 每回合限一次，消耗1根骨头，然后将此印记的激活成本增加1根骨头。
            AddTranslation("Once per turn, pay 1 bone to choose a creature to gain the Neutered sigil, then increase this sigil's activation cost by 1 Bone.", "每合一次，费骨一，择一物使得绝育印，而后此印启直益骨一。");
            for (int count = 0; count <= 100; count++)
            {
                // 每回合限一次，消耗{count}根骨头，然后将此印记的激活成本增加1根骨头。
                AddTranslation("Once per turn, pay " + count.ToString() + " bones to choose a creature to gain the Neutered sigil, then increase this sigil's activation cost by 1 Bone.", "每合一次，费骨" + count.ToString() + "，择一物使得绝育印，而后此印启直益骨一。");
            }
            // 战斗的意志已经丧失。
            AddTranslation("The will to fight has been lost.", "战志已丧。");
            // [creature]阻止被选中的造物攻击。
            AddTranslation("[creature] prevents the chosen creature from attacking.", "[creature]遏所择之物使不得攻。");
            // 灵巧之足
            AddTranslation("Nimble-Footed", "捷足");
            // 在持牌人的回合开始时，[creature]获得2点匆忙值。
            AddTranslation("At the start of the owner's turn, this card gains 2 Haste.", "持牌者合始，[creature]得疾二。");
            // 机会主义
            AddTranslation("Opportunistic", "乘机");
            // [creature]对在自己回合中无法攻击此牌的对手卡牌造成1点额外伤害。
            AddTranslation("[creature] deals 1 additional damage to opposing cards that cannot attack this card during their own turn.", "[creature]于彼回合中不能攻此牌之敌牌，多受其一伤。");
            // 一次廉价的攻击。
            AddTranslation("A cheap hit.", "乘隙之一击。");
            // 迫害者
            AddTranslation("Persecutor", "迫者");
            // 当放置[creature]时，若相邻的左侧和右侧位置均为空，则分别在左侧和右侧空位上创建一个钉子和一把锤子。
            AddTranslation("When a card bearing this sigil is played, create a Nail in the adjacent left space and a Hammer in the adjacent right space if they are empty.", "负此印之牌既陈，若左右邻位空，则左生钉，右生槌。");
            // 你是否为自己封闭的心感到内疚？
            AddTranslation("Are you guilty of having a closed heart?", "汝于闭心有愧乎？");
            // [creature]露出了它隐藏的工具！
            AddTranslation("[creature] reveals its hidden tools!", "[creature]发其藏器矣！");
            // 坚持不懈
            AddTranslation("Persistent", "穷追");
            // 类似断尾求生和水袭这样的印记无法避免或转移[creature]的攻击。
            AddTranslation("Attacks by this card cannot be avoided or redirected by sigils like Loose Tail or Waterborne.", "[creature]之攻，不可为断尾、潜袭诸印所避易。");
            // 猎物可没那么容易藏匿自己。
            AddTranslation("Prey cannot hide so easily.", "猎不得易匿。");
            // [creature]追捕猎物。
            AddTranslation("[creature] chases its prey down.", "[creature]穷逐其猎。");
            // [creature]造成的伤害无法被身披坚甲或茂密皮毛等防御印记所抵消或减少。
            AddTranslation("Damage dealt by this card cannot be negated or reduced by sigils such as Armoured or Thick Skin.", "[creature]所出之伤，不可为坚甲、厚皮诸印所消减。");
            // 你的野兽把我撕碎了。
            AddTranslation("Your beast runs mine through.", "汝兽洞贯我矣。");
            // 与[creature]相邻的造物在被攻击时受到的伤害减少1点。
            AddTranslation("Creatures adjacent to this card take 1 less damage when struck.", "邻于[creature]之物见击，则其伤少一。");
            // 你的野兽为友方抵挡攻击。
            AddTranslation("Your beast shields its ally against the blow.", "汝兽蔽其友以当击。");
            // [生物]为它的友方提供保护！
            AddTranslation("[creature] shields its friend!", "[creature]蔽其友矣！");
            // 惩罚者
            AddTranslation("Punisher", "罚者");
            // 当[creature]被击中时，攻击者会被杀死。
            AddTranslation("When [creature] is struck, the striker is killed.", "[creature]见击，则击者死。");
            // 报复行动迅速且残忍。
            AddTranslation("Retaliation is switft and brutal.", "报速而酷。");
            // [creature]迅速反击！
            AddTranslation("[creature] swiftly retaliates!", "[creature]速报之！");
            // 蜂后
            AddTranslation("Queen Nest", "蜂后");
            // [creature]在场时，每当有其他卡牌被消灭时，在你的手牌中生成一只工蜂。[define:wstl_queenBeeWorker]
            AddTranslation("Whenever another card is killed, create a Worker Bee in your hand. [define:wstl_queenBeeWorker]", "他牌死时，汝手中生一工蜂。[define:wstl_queenBeeWorker]");
            // 为了蜂巢。
            AddTranslation("For the hive.", "为其巢也。");
            // 另一工人天生就是为了服务[creature]而存在的。
            AddTranslation("Another worker is born to serve [creature].", "又一工蜂生以事 [creature]。");
            // 反射者
            AddTranslation("Reflector", "返者");
            // 当[creature]被击中时，攻击者会受到与其力量值相等的伤害。
            AddTranslation("When this card is struck, the striker is dealt damage equal to the striker's Power.", "[creature]见击，则击者受其威等数之伤。");
            // 一报还一报。
            AddTranslation("What goes around comes around.", "反报其身。");
            // [creature]返还了伤害。
            AddTranslation("[creature] returns the damage.", "[creature]返其伤矣。");
            // 牌组重塑
            AddTranslation("Refresh Decks", "更牌列");
            // 将主牌堆和副牌堆的牌组重塑。
            AddTranslation("Refreshes and reshuffles both draw piles.", "更而复乱主副二牌堆。");
            // 在持牌人的回合开始时，[creature]会治愈相邻卡牌1点生命。
            AddTranslation("At the start of its owner's turn, this card heals adjacent cards by 1 Health.", "持牌者合始，[creature]疗邻牌一命。");
            // 伤口会愈合，但疤痕依然存在。
            AddTranslation("Wounds heal, but the scars remain.", "疮可愈，而痕犹存。");
        }
    }
}
