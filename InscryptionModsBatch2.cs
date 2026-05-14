using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch2
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraAbilities();
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

        private static void RegisterGrimoraAbilities()
        {
            // 当敌方造物阵亡时，[creature]会储存1个灵魂能量（上限4个）。激活该印记可为当前能量计数器增加3点能量，并提升1点能量上限。
            AddTranslation("When an opponent creature perishes, [creature] will store a charge of soul energy, up to 4. Activating this sigil will add 3 soul energy to your current energy counter, and one max energy.", "敌物死，[creature]藏一蓄魂能，至四而止。按发此印技，则今能计加三，并益一能极。");
            // 加权骰子
            AddTranslation("Weighted Die", "权骰");
            // 消耗2根骨头，使[creature]的力量随机变为0至5之间的数值。
            AddTranslation("Pay 2 Bones for the power of [creature] to be randomized between 0 and 5.", "费2骨，使[creature]之威偶为零至五。");
            // [creature]会交替攻击其左右两侧的对面位置。
            AddTranslation("[creature] alternates between striking the opposing space to the left and right from it.", "[creature]迭击其左、右之对位。");
            // [creature]不受船只移动的影响。
            AddTranslation("[creature] is unaffected by the motion of the ship.", "[creature]不为舟行所移。");
            // [creature]会攻击相邻位置，以及正对面的左右两侧和中间位置各一次。
            AddTranslation("[creature] will strike its adjacent slots, and each opposing space to the left, right, and center of it.", "[creature]击其邻位，并其对面左、右、中位。");
            // [creature]死亡时不会产生骨头。
            AddTranslation("[creature] yields no bones upon death.", "[creature]死不生骨。");
            // 当[creature]击杀其他造物时，获得2根骨头。
            AddTranslation("When [creature] kills another creature, gain 2 bones.", "[creature]杀他物，则得二骨。");
            // [creature]在每回合结束时从你这里获取1个灵魂，并将其储存为2根骨头，最多可储存8根。当[creature]死亡时，你将获得其中储存的所有骨头。
            AddTranslation("[creature] takes 1 Soul from you at the end of every turn and stores it as 2 Bones, up to a maximum of 8. When [creature] dies, you gain all bones contained in it.", "[creature]每合终取汝一魂，藏为二骨，至八而止。[creature]死，则汝得其所藏诸骨。");
            // [creature]会强化持牌人侧牌桌上的所有骷髅牌，使其力量增加1点。
            AddTranslation("[creature] empowers each Skeleton on the owner's side of the board, providing a +1 buff to their power.", "[creature]益持牌者之侧局诸枯骨，各加一威。");
            // 海洋船歌
            AddTranslation("Sea Shanty", "海谣");
            // [creature]会随机攻击正对面的左右两侧和中间位置，最多攻击3次。
            AddTranslation("[creature] will strike the opposing slots to the left, right, and center of it randomly, up to 3 times.", "[creature]偶击其对面左、右、中位，至三击而止。");
            // 当[creature]阵亡时，若对面的卡牌未被冻结，则将其冰封禁锢。
            AddTranslation("When [creature] perishes, the card opposing it is Frozen Away if not already frozen.", "[creature]死，则其对位之牌若未冰藏，即冰藏之。");
            // 当[creature]死亡时，若道具栏有空位，则获得一个消耗品道具。
            AddTranslation("When [creature] dies, gain a consumable item, if you have a free slot.", "[creature]死，若器位有隙，则得一器。");
            // 使用[creature]时，己方所有空位均会出现骷髅牌。[define:Skeleton]
            AddTranslation("When [creature] is played, a Skeleton is created in each empty space on the owner's side. [define:Skeleton]", "[creature]既陈，持牌者之侧局诸空处各生一枯骨。[define:Skeleton]");
            // 骷髅军团
            AddTranslation("Skeleton Horde", "枯骨群");
            // 寻船者
            AddTranslation("Shipwreck Finder", "寻沉舟者");
            // 使用[creature]时，相邻空位均会出现沉船的浮木残骸。[define:arackulele.inscryption.grimoramod_Shipwreck_Dams]
            AddTranslation("When [creature] is played, a Shipwreck is created on each empty adjacent space. [define:arackulele.inscryption.grimoramod_Shipwreck_Dams]", "[creature]既陈，每邻之空处各生一沉舟。[define:arackulele.inscryption.grimoramod_Shipwreck_Dams]");
            // 骸骨之躯
            AddTranslation("Skeletons Within", "中有枯骨");
            // [creature]受到攻击时，可从骷髅堆中抽一张牌。
            AddTranslation("Once [creature] is struck, draw a card from your Skeleton pile.", "[creature]既受击，则自乃枯骨积引一牌。");
            // 糖果满溢
            AddTranslation("Full o' candy", "糖盈");
            // [creature]死亡时将掉落糖果，或许之后能派上用场。
            AddTranslation("[creature] will yield candy upon death, maybe this will be useful for later.", "[creature]死，则遗糖，后或有用。");
            // 持牌人回合结束时，[creature]将随机选择一个方向移动。
            AddTranslation("At the end of the owner's turn, [creature] will move in a random direction.", "持牌者合终，[creature]偶移一方。");
            // [creature]移动时会在路径上留下余烬轨迹。[define:arackulele.inscryption.grimoramod_Flames]
            AddTranslation("Whenever [creature] moves, it leaves a trail of Embers. [define:arackulele.inscryption.grimoramod_Flames]", "凡[creature]移，则遗烬迹。[define:arackulele.inscryption.grimoramod_Flames]");
            // 守护者
            AddTranslation("Guarding Presence", "守者");
            // 如对手的造物对面位置是空的，则[creature]会进入那个位置。
            AddTranslation("When an opposing creature is placed opposite to an empty space, [creature] will move to that empty space.", "敌物若陈于空位之对位，[creature]即移以御之。");
            // 骨饥者
            AddTranslation("Bone Starved", "骨饥");
            // 若你没有骨头，在你的回合开始时[creature]会造成额外2点伤害。
            AddTranslation("If you have no Bones, at the start of your turn [creature] deals 2 more damage.", "若汝无骨，则汝合始，[creature]益伤二。");
            // [creature]会攻击对面每个空间。若对面仅有一个造物，则该卡牌会攻击该造物两次。
            AddTranslation("[creature] will strike each opposing space. If only one creature is in the opposing spaces, this card will strike that creature twice. ", "[creature]击诸对位。若诸对位惟一物，则此牌两击之。");
            // 暴怒巨人
            AddTranslation("Enraged Giant", "怒巨");
            // [creature]会攻击对面所有位置。
            AddTranslation("[creature] will strike each opposing space.", "[creature]击诸对位。");
            // 幼雏
            AddTranslation("Fledgling", "稚雏");
            // [creature]在牌桌上1个回合后将进化为更强大的形态。
            AddTranslation("After one turn on the board, [creature] will evolve into a greater form.", "[creature]居局一合，则进为更上之形。");
            // 无形之物
            AddTranslation("Random Ability", "无形");
            // 抽到[creature]时，此印记将被随机替换为另一印记。
            AddTranslation("When [creature] is drawn, this sigil is replaced with another sigil at random.", "[creature]既引，此印契偶易为他印契。");
            // 当[creature]阵亡时，它会变成原位置的地缚灵。首个打在该位置的造物将继承它的印记。
            AddTranslation("When [creature] perishes, it haunts the space it died in. The first creature played on this space gain its old sigils.", "[creature]死，则祟其死处。后首陈于此处之物，得其故印契。");
            // 魂牵梦萦
            AddTranslation("Haunting Call", "祟呼");
            // [creature]在场时每回合会消耗你一根骨头，若你无骨头可用，该造物将阵亡。
            AddTranslation("Every turn [creature] is on the Board, it will take a Bone from you, if you have no Bones, it perishes.", "凡[creature]在局，每合取汝一骨；若汝无骨，则死。");
            // 当[creature]阵亡时，会将正对面位置的造物拖拽至持牌人侧牌桌。
            AddTranslation("When [creature] perishes, the creature in the opposing slot is dragged onto the owner's side of the board.", "[creature]死，则曳其对位之物至持牌者之侧局。");
            // 当不带有脆骨印记的友方造物阵亡时，[creature]增加1点力量。
            AddTranslation("When a non-brittle ally card perishes, [creature] gains 1 power.", "凡友牌之非脆骨者死，[creature]加一威。");
            // [creature]会以棋盘翻转后的方式攻击对面位置。位于最左侧位置的卡牌将攻击对面的最右侧位置。
            AddTranslation("[creature] will strike the opposing slot as if the board was flipped. A card in the far left slot will attack the opposing far right slot.", "局若反，[creature]乃击其对位；居极左位之牌，将击对面极右位。");
            // [creature]阵亡时，其持牌人需选定下一个继承掘骨人印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Bonedigger sigil.", "[creature]死，则持牌者择一物，受掘骨者印契。");
            // [creature]阵亡时，其持牌人需选定下一个继承水袭印记的造物。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Waterborne sigil.", "[creature]死，则持牌者择一物，受潜袭印契。");
            // [creature]每回合损失1点生命。当[creature]死亡时，正对面的造物以及相邻的友方造物均受到10点伤害。
            AddTranslation("[creature] loses 1 health per turn. When [creature] dies, the creature opposing it, as well as adjacent friendly creatures, are dealt 10 damage.", "[creature]每合损一命。及死，其对位之物与相邻友物皆受十伤。");
            // 当[creature]有可能受到攻击时，会在原地留下一截断肢，[creature]自身则会移动至相邻的空位。
            AddTranslation("When [creature] would be struck, a severed limb is created in its place and this card moves into an adjacent open slot.", "若[creature]将受击，则其处生一断肢，而此牌移于相邻空位。");
            // 每当[creature]直接造成伤害时，会损失1点力量和1点生命。
            AddTranslation("Each time [creature] deals damage directly, it loses 1 power and health.", "每[creature]直伤一次，则损一威一命。");
            // 当使用[creature]时，可免费打出你手牌中与之相邻的所有卡牌。
            AddTranslation("When [creature] is played, also play the cards in your hand that were adjacent to this card for free.", "[creature]既陈，手中与此牌相邻之牌，亦皆无直而陈。");
            // 浇灭
            AddTranslation("Douse", "沃灭");
            // 使用[creature]时，将熄灭牌桌上所有卡牌。
            AddTranslation("When played,[creature] will extinguish all cards on the Board.", "既陈，[creature]尽熄局中诸牌之焰。");
            // [creature]无法从正对面位置被攻击。若可能，正对面位置会转而攻击其相邻的友方卡牌。
            AddTranslation("[creature] cannot be attacked from the opposing slot. The opposing slot, if possible, instead attacks one of its adjacent friendly cards.", "[creature]不可自对位攻之。其对位之物若可，则反攻其相邻一友牌。");
            // 持牌人侧牌桌上的卡牌不受脆骨印记影响。
            AddTranslation("Cards on the owner's side of the field are unaffected by Brittle.", "持牌者之侧局诸牌，不受脆骨之效。");
            // [creature]会攻击其相邻位置，但不会攻击其他劫掠之徒。
            AddTranslation("[creature] will strike its adjacent slots, except other Raiders.", "[creature]击其相邻诸位，惟他掠者不与。");
            // 使用[creature]时，其印记会铭刻到相邻卡牌上。
            AddTranslation("When [creature] is played, it carves its Sigils into adjacent Cards.", "[creature]既陈，以其印契刻于相邻诸牌。");
            // 铭刻师
            AddTranslation("Sculptor", "刻者");
            // [creature]会尝试在相邻的友方位置寻找宿主，藏身其下并提供+1/+1增益。左侧卡牌优先。
            AddTranslation("[creature] will attempt to find a host in an adjacent friendly slot, hiding under it providing a +1/+1 buff. Cards on the left take priority.", "[creature]将求相邻友位之一主，伏其下，而其威与命各加一。左牌为先。");
            // 当[creature]攻击对面卡牌时，目标相邻的一个友方单位也会受到伤害。
            AddTranslation("When [creature] hits an opposing card, one of the targets adjacent allies will take damage as well ", "[creature]击对牌，则其所击者之相邻友牌，亦一受伤。");
            // 当使用[creature]时，能为持牌人提供一个灵魂。
            AddTranslation("When [creature] is played, it provides an energy soul to its owner.", "[creature]既陈，为持牌者益一魂。");
            // 地狱犬之渴
            AddTranslation("HellHound's Thirst", "狱犬之渴");
            // 带有该印记的卡牌会根据玩家当前拥有的骨头数量获得等量攻击力，每根骨头增加1点攻击力。
            AddTranslation("A card bearing this sigil gains 1 attack for each bone the player currently has.", "负此印契之牌，其主今每有一骨，加一威。");
            // 万圣之怒
            AddTranslation("Wrath Of Halloween", "万圣之怒");
            // 带有该印记的卡牌拥有10点力量，索耶每剩余1个糖果桶便增加1点力量。
            AddTranslation("A card bearing this sigil has 10 attack, 1 for each Candy Bucket Sawyer has left.", "负此印契之牌，其威如索耶所余糖桶之数，至十而止。");
            // 可靠的老船员
            AddTranslation("Trusty ol' Crew", "故舟卒");
            // 带有该印记的卡牌会根据场上每名海盗增加1点攻击力。
            AddTranslation("A card bearing this sigil gains 1 attack for every pirate on the board.", "负此印契之牌，局中每有一海上之盗，加一威。");
            // 死物锐击
            AddTranslation("Inanimate Attack", "死物击");
            // 牌桌上每存在一张0点攻击力的卡牌，带有该印记的卡牌就会获得1点攻击力。
            AddTranslation("A card bearing this sigil gains 1 attack for every card that has 0 attack on the board.", "负此印契之牌，局中每有一威为零之牌，加一威。");
            // 半根骨头
            AddTranslation("One Half Bones", "半骨");
            // 该印记代表的数值等于持牌人侧牌桌上存在的兽骨数量。
            AddTranslation("The value represented with this sigil will be equal to the number of Bones that the owner has on their side of the table.", "此印所指之值，如持牌者案上此侧之骨数。");
            // 双重死亡
            AddTranslation("Double Death", "双死");
            // 消耗1个灵魂，使[creature]随机获得1至6点力量。
            AddTranslation("Pay 1 Soul to add power to [creature] randomly between 1 and 6.", "费1魂，使[creature]偶增一至六威。");
            // 消耗2根骨头将[creature]治疗至满生命值
            AddTranslation("Pay 2 Bones to heal [creature] to max health.", "费2骨，疗[creature]至命极。");
            // 交替打击
            AddTranslation("Alternating Strike", "迭击");
            // 锚定
            AddTranslation("Anchored", "系锚");
            // 范围打击
            AddTranslation("Area Of Effect Strike", "广击");
            // 鲜血吞噬者
            AddTranslation("Blood Guzzler", "饮血者");
            // 无骨者
            AddTranslation("Boneless", "无骨者");
            // 窃骨者
            AddTranslation("Bone Thief", "窃骨者");
            // 赏金猎手
            AddTranslation("Bounty", "购");
            // 燃烧
            AddTranslation("Burning", "焚");
            // [creature]在你的回合结束时受到1点伤害；当它被其他卡牌攻击时，攻击者会被点燃。
            AddTranslation("[creature] takes 1 Damage at the end of your turn, when it gets attacked by another Card, that card gets set on fire.", "[creature]于汝合终受一伤；他牌攻之，则彼牌亦被焚。");
            // 混沌打击
            AddTranslation("Chaos Strike", "乱击");
            // 寒流骤至
            AddTranslation("Cold Front", "寒潮");
            // 收藏家
            AddTranslation("Collector", "藏者");
            // 飘忽不定
            AddTranslation("Erratic", "无常");
            // 火焰突袭
            AddTranslation("Flame Strafe", "焰趋");
            // 巨力打击
            AddTranslation("Giant Strike", "巨击");
            // 阴魂不散
            AddTranslation("Haunter", "祟灵");
            // 全套诱饵
            AddTranslation("Hook Line And Sinker", "钩饵俱下");
            // 灌注
            AddTranslation("Imbued", "灌注");
            // 逆反打击
            AddTranslation("Inverted Strike", "逆击");
            // 掘骨传花
            AddTranslation("Latch Bone Digger", "掘骨遗契");
            // 水袭传花
            AddTranslation("Latch Submerge", "潜袭遗契");
            // 引信
            AddTranslation("Lit Fuse", "燃绳");
            // 断肢求逝
            AddTranslation("Loose Limb", "脱肢");
            // 营养不良
            AddTranslation("Malnourishment", "羸馁");
            // 行军亡者
            AddTranslation("Marching Dead", "行尸");
            // 占有欲
            AddTranslation("Possessive", "据有");
            // 傀儡师
            AddTranslation("Puppeteer", "傀师");
            // 劫掠之徒
            AddTranslation("Raider", "掠者");
            // 爬肤者
            AddTranslation("Skin Crawler", "肤行者");
            // 劈砍者
            AddTranslation("Slasher", "斫者");
            // 灵魂商
            AddTranslation("Spirit Bearer", "负魂者");
            // 这张卡牌的力量等于持牌人侧牌桌上存在的绿宝石数量。
            AddTranslation("The power of this card is equal to the number of Green Gems that the owner has on their side of the table.", "此牌之威，如案上持牌者之侧绿玉之数。");
            // 附录12，第一节 - 能力{0}
            AddTranslation("APPENDIX XII, SUBSECTION I - ABILITIES {0}", "附编十二，第一节——诸印技{0}");
            // 附录,12，第二节 - 可变属性{0}
            AddTranslation("APPENDIX XII, SUBSECTION II - VARIABLE STATS {0}", "附编十二，第二节——变数{0}");
        }
    }
}
