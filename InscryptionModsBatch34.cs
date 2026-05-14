using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch34
    {
        public static void RegisterTranslations()
        {
            RegisterAbilityBatchSeven();
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

        private static void RegisterAbilityBatchSeven()
        {
            // 当使用[creature]时，若路径未被阻挡，它将移动至对手侧牌桌。
            AddTranslation("When [creature] is played, it will move onto the opponent's side of the board if unobstructed.", "[creature]既陈，若路无阻，则移于敌侧。");
            // 狙击刺甲
            AddTranslation("Trajectile Quills", "射棘");
            // [creature]被攻击时，其持牌人可选定一个敌方造物造成1点伤害。
            AddTranslation("When [creature] is struck, an opponent creature of the owner's choosing is dealt 1 damage.", "[creature]受击，则其主可择一敌物，使之受1伤。");
            // 撼地者
            AddTranslation("Trampler", "蹂者");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动。沿途的卡牌会被击杀，并使印记持有者获得+1攻击力。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed on the sigil. Cards in the way will be killed, and grant +1 attack power to the sigil bearer.", "持牌者合终，[creature]循印所志而移。道中诸牌皆死，而此印之主威加1。");
            // 易形者
            AddTranslation("Transformer", "易形者");
            // 回合结束时，[creature]会在当前形态与转化形态间切换一次。
            AddTranslation("At the end of the turn, [creature] will transform to or from it's alternate form.", "合终，[creature]往来于本形与异形之间。");
            // 变形术
            AddTranslation("Transmogrification", "化形术");
            // 当[creature]攻击造物时，该造物会转变为另一种形态。
            AddTranslation("When [creature] strikes a creature, that creature will be changed into another form.", "[creature]击物，则彼物化为异形。");
            // 陷阱颚
            AddTranslation("Trapjaw", "阱颌");
            // 若对面位置的左右两侧被阻挡，[creature]会攻击这些位置；若未被阻挡，则攻击会转移至正对面的位置。
            AddTranslation("[creature] will attack to the left and the right of the opposing space if those slots are obstructed. If those slots are not obstructed, the strikes will be transferred to the directly opposing space.", "若对位之左右两格有阻，[creature]则击其二位；若无阻，则二击皆归正对之位。");
            // 精良祭品
            AddTranslation("Trifling Sacrifice", "二血祭");
            // [creature]在献祭时可算作2点血量，而非1点。
            AddTranslation("[creature] counts as 2 Blood rather than 1 Blood when sacrificed.", "[creature]见祀时，算2血，非1血。");
            // 禁忌三重奏
            AddTranslation("Trio", "三身");
            // 当打出[creature]时，会在其左右两侧各生成一张相同的卡牌。
            AddTranslation("When [creature] is played, a copy of it is created to the left and right.", "[creature]既陈，则其左右各生一副本。");
            // 三重攻击
            AddTranslation("Triple Strike", "三击");
            // [creature]会在攻击时额外攻击对面位置两次。
            AddTranslation("[creature] will strike the opposing space two extra times when attacking.", "[creature]攻时，于对位更加二击。");
            // 战利品猎手
            AddTranslation("Trophy Hunter", "猎魁");
            // [creature]攻击时会锁定对面力量最强的卡牌。
            AddTranslation("[creature] will target the most powerful opposing card when it attacks.", "[creature]攻时，专取对面威最强之牌。");
            // 缩滚乐
            AddTranslation("Tuck And Roll", "伏滚");
            // 战斗结束时，[creature]会移动到受攻击力最小的空闲位置，计算时考虑后排待命造物、飞行与死神之触。
            AddTranslation("At the end of combat, [creature] will move to the free space opposed by the least amount of attack power, taking into account queued creatures, flight, and Touch of Death.", "战终，[creature]移于受敌威最少之空位；其算兼后候之物、飞行与死触。");
            // 生拉硬拽
            AddTranslation("Tug", "曳");
            // 当打出[creature]时，若条件允许，它会将排队中的对方造物拖拽至正对面的主位置。
            AddTranslation("When [creature] is played, it will draw the queued opposing creature into the main opposing space, if possible.", "[creature]既陈，若可，则曳敌之后候之物至正对之主位。");
            // 双生契约
            AddTranslation("Twin Bond", "双契");
            // 当使用[creature]时，会在相邻位置生成其复制体（若无空位则消灭其他造物腾出空间）。这两张卡牌共享生命值，其中任意一张死亡时，另一张也会随之死亡。
            AddTranslation("When [creature] is played, a copy of it is created adjacent, killing other creatures to make room if there is none. These cards share a health pool, and when either card dies, it's twin will die as well.", "[creature]既陈，则邻位生其副本；无空则杀他物以腾地。二牌共一命池，其一死，则其双亦死。");
            // 星轮变换
            AddTranslation("Twister", "旋变");
            // 当[creature]受到攻击时，会在当前形态与另一形态间转换。
            AddTranslation("When struck, [creature] will transform to or from it's alternate form.", "[creature]受击，则往来于本形与异形之间。");
            // 失衡领袖
            AddTranslation("Unbalanced Leadership", "偏帅");
            // [creature]左侧相邻的造物获得2点力量。
            AddTranslation("The creature directly to the left of [creature] gains 2 power.", "[creature]左邻之物威加2。");
            // 压力之下
            AddTranslation("Under Pressure", "压裂");
            // 当[creature]阵亡时，对正对面的造物造成2点伤害。此外，当[creature]阵亡时，所有相邻且带有该印记的造物均会受到10点伤害。
            AddTranslation("When [creature] perishes, 2 damage is dealt to the opponent creature. Also, when [creature] perishes, any adjacent creatures with this sigil also take ten damage.", "[creature]死，则对位之物受2伤。且凡相邻而负此印之物，亦受10伤。");
            // [creature]爆裂，对正对面的造物造成2点伤害！
            AddTranslation("[creature] pops, dealing 2 damage to the opposing creature!", "[creature]爆裂，而对位之物受2伤！");
            // 胡乱打击
            AddTranslation("Unfocused Strike", "妄击");
            // [creature]攻击时会随机选择一个目标位置。
            AddTranslation("[creature] will target a random space when it attacks.", "[creature]攻时随机取一位。");
            // 不可锤击
            AddTranslation("Unhammerable", "不可锤");
            // [creature]无法被锤子击杀
            AddTranslation("[creature] cannot be killed using the hammer.", "[creature]不可为锤所杀。");
            // 命途多舛
            AddTranslation("Unlucky", "薄命");
            // 当[creature]存活于牌桌时，对手打出的卡牌有几率被削弱状态值或随机失去一个印记。
            AddTranslation("While [creature] is alive on the board, cards played by the opponent have a chance to have debuffed stats, or lose a random sigil.", "[creature]存于场，则敌所陈之牌有几率削其威命，抑失一随机之印。");
            // 不可言喻
            AddTranslation("Unspeakable", "不可言");
            // 当你打出的卡牌未经手牌使用便结算至牌桌时，可选择从手牌或牌组中打出[creature]替代。
            AddTranslation("When a card you control resolves on the board without being played from your hand, you may choose to play [creature] from your hand or deck instead.", "凡汝所御之牌，未由手陈而见结于场时，可择自手抑自牌列改陈[creature]。");
            // 不稳定宝石
            AddTranslation("Unstable Gems", "危玉");
            // 当[creature]在场时，所有以玛珂宝石为费用的友方造物在打出时将获得脆骨印记。
            AddTranslation("While [creature] is on the board, all friendly creatures which cost a mox gem will gain the brittle sigil when played.", "[creature]在场，则凡费玛珂之友物，既陈时皆得脆骨印。");
            // [creature]使需要宝石的造物变得不稳定！
            AddTranslation("[creature] renders the gem cost creature unstable!", "[creature]使费玉之物危矣！");
            // 吉光片羽
            AddTranslation("Valuable", "值金");
            // [creature]阵亡时将给予一定数量的货币。
            AddTranslation("[creature] will grant an amount of currency when it perishes.", "[creature]死，则授若干之货。");
            // 吸血鬼
            AddTranslation("Vampiric", "饮血");
            // 当[creature]击杀对面造物时，可增加1点生命。
            AddTranslation("When [creature] attacks an opposing creature and it perishes, this card gains 1 health.", "[creature]攻敌物而杀之，则此牌命加1。");
            // 易形猎手
            AddTranslation("Venator", "猎变");
            // 当[creature]击杀另一只造物时，会在当前形态与第二形态间切换。
            AddTranslation("When [creature] kills another creature, it will transform to or from it's alternate form.", "[creature]杀一物，则往来于本形与异形之间。");
            // 容器掉落
            AddTranslation("Vessel Shedder", "遗皿");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在原地留下一个空容器。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscrybed in the sigil and drop an Empty Vessel in its old place.", "持牌者合终，[creature]循印所志而移，并于故处遗一空皿。");
            // 感官异能
            AddTranslation("Visceral", "余血化骨");
            // 当[creature]被献祭时，未被消耗的剩余血量将转化为骨头。
            AddTranslation("When [creature] is sacrificed, any leftover blood that is not used for the sacrifice will be converted into bones.", "[creature]见祀，则其未尽之余血化为骨。");
            // 革命万岁
            AddTranslation("Viva La Revolution", "变革万岁");
            // 在持牌人回合开始时，[creature]会使牌桌上所有造物顺时针旋转。此外，[creature]不会攻击其原主人。
            AddTranslation("At the start of its owners turn, [creature] will revolve all creatures on the board clockwise. Also, [creature] will not attack it's original owner.", "其主持合始，[creature]使场上诸物皆顺时而旋。且[creature]不攻其故主。");
            // 水鸟
            AddTranslation("Waterbird", "水禽");
            // 若[creature]攻击的位置有潜水的造物，该造物会浮出水面，[creature]将转而攻击它而非直接攻击。
            AddTranslation("If [creature] strikes a slot containing a submerged creature, that creature will re-emerge and [creature] will attack it instead of attacking directly.", "若[creature]所击之位有潜物，则彼物出水，[creature]转而击之，不复直攻。");
            // 摇摆打击
            AddTranslation("Wavering Strike", "摆击");
            // [creature]会在每回合结束时交替攻击原本攻击位置的左侧或右侧。
            AddTranslation("[creature] will alternate between striking to the left or right of where it would otherwise attack at the end of each turn.", "[creature]每合终交替而击其本所攻位之左，抑其右。");
            // 织网者
            AddTranslation("Weaver", "织者");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在原地留下一张蛛网。[creature]可以重新移动到自己放置的蛛网上。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed on the sigil and leave a Web in it's old space. [creature] can move back over webs it has placed.", "持牌者合终，[creature]循印所志而移，并于故处留一网。[creature]可复移于自所置之网。");
            // 昆虫类族群的造物不会攻击[creature]。
            AddTranslation("Creatures in the insect tribe will not attack [creature].", "虫族之物不攻[creature]。");
            // 无形传花
            AddTranslation("Weird Latch", "怪传花");
            // 抽到[creature]时，此印记将被随机替换为某个传花类印记。
            AddTranslation("When [creature] is drawn, this sigil is replaced by a random latch sigil.", "[creature]既引，则此印随机易为一传花印。");
            // 狂野易形
            AddTranslation("Wild Shape", "野形");
            // 当使用[creature]时，它会根据持牌人提供的宝石颜色进行变形。
            AddTranslation("When [creature] is played, it transforms based on what gem colours its owner controls.", "[creature]既陈，则因其主持有之宝石颜色而变形。");
            // [creature]会根据持牌人的宝石进行变形……
            AddTranslation("[creature] transforms based on its owner's gems...", "[creature]因其主之宝石而变形……");
            // 怯战
            AddTranslation("Wimpy", "怯弱");
            // [creature]对造物造成伤害时，实际伤害值总会比应有值少1点。
            AddTranslation("When [creature] deals damage to a creature, it will always deal 1 less damage than it should.", "[creature]伤物时，所成之伤恒少其应有者1。");
            // 碎翼者
            AddTranslation("Wing Clipper", "翦翼者");
            // 当[creature]入场时，所有带有空袭印记的敌方造物将失去该印记。
            AddTranslation("When [creature] is played, all opponent creatures with the Airborne sigil lose the Airborne sigil.", "[creature]既陈，凡敌物负空袭印者，皆失其印。");
            // [creature]让所有对手落地了！
            AddTranslation("[creature] grounds all its opponents!", "[creature]使群敌皆坠地矣！");
            // 骑翼者
            AddTranslation("Wingrider", "乘翼者");
            // 如果一张友方飞行造物在持牌人手中使用，则若[creature]位于手牌中，该卡牌会自动部署至其相邻位置。
            AddTranslation("If a friendly airborne creature is played while [creature] is in the owner's hand, this card will be played adjacent to it.", "若友方飞物既陈而[creature]在主手中，则此牌自陈于其邻位。");
            // 法树领主
            AddTranslation("Woodsie Lord", "术松主");
            // 使用[creature]时，所有空位将生成附魔松树。附魔松树具有：0点力量、3点生命。
            AddTranslation("When [creature] is played, Enchanted Pines are created on every empty space. An enchanted pine is defined as 0 power, 3 health.", "[creature]既陈，诸空位皆生附魔松。附魔松者：0威、3命。");
            // 蠕形螨动
            AddTranslation("Wriggle", "蠕动");
            // 当使用[creature]时，会对所有敌方造物造成1点伤害。
            AddTranslation("When [creature] is played it deals 1 damage to all opponent creatures.", "[creature]既陈，则敌方诸物皆受1伤。");
            // 垂死挣扎
            AddTranslation("Writhe", "挣命");
        }
    }
}
