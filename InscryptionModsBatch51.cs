using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch51
    {
        public static void RegisterTranslations()
        {
            RegisterP03SigilariumBatchThree();
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

        private static void RegisterP03SigilariumBatchThree()
        {
            // 充能樱桃炸
            AddTranslation("Explodonate When Powered", "得能殉爆");
            // 如[creature]处在回路中，则会引爆自身并对周围五个相邻位置各造成10点伤害。
            AddTranslation("If [creature] is within a circuit, it detonates itself and deals 10 damage to all five adjacent spaces.", "若[creature]在回路中，则自爆，周五邻位各受十伤。");
            // 充能金属风宝
            AddTranslation("Mental Gemnastics When Powered", "得能玉智");
            // 当使用[creature]时，若其处于回路中，持牌人可抽取等同于己方牌桌上玛珂牌数量的手牌。
            AddTranslation("When [creature] is played, if it is within a circuit, its owner draw cards equal to the number of Mox Cards on their side of the game board.", "[creature]既陈，若在回路中，则其主引牌，如其侧局上玛珂牌之数。");
            // 充能陷阱
            AddTranslation("Trap When Powered", "得能阱");
            // 如带有该印记的卡牌阵亡时处在回路中，它对面的造物也会同时阵亡。你的手牌中将出现一张容器卡牌。
            AddTranslation("When a card bearing this sigil perishes while in a circuit, the creature opposing it perishes as well. A Vessel is created in your hand.", "负此印者在回路中而死，则其对物亦死。汝手生一皿。");
            // 充能不死
            AddTranslation("Unkillable When Powered", "得能不死");
            // 如[creature]阵亡时处在回路中，则会在你的手牌中生成一张同样的牌。
            AddTranslation("If [creature] is within a circuit when it perishes, a copy of it is created in your hand.", "若[creature]死时在回路中，则汝手生其副。");
            // 接合管道
            AddTranslation("Splice Conduit", "接渠");
            // 如果[creature]构成完整回路，该回路中的所有卡牌都会向其靠拢，并在可能时与之接合。
            AddTranslation("If [creature] completes a circuit, all cards within that circuit are moved towards it, splicing with it if possible.", "若[creature]成一回路，则回路中诸牌皆向之移；可接则接。");
            // 臭臭管道
            AddTranslation("Stinky Conduit", "恶臭渠");
            // 处在由[creature]构成的回路中的卡牌将获得臭臭。
            AddTranslation("Cards within a circuit completed by [creature] have Stinky.", "在[creature]所成回路中之牌，皆得恶臭。");
            // 空袭管道
            AddTranslation("Airborne Conduit", "翔袭渠");
            // 处在由[creature]构成的回路中的卡牌获得空袭。
            AddTranslation("Cards within a circuit completed by [creature] have Airborne.", "在[creature]所成回路中之牌，皆得翔袭。");
            // 燃气管道
            AddTranslation("Gas Conduit", "燃渠");
            // 处在由[creature]构成的回路中的卡牌会获得火焰打击和过燃效果。
            AddTranslation("Cards within a circuit completed by [creature] have Fire Strike and Burnt Out.", "在[creature]所成回路中之牌，皆得火击与焚尽。");
            // 璀璨管道
            AddTranslation("Bedazzling Conduit", "炫渠");
            // 处在由[creature]构成的回路中的卡牌将被宝石化。
            AddTranslation("Cards within a circuit completed by [creature] are Gemified.", "在[creature]所成回路中之牌，皆玉化。");
            // 静电传导
            AddTranslation("Static Electricity", "静电");
            // [creature]会使所有友方卡牌表现得如同处于完整回路中。
            AddTranslation("[creature] will cause all friendly cards to behave as if they are part of a completed conduit.", "[creature]使我方诸牌皆若处于成回路中。");
            // 燃气发电机
            AddTranslation("Gas Generator", "燃机");
            // 只要燃料充足，[creature]就能让所有友方卡牌表现得如同处于完整回路中。
            AddTranslation("As long as it has fuel, [creature] will cause all friendly cards to behave as if they are part of a completed conduit.", "惟其有油，[creature]使我方诸牌皆若处于成回路中。");
            // 管道守护者
            AddTranslation("Conduit Protector", "护渠者");
            // 当[creature]处于完整回路中时，原本会作用于管道的伤害将转由该造物承担。
            AddTranslation("When [creature] is within a completed circuit, damage that would be dealt to the conduits is dealt to this creature instead.", "若[creature]在成回路中，则本加诸渠之伤，皆转加于此物。");
            // 死亡字节
            AddTranslation("Dead Byte", "死节");
            // 带有该印记的卡牌阵亡时，你会受到1点伤害。
            AddTranslation("When a card bearing this sigil perishes, take 1 damage.", "负此印者死，则汝受一伤。");
            // 双重冲刺
            AddTranslation("Double Sprinter", "再驰");
            // 持牌人回合结束时，带有该印记的卡牌会按照印记标记的方向连续移动两次。
            AddTranslation("At the end of the owner's turn, a card bearing this sigil will move in the direction inscribed in the sigil twice.", "持牌者合终，负此印者循印所志而移二。");
            // 脆骨召唤师
            AddTranslation("Brittle Summoner", "召脆");
            // 使用[creature]时，你的手牌中会随机生成一张脆骨卡牌。
            AddTranslation("When [creature] is played, a random brittle card is created in your hand.", "[creature]既陈，汝手生一偶脆骨牌。");
            // 迭代
            AddTranslation("Iterate", "迭出");
            // 使用[creature]时，你的手牌中将出现一张费用不同的复制卡牌。
            AddTranslation("When [creature] is played, a copy of it with a different cost is created in your hand.", "[creature]既陈，汝手生其副一牌，惟其费异。");
            // 机械师
            AddTranslation("Tinkerer", "机工");
            // 当使用[creature]时，随机生成三张法术牌。
            AddTranslation("When [creature] is played, create three spell cards selected at random.", "[creature]既陈，偶生三术牌。");
            // 当使用[creature]时，随机生成三张命令牌。
            AddTranslation("When [creature] is played, create three command cards selected at random.", "[creature]既陈，偶生三令牌。");
            // 相位炮就绪
            AddTranslation("Phasers Ready", "相炮备");
            // 使用[creature]时，在手牌中生成两张“电击！”牌。“电击！”具有：2点能量，是对任意目标造成1点伤害的法术牌。
            AddTranslation("When [creature] is played, create two Zap! cards in hand. Zap! is defined as a spell that costs 2 energy and deals 1 damage to any target.", "[creature]既陈，于手生二“电击！”。“电击！”者，费二能之术也，能伤所指一。");
            // 使用[creature]时，在手牌中生成两张“电击！”牌。“电击！”具有：2点能量，是对任意目标造成1点伤害的命令牌。
            AddTranslation("When [creature] is played, create two Zap! cards in hand. Zap! is defined as a command that costs 2 energy and deals 1 damage to any target.", "[creature]既陈，于手生二“电击！”。“电击！”者，费二能之令也，能伤所指一。");
            // 作战研习
            AddTranslation("Combat Research", "战研");
            // 当[creature]造成伤害时，在手牌中生成一张强制升级牌。强制升级具有：2点能量，是可使任意目标升级为新版本的法术牌。
            AddTranslation("When [creature] deals damage, create a Forced Upgrade card in hand. Forced Upgrade is defined as a spell that costs 2 energy and caused any target to upgrade to a new version.", "[creature]致伤，则于手生一“强升”。“强升”者，费二能之术也，能使所指即升为新形。");
            // 当[creature]造成伤害时，在手牌中生成一张强制升级牌。强制升级具有：2点能量，是可使任意目标升级为新版本的命令牌。
            AddTranslation("When [creature] deals damage, create a Forced Upgrade card in hand. Forced Upgrade is defined as a command that costs 2 energy and caused any target to upgrade to a new version.", "[creature]致伤，则于手生一“强升”。“强升”者，费二能之令也，能使所指即升为新形。");
            // 电力制导
            AddTranslation("Electric", "旁电");
            // 当[creature]发动攻击时，会对目标相邻的卡牌造成一半伤害。
            AddTranslation("When [creature] declares an attack, it will deal half the damage to cards adjacent to the target.", "[creature]既宣攻，则并以半伤及其所指左右。");
            // 绿色玛珂增益
            AddTranslation("Green Mox Buff", "绿玛珂益");
            // 当使用[creature]时，每打出一张绿色玛珂，该造物便获得2点生命值。
            AddTranslation("When [creature] is played, it gains two health for each Green Mox its owner controls.", "[creature]既陈，其主持每御一绿玛珂，此物命益二。");
            // 绿宝石祝福
            AddTranslation("Emerald Blessing", "绿玉福");
            // [creature]为你打出的所有造物提供+2点生命值。
            AddTranslation("[creature] provides +2 Health to all creatures you control.", "[creature]使汝所御诸物皆命益二。");
            // 绿宝石碎片
            AddTranslation("Emerald Shard", "绿玉屑");
            // 当[creature]即将受到攻击时，会在其位置生成一颗绿宝石玛珂，同时带有该印记的卡牌会向右移动。
            AddTranslation("When [creature] would be struck, an Emerald Mox is created in its place and a card bearing this sigil moves to the right.", "[creature]将受击，则其处生一绿玉玛珂，而负此印之牌右移。");
            // 坚盾予者
            AddTranslation("Armor Giver", "予铠者");
            // 当[creature]入场时，所有敌方卡牌获得纳米铠甲。
            AddTranslation("When [creature] enters, all opposing cards gain Nano Armor.", "[creature]既入，敌方诸牌皆得微铠。");
            // 能量虹吸
            AddTranslation("Energy Siphon", "吸能");
            // 当你拥有的其他卡牌在战斗中死亡时，[creature]会在你的手牌中生成一张“充能！”牌。“充能！”是使用时可恢复1点能量的法术牌。
            AddTranslation("Whenever another card you own dies in combat, [creature] creates a Charge in your hand. Charge is a spell that refills 1 Energy when played.", "凡汝他牌战死，[creature]于汝手生一“充能！”。“充能！”者，陈之则复一能之术也。");
            // 当你拥有的其他卡牌在战斗中死亡时，[creature]会在你的手牌中生成一张“充能！”牌。“充能！”是使用时可恢复1点能量的命令牌。
            AddTranslation("Whenever another card you own dies in combat, [creature] creates a Charge in your hand. Charge is a command that refills 1 Energy when played.", "凡汝他牌战死，[creature]于汝手生一“充能！”。“充能！”者，陈之则复一能之令也。");
            // 樱桃炸
            AddTranslation("Explodonate", "殉爆");
            // 当[creature]死亡时，会爆炸并对周围五个相邻位置各造成10点伤害。
            AddTranslation("When [creature] dies, it explodes and deals 10 damage to all five adjacent slots.", "[creature]死，则爆，周五邻位各受十伤。");
            // 火焰打击
            AddTranslation("Fire Strike", "火击");
            // 当[creature]攻击时，会使目标位置燃烧3回合。
            AddTranslation("When [creature] attacks, it sets the target space on fire for three turns.", "[creature]攻，则所指之位焚三合。");
            // 燃料火击
            AddTranslation("Fire Strike When Fueled", "得油火击");
            // 当[creature]攻击时若处于填充燃料状态，将消耗1点燃料使目标区域燃烧3回合。
            AddTranslation("When [creature] attacks, if it is fueled, it consumes one fuel to set the target space on fire for three turns.", "[creature]攻，若有油，则耗一油，使所指之位焚三合。");
            // 煽风点火
            AddTranslation("Flame Stoker", "鼓焰");
            // 当[creature]在场时，由你点燃的所有火焰都会更加强力，持续时间延长一回合。
            AddTranslation("While [creature] is on board, all fires you start will be stronger, causing them to last one turn longer.", "[creature]在局，则凡汝所然之火皆益炽，多延一合。");
            // 抛掷
            AddTranslation("Fling", "掷");
            // 当[creature]被使用时，若曾献祭一张或多张卡牌来使用它，[creature]将对玩家选择的一张卡牌造成等同于所有被献祭卡牌攻击力总和的伤害。
            AddTranslation("When [creature] is played, if one or more cards was sacrificed to play it, [creature] deals damage to a card of the player's choice equal to the total attack value of all sacrificed cards.", "[creature]既陈，若尝以一牌以上祀之，则对玩家所择一牌，伤如所祀诸牌威之总。");
            // 强制升级
            AddTranslation("Upgrade", "强升");
            // 当[creature]选定一个位置时，该位置上的单位会立即升级为更强版本。
            AddTranslation("When [creature] targets a slot, the target is immediately upgraded to a stronger version of itself.", "[creature]所指之位，即升为益强之形。");
            // 献血装置
            AddTranslation("Blood Donation", "输血");
            // 只要[creature]存活，所有友方卡牌，就算它们通常不可被献祭，也均可用于支付血量费用。
            AddTranslation("As long as [creature] is alive, all friendly cards can be sacrificed to pay blood costs even if they normally could not.", "惟[creature]生，我方诸牌纵素不可祀，今亦可祀以当血价。");
            // 磐石之赠
            AddTranslation("Stone Giver", "予磐");
            // 只要[creature]存活，所有友方卡牌都将获得磐石之身。
            AddTranslation("As long as [creature] is alive, all friendly cards are Made of Stone", "惟[creature]生，我方诸牌皆为磐身。");
            // 风尘之赠
            AddTranslation("Dust Giver", "予尘");
            // 只要[creature]存活，所有友方卡牌都会获得魔法粉尘。
            AddTranslation("As long as [creature] is alive, all friendly cards have Magic Dust.", "惟[creature]生，我方诸牌皆得灵尘。");
            // 煤炭滚轮
            AddTranslation("Coal Roller", "煤轮");
            // 只要[creature]存活，所有拥有燃料的友方卡牌都会获得臭臭。
            AddTranslation("As long as [creature] is alive, all friendly cards which have fuel are Stinky.", "惟[creature]生，我方有油诸牌皆得恶臭。");
            // 宝石点火器
            AddTranslation("Gem Ignition", "玉燃");
            // 只要[creature]存活，所有友方宝石获得+1点力量、火焰打击、脆骨与过燃效果。
            AddTranslation("As long as [creature] is alive, all friendly gems have +1 Power, Flame Strike, Brittle, and Burnt Out.", "惟[creature]生，我方诸玉皆威益一，兼得火击、脆骨、焚尽。");
            // 燃料打击
            AddTranslation("Fuel Strike", "油击");
            // [creature]每次攻击需消耗1点燃料，且仅在有燃料时才能攻击。
            AddTranslation("[creature] consumes one fuel to attack and can only attack if it has fuel.", "[creature]攻则耗一油；无油则不能攻。");
            // 该卡牌带有外部燃料源，可为它的一个或多个印记提供能量。当燃料耗尽时，这些印记将停止运作。
            AddTranslation("This card carries an external fuel source which powers one or more of its sigils. When a card's fuel tank empties, those sigils cease to function.", "此牌负外油之源，以行一印或数印。油既竭，则诸印皆废。");
        }
    }
}
