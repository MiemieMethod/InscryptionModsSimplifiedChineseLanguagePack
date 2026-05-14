using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch42
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchSix();
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

        private static void RegisterAllTheSigilsBatchSix()
        {
            // [creature]在正常战斗中不会攻击。它将改为在对手的卡牌攻击后进行攻击。
            AddTranslation("[creature] will not attack during normal combat. It will instead attack after the Opponent's cards attack.", "[creature]常战不攻；俟敌牌既攻而后攻。");
            // 有点慢，嗯？
            AddTranslation("A bit slow there eh?", "少缓矣？");
            // 安眠曲
            AddTranslation("Song of sleep", "眠歌");
            // 如果一个造物移动到[creature]对面的空间，该造物将获得休眠印记。
            AddTranslation("If a creature moves into the space opposing [creature], that creature will obtain the asleep sigil.", "若有物移至[creature]对位，则彼得寐印。");
            // 创造性冲刺
            AddTranslation("Spawner", "生行");
            // 在持牌人的回合结束时，[creature]将按照印记标注的方向移动，并在其原来的位置创造另一个造物。
            AddTranslation("At the end of its owner's turn, [creature] will move in the direction inscribed on the sigil and will create another creature in its old space.", "持牌者合终，[creature]循印所志而移，而故处生别物。");
            // 席卷狂潮
            AddTranslation("Stampede", "驰攻");
            // [creature]如果在非战斗状态下在场地上放置，将导致相邻的造物攻击。
            AddTranslation("[creature] will cause adjacent creatures to attack when played on the board if played not during combat.", "[creature]若于战外既陈，则使其旁诸物出击。");
            // 人多力量大。
            AddTranslation("Power in Numbers", "众则有力。");
            // 如胶似漆
            AddTranslation("Sticky", "胶");
            // 如果[creature]对位的卡牌移动，[creature]将尝试与其一起移动.
            AddTranslation("If the card opposing [creature] moves, [creature] will try to move with it", "若[creature]对位之牌移，[creature]亦尝从之。");
            // 风驰电掣
            AddTranslation("Velocity", "迅");
            // 在持牌人的回合结束时，[creature]将向印记标注的方向移动。如果它能够移动，它将获得1点力量和1点生命。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. If it is able to move, it will gain 1 power and 1 health.", "持牌者合终，[creature]循印所志而移；若能移，则威命各益一。");
            // 强风吹拂
            AddTranslation("Strong Wind", "烈风");
            // 如果[creature]在场上，则取消其后出场的所有卡牌的空袭印记。
            AddTranslation("If [creature] is on the board, negate the airbone sigil of all cards that are played after it.", "凡[creature]在局，后陈之牌，其翔袭印皆废。");
            // 强风迫使着陆。
            AddTranslation("The Wind forces a landing.", "风迫其降。");
            // 水下伏击
            AddTranslation("Submerged Ambush", "潜伏");
            // [creature]在它潜水时，将对攻击过它位置的卡牌造成1点伤害。不影响带有空袭印记的卡牌。
            AddTranslation("[creature] will deal 1 damage to cards that attacked over it while it was face-down. Does not affect cards that are Airborne.", "[creature]翻伏时，凡越其位而攻者，受一伤；翔袭者不与。");
            // 它的攻击来着水下。
            AddTranslation("It strikes from the water.", "出击于水中。");
            // 吞噬者
            AddTranslation("Swallower", "吞");
            // 在[creature]攻击后，如果它的生命值低于它所攻击的卡牌，它将摧毁它所攻击的卡牌并恢复所有生命。
            AddTranslation("After [creature] attacks, it will destroy the card it attacks if it has less health than it and heal to full health.", "攻后，若所攻之牌命少于[creature]，则毁之，而[creature]命尽复。");
            // 一饮而尽。
            AddTranslation("Gone in one gulp.", "一啜而尽。");
            // 同情
            AddTranslation("Sympathetic", "恤");
            // [creature]只有当对位造物的生命值不小于它时，才会攻击。
            AddTranslation("[creature] will only attack if the opposing creature has more or equal health to it.", "[creature]惟对物之命不少于己，乃攻。");
            // 骨驱空袭
            AddTranslation("Take-Off (Bones)", "骨翔");
            // 消耗2根骨头，使这张卡牌直到持牌人下一个回合开始时获得空袭印记的效果。
            AddTranslation("Pay 2 bones to give this card Airborne till the start of owner's next turn.", "费二骨，使此牌至其主持次合始得翔袭。");
            // 展翅飞翔。
            AddTranslation("Spread your wings and fly.", "展翼而翔。");
            // 电驱空袭
            AddTranslation("Take-Off (Energy)", "能翔");
            // 消耗2点能量，使这张卡牌直到持牌人的下一个回合开始时获得空袭印记的效果。
            AddTranslation("Pay 2 energy to give this card Airborne till the start of the owner's next turn.", "费二能，使此牌至其主持次合始得翔袭。");
            // 惊慌失措
            AddTranslation("Terrified", "骇遁");
            // 当有卡牌移动到与[creature]相对的空间时，[creature]将远离该卡牌移动到随机相邻的空位，同时推开挡在其路上的任何造物，优先选择没有任何相对造物的槽位。
            AddTranslation("When a creature moves into the space opposing [creature], [creature] will move away from that card to a random free adjacent spot while pushing any creatures in it's way, while prioritizing slots without any opposing creatures.", "有物移至与[creature]相对之位，则[creature]避彼而移于一邻空位；道有诸物，则推之；先择无对物者。");
            // 厚重甲壳
            AddTranslation("Thick Shell", "厚甲");
            // 当[creature]被攻击时，少受1点伤害。
            AddTranslation("When attacked, [creature] takes 1 less damage.", "[creature]见攻，则所受伤少一。");
            // 那个造物身上的厚壳保护它少受1点伤害！
            AddTranslation("The thick shell on that creature protected it from one damage!", "其厚壳为之省一伤！");
            // [creature]在战斗时或在持牌人的回合开始时，将尝试从对位造物那里偷取一个随机的默认印记，直到成功为止。
            AddTranslation("[creature] will try to steal a random default sigil from a card in the opposing lane when played, or at the start of the owner's turn until it does.", "[creature]既陈，或持牌者合始，尝自其对列之一牌窃一偶常印，至得乃止。");
            // 要是能偷月亮就好了……
            AddTranslation("If only I could steal the moon...", "若得窃月则善矣……");
            // 骨后
            AddTranslation("Bone prince 3", "骨侯三");
            // 当[creature]死亡时，奖励3根骨头，而不是1根。
            AddTranslation("When [creature] dies, 3 bones are rewarded instead of 1.", "[creature]死，则赏骨三，不一。");
            // 三重骨礼
            AddTranslation("Bone hoarder 3", "藏骨三");
            // [creature]被放置时，给予持有者3块骨头。
            AddTranslation("When [creature] is played, 3 bones are rewarded.", "[creature]既陈，则其主持得三骨。");
            // 牙齿交易
            AddTranslation("Tooth Bargain", "齿约");
            // 当[creature]被召唤时，它将对对手的天平一侧造成1点伤害。当它阵亡时，它将对持牌人的天平一侧造成2点伤害。
            AddTranslation("When [creature] is played, it will put 1 point of damage of it's opponent's side of the scale. When it perishes, it will put 2 damage on the owner's side of the scale.", "[creature]既陈，则敌衡加一伤；其死，则其主衡加二伤。");
            // 我看到了和魔鬼的交易……
            AddTranslation("A deal with a devil I see...", "盖与鬼神为约也……");
            // 拔牙器
            AddTranslation("Toothpuller", "抽齿");
            // 在持牌人回合结束时，[creature]将对对手的天平造成一点伤害。
            AddTranslation("At the end of the owner's turn, [creature] will add one point of damage to the opponent's scale.", "持牌者合终，[creature]使敌衡加一伤。");
            // 那很疼。
            AddTranslation("That Hurts", "痛哉。");
            // 牙齿碎片
            AddTranslation("Tooth Shard", "齿屑");
            // [creature]被攻击时，如果它存活下来，将给予持有者一个货币。
            AddTranslation("[creature] will generate 1 foil when hit, if it lives through the attack.", "[creature]见击而不死，则生一箔。");
            // 一小块金子。
            AddTranslation("A splinter of gold.", "金之一屑。");
            // 混合毒素
            AddTranslation("Toxin", "毒");
            // 当[creature]对另一造物造成伤害时，该造物失去1点力量和1点生命。
            AddTranslation("When [creature] damages another creature, that creature looses 1 power and 1 health.", "[creature]伤他物，则彼失一威一命。");
            // 所有的东西都可以用不同的方式磨损。
            AddTranslation("All things can be worn down, and in different ways.", "物皆可磨，而其途不同。");
            // 致命毒素
            AddTranslation("Toxin (Deadly)", "死毒");
            // 当[creature]对另一造物造成伤害时，该造物获得奄奄一息印记。奄奄一息的定义是：带有此印记的卡牌将在2回合后死亡。
            AddTranslation("When [creature] damages another creature, that creature gains the Dying Sigil. The Dying Sigil is defined as: [creature] will die after 2 number of turns.", "[creature]伤他物，则彼得将死印。将死印者：历二合而死。");
            // 即使战斗结束，也会留下致命的痕迹.
            AddTranslation("Even once combat is over, it leaves a deadly mark", "战罢犹遗死痕。");
            // 残废毒素
            AddTranslation("Toxin (Sickening)", "疾毒");
            // 当[creature]伤害另一个造物时，该造物获得疾病肆虐印记。疾病肆虐被定义为：每当带有此印记的造物宣布攻击时，它们将失去一点力量。
            AddTranslation("When [creature] damages another creature, that creature gains the Sickness Sigil. The Sickness Sigil is defined as: When ever a creature bearing this sigil declares an attack, they will loose one attack.", "[creature]伤他物，则彼得疾病印。疾病印者：凡有此印之物，每宣攻失一威。");
            // 即使战斗结束，疾病也会在战斗中传播。
            AddTranslation("Even once combat is over, it leaves sickness spreads in what it fights.", "战罢犹遗其疾于所斗者。");
            // 力量毒素
            AddTranslation("Toxin (Strength)", "削威毒");
            // 当[creature]伤害另一个造物时，该造物失去1点力量。
            AddTranslation("When [creature] damages another creature, that creature looses 1 power.", "[creature]伤他物，则彼失一威。");
            // 即使战斗结束，力量也会离开它们。
            AddTranslation("Even once combat is over, strength leaves it's target", "战罢犹使其靶失威。");
            // 生命毒素
            AddTranslation("Toxin (Vigor)", "削命毒");
            // 当[creature]对另一造物造成伤害时，该造物失去1点生命值。
            AddTranslation("When [creature] damages another creature, that creature looses 1 health.", "[creature]伤他物，则彼失一命。");
            // 践踏
            AddTranslation("Trample", "蹂");
            // 当[creature]对另一卡牌造成超额伤害时，超额伤害将传给该牌的持牌人。
            AddTranslation("When [creature] deals overkill damage to a card, the overkill damage will be sent to the owner.", "[creature]溢伤及其主。");
            // 践踏永不停止。
            AddTranslation("A stampede can not be stopped.", "驰群不可止。");
            // 易形鸡（仅敌人）
            AddTranslation("Transform Chicken (Enemy Only)", "化鸡（敌惟）");
            // [creature]将在每个持牌人的回合开始时使对方场地上的一个随机造物变成鸡。鸡被定义为：1点力量，1点生命。
            AddTranslation("[creature] will transform a random creature on the board on the opponent's side into a Chicken. A Chicken is defined as 1 Attack, 1 Health.", "[creature]每持牌者合始，使敌侧一偶物化为鸡。鸡者：1威、1命。");
            // 易形鸡（全场）
            AddTranslation("Transform Chicken (Loose Cannon)", "化鸡（全场）");
            // [creature]将在每个持牌人的回合开始时使全场的一个随机造物变成鸡。鸡被定义为：1点力量，1点生命。
            AddTranslation("[creature] will transform a random creature on the board into a Chicken. A Chicken is defined as 1 Attack, 1 Health.", "[creature]每持牌者合始，使局上一偶物化为鸡。鸡者：1威、1命。");
            // 易形鸡（对位）
            AddTranslation("Transform Chicken (Opposing)", "化鸡（对位）");
            // 当一个造物与[creature]对位时，它会变成一只鸡。鸡被定义为：1点力量，1点生命。
            AddTranslation("When a creature is played opposing [creature] it will turn into a Chicken. A Chicken is defined as 1 Attack, 1 Health.", "有物陈于[creature]对位，则化为一鸡。鸡者：1威、1命。");
            // 昙花一现
            AddTranslation("Transient", "旋返");
            // 在持牌人回合结束时，[creature]将回到其手中。
            AddTranslation("At the end of the owner's turn, [creature] will return to your hand.", "持牌者合终，[creature]反归汝手。");
            // 该造物在回合结束时跑回持牌人手中。
            AddTranslation("The creature blinks back into the owner's hand at the end of their turn.", "此物合终倏返其主之手。");
            // 族群盟友
            AddTranslation("Tribal Ally", "同属友");
            // 当[creature]被召唤时，你手中将产生一张与之相同族群的卡牌。无族群的卡牌视为“无族群”族群。
            AddTranslation("When [creature] is played, A card of the same tribe is created in your hand. No tribe counts as a tribe of tribeless.", "[creature]既陈，汝手中生一与之同属之牌。无属者，以无属为属。");
            // 它需要它的亲属。
            AddTranslation("It calls for it's kin.", "呼其族矣。");
            // 族群囤积
            AddTranslation("Tribal Tutor", "同属引");
            // 当[creature]被召唤时，你可以从牌库中搜寻一张与之相同族群的卡牌并将其加入你的手牌。无族群的卡牌视为“无族群”族群。
            AddTranslation("When [creature] is played, you may search your deck for a card of the same tribe and take it into your hand. No tribe counts as a tribe of tribeless.", "[creature]既陈，汝可索牌列中与之同属之一牌，取入手。无属者，以无属为属。");
        }
    }
}
