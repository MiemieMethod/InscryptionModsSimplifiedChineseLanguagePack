using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch18
    {
        public static void RegisterTranslations()
        {
            RegisterMagnificusLateDialogueThree();
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

        private static void RegisterMagnificusLateDialogueThree()
        {
            // 很高兴认识你，我的学徒
            AddTranslation("It was nice meeting you, my student.", "得识子，吾弟子，亦可乐也。");
            // 但此刻我们该道别了……
            AddTranslation("But this is where we say farewell..", "然今当别矣……");
            // 保持片刻别动
            AddTranslation("Just hold still for a second.", "且少止。");
            // 我会根据你牌组里的卡牌来决定。
            AddTranslation("I will base it off of cards in your deck.", "吾将本于子牌列中诸牌而定之。");
            // 首先，是属性。
            AddTranslation("First, the stats.", "先其数。");
            // 然后是[c:g1]印记[c:]。
            AddTranslation("The [c:g1]sigils[c:].", "次其[c:g1]印契[c:]。");
            // 唔……你的颜料用完了。
            AddTranslation("Hmm.. You're out of paint.", "唔……子之丹尽矣。");
            // 你可以漂白画作……或者就此收笔。
            AddTranslation("You can bleach your drawing.. or consider it finished.", "子可漂其画……抑以为已毕。");
            // 每位学徒的必修课都包含美术训练……
            AddTranslation("A neccesary part of each student's training is art..", "凡弟子之学，画为其常课……");
            // 先从肖像画开始吧……
            AddTranslation("Let's start with the portrait..", "先始于像……");
            // 左侧的漂白剂可用来擦除作品……
            AddTranslation("You can use the bleach on the left to wipe your work..", "左之漂液，可拭子作……");
            // 你正握着[c:g1]仿制画笔[c:]……若需要更细的笔，可取用右侧那支
            AddTranslation("You are currently holding a [c:g1]replica brush[c:].. If you feel you need a smaller one, you can grab the one on the right.", "子今执[c:g1]摹笔[c:]……若欲其细，则取右者。");
            // 用后排那支笔切换颜色
            AddTranslation("Use that brush in the back to change your color.", "以后列之笔易其色。");
            // 学徒们的肖像总能取悦我……
            AddTranslation("My pupil's portraits never fail to amuse me..", "吾弟子之像，恒足娱吾……");
            // 现在选择要为哪张卡的[c:g1]属性[c:]注入魔力
            AddTranslation("Now let's choose which card's [c:g1]stats[c:] to imbue.", "今择何牌之[c:g1]数[c:]以灌之。");
            // 现在，是[c:g1]印记[c:]。
            AddTranslation("Now, the [c:g1]sigils[c:].", "今其[c:g1]印契[c:]。");
            // 啊，但你的法术书已经满了……
            AddTranslation("Ah, but your spell book is full..", "噫，然子之咒书已盈……");
            // 要么丢弃这张……
            AddTranslation("Either discard this one...", "则弃此一……");
            // 要么移除你的一张法术……
            AddTranslation("Or, remove one of your spells..", "抑去子之一咒……");
            // 没有可施加[c:g1]药剂[c:]的卡牌
            AddTranslation("You don't have any cards to use that [c:g1]potion[c:] on.", "子无牌可受此[c:g1]药[c:]。");
            // 你已无卡牌可施法。
            AddTranslation("You won't have any cards to use that spell on.", "子已无牌可施此咒。");
            // 该单位未持有任何魔力。
            AddTranslation("That doesn't have any mana.", "彼无术力。");
            // 你无法从中汲取魔力。
            AddTranslation("You can not draw mana from that.", "子不得自彼汲术力。");
            // 穿越这幅画作与幻象的迷宫，或有存在愿屈尊加入你的牌组\n认真选吧
            AddTranslation("Through this maze of paintings and illusions, there may be some that deign to join your deck.\nChoose carefully.", "由此画与幻之迷，或有物肯屈而入子牌列。\n审择之。");
            // ……有点意思
            AddTranslation("... Curious.", "……异哉。");
            // 我还以为我已经彻底清除了这…[c:g2]污秽[c:]。
            AddTranslation("I thought I had completely removed this.. [c:g2]filth[c:].", "吾谓已尽去此……[c:g2]秽[c:]矣。");
            // 你倒挺会逗我开心啊，挑战者……
            AddTranslation("You humor me challenger..", "角者，子颇能娱吾……");
            // 你以为区区[c:g1]锤子[c:]能对[c:g1]衔宝蛇[c:]起作用？
            AddTranslation("Did you expect your measely [c:g1]hammer[c:] to work on such a creature as the [c:g1]ouroberyl[c:]?", "子谓区区[c:g1]锤[c:]可加于[c:g1]衔玉蛇[c:]乎？");
            // 何其愚蠢。
            AddTranslation("How foolish.", "愚何甚也。");
            // 你的锤子现已[c:g1]损毁[c:]，本场战斗无法再使用。
            AddTranslation("Your hammer is now [c:g1]broken[c:], and may not be used for the remainder of the battle.", "子之锤今已[c:g1]毁[c:]，此战余时，不得复用。");
            // 看来你输了……
            AddTranslation("It seems that you lost..", "子似已败……");
            // 看到这幅肖像了吗？
            AddTranslation("See this portrait?", "见此像乎？");
            // 这幅肖像将作为你的生命计数器。
            AddTranslation("This portrait will act as your life counter.", "此像将为子命之计。");
            // 当所有[c:g1]玛[c:][c:g2]珂[c:][c:g3]宝[c:][c:g1]石[c:]熄灭时…你就输了。
            AddTranslation("Once all the [c:g1]m[c:][c:g2]o[c:][c:g3]x[c:] [c:g1]g[c:][c:g2]e[c:][c:g3]m[c:][c:g1]s[c:] go out.. You lose the game.", "诸[c:g1]玛[c:][c:g2]珂[c:][c:g3]玉[c:] [c:g1]既[c:] [c:g2]尽[c:] [c:g3]熄[c:]……子则败。");
            // 既然你输了…我得移除一颗宝石。
            AddTranslation("Since you lost.. I will have to remove one gem.", "子既败……吾须去一玉。");
            // 事情已成定局。
            AddTranslation("The deed has been done.", "事已定矣。");
            // 看来你被对手击倒了。
            AddTranslation("Looks like you have been knocked down by your opponent.", "子似为敌所仆。");
            // 挺直腰杆，继续前进。
            AddTranslation("Stand tall, and continue forth.", "正身而前。");
            // 看来你该好好研究下玛珂了。
            AddTranslation("It seems as though you should study up on mox.", "子似当更学玛珂。");
            // 但别绝望，你还有两次机会。
            AddTranslation("Though you should not lose hope, as you still have 2 more lives.", "然毋绝望，子尚有二命。");
            // 你做了最后挣扎却仍失败。看来你又输了。
            AddTranslation("You make a last effort to succeed, yet fail. It seems you lose, again.", "子尽其末力而犹败。似复失矣。");
            // 你应当继续前进。
            AddTranslation("You shall continue forward.", "子当复前。");
            // 再受一击你就会倒下。
            AddTranslation("It takes just one more blow for you to fall to the ground.", "更一击，子即仆地。");
            // 失去一条命后，你必须继续前进。
            AddTranslation("Losing a life, you must continue forward.", "既失一命，子犹须前。");
            // 看来表演该落幕了…暂时如此……
            AddTranslation("It seems the show shall end… for now..", "戏似当终……姑如此耳……");
            // 这到底是怎么回事？
            AddTranslation("Just what is going on here?", "此终何为也？");
            // “至尊大师”……
            AddTranslation("'Master Magnus'..", "“至尊大师”……");
            // 根本[c:g2]没有[c:]这号大师！
            AddTranslation("There is [c:g2]NO[c:] such master!", "本[c:g2]无[c:]此大师！");
            // 呃……若你执意要玩这些把戏，我确实无力阻止。
            AddTranslation("Argh.. I guess, if you truly wish to play with such additions, I am truly unable to stop you.", "呃……子若诚欲戏此等增物，吾实不能止子。");
            // 但我绝不认可这种行为。
            AddTranslation("Though, I do NOT approve of this.", "然吾绝不许之。");
            // 看来那个虚构的至尊大师现身了。
            AddTranslation("It appears that the ficticious Master Magnus has showed itself.", "彼虚妄之至尊大师，似已自见。");
            // 那[c:g1]怪物[c:]正探出它丑陋的脑袋。
            AddTranslation("That horrid [c:g1]thing[c:] rears it's ugly head.", "彼[c:g1]怪物[c:]出其丑首矣。");
            // 解缚的至尊大师正在逼近。
            AddTranslation("The released Master Magnus approaches.", "纵释之至尊大师正前。");
            // 当心，那个可怕的大师来了。
            AddTranslation("Careful. That horrible master is here.", "慎之。彼可畏之大师至矣。");
            // 至尊大师已至，务必小心
            AddTranslation("Master Magnus has arrived. Be cautious.", "至尊大师已至，慎之。");
            // 认真选吧
            AddTranslation("Choose wisely.", "审择之。");
            // 呃啊！！！
            AddTranslation("ARRGH!!!", "呃啊！！！");
            // [c:g1]攻击！[c:]
            AddTranslation("[c:g1]STRIKE![c:]", "[c:g1]击！[c:]");
            // [c:g2]攻击！[c:]
            AddTranslation("[c:g2]STRIKE![c:]", "[c:g2]击！[c:]");
            // 永别了
            AddTranslation("Au Revoir", "永诀。");
            // 真是鲁莽。
            AddTranslation("How reckless.", "鲁哉。");
            // 唔……我明白了。
            AddTranslation("Hmm.. I see..", "唔……吾知之矣。");
            // 但你[c:g2]永远[c:]无法删除我——魔法冥刻者！
            AddTranslation("But you'll [c:g2]NEVER[c:] delete me, the Scrybe of Magicks!", "然子[c:g2]终不[c:]能削我——术之司锲！");
            // 嘎啊啊啊！！
            AddTranslation("GRRAHH!!", "嘎啊啊啊！！");
        }
    }
}
