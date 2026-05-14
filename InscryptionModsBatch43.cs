using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch43
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchSeven();
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

        private static void RegisterAllTheSigilsBatchSeven()
        {
            // 族群攻击
            AddTranslation("Tribe Attack", "属攻");
            // 当[creature]在场上时，同一侧所有相同族群的卡牌攻击力+1。
            AddTranslation("While [creature] is on the board, all other cards on your side of the board of the same tribe will gain +1 attack.", "凡[creature]在局，汝侧余牌与之同属者，威皆益一。");
            // 族群生命
            AddTranslation("Tribe Health", "属命");
            // 当[creature]在场上时，同一侧所有相同族群的卡牌生命值+1。
            AddTranslation("While [creature] is on the board, all other cards on your side of the board of the same tribe will gain +1 health.", "凡[creature]在局，汝侧余牌与之同属者，命皆益一。");
            // 混沌水域
            AddTranslation("Turbulent Waters", "湍波");
            // [creature]将迫使其他拥有水袭印记的造物浮出水面，并在持牌人的回合开始时受到1点伤害。
            AddTranslation("[creature] will force other creatures with waterborne to resurface and take 1 damage at the start of the owner's turn.", "[creature]迫有潜袭印之余物出水；持牌者合始，彼皆受一伤。");
            // 水面波涛汹涌。
            AddTranslation("The waters be rough.", "波涛甚恶。");
            // 骨臣
            AddTranslation("Bone prince 2", "骨侯二");
            // 当[creature]死亡时，奖励2根骨头，而不是1根。
            AddTranslation("When [creature] dies, 2 bones are rewarded instead of 1.", "[creature]死，则赏骨二，不一。");
            // 双重骨礼
            AddTranslation("Bone hoarder 2", "藏骨二");
            // [creature]被放置时，给予持有者2块骨头。
            AddTranslation("When [creature] is played, 2 bones are rewarded.", "[creature]既陈，则其主持得二骨。");
            // 扶弱锄强
            AddTranslation("Underdog", "居下");
            // [creature]只能在您处于劣势时使用。
            AddTranslation("[creature] can only be played when you are losing.", "汝处下风，乃得陈[creature]。");
            // 凶相毕露
            AddTranslation("Vicious", "狠");
            // 当[creature]被攻击时，它获得1点力量。
            AddTranslation("When [creature] is attacked, it gains 1 power.", "[creature]见攻，则威益一。");
            // 一次攻击只会让它生气。
            AddTranslation("A hit just makes it angry.", "一击适足怒之。");
            // 穿场者
            AddTranslation("Warper", "越界");
            // 在其持牌人的回合结束时，[creature]将向右移动，穿过其路径上的任何造物，如果遇到场地边缘，它将回到最左侧。
            AddTranslation("At the end of its owner's turn, [creature] will move to the right, jumping over any creatures in its path, if it encounters the edge of the board, it will loop over to the other side.", "持牌者合终，[creature]右移，越其途诸物；遇局边，则环至彼端。");
            // 狂野饥饿
            AddTranslation("Wild hunger", "饕行");
            // 在持牌人的回合结束时，[creature]将按印记标注的方向移动，若在移动过程中遇到其他卡牌，[creature]将停止移动，被撞到的卡牌将消亡，并且[creature]将获得1点力量和1点生命。
            AddTranslation("At the end of its owner's turn, [creature] will move in the direction inscribed on the sigil, however if it hits a card whilst moving, [creature] will stop, the card it hit will perish and [creature] will gain 1+/1+.", "持牌者合终，[creature]循印所志而移；若移时触牌，则止，所触者死，而[creature]威命各益一。");
            // 凋零
            AddTranslation("Withering", "枯");
            // [creature]将在对手回合结束时消亡。
            AddTranslation("[creature] will perish at the end of the opponant's turn.", "[creature]于敌合终灭。");
            // 瘫痪之触
            AddTranslation("Zapper", "痹触");
            // 当[creature]对另一造物造成伤害时，该造物将获得瘫痪印记。瘫痪印记定义为：带有此印记的卡牌将每隔一回合攻击一次。
            AddTranslation("When [creature] damages another creature, that creature will gain the Paralysis Sigil. The Paralysis sigil is defined as: A card bearing this sigil will only attack every other turn.", "[creature]伤他物，则彼得瘫印。瘫印者：有此印之牌，隔合乃攻。");
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
        }
    }
}
