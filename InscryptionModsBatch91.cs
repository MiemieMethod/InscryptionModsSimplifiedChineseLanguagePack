using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch91
    {
        public static void RegisterTranslations()
        {
            RegisterZephtSunOne();
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

        private static void RegisterZephtSunOne()
        {
            // 调试阳光
            AddTranslation("DebugSun", "试日芒");
            // 阳光：
            AddTranslation("Sun: ", "日芒：");
            for (int count = 0; count <= 100; count++)
            {
                // 阳光：{count}
                AddTranslation("Sun: " + count.ToString(), "日芒：" + count.ToString());
            }
            // 夜幕降临
            AddTranslation("Night time", "夜至");
            // 你将无法从天空中获取阳光。
            AddTranslation("You will no longer get passive sun falling from the sky.", "自天而坠之日芒，汝不复得之。");
            // 阳光激励
            AddTranslation("SunBoost", "增晖");
            // 当[creature]被放置时，持牌人会得到一定数量的阳光。
            AddTranslation("When [creature] is placed on the board, the owner will gain sun.", "[creature]既置于局，持者得日芒。");
            // 明智地使用应急物资。
            AddTranslation("Wise use of emergency supplies.", "急储善用。");
            // 阳光杀戮
            AddTranslation("SunKill", "杀取晖");
            // 当[creature]击败另一张卡牌时，另一张卡牌将掉落阳光。
            AddTranslation("When [creature] defeats another card, the other card will drop sun.", "[creature]既败他牌，其牌堕日芒。");
            // 将你的敌人重新转化为营养。
            AddTranslation("Recycle your enemies back into nutrients", "反汝敌而归养。");
            // 阳光生产
            AddTranslation("SunMaker 1", "生晖一");
            // 在持牌人的回合结束时，若[creature]在玩家一侧，它将生产1个阳光。
            AddTranslation("At the end of the owner's turn, [creature] will produce 1 sun, if it belongs to the player.", "持者合终，若[creature]在玩家一侧，则生一日芒。");
            // 每一点都很重要
            AddTranslation("Every little bit counts", "纤芒亦数。");
            // 双重生产
            AddTranslation("SunMaker 2", "生晖二");
            // 在持牌人的回合结束时，若[creature]在玩家一侧，它将生产2个阳光。
            AddTranslation("At the end of the owner's turn, [creature] will produce 2 sun, if it belongs to the player.", "持者合终，若[creature]在玩家一侧，则生二日芒。");
            // 要是月亮这么有用就好了
            AddTranslation("If only the moon was this useful", "月若如是之用可矣。");
            // 三重生产
            AddTranslation("SunMaker 3", "生晖三");
            // 在持牌人的回合结束时，若[creature]在玩家一侧，它将生产3个阳光。
            AddTranslation("At the end of the owner's turn, [creature] will produce 3 sun, if it belongs to the player.", "持者合终，若[creature]在玩家一侧，则生三日芒。");
            // 太阳的力量，在你的掌心
            AddTranslation("The power of the sun, in the palm of your hand", "日之力，在汝掌中。");
            // 阳光生产
            AddTranslation("SunMaker", "生晖");
            // 在持牌人的回合结束时，若[creature]在玩家一侧，它将生产X个阳光。有些牌比其他牌产生更多的阳光。
            AddTranslation("At the end of the owner's turn, [creature] will produce X sun, if it belongs to the player. Some cards produce more sun than others.", "持者合终，若[creature]在玩家一侧，则生X日芒。诸牌所生，多少不同。");
            // 你没有足够的阳光。
            AddTranslation("You dont have enough sun for that one", "汝之日芒不足。");
        }
    }
}
