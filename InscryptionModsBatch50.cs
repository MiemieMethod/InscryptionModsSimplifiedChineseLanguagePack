using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch50
    {
        public static void RegisterTranslations()
        {
            RegisterP03SigilariumBatchTwo();
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

        private static void RegisterP03SigilariumBatchTwo()
        {
            // 附录12，第一节 - 额外机制{0}
            AddTranslation("APPENDIX XII, SUBSECTION I - Additional Mechanics {0}", "附录十二·第一节——别机{0}");
            // 坚盾吸收
            AddTranslation("Shield Absorption", "吸盾");
            // 当[creature]被使用时，所有造物都会失去护盾。每失去一个护盾，该造物便增加1点攻击力。
            AddTranslation("When [creature] is played, all creatures lose their shields. This creature gains 1 attack for each shield lost this way.", "[creature]既陈，诸物失其盾；每由此失一盾，此物威益一。");
            // 极速回收
            AddTranslation("Rapid Recycle", "疾回用");
            // 消耗1点能量选择你控制的另一张卡牌死亡并立即重生。每回合只能激活此能力一次。
            AddTranslation("Pay 1 Energy to choose another card you control to die and immediately respawn. You may only activate this ability once per turn.", "费一能，使汝所御别一牌死而即复生。此技每合惟一启。");
            // 超载充能
            AddTranslation("Supercharge", "亢充");
            // 消耗1点燃料：友方卡牌获得1点力量，持续至回合结束。该能力每回合只能激活一次。
            AddTranslation("Spend one fuel: friendly cards gain 1 power until the end of the turn. This ability can only be activated once per turn.", "费一油：友牌皆威益一，至合终。此技每合惟一启。");
            // 复制粘贴
            AddTranslation("Copy and Paste", "摹移");
            // [creature]的持牌人需选择其控制的两张卡牌，将第二张卡的印记替换为第一张卡的印记。
            AddTranslation("The controller of [creature] chooses two cards they control. The second card's sigils are replaced with the sigils of the first.", "[creature]之主持择其所御二牌。以后者之印，易为前者之印。");
            // 选择要复制印记的卡牌
            AddTranslation("Choose a card to copy sigils from", "择一牌以摹其印");
            // 选择要粘贴印记的卡牌
            AddTranslation("Choose a card to paste sigils onto", "择一牌以受其印");
            // 炮火轰击
            AddTranslation("Cannon Fire", "炮击");
            // 消耗1点燃料：在手牌中生成一张“轰爆！”牌。“轰爆！”具有：2点能量，是可以使目标着火的法术牌。该能力每回合只能激活一次。
            AddTranslation("Spend one fuel: Create a Blast! card in hand. Blast! is defined as a spell that costs 2 energy and sets the target on fire. This ability can only be activated once per turn.", "费一油，于手生一“轰爆！”。“轰爆！”者，费二能之术也，能然所指。此技每合惟一启。");
            // 消耗1点燃料：在手牌中生成一张“轰爆！”牌。“轰爆！”具有：2点能量，是可以使目标着火的命令牌。该能力每回合只能激活一次。
            AddTranslation("Spend one fuel: Create a Blast! card in hand. Blast! is defined as a command that costs 2 energy and sets the target on fire. This ability can only be activated once per turn.", "费一油，于手生一“轰爆！”。“轰爆！”者，费二能之令也，能然所指。此技每合惟一启。");
            // 充能储备
            AddTranslation("Recharge Reserves", "储充");
            // 消耗2点能量在手牌中生成一张“充能！”牌。“充能！”是使用时可恢复1点能量的法术牌。
            AddTranslation("Pay 2 Energy to create a Charge in your hand. Charge is defined as a spell that refills 1 Energy when played.", "费二能，于手生一“充能！”。“充能！”者，陈之则复一能之术也。");
            // 消耗2点能量在手牌中生成一张“充能！”牌。“充能！”是使用时可恢复1点能量的命令牌。
            AddTranslation("Pay 2 Energy to create a Charge in your hand. Charge is defined as a command that refills 1 Energy when played.", "费二能，于手生一“充能！”。“充能！”者，陈之则复一能之令也。");
            // 全息编织者
            AddTranslation("Holo Weaver", "幻织");
            // 每回合可在手牌中生成一张“防御！”牌。“防御！”具有：2点能量，是能为目标提供护盾的法术牌。
            AddTranslation("Once per turn, create a Defend! card in hand. Defend! is defined as a spell that costs 2 energy and gives the target a shield.", "每合一度，于手生一“防御！”。“防御！”者，费二能之术也，予所指以微铠。");
            // 每回合可在手牌中生成一张“防御！”牌。“防御！”具有：2点能量，是能为目标提供护盾的命令牌。
            AddTranslation("Once per turn, create a Defend! card in hand. Defend! is defined as a command that costs 2 energy and gives the target a shield.", "每合一度，于手生一“防御！”。“防御！”者，费二能之令也，予所指以微铠。");
            // 未来视界
            AddTranslation("Future Sight", "先见");
            // 查看牌组顶端的卡牌。你可以直接使用它。
            AddTranslation("Look at the top card of your deck. You can play it.", "视牌列上牌。汝可即陈之。");
            // 化石燃料
            AddTranslation("Fossil Fuel", "石脂");
            // 可提供1点额外能量槽。
            AddTranslation("Provides an additional energy cell.", "益一能格。");
            // 售货机
            AddTranslation("Dispenser", "予器");
            // 获得一个随机道具。
            AddTranslation("Gain a random item.", "得一偶物。");
            // 电能过载
            AddTranslation("Overcharge", "过充");
            // 消耗4点能量使该卡牌的力量+1。
            AddTranslation("Pay 4 Energy to increase the Power of this card by 1.", "费四能，益此牌威一。");
            // 超频领袖
            AddTranslation("Enrage", "怒充");
            // 消耗等同于该卡牌力量值加2点的能量，使该卡牌的力量值增加1点。
            AddTranslation("Pay Energy equal to the Power of this card plus 2 to increase the Power of this card by 1.", "费能如是牌之威加二，以益其威一。");
            // 驱动
            AddTranslation("Drive", "驱");
            // 消耗1点燃料：向该印记标注的方向移动。该能力每回合只能发动一次。
            AddTranslation("Spend one fuel: move in the direction inscribed in this sigil. This ability can only be activated once per turn.", "费一油：循此印所志而移。此技每合惟一启。");
            // 十字键
            AddTranslation("D-Pad", "十键");
            // 移动至相邻的空位
            AddTranslation("Move to an adjacent empty lane.", "移于邻虚列。");
            // 十字键左进
            AddTranslation("D-Pad Left", "左键");
            // 若左侧路线为空，则移动至该位置。
            AddTranslation("Move to the lane to the left, if it is empty.", "左列若虚，则移于彼。");
            // 十字键右进
            AddTranslation("D-Pad Right", "右键");
            // 若右侧路线为空，则移动至该位置。
            AddTranslation("Move to the lane to the right, if it is empty.", "右列若虚，则移于彼。");
            // 下潜
            AddTranslation("Submerge", "潜");
            // 消耗1点燃料：在对手回合期间潜入水下。潜水时，敌方造物将直接攻击其持有者。
            AddTranslation("Spend one fuel: submerge during the opponent's turn. While submerged, opposing creatures attack its owner directly.", "费一油：敌合则潜。既潜，则敌物直攻其主。");
            // 拖拽钩
            AddTranslation("Tow Hook", "牵钩");
            // 消耗1点燃料：将对方一个造物拖曳至你这一侧牌桌，持续到回合结束。被拖曳的造物无法被锤击。该能力每回合只能激活一次。
            AddTranslation("Spend one fuel: tow an opposing creature to your side of the board until end of turn. Creatures being towed cannot be hammered. This ability can only be activated once per turn.", "费一油：牵一敌物至汝侧，至合终。见牵者不得受槌。此技每合惟一启。");
            // 按键狂魔
            AddTranslation("Button Pusher", "叩键者");
            // 当使用[creature]时，所有可激活印记以及登场或死亡时触发的印记都会立即激活。
            AddTranslation("When [creature] is played, all activated sigils and sigils that trigger on play or on death are activated.", "[creature]既陈，凡可启之印，与陈时、死时而发之印，皆启。");
            // 寄生控制
            AddTranslation("Parasitic Control", "寄御");
            // 当使用[creature]时，所有对手卡牌都将转移至你这一侧的牌桌。
            AddTranslation("When [creature] is played, all opposing cards are moved to your side of the board.", "[creature]既陈，敌方诸牌皆移于汝侧。");
            // 能量力量
            AddTranslation("Energy Power", "能威");
            // 该印记代表的数值等于玩家本回合消耗能量的次数。
            AddTranslation("The value represented with this sigil will be equal to the number of times the player has spent energy this turn.", "此印所表之数，与玩家此合费能之次数等。");
            // 全息陷阱
            AddTranslation("Holo Trap", "幻阱");
            // 带有该印记的卡牌阵亡时，它对面的造物也会同时阵亡。你的手牌中将出现一张容器卡牌。
            AddTranslation("When a card bearing this sigil perishes, the creature opposing it perishes as well. A Vessel is created in your hand.", "负此印者死，则其对物亦死。汝手生一皿。");
            // 脆骨王
            AddTranslation("Brittle Lord", "脆主");
            // 只要[creature]存活，带有脆骨印记的卡牌都将获得不死之虫。
            AddTranslation("As long as [creature] is alive, cards with Brittle have Unkillable.", "惟[creature]生，凡有脆骨者皆得不死。");
            // 狂野冲撞
            AddTranslation("Buck Wild", "狂突");
            // 受到伤害时，此卡牌会冲入对面空位，沿途消灭一切阻挡之物。
            AddTranslation("Upon taking damage, this card will charge into the opposing slot, killing anything in its way.", "受伤则此牌突入其对位，所当者皆死。");
            // 燃烧卡槽(1)
            AddTranslation("Burning Slot (1)", "燔位（一）");
            // 这个卡槽着火了！它会在回合结束时对其中卡牌造成1点伤害。该效果持续1回合。
            AddTranslation("This slot is on fire! It deals one damage to the card in it at the end of the turn. This effect lasts one turn.", "此位焚矣！合终，处其中者受一伤。此效一合而止。");
            // 燃烧卡槽(2)
            AddTranslation("Burning Slot (2)", "燔位（二）");
            // 这个卡槽着火了！它会在回合结束时对其中卡牌造成1点伤害。该效果持续2回合。
            AddTranslation("This slot is on fire! It deals one damage to the card in it at the end of the turn. This effect lasts two turns.", "此位焚矣！合终，处其中者受一伤。此效二合而止。");
            // 燃烧卡槽(3)
            AddTranslation("Burning Slot (3)", "燔位（三）");
            // 这个卡槽着火了！它会在回合结束时对其中卡牌造成1点伤害。该效果持续3回合。
            AddTranslation("This slot is on fire! It deals one damage to the card in it at the end of the turn. This effect lasts three turns.", "此位焚矣！合终，处其中者受一伤。此效三合而止。");
            // 燃烧卡槽(4)
            AddTranslation("Burning Slot (4)", "燔位（四）");
            // 这个卡槽着火了！它会在回合结束时对其中卡牌造成1点伤害。该效果持续4回合。
            AddTranslation("This slot is on fire! It deals one damage to the card in it at the end of the turn. This effect lasts four turns.", "此位焚矣！合终，处其中者受一伤。此效四合而止。");
            // 过燃
            AddTranslation("Burnt Out", "焚尽");
            // 当[creature]死亡时，其所在位置将燃烧3回合。
            AddTranslation("When [creature] dies, it sets the land on fire for three turns.", "[creature]死，则其地焚三合。");
            // 燃烧中
            AddTranslation("on fire", "方焚");
            // 引燃
            AddTranslation("Catch Fire", "然火");
            // 当[creature]选定一个位置时，该位置将被引燃。
            AddTranslation("When [creature] targets a slot, the target is set on fire.", "[creature]所指之位皆焚。");
            // 失能退化
            AddTranslation("Transforms When Unpowered", "失能易形");
            // 若回合开始时[creature]未处于回路中，则会退化回原始形态。
            AddTranslation("If [creature] is NOT within a circuit at the beginning of the turn, it will transform back into its original form.", "合始，若[creature]不在回路中，则反其故形。");
            // 失能水袭
            AddTranslation("Waterborne When Unpowered", "失能潜袭");
            // 若[creature]不在回路中，则会在对手回合潜入水下。潜水时，敌方造物将直接攻击其持牌人。
            AddTranslation("If [creature] is NOT within a circuit it submerges itself during its opponent's turn. While submerged, opposing creatures attack its owner directly.", "若[creature]不在回路中，则敌合自潜；既潜，则敌物直攻其主。");
            // 充能短路
            AddTranslation("Short Circuit", "短路");
            // 若[creature]在回合开始时处于回路中，则会在你的手牌中生成一张“电击！”牌。“电击！”具有：2点能量，是可对任意目标造成1点伤害的法术牌。
            AddTranslation("If [creature] is within a circuit at the beginning of the turn, create a Zap! in your hand. Zap! is defined as a spell that costs 2 energy and deals 1 damage to any target.", "合始，若[creature]在回路中，则于手生一“电击！”。“电击！”者，费二能之术也，能伤所指一。");
            // 若[creature]在回合开始时处于回路中，则会在你的手牌中生成一张“电击！”牌。“电击！”具有：2点能量，是可对任意目标造成1点伤害的命令牌。
            AddTranslation("If [creature] is within a circuit at the beginning of the turn, create a Zap! in your hand. Zap! is defined as a command that costs 2 energy and deals 1 damage to any target.", "合始，若[creature]在回路中，则于手生一“电击！”。“电击！”者，费二能之令也，能伤所指一。");
            // 充能进化
            AddTranslation("Transforms When Powered", "得能易形");
            // 如[creature]在回合开始时处于回路中，则会进化为更强形态。
            AddTranslation("If [creature] is within a circuit at the beginning of the turn, it will transform into a stronger form.", "合始，若[creature]在回路中，则易为益强之形。");
        }
    }
}
