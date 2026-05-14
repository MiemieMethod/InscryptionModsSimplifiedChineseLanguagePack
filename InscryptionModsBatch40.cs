using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch40
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchFour();
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

        private static void RegisterAllTheSigilsBatchFour()
        {
            // 猎犬者
            AddTranslation("Dog Gone", "犬克");
            // 当[creature]对阵犬类族群造物时，将获得2点力量。
            AddTranslation("[creature] will gain 2 power when opposed by a creature of the Canine tribe.", "[creature]对犬属之物，则威加2。");
            // 戏鸟者
            AddTranslation("Fowl Play", "鸟克");
            // 当[creature]对阵鸟类族群造物时，获得2点力量。
            AddTranslation("[creature] will gain 2 power when opposed by a creature of the Avian tribe.", "[creature]对羽属之物，则威加2。");
            // 食虫者
            AddTranslation("Insectivore", "食虫");
            // 当[creature]对面是昆虫类族群造物时，获得2点力量。
            AddTranslation("[creature] will gain 2 power when opposed by a creature of the Insect tribe.", "[creature]对虫属之物，则威加2。");
            // 捕蛇者
            AddTranslation("Snakebite", "噬蛇");
            // [creature]与爬行族造物对战时将获得2点力量。
            AddTranslation("[creature] will gain 2 power when opposed by a creature of the Reptile tribe.", "[creature]对鳞属之物，则威加2。");
            // 橙色灵感
            AddTranslation("Orange Inspiration", "红感");
            // 当牌桌上有[creature]时，所有有以橙宝石为费用的友方卡牌增加1点力量。
            AddTranslation("While[creature] is on the board, all friendly cards which cost an orange gem gain +1 power.", "[creature]在局，则凡费橙玉之友牌，威加1。");
            // 器官盗贼
            AddTranslation("Organ Thief", "盗脏");
            // 当[creature]击杀另一只造物时，该造物的残骸会出现在你的手牌中。
            AddTranslation("When [creature] kills another creature, it's remains are created in your hand.", "[creature]杀一物，则彼物之骸生于汝手。");
            // 窃骨术
            AddTranslation("Osteoklepty", "窃骨");
            // 当[creature]入场时，它会窃取对手所有的骨头归其持牌人所有。
            AddTranslation("When [creature] is played, it steals all of the opponents bones for it's owner.", "[creature]既陈，则窃敌一切骨而归其主。");
            // 彼岸
            AddTranslation("Other Side", "彼岸");
            // 当[creature]在场时，所有在战斗中阵亡的友方造物将以骷髅形态返回持牌人手牌。
            AddTranslation("While [creature] is on the board, any friendly creatures that die in combat will be returned to the owner's hand as skeletons.", "[creature]在局，则凡友物战死，皆以枯骨之形返其主手。");
            // 痛苦占场
            AddTranslation("Painful Presence", "苦临");
            // 在每个维持阶段，[creature]对面、相邻以及斜对角相邻的所有造物均受到1点伤害。
            AddTranslation("On upkeep, all creatures adjacent to [creature] vertically, horizontally, or diagonally take 1 damage.", "每合始，[creature]纵横斜邻之诸物皆受1伤。");
            // 麻痹
            AddTranslation("Paralytic", "痹");
            // 当[creature]攻击造物时，该造物损失1点力量。
            AddTranslation("When [creature] strikes a creature, that creature loses 1 power.", "[creature]击物，则彼物失1威。");
            // 单性生殖
            AddTranslation("Parthenogenesis", "单生");
            // [creature]在战斗中死亡时，会在原位置留下幼虫形态，1回合后将进化为完全相同的克隆体。
            AddTranslation("When [creature] dies to combat, a larval form is left in it's old space that evolves into an exact clone after 1 turn.", "[creature]战死，则其故处留一幼体；一合后化为与之无异之副。");
            // 完美形态
            AddTranslation("Perfect Form", "完形");
            // 当牌桌上有[creature]时，所有友方造物的宝石消耗减少1颗。
            AddTranslation("While [creature] is on the board, the gems cost of all friendly creatures is reduced by 1 gem.", "[creature]在局，则诸友物之玉费减1。");
            // 移形换影
            AddTranslation("Phantasmic", "幻行");
            // 回合结束时，[creature]将沿印记标注方向移动，可穿透障碍物；若无法移动则绕至牌桌另一侧。
            AddTranslation("At the end of the turn, [creature] will move in the direction inscribed in the sigil, phasing past obstacles and wrapping around to the other side of the board if movement is impossible.", "合终，[creature]循印所志而移，能过阻碍；若不可移，则绕至牌局彼侧。");
            // 穿刺
            AddTranslation("Piercing", "穿");
            // 当[creature]攻击一个已有造物在后方排队的槽位时，排队的造物将受到1点伤害。
            AddTranslation("When [creature] strikes a slot which has a creature queued behind it, the queued creature will take 1 damage.", "[creature]击一位而其后有候补之物，则其候补者受1伤。");
            // 巅峰打击
            AddTranslation("Pinnacle Strike", "极击");
            // [creature]会在攻击时打击所有敌方位置。
            AddTranslation("[creature] will strike all opponent spaces when it attacks.", "[creature]攻时，尽击敌侧诸位。");
            // 涨潮者
            AddTranslation("Point Nemo", "海极");
            // 使用[creature]时，牌桌上所有造物均获得水袭印记。
            AddTranslation("When [creature] is played, all creatures on the board gain the Waterborne sigil.", "[creature]既陈，场上诸物皆得潜袭印。");
            // 强力献祭
            AddTranslation("Potent", "强祀");
            // 当[creature]被献祭时，献祭获得的新卡将随机附加一个印记。
            AddTranslation("When [creature] is sacrificed, the creature it was sacrificed for gains a random sigil.", "[creature]见祀，则受其祀之物随机得一印。");
            // 预先攻击
            AddTranslation("Preemptive Strike", "先发");
            // [creature]首次打出时会立即攻击一次。
            AddTranslation("[creature] will attack once when first played.", "[creature]初陈即攻一次。");
            // [creature]发动了一次先制攻击。
            AddTranslation("[creature] makes a free attack!", "[creature]得一先攻！");
            // 传播者
            AddTranslation("Propagation", "孳");
            // 当[creature]击杀对面造物时，会在该卡牌左右两侧的牌桌位置生成一个造物。
            AddTranslation("When [creature] attacks an opposing creature and it perishes, a creature is created on the board to the left or right of this card.", "[creature]攻敌物而杀之，则此牌左右之一位生一物。");
            // 预言家
            AddTranslation("Prophecy", "预言");
            // 当使用[creature]时，你可以检视牌组中的三张卡牌并按顺序选择。接下来你抽的三张牌将是你所选择的牌，且顺序与你在此处选择的顺序一致。
            AddTranslation("When [creature] is played, you may look at three cards from your deck and choose them in order. The next three cards you draw will be the cards you were shown, in the order that you chose them.", "[creature]既陈，汝可阅牌列中三牌而次定之。后所引三牌，即此三牌，次如所定。");
            // 我将允许你从三张卡牌中选择。这三张牌将是你接下来从牌组中抽到的牌，顺序与你在此处选择的顺序一致。
            AddTranslation("I will allow you to choose from three cards. These three cards will be the next three cards you draw from your deck, in the order you choose them here.", "我许汝自三牌中择之。此三牌将为汝后所引之三牌，次如汝今所定。");
            // 选择三个造物，改变你接下来的抽牌。
            AddTranslation("Choose three creatures, and alter your next draws.", "择三物，而易后引。");
            // 你知道该怎么做的。
            AddTranslation("You know how this goes.", "汝知其法。");
            // 从三张卡牌中选择。这三张牌将是你接下来从牌组中抽到的牌，顺序与你在此处选择的顺序一致。
            AddTranslation("Choose from three cards. These three cards will be the next three cards you draw from your deck, in the order you chose them.", "自三牌中择之。此三牌将为汝后所引之三牌，次如所定。");
            // 选择你接下来要抽的三张牌。
            AddTranslation("Choose your next three draws.", "定汝后三引。");
            // 唔……看来你的新预言覆盖了旧的。
            AddTranslation("Hmmm... your new prophecy overwrites the old, it would seem.", "唔……新预言覆旧者矣。");
            // 你的新预言覆盖了旧的！
            AddTranslation("Your new prophecy overwrites the old!", "新预言覆旧矣！");
            // 唔……很好
            AddTranslation("Hmm... very well", "唔……可。");
            // 你剩余的卡牌不足以进行预言。
            AddTranslation("You do not have enough cards left for a prophecy.", "汝馀牌不足为预言。");
            // 你剩余的卡牌不足以进行新的预言！
            AddTranslation("You don't have enough cards left to make a new prophecy!", "汝馀牌不足为新预言！");
            // 纯净之心
            AddTranslation("Pure Heart", "纯心");
            // 当[creature]阵亡时，会在原地生成一张巅峰玛珂。
            AddTranslation("When [creature] perishes, a Pinnacle Mox is created in its place.", "[creature]死，则其处生一极玛珂。");
            // 软柿子
            AddTranslation("Pushover", "易殪");
            // 若[creature]对面存在敌方造物，该卡牌将直接阵亡。
            AddTranslation("If [creature] is opposed by an enemy creature, the card will perish.", "若[creature]对面有敌物，则此牌立死。");
            // 步哨工程师
            AddTranslation("Put Sentry Here", "置哨于此");
            // 使用[creature]时，会在其左右两侧各部署一台哨兵无人机。
            AddTranslation("When [creature] is played, a Sentry Drone is created to its left and right.", "[creature]既陈，其左右各生一戍飞械。");
            // 四重攻击
            AddTranslation("Quad Strike", "四击");
            // [creature]会攻击正对面的左右两侧位置各一次，并额外攻击正前方位置一次。
            AddTranslation("[creature] will strike each opposing space to the left and right of the spaces across from it as well as striking the space in front of it an additional time.", "[creature]攻时，并击正对左右二位，而正前更加一击。");
            // 快攻
            AddTranslation("Quickdraw", "速陈");
            // [creature]会在每场战斗开始时自动从牌组中打出至随机空位。
            AddTranslation("[creature] will automatically play itself from your deck onto a random space at the start of each battle.", "[creature]每战之始，自牌列陈于随机空位。");
            // 突击员
            AddTranslation("Ranger", "游击");
            // 当[creature]入场时，其持牌人可选择一名敌方造物，该造物将受到10点伤害。
            AddTranslation("When [creature] is played, it's owner may choose an opponent creature. That creature will take 10 damage.", "[creature]既陈，其主可择一敌物；彼物受10伤。");
            // 贪婪之噬
            AddTranslation("Ravenous", "饕");
            // 当[creature]击杀一只造物时，它将在本场战斗中额外攻击对面位置一次。
            AddTranslation("When [creature] kills a creature, it will gain an additional strike against the opposing space until the end of combat.", "[creature]杀一物，则至战终前，对位更增一击。");
            // 蓄势
            AddTranslation("Recharge", "复能");
            // 使用[creature]时，持牌人恢复1点能量。不影响当前能量上限。
            AddTranslation("When [creature] is played, it's owner regains 1 energy. Does not affect the current energy maximum.", "[creature]既陈，其主复1能；不益今能极。");
            // 回收利用
            AddTranslation("Recycle", "回用");
            // 当[creature]在场时，任何友方造物因战斗阵亡时，其持有者手牌中将生成一张特殊卡牌。生成的卡牌类型取决于阵亡友方卡牌所属的神殿。
            AddTranslation("While [creature] is on the board, when any friendly creature perishes by combat a special card will be created in the owners hand. The card created depends on the temple of the friendly card which perishesd.", "[creature]在局，则凡友物战死，其主手中生一殊牌。所生之牌，视战死牌所属神殿而定。");
            // 镜面反击
            AddTranslation("Reflective", "映威");
            // 当[creature]对阵造物时，其力量将提升至与对面造物相同。
            AddTranslation("When [creature] is opposed by a creature, it gains power equal to the opposing creatures power.", "[creature]对位有物，则其威增至与彼相同。");
            // 万象更新
            AddTranslation("Regenerator", "自新");
            // 在持牌人回合开始时，[creature]将恢复1点生命值。
            AddTranslation("At the start of the owners turn, [creature] will heal 1 health.", "持牌者合始，[creature]复1命。");
            // [creature]恢复了1点生命值！
            AddTranslation("[creature] regenerates one health!", "[creature]复1命矣！");
            // 纪念之花
            AddTranslation("Rememberance", "追念");
            // 当使用[creature]时，其持牌人可从墓地检索一张卡牌，此印记将被该卡牌的印记所取代。
            AddTranslation("When [creature] is played, it's owner may search their graveyard for a card. This sigil is replaced by that cards sigils.", "[creature]既陈，其主可于墓地索一牌；此印即为彼牌诸印所代。");
            // 遥控
            AddTranslation("Remote Controlled", "遥御");
            // 使用[creature]时，持牌人将获得一个遥控器。当遥控器受到攻击时，[creature]会反击攻击者。
            AddTranslation("When [creature] is played, a Remote Controller is created in the owner's hand. When the remote controller is struck, [creature] will attack the striker.", "[creature]既陈，其主手中生一遥御器。遥御器受击，则[creature]攻其击者。");
            // 重新定向
            AddTranslation("Reroute", "易路");
            // 回合结束时，[creature]将与同侧随机一名造物交换位置。
            AddTranslation("At the end of the turn, [creature] will swap places with a random creature on the same side of the board.", "合终，[creature]与同侧随机一物易位。");
            // 百折不挠
            AddTranslation("Resilient", "韧");
            // [creature]受到的所有伤害均降为1点。
            AddTranslation("All damage taken by [creature] is reduced to 1.", "[creature]凡所受伤，皆减为1。");
            // 退却
            AddTranslation("Retreat", "遁");
            // 当[creature]受到攻击时，会随机移动至牌桌同侧的空位。
            AddTranslation("When [creature] is struck, it will move to a random empty space on the same side of the board.", "[creature]受击，则随机移于同侧空位。");
            // 复仇攻击
            AddTranslation("Return Strike", "反击");
            // [creature]受到攻击时会进行反击。
            AddTranslation("When [creature] is struck, it attacks in retaliation.", "[creature]受击，则反击之。");
            // 时针顺之魂
            AddTranslation("Revolve", "周旋");
            // 使用[creature]时，牌桌上所有卡牌均会按顺时针方向移动一格。
            AddTranslation("When [creature] is played, all cards on the board are moved one space clockwise.", "[creature]既陈，局上诸牌皆顺时步一格。");
            // 开膛手
            AddTranslation("Ripper", "剖者");
            // [creature]会移动并消灭任何生命值为1的非地形造物，每消灭一个都会变得更强。
            AddTranslation("[creature] will move to and destroy any free, 1 health, non-terrain creatures played, and becomes stronger for each one consumed.", "凡所陈之无费、命1、非地形物，[creature]皆移而灭之；每食一，则益强。");
            // 磐石吞噬者
            AddTranslation("Rock Eater", "食磐");
            // 当[creature]同侧的牌桌出现地形卡时，该卡会被吞噬，其属性与印记将转移至这张地形卡。
            AddTranslation("When a Terrain card is played on the same side of the board as [creature], it will be consumed, granting it's stats and sigils to the card.", "若[creature]同侧有地形牌既陈，则为其所食，而其威命与印皆归[creature]。");
            // 红宝石核芯
            AddTranslation("Ruby Core", "红玉核");
            // 当[creature]阵亡时，会在原地生成一个红宝石容器。
            AddTranslation("When [creature] perishes, a Ruby Vessel is created in its place.", "[creature]死，则其处生一红玉皿。");
            // 奔袭打击
            AddTranslation("Running Strike", "奔击");
            // 攻击后，[creature]将沿印记标注方向移动，并在移动过程中攻击目标位置对面的空间。
            AddTranslation("After attacking, [creature] will move in the direction inscribed on the sigil, striking the space opposing it's destination as it does so.", "攻后，[creature]循印所志而移，移时击其所至之对位。");
            // 割裂之触
            AddTranslation("Rupture", "裂触");
            // 当[creature]对造物造成伤害时，该伤害值的一半（向下取整）将同时作用于该造物的持有者。
            AddTranslation("When [creature] deals damage to a creature, half of that damage, rounded down, is also dealt to that creature's owner.", "[creature]伤一物，则其伤之半，取下，亦及其主。");
            // 血祭力量
            AddTranslation("Sanguine", "血威");
            // 当有造物被献祭时，[creature]的力量会临时增加1点直至战斗结束。
            AddTranslation("When a creature is sacrificed, [creature] gains 1 power until the end of combat.", "有物见祀，则[creature]威加1，至战终。");
        }
    }
}
