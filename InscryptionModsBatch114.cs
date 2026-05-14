using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch114
    {
        public static void RegisterTranslations()
        {
            RegisterRevenantThree();
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

        private static void RegisterRevenantThree()
        {
            // 荒弃凄凉，这座村落正盼着新住民，来填满它破败的屋舍。
            AddTranslation("Abandoned and forlorn, this village seeks new residents to fill its decrepit homes.", "既荒且凉，此村求新居者，以充其败屋。");
            // 每一座城镇，每一方都市，总有人要负责埋葬逝者。而终有一日，他们也会被葬入黄土。
            AddTranslation("In every town, in every city, someone must work to bury the dead. In time, they too will be buried.", "凡邑与都，必有人埋死者。及其时也，彼亦将见埋。");
            // 骸骨博士
            AddTranslation("Dr.Bones", "骨博士");
            // 杀不死你的东西，只会让你变得更清醒。
            AddTranslation("Whatever doesn't kill you simply makes you, saner.", "凡不能杀汝者，徒使汝更醒耳。");
            // 温迪戈
            AddTranslation("Wendigo", "温迪戈");
            // 自荒莽野地归来，倒让我想起一位故人。
            AddTranslation("Returned from the deep wilds, reminds me of a friend.", "自荒野深处归，使我忆一故人。");
            // 赢先生
            AddTranslation("Mister Win", "赢先生");
            // 一张致胜的牌。它永远立于不败之地。这便是它得名赢先生的缘由。
            AddTranslation("A card that wins. It always wins. That's why it's called Mister Win.", "一能胜之牌也。彼恒胜，故曰赢先生。");
            // 恐怕，并非那一张。
            AddTranslation("Not that one, I'm afraid.", "恐非此张。");
            // 你……你这个杀人如麻的怪物。
            AddTranslation("You... you murderous monster.", "汝……汝此嗜杀之怪。");
            // 哦，天哪……灾祸的洪流必将追赶你。
            AddTranslation("Oh Dear... The flow of Calamity will pursue you.", "噫……灾流必逐汝。");
            // 夷平你曾居住的村子。
            AddTranslation("Hecatomb the village you once lived.", "夷汝昔所居之村。");
            // 寻找那把能一直挖下去的铲子。
            AddTranslation("Seak for the shovel that digs forever.", "求其永掘之锸。");
            // 然后把那个手里拿着火花的失踪者带给我。
            AddTranslation("Bring me the lost one with a spark in hand.", "执火星之失者，携以来我。");
            // 经由古老存在的召唤，
            AddTranslation("Compelled by the beckoning of an ancient entity,", "为古物所招，");
            // 一场禁忌的仪式已经开始。
            AddTranslation("a forbidden ritual has been initiated.", "禁仪既作矣。");
            // 痛苦传到了古老的死亡巨蛇耳中。
            AddTranslation("The pain reaches the ancient great serpent of death.", "其痛达于上古死巨蛇。");
            // 你必须做出牺牲。
            AddTranslation("Sacrifices must be made.", "汝必须行牺牲。");
            // 哦……目前还没有死亡卡。
            AddTranslation("Oh... There are no dead cards yet.", "噫……今尚无死牌。");
            // 复生亡灵模组卡包
            AddTranslation("Revenant Mod Card Pack", "复生亡灵补缀牌韬");
            // 这套卡牌主要由一些能以各种方式返回玩家手中的卡牌组成。
            AddTranslation("This card pack consists of mainly cards that return to the player in a variety of ways.", "此牌韬多由能以诸途反归戏徒手中之牌成。");
            // 皮皮蛋
            AddTranslation("Pipis", "皮皮蛋");
            // 皮皮蛋。
            AddTranslation("Pipis.", "皮皮蛋。");
            // 帮助
            AddTranslation("Help", "援");
            // 持牌人的回合结束时，将牺牲自身，令相邻的卡牌各回复1点生命值。
            AddTranslation("At the end of the owner's turn [creature] will sacrifice itself to heal the adjacent cards by 1.", "持者合终，[creature]自祀，以疗相邻诸牌各一命。");
            // 畅通无阻
            AddTranslation("Pass-through", "洞彻");
            // 当即将被攻击力高于自身生命值的卡牌攻击时，此牌将消亡。
            AddTranslation("When [creature] is about to get attacked by a card with an attack higher than this card's health, this card perishes.", "[creature]将为一威高于此牌命之牌所攻时，此牌即死。");
            // 骚扰电话
            AddTranslation("Spam Call", "扰讯");
            // 当构成完整回路时，其回路内的空位将于持牌人回合结束时生成垃圾邮件卡牌。
            AddTranslation("Empty spaces within a circuit completed by [creature] spawn Spam Mail at the end of the owner's turn.", "[creature]若成完路，则路中空位于持者合终生垃圾邮件牌。");
            // NEO打击
            AddTranslation("NEO Strike", "NEO击");
            // 将攻击敌方所有有造物占据的格子，以及场地边缘所有有造物占据的区域。若未遭遇任何敌方造物，则会发起一次直接攻击。
            AddTranslation("[creature] will strike each opposing space that is occupied by a creature and additionally every side of the board occupied by a creature. It will strike directly if no creatures oppose it.", "[creature]将击敌侧凡有物所据之位，并局侧凡有物所据之处。敌前无物，则直击。");
            // 求救电话
            AddTranslation("A Call for Help", "呼援");
            // 持牌人的回合结束时，将发起求救电话。
            AddTranslation("At the end of the owner's turn, [creature] will call for help.", "持者合终，[creature]将呼援。");
            // 奋勇突进
            AddTranslation("Run Forth", "前赴");
            // 发起攻击前，其攻击力将被设定为至少1点。
            AddTranslation("Before [creature] attacks, its power will be set to at least 1.", "[creature]攻前，其威至少为一。");
            // 飞行头颅
            AddTranslation("Flying Head", "飞颅");
            // 最为关键的部分。
            AddTranslation("The most important part.", "最要者也。");
            // 垃圾邮车
            AddTranslation("Spam Cart", "垃圾邮车");
            // 垃圾邮件充盈其身，可吞噬各类攻势。
            AddTranslation("Filled with spam mail. Absorbs all kinds of attacks.", "满载垃圾邮件，能受诸攻。");
            // 垃圾邮件
            AddTranslation("Spam Mail", "垃圾邮件");
            // 囊括各类令人印象深刻的交易。
            AddTranslation("Has all kinds of unforgettable deals.", "有诸不忘之贾。");
            // 重炮手
            AddTranslation("Big Shooter", "重炮手");
            // 发射重磅弹药。
            AddTranslation("Shoots big shots.", "发重弹。");
            // 链锁之心
            AddTranslation("Heart on a Chain", "链心");
            // 美丽。
            AddTranslation("Beautiful.", "美。");
            // 扰讯凝胶
            AddTranslation("Spamgel", "扰讯胶");
            // 按F1触发效果。
            AddTranslation("The result of pressing F1.", "按F1之效也。");
            // 手机
            AddTranslation("Hand Phone", "手机");
            // 你真的还需要其他人吗？
            AddTranslation("Do you really need anyone else?", "汝真复须他人乎？");
            // NEO之力！！！
            AddTranslation("THE POWER OF NEO!!!", "NEO之力！！！");
            // 你难道不想成为大人物吗？
            AddTranslation("Don't you wanna be a big shot?", "汝不欲为巨擘乎？");
            // 通讯设备
            AddTranslation("Receiver", "受讯器");
            // 那道声音终将消逝。
            AddTranslation("The voice runs out eventually.", "其声终尽。");
            // 灰熊特惠符
            AddTranslation("Grizzlipis", "灰熊特惠符");
            // 灰熊特惠符。
            AddTranslation("Grizzlipis.", "灰熊特惠符。");
            // 灰熊货车
            AddTranslation("Bear Cart", "熊车");
            // 满载熊群，可吸收各类攻击。
            AddTranslation("Filled with bears. Absorbs all kinds of attacks.", "满载熊群，能受诸攻。");
            // 灰熊邮件
            AddTranslation("Bear Mail", "熊邮");
            // 给熊的邮件。
            AddTranslation("Mail for bears.", "致熊之邮。");
            // 缚链之熊
            AddTranslation("Bear on a Chain", "链熊");
            // 熊掌
            AddTranslation("Bear Hand", "熊掌");
            // 松鼠炸弹
            AddTranslation("Squirrel Bomb", "松鼠炸弹");
            // 松鼠被击杀时会爆炸，对相邻卡牌造成10点伤害。
            AddTranslation("Squirrels explode when killed, dealing 10 damage to adjacent cards.", "松鼠既死则爆，伤相邻诸牌十。");
            // 舞会
            AddTranslation("Dance Party", "舞会");
        }
    }
}
