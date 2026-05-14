using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch38
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchTwo();
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

        private static void RegisterAllTheSigilsBatchTwo()
        {
            // 当[creature]击杀其他造物时，它获得2点生命值。
            AddTranslation("When [creature] kills another creature, it gains 2 health.", "[creature]杀他物，则命益二。");
            // 懦夫
            AddTranslation("Cowardly", "怯");
            // [creature]不会攻击比自身攻击力高2的卡牌。
            AddTranslation("[creature] will not attack a card with a power 2 higher than its own.", "[creature]不攻威逾己二之牌。");
            // 死亡水域
            AddTranslation("Deadly Waters", "死水");
            // [creature]在它潜水时，会消灭攻击过它位置的卡牌。不影响拥有空袭和磐石之身的卡牌。
            AddTranslation("[creature] will kill cards that attacked over it while it was face-down. Does not affect cards that have Airborne or Made of Stone.", "[creature]翻伏时，凡越其位而攻者皆死；翔袭与石身者不与。");
            // 死亡爆发
            AddTranslation("Deathburst", "死爆");
            // [creature]在死亡时会对其左侧、右侧和自身的每个敌对空间造成1点伤害。
            AddTranslation("[creature] will deal 1 damage to each oppsing space to the left, right, and center of it.", "[creature]死，则伤其敌左、敌右与敌前各一。");
            // 在持牌人的回合开始时，[creature]将失去1点攻击力并获得1点生命值。
            AddTranslation("At the Start of its owner's turn [creature] will lose -1 attack and will gain +1 health.", "持牌者合始，[creature]威减一，而命益一。");
            // 绝望之力
            AddTranslation("Desperation", "穷急");
            // [creature]受伤至只有1点生命时，其获得3点力量。
            AddTranslation("[creature] is damaged to 1 health, it will gain 3 power.", "[creature]伤至惟一命，则威益三。");
            // 当离死亡如此之近的时候，它爆发了。
            AddTranslation("When so close to death, it strikes out.", "迫死则奋。");
            // 疫病汲取
            AddTranslation("Disease Absorbtion", "吸疠");
            // 当[creature]上场时，其会将场上所有负面印记转移到自身。
            AddTranslation("When played, [creature] will take all negative sigils onto itself.", "[creature]既陈，尽取诸负印于身。");
            // 多么高尚。
            AddTranslation("How Noble.", "高矣。");
            // 骨驱水袭
            AddTranslation("Dive (Bones)", "骨潜");
            // 消耗2根骨头，持牌人的回合结束时，[creature]将潜水一回合（重复点击没有效果，除非你想浪费骨头）。
            AddTranslation("Pay 2 bones to cause this card to flip face down at the end of the owner's turn.", "费二骨，则持牌者合终，此牌翻伏。");
            // 电驱水袭
            AddTranslation("Dive (Energy)", "能潜");
            // 消耗2点能量，持牌人的回合结束时，[creature]将潜水一回合（重复点击没有效果，除非你想浪费能量）。
            AddTranslation("Pay 2 energy to cause this card to flip face down at the end of the owner's turn.", "费二能，则持牌者合终，此牌翻伏。");
            // 多重打击
            AddTranslation("Multi-Strike", "连击");
            // 如果[creature]攻击的目标在其第一次攻击下存活，其将会多次打击该牌。不会触发额外打击的攻击或受伤的触发器效果。
            AddTranslation("[creature] will strike a card multiple times, if it lives through the first attack. Will not trigger -on attack- or -on damage- effects with the extra strikes.", "[creature]连击一牌；若彼不死于初击，则更击之。额外诸击，不触攻时、受伤时之效。");
            // 双重爪迹
            AddTranslation("Double scratch", "双爪");
            // 当[creature]攻击时，它会攻击两次，并攻击对位的左右两侧的空间。
            AddTranslation("When [creature] attacks it attacks twice and the space right and left of the attacked slot.", "[creature]攻时，再击一次，并及所攻位之左右。");
            // 血绘者
            AddTranslation("Draw Blood", "引血");
            // 当[creature]被召唤时，你的手牌中会随机创建一张消耗血液的卡牌。
            AddTranslation("When [creature] is played, a random card costing blood is created in your hand.", "[creature]既陈，汝手中生一血直之偶牌。");
            // 骨绘者
            AddTranslation("Draw Bone", "引骨");
            // 当[creature]被召唤时，你的手牌中会随机创建一张消耗骨头的卡牌。
            AddTranslation("When [creature] is played, a random card costing bone is created in your hand.", "[creature]既陈，汝手中生一骨直之偶牌。");
            // 冰绘者
            AddTranslation("Draw Card", "引化");
            // 当[creature]被召唤时，会根据其冰立方参数（默认为白鼬）在你的手中创建一张相关卡牌。
            AddTranslation("When [creature] is played, a card relating to it's ice cube parameter (default Stoat) is created in your hand.", "[creature]既陈，依其冰块之参（默认白鼬），汝手中生相关之一牌。");
            // 鹿角兔子洞
            AddTranslation("Draw Jackalope", "引鹿角兔");
            // 当[creature]被召唤时，你会获得一张鹿角兔卡牌，鹿角兔具有：2点力量，2点生命，冲刺能手，鹿角兔子洞。
            AddTranslation("When [creature] is played, a Jackalope is created in your hand.", "[creature]既陈，汝手中生一鹿角兔。");
            // 冲刺绘者
            AddTranslation("Draw Strafe", "引移");
            // 当[creature]移动时，会在你的手中随机创建一张带有移动印记的卡牌。
            AddTranslation("When [creature] moves, a random card with a movement sigil is created in your hand.", "凡[creature]移，则汝手中生一有移印之偶牌。");
            // 花费绘者
            AddTranslation("Draw Cost", "引同直");
            // 当[creature]被召唤时，你的手牌中将随机生成一张与[creature]相同费用类型的卡牌。
            AddTranslation("When [creature] is played, a random card that has the same cost type as [creature] is created in your hand.", "[creature]既陈，汝手中生一与[creature]同直类之偶牌。");
            // 能量绘者
            AddTranslation("Draw Energy", "引能");
            // 当[creature]被召唤时，会在你的手中随机创建一张消耗能量的卡牌。
            AddTranslation("When [creature] is played, a random card costing energy is created in your hand.", "[creature]既陈，汝手中生一能直之偶牌。");
            // 魔绘者
            AddTranslation("Draw Mox", "引玛珂");
            // 当[creature]被召唤时，会在你的手中随机创建一张需要玛珂的卡牌。
            AddTranslation("When [creature] is played, a random card costing mox is created in your hand.", "[creature]既陈，汝手中生一玛珂直之偶牌。");
            // 支援呼叫
            AddTranslation("Support call", "援呼");
            // 当[creature]被召唤时，你立即抽一张副牌堆的牌。
            AddTranslation("When [creature] is played, a card from your sidedeck is created in your hand.", "[creature]既陈，汝手中生一副牌之牌。");
            // 醉酒
            AddTranslation("Drunk", "醉");
            // [creature]将随机打击它对面左右两侧的任意一个敌方空间。
            AddTranslation("[creature] will strike a random one of the opposing spaces to the left and right of the space across from it.", "[creature]漫击其对位左右之一敌位。");
            // 矮人
            AddTranslation("Dwarf", "矮");
            // 当[creature]被抽到时，它将失去一个单位的花费，以及1点力量和2点生命（生命值不能低于1点）。一个单位被定义为：1点血量、3根骨头、3点能量或所有玛珂需求。
            AddTranslation("When [creature] is drawn, it will loose one unit of cost, as well as 1 power and 2 health (can't go below 1 health). A unit is defined as: 1 blood, 3 bones, 3 energy, or all mox.", "[creature]既引，则失一直，并威一命二（命不下于一）。一直者：一血、三骨、三能，或尽其玛珂。");
            // 奄奄一息
            AddTranslation("Dying", "将死");
            // [creature]将在X个回合后死亡。
            AddTranslation("[creature] will die after X number of turns.", "[creature]历X合而死。");
            // 前往屠杀
            AddTranslation("To The Slaughter", "赴屠");
            // 每回合结束时，[creature]将随机吃掉一只鸡，获得与被吃掉鸡的生命值相同的攻击力，并获得与被吃掉鸡的攻击力相同的生命值。
            AddTranslation("At the end of each turn [creature] will eat a random Chicken gaining the same amount of attack as the eaten chicken's health, and gaining the same amount of health as the eaten chicken's attack.", "每合终，[creature]食一偶鸡，得其所食之鸡命数为威，威数为命。");
            // 电力制导
            AddTranslation("Electric", "电裂");
            // 当[creature]发动攻击时，会对目标相邻的卡牌造成一半伤害。
            AddTranslation("When [creature] decalres an attack, they will deal half the damage to cards adjacent to the target.", "[creature]宣攻时，所中左右邻牌各受其半伤。");
            // 执法者
            AddTranslation("Enforcer", "纠");
            // 在持牌人的回合开始时，[creature]将使相邻的造物攻击。
            AddTranslation("At the start of the owner's turn, [creature] will cause adjacent creatures to attack.", "持牌者合始，[creature]使左右诸物出击。");
            // 超频领袖
            AddTranslation("Enrage", "狂帅");
            // [creature]将增加相邻的卡牌2点力量。然而，如果它们在获得力量时阵亡，它们将永久地从你的牌组中被移除。
            AddTranslation("[creature] will empower adjacent allies, increasing their strenght by 2. However, if they perish while empowered, they are permamently removed from your deck.", "[creature]益其旁友牌之威二。然彼受益而死，则永出汝牌列。");
            // 噬虫菌体
            AddTranslation("Entomophage", "啖虫");
            // [creature]将对昆虫类族群的卡牌造成额外2点伤害。
            AddTranslation("[creature] will deal 2 additional damage to cards of the insect tribe.", "[creature]对虫属之牌加伤二。");
            // 我听说它们是蛋白质的好来源。
            AddTranslation("They are a good source of protine I hear.", "闻其颇足为膳。");
            // 当相邻的卡牌攻击一张牌时，[creature]将帮助其攻击。
            AddTranslation("A familiar will help with attacking when it's adjacent allies attack a card.", "相邻之友攻牌，则[creature]助之击。");
            // 胆战心惊
            AddTranslation("Fearful", "惧");
            // 当[creature]被攻击但没有死亡时，它将被送回持牌人手中。
            AddTranslation("When [creature] is struck without it resulting in death, it will be returned to its owner's hand.", "[creature]见击而不死，则反归其主之手。");
            // 充能感应
            AddTranslation("Charge", "骨冲");
            // 消耗3根骨头选择一个敌对卡牌，[creature]将攻击选择的卡牌。
            AddTranslation("Pay 3 bones to choose an enemy creature that [creature] will strike.", "费三骨，择一敌物，[creature]击之。");
            // 星火燎原
            AddTranslation("Firestarter", "然火");
            // 当[creature]对另一造物造成伤害时，该造物将获得燃烧印记。燃烧印记被定义为：每个维持阶段，[creature]获得1点力量但失去1点生命。
            AddTranslation("When [creature] damages another creature, that creature will gain the Burning Sigil. The Burning Sigil is define as: Each upkeep, this creature gains 1 strength but looses 1 health.", "[creature]伤他物，则彼得焚印。焚印者：每合始，此物威益一而命损一。");
            // 即使战斗结束，也会留下致命的痕迹.
            AddTranslation("Even once combat is over, it leaves a deadly mark", "战罢犹遗死痕。");
            // 饵钓潜袭
            AddTranslation("Lure", "诱");
            // [creature]在攻击时会迫使盖住的卡牌翻面。
            AddTranslation("[creature] will cause facedown cards to become face up when attacking.", "[creature]攻时，使伏牌翻见。");
            // 潜水的造物浮出了水面。
            AddTranslation("The Submerge are brought back to the surface", "潜者复出于水上。");
            // 当放置[creature]时，持牌人可以选择一张敌方的卡牌钩其至自己的一侧。
            AddTranslation("When [creature], a targeted card is moved to the owner's side of the board.", "[creature]既陈，所择一牌移于其主一侧之局。");
            // 骨魔
            AddTranslation("Bone lord 5", "骨王五");
            // 当[creature]死亡时，奖励5根骨头，而不是1根。
            AddTranslation("When [creature] dies, 5 bones are rewarded instead of 1.", "[creature]死，则赏骨五，不一。");
            // 惊恐
            AddTranslation("Frightened", "惊");
            // 当有卡牌移动到与[creature]相对的空间时，[creature]将远离该卡牌移动到随机的相邻空位，优先选择没有任何对位卡牌的空位。
            AddTranslation("When a creature moves into the space opposing [creature], [creature] will move away from that card to a random free adjacent spot, while prioritizing slots without any opposing creatures.", "有物移至与[creature]相对之位，则[creature]避彼而移于一邻空位，先择无对物者。");
            // 令人生畏
            AddTranslation("Frightful", "骇");
            // [creature]攻击时将迫使敌方造物让开道路。
            AddTranslation("[creature] will cause opposing creatures to move out of the way when it attacks.", "[creature]攻时，迫敌物避路。");
            // 当[creature]被召唤时，它将增加1点血祭消耗，以及1点攻击力和2点生命值。
            AddTranslation("When [creature] is drawn, it will gain one unit blood of cost, as well as one attack and two health.", "[creature]既引，则直加一血，并威一命二。");
            // 你那儿的造物多大啊。
            AddTranslation("What a large creature you have there", "汝有大物哉。");
            // 放牧
            AddTranslation("Grazing", "啮草");
            // 在持牌人的回合结束时，如果没有敌方造物，[creature]将回复1点生命值。
            AddTranslation("At the end of the owner's turn, [creature] will regen 1 health if there is no opposing creature.", "持牌者合终，若无对物，[creature]复一命。");
            // 该造物将在其持牌人回合结束时恢复1点生命值。
            AddTranslation("This creature will heal 1 Health at the end of it's owner's turn.", "此物于其主持合终复一命。");
        }
    }
}
