using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch115
    {
        public static void RegisterTranslations()
        {
            RegisterSquirrelBombOne();
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

        private static void RegisterSquirrelBombOne()
        {
            // 你的卡牌每回合都需移动；无法移动的卡牌会被移除（判定为死亡）。
            AddTranslation("Your cards move each turn. The cards that can't move die.", "汝牌每合皆移；不能移者死。");
            // 再一次
            AddTranslation("Again", "复一");
            // 敌方所有卡牌攻击两次。
            AddTranslation("All opponent cards attack twice.", "敌牌皆再攻。");
            // 饥饿
            AddTranslation("Starving", "饥");
            // 祈祷。
            AddTranslation("Pray.", "祷。");
            // 角鲨
            AddTranslation("Dogfish", "角鲨");
            // 每场战斗开始时，场上会出现一桶带有守护者印记的鱼饵。
            AddTranslation("Each battle starts with a Bait Bucket that has Guardian.", "每战始，局上有一负守护印契之饵桶。");
            // 恼人图腾
            AddTranslation("Annoying Totems", "恼图腾");
            // 每场战斗开始时，将为你使用次数最多的族群生成1个惹人生厌图腾。
            AddTranslation("Start each battle with an Annoying totem for your most used tribe.", "每战始，为汝所最数用之属生一恼图腾。");
            // 痛苦牌堆
            AddTranslation("Painful Draws", "苦引");
            // 从主牌堆抽牌时，你会受到1点伤害。
            AddTranslation("Drawing from the main deck deals 1 damage.", "自正牌列引牌，则受伤一。");
            // 痛苦松鼠
            AddTranslation("Painful Squirrels", "苦松鼠");
            // 从副牌堆抽牌时，你会受到1点伤害。
            AddTranslation("Drawing from the side deck deals 1 damage.", "自副牌列引牌，则受伤一。");
            // 卢恩符文
            AddTranslation("Runes", "卢恩文");
            // 场上占比最高族群的敌方卡牌会获得随机印记。
            AddTranslation("Enemy cards of the dominant tribe get random sigils.", "敌中最多之属，其牌得偶印契。");
            // 牙齿秘术
            AddTranslation("Dentistry", "齿术");
            // 道具事件与道具商印记仅会给予钳子。
            AddTranslation("Item events and Trinket Bearer cards only give pliers.", "器事与负器印之牌，但予钳耳。");
            // 归档锁定
            AddTranslation("Archived", "归档");
            // 每轮卡牌选择事件均隐藏1个随机卡牌选项。
            AddTranslation("A random card choice is hidden in every card choice event.", "每牌择之事，皆隐一偶得之牌择。");
            // 核心基底
            AddTranslation("Foundation", "基");
            // 你的所有卡牌攻击力-1，而副卡组的卡牌自带领袖力量印记。
            AddTranslation("All cards have 1 less attack. Side deck cards have Leader.", "汝诸牌威皆损一；副牌列之牌皆负领袖印契。");
            // 双阶段进阶头目战
            AddTranslation("Final Boss v2", "终魁二段");
            // 以一位真正的大人物取代莱西，成为最终头目。
            AddTranslation("Replaces Leshy as the final boss with a true BIG SHOT.", "易莱西而以真巨擘为终魁。");
            // 你必须跳舞！不准停下！！
            AddTranslation("You must dance! Don't stop dancing!!", "汝必须舞！毋止舞！！");
            // 任何在我的派对上停下跳舞的人都将承担后果。
            AddTranslation("Whoever stops dancing at my party will suffer the consequences.", "于我舞会而止舞者，皆当受其报。");
            // 那个机制很烦人吗？
            AddTranslation("Is that mechanic annoying?", "彼法烦乎？");
            // 完美。这正是它的用意所在。
            AddTranslation("Perfect. That's the point of it.", "善。此其意也。");
            // 跳舞吧，我的傀儡！跳啊——
            AddTranslation("Dance my puppet! Daaaance.", "舞乎，我傀儡！舞——");
            // 你需要通过，记得吗？
            AddTranslation("You need to pass, remember?", "汝须过之，记乎？");
            // 我正在[_spamton_0,偷窃]你的大洋
            AddTranslation("I'M [_spamton_0,STEALING] YOUR KROMER", "我正[_spamton_0,窃]汝金");
            // 天啊[_spamton_0,祸源]我感觉太棒了
            AddTranslation("HOLY [_spamton_0,CUNGADERO] DO I FEEL GOOD", "天哉[_spamton_0,祸种]，我快甚");
            // 我来了！！！
            AddTranslation("HERE I AM!!!", "我来矣！！！");
            // 大
            AddTranslation("BIG", "大");
            // <size=10>大！！！</size>
            AddTranslation("<size=10>BIG!!!</size>", "<size=10>大！！！</size>");
            // <size=15>[_spamton_0,比以往任何时候都更强大、更出色]</size>
            AddTranslation("<size=15>[_spamton_0,BIGGER AND BETTER THAN EVER]</size>", "<size=15>[_spamton_0,益大而益善]</size>");
            // 而现在我身处这场[_spamton_0,卡牌游戏]之中
            AddTranslation("AND NOW THAT I'M IN THIS [_spamton_0,GAME OF CARDS]", "而今我既在此[_spamton_0,牌局]");
            // 我不可能被打败！！！
            AddTranslation("I CAN'T BE DEFEATED!!!", "我不可败！！！");
            // 准备好被[_spamton_0,彻底击溃]在[_spamton_0,NEO之力]之下吧！！！
            AddTranslation("PREPARE TO GET [_spamton_0,ABSOLUTELY OBLITERATED] BY [_spamton_0,THE POWER OF NEO]!!!", "备受[_spamton_0,尽灭]于[_spamton_0,NEO之力]下罢！！！");
            // [_spamton_0,这个]又来？？？
            AddTranslation("[_spamton_0,THIS] AGAIN???", "[_spamton_0,此]又来？？？");
            // 准备好被[_spamton_0,摧毁]吧！！！
            AddTranslation("PREPARE TO GET [_spamton_0,DESTROYED]!!!", "备受[_spamton_0,毁]罢！！！");
            // 你不会有任何机会的，你这[_spamton_0,小环形虫]！！！
            AddTranslation("YOU WON'T STAND A CHANGE, YOU [_spamton_0,LITTLE RING WORM]!!!", "汝终无机，汝此[_spamton_0,小环虫]！！！");
            // 准备好被我在你的[_spamton_0,脸]上[_spamton_0,打一拳]！！！
            AddTranslation("PREPARE TO [_spamton_0,GET PUNCHED] IN YOUR [_spamton_0,FACE]!!!", "备受我击汝[_spamton_0,面]罢！！！");
            // 注视[_spamton_0,我]！！注视[_spamton_0,你]！！
            AddTranslation("BEHOLED [_spamton_0,ME]!!! BEHOLD [_spamton_0,YOU]!!!", "视[_spamton_0,我]！！视[_spamton_0,汝]！！");
            // [_spamton_0,超链接已被屏蔽]
            AddTranslation("[_spamton_0,HYPERLINK BLOCKED]", "[_spamton_0,链已蔽]");
            // 这具躯体难道不正是[_spamton_0,天堂]般的吗？
            AddTranslation("ISN'T THIS BODY JUST [_spamton_0,HEAVEN]LY?", "此躯不亦[_spamton_0,天]乎？");
            // 两倍的[_spamton_0,火]力量
            AddTranslation("2X THE [_spamton_0,FIRE]POWER", "二倍[_spamton_0,火]威");
            // 三倍的[_spamton_0,水]力量
            AddTranslation("3X THE [_spamton_0,WATER]POWER", "三倍[_spamton_0,水]威");
            // 而最为重要的是
            AddTranslation("AND MOST IMPORTANTLY", "而尤要者");
            // 会飞的头颅！！！
            AddTranslation("FLYING HEADS!!!", "飞颅！！！");
            // 我们会收拾掉那些[_spamton_0,蠢货]还有[_spamton_0,家伙]
            AddTranslation("WE'LL TURN THOSE [_spamton_0,SCHMOES] AND [_spamton_0,DAVES]", "我将使彼[_spamton_0,庸徒]与[_spamton_0,家伙]");
            // 变成[_spamton_0,玫瑰坟墓]
            AddTranslation("INTO [_spamton_0,ROSEN GRAVES]", "化为[_spamton_0,玫冢]");
            // 那些[_spamton_0,阴极屏蔽]
            AddTranslation("THOSE [_spamton_0,CATHODE SCREENS]", "彼[_spamton_0,阴极屏]");
            // 变成[_spamton_0,阴极射线尖啸]
            AddTranslation("INTO [_spamton_0,CATHODE SCREAMS]", "化为[_spamton_0,阴极啸]");
            // 你难道不想成为我那颗美丽[_spamton_0,心]的[_spamton_0,一部分]吗？！
            AddTranslation("DON'T YOU WANNA BE [_spamton_0,PART] OF MY BEAUTIFUL [_spamton_0,HEART]?!", "汝不欲为我美[_spamton_0,心]之[_spamton_0,一分]乎？！");
            // 还是说…… 你需要一场小小的[_spamton_0,特别巡回]？！
            AddTranslation("OR... DID YOU NEED A LITTLE [_spamton_0,SPECIL TOUR]?", "抑……汝须一小[_spamton_0,特巡]乎？！");
            // [_spamton_0,什么]？！
            AddTranslation("[_spamton_0,WHAT]?!", "[_spamton_0,何]？！");
            // 你[_spamton_0,偷走]了我的[_spamton_0,心]？
            AddTranslation("YOU [_spamton_0,STOLE] MY [_spamton_0,HEART]?", "汝[_spamton_0,窃]我[_spamton_0,心]乎？");
            // 你不能[_spamton_0,偷走]我的[_spamton_0,心]，这本来就是我的[_spamton_0,心]！
            AddTranslation("YOU CAN'T BE [_spamton_0,STEALING] MY [_spamton_0,HEART], IT IS MY [_spamton_0,HEART]!", "汝不可[_spamton_0,窃]我[_spamton_0,心]，此乃我[_spamton_0,心]也！");
            // 别再[_spamton_0,偷窃]我的心了，你这个[_spamton_0,!@#$]！
            AddTranslation("STOP [_spamton_0,STEALING] MY HEART YOU [_spamton_0,!@#$]", "止[_spamton_0,窃]我心，汝此[_spamton_0,!@#$]！");
            // O U C [_spamton_0,超链接已被屏蔽]
            AddTranslation("O U C [_spamton_0,HYPERLINK BLOCKED]", "O U C [_spamton_0,链已蔽]");
            // 你刚刚[_spamton_0,打碎]了我那颗价值[_spamton_0,4.99美元]的心
            AddTranslation("YOU JUST [_spamton_0,BROKE] MY [_spamton_0,$4.99] HEART", "汝适[_spamton_0,碎]我值[_spamton_0,$4.99]之心");
            // 你知道你这么做的时候，我有多[_spamton_0,痛]吗？！
            AddTranslation("DO YOU KNOW THAT IT [_spamton_0,HURTS] WHEN YOU [_spamton_0,DO] THAT?!", "汝知汝[_spamton_0,为]此时，我何其[_spamton_0,痛]乎？！");
            // 你难道不想帮帮你的老朋友斯潘顿吗？
            AddTranslation("DON'T YOU WANNA HELP YOUR OLD PAL SPAMTON?", "汝不欲助汝故友斯潘顿乎？");
            // 好好想想！我的[_spamton_0,蛋]要怎么办？！
            AddTranslation("THINK! WHAT ARE MY [_spamton_0,EGGS] GOING TO DO!?", "思之！我[_spamton_0,卵]将若何？！");
            // 它在呼唤……
            AddTranslation("IT'S CALLING...", "其在呼……");
            // 我的[_spamton_0,心]……
            AddTranslation("MY [_spamton_0,HEART]...", "我[_spamton_0,心]……");
            // 我的[_spamton_0,手]……
            AddTranslation("MY [_spamton_0,HANDS]...", "我[_spamton_0,手]……");
            // 看着[_spamton_0,NEO之力]，然后问问你自己……
            AddTranslation("LOOK AT THE [_spamton_0,POWER OF NEO] AND ASK YOURSELF...", "视[_spamton_0,NEO之力]，而自问……");
            // 你难道不吗？
            AddTranslation("DON'T YOU?", "汝不欲乎？");
            // 你难道不想成为一个[_spamton_0,大人物]吗？！
            AddTranslation("DON'T YOU WANNA BE A [_spamton_0,BIG SHOT]!?", "汝不欲为[_spamton_0,巨擘]乎？！");
            // 尊敬的顾客，我可算看出来了，你是想耗尽我的生命值！
            AddTranslation("MY ESTEEM CUSTOMER I SEE YOU ARE ATTEMPTING TO DEPLETE MY HP!", "贵客，我见汝欲尽我命矣！");
            // 我承认你小子有点[_spamton_0,胆量]！
            AddTranslation("I'LL ADMIT YOU'VE GOT SOME [_spamton_0,GUTS]!", "我认汝颇有[_spamton_0,胆]！");
            // 但在一场[_spamton_0,一对一]的对决里，NEO绝不会输！！！
            AddTranslation("BUT IN A [_spamton_0,1 FOR 1] BATTLE, NEO NEVER LOSES!!!", "然于[_spamton_0,一对一]之角，NEO未尝败！！！");
            // 是时候来点儿[_spamton_0,蓝光特惠]了
            AddTranslation("IT'S TIME FOR A LITTLE [_spamton_0,BLUELIGHT SPECIL]", "今其时也，可来些[_spamton_0,蓝光特惠]");
            // 你是不是很[_spamton_0,惊讶]，你居然没办法用你那些[_spamton_0,差劲的小]卡牌[_spamton_0,摧毁]我？
            AddTranslation("ARE YOU [_spamton_0,SURPRISED] THAT YOU CAN'T JUST [_spamton_0,DESTROY] ME WITH YOUR [_spamton_0,PATHETIC LITTLE] [_spamton_0,CARDS]?", "汝其[_spamton_0,惊]乎，乃不能以汝[_spamton_0,可怜小]之[_spamton_0,牌]而[_spamton_0,毁]我？");
            // 你难道不知道[_spamton_0,NEO]就是以超高防御力闻名的吗？！
            AddTranslation("DIDN'T YOU KNOW [_spamton_0,NEO] IS FAMOUS FOR ITS HIGH DEFENSE!?", "汝不知[_spamton_0,NEO]以高御著乎？！");
            // 现在……好好欣赏这场烟火秀吧！！！
            AddTranslation("NOW... ENJ0Y THE FIR3WORKS!!!", "今……观此烟火罢！！！");
            // 好好欣赏这场烟火秀吧！！！
            AddTranslation("ENJOY THE FIREWORKS!!!!", "观此烟火罢！！！");
            // 什么？
            AddTranslation("WHAT?", "何？");
            // 你到底想[_spamton_0,呼叫]谁？？？
            AddTranslation("[_spamton_0,WHO] ARE YOU TRYING TO [_spamton_0,CALL]???", "汝欲[_spamton_0,呼]谁？？？");
        }
    }
}
