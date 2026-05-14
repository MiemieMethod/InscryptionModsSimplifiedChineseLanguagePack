using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch49
    {
        public static void RegisterTranslations()
        {
            RegisterToolkitAndP03BatchOne();
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

        private static void RegisterToolkitAndP03BatchOne()
        {
            // 环境：钓鱼人的池塘
            AddTranslation("Environment: Angler's Pond", "环境：渔父之池");
            // 对手将以拥有鱼饵的方式展开战斗。
            AddTranslation("The opponent will start the battle with Bait Buckets.", "敌将以饵桶而战始。");
            // 环境：暴雪
            AddTranslation("Environment: Blizzard", "环境：暴雪");
            // 在每回合开始时，如果场上没有雪崩，则会在场上的最左侧生成一个雪崩。
            AddTranslation("At the start of each turn, if there is not an Avalanche present on the board, one will be created on the left-most side of the board.", "每合始，若局中无雪崩，则最左生一雪崩。");
            // 环境：血月
            AddTranslation("Environment: Blood Moon", "环境：血月");
            // 对手将以拥有冰原狼幼崽的情况下开始战斗。
            AddTranslation("The opponent will start the battle with Dire Wolf Pups.", "敌将以恐狼崽而战始。");
            // 环境：微风
            AddTranslation("Environment: Breeze", "环境：微风");
            // 在每个回合开始时，场上所有造物都会获得或失去空袭印记；此环境对地形和拥有水袭或钻地龙印记的造物无效。
            AddTranslation("At the start of every turn, all creatures gain or lose Airborne. Terrain, and creatures with Waterborne or Burrower are ignored.", "每合始，诸物或得或失翔袭；地形与有潜袭、潜龙者不与。");
            // 环境：萝卜地
            AddTranslation("Environment: Carrot Patch", "环境：萝圃");
            // 对手将以拥有兔子的情况下开始战斗。
            AddTranslation("The opponent will start the battle with Rabbits.", "敌将以兔而战始。");
            // 环境：陡崖
            AddTranslation("Environment: Cliffside", "环境：绝崖");
            // 在战斗开始时，最左侧的路线将被陡崖封锁。
            AddTranslation("At the start of the battle, the leftmost lane will be blocked with Cliffs.", "战始，最左之列为崖所塞。");
            // 环境：工厂
            AddTranslation("Environment: Factory", "环境：工肆");
            // 维持状态下，场上所有卡牌均顺时针旋转1格。
            AddTranslation("On Upkeep, all cards are rotated clockwise.", "每合始，诸牌皆顺时移一格。");
            // 环境：黑森林
            AddTranslation("Environment: Dark Forest", "环境：黑林");
            // 对手将在拥有森林的情况下展开战斗。对手的所有地形卡都+1力量。
            AddTranslation("The opponent will start the battle with Trees. All of the opponent's terrain have +1 power.", "敌将以树而战始；其诸地形牌威皆益一。");
            // 环境：矿工的营地
            AddTranslation("Environment: Prospector's Camp", "环境：采夫之营");
            // 您将在某些位置上与潜在的危险人物展开战斗。
            AddTranslation("You will start the battle with Dynamite on some of your spaces.", "汝战始时，其侧数位有炸药。");
            // 环境：雷暴
            AddTranslation("Environment: Electrical Storm", "环境：雷暴");
            // 放置一张牌时，它会受到1点伤害，并获得1点力量。
            AddTranslation("When a card is played, it takes 1 damage and gains 1 power.", "牌既陈，则受一伤而威益一。");
            // 环境：快速生长
            AddTranslation("Environment: Flash Growth", "环境：急长");
            // 当一张牌被放置时，任何在回合开始时激活的印记都被激活一次。
            AddTranslation("When a card is played, any sigils that activate at the start of the turn are activated.", "牌既陈，则凡合始而发之印皆启。");
            // 环境：洪水
            AddTranslation("Environment: Flood", "环境：洪水");
            // 每放置一张造物，其获得水袭印记；此环境对地形和具有空袭印记的造物无效。
            AddTranslation("Whenever a creature is played, it gains Waterborne. Terrain, and creatures with Airborne are ignored.", "物既陈，则得潜袭；地形与有翔袭者不与。");
            // 环境：宝石保护区
            AddTranslation("Environment: Gem Sanctuary", "环境：玉境");
            // 所有宝石都+1力量。
            AddTranslation("All gems have +1 power.", "诸玉威皆益一。");
            // 环境：墓地
            AddTranslation("Environment: Graveyard", "环境：墓");
            // 当一个造物死亡时，它会立即复活并再次死亡。
            AddTranslation("When a creature dies, it dies again.", "一物既死，则复死。");
            // 环境：冰雹
            AddTranslation("Environment: Hail Storm", "环境：雹暴");
            // 在每个回合开始时，回合所有者的所有非地形卡受到1点伤害。
            AddTranslation("At the start of each turn, all of the turn owner's non-terrain cards take 1 damage.", "每合始，合主诸非地形牌皆受一伤。");
            // 环境：海盗谷
            AddTranslation("Environment: Pirate's Hollow", "环境：盗谷");
            // 对手将用迷你柠檬琴开始战斗。
            AddTranslation("The opponent will start the battle with a Minicello.", "敌将以小琴舟而战始。");
            // 环境：泥沼
            AddTranslation("Environment: Mud Swamp", "环境：泥泽");
            // 你将在场上有泥沼的情况下开始战斗。
            AddTranslation("You will start the battle with Mud on some of your spaces.", "汝战始时，其侧数位有泥。");
            // 环境：真菌场
            AddTranslation("Environment: Fungal Field", "环境：蕈场");
            // 对手将使用蘑菇开始战斗。
            AddTranslation("The opponent will start the battle with Mushrooms.", "敌将以蕈而战始。");
            // 环境：方尖碑
            AddTranslation("Environment: Obelisk", "环境：方尖碑");
            // 对手将在拥有方尖碑的情况下开始战斗。
            AddTranslation("The opponent will start the battle with an Obelisk.", "敌将以方尖碑而战始。");
            // 环境：诅咒图腾
            AddTranslation("Environment: Cursed Totem", "环境：咒图腾");
            // 对手将使用诅咒图腾以开始战斗。
            AddTranslation("The opponent will start the battle with Cursed Totems.", "敌将以咒图腾而战始。");
            // 环境：猎人的狩猎场
            AddTranslation("Environment: Trapper's Hunting Grounds", "环境：猎夫之猎场");
            // 对手将使用钢制陷阱以开始战斗。
            AddTranslation("The opponent will start the battle with Steel Traps.", "敌将以铁阱而战始。");
            // 攀登者的祸根
            AddTranslation("Ascender's Bane", "陟者殃");
            // 提醒过去的挑战者。
            AddTranslation("A reminder of past challengers.", "往昔角者之征也。");
            // 雪崩
            AddTranslation("Avalanche", "雪崩");
            // 巨大的雪堆。
            AddTranslation("A monsterous mound of snow.", "巨雪之堆也。");
            // 陡崖
            AddTranslation("Cliff", "绝崖");
            // 坚固的岩石墙。
            AddTranslation("A solid wall of rock.", "坚岩之壁也。");
            // 三叶草
            AddTranslation("Clover", "三叶草");
            // 罗亚尔船员中忠诚的成员。
            AddTranslation("A loyal member of Royal's crew.", "罗亚尔舟卒之忠者。");
            // 炸药
            AddTranslation("Dynamite", "炸药");
            // 一盒炸药。
            AddTranslation("A box of dynamite.", "炸药一匣。");
            // 金羊
            AddTranslation("Chrysomallos", "克律索马罗斯");
            // 神秘的、闪闪发光的生物。
            AddTranslation("A mystical, glittering being.", "神异而晶耀之物。");
            // 冰块
            AddTranslation("Ice Cube", "冰块");
            // 一块冰。
            AddTranslation("A block of ice.", "冰一块。");
            // 迷你柠檬琴号
            AddTranslation("Minicello", "小琴舟");
            // 一艘著名海盗船的微型版。
            AddTranslation("A miniture version of a famous pirate's ship.", "名海盗舟之小制也。");
            // 泥沼
            AddTranslation("Mud", "泥");
            // 蘑菇
            AddTranslation("Mushrooms", "蕈");
            // 一批奇怪的蘑菇。它们吸引附近的任何东西。
            AddTranslation("A collection of strange mushrooms. They attract anything nearby.", "异蕈丛也。其能招近侧诸物。");
            // 方尖碑
            AddTranslation("Obelisk", "方尖碑");
            // 一块高高的神秘石头。
            AddTranslation("A tall mysterious stone.", "高而神异之石也。");
            // 献祭祭坛
            AddTranslation("Sacrificial Altar", "祀坛");
            // 一块扁平的神秘石头。
            AddTranslation("A flat mysterious stone.", "平而神异之石也。");
            // 木筏
            AddTranslation("Raft", "筏");
            // 洪水中的一块干地。
            AddTranslation("A dry patch in the flood.", "洪中燥地也。");
            // 避难所
            AddTranslation("Shelter", "庇");
            // 躲避暴风雨的避难所。
            AddTranslation("Shelter from the storm.", "避暴雨之所也。");
            // 诅咒图腾
            AddTranslation("Cursed Totem", "咒图腾");
            // 被神秘能量包围的图腾。
            AddTranslation("A totem surrounded in mysterious energy.", "神异之气环之之图腾。");
            // 我自己的衔尾蛇。
            AddTranslation("My very own Ouroboros.", "我之衔尾蛇。");
            // 木板
            AddTranslation("Wooden Board", "木板");
            // 一块普通的木板。
            AddTranslation("A regular wooden board.", "凡木板也。");
            // 鼹鼠大副
            AddTranslation("Mole Firstmate", "鼹大副");
            // 机械衔尾蛇
            AddTranslation("Ourobot", "衔尾机");
            // 活了的{0}
            AddTranslation("Living {0}", "活{0}");
            // 攻击强化
            AddTranslation("Attack Up", "益攻");
            // 在本场战斗中提升目标单位的攻击力。
            AddTranslation("Increases the target's attack for the rest of the battle.", "益所中者之威，至战终。");
            // 攻击削弱
            AddTranslation("Attack Down", "损攻");
            // 在本场战斗中降低目标单位的攻击力。
            AddTranslation("Decreases the target's attack for the rest of the battle.", "损所中者之威，至战终。");
            // 灭世灾变
            AddTranslation("Cataclysm", "大坏");
            // 当[creature]死亡时，牌桌上所有其他卡牌也将随之毁灭。
            AddTranslation("When [creature] dies, all other cards on the boards perish as well.", "[creature]死，则局上余牌皆灭。");
            // 直接伤害
            AddTranslation("Direct Damage", "直伤");
            // 对目标造成直接伤害。
            AddTranslation("Deals damage directly to a target.", "直伤所中。");
            // 直接治疗
            AddTranslation("Direct Heal", "直疗");
            // 治疗目标单位。该效果可使目标生命值超过其初始上限。
            AddTranslation("Heals the target. This can heal the target beyond its original max health.", "疗所中者，且得逾其本命之极。");
            // 双倍抽牌
            AddTranslation("Draw Twice", "再引");
            // 当[creature]死亡时，可额外抽取两张牌加入牌组。
            AddTranslation("When [creature] dies, draw two more cards and add them to your deck.", "[creature]死，则更引二牌，纳于牌列。");
            // 夺取控制
            AddTranslation("Gain Control", "夺御");
            // 夺取目标造物的控制权。
            AddTranslation("Takes control of the targeted creature.", "夺所中之物。");
            // 赋予印记
            AddTranslation("Give Sigils", "予印");
            // 将此卡的印记赋予目标卡牌。
            AddTranslation("Gives this card's sigils to the target.", "以此牌之印予所中者。");
            // 赋予属性
            AddTranslation("Give Stats", "予数");
            // 将此卡的属性赋予目标卡牌。
            AddTranslation("Gives this card's stats to the target.", "以此牌之数予所中者。");
            // 赋予属性与印记
            AddTranslation("Give Stats and Sigils", "予数与印");
            // 将此卡的属性与印记赋予目标卡牌。
            AddTranslation("Gives this card's stats and sigils to the target.", "以此牌之数与印予所中者。");
            // 法术（全局）
            AddTranslation("Spell (Global)", "术（周）");
            // 当这张卡牌在牌桌任意位置打出时，会立即产生效果并消失。
            AddTranslation("When this card is played anywhere on the board, it will cause an immediate effect and then disappear.", "此牌无论陈于局何处，皆即时生效而后灭。");
            // 全局法术。
            AddTranslation("GLOBAL SPELL.", "周术。");
            // 法术（全局，瞬发）
            AddTranslation("Spell (Global, Instant)", "术（周，立发）");
            // 当这张卡牌打出时，会立即产生效果并消失。
            AddTranslation("When this card is played, it will cause an immediate effect and then disappear.", "此牌既陈，即生其效而灭。");
            // 瞬发全局法术。
            AddTranslation("INSTA-GLOBAL SPELL.", "立发周术。");
            // 法术（定向）
            AddTranslation("Spell (Targeted)", "术（指）");
            // 当这张卡牌打出时，它会选定并影响牌桌上的一个位置，随后消失。
            AddTranslation("When this card is played, it will target and affect a chosen space on the board and then disappear.", "此牌既陈，则择局上一位而及之，旋即自灭。");
            // 定向法术。
            AddTranslation("TARGETED SPELL.", "指术。");
            // 命令（全局）
            AddTranslation("Command (Global)", "令（周）");
            // 当这张卡牌在牌桌任意位置打出时，会立即产生效果并消失。
            AddTranslation("When this card is played anywhere on the board, it will cause an immediate effect and then disappear.", "此牌无论陈于局何处，皆即时生效而后灭。");
            // 全局命令。
            AddTranslation("GLOBAL COMMAND.", "周令。");
            // 命令（全局，瞬发）
            AddTranslation("Command (Global, Instant)", "令（周，立发）");
            // 当这张卡牌打出时，会立即产生效果并消失。
            AddTranslation("When this card is played, it will cause an immediate effect and then disappear.", "此牌既陈，即生其效而灭。");
            // 瞬发全局命令。
            AddTranslation("INSTA-GLOBAL COMMAND.", "立发周令。");
            // 命令（定向）
            AddTranslation("Command (Targeted)", "令（指）");
            // 当这张卡牌打出时，它会选定并影响牌桌上的一个位置，随后消失。
            AddTranslation("When this card is played, it will target and affect a chosen space on the board and then disappear.", "此牌既陈，则择局上一位而及之，旋即自灭。");
            // 定向命令。
            AddTranslation("TARGETED COMMAND.", "指令。");
            // 机械海胆电池
            AddTranslation("Urch1n Cell", "机海胆匣");
            // 充能！
            AddTranslation("Charge!", "充能！");
            // 升级！
            AddTranslation("Upgrade!", "升级！");
            // 电击！
            AddTranslation("Zap!", "电击！");
            // 轰爆！
            AddTranslation("Blast!", "轰爆！");
            // 防御！
            AddTranslation("Defend!", "防御！");
            // 废料堆
            AddTranslation("Junk", "废堆");
            // 机械鲑鱼
            AddTranslation("S4LM0N", "机鲑");
            // 种子
            AddTranslation("Seed", "种");
        }
    }
}
