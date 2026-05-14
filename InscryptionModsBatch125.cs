using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch125
    {
        public static void RegisterTranslations()
        {
            RegisterLifeCostTwoAndEriOne();
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

        private static void RegisterLifeCostTwoAndEriOne()
        {
            // 唱一遍，再一遍，掷出骰子搏个变！
            AddTranslation("Sing it once, Sing it twice, take a chance and roll the dice!", "歌一再歌，掷骰以试命！");
            // 现金转换器
            AddTranslation("Cash Converter", "财易器");
            // 支付4枚箔片，在对手一侧的天平上放置1点伤害。
            AddTranslation("Pay 4 foils to put 1 damage on your opponent's side of the scale", "出四箔，于敌侧之衡置伤一。");
            // 生命转换器
            AddTranslation("Life Converter", "命易器");
            // 支付2点生命，获得1枚箔片。
            AddTranslation("Pay 2 life to gain 1 foils", "出二命，得一箔。");
            // 吸血之力
            AddTranslation("Vamperic Strength", "饮血之力");
            // 支付3点生命，使的攻击力和生命值各+1。
            AddTranslation("Pay 3 life to increase the power and health of this card by 1", "出三命，使此牌威与命各加一。");
            // 以血换钱
            AddTranslation("Blood for money", "以血市财");
            // 自残可提升力量。
            AddTranslation("Hurting oneself can lead to an increase in strength.", "自伤可益威。");
            // 贪婪之力
            AddTranslation("Greedy Strength", "贪力");
            // 支付5点货币，使的攻击力和生命值各+1。
            AddTranslation("Pay 5 currency to increase the power and health of this card by 1", "出五货，使此牌威与命各加一。");
            // 侵蚀一切触碰之物的水洼。
            AddTranslation("A puddle that errods all that touches it.", "一洼蚀凡所触者。");
            // 可受雇执行多种任务。
            AddTranslation("One can be hired to do many tasks", "可雇以任众事。");
            // 熊崽
            AddTranslation("Young Bear", "熊子");
            // 一只年幼的灰熊，已足够强壮可以自保。
            AddTranslation("A young grizzly, old enough to defend itself.", "幼灰熊也，已足自卫。");
            // 乌鸦
            AddTranslation("Crow", "乌鸦");
            // 不祥之鸦，死亡的预兆
            AddTranslation("The ominous crow, an omen of death", "不祥之鸦，死之征也。");
            // 电鳗，会电击目标身旁的造物。
            AddTranslation("The Electric Eel, it will shock the creatures next to its target", "电鳗，将电其所中者之旁物。");
            // 骷髅麋鹿
            AddTranslation("Elk Skeleton", "麋骸");
            // 这么矮？奇怪。
            AddTranslation("A short one? Strange", "短如是乎？怪哉。");
            // 马来蚁
            AddTranslation("Malaysian Ant", "马来蚁");
            // 马来蚁，会为保护巢穴自爆。
            AddTranslation("The Malaysian Ant, it will explode to protect the nest", "马来蚁，将为护巢而自爆。");
            // “笨重” 之鸟
            AddTranslation("'Heavy' Bird", "“重”鸟");
            // 真搞不懂这玩意儿居然还能飞。
            AddTranslation("I'm not sure how that one can still fly", "我不知彼何以尚能飞。");
            // 烹饪时通常要放大量大蒜，但这次我们用一头就够了。
            AddTranslation("In cooking, always use much garlic. But one should be sufficient for our purposes.", "烹鲜恒多用蒜，然于此一头足矣。");
            // 腐烂的大蒜
            AddTranslation("Rotting Garlic", "腐蒜");
            // 巨蛭
            AddTranslation("Giant Leech", "巨蛭");
            // 令人憎恶的害虫，会汲取敌人的生命力。
            AddTranslation("A nasty vermin, it will drain the lifeforce of it's foes", "恶虫也，将吸敌之生气。");
            // 大猩猩
            AddTranslation("Gorilla", "猩猩");
            // 强壮的大猩猩，将会带领你的队伍。
            AddTranslation("The powerful gorilla, it will lead your team", "猩猩强，将率汝伍。");
            // 俯冲鹰
            AddTranslation("Diving Hawk", "俯鹰");
            // 威严的雄鹰，捕猎着它的猎物。
            AddTranslation("The majestic hawk, hunting its prey", "鹰威而俯猎其禽。");
            // 翱翔鹰
            AddTranslation("Soaring Hawk", "翔鹰");
            // 威严的雄鹰，在天空中翱翔。
            AddTranslation("The majestic hawk, soaring in the sky", "鹰威而翔于天。");
            // 刺猬
            AddTranslation("Hedgehog", "猬");
            // 啊，这只聪慧的刺猬，总能迅速逃离危险。
            AddTranslation("Ah, the wise hedgehog. Swift to escape danger.", "猬亦智，避危甚疾。");
            // 凶猛的蜜獾，受到攻击时会变得更强。
            AddTranslation("The ferocious Honey Badger, it will grows stronger when attacked", "蜜獾猛，见攻则益强。");
            // 别小瞧这只食腐者的威力。
            AddTranslation("Don't underestimate the might of this scavenger", "毋轻此食腐者之威。");
            // 螳螂卵
            AddTranslation("Mantis Egg", "螳卵");
            // 假以时日，这枚卵会孵化成一只强悍的螳螂。
            AddTranslation("With time this egg will become a powerful mantis", "假以时日，此卵将成强螳。");
            // 对于一个向他人学唱曲调的家伙来说，这名字再合适不过了。
            AddTranslation("A fitting name, for one who learns its song from others.", "其名甚称，盖学歌于人者也。");
            // 真菌人
            AddTranslation("Myconid", "菌人");
            // 极易被激怒的真菌人，没人摸得透它们的底细。
            AddTranslation("The easily annoyed myconid, not quite sure what they're about", "菌人易怒，莫测其情。");
            // 橡树
            AddTranslation("Oak Tree", "橡");
            // 章鱼
            AddTranslation("Octopus", "章鱼");
            // 老山羊
            AddTranslation("Old Goat", "老羊");
            // 成神的山羊。这头早该被献祭了。
            AddTranslation("The apotheosized Goat. This one is long due for a sacrifice.", "神化之羊，此物久当受祀矣。");
            // 枭熊
            AddTranslation("Owlbear", "枭熊");
            // 凶猛的枭熊，会在敌阵中横冲直撞。
            AddTranslation("The savage Owlbear, it will rampage through its opponents.", "枭熊猛，将横突于敌阵。");
            // 枭猫
            AddTranslation("Owlcat", "枭猫");
            // 半猫半鸮……说到底就是个畸变怪物。
            AddTranslation("Half cat, half owl... an aberation really.", "半猫半枭，诚异孽也。");
            // 枭史莱姆
            AddTranslation("Owlslime", "枭涎");
            // 天啊……这只猫头鹰到底遭遇了什么？
            AddTranslation("Oh no... what happenned to that owl?", "呜呼……彼鸮何遭此乎？");
            // 鸭嘴兽
            AddTranslation("Platypus", "鸭嘴兽");
            // 它就是只鸭嘴兽。它们本来就不怎么动弹。
            AddTranslation("He's a platypus. They don't do much.", "彼特鸭嘴兽耳，本无多为。");
            // 真是令人惋惜的命运。但或许，他还有几分用处。
            AddTranslation("A regrettable fate. But perhaps he may be of some use, yet.", "命可惋也，然或尚可少用。");
            // 山谷浣熊
            AddTranslation("Valley Raccoon", "谷浣熊");
            // 这只阴险狡诈的浣熊，会借力打力，用对手的优势反过来对付他们。
            AddTranslation("The conniving raccoon, it will use the strenghts of his opponent against them", "浣熊狡，将因敌之强而反制之。");
            // 巨角羊
            AddTranslation("Big Horn", "巨角羊");
            // 这头威猛的公羊会扫清挡在你路上的一切障碍。
            AddTranslation("The powerful ram will clear most things standing in your way", "角羊强，凡当汝路者多为之扫除。");
            // 骷髅鼠
            AddTranslation("Rat Skeleton", "鼠骸");
            // 一具老鼠残骸……在资源极度匮乏时，根本没得挑。
            AddTranslation("The remnant of a rat... Can't be picky when you're starving for ressources", "鼠之馀骸耳。资穷而饥时，不得择也。");
            // 红狐狸
            AddTranslation("Red Fox", "赤狐");
            // 红狐狸，是温顺兔子心中的恐惧之源。
            AddTranslation("The red fox, a source of terror to the meek rabbit", "赤狐，柔兔之所畏。");
            // 巨型犀牛，它的冲锋势不可挡。
            AddTranslation("The massive Rhinoceros, nothing will stop its charge", "巨犀之冲，无可止者。");
            // 环尾狐猴
            AddTranslation("Ring-Tailed Lemur", "环尾狐猴");
            // 它就爱扭来扭去。
            AddTranslation("He likes to move it.", "彼乐于动之。");
            // 蜂皇浆
            AddTranslation("Royal Jelly", "王浆");
            // 这罐甜浆既招蚂蚁，也引蜜蜂。
            AddTranslation("This sweet jar attract both ants and bees", "此甘浆之罂，蚁与蜂皆集焉。");
            // 海獭
            AddTranslation("Sea Otter", "海獭");
            // 狡猾的海獭，会潜入水下猎杀水生生物。
            AddTranslation("The cunning sea otter, it will dive to kill submerged creature", "海獭狡，将潜而杀水伏之物。");
            // 蛇鹫
            AddTranslation("Secretary Bird", "蛇鹫");
        }
    }
}
