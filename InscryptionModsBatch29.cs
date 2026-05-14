using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch29
    {
        public static void RegisterTranslations()
        {
            RegisterAbilityBatchTwo();
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

        private static void RegisterAbilityBatchTwo()
        {
            // 酥脆
            AddTranslation("Crunchy", "脆");
            // 当[creature]被献祭时，将为持牌人产生1根骨头。
            AddTranslation("When [creature] is sacrificed, it generates one bone for its owner.", "[creature]见祀，则为其主生1骨。");
            // 可爱
            AddTranslation("Cute", "可人");
            // 攻击[creature]的造物会产生愧疚感，并跳过下一次攻击。
            AddTranslation("Creatures that strike [creature] feel guilty, and will skip their next strike.", "击[creature]之物怀愧，而后一击遂阙。");
            // 数据泄露
            AddTranslation("Data Breach", "泄机");
            // 当[creature]阵亡时，其持牌人必须从牌组抽一张牌并立即弃置。对手将受到等同于所抽卡牌攻击力的伤害
            AddTranslation("When [creature] perishes, its owner must draw a card from their deck and immediately discard it. The opponent is dealt damage equal to the drawn creatures attack power.", "[creature]死，则其主自牌列引一牌而立弃之。敌受其所引物威数之伤。");
            // 死铃使者
            AddTranslation("Deadringer", "死铃");
            // 当[creature]存活且在牌桌上时，若其力量低于5点，每次铃响可使其增加1点力量。
            AddTranslation("While [creature] is alive and on the board, it gains +1 power each time the bell is rung, if it has less than 5 power.", "[creature]存于场而威未满5，则每铃鸣加1威。");
            // [creature]的力量提升了
            AddTranslation("[creature] powers up!", "[creature]威益矣！");
            // 死亡掠夺
            AddTranslation("Death Snatch", "死掠");
            // 当[creature]阵亡时，从你的牌组中抽一张牌。
            AddTranslation("When [creature] perishes, draw a card from your deck.", "[creature]死，则自乃牌列引一牌。");
            // 全副武装
            AddTranslation("Decked Out", "具装");
            // 当[creature]受到攻击时，会从随机神殿的副牌组中抽取一张牌加入你的手牌。
            AddTranslation("When [creature] is struck, a card from a random temple's side deck is created in your hand.", "[creature]受击，则自随机神殿之副牌生一牌于汝手。");
            // 污染者
            AddTranslation("Defiler", "污者");
            // 当[creature]阵亡时，其持牌人必须从牌组抽一张牌并立即弃置。
            AddTranslation("When [creature] perishes, its owner must draw a card from their deck and immediately discard it.", "[creature]死，则其主自牌列引一牌而立弃之。");
            // 孤注一掷
            AddTranslation("Desperate", "穷搏");
            // [creature]阵亡时对对手造成1点伤害。
            AddTranslation("When [creature] perishes, it deals one point of damage to the opponent.", "[creature]死，则遗1伤于敌。");
            // [creature]在阵亡时造成了1点额外伤害。
            AddTranslation("[creature] deals a free point of damage as it perishes.", "[creature]死而遗1伤于敌。");
            // 鹿神敬拜
            AddTranslation("Deus Hoof", "鹿神");
            // 当[creature]在场时，所有友方有蹄类造物获得+1力量和生命。此外，所有有蹄类造物会攻击任何袭击[creature]的目标。
            AddTranslation("All friendly hooved creatures gain +1 Power and Health while [creature] is on the board. Also, all hooved creatures will attack anything that strikes [creature].", "[creature]在场，则诸有蹄之友物皆加1威1命。凡击[creature]者，亦为诸蹄物所攻。");
            // 右前打击
            AddTranslation("Dexter Strike", "右前击");
            // [creature]攻击时会同时攻击正对面位置右侧的格子。
            AddTranslation("[creature] will also strike the slot to the right of the opposing slot when it attacks.", "[creature]攻时，亦击对位之右格。");
            // 对角打击
            AddTranslation("Diagonal Strike", "斜击");
            // 当[creature]攻击时，会优先攻击原目标左侧或右侧存在造物的位置。若两侧均有或均无造物，则随机选择左侧或右侧攻击。
            AddTranslation("When [creature] attacks, it will strike either to the left or right of its original target, prioritising striking slots containing creatures. If both or neither slots adjacent to the target contain creatures, [creature] will attack to the left or right at random.", "[creature]攻时，或击其本的之左，或击其右，先择有物者。若两侧俱有，抑俱无，则左右随机。");
            // 开膛破肚
            AddTranslation("Disembowel", "剖腹");
            // 当[creature]被献祭时，其持牌者手牌中将生成等同于剩余生命值的内脏。
            AddTranslation("When [creature] is sacrificed, an amount of guts equal to its remaining health are created in its owners hand.", "[creature]见祀，则其主手中生脏，如其余命之数。");
            // [creature]的内脏爆裂到你手中。
            AddTranslation("[creature]s guts explode into your hands.", "[creature]之脏迸入汝手。");
            // 魂不守舍
            AddTranslation("Distraction", "诱替");
            // 当[creature]可能受到攻击时，会在原地留下分心物，[creature]自身则向右移动。
            AddTranslation("When [creature] would be struck, a distraction is left in its place and [creature] moves to the right.", "[creature]将受击，则留一诱物于故处，而自身右移。");
            // 潜行者
            AddTranslation("Diver", "潜者");
            // [creature]可以直接攻击对位处于潜水状态的卡牌。
            AddTranslation("[creature] can strike the opposing card even while it is submerged.", "[creature]虽对位潜伏，亦可击之。");
            // 当[creature]存活且在牌桌上时，下一张抽到的卡牌将被复制。
            AddTranslation("The next card drawn while [creature] is alive and on the board will be duplicated.", "[creature]存于场，则后所引之牌将见复制。");
            // 可除性打击
            AddTranslation("Divisibility Strike", "奇偶击");
            // 每回合结束时，[creature]会交替攻击所有奇数编号和偶数编号的对手位置。
            AddTranslation("At the end of each turn, [creature] will alternate between striking all odd indexed opponent slots, and all even indexed opponent slots.", "每合终，[creature]交替击敌侧诸奇列与诸偶列。");
            // 温顺
            AddTranslation("Docile", "驯");
            // [creature]需等待固定回合数才能再次攻击。
            AddTranslation("[creature] will wait a set number of turns in between being allowed to attack.", "[creature]每攻之间，须俟定数之合。");
            // 命定者
            AddTranslation("Doomed", "定死");
            // 回合结束时，[creature]会阵亡。
            AddTranslation("At the end of the turn, [creature] will perish.", "合终，[creature]死。");
            // 协同攻击
            AddTranslation("Double Tap", "并击");
            // 当友方造物攻击敌方造物时，[creature]也会对该敌方造物发起攻击。
            AddTranslation("When a friendly creature strikes an opponent creature, [creature] will also attack that opponent creature.", "友物攻敌物时，[creature]亦攻彼物。");
            // [creature]在战斗中支援它的战友！
            AddTranslation("[creature] aids its comrades in battle!", "[creature]助其同袍战矣！");
            // 下沉气流
            AddTranslation("Downdraft", "下风");
            // [creature]会赋予左右两侧造物飞行能力。
            AddTranslation("[creature] will grant the power of flight to creatures to it's left and right.", "[creature]授其左右之物以飞。");
            // 绘牌之手
            AddTranslation("Draw", "引");
            // 当使用[creature]时，其持有者将抽取等同于该印记所示数量的卡牌。
            AddTranslation("When [creature] is played, its owner draws cards equal to the number inscribed on this sigil.", "[creature]既陈，其主引牌，如印所书之数。");
            // 流连
            AddTranslation("Dripping", "滴行");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在移动轨迹上留下部分躯体。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil and leave part of it's own body in it's wake.", "持牌者合终，[creature]循印所志而移，并遗其身之一分于行迹。");
            // 得手投弃
            AddTranslation("Drop", "引即陈");
            // 若[creature]作为初始手牌被抽到，将免费自动部署在随机空位。
            AddTranslation("If[creature] is drawn as part of your opening hand, it will be automatically played on a random board space for free.", "若[creature]为开局手牌所引，则免费自陈于随机空位。");
            // 使用[creature]时，你可在牌组中搜索任意卡牌并在手牌中生成其复制品。
            AddTranslation("When [creature] is played, you may search your deck for any card and create a duplicate of it in your hand.", "[creature]既陈，汝可于牌列索任一牌，并生其副本于手。");
            // 双重奏
            AddTranslation("Duppelgang", "双影");
            // 使用[creature]时，从牌组中抽取与其相邻卡牌的复制品加入手牌。
            AddTranslation("When [creature] is played, draw copies of cards adjacent to it from your deck to your hand.", "[creature]既陈，自牌列引其邻牌之副本入手。");
            // 渴望
            AddTranslation("Eager", "亟");
            // [creature]在牌桌上的首个回合内将获得+2力量。
            AddTranslation("[creature] will gain +2 power for the duration of it's first turn on the board.", "[creature]在场之初合，威加2。");
            // 轻而易举
            AddTranslation("Easy Pickings", "易取");
            // 当[creature]入场时，牌桌上所有生命值为1的造物将立即阵亡。
            AddTranslation("When [creature] is played, all other creatures on the board with 1 health will perish.", "[creature]既陈，场上一切命为1之物皆立死。");
            // 脱胎换骨
            AddTranslation("Emancipation", "脱化");
            // 使用[creature]时，持牌人拥有的所有瓶中卡牌会复制到其手牌中。
            AddTranslation("When [creature] is played, copies of any bottled cards the owner possesses are created in the owner's hand.", "[creature]既陈，则其主持有之诸瓶牌，皆生副本于手。");
            // 绿宝石核芯
            AddTranslation("Emerald Core", "绿玉核");
            // 当[creature]阵亡时，会在原地生成一个绿宝石容器。
            AddTranslation("When [creature] perishes, an Emerald Vessel is created in its place.", "[creature]死，则其处生一绿玉皿。");
            // 绿宝石之心
            AddTranslation("Emerald Heart", "绿玉心");
            // 当[creature]阵亡时，会在原地生成一张绿宝石玛珂。
            AddTranslation("When [creature] perishes, an Emerald Mox is created in its place.", "[creature]死，则其处生一绿玉玛珂。");
            // 附魔
            AddTranslation("Enchanting", "赋印");
            // 使用[creature]时，你打出的所有造物将随机获得它的一个其他印记。
            AddTranslation("When [creature] is played, all creatures you control gain one of its other sigils, at random.", "[creature]既陈，则汝所御诸物随机得其一他印。");
            // 濒危
            AddTranslation("Endangered", "垂危");
            // 回合结束时，[creature]有25%概率阵亡。
            AddTranslation("At the end of the turn, [creature] has a one in four chance to perish.", "合终，[creature]有四分之一之几而死。");
            // 敌军战线
            AddTranslation("Enemy Lines", "敌阵");
            // [creature]攻击时，会锁定所有非正对位置的敌方空位。
            AddTranslation("When [creature] attacks, it will target all opponent slots that it is NOT directly opposing.", "[creature]攻时，凡非其正对之敌位，皆为所向。");
            // 能量依赖
            AddTranslation("Energy Dependent", "恃能");
            // 若使用者能量为0，[creature]将阵亡。
            AddTranslation("If the user has 0 Energy, [creature] will perish.", "若其主之能为0，[creature]死。");
            // 愤怒
            AddTranslation("Enraged", "愤");
            // 当[creature]被攻击时，获得1点力量。
            AddTranslation("When [creature] is struck, it gains 1 attack power.", "[creature]受击，则威加1。");
            // 盘根错节
            AddTranslation("Entangle", "缠");
            // [creature]阵亡时，击杀者力量减半（向下取整）并持续一回合。
            AddTranslation("When [creature] perishes, its killer has their power reduced by half and rounded down for one turn.", "[creature]死，则杀之者威半减，取下而止于一合。");
            // 飘忽不定
            AddTranslation("Erratic", "无恒");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动。若目标格位被阻挡则不会移动。每次移动后有50%概率改变方向。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed on the sigil. It will not move if the target slot is obstructed. Direction has a 50/50 chance to change after moving.", "持牌者合终，[creature]循印所志而移。若前格有阻，则不移；每移之后，有半几改其向。");
            // 团队精神
            AddTranslation("Esprit De Corps", "同心");
            // 当[creature]在牌桌上时，同侧最左与最右位置的造物增加1点力量。
            AddTranslation("While [creature] is on the board, creatures in the leftmost and rightmost slots on the same side of the board gain 1 power.", "[creature]在场，则同侧最左与最右之物威加1。");
            // 当[creature]存活于牌桌上时，其持牌人不会受到致命伤害。
            AddTranslation("While[creature] is alive and on the board, its owner may not take fatal damage.", "[creature]存于场，则其主不受致死之伤。");
            // 偶数打击
            AddTranslation("Even Strike", "偶列击");
            // [creature]攻击时会打击所有偶数索引列的对面位置。列索引从左至右计数，起始值为1。
            AddTranslation("[creature] will strike all opposing spaces in even indexed columns when it attacks. Column index is counted from the left, starting at 1.", "[creature]攻时，凡敌侧偶列之位皆击之。列数自左计，始于1。");
            // 传说祭品
            AddTranslation("Exceptional Sacrifice", "奇祭");
        }
    }
}
