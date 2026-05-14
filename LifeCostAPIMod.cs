using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class LifeCostAPIMod
    {
        public static void RegisterTranslations()
        {
            // 莱克
            AddTranslation("Leck", "莱克");
            // 迷途之兽，形如牙齿，仅因错误出现。
            AddTranslation("The Lost Beast, in the shape of a tooth, showing up only in error.", "迷兽也，形若齿，仅以误而见。");
            // 梅克
            AddTranslation("Meck", "梅克");
            // 泰克
            AddTranslation("Teck", "泰克");
            // 你没有足够的[c:bG]生命[c:]或[c:gray]箔片[c:]来打出这张牌。对对手造成伤害以获得更多[c:bG]生命[c:]。
            AddTranslation("You do not have enough [c:bG]Life[c:] or [c:gray]Foils[c:] to play that. Damage your opponent to gain more [c:bG]Life[c:].", "汝[c:bG]生命[c:]或[c:gray]箔[c:]不足，不得陈此。伤汝敌以益[c:bG]生命[c:]。");
            // 你的天平上没有足够的[c:bG]生命[c:]来打出这张牌。对对手造成伤害以获得更多[c:bG]生命[c:]。
            AddTranslation("You do not have enough [c:bG]Life[c:] on your scales to play that. Damage your opponent to gain more [c:bG]Life[c:].", "汝衡上[c:bG]生命[c:]不足，不得陈此。伤敌以益[c:bG]生命[c:]。");
            // 你没有足够的[c:gray]箔片[c:]来打出这张牌。你可以通过造成过量伤害来获得[c:gray]箔片[c:]。
            AddTranslation("You do not have enough [c:gray]Foils[c:] to play that. You gain [c:gray]Foils[c:] by dealing overkill damage.", "汝[c:gray]箔[c:]不足，不得陈此。行溢伤以得[c:gray]箔[c:]。");
            // 最大能量豪赌
            AddTranslation("Max Energy Gamble", "极能豪赌");
            // 消耗6点能量，在目标一侧的天平上放置0至3点伤害。
            AddTranslation("Pay 6 energy to put 0 to 3 damage on someone's side of the scale", "输六能，于一侧衡上置零至三伤。");
            // 掷骰子
            AddTranslation("Die Roll", "掷骰");
            // 以钱换血
            AddTranslation("Money for Blood", "以财市血");
            // 支付5点生命/箔片，随机将0至6点属性增幅分配到各项属性上。
            AddTranslation("Pay 5 Life/Foils to gain between 0 and 6 increase in stats, distributed randomly", "出五生命/箔，随机分零至六之数于诸数上。");
            // 唱一遍，再一遍，掷出骰子搏个变！
            AddTranslation("Sing it once, Sing it twice, take a chance and roll the dice!", "歌一再歌，掷骰以试命！");
            // 现金转换器
            AddTranslation("Cash Converter", "财易器");
            // 支付4枚箔片，在对手一侧的天平上放置1点伤害。
            AddTranslation("Pay 4 foils to put 1 damage on your opponent's side of the scale", "出四箔，于敌侧之衡置伤一。");
            // 生命转换器
            AddTranslation("Life Converter", "命易器");
            // 支付2点生命，获得1枚箔片。
            AddTranslation("Pay 2 life to gain 1 foils", "出二命，得一箔。");
            // 吸血之力
            AddTranslation("Vamperic Strength", "饮血之力");
            // 支付3点生命，使[creature]的攻击力和生命值各+1。
            AddTranslation("Pay 3 life to increase the power and health of this card by 1", "出三命，使此牌威与命各加一。");
            // 以血换钱
            AddTranslation("Blood for money", "以血市财");
            // 自残可提升力量。
            AddTranslation("Hurting oneself can lead to an increase in strength.", "自伤可益威。");
            // 贪婪之力
            AddTranslation("Greedy Strength", "贪力");
            // 支付5点货币，使[creature]的攻击力和生命值各+1。
            AddTranslation("Pay 5 currency to increase the power and health of this card by 1", "出五货，使此牌威与命各加一。");
            // 侵蚀一切触碰之物的水洼。
            AddTranslation("A puddle that errods all that touches it.", "一洼蚀凡所触者。");
            // 可受雇执行多种任务。
            AddTranslation("One can be hired to do many tasks", "可雇以任众事。");
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
