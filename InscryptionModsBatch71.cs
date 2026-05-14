using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch71
    {
        public static void RegisterTranslations()
        {
            RegisterCursesAndGhostEvents();
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

        private static void RegisterCursesAndGhostEvents()
        {
            // 巨型鲨鱼
            AddTranslation("Mega Shark", "巨鲨");
            // 囫囵吞
            AddTranslation("Swallow Whole", "并吞");
            // 炸药！？
            AddTranslation("Dynamite!?", "火药！？");
            // 诱杀装置
            AddTranslation("Booby Trap", "伏爆");
            // 如果此牌在你回合结束时在你手中，它会爆炸。如果它在你对手的回合结束时在场地上，它会爆炸。不管怎样，它都会爆炸。
            AddTranslation("If this is in your hand at the end of your turn, it explodes. If it is on the board at the end of your opponent's turn, it explodes. Either way, it explodes.", "若此牌于汝合终在手，则爆；若于敌合终在局，亦爆。无论何如，皆爆。");
            // 这比预期的要困难得多……
            AddTranslation("This is more difficult than anticipated...", "此较所料难多矣……");
            // 我…我们可能让事情变得更糟了
            AddTranslation("We - We may have made things worse", "我……我等或使事愈恶矣");
            // 被诅咒的成就
            AddTranslation("Cursed Achievements", "诅成");
            // 玩得开心
            AddTranslation("Here For A Good Time", "为乐而来");
            // 以负挑战点数完成冒险。
            AddTranslation("Complete a run with a negative challenge level", "负角值而竟一局。");
            // 艰难时光
            AddTranslation("Here For A Hard Time", "为苦而来");
            // 完成挑战点数高于250的冒险。
            AddTranslation("Complete a run with a challenge level above 250", "角值逾二百五十，而竟一局。");
            // 彻底疯狂
            AddTranslation("Utter Insanity", "狂极");
            // 在激活两个“混乱的敌人”挑战头骨的情况下完成冒险。
            AddTranslation("Complete a run with two Chaotic Enemy skulls active", "启二“乱敌”髑而竟一局。");
            // 太恐怖了
            AddTranslation("Too Spooky", "魂甚");
            // 达到死亡卡鬼魂级别上限。
            AddTranslation("Reach the maximum deathcard haunt level", "至死牌缠级之极。");
            // 那不是月亮
            AddTranslation("That's No Moon", "非月也");
            // 激活“满月”挑战头骨并击败柠檬琴号。
            AddTranslation("Defeat the Limoncello with the Bigger Moon skull active", "启“满月”髑而败柠檬琴号。");
            // 不过皮肉伤
            AddTranslation("'Tis But A Flesh Wound", "皮伤耳");
            // 从巨型鲨鱼口中取回一张损坏的卡牌。
            AddTranslation("Retrieve a damaged card from the belly of a Mega Shark", "自巨鲨腹中取一伤牌。");
            // 弹药专家
            AddTranslation("Munitions Expert", "爆药师");
            // 安全地处理炸药。
            AddTranslation("Safely dispose of a stick of dynamite", "安处一枝火药。");
            // 满月
            AddTranslation("Full Moon", "满月");
            // 类似月亮的巨人卡有更多的攻击力和生命值。
            AddTranslation("Giant cards like the moon have more attack and health", "巨牌若月者，其威命更众。");
            // 骨王之惠
            AddTranslation("Minor Boon of the Bone Lord", "骨王小惠");
            // 在拥有骨王之惠的情况下开始游戏。
            AddTranslation("Start the game with a Minor Boon of the Bone Lord", "以骨王小惠而局始。");
            // 检查是否应该添加死亡卡……
            AddTranslation("Checking to see if we should add a deathcard...", "察其可加死牌否……");
            // 阴魂不散的过去
            AddTranslation("Haunted Past", "旧魂来缠");
            // 死亡卡有时会在敌对战斗中出现。
            AddTranslation("Deathcards will sometimes attack you in battle", "死牌有时将于战中犯汝。");
            // 爆炸卡牌
            AddTranslation("Exploding Cards", "爆牌");
            // 每次头目战斗结束，一张炸药都会被添加到你的牌组中。
            AddTranslation("Dynamite is added to your deck after every boss battle", "每魁战既毕，火药一枚入汝牌列。");
            // 黄金起始
            AddTranslation("Golden Beginnings", "金始");
            // 开始游戏时，可以抽取一张稀有卡牌。
            AddTranslation("Start the game with the ability to draft a rare card", "局始得择一稀牌。");
            // 头目复仇战
            AddTranslation("Boss Revenge", "魁复");
            // 每个头目都有一个额外阶段。
            AddTranslation("Each boss has an additional phase", "诸魁皆有别一段。");
            // 至少二回合
            AddTranslation("Two Turn Minimum", "至少二合");
            // 你不能在第一回合造成致命伤害。
            AddTranslation("You cannot deal lethal damage on the first turn.", "初合不得致死。");
            // 混乱的敌人
            AddTranslation("Chaotic Enemies", "乱敌");
            // 敌方造物获得随机印记。
            AddTranslation("Opposing creatures gain random abilities", "敌物得偶印技。");
            // 图腾收藏家
            AddTranslation("Totem Collector", "图腾藏者");
            // 你开局获得所有族群的图腾头部。
            AddTranslation("You start with all tribal totem tops", "局始得诸属图腾之首。");
            // 额外蜡烛
            AddTranslation("Extra Candle", "别烛");
            // 你被赋予了额外的生命。
            AddTranslation("You are given an extra life", "汝得别一命。");
            // 你感到空气中弥漫着寒意
            AddTranslation("you feel a chill in the air", "汝觉风气寒然。");
            // 你后颈的汗毛竖了起来
            AddTranslation("the hair stands up on the back of your neck", "汝后项之毛竖矣。");
            // [v:0]已降临
            AddTranslation("[c:bR][v:0][c:] has arrived", "[c:bR][v:0][c:]已至。");
            // 你突然感到虚弱
            AddTranslation("you suddenly feel weak", "汝忽觉羸。");
            // 你的牙齿开始打颤
            AddTranslation("your teeth start to chatter", "汝齿始战。");
            // [v:0]正在逼近
            AddTranslation("[c:bR][v:0][c:] is coming", "[c:bR][v:0][c:]方逼。");
            // 你无法解释缘由
            AddTranslation("you can't explain how", "汝不能言其故。");
            // 但你能感受到[v:0]的存在
            AddTranslation("but you can feel the presence of [c:bR][v:0][c:]", "然汝觉[c:bR][v:0][c:]在焉。");
            // 终于来了：[v:0]现身了
            AddTranslation("it finally happened: [c:bR][v:0][c:] is here", "其终至矣：[c:bR][v:0][c:]在此。");
            // “我一直在找你”幽灵低语道
            AddTranslation("[c:O]\"I have been looking for you\"[c:] says the apparition", "[c:O]“吾求汝久矣”[c:]鬼影曰。");
            // “现在你该死了！”
            AddTranslation("[c:O]\"And now you must die!\"[c:]", "[c:O]“今汝当死！”[c:]");
            // 幽灵沉默不语
            AddTranslation("the apparition has nothing to say", "鬼影默然。");
            // 但你知道它是冲你而来
            AddTranslation("but you sense that it is here for you", "然汝知其为汝而来。");
            // “你来错地方了”它低吼道
            AddTranslation("[c:O]\"you made a mistake coming here\"[c:] it growls", "[c:O]“汝来此误矣”[c:]其吼曰。");
            // “让我带你回家”
            AddTranslation("[c:O]\"let me show you the way home\"[c:]", "[c:O]“吾将导汝归”[c:]");
            // 幽灵显得孤寂
            AddTranslation("the apparition seems lonely", "鬼影若孤。");
            // 它想让你在死后世界陪伴它
            AddTranslation("it wants you to join it in the afterlife", "其欲汝与之偕于死后之境。");
            // 幽灵随风消散
            AddTranslation("the apparition fades into the wind", "鬼影随风而散。");
            // 你总觉得还有更多在暗处等待
            AddTranslation("you can't shake the feeling there are [c:O]more[c:] out there waiting", "汝终不能去心中之感：尚有[c:O]更多[c:]匿而待焉。");
            // [v:0]因你的烛火熄灭而欢愉战栗
            AddTranslation("[c:bR][v:0][c:] shivers with delight as your candle is extinguished", "[c:bR][v:0][c:]因汝烛灭而喜战。");
            // 看见环绕你的幽灵了吗？
            AddTranslation("do you see the [c:O]apparition[c:] encircling you?", "汝见环汝之[c:O]鬼影[c:]乎？");
            // 你已被逝去的怨念缠身
            AddTranslation("you have become [c:O]haunted[c:] by [c:O]those who have come before[c:]", "汝已为[c:O]先逝之人[c:]所[c:O]缠[c:]矣。");
            // 你战斗胜利次数越多，它们怨气越重
            AddTranslation("the more you [c:O]win in battle[c:] the angrier they become", "汝[c:O]胜战[c:]愈多，则彼辈怨愈深。");
            // 未来它们可能在战斗中与你对立
            AddTranslation("and they may [c:O]oppose you in battle[c:] in the future", "后日彼辈或将[c:O]于战中与汝敌[c:]。");
            // 这次咱们多玩会儿！
            AddTranslation("Let's play longer this time!", "此番其久玩之！");
            // 多乐呵乐呵总没坏处！
            AddTranslation("A lil' more fun never hurt nobody!", "多取些乐，未尝害人也！");
            // 老子给你备了点儿好货！
            AddTranslation("I got a little somethin' special for ya!", "吾为汝备少异物矣！");
            // 嘿——哈！接着乐呵！
            AddTranslation("Heeeeeeee-haaw! Let's keep the fun goin'!", "嘿——哈！且续其乐！");
            // 还想要鱼？
            AddTranslation("You want more fish?", "犹欲鱼乎？");
            // 这次鱼多。
            AddTranslation("We get extra fish.", "今鱼多矣。");
            // 鱼管够。
            AddTranslation("Many fish this time.", "今鱼足矣。");
        }
    }
}
