using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch37
    {
        public static void RegisterTranslations()
        {
            RegisterAllTheSigilsBatchOne();
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

        private static void RegisterAllTheSigilsBatchOne()
        {
            // 酸液滩
            AddTranslation("Acid Puddle", "酸沼");
            // 一滩酸液，摸起来很危险。
            AddTranslation("A puddle of Acid, dangerous to the touch", "酸潴一滩，触之则危。");
            // 鹿角兔
            AddTranslation("Jackalope", "鹿角兔");
            // 杰卡
            AddTranslation("Jacka", "杰卡");
            // 五谷丰登
            AddTranslation("Abundance", "丰");
            // [creature]死亡时，每有一个五谷丰登的实例，就会获得一个货币。
            AddTranslation("[creature] will grant one tooth per instance of Abundance when killed.", "[creature]死时，每有一重丰，得一齿。");
            // 酸性痕迹
            AddTranslation("Acidic Trail", "酸迹");
            // 在持牌人回合结束时，[creature]将沿印记标注的方向移动，如果能够移动，则对其对位造物造成1点伤害。
            AddTranslation("At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil, and deal 1 damage to the opposing creature if it is able to move.", "持牌者合终，[creature]循印所志之向而移；若能移，则伤其对物一。");
            // 脆骨激转
            AddTranslation("Activated Latch Brittle", "启脆");
            // 激活时消耗1点能量，将允许持牌人给予一个造物脆骨印记。
            AddTranslation("When activated for a cost of 1 energy will allow the owner to give a creature Brittle.", "启之而费一能，则持牌者可予一物以脆骨。");
            // 炸弹激转
            AddTranslation("Activated Latch Explode On Death", "启殉爆");
            // 激活时消耗1点能量，将允许持牌人给予一个造物引爆器印记。
            AddTranslation("When activated for a cost of 1 energy will allow the owner to give a creature Explode On Death.", "启之而费一能，则持牌者可予一物以死爆。");
            // 坚盾激转
            AddTranslation("Activated Latch Nano Shield", "启坚盾");
            // 激活时消耗1点能量/2根骨头，将允许持牌人给予一个造物纳米铠甲。
            AddTranslation("When activated for a cost of 1 energy / 2 bones will allow the owner to give a creature Nano Shield.", "启之而费一能或二骨，则持牌者可予一物以坚盾。");
            // 高跳激转
            AddTranslation("Activated Latch Reach", "启高跃");
            // 激活时消耗2点能量，将允许持牌人给予一个造物高跳印记。
            AddTranslation("When activated for a cost of 2 energy will allow the owner to give a creature Reach.", "启之而费二能，则持牌者可予一物以高跃。");
            // 敏捷
            AddTranslation("Agile", "捷");
            // 当[creature]将被击中时，它会跳开躲避。
            AddTranslation("When [creature] would be struck, it will move out of the way.", "[creature]将见击，则避而移。");
            // 这张牌为了保全自己而跳到一边……
            AddTranslation("The Card jumped out of the way to save itself...", "此牌跃而自全矣……");
            // 他们留下的痕迹让人生疼。
            AddTranslation("The trail they leave behind, hurts.", "其所遗之迹，伤人。");
            // 全知之眼
            AddTranslation("All seeing", "全见");
            // 当[creature]在场时，同侧场上的所有会说话的卡牌获得+2生命。
            AddTranslation("While [creature] is on the board, all talking cards on your side of the board get +2 health.", "凡[creature]在局，汝侧诸言牌命益二。");
            // 交替爪迹
            AddTranslation("Alternating Scratch", "交爪");
            // 当[creature]攻击时，它还会攻击对位相邻的空间，它将攻击的相邻位置将在每个对手回合结束时在左右之间切换。
            AddTranslation("When [creature] attacks it will also attack a space adjacent to the attacked slot, the adjacent slot that it will attack will change between left or right at the end of each opponent's turn.", "[creature]攻时，亦击所攻位旁一位；所击之旁位，每敌合终，左右迭易。");
            // 伏击
            AddTranslation("Ambush", "伏");
            // 当造物移动到与[creature]相对的空间时，它们会受到1点伤害。
            AddTranslation("When a creature moves into the space opposing [creature], they are dealt 1 damage.", "有物移至与[creature]相对之位，则受一伤。");
            // 鹿角商
            AddTranslation("Antler Bearer", "荷角");
            // 当[creature]被消灭时，随机获得三张随机有蹄类族群卡牌。
            AddTranslation("When [creature] is killed, gain three random hooved tribe cards.", "[creature]死，则得蹄属之牌三，皆偶然。");
            // 牧群聚在一起。
            AddTranslation("The herd sticks together.", "群蹄相附。");
            // 屏蔽
            AddTranslation("Shielded", "蔽");
            // 当[creature]受到伤害时，造成的伤害减半，向下取整。
            AddTranslation("When [creature] is dealt damage, the damage dealt is halved, rounded down.", "[creature]受伤，其伤减半，分奇则舍。");
            // 休眠
            AddTranslation("Asleep", "寐");
            // [creature]只要拥有此印记，攻击力为0，玩家回合开始时，此印记将从[creature]上移除。
            AddTranslation("[creature] has 0 attack for as long as it has this sigil, at the start of the player's turn this sigil will be removed from [creature].", "[creature]有此印时，威为零；及玩家合始，此印自去。");
            // 钓饵
            AddTranslation("Bait", "饵");
            // 当对侧上场卡牌时，若没有与[creature]相对位的卡牌，该造物将移动到[creature]的对位。
            AddTranslation("When an opposing creature is played and there is no card opposite of [creature], the opposing creature will move to that spot.", "敌物既陈，而[creature]对位无牌，则彼移就其位。");
            // 卓越祭品
            AddTranslation("Noble Sacrifice", "贵祭");
            // [creature]在献祭时可算作2点血量，而非1点。
            AddTranslation("[creature] is counted as 2 blood rather than 1 blood when sacrificed.", "[creature]祀时计二血，不一。");
            // 枯萎之血
            AddTranslation("Blight", "凋血");
            // 当[creature]被献祭时，献祭其上场的卡牌减去其属性值。
            AddTranslation("When [creature] is sacrificed, it subtracts its stat values to the card it was sacrificed for.", "[creature]祀时，所为而陈之牌减其数。");
            // 随机打击
            AddTranslation("Random Strike", "漫击");
            // [creature]攻击时会随机打击对手槽位。
            AddTranslation("[creature] will strike at opponent slots randomly when it attacks.", "[creature]攻时，漫击敌位。");
            // 致盲打击
            AddTranslation("Blinding Strike", "盲击");
            // 当[creature]对另一造物造成伤害时，该造物获得随机打击印记。
            AddTranslation("When [creature] damages another creature, that creature gains the Random Strikes Sigil.", "[creature]伤他物，则彼得漫击印契。");
            // 它们的攻击如此..宽广……
            AddTranslation("They strike widly...", "其击乱矣……");
            // 血液生长
            AddTranslation("Blood Growth", "长血");
            // 当[creature]攻击时，其作为祭品时计算的血量将会增加。
            AddTranslation("When [creature] attacks, the amount of blood it is counted as when sacrificed will increase.", "[creature]攻，则祀时所计之血益。");
            // 血液中蕴含力量。
            AddTranslation("There is power in the blood.", "血中有威。");
            // 鲜血吞噬者
            AddTranslation("BloodGuzzler", "饮血者");
            // [creature]造成伤害时，每造成1点伤害便获得1点生命值。
            AddTranslation("[creature] deals damage, it gains 1 Health for each damage dealt.", "[creature]出伤，每伤一，命益一。");
            // 从血中获得生命。
            AddTranslation("Gain life from the blood.", "饮血而生。");
            // 嗜血易形
            AddTranslation("Blood shifter", "血移");
            // 当[creature]杀死另一张牌时，它将变成那张牌。
            AddTranslation("When [creature] kills another card, it will turn into that card.", "[creature]杀他牌，则化为彼牌。");
            // 保镖
            AddTranslation("Bodyguard", "卫");
            // 如果相邻的位置将受到攻击，攻击者会改为攻击[creature]。
            AddTranslation("[creature] will redirect the initial attack of a card to it, if the attack was targeting a card in an adjacent space.", "相邻之位将见攻，则其初击改归[creature]。");
            // 一位致死也要坚持守护的保镖。
            AddTranslation("A protector, till the very end.", "卫之至终。");
            // 投弹虫
            AddTranslation("Bombardier", "投爆者");
            // [creature]将在每个持牌人的回合结束阶段对场上任何一个随机造物造成10点伤害。
            AddTranslation("[creature] will deal 10 damage to a random creature during the end phase of the owner's turn.", "持牌者合终，[creature]随机伤一物十。");
            // 情同手足
            AddTranslation("Bond", "契");
            // 当[creature]左侧有卡牌时，[creature]将增加1点力量；当[creature]右侧有卡牌时，[creature]将增加1点生命。
            AddTranslation("Any creatures adjacent to [creature] will gain either +1 attack or +1 health, depending on which stat it is closest to.", "[creature]旁诸物，或威益一，或命益一，视其所近之数而定。");
            // [creature]死亡时没有骨头，所有印记给予的额外骨头将不生效。
            AddTranslation("[creature] gives no bones! Any bones gained from sigils or death will be negated.", "[creature]不出骨！凡由印契或死所得之骨，皆不算。");
            // 这个造物没有骨头！
            AddTranslation("That creature has no bones!", "彼物无骨！");
            // 衔骨者
            AddTranslation("Bone Picker", "衔骨者");
            // [creature]每杀死一个造物，将生成1根骨头。
            AddTranslation("[creature] kills a creature, it will generate 1 Bone.", "[creature]杀一物，则生一骨。");
            // 骨头碎片
            AddTranslation("Bone Shard", "骨屑");
            // [creature]被击中时，如果存活下来，将给予持有者1根骨头。
            AddTranslation("[creature] will generate 1 bone when hit, if it lives through the attack.", "[creature]见击而不死，则生一骨。");
            // 一块骨头的碎片。
            AddTranslation("A splinter of bone.", "骨之一屑。");
            // 盒中之物
            AddTranslation("Box", "匣");
            // [creature]死亡时将从你的牌组中移除，并在你的卡组中添加一个包含其中的新造物。
            AddTranslation("[creature] will get removed from your deck on death, and a new creature contained within will be added to it.", "[creature]死，则自汝牌列去；匣中别物入焉。");
            // 破碎
            AddTranslation("Broken", "残");
            // [creature]死亡后将永久从你的牌组中移除。
            AddTranslation("[creature] is permanently removed from your deck if it dies.", "[creature]若死，永出汝牌列。");
            // [creature]在燃烧，并在每个回合结束时获得1点力量并失去1点生命值。可由防火免疫。
            AddTranslation("[creature] is on fire, and will gain 1 power and loose 1 health each upkeep. Blocked by Fire Resistance.", "[creature]在火中，每合始威益一而命损一；火拒可遏之。");
            // 它在燃烧时狂暴。
            AddTranslation("It rampages while on fire.", "火中而狂。");
            // 在其持有者的回合结束时，[creature]将朝着印记标注的方向移动，并在其原位置留下一个酸液滩。
            AddTranslation("At the end of the towner's turn, [creature] will move in the direction inscribed in the sigil, and drop an acid puddle in their old space.", "持牌者合终，[creature]循印所志之向而移，而遗一酸沼于故处。");
            // [creature]被计为一只鸡。
            AddTranslation("[creature] counts as a Chicken.", "[creature]计作一鸡。");
            // 舞蹈编排
            AddTranslation("Choreography", "舞度");
            // 激活后，[creature]将循环：不动、向左移动和向右移动。在持牌人回合结束时，[creature]将按照选择的方式移动。
            AddTranslation("On activation [creature] will cycle through: don't move, move left and move right. At the end of the owner's turn [creature] will move in the chosen way.", "启之，则于不动、左移、右移三者循环；持牌者合终，[creature]依所择而移。");
            // 硬币寻找者
            AddTranslation("Coin Finder", "索箔");
            // 在持牌人的回合结束时，[creature]将赋予其1枚硬币。
            AddTranslation("At the end of the owner's turn, [creature] will grant the owner 1 foil.", "持牌者合终，[creature]予其主一箔。");
            // 这颗牙齿是你的意愿吗？
            AddTranslation("A tooth for your thoughts?", "以一齿问汝心乎？");
            // 消费者
            AddTranslation("Consumer", "啖");
        }
    }
}
