using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class AchievementsMod
    {
        public static void RegisterTranslations()
        {
            // 成就
            AddTranslation("ACHIEVEMENTS", "功成录");
            // 凯茜模组成就
            AddTranslation("Kaycee's Mod Achievements", "凯茜补缀功成录");
            // 剧情成就
            AddTranslation("Story Achievements", "叙事功成录");
            // 成就已解锁
            AddTranslation("Achievement Unlocked", "功已启");
            // 隐藏成就
            AddTranslation("Secret Achievement", "隐功");
            // 解锁后显示
            AddTranslation("Revealed Once Unlocked", "启后乃显");
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
