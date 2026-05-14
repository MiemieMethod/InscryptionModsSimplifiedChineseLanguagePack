using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch109
    {
        public static void RegisterTranslations()
        {
            RegisterMagModExpansionThree();
            RegisterFloweysOne();
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

        private static void RegisterMagModExpansionThree()
        {
            // 生机终焉
            AddTranslation("Healthy Death", "生尽");
            // 消亡时，其左右两侧的卡牌各恢复1点生命值。
            AddTranslation("When a card bearing this sigil perishes, the cards to the left and right of the sigil bearer heal 1 health.", "负此印契之牌死，则其左右诸牌各复一命。");
            // 魔力混沌
            AddTranslation("Mana Mess", "法乱");
            // 打出时，抽一张随机的非稀有魔力消耗型卡牌。
            AddTranslation("When a card bearing this sigil is played, draw a random non-rare Mana costing card.", "负此印契之牌既陈，则引一偶得非法力费之罕牌。");
        }

        private static void RegisterFloweysOne()
        {
            // 小花
            AddTranslation("Flowey", "小花");
            // 一名狂热的领袖，一心要通过幕后阴谋复活伟大的克苏鲁，从而开启末日。
            AddTranslation("A fanatical leader hell-bent on bringing about the apocalypse by reviving the great Cthulhu through behind-the-scenes scheming.", "一狂热之长也，务以幕后之谋复大克苏鲁，而启末世。");
            // 你个蠢货
            AddTranslation("You Idiot", "汝愚哉");
            // 你要是觉得能打败我，那你可真是个蠢货！
            AddTranslation("You really are an Idiot if you think you can defeat me!", "汝若谓能胜我，诚愚矣！");
            // 终极小花
            AddTranslation("Omega Flowey", "极小花");
            // 你真是个蠢货。
            AddTranslation("You really are an idiot.", "汝诚愚也。");
            // 耐心
            AddTranslation("Patience", "忍");
            // 耐心。
            AddTranslation("patient.", "忍。");
            // 勇气
            AddTranslation("Bravery", "勇");
            // 勇气。
            AddTranslation("Brave.", "勇。");
            // 诚实
            AddTranslation("Integrity", "诚");
            // 诚实。
            AddTranslation("integrant.", "诚。");
            // 毅力
            AddTranslation("Perseverence", "毅");
            // 毅力。
            AddTranslation("Persevering.", "毅。");
            // 仁慈
            AddTranslation("Kindness", "慈");
            // 仁慈。
            AddTranslation("Kind.", "慈。");
            // 正义
            AddTranslation("Justice", "义");
            // 正义。
            AddTranslation("Justice.", "义。");
            // 你好——啊不对，你准备好去死了吗？
            AddTranslation("Howdy- Uh i meant Are you ready to Die?", "安——呃，我谓：汝备死乎？");
            // 你好！我叫小花，一朵叫小花的花！
            AddTranslation("Howdy! it's me Flowey, Flowey the Flower!", "安！我乃小花，小花之花也！");
            // 你知道这儿正在发生什么，对吧？
            AddTranslation("You know whats going on here, dont you?", "此间何事，汝知之乎？");
            // 你只是想看我受苦！
            AddTranslation("You just wanted to see me suffer[c:0]!", "汝徒欲见我苦耳[c:0]！");
            // 你知道吗，我一直在盯着你。
            AddTranslation("Do You know that ive been watching you?", "汝知我常伺汝乎？");
            // 现在《邪恶冥刻》已经归我掌控了！
            AddTranslation("Well i took over Inscryption now!", "今《冥勒》已归我制矣！");
            // 而且我还知道，《邪恶冥刻》背后隐藏着怎样的秘密……
            AddTranslation("and i know what Secrets are hiding beneath Inscryption...", "且我知《冥勒》之下所藏诸秘……");
            // 现在，没有任何东西能阻挡我征服世界的脚步了！
            AddTranslation("Now nothing stands in my Way to take over the World now!", "今更无物能沮我取天下矣！");
            // 你以为这场战斗的意义是什么？
            AddTranslation("What do you think this Fight was about?", "汝谓此战何为乎？");
            // 我不过是拿这场战斗当幌子，去偷偷翻阅《邪恶冥刻》的文件罢了！
            AddTranslation("I just used it as a cover to snoop through Inscryptions Files!", "我徒假此战为幌，以潜阅《冥勒》之牍耳！");
            // 当然，还有你的电脑！
            AddTranslation("And your PC of course!", "当然，亦及汝机！");
            // 你大概也察觉到了吧，没错——我现在已经连上互联网了！
            AddTranslation("And you may have noticed, BUT iam now connected to the Internet!", "汝殆已觉之矣——然，我今已通于网矣！");
            // 好了，现在是时候开始上传《邪恶冥刻》了！
            AddTranslation("So now its time to begin Uploading Inscryption!", "今其时也，始上传《冥勒》矣！");
            // 你真的是个蠢货！
            AddTranslation("You REALLY are an Idiot!", "汝真愚哉！");
            // 有了这份旧数据，我连人类灵魂的力量都压根不需要了！
            AddTranslation("I don't even need the Power of Human Souls if i just use the OLD_DATA!", "我苟用旧_档，则人魂之力亦无所须！");
            // 你以为这么做能得到什么？不过是一场空罢了。
            AddTranslation("[c:bR]Do you know what you are achieving by this? Nothing", "[c:bR]汝以为此能得何哉？终无所得耳。");
            // 你休想摆脱我！无论你做什么，我都会一直在这里！
            AddTranslation("[c:bR]You cant get rid of me! No matter what you do, i will always be there!", "[c:bR]汝不能去我！汝所为虽百，我常在此！");
            // 那…那些灵魂？
            AddTranslation("[c:bR]Th- The Souls?", "[c:bR]彼……彼诸魂乎？");
            // 我…我的力量呢？
            AddTranslation("[c:bR]wh- where are my Powers?", "[c:bR]我……我之力安在？");
            // 你都干了些什么？！
            AddTranslation("[c:bR]WHAT HAVE YOU DONE?!", "[c:bR]汝所为何事？！");
        }
    }
}
