using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch31
    {
        public static void RegisterTranslations()
        {
            RegisterAbilityBatchFour();
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

        private static void RegisterAbilityBatchFour()
        {
            // [creature]在战斗中阵亡时，会在原位置留下其他造物。与冰封禁锢不同，新造物将保留原造物的印记与增益效果。
            AddTranslation("When [creature] perishes by combat, it leaves something else in it's old space. Unlike Frozen Away, this new creature will retain the sigils and buffs of the original.", "[creature]战死，则其故处留一他物。异于“冰封禁锢”，新物犹存故物之印与益。");
            // 万有引力
            AddTranslation("Gravity", "引");
            // 当使用[creature]时，其持牌人可选择任意敌方造物，并将其移至己方牌桌的任意空位。
            AddTranslation("When [creature] is played, it's owner may choose any opponent creature, and move it to any open space on their side of the board.", "[creature]既陈，其主可择任一敌物，移之于己侧任一空位。");
            // 绿色灵感
            AddTranslation("Green Inspiration", "绿感");
            // 当牌桌上有[creature]时，所有有以绿宝石为费用的友方造物获得+2生命。
            AddTranslation("While [creature] is on the board, all friendly creatures which cost a green gem gain +2 health.", "[creature]在场，则凡费绿玉之友物，命加2。");
            // 呕脏者
            AddTranslation("Gut Spewer", "吐脏者");
            // 使用[creature]时，你的手牌里会出现一张内脏卡牌。
            AddTranslation("When [creature] is played, its innards are created in your hand.", "[creature]既陈，则其脏生于汝手。");
            // 先驱者
            AddTranslation("Harbinger", "先驱");
            // 当友方造物阵亡时，[creature]会移动至该空位补位。
            AddTranslation("When a friendly creatures perishes, [creature] will move to fill it's empty space.", "友物死，则[creature]移而补其空位。");
            // 内心之鹿
            AddTranslation("Harts Within", "内鹿");
            // [creature]受到攻击时，你的手牌中将随机出现一张有蹄类族群的卡牌。
            AddTranslation("When [creature] is struck, a random creature from the hooved tribe is created in your hand.", "[creature]受击，则于汝手随机生一有蹄族之牌。");
            // 阴魂不散
            AddTranslation("Haunter", "留魂");
            // 当[creature]战死时，其亡魂会盘踞在原位。进入该位置的造物将吸收其原有印记。
            AddTranslation("When [creature] dies to combat, it haunts the space it died in. Creatures that enter this space absorb its old sigils.", "[creature]战死，则其魂留于故位。后入其位之物，将纳其旧印。");
            // [creature]将印记留在了灵界！
            AddTranslation("[creature] leaves its sigils behind in the ethereal plane!", "[creature]遗其印于灵界矣！");
            // 在持牌人回合结束时，[creature]的持有者可以选择一个己方造物。该造物恢复1点生命。
            AddTranslation("At the end of the owner's turn, [creature]s owner may choose a creature they control. That creature gains 1 health.", "持牌者合终，[creature]之主可择一己物；其物命加1。");
            // 治疗护盾
            AddTranslation("Healshield", "疗甲");
            // 若[creature]在一回合内未受伤害，持牌人下回合开始时它将获得护甲。
            AddTranslation("If [creature] does not take damage during a turn, it will gain Armor at the start of its owner's next turn.", "若[creature]一合之中未受伤，则其主持下一合始时，它得甲。");
            // 使节
            AddTranslation("Herald", "报者");
            // 当[creature]击杀对面造物时，该卡牌左右两侧的造物各获得1点力量。
            AddTranslation("When[creature] attacks an opposing creature and it perishes, creatures to the left and right of this card gain 1 power.", "[creature]攻敌物而杀之，则此牌左右之物各得1威。");
            // 高功率
            AddTranslation("High Powered", "高能");
            // 在持牌人回合开始时，[creature]将消耗1点能量。
            AddTranslation("At the start of its owners turn, [creature] will consume 1 energy.", "其主持合始时，[creature]耗1能。");
            // 全垒打
            AddTranslation("Home Run", "本垒击");
            // [creature]会记住被放置的路线，并始终攻击该路线。
            AddTranslation("[creature] will remember the lane in which it was played, and will always attack that lane.", "[creature]识其初陈之路，而恒攻其路。");
            // 全套诱饵
            AddTranslation("Hook Line And Sinker", "钩线饵全");
            // 当[creature]在战斗中阵亡时，对面的造物会被拉入其原先所在位置。
            AddTranslation("When [creature] perishes by combat, the opposing creature will be pulled into it's old space.", "[creature]战死，则对位之物为曳入其故处。");
            // 超形态
            AddTranslation("Hypermorphic", "超形");
            // 每回合结束时，[creature]会随机变形为同类型同品质的卡牌。
            AddTranslation("At the end of each turn, [creature] will transform into a random card of the same type and quality.", "每合终，[creature]随机化为同类同品之一牌。");
            // 点燃
            AddTranslation("Ignition", "燃");
            // 当[creature]攻击造物时，目标将获得燃烧印记。
            AddTranslation("When [creature] strikes a creature, that creature gains the Burning sigil.", "[creature]击物，则彼物得燃印。");
            // 无瑕形态
            AddTranslation("Immaculate Form", "无瑕形");
            // 当[creature]在场时，所有友方造物的宝石消耗减少2颗。
            AddTranslation("While [creature] is on the board, the gems cost of all friendly creatures is reduced by 2 gems.", "[creature]在场，则诸友物之玉费减2。");
            // 缥缈之物
            AddTranslation("Immaterial", "无质");
            // 对手回合中对[creature]发动的攻击将直接穿透，并击中其持牌人。
            AddTranslation("Any attacks made against [creature] during the opponents turn will pass straight through, and hit the creature's owner directly.", "敌合中凡攻[creature]者，皆直透而中其主。");
            // 不朽之环
            AddTranslation("Immortal Coil", "不死环");
            // 当[creature]存活于牌桌上时，任何在战斗中阵亡的友方造物都会以略微削弱的状态返回持牌人手牌。
            AddTranslation("While [creature] is alive on the board, any friendly creatures that die to combat will return to the owner's hand, though slightly weakened.", "[creature]存于场，则凡友物战死者，皆稍弱而返其主之手。");
            // 失禁
            AddTranslation("Incontinent", "遗泄");
        }
    }
}
