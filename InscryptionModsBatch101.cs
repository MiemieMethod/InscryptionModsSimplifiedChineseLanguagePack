using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch101
    {
        public static void RegisterTranslations()
        {
            RegisterInGameCardCreatorTwo();
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

        private static void RegisterInGameCardCreatorTwo()
        {
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
            // {0}的特殊能力。
            AddTranslation("A [c:bR]Special Ability of {0}[c:].", "[c:bR]{0}之特技[c:]。");
            // {0}的特质。
            AddTranslation("A [c:bR]Trait of {0}[c:].", "[c:bR]{0}之性[c:]。");
            // 无特殊能力。无特质。
            AddTranslation("[c:bR]No Special Abilities. No Traits[c:].", "[c:bR]无特技。无性。[c:]");
            // {0}的印记。
            AddTranslation("A [c:bR]Sigil of {0}[c:].", "[c:bR]{0}之印契[c:]。");
            // 无印记。
            AddTranslation("[c:bR]No Sigils[c:].", "[c:bR]无印契。[c:]");
            // {0}族群。
            AddTranslation("[c:bR]{0} Tribe[c:].", "[c:bR]{0}族[c:]。");
            // 无族群。
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
            for (int value = 0; value <= 100; value++)
            {
                // {value}点血量
                AddTranslation(value + " blood", value + "血");
                // {value}根骨头
                AddTranslation(value + " bones", value + "骨");
                // {value}点能量
                AddTranslation(value + " energy", value + "能");
                // {value}个回合
                AddTranslation(value + " turns", value + "合");
                // {value}点力量
                AddTranslation(value + " power", value + "威");
                // {value}点生命
                AddTranslation(value + " health", value + "命");
                // {value}点能量成本。
                AddTranslation("A cost of [c:bR]" + value + " energy[c:].", "[c:bR]" + value + "能[c:]之费。");
                // {value}根骨头成本。
                AddTranslation("A cost of [c:bR]" + value + " bones[c:].", "[c:bR]" + value + "骨[c:]之费。");
                // {value}点血量成本。
                AddTranslation("A cost of [c:bR]" + value + " blood[c:].", "[c:bR]" + value + "血[c:]之费。");
                // {value}点力量。
                AddTranslation("[c:bR]" + value + " Power[c:].", "[c:bR]" + value + "威[c:]。");
                // {value}点生命。
                AddTranslation("[c:bR]" + value + " Health[c:].", "[c:bR]" + value + "命[c:]。");
                // {value}个回合。
                AddTranslation("[c:bR]" + value + " turns[c:].", "[c:bR]" + value + "合[c:]。");
            }
            // 1根骨头成本。
            AddTranslation("A cost of [c:bR]1 bone[c:].", "[c:bR]1骨[c:]之费。");
            // 成本……免费。
            AddTranslation("A cost of... [c:bR]free[c:].", "其费……[c:bR]无费[c:]。");
            // 1个回合。
            AddTranslation("[c:bR]1 turn[c:].", "[c:bR]1合[c:]。");
            // 1点血量
            AddTranslation("1 blood", "1血");
            // 1根骨头
            AddTranslation("1 bone", "1骨");
            // 1个回合
            AddTranslation("1 turn", "1合");
        }
    }
}
