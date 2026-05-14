using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class OriginalModifiedMod
    {
        public static void RegisterTranslations()
        {
            // 阿米巴松鼠
            AddTranslation("Amoeba Squirrel", "阿米巴松鼠");
            // 恼人水松鼠
            AddTranslation("Annoying Aquasquirrel", "烦水松鼠");
            // 献祭之石
            AddTranslation("Bloody Stone", "血石");
            // 自爆水松鼠
            AddTranslation("Explosion Aquasquirrel", "爆水松鼠");
            // 自爆松鼠
            AddTranslation("Explosion Squirrel", "爆松鼠");
            // 杀手蜂
            AddTranslation("Killer Bee", "杀蜂");
            // 优质松鼠
            AddTranslation("Quality Squirrel", "良松鼠");
            // 高跳松鼠
            AddTranslation("Reach Squirrel", "跃松鼠");
            // 可祭磐石
            AddTranslation("Sacrificable Boulder", "可祀磐");
            // 长尾松鼠
            AddTranslation("Tail Squirrel", "尾松鼠");
            // 鹰
            AddTranslation("Hawk", "鹰");
            // 凶猛的鹰。最有效的制空手段之一。
            AddTranslation("The vicious hawk. One of the most effective flying attackers.", "鹰猛，飞攻之尤效者。");
            // 鲑鱼
            AddTranslation("Salmon", "鲑");
            // 健壮的鲑鱼。它能逆流快速游动。
            AddTranslation("The athletic salmon. It swims quickly upstream.", "鲑健，溯流甚疾。");
            // 松鼠球
            AddTranslation("Squirrel Ball", "松鼠球");
            // 奇特的松鼠球。滚动时会留下几只迷途松鼠。
            AddTranslation("The peculiar squirrel ball. When it rolls, it leaves behind some stray squirrels.", "松鼠球甚奇，滚则遗数迷松鼠。");
            // 红宝石松鼠
            AddTranslation("Ruby Squirrel", "红玉松鼠");
            // 绿宝石松鼠
            AddTranslation("Emerald Squirrel", "绿玉松鼠");
            // 蓝宝石松鼠
            AddTranslation("Sapphire Squirrel", "蓝玉松鼠");
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
