using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch39
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchThree();
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

        private static void RegisterAllTheSigilsBatchThree()
        {
            // 夹持器
            AddTranslation("Gripper", "攫");
            // 在持牌人的回合结束时，[creature]将朝着印记标注的方向移动，如果可能，将尝试带着对方造物一起移动。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil, and try to move the opposing creature with it if it can.", "持牌者合终，[creature]循印所志之向而移；若能，则并引其对物俱移。");
            // 它们留下的痕迹让人生疼。
            AddTranslation("The trail they leave behind, hurts.", "其所遗之迹，伤人。");
            // 匆忙
            AddTranslation("Haste", "亟");
            // [creature]一旦被放置到场上便会立刻攻击一次。
            AddTranslation("[creature] will attack as soon as it gets played on the board if played not during combat.", "[creature]若于战外既陈，则即攻。");
            // 急于求成
            AddTranslation("Hasteful", "先击");
            // [creature]将在被放置到场地上后立即攻击。它不会在正常战斗中攻击，它将在持牌人的回合开始时攻击。
            AddTranslation("[creature] will attack as soon as it gets played on the board. It will not attack during normal combat. It will attack at the start of the owner's turn.", "[creature]既陈即攻。常战之时则不攻，而于持牌者合始攻。");
            // 芸芸众生
            AddTranslation("Herd", "滋群");
            // [creature]将在每个维持阶段在同侧的空位上召唤一个自己的复制体，最多三次。
            AddTranslation("[creature] will summon a copy of itself each upkeep, up to three times.", "[creature]每合始生一己身之副于同侧空位，至三而止。");
            // 隐士
            AddTranslation("Hermit", "隐");
            // [creature]可以放置在任何地形卡上。若如此做，它们的印记和属性将合并，并创建一个名称组合。
            AddTranslation("[creature] may be placed on any terrain card. If it is their sigils and stats will be combined, and a name combination will be created.", "[creature]可陈于诸地形牌上。若然，则并其印与数，而成一合名。");
            // 涨潮之时
            AddTranslation("High Tide", "潮涨");
            // 当[creature]在场时，它将为同一侧的场上造物赋予水袭印记。不影响具有空袭印记的卡牌。
            AddTranslation("While [creature] is on the board, it will grant the waterborne sigil of cards that are played after it on it's side of the board. Does not affect cards that are Airborne.", "凡[creature]在局，后陈于其侧之牌皆得潜袭印契。翔袭者不与。");
            // 潮水上涨了。
            AddTranslation("The waters rise.", "潮起矣。");
            // 宾至如归
            AddTranslation("Homing", "趋的");
            // 如果[creature]的对位为空，且其相邻的路线有其他卡牌，[creature]将攻击该牌而不是直接攻击。
            AddTranslation("If the opposing slot is empty, and there is a creature in a neighbouring lane, [creature] will attack that creature instead of attacking the opposing slot.", "其对位若空，而邻列有物，则[creature]击彼物，不直击敌主。");
            // 变幻莫测
            AddTranslation("Hoodini", "幻换");
            // 当带[creature]被召唤时，它将与对位造物交换位置。如果对位没有卡牌，它将跑到对面。
            AddTranslation("When [creature] is played, it will swap places with the opposing creature.", "[creature]既陈，则与其对物易位；若彼处无牌，则径赴敌侧。");
            // 巢穴
            AddTranslation("Host", "巢");
            // [creature]是其他造物的巢穴。当它被攻击时，会给你特定的造物。
            AddTranslation("[creature] is the host of other creatures. It will give you such creature when struck.", "[creature]为他物之巢。见击，则予汝其物。");
            // 当[creature]被使用时，将使对手跳过其下一回合。
            AddTranslation("[creature] will cause the opponant to skip their turn when played.", "[creature]既陈，使敌过其一合。");
            // 时光流逝。
            AddTranslation("The sands of time tic away", "时沙渐尽。");
            // 积劳成疾
            AddTranslation("Exhaustion", "惫");
            // [creature]的攻击伤害将减少与它失去的生命值相同的量。
            AddTranslation("The attack of [creature] will be decreased by the same amount as its lost health.", "[creature]之威，减如其所失之命。");
            // 激动
            AddTranslation("Hyped", "奋");
            // [creature]除了在正常战斗期间攻击之外，也会在持牌人的回合开始时攻击。
            AddTranslation("[creature] will attack at the start of the owner's turn in addition to during normal combat.", "[creature]除常战时攻外，亦于持牌者合始攻。");
            // 注灵
            AddTranslation("Imbuing", "赋灵");
            // [creature]将根据用于召唤它的献祭中哪个族群最为突出而获得特定的增益效果。
            AddTranslation("[creature] will get specific buffs depending on which tribe is most promenent in the sacrifices that were used to summon it.", "[creature]所受之益，视召之所用牺牲中何属最著而定。");
            // 未知之触
            AddTranslation("Inaccurate", "失准");
            // [creature]将对其对位以及对位左侧和右侧的一个随机位置进行攻击。
            AddTranslation("[creature] will strike a random one of the opposing spaces to the left and right of the spaces across from it as well as the space in front of it.", "[creature]漫击其对位及其左右之一处。");
            // 岁月年华
            AddTranslation("Old Timer", "老成");
            // 在持牌人的回合开始时，[creature]将获得1点攻击力并受到1点伤害。
            AddTranslation("At the Start of its owner's turn [creature] will gain +1 attack and will take 1 damage.", "持牌者合始，[creature]威益一，而受一伤。");
            // 受伤
            AddTranslation("Injured", "伤");
            // [creature]每次声明攻击时都会因伤势而损失1点生命值。
            AddTranslation("[creature] is hurt and will lose 1 health each time it declares an attack due to the strain of the injuries.", "[creature]每宣攻，皆以其伤势失一命。");
            // 转瞬即逝
            AddTranslation("Instant", "立尽");
            // [creature]在放置后立即消亡。
            AddTranslation("[creature] will perish immediately after its played.", "[creature]既陈即灭。");
            // 启示之作
            AddTranslation("Launcher", "发物");
            // 在持牌人回合结束时，[creature]将在场上同侧的随机空位上创造另一个造物。
            AddTranslation("At the end of its owner's turn, [creature] will create another creature on a random empty space on the owner's side of the table.", "持牌者合终，[creature]于其侧一偶空位生别物。");
            // 骨骼领导
            AddTranslation("Lead (Bones)", "骨导");
            // 消耗2根骨头，使[creature]向印记标注的方向移动一个槽位。
            AddTranslation("Pay 2 bones to move this card one slot in the direction inscribed on the sigil.", "费二骨，使此牌循印所志之向移一位。");
            // 人能把马牵到水边……
            AddTranslation("one can lead  a horse to water...", "人能引马临水……");
            // 能量领导
            AddTranslation("Lead (Energy)", "能导");
            // 消耗2点能量，使[creature]向印记标注的方向移动一个槽位。
            AddTranslation("Pay 2 energy to move this card one slot in the direction inscribed on the sigil.", "费二能，使此牌循印所志之向移一位。");
            // 嗜血之蛭
            AddTranslation("Leech", "蛭");
            // 当[creature]造成伤害时，每对卡牌造成1点伤害将恢复1点生命值。
            AddTranslation("When [creature] deals damage, it will heal 1 Health for each damage dealt to a card.", "[creature]出伤时，凡伤一牌一分，则复一命。");
            // 活力来自血液！
            AddTranslation("Vigor from blood!", "力生于血！");
            // 左侧爪迹
            AddTranslation("Left scratch", "左爪");
            // 当[creature]攻击时，它还会攻击其左侧的空间。
            AddTranslation("When [creature] attacks it will also attack the space on the left of the attacked slot.", "[creature]攻时，亦及左旁之位。");
            // 生命赌徒
            AddTranslation("Life Gambler", "赌命");
            // 在持牌人的回合结束时，[creature]将对持牌人造成2点伤害，以换取0到6点属性值的提升。承担不起此代价将导致死亡。
            AddTranslation("At the end of the owner's turn, [creature] will deal 2 damage to the owner in exchange for a 0 to 6 increase in stats. Failing to pay this cost will result in death.", "持牌者合终，[creature]伤其主二，以易数值益零至六；不能偿此，则死。");
            // 你的血液，它们的力量！
            AddTranslation("Your blood, their strength!", "汝血，彼威！");
            // 语言学家
            AddTranslation("Linguist", "舌师");
            // 当[creature]在场时，同侧场上的所有会说话的卡牌获得1攻击力。
            AddTranslation("While [creature] is on the board, all talking cards on your side of the board get +1 attack.", "凡[creature]在局，汝侧诸言牌威益一。");
            // 退潮之时
            AddTranslation("Low Tide", "潮退");
            // 当[creature]在场时，它将移除其同侧造物的水袭印记。
            AddTranslation("While [creature] is on the board, it will negate the waterborne sigil of cards that are played after it on it's side of the board.", "凡[creature]在局，后陈于其侧之牌，其潜袭印契皆废。");
            // 摇篮曲
            AddTranslation("Lullaby", "眠谣");
            // 当[creature]死亡时，所有对立造物获得休眠印记。
            AddTranslation("When [creature] dies, all opposing creatures gain the asleep sigil.", "[creature]死，则敌诸物皆得寐印。");
            // 调遣
            AddTranslation("Maneuver", "调行");
            // 在持牌人回合开始时，如果[creature]对面槽位有造物，则将向印记标注的方位移动。否则，将向印记标注的相反方向移动。
            AddTranslation("At the start of the owner's turn, [creature] will strafe in the direction inscribed on the sigil if there is a creature in the opposing slot from it. Else it will strafe in the opposite direction inscribed on the sigil.", "持牌者合始，若[creature]对位有物，则循印所志之向移；不然，则反向而移。");
            // 它跑了。
            AddTranslation("It runs", "奔矣。");
            // 医疗兵
            AddTranslation("Medic", "医");
            // 在持牌人回合开始时，[creature]将尝试为每张友方卡牌治疗1点生命，前提是存在可医疗单位。
            AddTranslation("At the start of the owner's turn, [creature] will try heal 1 damage to a friendly card for each instance of Medic.", "持牌者合始，[creature]每因一重医，尝疗一友牌之一伤。");
            // 不错的医疗。
            AddTranslation("A good patching", "其疗善矣。");
            // 医疗救助
            AddTranslation("Medical Aid", "救疗");
            // 对手回合结束时，持牌人选择一个受到伤害的己方造物，恢复1点生命值。
            AddTranslation("At the end of the opponent's turn, choose a hurt creature on the owner's side to heal for 1.", "敌合终，持牌者择一受伤之己物，疗之以一命。");
            // 点石成金
            AddTranslation("Midas", "点金");
            // [creature]杀死一个造物时，每有一个点石成金的卡牌实例，就会给予一个货币。
            AddTranslation("[creature] kills a creature, it will generate 1 Foil for each instance of Midas the card has.", "[creature]杀一物，则此牌每有一点金，生一箔。");
            // 全额支付的赏金。
            AddTranslation("A bounty, paid in full.", "赏已尽偿。");
            // 固定装置
            AddTranslation("Mount", "载");
            // 其他卡牌可以放置在[creature]上方。若如此做，将合并它们的属性和印记，并创建一个名称组合。
            AddTranslation("Cards may be played on top of [creature]. If they are their sigils and stats will be combined, and a name combination will be created.", "诸牌可陈于[creature]之上。若然，则并其印与数，而成一合名。");
            // 运动的力量
            AddTranslation("Power from Movement", "动益");
            // 在持牌人的回合开始时，如果[creature]在上一个回合移动过，它将获得1点力量和1点生命。
            AddTranslation("At the start of the owner's turn, [creature] will gain 1 power and 1 health if it moved last round.", "持牌者合始，若[creature]上合尝移，则威命各益一。");
            // 每次移动，它都会成长。
            AddTranslation("Each move, it grows", "每移而长。");
            // 护士
            AddTranslation("Nurse", "护医");
            // 在对手回合结束时，[creature]将治愈所有相邻的友方卡牌。
            AddTranslation("At the end of the opponent's turn, [creature] will heal any adjacent friendly cards.", "敌合终，[creature]疗其左右己牌。");
            // 营养丰富
            AddTranslation("Nutritious", "饶养");
            // 当[creature]被献祭时，它将为献祭其上场的卡牌增加1点力量和2点生命。
            AddTranslation("When [creature] is sacrificed, it adds 1 power and 2 health to the card it was sacrificed for.", "[creature]祀时，所为而陈之牌威益一，命益二。");
            // 那个造物是如此的营养丰富，你所放置的造物将变得更强！
            AddTranslation("That creature is so full of nutrients, the creature you play comes in stronger!", "彼物饶养，故汝所陈者益强！");
            // 骨礼
            AddTranslation("Bone hoarder 1", "藏骨一");
            // [creature]被放置时，给予持有者1块骨头。
            AddTranslation("When [creature] is played, 1 bone is rewarded.", "[creature]既陈，则其主持得一骨。");
            // 机会主义者
            AddTranslation("Opportunist", "乘隙");
            // 当对位为空时，[creature]将因每个拥有机会主义者印记的实例获得1点力量。
            AddTranslation("[creature] will gain 1 power for each instance of Opportunist, when the opposing slot is empty.", "其对位若空，[creature]每因一重乘隙而威益一。");
            // 它抓住机会，当它得到时。
            AddTranslation("It takes it's chance when it gets it.", "得隙则乘之。");
        }
    }
}
