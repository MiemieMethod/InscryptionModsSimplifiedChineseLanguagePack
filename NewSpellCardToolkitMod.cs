using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class NewSpellCardToolkitMod
    {
        public static void RegisterTranslations()
        {
            // 攻击强化
            AddTranslation("Attack Up", "益攻");
            // 在本场战斗中提升目标单位的攻击力。
            AddTranslation("Increases the target's attack for the rest of the battle.", "益所中者之威，至战终。");
            // 攻击削弱
            AddTranslation("Attack Down", "损攻");
            // 在本场战斗中降低目标单位的攻击力。
            AddTranslation("Decreases the target's attack for the rest of the battle.", "损所中者之威，至战终。");
            // 灭世灾变
            AddTranslation("Cataclysm", "大坏");
            // 当[creature]死亡时，牌桌上所有其他卡牌也将随之毁灭。
            AddTranslation("When [creature] dies, all other cards on the boards perish as well.", "[creature]死，则局上余牌皆灭。");
            // 直接伤害
            AddTranslation("Direct Damage", "直伤");
            // 对目标造成直接伤害。
            AddTranslation("Deals damage directly to a target.", "直伤所中。");
            // 直接治疗
            AddTranslation("Direct Heal", "直疗");
            // 治疗目标单位。该效果可使目标生命值超过其初始上限。
            AddTranslation("Heals the target. This can heal the target beyond its original max health.", "疗所中者，且得逾其本命之极。");
            // 双倍抽牌
            AddTranslation("Draw Twice", "再引");
            // 当[creature]死亡时，可额外抽取两张牌加入牌组。
            AddTranslation("When [creature] dies, draw two more cards and add them to your deck.", "[creature]死，则更引二牌，纳于牌列。");
            // 夺取控制
            AddTranslation("Gain Control", "夺御");
            // 夺取目标造物的控制权。
            AddTranslation("Takes control of the targeted creature.", "夺所中之物。");
            // 赋予印记
            AddTranslation("Give Sigils", "予印");
            // 将此卡的印记赋予目标卡牌。
            AddTranslation("Gives this card's sigils to the target.", "以此牌之印予所中者。");
            // 赋予属性
            AddTranslation("Give Stats", "予数");
            // 将此卡的属性赋予目标卡牌。
            AddTranslation("Gives this card's stats to the target.", "以此牌之数予所中者。");
            // 赋予属性与印记
            AddTranslation("Give Stats and Sigils", "予数与印");
            // 将此卡的属性与印记赋予目标卡牌。
            AddTranslation("Gives this card's stats and sigils to the target.", "以此牌之数与印予所中者。");
            // 法术（全局）
            AddTranslation("Spell (Global)", "术（周）");
            // 当这张卡牌在牌桌任意位置打出时，会立即产生效果并消失。
            AddTranslation("When this card is played anywhere on the board, it will cause an immediate effect and then disappear.", "此牌无论陈于局何处，皆即时生效而后灭。");
            // 全局法术。
            AddTranslation("GLOBAL SPELL.", "周术。");
            // 法术（全局，瞬发）
            AddTranslation("Spell (Global, Instant)", "术（周，立发）");
            // 当这张卡牌打出时，会立即产生效果并消失。
            AddTranslation("When this card is played, it will cause an immediate effect and then disappear.", "此牌既陈，即生其效而灭。");
            // 瞬发全局法术。
            AddTranslation("INSTA-GLOBAL SPELL.", "立发周术。");
            // 法术（定向）
            AddTranslation("Spell (Targeted)", "术（指）");
            // 当这张卡牌打出时，它会选定并影响牌桌上的一个位置，随后消失。
            AddTranslation("When this card is played, it will target and affect a chosen space on the board and then disappear.", "此牌既陈，则择局上一位而及之，旋即自灭。");
            // 定向法术。
            AddTranslation("TARGETED SPELL.", "指术。");
            // 命令（全局）
            AddTranslation("Command (Global)", "令（周）");
            // 当这张卡牌在牌桌任意位置打出时，会立即产生效果并消失。
            AddTranslation("When this card is played anywhere on the board, it will cause an immediate effect and then disappear.", "此牌无论陈于局何处，皆即时生效而后灭。");
            // 全局命令。
            AddTranslation("GLOBAL COMMAND.", "周令。");
            // 命令（全局，瞬发）
            AddTranslation("Command (Global, Instant)", "令（周，立发）");
            // 当这张卡牌打出时，会立即产生效果并消失。
            AddTranslation("When this card is played, it will cause an immediate effect and then disappear.", "此牌既陈，即生其效而灭。");
            // 瞬发全局命令。
            AddTranslation("INSTA-GLOBAL COMMAND.", "立发周令。");
            // 命令（定向）
            AddTranslation("Command (Targeted)", "令（指）");
            // 当这张卡牌打出时，它会选定并影响牌桌上的一个位置，随后消失。
            AddTranslation("When this card is played, it will target and affect a chosen space on the board and then disappear.", "此牌既陈，则择局上一位而及之，旋即自灭。");
            // 定向命令。
            AddTranslation("TARGETED COMMAND.", "指令。");
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
