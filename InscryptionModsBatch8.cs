using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch8
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraFurtherCards();
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

        private static void RegisterGrimoraFurtherCards()
        {
            // 木乃伊之王
            AddTranslation("Mummy Lord", "木乃伊王");
            // 一切延续死后生命的尝试皆属徒劳，但死灵法师仍在坚持。他必须如此。
            AddTranslation("ALL EFFORTS TO PRESERVE LIFE AFTER DEATH HAVE BEEN FUTILE, YET THE NECROMANCER GOES ON. HE HAS TO.", "凡续死后之生者，悉徒劳矣；然死灵巫犹行之。其不得不然。");
            // 死灵法师
            AddTranslation("Necromancer", "死灵巫");
            // 一个喜欢把别人拖入水底坟墓的麻烦湖灵。
            AddTranslation("A troublesome lake spirit that enjoys dragging others down to a watery grave.", "为人患之湖灵，好曳人入水冢。");
            // 水妖
            AddTranslation("Nixie", "水妖");
            // 苍白病态贵族的蹒跚尸骸。它一边剥落腐肉，一边散播污秽。
            AddTranslation("The shambling corpse of a pale, sickly noble. it spreads it's filth as it sheds it's flesh.", "苍白病贵之蹒跚尸也。其脱肉之际，亦散其秽。");
            // 诺斯费拉图
            AddTranslation("Nosferat", "诺斯费拉图");
            // 古银币
            AddTranslation("Ancient Obol", "古奥波勒");
            // 真相终将揭晓。这枚欧宝银币比时间本身更古老，时机成熟时自会显现真容。
            AddTranslation("IT WILL ALL MAKE SENSE SOON. THE OBOL IS OLDER THAN TIME ITSELF, AND THUS IT WILL REVEAL ITSELF IN DUE TIME.", "其义旋当自明。奥波勒古于时，故其形终将自著。");
            // 独臂强盗
            AddTranslation("One Armed Bandit", "独臂盗");
            // 十步试炼夺走了他一条胳膊，最终要了他的命。
            AddTranslation("Took the ten paces, that ordeal cost him an arm, and his life.", "十步之试，既夺其臂，亦夺其生。");
            // 常言道善终即善。常言时间如衔尾之蛇，无始无终，唯有轮回。
            AddTranslation("IT IS SAID ALL IS WELL THAT ENDS. IT IS SAID TIME IS LIKE AN OUROBOROS, IT DOES NOT END, IT ONLY REPEATS ITSELF.", "或云终善则皆善。又云时若衔骨蛇，无终也，惟自反耳。");
            // 衔骨蛇
            AddTranslation("Ourobones", "衔骨蛇");
            // 疫医
            AddTranslation("Plague Doctor", "疫医");
            // 他诊断出亡灵们罹患恶疾。唯一的解药就是死亡。
            AddTranslation("HE HAS DETERMINED THE UNDEAD ARE SICK WITH A TERRIBLE ILLNESS. THE ONLY CURE IS DEATH.", "彼断亡者罹剧疾。其唯一之疗，惟死。");
            // 邪恶的捣蛋鬼，恶灵非常享受自己的死亡。
            AddTranslation("AN EVIL TRICKSTER, THE POLTERGEIST HAS ENJOYED THEIR DEATH VERY MUCH.", "恶戏之灵，甚乐其死。");
            // 恶灵
            AddTranslation("Poltergeist", "恶灵");
            // 一套被邪灵附体的古老盔甲。她的铁拳会将更多造物拖入战场。
            AddTranslation("A suit of ancient armour in which an occult spirit has taken up residence. Her iron fist drags more creatures to the fight.", "古甲一具，邪魂处其中。其铁拳曳更多物以赴战。");
            // 附魔铠甲
            AddTranslation("Possessed Armour", "附魂甲");
            // 一场失败的实验，妄图创造死亡之舞却徒劳无功。它们无法协同运作。
            AddTranslation("AN EXPERIMENT GONE WRONG, IN A FUTILE ATTEMPT TO CREATE A DANSE MACCABRE. THEY DO NOT FUNCTION TOGETHER.", "实验之败也，徒欲成死舞，而终不相用。");
            // 实验体
            AddTranslation("Project", "试物");
            // 你不该看到这个
            AddTranslation("You shouldnt be seeing this right now", "今不当见此。");
            // 无形造物
            AddTranslation("Random Cards", "无形牌");
            // 手持死亡镰刀的复生亡灵，只为复仇而生。
            AddTranslation("BRINGING THE SCYTHE OF DEATH, THE REVENANT SEEKS ONLY REVENGE.", "执死镰而来，逆生魂所求惟雠。");
            // 复生亡灵
            AddTranslation("Revenant", "逆生魂");
            // 开膛手
            AddTranslation("Ripper", "剖者");
            // 开膛手信奉暴力解决一切。它会用纯粹的蛮力粉碎所有阻碍，正面击溃任何难题。
            AddTranslation("THE RIPPER SOLVES EVERYTHING THROUGH SHEER STRENGTH. IT WILL PUNCH ANY ISSUE STRAIGHT IN THE FACE AND SOLVE IT, TOO.", "彼恃纯威以断万事。凡事之当面者，辄拳而破之。");
            // 真是个奇迹，这家伙居然还没散架！不过要是想逃跑的话，那条胳膊可能会掉下来。
            AddTranslation("It's a wonder this one has stayed together! Though it may lose that arm if it tries to flee.", "异哉，其尚未散！然若欲遁，则其臂或坠。");
            // 腐尸
            AddTranslation("Rotten", "腐尸");
            // 抽搐的手臂
            AddTranslation("Twitching Arm", "搐臂");
            // 诡秘的储物柜
            AddTranslation("The elusive Locker.", "诡柜也。");
            // 戴维·琼斯的储物柜
            AddTranslation("Davy Jones Locker", "戴维·琼斯之柜");
            // 黄胡子
            AddTranslation("Yellowbeard", "黄须");
            // 蓝胡子
            AddTranslation("Bluebeard", "蓝须");
        }
    }
}
