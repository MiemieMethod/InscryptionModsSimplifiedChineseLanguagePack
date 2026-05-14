using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch33
    {
        public static void RegisterTranslations()
        {
            RegisterAbilityBatchSix();
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

        private static void RegisterAbilityBatchSix()
        {
            // 退却
            AddTranslation("Retreat", "遁");
            // 当[creature]受到攻击时，会随机移动至牌桌同侧的空位。
            AddTranslation("When [creature] is struck, it will move to a random empty space on the same side of the board.", "[creature]受击，则随机移于同侧空位。");
            // 复仇攻击
            AddTranslation("Return Strike", "反击");
            // [creature]受到攻击时会进行反击。
            AddTranslation("When [creature] is struck, it attacks in retaliation.", "[creature]受击，则反击之。");
            // 时针顺之魂
            AddTranslation("Revolve", "周旋");
            // 使用[creature]时，牌桌上所有卡牌均会按顺时针方向移动一格。
            AddTranslation("When [creature] is played, all cards on the board are moved one space clockwise.", "[creature]既陈，场上诸牌皆顺时而移一位。");
            // 开膛手
            AddTranslation("Ripper", "剖者");
            // [creature]会移动并消灭任何生命值为1的非地形造物，每消灭一个都会变得更强。
            AddTranslation("[creature] will move to and destroy any free, 1 health, non-terrain creatures played, and becomes stronger for each one consumed.", "[creature]移而灭凡命1之非地形物；每食一，则益强。");
            // 磐石吞噬者
            AddTranslation("Rock Eater", "食磐");
            // 当[creature]同侧的牌桌出现地形卡时，该卡会被吞噬，其属性与印记将转移至这张地形卡。
            AddTranslation("When a Terrain card is played on the same side of the board as [creature], it will be consumed, granting it's stats and sigils to the card.", "若[creature]同侧有地形牌既陈，则为其所食，而其威命与印皆归[creature]。");
            // 红宝石核芯
            AddTranslation("Ruby Core", "红玉核");
            // 当[creature]阵亡时，会在原地生成一个红宝石容器。
            AddTranslation("When [creature] perishes, a Ruby Vessel is created in its place.", "[creature]死，则其处生一红玉皿。");
            // 奔袭打击
            AddTranslation("Running Strike", "奔击");
            // 攻击后，[creature]将沿印记标注方向移动，并在移动过程中攻击目标位置对面的空间。
            AddTranslation("After attacking, [creature] will move in the direction inscribed on the sigil, striking the space opposing it's destination as it does so.", "攻后，[creature]循印所志而移，并于移时击其所至位之对位。");
            // 割裂之触
            AddTranslation("Rupture", "裂触");
            // 当[creature]对造物造成伤害时，该伤害值的一半（向下取整）将同时作用于该造物的持有者。
            AddTranslation("When [creature] deals damage to a creature, half of that damage, rounded down, is also dealt to that creature's owner.", "[creature]伤一物，则其伤之半，取下，亦及其主。");
            // 血祭力量
            AddTranslation("Sanguine", "血威");
            // 当有造物被献祭时，[creature]的力量会临时增加1点直至战斗结束。
            AddTranslation("When a creature is sacrificed, [creature] gains 1 power until the end of combat.", "有物见祀，则[creature]威加1，至战终。");
        }
    }
}
