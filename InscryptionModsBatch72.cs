using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch72
    {
        public static void RegisterTranslations()
        {
            RegisterEndlessActTwoOne();
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

        private static void RegisterEndlessActTwoOne()
        {
            // 选择要使用的牌组。这将覆盖你当前的牌组！
            AddTranslation("SELECT A DECK TO USE.\nTHIS WILL OVERRIDE YOUR CURRENT DECK!", "择一牌列以用。\n此将覆汝今之牌列！");
            for (int score = 0; score <= 100; score++)
            {
                // 最高分：{score}
                AddTranslation("High Score: " + score.ToString(), "至高分：" + score.ToString());
            }
            // 已拾取新牌组。
            AddTranslation("Picked up your new deck.", "已取新牌列。");
            // 这张卡牌已加入你的牌库。
            AddTranslation("The card was added to your collection.", "此牌已入汝藏。");
            // 啊
            AddTranslation("buh", "啊");
            // 选择一种卡牌。
            AddTranslation("Choose a card type.", "择一牌类。");
            // 你的牌组至少需要20张卡牌！
            AddTranslation("You need at least 20 cards in your deck!", "汝牌列至少须二十牌！");
            // ……
            AddTranslation("...", "……");
            // 不错的祭品。
            AddTranslation("Good offering.", "祭善矣。");
            // 拿去吧。
            AddTranslation("Have this.", "取之。");
            // 你可以选择在此合并两张卡牌。
            AddTranslation("You have a choice of merging two cards here..", "汝可于此并两牌。");
            // 赏金
            AddTranslation("Bounty", "购赏");
            // 每3次战斗胜利，你就获得一颗悬赏星星。随着悬赏星星的增加，随机的赏金猎人将开始出现在战斗中。
            AddTranslation("Every 3 succesful battles, you gain a bounty star. With bounty stars, random bounty hunters will start to spawn in battles.", "每三战而胜，汝得购赏一星。星既增，则购捕者将偶出于战。");
            // 奖励
            AddTranslation("Boon", "惠");
            // 你只能装备一张奖励卡牌。
            AddTranslation("You have only one boon slot.", "汝惟一惠位。");
            // 精英
            AddTranslation("Elite", "精魁");
            // 每一次常规的卡牌战斗都会被精英战斗所取代。
            AddTranslation("Every regular card battle is replaced with an elite battle.", "诸常牌战，皆为精魁战所易。");
            // 放弃缝合
            AddTranslation("Don't merge.", "毋并之。");
            // 缝合田鼠
            AddTranslation("Merge Field Mice", "并田鼠");
            // 缝合哨兵无人机
            AddTranslation("Merge Sentry Drone", "并哨机");
            // 缝合蓝色法师
            AddTranslation("Merge Blue Mage", "并蓝巫");
            // 缝合掘墓人
            AddTranslation("Merge Gravedigger", "并掘墓者");
            // 你可以选择在此处缝合两张卡牌……
            AddTranslation("You have a choice of merging two cards here..", "汝可于此并两牌……");
            // 选择{}牌组？
            AddTranslation("Select the {} deck?", "择{}牌列乎？");
            // 选择野兽牌组？
            AddTranslation("Select the Deck of Beasts?", "择兽牌列乎？");
            // 选择死亡牌组？
            AddTranslation("Select the Deck of the Dead?", "择死牌列乎？");
            // 选择科技牌组？
            AddTranslation("Select the Deck of Technology?", "择机牌列乎？");
            // 选择魔法牌组？
            AddTranslation("Select the Deck of Magick?", "择术牌列乎？");
            // 拿起你的牌组。
            AddTranslation("Take the deck.", "取其牌列。");
            // 离开这里。
            AddTranslation("Leave it.", "舍之。");
            // 你的牌组至少需要20张牌！
            AddTranslation("You need at least 20 cards in your deck!", "汝牌列至少须二十牌！");
            // 你的牌组中没有祭品？
            AddTranslation("No offering in your deck?", "汝牌列中无祭乎？");
            // 好吧，拿这个代替。
            AddTranslation("Fine. Take this instead.", "然则取此以代之。");
            // 什么？你还想要更多吗？
            AddTranslation("What? You still crave more?", "何？汝犹欲更多乎？");
            // 好吧，拿上这个。
            AddTranslation("Fine. Take this.", "然，则取此。");
            // 转世轮回
            AddTranslation("Reincarnation", "轮回");
            // 电压
            AddTranslation("Voltage", "电压");
            // 构筑
            AddTranslation("Construct", "构");
            // 化石
            AddTranslation("Fossil", "化石");
            // 赏金猎人
            AddTranslation("BountyHunter", "购捕者");
            // 魔法
            AddTranslation("Nuzlocke", "死锁");
            // 幸运之奖
            AddTranslation("Boon of Luck", "幸运之惠");
            // 每一场战斗开始时获得一张三叶草。
            AddTranslation("Start each battle with a clover.", "每战始得一苜蓿。");
            // 当装备该奖励时，每一场战斗开始时获得一张三叶草。
            AddTranslation("With this boon equipped, Start each battle with a clover.", "有此惠，则每战始得一苜蓿。");
            // 血肉之奖
            AddTranslation("Boon of Flesh", "血肉之惠");
            // 玛珂牌可以被献祭。
            AddTranslation("Mox may be sacrificed.", "玛珂可见祀。");
            // 当装备该奖励时，玛珂牌可以被献祭。
            AddTranslation("With this boon equipped, Mox may be sacrificed.", "有此惠，则玛珂可见祀。");
            // 脉冲之奖
            AddTranslation("Boon of Voltage", "电势之惠");
            // 当你献祭一张野兽卡牌时，你将增加你的最大能量并获得一个能量槽。
            AddTranslation("When you sacrifice a beast card, you increase your max energy and gain an energy cell.", "汝祀一兽牌，则能极益，而得一能格。");
            // 当装备该奖励时，当你献祭一张野兽卡牌时，你将增加你的最大能量并获得一个能量槽。
            AddTranslation("With this boon equipped, When you sacrifice a beast card, you increase your max energy and gain an energy cell.", "有此惠，则汝祀一兽牌，能极益，而得一能格。");
            // 轮回之奖
            AddTranslation("Boon of Reincarnation", "轮回之惠");
            // 你献祭骷髅卡牌时，获得一张松鼠牌。
            AddTranslation("When a Skeleton is sacrificed, draw a squirrel.", "祀一枯骨，则引一松鼠。");
            // 当装备该奖励时，你献祭骷髅卡牌时，获得一张松鼠牌。
            AddTranslation("With this boon equipped, When a Skeleton is sacrificed, draw a squirrel.", "有此惠，则祀一枯骨，引一松鼠。");
            // 死灵之奖
            AddTranslation("Boon of Necromancy", "死灵之惠");
            // 当一张骷髅死亡时，将在其位置生成一张随机玛珂牌。
            AddTranslation("When a Skeleton dies, a random mox is placed in it's place.", "一枯骨死，则其位生一偶玛珂。");
            // 当装备该奖励时，当一张骷髅死亡时，将在其位置生成一张随机玛珂牌。
            AddTranslation("With this boon equipped, When a Skeleton dies, a random mox is placed in it's place.", "有此惠，则一枯骨死，其位生一偶玛珂。");
            // 碎屑之奖
            AddTranslation("Boon of Scrap", "废屑之惠");
            // 每当你达到满能量时，你就会获得一块骨头。
            AddTranslation("Whenever you reach full energy, you gain a bone.", "汝能既满，则得一骨。");
            // 当装备该奖励时，每当你达到满能量时，你就会获得一块骨头。
            AddTranslation("With this boon equipped, Whenever you reach full energy, you gain a bone.", "有此惠，则汝能既满，得一骨。");
            // 构筑之奖
            AddTranslation("Boon of Construct", "构成之惠");
            // 任何成本超过2能量的科技卡牌都会在死亡时掉落一张随机玛珂牌。
            AddTranslation("Any tech card that costs more than 2 energy will drop a random mox on death.", "凡费能逾二之机牌，死则坠一偶玛珂。");
            // 当装备该奖励时，任何成本超过2能量的科技卡牌都会在死亡时掉落一张随机玛珂牌。
            AddTranslation("With this boon equipped, Any tech card that costs more than 2 energy will drop a random mox on death.", "有此惠，则凡费能逾二之机牌，死则坠一偶玛珂。");
            // 救赎恩典
            AddTranslation("Boon of The Saving Grace", "全生之惠");
            // 每当你受到致命伤害时，会给你保留1点生命。（每场战斗限触发一次）
            AddTranslation("Whenever you would recieve fatal damage, the scales are only tipped down to 4.\nONCE PER BATTLE", "汝将受致命伤时，衡止倾至四。\n每战一发而已");
            // 当装备该奖励时，每当你受到致命伤害时，会给你保留1点生命。（每场战斗限触发一次）
            AddTranslation("With this boon equipped, Whenever you would recieve fatal damage, the scales are only tipped down to 4.\nONCE PER BATTLE", "有此惠，则汝将受致命伤时，衡止倾至四。\n每战一发而已");
            // 每场战斗开始时，在你一侧的场上放一只黑山羊。
            AddTranslation("Start each battle with a black goat on the board.", "每战始，于汝侧局上置一黑羊。");
            // 当装备该奖励时，每场战斗开始时，在你一侧的场上放一只黑山羊。
            AddTranslation("With this boon equipped, Start each battle with a black goat on the board.", "有此惠，则每战始，于汝侧局上置一黑羊。");
            // 每一场战斗开始时就有3块骨头。
            AddTranslation("Start each battle with +3 bones.", "每战始得骨三。");
            // 当装备该奖励时，每一场战斗开始时就有3块骨头。
            AddTranslation("With this boon equipped, Start each battle with +3 bones.", "有此惠，则每战始得骨三。");
            // 每回合抽2张牌，而不是1张，但只有当你战斗时牌组中的牌少于20张时，它才会起作用。
            AddTranslation("Draw 2 cards each turn instead of 1, but it will only function if you have less than 20 cards in your deck while battling.", "每合引二牌，不一。然惟战时牌列少于二十，乃行。");
            // 当装备该奖励时，每回合抽2张牌，而不是1张，但只有当你战斗时牌组中的牌少于20张时，它才会起作用。
            AddTranslation("With this boon equipped, Draw 2 cards each turn instead of 1, but it will only function if you have less than 20 cards in your deck while battling.", "有此惠，则每合引二牌，不一。然惟战时牌列少于二十，乃行。");
            // 每一场战斗开始时，你手中获得两张大冷杉。
            AddTranslation("Start each battle with 2 firs in your hand.", "每战始，汝手得二杉。");
            // 当装备该奖励时，每一场战斗开始时，你手中获得两张大冷杉。
            AddTranslation("With this boon equipped, Start each battle with 2 firs in your hand.", "有此惠，则每战始，汝手得二杉。");
            // 化石之奖
            AddTranslation("Boon of Fossils", "化石之惠");
            // 地形卡在死亡时产生3根骨头，而不是1根。
            AddTranslation("Terrain cards yield 3 bones on death instead of 1.", "地形牌死则出骨三，不一。");
            // 当装备该奖励时，地形卡在死亡时产生3根骨头，而不是1根。
            AddTranslation("With this boon equipped, Terrain cards yield 3 bones on death instead of 1.", "有此惠，则地形牌死则出骨三，不一。");
            // 骨髓之奖
            AddTranslation("Boon of Marrow", "骨髓之惠");
        }
    }
}
