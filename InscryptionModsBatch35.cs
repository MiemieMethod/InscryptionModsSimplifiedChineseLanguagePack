using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch35
    {
        public static void RegisterTranslations()
        {
            RegisterAbilityBatchFromAgentB();
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

        private static void RegisterAbilityBatchFromAgentB()
        {
            // 消灭[creature]。
            AddTranslation("Kill [creature].", "杀[creature]。");
            // 磨砺
            AddTranslation("Sharpen", "砺");
            // 若你拥有橙色玛珂，可献祭它使[creature]获得+1攻击力
            AddTranslation("If you have an orange mox gem, sacrifice it to give [creature] +1 attack power.", "若汝有橙玛珂，可祀之，使[creature]威加一。");
            // [creature]献祭橙色玛珂以磨砺其攻击！
            AddTranslation("[creature] sacrifices an orange gem to sharpen it's attack!", "[creature]祀橙玉，以砺其击！");
            // 咒术之剑
            AddTranslation("Spellsword", "术剑");
            // 与[creature]同侧的牌桌上所有宝石获得2点力量、发动攻击后阵亡。
            AddTranslation("All gems on the same side of the board as[creature] gain 2 power, attack, and perish.", "与[creature]同侧局上诸玉，威益二，出击而死。");
            // 飞行能手
            AddTranslation("Trained Flier", "习翔");
            // 使[creature]获得空袭印记效果直至下次维持阶段。若该卡已具有空袭印记，则暂时移除该效果直至下次维持阶段。
            AddTranslation("Grant [creature] the effect of the Airborne sigil until next upkeep. If the card already has Airborne, this will remove it's effect until next upkeep.", "使[creature]至次合始得翔袭印契；若此牌素有之，则反去其效至次合始。");
            // 游泳能手
            AddTranslation("Trained Swimmer", "习潜");
            // 该造物将获得水袭印记的效果，持续一回合。
            AddTranslation("Creature will gain the effect of the Waterborne sigil for one turn.", "[creature]一合得潜袭印契。");
            // 升级子程序
            AddTranslation("Upgrade Subroutine", "升程");
            // 当[creature]摧毁其他机器人时，可获得1点升级点数。激活时，持牌人可从三个印记中选择一个永久强化该卡牌。选择印记会消耗点数，激活时积累的点数越多，提供的印记品质越高。
            AddTranslation("When[creature] destroys another bot, this gains 1 point. When activated, the owner is presented with a choice of three sigils to permanently augment the card. Selecting a sigil spends points, and the more points accumulated when the sigil is activated, the higher quality the presented sigils will be.", "凡[creature]毁他机人，则积一点。启之，则持牌者于三印契中择一，以永益此牌。择印耗点；积点愈多，则所示印契愈良。");
            // 蛰刺握
            AddTranslation("Aculeate Grip", "螫攫");
            // 当有造物被放置在与[creature]同侧的牌桌时，[creature]会尽可能向其移动，对其造成1点伤害并增加自身1点生命值。
            AddTranslation("When a creature is played on the same side of the board as [creature], [creature] will move towards them as far as possible, dealing them one damage and increasing it's own health by 1.", "他物既陈于与[creature]同侧之局，[creature]即尽所能趋之，伤彼一，而自命益一。");
            // 媚骨天生
            AddTranslation("Allure", "媚引");
            // 回合结束时，[creature]会将对方造物吸引至自己正前方。
            AddTranslation("At the end of the round, [creature] will draw opposing creatures in front of itself.", "每轮终，[creature]引敌物于其前。");
            // 湮灭
            AddTranslation("Annihilation", "殄灭");
            // 当[creature]阵亡时，牌桌上所有造物均受到10点伤害
            AddTranslation("When [creature] perishes, all creatures on the board are dealt 10 damage.", "[creature]死，则局上诸物皆受十伤。");
            // 蚂蚁守护者
            AddTranslation("Ant Guardian", "护蚁");
            // 当友方蚂蚁遭受攻击时，[creature]会以自身攻击力对攻击者造成等量伤害。
            AddTranslation("[creature] will deal damage equal to it's attack power to any card which strikes a friendly ant.", "己蚁见击，则[creature]以其威伤击者。");
            // 反魔法
            AddTranslation("Antimagic", "反术");
            // 当[creature]在场时，任何打出的玛珂宝石会立即消亡。[creature]会移动到被摧毁宝石的位置，获得1点生命值并立即攻击。
            AddTranslation("Any mox gems played while [creature] is on the board will immediately perish. [creature] will move to the position of the destroyed gem, gain 1 health, and immediately attack.", "凡[creature]在局，所陈玛珂玉即死。[creature]移据其毁玉之处，命益一，而即击。");
            // [creature]摧毁了打出的宝石！
            AddTranslation("[creature] destroys the played gem!", "[creature]毁其所陈之玉！");
            // 装甲化
            AddTranslation("Armortify", "被甲");
            // 当[creature]击杀对面造物时，该卡牌将获得身披坚甲印记。
            AddTranslation("When [creature] attacks an opposing creature and it perishes, this card gains the armored sigil.", "[creature]击杀敌物，则此牌得坚甲印契。");
            // 艺术许可
            AddTranslation("Artistic License", "艺纵");
            // 当打出[creature]时，其对面的造物将失去所有印记。
            AddTranslation("When [creature] is played, the creature opposing it loses all sigils.", "[creature]既陈，其对物失其诸印。");
            // 想偷老子的印记？你这扫兴的混账！
            AddTranslation("Trying to plunder me sigils? Yer a sour spoilsport!", "欲掠我印耶？汝真败兴之徒！");
            // 纵使技艺精湛，月之魂仍不可撼动……
            AddTranslation("Despite your artistry, the soul of the moon is impervious...", "虽工于艺，然月魂不可犯……");
            // 数据备份
            AddTranslation("Backup", "后继");
            // 当[creature]在战斗中阵亡时，其持有者手牌中的第一张卡牌将自动补位。
            AddTranslation("When [creature] perishes by combat, the first card in it's owner's hand is played in it's place.", "[creature]战死，则持牌者手中首牌代居其处。");
            // [creature]呼叫了后备支援
            AddTranslation("[creature] calls in backup.", "[creature]召后继矣。");
            // 绷带编织者
            AddTranslation("Bandage Weaver", "纫帛者");
            // 回合结束时，[creature]会为左右两侧的卡牌各恢复1点生命值。
            AddTranslation("At the end of the turn,[creature] will heal the cards to it's left and right for 1 health.", "合终，[creature]疗左右诸牌各一命。");
            // 堡垒
            AddTranslation("Bastion", "垒");
            // 当[creature]受到伤害时，实际承受的伤害值减半（向上取整）。
            AddTranslation("When [creature] recieves damage, it only takes half the damage it normally would, rounded up.", "[creature]受伤，所受惟常半，分奇则进一。");
            // 批量删除
            AddTranslation("Batch Delete", "并删");
            // 当[creature]击杀目标造物时，牌桌上所有与该目标费用相同的造物都会阵亡。
            AddTranslation("When [creature] strikes a creature and it perishes, any creatures on the board which share the same cost as the target perish also.", "[creature]击物而杀之，则局上凡与其同直之物亦皆死。");
            // [creature]会粉碎所有与受害者费用相同的卡牌。
            AddTranslation("[creature] shreds any other cards with the same cost as it's victim...", "[creature]尽裂诸与所害者同直之牌……");
            // 宝石迷阵
            AddTranslation("Bejeweled", "连玉");
            // 当[creature]在场时，若同色宝石三连成线，则移除这些宝石。与之对阵的造物也将被移除，对手将受到等同于这些造物总攻击力的直接伤害。
            AddTranslation("While [creature] is on the field, lining up three gems of the same colour will remove those gems from the field. Any creatures which opposed those gems will be removed as well, and the opponent will take damage directly equal to their combined attack power. ", "凡[creature]在局，三同色之玉若成列，则去此诸玉。凡与之相对之物亦去之；敌并直受其合威之伤。");
            // 扑朔迷离
            AddTranslation("Bewilder", "惑");
            // 当使用[creature]时，其持牌人可选择任意造物，互换该造物的力量与生命。
            AddTranslation("When [creature] is played, it's owner may choose any creature. Swap that creatures power and health.", "[creature]既陈，持牌者可择一物，而易其威与命。");
            // 橙色兵分
            AddTranslation("Bifurcated When Gempowered", "得玉歧击");
            // 若持牌人拥有橙宝石，[creature]会攻击正对面的左右两侧位置各一次。
            AddTranslation("If its owner has an Orange Gem, [creature] will strike each opposing space to the left and right of the space across from it.", "若持牌者有橙玉，[creature]击其正对之左与右。");
            // 二分法
            AddTranslation("Bisection", "二裂");
            // 当[creature]击杀其他造物时，会在持牌人手中生成两张力量归零、生命值减半的受害者复制卡牌。
            AddTranslation("When [creature] kills another creature, two copies of the victim are created in the owner's hand with zero power and halved health.", "[creature]杀他物，则持牌者手中生受害者之同牌二，威皆为零，而命半之。");
            // 漂白剂
            AddTranslation("Bleach", "漂液");
            // 当[creature]被打出时，所有敌方造物将失去全部印记。
            AddTranslation("When [creature] is played, all opponent creatures lose all sigils.", "[creature]既陈，敌诸物尽失其诸印。");
            // 肥美多汁
            AddTranslation("Bloated", "丰血");
            // [creature]在献祭时可算作等同于其生命值的血量。
            AddTranslation("[creature] is worth blood equal to its health when sacrificed.", "[creature]祀时，其值血如其命。");
            // 血液艺术家
            AddTranslation("Blood Artist", "血绘者");
            // 当牌桌上有[creature]时，每有三张卡牌因战斗阵亡，[creature]将为持牌人制作一张由这些造物的费用、属性和印记构成的死亡卡。
            AddTranslation("Every three cards which perish by combat while [creature] is on the board, [creature] will give it's owner a deathcard constructed from the cost, stats, and sigils of those creatures.", "凡[creature]在局，战死之牌每三，则[creature]为持牌者作一死牌，因其诸物之直、数与印契而成之。");
            // [creature]会根据先前阵亡造物制作死亡卡……
            AddTranslation("[creature] constructs a deathcard from previous creatures deaths...", "[creature]因先死诸物而作一死牌……");
            // 当[creature]被献祭时，它会切换形态而非阵亡。
            AddTranslation("When [creature] is sacrificed, it transforms to or from it's alternate form instead of perishing.", "[creature]祀之，则不死，而与其异相相易。");
            // 血液依赖
            AddTranslation("Blood Dependent", "恃血");
            // 若[creature]在攻击阶段未能击中其他造物，则会在持牌人下个回合开始时阵亡。
            AddTranslation("If [creature] does not strike another creature during the attack phase, it will perish at the start of the owner's next turn.", "若[creature]攻时不击他物，则持牌者次合始必死。");
            // 石中取血
            AddTranslation("Blood From Stone", "石出血");
            // 你可以献祭地形卡来打出[creature]。
            AddTranslation("You may sacrifice terrain cards in order to play [creature].", "可祀地形牌，以陈[creature]。");
            // 鲜血喷涌
            AddTranslation("Blood Gusher", "涌血");
            // 当[creature]击杀对面造物时，该卡牌及其左右相邻的造物各恢复1点生命。
            AddTranslation("When [creature] attacks an opposing creature and it perishes, this card, as well as creatures to the left and right of this card, gain 1 health.", "[creature]击杀敌物，则此牌与左右邻物各命益一。");
            // 鲜血吞噬者
            AddTranslation("Blood Guzzler", "饮血者");
            // 当[creature]对造物造成伤害时，每造成1点伤害即恢复1点生命。
            AddTranslation("When[creature] deals damage to a creature, it gains 1 Health for each damage dealt.", "[creature]出伤之时，每伤一，则命益一。");
            // [creature]吸食着猎物的鲜血！
            AddTranslation("[creature] consumes the blood of its prey!", "[creature]饮其猎之血！");
            // 血魔法
            AddTranslation("Blood Magic", "血术");
            // 当[creature]在场时，其持牌人可以献祭任意宝石，即使这些宝石通常无法被献祭。
            AddTranslation("While [creature] is on the field, its owner may sacrifice any gems, even if those gems normally cannot be sacrificed.", "凡[creature]在局，持牌者可祀诸玉；纵其常不可祀，亦可。");
            // 血行者
            AddTranslation("Bloodrunner", "血行");
            // 当[creature]对造物造成伤害时，它将朝印记标注的方向移动。
            AddTranslation("When [creature] deals damage to a creature, it will move in the direction inscribed in the sigil.", "[creature]伤物，则循印所志之向而移。");
            // 蓝色灵感
            AddTranslation("Blue Inspiration", "蓝悟");
            // 当牌桌上有[creature]时，所有以蓝宝石为费用的友方造物登场时将获得随机印记。
            AddTranslation("While [creature] is on the board, all friendly creatures which cost a blue gem will gain a random sigil when played.", "凡[creature]在局，己物凡直蓝玉者既陈，皆得一偶印契。");
            // [creature]为以蓝宝石为费用的造物赋予随机印记！
            AddTranslation("[creature] empowers the Blue Gem cost creature with a random sigil!", "[creature]使一直蓝玉之物得一偶印契！");
            // 爆弹咒
            AddTranslation("Bombjuration", "爆召");
            // 使用[creature]时，持牌人可选择牌桌任意一侧的空位，在该位置生成一枚魔法爆弹。
            AddTranslation("When [creature] is played, it's owner may choose an empty slot on either side of the board. A magic bomb is created in the chosen slot.", "[creature]既陈，持牌者可择局中一空位，生一法爆于其所。");
            // 炸弹空投
            AddTranslation("Bombs Away", "投爆");
            // 使用[creature]时，对面位置会出现一个有效载荷。[define:SigilNevernamed Payload]
            AddTranslation("When [creature] is played, a Payload is created in the opposing slot. [define:SigilNevernamed Payload]", "[creature]既陈，则其对位生一载荷。[define:SigilNevernamed Payload]");
            // [creature]向对面位置空投了一个有效载荷！
            AddTranslation("[creature] drops a payload into the opposing slot!", "[creature]投一载荷于其对位！");
            // 骨头依赖
            AddTranslation("Bone Dependent", "恃骨");
            // 若使用者骨头数为零，[creature]将立即阵亡。
            AddTranslation("If the user has 0 Bones, [creature] will perish.", "若持牌者无骨，[creature]即死。");
            // 骨公爵
            AddTranslation("Bone Duke", "骨公");
            // [creature]死亡时，原本获得的1根骨头将变为3根。
            AddTranslation("When [creature] dies, 3 Bones are awarded instead of 1.", "[creature]死，则所得之骨不一而三。");
            // 骨欲
            AddTranslation("Bonelust", "嗜骨");
            // 当[creature]击杀其他造物时，为持牌人生成3根骨头。
            AddTranslation("When [creature] kills another creature, it generates 3 bones for its owner.", "[creature]杀他物，则为持牌者生三骨。");
            // 骨刺
            AddTranslation("Bone Spurs", "骨刺");
            // [creature]被攻击时，将为持牌人产生1根骨头。
            AddTranslation("When [creature] is struck, it generates a bone for it's owner.", "[creature]见击，则为持牌者生一骨。");
            // [creature]会在攻击时优先选择对面力量最低的卡牌。
            AddTranslation("[creature] will target the least powerful opposing card when it attacks.", "[creature]攻时，先击敌牌威最寡者。");
            // 燃烧
            AddTranslation("Burning", "焚");
            // 持牌人回合结束时，[creature]会受到1点伤害。此外，当[creature]被攻击时，攻击者会获得该印记。
            AddTranslation("At the end of the owner's turn, [creature] takes 1 damage. Also, when [creature] is struck, the striker gains this sigil.", "持牌者合终，[creature]受一伤；其见击也，击者亦得此印契。");
            // 蜉蝣冲击
            AddTranslation("Buzz Off", "遗蜉");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在原地留下一只蜉蝣。蜉蝣定义为1点力量、1点生命值、具有飞行与脆弱特性。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil and leave a mayfly in it's old place. A mayfly is defined as 1 power, 1 health, airborne, brittle.", "持牌者合终，[creature]循印所志之向而移，并遗一蜉蝣于故处。蜉蝣者：1威、1命、翔袭、脆骨。");
            // 号召行动
            AddTranslation("Call To Arms", "号战");
            // 当使用[creature]时，其左右两侧的造物会立即发起攻击。
            AddTranslation("When [creature] is played, the creatures to it's left and right will immediately attack.", "[creature]既陈，其左右之物即击。");
            // 牌堆剥离者
            AddTranslation("Card Shedder", "遗牌");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在其经过之处留下一张卡牌。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil and leave a card in it's wake.", "持牌者合终，[creature]循印所志之向而移，并遗一牌于其后。");
            // 物腐毒生
            AddTranslation("Caustic", "腐毒");
            // 当[creature]阵亡时，击杀它的造物也会随之阵亡。
            AddTranslation("When [creature] perishes, it's killer perishes as well.", "[creature]死，则杀之者亦死。");
            // 中心打击
            AddTranslation("Center Strike", "中击");
            // [creature]会攻击除最左和最右路线外的所有对手位置。
            AddTranslation("[creature] will attack all opponent slots except for those in the leftmost and rightmost lanes.", "[creature]击诸敌位，惟最左与最右之列不击。");
            // 混沌打击
            AddTranslation("Chaos Strike", "乱击");
            // 抽到[creature]时，此印记将被随机替换为一个打击强化类印记。
            AddTranslation("When [creature] is drawn, this sigil is replaced by a random strike modifier sigil.", "[creature]既引，此印契偶易为一击类印契。");
            // 欺诈者
            AddTranslation("Cheater", "诈者");
        }
    }
}
