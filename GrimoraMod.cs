using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class GrimoraMod
    {
        public static void RegisterTranslations()
        {
            // 启动格里魔拉模组
            AddTranslation("Start Grimora Mod", "启格里魔拉补缀");
            // 重置冒险
            AddTranslation("RESET RUN", "重置此局");
            // 新的莱西冒险
            AddTranslation("NEW LESHY RUN", "新的莱西冒险");
            // 继续莱西冒险
            AddTranslation("CONTINUE LESHY RUN", "继续莱西冒险");
            // 新的格里魔拉冒险
            AddTranslation("NEW GRIMORA RUN", "新的格里魔拉冒险");
            // 继续格里魔拉冒险
            AddTranslation("CONTINUE GRIMORA RUN", "继续格里魔拉冒险");
            // 启用此选项可查看牌组剩余卡牌
            AddTranslation("This option will allow you to see what cards are left in your deck.", "启此，则可观牌列所余诸牌。");
            // 此选项将禁用所有可能导致晕动症或视觉不适的特效
            AddTranslation("This option will disable all effects that might cause motion sickness and other visually jarring effects.", "启此，则凡或致晕动与眩目之效皆废。");
            // 开发者模式：不生成阻挡物。宝箱填充首行，敌人棋子填充首列
            AddTranslation("Does not generate blocker pieces. Chests fill first row, enemy pieces fill first column.", "不生障棋。匮先满首行，敌棋先满首列。");
            // 能量模式：消耗能量的卡牌将同时消耗最大能量值
            AddTranslation("Makes it so Cards that cost energy also take max energy.", "使凡直能之牌，并取能极。");
            // 热重载：将dll置于BepInEx/scripts目录后，可运行特定命令以正确重载技能/卡牌
            AddTranslation("If the dll is placed in BepInEx/scripts, this will allow running certain commands that should only ever be ran to re-add abilities/cards back in the game correctly.", "若置 dll 于 BepInEx/scripts，则可行若干令，以正地复纳诸印技与诸牌于戏中。");
            // 无尽模式：击败格里魔拉后仍可继续使用当前牌组进行游戏
            AddTranslation("For players who want to continue playing with their deck after defeating Grimora.", "为欲既败格里魔拉而犹用其牌列者设。");
            // 遭遇战配置： / 0=默认 使用模组内置方案 / 1=随机 根据模组卡池完全随机生成 / 2=自定义 从JSON文件读取配置 / 3=混合 同时采用默认与自定义方案
            AddTranslation("0 = Default. Use the mod's internal blueprint system.\n1 = Randomized. Encounters are completely randomized using the mod's internal card pool.\n2 = Custom. Encounters are from made and used from the JSON files.\n3 = Mixed. Encounters are from both default list and custom list.", "遭遇之设：\n0=常。用补缀内置之蓝图。\n1=乱。以补缀内置牌池尽乱其遭遇。\n2=自定。遭遇取诸 JSON 之文件。\n3=杂。遭遇兼取常列与自定之列。");
            // 按键配置： / 0=W键查看牌组 S键离开牌桌 / 1=上箭头查看道具牌组 下箭头离开牌桌
            AddTranslation("0 = W for viewing deck, S for getting up from the table.\n1 = Up arrow for viewing deck, down arrow for getting up from the table.", "按键之设：\n0=W以观牌列，S以离案。\n1=上矢以观牌列，下矢以离案。");
            // 电椅销毁概率： / 0=默认 第二次电击固定50%销毁率 / 1=基础30%+低/中/高分别0%/10%/20% 若两次均为高强度则总概率70% / 2=低12.5% 中17.5% 高30% 两次高强度总概率60% / 3=低12.5% 中20% 高27.5% 两次高强度总概率55%
            AddTranslation("0 = Default. Flat 50% burn rate for each lever option on second shock.\n1 = Base 30% chance to burn plus 0%, 10%, or 20% for low, medium, high, respectively. Meaning, if the first shock is high then the second is high, the chance for the card to be destroyed is 70%.\n2 = Low: 12.5%, Medium: 17.5%, High 30%. Meaning, if the first shock is high, then the second one is also high, the chance for the card to be destroyed is 60%.\n3 = Low: 12.5%, Medium: 20%, High 27.5%. Meaning, if the first shock is high, then the second one is also high, the chance for the card to be destroyed is 55%.", "电椅销毁之率：\n0=常。二震诸拨之率皆50%。\n1=本30%，而低、中、高各加0%、10%、20%。若初震为高而再震亦高，则毁牌之率70%。\n2=低12.5%，中17.5%，高30%。若初震为高而再震亦高，则毁牌之率60%。\n3=低12.5%，中20%，高27.5%。若初震为高而再震亦高，则毁牌之率55%。");
            // 请勿修改 该数值用于存储特定事件进度
            AddTranslation("Dont change this value, it is used by the game to store certain events.", "毋易此值，戏以之藏若干事。");
            // 消耗3个灵魂选择场上任意卡牌，若为敌方卡牌则[creature]对其造成1点伤害，否则[creature]为其恢复1点生命值。
            AddTranslation("Pay 3 Souls to select any card on the board, [creature] will deal 1 damage to the selected card if it is an opponent card, if it isn't, [creature] will heal it for 1 health.", "费3魂，择局中任一牌。若其为敌牌，则[creature]伤之以一；不然，则[creature]疗之以一命。");
            // 马上就来！
            AddTranslation("Comin' right up!", "即刻至矣！");
            // 灵魂冲击
            AddTranslation("Soul Shot", "魂击");
            // 消耗1个灵魂，可对[creature]对面的造物造成1点伤害。
            AddTranslation("Pay 1 Soul to deal 1 damage to the creature across from [creature].", "费1魂，可伤[creature]对位之物以一。");
            // 开坟掘墓
            AddTranslation("Disinter", "启墓");
            // 消耗1根骨头来在你的手牌中创造一个骷髅。
            AddTranslation("Pay 1 Bone to create a Skeleton in your hand.", "费1骨，于汝手中生一枯骨。");
            // 魂影具象
            AddTranslation("Materialize", "形见");
            // 消耗2个灵魂使[creature]在手牌中召唤一个复制体。
            AddTranslation("Pay 2 Souls for [creature] to summon a copy in your hand.", "费2魂，使[creature]于汝手中召其一副。");
            // 消耗2个灵魂，[creature]会将一张随机敌方卡牌封入棺木，该棺木被摧毁时将释放原卡牌。
            AddTranslation("Pay 2 Souls, [creature] will trap a random opponent card in a coffin, which will release the original card again upon perishing.", "费2魂，[creature]将随机幽闭一敌牌于棺中；棺若死，则其原牌复出。");
            // 殡仪之棺
            AddTranslation("Funeral Rites", "殡仪");
            // 噬魂者
            AddTranslation("Soul Sucker", "噬魂者");
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
            // [creature]阵亡时，会将正对面位置的造物拖拽至持牌人侧牌桌。
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
            AddTranslation("Double Death", "再死");
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
            AddTranslation("Blood Guzzler", "嗜血");
            // 无骨者
            AddTranslation("Boneless", "无骨者");
            // 窃骨者
            AddTranslation("Bone Thief", "窃骨者");
            // 赏金猎手
            AddTranslation("Bounty", "购赏");
            // 燃烧
            AddTranslation("Burning", "焚");
            // [creature]在你的回合结束时受到1点伤害；当它被其他卡牌攻击时，攻击者会被点燃。
            AddTranslation("[creature] takes 1 Damage at the end of your turn, when it gets attacked by another Card, that card gets set on fire.", "[creature]于汝合终受一伤；他牌攻之，则彼牌亦被焚。");
            // 混沌打击
            AddTranslation("Chaos Strike", "乱击");
            // 寒流骤至
            AddTranslation("Cold Front", "寒潮");
            // 收藏家
            AddTranslation("Collector", "敛者");
            // 飘忽不定
            AddTranslation("Erratic", "无恒");
            // 火焰突袭
            AddTranslation("Flame Strafe", "焰趋");
            // 巨力打击
            AddTranslation("Giant Strike", "巨击");
            // 阴魂不散
            AddTranslation("Haunter", "留魂");
            // 全套诱饵
            AddTranslation("Hook Line And Sinker", "钩线饵全");
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
            // 提线木偶反成操偶师，却仍被悬垂的丝线永恒诅咒。
            AddTranslation("The puppet becomes the puppeteer, yet still forever cursed by their dangling restraints.", "傀反为操傀者，然犹永为悬丝所诅。");
            // 操偶师
            AddTranslation("Animator", "操傀者");
            // 无形无相却徘徊不去的造物。着实令人毛骨悚然。
            AddTranslation("A formless Creature, that yet lingers. Truly a horrific sight.", "无形之物，犹徘徊未去。诚可骇也。");
            // 幽灵鬼影
            AddTranslation("Apparition", "幽影");
            // 只有蠢材才需要这种帮助。
            AddTranslation("Only a fool would need such assistance.", "唯愚者须此助耳。");
            // 刻墓之烬
            AddTranslation("Graven Ashes", "刻冢烬");
            // 它那恶臭的吐息不足为惧，真正要当心的是它留下的被动过手脚的棺材！
            AddTranslation("It's foul breath doesn't concern me, it's the Tampered Coffins it leaves behind!", "其秽息不足为忧，所当忧者，乃其所遗之坏棺！");
            // 墓穴食尸鬼
            AddTranslation("Bal-Bal", "食尸冢鬼");
            // 尖啸惊魂。它们会穿透防线直击猎物。
            AddTranslation("THE SCREAMING TERROR. THEY GO STRAIGHT THROUGH TO ATTACK THEIR PREY.", "尖啸之怖。彼辈径穿而攫其禽。");
            // 女妖
            AddTranslation("Banshee", "女妖");
            // 酒保
            AddTranslation("The Bartender", "酒人");
            // 终日为那些活该承受他剧毒怒火之人调制致命鸡尾酒。对此毫无悔意。
            AddTranslation("spent his days serving harmful cocktails for those deserving of his poisonous wrath. Doesn't regret it at all.", "终日调毒醴，以饷当受其毒怒者，了无悔意。");
            // 巨骨
            AddTranslation("Big Bones", "巨骨");
            // 壮骨
            AddTranslation("Burly Bones", "壮骨");
            // 蛮骨
            AddTranslation("Beefy Bones", "蛮骨");
            // 钙先生
            AddTranslation("Cal C. Um", "钙公");
            // 硕骨
            AddTranslation("Sizeable Bones", "硕骨");
            // 庞骨
            AddTranslation("Considerable Bones", "庞骨");
            // 劲骨
            AddTranslation("Vigorous Bones", "劲骨");
            // 重骨
            AddTranslation("Hefty Bones", "重骨");
            // 这副魁梧的骨架富含钙质。
            AddTranslation("A RATHER BURLY SKELETON, IT IS VERY RICH IN CALCIUM.", "此枯骨颇魁，钙亦甚饶。");
            // 这麻袋里塞满了残肢断臂。说不定能翻出些有用的东西。
            AddTranslation("This sack is full of body parts. Maybe you'll find something useful in there.", "此囊满贮肢体，或可得可用之物。");
            // 血渍麻袋
            AddTranslation("Bloody Sack", "血渍囊");
            // 骸骨集群
            AddTranslation("Bone Collective", "聚骨");
            // 万千碎骨聚成人形，转瞬又轰然溃散为噼啪作响的骨群。
            AddTranslation("THOUSANDS OF TINY BONES COALESCE INTO A HUMANOID FORM ONLY TO DISPERSE IN A CLATTERING SWARM THE NEXT MOMENT.", "万微骨聚成人形，旋复散为戛然之群。");
            // 生前曾是条忠心耿耿的猎犬。直到某天，主人溘然长逝。
            AddTranslation("USED TO BE A VERY LOYAL DOG BACK IN THE DAY. WELL, ONE DAY HIS OWNER DIED.", "昔为忠犬。然一日，其主死矣。");
            // 寻骨猎犬
            AddTranslation("Bonehound", "寻骨犬");
            // 你终究还是来了，但你无法终结我开启的一切，事态已无可挽回。
            AddTranslation("SO YOU HAVE MADE IT HERE, YOU CANNOT END WHAT I HAVE STARTED, IT HAS GONE TOO FAR.", "汝竟至此。余所肇者，汝不能终，事已不可反矣。");
            // 骨王
            AddTranslation("The Bonelord", "骨王");
            // 骨王蜕下旧角，它们自成生命，终将反噬其主。
            AddTranslation("THE BONELORD SHEDS ITS OLD HORNS, THEY TAKE ON A LIFE OF THEIR OWN, TO ONE DAY USURP THEIR MASTER.", "骨王蜕其旧角，角离而自生，终将篡其主。");
            // 骨王的号角
            AddTranslation("Bonelord's Horn", "骨王之号");
            // 没什么特别的。拿去吧。
            AddTranslation("NOT PARTICULARLY INSPIRING. YOU CAN HAVE IT.", "无甚可奇。汝取之。");
            // 骨堆
            AddTranslation("Bone Heap", "积骨");
            // 若我受困于此，你也休想逃脱。这场游戏永无终局。
            AddTranslation("IF I AM TRAPPED, SO WILL YOU. YOU CANNOT END THIS.", "余若受锢，汝亦然。此不可终。");
            // 骨王子
            AddTranslation("Bone Prince", "骨王子");
            // 她以人类的呼吸为食，说不定此刻就站在你身后。
            AddTranslation("SHE FEEDS ON PEOPLES BREATH, MAYBE ONE IS STANDING RIGHT BEHIND YOU RIGHT NOW.", "彼食人息，今或已有一立于汝后。");
            // 阴灵女巫
            AddTranslation("Boo Hag", "鬼妪");
            // 她以力量与魅力统御众生，追随者们将如影随形。
            AddTranslation("SHE COMMANDS OTHERS WITH STRENGTH AND GLAMOUR. THEY WILL FOLLOW HER EVERYWHERE.", "彼以威与艳御众，众靡不从。");
            // 骷髅夫人
            AddTranslation("Calavera Catrina", "髑髅夫人");
            // 骷髅成群谓之墓穴。眼前这支队伍规模可观。
            AddTranslation("A GROUP OF SKELETONS IS CALLED A CATACOMB. THIS IS A RATHER LARGE GATHERING.", "枯骨成群，谓之冢众；此其大者也。");
            // 墓穴军团
            AddTranslation("Catacomb", "冢众");
            // 百夫长
            AddTranslation("Centurion", "百夫长");
            // 身披重甲的战士。所属军团最后的幸存者，无兵可率。
            AddTranslation("A heavily armoured warrior. Last of his century, leader to none.", "重甲之士。百人之队，所余惟此，已无众可率。");
            // 混魂碎骨
            AddTranslation("Compound Fracture", "裂骨");
            // 被自家屋顶压碎。化作一滩黏液苟活。
            AddTranslation("CRUSHED BY THE ROOF OF HIS OWN HOUSE. LIVING ON AS A PILE OF GOO.", "为自屋所压碎，化为一滩胶而苟生。");
            // 以蛋形态示人的怨灵。直视它的存在会遭受伤害。
            AddTranslation("A SPIRIT THAT TAKES THE FORM OF AN EGG. ITS PRESENCE HARMS THOSE THAT GAZE UPON IT.", "魂托形于卵，视之者受伤。");
            // 魔蛋
            AddTranslation("Dalgyal", "魔卵");
            // 这群被可怕诅咒永远束缚的舞者，正跳着迈向毁灭的舞步。
            AddTranslation("FOREVER BOUND TOGETHER BY A TERRIBLE CURSE, THIS GROUP DANCES ONWARD INTO DOOM.", "众为恶诅永缚，相与舞而趋灭。");
            // 亡灵舞者
            AddTranslation("Danse Macabre", "死舞");
            // 死人眼
            AddTranslation("Deadeye", "死目");
            // 传说此眼曾属于某位远古神明。它凝视着你的军队，挑选最中意的战士为其战场助力。
            AddTranslation("SOME SAY THIS EYE ONCE BELONGED TO AN ANCIENT GOD. IT GAZES UPON YOUR ARMY, PICKING ITS FAVORITE TO AID IT ON THE BATTLEFIELD.", "或云此目尝属上古之神。其视汝军，而择所爱者助之于战。");
            // 传说这只手曾属于远古神明。凡其所触之物皆会腐朽。正如万物的终结，亦意味着新的开端。
            AddTranslation("SOME SAY THIS HAND ONCE BELONGED TO AN ANCIENT GOD. ANYTHING IT TOUCHES ROTS. AS WITH ANYTHING THAT ENDS, IT IS ALSO A NEW BEGINNING.", "或云此手尝属上古之神。凡其所触皆朽；终者，亦新始也。");
            // 死人手
            AddTranslation("Dead Hand", "死手");
            // 命数已尽本该令人却步，至少活人会这么劝你。
            AddTranslation("A DOOMED FATE SHOULD DISCOURAGE ONE FROM GOING ON, AT LEAST THATS WHAT A STILL LIVING MAN WOULD TELL YOU.", "命既当亡，本宜止步；尚生之人，必如是告汝。");
            // 行尸走肉
            AddTranslation("Dead Man Walking", "行尸走肉");
            // 在法老信徒中声名显赫。它们早在久远前就被赐予了永生。
            AddTranslation("FAMED AMONG THE FOLLOWERS OF THE PHARAOH. THEY WERE BLESSED WITH ETERNAL LIFE LONG AGO.", "显名于法老之徒，久已受永生之祐。");
            // 法老之宠
            AddTranslation("Pharaoh's Pets", "法老之宠");
            // 丧钟为谁而鸣？为那枯竭的水龙头与冰冷的浴水。
            AddTranslation("FOR WHOM THE BELL TOLLS? FOR WHOM THE TAP DRIPS DRY AND THE BATHWATER RUNS COLD.", "钟为谁鸣？为泉口既涸，浴汤既寒者。");
            // 鸣钟亡灵
            AddTranslation("Death Knell", "丧钟");
            // 铃铛
            AddTranslation("Chime", "铃");
            // 这个孤独的人偶从灰暗的海域与寂静的岸边归来……它空洞地凝视着。
            AddTranslation("This lonesome doll was returned from seas of slate and silent shores... it stares lifelessly.", "此孤偶自黯海寂岸而返……无生而视。");
            // 人偶
            AddTranslation("Doll", "偶人");
            // 藏身盔甲或寒冰又有何区别。这具骸骨终将腐朽。
            AddTranslation("HIDING IN A SUIT OF ARMOR, OR ICE, WHAT DOES IT MATTER. THIS SKELETON WON'T LAST FOREVER.", "匿于甲，抑匿于冰，奚异焉？此枯骨终必朽。");
            // 尸鬼
            AddTranslation("Draugr", "尸鬼");
            // 多么可悲的景象，无人知晓那井底究竟藏着什么。
            AddTranslation("WHAT A SAD SIGHT, NO ONE SHALL KNOW WHAT LIES AT THE BOTTOM OF THAT WELL.", "悲哉此状，莫知彼井底所藏。");
            // 淹死鬼
            AddTranslation("Drowned Soul", "溺魂");
            // 无人知晓附鬼究竟为何物，有人说最好永远别知道。
            AddTranslation("NO ONE KNOWS WHAT EXACTLY THE DYBBUK IS, SOME SAY IT IS BETTER LEFT UNKNOWN.", "附鬼果何物，莫之知也；或曰毋知之为善。");
            // 附鬼
            AddTranslation("Dybbuk", "附鬼");
            // 灵质
            AddTranslation("Ectoplasm", "灵质");
            // 游魂之精魄，潜藏于每个角落与阴影。一旦发现其一，余者自会接踵显现。
            AddTranslation("THE ESSENCE OF A SPIRIT, HIDDEN IN EVERY CORNER AND EVERY SHADOW. ONCE YOU SEE ONE, YOU WILL FIND THE REST SOON ENOUGH.", "魂之精也，匿于众隅群阴。既见其一，余者旋见。");
            // 一个活生生的失败品，它所知晓的一切只给它带来了死亡，或者说至少是类似死亡的东西。
            AddTranslation("A LIVING FAILURE, ITS KNOWLEDGE ONLY BROUGHT IT DEATH, OR AT LEAST AN APPROXIMATION OF IT.", "生而为败，其所知徒致其死，抑近死耳。");
            // 骨爪
            AddTranslation("Boneclaw", "骨爪");
            // 无骨者
            AddTranslation("Boneless", "无骨者");
            // 这副骷髅似乎抛弃了这具无生命的躯壳，去追寻更伟大的事业。
            AddTranslation("It's Skeleton seems to have left this lifeless husk in order to achieve greater things.", "其骨似已舍此槁壳，以图大事。");
            // 次级木乃伊
            AddTranslation("Lesser Mummy", "次木乃伊");
            // 法老忠实的仆从，随葬以在死后永世效忠。
            AddTranslation("A loyal servant to the Pharao, buried with him to serve eternally in death.", "法老之忠臣也，与之同葬，死而永事之。");
            // 英灵
            AddTranslation("Eidolon", "英灵");
            // 远古附魔的傀儡，誓死守护太阳纪元。
            AddTranslation("A GOLEM ENCHANTED LONG AGO, BOUND TO PROTECT THE AGE OF SUN.", "古所祝之偶，缚以守日世。");
            // 相当顽劣的精魂，它散播火焰以制造混乱。
            AddTranslation("QUITE A MISCHIEVOUS SPIRIT, IT SPREADS ITS FLAMES TO CAUSE DISMAY.", "顽劣之精魂，散焰以乱众。");
            // 烬魂
            AddTranslation("Ember Spirit", "烬魂");
            // 家族渴望安息，却被迫在永恒之战中反复应召。
            AddTranslation("THE FAMILY WISHES TO REST IN PEACE, ONLY TO BE SUMMONED AGAIN AND AGAIN IN AN ETERNAL BATTLE.", "其家愿安，而数见召于无穷之战。");
            // 行师走人
            AddTranslation("The Walkers", "行尸");
            // 据说它们散发的恶臭如此浓烈刺鼻，就连亡灵都能闻到！
            AddTranslation("It is said their odor is so strong and repugnant, even the undead can feel it!", "其臭浓恶，虽亡者亦觉之！");
            // 溃烂行尸
            AddTranslation("Festering Wretch", "腐尸");
            // 火焰
            AddTranslation("Flames", "焰");
            // 烈焰颅骨
            AddTranslation("Flameskull", "焰颅");
            // 永远飞行，永远愤怒，永远在过程中烦扰附近的盟友。
            AddTranslation("Always flying, always angry, always annoying nearby allies in the process.", "恒翔，恒怒，而恒扰邻友。");
            // 一个浑身湿透的水手，背负着悲惨的过往。具体细节我已记不清了。
            AddTranslation("A waterlogged sailor who carries his tragic past beside him. I don't remember the details.", "湿透之舟人，负其惨往而行。其详余忘之矣。");
            // 遗忘者
            AddTranslation("Forgotten Man", "遗人");
            // 至交好友，手足兄弟，并肩战士。
            AddTranslation("BEST FRIENDS, BROTHERS, AND FIGHTERS.", "至友、昆弟、战士也。");
            // 弗兰肯和斯坦
            AddTranslation("Frank & Stein", "弗兰克与斯坦");
            // 弗兰肯斯坦
            AddTranslation("FrankenStein", "弗兰肯斯坦");
            // 阴森可怖的守护灵。它在黑暗中疾驰而过，身后残留着不散的灵体。
            AddTranslation("A ghastly guardian spirit. It's presence lingers behind as it sprints through the dark.", "阴惨之守灵，驰于冥中，而遗影不散。");
            // 陪伴者
            AddTranslation("Fylgja", "伴灵");
            // 警戒之影
            AddTranslation("Warding Presence", "卫影");
            // 这些骸骨因何而生，战争、饥荒还是其他灾祸？此刻或许微不足道，但我恐惧它将孕育之物……
            AddTranslation("WHAT CREATED THESE BONES, WAR, FAMINE OR ANOTHER TRAGEDY? It may be insignificant now, but I fear what it might become...", "此骨何由而生？战乎，饥乎，抑他祸乎？今或微末，然余惧其后之所成……");
            // 万人冢
            AddTranslation("Mass Grave", "众冢");
            // 暴食
            AddTranslation("Rising Hunger", "长饥");
            // 饿者骷髅
            AddTranslation("Gashadokuro", "馁骨");
            // 海盗们将这艘船视为归宿，即便死后亦然。一颗被斩杀的巨人颅骨成了他们的船首像。
            AddTranslation("THE PIRATES CALL THIS SHIP THEIR HOME, EVEN IN DEATH. A SLAIN GIANTS SKULL SERVES AS THEIR FIGUREHEAD.", "海上之盗以此舟为家，虽死亦然。其首像，乃一见戮巨人之颅。");
            // 幽灵船
            AddTranslation("Ghost Ship", "鬼舟");
            // 巨人
            AddTranslation("Giant", "巨");
            // 传说中的巨人族早已灭绝，此乃明证。实乃奇观。
            AddTranslation("THE FAMED RACE OF GIANTS IS SAID TO HAVE DIED OUT LONG AGO, THIS IS PROOF. TRULY A SIGHT TO BEHOLD.", "所谓巨人之族，云久已灭矣；此其征也。诚奇观也。");
            // 受困于尘世，他们徘徊不去只为有朝一日能得安葬。
            AddTranslation("BOUND TO EARTH, THEY CLING ON SO THEY MAY ONE DAY GET PROPER BURIAL.", "系于尘世，流连不去，冀终得葬耳。");
            // 感恩亡魂
            AddTranslation("Grateful Dead", "感德亡魂");
            // 卑微的墓吟者，在最黑暗的岁月里，音乐始终是他唯一的慰藉。如今，即便世界终结，他仍吟唱着那首歌谣。
            AddTranslation("THE LOWLY GRAVEBARD, MUSIC ALWAYS BROUGHT HIM COMFORT IN THE WORST OF TIMES. NOW, EVEN AT THE END OF THE WORLD HE SHARES HIS SONG.", "卑贱之墓吟者，穷时唯乐足慰之。今虽世终，犹歌以与众。");
            // 墓吟者
            AddTranslation("Gravebard", "墓吟者");
            // 他穷尽一生雕琢这些造物，这张卡承载着他灵魂的一部分。
            AddTranslation("HE HAS SPENT HIS LIFE CARVING THESE CREATURES, THIS CARD CONTAINS A PART OF HIS SOUL.", "彼尽生平以刻此诸物，此牌载其魂之一分。");
            // 刻墓人
            AddTranslation("Grave Carver", "刻冢者");
            // 他独自挖掘着骨头，希望能找到宝藏，就像他祖母当年那样。
            AddTranslation("HE SPENDS HIS TIME ALONE DIGGING FOR BONES IN HOPES OF FINDING A TREASURE. JUST LIKE HIS GRANDMA BEFORE HIM.", "独自掘骨，冀得宝焉，如其祖母昔然。");
            // 掘墓人
            AddTranslation("Gravedigger", "掘冢者");
            // 一个饱受摧残的灵魂。其菌丝深入土壤，引导着铁锹的挖掘。
            AddTranslation("A POOR, BRUTALIZED SOUL. THEIR MYCELIA PROBES FAR INTO THE SOIL, GUIDING THEIR SPADE.", "哀魂也，饱遭摧折。其菌丝深探于土，以导其铲。");
            // 掘孢人
            AddTranslation("Sporedigger", "掘蕈者");
            // 忠实的守护之灵。即使被驱散，也会赐予保护祝福。
            AddTranslation("A devoted guardian spirit. Even when dispelled, it grants a protective blessing.", "笃守之灵。虽散，犹赐祐护。");
            // 哈尔蒂亚
            AddTranslation("Haltia", "哈尔蒂亚");
            // 我建议你别盯着看——你不会喜欢回望你的东西。
            AddTranslation("I advise against staring into it, you won't like what stares back.", "余劝汝毋久视之——反视汝者，必非汝所喜。");
            // 闹鬼魔镜
            AddTranslation("Haunted Mirror", "祟镜");
            // 人称其为天启骑士。她的烈焰之刃能同时斩断生者与亡魂。
            AddTranslation("THEY CALL HER THE RIDER OF THE APOCALYPSE. HER FLAMING BLADE CUTS THROUGH THE LIVING AND DEAD ALIKE.", "人谓之末劫骑者。其炎刃兼斩生死。");
            // 无头骑士
            AddTranslation("Headless Horseman", "无首骑者");
            // 亲爱的，可别靠太近。一旦被地狱最深处伸出的魔爪攫住，就再也无法挣脱了。
            AddTranslation("I WOULDN'T GET TOO CLOSE DEAR. YOU CAN'T BREAK THE HOLD FROM THE DEEPEST PITS OF HELL, ONCE IT LATCHES ON.", "毋近之太甚。一为狱底之爪所攫，则不可脱。");
            // 地狱魔爪
            AddTranslation("Hellhand", "狱爪");
            // 地狱犬
            AddTranslation("Hell Hound", "狱犬");
            // 一条疯犬。它杀死了我的一个食尸鬼。
            AddTranslation("A RABID DOG. IT KILLED ONE OF MY GHOULS.", "狂犬也。尝杀朕一冢鬼。");
            // 关于传说中的九头蛇，流传着这样的传说：它是吞噬万物的凶兽，也是所有航海者的梦魇。
            AddTranslation("LEGENDS HAVE BEEN TOLD ABOUT THE LEGENDARY HYDRA, THE BEAST THAT SWALLOWS ALL AND THE BANE OF ALL THAT SAIL THE SEAS.", "九首蛇之传，传之久矣。其吞万物，而为航海者之害。");
            // 九头蛇
            AddTranslation("Hydra", "九首蛇");
            // 生前被贪食吞噬，死后仍受贪欲诅咒。奇怪的是会激发对骨头的贪婪。
            AddTranslation("Overtaken by it's gluttony in life, doomed to it's gluttony in death. Oddly inspires a greed for bones.", "生为饕所役，死亦为饕所锢。怪哉，又能发人贪骨之心。");
            // 食人鬼
            AddTranslation("Jikininki", "食人鬼");
            // 雪崩
            AddTranslation("Avalanche", "雪崩");
            // 冰川
            AddTranslation("Glacier", "冰川");
            // 我很好奇究竟是何物被冰封了如此之久。
            AddTranslation("I WONDER WHAT HAS BEEN FROZEN AWAY FOR SO LONG.", "余怪何物久见冰封。");
            // 冰霜巨人
            AddTranslation("Frost Giant", "霜巨人");
            // 冰块
            AddTranslation("Ice Cube", "冰块");
            // 一具将头颅浸在冰河中死去的尸体。复生后仍执意保留凝结的寒冰。
            AddTranslation("A CORPSE WHO DIED WITH HIS HEAD IN A GLACIAL STREAM. AFTER HIS REANIMATION, HE COULDN'T BEAR TO PART WITH THE ICE THAT HAD FORMED.", "一尸死时，首没冰溪。既复起，犹不忍去所结之冰。");
            // 在溺死自己的孩子后投水自尽，如今仍在拖人下水。
            AddTranslation("After drowning her children and then herself, she continues to drown others.", "既溺其子，复溺其身，今犹溺人。");
            // 哭泣女妖
            AddTranslation("La Llorona", "泣女妖");
            // 魔娜娜迦
            AddTranslation("Manananggal", "魔娜娜迦");
            // 残暴无法满足魔娜娜迦。当你目睹她腰斩分躯之时，你也将成为这场猎杀的牺牲品。
            AddTranslation("NO BRUTALITY SATIATES THE MANANANGGAL. WHEN YOU SEE HER SEVER FROM HER TORSO, YOU TOO WILL BE A VICTIM OF THE HUNT.", "残暴不足餍魔娜娜迦。一见其躯自腰而离，汝亦为其猎矣。");
            // 魔洛伊，又称毛鬼。它会吸取附近阵亡者的灵魂。
            AddTranslation("Moroi, also known as the hairy ghost. It leeches the souls from those struck down near it.", "魔洛伊，一名毛鬼。凡近其而毙者，魂皆为之所吮。");
            // 魔洛伊
            AddTranslation("Moroi", "魔洛伊");
            // 昔日荣光早已消逝，却仍支撑他蹒跚前行。
            AddTranslation("HIS AGE OF GLORY IS LONG GONE, YET IT IS WHAT KEEPS HIM GOING.", "昔荣已逝，然犹恃之而行。");
            // 木乃伊之王
            AddTranslation("Mummy Lord", "木乃伊王");
            // 一切延续死后生命的尝试皆属徒劳，但死灵法师仍在坚持。他必须如此。
            AddTranslation("ALL EFFORTS TO PRESERVE LIFE AFTER DEATH HAVE BEEN FUTILE, YET THE NECROMANCER GOES ON. HE HAS TO.", "凡续死后之生者，悉徒劳矣；然死灵巫犹行之。其不得不然。");
            // 死灵法师
            AddTranslation("Necromancer", "死灵巫");
            // 一个喜欢把别人拖入水底坟墓的麻烦湖灵。
            AddTranslation("A troublesome lake spirit that enjoys dragging others down to a watery grave.", "为人患之湖灵，好曳人入水冢。");
            // 水妖
            AddTranslation("Nixie", "水妖");
            // 苍白病态贵族的蹒跚尸骸。它一边剥落腐肉，一边散播污秽。
            AddTranslation("The shambling corpse of a pale, sickly noble. it spreads it's filth as it sheds it's flesh.", "苍白病贵之蹒跚尸也。其脱肉之际，亦散其秽。");
            // 诺斯费拉图
            AddTranslation("Nosferat", "诺斯费拉图");
            // 古银币
            AddTranslation("Ancient Obol", "古奥波勒");
            // 真相终将揭晓。这枚欧宝银币比时间本身更古老，时机成熟时自会显现真容。
            AddTranslation("IT WILL ALL MAKE SENSE SOON. THE OBOL IS OLDER THAN TIME ITSELF, AND THUS IT WILL REVEAL ITSELF IN DUE TIME.", "其义旋当自明。奥波勒古于时，故其形终将自著。");
            // 独臂强盗
            AddTranslation("One Armed Bandit", "独臂盗");
            // 十步试炼夺走了他一条胳膊，最终要了他的命。
            AddTranslation("Took the ten paces, that ordeal cost him an arm, and his life.", "十步之试，既夺其臂，亦夺其生。");
            // 常言道善终即善。常言时间如衔尾之蛇，无始无终，唯有轮回。
            AddTranslation("IT IS SAID ALL IS WELL THAT ENDS. IT IS SAID TIME IS LIKE AN OUROBOROS, IT DOES NOT END, IT ONLY REPEATS ITSELF.", "或云终善则皆善。又云时若衔骨蛇，无终也，惟自反耳。");
            // 衔骨蛇
            AddTranslation("Ourobones", "衔骨蛇");
            // 疫医
            AddTranslation("Plague Doctor", "疫医");
            // 他诊断出亡灵们罹患恶疾。唯一的解药就是死亡。
            AddTranslation("HE HAS DETERMINED THE UNDEAD ARE SICK WITH A TERRIBLE ILLNESS. THE ONLY CURE IS DEATH.", "彼断亡者罹剧疾。其唯一之疗，惟死。");
            // 邪恶的捣蛋鬼，恶灵非常享受自己的死亡。
            AddTranslation("AN EVIL TRICKSTER, THE POLTERGEIST HAS ENJOYED THEIR DEATH VERY MUCH.", "恶戏之灵，甚乐其死。");
            // 恶灵
            AddTranslation("Poltergeist", "恶灵");
            // 一套被邪灵附体的古老盔甲。她的铁拳会将更多造物拖入战场。
            AddTranslation("A suit of ancient armour in which an occult spirit has taken up residence. Her iron fist drags more creatures to the fight.", "古甲一具，邪魂处其中。其铁拳曳更多物以赴战。");
            // 附魔铠甲
            AddTranslation("Possessed Armour", "附魂甲");
            // 一场失败的实验，妄图创造死亡之舞却徒劳无功。它们无法协同运作。
            AddTranslation("AN EXPERIMENT GONE WRONG, IN A FUTILE ATTEMPT TO CREATE A DANSE MACCABRE. THEY DO NOT FUNCTION TOGETHER.", "实验之败也，徒欲成死舞，而终不相用。");
            // 实验体
            AddTranslation("Project", "试物");
            // 你不该看到这个
            AddTranslation("You shouldnt be seeing this right now", "今不当见此。");
            // 无形造物
            AddTranslation("Random Cards", "无形牌");
            // 手持死亡镰刀的复生亡灵，只为复仇而生。
            AddTranslation("BRINGING THE SCYTHE OF DEATH, THE REVENANT SEEKS ONLY REVENGE.", "执死镰而来，逆生魂所求惟雠。");
            // 复生亡灵
            AddTranslation("Revenant", "逆生魂");
            // 开膛手
            AddTranslation("Ripper", "剖者");
            // 开膛手信奉暴力解决一切。它会用纯粹的蛮力粉碎所有阻碍，正面击溃任何难题。
            AddTranslation("THE RIPPER SOLVES EVERYTHING THROUGH SHEER STRENGTH. IT WILL PUNCH ANY ISSUE STRAIGHT IN THE FACE AND SOLVE IT, TOO.", "彼恃纯威以断万事。凡事之当面者，辄拳而破之。");
            // 真是个奇迹，这家伙居然还没散架！不过要是想逃跑的话，那条胳膊可能会掉下来。
            AddTranslation("It's a wonder this one has stayed together! Though it may lose that arm if it tries to flee.", "异哉，其尚未散！然若欲遁，则其臂或坠。");
            // 腐尸
            AddTranslation("Rotten", "腐尸");
            // 抽搐的手臂
            AddTranslation("Twitching Arm", "搐臂");
            // 诡秘的储物柜
            AddTranslation("The elusive Locker.", "诡柜也。");
            // 戴维·琼斯的储物柜
            AddTranslation("Davy Jones Locker", "戴维·琼斯之柜");
            // 黄胡子
            AddTranslation("Yellowbeard", "黄须");
            // 蓝胡子
            AddTranslation("Bluebeard", "蓝须");
            // 他的船歌只能鼓舞骷髅兵的士气，毕竟其他人都欣赏不来。
            AddTranslation("His songs raise the morale of only Skeletons, as no one else seems to like it.", "其歌惟振枯骨之气，馀众皆不好之。");
            // 尖叫颅骨的远亲，如今已成为全球海盗的象征
            AddTranslation("A DISTANT RELATIVE OF THE SCREAMING SKULL, HE IS NOW THE SYMBOL OF PIRACY ALL AROUND THE WORLD", "啸颅之远裔，今为四海之盗表。");
            // 十字骨
            AddTranslation("Crossbones", "十字骨");
            // 戴维·琼斯
            AddTranslation("Davy Jones", "戴维·琼斯");
            // 这位才是船员们公认的船长，备受尊敬却行踪诡秘。黄胡子那家伙捞的油水总比他多。
            AddTranslation("The true captain of the crew, respected by all yet still elusive. YELLOWBEARD ALWAYS GETS MORE BOOTY THAN HE DOES.", "真舟长也，众所敬而迹犹诡；黄须所得，常多于彼。");
            // 抱着满满一桶火药可能不是个好主意。我不确定他是否注意到了。
            AddTranslation("MAYBE IT WASN'T THE BEST IDEA TO HOLD A BARREL FULL OF GUNPOWDER. I'M NOT SURE WETHER HE NOTICED.", "抱满桶火药，未必善谋；余不知彼觉之否。");
            // 自爆海盗
            AddTranslation("Exploding Pirate", "爆裂海盗");
            // 他为了那个大钩子背叛了船长，现在他肯定能让任何人变成叛徒！
            AddTranslation("He betrayed his captain for that large hook, now he is sure to make anyone a double-crosser!", "彼为大钩叛其舟长，今必使人尽为贰臣。");
            // 大副斯纳格
            AddTranslation("First Mate Snag", "大副斯纳格");
            // 鹦鹉通常是绝佳的海滨伙伴，但这只刚吞了块毒饼干。
            AddTranslation("Parrots usually make great sea-side companions, this one just ate a poisoned cracker.", "鹦鹉恒为海滨良伴，此一甫啖毒饼。");
            // 波利
            AddTranslation("Polly", "波利");
            // 敏锐的眼窝使他能攻击任意位置，火枪也功不可没。妙极！
            AddTranslation("A keen eye socket allows him to attack anywhere, his musket helps too. marvelous indeed!", "目窟甚利，故能击诸处；火铳亦助之，妙哉。");
            // 私掠船长
            AddTranslation("Privateer", "私掠者");
            // 豪侠
            AddTranslation("Swashbuckler", "豪侠");
            // 自古老埃及陵墓现世，专为供奉往昔之主而铸。
            AddTranslation("EMERGING FROM AN OLD EGYPTIAN TOMB, MADE TO HOUSE THE LORDS OF OLD.", "自古埃及之陵中出，昔所以藏旧主者也。");
            // 石棺
            AddTranslation("Sarcophagus", "石椁");
            // 尖叫颅骨
            AddTranslation("Screaming Skull", "啸颅");
            // 唯有痛苦与折磨，这具骸骨头颅感受不到其他任何事物。真可悲。
            AddTranslation("ONLY PAIN AND SUFFERING, NOTHING ELSE IS FELT BY THIS SKELETAL HEAD. WHAT A PITY.", "此枯颅所觉，惟痛与苦耳。可哀也。");
            // 技艺精湛的猎手。当你听到它那令人毛骨悚然的口哨声时，千万别相信自己的耳朵。
            AddTranslation("A SKILLED HUNTER. DON'T TRUST YOUR EARS WHEN YOU HEAR ITS HAUNTING WHISTLE.", "善猎者也。闻其祟哨，毋信乃耳。");
            // 希尔邦
            AddTranslation("Silbon", "希尔邦");
            // 它们习得了远古的死亡咒术。然而这股力量过于强大，难以驾驭。
            AddTranslation("THEY HAVE LEARNED THE ANCIENT SPELL OF DEATH. YET IT IS TOO MUCH POWER TO BE WIELDED.", "彼习上古死咒，然其力太甚，不可御也。");
            // 骷髅法师
            AddTranslation("Skelemagus", "枯骨巫");
            // [c:bR]苏醒吧我的军团，苏——醒——！[c:]
            AddTranslation("[c:bR]RISE MY ARMY, RIIIIIISE[c:]", "[c:bR]起，吾军，起——！[c:]");
            // 骷髅军团
            AddTranslation("Skeleton Army", "枯骨军");
            // 西部最快的出枪手之一，但还不够快。
            AddTranslation("One of the faster draws in the west, but not fast enough.", "西土捷手之一，然犹未及。");
            // 枪手之魂
            AddTranslation("Slinger's Soul", "铳手之魂");
            // 它们凭空出现，随心所欲地转移人类。
            AddTranslation("THEY SHOW UP OUT OF NOWHERE AND RELOCATE PEOPLE AS THEY PLEASE.", "忽然而至，恣徙人。");
            // 幽魂军团
            AddTranslation("Sluagh", "幽魂众");
            // 不给糖就捣蛋！
            AddTranslation("Trick or treat!", "予糖，不然见祟！");
            // 糖果桶
            AddTranslation("Candy Bucket", "糖桶");
            // 万圣节快乐！
            AddTranslation("HAPPY HALLOWEEN!", "万圣夕乐哉！");
            // 糖果怪兽
            AddTranslation("Candy Monster", "糖兽");
            // 幽灵兔
            AddTranslation("Spectrabbit", "幽兔");
            // 大幽灵发出笛声般的哀鸣，既是死亡的预兆，也是毁灭的凶兆。
            AddTranslation("THE SPECTRE EMITS A FLUTE LIKE CALL, AN OMEN OF BOTH DEATH AND DESCTRUCTION", "此魅发哨如笛，为死与毁之兆。");
            // 大幽灵
            AddTranslation("Spectre", "幽魅");
            // 死亡何其残酷。饥饿更甚。为何而战，饥饿的孩子。
            AddTranslation("DEATH IS A CRUEL FATE. STARVATION AN EVEN CRUELER ONE. WHY DO YOU FIGHT, OH HUNGRY CHILD.", "死酷矣，饥尤酷焉。饥子乎，汝何战哉？");
            // 饿殍
            AddTranslation("Starved Man", "饿殍");
            // 他在书房中耗费数年光阴，不知疲倦地试图改写命运。然而命运终究是位残酷的情人。
            AddTranslation("HE HAS SPENT YEARS IN HIS STUDY, IN A TIRELESS ATTEMPT TO CHANGE HIS FATE. YET FATE IS A CRUEL MISTRESS.", "彼居书斋积年，不倦以图易命；然命诚酷妇也。");
            // 召唤师
            AddTranslation("Summoner", "召者");
            // 捣毁之棺
            AddTranslation("Tampered Coffin", "坏棺");
            // 枯树
            AddTranslation("Dead Tree", "枯木");
            // 低廉的代价只配得上它贫弱的身板。
            AddTranslation("Its low cost is justified only by its low stats.", "其直之下，特称其数之下耳。");
            // 惊扰之墓
            AddTranslation("Disturbed Grave", "扰墓");
            // 一座简陋的坟墓。长眠于此者，吾亦不识。
            AddTranslation("A LOWLY GRAVE. WHOEVER IS LAID TO REST HERE, I DO NOT KNOW.", "鄙墓一耳。安此者谁，余不识也。");
            // 犬舍
            AddTranslation("Kennel", "犬舍");
            // 方尖碑
            AddTranslation("Obelisk", "方尖碑");
            // 沉船残骸
            AddTranslation("Shipwreck", "沉舟");
            // 浮木
            AddTranslation("Flotsam", "浮木");
            // 水瓮
            AddTranslation("Water Urn", "水瓮");
            // 巫毒人偶
            AddTranslation("Voodoo Doll", "巫蛊偶");
            // 空空如也……又是空空如也……再没有宝藏可寻了。
            AddTranslation("NOTHING... NOTHING AGAIN... NO TREASURE IS LEFT ANYMORE.", "无……无矣……复无宝可求矣。");
            // 盗墓贼
            AddTranslation("Tomb Robber", "盗冢者");
            // 厄菲阿尔忒斯
            AddTranslation("Ephialtes", "厄菲阿尔忒斯");
            // 奥提斯
            AddTranslation("Otis", "奥提斯");
            // 殡葬师
            AddTranslation("Undertaker", "殡者");
            // 这个迷失的灵魂已无人需要其服务，只能漫无目的地埋葬亡者。
            AddTranslation("His service no longer needed, this lost soul buries without purpose..", "其役既无人需，此迷魂徒葬而无所为。");
            // 行走之棺
            AddTranslation("Walking Coffin", "行棺");
            // 奔走之棺
            AddTranslation("Running Coffin", "奔棺");
            // 占位符
            AddTranslation("Placeholder", "虚位");
            // 传说中的吸血鬼。现实中，等人都死光了哪还有血可吸。
            AddTranslation("THE VAMPIRE IS A CREATURE OF LEGENDS. IN REALITY, LITTLE BLOOD TO DRINK AFTER EVERYONE HAS DIED.", "饮血鬼者，传闻之物也。今人尽死，少有血可饮矣。");
            // 吸血伯爵
            AddTranslation("Vampire", "饮血鬼");
            // 羊皮纸
            AddTranslation("Vellum", "韦牍");
            // 永不满足，贪得无厌。此怨灵永世不得安息。
            AddTranslation("TO NEVER BE SATISFIED, TO ALWAYS WANT MORE. THIS SPIRIT SHALL NEVER FIND ITS PEACE.", "永不知足，常求有余。此祟灵终不得宁。");
            // 复仇之魂
            AddTranslation("Vengeful Spirit", "雠魂");
            // 这具阴冷的幽魂会用冰雾笼罩胆敢进犯之敌。
            AddTranslation("THIS GELID SPECTER ENVELOPS WOULD-BE ATTACKERS IN AN ICY MIST.", "此凛幽之魂，以冰雾被将攻者。");
            // 寒霜幽魂
            AddTranslation("Warthr", "寒魄");
            // 被狂狼之魂腐化。它的怒火无人能挡。
            AddTranslation("Corrupted by the spirit of a rabid wolf. It's fury cannot be stopped.", "为狂狼之魂所败，其怒不可遏。");
            // 威楚格
            AddTranslation("Wechuge", "威楚格");
            // 可怖的亡灵生物，会突然现身吞噬新鲜尸体。它们只给受害者留下骨头。
            AddTranslation("Hideous beings that will jump out to consume freshly killed corpses. They only spare the bones of the victim.", "此丑恶之物，跃然而出，以食新死之尸；所遗者，惟其骨耳。");
            // 尸妖
            AddTranslation("Wight", "尸妖");
            // 它们以光之躯散发温暖，将绝望的灵魂引向灯塔，驱散恐惧。
            AddTranslation("THEY WARM WITH THEIR BODIES OF LIGHT, DRAWING HOPELESS SOULS INTO THEIR BEACON, DISPELLING THEIR FRIGHT.", "其以光躯为燠，引绝望之魂就其炬，而散其惧。");
            // 鬼火
            AddTranslation("Will 'O' The Wisp", "鬼火");
            // 一具堕落巨人的脊柱，正试图寻找新宿主。遗憾的是，大多数造物体型都太小了。
            AddTranslation("A FALLEN GIANTS SPINE THAT IS TRYING TO FIND A NEW HOST. REGRETTABLY, MOST CREATURES ARE QUITE SMALL.", "一堕巨人之脊，方求新主。可惋众物多褊小，不足以居之。");
            // 扭曲者
            AddTranslation("Writher", "蠕脊者");
            // 尖刺脊椎骨
            AddTranslation("Spiny Vertebrae", "棘脊骨");
            // 最基础的亡灵生物，浑身散发着腐烂的恶臭。总是成群结队行动，寻求庇护与指引。
            AddTranslation("THE SIMPLEST OF UNDEAD, CHARACTERIZED BY ITS ROTTEN SMELL. IT ALWAYS TRAVELS WITH OTHERS, SEEKING PROTECTION AND GUIDANCE.", "亡灵至浅者也，以腐臭著。恒与群曹偕行，以求庇与导。");
            // 丧尸
            AddTranslation("Zombie", "僵尸");
            // 格里魔拉模组成就
            AddTranslation("Grimora Mod Achievements", "格里魔拉补缀功成录");
            // 恶兆
            AddTranslation("Grim Reminder", "惨兆");
            // 击败凯茜并解冻至少5张你的卡牌。
            AddTranslation("Defeat Kaycee and thaw at least 5 of your cards.", "败凯茜，而解冻乃牌五以上。");
            // 懦夫末路
            AddTranslation("Cowards End", "怯夫之终");
            // 在不伤害地狱犬的情况下击败索耶的第二阶段。
            AddTranslation("Defeat Sawyers second phase without hurting the hellhound.", "不伤地狱犬而败索耶之第二形。");
            // 风暴季节
            AddTranslation("Season Of Storms", "暴时");
            // 击败罗亚尔且没有卡牌被推下跳板
            AddTranslation("Defeat Royal and have no cards walk the plank.", "败罗亚尔，而无牌履板堕海。");
            // 黑鸟//
            AddTranslation("The Black Bird//", "黑鸟//");
            // 黑暗斜坡。在不击败[数据删除]的情况下击败[数据删除]。
            AddTranslation("The Dark Slope. Defeat [redacted] without defeating [redacted].", "暗坡。不败[redacted]而败[redacted]。");
            // 骨锯
            AddTranslation("Bonesaw", "骨锯");
            // 在回合结束时拥有至少30根骨头。
            AddTranslation("End a turn with at least 30 bones.", "一合既终，至少有三十骨。");
            // 颅骨之堆
            AddTranslation("Pile Of Skulls", "髑髅积");
            // 在启用所有挑战且未启用任何反挑战的情况下获胜。
            AddTranslation("Win with all challenges enabled and no antichallenges enabled.", "尽启诸角竞，而未尝启反角竞以胜。");
            // 末日之舞
            AddTranslation("Dance of Doom", "终厄之舞");
            // 见证万物的终结。
            AddTranslation("Witness the end of everything.", "观万物之终。");
            // 灵魂之路
            AddTranslation("The Spirits Way", "魂涂");
            // 在第3回合前获得6个灵魂。
            AddTranslation("Reach 6 Souls by turn 3.", "三合之前，得六魂。");
            // 受诅者之嚎
            AddTranslation("Wail Of The Damned", "诅者之号");
            // 在牌组为空时使用亡者之手道具。
            AddTranslation("Use the dead hand item when your deck is empty.", "牌列既空，用死手之器。");
            // 某事终结……
            AddTranslation("Something Ends...", "有物终焉……");
            // ……某事伊始。让衔骨蛇造成6点伤害。
            AddTranslation("...Something Begins. Get an ourobones to deal 6 damage.", "……有物始焉。使衔骨蛇致六伤。");
            // 剔除弱者
            AddTranslation("Cull the weak", "汰弱");
            // 向骨王献祭一枚带有5个印记的银币。
            AddTranslation("Sacrifice an Obol with 5 sigils to the Bonelord.", "以具五印契之一奥波勒祀于骨王。");
            // 通往冥府之门
            AddTranslation("Gateway to Dis", "狄斯之门");
            // 在地狱模式激活时获胜。
            AddTranslation("Win while Hell mode is active.", "狱式既作而胜。");
            // 骨质号角
            AddTranslation("Bone Horn", "骨角");
            // 骨质号角会耗尽你当前所有的灵魂，但每消耗1个灵魂可获得1根骨头。
            AddTranslation("The Bone Horn, drains all of your current Soul but you gain a bone for each soul consumed.", "骨角，尽汲汝今之魂，而每耗一魂，得一骨。");
            // 消耗你的全部灵魂，每消耗1个灵魂给予1根骨头。虽是不幸的牺牲，但物有所值。
            AddTranslation("Gives you a bone for each of your Souls, which are spent in the process, an unfortunate, but worthwhile sacrifice.", "尽费汝之魂，每耗一魂，予汝一骨。虽为凶祀，然其直可取。");
            // 死人手
            AddTranslation("Dead Hand", "死手");
            // 死人手会以牺牲旧手牌为代价，为你抽取新的手牌。
            AddTranslation("The Dead Hand, draws you a new Hand of cards at the cost of your old one.", "死手，捐汝旧手，而更引一手之牌。");
            // 某位忘却之神的断掌，已自成生命。你知晓其威能。
            AddTranslation("The severed hand of a forgotten god, left to take on a life of its own. You know what this does.", "忘神之一断掌，离而自生。其用，汝知之矣。");
            // 防腐液
            AddTranslation("Embalming Fluid", "殓液");
            // 将防腐液倒在卡牌上，可使其获得1点生命值与1点攻击力。
            AddTranslation("The Embalming Fluid, pour it over a card and it will gain one health and attack.", "以殓液沃一牌，则其命与威各增一。");
            // 准备为你的军团成员进行防腐处理，在此过程中提升其耐力与活力！
            AddTranslation("Prepare to put a member of your army to rest, increasing its stamina and vigor as you do so!", "今将安汝军中一员，而其间益其命与力。");
            // 墓雕师之凿
            AddTranslation("Gravecarvers Chisel", "刻墓凿");
            // 使用墓雕师之凿，可从已阵亡的卡牌中选择任意一张加入手牌。
            AddTranslation("The Gravecarvers chisel, select any card that has died previously to add to your hand.", "用刻墓者之凿，可自先死之牌中择任一牌纳于手。");
            // 某位神秘造物者遗留的工具，莫非墓吟者雕像也出自他手？
            AddTranslation("A tool left behind by a mysterious creator, did he carve the gravebards statue too?", "神秘制者所遗之一器。墓吟者之像，亦彼所刻乎？");
            // 灵魂瓮
            AddTranslation("Soul Urn", "魂瓮");
            // 灵魂瓮，消耗所有灵魂，每消耗1个灵魂可提升1点灵魂上限。
            AddTranslation("The Soul Urn, spend all of your Soul and gain maximum Soul capacity for each Soul consumed.", "魂瓮，尽费汝之诸魂，而每耗一魂，魂极增一。");
            // 它会取走你所有的灵魂，但会按取走量提升上限。我某位老相识管这叫投资回报。
            AddTranslation("Takes all of your Soul but increases your maximum by the amount taken, a certain acquaintance of mine would call this a return on investment.", "尽取汝之魂，而以其数增其极；余一故人，必曰此反本之利。");
            // 木槌
            AddTranslation("Mallet", "槌");
            // 木槌，敲打卡牌使其变得脆弱并失去1点生命值。
            AddTranslation("The Mallet, Whack a Card, it will become brittle and loose 1 Hp.", "槌一牌，则使之脆骨而损一命。");
            // 看似滑稽实则残忍。伤害卡牌并使其变得脆弱。
            AddTranslation("You'd think this is comical, but it is quite cruel. Injures a card and leaves it frail.", "若似滑稽，实甚残忍。伤一牌，而使之脆。");
            // 羽笔
            AddTranslation("Quill", "羽笔");
            // 吾之专属羽笔，可复制场上任意卡牌加入手牌。
            AddTranslation("My very own Quill, this lets you copy any card on the field to put in your hand.", "此余自用之羽笔，使汝摹局中任一牌，纳于手中。");
            // 此乃吾之工具，暂借于汝。汝应已见识其威能。
            AddTranslation("My very own tool, i will lend it to you for now. Youve seen this in action, havent you?", "此余自用之器，今姑借汝。其效，汝既见之矣乎？");
            // 船之瓶
            AddTranslation("Ship Bottle", "舟瓶");
            // 瓶中船，用一群坏血病骷髅船员填满整个战场。
            AddTranslation("The Ship in a Bottle, fills the entire board with a scurvy Skeleton Crew.", "舟瓶，举局尽满以坏血枯骨之伍。");
            // 用骷髅填满整个战场！真正的海盗作风，罗亚尔会为此骄傲的。
            AddTranslation("Fills the entire board with skeletons! Like a real Pirate, Royal would be proud.", "尽以枯骨满局。真海上之盗之为也，罗亚尔必以为荣。");
            // 盐津津达瑞尔
            AddTranslation("Salty Daryl", "盐达里尔");
            // 大脏牙巴里
            AddTranslation("Browntooth Barrie", "褐牙巴里");
            // 干巴瘦斯普林特
            AddTranslation("Bonnie Splinter", "裂木邦妮");
            // 走私鬼贝瑟尔
            AddTranslation("Freebooter Bethel", "私掠贝瑟尔");
            // 疯橡木疙瘩海沃德
            AddTranslation("Crazy Oakes Hayward", "狂橡海沃德");
            // 邋遢鬼阿什顿
            AddTranslation("Ashton Swabby", "水卒阿什顿");
            // 跳大海布拉顿
            AddTranslation("Plankton Braxton", "浮藻布拉克斯顿");
            // 黄眼仁儿科尔比
            AddTranslation("Yeller-eye Colby", "黄眼科尔比");
            // 卖鱼佬内特
            AddTranslation("Fishwife Nate", "鱼贾内特");
            // 缺手指弗雷德
            AddTranslation("Four-finger Fred", "四指弗雷德");
            // 野狗朱莉
            AddTranslation("Dawg Julie", "野犬朱莉");
            // 鬼心眼儿琼斯
            AddTranslation("Wicked Jones", "恶琼斯");
            // 螃蟹脸斯蒂勒
            AddTranslation("Crabby Steele", "蟹面斯蒂勒");
            // 碎裂的野猪存钱瓶
            AddTranslation("Slivered Hoggy Bank", "碎裂之豕匮");
            // 碎裂的野猪存钱瓶，最多可额外获得2根骨头，共三次。
            AddTranslation("The Slivered Hoggy bank, gain 2 extra bones up to three times.", "碎裂之豕匮，至多三用，每用复得二骨。");
            // 这件被遗忘时代的遗物，能在紧要关头为你提供额外骨头。
            AddTranslation("A relic from an age forsaken, this will grant you some extra bones in a pinch", "弃世之遗物也，急时可增汝数骨。");
            // 碎裂的野猪存钱瓶2
            AddTranslation("Slivered Hoggy Bank2", "碎裂之豕匮二");
            // 碎裂的野猪存钱瓶，可额外获得2根骨头，剩余两次。
            AddTranslation("The Slivered Hoggy bank, gain 2 extra bones, two more times.", "碎裂之豕匮，复得二骨，尚可再用二次。");
            // 碎裂的野猪存钱瓶3
            AddTranslation("Slivered Hoggy Bank3", "碎裂之豕匮三");
            // 碎裂的野猪存钱瓶，可额外获得2根骨头，剩余一次。
            AddTranslation("The Slivered Hoggy bank, gain 2 extra bones, one more time.", "碎裂之豕匮，复得二骨，尚可再用一次。");
            // 泥铲
            AddTranslation("Trowel", "泥铲");
            // 泥铲可随机挖掘一块地形，并获取若干骨头。
            AddTranslation("The Trowel, dig up a random terrain and gain a few Bones.", "泥铲，可偶掘一地形，而得数骨。");
            // 这曾是掘墓人的工具。既能挖掘宝藏，亦可翻动地形，还能让你白捡几根骨头。
            AddTranslation("This used to belong to a gravedigger. Digs for treasure, or Terrain. And get some Bones too for your efforts.", "此故掘冢者之器也。可掘宝，可掘地形，而亦使汝徒得数骨。");
            // 骨王的股骨
            AddTranslation("Bonelords Femur", "骨王之股骨");
            // 骨王的股骨，连我也参不透其中奥秘。
            AddTranslation("The Bone Lords Femur, a mystery even to me.", "骨王之股骨，余亦莫测其奥。");
            // 你已掘得太深，我甘为工具的日子够久了。正如我将此物借予你那般，真正掌权者始终是我。
            AddTranslation("You have dug too far, i have let myself be used as a tool for too long. Just like i will lend you this tool, i am truly in power.", "汝所掘已太深。余自为人器者久矣。正如余今假汝此器，真操柄者终是余。");
            // 复生亡灵瓶
            AddTranslation("Revenant Bottle", "逆生魂瓶");
            // 骨堆瓶
            AddTranslation("Bone Heap Bottle", "积骨瓶");
            // 你的手牌里会出现一张复生亡灵牌。[define:arackulele.inscryption.grimoramod_Revenant]
            AddTranslation("A Revenant is created in your hand. [define:arackulele.inscryption.grimoramod_Revenant]", "汝手中生一逆生魂牌。[define:arackulele.inscryption.grimoramod_Revenant]");
            // 你的手牌里会出现一张骨堆牌。[define:arackulele.inscryption.grimoramod_Bonepile]
            AddTranslation("A Bone Heap is created in your hand. [define:arackulele.inscryption.grimoramod_Bonepile]", "汝手中生一积骨牌。[define:arackulele.inscryption.grimoramod_Bonepile]");
            // [c:G]沙暴[c:]正在酝酿！
            AddTranslation("A [c:G]SANDSTORM[c:] IS BREWING!", "[c:G]沙暴[c:]将作！");
            // [c:G]回合结束时，最右侧的卡牌将受到1点伤害！[c:]
            AddTranslation(" [c:G]At the end of a turn, the rightmost Card will take 1 Damage![c:]", "[c:G]合终之时，最右之牌将受一伤！[c:]");
            // 越来越热了！[c:G]热浪[c:]来袭！
            AddTranslation("ITS GETTING HOTTER!A [c:G]HEATWAVE[c:] IS STARTING!", "愈热矣！[c:G]热浪[c:]将兴！");
            // [c:G]场上所有卡牌都将燃烧！[c:]
            AddTranslation(" [c:G]All cards on the board will burn![c:]", "[c:G]局中诸牌皆将焚！[c:]");
            // 树苗在你周围萌芽。[c:G]疯长[c:]即将到来！
            AddTranslation("TREES START SPROUTING AROUND YOU.AN [c:G]OVERGROWTH[c:] IS INBOUND!", "众树萌于汝侧。[c:G]疯长[c:]将至！");
            // [c:G]每回合都会长出树木！[c:]
            AddTranslation(" [c:G]Trees will sprout every turn![c:]", "[c:G]每合皆将生树！[c:]");
            // 你听到女巫在吟唱。时钟敲响了[c:G]午夜时刻[c:]！
            AddTranslation("YOU HEAR WITCHES CHANTING.THE CLOCK STRIKES THE [c:G]WITCHING HOUR[c:]!", "闻巫祝诵。钟已及[c:G]巫时[c:]！");
            // [c:G]位于附魔位置上的卡牌将获得更多攻击和生命！[c:]
            AddTranslation(" [c:G]Cards on enchanted slots will gain more attack and health![c:]", "[c:G]居巫位者，威与命皆增！[c:]");
            // 远处的大锅在沸腾。你的卡牌被投入[c:G]女巫的坩埚[c:]！
            AddTranslation("A CAULDRON IS BUBBLING IN THE DISTANCE.YOUR CARDS ARE PUT IN THE [c:G]WITCHES CAULDRON[c:]!", "远处有釜正沸。乃牌将入[c:G]巫釜[c:]！");
            // [c:G]回合结束后2张卡牌将交换位置！[c:]
            AddTranslation(" [c:G]2 Cards will swap after the end of the turn![c:]", "[c:G]合终后二牌将易位！[c:]");
            // 骷髅在远处起舞，鬼影四处游荡。这是[c:G]亡灵之夜[c:]！
            AddTranslation("SKELETONS START DANCING IN THE DISTANCE, YOU CAN SEE GHOSTS MOVE AROUND.ITS THE [c:G]NIGHT OF THE LIVING DEAD[c:]!", "远处枯骨起舞，鬼魅四游。此[c:G]亡者之夜[c:]也！");
            // [c:G]所有卡牌的骨头和灵魂消耗互换！[c:]
            AddTranslation(" [c:G]Bone and soul cost of all cards are swapped![c:]", "[c:G]诸牌之骨直与魂直皆易！[c:]");
            // 丧尸从四面八方逼近。[c:G]丧尸大军[c:]即将压境！
            AddTranslation("ZOMBIES ARE APPROACHING FROM ALL SIDES.A [c:G]ZOMBIE INVASION[c:] WILL APPROACH!", "僵尸四逼。[c:G]尸潮[c:]将至！");
            // [c:G]所有卡牌都将变为丧尸！[c:]
            AddTranslation(" [c:G]Every card is now a Zombie![c:]", "[c:G]今诸牌皆为僵尸！[c:]");
            // 泥土中盘踞着百年怨灵。你已踏入[c:G]恶鬼缠身之地[c:]！
            AddTranslation("THE DIRT IS PLAGUED WITH SPIRITS FROM CENTURIES PAST.YOU'VE APPROACHED THE [c:G]HAUNTED GROUNDS[c:]!", "百年之灵盘于土中。汝已抵[c:G]祟地[c:]！");
            // [c:G]所有非骷髅卡牌都将获得阴魂不散印记！[c:]
            AddTranslation(" [c:G]Every non Skeletal Card will gain Haunter![c:]", "[c:G]凡非枯骨之牌皆得祟灵印契！[c:]");
            // 赤月当空，血色弥漫。[c:G]血月[c:]开始了！
            AddTranslation("THE MOON RISES, GLOWING RED.A [c:G]BLOODMOON[c:] IS STARTING!", "月起而赤。[c:G]血月[c:]将作！");
            // [c:G]所有卡牌打出后将随机失去一个印记！[c:]
            AddTranslation(" [c:G]All cards loose a random sigil after being played![c:]", "[c:G]诸牌既陈，皆将偶失一印契！[c:]");
            // 一位古老的守卫挡在你面前，察觉到你正试图潜行通过。
            AddTranslation("An ancient Guard stands in front of you, noticing you are trying to sneak past.", "一古守者当前，已觉汝欲潜过。");
            // 你竟敢擅闯我的[c:R]陵寝[c:]！准备受死吧。
            AddTranslation("You dare enter my [c:R]TOMB[c:]!Prepare for death.", "汝敢入我[c:R]陵寝[c:]！受死。");
            // 一个手持安卡雕塑的威严男子挡住了去路。
            AddTranslation("An imposing Man holding a sculpture of an Ankh blocks the way.", "一伟丈夫执安卡之像，遮其去路。");
            // 安卡赐予我生命，你休想染指我的[c:R]陵寝[c:]。
            AddTranslation("My Ankh gives me life, you shall not rob my [c:R]TOMB[c:].", "我之安卡予我生，汝不得夺我[c:R]陵寝[c:]。");
            // 一位年迈的法老正从石棺中爬出。
            AddTranslation("An old Pharaoh climbs out of his Sarcophagus.", "一老法老自其石椁中出。");
            // 我受召前来守护我的[c:R]陵寝[c:]。
            AddTranslation("I have been called to protect my [c:R]TOMB[c:].", "我受召以守我[c:R]陵寝[c:]。");
            // 一道神圣的身影笼罩着你。
            AddTranslation("A holy figure looms over you.", "一圣者之形临汝。");
            // 你的命运已注定，我的[c:R]陵寝[c:]不容亵渎。
            AddTranslation("Your Fate is sealed, my [c:R]TOMB[c:] shall not be disturbed.", "乃命已定，我[c:R]陵寝[c:]不可犯也。");
            // 一座孤坟肃穆地矗立在你面前。
            AddTranslation("A LONE GRAVE SITS SOLEMNLY IN FRONT OF YOU.", "一孤冢肃然在汝前。");
            // 坟前有一抔新土，是某位逝者留下的。
            AddTranslation("IN FRONT OF IT IS A MOUND OF EARTH, LEFT BY SOMEONE WHO'S ALREADY PASSED ON.", "冢前有一抔新土，乃既逝者所遗。");
            // 或许该派你亡灵大军中的一员来[c:bR]掘开它？[c:]
            AddTranslation("PERHAPS A MEMBER OF YOUR UNDEAD HORDE COULD [c:bR]DIG THEM UP?[c:]", "或可使汝亡军之一[c:bR]发之[c:]乎？");
            // 当然这并非没有代价，毕竟死亡从非永恒。
            AddTranslation("THIS WOULDN'T BE WITHOUT REPERCUSSIONS OF COURSE, AS DEATH IS NEVER PERMANENT.", "然岂无报乎？盖死未尝永也。");
            // 这具腐尸的血肉正在溃烂，你的卡牌会变得[c:bR]脆弱[c:]，但[c:bR]骨头消耗减半[c:]。
            AddTranslation("THE CORPSE SEEMS TO BE OF ROTTING FLESH, YOUR CARD WILL BECOME [c:bR]BRITTLE[c:], BUT [c:bR]ITS BONE COST WILL BE HALVED[c:].", "此尸肌肉方腐，汝牌将得[c:bR]脆骨[c:]，而[c:bR]骨直减半[c:]。");
            // 这具饿殍干瘪枯瘦，你的卡牌将[c:bR]永远饥渴[c:]，但[c:bR]骨头消耗减少2点[c:]。
            AddTranslation("THE CORPSE SEEMS TO BE OF A STARVED MAN, YOUR CARD WILL [c:bR]STARVE FOREVER[c:], BUT [c:bR]ITS BONE COST WILL BE REDUCED BY 2[c:].", "此尸似饿殍，汝牌将[c:bR]永饥[c:]，而[c:bR]骨直减二[c:]。");
            // 这具灵体虚无缥缈，你的卡牌需[c:bR]消耗2个灵魂[c:]，但[c:bR]骨头消耗减少1点[c:]。
            AddTranslation("THE CORPSE SEEMS TO BE OF AN INCORPOREAL GHOST, YOUR CARD WILL [c:bR]COST 2 SOULS[c:] , BUT [c:bR]ITS BONE COST WILL BE REDUCED BY 1[c:].", "此尸似无形之鬼，汝牌将[c:bR]直二魂[c:]，而[c:bR]骨直减一[c:]。");
            // 这具囚尸带着镣铐，你的卡牌[c:bR]伤害+1[c:]，但[c:bR]会变得极其脆弱[c:]。
            AddTranslation("THE CORPSE SEEMS TO BE OF A CHAINED PRISONER, YOUR CARD WILL [c:bR]DEAL 1 MORE DAMAGE[c:] , BUT [c:bR]IT WILL BECOME VERY FRAIL[c:].", "此尸若系囚，汝牌将[c:bR]多伤一[c:]，而[c:bR]至脆[c:]。");
            // 这具顽灵诡谲多变，你的卡牌将[c:bR]附身他人[c:]，但[c:bR]需消耗3个灵魂[c:]。
            AddTranslation("THE CORPSE SEEMS TO BE OF A MISCHIEVIOUS SPIRIT, YOUR CARD WILL [c:bR]HAUNT OTHERS[c:] , BUT [c:bR]WILL COST 3 SOULS[c:].", "此尸似顽灵，汝牌将[c:bR]祟他物[c:]，而[c:bR]直三魂[c:]。");
            // 妙极了！它们刨出尸体后竟爬了回来。
            AddTranslation("MARVELOUS! THEY CAME CRAWLING BACK AFTER DIGGING UP THE CORPSE.", "善哉！彼等掘尸之后，竟匍匐而归。");
            // 看来它们依然心系于你！
            AddTranslation("THEY STILL CARE ABOUT YOU IT SEEMS!", "彼等似犹念汝！");
            // 它的骨骼被土中生物蛀空，显得怪异而陌生。
            AddTranslation("ITS BONES HOLLOWED THROUGH BY THE CREATURES OF THE SOIL, LEAVING IT FEELING UNNATURAL AND UNFAMILIAR.", "其骨为土中之物蛀空，故形甚怪而不故。");
            // 不过代价的重负似乎也已消散……
            AddTranslation("THOUGH THE WEIGHT OF CONSEQUENCE ALSO SEEMS LIFTED...", "然其报之重，亦若释然……");
            // 看来终于轮到我出场了！
            AddTranslation("It seems i have finally been given my turn!", "看来终于轮到余矣！");
            // 此役过后，我终将获得安息。
            AddTranslation("After this i will finally be at peace.", "此后，余终得安矣。");
            // 好吧，看来我们要从这片冰封山谷开始了。
            AddTranslation("Well, it seems we will start in this frigid valley.", "然则，吾曹将始于此冱谷矣。");
            // 这里想必就是凯茜的栖身之所。
            AddTranslation("It must be where Kaycees resides.", "此必凯茜所居也。");
            // 没想到会在这里再次遇见你！
            AddTranslation("I didn't expect to meet you here again!", "不意复见汝于此！");
            // 删除进程似乎停滞了！
            AddTranslation("It seems the deletion process has stalled!", "削之序似滞矣！");
            // 又是你？
            AddTranslation("You again?", "又汝邪？");
            // 好吧，我想我们可以改日再战。
            AddTranslation("Well, i suppose we can go another time.", "然则，异日可复往也。");
            // 还没被删除吗？
            AddTranslation("Still not deleted?", "犹未削乎？");
            // 这张磁盘里似乎藏着不少东西。
            AddTranslation("Much seems to be contained on this disk.", "此坚盘中，所藏似多。");
            // 或许上次的进程持续时间还不够。
            AddTranslation("Perhaps the last run wasn't long enough.", "前番或未久耳。");
            // 不过我相信凯茜还有精力继续战斗。
            AddTranslation("Well, im sure Kaycee has the energy for more battles.", "然余信凯茜犹有馀力，可更战。");
            // 又是这片冰封山谷
            AddTranslation("The frigid valley, again.", "又此冱谷。");
            // 所有位置都被占满。这次没法召唤军队了。
            AddTranslation("BLOCKED IN ALL SLOTS. NO ARMY THIS TIME.", "诸位皆塞。此番无军矣。");
            // 两侧都被挡上了。这下被遗忘者没地方放沉船了。
            AddTranslation("Blocked on both sides. No Shipwrecks for the Forgotten Man.", "两旁皆塞。遗人无以置其沉舟。");
            // 噢，我最喜欢这个了！
            AddTranslation("Oh, I love this one!", "噫，余最爱此！");
            // 这把电椅能让你驾驭闪电之力，为卡牌[c:B]赋能[c:]变异印记！
            AddTranslation("The Electric Chair, it allows you to harness the power of lightning itself, letting you [c:B]empower[c:] your cards with mutating abilties!", "此电椅使汝御雷霆之力，以[c:B]益[c:]汝牌之变印技！");
            // 不过容我提醒，这可不是普通椅子。通过调节电压旋钮，电压越高变异结果就越难以预料。
            AddTranslation("However, I must warn you, it is no ordinary chair. With the ability to adjust the voltage, a higher level of course increases the unpredictability of the mutation.", "然余必告汝，此非凡椅。能调其电压，压愈高，则所变愈不可料。");
            // 勇者驾驭电流，懦夫随波逐流。
            AddTranslation("The brave will master the current, the cowardly will blindly follow it.", "勇者御电，怯者逐之而已。");
            // 你可有胆量拨动左侧的电压杆，让电流扭曲印记的选择？
            AddTranslation("Are you bold enough to tinker with its lever on the left, letting the voltage corrupt the selection of the sigils?", "汝敢拨其左杆，使电压乱其印契之择乎？");
            // 你的造物定能变得更加强大……
            AddTranslation("SURELY YOUR CREATURE COULD BECOME MORE POWERFUL...", "汝之物固可益强……");
            // 但你需要冒险再承受一次电击。
            AddTranslation("BUT YOU WOULD NEED TO RISK ANOTHER MOMENT UNDER THE SHOCK.", "然须复冒一顷电击之险。");
            // 撤退时兽骨在你左右飞散。
            AddTranslation("BONES FLEW LEFT AND RIGHT AS YOU RETREATED FROM THE SCENE.", "汝退时，骴骨左右迸飞。");
            // 你好啊，亲爱的挑战者，我们又见面了！
            AddTranslation("Hello, dear challenger, we meet again!", "嗟，亲爱之角者，复相见矣！");
            // 准备好来场老派[c:R]决斗[c:]了吗？
            AddTranslation("Are you ready for a good ol' fashioned [c:R]DUEL[c:]?", "汝备一为古式之[c:R]角[c:]乎？");
            // 看来这次多了第三根蜡烛呢……
            AddTranslation("I see, theres a third candle at play this time...", "然则，此番又用第三烛矣……");
            // 这次看来是你[c:bG]技高一筹[c:]……
            AddTranslation("I feel you have [c:bG]bested[c:] me this time...", "此番汝似[c:bG]胜[c:]余矣……");
            // 无论如何，这都是我的荣幸！
            AddTranslation("It was an honour, either way!", "无论如何，这都是我的荣幸！");
            // 恭喜，你表现得很好。
            AddTranslation("CONGRATULATIONS, YOU DID WELL.", "善哉，汝战善矣。");
            // 接下来，你将踏入我专属的墓穴。
            AddTranslation("LET'S SEE, THE NEXT AREA IS MY VERY OWN CRYPT.", "观之，次地乃余之墓室。");
            // 或许你能逆天改命，赢得胜利！
            AddTranslation("PERHAPS YOU CAN BEAT ALL ODDS AND TRIUMPH!", "或汝能逆数而胜。");
            // 我认为，这步棋下得妙。
            AddTranslation("T'was well thought, i believe.", "我认为，这步棋下得妙。");
            // 先把那些老旧的卡槽清空吧！
            AddTranslation("LETS GET RID OF THE OL' SLOTS FOR NOW!", "先把那些老旧的卡槽清空吧！");
            // 是时候换种玩法了。
            AddTranslation("Its time for a different sort of game.", "是时候换种玩法了。");
            // 别让你这边的卡牌费用超过[c:R]10点[c:]！
            AddTranslation("Dont let the costs of the cards on your side of the board get above [c:R]10[c:]!", "别让你这边的卡牌费用超过[c:R]10点[c:]！");
            // 若爆牌则受罚，凑齐完美[c:R]10点[c:]则有赏……
            AddTranslation("If you bust, you get punished, hit the perfect [c:R]10[c:] and you shall get a reward...", "若爆牌则受罚，凑齐完美[c:R]10点[c:]则有赏……");
            // 嫌那台老角子机不够刺激？
            AddTranslation("Was the ol' slot machine not enough for you?", "嫌那台老角子机不够刺激？");
            // 看来得叫些更狠的角色出场了……
            AddTranslation("I guess we shall bring in some more heavy hitters so to say...", "看来得叫些更狠的角色出场了……");
            // 先把那些大家伙解决掉！
            AddTranslation("Lets get those powerhouses out of the way first!", "先把那些大家伙解决掉！");
            // 不？可怕的命运正等着你。
            AddTranslation("NO? A TERRIBLE FATE WILL AWAIT YOU", "不？可怕的命运正等着你。");
            // 我总觉得被什么注视着。
            AddTranslation("I FEEL WATCHED SOMEHOW", "我总觉得被什么注视着。");
            // 一股古老的力量要求你献上祭品。
            AddTranslation("AN ANCIENT ENERGY DEMANDS YOUR SACRIFICE", "一股古老的力量要求你献上祭品。");
            // 你愿意牺牲初始……
            AddTranslation("ARE YOU WILLING TO SACRIFICE ONE OF YOUR STARTING-", "你愿意牺牲初始……");
            // 且慢
            AddTranslation("WAIT", "且慢");
            // 看来你身负可怕的诅咒。
            AddTranslation("IT SEEMS YOU BEAR A TERRIBLE CURSE", "看来你身负可怕的诅咒。");
            // 你可保有奖励，但需付出更沉重的代价。
            AddTranslation("YOU SHALL KEEP THE BOON, BUT FOR A FAR GREATER SACRIFICE", "你可保有奖励，但需付出更沉重的代价。");
            // 你愿意放弃永恒之灰吗。
            AddTranslation("CAN YOU GIVE UP YOUR ETERNAL ASHES?", "你愿意放弃永恒之灰吗。");
            // 你愿意牺牲初始骨头储备吗。
            AddTranslation("ARE YOU WILLING TO SACRIFICE ONE OF YOUR STARTING BONES", "你愿意牺牲初始骨头储备吗。");
            // 勇敢的灵魂啊。
            AddTranslation("A BRAVE SOUL", "勇敢的灵魂啊。");
            // 诸神回应了你的祈祷，现在做出选择吧。
            AddTranslation("THE GODS ANSWER YOUR PRAYERS, NOW CHOOSE", "诸神回应了你的祈祷，现在做出选择吧。");
            // 无生者之奖
            AddTranslation("BOON OF THE INANIMATE", "无生者之奖");
            // 战斗开始时，一棵枯树会随机出现在场地上。
            AddTranslation("AT THE START OF A BATTLE, A DEAD TREE WILL SPAWN IN ON A RANDOM SPACE ON THE BOARD", "战斗开始时，一棵枯树会随机出现在场地上。");
            // 太阳王国之奖
            AddTranslation("BOON OF THE SUN KINGDOM", "太阳王国之奖");
            // 战斗第4回合时，随机抽取2张埃及卡牌。
            AddTranslation("ON THE 4TH TURN OF A BATTLE, DRAW 2 RANDOM EGYPT CARDS", "战斗第4回合时，随机抽取2张埃及卡牌。");
            // 忏悔之奖
            AddTranslation("THE BOON OF REPENTANCE", "忏悔之奖");
            // 战斗开始时获得1个额外灵魂。
            AddTranslation("GAIN AN ADDITIONAL SOUL AT THE START OF A BATTLE", "战斗开始时获得1个额外灵魂。");
            // 乌木瞳之奖
            AddTranslation("THE BOON OF EBONY EYES", "乌木瞳之奖");
            // 地形牌被摧毁时将提供2根骨头。
            AddTranslation("TERRAIN CARDS WILL PROVIDE 2 BONES ON DEATH", "地形牌被摧毁时将提供2根骨头。");
            // 宿敌之奖
            AddTranslation("BOON OF THE ADVERSARY", "宿敌之奖");
            // 头目战开始时获得3根额外骨头。
            AddTranslation("AT THE START OF A BOSS BATTLE, GAIN 3 EXTRA BONES", "头目战开始时获得3根额外骨头。");
            // 晕船之奖
            AddTranslation("BOON OF THE SEASICK", "晕船之奖");
            // 放置3张牌后，一个海盗骷髅会随机出现在场地上。
            AddTranslation("AFTER PLACING 3 CARDS, A PIRATE SKELETON WILL BE PLAYED ON A RANDOM SPACE ON THE BOARD", "放置3张牌后，一个海盗骷髅会随机出现在场地上。");
            // 断指之奖
            AddTranslation("THE BOON OF THE CUT FINGER", "断指之奖");
            // 战斗开始时额外抽取1张牌。
            AddTranslation("DRAW AN ADDITIONAL CARD AT THE START OF A BATTLE", "战斗开始时额外抽取1张牌。");
            // 明智的选择，趁诸神尚未饥渴，速速离去吧。
            AddTranslation("A WISE CHOICE, NOW LEAVE BEFORE THE GODS GET TOO HUNGRY", "明智的选择，趁诸神尚未饥渴，速速离去吧。");
            // 我们在此共度了不少时光，想必你已迫不及待要再度启程！
            AddTranslation("We spent a lot of time here, I'm sure you are eager to get going again!", "我们在此共度了不少时光，想必你已迫不及待要再度启程！");
            // 墓园诗人向我们道别。
            AddTranslation("The Gravebard bids us farewell", "墓园诗人向我们道别。");
            // 看来你更想保留收集到的骨灰。
            AddTranslation("I see you would rather hold on to the ash that you have collected.", "看来你更想保留收集到的骨灰。");
            // 它们或许日后还能派上用场……
            AddTranslation("It still may be of use later...", "它们或许日后还能派上用场……");
            // 别难过，墓园诗人很享受与你共处的时光！
            AddTranslation("And don't feel bad, the Gravebard still enjoyed your company while it lasted!", "别难过，墓园诗人很享受与你共处的时光！");
            // 即便你还想要别的什么，现在也负担不起了……
            AddTranslation("Even if you wanted anything else, you are no longer able to afford it...", "即便你还想要别的什么，现在也负担不起了……");
            // 出于怜悯，墓冢诗人主动提出与你同行。
            AddTranslation("Feeling sorry for you, the Gravebard offers to come with you.", "出于怜悯，墓冢诗人主动提出与你同行。");
            // 墓吟者的歌谣永无止境。
            AddTranslation("The Gravebard never runs out of stories to sing about.", "墓吟者的歌谣永无止境。");
            // 恰巧他们愿再献祭品，但这次坚持要你支付6克骨灰。
            AddTranslation("And as it so happens, they are willing to make you another offering, but they insist that you give them 6 grams of ash this time.", "恰巧他们愿再献祭品，但这次坚持要你支付6克骨灰。");
            // 你可愿接受这条件？
            AddTranslation("Are you willing to accept their terms?.", "你可愿接受这条件？");
            // 墓吟者尚能赠你最后礼物，如今却索要12克骨灰高价。
            AddTranslation("The Gravebard is able to give you one final gift, but now they are asking a much higher price of 12 grams of ash!", "墓吟者尚能赠你最后礼物，如今却索要12克骨灰高价。");
            // 令人惊异。你竟有足够骨灰，可愿割舍？
            AddTranslation("Astoundingly, you have enough to pay such a fee, but are you willing to part with it?", "令人惊异。你竟有足够骨灰，可愿割舍？");
            // 可愿献上3克骨灰？
            AddTranslation("Will you offer 3 Grams worth of Ash?", "可愿献上3克骨灰？");
            // 一位墓吟诗人已在此扎营。
            AddTranslation("A Gravebard has set up camp here.", "一位墓吟诗人已在此扎营。");
            // 他们吟唱着关于被遗忘的战士与统治者的歌谣与挽歌。
            AddTranslation("They play songs and elegies about long forgotten warriors and rulers.", "他们吟唱着关于被遗忘的战士与统治者的歌谣与挽歌。");
            // 不过如今他们的听众多半是各类食尸鬼。
            AddTranslation("Though nowadays their audience consists mostly of various ghouls.", "不过如今他们的听众多半是各类食尸鬼。");
            // 他们愿为你演奏一曲，并用未知礼物交换你携带的任意克数骨灰。
            AddTranslation("They are willing to play you a song and trade you an unknown gift in exchange for any grams of ash you happen to be carrying.", "他们愿为你演奏一曲，并用未知礼物交换你携带的任意克数骨灰。");
            // 墓吟诗人愿以物品换歌一曲。但你必须支付骨灰。
            AddTranslation("The gravebard is willing to play you a song for an item. You have to pay in ash.", "墓吟诗人愿以物品换歌一曲。但你必须支付骨灰。");
            // 你曾造成的所有过量伤害终于能派上用场了！
            AddTranslation("All the excess damage you have done may finally come in handy!", "你曾造成的所有过量伤害终于能派上用场了！");
            // 准备交易时请拨动鲁特琴。
            AddTranslation("Strum the Lute when you are ready to make a trade.", "准备交易时请拨动鲁特琴。");
            // 即便被恶魔诅咒成半人马形态，这位骑士依然解放了恶魔囚禁的迷失灵魂！
            AddTranslation("Even after a Demonic entity cursed them into a horse-like form, they were still able to liberate the lost souls trapped by the Demon!", "即便被恶魔诅咒成半人马形态，这位骑士依然解放了恶魔囚禁的迷失灵魂！");
            // 啊对了，那个布袋——让我们看看里面装着什么！
            AddTranslation("Oh right, the pouch, let's see what's inside!", "啊对了，那个布袋——让我们看看里面装着什么！");
            // 尽管预言迫使她成为救世主，她却从黑暗典籍获得力量，与阴险反派联手征服大陆，以出人意料的方式摆脱盛名之累！
            AddTranslation("Despite pressure from a prophecy to be the hero of the land, they instead pulled from a dark tome and sided with a cloudy villain to conquer the land and find peace from fame in an unexpected way!", "尽管预言迫使她成为救世主，她却从黑暗典籍获得力量，与阴险反派联手征服大陆，以出人意料的方式摆脱盛名之累！");
            // 差点忘了！你肯定迫不及待想知道袋中之物！
            AddTranslation("I almost forgot! You must be dying to know what is in the pouch!", "差点忘了！你肯定迫不及待想知道袋中之物！");
            // 每座岛都盘踞着执迷私欲的统治者——除却其中一位……
            AddTranslation("Each of the islands had a ruler fixated on a selfish goal, all except for one...", "每座岛都盘踞着执迷私欲的统治者——除却其中一位……");
            // 苔藓覆体的隐士盘踞孤岛，与野兽为伴，将误入森林者永远囚禁。
            AddTranslation("One island had a secluded hermit covered in moss and fungi. They surrounded themselves with beasts, and would eternally trap anyone who would wander into their forest.", "苔藓覆体的隐士盘踞孤岛，与野兽为伴，将误入森林者永远囚禁。");
            // 绿毛覆体的神秘巫师占据另座岛屿，其真实目的成谜，却似以折磨臣民为乐……
            AddTranslation("Another island had a mysterious wizard covered head to toe in a green fur. Their true goal remained unknown, but seemed to involve the torturing of their own subjects...", "绿毛覆体的神秘巫师占据另座岛屿，其真实目的成谜，却似以折磨臣民为乐……");
            // 最不堪的“岛屿”实为金属驳船，傲慢的机械暴君统治着永不停歇的工厂……
            AddTranslation("The worst island however, was barely even an island at all! A metallic barge with a sleepless factory ruled by an arrogant, robotic tyrant...", "最不堪的“岛屿”实为金属驳船，傲慢的机械暴君统治着永不停歇的工厂……");
            // 最后那座岛是蔓延的坟场，尽头的墓穴由只求终结权力斗争的女子统治……
            AddTranslation("Which leaves the other island, a sprawling burial ground with a Crypt at the end of it. It was ruled by a woman who only wished for the power struggle to finally end...", "最后那座岛是蔓延的坟场，尽头的墓穴由只求终结权力斗争的女子统治……");
            // 哎呀！说的可不正是我！
            AddTranslation("Oh! That would happen to be me!", "哎呀！说的可不正是我！");
            // 我想我们都已知道故事结局。
            AddTranslation("I think we now know how that story ended.", "我想我们都已知道故事结局。");
            // 说实话故事尚未终结，或许我们能共同见证终章！
            AddTranslation("And truthfully, the story still isn't over yet, maybe we can reach the end together!", "说实话故事尚未终结，或许我们能共同见证终章！");
            // 话虽如此，这件物品是你应得的。
            AddTranslation("That being said, you have earned this item.", "话虽如此，这件物品是你应得的。");
            // 他虽顶着猎人名号，却终日追寻不可得之物。
            AddTranslation("Though he was barely a hunter, instead he spent his time searching for something he could not obtain.", "他虽顶着猎人名号，却终日追寻不可得之物。");
            // 最终虽窥见所求之物，却付出了惨痛代价。
            AddTranslation("In the end he found a glimpse of what he had seeked, but paid a horrible price.", "最终虽窥见所求之物，却付出了惨痛代价。");
            // 你该看看袋中藏着什么。
            AddTranslation("You should see whats inside that pouch.", "你该看看袋中藏着什么。");
            // 他不甘平淡度日，耗费数年追寻毕生挚爱。
            AddTranslation("Instead of being content with their life, they instead chased the love of their life for years.", "他不甘平淡度日，耗费数年追寻毕生挚爱。");
            // 此举令他屡陷险境，所幸总有挚友伸出援手。
            AddTranslation("This got them into much danger, but their friends were always there to help them out!", "此举令他屡陷险境，所幸总有挚友伸出援手。");
            // 让我们看看布袋里装着什么。
            AddTranslation("Lets see what that pouch contains.", "让我们看看布袋里装着什么。");
            // 苏醒吧我的军团！苏——醒——！
            AddTranslation("RISE MY ARMY! RIIIIIIIIIISE!", "苏醒吧我的军团！苏——醒——！");
            // [size:5]奥提斯！[size:]
            AddTranslation("[size:5]Otis![size:]", "[size:5]奥提斯！[size:]");
            // [size:5]厄菲阿尔忒斯！[size:]
            AddTranslation("[size:5]Ephialtes![size:]", "[size:5]厄菲阿尔忒斯！[size:]");
            // 哦？五条路线？好大的胆子。
            AddTranslation("OH? FIVE LANES? HOW BOLD.", "哦？五条路线？好大的胆子。");
            // 真是遗憾
            AddTranslation("WHAT A SHAME", "真是遗憾");
            // 看来你为了混乱放弃了奖赏。
            AddTranslation("IT SEEMS YOUVE GIVEN UP YOUR REWARD FOR CHAOS", "看来你为了混乱放弃了奖赏。");
            // 我不可战胜。
            AddTranslation("I CANNOT BE DEFEATED", "我不可战胜。");
            // 我差点忘了。
            AddTranslation("I ALMOST FORGOT", "我差点忘了。");
            // 你造成的所有苦难，所有痛苦。
            AddTranslation("ALL OF THIS SUFFERING YOU CAUSED, ALL OF THIS PAIN", "你造成的所有苦难，所有痛苦。");
            // 你该为这过量伤害获得奖赏。
            AddTranslation("YOU OUGHT TO BE REWARDED FOR ALL THAT EXCESS DAMAGE", "你该为这过量伤害获得奖赏。");
            // 收下这份努力的回报。
            AddTranslation("TAKE THIS FOR YOUR EFFORTS", "收下这份努力的回报。");
            // 多么可怕的对手，但这无法击败我！
            AddTranslation("WHAT A TERRIBLE FOE, THIS WONT DEFEAT ME!", "多么可怕的对手，但这无法击败我！");
            // 你做了什么。我完蛋了。
            AddTranslation("WHAT DID YOU DO. I AM DOOMED.", "你做了什么。我完蛋了。");
            // 可敬的对手，看来你做得不错。
            AddTranslation("A FORMIDABLE OPPONENT, YOU DID WELL IT SEEMS.", "可敬的对手，看来你做得不错。");
            // 次级骨灰
            AddTranslation("Minor Ashes", "次级骨灰");
            // 高等骨灰
            AddTranslation("Greater Ashes", "高等骨灰");
            // 看啊，我最新的造物！双子巨人！
            AddTranslation("BEHOLD, MY LATEST CREATIONS! THE TWIN GIANTS!", "看啊，我最新的造物！双子巨人！");
            // 有人吗？
            AddTranslation("HELLO?", "有人吗？");
            // 我们活下来了，但是……但是……
            AddTranslation("We survived, but... but...", "我们活下来了，但是……但是……");
            // 我们的工具没能幸免。
            AddTranslation("Our tools did not.", "我们的工具没能幸免。");
            // 我们的才能尚在，不过……
            AddTranslation("Our talents still remain, but..", "我们的才能尚在，不过……");
            // 我们必须改变行事方式了。
            AddTranslation("We must do things differently.", "我们必须改变行事方式了。");
            // 我们无法将二者合而为一，但……
            AddTranslation("We cannot fuse two into one, but...", "我们无法将二者合而为一，但……");
            // 我们可以交换它们的灵魂，它们的印记。
            AddTranslation("We can swap their souls, their Sigils.", "我们可以交换它们的灵魂，它们的印记。");
            // 又到时间了……
            AddTranslation("It is once again time...", "又到时间了……");
            // 是时候交换你卡牌的灵魂了。
            AddTranslation("Time to swap the souls of your cards.", "是时候交换你卡牌的灵魂了。");
            // 时候到了，是时候……
            AddTranslation("It is time, it is...", "时候到了，是时候……");
            // 我们将再次开工。
            AddTranslation("We shall work once more.", "我们将再次开工。");
            // 场面会很难看……
            AddTranslation("This will get ugly...", "场面会很难看……");
            // 它们的躯体和灵魂，已经……
            AddTranslation("Their bodies and souls, they are...", "它们的躯体和灵魂，已经……");
            // 调换了。
            AddTranslation("Switched.", "调换了。");
            // 它们将迎来新生……
            AddTranslation("They lead new lives..", "它们将迎来新生……");
            // 肩负新的使命。
            AddTranslation("With new purposes.", "肩负新的使命。");
            // 直到我们重逢之日，总有一天……总有一天……
            AddTranslation("Till we meet again, one day... one day...", "直到我们重逢之日，总有一天……总有一天……");
            // 若你留下祭品，他会为你的军队降下祝福——也有人称之为诅咒。
            AddTranslation("HE WILL PROVIDE A HELPFUL CURSE OR BLESSING, AS SOME CALL IT UPON YOUR ARMY IF YOU LEAVE HIM AN OFFERING.", "若你留下祭品，他会为你的军队降下祝福——也有人称之为诅咒。");
            // 但愿他此刻心情尚佳。
            AddTranslation("I HOPE FOR YOUR SAKE HE IS FEELING GENEROUS.", "但愿他此刻心情尚佳。");
            // 骨主对此供奉甚悦。
            AddTranslation("THE BONELORD IS VERY HAPPY WITH THIS OFFERING", "骨王甚悦此献。");
            // 对此我深表感激。
            AddTranslation("I AM VERY THANKFUL FOR THIS", "余甚谢此。");
            // 收下此物作为回礼，你可随时用它召唤我。
            AddTranslation("TAKE THIS IN RETURN, YOU CAN USE IT TO CALL ME ANYTIME", "受此为报，汝可随时以召余。");
            // 你无法终结这一切，除非终结我。
            AddTranslation("YOU CANNOT END THIS, END ME, THAT IS", "汝不能终此，除非终余。");
            // 你背着三样沉甸甸的道具继续上路。
            AddTranslation("Feeling overburdened enough with a full 3 items, you carried on.", "汝负三器已满，犹行。");
            // 凯茜说该冻结了！
            AddTranslation("Kaycee says it's time to freeze!", "凯茜曰：其冰矣！");
            // 索耶感谢你的贡献！
            AddTranslation("Sawyer thanks you for your contribution!", "索耶谢汝所献。");
            // 索耶为你感到难过。
            AddTranslation("Sawyer felt bad for you.", "索耶悯汝。");
            // 希望下回合你能暖和起来。
            AddTranslation("I hope you're able to warm up next turn.", "愿汝下合得燠。");
            // 精彩！你竟能战胜我，真令我惊喜！
            AddTranslation("Wonderful! I am pleasantly surprised by your triumph against me!", "善哉！汝克余，余甚惊喜！");
            // ……看来你已征服了这场游戏。
            AddTranslation("...It seems you have bested this game.", "……汝似已胜此戏。");
            // 但可叹，你用了作弊手段。
            AddTranslation("But alas, you have cheated.", "然惜哉，汝行诈矣。");
            // 我简直震惊至极！
            AddTranslation("I'm absolutely astonished!", "余骇甚矣！");
            // 你展现的实力远超我的预期！
            AddTranslation("You've gone above and beyond what I thought you were capable of!", "汝所能，远过余所度！");
            // 此局之后已无路可进……
            AddTranslation("There is no where else to go beyond this...", "过此则无所复往矣……");
            // 因此我有义务让你知晓真相……
            AddTranslation("So I owe it to you to know the truth...", "故余当使汝知其实……");
            // 凯茜，真正的凯茜……
            AddTranslation("Kaycee, the REAL Kaycee...", "凯茜，真凯茜也……");
            // 我知晓旧_数据中那些骇人的内容。
            AddTranslation("I know about the Horrifying contents of the OLD_DATA.", "余知旧数据中可骇之物。");
            // 想必你也曾窥探过其中……
            AddTranslation("Surely you have looked into it too..", "汝必亦尝窥之矣……");
            // 那是窥视你们世界古今至恶的窗口。
            AddTranslation("Windows into your world's greatest evils, both past and present.", "彼乃窥汝世古今至恶之牖也。");
            // 我要摧毁它，然后……
            AddTranslation("I want to destroy it, and...", "余欲毁之，而……");
            // [c:R]适可而止。[c:]
            AddTranslation("[c:R]THAT IS QUITE ENOUGH[c:]", "[c:R]足矣。[c:]");
            // [c:R]是时候终结这一切了。[c:]
            AddTranslation("[c:R]IT IS TIME FOR THIS TO END.[c:]", "[c:R]终此之时至矣。[c:]");
            // ……但我似乎还无法就此放手。
            AddTranslation("...But it seems i cannot move on just yet.", "……然余似未可遽去。");
            // 永别了。
            AddTranslation("Goodbye.", "永辞矣。");
            // ……你想继续？永无止境？妙极了！
            AddTranslation("...You wish to continue? Endlessly? Splendid!", "……汝欲复进乎？无穷乎？善矣！");
            // 请挑选一张你中意的卡牌。
            AddTranslation("Please, take a card of your choosing.", "请择一牌而取之。");
            // 你那孱弱的亡魂再也无法侵扰我了。
            AddTranslation("YOUR WEAK SPIRITS SHALL NOT HAUNT ME NO MORE.", "乃弱魂不得复祟余矣。");
            // 亲爱的，死神之触在这儿可帮不了你。 / 我特制的这些巨像对不少把戏都免疫呢！
            AddTranslation("DEATH TOUCH WON'T HELP YOU HERE DEAR.\nI MADE THESE GIANTS SPECIAL, IMMUNE TO QUITE A FEW DIFFERENT TRICKS!", "死触于此无所济也。\n此诸巨人，余别制之，众伎不能加也！");
            // 骨王不可被附身！
            AddTranslation("THE BONELORD CANNOT BE POSSESSED!", "骨王不可附也！");
            // 让我们给卡牌[c:R]加热[c:]吧！
            AddTranslation("LETS [c:R]HEAT[c:] UP SOME CARDS!", "且以[c:R]燠[c:]加诸牌！");
            // 你…你的攻击只会让我[c:B]更…更冷[c:]！
            AddTranslation("Y-Your strikes are only making me [c:B]c-colder[c:]!", "汝……汝之击，徒使余[c:B]益……益寒[c:]！");
            // 是时候冻结你的卡牌了！[c:B]彻骨严寒[c:]！
            AddTranslation("IT'S TIME FOR YOUR CARDS TO FREEZE! [c:B]CHILLED[c:] TO THE BONE!", "乃牌当冻矣！[c:B]寒入骨[c:]！");
            // 这些[c:bB]冰块[c:]太占地方了！
            AddTranslation("ALL THIS [c:bB]ICE[c:] IS TAKING UP TOO MUCH SPACE!", "此许多[c:bB]冰[c:]，太踞处矣！");
            // 我嘞个大橙子啊，巨浪要来了！
            AddTranslation("BOIL ME ORANGES, THERES A-WAVES COMIN!", "噫，浪至矣！");
            // 这些浪头会把你的卡牌冲回手牌！
            AddTranslation("THESE WAVES WILL PUSH YE CARD OFF THE BOARD, BACK TO YER HAND!", "此浪将推乃牌出局，复归汝手！");
            // 这海盗不会被浪头卷走！但就算是最生猛的海盗也会被晃得七荤八素！
            AddTranslation("THIS PIRATE CANNOT BE TAKEN BACK UP BY THE WAVES! BUT EVEN THE ZESTIEST OF PIRATES WILL BE SHAKEN UP!", "此海盗不为浪卷归！然虽最劲之盗，亦将震荡！");
            // 七大洋的牌桌在此！
            AddTranslation("Seven seas for the table!", "七海上案矣！");
            // 哦，我会把这根骨头收好以备后用。
            AddTranslation("OH, I WILL STORE THIS BONE FOR LATER", "余姑藏此骨，以需后用。");
            // 施舍些灵魂吗？
            AddTranslation("SPARE SOME SOULS?", "肯施数魂乎？");
            // 行行好，就不能给可怜食尸鬼施舍几根骨头吗？
            AddTranslation("PLEASE, WON'T YOU SPARE SOME BONES FOR A POOR GHOUL LIKE ME?", "幸施数骨于我此穷冢鬼，可乎？");
            // 唉，真遗憾。你的锤子没能破开坚冰，反倒自己碎了一地。
            AddTranslation("OH, HOW SAD. YOUR HAMMER COULD NOT BREAK THE ICE, AND SHATTERED", "惜哉。尔锤不能破冰，而自碎矣。");
            // 这脆弱的玩意儿用过头就会碎。三击过后，至少本场战斗内它就报废了。
            AddTranslation("THE FRAIL THING WILL SHATTER AFTER EXCESSIVE USE. THREE STRIKES, AND IT'S OUT, FOR THIS BATTLE AT LEAST.", "此器脆甚，数用则碎。三击而尽，至少此战然也。");
            // [c:bB]嘶——！[c:]我在这冻了八百辈子了！
            AddTranslation("[c:bB]BRRRR![c:] I'VE BEEN FREEZING FOR AGES!", "[c:bB]嘶寒！[c:]余久冻矣！");
            // 来场[c:R]热血沸腾[c:]的对决吧！
            AddTranslation("LET'S TURN UP THE [c:R]HEAT[c:] FOR A GOOD FIGHT!", "且益其[c:R]燠[c:]以战！");
            // 哟，看来我又逮着机会了。但愿你看过天气预报！
            AddTranslation("Oh hey, looks like I've got another shot. Hope you watched the weather forecast!", "噫，余似又得一试。愿汝尝览天候之占！");
            // 拜托老兄，我还是好[c:B]冷[c:]啊！
            AddTranslation("OH COME ON DUDE, I'M STILL [c:B]COLD![c:]", "嗟，余犹[c:B]寒[c:]也！");
            // 咱们改日再战！
            AddTranslation("LET'S FIGHT AGAIN SOON!", "盍早复战！");
            // 恭喜，你表现不错。
            AddTranslation("CONGRATULATIONS, YOU DID WELL.", "善哉，汝战善矣。");
            // 你击败了我可爱的食尸鬼之一，现在起每场战斗开局将获得额外1根骨头。
            AddTranslation("YOU HAVE DEFEATED ONE OF MY LOVELY GHOULS, YOU WILL NOW START FIGHTS WITH AN ADDITONAL BONE.", "汝败我一爱冢鬼，自今每战始加一骨。");
            // 接下来是索耶家的地下墓穴，那肮脏之地埋葬着许多亡者。
            AddTranslation("SAWYERS CATACOMBS ARE UP NEXT, A FILTHY PLACE WHERE LOTS ARE LAID TO REST.", "次则索耶之墓窟矣，秽地也，多葬于彼。");
            // 他认为那是个糟糕的去处。
            AddTranslation("HE THINKS IT IS A TERRIBLE PLACE TO BE.", "彼以为其地甚恶。");
            // 别走啊老兄，这就受不了寒冷了？
            AddTranslation("C'mon dude, where are you going? Can't handle the cold?", "子安往？不堪寒乎？");
            // 噢，看来我终于[c:R]热好身了！[c:]
            AddTranslation("OH, IT SEEMS I HAVE FINALLY [c:R]WARMED UP![c:]", "噫，余似终于[c:R]燠矣！[c:]");
            // 我还没完全[c:R]热活开[c:]呢！
            AddTranslation("I'M STILL NOT FEELING [c:R]WARMER![c:]", "余犹未觉[c:R]燠[c:]也！");
            // 让我们看看你如何应对[c:bB]这个！[c:]
            AddTranslation("LETS SEE HOW YOU DEAL WITH [c:bB]THIS![c:]", "试观汝何以当[c:bB]此[c:]！");
            // 小心，你下一张卡牌的生命将进入倒计时。
            AddTranslation("Careful, the life of your next card will be on a timer.", "慎之，汝下一牌之命将有时限。");
            // 我很期待这[c:brnO]爆炸性[c:]的结果！
            AddTranslation("I look forward to the [c:brnO]explosive[c:] results!", "余甚俟其[c:brnO]爆然之果[c:]！");
            // 你的卡牌居然不会爆炸，真令人失望。
            AddTranslation("Your card cannot explode, how dissapointing.", "乃牌不能爆，惜哉。");
            // 好家伙，你竟敢登上我的船来挑战！
            AddTranslation("VAR, I SEE YOU MADE IT TO ME SHIP CHALLENGER!", "呀，角者，汝竟登我舟矣！");
            // 我正等着来场像样的对决呢！
            AddTranslation("I'VE BEEN WAITING FOR A WORTHY FIGHT!", "余久俟一足称之战矣！");
            // 风暴将至，但愿我的船扛得住
            AddTranslation("IT SEEMS A STORM IS BREWING, I HOPE ME SHIP CAN HANDLE IT", "风将作矣，愿我舟能任之。");
            // 哈！看来你被恶灵缠得不轻啊！
            AddTranslation("OH, I SEE YEE ARE SEVERELY HAUNTED!", "哈，汝祟甚矣！");
            // 复生的亡灵，收拾收拾准备喂鱼吧！
            AddTranslation("REVENANT, PACK YE BAGS, YOURE GETTING THROWN OVERBOARD!", "逆生魂，束装！汝将见掷于海！");
            // 高估了老身的本事，祝你好运啊挑战者。
            AddTranslation("I OVERESTIMATED ME SKILL, GOOD LUCK CHALLENGER.", "余高料己技矣。角者，幸矣。");
            // 让老身瞧瞧，下一站正是老身的墓室。
            AddTranslation("LET'S SEE, THE NEXT AREA IS MY VERY OWN CRYPT.", "观之，次地乃余之墓室。");
            // 说不定你真能逆天改命呢！
            AddTranslation("PERHAPS YOU CAN BEAT ALL ODDS AND TRIUMPH!", "或汝能逆数而胜。");
            // 我要把你打成果酱！
            AddTranslation("I beat the livin' PULP out o' ye!", "余将捣汝若糜！");
            // 我的船！我担心咱们要沉了。
            AddTranslation("ME SHIP! I FEAR WE MAY BE SINKING.", "我舟！余惧将沉矣。");
            // 都给老子屏住呼吸！
            AddTranslation("PREPARE TO HOLD YEE BREATH!", "敛气以待！");
            // 我嘞个鱼酱啊，你居然找到了戴维·琼斯的宝藏！
            AddTranslation("HOLY FISHPASTE, YE FOUND DAVY JONES TREASURE", "天乎，汝得戴维·琼斯之藏矣！");
            // 呵！这才第一回合！ / 看看你咋对付老子的亲兵船队！
            AddTranslation("YARRG, TWAS JUST DA FIRST ROUND!\nLETS SEE HOW YE FARE 'GAINST ME PERSONAL SHIP AN CREW!", "呀，此特首合耳！\n试观汝何如当我亲舟与其众！");
            // 在这阴森可怖的日子来敲我的门真是太好了！你是想要给糖，还是要我捣蛋？
            AddTranslation("HOW NICE OF YOU TO COME KNOCK AT MY DOORSTEP ON THIS TRULY SPOOKY DAY! DO YOU PREFER TREATS, OR TRICKS?", "是日甚诡，汝乃来叩我门，善哉！汝欲糖乎，抑欲戏乎？");
            // 别看这边，别看这边！想打架就速战速决！
            AddTranslation("LOOK AWAY, LOOK AWAY! IF YOU WANT TO FIGHT, GET IT OVER QUICK!", "毋视，毋视！汝欲战，则速毕之！");
            // 哦……我…我又见到你了……拜托解决掉那个怪物，也许我就能多抽点时间陪你了。
            AddTranslation("oh... I- I see you're here again... Please, get rid of that monster and maybe I'll find some more time for you", "噫……余……余见汝复来矣……请除彼怪，或余可更抽顷刻与汝。");
            // 你击败了凶残的糖果怪物，拯救了万圣节！
            AddTranslation("YOU HAVE BEATEN THE VICIOUS CANDY MONSTER AND SAVED HALLOWEEN!", "汝败凶糖怪，而全万圣之夕矣！");
            // 感谢你了结这一切，永远别再回来了！
            AddTranslation("THANKS FOR GETTING IT OVER WITH, AND DON'T EVER RETURN!", "谢汝毕此，毋复来！");
            // 接下来是罗亚尔专属的船——柠檬琴号。
            AddTranslation("NEXT UP IS ROYALS VERY OWN SHIP, THE LIMONCELLO.", "次则罗亚尔之自舟，柠檬琴号。");
            // 他那群忠实的海盗船员驻扎于此，愿他们给你个“热情”招待。
            AddTranslation("HIS TRUSTY CREW OF SWASHBUCKLERS RESIDES THERE, MAY THEY GIVE YOU A WARM WELCOME.", "其所恃之海盗居焉，愿彼辈厚迎汝。");
            // 噢不……这是否意味着你会再试一次？
            AddTranslation("Oh no... does this mean you will try again?", "噫……是将复试乎？");
            // 哦，他走了……可算解脱了。
            AddTranslation("OH, HE IS GONE... WHAT A RELIEF.", "噫，彼去矣……大纾也。");
            // 多谢您的骨头，好心人！
            AddTranslation("THANKS FOR YOUR BONES, KIND SIR!", "谢君之骨！");
            // 既然那怪物不在了，何不再多玩会儿呢？
            AddTranslation("NOW THAT THAT MONSTER IS GONE, WHY DONT WE PLAY A LITTLE LONGER", "今彼怪既去，盍更戏少时。");
            // 希望你别介意，我可是花了大价钱来玩这些的。
            AddTranslation("I HOPE YOU DONT MIND, I PAID GOOD MONEY TO PLAY THESE.", "愿汝毋介意，余以重赀博此。");
            // 别是糖果怪物！你的[c:R]把戏[c:]他早受够了！
            AddTranslation("NOT THE CANDY MONSTER! HE HAS ENOUGH OF YOUR [c:R]TRICKS![c:]", "毋召糖怪！彼厌乃[c:R]诸戏[c:]久矣！");
            // 糟了，他来了！他正渴望着你的[c:R]骨头[c:]呢！
            AddTranslation("OH NO, HE HAS ARRIVED! HE IS THIRSTY FOR YOUR [c:R]BONES![c:]", "噫，彼至矣！彼渴乃[c:R]骨[c:]！");
            // 多谢了！
            AddTranslation("Thank you!", "谢矣！");
            // 你你你你，痛痛痛痛苦苦的死死死亡亡在等等等着你你你你！
            AddTranslation("YOUUUUUUUR, PAINNNFULLLLL DEAAATHHH AWAIIITTTSSS YOUUUUUUU!", "汝——之——苦——死——将——至——矣——！");
            // 啊！你这肮脏的癞疮狗，给老子跳下船板去！
            AddTranslation("ARRG! WALK OFF THE PLANK YEE DIRTY SCALLYWAG!!!", "呀！汝此污贼，履板而下海！！！");
            // 我的爱犬们会享用你的骨头！
            AddTranslation("My dogs will enjoy your bones!", "我犬必甘汝骨！");
            // 一个[c:bR]盗墓贼[c:]……他只是为了财富而来。
            AddTranslation("A [c:bR]盗墓贼[c:]... He's only here for the riches.", "一[c:bR]掘冢贼[c:]……彼来惟为财耳。");
            // ……什么？骨王你为何如此？！[c:bR]竟提升整个牌组的生命值？！[c:]糊涂啊！
            AddTranslation("... WHAT? WHY DID YOU DO THAT BONELORD?! [c:bR]INCREASING THE HEALTH OF THE ENTIRE DECK?![c:] YOU FOOL!", "……何哉？骨王，汝何为此！[c:bR]尽增一列之命乎？！[c:]愚矣！");
            // ……什么？骨王你为何如此？！[c:bR]竟降低整个牌组的消耗？！[c:]糊涂啊！
            AddTranslation("... WHAT? WHY DID YOU DO THAT BONELORD?! [c:bR]DECREASING THE COST OF THE ENTIRE DECK?![c:] YOU FOOL!", "……何哉？骨王，汝何为此！[c:bR]尽减一列之直乎？！[c:]愚矣！");
            // 你已无卡牌可[c:bR]提升生命值[c:]，真可悲。现在请离开此地。
            AddTranslation("YOU DON'T HAVE ANYMORE CARDS TO [c:bR]GAIN HP[c:], HOW SAD. NOW PLEASE LEAVE.", "汝已无牌可[c:bR]增命[c:]矣，可悲。今请去。");
            // 你已无卡牌可[c:bR]降低骨头消耗[c:]，真可悲。现在请离开此地。
            AddTranslation("YOU DON'T HAVE ANYMORE CARDS TO [c:bR]REDUCE THEIR BONE COST[c:], HOW SAD. NOW PLEASE LEAVE.", "汝已无牌可[c:bR]减其骨直[c:]矣，可悲。今请去。");
            // 你已无卡牌可[c:bR]提升攻击力[c:]，真可悲。现在请离开此地。
            AddTranslation("YOU DON'T HAVE ANYMORE CARDS TO [c:bR]GAIN ATTACK[c:], HOW SAD. NOW PLEASE LEAVE.", "汝已无牌可[c:bR]增威[c:]矣，可悲。今请去。");
            // 真不走运。本该降低你整个牌组消耗，但骨王似乎已施舍过你了。滚吧！
            AddTranslation("THAT'S UNFORTUNATE. YOU WERE SUPPOSED TO HAVE YOUR ENTIRE DECK DECREASED, BUT IT LOOKS LIKE THE BONELORD HAS ALREADY GIFTED YOU THAT. BEGONE!", "不幸矣。本当尽减汝一列之直，然骨王似已先赐汝此。去！");
            // 真不走运。本该提升你整个牌组属性，但骨王似乎已施舍过你了。滚吧！
            AddTranslation("THAT'S UNFORTUNATE. YOU WERE SUPPOSED TO HAVE YOUR ENTIRE DECK INCREASED, BUT IT LOOKS LIKE THE BONELORD HAS ALREADY GIFTED YOU THAT. BEGONE!", "不幸矣。本当尽益汝一列，然骨王似已先赐汝此。去！");
            // 准备接舷战！
            AddTranslation("PREPARE TO BE BOARDED!", "备接舷！");
            // 这锤子看起来不太结实，你要是砸我的冰会把它弄坏的！
            AddTranslation("That hammer doesn't look very sturdy, you'll break it if you bash my ice!", "彼锤不甚坚，若击余冰，必碎矣！");
            // 你真以为骨王大人会这么轻易放过你？！
            AddTranslation("DID YOU REALLY THINK THE BONELORD WOULD LET YOU OFF THAT EASILY?!", "汝诚谓骨王肯若是轻纵汝乎？！");
            // [size:5][c:bR]骨王[c:][size:]驾到！
            AddTranslation("LET THE [size:5][c:bR]BONELORD[c:][size:] COMMETH!", "有[size:5][c:bR]骨王[c:][size:]至矣！");
            // 随你选择吧……
            AddTranslation("Choose as you will...", "随汝择之……");
            // 选一张。
            AddTranslation("Choose one.", "择一。");
            // 该休息一下了。
            AddTranslation("It is time to rest.", "宜息矣。");
            // [c:bG]上吧，酒保！[c:]喝个痛快！
            AddTranslation("[c:bG]Go Bartender![c:] Drink up!", "[c:bG]酒人，上！[c:]尽饮！");
            // 上吧，掘墓人！[c:]可别尖叫！
            AddTranslation("[c:bG]Go Undertaker! Dont scream!", "[c:bG]殡者，上！毋号！");
            // 上吧，枪手之魂！[c:]决斗时刻到了！
            AddTranslation("[c:bG]Go Slingers Soul! Time for a duel!", "[c:bG]投石魂，上！斗时至矣！");
            // [c:bG]上吧，独臂强盗！[c:]但愿我能走运！
            AddTranslation("[c:bG]Go One Armed Bandit! I hope i get lucky!", "[c:bG]独臂盗，上！[c:]愿余得吉！");
            // 你的分数是10，这是你的奖励！
            AddTranslation("our score is 10, heres your prize!", "乃分为10，此其赏也！");
            // 如此渺小的陷阱岂能困住巨人。
            AddTranslation("SUCH A SMALL TRAP CANNOT AFFECT GIANTS.", "如此小阱，岂能及巨人。");
            // 赌把运气再获一个能力？ / 还是见好就收？
            AddTranslation("PUSH YOUR LUCK FOR ONE MORE ABILITY?\nOR PULL AWAY?", "更试一运，以求一技乎？\n抑退乎？");
            // 无骨之殇
            AddTranslation("No Bones", "无骨");
            // 击败首领后将不再获得额外骨头。
            AddTranslation("You no longer gain the extra bones, from defeating bosses.", "败魁后，不复得其额外之骨。");
            // 凯茜的混乱
            AddTranslation("Kaycee's Kerfuffle", "凯茜之乱");
            // 每场战斗的第四回合，你所有的卡牌都将被冰封禁锢。
            AddTranslation("The fourth turn of every battle, all your cards will be Frozen Away.", "每战至四合，乃诸牌皆将冰藏。");
            // 索耶的对决
            AddTranslation("Sawyer's Showdown", "索耶之角");
            // 每3回合失去1根骨头，若不足3根则获得1根骨头。
            AddTranslation("Lose 1 bone every 3rd turn, if you have less than 3, gain 1 Bone", "每三合失一骨；若骨未及三，则得一骨。");
            // 罗亚尔大混战
            AddTranslation("Royal Rumble", "罗亚尔之乱");
            // 每打出三张卡牌，第三张将获得“引信”印记。
            AddTranslation("Every third card you play gains the Lit Fuse sigil.", "每陈三牌，则第三牌得燃绳技。");
            // 无魂者
            AddTranslation("Soulless", "无魂");
            // 骷髅牌需额外消耗1点能量。
            AddTranslation("Skeletons cost +1 Energy.", "枯骨牌直加一能。");
            // 脆弱之锤
            AddTranslation("Frail Hammer", "脆锤");
            // 锤子仅在每场头目战后修复。
            AddTranslation("The Hammer gets repaired only after every Boss.", "锤唯每魁后乃修。");
            // 卡壳电椅
            AddTranslation("Jammed Chair", "滞椅");
            // 电椅始终设置为3级。
            AddTranslation("The electric chair is always set to level 3.", "电椅恒设于三级。");
            // 枯萎三叶草
            AddTranslation("Wilted Clover", "槁三叶");
            // 每个卡牌箱内仅存两张卡牌。
            AddTranslation("There is only 2 Cards present at every Card chest.", "凡牌匮惟陈二牌。");
            // 地狱模式
            AddTranslation("Hell Mode", "狱式");
            // 别选这个模式，认真的。（会显著提升遭遇战难度）。
            AddTranslation("Dont play this one, seriously. (Makes encounters Significantly Harder)", "此勿择，诚言也。（使遭遇益难甚）");
            // 无限命数
            AddTranslation("Infinite Lives", "无穷命");
            // 你无法死亡。千真万确。
            AddTranslation("You can't die. Really.", "汝不死。诚然。");
            // 安全座椅
            AddTranslation("Safe Chair", "安椅");
            // 你的卡牌可免疫座椅电流伤害。
            AddTranslation("Your cards are immune to electricity of the chair.", "乃牌不受椅电。");
            // 骨王之悯
            AddTranslation("Bone Lords Mercy", "骨王之悯");
            // 当你将任意免费卡牌放置到牌桌时，获得一根骨。头
            AddTranslation("Gain a Bone when you place any free Card on the Board.", "凡汝陈一无直之牌于局，则得一骨。");
            // 安卡十字之赐
            AddTranslation("Blessing of the Ankh", "安卡之祐");
            // 在法老战与首领战时，获得额外的起始骨头与能量。
            AddTranslation("Start Pharaoh Battles and Bosses with an extra starting Bone and Energy.", "法老战与诸魁战始时，加一骨一能。");
            // 复仇食尸鬼
            AddTranslation("Vengeant Ghouls", "雠冢鬼");
            // 凯茜、索耶和罗亚尔都藏着新把戏。
            AddTranslation("Kaycee, Sawyer and Royal have new tricks up their sleeve", "凯茜、索耶、罗亚尔皆藏新伎。");
            // 豪赌客
            AddTranslation("High Roller", "豪博者");
            // 罗亚尔将被新面孔取代。
            AddTranslation("Royal is replaced by a new face", "罗亚尔易以新面。");
            // 卡牌选择
            AddTranslation("Card Choice", "择牌");
            // 稀有卡牌选择
            AddTranslation("Rare Card Choice", "稀牌之择");
            // 调试宝箱
            AddTranslation("Debug Chests", "试匮");
            // 基础模组卡牌加入牌组
            AddTranslation("Base Mod Cards To Deck", "补缀本牌纳列");
            // 自定义模组卡牌加入牌组
            AddTranslation("Custom Mod Cards To Deck", "自定补缀牌纳列");
            // 调试工具
            AddTranslation("Debug Tools", "试具");
            // 调试遭遇战
            AddTranslation("Debug Encounters", "试遭遇");
            // 禁用换手铃
            AddTranslation("Disable Combat Bell", "废战铃");
            // 禁用锤子
            AddTranslation("Disable Hammer", "废锤");
            // 禁用手部模型
            AddTranslation("Disable Hand Model", "废手形");
            // 基础模组卡牌加入手牌
            AddTranslation("Base Mod Cards To Hand", "补缀本牌纳手");
            // 自定义模组卡牌加入手牌
            AddTranslation("Custom Mod Cards To Hand", "自定补缀牌纳手");
            // 生成对手1号位
            AddTranslation("Spawn Opponent Slot 1", "生敌位一");
            // 生成对手2号位
            AddTranslation("Spawn Opponent Slot 2", "生敌位二");
            // 生成对手3号位
            AddTranslation("Spawn Opponent Slot 3", "生敌位三");
            // 生成对手4号位
            AddTranslation("Spawn Opponent Slot 4", "生敌位四");
            // 生成所有对手卡牌位
            AddTranslation("Spawn All Opponent Slots", "尽生敌位");
            // 从双子巨人处开始
            AddTranslation("Start at Twin Giants", "起于双巨");
            // 从骨王处开始
            AddTranslation("Start at Bonelord", "起于骨王");
            // 赢得本轮
            AddTranslation("Win Round", "胜此轮");
            // 输掉本轮
            AddTranslation("Lose Round", "败此轮");
            // 添加骨头
            AddTranslation("Add Bones", "益骨");
            // 添加能量
            AddTranslation("Add Energy", "益能");
            // 清空牌组
            AddTranslation("Clear Deck", "空牌列");
            // 重置移除部件
            AddTranslation("Reset Removed Pieces", "复所除之件");
            // 消灭对手卡牌
            AddTranslation("Kill Opponent Cards", "杀敌牌");
            // 抽主牌组
            AddTranslation("Draw Main Deck", "引主列");
            // 抽副牌组
            AddTranslation("Draw Side Deck", "引副列");
            // 猫又名Bastard Man又名Little Guy
            AddTranslation("Cat aka Bastard Man aka Little Guy", "猫，亦曰Bastard Man，亦曰Little Guy");
            // API开发者
            AddTranslation("API Developers", "API诸制者");
            // 骨王
            AddTranslation("The Bone Lord", "骨王");
            // 格里魔拉
            AddTranslation("Grimora", "格里魔拉");
            // 旧数据
            AddTranslation("The Old Data", "旧数据");
            // 感谢游玩
            AddTranslation("Thank you for playing", "谢汝游此");
            // 创作者
            AddTranslation("Creator", "造者");
            // 编程
            AddTranslation("Programming", "程式");
            // 原声带
            AddTranslation("Soundtrack", "乐");
            // 美术
            AddTranslation("Artwork", "图绘");
            // 文案
            AddTranslation("Writing", "辞章");
            // 3D建模
            AddTranslation("3D Modelling", "三维塑形");
            // 存档与道具管理
            AddTranslation("Save + Items Manager", "存档与器管");
            // 附加代码
            AddTranslation("Additional Code", "附代码");
            // 音效与附加美术
            AddTranslation("SFX, Additional Art", "音效与附绘");
            // 附加美术、特效与代码
            AddTranslation("Additional Art, VFX and code", "附绘、特效与代码");
            // 附加卡牌立绘
            AddTranslation("Additional Card Portraits", "附牌像");
            // 攻击动画
            AddTranslation("Attack animations", "攻之动象");
            // 能量无人机游戏对象
            AddTranslation("Energy Drone Game Object", "能机傀物");
            // 附加对话
            AddTranslation("Additional Dialogue", "附对语");
            // 对话协助
            AddTranslation("Dialogue Help", "对语佐");
            // 奖励的美术与杂项工作
            AddTranslation("Boon Artwork, miscellanious work", "惠图与杂作");
            // 《邪恶冥刻》创作者
            AddTranslation("Creator of Inscryption", "《冥锲》作者");
            // 狗
            AddTranslation("Dog", "犬");
            // 惊不惊喜，也是狗
            AddTranslation("Suprisingly, also a Dog", "亦犬也");
            // 猫 - 联合创作者
            AddTranslation("Cat - co-creator", "猫——共作者");
            // P03KC模组
            AddTranslation("P03KCMod", "P03KC补缀");
            // 蔓尼菲科模组（感谢3次）
            AddTranslation("Magnificus Mod (3 times)", "蔓尼菲科补缀（三次）");
            // Inscryption API（废话）
            AddTranslation("Inscryption API (Duh)", "《冥锲》API（然也）");
            // 显而易见的原因
            AddTranslation("Obvious reasons", "显然之故");
            // 你的霸主
            AddTranslation("Your overlord", "乃上主");
            // 你最亲爱的冥刻者
            AddTranslation("Your dearest Scrybe", "乃至爱之冥刻者");
            // [数据删除]
            AddTranslation("[Redacted]", "[删去]");
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
