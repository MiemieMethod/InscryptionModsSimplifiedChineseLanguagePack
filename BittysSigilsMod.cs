using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class BittysSigilsMod
    {
        public static void RegisterTranslations()
        {
            // 两侧堵塞。没有蛋给你。
            AddTranslation("Blocked on both sides. No Eggs for you.", "两旁既塞，无卵与汝。");
            // 没有空位，无法给你大冷杉。
            AddTranslation("No empty spaces. No firs for you.", "无空位，无杉与汝。");
            // 松鼠泛滥
            AddTranslation("Explosive Squirrel Reproduction", "蕃鼠");
            // 当打出[creature]时，你的副牌组将被松鼠填满。
            AddTranslation("When [creature] is played, fill your side deck with squirrels.", "[creature]既陈，则以松鼠充汝副牌列。");
            // 运输者
            AddTranslation("Hauler", "牵");
            // 在持牌人的回合结束时，[creature]会向印记标注的方向移动。相邻的友方生物会被拉向同一方向。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. Adjacent friendly creatures will be pulled in the same direction.", "持牌者合终，[creature]循印所志而移；其旁友物，亦为之牵而同移。");
            // 心灵交换
            AddTranslation("Heart Swap", "易心");
            // 当打出[creature]时，场上所有卡牌将交换其力量和生命值。
            AddTranslation("When [creature] is played, all cards on the board swap their power and health.", "[creature]既陈，局上诸牌皆易其威命。");
            // 相互雇佣
            AddTranslation("Mutual Hire", "相雇");
            // 当打出[creature]时，会在对方区域创造一个它的副本。
            AddTranslation("When [creature] is played, a copy of it is created in the opposing space.", "[creature]既陈，则其对位生一副。");
            // 充能弹幕
            AddTranslation("Charged Barrage", "充霰");
            // 消耗4点生命值，增加同侧场上所有卡牌1点力量。
            AddTranslation("Pay 4 life to increase the power of all cards on your side of the board by 1.", "费四命，则汝侧诸牌威皆益一。");
            // 生命骰子
            AddTranslation("Health Roll", "命骰");
            // 消耗1点能量，将[creature]的生命值设置为1到6的随机数字。
            AddTranslation("Pay 1 Energy to set the health of [creature] randomly between 1 and 6.", "费一能，使[creature]之命偶定于一至六。");
            // 印记骰子
            AddTranslation("Sigil Roll", "印骰");
            // 消耗4点生命值，将一个随机印记添加到[creature]上。
            AddTranslation("Pay 4 Life to add a random sigil to [creature].", "费四命，加一偶印于[creature]。");
            // 野兽相机
            AddTranslation("Wildlife Camera", "野影器");
            // 当[creature]击杀另一张卡牌时，会在你的手中创造该被击杀卡牌的副本。
            AddTranslation("When [creature] kills another card, a copy of the killed card is created in your hand.", "[creature]杀他牌，则彼牌之副生于汝手。");
            // 尘埃羽毛笔
            AddTranslation("Dusty Quill", "尘笔");
            // 当[creature]在场上时，若其他造物死亡，会在其位置召唤一具尸体。尸体被定义为：0点力量，1点生命。
            AddTranslation("Whenever a creature dies while [creature] is on the board, a corpse is raised in it's place. Corpses are defined as: 0/1.", "凡[creature]在局，有物死，则其处起一尸。尸者：0威、1命。");
            // 漂白之笔
            AddTranslation("Bleached Brush", "素笔");
            // 当[creature]被打出时，对位的卡牌将失去所有印记。
            AddTranslation("When [creature] is played, the opposing card will lose all its sigils.", "[creature]既陈，其对牌尽失诸印。");
            // 剽悍之魂
            AddTranslation("Strong Soul", "强魂");
            // [creature]不能接受其他造物的印记转移。
            AddTranslation("[creature] may not recieve sigils from another card.", "[creature]不得受他牌之印。");
            // 孱弱之魂
            AddTranslation("Weak Soul", "弱魂");
            // [creature]不能转移自己的印记。
            AddTranslation("[creature] may not have its sigils transferred to another card.", "[creature]不得徙己印于他牌。");
            // 缥缈之魂
            AddTranslation("Nonexistent Soul", "无魂");
            // [creature]不能接受其他造物的印记转移和转移自己的印记。
            AddTranslation("[creature] may not have sigils transferred to, or from this card.", "[creature]不得受印，亦不得徙印。");
            // 恐火症
            AddTranslation("Pyrophobia", "惧火");
            // [creature]不能在篝火事件获得增益。
            AddTranslation("[creature] may not be buffed at campsites.", "[creature]不得于篝火处受益。");
            // 恐火症（力量）
            AddTranslation("Pyrophobia (Attack)", "惧火（威）");
            // [creature]不能从篝火事件获得力量增益。
            AddTranslation("[creature] may not recieve power buffs from campsites.", "[creature]不得于篝火处受威益。");
            // 恐火症（生命）
            AddTranslation("Pyrophobia (Health)", "惧火（命）");
            // [creature]不能从篝火事件获得生命增益。
            AddTranslation("[creature] may not recieve health buffs from campsites.", "[creature]不得于篝火处受命益。");
            // 排斥
            AddTranslation("Repulsion", "斥");
            // [creature]不能攻击。
            AddTranslation("[creature] may not attack.", "[creature]不得攻。");
            // 神秘蘑菇
            AddTranslation("Mysterious Mushrooms", "异蕈");
            // 回合结束时，如果[creature]的两侧有牌，它们会融合在一起。
            AddTranslation("At the end of the turn, if there is a card on either side of [creature], they are fused together.", "合终，若[creature]两旁有牌，则并而为一。");
            // 在持牌人的回合结束时，[creature]会带动对位卡牌和自身向印记标注的方向移动。
            AddTranslation("At the end of the owner's turn, [creature] will move the opposing card and itself in the direction inscribed in the sigil.", "持牌者合终，[creature]引其对牌与己，循印所志而移。");
            // 反伤刺甲
            AddTranslation("Counter Attack", "反刺");
            // 一旦[creature]被攻击，攻击者将受到等同于这张卡牌攻击力的伤害。
            AddTranslation("Once [creature] is struck, the striker is then dealt damage equal to this card's attack.", "[creature]见击，则击者受伤如是牌之威。");
            // 镜面刺甲
            AddTranslation("Mirror Counter", "镜刺");
            // 一旦[creature]被攻击，攻击者将受到等同于攻击者攻击力的伤害。
            AddTranslation("Once [creature] is struck, the striker is then dealt damage equal to the striker's attack.", "[creature]见击，则击者受伤如其自威。");
            // 全场移相
            AddTranslation("Board Shifter", "移局");
            // 在持牌人的回合结束时，[creature]将按照印记标注的方向移动。所有卡牌将朝同一方向移动，绕到场地的另一侧。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. All cards will shift in the same direction, looping to the other edge of the board.", "持牌者合终，[creature]循印所志而移。诸牌皆同向而移，环至彼边。");
            // 友军移相
            AddTranslation("Board Shifter (Owner)", "移友局");
            // 在持牌人的回合结束时，[creature]将按照印记标注的方向移动。友方卡牌将朝同一方向移动，绕到场地的另一侧。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. Friendly cards will shift in the same direction, looping to the other edge of the board.", "持牌者合终，[creature]循印所志而移。友牌皆同向而移，环至彼边。");
            // 敌军移相
            AddTranslation("Board Shifter (Opposing)", "移敌局");
            // 在持牌人的回合结束时，[creature]将按照印记标注的方向移动。对手的卡牌将朝同一方向移动，绕到场地的另一侧。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. The opposing cards will shift in the same direction, looping to the other edge of the board.", "持牌者合终，[creature]循印所志而移。敌牌皆同向而移，环至彼边。");
            // 丧钟
            AddTranslation("Deathbell", "丧钟");
            // 每个回合开始时，[creature]会消亡。
            AddTranslation("At the start of the battle phase, [creature] perishes.", "战阶始，[creature]即灭。");
            // 顺时针
            AddTranslation("Clockwise", "顺时");
            // 当一张[creature]被打出时，场上所有卡牌顺时针移动一格。
            AddTranslation("When [creature] is played, move all cards on the board clockwise.", "[creature]既陈，局上诸牌皆顺时移一格。");
            // 顽固不化
            AddTranslation("Stubborn", "固");
            // [creature]不能交换其属性。
            AddTranslation("[creature] may not have its stats swapped.", "[creature]不得易其数。");
            // 每回合结束时，若场上存在一张[creature]，则将场上的所有卡牌顺时针移动一格。
            AddTranslation("At the end of each turn [creature] is on the board, move all cards on the board clockwise.", "每合终，若[creature]在局，则局上诸牌皆顺时移一格。");
            // 稍纵即逝
            AddTranslation("Fleeting", "暂");
            // 一张[creature]将在回合结束时被弃置。
            AddTranslation("At the end of the turn [creature] will be discarded from your hand.", "合终，[creature]自汝手见弃。");
            // 灵魂链接
            AddTranslation("Soul Link", "同魂");
            // 当[creature]消亡时，所有其他带有此印记的友方卡牌也将随之消亡。
            AddTranslation("When [creature] perishes, all other allied cards bearing this sigil perish as well.", "[creature]灭，则余有此印之友牌皆灭。");
            // 空洞抽取
            AddTranslation("Hollow Draw", "虚引");
            // 当[creature]被打出时，弃掉你手中最早抽到的卡牌，重新抽一张牌。
            AddTranslation("When [creature] is played, discard the oldest card in your hand, draw a card.", "[creature]既陈，弃汝手中最先所引之牌，而更引一牌。");
            // 空洞弹幕
            AddTranslation("Hollow Barrage", "虚霰");
            // 当[creature]被打出时，场上所有卡牌受到1点伤害。
            AddTranslation("When [creature] is played, all cards take 1 damage.", "[creature]既陈，局上诸牌皆受一伤。");
            // 宝石恐惧
            AddTranslation("Gem Phobic", "惧玉");
            // 若[creature]的持有者场上拥有任何玛珂牌，[creature]将消亡。
            AddTranslation("If [creature]'s owner controls a Mox card, [creature] perishes.", "若[creature]之主持有玛珂牌，[creature]即灭。");
            // 鲁莽
            AddTranslation("Foolhardy", "妄");
            // [creature]不能从任何事件中获得修改。
            AddTranslation("[creature] may not recieve modifications from any source.", "[creature]不得受任何改益。");
            // 跳跃者
            AddTranslation("Jumper", "跃");
            // 在持牌人的回合结束时，[creature]会自行向印记标注的方向移动至第一个空位。
            AddTranslation("At the end of the owner's turn, [creature] will move itself to the first empty space in the direction inscribed in the sigil.", "持牌者合终，[creature]自循印所志之向移至其首空位。");
            // 冲刺狂人
            AddTranslation("Super Sprinter", "疾趋");
            // 在持牌人的回合结束时，[creature]会尽可能地向印记标注的方向移动。
            AddTranslation("At the end of the owner's turn, [creature] will move itself as far as possible in the direction inscribed in the sigil.", "持牌者合终，[creature]尽所能循印所志而移。");
            // 蛋之艺术
            AddTranslation("Eggist", "生卵");
            // 当打出[creature]时，在每个相邻的空位上各创建一个蛋。
            AddTranslation("When [creature] is played, an Egg is created on each empty adjacent space.", "[creature]既陈，其邻空位各生一卵。");
            // 唤林者
            AddTranslation("Fir Caller", "召杉");
            // 当[creature]被打出时，在持牌人的每个空位上创造一个大冷杉。
            AddTranslation("When [creature] is played, a Fir is created in each of the owner's spaces.", "[creature]既陈，持牌者诸空位各生一杉。");
            // 浮光掠影
            AddTranslation("Flipper", "易数");
            // 在持牌人回合结束时，[creature]会交换其属性。
            AddTranslation("At the end of the owner's turn, [creature] swaps its stats.", "持牌者合终，[creature]易其数。");
            // 消逝之手
            AddTranslation("Fleeting Draw", "暂引");
            // 当一张[creature]被打出时，获得一张带有稍纵即逝印记的牌。
            AddTranslation("When [creature] is played, draw 1 card with Fleeting.", "[creature]既陈，则引一有暂印之牌。");
            // 流浪者
            AddTranslation("Outcast", "还列");
            // 回合结束时，[creature]会被洗入你的牌组。
            AddTranslation("At the end of the turn, [creature] is shuffled into the deck.", "合终，[creature]还入汝牌列而乱之。");
            // 空洞中继
            AddTranslation("Hollow Repeater", "虚继");
            // 当[creature]消亡时，该卡牌上所有上场时触发的印记将被激活。
            AddTranslation("When [creature] perishes, all On Play sigils on that card are activated.", "[creature]灭，则此牌上凡陈时所发之印皆启。");
            // 买一送一
            AddTranslation("Replenish", "续引");
            // 当一张[creature]被抽到时，再抽一张牌。
            AddTranslation("When [creature] is drawn, draw a card.", "[creature]既引，更引一牌。");
            // 目标交换器
            AddTranslation("Target Swap", "易数指");
            // 放置[creature]时，持牌人选择一张牌：该牌的力量和生命数值将被交换。
            AddTranslation("When [creature] is played, Target a Card: the card's stats are swapped.", "[creature]既陈，择一牌而易其威命。");
            // 祭祀生长
            AddTranslation("Sacrificial Growth", "祀长");
            // 当[creature]被献祭时，它将成长为更强大的形态。
            AddTranslation("When [creature] is sacrificed, it will grow into a more powerful form.", "[creature]见祀，则长为益强之形。");
            // 红宝石易形
            AddTranslation("Ruby Transformer", "红玉化");
            // 若[creature]的持牌人场上拥有红宝石玛珂，[creature]将转变为另一种形态；否则[creature]将转变为其基础形态。
            AddTranslation("If [creature]'s owner controls a Ruby Mox, [creature] will be transformed; otherwise [creature] will transform into its base form.", "若[creature]之主持红玉玛珂，则[creature]化其异形；不然，则反其本形。");
            // 宝石增益
            AddTranslation("Gemify", "玉益");
            // [creature]根据进场时持牌人拥有宝石获得增益。橙色：增加1点力量；绿色：增加2点生命；蓝色：降低花费成本。
            AddTranslation("[creature] gains buffs based on moxes in play on the owner's side. Orange is 1 Power. Green is 2 Health. Blue is lower Cost.", "[creature]视其主持局中诸玛珂而受益：橙则威益一，绿则命益二，蓝则直降。");
            // 尸体
            AddTranslation("Corpse", "尸");
            // 测试卡牌
            AddTranslation("TestCard", "试牌");
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
    }
}
