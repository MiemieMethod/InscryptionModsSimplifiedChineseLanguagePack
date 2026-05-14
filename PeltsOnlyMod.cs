using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class PeltsOnlyMod
    {
        public static void RegisterTranslations()
        {
            // 只有毛皮
            AddTranslation("Pelts Only", "惟皮");
            // 所有卡牌选择节点都将替换为猎人和毛皮商。
            AddTranslation("All Card Choices are replaced with either Trapper or Trader.", "诸牌择之节点，皆易为猎夫或易皮者。");
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
