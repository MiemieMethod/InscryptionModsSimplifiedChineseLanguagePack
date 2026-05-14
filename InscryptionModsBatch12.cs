using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch12
    {
        public static void RegisterTranslations()
        {
            RegisterMagnificusOpening();
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

        private static void RegisterMagnificusOpening()
        {
            // 新的蔓尼菲科冒险
            AddTranslation("New Magnificus Run", "蔓尼菲科新局");
            // 新的蔓尼菲科冒险
            AddTranslation("NEW MAGNIFICUS RUN", "蔓尼菲科新局");
            // 查看牌组
            AddTranslation("View Deck", "观牌列");
            // 魔法之塔
            AddTranslation("TOWER OF MAGICKS", "术塔");
            // 黏液地牢
            AddTranslation("GOO DUNGEON", "胶狱");
            // 熔岩地牢
            AddTranslation("LAVA DUNGEON", "熔狱");
            // 虚空地牢
            AddTranslation("VOID DUNGEON", "虚狱");
            // 自动解锁蔓尼菲科凯茜模组中的所有挑战与初始牌组。这不会改变你的蔓尼菲科挑战点数。若你改变主意想公平解锁挑战，你的挑战点数将保持不变。
            AddTranslation("Automatically unlocks every challenge and starter deck in Magnificus' Kaycees Mod. This does NOT change your magnificus challenge point value. If you have a change of heart and decide to unlock the challenges fairly, your challenge points will remain the same.", "自启蔓尼菲科凯茜补缀诸角竞与初牌列；此不改汝蔓尼菲科挑战点。若回心而欲循正启之，其挑战点仍如故。");
            // 第二章的基础巫师卡牌将保持原版数值。
            AddTranslation("Base wizard cards from act 2 will keep their original statlines.", "第二章诸本巫牌，仍守原数。");
            // 使用旧版2D平面卡牌设计而非新版3D模型。
            AddTranslation("Use the old 2D flat card designs instead of the new 3D models.", "用旧二维平牌之式，毋用新三维之形。");
            // 为所有卡牌背景添加颜料飞溅效果（如同原版蔓尼菲科终局）。
            AddTranslation("Add paint splashes to the background of every card (like in the original magnificus finale).", "诸牌之背皆加泼丹，如原本蔓尼菲科终局然。");
            // 启用蔓尼菲科游戏的第三人称视角。若需经典第一人称体验请关闭此选项。
            AddTranslation("Third person perspective for magnificus' game. Disable if you want the classic first person experience.", "蔓尼菲科之戏用第三人称之视；欲守旧式第一人称者，可闭此项。");
            // 在桌面模式下显示玩家周围的网格。
            AddTranslation("Show a grid around the player in tabletop mode.", "桌案之式，示戏徒四周之格。");
            // 空白玛珂
            AddTranslation("Blank Mox", "虚玛珂");
            // 抽到[creature]时，它会实体化为随机一种玛珂水晶。\n当该印记存在于其他卡牌上时，该卡牌会生成随机一种玛珂水晶。
            AddTranslation("When a card bearing this sigil is drawn, it will materialize into a random Mox Crystal. \n When on another card, the card will generate a random Mox Crystal.", "负此印契之牌既引，则化为一偶玛珂晶。\n若此印在他牌，则彼牌生一偶玛珂晶。");
            // 无形玛珂
            AddTranslation("Undecided Mox", "未定玛珂");
            // 当[creature]打出时，选择一种玛珂类型供其提供。
            AddTranslation("When a card bearing this sigil is played, select a mox type for this card to provide.", "负此印契之牌既陈，择一玛珂之类以供之。");
            // 红宝石之心
            AddTranslation("Ruby Heart", "红玉心");
            // [creature]阵亡时，会在原地生成一张红宝石玛珂。
            AddTranslation("When a card bearing this sigil perishes, it creates a Ruby Mox in its place.", "负此印契之牌死，则其处生一红玉玛珂。");
            // 蓝宝石之心
            AddTranslation("Sapphire Heart", "蓝玉心");
            // [creature]阵亡时，会在原地生成一个蓝宝石玛珂。
            AddTranslation("When a card bearing this sigil perishes, it creates a Sapphire Mox in its place.", "负此印契之牌死，则其处生一蓝玉玛珂。");
            // 骨髓
            AddTranslation("Bone Marrow", "骨髓");
            // 当你的非宝石卡牌阵亡时，[creature]获得1点力量，最高可叠加至5点。
            AddTranslation("When one of your non-gem cards perishes, a card bearing this sigil gains 1 power, maxing out at 5.", "汝一非玉牌死，则负此印契之牌威加一，至五而止。");
            // 刺激
            AddTranslation("Stimulation", "激威");
            // 每回合结束时，[creature]增加1点力量，最高不超过4点。
            AddTranslation("At the end of every turn, a card bearing this sigil gains 1 power, maxing out at 4.", "每合终，负此印契之牌威加一，至四而止。");
            // 刺激（生命）
            AddTranslation("Stimulation (Health)", "激命");
            // 每回合结束时，[creature]获得2点生命值，上限为10点。
            AddTranslation("At the end of every turn, a card bearing this sigil gains 2 health, maxes out at 10.", "每合终，负此印契之牌命加二，至十而止。");
            // 死亡掠夺
            AddTranslation("Dead Draw", "死引");
            // 当非宝石卡牌阵亡时，从牌组中抽取一张卡牌。
            AddTranslation("When a non-gem card dies, draw a card from your deck.", "非玉牌一死，则自牌列引一牌。");
            // 绿宝石之心
            AddTranslation("Emerald Heart", "绿玉心");
            // [creature]阵亡时，会在原地生成一张绿宝石玛珂。
            AddTranslation("When a card bearing this sigil perishes, it creates an Emerald Mox in its place.", "负此印契之牌死，则其处生一绿玉玛珂。");
            // 黏液
            AddTranslation("Gooey", "胶");
            // [creature]受到攻击时，攻击者失去1点力量。
            AddTranslation("When a card bearing this sigil is struck, the striker loses 1 attack.", "负此印契之牌受击，则攻者失一威。");
            // 头脑风宝
            AddTranslation("Mental Gemnastics", "玉智");
            // 当使用[creature]时，根据牌桌上宝石数量从牌组抽取相应数量的卡牌。
            AddTranslation("When a card bearing this sigil is played, draw cards from your deck based on how many Gems are on the board.", "负此印契之牌既陈，则视局上诸玉之数而引牌。");
            // 劫掠者
            AddTranslation("Loot", "掠者");
            // 当[creature]造成直接伤害时，根据造成的伤害数值从牌组抽取相应数量的牌。
            AddTranslation("When a card bearing this sigil deals direct damage, draw cards from your deck based on how much damage was dealt.", "负此印契之牌直伤之时，每伤一，则引一牌。");
            // 生命窃取
            AddTranslation("Life Steal", "夺生");
            // 当[creature]造成直接伤害时，伤害值将转化为持牌人的生命恢复。
            AddTranslation("When a card bearing this sigil deals direct damage, the amount dealt will be healed to the owner of this card.", "负此印契之牌直伤之时，所伤若干，则持牌者疗若干。");
            // 驱时之触
            AddTranslation("Knockback Hit", "却击");
            // [creature]击中对手卡牌时，会将对手卡牌朝印记所示方向击退。
            AddTranslation("When a card bearing this sigil hits an opposing card, the opposing card will be kicked in the direction inscrybed in the sigil.", "负此印契之牌击对牌，则彼牌循印所志而却。");
            // 长矛召唤
            AddTranslation("Impaled", "贯矛");
            // [creature]阵亡时，会在其位置生成一柄长矛。长矛具有：0点力量，3点生命，尖刺铠甲。
            AddTranslation("When a card bearing this sigil perishes, it creates a Spear in its placed. A spear is defined as Sharp, 0 power, 3 health.", "负此印契之牌死，则其处生一矛。矛者：0威、3命、利棘。");
            // 至尊玛珂
            AddTranslation("Magnus Mox", "至尊玛珂");
            // 当牌桌上有[creature]时，可为持牌人提供橙、蓝、绿三色玛珂各一颗。
            AddTranslation("While a card bearing this sigil is on the board, it provides an orange gem, a blue gem and a green gem to its owner.", "负此印契之牌在局，则为持牌者供橙玉、蓝玉、绿玉各一。");
            // 复活苏生
            AddTranslation("Resurrection", "苏生");
            // 当非宝石卡阵亡时，这张死亡的卡牌会复活，但此卡失去3点生命值。
            AddTranslation("When a non-gem card perishes, the dead card will be brought back to life, but this card loses 3 health.", "非玉牌一死，则复生之；然此牌失三命。");
            // 骰子力量
            AddTranslation("Rerolls", "重掷");
            // 每回合结束时，[creature]基础力量会变成0至3的随机数。
            AddTranslation("At the end of every turn, a card bearing this sigils' base power will be increased by a random value between 0 and 3.", "每合终，负此印契之牌之本威偶加零至三。");
            // 铁兽夹
            AddTranslation("Steel Trap", "铁阱");
            // [creature]阵亡时，对面的卡牌也会同时阵亡。
            AddTranslation("When a card bearing this sigil perishes, the opposing card also perishes.", "负此印契之牌死，则其对牌亦死。");
            // 宝石护盾
            AddTranslation("Gem Shield", "玉盾");
            // 使用[creature]时，牌桌上所有宝石均获得护盾。
            AddTranslation("When a card bearing this sigil is played, all gems on the board gain a shield.", "负此印契之牌既陈，局上诸玉皆得坚盾。");
            // 镀层工艺
            AddTranslation("Plating Work", "镀工");
            // 当[creature]在场时，持牌人侧牌桌上所有宝石获得尖刺铠甲印记和2点生命值。
            AddTranslation("While a card bearing this sigil is on the board, all gems on your side of the board gain the Sharp Quills sigil, and 2 health.", "负此印契之牌在局，则持牌者之侧局上诸玉皆得利棘印契，并二命。");
            // 操偶师
            AddTranslation("Animator", "操傀者");
            // 当[creature]在场时，所有力量为0的非玛珂卡牌获得2点力量。
            AddTranslation("While a card bearing this sigil is on the board, all non-mox cards with 0 power gain 2 power", "负此印契之牌在局，则凡非玛珂而威为零之牌，皆得二威。");
            // 宝石吸收者
            AddTranslation("Gem Absorber", "吸玉者");
            // 当[creature]使用时，持牌人侧牌桌上的所有宝石将被摧毁。每吸收一个宝石，获得1点力量和2点生命。
            AddTranslation("When a card bearing this sigil is played, all gems on your side of the board will perish. For each gem absorbed, gain 1 power and 2 health.", "负此印契之牌既陈，则持牌者之侧局上诸玉尽死。每吸一玉，威加一，命加二。");
            // 下潜
            AddTranslation("Submerge", "潜没");
            // 回合结束时，[creature]会潜入水下。重新上浮时，该卡牌会变为随机触手卡牌。
            AddTranslation("At the end of the turn, a card bearing this sigil will submerge. Upon resubmerging, this card will become a random Tentacle Card.", "合终，负此印契之牌将潜；及复出时，化为一偶触手牌。");
            // 使魔
            AddTranslation("Familiar", "使魔");
            // 若牌桌上没有非宝石卡牌，[creature]将会阵亡。
            AddTranslation("A card bearing this sigil will perish if there are no non-gem cards on the board.", "若局上无非玉牌，则负此印契之牌死。");
            // 消逝
            AddTranslation("Fading", "消逝");
            // [creature]会在回合结束时消亡。
            AddTranslation("A card bearing this sigil will perish at the end of the turn.", "负此印契之牌合终而死。");
            // 不定变体
            AddTranslation("Morph", "化形");
            // 当[creature]被使用时，会复制对面位置的卡牌。若对面无卡牌，则该卡牌会阵亡。
            AddTranslation("When a card bearing this sigil is played, it will mimic the card opposing it. If there is no card opposing it, this card will perish.", "负此印契之牌既陈，则效其对牌；若无对牌，则死。");
            // 矩阵乘法
            AddTranslation("Multiplication", "倍生");
            // 使用[creature]时，抽一张同名卡牌，但其宝石需求会发生变化。
            AddTranslation("When a card bearing this sigil is played, draw another of this card, but with a different gem cost.", "负此印契之牌既陈，复引一同牌，惟其玉直异焉。");
            // 玛珂循环
            AddTranslation("Mox Cycle", "玛珂轮转");
            // 每回合结束时，牌桌上所有玛珂牌会循环转换为其他宝石类型。
            AddTranslation("At the end of every turn, all the mox on the board will cycle into different gems.", "每合终，局上诸玛珂皆轮易为他玉。");
            // 玛珂掉落
            AddTranslation("Mox Strafe", "遗以玛珂");
            // 回合结束时，此卡牌会按照印记标记的方向突进，并在原地留下一颗随机玛珂。
            AddTranslation("At the end of the turn, this card will move to the direction inscrybed on the sigil, and leave behind a mox.", "合终，此牌循印所志之向而移，并遗一玛珂于故处。");
            // 纯粹主义
            AddTranslation("Purist", "粹者");
            // 任何直接与该卡牌对位的卡牌将失去所有印记。
            AddTranslation("Any card directly opposing this one will have all it's sigils removed.", "凡与此牌直对者，尽去其印契。");
            // 酿造坊
            AddTranslation("Brewery", "酿坊");
            // 每回合结束时，自动从副牌组抽取一张玛珂牌。
            AddTranslation("At the end of every turn, you automatically draw a mox card from your side deck.", "每合终，自副牌列引一玛珂牌。");
            // 引火
            AddTranslation("Ignite", "引焰");
            // 当[creature]被使用时，所有对侧空位将被火焰填满。火焰具有：0点力量，1点生命值，惹人生厌。
            AddTranslation("When a card bearing this sigil is played, every empty opposing slot will be filled with flames. A flame is defined as a 0/1, Annoying.", "负此印契之牌既陈，则诸对位之空处皆满以焰。焰者：0威、1命、可厌。");
            // 星空投影
            AddTranslation("Projection", "星影");
            // [creature]受击时会移动，并留下自身的星体投影。
            AddTranslation("When a card bearing this sigil is stuck, it will move and leave behind an astral projection of itself.", "负此印契之牌受击，则移，而遗其星影。");
            // 法术大全
            AddTranslation("Spell Book", "咒书");
            // [creature]打出时，随机抽取一张法术牌。
            AddTranslation("When a card bearing this sigil is played, draw a random spell card.", "负此印契之牌既陈，偶引一咒牌。");
            // 法术学者
            AddTranslation("Scholar", "儒");
            // [creature]打出时，随机抽取一本蓝绿橙大师的书。
            AddTranslation("When a card bearing this sigil is played, draw a random one of Bleene's Books.", "负此印契之牌既陈，偶引蓝绿大师之一书。");
            // 黄金之触
            AddTranslation("Midas' Touch", "金触");
            // [creature]攻击其他卡牌时，被攻击的卡牌将失去所有力量并转化为黄金。
            AddTranslation("When a card bearing this sigil attacks another card, the attacked card will lose all of it's attack and turn to gold.", "负此印契之牌攻他牌，则受攻者尽失其威，而化金。");
            // 黄金之躯
            AddTranslation("Made of Gold", "金身");
            // [creature]阵亡时，击杀者将获得2颗水晶。
            AddTranslation("When a card bearing this sigil perishes, the killer will gain 2 crystals.", "负此印契之牌死，则杀者得二水晶。");
            // 引爆召唤
            AddTranslation("Summon Runes", "召符");
            // 当[creature]被使用时，会在其相邻位置召唤两个魔法炸弹符文。符文具有：0点力量、1点生命，引爆器。
            AddTranslation("When a card bearing this sigil is played, it will summon two runes beside it. A rune is defined as 0 power, 1 health, Detonator.", "负此印契之牌既陈，则两旁各生一符。符者：0威、1命、引爆。");
            // 生命法术
            AddTranslation("Spell of Health", "命咒");
            // 当带有该印记的法术牌被使用时，持牌人侧牌桌上所有卡牌获得+2生命值。
            AddTranslation("When a spell bearing this sigil is played, all cards on your side of the board gain +2 health.", "负此印契之咒既陈，汝侧诸牌命加二。");
            // 攻击法术
            AddTranslation("Spell of Attack", "威咒");
            // 当带有该印记的法术被使用时，持牌人侧牌桌上所有卡牌获得+1攻击力。
            AddTranslation("When a spell bearing this sigil is played, all cards on your side of the board gain +1 attack.", "负此印契之咒既陈，汝侧诸牌威加一。");
            // 寒霜咒
            AddTranslation("Frost Spell", "霜咒");
            // 当使用带有该印记的法术牌时，对手所有卡牌的攻击力将归零，但生命值+2。
            AddTranslation("When a spell bearing this sigil is played, all cards belonging to the opponent will have their attack set to 0, but given +2 health.", "负此印契之咒既陈，敌方诸牌威归零，而命加二。");
            // 强风咒
            AddTranslation("Spell of Wind", "风咒");
            // 当使用带有该印记的法术时，持牌人侧牌桌上的所有卡牌将获得空袭能力。
            AddTranslation("When a spell bearing this sigil is played, all cards on your side of the board will become airborne.", "负此印契之咒既陈，汝侧诸牌皆得翔袭。");
            // 时针顺碎语
            AddTranslation("Ruckus", "乱移");
            // 当[creature]被使用时，牌桌上所有卡牌均会按顺时针方向移动。
            AddTranslation("When a card bearing this sigil is played, all cards on the board will move clockwise.", "负此印契之牌既陈，局上诸牌皆顺时步一格。");
            // 净水咒
            AddTranslation("Spell of Water", "水咒");
            // 当带有该印记的咒语牌被使用时，牌桌上所有卡牌的印记将被清除。
            AddTranslation("When a spell bearing this sigil is played, every card on the board will have their sigils erased.", "负此印契之咒既陈，局上诸牌之印契尽除。");
            // 火焰咒
            AddTranslation("Spell of Flame", "焰咒");
            // 选择牌桌一侧，该侧所有卡牌生命值减少2点（但不会阵亡）且攻击力增加1点。
            AddTranslation("Select a side of the board, every card on that side will lose 2 health (without perishing) and have their attack increased by 1.", "择局一侧，其侧诸牌命减二而不死，威加一。");
            // 点燃
            AddTranslation("Set Ablaze", "燎");
        }
    }
}
