using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch15
    {
        public static void RegisterTranslations()
        {
            RegisterMagnificusAbilitiesMid();
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

        private static void RegisterMagnificusAbilitiesMid()
        {
            // 点燃
            AddTranslation("Set Ablaze", "燎");
            // 对方所有卡牌将失去2点生命值（但不会阵亡）且攻击力增加1点。
            AddTranslation("Every card on the opposite side will lose 2 health (without perishing) and have their attack increased by 1.", "敌侧诸牌皆损二命，不死，而威加一。");
            // 一次性法术
            AddTranslation("One Time Spell", "一度术");
            // 当回合结束时，带有该印记的法术会阵亡并从你的牌组移除。
            AddTranslation("When the turn ends, a spell bearing this sigil will perish and be removed from your deck.", "合终，负此技之术死，而削于乃牌列。");
            // 贪欲之壶
            AddTranslation("Vase of Greed", "贪壶");
            // 当带有该印记的法术牌被使用时，弃掉当前手牌并抽取4张新牌。
            AddTranslation("When a spell bearing this sigil is played, discard your current hand and draw 4 new cards.", "负此技之术既陈，弃今手，而更引四牌。");
            // 侏儒化
            AddTranslation("Gnomification", "侏化");
            // 选择一个空位召唤侏儒卡牌。
            AddTranslation("Select a slot to summon a Gnome card in.", "择一空位，召一侏牌。");
            // 诅咒
            AddTranslation("Cursed", "诅");
            // 带有该印记的法术牌打出时会立即阵亡。
            AddTranslation("When a spell bearing this sigil is played, it will immediately perish.", "负此技之术既陈，即死。");
            // 灵感
            AddTranslation("Inspiration", "灵悟");
            // 选择一张卡牌使其获得空袭与劫掠者效果，持续1回合。
            AddTranslation("Select a card to give Airborne + Looter for 1 turn.", "择一牌，使一合得翔袭、掠者。");
            // 微积
            AddTranslation("Calculus", "筹算");
            // 选择一张卡牌交换其属性。
            AddTranslation("Select a card to swap stats.", "择一牌，易其数。");
            // 狂怒
            AddTranslation("Rage", "怒");
            // 选择一张卡牌消灭。该卡牌的对手本体将受到等同于被消灭卡牌生命值的伤害。
            AddTranslation("Select a card to kill. The opponent of the card will recieve damage equal to the amount of health the card had.", "择一牌杀之；其敌主受伤，如其故命。");
            // 火球术
            AddTranslation("Fireball", "火丸");
            // 选择一张卡牌使其受到2点伤害。
            AddTranslation("Select a card to take 2 damage.", "择一牌，使受二伤。");
            // 冰封之触
            AddTranslation("Cold to the Touch", "寒触");
            // [creature]攻击其他卡牌时，被攻击卡牌会失去1点力量。
            AddTranslation("When a card bearing this sigils attack another card, that card will lose 1 attack.", "负此技之牌攻他牌，则彼威损一。");
            // 冰封
            AddTranslation("Frozen", "冰封");
            // 每回合结束时，该卡牌会失去冰封生命值。当冰封生命值耗尽或该卡牌受到攻击时，将解除冰封状态。
            AddTranslation("At the end of each turn, this card will lose its frozen health. When all frozen health is depleted, or this card is struck, it will defrost.", "每合终，此牌损其冰命。冰命尽，抑受击，则解冰。");
            // 强力牵引
            AddTranslation("Strong Pull", "强引");
            // 所有敌方卡牌都会优先攻击此卡而非其他目标。
            AddTranslation("Every opposing card will be inclined to hit this card instead of any other.", "敌诸牌皆先击此牌，不及他。");
            // 置换反应
            AddTranslation("Displacement", "置换");
            // 抽到[creature]时，会随机将一张同名卡牌加入你的牌组。
            AddTranslation("When a card bearing this sigil is drawn, another of this card will be added randomly into your deck", "引负此技之牌时，偶益一同牌于乃牌列。");
            // 宝石清算
            AddTranslation("Gem Reckoning", "玉算");
            // 每回合结束时，若持牌人未打出任何宝石，则弃置你手牌最左侧的卡牌。
            AddTranslation("At the end of each turn, if the owner of this card does not control any gems, the leftmost card in your hand is discarded.", "每合终，若此牌之主无玉，则弃汝手最左之一牌。");
            // 玛珂力量
            AddTranslation("Mox Power", "玛珂威");
            // 该印记代表的数值等于持牌人侧牌桌上存在的玛珂牌数量。
            AddTranslation("The value represented with this sigil will be equal to the number of Mox Cards that the owner has on their side of the table.", "此技所指之值，如持牌者之侧局上玛珂牌之数。");
            // 玛珂生命
            AddTranslation("Mox Health", "玛珂命");
            // 烛火临近
            AddTranslation("Candle Proximity", "近烛");
            // 该印记代表的数值等于此卡牌与桌上蜡烛之间的距离。
            AddTranslation("The value represented with this sigil will be equal to how close this card is to the Candle on the table.", "此技所指之值，如此牌至局上烛之距。");
            // 杀戮之力
            AddTranslation("Murder Power", "戮威");
            // 该印记代表的数值等于对手牌桌上所有造物的力量总和。
            AddTranslation("The value represented with this sigil will be equal the total amount of power on the opponents board.", "此技所指之值，如敌局诸物威之和。");
            // 该印记代表的数值等于你牌桌上所有造物力量总和的一半。
            AddTranslation("The value represented with this sigil will be equal to half the total amount of power on your board.", "此技所指之值，如汝局诸物威和之半。");
            // 法术力量
            AddTranslation("Spell Power", "术威");
            // 该印记代表的数值等于当前地牢中已施放的法术总数。
            AddTranslation("The value represented with this sigil will be equal to total amount of spells played during this current dungeon.", "此技所指之值，如此窟所施诸术之数。");
            // 该印记代表的数值等于战斗期间已施放的法术总数。
            AddTranslation("The value represented with this sigil will be equal to total amount of spells played during the battle.", "此技所指之值，如此战所施诸术之数。");
            // 反击力量
            AddTranslation("Counterbattery Power", "反击威");
            // 该印记代表的数值等于本场战斗你受到的总伤害值除以二。
            AddTranslation("The value represented with this sigil will be equal to the amount of damage taken by you this battle, divided by two.", "此技所指之值，如此战汝所受伤之半。");
        }
    }
}
