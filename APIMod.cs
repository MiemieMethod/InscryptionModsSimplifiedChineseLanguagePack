using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class APIMod
    {
        public static void RegisterTranslations()
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
            // 依赖于挑战：
            AddTranslation("Depends on: ", "依赖于挑战：");
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
