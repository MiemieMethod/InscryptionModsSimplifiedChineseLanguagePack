using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch112
    {
        public static void RegisterTranslations()
        {
            RegisterRevenantOne();
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

        private static void RegisterRevenantOne()
        {
            // 攻击结束后，将阵亡，随后将2个携带其原有印记的复生亡灵洗入你的副牌组。复生亡灵被定义为：3点力量，1点生命，脆骨。
            AddTranslation("After attacking, [creature] perishes, then shuffle 2 Revenants with its old sigils into your side deck. A Revenant is defined as: 3 Power, 1 Health, Brittle.", "攻毕，[creature]即死，复洗二负其旧印之复生亡灵入汝副列。复生亡灵者：三威，一命，脆骨。");
            // 不祥之兆
            AddTranslation("Bad Omen", "凶征");
            // 持牌人的回合结束时，将对持牌人造成1点伤害。
            AddTranslation("At the end of the owner's turn, [creature] will deal 1 damage to the owner.", "持者合终，[creature]伤其主一。");
            // 怨煞
            AddTranslation("Rancor", "怨煞");
            // 阵亡时，会在其原占据的格子上留下一层永久的1点力量加成。
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
            // 当因战斗阵亡时，将在其所有相邻的空格上生成一个畸变体。
            AddTranslation("When [creature] perishes by combat, create a Dysmorphia on each empty adjacent space.", "[creature]若战死，则其邻诸空位各生一畸变体。");
            // 迟钝
            AddTranslation("Torpid", "钝");
            // 无法进行常规攻击。
            AddTranslation("[creature] cannot attack normally.", "[creature]不能常攻。");
            // 幽冥墓志
            AddTranslation("Grim Epitaph", "冥志");
            // 打出时，你可选择一张已进入休眠状态的卡牌，将其收回手牌。
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
            // 这些部件曾经属于某个人，而如今，属于某个……东西……(测试)
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
        }
    }
}
