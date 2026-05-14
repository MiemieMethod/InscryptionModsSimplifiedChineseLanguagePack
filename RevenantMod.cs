using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class RevenantMod
    {
        public static void RegisterTranslations()
        {
            // 亡灵舞者
            AddTranslation("DanseMacabre", "亡灵舞者");
            // 支付2根骨头，逆转该印记的效果。在持牌人的回合结束时，场上所有造物获得1点生命值。
            AddTranslation("Pay 2 Bones to reverse this sigil effect. At the end of the owner's turn, all creatures on the board gain 1 health.", "支付2根骨头，逆转该印记的效果。在持牌人的回合结束时，场上所有造物获得1点生命值。");
            // 生命汲取
            AddTranslation("LifeDraw", "生命汲取");
            // 支付1点血量，从你的主牌堆抽一张牌。
            AddTranslation("Pay 1 Blood to draw a card from your main deck.", "支付1点血量，从你的主牌堆抽一张牌。");
            // 魂域之门
            AddTranslation("Soulgate", "魂域门");
            // 支付1根骨头，获得1点能量；在持牌人回合结束时，失去等量的最大能量。
            AddTranslation("Pay 1 Bone to gain 1 Energy, lose as much Max Energy at the end of the owner's turn.", "支付1根骨头，获得1点能量；在持牌人回合结束时，失去等量的最大能量。");
            // 唤灵术
            AddTranslation("Evocation", "唤灵术");
            // 支付3点能量，从坟墓中将最早进入且不带脆骨印记的友方造物移回你的手牌。
            AddTranslation("Pay 3 Energy to return the oldest non-Brittle allied creature from the graveyard to your hand.", "支付3点能量，从坟墓中将最早进入且不带脆骨印记的友方造物移回你的手牌。");
            // 休眠
            AddTranslation("Dormant", "休眠");
            // 支付与[creature]力量值等量的骨头，可使该印记失效1回合；[creature]本回合无法进行常规攻击。
            AddTranslation("Pay Bones equal to the Power of [creature] to disable this sigil for 1 turn. [creature] cannot attack normally.", "支付与[creature]力量值等量的骨头，可使该印记失效1回合；[creature]本回合无法进行常规攻击。");
            // 炼变
            AddTranslation("Transmute", "炼变");
            // 支付2根骨头，将[creature]转化为另一种形态。
            AddTranslation("Pay 2 Bones to transform [creature] to its alternate form.", "支付2根骨头，将[creature]转化为另一种形态。");
            // 保护者
            AddTranslation("Protector", "佑");
            // 与[creature]相邻的造物获得1点最大生命值。
            AddTranslation("Creatures adjacent to [creature] gain 1 max health.", "与[creature]相邻的造物获得1点最大生命值。");
            // 灾厄溢流
            AddTranslation("CalamityEffusion", "灾厄溢流");
            // 持牌人的回合结束时，场上所有造物失去1点生命值。
            AddTranslation("At the end of the owner's turn, all creatures on the board lose 1 health.", "持牌人的回合结束时，场上所有造物失去1点生命值。");
            // 慰藉光环
            AddTranslation("ComfortAura", "慰藉光环");
            // 持牌人的回合结束时，与[creature]相邻的所有造物恢复1点生命值。
            AddTranslation("At the end of the owner's turn, creatures adjacent to [creature] heal 1 health.", "持牌人的回合结束时，与[creature]相邻的所有造物恢复1点生命值。");
            // 尸魂盛宴
            AddTranslation("CorpseParty", "尸魂盛宴");
            // 当持牌人一侧不带脆骨印记的造物因战斗阵亡时，一张丧尸会加入你的手牌。丧尸被定义为：1点力量，1点生命。
            AddTranslation("When a non-brittle creature on the owner's side perishes by combat, a Zombie enters your hand. A Zombie is defined as: 1 Power, 1 Health.", "当持牌人一侧不带脆骨印记的造物因战斗阵亡时，一张丧尸会加入你的手牌。丧尸被定义为：1点力量，1点生命。");
            // 亡者叩门
            AddTranslation("DeathKnock", "亡者叩门");
            // 当[creature]因战斗而阵亡时，会发起反击，随后再阵亡。
            AddTranslation("When [creature] perishes by combat, it strikes back then perishes.", "当[creature]因战斗而阵亡时，会发起反击，随后再阵亡。");
            // 死金轰鸣
            AddTranslation("DeathMetal", "死金轰鸣");
            // 当[creature]被打出时，其相邻以及位于其左、右、正前方的敌对造物均受到1点伤害。每有一个受影响的造物，[creature]便获得1点力量。
            AddTranslation("When [creature] is played, adjacent creatures and opposing creatures to the left, right, and center of it take 1 damage. It gains 1 Power for each affected creature.", "当[creature]被打出时，其相邻以及位于其左、右、正前方的敌对造物均受到1点伤害。每有一个受影响的造物，[creature]便获得1点力量。");
            // 污染者
            AddTranslation("Defiler", "污者");
            // 当[creature]阵亡时，你抽一张牌，随后从你的手牌中选择一张弃置。
            AddTranslation("When [creature] perishes, draw a card then choose one to discard from your hand.", "当[creature]阵亡时，你抽一张牌，随后从你的手牌中选择一张弃置。");
            // 侵噬
            AddTranslation("Encroachment", "侵噬");
            // [creature]在场2回合后，会在你的手牌中生成一张它的复制体。
            AddTranslation("[creature] creates a copy of it in your hand after 2 turns on the board.", "[creature]在场2回合后，会在你的手牌中生成一张它的复制体。");
            // 炼骨塑骸
            AddTranslation("Skeletonize", "炼骨塑骸");
            // 当[creature]阵亡时，一张带有其原有印记的骷髅会加入你的手牌。骷髅被定义为：1点力量，1点生命，脆骨。
            AddTranslation("When [creature] perishes, a Skeleton with its old sigils enters your hand. A Skeleton is defined as: 1 Power, 1 Health, Brittle.", "当[creature]阵亡时，一张带有其原有印记的骷髅会加入你的手牌。骷髅被定义为：1点力量，1点生命，脆骨。");
            // 镇魂涤秽
            AddTranslation("Exorcise", "镇魂涤秽");
            // 当[creature]被打出时，玩家会获得等同于敌方造物骨头费用的骨头数量。
            AddTranslation("When [creature] is played, Bones equal to the Bone cost of the opposing creature are granted to the player.", "当[creature]被打出时，玩家会获得等同于敌方造物骨头费用的骨头数量。");
            // 尸爆
            AddTranslation("ExplodingCorpse", "尸爆");
            // 当[creature]因战斗阵亡时，场上所有空位都会被一张内脏牌填满。
            AddTranslation("When [creature] perishes by combat, all empty spaces on the board are filled with a Guts card.", "当[creature]因战斗阵亡时，场上所有空位都会被一张内脏牌填满。");
            // 积怨者
            AddTranslation("GrudgeCollector", "积怨者");
            // 每有2次敌方造物对持牌人造成直接伤害时，[creature]便获得1点力量。
            AddTranslation("[creature] gains 1 power for every 2 times opponent creatures deal direct damage to its owner.", "每有2次敌方造物对持牌人造成直接伤害时，[creature]便获得1点力量。");
            // 铃铛力量
            AddTranslation("Chime Power", "铃铛力量");
            // 此印记所代表的数值，等同于场上铃铛牌的数量。
            AddTranslation("The value represented by this sigil will be equal to the number of Bell cards on the board.", "此印记所代表的数值，等同于场上铃铛牌的数量。");
            // 掘骨力量
            AddTranslation("Bone Digger Power", "掘骨力量");
            // 此印记所代表的数值，等同于场上所有骨系及掘骨相关印记的数量。
            AddTranslation("The value represented by this sigil will be equal to the number of Bone and Digger related sigils on the board.", "此印记所代表的数值，等同于场上所有骨系及掘骨相关印记的数量。");
            // 点燃
            AddTranslation("Ignition", "燃");
            // 该造物在场上每经过一个回合，便以损失1点生命值为代价，获得1点力量。
            AddTranslation("[creature] gains 1 power at the cost of 1 health after each turn on the board.", "该造物在场上每经过一个回合，便以损失1点生命值为代价，获得1点力量。");
            // 掘骨传花
            AddTranslation("Digger Latch", "掘骨传花");
            // 持牌人回合结束时，[creature]会生成1根骨头。当它阵亡时，持牌人可选择一名造物，使其获得掘骨印记。
            AddTranslation("At the end of the owner's turn, [creature] will generate 1 Bone. When it perishes, its owner chooses a creature to gain the Bone Digger sigil.", "持牌人回合结束时，[creature]会生成1根骨头。当它阵亡时，持牌人可选择一名造物，使其获得掘骨印记。");
            // 强化掘骨传花
            AddTranslation("Primed Digger Latch", "强化掘骨传花");
            // 持牌人回合结束时，[creature]会生成1根骨头。当它阵亡时，持牌人可选择一名造物，使其获得此印记。
            AddTranslation("At the end of the owner's turn, [creature] will generate 1 Bone. When it perishes, its owner chooses a creature to gain this sigil.", "持牌人回合结束时，[creature]会生成1根骨头。当它阵亡时，持牌人可选择一名造物，使其获得此印记。");
            // 焕生
            AddTranslation("Rejuvenation", "焕生");
            // 当[creature]阵亡时，持牌人可选择一名造物，使其获得幼雏印记。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Fledgling sigil.", "当[creature]阵亡时，持牌人可选择一名造物，使其获得幼雏印记。");
            // 头骨风暴
            AddTranslation("Skull Storm", "头骨风暴");
            // 持牌人回合结束时，此印记会随机替换为另一印记。它阵亡后，持牌人可选择一名造物，使其获得此印记。
            AddTranslation("At the end of the owner's turn, this sigil is replaced with another sigil at random. When it perishes, its owner chooses a creature to gain this sigil.", "持牌人回合结束时，此印记会随机替换为另一印记。它阵亡后，持牌人可选择一名造物，使其获得此印记。");
            // 引火
            AddTranslation("Ignite", "引焰");
            // 当[creature]阵亡时，持牌人可选择一名造物，使其获得点燃印记。
            AddTranslation("When [creature] perishes, its owner chooses a creature to gain the Ignition sigil.", "当[creature]阵亡时，持牌人可选择一名造物，使其获得点燃印记。");
            // 骸脉惊魂
            AddTranslation("MacabreBonePulse", "骸脉惊魂");
            // [creature]被打出后会立即阵亡，掉落的骨头数量等于持牌人方场上造物数量的两倍。
            AddTranslation("When [creature] is played, it perishes immediately, dropping Bones equal to double the amount of creatures on the owner's side.", "[creature]被打出后会立即阵亡，掉落的骨头数量等于持牌人方场上造物数量的两倍。");
            // 孕育
            AddTranslation("Maternal", "孕育");
            // 与[creature]相邻的造物将获得水袭印记。
            AddTranslation("Creatures adjacent to [creature] are inscrybed by Waterborne.", "与[creature]相邻的造物将获得水袭印记。");
            // 腐溃
            AddTranslation("Necrosis", "腐溃");
            // [creature]在场上每经过一个回合，便损失1点力量与1点最大生命。
            AddTranslation("[creature] loses 1 power and 1 max health after each turn on the board.", "[creature]在场上每经过一个回合，便损失1点力量与1点最大生命。");
            // 地狱边境
            AddTranslation("Limbo", "地狱边境");
            // 当[creature]阵亡后，将回归至你的牌组顶端。
            AddTranslation("When [creature] perishes, it returns to the top of your deck.", "当[creature]阵亡后，将回归至你的牌组顶端。");
            // 厉魂不灭
            AddTranslation("RelentlessRevenant", "厉魂不灭");
            // 持牌人的回合开始时，与[creature]相邻的造物将变形为复生亡灵。复生亡灵被定义为：3点力量，1点生命，脆骨。
            AddTranslation("At the start of the owner's turn, creatures adjacent to [creature] transform into a Revenant. A Revenant is defined as: 3 Power, 1 Health, Brittle.", "持牌人的回合开始时，与[creature]相邻的造物将变形为复生亡灵。复生亡灵被定义为：3点力量，1点生命，脆骨。");
            // 复生归魂
            AddTranslation("Revedue", "复生归魂");
            // 攻击结束后，[creature]将阵亡，随后将2个携带其原有印记的复生亡灵洗入你的副牌组。复生亡灵被定义为：3点力量，1点生命，脆骨。
            AddTranslation("After attacking, [creature] perishes, then shuffle 2 Revenants with its old sigils into your side deck. A Revenant is defined as: 3 Power, 1 Health, Brittle.", "攻毕，[creature]即死，复洗二负其旧印之复生亡灵入汝副列。复生亡灵者：三威，一命，脆骨。");
            // 不祥之兆
            AddTranslation("Bad Omen", "凶征");
            // 持牌人的回合结束时，[creature]将对持牌人造成1点伤害。
            AddTranslation("At the end of the owner's turn, [creature] will deal 1 damage to the owner.", "持者合终，[creature]伤其主一。");
            // 怨煞
            AddTranslation("Rancor", "怨煞");
            // 当[creature]阵亡时，会在其原占据的格子上留下一层永久的1点力量加成。
            AddTranslation("When [creature] perishes, it leaves a permanent 1 power buff in the space it occupied.", "[creature]死，则其所据之位留一永威。");
            // 宁谧芳原
            AddTranslation("SoothingMeadows", "宁原");
            // 持牌人回合结束时，场上所有造物获得1点生命值。
            AddTranslation("At the end of the owner's turn, all creatures on the board gain 1 health.", "持者合终，局上诸物皆得一命。");
            // 临终之笔
            AddTranslation("PartingStroke", "诀笔");
            // 当持牌人方的非脆骨造物因战斗阵亡时，持牌人可选择一个造物，使其失去所有印记。
            AddTranslation("When a non-brittle creature on the owner's side perishes by combat, its owner chooses a creature to lose all of its sigils.", "主持侧非脆骨之物若战死，则其主持择一物，使尽失其印契。");
            // 分尸
            AddTranslation("SplittingCorpse", "裂尸");
            // 当[creature]因战斗阵亡时，将在其所有相邻的空格上生成一个畸变体。
            AddTranslation("When [creature] perishes by combat, create a Dysmorphia on each empty adjacent space.", "[creature]若战死，则其邻诸空位各生一畸变体。");
            // 迟钝
            AddTranslation("Torpid", "钝");
            // [creature]无法进行常规攻击。
            AddTranslation("[creature] cannot attack normally.", "[creature]不能常攻。");
            // 幽冥墓志
            AddTranslation("Grim Epitaph", "冥志");
            // 打出[creature]时，你可选择一张已进入休眠状态的卡牌，将其收回手牌。
            AddTranslation("When [creature] is played, you may choose a card that has already been put to rest, to bring back to your hand.", "[creature]既陈，汝可择一已安息之牌，反之于手。");
            // 巨足
            AddTranslation("Bigfoot", "巨足");
            // 一种潜藏于森林之中的神秘造物，仅有少数人声称曾目睹过它的踪迹。
            AddTranslation("a mysterious creature lurking the forests, only few have claimed to see one.", "一潜于林中之秘物也，称尝见之者寡矣。");
            // 哥布林
            AddTranslation("Goblin", "哥布林");
            // 一头忠心耿耿的蛮荒凶兽，能成为你军团中得力的一员。
            AddTranslation("A loyal barbaric beast, a fine addition to your army.", "一忠而野之兽也，可为汝军良益。");
            // 薇拉
            AddTranslation("Vila", "薇拉");
            // 一见倾心——至少，它想让你这么认为。
            AddTranslation("Love at first sight, at least that's what it wants you to think.", "一见而倾心，至少其欲使汝然思。");
            // 赤肤蛙魔
            AddTranslation("Yaramayawho", "赤肤蛙魔");
            // 它似乎永远也没法吃完自己的猎物……
            AddTranslation("This one can never seem to finish it's meals...", "此物似终不能尽其食……");
            // 试验肢体
            AddTranslation("Test Limbs", "试肢");
            // 这些部件曾经属于某个人，而如今，属于某个…… 东西……(测试)
            AddTranslation("Those parts used to belong to someone, or now some thing...(Test)", "此诸肢尝属于一人，而今属于某……物……（试）");
            // 哀灵狂魂
            AddTranslation("Allip", "狂魂");
            // 疯子残存的魂灵！你永远无从知晓那张面容背后藏着怎样的故事，但它注定满是执念。
            AddTranslation("The remnants of the insane! You never know what story lies behind that face, but it's sure to be filled with fervor.", "狂者之馀魂也！彼面之后所藏何事，汝终无由知；然必满执念。");
            // 奄美兔
            AddTranslation("Amami Rabbit", "奄美兔");
            // 将幼崽藏于洞穴之中，只求护它们周全。
            AddTranslation("Hiding their young in holes, they wish for their best safety.", "匿其幼于穴，惟愿其安。");
            // 安卡咒物
            AddTranslation("Ankhame", "安卡咒物");
            // 一件会被你的鲜血所吸引的遗物，或许你可以挥砍它试试！
            AddTranslation("A relic that is drawn to your blood, perhaps you could give it a swing!", "一为汝血所招之遗物也，或可挥之试之！");
            // 安妮塔
            AddTranslation("Anneta", "安妮塔");
            // 墨汁不住地奔涌流淌，她的身影是否还在那里？死亡所能给予的全部承诺，不过是让你再次醒来。
            AddTranslation("That ink keeps on pouring, is she even there anymore? All that death promises is that you will wake up again.", "其墨奔流不已，彼身尚在其间乎？死之所许，惟使汝复醒耳。");
            // 厌食魔
            AddTranslation("Anorexia", "厌食魔");
            // 让你被自我厌恶的情绪所淹没，你永远无从知晓它下一刻会化作何种形态。
            AddTranslation("Overflowing you with self loathing, you never know what form it may take on next.", "使汝自恶溢怀，彼次将为何形，终不可知。");
            // 巫妖之铃
            AddTranslation("Lych Bell", "巫妖铃");
            // 看来，他们寻得了一种使用铃铛的新法子。
            AddTranslation("It seems like they found a new way to use bells.", "观彼似得用铃之一新术。");
            // 胀尸
            AddTranslation("TheBloated", "胀尸");
            // 狰狞的脓疮，正蓄势待发，一触即溃。
            AddTranslation("Grotesque boils, ready to burst.", "恶疮狞然，将裂矣。");
            // 畸脑罐头
            AddTranslation("BrainJar", "脑罂");
            // 光是想象那罐子里藏着何等非人的念头，便足以令人战栗……
            AddTranslation("One shudders to imagine what inhuman thoughts lie inside that jar...", "念彼罂中所藏何等非人之思，足令人栗……");
            // 爆燃尸壳
            AddTranslation("Combustor", "燃尸");
            // 天呐，曾几何时那般炙手可热的尊荣竟一落千丈，如今只剩下一具金属残骸，以及那最后一丝尚存的警戒之物……
            AddTranslation("Oh dear, what a fall from such a stimulatingly high status, now all that's left is a metal carcass, and the last of that watchful substance...", "呜呼，盛时何其炽也，今遽坠若此，仅馀金属之骸，与彼最后一点警觉之质……");
            // 糜烂白鼬
            AddTranslation("Misplayed Stoat", "败白鼬");
            // 一只腐坏的白鼬，它那套曾被奉若圭臬的完美策略，终究让它一败涂地。
            AddTranslation("A decaying Stoat whose oh-so perfect strategies failed him tremendously.", "一腐白鼬也，其所谓完策终使之大败。");
            // 畸变体
            AddTranslation("Dysmorphia", "畸变体");
            // 左侧畸变体。
            AddTranslation("Dysmorphia Left.", "左畸变体。");
            // 右侧畸变体。
            AddTranslation("Dysmorphia Right.", "右畸变体。");
            // 驱魔道人
            AddTranslation("Exorcist", "祓者");
            // 他仍以为驱逐那些受诅之物便能为自己带来裨益，可他当真知晓自己身处于何方吗？
            AddTranslation("He still thinks banishing the dammed will do him good, does he know where he is?", "彼犹谓逐去受诅者足自利，然其果知身今何所乎？");
            // 脓骨鬼
            AddTranslation("Flembones", "脓骨鬼");
            // 等他摆弄好他的摄像头再说。
            AddTranslation("Wait until he plays with his webcam.", "姑待彼戏其影机。");
            // 斯坦和弗兰肯
            AddTranslation("Stein & Frank", "斯坦与弗兰肯");
            // 即便是地狱业火，也未能将二人分离开来。
            AddTranslation("Even hell was not hot enough to split them.", "虽狱火之炽，亦不足析之。");
            // 惊雷颅骨
            AddTranslation("FulmineSkull", "雷颅");
            // 凝神细听，你仍能听见烈焰灼烧骸骨的噼啪声响……以及他们残存的低语。
            AddTranslation("If you listen closely, you can still hear the cackling of flame on bone... as well as their voice.", "凝听之，犹可闻炎炙骨之噼啪……并其馀语。");
            // 轰雷殖骨
            AddTranslation("FulurOssa", "雷殖骨");
            // 它从未真正离开过那张电椅。
            AddTranslation("It never truly left the electric chair.", "彼未尝真离电椅。");
            // 普罗米修斯之火
            AddTranslation("PrometheusFlame", "普罗米修斯火");
            // 此物着实独一无二，乃是那造福人类的窃贼所遗留的馈赠！话说回来，要来份精致的肝脏尝尝吗？
            AddTranslation("This one is quite unique, the lingering spoils of a thief to benefit humanity! Fancy liver by chance?", "此物诚异，乃惠人之盗所遗馀赐也！汝欲尝肝乎？");
            // 内脏
            AddTranslation("Guts", "腑");
            // 烦人的内脏。
            AddTranslation("Annoying guts.", "烦腑也。");
            // 先驱者
            AddTranslation("Harbinger", "先驱");
            // 一头强大的魔物，其效命的代价高昂至极。
            AddTranslation("A powerful fiend that extols a heavy price for its servitude.", "一强魔也，其役之价甚重。");
            // 哈斯塔
            AddTranslation("Hastur", "哈斯塔");
            // 祂自群星之外而来，将自身倒影的碎片，同等赠予君王与愚人。你，会收下这片碎片吗？
            AddTranslation("He came from beyond the stars, gifting pieces of his reflection to kings and fools alike. Will you accept this piece?", "彼自群星之外来，以己影之片同赐君与愚。汝其受此片乎？");
            // 寻常魔仆
            AddTranslation("Common Imp", "常魔仆");
            // 一种小小魔物，所到之处必生事端与混乱，脸上挂着狡黠的坏笑，性子顽劣至极！
            AddTranslation("A tiny creature known for causing trouble and mayhem wherever it goes, with its mischievous grin and playful nature!", "一小魔也，所往必生乱，其笑狡黠，而性顽甚。");
            // 八岐残魂
            AddTranslation("Orochimitama", "八岐残魂");
            // 哦……它本不该出现在此地的……
            AddTranslation("Oh... He is not supposed to be here...", "噫……彼本不当在此……");
            // 生之息
            AddTranslation("Inochi", "生息");
            // 一股抚慰心神的力量，治愈你的造物，亦是风暴降临前的片刻宁静。
            AddTranslation("A soothing presence to heal your creatures, a calm before the storm.", "一和抚之气也，疗汝诸物，亦风暴前之暂宁。");
            // 折磨之径。
            AddTranslation("Trail of Torment.", "苦径。");
            // 异肢
            AddTranslation("Possessed Limbs", "祟肢");
            // 一旦附着于活人身上，它们便彻底归于另一个存在所有。
            AddTranslation("Once attached to a living person, they now belong to something else entirely.", "既附生人，则尽归他物矣。");
            // 鼹鼠掘墓人
            AddTranslation("Mole Digger", "鼹掘者");
            // 坚定的鼹鼠……掘墓人？不用管这是什么……
            AddTranslation("The stalwart Mole... Digger? Whatever this is...", "坚鼹……掘者乎？姑无问此为何也……");
            // 御魂主宰
            AddTranslation("Nekros", "御魂主宰");
            // 御魂主宰执掌战场，挑战者。死亡即是他的猎场。
            AddTranslation("Nekros possesses the board, challenger. Death is his playground.", "御魂主宰据此局矣，角者。死即其戏场。");
            // 圣装御魂主宰
            AddTranslation("NekrosPrime", "圣装御魂主宰");
            // 你再也寻不到……比这更磅礴的力量……莫过于念及自身名姓……被镌刻在墓碑之上的瞬间。
            AddTranslation("You will find no greater power... than the simple thought of your own name... inscrybed upon a grave.", "汝将无复见大于此之力……惟念己名……铭于墓石之上耳。");
            // 诺克那维
            AddTranslation("Nuckelavee", "诺克那维");
            // 它乃深海之主，你最好祈祷它的气息，不会玷污你的仆从！
            AddTranslation("The Administrator of its sea, you better hope it's breath doesn't taint your Thralls!", "彼其海之主也，汝宜祷其息不污汝役！");
            // 秽邪巨体
            AddTranslation("OdiousMass", "秽巨体");
            // 何其丑陋。
            AddTranslation("How unsightly.", "何陋之甚。");
            // 八岐大蛇
            AddTranslation("Orochi", "八岐蛇");
            // 必须做出牺牲。
            AddTranslation("Sacrifices must be made.", "汝必须行牺牲。");
            // 欧罗大师
            AddTranslation("Master Ouro", "欧罗大师");
            // 在无尽的折磨与痛苦之中，它们竟摸索出了一条途径，得以窥见这可怜残躯的内里……并将其痛苦尽数抹去。
            AddTranslation("From within the endless torment and suffering, they had somehow learned a way to see inside this poor broken thing... and take away its pain.", "处无尽之苦与痛中，彼竟得一术，以窥此可怜残体之内……而尽夺其痛。");
            // 生死轮回无休无止，早已摧残了这些遭人遗弃的残躯。痛苦真实不虚，但死亡并不是终结！
            AddTranslation("An endless cycle of life and death has taken a toll on these discarded remains. The pain was real, but death is never final!", "生死之环无穷，已尽残此诸弃骸。其痛诚真，然死终非竟也！");
            // 杜拉尔罕
            AddTranslation("GanCeann", "杜拉尔罕");
            // 无数传说都提及杜拉尔罕，却无一则能道尽它暴怒的真正程度。
            AddTranslation("Countless legends tell of the dullahan, but all fail to convey the true extent of its pique.", "诸传多言杜拉尔罕，然莫能尽道其怒之实。");
            // 暗黑王子
            AddTranslation("Dark Prince", "暗王子");
            // 你体内正闪耀着毛茸茸小家伙们的力量。
            AddTranslation("The power of fluffy bois shines within you.", "绒毛诸子之力，方辉于汝中。");
            // 夭折鸦灵
            AddTranslation("Stillborn Raven", "夭鸦灵");
            // 再回年少，快意畅快！
            AddTranslation("Feels good to be young again!", "复少诚快！");
            // 回魂者
            AddTranslation("Reanimated", "回魂者");
            // 手持死亡镰刀的复生亡灵，只为……等等，这是什么？
            AddTranslation("BRINGING THE SCYTHE OF DEATH, THE REVENANT... WAIT, WHAT?", "携死镰而来的复生亡灵……且，何物？");
            // 复生异灵
            AddTranslation("RevenantEldritch", "复生异灵");
            // 灾祸之源，冷酷无情，精准无匹。
            AddTranslation("The source of Calamity, relentless and unerring.", "灾之源也，不舍而不谬。");
            // 懒骨
            AddTranslation("Lazy Bones", "懒骨");
            // 一具慵懒又爱讲冷笑话的骷髅，可太喜欢他了。
            AddTranslation("A slothful skeleton with a knack for jokes. I adore him.", "一惰而善谐之骨也，吾甚爱之。");
            // 骸音机
            AddTranslation("Skelephone", "骨音器");
            // 与死者沟通之法，不过代价不菲。
            AddTranslation("A way to communicate with the dead, for a price.", "通死者之一术也，然其价不轻。");
            // 魂域之门
            AddTranslation("Soulgate", "魂域门");
            // 踏入魂域的机缘，何其美妙？但愿你付得起相应的代价。
            AddTranslation("A chance to enter the soul realm, how delightful? I hope you can afford the price.", "入魂域之机，何其美乎？愿汝办得其价。");
            // 黑桃战士
            AddTranslation("SpadeWarrior", "黑桃武者");
            // 这威名赫赫的战士定会将你送入黄泉，从里到外，无一幸免。
            AddTranslation("This fearsome warrior will put you six feet under, in every possible sense.", "此武者可畏，必使汝入冢，凡所可言之义皆然。");
            // 不死民灵
            AddTranslation("UndeadCivilian", "不死民灵");
            // 困于永恒黑暗之中，这缕可怜的亡魂正苦苦寻觅出路。或许，你能为他点亮一盏明灯？
            AddTranslation("Lost in eternal darkness, this poor soul desperately seeks a way out. Perhaps you can light his way?", "陷永闇中，此可怜魂苦觅其路。汝其能为之燃一灯乎？");
            // 葬灵村
            AddTranslation("UndeadVillage", "葬灵村");
            // 荒弃凄凉，这座村落正盼着新住民，来填满它破败的屋舍。
            AddTranslation("Abandoned and forlorn, this village seeks new residents to fill its decrepit homes.", "既荒且凉，此村求新居者，以充其败屋。");
            // 每一座城镇，每一方都市，总有人要负责埋葬逝者。而终有一日，他们也会被葬入黄土。
            AddTranslation("In every town, in every city, someone must work to bury the dead. In time, they too will be buried.", "凡邑与都，必有人埋死者。及其时也，彼亦将见埋。");
            // 骸骨博士
            AddTranslation("Dr.Bones", "骨博士");
            // 杀不死你的东西，只会让你变得更清醒。
            AddTranslation("Whatever doesn't kill you simply makes you, saner.", "凡不能杀汝者，徒使汝更醒耳。");
            // 温迪戈
            AddTranslation("Wendigo", "温迪戈");
            // 自荒莽野地归来，倒让我想起一位故人。
            AddTranslation("Returned from the deep wilds, reminds me of a friend.", "自荒野深处归，使我忆一故人。");
            // 赢先生
            AddTranslation("Mister Win", "赢先生");
            // 一张致胜的牌。它永远立于不败之地。这便是它得名赢先生的缘由。
            AddTranslation("A card that wins. It always wins. That's why it's called Mister Win.", "一能胜之牌也。彼恒胜，故曰赢先生。");
            // 恐怕，并非那一张。
            AddTranslation("Not that one, I'm afraid.", "恐非此张。");
            // 你……你这个杀人如麻的怪物。
            AddTranslation("You... you murderous monster.", "汝……汝此嗜杀之怪。");
            // 哦，天哪……灾祸的洪流必将追赶你。
            AddTranslation("Oh Dear... The flow of Calamity will pursue you.", "噫……灾流必逐汝。");
            // 夷平你曾居住的村子。
            AddTranslation("Hecatomb the village you once lived.", "夷汝昔所居之村。");
            // 寻找那把能一直挖下去的铲子。
            AddTranslation("Seak for the shovel that digs forever.", "求其永掘之锸。");
            // 然后把那个手里拿着火花的失踪者带给我。
            AddTranslation("Bring me the lost one with a spark in hand.", "执火星之失者，携以来我。");
            // 经由古老存在的召唤，
            AddTranslation("Compelled by the beckoning of an ancient entity,", "为古物所招，");
            // 一场禁忌的仪式已经开始。
            AddTranslation("a forbidden ritual has been initiated.", "禁仪既作矣。");
            // 痛苦传到了古老的死亡巨蛇耳中。
            AddTranslation("The pain reaches the ancient great serpent of death.", "其痛达于上古死巨蛇。");
            // 你必须做出牺牲。
            AddTranslation("Sacrifices must be made.", "汝必须行牺牲。");
            // 哦……目前还没有死亡卡。
            AddTranslation("Oh... There are no dead cards yet.", "噫……今尚无死牌。");
            // 复生亡灵模组卡包
            AddTranslation("Revenant Mod Card Pack", "复生亡灵补缀牌韬");
            // 这套卡牌主要由一些能以各种方式返回玩家手中的卡牌组成。
            AddTranslation("This card pack consists of mainly cards that return to the player in a variety of ways.", "此牌韬多由能以诸途反归戏徒手中之牌成。");
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
