using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch52
    {
        public static void RegisterTranslations()
        {
            RegisterP03SigilariumBatchFour();
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

        private static void RegisterP03SigilariumBatchFour()
        {
            // 燃料
            AddTranslation("Fuel", "油");
            // 燃料护盾
            AddTranslation("Fuel Shield", "油盾");
            // 只要[creature]还有燃料，受到伤害时会优先消耗燃料而非生命值。
            AddTranslation("As long as [creature] has fuel, it takes damage by losing fuel instead of health.", "惟[creature]有油，受伤则先耗其油，不损其命。");
            // 燃料虹吸
            AddTranslation("Fuel Siphon", "吸油");
            // 当[creature]直接对对手造成伤害时，获得等量燃料。
            AddTranslation("Whenever [creature] deals damage directly to the opponent, it gains that much fuel.", "[creature]直伤敌，则得油如其伤。");
            // 血液满溢
            AddTranslation("Full of Blood", "盈血");
            // [creature]可被献祭以支付血量费用。
            AddTranslation("[creature] can be sacrificed to pay blood costs.", "[creature]可见祀以当血价。");
            // 燃油满溢
            AddTranslation("Full of Oil", "盈油");
            // 当[creature]死亡时，会为它两侧及对面的每张卡牌增加3点生命值。
            AddTranslation("When [creature] dies, it adds 3 health to each card on either side and across from it.", "[creature]死，则其两旁与其对之诸牌各命益三。");
            // 满载
            AddTranslation("Fully Loaded", "满载");
            // 当[creature]死亡时，会在其所在列留下永久的+1攻击力加成。
            AddTranslation("When [creature] dies, it leaves a permanent +1 attack bonus in the lane it occupied.", "[creature]死，则其所居之列遗永久益威一之效。");
            // 该卡槽的卡牌将获得+1攻击力。
            AddTranslation("The card in this slot has its power increased by one.", "此位之牌，威益一。");
            // 防御
            AddTranslation("Defend", "御");
            // 当[creature]选定一个位置时，目标将获得纳米铠甲。
            AddTranslation("When [creature] targets a slot, the target gains Nano Armor.", "[creature]所指之位，受微铠。");
            // 蓝色玛珂之赠
            AddTranslation("Blue Mox Gift", "蓝玛珂之赠");
            // [creature]阵亡时，若你打出了蓝色玛珂，则获得一张随机卡牌。
            AddTranslation("When [creature] perishes, if you control an Blue Mox, gain a random card.", "[creature]死，若汝御蓝玛珂，则得一偶牌。");
            // 蓝色玛珂劫掠
            AddTranslation("Blue Mox Looter", "蓝玛珂掠");
            // 当[creature]直接造成伤害时，若你打出了蓝色玛珂，每造成1点伤害即可抽一张牌。
            AddTranslation("When [creature] deals damage directly, if you control a Blue Mox, draw a card for each damage dealt.", "[creature]直伤，若汝御蓝玛珂，则每伤一，引一牌。");
            // 纯蓝主义
            AddTranslation("Purist With Blue", "蓝纯");
            // 若[creature]的持牌人打出有一张蓝色玛珂牌，则与[creature]对战的卡牌将失去所有印记。
            AddTranslation("If the owner of [creature] controls a Blue Mox, cards opposing [creature] have their sigils removed.", "若[creature]之主持有蓝玛珂，则其对牌失诸印。");
            // 无绿生厌
            AddTranslation("Annoying Without Green", "无绿则可厌");
            // 若[creature]的持牌人未打出绿宝石，则与之对阵的造物获得1点力量。
            AddTranslation("The creature opposing [creature] gains 1 power unless the owner of [creature] also controls a Green Mox.", "若[creature]之主持无绿玛珂，则其对物威益一。");
            // 绿色玛珂之赠
            AddTranslation("Green Mox Gift", "绿玛珂之赠");
            // [creature]阵亡时，若你打出了绿色玛珂，则获得一张随机卡牌。
            AddTranslation("When [creature] perishes, if you control a Green Mox, gain a random card.", "[creature]死，若汝御绿玛珂，则得一偶牌。");
            // 无橙即碎
            AddTranslation("Brittle Without Orange", "无橙则脆");
            // 攻击之后，若持牌人未打出橙色玛珂，[creature]会自毁。
            AddTranslation("After attacking, [creature] will perish if its owner does not control an Orange Mox.", "攻后，若其主持无橙玛珂，则[creature]死。");
            // 橙色玛珂空袭
            AddTranslation("Orange Mox Airborne", "橙玛珂翔袭");
            // 若你打出了橙色玛珂，[creature]将无视对面卡牌直接攻击对手。
            AddTranslation("If you control an Orange Mox, [creature] will ignore opposing cards and strike an opponent directly.", "若汝御橙玛珂，则[creature]无视其对牌，直击其主。");
            // 橙色玛珂打印机
            AddTranslation("Orange Mox Printer", "橙玛珂印机");
            // 若你打出了橙色玛珂，[creature]将在每回合开始时从副牌组抽一张牌。
            AddTranslation("If you control an Orange Mox, [creature] will draw a card from your side deck at the start of every turn.", "若汝御橙玛珂，则[creature]每合始，自副牌列引一牌。");
            // 宝石打击
            AddTranslation("Gem Strike", "玉击");
            // [creature]会根据持牌人打出的宝石提供器数量进行多次攻击。
            AddTranslation("[creature] attacks once for each gem provider its owner controls.", "[creature]每其主持所御一供玉者，则攻一次。");
            // 绿宝石力量
            AddTranslation("Emerald Power", "绿玉威");
            // 该印记代表的数值等于持牌人控制的绿宝石数量。
            AddTranslation("The value represented with this sigil will be equal to the number of green gems its owner controls.", "此印所表之数，与其主持所御绿玉之数等。");
            // 跑赢
            AddTranslation("Hopper", "跃");
            // 每回合结束时，[creature]会移动到持牌人指定的空位。
            AddTranslation("At the end of each turn, [creature] moves to an empty space of its owner's choosing.", "每合终，[creature]移于其主持所择之虚位。");
            // 克拉肯易形
            AddTranslation("Kraken Transformer", "克拉肯易形");
            // 在你的回合开始时，[creature]会在当前状态和克拉肯状态间切换一次。
            AddTranslation("At the beginning of your turn, [creature] will transform to, or from, Kraken mode.", "汝合始，[creature]一变为克拉肯之形，或反之。");
            // 恼人传花
            AddTranslation("Annoying Latch", "可厌遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承惹人生厌印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Annoying sigil.", "[creature]死，则其主持择一物，受可厌印契。");
            // 死亡传花
            AddTranslation("Death Latch", "死遗契");
            // [creature]将在回合结束时死亡。当[creature]阵亡时，其持牌人需选定下一个继承该印记的造物。此过程将循环往复。
            AddTranslation("[creature] will die at the end of the turn. When [creature] perishes, its owner chooses a creature to gain this sigil. This will repeat.", "[creature]将于合终死。其死，则其主持择一物，受此印契；如是循环。");
            // 首印传花
            AddTranslation("First Latch", "首印遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承该卡牌首个印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the first sigil this card has.", "[creature]死，则其主持择一物，受此牌之首印。");
            // 空袭传花
            AddTranslation("Airborne Latch", "翔袭遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承空袭印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Airborne sigil.", "[creature]死，则其主持择一物，受翔袭印契。");
            // 管道传花
            AddTranslation("Conduit Latch", "虚渠遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承空无管道印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Null Conduit sigil.", "[creature]死，则其主持择一物，受虚渠印契。");
            // 冲撞传花
            AddTranslation("Rampage Latch", "横冲遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承横冲直撞印记的造物。目标获得印记时将立即发动一次冲撞攻击。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Rampager sigil. The target will immediately rampage once when the latch is applied.", "[creature]死，则其主持择一物，受横冲印契。受之时，即先横冲一度。");
            // 臭臭传花
            AddTranslation("Stinky Latch", "恶臭遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承臭臭印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Stinky sigil.", "[creature]死，则其主持择一物，受恶臭印契。");
            // 交换传花
            AddTranslation("Swapper Latch", "易数遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承交换器印记的造物。目标获得印记时将立即触发一次属性交换。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Swapper sigil. The target will immediately swap stats once when the latch is applied.", "[creature]死，则其主持择一物，受易数印契。受之时，即一易其数。");
            // 战利品箱
            AddTranslation("Lootbox", "掠匣");
            // 当[creature]击杀一张卡牌时，你的手牌中会随机生成一张卡牌。
            AddTranslation("Whenever [creature] kills a card, a random card is created in your hand.", "凡[creature]杀一牌，汝手生一偶牌。");
            // 生死与共
            AddTranslation("Synchronized Fate", "同命");
            // 当[creature]死亡时，你将输掉游戏。
            AddTranslation("When [creature] dies, you lose the game.", "[creature]死，则汝败。");
            // 魔法粉尘
            AddTranslation("Magic Dust", "灵尘");
            // 当[creature]死亡时，会在牌桌上留下一颗宝石。之后放置在该位置的卡牌都会提供相同类型的宝石。
            AddTranslation("When [creature] dies, it leaves one of its gems behind on the board. Any future cards in that space will provide those gems.", "[creature]死，则遗其一玉于局上。后陈于其位者，皆供其同类之玉。");
            // 蓝色玛珂卡槽
            AddTranslation("Blue Mox Slot", "蓝玛珂位");
            // 放置在该卡槽的卡牌会提供蓝色玛珂。
            AddTranslation("The card in this slot will provide a Blue Mox.", "处此位之牌，供蓝玛珂。");
            // 橙色玛珂卡槽
            AddTranslation("Orange Mox Slot", "橙玛珂位");
            // 放置在该卡槽的卡牌会提供橙色玛珂。
            AddTranslation("The card in this slot will provide an Orange Mox.", "处此位之牌，供橙玛珂。");
            // 绿色玛珂卡槽
            AddTranslation("Green Mox Slot", "绿玛珂位");
            // 放置在该卡槽的卡牌会提供绿色玛珂。
            AddTranslation("The card in this slot will provide a Green Mox.", "处此位之牌，供绿玛珂。");
            // 至尊玛珂卡槽
            AddTranslation("Great Mox Slot", "至尊玛珂位");
            // 放置在该卡槽的卡牌会同时提供三种玛珂。
            AddTranslation("The card in this slot will provide all three moxen.", "处此位之牌，并供三玛珂。");
            // 探矿者
            AddTranslation("Miner", "矿夫");
            // [creature]会在对手回合时潜入地下。潜地期间，敌方造物将直接攻击其持牌人。当它重返地面时，会为持牌人创造一张新卡牌。
            AddTranslation("[creature] buries itself during its opponent's turn. While buried, opposing creatures attack its owner directly. When it comes back up, it creates a card in its owner's hand.", "[creature]敌合则潜地。既潜，则敌物直攻其主。及其复出，则为其主生一牌于手。");
            // 橡皮图章
            AddTranslation("Rubber Stamp", "印模");
            // 当你使用[creature]时，它会变成你选择的另一个造物的复制品。若该造物具有其他能力，这些能力也将被转移（最多4个）。
            AddTranslation("Whenever you play [creature], it becomes a copy of another creature of your choosing. If this creature has other abilities, those abilities will be transferred (up to the maximum of 4).", "汝每陈[creature]，则其化为汝所择他物之副。若彼物别有诸技，则其技亦从之（至多四）。");
            // 导弹发射器
            AddTranslation("Launch Missile", "发弹");
            // [creature]可跳过本回合攻击以发射导弹，导弹将在下回合落地并对相邻位置造成溅射伤害。弹药有限，请谨慎使用。
            AddTranslation("[creature] can skip its attack this turn to launch a missile that lands on the next turn, splashing damage to adjacent spaces. Use carefully - ammo is limited.", "[creature]此合可舍其攻，以发一弹；后合乃坠，并旁溅其伤。慎用之，弹有限。");
            // 自我发射器
            AddTranslation("Launch Self", "自发");
            // [creature]可牺牲自己发射一枚导弹，导弹将在下回合落地并对相邻位置造成溅射伤害。
            AddTranslation("[creature] can sacrifice itself to launch a missile that lands on the next turn, splashing damage to adjacent spaces.", "[creature]可自祀以发一弹；后合乃坠，并旁溅其伤。");
            // 易燃
            AddTranslation("Flammable", "易燔");
            // 当[creature]死亡时，它会爆炸并使相邻位置燃烧3回合。
            AddTranslation("When [creature] dies, it detonates and sets adjacent spaces on fire for three turns.", "[creature]死，则爆，且其邻位焚三合。");
            // 纵火狂
            AddTranslation("Arsonist", "纵火");
            // 当使用[creature]时，牌桌上所有位置将燃烧4个回合。
            AddTranslation("When [creature] is played, it sets all spaces on the board on fire for four turns.", "[creature]既陈，局上诸位皆焚四合。");
        }
    }
}
