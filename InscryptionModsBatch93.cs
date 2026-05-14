using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch93
    {
        public static void RegisterTranslations()
        {
            RegisterPlantsVsZombiesTwo();
            RegisterSmallTweakHydraOne();
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

        private static void RegisterPlantsVsZombiesTwo()
        {
            for (int count = 0; count <= 100; count++)
            {
                // 添加植物大战僵尸的卡牌，以及自定义的阳光成本。包含{count}张新卡牌。
                AddTranslation("Adds plants vs zombies cards to the mix, with a custom sun currency too. Contains " + count.ToString() + " new cards.", "益以植物战僵尸之牌，亦设自定日芒之费。凡" + count.ToString() + "新牌。");
            }
            // 原始种子
            AddTranslation("The original seeds", "原种");
            // 午夜员工
            AddTranslation("The midnight crew", "夜半众");
            // 禅境花园
            AddTranslation("The Zen Garden", "禅园");
            // 附加状态
            AddTranslation("Add Stats", "益数");
            // 当[creature]被放置时，它的生命、攻击和其他印记将被添加到持牌人一侧的每一张非地形卡上。然后此牌将被销毁。[creature]不能用于印记转移或篝火。
            AddTranslation("When [creature] is played, its health, attack, and other sigils will be added to every other non terrain card on your side of the board. Then this card will perish. Cards bearing this sigil cannot be used in sigil transfers or campfires.", "[creature]既陈，其命、威与余印契皆加于汝侧诸非地形牌。既而此牌死。负此印契之牌，不得用于转印与营火。");
            // 团队合作的力量
            AddTranslation("The power of teamwork", "协力之功。");
            // 附加对手状态
            AddTranslation("Add Stats Opponent", "益敌数");
            // 当[creature]被放置时，它的生命、攻击和其他印记将被添加到持牌人对手一侧的每一张非地形卡上。然后此牌将被销毁。[creature]不能用于印记转移或篝火。
            AddTranslation("When [creature] is played, its health, attack, and other sigils will be added to every card on the opposing side of the board. Then this card will perish. Cards bearing this sigil cannot be used in sigil transfers or campfires.", "[creature]既陈，其命、威与余印契皆加于敌侧诸牌。既而此牌死。负此印契之牌，不得用于转印与营火。");
            // 消灭你的敌人
            AddTranslation("Blight your foes", "殃汝敌。");
            // 装甲破坏者
            AddTranslation("Armor breaker", "破甲");
            // 当放置[creature]时，其将移除所有对手卡牌的防御型印记。
            AddTranslation("When [creature] is played, it removes all defense sigils from all of the opposing cards.", "[creature]既陈，尽去敌牌诸御印。");
            // 破甲是一种很好的进攻方式
            AddTranslation("Removing defense is a great offense", "去其御，善攻也。");
            // 末日使者
            AddTranslation("DoomBringer", "赍末");
            // 持牌人的结束时，[creature]将爆炸，对对手的所有卡牌造成7点伤害，对所有持牌人的卡牌造成1点伤害。
            AddTranslation("At the end of the owner's turn, [creature] will explode and deal 7 damage to all of the opponent's cards, along with 1 damage to all of the owners cards.", "持者合终，[creature]爆，伤敌诸牌七，兼伤其主诸牌一。");
            // 只有毁灭才会随之而来。
            AddTranslation("Only destruction lays in its wake", "其后惟毁。");
            // 逐渐消失
            AddTranslation("Fade Away", "渐灭");
            // 在持牌人的结束时，[creature]将受到1点伤害。
            AddTranslation("At the end of the owner's turn, [creature] will take 1 damage.", "持者合终，[creature]受一伤。");
            // 没有什么是永恒的
            AddTranslation("Nothing can last forever", "无有能久者。");
            // 头脑冷静
            AddTranslation("Hard Headed", "坚首");
            // 当[creature]受到攻击时，受到的伤害将减少2。然后，此印记将被移除。
            AddTranslation("When [creature] is attacked, the damage taken will be reduced by 2. Then this sigil will be removed.", "[creature]见攻，则所受之伤减二。既而去此印契。");
            // 头盔在防护方面出奇地优秀。
            AddTranslation("Headwear is surprisingly good at negating wounds", "首具御伤，异乎其善。");
            // 魅惑师
            AddTranslation("Hypnotist", "惑心");
            // 当[creature]被击败时，杀死它的卡牌会移动到它的位置。
            AddTranslation("When [creature] gets defeated, its killer will move to take its place.", "[creature]既败，杀之者移而据其处。");
            // 想想背叛这么容易发生。
            AddTranslation("To think that betrayal can happen so easily", "叛乃如此易生。");
            // 穿透打击
            AddTranslation("Pierce", "贯");
            // 在攻击之前，[creature]会先攻击对方队列中的卡牌，同时也会使其护甲印记失效。
            AddTranslation("Before attacking, [creature] attacks the given card in the opposing queue, it also nullifies the Armored sigil.", "将攻之前，[creature]先击敌列所指之牌，且废其坚甲印契。");
            // 躲在后面并不能保护你
            AddTranslation("Hiding in the back doesn't protect you here", "匿于后，不足自全。");
            // 火爆之辣
            AddTranslation("Spicy", "辛爆");
            // 在持牌人的回合结束时，[creature]将爆炸并对对位卡牌和其后方卡牌造成4点伤害。带有此印记的卡牌不能用于印记转移或篝火。
            AddTranslation("At the end of the owner's turn, [creature] will explode and deal 4 damage to the opposing card and to the card on the opposing backline. Cards bearing this sigil cannot be used in sigil transfers or campfires.", "持者合终，[creature]爆，伤其对位之牌与其后列之牌各四。负此印契之牌，不得用于转印与营火。");
            // 我从来都不太喜欢香料
            AddTranslation("I've never been too fond of spice", "我素不甚好辛。");
            // 孢子生殖
            AddTranslation("Spore Spreader", "散孢");
            // 如果[creature]击败另一张牌，你将获得一张[creature]的副本。
            AddTranslation("If [creature] defeats another card, a copy of itself will be returned to your hand.", "[creature]若败他牌，则一其副本归汝手。");
            // 这些孢子会传播多少？
            AddTranslation("just how much will these spores spread?", "此孢所散几何？");
            // 土豆泥
            AddTranslation("Spudow", "薯爆");
            // 当[creature]被击败时，它会对对位卡牌造成4点伤害。
            AddTranslation("When [creature] gets defeated, it deals 4 damage to the opposing card.", "[creature]既败，则伤其对位之牌四。");
            // 在土豆地里一定要小心脚下
            AddTranslation("Always watch your step in a potato field", "行薯畦间，常慎乃步。");
            // 芬芳
            AddTranslation("Sweet", "甘爆");
            // 在持牌人的回合结束时，[creature]将爆炸并对其周围3个敌方槽位中的卡牌造成3点伤害，然后对相邻插槽中的卡牌造成1点伤害。带有此印记的卡牌不能用于印记转移或篝火。
            AddTranslation("At the end of the owner's turn, [creature] will explode and deal 3 damage to the cards in the 3 enemy slots around it, then deal 1 damage to the cards in your adjacent slots. Cards bearing this sigil cannot be used in sigil transfers or campfires.", "持者合终，[creature]爆，伤其四遭三敌位之牌各三，复伤汝相邻位之牌各一。负此印契之牌，不得用于转印与营火。");
            // 也许比预期的更尖刻。
            AddTranslation("Maybe there's a bit more tartness than anticipated", "或其酸厉过所期。");
            // 胆小
            AddTranslation("Scaredy", "怯");
            // [creature]在面对攻击力大于0的对手卡牌时，会失去1点攻击力，但会获得1点生命值，直至对位卡牌离开。
            AddTranslation("[creature] loses 1 attack but gains 1 health when against an opposing card whose attack is greater than 0, unless the opposing card retreats too.", "[creature]当敌对之牌威大于零而与之相直，则失一威而得一命；彼牌若退，则止。");
            // 他们称之为战术撤退
            AddTranslation("They call it a tactical retreat", "人谓之权退。");
            // 僵尸号召
            AddTranslation("Zombie Caller", "召尸");
            // 当[creature]被放置时，将在其两侧空位上生成僵尸，尽管它可能有头饰。[define:zep_pvz_zombie]
            AddTranslation("When [creature] is played, A zombie gets played on each empty adjacent space, though it may have headgear. [define:zep_pvz_zombie]", "[creature]既陈，则两旁空处各生一尸；其尸或有首具。[define:zep_pvz_zombie]");
            // 一大波僵尸即将来袭！
            AddTranslation("A huge wave of zombies is approaching", "大群尸将至！");
            // 蘑菇力量
            AddTranslation("Shrooms", "蕈数");
            // 此印记表示的值将等于持牌人一侧的蘑菇数量。
            AddTranslation("The value represented with this sigil will be equal to the number of mushrooms that the owner has on their side of the table.", "此印所表之数，如其主持侧诸蕈之数。");
        }

        private static void RegisterSmallTweakHydraOne()
        {
            // [creature]在抽取时的孵化条件如下：你的牌组中的造物的生命和力量包含5个不同的数字，且有至少来自5个不同族群的造物各一张（所有带有此印记的卡牌将不会纳入此印记的计算）。
            AddTranslation("A card bearing this Sigil hatches when drawn if 5 unique numbers are in the Health of creatures in your deck, and in their Power, and if there is a creature of 5 unique tribes in your deck. [This Excludes all cards bearing this sigil]", "负此印契之牌，引而孚之：若汝牌列中诸物之命有五异数，威亦有五异数，又有五异族之物各一。〔凡负此印契者，不豫其数。〕");
        }
    }
}
