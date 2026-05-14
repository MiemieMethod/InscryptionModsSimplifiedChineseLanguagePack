using System.Collections.Generic;
using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch64
    {
        private static readonly Dictionary<string, string> Consumables = new Dictionary<string, string>
        {
            { "Goobert", "黏伯特" },
            { "Data Cube", "数匣" },
            { "Laser Rifle", "光铳" },
            { "Amplification Coil", "益幅环" },
            { "UFO", "幽浮" },
            { "Wiseclock", "顺时钟" },
        };

        public static void RegisterTranslations()
        {
            RegisterP03InKayceesDialogueSix();
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

        private static void RegisterP03InKayceesDialogueSix()
        {
            // 你往我机器里塞了什么鬼东西？
            AddTranslation("What horrible thing did you put into my machine?", "汝置何怪物于我机中？");
            // 现在我只能把这玩意儿扔了换台新的。
            AddTranslation("I'm going to have to throw this away and get a new one now.", "今我惟得弃之，而更取新者。");
            // 真是谢谢您嘞。你的卡牌别想拿回去了。
            AddTranslation("Thanks a lot. You're definitely not getting your card back.", "真多谢矣。汝之牌休望复得。");
            // 就因为你上次干的好事，害得我又得买台新机器。
            AddTranslation("I had to go buy a new machine because of what you did last time.", "缘汝前所为，我不得不更市新机。");
            // 从今往后对别人的东西放尊重点。
            AddTranslation("Try to treat other people's stuff with some respect from now on.", "自今以后，宜稍敬人之物。");
            // 你好！我是全球传送带联盟的实地研究员。
            AddTranslation("Greetings! I'm a field researcher for [c:lGr]Global Conveyor Consortium[c:].", "安乎！我乃[c:lGr]寰输带盟[c:]之野察者。");
            // 我正在寻找愿意实地测试我们专利产品机器人战斗传送带的人选。
            AddTranslation("I'm looking for someone who would be willing to field test our patented [c:lGr]Bot Battle Conveyor Belts[c:].", "我方求一人，肯实试我等专有之[c:lGr]机战输带[c:]。");
            // 当然，这些测试必须在实战中进行！
            AddTranslation("Naturally, these tests would have to happen during [c:bR]actual combat[c:]!", "固然，此诸试必行于[c:bR]实斗[c:]之中！");
            // 如果你对此感兴趣，请再和我聊聊。
            AddTranslation("If that's something you would be interested in, please speak to me again.", "若汝有意，则请更与我言。");
            // 太棒了！我们马上开始战斗测试。
            AddTranslation("Oh fantastic! We will begin our [c:bR]combat trials[c:] immediately.", "善哉！今即始我等之[c:bR]斗试[c:]。");
            // 我们将收集你接下来三场战斗的实战数据。
            AddTranslation("We will collect field trial data for your next [c:bR]three[c:] battles.", "我等将采汝后[c:bR]三[c:]战之实试数据。");
            // 完成后记得再来找我。
            AddTranslation("Once that is complete, come and see me again.", "既竟此，而后更来见我。");
            // 我们的数据收集尚未完成。
            AddTranslation("Our data is still not yet complete.", "我等之数采犹未竟。");
            // 你只完成了3场必要战斗中的[v:0]场。
            AddTranslation("You have only completed [c:bR][v:0][c:] battles out of the required [c:bR]3[c:].", "三场所需之战，汝仅竟其[c:bR][v:0][c:]。");
            // 请继续战斗测试，完成后记得来找我。
            AddTranslation("Please, continue the [c:bR]combat trials[c:] and see me when they are complete.", "请续[c:bR]斗试[c:]，既竟而后见我。");
            // 测试大获成功！！
            AddTranslation("The trials were a smashing success!!", "诸试大成矣！！");
            // 全球传送带联盟对您为我们的努力做出的贡献表示万分感谢。
            AddTranslation("The [c:lGr]Global Conveyor Consortium[c:] is tremendously grateful for your contribution to our efforts.", "[c:lGr]寰输带盟[c:]深感汝助我等之劳。");
            // 为表谢意，他们授权我发放以下奖励。
            AddTranslation("To show their appreciation, they have authorized me to disburse the following.", "为表其谢，彼辈使我发此。");
            // 祝您未来一切顺利。
            AddTranslation("Good luck in all of your future endeavours.", "愿汝后事咸利。");
            // 悬赏目标！别让他跑了！
            AddTranslation("That's the bounty! Get him before he escapes!", "彼即赏的！逸前执之！");
            // 这次让他跑了，但我保证他还会回来的……
            AddTranslation("He got away that time, but I guarantee he'll be back...", "此番彼逸矣，然我保其必复来……");
            // 干得漂亮！来领赏吧！
            AddTranslation("You got him! Nice job! Come and see me for your reward.", "汝得彼矣！善哉！来受汝赏。");
            // 嘿搭档！想不想赚点外快？
            AddTranslation("Howdy partner! You interested in earning a little extra spending money?", "嘿，搭档！欲得些外财乎？");
            // 有个悬赏目标滑不溜秋的，可给我惹了不少麻烦。
            AddTranslation("I've got myself a slippery little [c:bR]bounty[c:] that's been giving me all sorts of trouble.", "我有一[c:bR]赏的[c:]甚滑，给我生诸多扰。");
            // 像你这样能干的人，正好能帮我追踪并解决掉他们。
            AddTranslation("I could use the help of a real go-getter like yourself to track them down and take them out.", "若汝之能者助我追索而除之，甚善。");
            // 要是感兴趣的话，随时来找我。
            AddTranslation("If this is something you might be interested in, just talk to me again.", "若或有意，随时来见我。");
            // 这才像话嘛，搭档！
            AddTranslation("That's the spirit, partner!", "此乃其气也，搭档！");
            // 你只需要在战斗时帮我留意着点。
            AddTranslation("All I need you to do is keep your eye out as you go into battle.", "汝所须为者，惟战时为我留目耳。");
            // 我敢保证那个滑头迟早会现身的……
            AddTranslation("I guarantee you that slippery bastard will show up sooner or later...", "我保彼滑贼迟早自见……");
            // 多留个心眼，搭档！
            AddTranslation("Just keep your eye out, partner!", "且留意之，搭档！");
            // 你迟早会逮到他的！
            AddTranslation("You'll catch him eventually!", "汝终当执彼！");
            // 干得漂亮，搭档！
            AddTranslation("Well done, partner!", "善哉，搭档！");
            // 说好的赏金，拿去吧。
            AddTranslation("Here's your bounty, as promised.", "其赏在此，如约取之。");
            // 这东西有点沉——换别的试试。
            AddTranslation("It's a little too heavy - try something else.", "此物稍重——更试他物。");
            // 亲爱的冒险者——看来你也对光荣的跳跃机器人情有独钟啊！
            AddTranslation("Dear traveler - I see you too have a love for the glorious [c:lGr]L33pB0t[c:]!", "亲之旅人——观汝亦爱彼光荣之[c:lGr]跃机[c:]也！");
            // 看来它在战斗中为你立下了汗马功劳。
            AddTranslation("Yours has served you well in battle, it seems.", "观其于战，事汝甚善。");
            // 让我来为你展示它真正的潜力吧……
            AddTranslation("Allow me to show you its true potential...", "请容我示其真材……");
            // 我都不知道该怎么说你好了！
            AddTranslation("I don't even know what to say to you!", "我竟不知何言于汝！");
            // 你明明拥有最牛逼的跳跃机器人……
            AddTranslation("You had the most glorious [c:lGr]L33pB0t[c:] in your posession...", "汝本有最光荣之[c:lGr]跃机[c:]……");
            // 居然把它放跑了？？！
            AddTranslation("And you let it go??!", "竟纵之去乎？？！");
            // 滚吧。最好永远别让我再看见你。
            AddTranslation("Begone. I hope to never see you again.", "去矣。愿永不复见汝。");
            // 别犯傻了。那张卡牌用不了那件道具。
            AddTranslation("Don't be an idiot. That card can't benefit from that item.", "毋愚。彼牌不能受彼器之益。");
            // 我在那边的垃圾桶里发现了这本贴纸书。
            AddTranslation("I found this sticker book in the trash can over there.", "我于彼侧秽桶得此贴簿。");
            // 你可以用它装饰卡牌之类的吧。关我屁事。
            AddTranslation("I think you can use it to decorate your cards, or something. I don't care.", "汝或可以之饰牌云尔。我不之顾。");
            // 我就爱看东西爆炸，你不觉得带劲吗？
            AddTranslation("I just love watching things [c:bR]explode[c:], don't you?", "我独爱见物[c:bR]爆[c:]也，汝不然乎？");
            // 这周围的一切都太……安分了……
            AddTranslation("Everything around here seems to be just a little too...stable...", "此间诸事皆稍……太安矣……");
            // 我觉得该给你的对战加点料，让事情变得真正有趣起来。
            AddTranslation("I think we could spice up your [c:bR]battles[c:] and make things truly interesting.", "我意可益汝之[c:bR]战[c:]以其味，使之真可玩。");
            // 要是想来点真正爆炸性的玩法，随时找我唠嗑。
            AddTranslation("Talk to me again if you're interested in some truly explosive gameplay.", "若欲求真爆之戏法，更来与我言。");
            // 哦耶宝贝咱们开干吧！
            AddTranslation("Ohhh yeah let's do it baby!", "噫然，友！其为之！");
            // 接下来三场战斗里每张卡牌都会装上引信。
            AddTranslation("I'm going to light a fuse on every card for the next [c:bR]three[c:] battles.", "后[c:bR]三[c:]战，我将尽然诸牌之燧。");
            // 搞定了再来找我！
            AddTranslation("Come find me again when that's complete!", "既竟此，而后更来见我！");
            // 我已经迫不及待想看看接下来会发生什么了。
            AddTranslation("I'm just buzzing with anticipation to see what happens next.", "我已急欲观后事矣。");
            // 你已经完成了3场战斗中的[v:0]场。
            AddTranslation("You've finished [c:bR][v:0][c:] battles out of [c:bR]3[c:].", "三战之中，汝已竟其[c:bR][v:0][c:]。");
            // 继续前进，完成后记得来找我！
            AddTranslation("Keep going, and see me when it's done!", "且续之，及竟而后见我！");
            // 这游戏打得可真够劲爆啊！
            AddTranslation("That was some truly explosive gameplay!", "此局诚劲爆矣！");
            // 这点小玩意儿就当辛苦费了。
            AddTranslation("Here's a little something for your trouble.", "此少物，以酬汝劳。");
            // 你买不起这个。
            AddTranslation("You can't afford that.", "汝不足以偿此。");
            // 那个传送节点会在你击败本区域的巨型机器人后解锁。
            AddTranslation("That [c:bR]warp node[c:] will unlock when you defeat the [c:bG]Uberbot[c:] on this map.", "彼[c:bR]迁节点[c:]，待汝败此地图之[c:bG]巨机[c:]而后启。");
            // 顺带一提，我最近升级了那个小地图……
            AddTranslation("And by the way, I upgraded that [c:bR]minimap[c:] recently...", "且言之，我近升彼[c:bR]小图[c:]矣……");
            // 你可以点击任意已探索过的房间进行瞬间传送。
            AddTranslation("You can click any room you've visited before to travel there instantly.", "汝可点凡尝至之室，而立至其处。");
            // 你的能量已经满了。现在使用这张牌没有任何好处。
            AddTranslation("You already have full energy. It won't do you any good to play that right now.", "汝之能已满。今陈彼牌，无益也。");
            // 我这儿还有东西要给你，但现在不行。晚点再来找我！
            AddTranslation("I've got something else to give you, but I can't right now. Come see me later!", "我尚有他物欲与汝，然今不可。后更来见我！");
            // 我这儿有个[v:0]要给你，但你的背包已经塞满了。等腾出空位再来找我吧！
            AddTranslation("I have a [c:bR][v:0][c:] for you, but you don't have room in your backback. Come see me when you do!", "我有一[c:bR][v:0][c:]欲与汝，然汝囊已满。俟有余隙而后更来。");
            foreach (var c in Consumables)
            {
                // 我这儿有个{c}要给你，但你的背包已经塞满了。等腾出空位再来找我吧！
                AddTranslation("我这儿有个[c:bR]" + c.Key + "[c:]要给你，但你的背包已经塞满了。等腾出空位再来找我吧！", "我有一[c:bR]" + c.Value + "[c:]欲与汝，然汝囊已满。俟有余隙而后更来。");
            }
            // 选择将哪条额外挑战规则应用于本场战斗。
            AddTranslation("Choose which [c:bR]extra challenge rule[c:] will be applied to this battle.", "择何[c:bR]别角竞之律[c:]以施于此战。");
            // 请选择一项额外实验参数。
            AddTranslation("We require you to select one [c:bR]additional experimental parameter[c:].", "请择一[c:bR]别试参数[c:]。");
            // 我的图书管理员们想让你选个最中意的规则。
            AddTranslation("My librarians have asked you to choose [c:bR]which of these rules[c:] is your favorite.", "我之守牍者请汝择此诸[c:bR]律[c:]之所最好者。");
            // 哇！这些画可真漂亮！不如你选一幅咱们留着？
            AddTranslation("Wow! These paintings are so pretty! Why don't you [c:bR]pick one[c:] for us to keep?", "嘻！此诸画甚美！曷不为我等[c:bR]择一[c:]而留之？");
            // 我觉得那鲑鱼简直……太尊贵了！
            AddTranslation("I think that [c:bSG]salmon[c:] is just so...majestic!", "我谓彼[c:bSG]鲑[c:]诚……甚尊也！");
            // 选一张我的画作加入你的收藏。
            AddTranslation("Select [c:bR]one of my paintings[c:] to add to your collection.", "择[c:bR]我画之一[c:]，以入汝藏。");
            // 不过首先——你得选幅画当咱们照片的背景
            AddTranslation("But first - you must [c:bR]choose a painting[c:] to be the background of our photographs.", "然先之——汝须[c:bR]择一画[c:]为我等写真之景。");
            // 欢迎来到多元宇宙世界！
            AddTranslation("Welcome to the [c:R]M[c:][c:bR]U[c:][c:O]L[c:][c:bG]T[c:][c:G]I[c:][c:blGr]V[c:][c:lGr]E[c:][c:B]R[c:][c:dB]S[c:][c:bB]E[c:]!", "[c:R]欢[c:][c:bR]迎[c:][c:O]来[c:][c:bG]到[c:][c:G]诸[c:][c:blGr]界[c:][c:lGr]之[c:][c:B]域[c:][c:dB]！[c:][c:bB][c:]");
            // 以你那可怜的脑容量，试图理解我们集合智慧的浩瀚程度只会让你脑浆炸裂。
            AddTranslation("Your feeble mind will implode if you try to comprehend the vastness of my combined intellect.", "汝之微智，若欲解我群智之广，必自裂耳。");
            // 所以每次只放三个我出来陪你玩，懂？
            AddTranslation("So we'll stick to three of me at a time, okay?", "故每次止出我三身，可乎？");
            // 既然你没法像我们这样看透多元宇宙世界的真形态，
            AddTranslation("And since you can't see through the [c:R]M[c:][c:bR]U[c:][c:O]L[c:][c:bG]T[c:][c:G]I[c:][c:blGr]V[c:][c:lGr]E[c:][c:B]R[c:][c:dB]S[c:][c:bB]E[c:] like we can,", "既汝不若我等能洞见[c:R]诸[c:][c:bR]界[c:][c:O]之[c:][c:bG]真[c:][c:G]形[c:][c:blGr]态[c:][c:lGr]，[c:][c:B][c:][c:dB][c:][c:bB][c:]");
            // 我们贴心地准备了这些监视器让你能在宇宙间穿梭。
            AddTranslation("We have provided these [c:bR]monitors[c:] to let you travel between universes.", "我等设此[c:bR]监镜[c:]，使汝得越诸界。");
            // 别偷看还没完工的东西！
            AddTranslation("Don't peek at things that aren't done yet!", "毋窥未成之物！");
        }
    }
}
