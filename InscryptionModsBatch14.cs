using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch14
    {
        public static void RegisterTranslations()
        {
            RegisterMagnificusAchievementsAndDialogue();
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

        private static void RegisterMagnificusAchievementsAndDialogue()
        {
            // 蔓尼菲科模组成就
            AddTranslation("Magnificus Mod Achievements", "蔓尼菲科补缀功成录");
            // 魔法迷宫
            AddTranslation("Magical Labyrinth", "术迷宫");
            // 击败最终首领
            AddTranslation("Defeat the final boss.", "败终魁。");
            // 水晶头骨
            AddTranslation("Crystal Skull", "晶颅");
            // 在激活所有挑战且无反挑战的情况下完成一轮游戏（可使用地图）
            AddTranslation("Complete a run with every challenge active, and no anti challenges. (You may use the map)", "尽启诸角竞，而无反角竞，以毕一局。（可用图）");
            // 人形黏液
            AddTranslation("Humanoid Slime", "人形胶");
            // 在第二阶段开始时没有任何卡牌力量被削弱的情况下击败第一首领
            AddTranslation("Defeat the first boss without having any cards get their power reduced at the start of phase 2.", "第二形始时，诸牌威无损，而败首魁。");
            // 无头骑士
            AddTranslation("Headless Knight", "无首骑者");
            // 在不触发任何附魔长矛的情况下击败第二首领
            AddTranslation("Defeat the second boss without triggering any Enchanted Spears.", "不触一祝矛，而败次魁。");
            // 快速召唤
            AddTranslation("Quick Summon", "疾召");
            // 在回合计时器从未耗尽的情况下击败第三首领
            AddTranslation("Defeat the third boss without letting the turn timer expire once.", "合时未尝尽，而败三魁。");
            // 时间女神的恶作剧
            AddTranslation("Mischief of the Time Goddess", "时神之戏");
            // 让第三首领的计时器耗尽5次后仍赢得战斗
            AddTranslation("Let the third boss's timer run out 5 times, and still win the fight.", "使三魁之时尽五，而犹胜其战。");
            // 鲁莽突进
            AddTranslation("Rush Recklessly", "妄趋");
            // 仅使用3次或更少事件后击败第一首领
            AddTranslation("Defeat the first boss after using only 3 or less events.", "所历事不过三，而败首魁。");
            // 帝王加冕
            AddTranslation("Crowning of the Emperor", "帝冕");
            // 青眼白龙
            AddTranslation("Blue Eyes White Dragon", "青眼白龙");
            // 单回合造成10点伤害
            AddTranslation("Deal 10 damage in a single turn.", "一合致十伤。");
            // 牺牲之卡
            AddTranslation("Card of Sacrifice", "祀牌");
            // 在抵达最终首领时持有10张或更少卡牌
            AddTranslation("Have 10 or less cards by the time you reach the final boss.", "及终魁，所持牌不过十。");
            // 黑森林猫头鹰
            AddTranslation("Owl of the Black Forest", "黑林鸮");
            // 放逐虚构的至尊大师
            AddTranslation("Banish the Ficticious Master Magnus.", "逐虚妄之至尊大师。");
            // 什么？难道我不能离开吗？
            AddTranslation("WHAT? BUT DON'T I GET TO LEAVE?", "何？然吾不得去乎？");
            // 我还有那么多刺激没体验呢！！
            AddTranslation("I STILL HAVE SO MUCH STIMULATION TO GET!!", "吾犹多激未得！！");
            // [c:g2]求你了挑战者[c:]，你必须带我…
            AddTranslation("[c:g2]PLEASE, CHALLENGER,[c:] YOU HAVE TO GET ME-", "[c:g2]求子，角者，[c:]子须携吾—");
            // 肃静
            AddTranslation("Hush.", "默。");
            // 嗯？
            AddTranslation("Hmm?", "噫？");
            // 你以为我会修复你的[c:g1]生命画作[c:]？
            AddTranslation("Did you expect me to restore your [c:g1]life painting[c:]?", "子谓吾将复乃[c:g1]命画[c:]乎？");
            // 唔……这里的规则可非如此，挑战者……
            AddTranslation("Hmm.. That's not how it works here, challenger..", "唔……此间之法不尔，角者……");
            // 漂白之痕难以复原
            AddTranslation("Bleach is not easily restorable.", "素痕难复。");
            // 你只能选择一张[c:g3]稀有卡牌[c:]
            AddTranslation("You may only pick a [c:g3]rare card[c:].", "子唯得择一[c:g3]罕有牌[c:]。");
            // 当你投入战斗时，注意到周围浮现出虚幻的符文……
            AddTranslation("As you engage in combat, you notice ethereal runes surrounding you..", "子方角时，见虚符周子……");
            // 这些符文似乎正在对你施加[c:g2]契约[c:]……
            AddTranslation("It seems as though they were placing a [c:g2]pact[c:] on you..", "若将加[c:g2]契[c:]于子……");
            // 你原有的印记在这场战斗中毫无用处
            AddTranslation("Your olden sigils shant be of any use in this battle.", "乃旧印于此战无益。");
            // 当战斗的硝烟散去，神秘的符文在你面前显现。
            AddTranslation("As the smoke of combat clears, the mysterious runes reveal themselves to you.", "战烟既歇，神符乃见于子。");
            // 啊，但这张可引不起符文的兴趣。
            AddTranslation("Ah, but this one does not interest the runes.", "噫，此牌不为群符所嗜。");
            // 印记已被替换，福祸难料。
            AddTranslation("The sigil, replaced, for better or for worse.", "印既易矣，休咎未可知也。");
            // [c:g3]唔…？[c:][c:g1]又来[c:][c:g3]一个[c:][c:g1]学徒？[c:]
            AddTranslation("[c:g3]Hmm..?[c:] [c:g1]Another[c:] [c:g3]student[c:] [c:g1]here?[c:]", "[c:g3]唔……？[c:] [c:g1]又一[c:] [c:g3]学徒[c:] [c:g1]至此乎？[c:]");
            // [c:g3]是[c:][c:g1]来[c:][c:g3]协助[c:][c:g1]我[c:][c:g3]研习[c:][c:g1]的吗？[c:]
            AddTranslation("[c:g3]Have[c:] [c:g1]you[c:] [c:g3]come[c:] [c:g1]to[c:] [c:g3]assist[c:] [c:g1]my[c:] [c:g3]studies?[c:]", "[c:g3]子[c:] [c:g1]来[c:] [c:g3]佐[c:] [c:g1]吾[c:] [c:g3]学[c:] [c:g1]乎？[c:]");
            // [c:g3]唔……[c:][c:g1]是时候[c:][c:g3]再[c:][c:g1]玩些……[c:][c:g3]禁书[c:][c:g1]了[c:]
            AddTranslation("[c:g3]Hmm..[c:] [c:g1]I[c:] [c:g3]think[c:] [c:g1]it's[c:] [c:g3]time[c:] [c:g1]to[c:] [c:g3]play[c:] [c:g1]some[c:] [c:g3]more...[c:]  [c:g2]forbidden[c:] [c:g1]books[c:]", "[c:g3]唔……[c:] [c:g1]时至[c:] [c:g3]更戏[c:] [c:g1]若干……[c:] [c:g2]禁[c:] [c:g1]书矣[c:]");
            // [c:g3]大师[c:][c:g1]的[c:][c:g3]杰作[c:][c:g1]肖像[c:]
            AddTranslation("[c:g3]An[c:] [c:g1]excellent[c:] [c:g3]portrait[c:] [c:g1]by[c:] [c:g3]the[c:] [c:g1]Master.[c:]", "[c:g3]大师[c:] [c:g1]之[c:] [c:g3]善像[c:] [c:g1]也。[c:]");
            // [c:g3]看来[c:][c:g1]你[c:][c:g3]也[c:][c:g1]有[c:][c:g3]自己[c:][c:g1]的[c:][c:g3]猎犬[c:][c:g1]了[c:]
            AddTranslation("[c:g3]Looks[c:] [c:g1]like[c:] [c:g3]you[c:] [c:g1]got[c:] [c:g3]a[c:] [c:g1]hound[c:] [c:g3]of[c:] [c:g1]your[c:] [c:g3]own![c:]", "[c:g3]子[c:] [c:g1]亦有[c:] [c:g3]己[c:] [c:g1]之[c:] [c:g3]犬[c:] [c:g1]矣。[c:]");
            // [c:g3]啊[c:][c:g1]没错，[c:][c:g3]我[c:][c:g1]确实[c:][c:g3]喜欢[c:][c:g1]读[c:][c:g3]好[c:][c:g1]书[c:]
            AddTranslation("[c:g3]Oh[c:] [c:g1]yes,[c:] [c:g3]I[c:] [c:g1]do[c:] [c:g3]love[c:] [c:g1]a[c:] [c:g3]good[c:] [c:g1]book.[c:]", "[c:g3]然[c:] [c:g1]也，[c:] [c:g3]吾[c:] [c:g1]爱[c:] [c:g3]善书[c:] [c:g1]甚矣。[c:]");
            // [c:g3]让[c:][c:g1]我[c:][c:g3]来[c:][c:g1]分享[c:][c:g3]几本[c:][c:g1]我[c:][c:g3]最爱[c:][c:g1]的[c:][c:g3]作品[c:][c:g1]吧[c:]
            AddTranslation("[c:g3]Let[c:] [c:g1]me[c:] [c:g3]share[c:] [c:g1]some[c:] [c:g3]of[c:] [c:g1]my[c:] [c:g3]favourites[c:] [c:g1]with[c:] [c:g3]you.[c:]", "[c:g3]请[c:] [c:g1]使吾[c:] [c:g3]以[c:] [c:g1]所爱[c:] [c:g3]数书[c:] [c:g1]分[c:] [c:g3]诸子[c:] [c:g1]焉。[c:]");
            // ……想象你是一个冰块，在热锅上慢慢融化……
            AddTranslation("Just imagine.. You are an ice cube, slowly melting in a hot pan..", "姑试思之……汝为冰块，徐融于热釜之上……");
            // 这些附魔长矛可不只是摧毁你的卡牌……
            AddTranslation("These enchanted spears won't just damage your cards..", "此诸祝矛，非徒伤乃牌耳……");
            // 哈！用我自己的法术来对付我？
            AddTranslation("Hah! Using one of my own spells against me?", "哈！以吾术反攻吾乎？");
            // 你不觉得这些卡牌有点太强了吗？
            AddTranslation("Don't you think those cards are a little too powerful?", "子不觉此诸牌太强乎？");
            // 这样好多了
            AddTranslation("That's better.", "是为善矣。");
            // [c:g1]你是怎么得到这个的？[c:]
            AddTranslation("[c:g1]How did you get that?[c:]", "[c:g1]子何自得此？[c:]");
            // ……我的[c:g1]黏液法师[c:]到底在哪？
            AddTranslation(".. Where on earth is my [c:g1]Goo Mage[c:]?", "……吾之[c:g1]胶巫[c:]安在哉？");
            // 莫非是你的…模组把他移除了？
            AddTranslation("Have your.. Modifications removed him?", "抑乃……补缀去之乎？");
            // 这般篡改持续太久了。我绝不会再容忍。
            AddTranslation("This tampering has gone on for far too long. I shall not allow it anymore.", "此窜改久矣。吾不容之复然。");
            // 待我们对决时，我绝不会手下留情。
            AddTranslation("When we face off, I won't be holding myself back.", "及与子角，吾必不复自抑。");
            // [c:g1]止步！[c:][c:g2]竟有[c:][c:g1]挑战者[c:][c:g2]胆敢[c:][c:g1]近前？！[c:]
            AddTranslation("[c:g1]Halt![c:] [c:g2]A[c:] [c:g1]challenger[c:] [c:g2]dare[c:] [c:g1]approach?![c:]", "[c:g1]止！[c:] [c:g2]乃有[c:] [c:g1]角者[c:] [c:g2]敢[c:] [c:g1]前乎？！[c:]");
            // [c:g1]可笑，[c:][c:g2]我[c:][c:g1]必将[c:][c:g2]把[c:][c:g1]你[c:][c:g2]剁[c:][c:g1]成[c:][c:g2]肉[c:][c:g1]酱[c:]
            AddTranslation("[c:g1]Quaint,[c:] [c:g2]I[c:] [c:g1]shall[c:] [c:g2]make[c:] [c:g1]mince[c:] [c:g2]meat[c:] [c:g1]out[c:] [c:g2]of[c:] [c:g1]you.[c:]", "[c:g1]可笑，[c:] [c:g2]吾[c:] [c:g1]必[c:] [c:g2]斫[c:] [c:g1]子[c:] [c:g2]为[c:] [c:g1]肉糜[c:]。");
            // [c:g1]恼人的是，[c:][c:g2]你[c:][c:g1]执意如此。[c:][c:g2]你[c:][c:g1]已[c:][c:g2]逼得[c:][c:g1]我[c:][c:g2]必须[c:][c:g1]出剑。[c:]
            AddTranslation("[c:g1]Irritating,[c:] [c:g2]you[c:] [c:g1]persist.[c:] [c:g2]You[c:] [c:g1]have[c:] [c:g2]bound[c:] [c:g1]me[c:] [c:g2]to[c:] [c:g1]excert[c:] [c:g2]my[c:] [c:g1]blade.[c:]", "[c:g1]恼哉，[c:] [c:g2]子[c:] [c:g1]犹执。[c:] [c:g2]子[c:] [c:g1]逼[c:] [c:g2]吾[c:] [c:g1]出剑[c:]。");
            // [c:g1]嗯？[c:][c:g2]某种[c:][c:g1]拙劣地[c:][c:g2]模仿[c:][c:g1]我[c:][c:g2]的[c:][c:g1]东西[c:][c:g2]吗？[c:]
            AddTranslation("[c:g1]Eh?[c:] [c:g2]Some[c:] [c:g1]sort[c:] [c:g2]of[c:] [c:g1]immitation[c:] [c:g2]of[c:] [c:g1]me?[c:]", "[c:g1]噫？[c:] [c:g2]某[c:] [c:g1]肖[c:] [c:g2]吾[c:] [c:g1]之伪物[c:] [c:g2]乎？[c:]");
            // [c:g1]可悲。[c:] [c:g2]我的[c:][c:g1]巨龙[c:][c:g2]可比[c:][c:g1]那个[c:][c:g2]宏伟[c:][c:g1]多了。[c:]
            AddTranslation("c:g1]Pathetic.[c:] [c:g2]My[c:] [c:g1]Drake[c:] [c:g2]was[c:] [c:g1]much[c:] [c:g2]grander[c:] [c:g1]than[c:] [c:g2]that.[c:]", "[c:g1]可悲。[c:] [c:g2]吾[c:] [c:g1]龙[c:] [c:g2]远[c:] [c:g1]伟[c:] [c:g2]于彼[c:]。");
            // 什…什么？挑战者？
            AddTranslation("W-What? A challenger?", "何……何？角者乎？");
            // 终于！！来点刺激的！
            AddTranslation("FINALLY!! STIMULATION!", "终于！！有激矣！");
            // 我还不够兴奋！！
            AddTranslation("I'M STILL NOT STIMULATED ENOUGH!!", "吾犹未足激也！！");
            // 我忍不住想翻卡堆了！
            AddTranslation("I HAVE THE URGE TO SEARCH A CARD PILE!", "吾欲翻牌积矣！");
            // 我已经失去耐心了！\n我需要更多刺激！！
            AddTranslation("I'M GROWING IMPATIENT!\nI NEED MORE STIMULATION!!", "吾已不耐！\n吾须更多激！！");
            // 哇哦！！我记得调制过这个！
            AddTranslation("WOW!! I REMEMBER BREWING THAT!", "噫！！吾记尝酿此！");
            // 嘿……你一张牌都不剩了？
            AddTranslation("HEY.. YOU DON'T HAVE ANY CARDS LEFT?", "噫……子一牌亦无乎？");
            // 无聊！
            AddTranslation("BORING!", "鄙哉！");
            // 哇！好酷的卡牌！！
            AddTranslation("WOW! COOL CARD!!", "噫！此牌伟哉！！");
            // 谁捡到归谁！
            AddTranslation("FINDERS KEEPERS!", "得者有之！");
            // 恐怕你把我们所有人都祸害了，挑战者……
            AddTranslation("I'm afraid you've doomed us all, challenger..", "角者，恐子已祸我众矣……");
            // 或许我确实是年岁渐长，动作迟缓了……
            AddTranslation("Perhaps I am slowing down with age..", "或吾以年老而迟矣……");
            // 我必须再次动用画笔的力量了。
            AddTranslation("I must use the brush to my advantage yet again.", "吾须复藉笔势。");
            // 你令我刮目相看，确实如此……
            AddTranslation("You have impressed me, you truly have..", "子诚使吾异视之……");
            // 已失两条性命。
            AddTranslation("2 lives down now.", "今已失二命。");
            // 可惜你算漏了，我尚有几招未出。
            AddTranslation("Unfortunately for you, I still have a few tricks up my sleeve.", "惜乎，于子不利；吾犹藏数伎。");
            // 我绝不会让自己这么轻易倒下。
            AddTranslation("I could never allow myself to go down that easily.", "吾必不使己若是易仆。");
            // 愚蠢至极……竟寻求外援？
            AddTranslation("Utter folly.. Getting outside assitance, are we?", "愚甚矣……乃求外助乎？");
            // 自由之足
            AddTranslation("Free Legs", "释足");
            // 解封之躯
            AddTranslation("Unsealed Body", "启躯");
            // 解放之臂
            AddTranslation("Released Arms", "释臂");
            // 解缚的暴君
            AddTranslation("Unleashed Tyrant", "纵暴君");
            // 你以为你在干什么？
            AddTranslation("Just what do you think you're doing?", "子谓己何为哉？");
            // 住手
            AddTranslation("Do not.", "止。");
            // 竟敢耍这种下作把戏
            AddTranslation("Trying to pull a trick as dirty as that..", "乃敢弄此下伎乎……");
        }
    }
}
