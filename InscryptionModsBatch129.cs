using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch129
    {
        public static void RegisterTranslations()
        {
            RegisterFiveNightsThree();
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

        private static void RegisterFiveNightsThree()
        {
            // 往昔残影，利爪依旧致命。却只能驻留片刻光阴。
            AddTranslation("A remnant of the past, its hook is still deadly. But it can only stay for a short time.", "往日之馀影，其钩犹杀，然留世惟顷刻。");
            // 幻影弗莱迪
            AddTranslation("Phantom Freddy", "幻弗莱迪");
            // 往昔的残影，酷爱阅读同人小说。
            AddTranslation("A remnant of the past, loves to read fanfiction.", "往日之馀影，喜读旁传。");
            // 幻影曼果
            AddTranslation("Phantom Mangle", "幻曼果");
            // 往昔的残痕。你能感受到它遗落的能量正不断弥散。
            AddTranslation("A remnant of the past. You can feel the seeping Energy it leaves behind.", "往日之馀影。其遗之能，汝可觉其渗焉。");
            // 幻影傀儡
            AddTranslation("Phantom Puppet", "幻傀儡");
            // 往昔残影，如今已不再超度亡魂。
            AddTranslation("a remnant of the past, it now no longer revives dead souls.", "往日之馀影，今不复起亡魂。");
            // 波波炸弹
            AddTranslation("Pop-Pop", "波波");
            // 对所有卡牌造成 1 点伤害。
            AddTranslation("Deals 1 Damage to all Cards.", "伤诸牌各一。");
            // 嗯……某个游戏里的造物，看起来马上就要爆炸了！
            AddTranslation("Hmm... a Creature from some Game... It looks like it will blow up soon!", "唔……他戏之物乎……观其将爆。");
            // 残魂奔涌
            AddTranslation("Remnant Surge", "馀响涌");
            // 消耗所有能量，每消耗2点能量，获得1点攻击力，仅存在一回合。
            AddTranslation("[creature] will get +1 Attack for 2 Remnant.", "每二馀响，[creature]威加一。");
            // 傀儡
            AddTranslation("The Puppet", "傀儡");
            // 你听见八音盒悠远的旋律。一股诡秘的气息萦绕不散，它牵动着迷途与被遗忘之人的心弦…… 赠予他们一次重来的机会。
            AddTranslation("You hear the distant melody of a music box. A sprrpwful presence lingers, its strings pulling at the lost and forgotten... offering them one more chance.", "汝闻八音匣之远调。一股幽然之气久留，其丝牵及迷失与见遗者……予之一再试之机。");
            // 傀儡师
            AddTranslation("Puppeter", "傀儡师");
            // 放置时，抽取邦邦或邦尼特其中一张。
            AddTranslation("On Play: [creature] will draw either Bon Bon or Bonnet.", "既陈，引邦邦或邦妮特之一。");
            // 傀师之偶
            AddTranslation("Puppeteers Puppet", "傀师之偶");
            // 回合结束时，将与欢乐时光弗莱迪进行登场合体。
            AddTranslation("On Turn End: [creature] will combine with Funtime Freddy On Play.", "合终，[creature]将与欢时弗莱迪合为一体。");
            // 其他卡牌死亡时，可在友方造物将死之际，将其以弱化形态复活。
            AddTranslation("On Other Card Death: [creature] will ressurect friendly creatures in a weaker state when they perish.", "他牌死时，[creature]能使友物以弱形复起。");
            // 彩虹
            AddTranslation("Rainbow", "彩虹");
            // 退出键
            AddTranslation("Escape key", "退键");
            // 将抽取一张随机卡牌。
            AddTranslation("[creature] will draw a random card.", "[creature]将引一偶牌。");
            // 抽取时，随机选定一项冲刺能力，作为舞蹈编排的效果。
            AddTranslation("On Drawn: [creature] Chooses a random Strafe Ability as part of the Choreography.", "[creature]既引，则偶择一徙行印技为其舞式之一。");
            // 残响引者
            AddTranslation("Remnant Drawer", "引馀响者");
            // 上场时，从你的牌库抽一张牌（拥有2点残响时额外抽一张牌）。
            AddTranslation("On Play: [creature] will draw a card from your Deck (Draw an additional Card for 2 Remnant).", "既陈，自汝牌列引一牌（有二馀响则又引一牌）。");
            // 残响共鸣
            AddTranslation("Remnant Sharer", "馀响同分");
            // 在场时，能让你从自己的卡牌中获得残响。
            AddTranslation("[creature] will allow you to gain Remnant from your own Cards.", "[creature]在局，则汝可自汝之牌得馀响。");
            // 残响辅抽者
            AddTranslation("Remnant Side Drawer", "副引馀响者");
            // 消亡时，从你的副牌堆抽一张牌（拥有2点残响时额外抽一张牌）。
            AddTranslation("On Death: [creature] will draw a card from your Side Deck (Draw an additional Card for 2 Remnant).", "[creature]既亡，自汝副牌列引一牌（有二馀响则又引一牌）。");
            // 残响生成器
            AddTranslation("Remnant Spawner", "生馀响者");
            // 消亡时，消耗2点残响，将其自身检索入手牌。
            AddTranslation("On Death: [creature] will draw itself in exchange for 2 Remnant.", "[creature]既亡，出二馀响，而反引其身。");
            // 劣质主机
            AddTranslation("Bad Pc", "弊机");
            // 取消对小屋做出的所有改动
            AddTranslation("Disables the changes made to the Cabin", "罢庐中诸变。");
            // 绞碎机
            AddTranslation("Scooper", "绞机");
            // 持牌人的回合结束时，有1/10的几率直接消灭敌方卡牌。
            AddTranslation("On Turn End: [creature] has a 1/10 chance to instantly kill the opposing Card.", "合终，[creature]有什一之几可立杀所对之牌。");
            // 废弃玩偶
            AddTranslation("Scrap Baby", "废婴");
            //  ...A freakshow. Mind her grasping claw.
            AddTranslation(" ...A freakshow. Mind her grasping claw.", "……异形之戏也。慎其攫爪。");
            // 暗影邦尼
            AddTranslation("Shadow Bonnie", "影邦尼");
            // 暗影弗莱迪
            AddTranslation("Shadow Freddy", "影弗莱迪");
            // 好戏开场
            AddTranslation("Showtime", "开演");
            // 被抽到时，的能量消耗变为1至6点随机数值。
            AddTranslation("On Drawn: [creature] will have its energy cost randomized from 1 - 6.", "既引，[creature]之能耗偶为一至六。");
            // 灵魂
            AddTranslation("Soul", "魂");
            // 曾为凡人之躯，如今只剩残响与痛苦的傀儡。
            AddTranslation("Once a human being, now only a tool of Remnant and Agony.", "昔为人，今惟馀响与苦痛之具耳。");
            // 野兽冥刻者
            AddTranslation("Scrybe of Beasts", "兽司锲");
            // 死亡冥刻者
            AddTranslation("Scrybe of Death", "死司锲");
            // 魔法冥刻者
            AddTranslation("Scrybe of Magik", "术司锲");
            // 科技冥刻者
            AddTranslation("Scrybe of Technology", "机司锲");
            // 弹簧陷阱
            AddTranslation("Springtrap", "弹簧陷阱");
            // 一名被困在自己造物之中的凶手。
            AddTranslation("A murderer trapped in his own creation.", "一凶徒，自陷其所造者中。");
            // 静电杂音
            AddTranslation("Static", "静噪");
            // 将激怒敌方单位，使其无法发起攻击。
            AddTranslation("[creature] Irritates the Opponent, making it unable to attack.", "[creature]激恼其敌，使不能攻。");
            // 填充物
            AddTranslation("Stuffed", "填物");
            // 戴夫
            AddTranslation("Dave", "戴夫");
            // ……这家伙是怎么来到这里的？
            AddTranslation("... How did this guy get here?", "……此人何以来此？");
            // 燃烧残骸
            AddTranslation("Burning Debris", "焚骸");
            // 费斯熊惊魂屋的燃烧残骸
            AddTranslation("Burning Debris of Fazbears Fright", "费熊惊馆之焚骸");
            // 噬咬事件
            AddTranslation("The Bite", "咬祸");
            // 当受到伤害时，持牌人获得1点残响。
            AddTranslation("On Take Damage: [creature] will give 1 Remnant.", "[creature]受伤，则予一馀响。");
            // 曼果
            AddTranslation("The Mangle", "曼果");
            // 他总是不断碎裂瓦解，而她却能一次次重塑自身。
            AddTranslation("He constantly falls apart, but she keeps putting herself back together.", "彼恒自解，而她又恒自缀。");
            // 玩具邦尼
            AddTranslation("Toy Bonnie", "玩具邦尼");
            // 这是 “全新升级版” 邦尼。你得先为它充能，才能发挥作用。
            AddTranslation("The 'New and Improved' Bonnie. You'll need to charge it to get any use.", "“新而更良”之邦尼。欲得其用，须先充能。");
            // 玩具奇卡
            AddTranslation("ToyChica", "玩具奇卡");
            // “全新升级版” 奇卡。它拥有过剩的能量。
            AddTranslation("The 'New and Improved' Chica. It has an excess amount of energy.", "“新而更良”之奇卡。其能甚有馀。");
            // 玩具弗莱迪
            AddTranslation("Toy Freddy", "玩具弗莱迪");
            // “全新升级版” 弗莱迪。一个脾气暴躁的硬核玩家。
            AddTranslation("The 'New And Improved' Freddy. A true xXGamerXx with anger issues.", "“新而更良”之弗莱迪。真戏徒也，而性甚躁。");
            // 持牌人的回合结束时，将敌方卡牌吞噬入自身。
            AddTranslation("On Turn End: [creature] will capture the opposing Card in itself.", "持者合终，[creature]吞所对之牌于其内。");
            // 金属丝线
            AddTranslation("Wire Pile", "金属丝堆");
            // 凋零邦尼
            AddTranslation("Withered Bonnie", "凋邦尼");
            // 邦尼的破损版本。性情乖戾暴躁，出手凶狠且极具破坏力。
            AddTranslation("A broken down version of Bonnie. Erratic, violent, and has a mean punch.", "邦尼之残形。乖戾而暴，其击甚猛。");
            // 凋零奇卡
            AddTranslation("Withered Chica", "凋奇卡");
            // 奇卡的破损形态。外露的电线让它的触碰足以致命，性格也和其他玩偶一样喜怒无常。
            AddTranslation("A broken down version of Chica. Its touch is deadly, due to its exposed wirings. Just as erratic as the others.", "奇卡之残形。其线外露，故触之致命；其性亦如他偶之乖戾。");
            // 凋零霍斯
            AddTranslation("Withered Foxy", "凋霍斯");
            // 霍斯的破损版本。极易动怒，也常常四处游荡。小心它的铁钩，依旧锋利无比。
            AddTranslation("A broken down version of Foxy. Easily angered, but also spends a good amount of its time roaming. Mind its hook, it's still just as sharp.", "霍斯之残形。易怒，然亦多时游行。慎其钩，犹利如故。");
            // 凋零弗莱迪
            AddTranslation("Withered Freddy", "凋弗莱迪");
            // 弗莱迪的破损版本。性情乖戾无常，会攻击任何触碰它的事物。
            AddTranslation(" A broken down version of Freddy. It's erratic, and will attack anything that touches it.", "弗莱迪之残形。乖戾无常，凡触之者皆攻。");
            // 你是第一名
            AddTranslation("You are Number One", "汝为第一");
            // 持牌人的回合结束时，为左侧卡牌赋予1点力量。额外效果：若持牌人拥有1点残响，同时为右侧卡牌也赋予1点力量。
            AddTranslation("On Turn End: [creature] will give the Card to its left +1/0 (Additionally: If you have 1 Remnant also give the Card to its right +1/0).", "持者合终，[creature]益左牌一威；若主持有一馀响，亦益右牌一威。");
            // 邪恶冥刻：玩具熊的五夜后宫
            AddTranslation("Five Nights at Inscryption", "《冥锲》五夜");
            // 该卡包包含一众玩具熊的五夜后宫主题卡牌，涵盖从弗莱迪费斯熊到弹簧陷阱的各类角色。
            AddTranslation("This card pack contains a bunch of FNAF themed Cards, from Freddy Fazbear to Springtrap.", "此牌韬收诸五夜题牌，自弗莱迪费熊至弹簧陷阱，皆在焉。");
        }
    }
}
