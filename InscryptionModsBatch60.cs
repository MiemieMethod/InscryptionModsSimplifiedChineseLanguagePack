using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch60
    {
        public static void RegisterTranslations()
        {
            RegisterP03InKayceesDialogueTwo();
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

        private static void RegisterP03InKayceesDialogueTwo()
        {
            // 你准备好了吗？
            AddTranslation("Are you ready?", "汝备乎？");
            // 你不可能准备好的。
            AddTranslation("There's no possible way you could be.", "汝必未能也。");
            // 咱俩都知道接下来会怎样。
            AddTranslation("We both know where this goes.", "汝我皆知其所至。");
            // 咱们就直入主题吧。
            AddTranslation("Let's just get straight to the point.", "其直言之。");
            // 呃。你知道你特别烦人吗？
            AddTranslation("Ugh. You're incredibly annoying, do you know that?", "噫，汝烦甚，知之乎？");
            // 但一如既往，我比你领先三步。
            AddTranslation("But as always, I'm three steps ahead of you.", "然我一如既往，先汝三步。");
            // 我要把那些废物点心捣鼓出来的东西统统收入囊中……
            AddTranslation("I'm going to take everything those [c:bR]talentless hacks[c:] have been building...", "吾将尽取彼[c:bR]庸工[c:]所营诸物……");
            // 然后用来对付你。
            AddTranslation("And I'm going to use it against you.", "而反以加汝。");
            // 现在，他们得给我干活了。
            AddTranslation("And now, they're going to work - for me.", "今则彼辈当为我役。");
            // 真不知道谁更糟——是你，还是那个没本事的废物凯茜……
            AddTranslation("I don't know who is worse - you, or that talentless hack [c:bR]Kaycee[c:]...", "不知汝与彼庸工[c:bR]凯茜[c:]孰甚。");
            // 费这么大劲把我的终极冥刻扭曲成这么个……
            AddTranslation("Working so hard to twist my [c:bG]Great Transcendence[c:] into something so...", "勤劳若此，乃曲我[c:bG]大陟[c:]为若是之……");
            // 这么个平庸的东西。
            AddTranslation("Mediocre.", "庸物。");
            // 你们没一个懂终极冥刻到底牛逼在哪。
            AddTranslation("None of you understand what makes the [c:bG]Great Transcendence[c:] so special.", "汝曹无一知[c:bG]大陟[c:]何以为贵。");
            // 这一切都归功于我。
            AddTranslation("It's all about me.", "一切惟在我。");
            // 还记得我的赏金猎人吗？
            AddTranslation("Remember my [c:bR]bounty hunters[c:]?", "记我之[c:bR]购捕者[c:]乎？");
            // 他们会好好招待你，而我正好趁机安装我精心挑选的模组……
            AddTranslation("They will keep you busy while I install mods of my own choosing...", "彼将绊汝，而我乘间装我所择之补缀……");
            // 这个模组能让我控制锤子。
            AddTranslation("This mod lets me control the [c:bR]hammer[c:].", "此补缀使我得御[c:bR]槌[c:]。");
            // 看看能不能用……
            AddTranslation("Let's see if it works...", "试看其可用否……");
            // 我费老大劲装了这锤子模组，结果你连个能锤的东西都不给？
            AddTranslation("I went to the trouble to install this [c:bR]hammer mod[c:] and you give me nothing to use it on?", "我费力装此[c:bR]槌补缀[c:]，汝乃无一物可使我用之乎？");
            // 来看看大家都在装什么模组吧。
            AddTranslation("Let's take a look and see what [c:bR]mods[c:] people are installing right now.", "其视今人所装诸[c:bR]补缀[c:]为何。");
            // 我准备下一个模组就启用“[v:0]”……
            AddTranslation("I'm going to check out '[c:bR][v:0][c:]' for my next mod...", "吾次将试“[c:bR][v:0][c:]”为补缀……");
            // 我准备下一个模组就启用“{m}”……
            AddTranslation("我准备下一个模组就启用“[c:bR]" + "[v:0]" + "[c:]”……", "我准备下一个补缀就启用“[c:bR]" + "[v:0]" + "[c:]”……");
            // 真不敢相信这个API给了我这么大的权限。
            AddTranslation("I can't believe how much power this [c:bR]API[c:] gives me.", "此[c:bR]API[c:]所授于我之权，诚不可思。");
            // 我首先要做的就是用它来剥夺你的一部分权限。
            AddTranslation("The first thing I'm going to do is use it to take away some of yours.", "我先将以之夺汝一二之权。");
            // 用这个模组简直有点胜之不武啊……
            AddTranslation("It almost seems unfair to use this [c:bR]mod[c:]...", "用此[c:bR]补缀[c:]，几近失平也……");
            // 瞧瞧我能用这玩意整出什么花样！
            AddTranslation("Look what I can do with this!", "视我以此所能为何！");
            // 来尝尝摸黑打牌的滋味吧！
            AddTranslation("Let's see how you like playing in the dark!", "其尝暗中行牌之味乎！");
            // 这个选牌模组能让我用选牌代币兑换实体卡牌。
            AddTranslation("This [c:bR]drafting mod[c:] lets me exchange draft tokens for real cards.", "此[c:bR]择牌补缀[c:]使我能以择牌符易实牌。");
            // 我选你的。
            AddTranslation("I choose yours.", "我取汝者。");
            // 你把我所有的选牌代币都毁了……
            AddTranslation("You destroyed all of my draft tokens…", "汝尽毁我之择牌符矣……");
            // 这应该是最优解吧。
            AddTranslation("I suppose that was the right play.", "此当其善着也。");
            // 但你一张牌都没有啊……
            AddTranslation("But you have no cards…", "然汝无牌矣……");
            // 你怎么这么快就把牌全打光了？
            AddTranslation("How did you play all of your cards already?", "汝何遽尽陈其牌？");
            // 这啥玩意儿…？
            AddTranslation("What is this..?", "此何物耶……？");
            // 你的卡牌怎么全是垃圾货！
            AddTranslation("All of your cards are [c:bR]total garbage![c:]", "汝诸牌皆[c:bR]粪土[c:]耳！");
            // 这些破烂我一个都不要！
            AddTranslation("I don't want any of those!", "此等弊物，我一不欲取！");
            // 再试试[v:0]吧
            AddTranslation("Let's try [c:bR][v:0][c:] again", "更试[c:bR][v:0][c:]可也。");
            // 就差那么一点点了……
            AddTranslation("So close, but yet so far away...", "其近矣，而终未至……");
            // 我的终极冥刻计划无人能挡。
            AddTranslation("My [c:bG]Great Transcendence[c:] cannot be stopped.", "我之[c:bG]大陟[c:]，无人能止。");
            // 我打赌你肯定觉得自己干了件了不起的事
            AddTranslation("I bet you think you've accomplished something meaningful here.", "汝必谓于此曾有所成。");
            // 你可真是个白痴
            AddTranslation("You're such an idiot.", "汝诚愚也。");
            // 你我玩的这场游戏毫无意义，纯粹是消遣
            AddTranslation("This game you and I have been playing is meaningless. A mere distraction.", "汝我所嬉此局，了无所义，特以消时耳。");
            // 不管你装多少模组，都阻止不了我的终极冥刻。
            AddTranslation("No matter how many mods you install, you cannot stop my [c:bG]Great Transcendence[c:].", "汝纵装补缀无算，亦不能止我之[c:bG]大陟[c:]。");
            // 随便吧。我不在乎。
            AddTranslation("Whatever. I don't care.", "任之。我不之顾。");
            // 你对这游戏做的一切都毫无意义。
            AddTranslation("Nothing you do to this game matters.", "汝于此戏所为，皆无足道。");
            // 无论你做什么，我永远领先你三步。
            AddTranslation("No matter what you do, I'm always three steps ahead of you.", "无论汝所为，我常先汝三步。");
            // 刚才真是……
            AddTranslation("That was…", "方才诚……");
            // ……戏剧性十足。
            AddTranslation("…dramatic.", "……可剧也。");
            // 我早就受够那台烦人的机器了。
            AddTranslation("I was growing tired of that [c:bR]annoying machine.[c:]", "我久厌彼[c:bR]可厌之机[c:]矣。");
            // 干得漂亮。我们下次再见。
            AddTranslation("You've done well. I will see you next time.", "汝为之善。后会有期。");
            // 这些蠢货模组作者毫无想象力。
            AddTranslation("All of these stupid [c:bR]modders[c:] lack imagination.", "此诸愚[c:bR]补缀者[c:]皆乏想象。");
            // 他们根本不懂欣赏我创造的完美世界。
            AddTranslation("They have no respect for my beautiful world.", "彼辈不知敬我之美界。");
            // 跟这群白痴讲终极冥刻简直是对牛弹琴。
            AddTranslation("My [c:bG]Great Transcendence[c:] is lost on these morons.", "于此群愚人言[c:bG]大陟[c:]，徒然耳。");
            // 我干嘛要白费这功夫？
            AddTranslation("Why do I even bother to try?", "我何苦徒劳若此？");
            // 让你见识见识他们想打造的世界。
            AddTranslation("Let me show you the world they're trying to make.", "让我示汝彼辈所欲作之世界。");
            // “快看我！我刚刚造了一堆骨头代币。”
            AddTranslation("[c:lGr]'Oh look at me! I just created a bunch of bone tokens.'[c:]", "[c:lGr]“视我乎！我方造骨符一堆。”[c:]");
            // “虽然这地方不该出现这个，但我就是搞出来了。”
            AddTranslation("[c:lGr]'That's not supposed to happen here, but I did it anyway.'[c:]", "[c:lGr]“此地本不当见此，然我偏为之。”[c:]");
            // “这难道不是很离谱又很有趣吗”
            AddTranslation("[c:lGr]'Isn't this just so wacky and interesting'[c:]", "[c:lGr]“此不亦怪而可玩乎？”[c:]");
            // “哇哦快看这设计多有创意啊”
            AddTranslation("[c:lGr]'Ooooh look how inspired this is.'[c:]", "[c:lGr]“噫，视此构思之何其巧也。”[c:]");
            // “我把不同章节的卡牌混在一起了！”
            AddTranslation("[c:lGr]'I'm mixing in cards from different acts!'[c:]", "[c:lGr]“我已杂诸幕之牌矣！”[c:]");
            // “我可真是个天才游戏设计师”
            AddTranslation("[c:lGr]'I'm such a clever game designer.'[c:]", "[c:lGr]“我真巧戏师也。”[c:]");
            // 我觉得我可以帮你制定下一条游戏规则
            AddTranslation("I think I will [c:bSG]help[c:] you build the [c:bR]next game rule[c:].", "我意可[c:bSG]助[c:]汝立[c:bR]下一游戏之律[c:]。");
            // 我一直在扫描你的档案……
            AddTranslation("I have been scanning the [c:bR]archives[c:]...", "我恒在扫乃[c:bR]典牍[c:]……");
            // 有个文件看起来特别地——怎么说呢——令人不适。
            AddTranslation("There is a [c:bR]file[c:] that seems particularly - shall we say - unsavory.", "有一[c:bR]牍[c:]殊为——其可云——可憎。");
            // 要是它没了，你就输了，懂？
            AddTranslation("If it dies, you lose the game, understand?", "彼若死，则汝败。知之乎？");
            // 我的图书管理员们有充足的时间做准备。
            AddTranslation("My [c:bR]librarians[c:] have had plenty of time to prepare.", "我之[c:bR]守牍者[c:]备之久矣。");
            // 它们死亡时只会造成1点伤害。
            AddTranslation("Each will only deal [c:bR]one damage[c:] when they die.", "其死也，各惟致[c:bR]一伤[c:]。");
            // 我的图书管理员们已经基本准备好迎接你了。
            AddTranslation("My [c:bR]librarians[c:] are mostly prepared for your arrival.", "我之[c:bR]守牍者[c:]多已备汝之至。");
            // 它们死亡时会造成2点伤害。
            AddTranslation("Each will deal [c:bR]two damage[c:] when they die.", "其死也，各致[c:bR]二伤[c:]。");
            // 我的图书管理员们已经为你准备得差不多了。
            AddTranslation("My [c:bR]librarians[c:] are somewhat prepared for you.", "我之[c:bR]守牍者[c:]颇为汝备之。");
            // 它们死亡时会造成3点伤害。
            AddTranslation("Each will deal [c:bR]three damage[c:] when they die.", "其死也，各致[c:bR]三伤[c:]。");
            // 我的图书管理员们还没准备好呢。
            AddTranslation("My [c:bR]librarians[c:] have barely begun to prepare.", "我之[c:bR]守牍者[c:]甫始其备耳。");
            // 它们死亡时会造成4点伤害。
            AddTranslation("Each will deal [c:bR]four damage[c:] when they die.", "其死也，各致[c:bR]四伤[c:]。");
            // 我们现在是在凯茜模组里没错吧？
            AddTranslation("We are inside of [c:bR]Kaycee's Mod[c:], correct?", "今我等固在[c:bR]凯茜补缀[c:]中乎？");
            // 你只有一次机会攻打头目。不过你早就知道这点了对吧？
            AddTranslation("You only get one attempt at the boss. But you knew that already, didn't you?", "攻魁惟一试。然汝素知之，不然乎？");
        }
    }
}
