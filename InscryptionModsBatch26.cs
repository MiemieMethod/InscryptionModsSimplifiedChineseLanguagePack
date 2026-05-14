using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch26
    {
        private static readonly (string English, string Simplified, string Classical)[] EncounterPacks =
        {
            ("Inscryption: Beastly Card Expansion Pack", "邪恶冥刻：野兽卡牌扩展包", "《冥勒》：兽牌扩包"),
            ("Inscryption: Techno Card Expansion Pack", "邪恶冥刻：科技卡牌扩展包", "《冥勒》：机牌扩包"),
            ("Inscryption: Undead Card Expansion Pack", "邪恶冥刻：死亡卡牌扩展包", "《冥勒》：亡牌扩包"),
            ("GrimoraMod", "格里魔拉模组", "格里魔拉模组"),
            ("Inscryption: Magickal Card Expansion Pack", "邪恶冥刻：魔法卡牌扩展包", "《冥勒》：术牌扩包"),
            ("Miscellaneous Community Cards", "社区杂项卡牌", "社区杂牌"),
            ("Inscryption: Beastly Encounters", "邪恶冥刻：野兽遭遇战", "《冥勒》：兽遇战"),
            ("Unsorted Regions and Encounters", "未分类区域与遭遇战", "未分区域与遇战"),
            ("Eri Card Expansion", "艾瑞卡牌扩展包", "艾瑞牌扩包"),
            ("Ara's Card Expansion", "阿拉的卡牌扩展包", "阿拉牌扩包"),
            ("Hallownest Expansion", "圣巢扩展包", "圣巢扩包"),
            ("Bitty's Regions", "比蒂的区域扩展包", "比蒂区域扩包"),
            ("Void Region Expansion", "虚空区域扩展包", "虚空区域扩包"),
            ("Eri's Card Pack Encounters", "艾瑞的卡包遭遇战", "艾瑞牌包遇战"),
            ("Original Undead Card", "原版亡灵族群卡牌", "原版亡族牌"),
            ("NonOriginal Undead Card", "非原版亡灵族群卡包", "补缀亡族牌包"),
            ("Wilderness Legend", "荒野传说", "荒野传奇"),
            ("DLC_Fairy_Tale", "荒野传说DLC：璀璨童话", "荒野传奇DLC：绮童话"),
            ("P03KCM", "P03KCM", "P03KCM"),
            ("Kaycee's P03 Expansion Pack #1", "凯茜的P03扩展包#1", "凯茜P03扩包其一"),
            ("Kaycee's P03 Expansion Pack #2", "凯茜的P03扩展包#2", "凯茜P03扩包其二"),
            ("Inscryption: Rogue Bots of Botopia", "邪恶冥刻：机托邦的失控机器人", "《冥勒》：机托邦叛械"),
            ("Kaycee's P03 Encounter Expansion #1", "凯茜的P03遭遇战扩展#1", "凯茜P03遇战扩包其一"),
            ("Kaycee's P03 Encounter Expansion #2", "凯茜的P03遭遇战扩展#2", "凯茜P03遇战扩包其二"),
            ("Kaycee's P03 Expansion Pack #3", "凯茜的P03扩展包#3", "凯茜P03扩包其三"),
            ("Kaycee's P03 Encounter Expansion #3", "凯茜的P03遭遇战扩展#3", "凯茜P03遇战扩包其三"),
            ("Aga's Magnificus Expansion", "Aga的蔓尼菲科模组扩展", "Aga蔓尼菲科扩包"),
            ("Smughtro's MagMod Expansion", "Smughtro的蔓尼菲科模组扩展", "Smughtro蔓尼菲科扩包"),
            ("Revenant Mod Card Pack", "复生亡灵模组卡包", "复生亡灵牌包"),
            ("Card Pack: StarCraft", "星际争霸卡包", "星际争霸牌包"),
            ("Legends From The Darkness: Encounters", "来自黑暗的传说：遭遇战", "《自暗而来之传》：遇战"),
            ("Gareth's Mod", "加雷斯的模组", "Gareth模组"),
        };

        public static void RegisterTranslations()
        {
            RegisterPackManagementModOne();
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

        private static void RegisterPackManagementModOne()
        {
            // 选择卡包
            AddTranslation("Select Card Packs", "择牌包");
            // 选择遭遇战卡包
            AddTranslation("Select Encounter Packs", "择遇战牌包");
            // 选择激活的卡包
            AddTranslation("Choose Active Packs", "择所用牌包");

            // 邪恶冥刻：野兽卡牌扩展包
            AddTranslation("Inscryption: Beastly Card Expansion Pack", "《冥勒》：兽牌扩包");
            // 莱西小屋中的原始卡牌系列。包含狼、螳螂以及偶尔出现的蟑螂。
            AddTranslation("The original set of cards featured in Leshy's cabin. Featuring wolves, mantises, and the occasional cockroach.", "莱西之庐旧牌之列也，有狼、螳螂，间亦有蜚蠊。");
            // 邪恶冥刻：科技卡牌扩展包
            AddTranslation("Inscryption: Techno Card Expansion Pack", "《冥勒》：机牌扩包");
            // 采用能量机制的原始机器人卡牌系列。
            AddTranslation("The original set of robotic cards, exclusively using the energy mechanic.", "机牌旧列也，专用能量之法。");
            // 邪恶冥刻：死亡卡牌扩展包
            AddTranslation("Inscryption: Undead Card Expansion Pack", "《冥勒》：亡牌扩包");
            // 格里魔拉模组
            AddTranslation("GrimoraMod", "格里魔拉模组");
            // 这些卡牌由亡者之骨驱动，从坟墓归来为你而战。
            AddTranslation("Powered by the bones of the dead, these cards have come back from the grave to fight for you.", "藉亡者之骨而动，自冢中归来，为汝战。");
            // 邪恶冥刻：魔法卡牌扩展包
            AddTranslation("Inscryption: Magickal Card Expansion Pack", "《冥勒》：术牌扩包");
            // 驾驭玛珂之力召唤学徒，在最荣耀的决斗中作战。
            AddTranslation("Harness the might of the moxen to summon forth apprentices and fight in the most honorable of duels.", "驭诸玛珂之威，召学徒而出，于至荣之决斗中战。");
            // 驾驭玛珂之力召唤学徒，在最荣耀的决斗中作战。（蔓尼菲科模组卡牌）
            AddTranslation("Harness the might of the moxen to summon forth apprentices and fight in the most honorable of duels. (Magnificus Mod Cards)", "驭诸玛珂之威，召学徒而出，于至荣之决斗中战。（蔓尼菲科模组牌）");
            // 社区杂项卡牌
            AddTranslation("Miscellaneous Community Cards", "社区杂牌");
            // 由模组添加但未妥善分类的非常规杂乱卡牌。
            AddTranslation("The unusual, unsorted, and unruly cards that have been added by mods but not properly sorted into packs.", "诸模组所益异牌，未妥分入诸包者。");
            // 邪恶冥刻：野兽遭遇战
            AddTranslation("Inscryption: Beastly Encounters", "《冥勒》：兽遇战");
            // 莱西精心策划的包含[summary]的原始系列，旨在提供理想游戏体验。
            AddTranslation("The original set of [summary] that Leshy has carefully curated for the ideal gaming experience.", "莱西所精治之旧[summary]也，以供佳局。");
            // 未分类区域与遭遇战
            AddTranslation("Unsorted Regions and Encounters", "未分区域与遇战");
            // 这里的[summary]由模组添加但未妥善归类至卡包
            AddTranslation("These [summary] have been added by mods but not properly sorted into packs.", "此[summary]皆模组所益，而未妥归诸包。");
            // 艾瑞卡牌扩展包
            AddTranslation("Eri Card Expansion", "艾瑞牌扩包");
            // 从[randomcard]到[randomcard]，此卡包内含[count]种野生动物，它们与《邪恶冥刻》的蛮荒世界完美契合。
            AddTranslation("From the [randomcard] to the [randomcard], this pack contains [count] wild animals that feel right at home in the wild world of Inscryption.", "自[randomcard]至[randomcard]，此包凡有[count]种野兽，宜于《冥勒》荒野之世。");
            // 阿拉的卡牌扩展包
            AddTranslation("Ara's Card Expansion", "阿拉牌扩包");
            // 该扩展包包含[count]张卡牌，为《邪恶冥刻》核心玩法带来独特变化。[randomcard]与[randomcard]等卡牌将为你的下次冒险增添别样趣味。
            AddTranslation("This expansion contains [count] cards that offer a unique twist on Inscryption's core gameplay. Cards like [randomcard] and [randomcard] will give a little additional spice to your next run.", "此扩包有[count]牌，于《冥勒》本戏之法别出机杼。[randomcard]与[randomcard]诸牌，足为尔下回之行增一味。");
            // 圣巢扩展包
            AddTranslation("Hallownest Expansion", "圣巢扩包");
            // 大型扩展包，内含[count]种来自《空洞骑士》的造物。从宁静的十字路，下至深渊之底。
            AddTranslation("A large expansion containing [count] creatures from Hollow Knight. Up from peaceful Crossroads, down into the Abyss.", "大扩包也，含《空洞骑士》诸物[count]种。上自宁静十字路，下至深渊之底。");
            // 比蒂的区域扩展包
            AddTranslation("Bitty's Regions", "比蒂区域扩包");
            // 比蒂的区域扩展包新增了[summary]。
            AddTranslation("Bitty's Regions adds [summary].", "比蒂区域扩包，益[summary]。");
            // 虚空区域扩展包
            AddTranslation("Void Region Expansion", "虚空区域扩包");
            // 来自虚空的区域扩展包新增了[summary]。
            AddTranslation("This region expansion from Void adds [summary].", "此虚空区域扩包，益[summary]。");
            // 艾瑞的卡包遭遇战
            AddTranslation("Eri's Card Pack Encounters", "艾瑞牌包遇战");
            // 该扩展新增了[summary]，包含来自艾瑞卡牌扩展包的卡牌
            AddTranslation("This expansion adds [summary] featuring cards from Eri's Card Expansion.", "此扩包益[summary]，皆用艾瑞牌扩包之牌。");
            // 凯茜的P03扩展包#1
            AddTranslation("Kaycee's P03 Expansion Pack #1", "凯茜P03扩包其一");
            // 来自“凯茜模组中的P03模组”开发团队的首个扩展包，为机托邦四大区域新增[count]张卡牌。
            AddTranslation("The first expansion pack from the developers of 'P03 in Kaycees Mod' adds [count] new cards across all four regions of Botopia.", "“凯茜模组中之P03”开发者首扩包也，为机托邦四域益[count]新牌。");
            // 凯茜的P03扩展包#2
            AddTranslation("Kaycee's P03 Expansion Pack #2", "凯茜P03扩包其二");
            // 官方第二弹扩展包，内含[count]张能引发爆炸性反应的火热新卡！
            AddTranslation("The second official expansion pack, with [count] firey new cards that command an explosive reaction!", "官方第二扩包也，内有[count]火烈新牌，足发爆应！");
            // 邪恶冥刻：机托邦的失控机器人
            AddTranslation("Inscryption: Rogue Bots of Botopia", "《冥勒》：机托邦叛械");
            // 机托邦已被失控机器人占领！这些[count]个遭遇战已针对凯茜模组重新平衡。
            AddTranslation("Botopia has become overrun with rogue bots! These [count] encounters have been rebalanced for Kaycee's Mod.", "机托邦为叛械所充矣！此[count]遇战，已为凯茜模组重平之。");
            // 凯茜的P03遭遇战扩展#1
            AddTranslation("Kaycee's P03 Encounter Expansion #1", "凯茜P03遇战扩包其一");
            // 新增[count]个包含首款P03官方扩展包卡牌的遭遇战。
            AddTranslation("[count] additional encounters that feature cards from the first official P03 expansion pack.", "别益[count]遇战，皆用P03首官方扩包之牌。");
            // 凯茜的P03遭遇战扩展#2
            AddTranslation("Kaycee's P03 Encounter Expansion #2", "凯茜P03遇战扩包其二");
            // 新增[count]个包含第二款P03官方扩展包卡牌的遭遇战。
            AddTranslation("[count] additional encounters that feature cards from the second official P03 expansion pack.", "别益[count]遇战，皆用P03第二官方扩包之牌。");
            // 凯茜的P03扩展包#3
            AddTranslation("Kaycee's P03 Expansion Pack #3", "凯茜P03扩包其三");
            // 他们说这永远不会发生，但它来了！第三个官方扩展包打破了所有规则，为机托邦带来了[count]张包含骨头、血量和宝石的新卡牌！
            AddTranslation("They said it would never happen, but it's here! The third official expansion pack breaks all of the rules, with [count] new cards that bring bones, blood, and gems to Botopia!", "人皆谓终不可至，而今其来矣！第三官方扩包尽破旧则，为机托邦致[count]新牌，兼骨、血与玉！");
            // 凯茜的P03遭遇战扩展#3
            AddTranslation("Kaycee's P03 Encounter Expansion #3", "凯茜P03遇战扩包其三");
            // [count]个额外遭遇战，包含来自第三个官方P03扩展包的卡牌。
            AddTranslation("[count] additional encounters that feature cards from the third official P03 expansion pack.", "别益[count]遇战，皆用P03第三官方扩包之牌。");
            // Aga的蔓尼菲科模组扩展
            AddTranslation("Aga's Magnificus Expansion", "Aga蔓尼菲科扩包");
            // 蔓尼菲科模组的非官方扩展，拥有[count]位独特而丰富多彩的法师
            AddTranslation("An unofficial expansion to the Magnificus Mod featuring [count] unique and colourful mages", "蔓尼菲科模组之非官方扩包，有[count]法师，皆异而多采。");
            // Smughtro的蔓尼菲科模组扩展
            AddTranslation("Smughtro's MagMod Expansion", "Smughtro蔓尼菲科扩包");
            // 为Magnificus模组新增19张普通卡、7张稀有卡、7个法术及6张代币卡。
            AddTranslation("Adds 19 common cards, 7 rare cards, 7 spells, and 6 token cards to Magnificus Mod.", "为蔓尼菲科模组益十九常牌、七稀牌、七术与六符牌。");
            // 复生亡灵模组卡包
            AddTranslation("Revenant Mod Card Pack", "复生亡灵牌包");
            // 这套卡牌主要由一些能以各种方式返回玩家手中的卡牌组成。
            AddTranslation("This card pack consists of mainly cards that return to the player in a variety of ways.", "此牌包多为能以诸法返于玩家之手者。");
            // 星际争霸卡包
            AddTranslation("Card Pack: StarCraft", "星际争霸牌包");
            // 《星际争霸Ⅰ》登场角色
            AddTranslation("Characters from StarCraft One.", "《星际争霸Ⅰ》之人物。");
            // 来自黑暗的传说：遭遇战
            AddTranslation("Legends From The Darkness: Encounters", "《自暗而来之传》：遇战");
            // 为《来自黑暗的传说》打造的持续更新内容包，旨在为游戏新增遭遇战。
            AddTranslation("an Ever-expanding content pack for LFTD, meant to add battle encounters to the game.", "《自暗而来之传》之常增内容包也，志在益遇战于戏。");
            // 加雷斯的模组
            AddTranslation("Gareth's Mod", "Gareth模组");
            // 由Gareth48制作、Plutraser绘制插画的第一章补充卡包。新增[count]张卡牌与7种特殊印记，设计风格完美融入原版《邪恶冥刻》的体系。
            AddTranslation("A part 1 booster pack created by Gareth48 and illustrated by Plutraser. Adds [count] cards and 7 sigils designed to fit right into vanilla Inscryption.", "Gareth48作而Plutraser画之第一章补牌包也，益[count]牌与七印技，皆可无间入于原版《冥勒》。");

            foreach (var pack in EncounterPacks)
            {
                // 卡包：{title}
                AddTranslation("Card Pack: " + pack.Simplified, "牌包：" + pack.Classical);
                // 遭遇战卡包：{title}
                AddTranslation("Encounters Pack: " + pack.Simplified, "遇战牌包：" + pack.Classical);
                for (int count = 0; count <= 100; count++)
                {
                    // 包含来自于{title}的{count}场遭遇战。
                    AddTranslation("Contains " + count.ToString() + " encounters from " + pack.Simplified + ".", "含自" + pack.Classical + "来之" + count.ToString() + "场遇战。");
                }
            }

            for (int count = 0; count <= 100; count++)
            {
                // 包含{count}场遭遇战。
                AddTranslation("Contains " + count.ToString() + " encounters.", "含" + count.ToString() + "场遇战。");
            }

            // 包含：{0}以及更多的{1}张卡牌。
            AddTranslation("Cards in this pack: {0} and {1} other{2}.", "此包有{0}及余{1}牌{2}。");
        }
    }
}
