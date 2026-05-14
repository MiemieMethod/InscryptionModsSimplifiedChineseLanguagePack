using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch16
    {
        public static void RegisterTranslations()
        {
            RegisterMagnificusLateDialogueOne();
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

        private static void RegisterMagnificusLateDialogueOne()
        {
            // ……
            AddTranslation("...", "……");
            // 真令人沮丧。我似乎要输了。
            AddTranslation("Upsetting. I seem to be losing.", "可恼。吾似将败。");
            // 不如来条新规则。
            AddTranslation("How about a new rule.", "盍立新律。");
            // 每当[c:g2]你[c:]打出玛珂牌，[c:g2]我[c:]就恢复1点生命。
            AddTranslation("Everytime [c:g2]you[c:] play a mox, [c:g2]I[c:] restore 1 health.", "凡[c:g2]子[c:]陈一玛珂，[c:g2]吾[c:]复一命。");
            // 太糟了。我不得不用最后手段了。
            AddTranslation("Frustrating. I must use my last resort.", "可恼。吾不得不用末策。");
            // [c:g1]我们[c:][c:g2]成[c:][c:g3]了[c:]四个！
            AddTranslation("[c:g1]We[c:] [c:g2]have[c:] [c:g3]become[c:] four!", "[c:g1]吾曹[c:] [c:g2]今[c:] [c:g3]为四矣！[c:]");
            // [c:g2]嗯？[c:][c:g3]一个[c:][c:g2]对手…？[c:]
            AddTranslation("[c:g2]Hmm?[c:] [c:g3]An[c:] [c:g2]opponent..?[c:]", "[c:g2]嗯？[c:] [c:g3]敌[c:] [c:g2]乎？[c:]");
            // [c:g2]我[c:][c:g3]已经[c:][c:g2]有[c:][c:g3]一个[c:][c:g2]世纪[c:][c:g3]没有[c:][c:g2]对决[c:][c:g3]过了！[c:]
            AddTranslation("[c:g2]I[c:] [c:g3]haven't[c:] [c:g2]had[c:] [c:g3]a[c:] [c:g2]duel[c:] [c:g3]in[c:] [c:g2]a[c:] [c:g3]century![c:]", "[c:g2]吾[c:] [c:g3]百年[c:] [c:g2]未[c:] [c:g3]尝[c:] [c:g2]角[c:]矣！[c:]");
            // [c:g2]接[c:][c:g3]招[c:][c:g2]吧！[c:]
            AddTranslation("[c:g2]Have[c:] [c:g3]at[c:] [c:g2]thee![c:]", "[c:g2]来[c:] [c:g3]战[c:] [c:g2]乎！[c:]");
            // [c:g2]真[c:][c:g3]是个[c:][c:g2]难缠[c:][c:g3]的[c:][c:g2]对手！[c:]
            AddTranslation("[c:g2]A[c:] [c:g3]fierce[c:] [c:g2]opponent[c:] [c:g3]you[c:] [c:g2]are![c:]", "[c:g2]子[c:] [c:g3]诚[c:] [c:g2]劲敌[c:]！");
            // [c:g2]看来[c:][c:g3]得[c:][c:g2]用些[c:][c:g3]下三滥[c:][c:g2]的[c:][c:g3]手段[c:][c:g2]才能[c:][c:g3]打败[c:][c:g2]你[c:][c:g3]了！[c:]
            AddTranslation("[c:g2]I'll[c:] [c:g3]just[c:] [c:g2]have[c:] [c:g3]to[c:] [c:g2]use[c:] [c:g3]some[c:] [c:g2]more[c:] [c:g3]dirty[c:] [c:g2]tricks[c:] [c:g3]to[c:] [c:g2]beat[c:] [c:g3]you![c:]", "[c:g2]然则[c:] [c:g3]吾[c:] [c:g2]须[c:] [c:g3]更[c:] [c:g2]以秽术[c:] [c:g3]胜[c:] [c:g2]子[c:]矣！");
            // [c:g2]再[c:][c:g3]来点[c:][c:g2]别的[c:][c:g3]花样[c:][c:g2]也[c:][c:g3]未尝不可[c:]
            AddTranslation("[c:g2]And[c:] [c:g3]something[c:] [c:g2]else,[c:] [c:g3]why[c:] [c:g2]not.[c:]", "[c:g2]更[c:] [c:g3]加[c:] [c:g2]他戏，[c:] [c:g3]亦[c:] [c:g2]无妨[c:]。");
            // [c:g2]噢！[c:][c:g3]多么[c:][c:g2]绝妙的[c:][c:g3]肖像画[c:][c:g2]啊！[c:]
            AddTranslation("[c:g2]Ooh![c:] [c:g3]What[c:] [c:g2]a[c:] [c:g3]great[c:] [c:g2]portrait![c:]", "[c:g2]噫！[c:] [c:g3]美[c:] [c:g2]像[c:]！");
            // [c:g2]这是[c:][c:g3]我[c:][c:g2]忠诚的[c:][c:g3]凤凰[c:][c:g2]的[c:][c:g3]复制品，[c:][c:g2]难道[c:][c:g3]她不[c:][c:g2]美得[c:][c:g3]惊心动魄吗？[c:]
            AddTranslation("[c:g2]A[c:] [c:g3]replica[c:] [c:g2]of[c:] [c:g3]my[c:] [c:g2]loyal[c:] [c:g3]phoenix,[c:] [c:g2]isn't[c:] [c:g3]she[c:] [c:g2]absolutely[c:] [c:g3]stunning?[c:]", "[c:g2]此[c:] [c:g3]乃[c:] [c:g2]吾忠凤之摹[c:]，[c:g3]岂[c:] [c:g2]不绝艳[c:]乎？");
            // [c:g2]我[c:][c:g3]看[c:][c:g2]你[c:][c:g3]打出[c:][c:g2]了[c:][c:g3]不少[c:][c:g2]伤害！[c:]
            AddTranslation("[c:g2]I[c:] [c:g3]see[c:] [c:g2]you've[c:] [c:g3]done[c:] [c:g2]a[c:] [c:g3]fair[c:] [c:g2]bit[c:] [c:g3]of[c:] [c:g2]damage![c:]", "[c:g2]观[c:] [c:g3]子[c:] [c:g2]所致之伤[c:] [c:g3]颇[c:] [c:g2]多[c:]！");
            // [c:g2]不[c:][c:g3]介意[c:][c:g2]我[c:][c:g3]放些[c:][c:g2]小偷[c:][c:g3]吧……[c:]
            AddTranslation("[c:g2]Don't[c:] [c:g3]mind[c:] [c:g2]if[c:] [c:g3]I[c:] [c:g2]just[c:] [c:g3]place[c:] [c:g2]my[c:] [c:g3]thieves..[c:]", "[c:g2]吾[c:] [c:g3]置[c:] [c:g2]吾盗[c:] [c:g3]于此[c:]，[c:g2]可[c:]乎……？");
            // 没牌了……
            AddTranslation("Out of cards..", "牌尽矣……");
            // 真令人失望。我曾对你寄予厚望。
            AddTranslation("Dissapointing. I had high hopes for you.", "可惋。吾尝厚望于子。");
            // 就这点可怜的卡牌……
            AddTranslation("Such a tiny collection of cards..", "牌藏何其寡也……");
            // 我严重怀疑你能赢
            AddTranslation("I highly doubt you will win.", "吾甚疑子能胜。");
            // 在魔法的烈焰中，你终结了战斗。你造成的伤害远超所需。
            AddTranslation("With a blaze of Magick, you end the battle. You managed to deal more damage than needed.", "术焰既炽，战遂终焉。子所致之伤，已过所须。");
            // 溢出的魔法能量将转化为[c:g3]水晶[c:]。你可以在遇到的任何商店中使用它们。
            AddTranslation("The excess Magick you cast turns into [c:g3] Crystals. [c:] You may spend them at any meek store you happen to find.", "溢术化为[c:g3]晶[c:]。后遇小肆，可费之。");
            // 欢迎回来。
            AddTranslation("Welcome back.", "子复来矣。");
            // 许久未见能走到这一步的挑战者了。
            AddTranslation("You're the first in a while to get this far.", "久矣，始见有至此者。");
            // 现在，我将授予你至高无上的荣耀。
            AddTranslation("I will now bestow upon you, the highest honour I can possibly give.", "今吾将授子吾所能授之至荣。");
            // 以画笔将你永恒铭刻，化作一张卡牌。
            AddTranslation("To be painted, and immortalised forever, as a card.", "受画而永存，为一牌。");
            // 假人毫无生气地回瞪着你。
            AddTranslation("The dummy stares lifelessly back at you.", "偶人无生而反视子。");
            // 然后，它突然动了起来！
            AddTranslation("Then, suddenly it springs to motion!", "俄而骤动！");
            // 假人的铰链吱吱嘎嘎地回归原位，恢复了毫无生气的茫然凝视状态。
            AddTranslation("The dummy's hinges creak back into position, and it returns to it's lifeless stare.", "其枢吱然复位，而复无生以视。");
            // 你终于来了……
            AddTranslation("So you finally arrive..", "子终至矣……");
            // 但愿你已经做好充分准备来面对魔法冥刻者了
            AddTranslation("Hopefully you have prepared yourself well enough to face the Scrybe of Magicks.", "愿子已备足以当术之司锲。");
            // 这将是你最终的考验
            AddTranslation("This will be your final exam.", "此乃子终试。");
            // 该我们起舞了
            AddTranslation("Let us dance.", "与子舞。");
            // [c:g2]你[c:]终于现身了
            AddTranslation("[c:g2]You[c:] are finally here.", "[c:g2]子[c:]终至矣。");
            // 希望你明白这次是真正的终局
            AddTranslation("I hope you realise that this is truly it.", "愿子知此真终矣。");
            // 你或许移除了我学生的战斗
            AddTranslation("You may have removed my student's battles,", "子或已削我弟子诸战，");
            // 你或许篡改了我的整个游戏
            AddTranslation("You may have tampered with my entire game..", "或已窜我全戏……");
            // 是时候了
            AddTranslation("It is time.", "时至矣。");
            // 向你问候，挑战者。
            AddTranslation("Greetings, challenger.", "角者，见礼。");
            // 看来你的所有玛珂都被抹除了。
            AddTranslation("It appears that all of your mox has been erased.", "子诸玛珂，似尽见削。");
            // 好奇心害死猫……
            AddTranslation("Curiosity killed the cat..", "好奇取祸……");
            // 真遗憾你这么快就败下阵来……
            AddTranslation("It's a shame you got defeated so early..", "败之甚早，可惜也……");
            // 真遗憾你如此轻易就被击败了。
            AddTranslation("It's a shame you got defeated so easily.", "败之甚易，可惜也。");
            // 真遗憾你在深入之际落败。
            AddTranslation("It's a shame you got defeated so far in.", "既深入而败，可惜也。");
            // 我曾寄予厚望，可你辜负了一切……
            AddTranslation("I had such high hopes, but you lost it all..", "吾尝厚望，而子尽失之……");
            // 看来我的黏液法师技高一筹。真令人失望。
            AddTranslation("It seems my slime mage got the best of you. How dissapointing.", "乃为我胶巫所胜。可惋。");
            // 看来我的长矛法师用战术解决了你……
            AddTranslation("It looks like my pike mage tactically took you out..", "似我矛巫以术败子……");
            // 看来那位孤独的巫师得手了……
            AddTranslation("Looks like that lonely mage got to you..", "似彼孤巫所乘……");
            // 不过无所谓了。
            AddTranslation("Though it does not matter.", "然无足论。");
            // 你对我已无价值。
            AddTranslation("I do not have any more use for you.", "子于我已无所用。");
            // 请自行离开吧。
            AddTranslation("Please, take your leave.", "请去。");
            // 在找什么东西吗？
            AddTranslation("Looking for something?", "有所索乎？");
            // 恐怕你要找的东西已经……[c:g1]转移他处[c:]……
            AddTranslation("I'm afraid the object you seek has been.. [c:g1]relocated[c:]..", "子所索之物，恐已……[c:g1]徙他所[c:]……");
            // 看看你都释放了些什么……
            AddTranslation("Look at what you've unleashed..", "观子所纵者……");
            // 这真的值得寻找吗？
            AddTranslation("Was it truly worth finding?", "求之诚值乎？");
            // 哼……我本没打算让你走到这一步……
            AddTranslation("Hmph.. I did not intend for you to get out here..", "哼……吾本不欲子出至此……");
            // 不过我已预见了。尽管竭力阻拦，你仍执意前行。
            AddTranslation("I have forseen it though. Despite my best attempts you persist.", "然吾已先见之。虽极力阻子，子犹前。");
            // 我们就在此决斗吧……
            AddTranslation("We shall duel here..", "吾曹即此而角……");
            // 但这次，我们加点赌注。
            AddTranslation("Though, lets up the stakes.", "然且益其注。");
            // 若你败北，你的全部[c:g1]生命画作[c:]都将被漂白……
            AddTranslation("If you lose here, your entire [c:g1]life painting[c:] will get bleached..", "子若败于此，则子之全[c:g1]生画[c:]皆将漂……");
            // 若敢应战，便上前来。
            AddTranslation("Step forth if you dare.", "子敢则前。");
            // 你还要继续？
            AddTranslation("You persist again?", "子又来乎？");
            // 原来如此……
            AddTranslation("I see..", "然则……");
            // 我们再来一局！
            AddTranslation("We shall duel again!", "复与子角！");
            // 啊……你终于来了。
            AddTranslation("Ah.. Finally, you arrive.", "噫……子终至矣。");
            // 我在此处俯瞰着你全部的旅程。
            AddTranslation("I've been watching you from up here, for your entire journey.", "吾自上尽观子来涂。");
            // 挑战者，你已跋涉甚远。
            AddTranslation("You've come a long way, challenger.", "角者，子来亦远矣。");
            // 可惜这一切都将在此时终结。
            AddTranslation("Unfortunately, that will all come to an end here.", "惜乎，至此而终。");
            // 最后一战，决定你的命运……
            AddTranslation("One last duel, to decide your fate..", "更一角，以定子命……");
            // 是时候终结你这[c:g1]愚行[c:]了。
            AddTranslation("It is time to put an end to this.. [c:g1]foolery[c:] of yours.", "今当终子此[c:g1]愚戏[c:]。");
            // 若你视这些作弊手段为公平，那我不妨也动用些自己的伎俩。
            AddTranslation("If you consider these cheats fair, then I might as well use some cheats of my own.", "子既以诸诈为公，吾亦可用吾诈。");
            // 按常理我该当场将你除名……不过今日我格外宽容。
            AddTranslation("Normally, I would have you expelled right on the spot.. But I'm feeling generous.", "常则吾当即黜子；今姑宽之。");
            // 开始对决吧。
            AddTranslation("Let us duel.", "其角。");
            // 怎么了？卡住了？
            AddTranslation("Whats the matter? Stumped?", "何如？穷乎？");
            // 在地牢里再找找……你可能漏掉了一些[c:g1]标记[c:]……
            AddTranslation("Try searching around the dungeon.. There may be certain [c:g1]markings[c:] you missed..", "更索诸狱……或有若干[c:g1]记[c:]为子所遗……");
            // 嗯？
            AddTranslation("Hmm?", "唔？");
            // 在好奇这本书的用途吗？
            AddTranslation("Are you wondering what this book is for?", "怪此书何用乎？");
            // 这是你的[c:g1]法术书[c:]，可用它抽取一张[c:g3]法术牌[c:]
            AddTranslation("That is your [c:g1]spell book[c:]. You may use it to draw one of your [c:g3]spell cards[c:].", "此乃子之[c:g1]咒书[c:]。可藉之引一[c:g3]咒牌[c:]。");
            // 但每回合仅限[c:g1]一次[c:]……
            AddTranslation("But only [c:g1]one[c:] per turn..", "然每合惟[c:g1]一[c:]耳……");
            // 你跌入一滩黏稠的黏液，延伸向看似无尽的虚空……
            AddTranslation("You land in a sticky puddle of goo, stretching out into what seems like an endless void..", "子坠于一滩稠胶，延入若无穷之虚……");
            // 断裂的立柱与古老墙壁充斥视野，又被更多黏液吞没……
            AddTranslation("Ruined pillars and ancient walls surround your vision, overtaken by yet more slime..", "断柱古垣环目，而又尽为胶所没……");
            // 头顶闪烁的天穹向你投下耀眼辉光
            AddTranslation("The glistening heavens above shine brightly unto you.", "上有烂然之穹，明辉下烛。");
            // 你抵达了……
            AddTranslation("You arrive in the..", "子至于……");
            // 突如其来的热浪将你包围……
            AddTranslation("A sudden influx of heat surrounds you..", "热浪骤至，周子……");
            // 昏暗肮脏的厅室在视野中无尽延展
            AddTranslation("Dimly lit and dingy chambers spread out as far as you can see.", "昏黯秽室，极目而延。");
            // 远古比斗的回响在厅内萦绕不绝
            AddTranslation("Long forgotten echoes of ancient sparring fill the room.", "古角余响，久湮而满室。");
            // 你发现自己置身于……
            AddTranslation("You find yourself in the..", "子乃在……");
            // 陈腐的尘埃气息涌入鼻腔……
            AddTranslation("A dusty old smell fills your nostrills..", "陈尘之气，满子鼻……");
            // 沉寂的景致中，无数书墙已尘封万古
            AddTranslation("Hundreds of walls containing books, laying untouched for eons, fill the quiet landscape.", "百堵书壁，万古未触，充乎寂景。");
            // 蕴含禁忌知识的缥缈符文将你环绕
            AddTranslation("Ethereal runes, containing lost, forbidden knowledge surround you.", "载亡佚禁知之虚符，环子。");
            // 你苏醒于……
            AddTranslation("You awake in the..", "子寤于……");
            // 嗯。看来又有新学徒被绘入我的画布了。
            AddTranslation("Hmmm. It seems a new student is woven onto my canvas.", "似又有新弟子缀入我画缣。");
            // 若你回头望去，或能看见一间[c:g1]商店[c:]。
            AddTranslation("If you look behind yourself, you may see a [c:g1]shop[c:].", "子若顾后，或见一[c:g1]肆[c:]。");
            // 你可以查看牌组并调整副牌组。
            AddTranslation("You may view your deck and rearange your side deck.", "可观牌列，并易副牌列。");
            // 不过莫要惊慌，冒险途中自会遇到商店。
            AddTranslation("Though, do not be alarmed. You may find a shop later on your adventures.", "然毋惧。后于行中，自可遇肆。");
            // 若你已准备就绪，便可踏入未知之境。
            AddTranslation("If you are ready to proceed, you may step forth and enter into the unknown.", "若已备，可前而入于未知。");
            // 唔……又来了个年轻学徒，
            AddTranslation("Hmm.. A young student appears,", "唔……少弟子又至，");
            // 愚不可及，你的前辈连我的[c:g1]黏液法师[c:]都未能击败。
            AddTranslation("So foolish, your predesscor didn't even manage to get past my [c:g1]Goo Mage[c:].", "愚哉，乃前人尚不能过我[c:g1]胶巫[c:]。");
            // 也罢……或许你能创造此等壮举。
            AddTranslation("Ah well.. Maybe you will manage such a feat.", "然或子能成此举。");
            // 又来一个。
            AddTranslation("Another appears.", "又一人至。");
            // 兴许你能比前人走得更远。
            AddTranslation("Maybe you will manage to get further than those before you.", "或子能逾前人。");
            // 你们这些年轻学徒还有太多要学。
            AddTranslation("You young understudies still have much to learn.", "尔诸少徒，所学尚多。");
            // 啊，我对前任法师寄予厚望，
            AddTranslation("Ah. I had expectations for my previous mage,", "噫，吾尝望我前巫，");
            // 他们甚至击败了我的[c:g2]长矛法师[c:]。
            AddTranslation("They even managed to get past my [c:g2]Pike Mage[c:].", "彼甚至过我[c:g2]矛巫[c:]。");
            // 了不起的壮举，现在该你追随其脚步了……
            AddTranslation("A great feat, it seems now you must follow in their footsteps...", "斯诚壮举，今子宜蹑其迹……");
            // 那么，又一位自荐成为我的学徒之人。
            AddTranslation("So, yet another steps up to be my student.", "然则，又一人进为我弟子。");
            // 你需自行领悟，方能跨越我设下的重重考验。
            AddTranslation("You must learn yourself, to overcome my many obstacles and challenges.", "子当自学，以越我众阻与诸试。");
            // 若你真能成功，我自会赐予你无上荣耀……
            AddTranslation("If you do succeed, I shall bestow upon you a great honour..", "子若竟成，吾必赐子大荣……");
            // 唔…有些不对劲……
            AddTranslation("Hmm.. Something feels off..", "唔……有不协者……");
            // 挑战者，你可是[c:g1]修改了[c:]我的游戏？
            AddTranslation("Have you [c:g1]modded[c:] my game, challenger?", "角者，子其[c:g1]补缀[c:]我戏乎？");
            // 哼！何等无礼！
            AddTranslation("Hmph! How disrespectful!", "哼！无礼甚矣！");
            // 莫非我的游戏还不足以满足你？
            AddTranslation("Was my game not enough for you?", "我戏不足于子邪？");
            // 唉，我也只能听之任之……
            AddTranslation("Alas, I have no choice but to allow it..", "嗟，吾亦不得不听之……");
            // 这是怎么回事…？
            AddTranslation("Just what is going on here..?", "此何为也……？");
            // 这些卡牌，
            AddTranslation("These cards,", "此诸牌，");
            // 那个[c:g2]肮脏的小东西…[c:]闯进来了…？
            AddTranslation("Did that [c:g2]foul little..[c:] get in here..?", "彼[c:g2]秽小物……[c:]入此邪……？");
            // 挑战者，你恐怕来错地方了。
            AddTranslation("I believe you are in the wrong place, challenger.", "角者，子误至矣。");
            // 别动
            AddTranslation("Hold still.", "止。");
            // 指望天平？你可真天真。
            AddTranslation("You are a simpleton for expecting scales.", "望衡，子诚昧也。");
            // 这不过是场看谁先归零的简单竞赛。
            AddTranslation("This is a simple race to 0.", "此直争先归零耳。");
            // 现在该让我施展酿造魔法了！！
            AddTranslation("NOW ITS TIME FOR ME TO PRACTICE MY BREWING MAGICKS!!", "今当吾试吾酿术矣！！");
            // 完成了！！！快去拿吧！！
            AddTranslation("IT IS DONE!!! GO TAKE IT!!", "已成矣！！！往取之！！");
            // 快走！！
            AddTranslation("GO!!", "去！！");
            // [c:g2]给我滚出去！！[c:]
            AddTranslation("[c:g2]GET OUT OF HERE!![c:]", "[c:g2]速出此！！[c:]");
            // 哇哦！看来你往药剂里加的东西让它有点……[c:g1]贵[c:]……
            AddTranslation("WOAH! LOOKS LIKE SOMETHING YOU PUT INTO THE POTION MADE IT A BIT.. [c:g1]PRICY[c:]..", "噫！子所投于药者，似使之稍……[c:g1]贵[c:]……");
            // 什…什么？我终于自由了吗？
            AddTranslation("W-What? Am I finally free?", "何……吾终得释乎？");
            // 从那无尽黑暗中解脱了？
            AddTranslation("A break from that endless darkness?", "脱彼无穷之冥乎？");
            // 算了…不过是调制药水罢了……
            AddTranslation("Nevermind.. It's just potion making..", "已矣……特调药耳……");
            // 噢，你好啊挑战者！！
            AddTranslation("Oh, Hi Challenger!!", "噫，角者！！");
            // 哇，新面孔！！
            AddTranslation("Wow, someone new!!", "噫，新人！！");
            // 给我两张你的卡牌，咱们就能调制药水啦！！
            AddTranslation("Just give me two cards of yours and we'll make a potion out of them!!", "但予我二牌，则可和药矣！！");
            // 之后你可以把药水赋予卡牌，让它们获得些有趣的效果！
            AddTranslation("You can later give this potion to your cards and they gain some silly effects!", "后可以此药授子牌，则彼得若干谲效！");
            // 来吧！！可好玩了！！
            AddTranslation("Come on!! It will be fun!!", "来！！其甚乐！！");
            // 而且超刺激……
            AddTranslation("And stimulating..", "且激哉……");
            // 太刺激了
            AddTranslation("So stimulating", "甚激哉");
            // 嘿你好啊挑战者！！
            AddTranslation("Hello there challenger!!", "嗟，角者！！");
            // 现在你懂流程了吧
            AddTranslation("You know how this works now", "今子知其法矣");
            // 随便给我两张卡就能调制药水！
            AddTranslation("Just give me two cards and we'll make a potion!", "但予我二牌，则可和药！");
            // 哇哦…这是…什么地方？
            AddTranslation("Woah.. What.. Is this place?", "噫……此何地？");
            // 好亮啊……
            AddTranslation("So bright..", "何其明也……");
            // 噢，你好呀！！
            AddTranslation("Oh, Hi there!!", "噫，子来矣！！");
            // 咱们来调制药水吧！！
            AddTranslation("Let's make some potions!!", "其和药！！");
            // 递给我两张卡就完事……
            AddTranslation("Just hand over two cards and we'll be done with it..", "但予我二牌，则可毕矣……");
            // 等等！！你的法术书满了！
            AddTranslation("WAIT!! YOUR SPELLBOOK IS FULL", "止！！子之咒书盈矣！");
            // 先丢弃一个法术，否则你拿不走我们的药水！！
            AddTranslation("GET RID OF ONE OF YOUR SPELLS, OR YOU WONT BE ABLE TO TAKE OUR POTION!!", "先去一咒，不然不得取吾药！！");
            // 你的卡牌消耗已经更改……
            AddTranslation("Your card's cost has been changed..", "子牌之直已易……");
            // 你有对费用不满意的卡牌吗？
            AddTranslation("Do you have a card that has a cost you are unsatisfied with?", "子有不惬其直之牌乎？");
            // 看来没有。
            AddTranslation("No. It appears not.", "无。似无之。");
            // 让我看看……
            AddTranslation("LETS SEE HERE..", "且视之……");
            // 嗯？
            AddTranslation("HMM?", "嗯？");
            // 你觉得呢？
            AddTranslation("WHAT DO YOU THINK?", "子以为如何？");
            // 怎么样？
            AddTranslation("WELL?", "何如？");
            // 大师会怎么想？
            AddTranslation("WHAT WOULD THE MASTER THINK?", "大师将何思？");
            // 大师会为我骄傲吗？
            AddTranslation("WOULD THE MASTER BE PROUD?", "大师将以吾为荣乎？");
            // 这样行吗？
            AddTranslation("IS IT GOOD?", "善乎？");
            // 向挑战者致意！
            AddTranslation("GRREETINGS CHALLENGER!", "角者，见礼！");
            // 你竟已至此？
            AddTranslation("YOU'RE ALREADY HERE?", "子已至此乎？");
            // 我确实不记得与你交战过……
            AddTranslation("I DON'T REALLY RECALL US BATTLING..", "吾实不记与子尝战……");
            // 总之…我该拿哪张牌练习？
            AddTranslation("WELL ANYWAYS.. WHAT CARD WHOULD I PRACTICE ON?", "然则……当习何牌？");
            // 看来你已使我蒙羞！
            AddTranslation("IT WOULD SEEM THAT YOU HAVE DISGRACED ME!", "子已辱我！");
            // 不过无妨，我宽恕你
            AddTranslation("BUT IT IS ALRIGHT, I FORGIVE YOU.", "然无伤，吾恕子。");
            // 听着挑战者，我想练习我的[c:g2]美术[c:]……
            AddTranslation("SAY, CHALLENGER, I WOULD LIKE TO PRACTICE MY [c:g2]ART[c:]..", "角者，吾欲习我[c:g2]画[c:]……");
            // 终有一日我将比肩大师！
            AddTranslation("ONE DAY I MIGHT EVEN BE AS GOOD AS THE MASTER!", "异日吾或可比肩大师！");
            // 你不介意给我张牌对吧？
            AddTranslation("YOU WOULDN'T MIND GIVING ME ONE OF YOUR THERE CARDS, RIGHT?", "子不介予我一牌乎？");
            // 我该练习哪张牌？
            AddTranslation("WHAT CARD SHOULD I PRACTICE ON?", "当习何牌？");
            // 我需要张牌来磨砺技艺
            AddTranslation("I'LL NEED A CARD TO HONE MY SKILLS ON.", "吾须一牌以砺吾技。");
            // 我们素未谋面！
            AddTranslation("I DON'T THINK WE'VE MET BEFORE!", "吾曹未尝相见！");
            // 你本不该此时见我，但……
            AddTranslation("YOU ARENT SUPPOSED TO SEE ME UNTILL LATER, BUT..", "子本不当早见吾，然……");
            // ..看来你已无物可供……
            AddTranslation(".. It appears you have nothing else to offer..", "似子已无他物可供……");
        }
    }
}
