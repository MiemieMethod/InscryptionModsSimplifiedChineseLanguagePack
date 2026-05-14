using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch1
    {
        public static void RegisterTranslations()
        {
            RegisterApiMod();
            RegisterAchievementsMod();
            RegisterGrimoraMod();
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

        private static void RegisterApiMod()
        {
            // 伊耶拉克
            AddTranslation("Ijiraq", "伊耶拉克");
            // 牌桌上至少需有一颗[v:1]宝石才能使用这张[v:0]。
            AddTranslation("You need at least one [v:1] gem on the board to play that [v:0].", "局中至少须有一[v:1]玉，乃可陈彼[v:0]。");
            // 这台[c:bR]发电机[c:]要爆炸……或是怎样。
            AddTranslation("This [c:bR]generator[c:] is about to explode... or something.", "此[c:bR]机枢[c:]将爆矣……抑或然也。");
            // 好鱼。[w:0.3]打挖泥工。[w:0.3]打黏液。[w:0.3]打凯茜。
            AddTranslation("Good fish.[w:0.3] Beat Dredger.[w:0.3] Beat Goo.[w:0.3] Beat Kaycee.", "善鱼。[w:0.3]克浚夫。[w:0.3]克胶。[w:0.3]克凯茜。");
            // 我应该把它给挖泥工……[w:0.3]它倒也并不是一无是处。
            AddTranslation("I've gotta give it to that Dredger...[w:0.3] Not as useless as I thought.", "余当称彼浚夫……[w:0.3]未若余意之无用。");
            // 你能获得我的[c:bR]奖励[c:]吗，冒险者？
            AddTranslation("Will you earn my [c:bR]boons[c:], traveller?", "行者，汝能得我[c:bR]诸惠[c:]乎？");
            // 你即将死于机械虫之手。你抽到了跳跃机器人。
            AddTranslation("YOU ARE ABOUT TO DIE FROM AN INSECTODRONE. YOU DRAW A L33PB0T.", "汝将死于虫飞械。汝引得跃机人。");

            // 选择挑战
            AddTranslation("SELECT CHALLENGES", "择诸角竞");
            // 挑战不可用
            AddTranslation("CHALLENGE UNAVAILABLE", "角竞不可用");
            // 附录12，第一节 - 模组奖励{0}
            AddTranslation("APPENDIX XII, SUBSECTION I - MOD BOONS {0}", "附编十二，第一节——补缀诸惠{0}");
            // 附录12，第一节 - 卡槽效果{0}
            AddTranslation("APPENDIX XII, SUBSECTION I - SLOT EFFECTS {0}", "附编十二，第一节——补缀位效{0}");
            // 附录12，第一节 - 模组能力{0}
            AddTranslation("APPENDIX XII, SUBSECTION I - MOD ABILITIES {0}", "附编十二，第一节——补缀诸印技{0}");
            // 能力描述。
            AddTranslation("Ability Description.", "印技之释。");
            // 不兼容挑战：饥荒
            AddTranslation("Incompatible with: 饥荒", "不兼于：饥荒");
            // 不兼容挑战：五谷丰登
            AddTranslation("Incompatible with: 五谷丰登", "不兼于：五谷丰登");
            // 不兼容挑战：天平不平
            AddTranslation("Incompatible with: 天平不平", "不兼于：天平不平");
            // 不兼容挑战：反向天平不平
            AddTranslation("Incompatible with: 反向天平不平", "不兼于：反向天平不平");

            // 若选择原版，不更改图腾头部；若选择自定义族群，新增族群将使用自定义头部；若选择全部族群，则所有图腾头部均使用自定义样式。
            AddTranslation("If Vanilla, don't change totem tops; if CustomTribes, added custom tribes will use custom totem tops; if AllTribes then all totem tops will use a custom top.", "若取原本，则神偶之首不易；若取自定诸属，则新增诸属各用自定之首；若取诸属尽然，则凡神偶之首皆用自定之式。");
            // 若选择原版，仅使用原版道具；若选择自定义，新增道具将使用自定义模型；若选择全部，则所有道具均使用自定义模型。
            AddTranslation("If Vanilla, only vanilla items will be used; if Custom, added custom items will use custom models; if All then all items will use a custom model.", "若取原本，则唯用原本诸器；若取自定，则新增诸器各用自定之形；若取尽然，则凡器皆用自定之形。");
            // 启用时，挑战选择界面的箭头将强制显示在屏幕顶部而非两侧。
            AddTranslation("When true, forces the challenge screen arrows to appear at the top of the screen instead of the sides.", "启此，则角竞之屏所见箭镞强出于屏上，不在两旁。");
            // 启用时，第一章卡牌费用选择项的呈现顺序将被随机打乱。
            AddTranslation("When true, randomises the order card cost choices are presented in Act 1.", "启此，则第一章牌直诸择之次第皆乱。");
            // 启用时，头目战不会生成场景装饰物（如矿工的冷杉），可提升低配置设备的运行性能。
            AddTranslation("When true bosses will not spawn their scenery. (eg: Prospector's trees) This can improve performance on low-end machines.", "启此，则诸魁不生其景饰（如采夫之树）。此可益薄力之机。");

            // 你的[v:1]宝石不足。
            AddTranslation("You don't have enough [v:1] gems for that.", "汝之[v:1]玉不足。");
            // 牌桌上[v:1]宝石不够？你无法使用此牌。
            AddTranslation("Not enough [v:1] gems on the table? Then you can't play it.", "局中[v:1]玉不足，则不得陈此。");
            // 牌桌上需要更多[v:1]宝石才能使用这张[v:0]。
            AddTranslation("You need more [v:1] gems on the board in order to play that [v:0].", "欲陈彼[v:0]，局中尚须更多[v:1]玉。");
            // 必须先使用[v:1]宝石……才能打出此牌。
            AddTranslation("Play the required [v:1] gems... then you can play that.", "先陈所须之[v:1]玉……而后可陈彼。");
            // [c:bB]你的[v:1]宝石不足。[c:]
            AddTranslation("[c:bB]You don't have enough [v:1] gems for that.[c:]", "[c:bB]汝之[v:1]玉不足。[c:]");
            // [c:bB]牌桌上[v:1]宝石不够？你无法使用此牌。[c:]
            AddTranslation("[c:bB]Not enough [v:1] gems on the table? Then you can't play it.[c:]", "[c:bB]局中[v:1]玉不足，则不得陈此。[c:]");
            // [c:bB]牌桌上需要更多[v:1]宝石才能使用这张[v:0]。[c:]
            AddTranslation("[c:bB]You need more [v:1] gems on the board in order to play that [v:0].[c:]", "[c:bB]欲陈彼[v:0]，局中尚须更多[v:1]玉。[c:]");
            // [c:bB]必须先使用[v:1]宝石……才能打出此牌。[c:]
            AddTranslation("[c:bB]Play the required [v:1] gems... then you can play that.[c:]", "[c:bB]先陈所须之[v:1]玉……而后可陈彼。[c:]");
            // 不成，你的能量不足。
            AddTranslation("No. You don't have the energy.", "不可。能不足。");
            // 需要[v:1]点能量。你目前只有[v:2]点能量。
            AddTranslation("That costs [v:1] energy and you have [v:2].", "此直[v:1]能，而今唯[v:2]能。");
            // 你还没懂吗？需要[v:1]点能量。你的能量不足。
            AddTranslation("Do you still not get it? It costs [v:1] energy and you don't have enough.", "犹未喻乎？此直[v:1]能，而能不足。");
            // 能量不足，无法使用[v:0]。
            AddTranslation("That [v:0] costs more energy than you have.", "[v:0]所须之能，多于既有。");
        }

        private static void RegisterAchievementsMod()
        {
            // 成就
            AddTranslation("ACHIEVEMENTS", "功成录");
            // 凯茜模组成就
            AddTranslation("Kaycee's Mod Achievements", "凯茜补缀功成录");
            // 剧情成就
            AddTranslation("Story Achievements", "叙事功成录");
            // 成就已解锁
            AddTranslation("Achievement Unlocked", "功已启");
            // 隐藏成就
            AddTranslation("Secret Achievement", "隐功");
            // 解锁后显示
            AddTranslation("Revealed Once Unlocked", "启后乃显");
        }

        private static void RegisterGrimoraMod()
        {
            // 启动格里魔拉模组
            AddTranslation("Start Grimora Mod", "启格里魔拉补缀");
            // 重置冒险
            AddTranslation("RESET RUN", "重置此局");

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
            // 遭遇战配置：
            // 0=默认 使用模组内置方案
            // 1=随机 根据模组卡池完全随机生成
            // 2=自定义 从JSON文件读取配置
            // 3=混合 同时采用默认与自定义方案
            AddTranslation("0 = Default. Use the mod's internal blueprint system.\n1 = Randomized. Encounters are completely randomized using the mod's internal card pool.\n2 = Custom. Encounters are from made and used from the JSON files.\n3 = Mixed. Encounters are from both default list and custom list.", "遭遇之设：\n0=常。用补缀内置之蓝图。\n1=乱。以补缀内置牌池尽乱其遭遇。\n2=自定。遭遇取诸 JSON 之文件。\n3=杂。遭遇兼取常列与自定之列。");
            // 按键配置：
            // 0=W键查看牌组 S键离开牌桌
            // 1=上箭头查看道具牌组 下箭头离开牌桌
            AddTranslation("0 = W for viewing deck, S for getting up from the table.\n1 = Up arrow for viewing deck, down arrow for getting up from the table.", "按键之设：\n0=W以观牌列，S以离案。\n1=上矢以观牌列，下矢以离案。");
            // 电椅销毁概率：
            // 0=默认 第二次电击固定50%销毁率
            // 1=基础30%+低/中/高分别0%/10%/20% 若两次均为高强度则总概率70%
            // 2=低12.5% 中17.5% 高30% 两次高强度总概率60%
            // 3=低12.5% 中20% 高27.5% 两次高强度总概率55%
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
        }
    }
}
