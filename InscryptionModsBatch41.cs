using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch41
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchFive();
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

        private static void RegisterAllTheSigilsBatchFive()
        {
            // 瘫痪
            AddTranslation("Paralysis", "瘫");
            // [creature]将只在奇数回合攻击。一些印记的效果可能会绕过这一限制。
            AddTranslation("[creature] will only attack every other turn. Some effects from sigils may bypass this.", "[creature]隔合乃攻。诸印之效或能逾此。");
            // 令人震惊的事件。
            AddTranslation("A shocking event.", "骇矣。");
            // 寄生虫
            AddTranslation("Parasite", "寄");
            // [creature]可以放置在任何卡牌上方。若如此做，将合并它们的属性和印记，并创建一个名称组合。
            AddTranslation("[creature] may be placed on top of any card. If it is their sigils and stats will be combined, and a name combination will be created.", "[creature]可陈于诸牌之上。若然，则并其印与数，而成一合名。");
            // 可悲之血
            AddTranslation("Pathetic Sacrifice", "鄙祭");
            // [creature]无法被献祭，且无法被锤击。
            AddTranslation("[creature] is so pathetic, it is not a worthy or noble sacrifice. [creature] is meant to stay on the board, and thus can't be targeted by the hammer.", "[creature]甚鄙，不为堪祀，亦非贵祭。[creature]当留于局，故锤不得指之。");
            // 这不是一个卓越的，或值得的献祭。
            AddTranslation("That is not a noble, or worthy sacrifice", "此非贵祭，亦非堪祀。");
            // 挑肥拣瘦
            AddTranslation("Picky", "择");
            // [creature]不能通过任何免费卡牌作为祭品召唤。
            AddTranslation("[creature] cannnot be summoned by using any free cards as sacrifice.", "[creature]不得以无费牌为牲而召。");
            // 隔山打牛
            AddTranslation("Pierce", "贯");
            // [creature]在声明攻击时，首先攻击其初始目标后面的队列中的卡牌。
            AddTranslation("[creature] attacks the card in queue behind it's initial target first when declaring an attack.", "[creature]宣攻时，先贯其初所攻者之后列之牌。");
            // 我的造物！
            AddTranslation("My creatures!", "吾物！");
            // 剧毒腐蚀
            AddTranslation("Poisonous", "毒");
            // 当[creature]阵亡时，杀死它的卡牌也会阵亡。
            AddTranslation("When [creature] perishes, the creature that killed it perishes as well.", "[creature]死，则杀之者亦死。");
            // 攻击有毒之物，不是明智的选择。
            AddTranslation("Attacking something poisonous, isn't that smart.", "攻毒物，非智也。");
            // 灵魂附身
            AddTranslation("Possessor", "附");
            // 当[creature]阵亡时，它将赋予一个随机友方卡牌基于该卡牌的基础力量和生命的属性。
            AddTranslation("When [creature] perishes, it will grant a random friendly card that is on the board it's base power and health.", "[creature]死，则以其本威与本命授局上一偶友牌。");
            // 它把力量传给剩余的造物。
            AddTranslation("It passes it's strength onto those who remain", "其遗其力于存者。");
            // 强力附身
            AddTranslation("Powerful Possessor", "强附");
            // 当[creature]阵亡时，它将赋予一个随机友方卡牌基于该卡牌的当前力量和生命的属性。
            AddTranslation("When [creature] perishes, it will grant a random friendly card that is on the board it's base plus modified power and base plus modified health.", "[creature]死，则以其今威与今命授局上一偶友牌。");
            // 掠食者
            AddTranslation("Predator", "掠");
            // 当其对位有卡牌时，[creature]将为每个拥有掠食者印记的实例增加1点力量。
            AddTranslation("[creature] will gain 1 power for each instance of Predator, when the opposing slot has a card.", "其对位有牌，则[creature]每因一重掠而威益一。");
            // 骄傲
            AddTranslation("Prideful", "骄");
            // [creature]不会攻击比自己攻击力低2的卡牌。
            AddTranslation("[creature] will not attack a card with a power 2 lower than its own.", "[creature]不攻威下己二之牌。");
            // 一个造物的骄傲就是它的堕落。
            AddTranslation("A creature's pride will be it's downfall.", "物之骄，其败也。");
            // 保护者
            AddTranslation("Protector", "佑");
            // [creature]在场时，攻击相邻卡牌的伤害将改为直接攻击持有者。
            AddTranslation("[creature] will attacks on adjacent allies to hit directly.", "[creature]在局，则攻其邻友者，皆直中其主。");
            // 它们保护它们的盟友，但谁保护你呢？
            AddTranslation("They protect their allies, but who protects you?", "彼护其友，谁护汝？");
            // 木偶之礼
            AddTranslation("Puppets gift", "傀礼");
            // 只要[creature]在场上，任何拥有脆骨印记的卡牌不会因脆骨印记而死亡。
            AddTranslation("As long as [creature] is on the board any cards with brittle won't die because of brittle.", "凡[creature]在局，有脆骨之牌不以脆骨而死。");
            // 史诗祭品
            AddTranslation("Superior Sacrifice", "上祭");
            // [creature]被献祭时被计为4点血量而非1点（此印记对不可献祭的卡牌无效）。
            AddTranslation("[creature] is counted as 4 blood rather than 1 blood when sacrificed.", "[creature]祀时计四血，不一。");
            // 好战之羊
            AddTranslation("Ram", "触");
            // [creature]在放置时将尝试撞击其面前的卡牌，直至成功为止的每个维持阶段。如果此牌在我方，则将攻击的目标送回后方队列；如果在敌方，则会将攻击的目标送回手牌。战斗阶段无效。
            AddTranslation("[creature] will try to ram the card infront of it when played, or every upkeep till it succeeds once. It will send the rammed target to the queue if on my side, or back to the hand if on your side. Does not work during combat.", "[creature]既陈，则尝触其前之牌；不成则每合始复然，至一成而止。此牌若在我侧，则所触者却于后列；若在汝侧，则反之于手。战时无效。");
            // 移动造物？多么粗鲁！
            AddTranslation("Moving creatures around? How Rude!", "移物耶？无礼甚矣！");
            // 无形的移动
            AddTranslation("Random Strafe", "偶移");
            // 抽到[creature]，此印记将随机改为一个移动印记。
            AddTranslation("[creature] is drawn, it will gain a random strafe sigil.", "[creature]既引，则得一偶移印。");
            // 它将如何移动？
            AddTranslation("How will it move?", "其将安移？");
            // 后坐力
            AddTranslation("Recoil", "反震");
            // [creature]每次攻击都会受到1点伤害。
            AddTranslation("[creature] will take 1 damage each time they attack.", "[creature]每攻，受一伤。");
            // 力量使它痛苦。
            AddTranslation("The strength causes the creature pain.", "其威反伤其身。");
            // 再生
            AddTranslation("Regen 1", "复一");
            // 在持牌人回合结束时，[creature]将恢复1点生命值。
            AddTranslation("At the end of the owner's turn, [creature] will regen 1 health.", "持牌者合终，[creature]复一命。");
            // 这个造物将在持牌人回合结束时恢复1点生命值。
            AddTranslation("This creature will heal 1 Health at the end of it's owner's turn.", "此物于其主合终复一命。");
            // 双重再生
            AddTranslation("Regen 2", "复二");
            // 在持牌人回合结束时，[creature]将恢复2点生命值。
            AddTranslation("At the end of the owner's turn, [creature] will regen 2 health.", "持牌者合终，[creature]复二命。");
            // 这个造物将在持牌人回合结束时恢复2点生命值。
            AddTranslation("This creature will heal 2 Health at the end of it's owner's turn.", "此物于其主合终复二命。");
            // 三重再生
            AddTranslation("Regen 3", "复三");
            // 在持牌人回合结束时，[creature]将恢复3点生命值。
            AddTranslation("At the end of the owner's turn, [creature] will regen 3 health.", "持牌者合终，[creature]复三命。");
            // 这个造物将在持牌人回合结束时恢复3点生命值。
            AddTranslation("This creature will heal 3 Health at the end of it's owner's turn.", "此物于其主合终复三命。");
            // 神愈再生
            AddTranslation("Regen", "尽复");
            // 在持牌人回合结束时，[creature]将恢复至满血。
            AddTranslation("At the end of the owner's turn, [creature] will regen to full health.", "持牌者合终，[creature]命尽复。");
            // 这个造物将在持牌人回合结束时恢复全部生命值。
            AddTranslation("This creature will heal to full Health at the end of it's owner's turn.", "此物于其主合终命尽复。");
            // 拒人千里
            AddTranslation("Repellant", "斥");
            // 当[creature]阵亡时，杀死它的造物会被推到后排。
            AddTranslation("When [creature] perishes, the creature that killed it gets pushed into the back row.", "[creature]死，则杀之者却于后列。");
            // 抗性提升
            AddTranslation("Resistant", "耐");
            // [creature]通常只会受到大多数造物的1点伤害。有些效果可能会绕过这一点。
            AddTranslation("[creature] will only ever take 1 damage from most things. Some effects might bypass this.", "[creature]凡所受伤，多不过一；诸效或能逾此。");
            // 它是一个顽强的造物。
            AddTranslation("A hardy creature that one is.", "此物诚强。");
            // 资源丰富
            AddTranslation("Resourceful", "余用");
            // 当[creature]被献祭时，它不会死亡，而是失去自身已有的一个随机印记。资源丰富仅在卡牌上没有其他印记时才会移除自己。
            AddTranslation("When [creature] is sacrificed, instead of dying, it loses a random sigil. Resourceful will only remove itself when there are no other sigils on the card.", "[creature]见祀不死，惟失一偶印；诸印既尽，余用乃自去。");
            // 反戈一击
            AddTranslation("Retaliate", "报击");
            // [creature]将对攻击其相邻卡牌的敌人进行反击。
            AddTranslation("[creature] will strike those who strike their adjacent allies.", "[creature]击诸攻其邻友者。");
            // 右侧爪迹
            AddTranslation("Right scratch", "右爪");
            // 当[creature]攻击时，它还会攻击其右侧的空间。
            AddTranslation("When [creature] attacks it will also attack the space on the right of the attacked slot.", "[creature]攻时，亦及右旁之位。");
            // 急行军
            AddTranslation("Rushing march", "疾行");
            // 在持牌人的回合结束时，[creature]将按印记标注的方向移动，但如果在移动过程中遇到卡牌，[creature]将停止，并且被击中的卡牌将消亡。
            AddTranslation("At the end of its owner's turn, [creature] will move in the direction inscribed on the sigil, however if it hits a card whilst moving, [creature] will stop and the card it hit will perish.", "持牌者合终，[creature]循印所志之向而移；若移时触牌，则止，而所触者死。");
            // 水袭指导
            AddTranslation("Schooling", "同潜");
            // [creature]将赋予拥有水袭印记的造物1点力量。
            AddTranslation("[creature] will grant creatures with the waterborn 1 power.", "[creature]使有潜袭印之物威益一。");
            // 水袭造物团结一心。
            AddTranslation("The waterborn stick together.", "潜者相附。");
            // 当[creature]被召唤时，剪碎一张目标卡牌。
            AddTranslation("When [creature] is played, a targeted card cut in two.", "[creature]既陈，可剖所择一牌为二。");
            // 我的卡牌！
            AddTranslation("My card!", "吾牌！");
            // 损伤易形
            AddTranslation("Shapeshifter", "易形");
            // [creature]一直在变化。一旦被击中，它就会改变形态。
            AddTranslation("[creature] is ever changing. It will change its form once it's struck.", "[creature]常变。见击，则易其形。");
            // 短小精悍
            AddTranslation("Short", "短");
            // [creature]不会被带有空袭印记的造物阻挡。
            AddTranslation("[creature] will not be blocked by an opposing creature bearing the airborn sigil.", "[creature]不为有翔袭之敌物所阻。");
            // 疾病肆虐
            AddTranslation("Sickness", "疾");
            // [creature]每次声明攻击时都会失去1点攻击力。
            AddTranslation("[creature] will loose 1 attack each time it declares an attack.", "[creature]每宣攻，失一威。");
            // 造物的力量在攻击时流失。
            AddTranslation("The creature's strength leaves it as it strikes.", "其击也，威去之。");
            // 骨神
            AddTranslation("Bone lord 6", "骨王六");
            // 当[creature]死亡时，奖励6根骨头，而不是1根。
            AddTranslation("When [creature] dies, 6 bones are rewarded instead of 1.", "[creature]死，则赏骨六，不一。");
            // 缓慢
            AddTranslation("Sluggish", "缓");
        }
    }
}
