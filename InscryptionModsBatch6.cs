using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch6
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraConsumables();
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

        private static void RegisterGrimoraConsumables()
        {
            // 骨质号角
            AddTranslation("Bone Horn", "骨角");
            // 骨质号角会耗尽你当前所有的灵魂，但每消耗1个灵魂可获得1根骨头。
            AddTranslation("The Bone Horn, drains all of your current Soul but you gain a bone for each soul consumed.", "骨角，尽汲汝今之魂，而每耗一魂，得一骨。");
            // 消耗你的全部灵魂，每消耗1个灵魂给予1根骨头。虽是不幸的牺牲，但物有所值。
            AddTranslation("Gives you a bone for each of your Souls, which are spent in the process, an unfortunate, but worthwhile sacrifice.", "尽费汝之魂，每耗一魂，予汝一骨。虽为凶祀，然其直可取。");
            // 死人手
            AddTranslation("Dead Hand", "死手");
            // 死人手会以牺牲旧手牌为代价，为你抽取新的手牌。
            AddTranslation("The Dead Hand, draws you a new Hand of cards at the cost of your old one.", "死手，捐汝旧手，而更引一手之牌。");
            // 某位忘却之神的断掌，已自成生命。你知晓其威能。
            AddTranslation("The severed hand of a forgotten god, left to take on a life of its own. You know what this does.", "忘神之一断掌，离而自生。其用，汝知之矣。");
            // 防腐液
            AddTranslation("Embalming Fluid", "殓液");
            // 将防腐液倒在卡牌上，可使其获得1点生命值与1点攻击力。
            AddTranslation("The Embalming Fluid, pour it over a card and it will gain one health and attack.", "以殓液沃一牌，则其命与威各增一。");
            // 准备为你的军团成员进行防腐处理，在此过程中提升其耐力与活力！
            AddTranslation("Prepare to put a member of your army to rest, increasing its stamina and vigor as you do so!", "今将安汝军中一员，而其间益其命与力。");
            // 墓雕师之凿
            AddTranslation("Gravecarvers Chisel", "刻墓凿");
            // 使用墓雕师之凿，可从已阵亡的卡牌中选择任意一张加入手牌。
            AddTranslation("The Gravecarvers chisel, select any card that has died previously to add to your hand.", "用刻墓者之凿，可自先死之牌中择任一牌纳于手。");
            // 某位神秘造物者遗留的工具，莫非墓吟者雕像也出自他手？
            AddTranslation("A tool left behind by a mysterious creator, did he carve the gravebards statue too?", "神秘制者所遗之一器。墓吟者之像，亦彼所刻乎？");
            // 灵魂瓮
            AddTranslation("Soul Urn", "魂瓮");
            // 灵魂瓮，消耗所有灵魂，每消耗1个灵魂可提升1点灵魂上限。
            AddTranslation("The Soul Urn, spend all of your Soul and gain maximum Soul capacity for each Soul consumed.", "魂瓮，尽费汝之诸魂，而每耗一魂，魂极增一。");
            // 它会取走你所有的灵魂，但会按取走量提升上限。我某位老相识管这叫投资回报。
            AddTranslation("Takes all of your Soul but increases your maximum by the amount taken, a certain acquaintance of mine would call this a return on investment.", "尽取汝之魂，而以其数增其极；余一故人，必曰此反本之利。");
            // 木槌
            AddTranslation("Mallet", "槌");
            // 木槌，敲打卡牌使其变得脆弱并失去1点生命值。
            AddTranslation("The Mallet, Whack a Card, it will become brittle and loose 1 Hp.", "槌一牌，则使之脆骨而损一命。");
            // 看似滑稽实则残忍。伤害卡牌并使其变得脆弱。
            AddTranslation("You'd think this is comical, but it is quite cruel. Injures a card and leaves it frail.", "若似滑稽，实甚残忍。伤一牌，而使之脆。");
            // 羽笔
            AddTranslation("Quill", "羽笔");
            // 吾之专属羽笔，可复制场上任意卡牌加入手牌。
            AddTranslation("My very own Quill, this lets you copy any card on the field to put in your hand.", "此余自用之羽笔，使汝摹局中任一牌，纳于手中。");
            // 此乃吾之工具，暂借于汝。汝应已见识其威能。
            AddTranslation("My very own tool, i will lend it to you for now. Youve seen this in action, havent you?", "此余自用之器，今姑借汝。其效，汝既见之矣乎？");
            // 船之瓶
            AddTranslation("Ship Bottle", "舟瓶");
            // 瓶中船，用一群坏血病骷髅船员填满整个战场。
            AddTranslation("The Ship in a Bottle, fills the entire board with a scurvy Skeleton Crew.", "舟瓶，举局尽满以坏血枯骨之伍。");
            // 用骷髅填满整个战场！真正的海盗作风，罗亚尔会为此骄傲的。
            AddTranslation("Fills the entire board with skeletons! Like a real Pirate, Royal would be proud.", "尽以枯骨满局。真海上之盗之为也，罗亚尔必以为荣。");
            // 盐津津达瑞尔
            AddTranslation("Salty Daryl", "盐达里尔");
            // 大脏牙巴里
            AddTranslation("Browntooth Barrie", "褐牙巴里");
            // 干巴瘦斯普林特
            AddTranslation("Bonnie Splinter", "裂木邦妮");
            // 走私鬼贝瑟尔
            AddTranslation("Freebooter Bethel", "私掠贝瑟尔");
            // 疯橡木疙瘩海沃德
            AddTranslation("Crazy Oakes Hayward", "狂橡海沃德");
            // 邋遢鬼阿什顿
            AddTranslation("Ashton Swabby", "水卒阿什顿");
            // 跳大海布拉顿
            AddTranslation("Plankton Braxton", "浮藻布拉克斯顿");
            // 黄眼仁儿科尔比
            AddTranslation("Yeller-eye Colby", "黄眼科尔比");
            // 卖鱼佬内特
            AddTranslation("Fishwife Nate", "鱼贾内特");
            // 缺手指弗雷德
            AddTranslation("Four-finger Fred", "四指弗雷德");
            // 野狗朱莉
            AddTranslation("Dawg Julie", "野犬朱莉");
            // 鬼心眼儿琼斯
            AddTranslation("Wicked Jones", "恶琼斯");
            // 螃蟹脸斯蒂勒
            AddTranslation("Crabby Steele", "蟹面斯蒂勒");
            // 碎裂的野猪存钱瓶
            AddTranslation("Slivered Hoggy Bank", "碎裂之豕匮");
            // 碎裂的野猪存钱瓶，最多可额外获得2根骨头，共三次。
            AddTranslation("The Slivered Hoggy bank, gain 2 extra bones up to three times.", "碎裂之豕匮，至多三用，每用复得二骨。");
            // 这件被遗忘时代的遗物，能在紧要关头为你提供额外骨头。
            AddTranslation("A relic from an age forsaken, this will grant you some extra bones in a pinch", "弃世之遗物也，急时可增汝数骨。");
            // 碎裂的野猪存钱瓶2
            AddTranslation("Slivered Hoggy Bank2", "碎裂之豕匮二");
            // 碎裂的野猪存钱瓶，可额外获得2根骨头，剩余两次。
            AddTranslation("The Slivered Hoggy bank, gain 2 extra bones, two more times.", "碎裂之豕匮，复得二骨，尚可再用二次。");
            // 碎裂的野猪存钱瓶3
            AddTranslation("Slivered Hoggy Bank3", "碎裂之豕匮三");
            // 碎裂的野猪存钱瓶，可额外获得2根骨头，剩余一次。
            AddTranslation("The Slivered Hoggy bank, gain 2 extra bones, one more time.", "碎裂之豕匮，复得二骨，尚可再用一次。");
            // 泥铲
            AddTranslation("Trowel", "泥铲");
            // 泥铲可随机挖掘一块地形，并获取若干骨头。
            AddTranslation("The Trowel, dig up a random terrain and gain a few Bones.", "泥铲，可偶掘一地形，而得数骨。");
            // 这曾是掘墓人的工具。既能挖掘宝藏，亦可翻动地形，还能让你白捡几根骨头。
            AddTranslation("This used to belong to a gravedigger. Digs for treasure, or Terrain. And get some Bones too for your efforts.", "此故掘冢者之器也。可掘宝，可掘地形，而亦使汝徒得数骨。");
        }
    }
}
