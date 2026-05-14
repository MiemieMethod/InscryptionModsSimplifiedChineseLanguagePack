using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class SmallTweakHydraMod
    {
        public static void RegisterTranslations()
        {
            // [creature]在抽取时的孵化条件如下：你的牌组中的造物的生命和力量包含5个不同的数字，且有至少来自5个不同族群的造物各一张（所有带有此印记的卡牌将不会纳入此印记的计算）。
            AddTranslation("A card bearing this Sigil hatches when drawn if 5 unique numbers are in the Health of creatures in your deck, and in their Power, and if there is a creature of 5 unique tribes in your deck. [This Excludes all cards bearing this sigil]", "负此印契之牌，引而孚之：若汝牌列中诸物之命有五异数，威亦有五异数，又有五异族之物各一。〔凡负此印契者，不豫其数。〕");
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
