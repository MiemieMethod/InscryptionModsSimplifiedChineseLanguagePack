using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class SmallTweakBorneMod
    {
        public static void RegisterTranslations()
        {
            // [creature]带有该印记的卡牌将直接攻击一名敌人，即使其对面有其他造物也无妨，除非该造物也有此印记。
            AddTranslation("[creature] will strike an opponent directly, even if there is a creature opposing it, unless the creature has this sigil.", "[creature]虽有物当之，亦直击敌主；彼物若亦负此印契，则否。");
            // [creature]在对手的回合潜入水下，其潜水时，敌对造物会直接攻击其主人，除非该造物也有此印记。
            AddTranslation("[creature] submerges itself during its opponent's turn. While submerged, opposing creatures attack its owner directly, unless that creature has this sigil.", "[creature]于敌合自潜。其既潜，则敌物直击其主；彼物若亦负此印契，则否。");
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
