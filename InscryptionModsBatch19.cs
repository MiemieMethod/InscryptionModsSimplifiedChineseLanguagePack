using System.Collections.Generic;
using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch19
    {
        public static void RegisterTranslations()
        {
            RegisterGemWarnings();
            RegisterMagnificusLateDialogueFour();
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

        private static void RegisterGemWarnings()
        {
            Dictionary<GemType, string> gemTypesEn = new Dictionary<GemType, string>
            {
                { GemType.Orange, "Orange" },
                { GemType.Blue, "Blue" },
                { GemType.Green, "Green" },
            };
            Dictionary<GemType, string> gemTypes = new Dictionary<GemType, string>
            {
                { GemType.Orange, "橙" },
                { GemType.Blue, "蓝" },
                { GemType.Green, "绿" },
            };

            foreach (var gemType in gemTypes.Keys)
            {
                // 你的橙/蓝/绿玛珂不足两颗，无法使用此牌
                AddTranslation(
                    "You don't have two " + HintsHandler.GetColorCodeForGem(gemType) + gemTypesEn[gemType] + "</color> gems to play that.",
                    "无二" + HintsHandler.GetColorCodeForGem(gemType) + gemTypes[gemType] + "</color>玉，故不能陈此牌。");
                // 牌桌上需要有两颗橙/蓝/绿玛珂
                AddTranslation(
                    "You need two " + HintsHandler.GetColorCodeForGem(gemType) + gemTypesEn[gemType] + "</color> gems on the board.",
                    "局上须有二" + HintsHandler.GetColorCodeForGem(gemType) + gemTypes[gemType] + "</color>玉。");
            }
        }

        private static void RegisterMagnificusLateDialogueFour()
        {
            // 咋了
            AddTranslation("whats up", "何哉");
            // 我的[c:g1]黏液法师[c:]败于你手……我本对他期望更高些……
            AddTranslation("My [c:g1]Goo Mage[c:] falls by your hands.. I expected more from him..", "我[c:g1]胶巫[c:]败于子手……吾本望之更厚……");
            // 哼……我的[c:g1]黏液法师[c:]又一次让我失望……
            AddTranslation("Hmph.. My [c:g1]Goo Mage[c:] dissapoints me again..", "哼……我[c:g1]胶巫[c:]复令吾失望……");
            // 再一次，我可怜的[c:g1]黏液法师[c:]倒下了……
            AddTranslation("Yet again, my pathetic [c:g1]Goo Mage[c:] falls..", "复矣，我可悯之[c:g1]胶巫[c:]又仆……");
            // [c:g1]什么……？[c:][c:g2]我，[c:][c:g1]败了……？[c:]
            AddTranslation("[c:g1]What..?[c:] [c:g2]Me,[c:] [c:g1]defeated..?[c:]", "[c:g1]何……？[c:][c:g2]吾，[c:][c:g1]败矣……？[c:]");
            // [c:g1]呃啊……[c:][c:g2]我[c:][c:g1]被[c:][c:g2]你[c:][c:g1]击败了？？[c:]
            AddTranslation("[c:g1]Blargh..[c:] [c:g2]I've[c:] [c:g1]been[c:] [c:g2]taken[c:] [c:g1]out[c:] [c:g2]by[c:] [c:g1]you??[c:] ", "[c:g1]呃啊……[c:][c:g2]吾[c:][c:g1]竟[c:][c:g2]为[c:][c:g1]子[c:][c:g2]所败[c:]？？");
            // [c:g1]不可能……[c:][c:g2]我[c:][c:g1]居然[c:][c:g2]输了……[c:]
            AddTranslation("[c:g1]Impossible..[c:] [c:g2]I've[c:] [c:g1]been[c:] [c:g2]defeated..[c:]", "[c:g1]不可……[c:][c:g2]吾[c:][c:g1]竟[c:][c:g2]败矣……[c:]");
            // 啊……看来你打败了我的[c:g2]长矛法师[c:]……
            AddTranslation("Ahh.. I see you've defeated my [c:g2]Pike Mage[c:]..", "噫……子已败我[c:g2]矛巫[c:]矣……");
            // 我的[c:g2]长矛法师[c:]倒下了……真令人失望
            AddTranslation("My [c:g2]Pike Mage[c:] falls.. Dissapointing.", "我[c:g2]矛巫[c:]既仆……可惋。");
            // 我承认挑战者……你比大多数人都走得更远
            AddTranslation("I'll admit challenger.. You've gotten farther than most.", "角者，吾认之……子逾众人远矣。");
            // [c:g2]真是[c:][c:g3]一场[c:][c:g2]精彩[c:][c:g3]对决[c:][c:g2]啊！[c:]
            AddTranslation("[c:g2]A[c:] [c:g3]fantastic[c:] [c:g2]duel[c:] [c:g3]we[c:] [c:g2]had![c:]", "[c:g2]此[c:] [c:g3]诚[c:] [c:g2]妙[c:] [c:g3]角[c:] [c:g2]也！[c:]");
            // [c:g2]这[c:][c:g3]是[c:][c:g2]场[c:][c:g3]绝妙[c:][c:g2]战斗[c:]
            AddTranslation("[c:g2]'Twas[c:] [c:g3]an[c:] [c:g2]excellent[c:] [c:g3]battle.[c:]", "[c:g2]此[c:] [c:g3]诚[c:] [c:g2]善战[c:]。");
            // [c:g2]打[c:][c:g3]得[c:][c:g2]漂亮[c:][c:g3]年轻法师[c:]
            AddTranslation("[c:g2]Great[c:] [c:g3]fighting,[c:] [c:g2]young[c:] [c:g3]mage.[c:]", "[c:g2]战[c:] [c:g3]善矣，[c:] [c:g2]少巫[c:]。");
            // 很好挑战者……既然你已击败[c:g3]孤独巫师[c:]，现在可以面对我了
            AddTranslation("Well challenger.. Now that you have defeated the [c:g3]Lonely Mage[c:]. You may now face me.", "然矣，角者……子既败[c:g3]孤巫[c:]，今可当吾。");
            // 你已击败我所有学徒……我将恭候你的到来
            AddTranslation("You've defeated all my students.. I will await your arrival.", "子已败我诸弟子……吾将待子之至。");
            // 我的[c:g3]孤独巫师[c:]败北了……出乎意料……但现在，我静候你的到来
            AddTranslation("My [c:g3]Lonely Mage[c:] falls.. this is unexpected.. But now, I await your arrival.", "我[c:g3]孤巫[c:]既败……此出吾料外……然今吾待子来。");
            // [c:g3]真是[c:][c:g1]场[c:][c:g3]精彩[c:][c:g1]较量！[c:]
            AddTranslation("[c:g3]An[c:] [c:g1]excellent[c:] [c:g3]fight![c:]", "[c:g3]善[c:] [c:g1]角[c:]！");
            // [c:g3]即便[c:][c:g1]动用[c:][c:g3]最致命的[c:][c:g1]典籍，[c:][c:g3]你仍[c:][c:g1]获胜了！[c:]
            AddTranslation("[c:g3]Despite[c:] [c:g1]my[c:] [c:g3]deadliest[c:] [c:g1]books,[c:] [c:g3]you[c:] [c:g1]still[c:] [c:g3]won![c:]", "[c:g3]虽[c:] [c:g1]吾[c:] [c:g3]尽用[c:] [c:g1]最毒之书，[c:] [c:g3]子[c:] [c:g1]犹胜[c:]！");
            // [c:g3]你竟[c:][c:g1]能[c:][c:g3]破解[c:][c:g1]我最[c:][c:g3]致命的[c:][c:g1]魔典，[c:][c:g3]令人[c:][c:g1]印象深刻！[c:]
            AddTranslation("[c:g3]You[c:] [c:g1]managed[c:] [c:g3]to[c:] [c:g1]overcome[c:] [c:g3]my[c:] [c:g1]deadliest[c:] [c:g3]tomes,[c:] [c:g1]impressive![c:]", "[c:g3]子[c:] [c:g1]竟能[c:] [c:g3]胜[c:] [c:g1]吾最毒之典，[c:] [c:g3]异哉！[c:]");
            // [c:g3]哎哟！[c:][c:g1]看来[c:][c:g3]你[c:][c:g1]得[c:][c:g3]好好[c:][c:g1]钻研[c:][c:g3]玛珂[c:][c:g1]了[c:]
            AddTranslation("[c:g3]Whoops![c:] [c:g1]Looks[c:] [c:g3]you[c:] [c:g1]need[c:] [c:g3]to[c:] [c:g1]study[c:] [c:g3]up[c:] [c:g1]on[c:] [c:g3]mox.[c:]", "[c:g3]噫！[c:] [c:g1]子[c:] [c:g3]尚须[c:] [c:g1]深学[c:] [c:g3]玛珂[c:]。");
            // 我的长矛法师又击败了一个对手……
            AddTranslation("My Pike Mage bests another opponent...", "我矛巫复胜一敌……");
            // 太令人失望了……
            AddTranslation("Dissapointing...", "可惋……");
            // [c:g1]又[c:][c:g2]一个[c:][c:g1]灵魂[c:][c:g2]归[c:][c:g1]我[c:][c:g2]所有[c:][c:g1]了。[c:][c:g2]滚[c:][c:g1]去[c:][c:g2]深渊[c:][c:g1]吧，[c:][c:g2]永远[c:][c:g1]别[c:][c:g2]回来[c:]
            AddTranslation("[c:g1]Yet[c:] [c:g2]another[c:] [c:g1]soul[c:] [c:g2]I[c:] [c:g1]claim.[c:] [c:g2]Banish[c:] [c:g1]yourself[c:] [c:g2]to[c:] [c:g1]the[c:] [c:g2]depths,[c:] [c:g1]and[c:] [c:g2]do[c:] [c:g1]not[c:] [c:g2]return.[c:]", "[c:g1]又[c:] [c:g2]一[c:] [c:g1]魂[c:] [c:g2]归[c:] [c:g1]吾[c:]矣。[c:] [c:g2]自逐[c:] [c:g1]于深渊[c:]，[c:g2]毋[c:] [c:g1]复来[c:]。");
            // 又一位学徒，被我的孤独巫师偷袭得手……
            AddTranslation("Yet another student, hit off guard by my Lonely Mage..", "又一弟子，为我孤巫所乘……");
            // 你都走到这一步了……
            AddTranslation("You got so far.....", "子已行至此……");
            // 真弱。
            AddTranslation("Weak.", "弱哉。");
            // [c:g2]再会了，[c:][c:g3]年轻的[c:][c:g2]法师！[c:][c:g3]真是[c:][c:g2]一场[c:][c:g3]精彩[c:][c:g2]对决。[c:]
            AddTranslation("[c:g2]Farewell,[c:] [c:g3]young[c:] [c:g2]mage![c:] [c:g3]'Twas[c:] [c:g2]a[c:] [c:g3]fantastic[c:] [c:g2]duel.[c:]", "[c:g2]别矣，[c:] [c:g3]少巫[c:]！[c:g2]此[c:] [c:g3]诚[c:] [c:g2]妙角[c:]。");
            // ~ 黏液地牢 ~
            AddTranslation("~ Goo Dungeon ~", "~ 胶狱 ~");
            // ~ 熔岩地牢 ~
            AddTranslation("~ Lava Dungeon ~", "~ 熔狱 ~");
            // ~ 虚空地牢 ~
            AddTranslation("~ Void Dungeon ~", "~ 虚狱 ~");
            // ~ 魔法之塔 ~
            AddTranslation("~ Tower of Magicks ~", "~ 术塔 ~");
            // 空白玛珂
            AddTranslation("Blank Mox", "虚玛珂");
            // 你的副牌组玛珂效果完全随机
            AddTranslation("Your sidedeck's mox is completely random.", "子副牌列之玛珂，皆偶然也。");
            // 弱漂白剂
            AddTranslation("Weaker Bleach", "弱漂液");
            // 漂白事件将不再能移除负面印记
            AddTranslation("The Bleaching Event can no longer remove negative sigils.", "漂事不复能去负印。");
            // 回合崩盘
            AddTranslation("Turn Wipeout", "合崩");
            // 若在第6回合后（首领战为第12回合）敲换手铃，你将受到1点伤害
            AddTranslation("When you ring the bell past turn 6 (12 on bosses) you take 1 damage.", "六合后（魁战则十二合）鸣铃，则子受一伤。");
            // 更强对手
            AddTranslation("Stronger Opponent", "强敌");
            // 对战对手初始额外获得5点生命值
            AddTranslation("Your battle opponent starts with 5 extra health points.", "战敌始得外加五命。");
            // 微型法术书
            AddTranslation("Tiny Spellbook", "小咒书");
            // 你的法术书只能容纳4个法术，而非8个
            AddTranslation("Your spellbook can only hold 4 spells instead of 8.", "子之咒书惟容四咒，不及八。");
            // 怨灵缠身
            AddTranslation("Displeased Spirits", "怨灵缠身");
            // 这片被诅咒的土地永远充满怨念
            AddTranslation("The enchanted grounds will always be displeased.", "此附地常不悦。");
            // 坚甲之壳
            AddTranslation("Armored Shell", "坚甲");
            // 每回合敌方最多承受4点伤害
            AddTranslation("Your opponent cant take more than 4 damage per turn.", "每合敌所受伤不过四。");
            // 铁处女
            AddTranslation("Iron Maiden", "铁闺");
            // 每回合开始时，持牌人侧牌桌上的每张玛珂牌会受到1点伤害
            AddTranslation("Every turn, each mox on your side of the board takes 1 damage.", "每合，子侧局上诸玛珂各受一伤。");
            // 魔法涂料
            AddTranslation("Magickal Paint", "术丹");
            // 待出卡牌偶尔会被额外绘制上印记
            AddTranslation("Queued cards will occasionally get additional sigils painted on them.", "待陈之牌，间见加绘其印。");
            // 转瞬生命
            AddTranslation("Fleeting Life", "浮命");
            // 初始生命值为75，但战斗间不会恢复
            AddTranslation("You have 75 health, but it does not replenish inbetween battles.", "子始有七十五命，然战间不复。");
            // 侵扰之影
            AddTranslation("Intrusive Presence", "侵影");
            // 不受欢迎的存在将跟随你进入卡牌对战
            AddTranslation("An unwelcome prescence will follow you into card battles.", "不速之在，将从子入牌战。");
            // 大师头目
            AddTranslation("Master Bosses", "大师诸魁");
            // 所有头目战都会替换为玛珂大师之一
            AddTranslation("Every bossfight is replaced with one of the Mox Masters.", "诸魁战皆易为诸玛珂大师之一。");
            // 宝石依赖的开局
            AddTranslation("Gem Dependant Starters", "依玉初牌");
            // 起始手牌中的卡牌均带有宝石依赖印记
            AddTranslation("Cards in your starting deck have the gem dependant sigil.", "子初牌列诸牌皆负依玉之印。");
            // 蔓尼菲科挑战关卡：{0}
            AddTranslation("Magnificus Challenge Level: {0}", "蔓尼菲科角竞阶：{0}");
            // 蔓尼菲科挑战点数：{0}
            AddTranslation("Magnificus Challenge Points: {0}", "蔓尼菲科角竞点：{0}");
        }
    }
}
