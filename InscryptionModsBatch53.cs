using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch53
    {
        public static void RegisterTranslations()
        {
            RegisterP03SigilariumBatchFive();
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

        private static void RegisterP03SigilariumBatchFive()
        {
            // 加油站
            AddTranslation("Refueler", "补油者");
            // 只要燃料充足，[creature]会主动靠近你打出的其他需燃料造物。每回合为相邻造物补充燃料。
            AddTranslation("As long as it has fuel, [creature] will attempt to move beside any creatures you play that also use fuel. Each turn, [creature] will refuel adjacent creatures.", "惟其有油，[creature]将趋汝所陈他有油之物旁。每合为邻物补油。");
            // 死灰复燃
            AddTranslation("Second Chance", "再起");
            // 当友方非脆骨造物死亡时，若[creature]在战场上，将在其位置生成一个1/1的骷髅。
            AddTranslation("Whenever a friendly non-Brittle creature dies, if [creature] is on the battlefield, a 1/1 skeleton will be created in its place.", "凡我方非脆骨之物死，若[creature]在场，则其处生一一一枯骨。");
            // 额外能量管道
            AddTranslation("Bonus Energy Conduit", "余能渠");
            // 如果[creature]参与构成一条完整回路，那么它会提供一个等同于玩家当前最大能量值的能量储备。
            AddTranslation("If [creature] is part of a completed circuit, it provides a reserve of energy equal to the player's current maximum energy.", "若[creature]在成回路中，则所供之余能，如玩家今之能极。");
            // 外骨骼超频
            AddTranslation("Skeleclocked", "骨机化");
            // 当[creature]死亡时，它会永久变为具有相同能力的机械外骨骼。若[creature]带有不死之虫则不受影响。
            AddTranslation("When [creature] dies, it permanently becomes an Exeskeleton with the same abilities. If [creature] has Unkillable, it will be unaffected.", "[creature]死，则永久化为一外骨骼，而其诸技如故。若[creature]有不死，则不与。");
            // 过热
            AddTranslation("Overheat", "亢热");
            // 当战局对你有利时，[creature]损失1点力量。当战局不利时，[creature]获得1点力量。
            AddTranslation("When the scales are in your favor, [creature] loses 1 power. When the scales aren't in your favor, [creature] gains 1 power.", "衡若利汝，[creature]威损一；不利，则威益一。");
            // 能量流失
            AddTranslation("Power Drain", "耗能");
            // [creature]每回合会消耗其持牌人所有的可用能量。
            AddTranslation("[creature] consumes all of its owner's available energy each turn.", "[creature]每合尽耗其主持可用之能。");
            // 纯粹主义
            AddTranslation("Purist", "粹者");
            // 与[creature]对位的卡牌将失去所有印记。
            AddTranslation("Cards opposing [creature] have their sigils removed.", "与[creature]对之牌，失诸印。");
            // 该效果会实际移除能力。你本不该在卡牌上看到这个能力！！！
            AddTranslation("This handles actually removing abilities. You should never see this ability on a card!!!", "此者实用于去诸技。汝本不当于牌上见之！！！");
            // 赏金猎人
            AddTranslation("Bounty Hunter", "购捕者");
            // 当被抽到时，[creature]会随机变成一名赏金猎人。
            AddTranslation("When drawn, [creature] will turn into a random bounty hunter.", "既引，[creature]随机化为一购捕者。");
            // 来Nerf这招！
            AddTranslation("Nerf This!", "削此！");
            // 当[creature]被抽到时，会随机获得一个负面印记。
            AddTranslation("When [creature] is drawn, it gains a randomly selected negative ability.", "既引，[creature]得一偶负印。");
            // 无形神物
            AddTranslation("Apotheosis", "登神");
            // 当[creature]被抽到时，会随机获得一项稀有能力。
            AddTranslation("When [creature] is drawn, it gains a randomly selected rare ability.", "既引，[creature]得一偶稀技。");
            // 蓄势
            AddTranslation("Recharge", "复能");
            // 当使用[creature]时，将恢复1点能量（不超过玩家能量上限）。
            AddTranslation("When [creature] is played, one energy will be refilled (up to the player's maximum energy)", "[creature]既陈，复一能（至玩家之能极）。");
            // 闹钟机器人
            AddTranslation("Alarm Clock", "报时机");
            // 该印记当前指向的造物将获得+1点力量。闹钟会在玩家回合开始时旋转方向。
            AddTranslation("The creature that this sigil is pointing to will gain +1 attack. The clock will turn at the beginning of the player's turn.", "此印所指之物威益一。玩家合始，此钟自转。");
            // 红宝石祝福
            AddTranslation("Ruby Blessing", "红玉福");
            // [creature]为你打出的所有造物提供+1力量。
            AddTranslation("[creature] provides +1 Attack to all creatures you control.", "[creature]使汝所御诸物皆威益一。");
            // 橙色玛珂战士
            AddTranslation("Orange Mox Warrior", "橙玛珂武者");
            // 当使用[creature]时，它会攻击所有与持牌人打出的橙玛珂提供者相对的敌方卡牌。
            AddTranslation("When [creature] is played, it attacks all enemy cards opposite Orange Mox providers its owner controls.", "[creature]既陈，则攻诸与其主持所御橙玛珂供者相对之敌牌。");
            // 轰然炸裂
            AddTranslation("Burst", "爆");
            // 为召唤[creature]而献祭的卡牌会爆炸，对每张相邻卡牌造成10点伤害。
            AddTranslation("Cards sacrificed to pay for [creature] explode, dealing 10 damage to each adjacent card.", "为陈[creature]所祀之牌皆爆，各伤邻牌十。");
            // 宝石吞噬者
            AddTranslation("Gem Consumer", "噬玉者");
            // 使用[creature]时，持牌人侧牌桌上所有宝石容器均会被献祭。
            AddTranslation("When [creature] is played, all gem vessels on its owner's side of the board are sacrificed.", "[creature]既陈，其主持之侧局上诸玉皿皆见祀。");
            // 奔涌传花
            AddTranslation("Emergence Latch", "涌遗契");
            // 当为[creature]献祭的卡牌死亡时，其持牌人需选定一张卡牌继承它们的首个印记。
            AddTranslation("When cards sacrificed to pay for [creature] die, their owner chooses a card to gain their first sigil.", "为陈[creature]而祀之牌既死，则其主持择一牌，受其首印。");
            // 惊悚蜕变
            AddTranslation("Macabre Growth", "凶长");
            // [creature]将获得所有被献祭卡牌的攻击力和生命值。
            AddTranslation("[creature] gains the attack and health of all cards sacrificed to play it.", "[creature]得诸祀牌之威与命。");
            // 分崩离析
            AddTranslation("Shatter", "碎");
            // 为支付[creature]的费用而献祭的卡牌死亡时将掉落4根骨头而非1根。
            AddTranslation("Cards sacrificed to pay for [creature] drop 4 bones instead of 1 when they die.", "为陈[creature]所祀之牌死，则落骨四，不止一。");
            // 内脏祭品
            AddTranslation("Guts Sacrifice", "腑祀");
            // 为支付[creature]的费用而献祭的卡牌死亡时，会在对面位置留下黏液。位于黏液位置的卡牌减少1点力量。
            AddTranslation("Cards sacrificed to pay for [creature] slime the opposing slot when they die. Cards in slimed slots have one less power.", "为偿[creature]之费而祀之牌既死，则涂其对位以涎。处涎位者威减一。");
            // 蓝色玛珂充能器
            AddTranslation("Blue Mox Charger", "蓝玛珂充者");
            // 当使用[creature]时，持牌人每打出一张蓝宝石玛珂，就会在手牌中生成一张“充能！”牌。“充能！”是使用时可恢复1点能量的法术牌。
            AddTranslation("When [creature] is played, it creates a Charge in your hand for each Blue Mox its owner controls. Charge is a spell that refills 1 Energy when played.", "[creature]既陈，其主持每御一蓝玛珂，则于手生一“充能！”。“充能！”者，陈之则复一能之术也。");
            // 当使用[creature]时，持牌人每打出一张蓝宝石玛珂，就会在手牌中生成一张“充能！”牌。“充能！”是使用时可恢复1点能量的命令牌。
            AddTranslation("When [creature] is played, it creates a Charge in your hand for each Blue Mox its owner controls. Charge is a command that refills 1 Energy when played.", "[creature]既陈，其主持每御一蓝玛珂，则于手生一“充能！”。“充能！”者，陈之则复一能之令也。");
            // 蓝宝石祝福
            AddTranslation("Sapphire Blessing", "蓝玉福");
            // [creature]可使你手牌中所有卡牌的费用降低1点。
            AddTranslation("[creature] reduces the cost of all cards in your hand by 1.", "[creature]使汝手中诸牌之费皆减一。");
            // 废料倾卸机
            AddTranslation("Scrap Dumper", "倾废者");
            // 使用带有该印记的卡牌时，对面位置会出现一个损坏的机器人。
            AddTranslation("When a card bearing this sigil is played, a broken bot is played on the opposing space.", "负此印者既陈，则其对位生一坏机。");
            // 废物利用
            AddTranslation("Scrap Salvage", "废取");
            // 使用[creature]时，将献祭卡牌的总成本转化为资源：每点能量生成1张“充能！”卡牌，每颗宝石生成1张“电击！”卡牌，每点血量生成1张“升级！”卡牌，每根骨头生成1张“防御！”卡牌。
            AddTranslation("When [creature] is played, add the total cost of all cards sacrificed to play it, then create a Charge! for each energy, create a Zap! for each gem, create an Upgrade! for each blood, and create a Defend! for each bone.", "[creature]既陈，合所祀诸牌之总费：每一能，生一“充能！”；每一玉，生一“电击！”；每一血，生一“升级！”；每一骨，生一“防御！”。");
            // 推土机
            AddTranslation("Bulldoze", "推辟");
            // 消耗1点能量使该卡牌朝印记标注的方向移动。沿途的造物会被推向同一方向。
            AddTranslation("Pay 1 Energy to cause this card to move in the direction inscribed in the sigil. Creatures that are in the way will be pushed in the same direction.", "费一能，使此牌循印所志而移。当途之物皆同向见推。");
            // 零敲碎打
            AddTranslation("Shred", "裂牌");
            // 粉碎一张手牌以获得+1攻击力（持续至回合结束）。被粉碎的卡牌视同死亡。无法被消灭的卡牌和石制卡牌不可被粉碎。
            AddTranslation("Shred a card from your hand to get +1 Attack (until end of turn). The shredded card behaves as if it died. Unkillable cards and cards Made of Stone cannot be shredded.", "裂汝手中一牌，以得威益一，至合终。彼裂牌视若已死。不死牌与磐身牌，不可裂。");
            // 副牌组力量
            AddTranslation("Side Deck Power", "副列威");
            // 该印记代表的数值等于持牌人从副牌组中抽取的卡牌数量。
            AddTranslation("The value represented with this sigil will be equal to the number of cards its owner has drawn from the side deck.", "此印所表之数，与其主持自副牌列所引之牌数等。");
            // 黏液卡槽
            AddTranslation("Slimed Slot", "涎位");
            // 该卡槽中的卡牌攻击力将降低1点。
            AddTranslation("The card in this slot will have its attack reduced by one.", "处此位之牌，威减一。");
            // 相位穿梭
            AddTranslation("Phase Through", "穿相");
            // 持牌人回合结束时，[creature]将向指定方向移动一格，必要时可穿透其他卡牌直至找到空位。
            AddTranslation("At the end of its controller's turn, [creature] moves one space in the direction indicated, moving through other cards if necessary until it finds an empty space.", "持牌者合终，[creature]循所志而移一；必要则穿诸牌而过，至得虚位乃止。");
            // 太阳之心
            AddTranslation("Solar Heart", "日心");
            // 当[creature]死亡时，其心脏会留在原地并为该卡槽提供管道能量。
            AddTranslation("When [creature] dies, its heart stays behind and provides conduit power to the slot.", "[creature]死，则其心留于故处，而为其位输渠能。");
            // 太阳能供电
            AddTranslation("Solar Powered", "日能");
            // 该卡槽将始终保持充能状态，即使未处于完整回路中。
            AddTranslation("This card slot stays powered at all times, even if it is not in a completed circuit.", "此位常得能，纵不在成回路中亦然。");
            // 强势入场
            AddTranslation("Overwhelming Entrance", "压入");
            // 当[creature]被使用时，所有对位的造物都会被抛到新的位置。非管道地形不受影响。
            AddTranslation("When [creature] is played, all opposing creatures are tossed into new slots. Non-conduit terrain is not affected.", "[creature]既陈，诸对物皆掷于新位。非渠地形不与。");
            // 使魔召唤
            AddTranslation("Summon Familiar", "召使魔");
            // 当使用[creature]时，会在相邻空位放置一只机械兽。
            AddTranslation("When [creature] is played, it plays a techbeast in an empty adjacent slot.", "[creature]既陈，则于邻虚位陈一机兽。");
            // 死亡时速
            AddTranslation("Zip of Death", "疾毙");
            // 受到2点伤害
            AddTranslation("Take 2 damage.", "受二伤。");
            // 目标锁定
            AddTranslation("Target Required", "有敌乃击");
            // [creature]只能攻击有卡牌存在的路线。
            AddTranslation("[creature] can only attack lanes that have cards in them.", "[creature]惟可攻有牌之列。");
            // 操控
            AddTranslation("Controlled", "见御");
            // [creature]当前由对手操控。回合结束时将回归原主。被操控期间无法被锤击。
            AddTranslation("[creature] is under control of its opponent. At the end of the turn, it will return to its owner. While being controlled, it cannot be hammered.", "[creature]今为敌所御。合终则归故主。既见御，不得受槌。");
            // 火球术
            AddTranslation("Fireball", "火丸");
            // [creature]回合结束时，将选择一个卡槽点燃，持续三回合。
            AddTranslation("At the end of its turn, [creature] chooses a card slot to set on fire for three turns.", "其合终，[creature]择一位，使之焚三合。");
            // 黏液球
            AddTranslation("Slimeball", "涎丸");
            // [creature]会在其回合结束时选择一个卡槽进行黏液覆盖。处于黏液卡槽中的卡牌会减少1点力量。
            AddTranslation("At the end of its turn, [creature] will choose one slot to become slimed. Cards in a slimed slot lose one power.", "其合终，[creature]择一位，使为涎位。处涎位者威减一。");
            // 史莱姆破坏者
            AddTranslation("Slime Vandal", "涎贼");
            // 当使用[creature]时，它会污染牌桌上所有空位。被污染空位中的卡牌将损失1点力量。
            AddTranslation("When [creature] is played, it slimes all slots on the board. Cards in slimed slots lose one power.", "[creature]既陈，则局上诸位皆涎。处涎位者威减一。");
            // 内脏炸弹
            AddTranslation("Full of Guts", "满腑");
            // 当[creature]死亡时，会在对面位置留下一滩内脏黏液。
            AddTranslation("When [creature] dies, it slimes the opposing slot.", "[creature]死，则其对位涎。");
            // 种子掉落
            AddTranslation("Seed Sprinter", "遗种驰");
            // 在持牌人回合结束时，[creature]会向指定方向移动一格（若可行）并在原位置种下一颗种子。
            AddTranslation("At the end of its controller's turn, [creature] moves one space in the direction indicated (if it can) and plants a seed in its previous space.", "持牌者合终，[creature]循所志移一（若可），而其故处殖一种。");
            // 容器之心
            AddTranslation("Vessel Heart", "皿心");
            // 带有该印记的卡牌阵亡时，会在其位置生成一个容器。
            AddTranslation("When a card bearing this sigil perishes, a vessel is created in its place.", "负此印者死，则其处生一皿。");
            // 电击
            AddTranslation("Zap", "电击");
            // 对目标造成直接伤害。
            AddTranslation("Deals damage directly to the target.", "直伤所指。");
            // 海胆生成管道
            AddTranslation("Urchin Spawn Conduit", "海胆生渠");
            // 由[creature]构成的回路中的空位置可在持牌人回合结束时生成海胆电池。
            AddTranslation("Empty spaces within a circuit completed by [creature] spawn Urchin Cells at the end of the owner's turn.", "在[creature]所成回路中之虚位，持牌者合终皆生海胆匣。");
            // 消耗2点能量，使[creature]力量设为1至6之间的随机数值。
            AddTranslation("Pay 2 Energy to set the power of [creature] randomly between 1 and 6.", "费二能，使[creature]之威偶定于一至六。");
        }
    }
}
