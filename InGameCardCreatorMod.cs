using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class InGameCardCreatorMod
    {
        public static void RegisterTranslations()
        {
            // 您已进入[c:bR]卡牌创建[c:]模式。
            AddTranslation("You entered the [c:bR]card creation[c:] mode.", "汝既入[c:bR]造牌[c:]之式。");
            // 看来你正常落败了。
            AddTranslation("It appears that you lost normally.", "观汝所败，常也。");
            // 只有有价值的挑战者才能访问卡牌创建器。
            AddTranslation("Only worthy challengers may access the Card Creator.", "惟可取之角者，乃得入造牌器。");
            // 再试一次，但这次记得要正常打开密室门。
            AddTranslation("Try again, but this time open the backroom door normally.", "更试之，此番当以常法启后室之门。");
            // 当前卡牌
            AddTranslation("current card", "今牌");
            // 你应该赐予其一个名字。
            AddTranslation("You should give it a name.", "宜名之。");
            // 请输入对其的描述。
            AddTranslation("Please type the description.", "请书其叙。");
            // 是时候让你回去了。
            AddTranslation("It is time for you to return.", "汝当归矣。");
            // 正在加载卡面图片。
            AddTranslation("Loading portraits.", "方载牌像。");
            // 上一页
            AddTranslation("previous page", "前页");
            // 下一页
            AddTranslation("next page", "后页");
            // 然后是另一项。这次我将写入它的[c:bR]力量[c:]。
            AddTranslation("And another. This time I will use its [c:bR]power[c:].", "复有一项，此番我将取其[c:bR]威[c:]。");
            // 选择卡牌的[c:bR]复杂程度[c:]。这将决定它在教程中何时解锁。
            AddTranslation("Choose the [c:bR]complexity[c:] of card. This determines when it is unlocked in the tutorial.", "择牌之[c:bR]繁简[c:]。此定其于教次中何时而解。");
            // 免费
            AddTranslation("free", "无费");
            // 请从中选择一张卡牌来抽取[c:bR]成本[c:]。
            AddTranslation("Please, choose a card to draw the [c:bR]cost[c:] from.", "请择一牌，以取其[c:bR]费[c:]。");
            // 你想添加另一种[c:bR]成本[c:]吗？
            AddTranslation("Do you want to add another [c:bR]cost[c:]?", "汝欲更益一[c:bR]费[c:]乎？");
            // 选择它将成长为哪张卡牌。
            AddTranslation("Choose which card it will evolve into.", "择其所将孚为何牌。");
            // 选择其死亡后将生成哪张卡牌。
            AddTranslation("Choose which card it will create upon death.", "择其死后所生为何牌。");
            // 这张牌需要[c:bR]多少回合[c:]才能成长？
            AddTranslation("[c:bR]How many turns[c:] should it take for this card to evolve?", "此牌须[c:bR]几合[c:]而孚？");
            // 然后是另一项。这次我将写入它的[c:bR]生命[c:]。
            AddTranslation("And another. This time I will use its [c:bR]health[c:].", "复有一项，此番我将取其[c:bR]命[c:]。");
            // 常规
            AddTranslation("regular", "常");
            // 稀有
            AddTranslation("rare", "罕");
            // 隐藏
            AddTranslation("hidden", "隐");
            // 选择卡牌的[c:bR]类型[c:]。
            AddTranslation("Choose the [c:bR]type[c:] of card.", "择牌之[c:bR]类[c:]。");
            // 现在选择一些卡牌，我们将从中提取[c:bR]印记[c:]。请注意，有些可能无法正常工作。
            AddTranslation("Now choose some cards from which we will extract the [c:bR]sigils[c:]. Note that some may not work correctly.", "今择数牌，我曹将取其[c:bR]印契[c:]。然有不尽可用者。");
            // 最后，选择隐藏的[c:bR]特殊能力[c:]和[c:bR]特质[c:]。同样，有些可能无法正常工作。
            AddTranslation("Finally, choose the hidden [c:bR]special abilities[c:] and [c:bR]traits[c:]. Again, some may not function properly.", "终则择其隐[c:bR]特技[c:]与[c:bR]性[c:]。亦有不尽可用者。");
            // 成本（设置）
            AddTranslation("cost (set)", "费（定）");
            // 成本（增加）
            AddTranslation("cost (add)", "费（益）");
            // 印记
            AddTranslation("sigils", "印契");
            // 族群
            AddTranslation("tribes", "族");
            // 特殊能力
            AddTranslation("sp. abilities", "特技");
            // 卡面
            AddTranslation("portrait", "牌像");
            // 复杂程度
            AddTranslation("complexity", "繁简");
            // 备用卡面
            AddTranslation("alternate portrait", "副像");
            // 完成
            AddTranslation("finish", "毕");
            // 选择一个属性。
            AddTranslation("Choose a property.", "择一性。");
            // 现在选择[c:bR]族群[c:]。
            AddTranslation("Now choose the [c:bR]tribes[c:].", "今择[c:bR]族[c:]。");
            // 导出并退出
            AddTranslation("export and quit", "出而退");
            // 导出并新建
            AddTranslation("export and create another", "出而更造");
            // 退出但不导出
            AddTranslation("quit without exporting", "不出而退");
            // 新建但不导出
            AddTranslation("create another without exporting", "不出而更造");
            // 我该如何处置这张卡牌？
            AddTranslation("What should I do with this card?", "此牌我当何处之？");
            // 正在导出卡牌……
            AddTranslation("Exporting card...", "方出此牌……");
            // 该卡已创建、加载并导出到BepInEx插件文件夹中的IGCCExports文件夹。
            AddTranslation("The card has been created, loaded, and exported to IGCCExports inside the BepInEx plugins folder.", "此牌既造、既载，而出于 BepInEx 补缀夹中之 IGCCExports。");
            // [c:bR]{0}的特殊能力[c:]。
            AddTranslation("A [c:bR]Special Ability of {0}[c:].", "[c:bR]{0}之特技[c:]。");
            // [c:bR]{0}的特质[c:]。
            AddTranslation("A [c:bR]Trait of {0}[c:].", "[c:bR]{0}之性[c:]。");
            // [c:bR]无特殊能力。无特质[c:]。
            AddTranslation("[c:bR]No Special Abilities. No Traits[c:].", "[c:bR]无特技。无性。[c:]");
            // [c:bR]{0}的印记[c:]。
            AddTranslation("A [c:bR]Sigil of {0}[c:].", "[c:bR]{0}之印契[c:]。");
            // [c:bR]无印记[c:]。
            AddTranslation("[c:bR]No Sigils[c:].", "[c:bR]无印契。[c:]");
            // [c:bR]{0}族群[c:]。
            AddTranslation("[c:bR]{0} Tribe[c:].", "[c:bR]{0}族[c:]。");
            // [c:bR]无族群[c:]。
            AddTranslation("[c:bR]No Tribes[c:].", "[c:bR]无族。[c:]");
            // 默认（+1/+2）
            AddTranslation("default (+1/2)", "常（+1/+2）");
            // 默认（负鼠）
            AddTranslation("default (opposum)", "常（负鼠）");
            // 铃铛
            AddTranslation("Bell", "钟");
            // 手中卡牌
            AddTranslation("CardInHand", "手牌");
            // 绿宝石数
            AddTranslation("GreenGems", "绿玉数");
            // 镜子
            AddTranslation("Mirror", "镜");
            // 本回合献祭数
            AddTranslation("SacrificesThisTurn", "今合祀数");
            // 非死亡卡创建待选项
            AddTranslation("DeathcardCreationNonOption", "非死牌造项");
            // 缝合
            AddTranslation("Fused", "缀合");
            // 宝石
            AddTranslation("Gem", "玉");
            // 可毒杀幸存者
            AddTranslation("KillsSurvivors", "毒余生者");
            // 毛皮
            AddTranslation("Pelt", "革");
            // 可满足圆环试炼
            AddTranslation("SatisfiesRingTrial", "应环试");
            // 地形
            AddTranslation("Terrain", "地形");
            // 免疫剪刀和鱼钩
            AddTranslation("Uncuttable", "不受剪钩");
            // 熊
            AddTranslation("Bear", "熊");
            // 眼盲
            AddTranslation("Blind", "盲");
            // 可吃掉兔窝
            AddTranslation("EatsWarrens", "食兔穴");
            // 可喂给白鼬
            AddTranslation("FeedsStoat", "饲白鼬");
            // 幼崽
            AddTranslation("Juvenile", "幼");
            // 喜爱蜂蜜
            AddTranslation("LikesHoney", "嗜蜜");
            // 结构
            AddTranslation("Structure", "构");
            // 保护幼崽
            AddTranslation("ProtectsCub", "护幼");
            // 死灵
            AddTranslation("Undead", "死灵");
            // 铃铛接近度
            AddTranslation("BellProximity", "近钟");
            // 破碎银币（左）
            AddTranslation("BrokenCoinLeft", "残币左");
            // 破碎银币（右）
            AddTranslation("BrokenCoinRight", "残币右");
            // 达欧斯
            AddTranslation("Daus", "达欧斯");
            // 巨型卡牌
            AddTranslation("GiantCard", "巨牌");
            // 巨型月亮
            AddTranslation("GiantMoon", "巨月");
            // 巨型船
            AddTranslation("GiantShip", "巨舟");
            // 绿色法师
            AddTranslation("GreenMage", "绿巫");
            // 13号孩子
            AddTranslation("JerseyDevil", "十三子");
            // 随机卡牌
            AddTranslation("RandomCard", "偶牌");
            // 繁衍虱子
            AddTranslation("SpawnLice", "生虱");
            // 会说话的卡牌选择器
            AddTranslation("TalkingCardChooser", "语牌择器");
            // 陷阱生成器
            AddTranslation("TrapSpawner", "阱生器");
            // [c:bR]1根骨头[c:]成本。
            AddTranslation("A cost of [c:bR]1 bone[c:].", "[c:bR]1骨[c:]之费。");
            // 成本……[c:bR]免费[c:]。
            AddTranslation("A cost of... [c:bR]free[c:].", "其费……[c:bR]无费[c:]。");
            // [c:bR]1个回合[c:]。
            AddTranslation("[c:bR]1 turn[c:].", "[c:bR]1合[c:]。");
            // 1点血量
            AddTranslation("1 blood", "1血");
            // 1根骨头
            AddTranslation("1 bone", "1骨");
            // 1个回合
            AddTranslation("1 turn", "1合");
            // 手牌数
            AddTranslation("CardsInHand", "手牌数");
            // 虱子
            AddTranslation("lice", "虱");
            // 简单
            AddTranslation("simple", "简");
            // 中等
            AddTranslation("intermediate", "中");
            // 高级
            AddTranslation("advanced", "繁");
            // [c:bR]常规[c:]卡牌。
            AddTranslation("A [c:bR]regular[c:] card.", "[c:bR]常[c:]牌。");
            // [c:bR]稀有[c:]卡牌。
            AddTranslation("A [c:bR]rare[c:] card.", "[c:bR]罕[c:]牌。");
            // [c:bR]隐藏[c:]卡牌。
            AddTranslation("A [c:bR]hidden[c:] card.", "[c:bR]隐[c:]牌。");
            // 松鼠族群
            AddTranslation("squirrel tribe", "松鼠族");
            // 鸟类族群
            AddTranslation("bird tribe", "鸟族");
            // 犬类族群
            AddTranslation("canine tribe", "犬族");
            // 有蹄类族群
            AddTranslation("hooved tribe", "蹄族");
            // 爬行类族群
            AddTranslation("reptile tribe", "鳞族");
            // 昆虫类族群
            AddTranslation("insect tribe", "虫族");
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
