using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch110
    {
        public static void RegisterTranslations()
        {
            RegisterFloweysTwo();
            RegisterUndertaleOne();
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

        private static void RegisterFloweysTwo()
        {
            // 小花的防御被降到了0！
            AddTranslation("Floweys Defence dropped to [c:bR]0!", "小花之御降于[c:bR]0[c:]！");
            // 不！！！
            AddTranslation("[c:bR]NOOOOOO", "[c:bR]不！！！[c:]");
            // 刚刚……发生了什么？
            AddTranslation("What just happened...", "适才……何事生矣？");
            // 哼，看来这次是你赢了……
            AddTranslation("Hmph seemms you have won this time...", "哼，此番似汝胜矣……");
            // 没有人会来帮你的！
            AddTranslation("[c:bR]NOBODY IS GOING TO HELP YOU!", "[c:bR]无人将来援汝！[c:]");
            // 别再呼救了！
            AddTranslation("STOP CALLING FOR [c:bR]HELP!", "毋复呼[c:bR]援[c:]！");
            // 你真的以为我会这么轻易让你杀了我？
            AddTranslation("[c:bR]Did you really think id let you kill me so easily?", "[c:bR]汝真谓我肯使汝易杀我乎？[c:]");
            // 什、什么——
            AddTranslation("[c:bR]what the-", "[c:bR]何、何——[c:]");
            // 小花还真以为，它能随便利用我啊……
            AddTranslation("[c:bR]Flowey thought they could just use me...", "[c:bR]小花真谓可恣用我乎……[c:]");
            // 它甚至连我究竟是什么都不清楚！
            AddTranslation("[c:bR]He didnt even know what I am!", "[c:bR]彼甚至不知我为何物！[c:]");
            // 但现在，掌控一切的人是我……
            AddTranslation("[c:bR]But now IAM in control...", "[c:bR]然今制之者我也……[c:]");
            // 真是可悲，它居然没把自己的生命值设成无限……我可不会犯这种低级错误。
            AddTranslation("[c:bR]How pathetic of him to not set his HP to Infinite... I won't make that mistake", "[c:bR]其不以己命设为无极，诚可哀也……我不犯此失。[c:]");
            // 尽你所能，你也杀不了我！
            AddTranslation("[c:bR]Try all you want you can't kill me!", "[c:bR]汝尽力为之，亦不能杀我！[c:]");
            // 现在，来瞧瞧这玩意儿到底有什么用……
            AddTranslation("[c:bR]Now lets see what this does...", "[c:bR]今试观此物果何用……[c:]");
            // 为什么我不能重置这一切？！
            AddTranslation("[c:bR]WHY CANT I UNDO THIS???", "[c:bR]何为我不能反此？？？[c:]");
            // 看着你一次次死掉，可真是有趣极了！
            AddTranslation("SEEING YOU DIE OVER AND OVER AGIAN IS REALLY [c:bR]FUN!", "见汝一死再死，诚[c:bR]快[c:]甚矣！");
            // 连一丝一毫的伤害都打不出来！
            AddTranslation("NOT EVEN A SINGLE POINT OF DAMAGE!", "一丝之伤亦不能致！");
            // 就凭你，根本赢不了我！
            AddTranslation("SOMEONE LIKE [c:bR]YOUCANT BEAT ME!", "若[c:bR]汝[c:]者，终不能胜我！");
            // 饥饿可打断不了这场战斗！
            AddTranslation("[c:bR]Starvation wont interrupt this fight!", "[c:bR]饥不能中绝此战！[c:]");
        }

        private static void RegisterUndertaleOne()
        {
            // 《传说之下》卡包
            AddTranslation("Card Pack:U", "《传说之下》牌韬");
            // 亚伦
            AddTranslation("Aaron", "亚伦");
            // 啊没错，勇猛的亚伦，俊美的亚伦。你难道能把目光从它的肌肉上挪开吗？
            AddTranslation("Ah yes, Aaron the bold, aaron the beautiful. can you manage to take your eyes off his muscles?", "噫，亚伦勇矣，亚伦美矣。汝能移目于其肌乎？");
            // 艾菲斯
            AddTranslation("Alphys", "艾菲斯");
            // 艾菲斯博士正是你在这里见到的，那些让人不安的“个体”的创造者……或者说，我该称他们为“多元体”？
            AddTranslation("Dr. Alphys is responsible for the creation of some of the more 'unnerving' individuals you've seen here... or should I say... MULTI-viduals.", "艾菲斯博士，正此间诸“可悚之体”之造者也……抑当谓之“多体”乎？");
            // 这生物既惹人怜爱，又带着股烦人的劲儿。这般矛盾的两面性，简直独一无二。
            AddTranslation("Loveable, yet pestulant. The duality of this creature is unparalleled.", "其物可爱而复烦人，其二端之并，无与比也。");
            // 艾斯戈尔
            AddTranslation("Asgore", "艾斯戈尔");
            // 怪物之王……它无疑是靠着纯粹的蛮力就能让人望而生畏的存在，但除此之外……竟也藏着一份慈悲之心？
            AddTranslation("The king of monsters... he truly is an intimidating force of brute strength, but also... compassion?", "怪物之王也……其威惟蛮力已足使人惧，然其间……亦有慈乎？");
            // 艾斯利尔·逐梦
            AddTranslation("asriel dreemurr", "艾斯利尔·逐梦");
            // 地底世界最强大的存在……但愿你能派上他的用场。
            AddTranslation("the most powerful being in the underground... hopefully you find some use for him.", "地下最强之有也……愿汝得其所用。");
            // 散光眼
            AddTranslation("Astigmatism", "散光眼");
            // 这恼人的散光眼……真是让人捉摸不透。
            AddTranslation("The frustrating astigmatism... it can't make up its mind.", "此散光眼恼人……其意终未能定。");
            // 龙骨炮
            AddTranslation("Gaster Blaster", "龙骨炮");
            // 冰块
            AddTranslation("Block of Ice", "冰块");
            // 一块出奇大的冰块……谁知道里面藏着什么呢。
            AddTranslation("A peculiarly large ice cube... Who knows what could be inside.", "一冰块大而异……孰知其中何有。");
            // 查拉
            AddTranslation("Chara", "查拉");
            // 狗来米
            AddTranslation("Dogamy", "狗来米");
            // 狗来米与妻子狗媳儿，最爱在战场上默契配合联合作战。切记别让它们中的任何一方倒下……
            AddTranslation("Dogamy and his wife, Dogaressa, love to tag-team the battlefield. Just don't let one of them perish...", "狗来米与其妻狗媳儿，最喜并力于战。慎勿使其一者死……");
            // 狗媳儿
            AddTranslation("Dogaressa", "狗媳儿");
            // 遁狗
            AddTranslation("Doggo", "遁狗");
            // 啊，那只盲眼遁狗……但凡有半点动静，它都会猛地扑过去。
            AddTranslation("Ah, the blind doggo... He leaps towards any sound of movement.", "噫，此盲遁狗也……凡闻动响，辄跃赴之。");
            // 涂鸦沼泽
            AddTranslation("doodlebog", "涂鸦沼泽");
            // 人偶
            AddTranslation("Dummy", "人偶");
            // 这尊呆板的人偶……可远不如它那“生气”的同类有魅力。
            AddTranslation("the bland dummy... not as charismatic as its 'mad' counterpart", "此人偶平然，不若其“怒”类之有姿也。");
            // 融合怪
            AddTranslation("Amalgamate", "融怪");
            // 聚合犬
            AddTranslation("Endogeny", "聚犬");
            // 无
            AddTranslation("null", "无");
            // 终极蛙吉特
            AddTranslation("Final Froggit", "终蛙吉特");
            // 可不是嘛，这蛙吉特的终极头目形态……却和那些低阶的同类一样，照样轻易就能糊弄过去。
            AddTranslation("Ah yes, the ultimate boss of froggits... Still as easily fooled as its lesser evolved kin.", "终蛙吉特者，蛙辈之极魁也……然犹与其下类同，易欺如故。");
            // 弗里斯克
            AddTranslation("Frisk", "弗里斯克");
            // 蛙吉特
            AddTranslation("Froggit", "蛙吉特");
            // 可不是嘛，这蛙吉特天生胆小得很……打心底里不愿卷入纷争。真是可惜啊。
            AddTranslation("Ah yes, as shy as they come... the froggit wishes not to engage in conflict. how unfortunate.", "蛙吉特性至怯……本不欲预争。惜哉。");
            // 加斯特
            AddTranslation("W.D.Gaster", "加斯特");
            // 格莱德
            AddTranslation("glyde", "格莱德");
            // 这家伙自恋到了极点，非得有张牌在跟前供它自我欣赏，才肯出手攻击。
            AddTranslation("Such a narcisist, it can only attack if a card is in front of it to watch.", "其自爱之甚，必前有一牌可观，而后始攻。");
            // 大犬汪
            AddTranslation("Greater Dog", "大犬汪");
            // 它堪称犬类演化的终极形态，名副其实，完美得无可挑剔。
            AddTranslation("truly and nobly adequate, it is the highest form of evolution a canine can become.", "其诚为犬属之极形，完足无玷。");
            // 礼物鹿
            AddTranslation("Gyftrot", "礼鹿");
            // 善待这只生灵吧，它已经承受了太多。
            AddTranslation("Be kind to this creature, it has gone through enough.", "善待此生，其所经已多矣。");
            // 冰狼
            AddTranslation("Ice Wolf", "冰狼");
            // 可不是嘛，这只壮硕的家伙一倒下，就会生成一块冰块。
            AddTranslation("Ah yes, this buff creature spawns a block of ice upon death.", "此壮物一死，则生一冰块。");
            // 冰帽盖
            AddTranslation("Icecap", "冰帽盖");
            // 杰瑞
            AddTranslation("Jerry", "杰瑞");
            // 赶紧别管他了。
            AddTranslation("Just ditch him already.", "速舍之。");
            // 晚安骑士
            AddTranslation("Knight Knight", "晚安骑士");
            // 呵，那散发着不祥气息的晚安骑士……乃是执掌沉眠的守夜者。她在这场征伐之中，从无半分懈怠。
            AddTranslation("ah, the forboding knight knight... a sentinel of sleep. She is relentless in her conquest..", "噫，此晚安骑士不祥……乃眠之戍者也。其征伐未尝少懈。");
            // 柠檬面包
            AddTranslation("Lemon Bread", "柠檬面包");
            // 小犬汪
            AddTranslation("Lesser Dog", "小犬汪");
            // 顶天了也就算只平平无奇的犬类……至少以它现在的形态来看是这样。
            AddTranslation("A mediocre canine at best... at least in its current form.", "上不过中犬耳，至少就其今形言之。");
            // 卢克眼
            AddTranslation("Loox", "卢克眼");
            // 狡黠的卢克眼……你最好别去招惹它。
            AddTranslation("The cunning Loox EyeWalker... you would be wise not to pick on him.", "卢克眼狡矣，汝勿撄之为智。");
            // 生气的人偶
            AddTranslation("Mad Dummy", "怒人偶");
            // 人偶？
            AddTranslation("Dummy?", "人偶？");
            // 外表是会骗人的……
            AddTranslation("Looks can be deceiving...", "貌可欺人……");
            // 疯狂魔术师
            AddTranslation("Madjick", "狂术士");
            // 真是个厉害的魔法师……
            AddTranslation("quite the magician...", "真术者也……");
            // 记忆脑
            AddTranslation("Memoryhead", "忆首");
        }
    }
}
