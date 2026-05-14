using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch17
    {
        public static void RegisterTranslations()
        {
            RegisterMagnificusLateDialogueTwo();
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

        private static void RegisterMagnificusLateDialogueTwo()
        {
            // 或者根据[c:g1]虚空印记[c:]的指引，献祭它以强化附魔效果
            AddTranslation("Or you can slaughter it to improve the enchantment, dictated by the [c:g1]Ethereal Sigils[c:].", "抑可循[c:g1]虚印契[c:]之指，杀之以益其附。");
            // 选择权在你手中
            AddTranslation("The choice is yours.", "择在子。");
            // [c:g1]虚空印记[c:]在场地周围浮动
            AddTranslation("[c:g1]Ethereal Sigils[c:] hover around the grounds.", "[c:g1]虚印契[c:]浮于地上。");
            // 你可以借此预判可能的结果……
            AddTranslation("You may use them to predict a possible outcome..", "子可藉之先见其果……");
            // [c:g1]献祭之地[c:]矗立眼前。\n传说在特定条件下，卡牌能在此获得指数级的力量提升……
            AddTranslation("The [c:g1]Sacrifical Grounds[c:] stand before you.\nLegends tell of cards growing exponentially in power here, under the right circumstances..", "[c:g1]祀地[c:]立于子前。\n传曰，牌于其时若宜，则威可倍长于此……");
            // ……但看来你并未携带适合这片附魔之地的祭品
            AddTranslation(".. However, it appears that you don't have anything to offer to the enchanted grounds..", "……然子似无物可供此附地。");
            // 附魔之地似乎略有擢升。
            AddTranslation("The Enchanted Grounds seem to be slightly improved.", "附地似少进矣。");
            // 附魔之地显得不太满意……
            AddTranslation("The Enchanted Grounds are unsatisfied..", "附地未惬……");
            // 附魔之地因献祭能量而微微发亮。
            AddTranslation("The Enchanted Grounds dimly light up with sacrifical energy.", "附地缘祀气而微明。");
            // 附魔之地显得很不悦……
            AddTranslation("The Enchanted Grounds are displeased..", "附地不悦……");
            // 附魔之地因超凡能量而闪耀。
            AddTranslation("The Enchanted Grounds light up with supernatural energy.", "附地缘神异之气而耀。");
            // 附魔之地被激怒了。
            AddTranslation("The Enchanted Grounds are angered..", "附地怒矣……");
            // 附魔之地因献祭能量而剧烈翻腾。
            AddTranslation("The Enchanted Grounds The Enchanted Grounds are absolutely bursting with sacrifical energy.", "附地祀气充溢，几将迸矣。");
            // 附魔之地震怒不已……
            AddTranslation("The Enchanted Grounds The Enchanted Grounds are furious.", "附地震怒不已……");
            // 呃..这地方真恶心……
            AddTranslation("Eurgh.. This place is disgusting..", "呃……此地秽甚……");
            // 看来我被迫要在这儿练习法术了
            AddTranslation("Seems like I'm forced to train spellcasting in here.", "吾似见迫而习咒于此。");
            // 给我一个你的[c:g1]法术[c:]，动作快点
            AddTranslation("Give me a [c:g1]spell[c:] of yours, and make it quick.", "予我子之一[c:g1]咒[c:]，亟之。");
            // 你好……
            AddTranslation("Greetings..", "见礼……");
            // 给我一个你的[c:g1]法术[c:]
            AddTranslation("Give me one of your [c:g1]spells[c:]", "予我子之一[c:g1]咒[c:]");
            // 给我一个你的[c:g1]法术[c:]
            AddTranslation("Give me one of your [c:g1]spells[c:].", "予我子之一[c:g1]咒[c:]。");
            // 哦…你好……我们似乎还没正式认识……
            AddTranslation("Oh.. Greetings... I don't believe we've been introduced..", "噫……见礼……吾曹似未尝正相见……");
            // 我被强制…呃…受邀来这儿练习法术
            AddTranslation("I've been force- er.. asked to train my spellcasting here.", "吾见迫……呃……受命来此习咒。");
            // 不如给我些你的[c:g1]法术[c:]如何？
            AddTranslation("Why don't you give me some of your [c:g1]spells[c:]?", "盍予我若干子之[c:g1]咒[c:]？");
            // 嗯？哦，又见面了…我们还没正式介绍过
            AddTranslation("Hm? Oh, hello again.. We still haven't been formally introduced.", "嗯？噫，又见矣……吾曹犹未正相介也。");
            // 我需要一个你的[c:g1]法术[c:]来训练……
            AddTranslation("I'll need one of your [c:g1]spells[c:] for my training..", "吾须子之一[c:g1]咒[c:]以习之……");
            // 哦…你好啊
            AddTranslation("Oh.. Hello there.", "噫……见礼。");
            // 大师让我来练习法术……
            AddTranslation("The master asked me to practice my spellcasting..", "大师使吾来习咒……");
            // 哦…法术练习。对……
            AddTranslation("Oh.. Spellcasting. Right..", "噫……习咒。然……");
            // 什么？哦…这一定是…[c:g3]他[c:]的地盘……
            AddTranslation("What? Oh.. This must be.. [c:g3]his[c:] area..", "何？噫……此必……[c:g3]彼[c:]之地……");
            // 好吧不管怎样…大师让我来练习法术……
            AddTranslation("Well, anyway.. The master asked me to train my spellcasting.", "然无论何如……大师使吾来习咒。");
            // 唔……？
            AddTranslation("Hmm..?", "唔……？");
            // 这么快？我们还没对战过……
            AddTranslation("Here already? We haven't even battled..", "已至此乎？吾曹犹未尝战……");
            // 总之，交出一个[c:g1]法术[c:]就行……
            AddTranslation("Well anyways, just hand over a [c:g1]spell[c:].", "然则，但出一[c:g1]咒[c:]可也……");
            // 哦…你一个法术都没有吗？
            AddTranslation("Oh.. You don't have any spells?", "噫……子一咒亦无乎？");
            // 也许我可以给你一个强化过的…希望我的这些足够强……
            AddTranslation("I guess I could give you one of my upgraded ones.. Hopefully they're good.", "吾或可予子一吾所益强者……愿其足良……");
            // 现在，你的法术将永世长存……
            AddTranslation("Now your spell will last forever..", "今子之咒将永存……");
            // 所以，你当真要释放那个暴君……
            AddTranslation("So, you truly wish to release that tyrant..", "然则，子诚欲纵彼暴君……");
            // 希望你明白自己正在染指何种力量……
            AddTranslation("I hope you understand the type of power you are dealing with..", "愿子知所干者何等之力……");
            // 唔……该印记的精髓与你的卡牌并不契合……
            AddTranslation("Hmm.. The essence of that sigil does not resonate with your card..", "唔……彼印之精，与子牌不谐……");
            // ……看来一无所获
            AddTranslation("..It appears nothing was gained", "……似无所得。");
            // 印记的精髓使卡牌获得了更多能量
            AddTranslation("The essence of the sigil has imbued the card with more power.", "印之精已益其牌以威。");
            // 印记的精髓使卡牌获得了更多脑瓜
            AddTranslation("The essence of the sigil has imbued the card with more gourd.", "印之精已益其牌以智。");
            // 印记的精髓使卡牌获得了更多力量
            AddTranslation("The essence of the sigil has imbued the card with more strength.", "印之精已益其牌以力。");
            // 哼……我的漂白剂……失效了？
            AddTranslation("Hmph.. My bleach.. failed?", "哼……吾之漂液……失其验乎？");
            // 这是你的手笔吗，挑战者？
            AddTranslation("Was this your doing, challenger?", "此子所为乎，角者？");
            // 哼……
            AddTranslation("Hmph..", "哼……");
            // 选择一张卡牌漂白印记，并灌注等同于已失去印记的力量……
            AddTranslation("Select a card to imbue with a lost sigils strength..", "择一牌，以其所亡之印力灌之……");
            // 在此我将允许你[c:g1]漂白[c:]一张卡牌的某个印记……
            AddTranslation("Here I will allow you to [c:g1]bleach[c:] a card of one of its sigils..", "于此吾将许子[c:g1]漂[c:]一牌之一印……");
            // 被漂白后，该卡牌将继承已失去印记的力量，
            AddTranslation("When bleached, the card will imbue the power of its lost sigil,", "既漂，则其牌受其亡印之力，");
            // 并根据印记的原始强度变得[c:g2]更强[c:]。
            AddTranslation("and get much [c:g2]stronger[c:] depending on the sigils raw strength.", "而因彼印本强，益为[c:g2]强[c:]。");
            // 啊，但你的[c:g1]法术书[c:]已经满了……
            AddTranslation("Ah, but your [c:g1]spell book[c:] is full...", "噫，然子之[c:g1]咒书[c:]已盈……");
            // 你踏入一家小店…漫长旅途中的短暂休憩
            AddTranslation("You step foot into a small store.. A brief respite from your winding travels.", "子履一小肆……曲途之中，少憩耳。");
            // 你踏入一家小店……
            AddTranslation("You step foot into a small store...", "子履一小肆……");
            // 你的[c:g1]牌组[c:]存放在这堆卡牌中……
            AddTranslation("Your [c:g1]deck[c:] is stored in this pile.. ", "子之[c:g1]牌列[c:]藏于此积……");
            // ……而你的[c:g1]副牌组[c:]存放在此，可随时调整
            AddTranslation(".. And your [c:g1]side deck[c:] is stored here, where you can adjust it as you see fit. ", "……而子之[c:g1]副牌列[c:]藏于此，可随意更之。");
            // …哼，看来缘分未到……
            AddTranslation(".. Hmmph, I guess it was not meant to be..", "……哼，盖未当其时也……");
            // 在真菌的扭曲与侵蚀下，一张新卡牌诞生了。唯有经历痛苦，方能成长……
            AddTranslation("Twisted and warped by the fungi, a new card emerges. Only through pain can one grow…", "为菌所扭所蚀，而新牌生焉。惟历苦，乃能长……");
            // 现在蘑菇们需要一张卡牌来寄生…从而提升宿主的属性
            AddTranslation("Now the mushrooms require a card that they will attach.. Increasing the stats of the host.", "今菌须一牌以附……而益宿主之数。");
            // 你遭遇了侵染地牢的异常恶心的真菌
            AddTranslation("You encounter the abnormally disgusting fungi that infests this dungeon.", "子逢染此狱之异秽真菌。");
            // 据说它们具有奇特的性质……
            AddTranslation("It is said to possess strange properties..", "传其性甚奇……");
            // 这些蘑菇渴望找到一张能作为…[c:g1]宿主[c:]的卡牌
            AddTranslation("The mushrooms yearn for a card they can use as a.. [c:g1]host[c:] of sorts.", "此菌渴得一牌，可权为其……[c:g1]宿[c:]者。");
            // 它们将依附其上
            AddTranslation("One that they will attack to.", "菌将附其上。");
            // 你再次遭遇了那些恶心的真菌
            AddTranslation("You encounter the disgusting fungi yet again..", "子复逢彼秽菌……");
            // 真菌渴求着能作为[c:g1]宿主[c:]…来依附的卡牌
            AddTranslation("The fungi yearn for a card they can use as a [c:g1]host[c:].. to attach to.", "菌渴得一牌，可为[c:g1]宿[c:]……以附之。");
            // 然而……你似乎没有两张值得真菌触碰的卡牌。真扫兴
            AddTranslation("Yet... It seems you do not have two cards worthy of the fungi's touch. Wearisome.", "然……子似无二牌堪菌所触。可厌。");
            // 命名权就交给你了
            AddTranslation("You have the honours of naming it.", "名之之荣，归子。");
            // 完成了吗？
            AddTranslation("Finished?", "毕乎？");
            // [c:g1]费用[c:]和[c:g2]肖像[c:]由我来处理
            AddTranslation("The [c:g1]cost[c:] and [c:g2]portrait[c:] I will handle myself..", "[c:g1]直[c:]与[c:g2]像[c:]，吾自为之……");
        }
    }
}
