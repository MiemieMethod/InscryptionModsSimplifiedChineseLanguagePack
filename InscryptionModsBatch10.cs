using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch10
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraEventsAndDuels();
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

        private static void RegisterGrimoraEventsAndDuels()
        {
            // 一座孤坟肃穆地矗立在你面前。
            AddTranslation("A LONE GRAVE SITS SOLEMNLY IN FRONT OF YOU.", "一孤冢肃然在汝前。");
            // 坟前有一抔新土，是某位逝者留下的。
            AddTranslation("IN FRONT OF IT IS A MOUND OF EARTH, LEFT BY SOMEONE WHO'S ALREADY PASSED ON.", "冢前有一抔新土，乃既逝者所遗。");
            // 或许该派你亡灵大军中的一员来掘开它？
            AddTranslation("PERHAPS A MEMBER OF YOUR UNDEAD HORDE COULD [c:bR]DIG THEM UP?[c:]", "或可使汝亡军之一[c:bR]发之[c:]乎？");
            // 当然这并非没有代价，毕竟死亡从非永恒。
            AddTranslation("THIS WOULDN'T BE WITHOUT REPERCUSSIONS OF COURSE, AS DEATH IS NEVER PERMANENT.", "然岂无报乎？盖死未尝永也。");
            // 这具腐尸的血肉正在溃烂，你的卡牌会变得脆弱，但骨头消耗减半。
            AddTranslation("THE CORPSE SEEMS TO BE OF ROTTING FLESH, YOUR CARD WILL BECOME [c:bR]BRITTLE[c:], BUT [c:bR]ITS BONE COST WILL BE HALVED[c:].", "此尸肌肉方腐，汝牌将得[c:bR]脆骨[c:]，而[c:bR]骨直减半[c:]。");
            // 这具饿殍干瘪枯瘦，你的卡牌将永远饥渴，但骨头消耗减少2点。
            AddTranslation("THE CORPSE SEEMS TO BE OF A STARVED MAN, YOUR CARD WILL [c:bR]STARVE FOREVER[c:], BUT [c:bR]ITS BONE COST WILL BE REDUCED BY 2[c:].", "此尸似饿殍，汝牌将[c:bR]永饥[c:]，而[c:bR]骨直减二[c:]。");
            // 这具灵体虚无缥缈，你的卡牌需消耗2个灵魂，但骨头消耗减少1点。
            AddTranslation("THE CORPSE SEEMS TO BE OF AN INCORPOREAL GHOST, YOUR CARD WILL [c:bR]COST 2 SOULS[c:] , BUT [c:bR]ITS BONE COST WILL BE REDUCED BY 1[c:].", "此尸似无形之鬼，汝牌将[c:bR]直二魂[c:]，而[c:bR]骨直减一[c:]。");
            // 这具囚尸带着镣铐，你的卡牌伤害+1，但会变得极其脆弱。
            AddTranslation("THE CORPSE SEEMS TO BE OF A CHAINED PRISONER, YOUR CARD WILL [c:bR]DEAL 1 MORE DAMAGE[c:] , BUT [c:bR]IT WILL BECOME VERY FRAIL[c:].", "此尸若系囚，汝牌将[c:bR]多伤一[c:]，而[c:bR]至脆[c:]。");
            // 这具顽灵诡谲多变，你的卡牌将附身他人，但需消耗3个灵魂。
            AddTranslation("THE CORPSE SEEMS TO BE OF A MISCHIEVIOUS SPIRIT, YOUR CARD WILL [c:bR]HAUNT OTHERS[c:] , BUT [c:bR]WILL COST 3 SOULS[c:].", "此尸似顽灵，汝牌将[c:bR]祟他物[c:]，而[c:bR]直三魂[c:]。");
            // 妙极了！它们刨出尸体后竟爬了回来。
            AddTranslation("MARVELOUS! THEY CAME CRAWLING BACK AFTER DIGGING UP THE CORPSE.", "善哉！彼等掘尸之后，竟匍匐而归。");
            // 看来它们依然心系于你！
            AddTranslation("THEY STILL CARE ABOUT YOU IT SEEMS!", "彼等似犹念汝！");

            foreach (var card in GrimoraCardCatalog.All)
            {
                string sourceName = "[c:R]" + card.Simplified + "[c:]";
                string classicalName = "[c:R]" + card.Classical + "[c:]";
                // 被从永恒安眠中拽出，蹒跚回归亡灵大军。
                AddTranslation("TORN FROM ITS ETERNAL RESPITE WITH A RELUCTANT GROAN, THE " + sourceName + " SHAMBLES BACK TO ITS RIGHTFUL PLACE AMONG YOUR HORDE.", "伴不甘之呻，" + classicalName + "曳自永息，蹒跚归于汝亡军故列。");
            }

            // 它的骨骼被土中生物蛀空，显得怪异而陌生。
            AddTranslation("ITS BONES HOLLOWED THROUGH BY THE CREATURES OF THE SOIL, LEAVING IT FEELING UNNATURAL AND UNFAMILIAR.", "其骨为土中之物蛀空，故形甚怪而不故。");
            // 不过代价的重负似乎也已消散……
            AddTranslation("THOUGH THE WEIGHT OF CONSEQUENCE ALSO SEEMS LIFTED...", "然其报之重，亦若释然……");
            // 看来终于轮到我出场了！
            AddTranslation("It seems i have finally been given my turn!", "看来终于轮到余矣！");
            // 此役过后，我终将获得安息。
            AddTranslation("After this i will finally be at peace.", "此后，余终得安矣。");
            // 好吧，看来我们要从这片冰封山谷开始了。
            AddTranslation("Well, it seems we will start in this frigid valley.", "然则，吾曹将始于此冱谷矣。");
            // 这里想必就是凯茜的栖身之所。
            AddTranslation("It must be where Kaycees resides.", "此必凯茜所居也。");
            // 没想到会在这里再次遇见你！
            AddTranslation("I didn't expect to meet you here again!", "不意复见汝于此！");
            // 删除进程似乎停滞了！
            AddTranslation("It seems the deletion process has stalled!", "削之序似滞矣！");
            // 又是你？
            AddTranslation("You again?", "又汝邪？");
            // 好吧，我想我们可以改日再战。
            AddTranslation("Well, i suppose we can go another time.", "然则，异日可复往也。");
            // 还没被删除吗？
            AddTranslation("Still not deleted?", "犹未削乎？");
            // 这张磁盘里似乎藏着不少东西。
            AddTranslation("Much seems to be contained on this disk.", "此坚盘中，所藏似多。");
            // 或许上次的进程持续时间还不够。
            AddTranslation("Perhaps the last run wasn't long enough.", "前番或未久耳。");
            // 不过我相信凯茜还有精力继续战斗。
            AddTranslation("Well, im sure Kaycee has the energy for more battles.", "然余信凯茜犹有馀力，可更战。");
            // 又是这片冰封山谷
            AddTranslation("The frigid valley, again.", "又此冱谷。");

            foreach (var card in GrimoraCardCatalog.All)
            {
                // 刺骨严寒或许伤人，但休想拖慢它。
                AddTranslation("THE BITTER CHILL MIGHT HURT, BUT IT WON'T SLOW DOWN " + card.Simplified + "!", "苦寒虽伤，终不能迟" + card.Classical + "！");
            }

            // 所有位置都被占满。这次没法召唤军队了。
            AddTranslation("BLOCKED IN ALL SLOTS. NO ARMY THIS TIME.", "诸位皆塞。此番无军矣。");
            // 两侧都被挡上了。这下被遗忘者没地方放沉船了。
            AddTranslation("Blocked on both sides. No Shipwrecks for the Forgotten Man.", "两旁皆塞。遗人无以置其沉舟。");
            // 噢，我最喜欢这个了！
            AddTranslation("Oh, I love this one!", "噫，余最爱此！");
            // 这把电椅能让你驾驭闪电之力，为卡牌赋能变异印记！
            AddTranslation("The Electric Chair, it allows you to harness the power of lightning itself, letting you [c:B]empower[c:] your cards with mutating abilties!", "此电椅使汝御雷霆之力，以[c:B]益[c:]汝牌之变印技！");
            // 不过容我提醒，这可不是普通椅子。通过调节电压旋钮，电压越高变异结果就越难以预料。
            AddTranslation("However, I must warn you, it is no ordinary chair. With the ability to adjust the voltage, a higher level of course increases the unpredictability of the mutation.", "然余必告汝，此非凡椅。能调其电压，压愈高，则所变愈不可料。");
            // 勇者驾驭电流，懦夫随波逐流。
            AddTranslation("The brave will master the current, the cowardly will blindly follow it.", "勇者御电，怯者逐之而已。");
            // 你可有胆量拨动左侧的电压杆，让电流扭曲印记的选择？
            AddTranslation("Are you bold enough to tinker with its lever on the left, letting the voltage corrupt the selection of the sigils?", "汝敢拨其左杆，使电压乱其印契之择乎？");
            // 你的造物定能变得更加强大……
            AddTranslation("SURELY YOUR CREATURE COULD BECOME MORE POWERFUL...", "汝之物固可益强……");
            // 但你需要冒险再承受一次电击。
            AddTranslation("BUT YOU WOULD NEED TO RISK ANOTHER MOMENT UNDER THE SHOCK.", "然须复冒一顷电击之险。");
            // 撤退时兽骨在你左右飞散。
            AddTranslation("BONES FLEW LEFT AND RIGHT AS YOU RETREATED FROM THE SCENE.", "汝退时，骴骨左右迸飞。");

            foreach (var card in GrimoraCardCatalog.All)
            {
                string sourceName = "[c:bR]" + card.Simplified + "[c:]";
                string classicalName = "[c:bR]" + card.Classical + "[c:]";
                // 小心翼翼地把它从电流中抽离后离开。
                AddTranslation("YOU EVER SO CAREFULLY PULL THE " + sourceName + " AWAY FROM THE ELECTRICITY AND LEAVE.", "汝谨引" + classicalName + "离电而去。");
            }

            // 你好啊，亲爱的挑战者，我们又见面了！
            AddTranslation("Hello, dear challenger, we meet again!", "嗟，亲爱之角者，复相见矣！");
            // 准备好来场老派决斗了吗？
            AddTranslation("Are you ready for a good ol' fashioned [c:R]DUEL[c:]?", "汝备一为古式之[c:R]角[c:]乎？");
            // 看来这次多了第三根蜡烛呢……
            AddTranslation("I see, theres a third candle at play this time...", "然则，此番又用第三烛矣……");
            // 这次看来是你技高一筹……
            AddTranslation("I feel you have [c:bG]bested[c:] me this time...", "此番汝似[c:bG]胜[c:]余矣……");
        }
    }
}
