using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch128
    {
        public static void RegisterTranslations()
        {
            RegisterFiveNightsTwo();
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

        private static void RegisterFiveNightsTwo()
        {
            // 幽影魔躯
            AddTranslation("Ghastly Body", "鬼躯");
            // 回合开始时，将失去1点生命值。
            AddTranslation("Start Of Turn: [creature] will loose 1 Health.", "合始，[creature]失一命。");
            // 残破躯壳
            AddTranslation("Damaged", "残壳");
            // 受到攻击时，对攻击者造成等额伤害。
            AddTranslation("When struck, [creature] will damage the striker with equal damage.", "见击，[creature]以等伤反之。");
            // 内骨骼 01
            AddTranslation("Endo 01", "内骼01");
            // 一具无外皮的骨架。一具无用且脆弱不堪的躯壳。
            AddTranslation("A suitless skeleton. A useless, easily broken husk.", "无衣之骨架。无用而易碎之壳。");
            // 内骨骼 02
            AddTranslation("Endo 02", "内骼02");
            // 一具无外皮的骨架。一具更为可靠的躯壳。
            AddTranslation("A suitless skeleton. A more reliable husk.", "无衣之骨架。较可信之壳。");
            // 内骨军团
            AddTranslation("Endo Army", "内骼军");
            // 当放置时，其将在己方所有空位生成自身的复制体。
            AddTranslation("On Play: [creature] will create multiples of itself in every free slot on [creature]'s side.", "[creature]既陈，于己侧诸空位皆生其类。");
            // 虚无残响
            AddTranslation("No Remnant", "无馀响");
            // 死亡时，其不会掉落任何残响。
            AddTranslation("On Death: [creature] will not give any Remnant.", "[creature]既死，不遗馀响。");
            // 残响转换器
            AddTranslation("Remnant Converter", "馀响易器");
            // 将2点能量转化为1点残响。
            AddTranslation("[creature] will convert 2 Energy into 1 Remnant.", "[creature]以二能易一馀响。");
            // 恩纳德
            AddTranslation("Ennard", "恩纳德");
            // 缝合一体，融为独一存在……这话听着甚是耳熟。
            AddTranslation("Stitched together to make one being...that sounds familiar.", "缝合为一……此语甚熟。");
            // 合众聚合
            AddTranslation("Union", "合众");
            // 其他卡牌死亡时，获得1点生命值。
            AddTranslation("On other Cards Death: [creature] will gain 1 Health.", "他牌死时，[creature]得一命。");
            // 腐兔
            AddTranslation("Malhare", "腐兔");
            // 我总会归来！
            AddTranslation("I always come back!", "我恒归来！");
            // 狐媚之钩
            AddTranslation("Foxys Hook", "霍斯之钩");
            // 会持续移动直至碰到障碍物，沿途攻击每一个敌方格子。
            AddTranslation("[creature] will move until it reaches something, attacking every opposing slot on its way.", "[creature]徙行至有所触，途所对诸位皆攻之。");
            // 海盗霍斯
            AddTranslation("Foxy the Pirate", "海盗霍斯");
            // 一处旁支景点，拥有迅猛的冲刺与极具杀伤力的铁钩。
            AddTranslation("A side attraction, with a fast sprint and a rather deadly hook.", "旁出之一景也，冲疾而钩甚杀。");
            // 小弗莱迪
            AddTranslation("Freddle", "小弗莱迪");
            // 恐惧的造物。一张张尖利牙齿的小巧面容，在黑暗中朝你咧嘴狞笑。
            AddTranslation("A creation of fear. Tiny sharp-toothed faces grin up at you from the dark.", "恐所生之物。细小利齿之面，自暗中向汝狞笑。");
            // 迷你弗莱迪群
            AddTranslation("Freddles", "小弗莱迪群");
            // 放置时，召唤3只迷你弗莱迪，并将其洗入你的己方牌组。
            AddTranslation("On Play: [creature] will spawn 3 Freddles and shuffles them into your side deck.", "[creature]既陈，生三小弗莱迪，并洗入汝副牌列。");
            // 弗莱迪・费斯贝尔
            AddTranslation("Freddy Fazbear", "弗莱迪・费斯贝尔");
            // 费斯贝尔乐队的冠名主角与领袖。独一无二的弗莱迪・费斯贝尔！
            AddTranslation("The namesake and leader of the Fazbear Band. The one, the only, Freddy Fazbear!", "费斯贝尔乐队之名主与领。独一之弗莱迪・费斯贝尔！");
            // 弗莱迪头套
            AddTranslation("Freddy Mask", "弗莱迪面");
            // 降低所有卡牌1点攻击力，无法对部分电子玩偶生效。
            AddTranslation("Reduces all Cards Attack by 1, cannot be used on some Animatronics.", "降诸牌威一，然数玩偶不可用。");
            // 唔……这头套，能够阻拦部分电子玩偶发起攻击……
            AddTranslation("Hmm... The Mask, it prevents some Animatronics from attacking...", "唔……此面能止数玩偶之攻……");
            // 欢乐时光霍斯
            AddTranslation("Funtime Foxy", "欢时霍斯");
            // 似曾相识的造物。无人能挡其前路。
            AddTranslation("A familiar creation. Nothing can stand in their way.", "熟悉之作。无物能当其前。");
            // 欢乐时光弗莱迪
            AddTranslation("Funtime Freddy", "欢时弗莱迪");
            // 似曾相识的造物。他的搭档邦邦，也会随他一同发起攻击。
            AddTranslation("A familiar creation. His Companion, Bon Bon, also attacks with him.", "熟悉之作。其侣邦邦，亦与之俱攻。");
            // 残响收集者
            AddTranslation("Remnant Collector", "聚馀响者");
            // 放置时，持牌人获得1点残响。
            AddTranslation("On Play: Gain 1 Remnant.", "既陈，得馀响一。");
            // 黄金弗莱迪
            AddTranslation("Golden Freddy", "金弗莱迪");
            // ……我不太看好这家伙的样子。
            AddTranslation("...I don't like the look of this one.", "……我不喜其状。");
            // 手持终端
            AddTranslation("Hand Unit", "手元机");
            // 我看懂了你想要选择的内容，并将为你自动更正。感谢你选择手持终端。
            AddTranslation("I see what you were trying to choose and I will auto correct it for you. Thank you for choosing Hand Unit.", "我见汝所欲择者，且为汝自正之。谢汝择手元机。");
            // 最后遗愿
            AddTranslation("Last Will", "末愿");
            // 消亡时，给予持牌人2点残响。
            AddTranslation("On Death: [creature] will give you 2 Remnant.", "[creature]既亡，予汝馀响二。");
            // 莱夫蒂
            AddTranslation("Lefty", "莱夫蒂");
            // 一个用以收容某种极其棘手之物的容器。
            AddTranslation("A container for something far more troublesome.", "为容更难制之物者。");
            // 洛比特
            AddTranslation("Lolbit", "洛比特");
            // 系统出现技术故障，请稍候。
            AddTranslation("TECHNICAL DIFFICULTIES. PLEASE STAND BY.", "机术有艰，请姑待。");
            // 曼果冲刺
            AddTranslation("Mangle Strafe", "曼果徙");
            // 持牌人的回合结束时，会沿印记方向移动，并留下一堆金属丝线，金属丝线具有：0点力量，1点生命，尖刺铠甲。
            AddTranslation("At the end of the Owners turn a [creature] will move in the Sigil Direction and leave behind a pile of Wire(0/1,Sharp Quills).", "持者合终，[creature]循印所指而徙，遗一堆金属丝于后。金属丝者：零威，一命，利棘。");
            // 模仿者
            AddTranslation("Mimic", "摹者");
            // 迷你瑞娜
            AddTranslation("Minireena", "迷你瑞娜");
            // 熔火弗莱迪
            AddTranslation("Molten Freddy", "熔弗莱迪");
            // 一团肆意抽打周遭所有事物的金属丝线聚合体。
            AddTranslation("A mass of wires lashing out at everything in reach.", "诸线聚为一团，鞭击所及诸物。");
            // 万事通先生
            AddTranslation("Mr Can Do", "万事先生");
            // 一具带着空洞笑容的锈蚀铁桶。它平日里并无异动，可若是为其注入足够能量，便会吐出些有用的东西。这过程透着一股……诡异违和感。
            AddTranslation("A rusted can with a vacant smile. It doesn't do much, but if you feed it enough power, it coughs up something useful. The process seems... unnatural.", "锈桶含空笑。平日无为；若饲以足能，则吐可用之物。其状似甚诡。");
            // 抱抱先生
            AddTranslation("Mr Hugs", "抱抱先生");
            // 一台……吸尘器？它缓缓挪动，行经之处留下一股怪异且久久不散的气息。
            AddTranslation("A... Vaccuum? It shuffles along, leaving a strange, lingering presence in its wake", "一……吸尘器乎？其徐徐而行，身后遗一怪气，久而不散。");
            // 梦魇
            AddTranslation("Nightmare", "梦魇");
            // 恐怖之影。它从你心底深藏的恐惧中汲取力量。
            AddTranslation("A shadow of terror. It draws power from the fears you hold close to yourself.", "恐影也，自汝心所藏之惧取力。");
            // 梦魇邦尼
            AddTranslation("Nightmare Bonnie", "梦魇邦尼");
            // 由恐惧孕育的造物。他静立等候，纹丝不动。纵使闭上双眼，你也深知他就在那里。
            AddTranslation("A creation of fear. He waits in silence, unmoving. You know he's there, even when you close your Eyes.", "恐所生之物。彼默立以待，虽闭目，汝亦知其在彼。");
            // 梦魇奇卡
            AddTranslation("Nightmare Chica", "梦魇奇卡");
            // 由恐惧造就的造物。她那空洞大张的嘴本不该张到这般夸张的程度。她发出的声响既不属于人类，也不属于机械——而是全然异样的存在。
            AddTranslation("A creation of fear. Her gaping, hollow maw shouldn't be able to open that wide. The Noise she makes is neither human nor mechanical -it's something else entirely.", "恐所造之物。其虚颔大张，不当至是。其声非人非机，乃别物也。");
            // 梦魇霍斯
            AddTranslation("Nightmare Foxy", "梦魇霍斯");
            // 由恐惧衍生的造物。他潜伏在视野边缘。你漠视他的时间越久，他便愈发逼近。待到发难之时，便再无反应之机。
            AddTranslation("A creation of fear. He lurks just out of sight. The longer you ignore him, the closer he gets. When he strikes, there won't be time to react.", "恐所生之物。潜于所视之外。汝愈忽之，彼愈逼近。及其发难，无以应之。");
            // 梦魇弗雷德熊
            AddTranslation("Nightmare Fredbear", "梦魇弗雷德熊");
            // 由恐惧催生的恐怖造物。它对铃声有着极致的敏感。
            AddTranslation("A creation of terror. It is incredibly sensitive to the sounds of ringing.", "恐所生之怪，对铃声至敏。");
            // 梦魇弗莱迪
            AddTranslation("Nightmare Freddy", "梦魇弗莱迪");
            // 由恐惧而生的造物。他从不孤身一人。他的小家伙们早已在暗处等候着你。
            AddTranslation("A creation of fear. He is never alone. His little ones are already waiting for you.", "恐所生之物。彼未尝独行，其小者已先待汝。");
            // 头号箱
            AddTranslation("No1 Crate", "头号箱");
            // 放置时，木箱微微震颤。内里之物蠢蠢欲动，将力量赋予身旁一切。若付代价，它能做得更多。
            AddTranslation("The crate shudders when placed. Whatever's inside shifts, lending its strength to whatever stands beside it. For a price, it does even more.", "箱既置则微颤。内物移荡，以其力益旁物。若出直，则所能更多。");
            // 锅头斯坦
            AddTranslation("Pan Stan", "锅斯坦");
            // 金属撞击的声响在它崩解后久久回荡。即便已然碎裂，残片依旧散发着某种异样气息。
            AddTranslation("The sound of clanging metal echoes long after he falls apart. Yet, teh pieces still radiate something.", "金铁之声，虽其崩散后犹久回。然其碎片尚吐异气。");
            // 派对赠品
            AddTranslation("Party Favors", "宴赠");
            // 持牌人的回合结束时，为相邻卡牌回复等同于其攻击力的生命值。
            AddTranslation("On Turn End: [creature] heals cards adjacent to it equal to its Attack.", "持者合终，[creature]疗相邻诸牌，数如其威。");
            // 幻影奇卡
            AddTranslation("Phantom Chica", "幻奇卡");
            // 往昔的残魂虚影。它每次仅能短暂现世，与现世产生片刻交集。
            AddTranslation("A remnant of the past. It can interact with this world for mere moments at a time.", "往日之馀影。每次仅暂现于世而已。");
            // 幻影霍斯
            AddTranslation("Phantom Foxy", "幻霍斯");
        }
    }
}
