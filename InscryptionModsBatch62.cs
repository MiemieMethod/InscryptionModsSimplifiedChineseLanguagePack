using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch62
    {
        public static void RegisterTranslations()
        {
            RegisterP03InKayceesDialogueFour();
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

        private static void RegisterP03InKayceesDialogueFour()
        {
            // 我和你一样，也在追寻完美升级卡牌！
            AddTranslation("I, like yourself, am in pursuit of the [c:G]perfectly upgraded card[c:]!", "我与汝同，亦逐[c:G]至善之升牌[c:]！");
            // 一张同时具备超频、可变形和宝石化特性的卡牌。
            AddTranslation("A card that is simultaneously [c:r]overclocked[c:], [c:dlGr]transformable[c:], and [c:O]g[c:][c:B]e[c:][c:G]m[c:]ified.", "一牌兼具[c:r]亢机[c:]、[c:dlGr]可易形[c:]与[c:O]玉[c:][c:B]化[c:][c:G]之性[c:]。");
            // 我真的很想见识下这样的卡牌。
            AddTranslation("I would very much love to see such a card.", "我诚欲见此牌。");
            // 哟，牌友！
            AddTranslation("Ahoy there, fellow decksmith!", "嗨，牌匠之友！");
            // 天呐——你居然完美升级了一张卡？
            AddTranslation("Oh my - have you managed to [c:G]perfectly upgrade[c:] a card?", "噫——汝竟能[c:G]至善其升[c:]于一牌乎？");
            // 我对你的组牌技术佩服得五体投地。
            AddTranslation("I am in awe of your deckbuilding prowess.", "我服乃构牌之工。");
            // 希望这份礼物能充分表达我对你成就的仰慕。
            AddTranslation("I hope this offering sufficiently conveys my admiration for your accomplishments.", "愿此馈足表我慕汝所成。");
            // 第一波数据脉冲已收集完成。还剩四波！
            AddTranslation("The first data burst has been collected. Only [c:bR]four[c:] more to go!", "首波机脉已集。尚余[c:bR]四[c:]波！");
            // 已经收集两波数据了。还剩三波！
            AddTranslation("I have collected two bursts already. Only [c:bR]three[c:] more to go!", "我已集二波。尚余[c:bR]三[c:]波！");
            // 第三波数据脉冲搞定。还剩两波！
            AddTranslation("That was the third data burst. Only [c:bR]two[c:] more to go!", "三波已竟。尚余[c:bR]二[c:]波！");
            // 第四波数据脉冲到手。只剩最后一波啦！
            AddTranslation("And that makes the fourth data burst. Only [c:bR]one[c:] more to go!", "四波已集。尚余[c:bR]一[c:]波！");
            // 最后一波数据脉冲收集完毕！快来找我领赏！
            AddTranslation("That was the [c:bR]last[c:] data burst I needed to collect! Come find me for your reward!", "我所需之[c:bR]末[c:]波机脉已集毕！速来受赏！");
            // 信号开始传输了。再坚持一会儿别让它断掉。
            AddTranslation("The signal is starting to come through. Just keep it alive for a little bit longer.", "其讯始通。更护之少顷，毋使绝也。");
            // 刚收集的信号丢了。搞什么鬼？？
            AddTranslation("I lost the last signal we collected. What happened??", "方集之讯竟失矣。何也？？");
            // 你好啊，朋友！
            AddTranslation("Greetings, my friend!", "安乎，朋友！");
            // 我正在研究这个世界里机器人的通讯协议。
            AddTranslation("I am researching the communication protocols of the robots in this world.", "我方究此世界机人通讯之法。");
            // 我需要一位研究助手，如果你有兴趣帮忙的话。
            AddTranslation("I could use a [c:bR]research assistant[c:], if you're interested in helping out.", "我须一[c:bR]研助[c:]，汝若乐助，可为之。");
            // 想试试的话随时可以再来找我。
            AddTranslation("Just speak to me again if you want to give it a try.", "若欲试之，更来告我。");
            // 你现在是我的正式研究助手了！
            AddTranslation("You are now my official [c:bR]research assistant[c:]!", "今汝为我正[c:bR]研助[c:]矣！");
            // 我已经给你的牌组添加了一座信号塔。
            AddTranslation("I've added a radio tower to your deck.", "我已置一讯塔于汝牌列。");
            // 你需要把它放在游戏板子上并保持存活，同时我会从机器人那里收集五次数据脉冲。
            AddTranslation("You need to place it on the [c:bR]game board[c:] and keep it alive while I collect [c:bR]five data bursts[c:] from the robots.", "汝须陈之于[c:bR]局[c:]上而护其存，我则自机人处集[c:bR]五波机脉[c:]。");
            // 等我收集够了，回来找我领奖励。
            AddTranslation("Once I've collected enough, come back and see me for a reward.", "俟我集足，而后归见我受赏。");
            // 你好啊研究助手！
            AddTranslation("Hello there [c:bR]research assistant[c:]!", "安乎，[c:bR]研助[c:]！");
            // 你该不会真把我信号塔搞丢了吧？
            AddTranslation("Did you really lose my [c:bR]radio tower[c:]?", "汝真失我之[c:bR]讯塔[c:]乎？");
            // 你这废物程度简直突破天际！
            AddTranslation("Your incompetence is staggering!", "汝之不肖，骇人甚矣！");
            // 你真是个相当出色的研究助手。
            AddTranslation("You were a truly excellent [c:bR]research assistant[c:].", "汝诚善为[c:bR]研助[c:]。");
            // 请收下这份代币作为谢礼。
            AddTranslation("Please take this [c:G]token[c:] of my appreciation.", "请受此[c:G]符[c:]，以表我谢。");
            // 骨头！我最爱骨头了！
            AddTranslation("[c:G]Bones![c:] I just love [c:G]bones[c:]!", "[c:G]骨！[c:]我最爱[c:G]骨[c:]矣！");
            // 我就喜欢它们脆脆的样子！
            AddTranslation("I love how [c:G]brittle[c:] they are!", "我爱其[c:G]脆[c:]也！");
            // 它们一碰就碎的样子太棒了！
            AddTranslation("I love how [c:G]breakable[c:] they are!", "我爱其[c:G]易折[c:]也！");
            // 骨头的一切我都爱！
            AddTranslation("I love everything about [c:G]bones[c:]!", "凡[c:G]骨[c:]之一切，我皆爱之！");
            // 能给我看看骨头吗？！
            AddTranslation("Could you show me some [c:G]bones?![c:]", "可示我些[c:G]骨[c:]乎？！");
            // 至少三根就行！
            AddTranslation("At least [c:G]three[c:] would do it!", "至少[c:G]三[c:]骨可矣！");
            // 你的牌组里全是骨头啊！
            AddTranslation("Your deck is absolutely teeming with [c:G]bones[c:]!", "汝牌列中，骨多矣！");
            // 这张骷髅大师能让你收藏更完整！
            AddTranslation("This [c:G]Skeleton Master[c:] should complete your collection!", "此[c:G]枯骨主[c:]足成汝藏矣！");
            // 我知道这话可能有点难听但……
            AddTranslation("I know this might sound a little rude but…", "我知此言或稍逆耳，然……");
            // 你不觉得这一切对你来说太简单了点吗？
            AddTranslation("Doesn't it seem like this is all just a little too easy for you?", "汝不谓此于汝稍易乎？");
            // 想要挑战的话随时来找我。
            AddTranslation("Talk to me again if you want a challenge.", "若欲更难，随时来见我。");
            // 我就知道你不是个懦夫。
            AddTranslation("I knew you were no coward.", "我知汝非怯者。");
            // 接下来的三场战斗，你都将处于劣势开局。
            AddTranslation("For the next [c:bR]three[c:] battles, you will start with a disadvantage.", "后[c:bR]三[c:]战，汝皆以劣势而始。");
            // 完成这些战斗后，来找我领赏吧。
            AddTranslation("Complete those battles, then come see me for a reward.", "竟此诸战，而后归受赏。");
            // 老实说——战斗越难游戏才越有意思，对吧？
            AddTranslation("Be honest - the game is more fun when the battles are harder, is it not?", "实言之——战愈难，戏愈乐，不然乎？");
            // 继续战斗吧，等你打够场数再来找我。
            AddTranslation("Keep fighting, and come see me when you've completed enough battles.", "且战，及汝竟战足数，而后归见我。");
            // 不得不说：我服了。
            AddTranslation("I must say: I am impressed.", "我不得不言：我服矣。");
            // 你轻轻松松就打赢了那些战斗。
            AddTranslation("You completed those battles with ease.", "汝易而竟彼诸战。");
            // 既然你看起来怎么都死不了，那我就把这种能力也赐予一张我选中的卡牌吧。
            AddTranslation("Since you seem impossible to kill, I shall grant that ability to a card of my choosing as well.", "既汝似不可杀，我亦将以此能授我所择之一牌。");
            // 糟了…这下真糟了……
            AddTranslation("This is bad…this is real bad…", "恶矣……此诚大恶矣……");
            // 这个能量发电机已经过载了。
            AddTranslation("This [c:bR]power generator[c:] has gone critical.", "此[c:bR]电枢[c:]已亢极矣。");
            // 得有人进去把它关掉。
            AddTranslation("Someone is going to have to go in there and shut it down.", "须有人入而闭之。");
            // 虽然不知道你怎么做到的，但这波操作属实惊艳。
            AddTranslation("I don't know how you did that, but that was incredibly impressive.", "我不知汝何以能之，然此举诚可异也。");
            // 虽然没啥好东西能给你，但请收下这个吧。
            AddTranslation("I don't have much to give you, but please take this.", "我无多物可与，然请受此。");
            // 噢噢，他们肯定不会喜欢这个的……
            AddTranslation("Ohhh, [c:G]they[c:] are not going to like this…", "噫噫，[c:G]彼辈[c:]必不喜此……");
            // 我得在他们把我变成实验体之前逃出去！
            AddTranslation("I've gotta get out of here before they turn me into one of their [c:G]experiments[c:]!", "我当于彼使我为其[c:G]验体[c:]之前逃此！");
            // 设备正在启动。再等三个回合就搞定了。
            AddTranslation("The device is starting to power up. [c:bR]Three[c:] more turns should do it.", "其器方始充能。更俟[c:bR]三[c:]合可矣。");
            // 啊——我能感觉到能量正在汇聚。再过两回合应该就够了。
            AddTranslation("Ahh - I can feel the power gathering from here. [c:bR]Two[c:] more turns ought to be enough.", "啊——我能觉其能方聚。更[c:bR]二[c:]合应足矣。");
            // 设备开始发烫了！再来一回合就能获得所需全部能量。
            AddTranslation("The device is starting to really heat up! [c:bR]One[c:] more turn and we'll have all the power we need.", "其器始热矣！更[c:bR]一[c:]合，则吾等得所需之能尽矣。");
            // 设备已经充满电了！把它还给我，我会如约支付报酬。
            AddTranslation("The device is fully charged! Return it to me, and I will give you the payment as promised.", "其器既充！反之于我，我将如约偿汝。");
            // 该设备功能正常，但必须处于完整回路中才能充能。
            AddTranslation("The device is functional, but it cannot charge unless it is in a completed circuit.", "其器可用，然不在成回路中则不能充。");
            // 当心！设备受损时会失去最后一点能量！
            AddTranslation("Be careful! When the device is damaged, it loses its last charge!", "慎之！其器受损，则失其末一充！");
            // 想找份工作吗？
            AddTranslation("You looking for a job?", "汝欲求事乎？");
            // 我正在收集能量。
            AddTranslation("I am attempting to gather [c:G]power[c:].", "我方集[c:G]能[c:]。");
            // 不是比喻意义上的能量——我是说真正的电力，而你的帮助会很有用。
            AddTranslation("Not metaphorical power - I mean real [c:G]electricity[c:], and I could really use your help.", "非譬喻之能也——我谓真[c:G]电[c:]也，而汝之助甚有用。");
            // 为什么？
            AddTranslation("[c:bR]Why?[c:]", "[c:bR]何也？[c:]");
            // 这不重要。重要的是我愿意付钱。
            AddTranslation("That's not important. What's important is that I'm willing to pay.", "此不重要。所重者，我肯偿也。");
            // 想赚外快的话，随时来找我。
            AddTranslation("If you want to make some extra cash, just speak to me again.", "若欲得外财，则更来见我。");
            // 为了钱你真是啥都肯干啊？
            AddTranslation("You truly will do anything for money, won't you?", "为财而为，汝何所不肯哉？");
            // 给你的牌组加了台能量收集装置。
            AddTranslation("I've added a power collection device to your deck.", "我已置一聚能器于汝牌列。");
            // 你得把它放在游戏板子上，在回路里充能四个回合。
            AddTranslation("You need to place it on the [c:bR]game board[c:] and power it inside of a circuit for [c:bR]four turns[c:].", "汝须陈之于[c:bR]局[c:]上，而使其在回路中充[c:bR]四[c:]合。");
            // 搞定之后来找我领赏。
            AddTranslation("Once you've done that, come back and see me for a reward.", "既竟此，而后归受赏。");
            // 你难道不该去收集能量吗？
            AddTranslation("Shouldn't you be out there gathering [c:G]power[c:]?", "汝不当往集[c:G]能[c:]乎？");
            // 你竟敢拆掉我的能量槽！
            AddTranslation("I can't believe you got rid of my [c:bR]power sink[c:]!", "汝竟去我之[c:bR]蓄能塔[c:]！");
            // 等着吃我的律师函吧！
            AddTranslation("You will be hearing from my lawyers!", "其待我讼人之书矣！");
            // 看来你刚好给我收集了足够的能量。
            AddTranslation("It looks like you collected just enough power for me.", "汝所集之能，适足于我矣。");
            // 你的报酬：如约奉上。
            AddTranslation("Your payment: as promised.", "汝之偿：如约奉上。");
            // 亲爱的朋友，能施舍几个币帮帮这些可怜的报废机器人吗？
            AddTranslation("Dear friend, can you spare a few coins to help poor [c:bR]broken-down bots[c:]?", "亲者，可舍数币以济此可怜之[c:bR]废机[c:]乎？");
            // 这些机器人曾为机托邦奉献一生。
            AddTranslation("These bots have served [c:G]Botopia[c:] faithfully their whole lives.", "此诸机人为[c:G]机邦[c:]尽忠终身。");
            // 如今它们走到生命尽头，却无人照料。
            AddTranslation("And now that they have reached the end, they have nobody to care for them.", "今其至终，而无所恤之。");
            // 您看起来宅心仁厚，定会怜悯这些机器人。
            AddTranslation("You look like a kind, generous soul, with compassion for these bots.", "观汝心慈而厚，必能哀此诸机。");
            // 若您能施舍区区10枚机器币，就能为这些可怜机器人提供温暖家园。
            AddTranslation("If you could spare a measly [c:bR]10 robobucks[c:], we could give many of these poor bots a wonderful home.", "若能舍区区[c:bR]十机币[c:]，则可为此诸贫机得善居。");
        }
    }
}
