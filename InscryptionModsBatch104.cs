using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch104
    {
        public static void RegisterTranslations()
        {
            RegisterAgasMagnificusTwo();
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

        private static void RegisterAgasMagnificusTwo()
        {
            // 全能法师
            AddTranslation("EveryMage", "全术士");
            // 法师
            AddTranslation("mage", "术士");
            // 塑能师
            AddTranslation("Evoker", "召能者");
            // 令人厌恶的教义的不祥秘密。可归纳之蛇是最致命的。
            AddTranslation("The ominous crettin of disgusting teachings. It's summonable snakes are of the deadliest caliber", "其学可憎，而人亦不祥。其所召之蛇，毒最烈。");
            // 蛇之召
            AddTranslation("Serpent Summon", "召蛇");
            // 纵火狂
            AddTranslation("Firebender", "御火者");
            // 在战斗最激烈的时候，他总是在寻找下一个火球的受害者。
            AddTranslation("Chipper in the heat of battle, he is always on the hunt for the next victim of his fireballs", "战酣之际，其恒索火丸之次受者。");
            // 前瞻法师
            AddTranslation("Foresight Mage", "先见术士");
            // 当他凝视着你的未来，他永远预言着可能会到来的攻击。
            AddTranslation("As he gazes upon your future, attacks that may come his way he forever predicts", "其视汝后日，则凡或临己之攻，皆先知之。");
            // 展望未来，他可能会看到任何敢于接近的人。
            AddTranslation("Gazing into the future, he may see any body who dares make an approach", "瞻后日，则凡敢近者，或皆为其所见。");
            // 冰川
            AddTranslation("Glacier", "冰川");
            // 饿者骷髅
            AddTranslation("Gashadokuro", "馁骨");
            // 宝石哨兵
            AddTranslation("Gem Sentinel", "玉哨");
            // 被我的玛珂光辉迷住的精英战士部队。
            AddTranslation("the elite warrior unit enchanted with the aura of my moxen", "受我玛珂之辉所咒之锐士。");
            // 研星者
            AddTranslation("Grand Astrologer", "大占星者");
            // 战场永远是他的游乐场，太空是他的武器。一切在他面前都是光秃秃的。
            AddTranslation("The battlefield is forever his playground, and space is his weapon. All is bare before him.", "战场常为其戏地，空宇为其兵。一切于前，无所匿也。");
            // 重力法师
            AddTranslation("Gravity Mage", "重术士");
            // 重力的大师。任何人都会屈从于他坚定不移的意志。
            AddTranslation("A master of the forces of gravity. Any and all mox bend to his unwavering will", "重力之师也。凡玛珂皆屈其不贰之志。");
            // 幻术师
            AddTranslation("Illusion Mage", "幻术士");
            // 乍一看，他的诡计和伪装，没有比这更可怕的了。
            AddTranslation("Dawning his tricks and disguises, there is none scarier. At first glance", "其机诈与伪饰，初视之无有加怖者。");
            // 感染法师
            AddTranslation("Infestation Mage", "染术士");
            // 我想像你这样的篡位挑战者可以忍受一定量的变身邪术。
            AddTranslation("I suppose a usurping challenger such as yourself could endulge in a dosage of skinwalking", "若汝此篡位之角者，亦当堪受些许易形邪术。");
            // 侮辱魔镜
            AddTranslation("Insulting Mirror", "辱镜");
            // 魔法的威胁在所有谈吐中嘲讽和粗鲁的评论中飞舞；你越愤怒，它越将转化为自己的力量。
            AddTranslation("The Magick Menace Flies About All Spitting Taunts And Hurling Cheeky Comments, Your Anger, It Channels Into A Strength Of It's Own", "此魔患飞扬，吐侮掷讥；汝怒愈甚，则其威愈归于己。");
            // 铁处女
            AddTranslation("Iron Maiden", "铁闺");
            // 我最优秀的圣骑士们工作时间最长。没有人能穿过他的长城。
            AddTranslation("My finest of paladins working the finest of hours. No soul goes through his grand wall", "我诸圣骑中最良者也。无一魂得逾其巨垣。");
        }
    }
}
