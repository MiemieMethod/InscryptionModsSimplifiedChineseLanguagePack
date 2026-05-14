using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch76
    {
        public static void RegisterTranslations()
        {
            RegisterWhistleWindAbnormalSigilsThree();
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

        private static void RegisterWhistleWindAbnormalSigilsThree()
        {
            // [creature]治愈邻近的造物。
            AddTranslation("[creature] heals adjacent creatures.", "[creature]疗邻物。");
            // 回归手牌
            AddTranslation("Return Card to Hand", "归手");
            // 将所选卡牌归还回至你手中，并保留所有更改和属性。根据最近放置的卡牌时间，将所选卡牌的成本更改为0-2块骨头。
            AddTranslation("Returns the selected card to your hand with all changes and statuses retained. Change the selected card's cost to 0-2 Bones based on how recently it was played.", "使所择之牌归汝手，而诸改与诸状皆存。其直随其新旧，改为零至二骨。");
            // 回归虚无
            AddTranslation("Return to Nihil", "归虚");
            // 在持牌人的回合结束时，[creature]将对场上的所有其他卡牌造成与此牌力量值相等的伤害。
            AddTranslation("At the end of the owner's turn, deal damage equal to this card's Power to all other cards on the board.", "持牌者合终，[creature]伤局上他牌皆如其威。");
            // 离遗忘又近了一步。
            AddTranslation("One step closer to oblivion.", "去忘又近一步。");
            // 虚空召唤。
            AddTranslation("The void calls.", "虚召矣。");
            // 法定继承者
            AddTranslation("Rightful Heir", "正嗣");
            // 每回合一次，消耗[sigilcost:1根骨头]将选定的造物变成南瓜，然后将此印记的激活成本增加1。[define:wstl_ozmaPumpkin]
            AddTranslation("Once per turn, pay [sigilcost:1 Bone] to transform a chosen creature into a Pumpkin, then increase this sigil's activation cost by 1. [define:wstl_ozmaPumpkin]", "每合一次，费[sigilcost:1 Bone]使所择之物化为南瓜，而后此印启直益一。[define:wstl_ozmaPumpkin]");
            // 每回合一次，消耗1根骨头将选定的造物变成南瓜，然后将此印记的激活成本增加1。[define:wstl_ozmaPumpkin]
            AddTranslation("Once per turn, pay 1 bone to transform a chosen creature into a Pumpkin, then increase this sigil's activation cost by 1. [define:wstl_ozmaPumpkin]", "每合一次，费骨一使所择之物化为南瓜，而后此印启直益一。[define:wstl_ozmaPumpkin]");
            for (int count = 0; count <= 100; count++)
            {
                // 每回合一次，消耗{count}根骨头将选定的造物变成南瓜，然后将此印记的激活成本增加1。[define:wstl_ozmaPumpkin]
                AddTranslation("Once per turn, pay " + count.ToString() + " bones to transform a chosen creature into a Pumpkin, then increase this sigil's activation cost by 1. [define:wstl_ozmaPumpkin]", "每合一次，费骨" + count.ToString() + "使所择之物化为南瓜，而后此印启直益一。[define:wstl_ozmaPumpkin]");
            }
            // 她现在只剩下孩子了。
            AddTranslation("All she has left now are her children.", "今其所余，惟子耳。");
            // [creature]把造物变成南瓜。
            AddTranslation("[creature] turns the creature into a pumpkin.", "[creature]化其物为南瓜。");
            // 缠根
            AddTranslation("Roots", "根缠");
            // 放置[creature]时，在相邻的空位生成刺藤。[define:wstl_snowWhitesVine]
            AddTranslation("When this card is played, create Thorny Vines on adjacent empty spaces. [define:wstl_snowWhitesVine]", "[creature]既陈，则邻空位生棘藤。[define:wstl_snowWhitesVine]");
            // 怨恨像野草一样爆发。
            AddTranslation("Resentment bursts forth like a weed.", "怨如莠而暴发。");
            // 尖锐的刺在[creature]周围射出！
            AddTranslation("Sharp thorns shoot out around [creature]!", "利棘四发于[creature]旁！");
            // 烈炎
            AddTranslation("Scorching", "灼");
            // 与[creature]对位的造物在回合结束时受到1点伤害。
            AddTranslation("The creature opposing this card takes 1 damage at the end of its owner's turn.", "[creature]对位之物，于其主合终受一伤。");
            // 缓慢而痛苦的死亡。
            AddTranslation("A slow and painful death.", "徐而痛之死也。");
            // 对抗[creature]的造物被烧毁了！
            AddTranslation("The creature opposing [creature] is burned!", "与[creature]对之者灼矣！");
            // 扰频器
            AddTranslation("Scrambler", "乱数者");
            // 当[creature]被献祭时，将其属性提供给献祭其上场的牌，然后将最终属性随机化。
            AddTranslation("When [creature] is sacrificed, give its stats to the sacrificing card then randomise the resulting stats.", "[creature]见祀，则以其数授受祀之牌，而后乱其成数。");
            // 当[creature]被献祭时，自身属性提供给献祭它上场的牌，然后将最终属性随机化。适用于法术。
            AddTranslation("When [creature] is sacrificed, give its stats to the sacrificing card then randomise the resulting stats. Works for Spells.", "[creature]见祀，则以其数授受祀之牌，而后乱其成数。术亦然。");
            // 你爱你的城市吗？
            AddTranslation("Do you love your city?", "汝爱汝城乎？");
            // 裸巢
            AddTranslation("Serpent's Nest", "蛇巢");
            // 当[creature]被攻击时，攻击者获得一点裸虫值。
            AddTranslation("When [creature] is struck, the striker gains 1 Worms.", "[creature]见击，则击者得裸虫一。");
            // 它可以通过任何孔进入你的身体。
            AddTranslation("It can enter your body through any aperture.", "其可由诸孔入汝身。");
            // 史莱姆之身
            AddTranslation("Made of Slime", "胶躯");
            // 在持牌人的回合结束时，[creature]将给予相邻的卡牌此印记，如果这张牌不是史莱姆，则对其造成1点伤害。此牌在死亡时会变成史莱姆。
            AddTranslation("At the end of the owner's turn, give adjacent cards this sigil, and deal 1 damage to this card if it is not a Slime. This card transforms into a Slime on death.", "持牌者合终，[creature]以此印授邻牌；若其非胶，则自受一伤。此牌死则化为胶。");
            // 它的军队每天都在壮大。
            AddTranslation("Its army grows everyday.", "其众日长。");
            // [生物]融化成史莱姆！
            AddTranslation("[creature] melts into slime!", "[creature]融为胶矣！");
            // 孢子囊
            AddTranslation("Sporogenic", "散孢");
            // 与[creature]相邻的造物在其持牌人的回合结束时获得1个孢子。此印记将在其他印记之前生效。
            AddTranslation("Creatures adjacent to this card gain 1 Spores at the end of its owner's turn. This sigil activates before other sigils.", "邻于[creature]之物，于其主合终得孢一。此印先于他印而发。");
            // 它们会像爱祝福一样爱这个诅咒。
            AddTranslation("They will love this curse like a blessing.", "彼将爱此诅如祝。");
            // [creature]在相邻的卡牌上散布孢子！
            AddTranslation("[creature] scatters spores on the adjacent cards!", "[creature]散孢于邻牌矣！");
            // 团队领袖
            AddTranslation("Team Leader", "领队");
            // 当[creature]在场上时，所有友方造物都会获得1点力量。
            AddTranslation("While this card is on the board, all allied creatures gain 1 Power.", "[creature]在局，则友诸物威益一。");
            // 你的野兽让它的盟友更加大胆。
            AddTranslation("Your beast emboldens its allies.", "汝兽壮其友志。");
            // 列车
            AddTranslation("The Train", "列车");
            // 放置[creature]时，杀死场上的所有造物。以这种方式杀死的造物不会掉骨头。
            AddTranslation("When [creature] is played, kill all creatures on the board. Creatures killed this way do not drop bones.", "[creature]既陈，则局上诸物尽死。由此死者不出骨。");
            // 列车会消灭那些没有离开轨道的造物。
            AddTranslation("The train boards those that don't step away from the tracks.", "列车碾不避轨者。");
            // 列车鸣响警笛。
            AddTranslation("The train blows its mighty horn.", "列车鸣其巨角。");
            // 茂密皮毛
            AddTranslation("Thick Skin", "厚皮");
            // 每当[creature]受到伤害时，该伤害-1。
            AddTranslation("Whenever [creature] takes damage, reduce that damage by 1.", "[creature]凡受伤，则其伤减一。");
            // 你的造物的皮毛吸收了打击。
            AddTranslation("Your creature's hide absorbs the blow.", "汝物之皮受其击矣。");
            // [creature]吸收了这一击。
            AddTranslation("[creature] absorbs the blow.", "[creature]受其击矣。");
            // 易爆
            AddTranslation("Volatile", "躁爆");
            // 当[creature]死亡时，相邻和对位的卡牌将受到10点伤害。
            AddTranslation("When this card dies, adjacent and opposing cards are dealt 10 damage.", "[creature]死，则邻牌与对牌受伤十。");
            // 爆炸性的完成。
            AddTranslation("An explosive finish.", "爆而终焉。");
            // [creature]爆炸了！邻近的造物在爆炸中被杀死。
            AddTranslation("[creature] detonates! Adjacent creatures are killed in the blast.", "[creature]爆矣！邻物皆死于其炎。");
            // 目击者
            AddTranslation("Witness", "见者");
            // 消耗2根骨头，使所选造物的生命值增加2，受到的伤害增加1。此效果可叠加3次。
            AddTranslation("Pay 2 Bones to increase the selected creature's Health by 2 and their taken damage by 1. This effect stacks up to 3 times.", "费骨二，使所择之物命益二，而所受伤益一。此效至三重。");
            // 真相会让你获得自由。
            AddTranslation("The truth will set you free.", "真将释汝。");
            // 被选中的造物看到[creature]并获得新生。
            AddTranslation("The chosen beholds [creature] and is reborn.", "所择者见 [creature] 而更生。");
            // 樵夫
            AddTranslation("Woodcutter", "樵者");
            // 当其他造物移动到[creature]对面的空间时，它们受到等于[creature]力量值的伤害。
            AddTranslation("When a creature moves into the space opposite this card, they take damage equal to this card's Power.", "有物移至[creature]对位，则受其威等数之伤。");
            // 无论有多少棵树倒下，森林仍然茂密。
            AddTranslation("No matter how many trees fall, the forest remains dense.", "木虽多仆，林犹密也。");
            // [creature]自由摆动。
            AddTranslation("[creature] takes a free swing.", "[creature]乘势一挥。");
            // 在持牌人的回合结束时，[creature]会按印记标注的方向移动，在持牌人的场地上循环。友方造物会尽可能朝着这张牌运动的方向前进。
            AddTranslation("At the end of its owner's turn, this card moves in the sigil's direction, looping around the owner's side of the board. Allied creatures towards this card in the sigil's direction as far as possible.", "持牌者合终，[creature]循印所志而移，环行于其主场侧；友方诸物亦尽所能随其向而进。");
            // 我们一起走吧。
            AddTranslation("Let's go, together.", "其偕行矣。");
            // [creature]带领你的造物前进。
            AddTranslation("[creature] leads your creatures forward.", "[creature]导汝诸物而进。");
            // [creature]不受死神之触、臭臭、惩罚者、诅咒和偶像印记的影响。
            AddTranslation("A card bearing this sigil is immune to the effects of Touch of Death, Stinky, Punisher, Cursed, and Idol.", "负此印之牌，不受死触、恶臭、罚者、诅与偶之效。");
            // 相邻造物获得的力量等于带有该印记的卡牌的基础力量的一半，四舍五入。下一回合，此印记效果会发生变化。
            AddTranslation("Adjacent creatures gain Power equal to half this card's base Power, rounded down. This effect changes next turn.", "邻物得威等于此牌本威之半，余者舍。此效次合更易。");
            // 场上的友方造物获得的力量等于带有该印记的卡牌基础力量的一半，四舍五入。下一回合，此印记效果会发生变化。
            AddTranslation("Allied creatures on the board gain Power equal to half this card's base Power, rounded down. This effect changes next turn.", "局上友物得威等于此牌本威之半，余者舍。此效次合更易。");
            // 场上的所有其他造物获得与带有该印记的卡牌的力量值相等的力量。
            AddTranslation("All other creatures on the board gain Power equal to this card's Power.", "局上诸他物得威等于此牌之威。");
            // 没有你可以选择的卡牌。
            AddTranslation("There are no cards you can choose.", "无可择之牌。");
            // 你不能瞄准空气。
            AddTranslation("You can't target the air.", "不得指虚空。");
            // 你必须从其他卡牌中选择一张。
            AddTranslation("You must choose one of your other cards.", "汝须择他牌之一。");
            // 它已经锁上了……
            AddTranslation("It's already latched...", "其已见契矣……");
            // 你必须从其他卡牌中选择一张。
            AddTranslation("You must choose one of your other cards.", "汝须择他牌之一。");
            // 这个世界上有些东西太独特了，无法复制。
            AddTranslation("Some things in this world are too unique to replicate.", "世有物太独，不可摹也。");
            // 谎言破灭了，暴露了你可怜的真实自我。
            AddTranslation("The lie falls apart, revealing your pitiful true self.", "其伪既解，乃露汝可哀之真形。");
            // 你的造物构造太弱了。
            AddTranslation("Your creature's consitution is too weak.", "汝物之质太弱矣。");
        }
    }
}
