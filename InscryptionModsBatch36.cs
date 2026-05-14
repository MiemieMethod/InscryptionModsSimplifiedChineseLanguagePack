using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch36
    {
        public static void RegisterTranslations()
        {
            RegisterSpecialStatsBatch();
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

        private static void RegisterSpecialStatsBatch()
        {
            // 该印记代表的数值等于牌桌上所有甲壳类族群造物的数量（包括对手的造物）。
            AddTranslation("The value represented with this sigil will be equal to the number of crustacean tribe creatures on the board, including opponent creatures.", "此印所表之数，如局上甲属诸物之数，敌物亦在焉。");
            // [creature]的力量等于牌桌上所有甲壳类族群造物的数量（包括对手的造物）。
            AddTranslation("[creature]s power is equal to the number of crustacean tribe creatures on the board, including opponent creatures.", "[creature]之威，如局上甲属诸物之数，敌物亦在焉。");
            // 伤害骰子
            AddTranslation("Damage Dice", "骰威");
            // 该印记初始数值为3，之后每回合开始时将随机变为1至6之间的数值。
            AddTranslation("The value represented with this sigil starts at 3, and will become a random number between 1 and 6 at the start of each subsequent turn.", "此印所表之数，始于三；后每合始，偶变为一至六。");
            // [creature]的攻击力初始为3，之后每回合开始时将随机变为1至6之间的数值。
            AddTranslation("[creature]s power starts at 3, and will become a random number between 1 and 6 at the start of each subsequent turn.", "[creature]之威始于三；后每合始，偶变为一至六。");
            // 伤害缩放
            AddTranslation("Damage Scaling", "败余");
            // 该印记代表的数值等于5减去你距离败北还需承受的伤害值。
            AddTranslation("The value represented with this sigil will be equal to five minus the amount of damage until you lose the game.", "此印所表之数，如五减汝至败所余受伤之数。");
            // [creature]的力量等于5减去你距离败北还需承受的伤害值。
            AddTranslation("[creature]s power is equal to five minus the amount of damage until you lose the game.", "[creature]之威，如五减汝至败所余受伤之数。");
            // 操盘手
            AddTranslation("Director Of The Board", "局督");
            // 该印记代表的数值等于牌桌上所有卡牌的数量，包括对手的卡牌。
            AddTranslation("The value represented with this sigil will be equal to the number of cards on the board, including opponent cards.", "此印所表之数，如局上诸牌之数，敌牌亦在焉。");
            // [creature]的力量等于牌桌上所有卡牌的总数，包括对手的造物。
            AddTranslation("[creature]s power is equal to the total number of cards on the board, including opponent creatures.", "[creature]之威，如局上诸牌之总数，敌物亦在焉。");
            // 抽离之力
            AddTranslation("Drawn Out", "引积");
            // 该印记代表的数值等于本回合内当持有者位于牌桌上时你抽牌的数量。
            AddTranslation("The value represented with this sigil will be equal to the number of cards you have drawn this turn while it's bearer is on the board.", "此印所表之数，如此合中其持者在局时汝所引之牌数。");
            // [creature]的力量等于本回合内当它位于牌桌上时你抽牌的数量。
            AddTranslation("[creature]s power is equal to the number of cards you have drawn this turn while it is on the board.", "[creature]之威，如此合中其在局时汝所引之牌数。");
            // 稀有传奇
            AddTranslation("Fabled", "罕传");
            // 该印记代表的数值等于牌桌上稀有造物数量的两倍。
            AddTranslation("The value represented with this sigil will be equal to twice the number of rare creatures on the board.", "此印所表之数，如局上罕有物数之再。");
            // [creature]的力量等于牌桌上稀有造物数量的两倍。
            AddTranslation("[creature]s power is equal to twice the number of rare creatures on the board.", "[creature]之威，如局上罕有物数之再。");
            // 火焰之力
            AddTranslation("Firepower", "火威");
            // 该印记代表的数值等于场上带有燃烧印记的造物数量。
            AddTranslation("The value represented with this sigil will be equal to the number of creatures on the board with the Burning sigil.", "此印所表之数，如局上有焚印之物数。");
            // [creature]的力量等于场上带有燃烧印记的造物数量。
            AddTranslation("[creature]s power is equal to the number of creatures on the board with the Burning sigil.", "[creature]之威，如局上有焚印之物数。");
            // 跟随领导
            AddTranslation("Follow The Leader", "随长");
            // 该印记代表的数值将等于你手牌中第一张卡牌的攻击力。
            AddTranslation("The value represented with this sigil will be equal to the attack power of the first card in your hand.", "此印所表之数，如汝手中首牌之威。");
            // [creature]的力量等于你手牌中第一张卡牌的攻击力
            AddTranslation("[creature]s power is equal to the attack power of the first card in your hand.", "[creature]之威，如汝手中首牌之威。");
            // 绿芽
            AddTranslation("Greenhorn", "绿角");
            // 该印记代表的数值等于卡牌打出时持牌人侧牌桌上绿宝石数量的两倍。
            AddTranslation("The value represented with this sigil will be equal to twice the number of Green gems on the owner's side of the board when the bearer was played.", "此印所表之数，如其既陈之时持牌者一侧局上绿玉数之再。");
            // [creature]的生命值等于其打出时持牌人侧牌桌上绿宝石数量的两倍。
            AddTranslation("[creature]s health is equal to twice the number of Green gems on it's owner's side of the board when it was played.", "[creature]之命，如其既陈之时持牌者一侧局上绿玉数之再。");
            // 半充能
            AddTranslation("Half Charged", "半充");
            // 该印记代表的数值等于玩家当前能量值的一半（向上取整）。
            AddTranslation("The value represented with this sigil will be equal to half the player's current energy, rounded up.", "此印所表之数，如玩家今能之半，分奇则进一。");
            // [creature]的力量等于你当前能量值的一半（向上取整）。
            AddTranslation("[creature]s power is equal to half your current energy, rounded up.", "[creature]之威，如汝今能之半，分奇则进一。");
            // 手按心
            AddTranslation("Hand On Heart", "按心");
            // 该印记代表的数值等于你手中的卡牌数。
            AddTranslation("The value represented with this sigil will be equal to the number of cards in your hand.", "此印所表之数，如汝手中牌数。");
            // [creature]的生命值等于你手中的卡牌数。
            AddTranslation("[creature]s health is equal to the number of cards in your hand.", "[creature]之命，如汝手中牌数。");
            // 生命伤害
            AddTranslation("Health Damage", "命威");
            // 该印记代表的数值等于携带者当前的生命值。
            AddTranslation("The value represented with this sigil will be equal to it's bearer's current health.", "此印所表之数，如其持者今命。");
            // [creature]的力量等于其生命值
            AddTranslation("[creature]s power is equal to its health.", "[creature]之威，如其命。");
            // 放牧兽
            AddTranslation("Herding Beast", "群蹄");
            // 该印记代表的数值等于牌桌上所有有蹄类族群造物的数量（包括对手的造物）。
            AddTranslation("The value represented with this sigil will be equal to the number of hooved tribe creatures on the board, including opponent creatures.", "此印所表之数，如局上蹄属诸物之数，敌物亦在焉。");
            // [creature]的力量等于牌桌上所有有蹄类族群造物的数量（包括对手的造物）。
            AddTranslation("[creature]s power is equal to the number of hooved tribe creatures on the board, including opponent creatures.", "[creature]之威，如局上蹄属诸物之数，敌物亦在焉。");
            // 亲石者
            AddTranslation("Lithophile", "亲石");
            // 该印记代表的数值等于牌桌上地形牌的数量。
            AddTranslation("The value represented with this sigil will be equal to the number of terrain cards on the board.", "此印所表之数，如局上地形牌数。");
            // [creature]的力量等于牌桌上地形牌的数量。
            AddTranslation("[creature]s power is equal to the number of terrain cards on the board.", "[creature]之威，如局上地形牌数。");
            // 魔法力量
            AddTranslation("Magicke Power", "术威");
            // 该印记代表的数值等于该卡牌通过漂白剂印记或艺术许可印记移除的印记数量。
            AddTranslation("The value represented with this sigil is equal to the number of sigils this card has removed with the Bleach Sigil or Artistic License Sigil.", "此印所表之数，如此牌以漂液印与艺纵印所去之印数。");
            // [creature]的力量等于其通过漂白剂印记或艺术许可印记移除的印记数量。
            AddTranslation("[creature]s power is equal to the number of sigils it has removed with the Bleach Sigil or Artistic License Sigil.", "[creature]之威，如其以漂液印与艺纵印所去之印数。");
            // 半只松鼠
            AddTranslation("One Half Squirrels", "半鼠");
            // 该印记代表的数值等于你方副牌组中剩余松鼠数量的一半。
            AddTranslation("The value represented with this sigil will be equal to half the number of Squirrels remaining in your side deck. ", "此印所表之数，如汝副牌中余松鼠数之半。");
            // [creature]的力量等于你方副牌组中剩余松鼠数量的一半。
            AddTranslation("[creature]s power is equal to half the number of Squirrels remaining in your side deck.", "[creature]之威，如汝副牌中余松鼠数之半。");
            // 犬之猎
            AddTranslation("Pack Hunter", "群犬");
            // 该印记代表的数值等于牌桌上犬类族群造物的总数，包括对手的造物。
            AddTranslation("The value represented with this sigil will be equal to the number of canine tribe creatures on the board, including opponent creatures.", "此印所表之数，如局上犬属诸物之数，敌物亦在焉。");
            // [creature]的力量等于牌桌上犬类族群造物的总数，包括对手的造物。
            AddTranslation("[creature]s power is equal to the number of canine tribe creatures on the board, including opponent creatures.", "[creature]之威，如局上犬属诸物之数，敌物亦在焉。");
            // 道具力量
            AddTranslation("Pack Power", "器威");
            // 该印记代表的数值等于持牌人持有的道具数量。
            AddTranslation("The value represented with this sigil will be equal to the number of items the owner holds.", "此印所表之数，如持牌者所执器数。");
            // [creature]的力量等于持牌人持有的道具数量。
            AddTranslation("[creature]s power is equal to the number of items it's owner holds.", "[creature]之威，如持牌者所执器数。");
            // 双重道具力量
            AddTranslation("Pack Power Plus", "重器威");
            // 该印记代表的数值等于持牌人持有道具数量的两倍。
            AddTranslation("The value represented with this sigil will be equal to twice the number of items the owner holds.", "此印所表之数，如持牌者所执器数之再。");
            // [creature]的力量等于持牌人持有道具数量的两倍。
            AddTranslation("[creature]s power is equal to twice the number of items it's owner holds.", "[creature]之威，如持牌者所执器数之再。");
            // 狂热血祭
            AddTranslation("Sanguine Bond", "血契");
            // 该印记代表的数值等于带有印记的造物被放置时该回合内做出的献祭次数。
            AddTranslation("The value represented with this sigil will be equal to the number of sacrifices made on the turn when the bearer was placed.", "此印所表之数，如其持者既陈之合中所祀之数。");
            // [creature]的力量等于其被放置时该回合内做出的献祭次数。
            AddTranslation("[creature]s power is equal to the number of sacrifices made on the turn when it was placed.", "[creature]之威，如其既陈之合中所祀之数。");
            // 罪食者
            AddTranslation("Sin Eater", "食罪");
            // 该印记代表的数值等于召唤该造物时被献祭造物携带的印记总数。
            AddTranslation("The value represented with this sigil will be equal to the amount of sigils present on the creatures that were sacrificed to play it's bearer.", "此印所表之数，如陈其持者时所祀诸物所带印之总数。");
            // [creature]的力量等于召唤该造物时被献祭造物携带的印记总数。
            AddTranslation("[creature]s power is equal to the amount of sigils present on the creatures that were sacrificed to play it.", "[creature]之威，如陈之时所祀诸物所带印之总数。");
            // 饥渴
            AddTranslation("Starved", "饥");
            // 该印记代表的数值等于7减去你牌组中剩余的卡牌数。
            AddTranslation("The value represented with this sigil will be equal to seven minus the number of cards left in your deck.", "此印所表之数，如七减汝牌列所余之牌数。");
            // [creature]的力量等于7减去你牌组中剩余的卡牌数
            AddTranslation("[creature]s power is equal to seven minus the number of cards left in your deck.", "[creature]之威，如七减汝牌列所余之牌数。");
            // 众志成城
            AddTranslation("Strength In Numbers", "众威");
            // 该印记代表的数值等于牌桌上所有带有相同印记的造物数量（包括对手造物）。
            AddTranslation("The value represented with this sigil will be equal to the number of creatures bearing this sigil on the board, including opponent creatures.", "此印所表之数，如局上有此同印之物数，敌物亦在焉。");
            // [creature]的力量等于牌桌上所有带有相同特殊伤害属性的造物数量（包括对手造物）。
            AddTranslation("[creature]s power is equal to the number of creatures bearing the same special damage stat on the board, including opponent creatures.", "[creature]之威，如局上有此同特伤数之物数，敌物亦在焉。");
            // 道具生命力
            AddTranslation("Trinket Vitality", "器命");
            // 该印记代表的数值等于持牌人持有道具数量的两倍。
            AddTranslation("The value represented with this sigil will be equal to double the number of items the owner holds.", "此印所表之数，如持牌者所执器数之再。");
            // [creature]的生命等于其持牌人持有道具数量的两倍。
            AddTranslation("[creature]s health is equal to twice the number of items it's owner holds.", "[creature]之命，如持牌者所执器数之再。");
            // 万维网
            AddTranslation("World Wide Web", "天网");
            // 该印记代表的数值等于牌桌上所有蛛形类族群造物的数量（包括对手的造物）。
            AddTranslation("The value represented with this sigil will be equal to the number of arachnid tribe creatures on the board, including opponent creatures.", "此印所表之数，如局上蛛属诸物之数，敌物亦在焉。");
            // [creature]的力量等于牌桌上所有蛛形类族群造物的数量（包括对手的造物）。
            AddTranslation("[creature]s power is equal to the number of arachnid tribe creatures on the board, including opponent creatures.", "[creature]之威，如局上蛛属诸物之数，敌物亦在焉。");
            // 忍住
            AddTranslation("Abstain", "止");
            // 丰产囤积狂
            AddTranslation("Dupeglitch", "孳囤");
            // 左前打击
            AddTranslation("Sinister Strike", "左斜击");
            // 横行霸道
            AddTranslation("Bully", "凌");
            // 集团
            AddTranslation("Legion", "军");
            // 血魔
            AddTranslation("Bloodborn", "血裔");
            // 占星师
            AddTranslation("Divination", "卜");
            // 寻墓者
            AddTranslation("Exhume", "发冢");
            // 天使坠落
            AddTranslation("Eternal", "恒");
            // 山羊召唤
            AddTranslation("Goated", "召羊");
            // 治疗师
            AddTranslation("Healer", "医");
        }
    }
}
