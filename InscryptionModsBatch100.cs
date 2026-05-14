using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch100
    {
        public static void RegisterTranslations()
        {
            RegisterInGameCardCreatorOne();
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

        private static void RegisterInGameCardCreatorOne()
        {
            // 您已进入卡牌创建模式。
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
            // 然后是另一项。这次我将写入它的力量。
            AddTranslation("And another. This time I will use its [c:bR]power[c:].", "复有一项，此番我将取其[c:bR]威[c:]。");
            // 选择卡牌的复杂程度。这将决定它在教程中何时解锁。
            AddTranslation("Choose the [c:bR]complexity[c:] of card. This determines when it is unlocked in the tutorial.", "择牌之[c:bR]繁简[c:]。此定其于教次中何时而解。");
            // 免费
            AddTranslation("free", "无费");
            // 请从中选择一张卡牌来抽取成本。
            AddTranslation("Please, choose a card to draw the [c:bR]cost[c:] from.", "请择一牌，以取其[c:bR]费[c:]。");
            // 你想添加另一种成本吗？
            AddTranslation("Do you want to add another [c:bR]cost[c:]?", "汝欲更益一[c:bR]费[c:]乎？");
            // 选择它将成长为哪张卡牌。
            AddTranslation("Choose which card it will evolve into.", "择其所将孚为何牌。");
            // 选择其死亡后将生成哪张卡牌。
            AddTranslation("Choose which card it will create upon death.", "择其死后所生为何牌。");
            // 这张牌需要多少回合才能成长？
            AddTranslation("[c:bR]How many turns[c:] should it take for this card to evolve?", "此牌须[c:bR]几合[c:]而孚？");
            // 然后是另一项。这次我将写入它的生命。
            AddTranslation("And another. This time I will use its [c:bR]health[c:].", "复有一项，此番我将取其[c:bR]命[c:]。");
            // 常规
            AddTranslation("regular", "常");
            // 稀有
            AddTranslation("rare", "罕");
            // 隐藏
            AddTranslation("hidden", "隐");
            // 选择卡牌的类型。
            AddTranslation("Choose the [c:bR]type[c:] of card.", "择牌之[c:bR]类[c:]。");
            // 现在选择一些卡牌，我们将从中提取印记。请注意，有些可能无法正常工作。
            AddTranslation("Now choose some cards from which we will extract the [c:bR]sigils[c:]. Note that some may not work correctly.", "今择数牌，我曹将取其[c:bR]印契[c:]。然有不尽可用者。");
            // 最后，选择隐藏的特殊能力和特质。同样，有些可能无法正常工作。
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
            // 现在选择族群。
            AddTranslation("Now choose the [c:bR]tribes[c:].", "今择[c:bR]族[c:]。");
            // 导出并退出
            AddTranslation("export and quit", "出而退");
            // 导出并新建
            AddTranslation("export and create another", "出而更造");
        }
    }
}
