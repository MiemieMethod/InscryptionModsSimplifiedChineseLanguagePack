using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch4
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraLaterCards();
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

        private static void RegisterGrimoraLaterCards()
        {
            // 藏身盔甲或寒冰又有何区别。这具骸骨终将腐朽。
            AddTranslation("HIDING IN A SUIT OF ARMOR, OR ICE, WHAT DOES IT MATTER. THIS SKELETON WON'T LAST FOREVER.", "匿于甲，抑匿于冰，奚异焉？此枯骨终必朽。");
            // 尸鬼
            AddTranslation("Draugr", "尸鬼");
            // 多么可悲的景象，无人知晓那井底究竟藏着什么。
            AddTranslation("WHAT A SAD SIGHT, NO ONE SHALL KNOW WHAT LIES AT THE BOTTOM OF THAT WELL.", "悲哉此状，莫知彼井底所藏。");
            // 淹死鬼
            AddTranslation("Drowned Soul", "溺魂");
            // 无人知晓附鬼究竟为何物，有人说最好永远别知道。
            AddTranslation("NO ONE KNOWS WHAT EXACTLY THE DYBBUK IS, SOME SAY IT IS BETTER LEFT UNKNOWN.", "附鬼果何物，莫之知也；或曰毋知之为善。");
            // 附鬼
            AddTranslation("Dybbuk", "附鬼");
            // 灵质
            AddTranslation("Ectoplasm", "灵质");
            // 游魂之精魄，潜藏于每个角落与阴影。一旦发现其一，余者自会接踵显现。
            AddTranslation("THE ESSENCE OF A SPIRIT, HIDDEN IN EVERY CORNER AND EVERY SHADOW. ONCE YOU SEE ONE, YOU WILL FIND THE REST SOON ENOUGH.", "魂之精也，匿于众隅群阴。既见其一，余者旋见。");
            // 一个活生生的失败品，它所知晓的一切只给它带来了死亡，或者说至少是类似死亡的东西。
            AddTranslation("A LIVING FAILURE, ITS KNOWLEDGE ONLY BROUGHT IT DEATH, OR AT LEAST AN APPROXIMATION OF IT.", "生而为败，其所知徒致其死，抑近死耳。");
            // 骨爪
            AddTranslation("Boneclaw", "骨爪");
            // 无骨者
            AddTranslation("Boneless", "无骨者");
            // 这副骷髅似乎抛弃了这具无生命的躯壳，去追寻更伟大的事业。
            AddTranslation("It's Skeleton seems to have left this lifeless husk in order to achieve greater things.", "其骨似已舍此槁壳，以图大事。");
            // 次级木乃伊
            AddTranslation("Lesser Mummy", "次木乃伊");
            // 法老忠实的仆从，随葬以在死后永世效忠。
            AddTranslation("A loyal servant to the Pharao, buried with him to serve eternally in death.", "法老之忠臣也，与之同葬，死而永事之。");
            // 英灵
            AddTranslation("Eidolon", "英灵");
            // 远古附魔的傀儡，誓死守护太阳纪元。
            AddTranslation("A GOLEM ENCHANTED LONG AGO, BOUND TO PROTECT THE AGE OF SUN.", "古所祝之偶，缚以守日世。");
            // 相当顽劣的精魂，它散播火焰以制造混乱。
            AddTranslation("QUITE A MISCHIEVOUS SPIRIT, IT SPREADS ITS FLAMES TO CAUSE DISMAY.", "顽劣之精魂，散焰以乱众。");
            // 烬魂
            AddTranslation("Ember Spirit", "烬魂");
            // 家族渴望安息，却被迫在永恒之战中反复应召。
            AddTranslation("THE FAMILY WISHES TO REST IN PEACE, ONLY TO BE SUMMONED AGAIN AND AGAIN IN AN ETERNAL BATTLE.", "其家愿安，而数见召于无穷之战。");
            // 行师走人
            AddTranslation("The Walkers", "行尸");
            // 据说它们散发的恶臭如此浓烈刺鼻，就连亡灵都能闻到！
            AddTranslation("It is said their odor is so strong and repugnant, even the undead can feel it!", "其臭浓恶，虽亡者亦觉之！");
            // 溃烂行尸
            AddTranslation("Festering Wretch", "腐尸");
            // 火焰
            AddTranslation("Flames", "焰");
            // 烈焰颅骨
            AddTranslation("Flameskull", "焰颅");
            // 永远飞行，永远愤怒，永远在过程中烦扰附近的盟友。
            AddTranslation("Always flying, always angry, always annoying nearby allies in the process.", "恒翔，恒怒，而恒扰邻友。");
            // 一个浑身湿透的水手，背负着悲惨的过往。具体细节我已记不清了。
            AddTranslation("A waterlogged sailor who carries his tragic past beside him. I don't remember the details.", "湿透之舟人，负其惨往而行。其详余忘之矣。");
            // 遗忘者
            AddTranslation("Forgotten Man", "遗人");
            // 至交好友，手足兄弟，并肩战士。
            AddTranslation("BEST FRIENDS, BROTHERS, AND FIGHTERS.", "至友、昆弟、战士也。");
            // 弗兰肯和斯坦
            AddTranslation("Frank & Stein", "弗兰克与斯坦");
            // 弗兰肯斯坦
            AddTranslation("FrankenStein", "弗兰肯斯坦");
            // 阴森可怖的守护灵。它在黑暗中疾驰而过，身后残留着不散的灵体。
            AddTranslation("A ghastly guardian spirit. It's presence lingers behind as it sprints through the dark.", "阴惨之守灵，驰于冥中，而遗影不散。");
            // 陪伴者
            AddTranslation("Fylgja", "伴灵");
            // 警戒之影
            AddTranslation("Warding Presence", "卫影");
            // 这些骸骨因何而生，战争、饥荒还是其他灾祸？此刻或许微不足道，但我恐惧它将孕育之物……
            AddTranslation("WHAT CREATED THESE BONES, WAR, FAMINE OR ANOTHER TRAGEDY? It may be insignificant now, but I fear what it might become...", "此骨何由而生？战乎，饥乎，抑他祸乎？今或微末，然余惧其后之所成……");
            // 万人冢
            AddTranslation("Mass Grave", "万人冢");
            // 暴食
            AddTranslation("Rising Hunger", "长饥");
            // 饿者骷髅
            AddTranslation("Gashadokuro", "饥骨");
            // 海盗们将这艘船视为归宿，即便死后亦然。一颗被斩杀的巨人颅骨成了他们的船首像。
            AddTranslation("THE PIRATES CALL THIS SHIP THEIR HOME, EVEN IN DEATH. A SLAIN GIANTS SKULL SERVES AS THEIR FIGUREHEAD.", "海上之盗以此舟为家，虽死亦然。其首像，乃一见戮巨人之颅。");
            // 幽灵船
            AddTranslation("Ghost Ship", "鬼舟");
            // 巨人
            AddTranslation("Giant", "巨人");
            // 传说中的巨人族早已灭绝，此乃明证。实乃奇观。
            AddTranslation("THE FAMED RACE OF GIANTS IS SAID TO HAVE DIED OUT LONG AGO, THIS IS PROOF. TRULY A SIGHT TO BEHOLD.", "所谓巨人之族，云久已灭矣；此其征也。诚奇观也。");
            // 受困于尘世，他们徘徊不去只为有朝一日能得安葬。
            AddTranslation("BOUND TO EARTH, THEY CLING ON SO THEY MAY ONE DAY GET PROPER BURIAL.", "系于尘世，流连不去，冀终得葬耳。");
            // 感恩亡魂
            AddTranslation("Grateful Dead", "感德亡魂");
            // 卑微的墓吟者，在最黑暗的岁月里，音乐始终是他唯一的慰藉。如今，即便世界终结，他仍吟唱着那首歌谣。
            AddTranslation("THE LOWLY GRAVEBARD, MUSIC ALWAYS BROUGHT HIM COMFORT IN THE WORST OF TIMES. NOW, EVEN AT THE END OF THE WORLD HE SHARES HIS SONG.", "卑贱之墓吟者，穷时唯乐足慰之。今虽世终，犹歌以与众。");
            // 墓吟者
            AddTranslation("Gravebard", "墓吟者");
            // 他穷尽一生雕琢这些造物，这张卡承载着他灵魂的一部分。
            AddTranslation("HE HAS SPENT HIS LIFE CARVING THESE CREATURES, THIS CARD CONTAINS A PART OF HIS SOUL.", "彼尽生平以刻此诸物，此牌载其魂之一分。");
            // 刻墓人
            AddTranslation("Grave Carver", "刻冢者");
            // 他独自挖掘着骨头，希望能找到宝藏，就像他祖母当年那样。
            AddTranslation("HE SPENDS HIS TIME ALONE DIGGING FOR BONES IN HOPES OF FINDING A TREASURE. JUST LIKE HIS GRANDMA BEFORE HIM.", "独自掘骨，冀得宝焉，如其祖母昔然。");
            // 掘墓人
            AddTranslation("Gravedigger", "掘冢者");
            // 一个饱受摧残的灵魂。其菌丝深入土壤，引导着铁锹的挖掘。
            AddTranslation("A POOR, BRUTALIZED SOUL. THEIR MYCELIA PROBES FAR INTO THE SOIL, GUIDING THEIR SPADE.", "哀魂也，饱遭摧折。其菌丝深探于土，以导其铲。");
            // 掘孢人
            AddTranslation("Sporedigger", "掘蕈者");
            // 忠实的守护之灵。即使被驱散，也会赐予保护祝福。
            AddTranslation("A devoted guardian spirit. Even when dispelled, it grants a protective blessing.", "笃守之灵。虽散，犹赐祐护。");
            // 哈尔蒂亚
            AddTranslation("Haltia", "哈尔蒂亚");
            // 我建议你别盯着看——你不会喜欢回望你的东西。
            AddTranslation("I advise against staring into it, you won't like what stares back.", "余劝汝毋久视之——反视汝者，必非汝所喜。");
            // 闹鬼魔镜
            AddTranslation("Haunted Mirror", "祟镜");
            // 人称其为天启骑士。她的烈焰之刃能同时斩断生者与亡魂。
            AddTranslation("THEY CALL HER THE RIDER OF THE APOCALYPSE. HER FLAMING BLADE CUTS THROUGH THE LIVING AND DEAD ALIKE.", "人谓之末劫骑者。其炎刃兼斩生死。");
            // 无头骑士
            AddTranslation("Headless Horseman", "无首骑者");
            // 亲爱的，可别靠太近。一旦被地狱最深处伸出的魔爪攫住，就再也无法挣脱了。
            AddTranslation("I WOULDN'T GET TOO CLOSE DEAR. YOU CAN'T BREAK THE HOLD FROM THE DEEPEST PITS OF HELL, ONCE IT LATCHES ON.", "毋近之太甚。一为狱底之爪所攫，则不可脱。");
            // 地狱魔爪
            AddTranslation("Hellhand", "狱爪");
            // 地狱犬
            AddTranslation("Hell Hound", "狱犬");
            // 一条疯犬。它杀死了我的一个食尸鬼。
            AddTranslation("A RABID DOG. IT KILLED ONE OF MY GHOULS.", "狂犬也。尝杀朕一冢鬼。");
            // 关于传说中的九头蛇，流传着这样的传说：它是吞噬万物的凶兽，也是所有航海者的梦魇。
            AddTranslation("LEGENDS HAVE BEEN TOLD ABOUT THE LEGENDARY HYDRA, THE BEAST THAT SWALLOWS ALL AND THE BANE OF ALL THAT SAIL THE SEAS.", "九首蛇之传，传之久矣。其吞万物，而为航海者之害。");
            // 九头蛇
            AddTranslation("Hydra", "九首蛇");
            // 生前被贪食吞噬，死后仍受贪欲诅咒。奇怪的是会激发对骨头的贪婪。
            AddTranslation("Overtaken by it's gluttony in life, doomed to it's gluttony in death. Oddly inspires a greed for bones.", "生为饕所役，死亦为饕所锢。怪哉，又能发人贪骨之心。");
            // 食人鬼
            AddTranslation("Jikininki", "食人鬼");
            // 雪崩
            AddTranslation("Avalanche", "雪崩");
            // 冰川
            AddTranslation("Glacier", "冰川");
            // 我很好奇究竟是何物被冰封了如此之久。
            AddTranslation("I WONDER WHAT HAS BEEN FROZEN AWAY FOR SO LONG.", "余怪何物久见冰封。");
            // 冰霜巨人
            AddTranslation("Frost Giant", "霜巨人");
            // 冰块
            AddTranslation("Ice Cube", "冰块");
            // 一具将头颅浸在冰河中死去的尸体。复生后仍执意保留凝结的寒冰。
            AddTranslation("A CORPSE WHO DIED WITH HIS HEAD IN A GLACIAL STREAM. AFTER HIS REANIMATION, HE COULDN'T BEAR TO PART WITH THE ICE THAT HAD FORMED.", "一尸死时，首没冰溪。既复起，犹不忍去所结之冰。");
            // 在溺死自己的孩子后投水自尽，如今仍在拖人下水。
            AddTranslation("After drowning her children and then herself, she continues to drown others.", "既溺其子，复溺其身，今犹溺人。");
            // 哭泣女妖
            AddTranslation("La Llorona", "泣女妖");
            // 魔娜娜迦
            AddTranslation("Manananggal", "魔娜娜迦");
            // 残暴无法满足魔娜娜迦。当你目睹她腰斩分躯之时，你也将成为这场猎杀的牺牲品。
            AddTranslation("NO BRUTALITY SATIATES THE MANANANGGAL. WHEN YOU SEE HER SEVER FROM HER TORSO, YOU TOO WILL BE A VICTIM OF THE HUNT.", "残暴不足餍魔娜娜迦。一见其躯自腰而离，汝亦为其猎矣。");
            // 魔洛伊，又称毛鬼。它会吸取附近阵亡者的灵魂。
            AddTranslation("Moroi, also known as the hairy ghost. It leeches the souls from those struck down near it.", "魔洛伊，一名毛鬼。凡近其而毙者，魂皆为之所吮。");
            // 魔洛伊
            AddTranslation("Moroi", "魔洛伊");
            // 昔日荣光早已消逝，却仍支撑他蹒跚前行。
            AddTranslation("HIS AGE OF GLORY IS LONG GONE, YET IT IS WHAT KEEPS HIM GOING.", "昔荣已逝，然犹恃之而行。");
        }
    }
}
