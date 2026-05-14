using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch20
    {
        public static void RegisterTranslations()
        {
            RegisterUndeadTempleInkcmMod();
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

        private static void RegisterUndeadTempleInkcmMod()
        {
            // 觉醒的女妖
            AddTranslation("Awakened Banshee", "觉女妖");
            // 一堆骨头，用骨头换取力量。
            AddTranslation("A pile of bones, paying for bones in exchange for strength.", "堆骨也，费骨以易威。");
            // 觉醒的骨堆
            AddTranslation("Awakened Bone Heap", "觉积骨");
            // 觉醒的寻骨猎犬
            AddTranslation("Awakened Bonehound", "觉寻骨犬");
            // 即使死了，它仍然忠诚。
            AddTranslation("Even after being dead, it remains loyal.", "虽死，犹忠。");
            // 觉醒的死人手
            AddTranslation("Awakened Dead Hand", "觉死手");
            // 死亡之手，却于苍生长存。
            AddTranslation("The hand of death, but with life.", "死之手，而犹有生。");
            // 觉醒的尸鬼
            AddTranslation("Awakened Draugr", "觉尸鬼");
            // 冰封的恶魔，出来吧。
            AddTranslation("Frozen ghouls, break and come out.", "冰鬼破而出。");
            // 觉醒的淹死鬼
            AddTranslation("Awakened DrownedSoul", "觉溺魂");
            // 溺水的灵魂带着怨恨在水中游荡。
            AddTranslation("The drowned soul wanders with resentment in the water.", "溺魂怀怨，而游于水。");
            // 觉醒的行师走人
            AddTranslation("Awakened Family", "觉行尸");
            // 意外死亡的家庭。
            AddTranslation("A family that died unexpectedly.", "横死之一家。");
            // 科学怪人。
            AddTranslation("Frankenstein.", "科学怪人。");
            // 产生源源不断的骷髅的幽灵船。
            AddTranslation("A ghost ship that produces a steady stream of skeletons.", "鬼舟绵生枯骨。");
            // 觉醒的幽灵船
            AddTranslation("Awakened Ghost Ship", "觉鬼舟");
            // 觉醒的弗兰肯和斯坦
            AddTranslation("Awakened Frank & Stein", "觉弗兰克与斯坦");
            // 觉醒的掘墓人
            AddTranslation("Awakened Gravedigger", "觉掘冢者");
            // 作为一个勤劳的掘墓人，他不断地提供骨头。
            AddTranslation("A diligent gravedigger, he constantly supplies bones.", "掘冢勤者，恒给以骨。");
            // 死亡骑士，地狱中的刺客。
            AddTranslation("Death Knight, the assassin in hell.", "死骑，狱中之刺者。");
            // 觉醒骑士
            AddTranslation("Awakened Knight", "觉骑士");
            // 觉醒的号角
            AddTranslation("Awakened Horn", "觉号");
            // 骨王摆脱了它的旧角，开始了自己的魔生，有朝一日将篡夺其主。
            AddTranslation("the bonelord sheds its old horns, they take on a life of their own, to one day usurp their masters.", "骨王脱其旧角，角乃自生，终将夺其主。");
            // 木乃伊之神
            AddTranslation("Mummy God", "木乃伊神");
            // 此乃恐怖之王。
            AddTranslation("The King of Terror.", "恐之王也。");
            // 觉醒的死灵法师
            AddTranslation("Awakened Necromancer", "觉死灵巫");
            // 生来就是为了复仇。
            AddTranslation("Born solely for revenge.", "生唯为雠。");
            // 觉醒的复生亡灵
            AddTranslation("Awakened Revenant", "觉逆生魂");
            // 一个可怕的石棺，里面封印着恶魔。
            AddTranslation("A formidable sarcophagus with terrifying creations sealed inside.", "可畏之石椁，内缄恶魅。");
            // 一堆骨头
            AddTranslation("Bone Pile", "堆骨");
            // 觉醒的一堆骨头
            AddTranslation("Awakened Bone Pile", "觉堆骨");
            // 觉醒的盗墓贼
            AddTranslation("Awakened Tomb Robber", "觉盗冢者");
            // 即使死了，仍然盗墓。
            AddTranslation("Even if he dies, he still robs tombs.", "虽死，犹盗冢。");
            // 一个绝望之人
            AddTranslation("A desperate man.", "绝望之人。");
            // 觉醒的丧尸
            AddTranslation("Awakened Zombie", "觉僵尸");
            // 噬魂亡灵
            AddTranslation("Devouring Soul", "噬魂");
            // 一个噬魂的骷髅。
            AddTranslation("A skeleton devouring the soul.", "噬魂之枯骨也。");
            // 觉醒的噬魂亡灵
            AddTranslation("Awakened Devouring Soul", "觉噬魂");
            // 觉醒的死人眼
            AddTranslation("Awakened Dead Eye", "觉死目");
            // 与死人手一同，犹如某个神的一部分身体。
            AddTranslation("Both Deadeye and Dead Hand are said to be body parts of the same, now dead, god.", "死目与死手，并为一已亡之神之体。");
            // 渡灵骨鸦
            AddTranslation("Ferry Crow", "渡灵鸦");
            // 觉醒的渡灵骨鸦
            AddTranslation("Awakened Ferry Crow", "觉渡灵鸦");
            // 死亡的灵鸦，俯视众生的哀嚎
            AddTranslation("The mournful cry of looking down upon the undead after death.", "死鸦下瞰亡者而哀号。");
            // 墓碑
            AddTranslation("Grave", "墓");
            // 我希望不会有人来打扰它
            AddTranslation("I hope no one will disturb it.", "愿无人扰之。");
            // 无头人
            AddTranslation("Headless Man", "无首人");
            // 一个不称职的无头人，好像在寻找他丢失的东西。
            AddTranslation("An incompetent headless person, as if searching for something he had lost.", "无首而拙者，若索其所失。");
            // 觉醒的犬舍
            AddTranslation("Awakened Kennel", "觉犬舍");
            // 一个犬舍，希望没人会打扰里面的东西。
            AddTranslation("A dog house, hopefully no one will mess with the things inside.", "犬舍也，愿无人扰其中物。");
            // 药剂师
            AddTranslation("Pharmacist", "药师");
            // 觉醒的药剂师
            AddTranslation("Awakened Pharmacist", "觉药师");
            // 一个死去的药剂师，他将毒死所有反对他的造物。
            AddTranslation("A dead pharmacist who poisons all creations that oppose him.", "死药师也，凡逆己之物，尽毒之。");
            // 亡灵领袖
            AddTranslation("Skeleader", "骨魁");
            // 亡灵领袖一旦上场，便会被骷髅包围。
            AddTranslation("A skeleton leader, once on stage, is surrounded by skeletons.", "骨魁一陈，即为枯骨所环。");
            // 觉醒的亡灵领袖
            AddTranslation("Awakened Skeleader", "觉骨魁");
            // 骷髅狙击手
            AddTranslation("Skeleton Sniper", "枯骨狙者");
            // 一位死去的狙击手。
            AddTranslation("A dead sniper.", "死狙者也。");
            // 觉醒的骷髅狙击手
            AddTranslation("Awakened Skeleton Sniper", "觉枯骨狙者");
            // 欺诈者
            AddTranslation("Threaded Skeleton", "悬丝骨");
            // 有些人生来就是傀儡，有些人死后仍掌控他人。
            AddTranslation("Some people are born puppets, while others still control others after death.", "或生而为傀，或死而犹制人。");
            // 觉醒的欺诈者
            AddTranslation("Awakened Threaded Skeleton", "觉悬丝骨");
            // 不死麋鹿
            AddTranslation("Undead Elk", "尸麋");
            // 不死麋鹿，生前的躯壳。
            AddTranslation("The undead elk, a former husk of of what it once was.", "尸麋者，其故壳耳。");
            // 不死小麋鹿
            AddTranslation("Undead Elk Cub", "尸麋仔");
            // 甚至死后也带着活力和欲望。
            AddTranslation("Even death carries vitality and desire.", "虽死，犹挟生气与欲。");
            // 不死驼鹿
            AddTranslation("Undead Moose", "尸驼鹿");
            // 一具久已逝去的雄伟野兽腐烂的尸体。
            AddTranslation("A rotting carcass of a long-departed imposing beast.", "雄兽久逝之腐骸也。");
            // 觉醒的不死驼鹿
            AddTranslation("Awakened Undead Moose", "觉尸驼鹿");
            // 劫掠亡灵
            AddTranslation("Undead Predator", "亡猎者");
            // 在战争中牺牲的战士永远不会屈服。
            AddTranslation("Warriors who die in war will never bow down.", "战而死之士，永不屈。");
            // 觉醒的劫掠亡灵
            AddTranslation("Awakened Undead Predator", "觉亡猎者");
            // 不死红鹿
            AddTranslation("Undead RedHart", "尸红鹿");
            // 它腐朽的心灵保留着牺牲的力量。
            AddTranslation("its decaying mind retains the strength of sacrifice.", "其腐心犹存祀力。");
            // 觉醒的不死红鹿
            AddTranslation("Awakened Undead RedHart", "觉尸红鹿");
            // 鳄龟残骸
            AddTranslation("Undead Snapper", "鳄龟骸");
            // 觉醒的鳄龟残骸
            AddTranslation("Awakened Undead Snapper", "觉鳄龟骸");
            // 僵硬的陆地造物的尸体。
            AddTranslation("The corpse of a stiff terrestrial creation.", "陆生之物僵骸也。");
            // 亡灵领袖
            AddTranslation("Skeleader", "骨魁");
            // 当放置[creature]时，骷髅牌将出现在相邻的空位。骷髅有：1力量，1生命，脆骨。
            AddTranslation("When placing [creature], skeleton cards will appear in nearby empty spaces. Skeleton has: 1 power, 1 health, Brittle.", "[creature]既陈，相邻空处皆生枯骨牌。枯骨者：1威、1命、脆骨。");
            // 原版亡灵族群卡牌
            AddTranslation("Original Undead Card", "原版亡族牌");
            // 原版第二幕中的亡灵族群卡包。
            AddTranslation("The cards for the Undead Tribe are in the original game.(ACT2)", "原戏第二幕之亡族牌包。");
            // 非原版亡灵族群卡包
            AddTranslation("NonOriginal Undead Card", "补缀亡族牌包");
            // 由模组作者原创的非原版亡灵族群卡包。
            AddTranslation("The expansion cards for the Undead Tribe are not in the original game.", "亡族增牌，非原戏所有。");
        }
    }
}
