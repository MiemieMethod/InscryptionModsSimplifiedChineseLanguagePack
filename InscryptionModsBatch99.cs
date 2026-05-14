using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch99
    {
        public static void RegisterTranslations()
        {
            RegisterPizzaTowerTwo();
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

        private static void RegisterPizzaTowerTwo()
        {
            // 比萨塔的统治者，强大而保守秘密。如果它能进化的话
            AddTranslation("The ruler of the Pizza Tower, powerful and holding a secret if it can evolve", "披萨塔之主也，强而怀秘；若其得孚，则然。");
            // 破碎披萨脸
            AddTranslation("Broken Pizza Face", "残披萨脸");
            // 披萨塔的破碎统治者
            AddTranslation("The broken ruler of the Pizza Tower", "披萨塔之残主。");
            // 齿轮
            AddTranslation("Gear", "机轮");
            // 披萨头
            AddTranslation("Pizza Head", "披萨头");
            // 披萨塔的统治者，强大而...愚蠢
            AddTranslation("The ruler of the Pizza Tower, powerful and... goofy", "披萨塔之主也，强而……愚。");
            // 披萨塔的统治者，强大、愚蠢、愤怒
            AddTranslation("The ruler of the Pizza Tower, powerful, goofy, and angry", "披萨塔之主也，强、愚而怒。");
            // 披萨法师
            AddTranslation("Pizzard", "披萨巫");
            // 一个神秘的巫师...我拿错牌了吗？
            AddTranslation("A mystical wizard... did I grab the wrong deck?", "一玄巫也……我其取错牌列乎？");
            // 披萨蛞蝓
            AddTranslation("Pizza Slug", "披萨蛞蝓");
            // 一个来自猪城的脾气暴躁的吸食者。
            AddTranslation("A cranky smoker from the Pig City.", "一出于豕城而性躁之烟徒也。");
            // 披萨兵
            AddTranslation("Pizza Soldier", "披萨兵");
            // 准备打仗的应征入伍者。
            AddTranslation("A conscript, ready for war.", "一征卒，备战者也。");
            // 冻披萨
            AddTranslation("Pizzice", "冻披萨");
            // 冰封的披萨。
            AddTranslation("Frozen pizza.", "冰披萨也。");
            // 牧场射手
            AddTranslation("Ranch Shooter", "庄射手");
            // 容易受惊，容易触发。
            AddTranslation("Easily spooked and trigger happy.", "易惊而轻发。");
            // 刺尼克
            AddTranslation("Snick", "斯尼克");
            // 一只失业的豪猪正在举办游戏博览会
            AddTranslation("An out of work porcupine running a game expo", "一失业之豪猪，而主游戏之会。");
            // 邪刺尼克
            AddTranslation("Snick.EXE", "邪斯尼克");
            // 嗯……奇怪。我不记得了。
            AddTranslation("Hmm... odd. I don't remember that one.", "嗯……异哉。我不忆此物。");
            // 雪人
            AddTranslation("Snowman", "雪人");
            // 不能攻击，但它的鼻子远非无害的胡萝卜。
            AddTranslation("Can't attack, but it's nose is far from a harmless carrot.", "不能攻，然其鼻绝非无害之胡芦菔。");
            // 塔品豆
            AddTranslation("Toppins", "塔品豆");
            // 可爱又美味
            AddTranslation("Adorable and delicious", "可爱而甘美。");
            // 宝箱男
            AddTranslation("Treasure Chest Guy", "宝匮翁");
            // 不会攻击，但可以提供一些有用的资源。
            AddTranslation("Won't attack, but can provide some useful resources.", "不能攻，然可供有用之资。");
            // 幽浮橄榄怪
            AddTranslation("UFOlive", "飞盘橄榄怪");
            // 治安猎手
            AddTranslation("Vigilante", "义巡者");
            // 为正义而战的奶酪泥
            AddTranslation("A cheese slime fighting for justice", "为义而斗之酪泥。");
            // 雪茄肠哥
            AddTranslation("Weenie", "肠仔");
            // 小香肠。
            AddTranslation("Weenie.", "小肠也。");
        }
    }
}
