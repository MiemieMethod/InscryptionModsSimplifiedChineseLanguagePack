using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch103
    {
        public static void RegisterTranslations()
        {
            RegisterAgasMagnificusOne();
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

        private static void RegisterAgasMagnificusOne()
        {
            // Aga的蔓尼菲科模组扩展
            AddTranslation("Aga's Magnificus Expansion", "Aga氏蔓尼菲科扩篇");
            // 蔓尼菲科模组的非官方扩展，拥有[count]位独特而丰富多彩的法师
            AddTranslation("An unofficial expansion to the Magnificus Mod featuring [count] unique and colourful mages", "蔓尼菲科补缀之外扩，载[count]异而绚之术士。");
            // 飞升法师
            AddTranslation("Ascension Mage", "升举术士");
            // 他们利用时间的力量，传授远远超出他们的知识和经验。
            AddTranslation("Utilising the power of time they grant knowledge and experience from far beyond", "假时之力，以授远逾寻常之知与历。");
            // 灰烬法师
            AddTranslation("Ash Mage", "灰术士");
            // 他从自己身上剥落灰烬，灼烧所有反对他的人。
            AddTranslation("Ashes he sheds from his own body, scorching any and all who oppose him", "其自体落灰，凡逆己者皆灼之。");
            // 破碎的蛋
            AddTranslation("Broken Egg", "残卵");
            // 只有最伟大的训练师才能找到这个宝藏。
            AddTranslation("Only the greatest of trainers might find this treasure", "惟至善之训者，乃或得此宝。");
            // 天选之子
            AddTranslation("Chosen One", "天简之子");
            // 我选择的最爱的存在。尽管如此，他仍然依恋他的长辈...
            AddTranslation("My selected favourite. He still clings to his elders though...", "我所简而最爱者也。虽然，犹恋其长上……");
            // 清洁法师
            AddTranslation("Cleanliness Mage", "洁术士");
            // 我所有学生中最自豪的。没有人能比得上他的洗澡超能力。
            AddTranslation("The proudest of all my pupils. None come close to his bath superpowers", "我诸徒中最可矜者也。其浴之异能，无有近之。");
            // 牧师
            AddTranslation("Cleric", "司祭");
            // 凭借他的神圣魔法，他承受了所有人的痛苦，并消除了他们的伤痕。
            AddTranslation("With the virtue of his divine Magicks, he bears the pain of all and rids them of their wounds", "以其神术之德，负众痛而蠲其创。");
            // 时钟法师
            AddTranslation("Clock Mage", "钟术士");
            // 一个精通时间的巫师。当他接近死亡时，他会回到过去，重获新生。
            AddTranslation("A wizard with a mastery over time itself. When he nears his demise, he reverts to the past, and comes back to life", "一精于时之巫也。将死，则返于既往而更生。");
            // 造物收藏家
            AddTranslation("Creature Collector", "藏物者");
            // 你看，他四处寻找他的小伙伴。
            AddTranslation("He had searched far and wide for his little companion, you see", "子视之，彼尝周求其小侣。");
            // 分裂法师
            AddTranslation("Division Mage", "分术士");
            // 至少卡牌上这么说...我以为那些怪胎已经交往很久了。
            AddTranslation("So the card says at least... I assumed those freaks were long dealth with", "牌虽如是云……我意彼诸怪胎久已处置矣。");
            // 蛋
            AddTranslation("Egg", "卵");
            // 德鲁伊
            AddTranslation("Druid", "德鲁伊");
            // 大自然的原始奉献者，以消耗的法力为食来治愈他的盟友。
            AddTranslation("Nature's primal devotee, feeding on sapped mana to cure his allies", "自然之初徒也，食所汲之法力，以疗其侣。");
            // 附魔师
            AddTranslation("Enchanter", "附咒者");
            // 他临死时喷出宇宙魔法，让附近的一切都附上魔力。
            AddTranslation("He spews cosmic magicks upon his demise, enchanting everything nearby", "将死，则喷宇宙之术，使近者尽受其咒。");
        }
    }
}
