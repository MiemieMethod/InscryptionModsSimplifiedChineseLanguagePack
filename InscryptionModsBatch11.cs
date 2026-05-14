using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch11
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraFinale();
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

        private static void RegisterGrimoraFinale()
        {
            // 骨主对此供奉甚悦。
            AddTranslation("THE BONELORD IS VERY HAPPY WITH THIS OFFERING", "骨王甚悦此献。");
            // 对此我深表感激。
            AddTranslation("I AM VERY THANKFUL FOR THIS", "余甚谢此。");
            // 收下此物作为回礼，你可随时用它召唤我。
            AddTranslation("TAKE THIS IN RETURN, YOU CAN USE IT TO CALL ME ANYTIME", "受此为报，汝可随时以召余。");
            // 你无法终结这一切，除非终结我。
            AddTranslation("YOU CANNOT END THIS, END ME, THAT IS", "汝不能终此，除非终余。");
            // 你背着三样沉甸甸的道具继续上路。
            AddTranslation("Feeling overburdened enough with a full 3 items, you carried on.", "汝负三器已满，犹行。");
            // 凯茜说该冻结了！
            AddTranslation("Kaycee says it's time to freeze!", "凯茜曰：其冰矣！");
            // 索耶感谢你的贡献！
            AddTranslation("Sawyer thanks you for your contribution!", "索耶谢汝所献。");
            // 索耶为你感到难过。
            AddTranslation("Sawyer felt bad for you.", "索耶悯汝。");
            // 希望下回合你能暖和起来。
            AddTranslation("I hope you're able to warm up next turn.", "愿汝下合得燠。");
            // 精彩！你竟能战胜我，真令我惊喜！
            AddTranslation("Wonderful! I am pleasantly surprised by your triumph against me!", "善哉！汝克余，余甚惊喜！");
            // ……看来你已征服了这场游戏。
            AddTranslation("...It seems you have bested this game.", "……汝似已胜此戏。");
            // 但可叹，你用了作弊手段。
            AddTranslation("But alas, you have cheated.", "然惜哉，汝行诈矣。");
            // 我简直震惊至极！
            AddTranslation("I'm absolutely astonished!", "余骇甚矣！");
            // 你展现的实力远超我的预期！
            AddTranslation("You've gone above and beyond what I thought you were capable of!", "汝所能，远过余所度！");
            // 此局之后已无路可进……
            AddTranslation("There is no where else to go beyond this...", "过此则无所复往矣……");
            // 因此我有义务让你知晓真相……
            AddTranslation("So I owe it to you to know the truth...", "故余当使汝知其实……");
            // 凯茜，真正的凯茜……
            AddTranslation("Kaycee, the REAL Kaycee...", "凯茜，真凯茜也……");
            // 我知晓旧_数据中那些骇人的内容。
            AddTranslation("I know about the Horrifying contents of the OLD_DATA.", "余知旧数据中可骇之物。");
            // 想必你也曾窥探过其中……
            AddTranslation("Surely you have looked into it too..", "汝必亦尝窥之矣……");
            // 那是窥视你们世界古今至恶的窗口。
            AddTranslation("Windows into your world's greatest evils, both past and present.", "彼乃窥汝世古今至恶之牖也。");
            // 我要摧毁它，然后……
            AddTranslation("I want to destroy it, and...", "余欲毁之，而……");
            // [c:R]适可而止。[c:]
            AddTranslation("[c:R]THAT IS QUITE ENOUGH[c:]", "[c:R]足矣。[c:]");
            // [c:R]是时候终结这一切了。[c:]
            AddTranslation("[c:R]IT IS TIME FOR THIS TO END.[c:]", "[c:R]终此之时至矣。[c:]");
            // ……但我似乎还无法就此放手。
            AddTranslation("...But it seems i cannot move on just yet.", "……然余似未可遽去。");
            // 永别了。
            AddTranslation("Goodbye.", "永辞矣。");
            // ……你想继续？永无止境？妙极了！
            AddTranslation("...You wish to continue? Endlessly? Splendid!", "……汝欲复进乎？无穷乎？善矣！");
            // 请挑选一张你中意的卡牌。
            AddTranslation("Please, take a card of your choosing.", "请择一牌而取之。");
            // 你那孱弱的亡魂再也无法侵扰我了。
            AddTranslation("YOUR WEAK SPIRITS SHALL NOT HAUNT ME NO MORE.", "乃弱魂不得复祟余矣。");
            // 亲爱的，死神之触在这儿可帮不了你。\n我特制的这些巨像对不少把戏都免疫呢！
            AddTranslation("DEATH TOUCH WON'T HELP YOU HERE DEAR.\nI MADE THESE GIANTS SPECIAL, IMMUNE TO QUITE A FEW DIFFERENT TRICKS!", "死触于此无所济也。\n此诸巨人，余别制之，众伎不能加也！");
            // 骨王不可被附身！
            AddTranslation("THE BONELORD CANNOT BE POSSESSED!", "骨王不可附也！");
            foreach (var card in GrimoraCardCatalog.All)
            {
                string key = "[c:B]" + card.English + "[c:]";
                string value = "[c:B]" + card.Classical + "[c:]";
                // [c:B]{卡名}[c:]冻成冰块了可没法潜下去！
                AddTranslation(key + " MIGHT HAVE SOME DIFFICULTY SUBMERGING IF IT'S FROZEN SOLID!", value + "若凝为冰，则潜难矣！");
                // [c:B]{卡名}[c:]动都动不了还怎么附身！
                AddTranslation(key + " CAN'T POSSESS ANYTHING IF IT CAN'T MOVE!", value + "既不得动，安所附乎！");
                // [c:B]{卡名}[c:]冻得梆硬还怎么甩钩子！
                AddTranslation(key + " WILL HAVE A HARD TIME HOOKING ANYTHING IF IT'S FROZEN SOLID!", value + "既冻坚矣，安能施钩！");
                // [c:B]{卡名}[c:]总算！能摆脱那股恶臭了！
                AddTranslation(key + " FINALLY! TO GET RID OF THAT FOUL SMELL!", value + "善矣！终可去此秽气！");
            }
            // 让我们给卡牌[c:R]加热[c:]吧！
            AddTranslation("LETS [c:R]HEAT[c:] UP SOME CARDS!", "且以[c:R]燠[c:]加诸牌！");
            // 你…你的攻击只会让我[c:B]更…更冷[c:]！
            AddTranslation("Y-Your strikes are only making me [c:B]c-colder[c:]!", "汝……汝之击，徒使余[c:B]益……益寒[c:]！");
            // 是时候冻结你的卡牌了！[c:B]彻骨严寒[c:]！
            AddTranslation("IT'S TIME FOR YOUR CARDS TO FREEZE! [c:B]CHILLED[c:] TO THE BONE!", "乃牌当冻矣！[c:B]寒入骨[c:]！");
            // 这些[c:bB]冰块[c:]太占地方了！
            AddTranslation("ALL THIS [c:bB]ICE[c:] IS TAKING UP TOO MUCH SPACE!", "此许多[c:bB]冰[c:]，太踞处矣！");
            foreach (var card in GrimoraCardCatalog.All)
            {
                string key = "[c:bR]" + card.English + "[c:]";
                string value = "[c:bR]" + card.Classical + "[c:]";
                // 呀哈哈哈，我会好好享受[c:bR]{卡名}[c:]的爆炸艺术！
                AddTranslation("YARRRR, I WILL ENJOY THE KABOOM OF " + key, "呀哈，余乐观" + value + "之爆也！");
            }
            // 我嘞个大橙子啊，巨浪要来了！
            AddTranslation("BOIL ME ORANGES, THERES A-WAVES COMIN!", "噫，浪至矣！");
            // 这些浪头会把你的卡牌冲回手牌！
            AddTranslation("THESE WAVES WILL PUSH YE CARD OFF THE BOARD, BACK TO YER HAND!", "此浪将推乃牌出局，复归汝手！");
            // 这海盗不会被浪头卷走！但就算是最生猛的海盗也会被晃得七荤八素！
            AddTranslation("THIS PIRATE CANNOT BE TAKEN BACK UP BY THE WAVES! BUT EVEN THE ZESTIEST OF PIRATES WILL BE SHAKEN UP!", "此海盗不为浪卷归！然虽最劲之盗，亦将震荡！");
            // 七大洋的牌桌在此！
            AddTranslation("Seven seas for the table!", "七海上案矣！");
            // 哦，我会把这根骨头收好以备后用。
            AddTranslation("OH, I WILL STORE THIS BONE FOR LATER", "余姑藏此骨，以需后用。");
            // 施舍些灵魂吗？
            AddTranslation("SPARE SOME SOULS?", "肯施数魂乎？");
            // 行行好，就不能给可怜食尸鬼施舍几根骨头吗？
            AddTranslation("PLEASE, WON'T YOU SPARE SOME BONES FOR A POOR GHOUL LIKE ME?", "幸施数骨于我此穷冢鬼，可乎？");
            // 唉，真遗憾。你的锤子没能破开坚冰，反倒自己碎了一地。
            AddTranslation("OH, HOW SAD. YOUR HAMMER COULD NOT BREAK THE ICE, AND SHATTERED", "惜哉。尔锤不能破冰，而自碎矣。");
            // 这脆弱的玩意儿用过头就会碎。三击过后，至少本场战斗内它就报废了。
            AddTranslation("THE FRAIL THING WILL SHATTER AFTER EXCESSIVE USE. THREE STRIKES, AND IT'S OUT, FOR THIS BATTLE AT LEAST.", "此器脆甚，数用则碎。三击而尽，至少此战然也。");
            foreach (var card in GrimoraCardCatalog.All)
            {
                string key = "[c:lGr]" + card.English + "[c:]";
                string value = "[c:lGr]" + card.Classical + "[c:]";
                // 噢……要让[c:lGr]{卡名}[c:]在能力开满的状态下被附体可不太容易。
                AddTranslation("Oh... it will be rather difficult to haunt " + key + " with their abilities at max capacity.", "噫……" + value + "诸技既盈，则祟之难矣。");
            }
            foreach (var card in GrimoraCardCatalog.All)
            {
                // 天呐！看来你从{卡名}里钓出了什么东西！
                AddTranslation("OH DEAR! LOOKS LIKE YOU HAVE HOOKED SOMETHING OUT OF " + card.Simplified + "!", "噫！汝似自" + card.Classical + "中钓得一物矣！");
            }
            // [c:bB]嘶——！[c:]我在这冻了八百辈子了！
            AddTranslation("[c:bB]BRRRR![c:] I'VE BEEN FREEZING FOR AGES!", "[c:bB]嘶寒！[c:]余久冻矣！");
            // 来场[c:R]热血沸腾[c:]的对决吧！
            AddTranslation("LET'S TURN UP THE [c:R]HEAT[c:] FOR A GOOD FIGHT!", "且益其[c:R]燠[c:]以战！");
            // 哟，看来我又逮着机会了。但愿你看过天气预报！
            AddTranslation("Oh hey, looks like I've got another shot. Hope you watched the weather forecast!", "噫，余似又得一试。愿汝尝览天候之占！");
            // 拜托老兄，我还是好[c:B]冷[c:]啊！
            AddTranslation("OH COME ON DUDE, I'M STILL [c:B]COLD![c:]", "嗟，余犹[c:B]寒[c:]也！");
            // 咱们改日再战！
            AddTranslation("LET'S FIGHT AGAIN SOON!", "盍早复战！");
            // 恭喜，你表现不错。
            AddTranslation("CONGRATULATIONS, YOU DID WELL.", "善哉，汝战善矣。");
            // 你击败了我可爱的食尸鬼之一，现在起每场战斗开局将获得额外1根骨头。
            AddTranslation("YOU HAVE DEFEATED ONE OF MY LOVELY GHOULS, YOU WILL NOW START FIGHTS WITH AN ADDITONAL BONE.", "汝败我一爱冢鬼，自今每战始加一骨。");
            // 接下来是索耶家的地下墓穴，那肮脏之地埋葬着许多亡者。
            AddTranslation("SAWYERS CATACOMBS ARE UP NEXT, A FILTHY PLACE WHERE LOTS ARE LAID TO REST.", "次则索耶之墓窟矣，秽地也，多葬于彼。");
            // 他认为那是个糟糕的去处。
            AddTranslation("HE THINKS IT IS A TERRIBLE PLACE TO BE.", "彼以为其地甚恶。");
            // 别走啊老兄，这就受不了寒冷了？
            AddTranslation("C'mon dude, where are you going? Can't handle the cold?", "子安往？不堪寒乎？");
            // 噢，看来我终于[c:R]热好身了！[c:]
            AddTranslation("OH, IT SEEMS I HAVE FINALLY [c:R]WARMED UP![c:]", "噫，余似终于[c:R]燠矣！[c:]");
            // 我还没完全[c:R]热活开[c:]呢！
            AddTranslation("I'M STILL NOT FEELING [c:R]WARMER![c:]", "余犹未觉[c:R]燠[c:]也！");
            // 让我们看看你如何应对[c:bB]这个！[c:]
            AddTranslation("LETS SEE HOW YOU DEAL WITH [c:bB]THIS![c:]", "试观汝何以当[c:bB]此[c:]！");
            // 小心，你下一张卡牌的生命将进入倒计时。
            AddTranslation("Careful, the life of your next card will be on a timer.", "慎之，汝下一牌之命将有时限。");
            // 我很期待这[c:brnO]爆炸性[c:]的结果！
            AddTranslation("I look forward to the [c:brnO]explosive[c:] results!", "余甚俟其[c:brnO]爆然之果[c:]！");
            // 你的卡牌居然不会爆炸，真令人失望。
            AddTranslation("Your card cannot explode, how dissapointing.", "乃牌不能爆，惜哉。");
            // 好家伙，你竟敢登上我的船来挑战！
            AddTranslation("VAR, I SEE YOU MADE IT TO ME SHIP CHALLENGER!", "呀，角者，汝竟登我舟矣！");
            // 我正等着来场像样的对决呢！
            AddTranslation("I'VE BEEN WAITING FOR A WORTHY FIGHT!", "余久俟一足称之战矣！");
            // 风暴将至，但愿我的船扛得住
            AddTranslation("IT SEEMS A STORM IS BREWING, I HOPE ME SHIP CAN HANDLE IT", "风将作矣，愿我舟能任之。");
            // 哈！看来你被恶灵缠得不轻啊！
            AddTranslation("OH, I SEE YEE ARE SEVERELY HAUNTED!", "哈，汝祟甚矣！");
            // 复生的亡灵，收拾收拾准备喂鱼吧！
            AddTranslation("REVENANT, PACK YE BAGS, YOURE GETTING THROWN OVERBOARD!", "逆生魂，束装！汝将见掷于海！");
            // 高估了老身的本事，祝你好运啊挑战者。
            AddTranslation("I OVERESTIMATED ME SKILL, GOOD LUCK CHALLENGER.", "余高料己技矣。角者，幸矣。");
            // 让老身瞧瞧，下一站正是老身的墓室。
            AddTranslation("LET'S SEE, THE NEXT AREA IS MY VERY OWN CRYPT.", "观之，次地乃余之墓室。");
            // 说不定你真能逆天改命呢！
            AddTranslation("PERHAPS YOU CAN BEAT ALL ODDS AND TRIUMPH!", "或汝能逆数而胜。");
            // 我要把你打成果酱！
            AddTranslation("I beat the livin' PULP out o' ye!", "余将捣汝若糜！");
            // 我的船！我担心咱们要沉了。
            AddTranslation("ME SHIP! I FEAR WE MAY BE SINKING.", "我舟！余惧将沉矣。");
            // 都给老子屏住呼吸！
            AddTranslation("PREPARE TO HOLD YEE BREATH!", "敛气以待！");
            // 我嘞个鱼酱啊，你居然找到了戴维·琼斯的宝藏！
            AddTranslation("HOLY FISHPASTE, YE FOUND DAVY JONES TREASURE", "天乎，汝得戴维·琼斯之藏矣！");
            // 呵！这才第一回合！\n看看你咋对付老子的亲兵船队！
            AddTranslation("YARRG, TWAS JUST DA FIRST ROUND!\nLETS SEE HOW YE FARE 'GAINST ME PERSONAL SHIP AN CREW!", "呀，此特首合耳！\n试观汝何如当我亲舟与其众！");
            // 在这阴森可怖的日子来敲我的门真是太好了！你是想要给糖，还是要我捣蛋？
            AddTranslation("HOW NICE OF YOU TO COME KNOCK AT MY DOORSTEP ON THIS TRULY SPOOKY DAY! DO YOU PREFER TREATS, OR TRICKS?", "是日甚诡，汝乃来叩我门，善哉！汝欲糖乎，抑欲戏乎？");
            // 别看这边，别看这边！想打架就速战速决！
            AddTranslation("LOOK AWAY, LOOK AWAY! IF YOU WANT TO FIGHT, GET IT OVER QUICK!", "毋视，毋视！汝欲战，则速毕之！");
            // 哦……我…我又见到你了……拜托解决掉那个怪物，也许我就能多抽点时间陪你了。
            AddTranslation("oh... I- I see you're here again... Please, get rid of that monster and maybe I'll find some more time for you", "噫……余……余见汝复来矣……请除彼怪，或余可更抽顷刻与汝。");
            // 你击败了凶残的糖果怪物，拯救了万圣节！
            AddTranslation("YOU HAVE BEATEN THE VICIOUS CANDY MONSTER AND SAVED HALLOWEEN!", "汝败凶糖怪，而全万圣之夕矣！");
            // 感谢你了结这一切，永远别再回来了！
            AddTranslation("THANKS FOR GETTING IT OVER WITH, AND DON'T EVER RETURN!", "谢汝毕此，毋复来！");
            // 接下来是罗亚尔专属的船——柠檬琴号。
            AddTranslation("NEXT UP IS ROYALS VERY OWN SHIP, THE LIMONCELLO.", "次则罗亚尔之自舟，柠檬琴号。");
            // 他那群忠实的海盗船员驻扎于此，愿他们给你个“热情”招待。
            AddTranslation("HIS TRUSTY CREW OF SWASHBUCKLERS RESIDES THERE, MAY THEY GIVE YOU A WARM WELCOME.", "其所恃之海盗居焉，愿彼辈厚迎汝。");
            // 噢不……这是否意味着你会再试一次？
            AddTranslation("Oh no... does this mean you will try again?", "噫……是将复试乎？");
            // 哦，他走了……可算解脱了。
            AddTranslation("OH, HE IS GONE... WHAT A RELIEF.", "噫，彼去矣……大纾也。");
            // 多谢您的骨头，好心人！
            AddTranslation("THANKS FOR YOUR BONES, KIND SIR!", "谢君之骨！");
            // 既然那怪物不在了，何不再多玩会儿呢？
            AddTranslation("NOW THAT THAT MONSTER IS GONE, WHY DONT WE PLAY A LITTLE LONGER", "今彼怪既去，盍更戏少时。");
            // 希望你别介意，我可是花了大价钱来玩这些的。
            AddTranslation("I HOPE YOU DONT MIND, I PAID GOOD MONEY TO PLAY THESE.", "愿汝毋介意，余以重赀博此。");
            // 别是糖果怪物！你的[c:R]把戏[c:]他早受够了！
            AddTranslation("NOT THE CANDY MONSTER! HE HAS ENOUGH OF YOUR [c:R]TRICKS![c:]", "毋召糖怪！彼厌乃[c:R]诸戏[c:]久矣！");
            // 糟了，他来了！他正渴望着你的[c:R]骨头[c:]呢！
            AddTranslation("OH NO, HE HAS ARRIVED! HE IS THIRSTY FOR YOUR [c:R]BONES![c:]", "噫，彼至矣！彼渴乃[c:R]骨[c:]！");
            // 多谢了！
            AddTranslation("Thank you!", "谢矣！");
            // 你你你你，痛痛痛痛苦苦的死死死亡亡在等等等着你你你你！
            AddTranslation("YOUUUUUUUR, PAINNNFULLLLL DEAAATHHH AWAIIITTTSSS YOUUUUUUU!", "汝——之——苦——死——将——至——矣——！");
            // 啊！你这肮脏的癞疮狗，给老子跳下船板去！
            AddTranslation("ARRG! WALK OFF THE PLANK YEE DIRTY SCALLYWAG!!!", "呀！汝此污贼，履板而下海！！！");
            // 我的爱犬们会享用你的骨头！
            AddTranslation("My dogs will enjoy your bones!", "我犬必甘汝骨！");
            // 一个[c:bR]盗墓贼[c:]……他只是为了财富而来。
            AddTranslation("A [c:bR]盗墓贼[c:]... He's only here for the riches.", "一[c:bR]掘冢贼[c:]……彼来惟为财耳。");
            foreach (var card in GrimoraCardCatalog.All)
            {
                // 骨王慷慨解囊。\n[c:bR]{卡名}[c:]的骨头消耗降低了！
                AddTranslation("The Bonelord has been generous.\n[c:bR]" + card.Simplified + "[c:] bone cost has decreased!", "骨王施惠。\n[c:bR]" + card.Classical + "[c:]之骨直减矣！");
                // 骨王慷慨解囊。\n[c:bR]{卡名}[c:]的基础生命值提升了！
                AddTranslation("The Bonelord has been generous.\n[c:bR]" + card.Simplified + "[c:] base health has increased!", "骨王施惠。\n[c:bR]" + card.Classical + "[c:]之本命增矣！");
                // 哎呀，看来[c:bR]{卡名}[c:]的骨头消耗降低了！
                AddTranslation("Oh dear, it looks like [c:bR]" + card.Simplified + "[c:] bone cost has decreased!", "噫，[c:bR]" + card.Classical + "[c:]之骨直减矣！");
                // 骨王慷慨解囊。\n[c:bR]{卡名}[c:]的骨头消耗大幅降低了！
                AddTranslation("The Bonelord has been generous.\n[c:bR]" + card.Simplified + "[c:] bone cost has decreased greatly!", "骨王施惠。\n[c:bR]" + card.Classical + "[c:]之骨直大减矣！");
                // 骨王极为慷慨。\n[c:bR]{卡名}[c:]的基础生命值大幅提升了！
                AddTranslation("The Bonelord has been very generous.\n[c:bR]" + card.Simplified + "[c:] base health has increased greatly!", "骨王厚赐。\n[c:bR]" + card.Classical + "[c:]之本命大增矣！");
                // 骨王极为慷慨。\n[c:bR]{卡名}[c:]的基础攻击力提升了！
                AddTranslation("The Bonelord has been very generous.\n[c:bR]" + card.Simplified + "[c:] base attack has increased!", "骨王厚赐。\n[c:bR]" + card.Classical + "[c:]之本威增矣！");
            }
            // ……什么？骨王你为何如此？！[c:bR]竟提升整个牌组的生命值？！[c:]糊涂啊！
            AddTranslation("... WHAT? WHY DID YOU DO THAT BONELORD?! [c:bR]INCREASING THE HEALTH OF THE ENTIRE DECK?![c:] YOU FOOL!", "……何哉？骨王，汝何为此！[c:bR]尽增一列之命乎？！[c:]愚矣！");
            // ……什么？骨王你为何如此？！[c:bR]竟降低整个牌组的消耗？！[c:]糊涂啊！
            AddTranslation("... WHAT? WHY DID YOU DO THAT BONELORD?! [c:bR]DECREASING THE COST OF THE ENTIRE DECK?![c:] YOU FOOL!", "……何哉？骨王，汝何为此！[c:bR]尽减一列之直乎？！[c:]愚矣！");
            // 你已无卡牌可[c:bR]提升生命值[c:]，真可悲。现在请离开此地。
            AddTranslation("YOU DON'T HAVE ANYMORE CARDS TO [c:bR]GAIN HP[c:], HOW SAD. NOW PLEASE LEAVE.", "汝已无牌可[c:bR]增命[c:]矣，可悲。今请去。");
            // 你已无卡牌可[c:bR]降低骨头消耗[c:]，真可悲。现在请离开此地。
            AddTranslation("YOU DON'T HAVE ANYMORE CARDS TO [c:bR]REDUCE THEIR BONE COST[c:], HOW SAD. NOW PLEASE LEAVE.", "汝已无牌可[c:bR]减其骨直[c:]矣，可悲。今请去。");
            // 你已无卡牌可[c:bR]提升攻击力[c:]，真可悲。现在请离开此地。
            AddTranslation("YOU DON'T HAVE ANYMORE CARDS TO [c:bR]GAIN ATTACK[c:], HOW SAD. NOW PLEASE LEAVE.", "汝已无牌可[c:bR]增威[c:]矣，可悲。今请去。");
            // 真不走运。本该降低你整个牌组消耗，但骨王似乎已施舍过你了。滚吧！
            AddTranslation("THAT'S UNFORTUNATE. YOU WERE SUPPOSED TO HAVE YOUR ENTIRE DECK DECREASED, BUT IT LOOKS LIKE THE BONELORD HAS ALREADY GIFTED YOU THAT. BEGONE!", "不幸矣。本当尽减汝一列之直，然骨王似已先赐汝此。去！");
            // 真不走运。本该提升你整个牌组属性，但骨王似乎已施舍过你了。滚吧！
            AddTranslation("THAT'S UNFORTUNATE. YOU WERE SUPPOSED TO HAVE YOUR ENTIRE DECK INCREASED, BUT IT LOOKS LIKE THE BONELORD HAS ALREADY GIFTED YOU THAT. BEGONE!", "不幸矣。本当尽益汝一列，然骨王似已先赐汝此。去！");

            // ShowThenClear
            // 准备接舷战！
            AddTranslation("PREPARE TO BE BOARDED!", "备接舷！");
            // 这锤子看起来不太结实，你要是砸我的冰会把它弄坏的！
            AddTranslation("That hammer doesn't look very sturdy, you'll break it if you bash my ice!", "彼锤不甚坚，若击余冰，必碎矣！");
            // 你真以为骨王大人会这么轻易放过你？！
            AddTranslation("DID YOU REALLY THINK THE BONELORD WOULD LET YOU OFF THAT EASILY?!", "汝诚谓骨王肯若是轻纵汝乎？！");
            // [size:5][c:bR]骨王[c:][size:]驾到！
            AddTranslation("LET THE [size:5][c:bR]BONELORD[c:][size:] COMMETH!", "有[size:5][c:bR]骨王[c:][size:]至矣！");
            // 随你选择吧……
            AddTranslation("Choose as you will...", "随汝择之……");
            // 选一张。
            AddTranslation("Choose one.", "择一。");
            // 该休息一下了。
            AddTranslation("It is time to rest.", "宜息矣。");
            // [c:bG]上吧，酒保！[c:]喝个痛快！
            AddTranslation("[c:bG]Go Bartender![c:] Drink up!", "[c:bG]酒人，上！[c:]尽饮！");
            // 上吧，掘墓人！[c:]可别尖叫！
            AddTranslation("[c:bG]Go Undertaker! Dont scream!", "[c:bG]殡者，上！毋号！");
            // 上吧，枪手之魂！[c:]决斗时刻到了！
            AddTranslation("[c:bG]Go Slingers Soul! Time for a duel!", "[c:bG]投石魂，上！斗时至矣！");
            // [c:bG]上吧，独臂强盗！[c:]但愿我能走运！
            AddTranslation("[c:bG]Go One Armed Bandit! I hope i get lucky!", "[c:bG]独臂盗，上！[c:]愿余得吉！");
            for (int amnt = 0; amnt < 10; amnt++)
            {
                // 你的分数是{amnt}，尚可。
                AddTranslation("Your score is " + amnt.ToString() + ", acceptable.", "乃分为" + amnt.ToString() + "，可也。");
            }
            // 你的分数是10，这是你的奖励！
            AddTranslation("our score is 10, heres your prize!", "乃分为10，此其赏也！");
            for (int amnt = 11; amnt <= 100; amnt++)
            {
                // 你的分数是{amnt}，真遗憾！
                AddTranslation("our score is " + amnt.ToString() + ", too bad!", "乃分为" + amnt.ToString() + "，惜哉！");
            }
            // 如此渺小的陷阱岂能困住巨人。
            AddTranslation("SUCH A SMALL TRAP CANNOT AFFECT GIANTS.", "如此小阱，岂能及巨人。");

            // ShowMessage
            // 赌把运气再获一个能力？\n还是见好就收？
            AddTranslation("PUSH YOUR LUCK FOR ONE MORE ABILITY?\nOR PULL AWAY?", "更试一运，以求一技乎？\n抑退乎？");

            // Challenge
            // 无骨之殇
            AddTranslation("No Bones", "无骨");
            // 击败首领后将不再获得额外骨头。
            AddTranslation("You no longer gain the extra bones, from defeating bosses.", "败魁后，不复得其额外之骨。");
            // 凯茜的混乱
            AddTranslation("Kaycee's Kerfuffle", "凯茜之乱");
            // 每场战斗的第四回合，你所有的卡牌都将被冰封禁锢。
            AddTranslation("The fourth turn of every battle, all your cards will be Frozen Away.", "每战至四合，乃诸牌皆将冰藏。");
            // 索耶的对决
            AddTranslation("Sawyer's Showdown", "索耶之角");
            // 每3回合失去1根骨头，若不足3根则获得1根骨头。
            AddTranslation("Lose 1 bone every 3rd turn, if you have less than 3, gain 1 Bone", "每三合失一骨；若骨未及三，则得一骨。");
            // 罗亚尔大混战
            AddTranslation("Royal Rumble", "罗亚尔之乱");
            // 每打出三张卡牌，第三张将获得“引信”印记。
            AddTranslation("Every third card you play gains the Lit Fuse sigil.", "每陈三牌，则第三牌得燃绳技。");
            // 无魂者
            AddTranslation("Soulless", "无魂");
            // 骷髅牌需额外消耗1点能量。
            AddTranslation("Skeletons cost +1 Energy.", "枯骨牌直加一能。");
            // 脆弱之锤
            AddTranslation("Frail Hammer", "脆锤");
            // 锤子仅在每场头目战后修复。
            AddTranslation("The Hammer gets repaired only after every Boss.", "锤唯每魁后乃修。");
            // 卡壳电椅
            AddTranslation("Jammed Chair", "滞椅");
            // 电椅始终设置为3级。
            AddTranslation("The electric chair is always set to level 3.", "电椅恒设于三级。");
            // 枯萎三叶草
            AddTranslation("Wilted Clover", "槁三叶");
            // 每个卡牌箱内仅存两张卡牌。
            AddTranslation("There is only 2 Cards present at every Card chest.", "凡牌匮惟陈二牌。");
            // 地狱模式
            AddTranslation("Hell Mode", "狱式");
            // 别选这个模式，认真的。（会显著提升遭遇战难度）。
            AddTranslation("Dont play this one, seriously. (Makes encounters Significantly Harder)", "此勿择，诚言也。（使遭遇益难甚）");
            // 无限命数
            AddTranslation("Infinite Lives", "无穷命");
            // 你无法死亡。千真万确。
            AddTranslation("You can't die. Really.", "汝不死。诚然。");
            // 安全座椅
            AddTranslation("Safe Chair", "安椅");
            // 你的卡牌可免疫座椅电流伤害。
            AddTranslation("Your cards are immune to electricity of the chair.", "乃牌不受椅电。");
            // 骨王之悯
            AddTranslation("Bone Lords Mercy", "骨王之悯");
            // 当你将任意免费卡牌放置到牌桌时，获得一根骨。头
            AddTranslation("Gain a Bone when you place any free Card on the Board.", "凡汝陈一无直之牌于局，则得一骨。");
            // 安卡十字之赐
            AddTranslation("Blessing of the Ankh", "安卡之祐");
            // 在法老战与首领战时，获得额外的起始骨头与能量。
            AddTranslation("Start Pharaoh Battles and Bosses with an extra starting Bone and Energy.", "法老战与诸魁战始时，加一骨一能。");
            // 复仇食尸鬼
            AddTranslation("Vengeant Ghouls", "雠冢鬼");
            // 凯茜、索耶和罗亚尔都藏着新把戏。
            AddTranslation("Kaycee, Sawyer and Royal have new tricks up their sleeve", "凯茜、索耶、罗亚尔皆藏新伎。");
            // 豪赌客
            AddTranslation("High Roller", "豪博者");
            // 罗亚尔将被新面孔取代。
            AddTranslation("Royal is replaced by a new face", "罗亚尔易以新面。");

            // Debug
            // 卡牌选择
            AddTranslation("Card Choice", "择牌");
            // 稀有卡牌选择
            AddTranslation("Rare Card Choice", "稀牌之择");
            // 调试宝箱
            AddTranslation("Debug Chests", "试匮");
            // 基础模组卡牌加入牌组
            AddTranslation("Base Mod Cards To Deck", "补缀本牌纳列");
            // 自定义模组卡牌加入牌组
            AddTranslation("Custom Mod Cards To Deck", "自定补缀牌纳列");
            // 调试工具
            AddTranslation("Debug Tools", "试具");
            // 调试遭遇战
            AddTranslation("Debug Encounters", "试遭遇");
            // 禁用换手铃
            AddTranslation("Disable Combat Bell", "废战铃");
            // 禁用锤子
            AddTranslation("Disable Hammer", "废锤");
            // 禁用手部模型
            AddTranslation("Disable Hand Model", "废手形");
            // 基础模组卡牌加入手牌
            AddTranslation("Base Mod Cards To Hand", "补缀本牌纳手");
            // 自定义模组卡牌加入手牌
            AddTranslation("Custom Mod Cards To Hand", "自定补缀牌纳手");
            // 生成对手1号位
            AddTranslation("Spawn Opponent Slot 1", "生敌位一");
            // 生成对手2号位
            AddTranslation("Spawn Opponent Slot 2", "生敌位二");
            // 生成对手3号位
            AddTranslation("Spawn Opponent Slot 3", "生敌位三");
            // 生成对手4号位
            AddTranslation("Spawn Opponent Slot 4", "生敌位四");
            // 生成所有对手卡牌位
            AddTranslation("Spawn All Opponent Slots", "尽生敌位");
            // 从双子巨人处开始
            AddTranslation("Start at Twin Giants", "起于双巨");
            // 从骨王处开始
            AddTranslation("Start at Bonelord", "起于骨王");
            // 赢得本轮
            AddTranslation("Win Round", "胜此轮");
            // 输掉本轮
            AddTranslation("Lose Round", "败此轮");
            // 添加骨头
            AddTranslation("Add Bones", "益骨");
            // 添加能量
            AddTranslation("Add Energy", "益能");
            // 清空牌组
            AddTranslation("Clear Deck", "空牌列");
            // 重置移除部件
            AddTranslation("Reset Removed Pieces", "复所除之件");
            // 消灭对手卡牌
            AddTranslation("Kill Opponent Cards", "杀敌牌");
            // 抽主牌组
            AddTranslation("Draw Main Deck", "引主列");
            // 抽副牌组
            AddTranslation("Draw Side Deck", "引副列");

            // Credits
            // 猫又名Bastard Man又名Little Guy
            AddTranslation("Cat aka Bastard Man aka Little Guy", "猫，亦曰Bastard Man，亦曰Little Guy");
            // API开发者
            AddTranslation("API Developers", "API诸制者");
            // 骨王
            AddTranslation("The Bone Lord", "骨王");
            // 格里魔拉
            AddTranslation("Grimora", "格里魔拉");
            // 旧数据
            AddTranslation("The Old Data", "旧数据");
            // 感谢游玩
            AddTranslation("Thank you for playing", "谢汝游之");
            // 创作者
            AddTranslation("Creator", "作者");
            // 编程
            AddTranslation("Programming", "程式");
            // 原声带
            AddTranslation("Soundtrack", "乐");
            // 美术
            AddTranslation("Artwork", "图绘");
            // 文案
            AddTranslation("Writing", "辞章");
            // 3D建模
            AddTranslation("3D Modelling", "三维塑形");
            // 存档与道具管理
            AddTranslation("Save + Items Manager", "存档与器管");
            // 附加代码
            AddTranslation("Additional Code", "附代码");
            // 音效与附加美术
            AddTranslation("SFX, Additional Art", "音效与附绘");
            // 附加美术、特效与代码
            AddTranslation("Additional Art, VFX and code", "附绘、特效与代码");
            // 附加卡牌立绘
            AddTranslation("Additional Card Portraits", "附牌像");
            // 攻击动画
            AddTranslation("Attack animations", "攻之动象");
            // 能量无人机游戏对象
            AddTranslation("Energy Drone Game Object", "能机傀物");
            // 附加对话
            AddTranslation("Additional Dialogue", "附对语");
            // 对话协助
            AddTranslation("Dialogue Help", "对语佐");
            // 奖励的美术与杂项工作
            AddTranslation("Boon Artwork, miscellanious work", "惠图与杂作");
            // 《邪恶冥刻》创作者
            AddTranslation("Creator of Inscryption", "《冥锲》作者");
            // 狗
            AddTranslation("Dog", "犬");
            // 惊不惊喜，也是狗
            AddTranslation("Suprisingly, also a Dog", "亦犬也");
            // 猫 - 联合创作者
            AddTranslation("Cat - co-creator", "猫——共作者");
            // P03KC模组
            AddTranslation("P03KCMod", "P03KC补缀");
            // 蔓尼菲科模组（感谢3次）
            AddTranslation("Magnificus Mod (3 times)", "蔓尼菲科补缀（三次）");
            // Inscryption API（废话）
            AddTranslation("Inscryption API (Duh)", "《冥锲》API（然也）");
            // 显而易见的原因
            AddTranslation("Obvious reasons", "显然之故");
            // 你的霸主
            AddTranslation("Your overlord", "乃上主");
            // 你最亲爱的冥刻者
            AddTranslation("Your dearest Scrybe", "乃至爱之冥刻者");
            // [数据删除]
            AddTranslation("[Redacted]", "[删去]");
        }
    }
}
