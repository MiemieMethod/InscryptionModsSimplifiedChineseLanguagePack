﻿using System;
using System.Reflection;
using BepInEx;
using DiskCardGame;
using GracesGames.Common.Scripts;
using HarmonyLib;
using InscryptionAPI;
using InscryptionAPI.Card;
using InscryptionAPI.Dialogue;
using InscryptionAPI.Localizing;
using InscryptionAPI.Nodes;
using InscryptionAPI.Pelts;
using TMPro;
using UnityEngine;

namespace SimplifiedChineseLanguagePack
{

    [BepInDependency(InscryptionAPIPlugin.ModGUID)]
    [BepInPlugin(GUID, Name, Version)]
    public class SimplifiedChineseLanguagePackPlugin : BaseUnityPlugin
    {
        public const string GUID = "miemiemethod.inscryption.mods_simplified_chinese_language_pack";
        public const string Name = "SimplifiedChineseLanguagePack";
        private const string Version = "1.3.2";

        public static bool LanguageLoaded = false;

        private void Awake()
        {
            Logger.LogInfo($"Loaded {Name}!");
            Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), GUID);
            APIMod.RegisterTranslations();
            AchievementsMod.RegisterTranslations();
            GrimoraMod.RegisterTranslations();
            MagnificusMod.RegisterTranslations();
            UndeadTempleINKCMMod.RegisterTranslations();
            WildernessLegendMod.RegisterTranslations();
            OriginalModifiedMod.RegisterTranslations();
            CustomSideDeck.RegisterTranslations();
            PackManagement.RegisterTranslations();
        }

        [HarmonyPatch(typeof(FontReplacementData), "Initialize")]
        public class LanguagePatch
        {
            public static void Postfix()
            {
                if (!LanguageLoaded)
                {
                    FixSimplifiedChineseFonts();
                }
            }
        }

        private static void FixSimplifiedChineseFonts()
        {
            Debug.Log("Fixing Simplified Chinese Fonts");
            FontReplacement DAGGERSQUAREReplacement =
                Resources.Load<FontReplacement>("data/localization/fontreplacement/DAGGERSQUARE_to_SC-SANS");
            FontReplacement MISC3DReplacement =
                Resources.Load<FontReplacement>("data/localization/fontreplacement/MISC3D_to_SC-SCRIPT");
            string bundlePath = Path.Combine(Paths.PluginPath, "MiemieMethod-Simplified_Chinese_Language_Pack_for_Mods",
                "chinese_font");
            var bundle = AssetBundle.LoadFromFile(bundlePath);
            if (bundle == null)
            {
                Debug.LogError("字体AssetBundle加载失败！");
                return;
            }

            TMP_FontAsset NotoSans = bundle.LoadAsset<TMP_FontAsset>("assets/textmesh pro/fonts/notosans_sc sdf.asset");
            TMP_FontAsset NotoSerif =
                bundle.LoadAsset<TMP_FontAsset>("assets/textmesh pro/fonts/notoserif_sc sdf.asset");
            SetPrivateTMPFont(DAGGERSQUAREReplacement, NotoSans);
            SetPrivateTMPFont(MISC3DReplacement, NotoSerif);
            LanguageLoaded = true;
        }

        private static void SetPrivateTMPFont(FontReplacement replacement, TMP_FontAsset fontAsset)
        {
            if (replacement == null)
            {
                Debug.LogError("FontReplacement为空，无法设置字体！");
                return;
            }

            var type = typeof(FontReplacement);
            var field = type.GetField("replacementTMPFont", BindingFlags.NonPublic | BindingFlags.Instance);
            if (field == null)
            {
                Debug.LogError("找不到replacementTMPFont字段，无法替换字体！");
                return;
            }

            field.SetValue(replacement, fontAsset);
            Debug.Log($"成功替换{replacement.name}的TMP字体为{fontAsset.name}");
        }
    }

    public class APIMod
    {
        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for API Mod");
            // DisplayText
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SELECT CHALLENGES", "选择挑战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CHALLENGE UNAVAILABLE", "挑战不可用", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "APPENDIX XII, SUBSECTION I - MOD BOONS {0}", "附录12，第一节 - 模组奖励{0}", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "APPENDIX XII, SUBSECTION I - SLOT EFFECTS {0}", "附录12，第一节 - 卡槽效果{0}", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "APPENDIX XII, SUBSECTION I - MOD ABILITIES {0}", "附录12，第一节 - 模组能力{0}", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ability Description.", "能力描述。", Language.ChineseSimplified);

            // Config
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If Vanilla, don't change totem tops; if CustomTribes, added custom tribes will use custom totem tops; if AllTribes then all totem tops will use a custom top.", "若选择原版，不更改图腾头部；若选择自定义族群，新增族群将使用自定义头部；若选择全部族群，则所有图腾头部均使用自定义样式。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If Vanilla, only vanilla items will be used; if Custom, added custom items will use custom models; if All then all items will use a custom model.", "若选择原版，仅使用原版道具；若选择自定义，新增道具将使用自定义模型；若选择全部，则所有道具均使用自定义模型。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When true, forces the challenge screen arrows to appear at the top of the screen instead of the sides.", "启用时，挑战选择界面的箭头将强制显示在屏幕顶部而非两侧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When true, randomises the order card cost choices are presented in Act 1.", "启用时，第一章卡牌费用选择项的呈现顺序将被随机打乱。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When true bosses will not spawn their scenery. (eg: Prospector's trees) This can improve performance on low-end machines.", "启用时，头目战不会生成场景装饰物（如矿工的冷杉），可提升低配置设备的运行性能。", Language.ChineseSimplified);

            // DialogueEvent
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You don't have enough [v:1] gems for that.", "你的[v:1]宝石不足", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Not enough [v:1] gems on the table? Then you can't play it.", "牌桌上[v:1]宝石不够？你无法使用此牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You need more [v:1] gems on the board in order to play that [v:0].", "牌桌上需要更多[v:1]宝石才能使用这张[v:0]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Play the required [v:1] gems... then you can play that.", "必须先使用[v:1]宝石……才能打出此牌", Language.ChineseSimplified);
            Dictionary<string, string> peltTypes = new Dictionary<string, string>
            {
                // BasePeltNames
                { "pelthare", "野兔" },
                { "peltwolf", "狼" },
                { "peltgolden", "金羊" },
            };
            foreach (PeltManager.PeltData peltData in PeltManager.AllPeltsAvailableAtTrader())
            {
                string text = peltData.peltTierName ?? PeltManager.GetTierNameFromData(peltData);
                if (!peltTypes.ContainsKey(text))
                {
                    Debug.LogWarning($"未找到毛皮等级{text}的中文翻译，已跳过");
                    continue;
                }

                string dialogueId = "TraderPelts" + text;
                if (text.Contains("pelt") || text.Contains("pelt"))
                {
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, text + "pelts...", peltTypes[text] + "皮……", Language.ChineseSimplified);
                }
                else
                {
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, text + "...", peltTypes[text] + "……", Language.ChineseSimplified);
                }
            }
        }
    }

    public class AchievementsMod
    {
        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for Achievements Mod");
            // SetText
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ACHIEVEMENTS", "成就", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kaycee's Mod Achievements", "凯茜模组成就", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Story Achievements", "剧情成就", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Achievement Unlocked", "成就已解锁", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Secret Achievement", "隐藏成就", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Revealed Once Unlocked", "解锁后显示", Language.ChineseSimplified);


        }
    }

    public class GrimoraMod
    {
        public static Dictionary<string, string> Cards = new();

        public static void RegisterCard(string en, string zh)
        {
            Cards.Add(en, zh);
        }

        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for Grimora Mod");
            // SetText
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Start Grimora Mod", "启动格里魔拉模组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "RESET RUN", "重置冒险", Language.ChineseSimplified);
            //LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NEW LESHY RUN", "新的莱西冒险", Language.ChineseSimplified);
            //LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CONTINUE LESHY RUN", "继续莱西冒险", Language.ChineseSimplified);
            //LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NEW GRIMORA RUN", "新的格里魔拉冒险", Language.ChineseSimplified);
            //LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CONTINUE GRIMORA RUN", "继续格里魔拉冒险", Language.ChineseSimplified);

            // Config
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This option will allow you to see what cards are left in your deck.", "启用此选项可查看牌组剩余卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This option will disable all effects that might cause motion sickness and other visually jarring effects.", "此选项将禁用所有可能导致晕动症或视觉不适的特效", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Does not generate blocker pieces. Chests fill first row, enemy pieces fill first column.", "开发者模式：不生成阻挡物。宝箱填充首行，敌人棋子填充首列", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Makes it so Cards that cost energy also take max energy.", "能量模式：消耗能量的卡牌将同时消耗最大能量值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If the dll is placed in BepInEx/scripts, this will allow running certain commands that should only ever be ran to re-add abilities/cards back in the game correctly.", "热重载：将dll置于BepInEx/scripts目录后，可运行特定命令以正确重载技能/卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "For players who want to continue playing with their deck after defeating Grimora.", "无尽模式：击败格里魔拉后仍可继续使用当前牌组进行游戏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "0 = Default. Use the mod's internal blueprint system.\n1 = Randomized. Encounters are completely randomized using the mod's internal card pool.\n2 = Custom. Encounters are from made and used from the JSON files.\n3 = Mixed. Encounters are from both default list and custom list.", "遭遇战配置：\n0=默认 使用模组内置方案\n1=随机 根据模组卡池完全随机生成\n2=自定义 从JSON文件读取配置\n3=混合 同时采用默认与自定义方案", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "0 = W for viewing deck, S for getting up from the table.\n1 = Up arrow for viewing deck, down arrow for getting up from the table.", "按键配置：\n0=W键查看牌组 S键离开牌桌\n1=上箭头查看道具牌组 下箭头离开牌桌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "0 = Default. Flat 50% burn rate for each lever option on second shock.\n1 = Base 30% chance to burn plus 0%, 10%, or 20% for low, medium, high, respectively. Meaning, if the first shock is high then the second is high, the chance for the card to be destroyed is 70%.\n2 = Low: 12.5%, Medium: 17.5%, High 30%. Meaning, if the first shock is high, then the second one is also high, the chance for the card to be destroyed is 60%.\n3 = Low: 12.5%, Medium: 20%, High 27.5%. Meaning, if the first shock is high, then the second one is also high, the chance for the card to be destroyed is 55%.", "电椅销毁概率：\n0=默认 第二次电击固定50%销毁率\n1=基础30%+低/中/高分别0%/10%/20% 若两次均为高强度则总概率70%\n2=低12.5% 中17.5% 高30% 两次高强度总概率60%\n3=低12.5% 中20% 高27.5% 两次高强度总概率55%", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dont change this value, it is used by the game to store certain events.", "请勿修改 该数值用于存储特定事件进度", Language.ChineseSimplified);

            // Ability
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 3 Souls to select any card on the board, [creature] will deal 1 damage to the selected card if it is an opponent card, if it isn't, [creature] will heal it for 1 health.", "消耗3个灵魂选择场上任意卡牌，若为敌方卡牌则[creature]对其造成1点伤害，否则[creature]为其恢复1点生命值。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Comin' right up!", "马上就来！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soul Shot", "灵魂冲击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 1 Soul to deal 1 damage to the creature across from [creature].", "消耗1个灵魂，可对[creature]对面的造物造成1点伤害。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Disinter", "开坟掘墓", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 1 Bone to create a Skeleton in your hand.", "消耗1根骨头来在你的手牌中创造一个骷髅。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Materialize", "魂影具象", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 2 Souls for [creature] to summon a copy in your hand.", "消耗2个灵魂使[creature]在手牌中召唤一个复制体。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 2 Souls, [creature] will trap a random opponent card in a coffin, which will release the original card again upon perishing.", "消耗2个灵魂，[creature]会将一张随机敌方卡牌封入棺木，该棺木被摧毁时将释放原卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Funeral Rites", "殡仪之棺", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soul Sucker", "噬魂者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When an opponent creature perishes, [creature] will store a charge of soul energy, up to 4. Activating this sigil will add 3 soul energy to your current energy counter, and one max energy.", "当敌方造物阵亡时，[creature]会储存1个灵魂能量（上限4个）。激活该印记可为当前能量计数器增加3点能量，并提升1点能量上限。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Weighted Die", "加权骰子", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 2 Bones for the power of [creature] to be randomized between 0 and 5.", "消耗2根骨头，使[creature]的力量随机变为0至5之间的数值。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] alternates between striking the opposing space to the left and right from it.", "[creature]会交替攻击其左右两侧的对面位置。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] is unaffected by the motion of the ship.", "[creature]不受船只移动的影响。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will strike its adjacent slots, and each opposing space to the left, right, and center of it.", "[creature]会攻击相邻位置，以及正对面的左右两侧和中间位置各一次。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] yields no bones upon death.", "[creature]死亡时不会产生骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] kills another creature, gain 2 bones.", "当[creature]击杀其他造物时，获得2根骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] takes 1 Soul from you at the end of every turn and stores it as 2 Bones, up to a maximum of 8. When [creature] dies, you gain all bones contained in it.", "[creature]在每回合结束时从你这里获取1个灵魂，并将其储存为2根骨头，最多可储存8根。当[creature]死亡时，你将获得其中储存的所有骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] empowers each Skeleton on the owner's side of the board, providing a +1 buff to their power.", "[creature]会强化持牌人侧牌桌上的所有骷髅牌，使其力量增加1点。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sea Shanty", "海洋船歌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will strike the opposing slots to the left, right, and center of it randomly, up to 3 times.", "[creature]会随机攻击正对面的左右两侧和中间位置，最多攻击3次。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] perishes, the card opposing it is Frozen Away if not already frozen.", "当[creature]阵亡时，若对面的卡牌未被冻结，则将其冰封禁锢。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] dies, gain a consumable item, if you have a free slot.", "当[creature]死亡时，若道具栏有空位，则获得一个消耗品道具。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] is played, a Skeleton is created in each empty space on the owner's side. [define:Skeleton]", "使用[creature]时，己方所有空位均会出现骷髅牌。[define:Skeleton]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeleton Horde", "骷髅军团", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Shipwreck Finder", "寻船者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] is played, a Shipwreck is created on each empty adjacent space. [define:arackulele.inscryption.grimoramod_Shipwreck_Dams]", "使用[creature]时，相邻空位均会出现沉船的浮木残骸。[define:arackulele.inscryption.grimoramod_Shipwreck_Dams]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeletons Within", "骸骨之躯", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Once [creature] is struck, draw a card from your Skeleton pile.", "[creature]受到攻击时，可从骷髅堆中抽一张牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Full o' candy", "糖果满溢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will yield candy upon death, maybe this will be useful for later.", "[creature]死亡时将掉落糖果，或许之后能派上用场。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of the owner's turn, [creature] will move in a random direction.", "持牌人回合结束时，[creature]将随机选择一个方向移动。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Whenever [creature] moves, it leaves a trail of Embers. [define:arackulele.inscryption.grimoramod_Flames]", "[creature]移动时会在路径上留下余烬轨迹。[define:arackulele.inscryption.grimoramod_Flames]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Guarding Presence", "守护者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When an opposing creature is placed opposite to an empty space, [creature] will move to that empty space.", "如对手的造物对面位置是空的，则[creature]会进入那个位置。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Starved", "骨饥者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you have no Bones, at the start of your turn [creature] deals 2 more damage.", "若你没有骨头，在你的回合开始时[creature]会造成额外2点伤害。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will strike each opposing space. If only one creature is in the opposing spaces, this card will strike that creature twice. ", "[creature]会攻击对面每个空间。若对面仅有一个造物，则该卡牌会攻击该造物两次。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Enraged Giant", "暴怒巨人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will strike each opposing space.", "[creature]会攻击对面所有位置。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fledgling", "幼雏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "After one turn on the board, [creature] will evolve into a greater form.", "[creature]在牌桌上1个回合后将进化为更强大的形态。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Random Ability", "无形之物", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] is drawn, this sigil is replaced with another sigil at random.", "抽到[creature]时，此印记将被随机替换为另一印记。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] perishes, it haunts the space it died in. The first creature played on this space gain its old sigils.", "当[creature]阵亡时，它会变成原位置的地缚灵。首个打在该位置的造物将继承它的印记。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Haunting Call", "魂牵梦萦", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every turn [creature] is on the Board, it will take a Bone from you, if you have no Bones, it perishes.", "[creature]在场时每回合会消耗你一根骨头，若你无骨头可用，该造物将阵亡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] perishes, the creature in the opposing slot is dragged onto the owner's side of the board.", "[creature]阵亡时，会将正对面位置的造物拖拽至持牌人侧牌桌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a non-brittle ally card perishes, [creature] gains 1 power.", "当不带有脆骨印记的友方造物阵亡时，[creature]增加1点力量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will strike the opposing slot as if the board was flipped. A card in the far left slot will attack the opposing far right slot.", "[creature]会以棋盘翻转后的方式攻击对面位置。位于最左侧位置的卡牌将攻击对面的最右侧位置。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] perishes, its owner chooses a creature to gain the Bonedigger sigil.", "[creature]阵亡时，其持牌人需选定下一个继承掘骨人印记的造物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] perishes, its owner chooses a creature to gain the Waterborne sigil.", "[creature]阵亡时，其持牌人需选定下一个继承水袭印记的造物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] loses 1 health per turn. When [creature] dies, the creature opposing it, as well as adjacent friendly creatures, are dealt 10 damage.", "[creature]每回合损失1点生命。当[creature]死亡时，正对面的造物以及相邻的友方造物均受到10点伤害。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] would be struck, a severed limb is created in its place and this card moves into an adjacent open slot.", "当[creature]有可能受到攻击时，会在原地留下一截断肢，[creature]自身则会移动至相邻的空位。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Each time [creature] deals damage directly, it loses 1 power and health.", "每当[creature]直接造成伤害时，会损失1点力量和1点生命。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] is played, also play the cards in your hand that were adjacent to this card for free.", "当使用[creature]时，可免费打出你手牌中与之相邻的所有卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Douse", "浇灭", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When played,[creature] will extinguish all cards on the Board.", "使用[creature]时，将熄灭牌桌上所有卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] cannot be attacked from the opposing slot. The opposing slot, if possible, instead attacks one of its adjacent friendly cards.", "[creature]无法从正对面位置被攻击。若可能，正对面位置会转而攻击其相邻的友方卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cards on the owner's side of the field are unaffected by Brittle.", "持牌人侧牌桌上的卡牌不受脆骨印记影响。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will strike its adjacent slots, except other Raiders.", "[creature]会攻击其相邻位置，但不会攻击其他劫掠之徒。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] is played, it carves its Sigils into adjacent Cards.", "使用[creature]时，其印记会铭刻到相邻卡牌上。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sculptor", "铭刻师", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] will attempt to find a host in an adjacent friendly slot, hiding under it providing a +1/+1 buff. Cards on the left take priority.", "[creature]会尝试在相邻的友方位置寻找宿主，藏身其下并提供+1/+1增益。左侧卡牌优先。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] hits an opposing card, one of the targets adjacent allies will take damage as well ", "当[creature]攻击对面卡牌时，目标相邻的一个友方单位也会受到伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When [creature] is played, it provides an energy soul to its owner.", "当使用[creature]时，能为持牌人提供一个灵魂。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HellHound's Thirst", "地狱犬之渴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A card bearing this sigil gains 1 attack for each bone the player currently has.", "带有该印记的卡牌会根据玩家当前拥有的骨头数量获得等量攻击力，每根骨头增加1点攻击力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wrath Of Halloween", "万圣之怒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A card bearing this sigil has 10 attack, 1 for each Candy Bucket Sawyer has left.", "带有该印记的卡牌拥有10点力量，索耶每剩余1个糖果桶便增加1点力量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Trusty ol' Crew", "可靠的老船员", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A card bearing this sigil gains 1 attack for every pirate on the board.", "带有该印记的卡牌会根据场上每名海盗增加1点攻击力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inanimate Attack", "死物锐击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A card bearing this sigil gains 1 attack for every card that has 0 attack on the board.", "牌桌上每存在一张0点攻击力的卡牌，带有该印记的卡牌就会获得1点攻击力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One Half Bones", "半根骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to the number of Bones that the owner has on their side of the table.", "该印记代表的数值等于持牌人侧牌桌上存在的兽骨数量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Double Death", "双重死亡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 1 Soul to add power to [creature] randomly between 1 and 6.", "消耗1个灵魂，使[creature]随机获得1至6点力量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pay 2 Bones to heal [creature] to max health.", "消耗2根骨头将[creature]治疗至满生命值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Alternating Strike", "交替打击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Anchored", "锚定", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Area Of Effect Strike", "范围打击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blood Guzzler", "鲜血吞噬者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Boneless", "无骨者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Thief", "窃骨者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bounty", "赏金猎手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Burning", "燃烧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[creature] takes 1 Damage at the end of your turn, when it gets attacked by another Card, that card gets set on fire.", "[creature]在你的回合结束时受到1点伤害；当它被其他卡牌攻击时，攻击者会被点燃", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chaos Strike", "混沌三击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cold Front", "寒流骤至", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Collector", "收藏家", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Erratic", "飘忽不定", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flame Strafe", "火焰突袭", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Giant Strike", "巨力打击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Haunter", "阴魂不散", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hook Line And Sinker", "全套诱饵", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Imbued", "灌注", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inverted Strike", "逆反打击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Latch Bone Digger", "掘骨传花", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Latch Submerge", "水袭传花", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lit Fuse", "引信", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Loose Limb", "断肢求逝", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Malnourishment", "营养不良", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Marching Dead", "行军亡者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Possessive", "占有欲", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Puppeteer", "傀儡师", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Raider", "劫掠之徒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skin Crawler", "爬肤者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Slasher", "劈砍者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spirit Bearer", "灵媒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The power of this card is equal to the number of Green Gems that the owner has on their side of the table.", "这张卡牌的力量等于持牌人侧牌桌上存在的绿宝石数量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "APPENDIX XII, SUBSECTION I - ABILITIES {0}", "附录12，第一节 - 能力{0}", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "APPENDIX XII, SUBSECTION II - VARIABLE STATS {0}", "附录,12，第二节 - 可变属性{0}", Language.ChineseSimplified);

            // Card
            RegisterCard("Skeleton", "骷髅");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The puppet becomes the puppeteer, yet still forever cursed by their dangling restraints.", "提线木偶反成操偶师，却仍被悬垂的丝线永恒诅咒。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Animator", "操偶师", Language.ChineseSimplified);
            RegisterCard("Animator", "操偶师");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A formless Creature, that yet lingers. Truly a horrific sight.", "无形无相却徘徊不去的造物。着实令人毛骨悚然。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Apparition", "幽魂", Language.ChineseSimplified);
            RegisterCard("Apparition", "幽魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Only a fool would need such assistance.", "只有蠢材才需要这种帮助。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Graven Ashes", "刻墓之烬", Language.ChineseSimplified);
            RegisterCard("Graven Ashes", "刻墓之烬");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It's foul breath doesn't concern me, it's the Tampered Coffins it leaves behind!", "它那恶臭的吐息不足为惧，真正要当心的是它留下的被动过手脚的棺材！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bal-Bal", "墓穴食尸鬼", Language.ChineseSimplified);
            RegisterCard("Bal-Bal", "墓穴食尸鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE SCREAMING TERROR. THEY GO STRAIGHT THROUGH TO ATTACK THEIR PREY.", "尖啸惊魂。它们会穿透防线直击猎物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Banshee", "女妖", Language.ChineseSimplified);
            RegisterCard("Banshee", "女妖");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bartender", "酒保", Language.ChineseSimplified);
            RegisterCard("The Bartender", "酒保");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "spent his days serving harmful cocktails for those deserving of his poisonous wrath. Doesn't regret it at all.", "终日为那些活该承受他剧毒怒火之人调制致命鸡尾酒。对此毫无悔意。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Big Bones", "巨骨", Language.ChineseSimplified);
            RegisterCard("Big Bones", "巨骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Burly Bones", "壮骨", Language.ChineseSimplified);
            RegisterCard("Burly Bones", "壮骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Beefy Bones", "蛮骨", Language.ChineseSimplified);
            RegisterCard("Beefy Bones", "蛮骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cal C. Um", "钙先生", Language.ChineseSimplified);
            RegisterCard("Cal C. Um", "钙先生");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sizeable Bones", "硕骨", Language.ChineseSimplified);
            RegisterCard("Sizeable Bones", "硕骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Considerable Bones", "庞骨", Language.ChineseSimplified);
            RegisterCard("Considerable Bones", "庞骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vigorous Bones", "劲骨", Language.ChineseSimplified);
            RegisterCard("Vigorous Bones", "劲骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hefty Bones", "重骨", Language.ChineseSimplified);
            RegisterCard("Hefty Bones", "重骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A RATHER BURLY SKELETON, IT IS VERY RICH IN CALCIUM.", "这副魁梧的骨架富含钙质。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This sack is full of body parts. Maybe you'll find something useful in there.", "这麻袋里塞满了残肢断臂。说不定能翻出些有用的东西。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bloody Sack", "血渍麻袋", Language.ChineseSimplified);
            RegisterCard("Bloody Sack", "血渍麻袋");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Collective", "骸骨集群", Language.ChineseSimplified);
            RegisterCard("Bone Collective", "骸骨集群");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THOUSANDS OF TINY BONES COALESCE INTO A HUMANOID FORM ONLY TO DISPERSE IN A CLATTERING SWARM THE NEXT MOMENT.", "万千碎骨聚成人形，转瞬又轰然溃散为噼啪作响的骨群。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "USED TO BE A VERY LOYAL DOG BACK IN THE DAY. WELL, ONE DAY HIS OWNER DIED.", "生前曾是条忠心耿耿的猎犬。直到某天，主人溘然长逝。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bonehound", "寻骨猎犬", Language.ChineseSimplified);
            RegisterCard("Bonehound", "寻骨猎犬");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SO YOU HAVE MADE IT HERE, YOU CANNOT END WHAT I HAVE STARTED, IT HAS GONE TOO FAR.", "你终究还是来了，但你无法终结我开启的一切，事态已无可挽回。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bonelord", "骨王", Language.ChineseSimplified);
            RegisterCard("The Bonelord", "骨王");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BONELORD SHEDS ITS OLD HORNS, THEY TAKE ON A LIFE OF THEIR OWN, TO ONE DAY USURP THEIR MASTER.", "骨王蜕下旧角，它们自成生命，终将反噬其主。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bonelord's Horn", "骨王的号角", Language.ChineseSimplified);
            RegisterCard("Bonelord's Horn", "骨王的号角");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NOT PARTICULARLY INSPIRING. YOU CAN HAVE IT.", "没什么特别的。拿去吧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Heap", "骨堆", Language.ChineseSimplified);
            RegisterCard("Bone Heap", "骨堆");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IF I AM TRAPPED, SO WILL YOU. YOU CANNOT END THIS.", "若我受困于此，你也休想逃脱。这场游戏永无终局。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Prince", "骨王子", Language.ChineseSimplified);
            RegisterCard("Bone Prince", "骨王子");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SHE FEEDS ON PEOPLES BREATH, MAYBE ONE IS STANDING RIGHT BEHIND YOU RIGHT NOW.", "她以人类的呼吸为食，说不定此刻就站在你身后。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Boo Hag", "阴灵女巫", Language.ChineseSimplified);
            RegisterCard("Boo Hag", "阴灵女巫");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SHE COMMANDS OTHERS WITH STRENGTH AND GLAMOUR. THEY WILL FOLLOW HER EVERYWHERE.", "她以力量与魅力统御众生，追随者们将如影随形。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Calavera Catrina", "骷髅夫人", Language.ChineseSimplified);
            RegisterCard("Calavera Catrina", "骷髅夫人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A GROUP OF SKELETONS IS CALLED A CATACOMB. THIS IS A RATHER LARGE GATHERING.", "骷髅成群谓之墓穴。眼前这支队伍规模可观。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Catacomb", "墓穴军团", Language.ChineseSimplified);
            RegisterCard("Catacomb", "墓穴军团");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Centurion", "百夫长", Language.ChineseSimplified);
            RegisterCard("Centurion", "百夫长");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A heavily armoured warrior. Last of his century, leader to none.", "身披重甲的战士。所属军团最后的幸存者，无兵可率。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Compound Fracture", "混魂碎骨", Language.ChineseSimplified);
            RegisterCard("Compound Fracture", "混魂碎骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CRUSHED BY THE ROOF OF HIS OWN HOUSE. LIVING ON AS A PILE OF GOO.", "被自家屋顶压碎。化作一滩粘液苟活。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A SPIRIT THAT TAKES THE FORM OF AN EGG. ITS PRESENCE HARMS THOSE THAT GAZE UPON IT.", "以蛋形态示人的怨灵。直视它的存在会遭受伤害。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dalgyal", "魔蛋", Language.ChineseSimplified);
            RegisterCard("Dalgyal", "魔蛋");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "FOREVER BOUND TOGETHER BY A TERRIBLE CURSE, THIS GROUP DANCES ONWARD INTO DOOM.", "这群被可怕诅咒永远束缚的舞者，正跳着迈向毁灭的舞步。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Danse Macabre", "亡灵舞者", Language.ChineseSimplified);
            RegisterCard("Danse Macabre", "亡灵舞者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Deadeye", "死人眼", Language.ChineseSimplified);
            RegisterCard("Deadeye", "死人眼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SOME SAY THIS EYE ONCE BELONGED TO AN ANCIENT GOD. IT GAZES UPON YOUR ARMY, PICKING ITS FAVORITE TO AID IT ON THE BATTLEFIELD.", "传说此眼曾属于某位远古神明。它凝视着你的军队，挑选最中意的战士为其战场助力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SOME SAY THIS HAND ONCE BELONGED TO AN ANCIENT GOD. ANYTHING IT TOUCHES ROTS. AS WITH ANYTHING THAT ENDS, IT IS ALSO A NEW BEGINNING.", "传说这只手曾属于远古神明。凡其所触之物皆会腐朽。正如万物的终结，亦意味着新的开端。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dead Hand", "死人手", Language.ChineseSimplified);
            RegisterCard("Dead Hand", "死人手");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A DOOMED FATE SHOULD DISCOURAGE ONE FROM GOING ON, AT LEAST THATS WHAT A STILL LIVING MAN WOULD TELL YOU.", "命数已尽本该令人却步，至少活人会这么劝你。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dead Man Walking", "行尸走肉", Language.ChineseSimplified);
            RegisterCard("Dead Man Walking", "行尸走肉");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "FAMED AMONG THE FOLLOWERS OF THE PHARAOH. THEY WERE BLESSED WITH ETERNAL LIFE LONG AGO.", "在法老信徒中声名显赫。它们早在久远前就被赐予了永生。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pharaoh's Pets", "法老之宠", Language.ChineseSimplified);
            RegisterCard("Pharaoh's Pets", "法老之宠");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "FOR WHOM THE BELL TOLLS? FOR WHOM THE TAP DRIPS DRY AND THE BATHWATER RUNS COLD.", "丧钟为谁而鸣？为那枯竭的水龙头与冰冷的浴水。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Death Knell", "鸣钟亡灵", Language.ChineseSimplified);
            RegisterCard("Death Knell", "鸣钟亡灵");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chime", "铃铛", Language.ChineseSimplified);
            RegisterCard("Chime", "铃铛");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This lonesome doll was returned from seas of slate and silent shores... it stares lifelessly.", "这个孤独的人偶从灰暗的海域与寂静的岸边归来……它空洞地凝视着。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Doll", "人偶", Language.ChineseSimplified);
            RegisterCard("Doll", "人偶");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HIDING IN A SUIT OF ARMOR, OR ICE, WHAT DOES IT MATTER. THIS SKELETON WON'T LAST FOREVER.", "藏身盔甲或寒冰又有何区别。这具骸骨终将腐朽。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Draugr", "尸鬼", Language.ChineseSimplified);
            RegisterCard("Draugr", "尸鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT A SAD SIGHT, NO ONE SHALL KNOW WHAT LIES AT THE BOTTOM OF THAT WELL.", "多么可悲的景象，无人知晓那井底究竟藏着什么。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Drowned Soul", "淹死鬼", Language.ChineseSimplified);
            RegisterCard("Drowned Soul", "淹死鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NO ONE KNOWS WHAT EXACTLY THE DYBBUK IS, SOME SAY IT IS BETTER LEFT UNKNOWN.", "无人知晓附鬼究竟为何物，有人说最好永远别知道。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dybbuk", "附鬼", Language.ChineseSimplified);
            RegisterCard("Dybbuk", "附鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ectoplasm", "灵质", Language.ChineseSimplified);
            RegisterCard("Ectoplasm", "灵质");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE ESSENCE OF A SPIRIT, HIDDEN IN EVERY CORNER AND EVERY SHADOW. ONCE YOU SEE ONE, YOU WILL FIND THE REST SOON ENOUGH.", "游魂之精魄，潜藏于每个角落与阴影。一旦发现其一，余者自会接踵显现。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A LIVING FAILURE, ITS KNOWLEDGE ONLY BROUGHT IT DEATH, OR AT LEAST AN APPROXIMATION OF IT.", "一个活生生的失败品，它所知晓的一切只给它带来了死亡，或者说至少是类似死亡的东西。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Boneclaw", "骨爪", Language.ChineseSimplified);
            RegisterCard("Boneclaw", "骨爪");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Boneless", "无骨者", Language.ChineseSimplified);
            RegisterCard("Boneless", "无骨者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It's Skeleton seems to have left this lifeless husk in order to achieve greater things.", "这副骷髅似乎抛弃了这具无生命的躯壳，去追寻更伟大的事业。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lesser Mummy", "次级木乃伊", Language.ChineseSimplified);
            RegisterCard("Lesser Mummy", "次级木乃伊");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A loyal servant to the Pharao, buried with him to serve eternally in death.", "法老忠实的仆从，随葬以在死后永世效忠。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Eidolon", "英灵", Language.ChineseSimplified);
            RegisterCard("Eidolon", "英灵");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A GOLEM ENCHANTED LONG AGO, BOUND TO PROTECT THE AGE OF SUN.", "远古附魔的傀儡，誓死守护太阳纪元。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "QUITE A MISCHIEVOUS SPIRIT, IT SPREADS ITS FLAMES TO CAUSE DISMAY.", "相当顽劣的精魂，它散播火焰以制造混乱。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ember Spirit", "烬魂", Language.ChineseSimplified);
            RegisterCard("Ember Spirit", "烬魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE FAMILY WISHES TO REST IN PEACE, ONLY TO BE SUMMONED AGAIN AND AGAIN IN AN ETERNAL BATTLE.", "家族渴望安息，却被迫在永恒之战中反复应召。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Walkers", "行师走人", Language.ChineseSimplified);
            RegisterCard("The Walkers", "行师走人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is said their odor is so strong and repugnant, even the undead can feel it!", "据说它们散发的恶臭如此浓烈刺鼻，就连亡灵都能闻到！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Festering Wretch", "溃烂行尸", Language.ChineseSimplified);
            RegisterCard("Festering Wretch", "溃烂行尸");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flames", "火焰", Language.ChineseSimplified);
            RegisterCard("Flames", "火焰");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flameskull", "烈焰颅骨", Language.ChineseSimplified);
            RegisterCard("Flameskull", "烈焰颅骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Always flying, always angry, always annoying nearby allies in the process.", "永远飞行，永远愤怒，永远在过程中烦扰附近的盟友。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A waterlogged sailor who carries his tragic past beside him. I don't remember the details.", "一个浑身湿透的水手，背负着悲惨的过往。具体细节我已记不清了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Forgotten Man", "遗忘者", Language.ChineseSimplified);
            RegisterCard("Forgotten Man", "遗忘者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BEST FRIENDS, BROTHERS, AND FIGHTERS.", "至交好友，手足兄弟，并肩战士。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frank & Stein", "弗兰肯和斯坦", Language.ChineseSimplified);
            RegisterCard("Frank & Stein", "弗兰肯和斯坦");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "FrankNStein", "弗兰肯和斯坦", Language.ChineseSimplified); // why becomed this after chaired?
            RegisterCard("FrankNStein", "弗兰肯和斯坦");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A ghastly guardian spirit. It's presence lingers behind as it sprints through the dark.", "阴森可怖的守护灵。它在黑暗中疾驰而过，身后残留着不散的灵体。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fylgja", "陪伴者", Language.ChineseSimplified);
            RegisterCard("Fylgja", "陪伴者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Warding Presence", "警戒之影", Language.ChineseSimplified);
            RegisterCard("Warding Presence", "警戒之影");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT CREATED THESE BONES, WAR, FAMINE OR ANOTHER TRAGEDY? It may be insignificant now, but I fear what it might become...", "这些骸骨因何而生，战争、饥荒还是其他灾祸？此刻或许微不足道，但我恐惧它将孕育之物……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mass Grave", "万人冢", Language.ChineseSimplified);
            RegisterCard("Mass Grave", "万人冢");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rising Hunger", "暴食", Language.ChineseSimplified);
            RegisterCard("Rising Hunger", "暴食");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gashadokuro", "饿死鬼", Language.ChineseSimplified);
            RegisterCard("Gashadokuro", "饿死鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE PIRATES CALL THIS SHIP THEIR HOME, EVEN IN DEATH. A SLAIN GIANTS SKULL SERVES AS THEIR FIGUREHEAD.", "海盗们将这艘船视为归宿，即便死后亦然。一颗被斩杀的巨人颅骨成了他们的船首像。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ghost Ship", "幽灵船", Language.ChineseSimplified);
            RegisterCard("Ghost Ship", "幽灵船");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Giant", "巨人", Language.ChineseSimplified);
            RegisterCard("Giant", "巨人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE FAMED RACE OF GIANTS IS SAID TO HAVE DIED OUT LONG AGO, THIS IS PROOF. TRULY A SIGHT TO BEHOLD.", "传说中的巨人族早已灭绝，此乃明证。实乃奇观。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BOUND TO EARTH, THEY CLING ON SO THEY MAY ONE DAY GET PROPER BURIAL.", "受困于尘世，他们徘徊不去只为有朝一日能得安葬。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grateful Dead", "感恩亡魂", Language.ChineseSimplified);
            RegisterCard("Grateful Dead", "感恩亡魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE LOWLY GRAVEBARD, MUSIC ALWAYS BROUGHT HIM COMFORT IN THE WORST OF TIMES. NOW, EVEN AT THE END OF THE WORLD HE SHARES HIS SONG.", "卑微的墓吟者，在最黑暗的岁月里，音乐始终是他唯一的慰藉。如今，即便世界终结，他仍吟唱着那首歌谣。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gravebard", "墓吟者", Language.ChineseSimplified);
            RegisterCard("Gravebard", "墓吟者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HE HAS SPENT HIS LIFE CARVING THESE CREATURES, THIS CARD CONTAINS A PART OF HIS SOUL.", "他穷尽一生雕琢这些造物，这张卡承载着他灵魂的一部分。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grave Carver", "刻墓人", Language.ChineseSimplified);
            RegisterCard("Grave Carver", "刻墓人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HE SPENDS HIS TIME ALONE DIGGING FOR BONES IN HOPES OF FINDING A TREASURE. JUST LIKE HIS GRANDMA BEFORE HIM.", "他独自挖掘着骨头，希望能找到宝藏，就像他祖母当年那样。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gravedigger", "掘墓人", Language.ChineseSimplified);
            RegisterCard("Gravedigger", "掘墓人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A POOR, BRUTALIZED SOUL. THEIR MYCELIA PROBES FAR INTO THE SOIL, GUIDING THEIR SPADE.", "一个饱受摧残的灵魂。其菌丝深入土壤，引导着铁锹的挖掘。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sporedigger", "掘孢人", Language.ChineseSimplified);
            RegisterCard("Sporedigger", "掘孢人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A devoted guardian spirit. Even when dispelled, it grants a protective blessing.", "忠实的守护之灵。即使被驱散，也会赐予保护祝福。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Haltia", "哈尔蒂亚", Language.ChineseSimplified);
            RegisterCard("Haltia", "哈尔蒂亚");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I advise against staring into it, you won't like what stares back.", "我建议你别盯着看——你不会喜欢回望你的东西。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Haunted Mirror", "闹鬼魔镜", Language.ChineseSimplified);
            RegisterCard("Haunted Mirror", "闹鬼魔镜");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THEY CALL HER THE RIDER OF THE APOCALYPSE. HER FLAMING BLADE CUTS THROUGH THE LIVING AND DEAD ALIKE.", "人称其为天启骑士。她的烈焰之刃能同时斩断生者与亡魂。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Headless Horseman", "无头骑士", Language.ChineseSimplified);
            RegisterCard("Headless Horseman", "无头骑士");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I WOULDN'T GET TOO CLOSE DEAR. YOU CAN'T BREAK THE HOLD FROM THE DEEPEST PITS OF HELL, ONCE IT LATCHES ON.", "亲爱的，可别靠太近。一旦被地狱最深处伸出的魔爪攫住，就再也无法挣脱了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hellhand", "地狱魔爪", Language.ChineseSimplified);
            RegisterCard("Hellhand", "地狱魔爪");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hell Hound", "地狱犬", Language.ChineseSimplified);
            RegisterCard("Hell Hound", "地狱犬");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A RABID DOG. IT KILLED ONE OF MY GHOULS.", "一条疯犬。它杀死了我的一个食尸鬼。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LEGENDS HAVE BEEN TOLD ABOUT THE LEGENDARY HYDRA, THE BEAST THAT SWALLOWS ALL AND THE BANE OF ALL THAT SAIL THE SEAS.", "关于传说中的九头蛇，流传着这样的传说：它是吞噬万物的凶兽，也是所有航海者的梦魇。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hydra", "九头蛇", Language.ChineseSimplified);
            RegisterCard("Hydra", "九头蛇");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Overtaken by it's gluttony in life, doomed to it's gluttony in death. Oddly inspires a greed for bones.", "生前被贪食吞噬，死后仍受贪欲诅咒。奇怪的是会激发对骨头的贪婪。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Jikininki", "食人鬼", Language.ChineseSimplified);
            RegisterCard("Jikininki", "食人鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Avalanche", "雪崩", Language.ChineseSimplified);
            RegisterCard("Avalanche", "雪崩");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Glacier", "冰川", Language.ChineseSimplified);
            RegisterCard("Glacier", "冰川");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I WONDER WHAT HAS BEEN FROZEN AWAY FOR SO LONG.", "我很好奇究竟是何物被冰封了如此之久。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frost Giant", "冰霜巨人", Language.ChineseSimplified);
            RegisterCard("Frost Giant", "冰霜巨人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ice Cube", "冰块", Language.ChineseSimplified);
            RegisterCard("Ice Cube", "冰块");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A CORPSE WHO DIED WITH HIS HEAD IN A GLACIAL STREAM. AFTER HIS REANIMATION, HE COULDN'T BEAR TO PART WITH THE ICE THAT HAD FORMED.", "一具将头颅浸在冰河中死去的尸体。复生后仍执意保留凝结的寒冰。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "After drowning her children and then herself, she continues to drown others.", "在溺死自己的孩子后投水自尽，如今仍在拖人下水。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "La Llorona", "哭泣女妖", Language.ChineseSimplified);
            RegisterCard("La Llorona", "哭泣女妖");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Manananggal", "魔娜娜迦", Language.ChineseSimplified);
            RegisterCard("Manananggal", "魔娜娜迦");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NO BRUTALITY SATIATES THE MANANANGGAL. WHEN YOU SEE HER SEVER FROM HER TORSO, YOU TOO WILL BE A VICTIM OF THE HUNT.", "残暴无法满足魔娜娜迦。当你目睹她腰斩分躯之时，你也将成为这场猎杀的牺牲品。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Moroi, also known as the hairy ghost. It leeches the souls from those struck down near it.", "魔洛伊，又称毛鬼。它会吸取附近阵亡者的灵魂。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Moroi", "魔洛伊", Language.ChineseSimplified);
            RegisterCard("Moroi", "魔洛伊");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HIS AGE OF GLORY IS LONG GONE, YET IT IS WHAT KEEPS HIM GOING.", "昔日荣光早已消逝，却仍支撑他蹒跚前行。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mummy Lord", "木乃伊之王", Language.ChineseSimplified);
            RegisterCard("Mummy Lord", "木乃伊之王");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ALL EFFORTS TO PRESERVE LIFE AFTER DEATH HAVE BEEN FUTILE, YET THE NECROMANCER GOES ON. HE HAS TO.", "一切延续死后生命的尝试皆属徒劳，但死灵法师仍在坚持。他必须如此。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Necromancer", "死灵法师", Language.ChineseSimplified);
            RegisterCard("Necromancer", "死灵法师");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A troublesome lake spirit that enjoys dragging others down to a watery grave.", "一个喜欢把别人拖入水底坟墓的麻烦湖灵。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Nixie", "水妖", Language.ChineseSimplified);
            RegisterCard("Nixie", "水妖");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The shambling corpse of a pale, sickly noble. it spreads it's filth as it sheds it's flesh.", "苍白病态贵族的蹒跚尸骸。它一边剥落腐肉，一边散播污秽。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Nosferat", "诺斯费拉图", Language.ChineseSimplified);
            RegisterCard("Nosferat", "诺斯费拉图");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ancient Obol", "古银币", Language.ChineseSimplified);
            RegisterCard("Ancient Obol", "古银币");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT WILL ALL MAKE SENSE SOON. THE OBOL IS OLDER THAN TIME ITSELF, AND THUS IT WILL REVEAL ITSELF IN DUE TIME.", "真相终将揭晓。这枚欧宝银币比时间本身更古老，时机成熟时自会显现真容。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One Armed Bandit", "独臂强盗", Language.ChineseSimplified);
            RegisterCard("One Armed Bandit", "独臂强盗");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Took the ten paces, that ordeal cost him an arm, and his life.", "十步试炼夺走了他一条胳膊，最终要了他的命。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT IS SAID ALL IS WELL THAT ENDS. IT IS SAID TIME IS LIKE AN OUROBOROS, IT DOES NOT END, IT ONLY REPEATS ITSELF.", "常言道善终即善。常言时间如衔尾之蛇，无始无终，唯有轮回。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ourobones", "衔骨蛇", Language.ChineseSimplified);
            RegisterCard("Ourobones", "衔骨蛇");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Plague Doctor", "瘟疫医生", Language.ChineseSimplified);
            RegisterCard("Plague Doctor", "瘟疫医生");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HE HAS DETERMINED THE UNDEAD ARE SICK WITH A TERRIBLE ILLNESS. THE ONLY CURE IS DEATH.", "他诊断出亡灵们罹患恶疾。唯一的解药就是死亡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "AN EVIL TRICKSTER, THE POLTERGEIST HAS ENJOYED THEIR DEATH VERY MUCH.", "邪恶的捣蛋鬼，恶灵非常享受自己的死亡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Poltergeist", "恶灵", Language.ChineseSimplified);
            RegisterCard("Poltergeist", "恶灵");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A suit of ancient armour in which an occult spirit has taken up residence. Her iron fist drags more creatures to the fight.", "一套被邪灵附体的古老盔甲。她的铁拳会将更多造物拖入战场。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Possessed Armour", "附魔铠甲", Language.ChineseSimplified);
            RegisterCard("Possessed Armour", "附魔铠甲");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "AN EXPERIMENT GONE WRONG, IN A FUTILE ATTEMPT TO CREATE A DANSE MACCABRE. THEY DO NOT FUNCTION TOGETHER.", "一场失败的实验，妄图创造死亡之舞却徒劳无功。它们无法协同运作。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Project", "实验体", Language.ChineseSimplified);
            RegisterCard("Project", "实验体");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You shouldnt be seeing this right now", "你不该看到这个", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Random Cards", "无形造物", Language.ChineseSimplified);
            RegisterCard("Random Cards", "无形造物");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BRINGING THE SCYTHE OF DEATH, THE REVENANT SEEKS ONLY REVENGE.", "手持死亡镰刀的复生亡灵，只为复仇而生。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Revenant", "复生亡灵", Language.ChineseSimplified);
            RegisterCard("Revenant", "复生亡灵");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ripper", "开膛手", Language.ChineseSimplified);
            RegisterCard("Ripper", "开膛手");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE RIPPER SOLVES EVERYTHING THROUGH SHEER STRENGTH. IT WILL PUNCH ANY ISSUE STRAIGHT IN THE FACE AND SOLVE IT, TOO.", "开膛手信奉暴力解决一切。它会用纯粹的蛮力粉碎所有阻碍，正面击溃任何难题。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It's a wonder this one has stayed together! Though it may lose that arm if it tries to flee.", "真是个奇迹，这家伙居然还没散架！不过要是想逃跑的话，那条胳膊可能会掉下来。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rotten", "腐尸", Language.ChineseSimplified);
            RegisterCard("Rotten", "腐尸");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Twitching Arm", "抽搐的手臂", Language.ChineseSimplified);
            RegisterCard("Twitching Arm", "抽搐的手臂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The elusive Locker.", "诡秘的储物柜", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Davy Jones Locker", "戴维·琼斯的储物柜", Language.ChineseSimplified);
            RegisterCard("Davy Jones Locker", "戴维·琼斯的储物柜");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Yellowbeard", "黄胡子", Language.ChineseSimplified);
            RegisterCard("Yellowbeard", "黄胡子");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "His songs raise the morale of only Skeletons, as no one else seems to like it.", "他的船歌只能鼓舞骷髅兵的士气，毕竟其他人都欣赏不来。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A DISTANT RELATIVE OF THE SCREAMING SKULL, HE IS NOW THE SYMBOL OF PIRACY ALL AROUND THE WORLD", "尖叫颅骨的远亲，如今已成为全球海盗的象征", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crossbones", "骷髅旗", Language.ChineseSimplified);
            RegisterCard("Crossbones", "骷髅旗");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Davy Jones", "戴维·琼斯", Language.ChineseSimplified);
            RegisterCard("Davy Jones", "戴维·琼斯");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The true captain of the crew, respected by all yet still elusive. YELLOWBEARD ALWAYS GETS MORE BOOTY THAN HE DOES.", "这位才是船员们公认的船长，备受尊敬却行踪诡秘。黄胡子那家伙捞的油水总比他多。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "MAYBE IT WASN'T THE BEST IDEA TO HOLD A BARREL FULL OF GUNPOWDER. I'M NOT SURE WETHER HE NOTICED.", "抱着满满一桶火药可能不是个好主意。我不确定他是否注意到了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Exploding Pirate", "自爆海盗", Language.ChineseSimplified);
            RegisterCard("Exploding Pirate", "自爆海盗");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "He betrayed his captain for that large hook, now he is sure to make anyone a double-crosser!", "他为了那个大钩子背叛了船长，现在他肯定能让任何人变成叛徒！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "First Mate Snag", "大副斯纳格", Language.ChineseSimplified);
            RegisterCard("First Mate Snag", "大副斯纳格");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Parrots usually make great sea-side companions, this one just ate a poisoned cracker.", "鹦鹉通常是绝佳的海滨伙伴，但这只刚吞了块毒饼干。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Polly", "波利", Language.ChineseSimplified);
            RegisterCard("Polly", "波利");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A keen eye socket allows him to attack anywhere, his musket helps too. marvelous indeed!", "敏锐的眼窝使他能攻击任意位置，火枪也功不可没。妙极！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Privateer", "私掠船长", Language.ChineseSimplified);
            RegisterCard("Privateer", "私掠船长");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Swashbuckler", "豪侠", Language.ChineseSimplified);
            RegisterCard("Swashbuckler", "豪侠");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "EMERGING FROM AN OLD EGYPTIAN TOMB, MADE TO HOUSE THE LORDS OF OLD.", "自古老埃及陵墓现世，专为供奉往昔之主而铸。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sarcophagus", "石棺", Language.ChineseSimplified);
            RegisterCard("Sarcophagus", "石棺");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Screaming Skull", "尖叫颅骨", Language.ChineseSimplified);
            RegisterCard("Screaming Skull", "尖叫颅骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ONLY PAIN AND SUFFERING, NOTHING ELSE IS FELT BY THIS SKELETAL HEAD. WHAT A PITY.", "唯有痛苦与折磨，这具骸骨头颅感受不到其他任何事物。真可悲。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A SKILLED HUNTER. DON'T TRUST YOUR EARS WHEN YOU HEAR ITS HAUNTING WHISTLE.", "技艺精湛的猎手。当你听到它那令人毛骨悚然的口哨声时，千万别相信自己的耳朵。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Silbon", "希尔邦", Language.ChineseSimplified);
            RegisterCard("Silbon", "希尔邦");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THEY HAVE LEARNED THE ANCIENT SPELL OF DEATH. YET IT IS TOO MUCH POWER TO BE WIELDED.", "它们习得了远古的死亡咒术。然而这股力量过于强大，难以驾驭。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skelemagus", "骷髅法师", Language.ChineseSimplified);
            RegisterCard("Skelemagus", "骷髅法师");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:bR]RISE MY ARMY, RIIIIIISE[c:]", "[c:bR]苏醒吧我的军团，苏——醒——！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeleton Army", "骷髅军团", Language.ChineseSimplified);
            RegisterCard("Skeleton Army", "骷髅军团");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One of the faster draws in the west, but not fast enough.", "西部最快的出枪手之一，但还不够快。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Slinger's Soul", "枪手之魂", Language.ChineseSimplified);
            RegisterCard("Slinger's Soul", "枪手之魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THEY SHOW UP OUT OF NOWHERE AND RELOCATE PEOPLE AS THEY PLEASE.", "它们凭空出现，随心所欲地转移人类。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sluagh", "幽灵鬼影", Language.ChineseSimplified);
            RegisterCard("Sluagh", "幽灵鬼影");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Trick or treat!", "不给糖就捣蛋！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Candy Bucket", "糖果桶", Language.ChineseSimplified);
            RegisterCard("Candy Bucket", "糖果桶");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HAPPY HALLOWEEN!", "万圣节快乐！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Candy Monster", "糖果怪兽", Language.ChineseSimplified);
            RegisterCard("Candy Monster", "糖果怪兽");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spectrabbit", "幽灵兔", Language.ChineseSimplified);
            RegisterCard("Spectrabbit", "幽灵兔");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE SPECTRE EMITS A FLUTE LIKE CALL, AN OMEN OF BOTH DEATH AND DESCTRUCTION", "大幽灵发出笛声般的哀鸣，既是死亡的预兆，也是毁灭的凶兆", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spectre", "大幽灵", Language.ChineseSimplified);
            RegisterCard("Spectre", "大幽灵");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "DEATH IS A CRUEL FATE. STARVATION AN EVEN CRUELER ONE. WHY DO YOU FIGHT, OH HUNGRY CHILD.", "死亡何其残酷。饥饿更甚。为何而战，饥饿的孩子。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Starved Man", "饿殍", Language.ChineseSimplified);
            RegisterCard("Starved Man", "饿殍");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HE HAS SPENT YEARS IN HIS STUDY, IN A TIRELESS ATTEMPT TO CHANGE HIS FATE. YET FATE IS A CRUEL MISTRESS.", "他在书房中耗费数年光阴，不知疲倦地试图改写命运。然而命运终究是位残酷的情人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Summoner", "召唤师", Language.ChineseSimplified);
            RegisterCard("Summoner", "召唤师");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Tampered Coffin", "捣毁之棺", Language.ChineseSimplified);
            RegisterCard("Tampered Coffin", "捣毁之棺");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dead Tree", "枯树", Language.ChineseSimplified);
            RegisterCard("Dead Tree", "枯树");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its low cost is justified only by its low stats.", "低廉的代价只配得上它贫弱的身板。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Disturbed Grave", "惊扰之墓", Language.ChineseSimplified);
            RegisterCard("Disturbed Grave", "惊扰之墓");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A LOWLY GRAVE. WHOEVER IS LAID TO REST HERE, I DO NOT KNOW.", "一座简陋的坟墓。长眠于此者，吾亦不识。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kennel", "犬舍", Language.ChineseSimplified);
            RegisterCard("Kennel", "犬舍");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Obelisk", "方尖碑", Language.ChineseSimplified);
            RegisterCard("Obelisk", "方尖碑");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Shipwreck", "沉船残骸", Language.ChineseSimplified);
            RegisterCard("Shipwreck", "沉船残骸");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flotsam", "浮木", Language.ChineseSimplified);
            RegisterCard("Flotsam", "浮木");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Water Urn", "水瓮", Language.ChineseSimplified);
            RegisterCard("Water Urn", "水瓮");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Voodoo Doll", "巫毒人偶", Language.ChineseSimplified);
            RegisterCard("Voodoo Doll", "巫毒人偶");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NOTHING... NOTHING AGAIN... NO TREASURE IS LEFT ANYMORE.", "空空如也……又是空空如也……再没有宝藏可寻了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Tomb Robber", "盗墓贼", Language.ChineseSimplified);
            RegisterCard("Tomb Robber", "盗墓贼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ephialtes", "厄菲阿尔忒斯", Language.ChineseSimplified);
            RegisterCard("Ephialtes", "厄菲阿尔忒斯");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Otis", "奥提斯", Language.ChineseSimplified);
            RegisterCard("Otis", "奥提斯");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undertaker", "掘墓人", Language.ChineseSimplified);
            RegisterCard("Undertaker", "掘墓人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "His service no longer needed, this lost soul buries without purpose..", "这个迷失的灵魂已无人需要其服务，只能漫无目的地埋葬亡者。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Walking Coffin", "行走棺椁", Language.ChineseSimplified);
            RegisterCard("Walking Coffin", "行走棺椁");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Placeholder", "占位符", Language.ChineseSimplified);
            RegisterCard("Placeholder", "占位符");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE VAMPIRE IS A CREATURE OF LEGENDS. IN REALITY, LITTLE BLOOD TO DRINK AFTER EVERYONE HAS DIED.", "传说中的吸血鬼。现实中，等人都死光了哪还有血可吸。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vampire", "吸血伯爵", Language.ChineseSimplified);
            RegisterCard("Vampire", "吸血伯爵");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vellum", "羊皮纸", Language.ChineseSimplified);
            RegisterCard("Vellum", "羊皮纸");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TO NEVER BE SATISFIED, TO ALWAYS WANT MORE. THIS SPIRIT SHALL NEVER FIND ITS PEACE.", "永不满足，贪得无厌。此怨灵永世不得安息。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vengeful Spirit", "复仇之魂", Language.ChineseSimplified);
            RegisterCard("Vengeful Spirit", "复仇之魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THIS GELID SPECTER ENVELOPS WOULD-BE ATTACKERS IN AN ICY MIST.", "这具阴冷的幽魂会用冰雾笼罩胆敢进犯之敌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Warthr", "寒霜幽魂", Language.ChineseSimplified);
            RegisterCard("Warthr", "寒霜幽魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Corrupted by the spirit of a rabid wolf. It's fury cannot be stopped.", "被狂狼之魂腐化。它的怒火无人能挡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wechuge", "威楚格", Language.ChineseSimplified);
            RegisterCard("Wechuge", "威楚格");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hideous beings that will jump out to consume freshly killed corpses. They only spare the bones of the victim.", "可怖的亡灵生物，会突然现身吞噬新鲜尸体。它们只给受害者留下骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wight", "尸鬼", Language.ChineseSimplified);
            RegisterCard("Wight", "尸鬼");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THEY WARM WITH THEIR BODIES OF LIGHT, DRAWING HOPELESS SOULS INTO THEIR BEACON, DISPELLING THEIR FRIGHT.", "它们以光之躯散发温暖，将绝望的灵魂引向灯塔，驱散恐惧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Will 'O' The Wisp", "鬼火", Language.ChineseSimplified);
            RegisterCard("Will 'O' The Wisp", "鬼火");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A FALLEN GIANTS SPINE THAT IS TRYING TO FIND A NEW HOST. REGRETTABLY, MOST CREATURES ARE QUITE SMALL.", "一具堕落巨人的脊柱，正试图寻找新宿主。遗憾的是，大多数造物体型都太小了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Writher", "扭曲者", Language.ChineseSimplified);
            RegisterCard("Writher", "扭曲者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spiny Vertebrae", "尖刺脊椎骨", Language.ChineseSimplified);
            RegisterCard("Spiny Vertebrae", "尖刺脊椎骨");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE SIMPLEST OF UNDEAD, CHARACTERIZED BY ITS ROTTEN SMELL. IT ALWAYS TRAVELS WITH OTHERS, SEEKING PROTECTION AND GUIDANCE.", "最基础的亡灵生物，浑身散发着腐烂的恶臭。总是成群结队行动，寻求庇护与指引。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Zombie", "丧尸", Language.ChineseSimplified);
            RegisterCard("Zombie", "丧尸");

            // Achievement
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grimora Mod Achievements", "格里魔拉模组成就", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grim Reminder", "恶兆", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat Kaycee and thaw at least 5 of your cards.", "击败凯茜并解冻至少5张你的卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cowards End", "懦夫末路", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat Sawyers second phase without hurting the hellhound.", "在不伤害地狱犬的情况下击败索耶的第二阶段", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Season Of Storms", "风暴季节", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat Royal and have no cards walk the plank.", "击败罗亚尔且没有卡牌被推下跳板", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Black Bird//", "黑鸟//", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Dark Slope. Defeat [redacted] without defeating [redacted].", "黑暗斜坡。在不击败[数据删除]的情况下击败[数据删除]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bonesaw", "骨锯", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "End a turn with at least 30 bones.", "在回合结束时拥有至少30根骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pile Of Skulls", "颅骨之堆", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Win with all challenges enabled and no antichallenges enabled.", "在启用所有挑战且未启用任何反挑战的情况下获胜", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dance of Doom", "末日之舞", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Witness the end of everything.", "见证万物的终结", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Spirits Way", "灵魂之路", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Reach 6 Souls by turn 3.", "在第3回合前获得6个灵魂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wail Of The Damned", "受诅者之嚎", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Use the dead hand item when your deck is empty.", "在牌组为空时使用亡者之手道具", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Something Ends...", "某事终结...", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "...Something Begins. Get an ourobones to deal 6 damage.", "...某事伊始。让衔骨蛇造成6点伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cull the weak", "剔除弱者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sacrifice an Obol with 5 sigils to the Bonelord.", "向骨王献祭一枚带有5个印记的银币", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gateway to Dis", "通往冥府之门", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Win while Hell mode is active.", "在地狱模式激活时获胜", Language.ChineseSimplified);

            // Consumable
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Horn", "骨号角", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bone Horn, drains all of your current Soul but you gain a bone for each soul consumed.", "骨号角会耗尽你当前所有的灵魂，但每消耗1个灵魂可获得1根骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gives you a bone for each of your Souls, which are spent in the process, an unfortunate, but worthwhile sacrifice.", "消耗你的全部灵魂，每消耗1个灵魂给予1根骨头。虽是不幸的牺牲，但物有所值。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dead Hand", "死人手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Dead Hand, draws you a new Hand of cards at the cost of your old one.", "死人手会以牺牲旧手牌为代价，为你抽取新的手牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The severed hand of a forgotten god, left to take on a life of its own. You know what this does.", "某位忘却之神的断掌，已自成生命。你知晓其威能", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Embalming Fluid", "防腐液", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Embalming Fluid, pour it over a card and it will gain one health and attack.", "将防腐液倒在卡牌上，可使其获得1点生命值与1点攻击力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Prepare to put a member of your army to rest, increasing its stamina and vigor as you do so!", "准备为你的军团成员进行防腐处理，在此过程中提升其耐力与活力！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gravecarvers Chisel", "墓雕师之凿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Gravecarvers chisel, select any card that has died previously to add to your hand.", "使用墓雕师之凿，可从已阵亡的卡牌中选择任意一张加入手牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A tool left behind by a mysterious creator, did he carve the gravebards statue too?", "某位神秘造物者遗留的工具，莫非墓吟者雕像也出自他手？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soul Urn", "灵魂瓮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Soul Urn, spend all of your Soul and gain maximum Soul capacity for each Soul consumed.", "灵魂瓮，消耗所有灵魂，每消耗1个灵魂可提升1点灵魂上限。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Takes all of your Soul but increases your maximum by the amount taken, a certain acquaintance of mine would call this a return on investment.", "它会取走你所有的灵魂，但会按取走量提升上限。我某位老相识管这叫投资回报。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mallet", "木槌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Mallet, Whack a Card, it will become brittle and loose 1 Hp.", "木槌，敲打卡牌使其变得脆弱并失去1点生命值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You'd think this is comical, but it is quite cruel. Injures a card and leaves it frail.", "看似滑稽实则残忍。伤害卡牌并使其变得脆弱", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Quill", "羽笔", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My very own Quill, this lets you copy any card on the field to put in your hand.", "专属羽笔，可复制场上任意卡牌加入手牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My very own tool, i will lend it to you for now. Youve seen this in action, havent you?", "此乃吾之工具，暂借于汝。汝应已见识其威能", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ship Bottle", "船之瓶", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Ship in a Bottle, fills the entire board with a scurvy Skeleton Crew.", "瓶中船，用一群坏血病骷髅船员填满整个战场。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fills the entire board with skeletons! Like a real Pirate, Royal would be proud.", "用骷髅填满整个战场！真正的海盗作风，罗亚尔会为此骄傲的。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Salty Daryl", "盐津津达瑞尔", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Browntooth Barrie", "大脏牙巴里", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bonnie Splinter", "干巴瘦斯普林特", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Freebooter Bethel", "走私鬼贝瑟尔", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crazy Oakes Hayward", "疯橡木疙瘩海沃德", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ashton Swabby", "邋遢鬼阿什顿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Plankton Braxton", "跳大海布拉顿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Yeller-eye Colby", "黄眼仁儿科尔比", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fishwife Nate", "卖鱼佬内特", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Four-finger Fred", "缺手指弗雷德", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dawg Julie", "野狗朱莉", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wicked Jones", "鬼心眼儿琼斯", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crabby Steele", "螃蟹脸斯蒂勒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Slivered Hoggy Bank", "碎裂的野猪存钱瓶", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Slivered Hoggy bank, gain 2 extra bones up to three times", "碎裂的野猪存钱瓶，最多可额外获得2根骨头，共三次", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A relic from an age forsaken, this will grant you some extra bones in a pinch", "这件被遗忘时代的遗物，能在紧要关头为你提供额外骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Slivered Hoggy Bank2", "碎裂的野猪存钱瓶2", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Slivered Hoggy bank, gain 2 extra bones, two more times", "碎裂的野猪存钱瓶，可额外获得2根骨头，剩余两次", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Slivered Hoggy Bank3", "碎裂的野猪存钱瓶3", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Slivered Hoggy bank, gain 2 extra bones, one more time", "碎裂的野猪存钱瓶，可额外获得2根骨头，剩余一次", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Trowel", "泥铲", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Trowel, dig up a random terrain and gain a few Bones.", "泥铲可随机挖掘一块地形，并获取若干骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This used to belong to a gravedigger. Digs for treasure, or Terrain. And get some Bones too for your efforts.", "这曾是掘墓人的工具。既能挖掘宝藏，亦可翻动地形，还能让你白捡几根骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bonelords Femur", "骨王的股骨", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bone Lords Femur, a mystery even to me.", "骨王的股骨，连我也参不透其中奥秘", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You have dug too far, i have let myself be used as a tool for too long. Just like i will lend you this tool, i am truly in power.", "你已掘得太深，我甘为工具的日子够久了。正如我将此物借予你那般，真正掌权者始终是我", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Revenant Bottle", "复生亡灵瓶", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Heap Bottle", "骨堆瓶", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A Revenant is created in your hand. [define:arackulele.inscryption.grimoramod_Revenant]", "你的手牌里会出现一张复生亡灵牌。[define:arackulele.inscryption.grimoramod_Revenant]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A Bone Heap is created in your hand. [define:arackulele.inscryption.grimoramod_Bonepile]", "你的手牌里会出现一张骨堆牌。[define:arackulele.inscryption.grimoramod_Bonepile]", Language.ChineseSimplified);

            // ShowUntilInput
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A [c:G]SANDSTORM[c:] IS BREWING!", "[c:G]沙暴[c:]正在酝酿！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]At the end of a turn, the rightmost Card will take 1 Damage![c:]", "[c:G]回合结束时，最右侧的卡牌将受到1点伤害！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ITS GETTING HOTTER!A [c:G]HEATWAVE[c:] IS STARTING!", "越来越热了！[c:G]热浪[c:]来袭！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]All cards on the board will burn![c:]", "[c:G]场上所有卡牌都将燃烧！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TREES START SPROUTING AROUND YOU.AN [c:G]OVERGROWTH[c:] IS INBOUND!", "树苗在你周围萌芽。[c:G]疯长[c:]即将到来！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]Trees will sprout every turn![c:]", "[c:G]每回合都会长出树木！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU HEAR WITCHES CHANTING.THE CLOCK STRIKES THE [c:G]WITCHING HOUR[c:]!", "你听到女巫在吟唱。时钟敲响了[c:G]午夜时刻[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]Cards on enchanted slots will gain more attack and health![c:]", "[c:G]位于附魔位置上的卡牌将获得更多攻击和生命！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A CAULDRON IS BUBBLING IN THE DISTANCE.YOUR CARDS ARE PUT IN THE [c:G]WITCHES CAULDRON[c:]!", "远处的大锅在沸腾。你的卡牌被投入[c:G]女巫的坩埚[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]2 Cards will swap after the end of the turn![c:]", "[c:G]回合结束后2张卡牌将交换位置！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SKELETONS START DANCING IN THE DISTANCE, YOU CAN SEE GHOSTS MOVE AROUND.ITS THE [c:G]NIGHT OF THE LIVING DEAD[c:]!", "骷髅在远处起舞，鬼影四处游荡。这是[c:G]亡灵之夜[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]Bone and soul cost of all cards are swapped![c:]", "[c:G]所有卡牌的骨头和灵魂消耗互换！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ZOMBIES ARE APPROACHING FROM ALL SIDES.A [c:G]ZOMBIE INVASION[c:] WILL APPROACH!", "丧尸从四面八方逼近。[c:G]丧尸大军[c:]即将压境！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]Every card is now a Zombie![c:]", "[c:G]所有卡牌都将变为丧尸！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE DIRT IS PLAGUED WITH SPIRITS FROM CENTURIES PAST.YOU'VE APPROACHED THE [c:G]HAUNTED GROUNDS[c:]!", "泥土中盘踞着百年怨灵。你已踏入[c:G]恶鬼缠身之地[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]Every non Skeletal Card will gain Haunter![c:]", "[c:G]所有非骷髅卡牌都将获得阴魂不散印记！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE MOON RISES, GLOWING RED.A [c:G]BLOODMOON[c:] IS STARTING!", "赤月当空，血色弥漫。[c:G]血月[c:]开始了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " [c:G]All cards loose a random sigil after being played![c:]", "[c:G]所有卡牌打出后将随机失去一个印记！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An ancient Guard stands in front of you, noticing you are trying to sneak past.", "一位古老的守卫挡在你面前，察觉到你正试图潜行通过。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You dare enter my [c:R]TOMB[c:]!Prepare for death.", "你竟敢擅闯我的[c:R]陵寝[c:]！准备受死吧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An imposing Man holding a sculpture of an Ankh blocks the way.", "一个手持安卡雕塑的威严男子挡住了去路。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My Ankh gives me life, you shall not rob my [c:R]TOMB[c:].", "安卡赐予我生命，你休想染指我的[c:R]陵寝[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An old Pharaoh climbs out of his Sarcophagus.", "一位年迈的法老正从石棺中爬出。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I have been called to protect my [c:R]TOMB[c:].", "我受召前来守护我的[c:R]陵寝[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A holy figure looms over you.", "一道神圣的身影笼罩着你。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your Fate is sealed, my [c:R]TOMB[c:] shall not be disturbed.", "你的命运已注定，我的[c:R]陵寝[c:]不容亵渎。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A LONE GRAVE SITS SOLEMNLY IN FRONT OF YOU.", "一座孤坟肃穆地矗立在你面前", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IN FRONT OF IT IS A MOUND OF EARTH, LEFT BY SOMEONE WHO'S ALREADY PASSED ON.", "坟前有一抔新土，是某位逝者留下的", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PERHAPS A MEMBER OF YOUR UNDEAD HORDE COULD [c:bR]DIG THEM UP?[c:]", "或许该派你亡灵大军中的一员来[c:bR]掘开它？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THIS WOULDN'T BE WITHOUT REPERCUSSIONS OF COURSE, AS DEATH IS NEVER PERMANENT.", "当然这并非没有代价，毕竟死亡从非永恒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE CORPSE SEEMS TO BE OF ROTTING FLESH, YOUR CARD WILL BECOME [c:bR]BRITTLE[c:], BUT [c:bR]ITS BONE COST WILL BE HALVED[c:].", "这具腐尸的血肉正在溃烂，你的卡牌会变得[c:bR]脆弱[c:]，但[c:bR]骨头消耗减半[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE CORPSE SEEMS TO BE OF A STARVED MAN, YOUR CARD WILL [c:bR]STARVE FOREVER[c:], BUT [c:bR]ITS BONE COST WILL BE REDUCED BY 2[c:].", "这具饿殍干瘪枯瘦，你的卡牌将[c:bR]永远饥渴[c:]，但[c:bR]骨头消耗减少2点[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE CORPSE SEEMS TO BE OF AN INCORPOREAL GHOST, YOUR CARD WILL [c:bR]COST 2 SOULS[c:] , BUT [c:bR]ITS BONE COST WILL BE REDUCED BY 1[c:].", "这具灵体虚无缥缈，你的卡牌需[c:bR]消耗2个灵魂[c:]，但[c:bR]骨头消耗减少1点[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE CORPSE SEEMS TO BE OF A CHAINED PRISONER, YOUR CARD WILL [c:bR]DEAL 1 MORE DAMAGE[c:] , BUT [c:bR]IT WILL BECOME VERY FRAIL[c:].", "这具囚尸带着镣铐，你的卡牌[c:bR]伤害+1[c:]，但[c:bR]会变得极其脆弱[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE CORPSE SEEMS TO BE OF A MISCHIEVIOUS SPIRIT, YOUR CARD WILL [c:bR]HAUNT OTHERS[c:] , BUT [c:bR]WILL COST 3 SOULS[c:].", "这具顽灵诡谲多变，你的卡牌将[c:bR]附身他人[c:]，但[c:bR]需消耗3个灵魂[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "MARVELOUS! THEY CAME CRAWLING BACK AFTER DIGGING UP THE CORPSE.", "妙极了！它们刨出尸体后竟爬了回来", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THEY STILL CARE ABOUT YOU IT SEEMS!", "看来它们依然心系于你！", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                string name = "[c:R]" + value + "[c:]";
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TORN FROM ITS ETERNAL RESPITE WITH A RELUCTANT GROAN, THE " + name + " SHAMBLES BACK TO ITS RIGHTFUL PLACE AMONG YOUR HORDE.", "伴随着不情愿的呻吟，" + name + "被从永恒安眠中拽出，蹒跚回归亡灵大军的行列", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ITS BONES HOLLOWED THROUGH BY THE CREATURES OF THE SOIL, LEAVING IT FEELING UNNATURAL AND UNFAMILIAR.", "它的骨骼被土中生物蛀空，显得怪异而陌生", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THOUGH THE WEIGHT OF CONSEQUENCE ALSO SEEMS LIFTED...", "不过代价的重负似乎也已消散……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems i have finally been given my turn!", "看来终于轮到我出场了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "After this i will finally be at peace.", "此役过后，我终将获得安息", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Well, it seems we will start in this frigid valley.", "好吧，看来我们要从这片冰封山谷开始了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It must be where Kaycees resides.", "这里想必就是凯茜的栖身之所", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I didn't expect to meet you here again!", "没想到会在这里再次遇见你！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems the deletion process has stalled!", "删除进程似乎停滞了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You again?", "又是你？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Well, i suppose we can go another time.", "好吧，我想我们可以改日再战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Still not deleted?", "还没被删除吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Much seems to be contained on this disk.", "这张磁盘里似乎藏着不少东西", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Perhaps the last run wasn't long enough.", "或许上次的进程持续时间还不够", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Well, im sure Kaycee has the energy for more battles.", "不过我相信凯茜还有精力继续战斗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The frigid valley, again.", "又是这片冰封山谷", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BITTER CHILL MIGHT HURT, BUT IT WON'T SLOW DOWN ", "刺骨严寒或许伤人，但休想拖慢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BLOCKED IN ALL SLOTS. NO ARMY THIS TIME.", "所有位置都被占满。这次没法召唤军队了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blocked on both sides. No Shipwrecks for the Forgotten Man.", "两侧都被挡上了。这下被遗忘者没地方放沉船了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh, I love this one!", "噢，我最喜欢这个了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Electric Chair, it allows you to harness the power of lightning itself, letting you [c:B]empower[c:] your cards with mutating abilties!", "这把电椅能让你驾驭闪电之力，为卡牌[c:B]赋能[c:]变异印记！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "However, I must warn you, it is no ordinary chair. With the ability to adjust the voltage, a higher level of course increases the unpredictability of the mutation.", "不过容我提醒，这可不是普通椅子。通过调节电压旋钮，电压越高变异结果就越难以预料。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The brave will master the current, the cowardly will blindly follow it.", "勇者驾驭电流，懦夫随波逐流。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Are you bold enough to tinker with its lever on the left, letting the voltage corrupt the selection of the sigils?", "你可有胆量拨动左侧的电压杆，让电流扭曲印记的选择？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SURELY YOUR CREATURE COULD BECOME MORE POWERFUL...", "你的造物定能变得更加强大……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BUT YOU WOULD NEED TO RISK ANOTHER MOMENT UNDER THE SHOCK.", "但你需要冒险再承受一次电击。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BONES FLEW LEFT AND RIGHT AS YOU RETREATED FROM THE SCENE.", "撤退时兽骨在你左右飞散。", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                string name = "[c:bR]" + value + "[c:]";
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU EVER SO CAREFULLY PULL THE " + name + " AWAY FROM THE ELECTRICITY AND LEAVE.", "你小心翼翼地将" + name + "从电流中抽离，转身离去。", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hello, dear challenger, we meet again!", "你好啊，亲爱的挑战者，我们又见面了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Are you ready for a good ol' fashioned [c:R]DUEL[c:]?", "准备好来场老派[c:R]决斗[c:]了吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I see, theres a third candle at play this time...", "看来这次多了第三根蜡烛呢……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I feel you have [c:bG]bested[c:] me this time...", "这次看来是你[c:bG]技高一筹[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It was an honour, either way!", "无论如何，这都是我的荣幸！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CONGRATULATIONS, YOU DID WELL.", "恭喜，你表现得很好。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LET'S SEE, THE NEXT AREA IS MY VERY OWN CRYPT.", "接下来，你将踏入我专属的墓穴。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PERHAPS YOU CAN BEAT ALL ODDS AND TRIUMPH!", "或许你能逆天改命，赢得胜利！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "T'was well thought, i believe.", "我认为，这步棋下得妙。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LETS GET RID OF THE OL' SLOTS FOR NOW!", "先把那些老旧的卡槽清空吧！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its time for a different sort of game.", "是时候换种玩法了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dont let the costs of the cards on your side of the board get above [c:R]10[c:]!", "别让你这边的卡牌费用超过[c:R]10点[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you bust, you get punished, hit the perfect [c:R]10[c:] and you shall get a reward...", "若爆牌则受罚，凑齐完美[c:R]10点[c:]则有赏...", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Was the ol' slot machine not enough for you?", "嫌那台老角子机不够刺激？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I guess we shall bring in some more heavy hitters so to say...", "看来得叫些更狠的角色出场了...", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lets get those powerhouses out of the way first!", "先把那些大家伙解决掉！", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                string key = "[c:R]" + kvp.Key + "[c:]";
                string value = "[c:R]" + kvp.Value + "[c:]";
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh dear, you've made " + key + " quite angry.", "哎呀，你把" + value + "彻底惹恼了。", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A WISE CHOICE, NOW LEAVE BEFORE THE GODS GET TOO HUNGRY", "明智的选择，趁诸神尚未饥肠辘辘速速离去", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NO? A TERRIBLE FATE WILL AWAIT YOU", "不？可怕的命运正等着你", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I FEEL WATCHED SOMEHOW", "我总觉得被什么注视着", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "AN ANCIENT ENERGY DEMANDS YOUR SACRIFICE", "一股古老的力量要求你献上祭品", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ARE YOU WILLING TO SACRIFICE ONE OF YOUR STARTING-", "你愿意牺牲一张初始卡牌吗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WAIT", "且慢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT SEEMS YOU BEAR A TERRIBLE CURSE", "看来你身负可怕的诅咒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU SHALL KEEP THE BOON, BUT FOR A FAR GREATER SACRIFICE", "你可保留奖励，但需付出更沉重的代价", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CAN YOU GIVE UP YOUR ETERNAL ASHES?", "你愿意放弃永恒之灰吗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ARE YOU WILLING TO SACRIFICE ONE OF YOUR STARTING BONES", "你愿意牺牲初始骨头储备吗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A BRAVE SOUL", "勇敢的灵魂啊", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE GODS ANSWER YOUR PRAYERS, NOW CHOOSE", "诸神回应了你的祈祷，现在做出选择吧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BOON OF THE INANIMATE", "无生者之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "AT THE START OF A BATTLE, A DEAD TREE WILL SPAWN IN ON A RANDOM SPACE ON THE BOARD", "战斗开始时，一棵枯树会随机出现在场地上", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BOON OF THE SUN KINGDOM", "太阳王国之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ON THE 4TH TURN OF A BATTLE, DRAW 2 RANDOM EGYPT CARDS", "战斗第4回合时，随机抽取2张埃及卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BOON OF REPENTANCE", "忏悔之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GAIN AN ADDITIONAL SOUL AT THE START OF A BATTLE", "战斗开始时获得1个额外灵魂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BOON OF EBONY EYES", "乌木瞳之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TERRAIN CARDS WILL PROVIDE 2 BONES ON DEATH", "地形牌被摧毁时将提供2根骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BOON OF THE ADVERSARY", "宿敌之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "AT THE START OF A BOSS BATTLE, GAIN 3 EXTRA BONES", "头目战开始时获得3根额外骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BOON OF THE SEASICK", "晕船之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "AFTER PLACING 3 CARDS, A PIRATE SKELETON WILL BE PLAYED ON A RANDOM SPACE ON THE BOARD", "放置3张牌后，一个海盗骷髅会随机出现在场地上", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BOON OF THE CUT FINGER", "断指之奖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "DRAW AN ADDITIONAL CARD AT THE START OF A BATTLE", "战斗开始时额外抽取1张牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A WISE CHOICE, NOW LEAVE BEFORE THE GODS GET TOO HUNGRY", "明智的选择，趁诸神尚未饥渴，速速离去吧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We spent a lot of time here, I'm sure you are eager to get going again!", "我们在此共度了不少时光，想必你已迫不及待要再度启程！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Gravebard bids us farewell", "墓园诗人向我们道别", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I see you would rather hold on to the ash that you have collected.", "看来你更想保留收集到的骨灰", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It still may be of use later...", "它们或许日后还能派上用场……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "And don't feel bad, the Gravebard still enjoyed your company while it lasted!", "别难过，墓园诗人很享受与你共处的时光！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Even if you wanted anything else, you are no longer able to afford it...", "即便你还想要别的什么，现在也负担不起了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Feeling sorry for you, the Gravebard offers to come with you.", "出于怜悯，墓冢诗人主动提出与你同行。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Gravebard never runs out of stories to sing about.", "墓吟者的歌谣永无止境", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "And as it so happens, they are willing to make you another offering, but they insist that you give them 6 grams of ash this time.", "恰巧他们愿再献祭品 但这次坚持要你支付6克骨灰", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Are you willing to accept their terms?.", "你可愿接受这条件", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Gravebard is able to give you one final gift, but now they are asking a much higher price of 12 grams of ash!", "墓吟者尚能赠你最后礼物 如今却索要12克骨灰高价", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Astoundingly, you have enough to pay such a fee, but are you willing to part with it?", "令人惊异 你竟有足够骨灰 可愿割舍", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Will you offer 3 Grams worth of Ash?", "可愿献上3克骨灰", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A Gravebard has set up camp here.", "一位墓吟诗人已在此扎营。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They play songs and elegies about long forgotten warriors and rulers.", "他们吟唱着关于被遗忘的战士与统治者的歌谣与挽歌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though nowadays their audience consists mostly of various ghouls.", "不过如今他们的听众多半是各类食尸鬼。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They are willing to play you a song and trade you an unknown gift in exchange for any grams of ash you happen to be carrying.", "他们愿为你演奏一曲，并用未知礼物交换你携带的任意克数骨灰。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The gravebard is willing to play you a song for an item. You have to pay in ash.", "墓吟诗人愿以物品换歌一曲。你必须支付骨灰。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "All the excess damage you have done may finally come in handy!", "你曾造成的所有过量伤害终于能派上用场了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Strum the Lute when you are ready to make a trade.", "准备交易时请拨动鲁特琴。", Language.ChineseSimplified);
            for (int price = 0; price <= 100; price++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "With " + price.ToString() + " grams of ash, they hand you a pouch, and play a song about a brave knight from the crusades.", "接过" + price.ToString() + "克骨灰后，他们递给你一个布袋，并吟唱起十字军中某位勇敢骑士的传说", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Even after a Demonic entity cursed them into a horse-like form, they were still able to liberate the lost souls trapped by the Demon!", "即便被恶魔诅咒成半人马形态，这位骑士依然解放了恶魔囚禁的迷失灵魂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh right, the pouch, let's see what's inside!", "啊对了，那个布袋——让我们看看里面装着什么", Language.ChineseSimplified);
            for (int price = 0; price <= 100; price++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "With " + price.ToString() + " grams of ash in tow, they hand you another pouch, and play a tune about a sorceress from a mythical land.", "带着你献上的" + price.ToString() + "克骨灰，他们又递来一个布袋，弹奏起神话大陆某位女巫的谣曲", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Despite pressure from a prophecy to be the hero of the land, they instead pulled from a dark tome and sided with a cloudy villain to conquer the land and find peace from fame in an unexpected way!", "尽管预言迫使她成为救世主，她却从黑暗典籍获得力量，与阴险反派联手征服大陆，以出人意料的方式摆脱盛名之累", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I almost forgot! You must be dying to know what is in the pouch!", "差点忘了！你肯定迫不及待想知道袋中之物", Language.ChineseSimplified);
            for (int price = 0; price <= 100; price++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Feeling satisfied with  " + price.ToString() + " grams of ash, they hand you a pouch, and recount the tale of 4 islands.", "对" + price.ToString() + "克骨灰心满意足后，他们递来布袋，讲述起四座岛屿的传说", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Each of the islands had a ruler fixated on a selfish goal, all except for one...", "每座岛都盘踞着执迷私欲的统治者——除却其中一位", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One island had a secluded hermit covered in moss and fungi. They surrounded themselves with beasts, and would eternally trap anyone who would wander into their forest.", "苔藓覆体的隐士盘踞孤岛，与野兽为伴，将误入森林者永远囚禁", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Another island had a mysterious wizard covered head to toe in a green fur. Their true goal remained unknown, but seemed to involve the torturing of their own subjects...", "绿毛覆体的神秘巫师占据另座岛屿，其真实目的成谜，却似以折磨臣民为乐", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The worst island however, was barely even an island at all! A metallic barge with a sleepless factory ruled by an arrogant, robotic tyrant...", "最不堪的“岛屿”实为金属驳船，傲慢的机械暴君统治着永不停歇的工厂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Which leaves the other island, a sprawling burial ground with a Crypt at the end of it. It was ruled by a woman who only wished for the power struggle to finally end...", "最后那座岛是蔓延的坟场，尽头的墓穴由只求终结权力斗争的女子统治", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh! That would happen to be me!", "哎呀！说的可不正是我", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I think we now know how that story ended.", "我想我们都已知道故事结局", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "And truthfully, the story still isn't over yet, maybe we can reach the end together!", "说实话故事尚未终结，或许我们能共同见证终章", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "That being said, you have earned this item.", "话虽如此，这件物品是你应得的", Language.ChineseSimplified);
            for (int price = 0; price <= 100; price++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Taking " + price.ToString() + " grams of ash with them, they hand you a pouch, and tell you about an ancient hunter of ghouls.", "他们收下" + price.ToString() + "克骨灰后递来布袋，讲述起古代食尸鬼猎人的故事", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though he was barely a hunter, instead he spent his time searching for something he could not obtain.", "他虽顶着猎人名号，却终日追寻不可得之物", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "In the end he found a glimpse of what he had seeked, but paid a horrible price.", "最终虽窥见所求之物，却付出了惨痛代价", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You should see whats inside that pouch.", "你该看看袋中藏着什么", Language.ChineseSimplified);
            for (int price = 0; price <= 100; price++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Taking " + price.ToString() + " grams of your ash, they hand you a pouch, and reminisce about a medic from medieval times.", "接过你献上的" + price.ToString() + "克骨灰，他们递来布袋，追忆起中世纪的某位医师", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Instead of being content with their life, they instead chased the love of their life for years.", "他不甘平淡度日，耗费数年追寻毕生挚爱", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This got them into much danger, but their friends were always there to help them out!", "此举令他屡陷险境，所幸总有挚友伸出援手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lets see what that pouch contains.", "让我们看看布袋里装着什么", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "RISE MY ARMY! RIIIIIIIIIISE!", "苏醒吧我的军团！苏——醒——！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[size:5]Otis![size:]", "[size:5]奥提斯！[size:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[size:5]Ephialtes![size:]", "[size:5]厄菲阿尔忒斯！[size:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH? FIVE LANES? HOW BOLD.", "哦？五条战线？好大的胆子。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT A SHAME", "真是遗憾", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT SEEMS YOUVE GIVEN UP YOUR REWARD FOR CHAOS", "看来你为了混乱放弃了奖赏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I CANNOT BE DEFEATED", "我不可战胜", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I ALMOST FORGOT", "我差点忘了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ALL OF THIS SUFFERING YOU CAUSED, ALL OF THIS PAIN", "你造成的所有苦难，所有痛苦", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU OUGHT TO BE REWARDED FOR ALL THAT EXCESS DAMAGE", "你该为这过量伤害获得奖赏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TAKE THIS FOR YOUR EFFORTS", "收下这份努力的回报", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT A TERRIBLE FOE, THIS WONT DEFEAT ME!", "多么可怕的对手，但这无法击败我！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT DID YOU DO. I AM DOOMED.", "你做了什么。我完蛋了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A FORMIDABLE OPPONENT, YOU DID WELL IT SEEMS.", "可敬的对手，看来你做得不错。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Minor Ashes", "次级骨灰", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Greater Ashes", "高等骨灰", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BEHOLD, MY LATEST CREATIONS! THE TWIN GIANTS!", "看啊，我最新的造物！双子巨人！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HELLO?", "有人吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We survived, but... but...", "我们活下来了，但是……但是……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Our tools did not.", "我们的工具没能幸免。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Our talents still remain, but..", "我们的才能尚在，不过……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We must do things differently.", "我们必须改变行事方式了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We cannot fuse two into one, but...", "我们无法将二者合而为一，但……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We can swap their souls, their Sigils.", "我们可以交换它们的灵魂，它们的印记。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is once again time...", "又到时间了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Time to swap the souls of your cards.", "是时候交换你卡牌的灵魂了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is time, it is...", "时候到了，是时候……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We shall work once more.", "我们将再次开工。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This will get ugly...", "场面会很难看……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Their bodies and souls, they are...", "它们的躯体和灵魂，已经……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Switched.", "调换了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They lead new lives..", "它们将迎来新生……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "With new purposes.", "肩负新的使命。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Till we meet again, one day... one day...", "直到我们重逢之日，总有一天……总有一天……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HE WILL PROVIDE A HELPFUL CURSE OR BLESSING, AS SOME CALL IT UPON YOUR ARMY IF YOU LEAVE HIM AN OFFERING.", "若你留下祭品，他会为你的军队降下祝福——也有人称之为诅咒。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I HOPE FOR YOUR SAKE HE IS FEELING GENEROUS.", "但愿他此刻心情尚佳", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BONELORD IS VERY HAPPY WITH THIS OFFERING", "骨主对此供奉甚悦", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I AM VERY THANKFUL FOR THIS", "对此我深表感激", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TAKE THIS IN RETURN, YOU CAN USE IT TO CALL ME ANYTIME", "收下此物作为回礼，你可随时用它召唤我", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU CANNOT END THIS, END ME, THAT IS", "你无法终结这一切，除非终结我", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Feeling overburdened enough with a full 3 items, you carried on.", "你背着三样沉甸甸的道具继续上路。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kaycee says it's time to freeze!", "凯茜说该冻结了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sawyer thanks you for your contribution!", "索耶感谢你的贡献！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sawyer felt bad for you.", "索耶为你感到难过", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I hope you're able to warm up next turn.", "希望下回合你能暖和起来", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wonderful! I am pleasantly surprised by your triumph against me!", "精彩！你竟能战胜我，真令我惊喜！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "...It seems you have bested this game.", "……看来你已征服了这场游戏。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "But alas, you have cheated.", "但可叹，你用了作弊手段。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'm absolutely astonished!", "我简直震惊至极！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You've gone above and beyond what I thought you were capable of!", "你展现的实力远超我的预期！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "There is no where else to go beyond this...", "此局之后已无路可进……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So I owe it to you to know the truth...", "因此我有义务让你知晓真相……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kaycee, the REAL Kaycee...", "凯茜，真正的凯茜……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I know about the Horrifying contents of the OLD_DATA.", "我知晓旧_数据中那些骇人的内容。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Surely you have looked into it too..", "想必你也曾窥探过其中……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Windows into your world's greatest evils, both past and present.", "那是窥视你们世界古今至恶的窗口。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I want to destroy it, and...", "我要摧毁它，然后……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:R]THAT IS QUITE ENOUGH[c:]", "[c:R]适可而止[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:R]IT IS TIME FOR THIS TO END.[c:]", "[c:R]是时候终结这一切了。[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "...But it seems i cannot move on just yet.", "……但我似乎还无法就此放手。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Goodbye.", "永别了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "...You wish to continue? Endlessly? Splendid!", "……你想继续？永无止境？妙极了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Please, take a card of your choosing.", "请挑选一张你中意的卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOUR WEAK SPIRITS SHALL NOT HAUNT ME NO MORE.", "你那孱弱的亡魂再也无法侵扰我了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "DEATH TOUCH WON'T HELP YOU HERE DEAR.\nI MADE THESE GIANTS SPECIAL, IMMUNE TO QUITE A FEW DIFFERENT TRICKS!", "亲爱的，死神之触在这儿可帮不了你。\n我特制的这些巨像对不少把戏都免疫呢！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE BONELORD CANNOT BE POSSESSED!", "骨王不可被附身！", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                string key = "[c:B]" + kvp.Key + "[c:]";
                string value = "[c:B]" + kvp.Value + "[c:]";
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, key + " MIGHT HAVE SOME DIFFICULTY SUBMERGING IF IT'S FROZEN SOLID!", value + "冻成冰块了可没法潜下去！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, key + " CAN'T POSSESS ANYTHING IF IT CAN'T MOVE!", value + "动都动不了还怎么附身！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, key + " WILL HAVE A HARD TIME HOOKING ANYTHING IF IT'S FROZEN SOLID!", value + "冻得梆硬还怎么甩钩子！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, key + " FINALLY! TO GET RID OF THAT FOUL SMELL!", value + "总算！能摆脱那股恶臭了！", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LETS [c:R]HEAT[c:] UP SOME CARDS!", "让我们给卡牌[c:R]加热[c:]吧！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Y-Your strikes are only making me [c:B]c-colder[c:]!", "你-你的攻击只会让我[c:B]更-更冷[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT'S TIME FOR YOUR CARDS TO FREEZE! [c:B]CHILLED[c:] TO THE BONE!", "是时候冻结你的卡牌了！[c:B]彻骨严寒[c:]！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ALL THIS [c:bB]ICE[c:] IS TAKING UP TOO MUCH SPACE!", "这些[c:bB]冰块[c:]太占地方了！", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                string key = "[c:bR]" + kvp.Key + "[c:]";
                string value = "[c:bR]" + kvp.Value + "[c:]";
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YARRRR, I WILL ENJOY THE KABOOM OF " + key, "呀哈哈哈，我会好好享受" + value + "的爆炸艺术！", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BOIL ME ORANGES, THERES A-WAVES COMIN!", "我嘞个大橙子啊，巨浪要来了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THESE WAVES WILL PUSH YE CARD OFF THE BOARD, BACK TO YER HAND!", "这些浪头会把你的卡牌冲回手牌！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THIS PIRATE CANNOT BE TAKEN BACK UP BY THE WAVES! BUT EVEN THE ZESTIEST OF PIRATES WILL BE SHAKEN UP!", "这海盗不会被浪头卷走！但就算是最生猛的海盗也会被晃得七荤八素！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Seven seas for the table!", "七大洋的牌桌在此！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH, I WILL STORE THIS BONE FOR LATER", "哦，我会把这根骨头收好以备后用", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SPARE SOME SOULS?", "施舍些灵魂吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PLEASE, WON'T YOU SPARE SOME BONES FOR A POOR GHOUL LIKE ME?", "行行好，就不能给可怜食尸鬼施舍几根骨头吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH, HOW SAD. YOUR HAMMER COULD NOT BREAK THE ICE, AND SHATTERED", "唉，真遗憾。你的锤子没能破开坚冰，反倒自己碎了一地。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THE FRAIL THING WILL SHATTER AFTER EXCESSIVE USE. THREE STRIKES, AND IT'S OUT, FOR THIS BATTLE AT LEAST.", "这脆弱的玩意儿用过头就会碎。三击过后，至少本场战斗内它就报废了。", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                string key = "[c:lGr]" + kvp.Key + "[c:]";
                string value = "[c:lGr]" + kvp.Value + "[c:]";
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh... it will be rather difficult to haunt " + key + " with their abilities at max capacity.", "噢……要让" + value + "在能力开满的状态下被附体可不太容易", Language.ChineseSimplified);
            }
            foreach (var value in Cards.Values)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH DEAR! LOOKS LIKE YOU HAVE HOOKED SOMETHING OUT OF " + value + "!", "天呐！看来你从" + value + "里钓出了什么东西", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:bB]BRRRR![c:] I'VE BEEN FREEZING FOR AGES!", "[c:bB]嘶——！[c:]我在这冻了八百辈子了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LET'S TURN UP THE [c:R]HEAT[c:] FOR A GOOD FIGHT!", "来场[c:R]热血沸腾[c:]的对决吧！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh hey, looks like I've got another shot. Hope you watched the weather forecast!", "哟，看来我又逮着机会了。但愿你看过天气预报！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH COME ON DUDE, I'M STILL [c:B]COLD![c:]", "拜托老兄，我还是好[c:B]冷[c:]啊！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LET'S FIGHT AGAIN SOON!", "咱们改日再战！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CONGRATULATIONS, YOU DID WELL.", "恭喜，你表现不错。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU HAVE DEFEATED ONE OF MY LOVELY GHOULS, YOU WILL NOW START FIGHTS WITH AN ADDITONAL BONE.", "你击败了我可爱的食尸鬼之一，现在起每场战斗开局将获得额外1根骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SAWYERS CATACOMBS ARE UP NEXT, A FILTHY PLACE WHERE LOTS ARE LAID TO REST.", "接下来是索耶家的地下墓穴，那肮脏之地埋葬着许多亡者。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HE THINKS IT IS A TERRIBLE PLACE TO BE.", "他认为那是个糟糕的去处。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "C'mon dude, where are you going? Can't handle the cold?", "别走啊老兄，这就受不了寒冷了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH, IT SEEMS I HAVE FINALLY [c:R]WARMED UP![c:]", "噢，看来我终于[c:R]热好身了！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'M STILL NOT FEELING [c:R]WARMER![c:]", "我还没完全[c:R]热活开[c:]呢！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LETS SEE HOW YOU DEAL WITH [c:bB]THIS![c:]", "让我们看看你如何应对[c:bB]这个！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Careful, the life of your next card will be on a timer.", "小心，你下一张卡牌的生命将进入倒计时。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I look forward to the [c:brnO]explosive[c:] results!", "我很期待这[c:brnO]爆炸性[c:]的结果！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your card cannot explode, how dissapointing.", "你的卡牌居然不会爆炸，真令人失望。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "VAR, I SEE YOU MADE IT TO ME SHIP CHALLENGER!", "好家伙，你竟敢登上我的船来挑战！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'VE BEEN WAITING FOR A WORTHY FIGHT!", "我正等着来场像样的对决呢！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT SEEMS A STORM IS BREWING, I HOPE ME SHIP CAN HANDLE IT", "风暴将至，但愿我的船扛得住", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH, I SEE YEE ARE SEVERELY HAUNTED!", "哈！看来你被恶灵缠得不轻啊！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "REVENANT, PACK YE BAGS, YOURE GETTING THROWN OVERBOARD!", "亡魂，收拾收拾准备喂鱼吧！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I OVERESTIMATED ME SKILL, GOOD LUCK CHALLENGER.", "高估了老身的本事，祝你好运啊挑战者。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LET'S SEE, THE NEXT AREA IS MY VERY OWN CRYPT.", "让老身瞧瞧，下一站正是老身的墓室。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PERHAPS YOU CAN BEAT ALL ODDS AND TRIUMPH!", "说不定你真能逆天改命呢！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I beat the livin' PULP out o' ye!", "我要把你打成果酱！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ME SHIP! I FEAR WE MAY BE SINKING.", "我的船！我担心咱们要沉了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PREPARE TO HOLD YEE BREATH!", "都给老子屏住呼吸！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HOLY FISHPASTE, YE FOUND DAVY JONES TREASURE", "我嘞个鱼酱啊，你居然找到了戴维·琼斯的宝藏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YARRG, TWAS JUST DA FIRST ROUND!\nLETS SEE HOW YE FARE 'GAINST ME PERSONAL SHIP AN CREW!", "呵！这才第一回合！\n看看你咋对付老子的亲兵船队！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HOW NICE OF YOU TO COME KNOCK AT MY DOORSTEP ON THIS TRULY SPOOKY DAY! DO YOU PREFER TREATS, OR TRICKS?", "在这阴森可怖的日子来敲我的门真是太好了！你是想要给糖，还是要我捣蛋？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LOOK AWAY, LOOK AWAY! IF YOU WANT TO FIGHT, GET IT OVER QUICK!", "别看这边，别看这边！想打架就速战速决！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "oh... I- I see you're here again... Please, get rid of that monster and maybe I'll find some more time for you", "哦...我-我又见到你了...拜托解决掉那个怪物，也许我就能多抽点时间陪你了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU HAVE BEATEN THE VICIOUS CANDY MONSTER AND SAVED HALLOWEEN!", "你击败了凶残的糖果怪物，拯救了万圣节！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THANKS FOR GETTING IT OVER WITH, AND DON'T EVER RETURN!", "感谢你了结这一切，永远别再回来了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NEXT UP IS ROYALS VERY OWN SHIP, THE LIMONCELLO.", "接下来是罗亚尔专属的船——柠檬琴号", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HIS TRUSTY CREW OF SWASHBUCKLERS RESIDES THERE, MAY THEY GIVE YOU A WARM WELCOME.", "他那群忠实的海盗船员驻扎于此，愿他们给你个“热情”招待", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh no... does this mean you will try again?", "噢不……这是否意味着你会再试一次？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH, HE IS GONE... WHAT A RELIEF.", "哦，他走了……可算解脱了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THANKS FOR YOUR BONES, KIND SIR!", "多谢您的骨头，好心人！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NOW THAT THAT MONSTER IS GONE, WHY DONT WE PLAY A LITTLE LONGER", "既然那怪物不在了，何不再多玩会儿呢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I HOPE YOU DONT MIND, I PAID GOOD MONEY TO PLAY THESE.", "希望你别介意，我可是花了大价钱来玩这些的", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NOT THE CANDY MONSTER! HE HAS ENOUGH OF YOUR [c:R]TRICKS![c:]", "别是糖果怪物！你的[c:R]把戏[c:]他早受够了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH NO, HE HAS ARRIVED! HE IS THIRSTY FOR YOUR [c:R]BONES![c:]", "糟了，他来了！他正渴望着你的[c:R]骨头[c:]呢！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Thank you!", "多谢了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOUUUUUUUR, PAINNNFULLLLL DEAAATHHH AWAIIITTTSSS YOUUUUUUU!", "你你你你，痛痛痛痛苦苦的死死死亡亡在等等等着你你你你！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ARRG! WALK OFF THE PLANK YEE DIRTY SCALLYWAG!!!", "啊！你这肮脏的癞疮狗，给老子跳下船板去！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My dogs will enjoy your bones!", "我的爱犬们会享用你的骨头！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A [c:bR]盗墓贼[c:]... He's only here for the riches.", "一个[c:bR]盗墓贼[c:]……他只是为了财富而来", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bonelord has been generous.\n[c:bR]" + value + "[c:] bone cost has decreased!", "骨王慷慨解囊。\n[c:bR]" + value + "[c:]的骨头消耗降低了！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bonelord has been generous.\n[c:bR]" + value + "[c:] base health has increased!", "骨王慷慨解囊。\n[c:bR]" + value + "[c:]的基础生命值提升了！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh dear, it looks like [c:bR]" + value + "[c:] bone cost has decreased!", "哎呀，看来[c:bR]" + value + "[c:]的骨头消耗降低了！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bonelord has been generous.\n[c:bR]" + value + "[c:] bone cost has decreased greatly!", "骨王慷慨解囊。\n[c:bR]" + value + "[c:]的骨头消耗大幅降低了！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bonelord has been very generous.\n[c:bR]" + value + "[c:] base health has increased greatly!", "骨王极为慷慨。\n[c:bR]" + value + "[c:]的基础生命值大幅提升了！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bonelord has been very generous.\n[c:bR]" + value + "[c:] base attack has increased!", "骨王极为慷慨。\n[c:bR]" + value + "[c:]的基础攻击力提升了！", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "... WHAT? WHY DID YOU DO THAT BONELORD?! [c:bR]INCREASING THE HEALTH OF THE ENTIRE DECK?![c:] YOU FOOL!", "……什么？骨王你为何如此？！[c:bR]竟提升整个牌组的生命值？！[c:]糊涂啊！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "... WHAT? WHY DID YOU DO THAT BONELORD?! [c:bR]DECREASING THE COST OF THE ENTIRE DECK?![c:] YOU FOOL!", "……什么？骨王你为何如此？！[c:bR]竟降低整个牌组的消耗？！[c:]糊涂啊！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU DON'T HAVE ANYMORE CARDS TO [c:bR]GAIN HP[c:], HOW SAD. NOW PLEASE LEAVE.", "你已无卡牌可[c:bR]提升生命值[c:]，真可悲。现在请离开此地。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU DON'T HAVE ANYMORE CARDS TO [c:bR]REDUCE THEIR BONE COST[c:], HOW SAD. NOW PLEASE LEAVE.", "你已无卡牌可[c:bR]降低骨头消耗[c:]，真可悲。现在请离开此地。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU DON'T HAVE ANYMORE CARDS TO [c:bR]GAIN ATTACK[c:], HOW SAD. NOW PLEASE LEAVE.", "你已无卡牌可[c:bR]提升攻击力[c:]，真可悲。现在请离开此地。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THAT'S UNFORTUNATE. YOU WERE SUPPOSED TO HAVE YOUR ENTIRE DECK DECREASED, BUT IT LOOKS LIKE THE BONELORD HAS ALREADY GIFTED YOU THAT. BEGONE!", "真不走运。本该降低你整个牌组消耗，但骨王似乎已施舍过你了。滚吧！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "THAT'S UNFORTUNATE. YOU WERE SUPPOSED TO HAVE YOUR ENTIRE DECK INCREASED, BUT IT LOOKS LIKE THE BONELORD HAS ALREADY GIFTED YOU THAT. BEGONE!", "真不走运。本该提升你整个牌组属性，但骨王似乎已施舍过你了。滚吧！", Language.ChineseSimplified);


            // ShowThenClear
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PREPARE TO BE BOARDED!", "准备接舷战！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "That hammer doesn't look very sturdy, you'll break it if you bash my ice!", "这锤子看起来不太结实，你要是砸我的冰会把它弄坏的！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "DID YOU REALLY THINK THE BONELORD WOULD LET YOU OFF THAT EASILY?!", "你真以为骨王大人会这么轻易放过你？！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LET THE [size:5][c:bR]BONELORD[c:][size:] COMMETH!", "[size:5][c:bR]骨王[c:][size:]驾到！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Choose as you will...", "随你选择吧……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Choose one.", "选一张。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is time to rest.", "该休息一下了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Go Bartender! Drink up!", "上吧，酒保！喝个痛快！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Go Undertaker! Dont scream!", "上吧，掘墓人！可别尖叫！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Go Slingers Soul! Time for a duel!", "上吧，枪手之魂！决斗时刻到了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Go One Armed Bandit! I hope i get lucky!", "上吧，独臂强盗！但愿我能走运！", Language.ChineseSimplified);
            for (int amnt = 0; amnt < 10; amnt++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your score is " + amnt.ToString() + ", acceptable.", "你的分数是" + amnt.ToString() + "，尚可。", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "our score is 10, heres your prize!", "你的分数是10，这是你的奖励！", Language.ChineseSimplified);
            for (int amnt = 11; amnt <= 100; amnt++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "our score is " + amnt.ToString() + ", too bad!", "你的分数是" + amnt.ToString() + "，真遗憾！", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SUCH A SMALL TRAP CANNOT AFFECT GIANTS.", "如此渺小的陷阱岂能困住巨人。", Language.ChineseSimplified);

            // ShowMessage
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "PUSH YOUR LUCK FOR ONE MORE ABILITY?\nOR PULL AWAY?", "赌把运气再获一个能力？\n还是见好就收？", Language.ChineseSimplified);

            // Challenge
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "No Bones", "无骨之殇", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You no longer gain the extra bones, from defeating bosses.", "击败首领后将不再获得额外骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kaycee's Kerfuffle", "凯茜的混乱", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The fourth turn of every battle, all your cards will be Frozen Away.", "每场战斗的第四回合，你所有的卡牌都将被冰封禁锢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sawyer's Showdown", "索耶的对决", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lose 1 bone every 3rd turn, if you have less than 3, gain 1 Bone", "每3回合失去1根骨头，若不足3根则获得1根骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Royal Rumble", "罗亚尔大混战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every third card you play gains the Lit Fuse sigil.", "每打出三张卡牌，第三张将获得“引信”印记", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soulless", "无魂者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeletons cost +1 Energy.", "骷髅牌需额外消耗1点能量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frail Hammer", "脆弱之锤", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Hammer gets repaired only after every Boss.", "锤子仅在每场头目战后修复", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Jammed Chair", "卡壳电椅", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The electric chair is always set to level 3.", "电椅始终设置为3级", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wilted Clover", "枯萎三叶草", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "There is only 2 Cards present at every Card chest.", "每个卡牌箱内仅存两张卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hell Mode", "地狱模式", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dont play this one, seriously. (Makes encounters Significantly Harder)", "别选这个模式，认真的。（会显著提升遭遇战难度）", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Infinite Lives", "无限命数", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You can't die. Really.", "你无法死亡。千真万确", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Safe Chair", "安全座椅", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your cards are immune to electricity of the chair.", "你的卡牌可免疫座椅电流伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Lords Mercy", "骨王之悯", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gain a Bone when you place any free Card on the Board.", "当你将任意免费卡牌放置到牌桌时，获得一根骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blessing of the Ankh", "安卡十字之赐", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Start Pharaoh Battles and Bosses with an extra starting Bone and Energy.", "在法老战与首领战时，获得额外的起始骨头与能量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vengeant Ghouls", "复仇食尸鬼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kaycee, Sawyer and Royal have new tricks up their sleeve", "凯茜、索耶和罗亚尔都藏着新把戏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "High Roller", "豪赌客", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Royal is replaced by a new face", "罗亚尔将被新面孔取代", Language.ChineseSimplified);

            // Debug
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Card Choice", "卡牌选择", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rare Card Choice", "稀有卡牌选择", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Debug Chests", "调试宝箱", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Base Mod Cards To Deck", "基础模组卡牌加入牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Custom Mod Cards To Deck", "自定义模组卡牌加入牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Debug Tools", "调试工具", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Debug Encounters", "调试遭遇战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Disable Combat Bell", "禁用换手铃", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Disable Hammer", "禁用锤子", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Disable Hand Model", "禁用手部模型", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Base Mod Cards To Hand", "基础模组卡牌加入手牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Custom Mod Cards To Hand", "自定义模组卡牌加入手牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spawn Opponent Slot 1", "生成对手1号位", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spawn Opponent Slot 2", "生成对手2号位", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spawn Opponent Slot 3", "生成对手3号位", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spawn Opponent Slot 4", "生成对手4号位", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spawn All Opponent Slots", "生成所有对手卡片位", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Start at Twin Giants", "从双子巨人处开始", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Start at Bonelord", "从骨王处开始", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Win Round", "赢得本轮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lose Round", "输掉本轮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Add Bones", "添加骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Add Energy", "添加能量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Clear Deck", "清空牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Reset Removed Pieces", "重置移除部件", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Kill Opponent Cards", "消灭对手卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Draw Main Deck", "抽主牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Draw Side Deck", "抽副牌组", Language.ChineseSimplified);

            // Credits
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cat aka Bastard Man aka Little Guy", "猫又名Bastard Man又名Little Guy", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "API Developers", "API开发者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bone Lord", "骨王", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grimora", "格里魔拉", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Old Data", "旧数据", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Thank you for playing", "感谢游玩", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Creator", "创作者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Programming", "编程", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soundtrack", "原声带", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Artwork", "美术", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Writing", "文案", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "3D Modelling", "3D建模", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Save + Items Manager", "存档与物品管理", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Additional Code", "附加代码", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SFX, Additional Art", "音效与附加美术", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Additional Art, VFX and code", "附加美术、特效与代码", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Additional Card Portraits", "附加卡牌立绘", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Attack animations", "攻击动画", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Energy Drone Game Object", "能量无人机游戏对象", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Additional Dialogue", "附加对话", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dialogue Help", "对话协助", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Boon Artwork, miscellanious work", "奖励的美术与杂项工作", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Creator of Inscryption", "《邪恶冥刻》创作者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dog", "狗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Suprisingly, also a Dog", "意外地，也是狗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cat - co-creator", "猫 - 联合创作者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "P03KCMod", "P03KC模组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magnificus Mod (3 times)", "蔓尼菲科模组（3次）", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inscryption API (Duh)", "《邪恶冥刻》API（废话）", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Obvious reasons", "显而易见的原因", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your overlord", "你的霸主", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your dearest Scrybe", "你最亲爱的冥刻者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[Redacted]", "[数据删除]", Language.ChineseSimplified);

        }
    }

    public class MagnificusMod
    {
        public static Dictionary<string, string> Cards = new();
        public static Dictionary<string, KeyValuePair<string, string>> CardsDescription = new();
        public static Dictionary<string, string> Abilities = new();

        public static void RegisterCard(string en, string zh, string desen, string deszh)
        {
            Cards.Add(en, zh);
            CardsDescription.Add(en, new KeyValuePair<string, string>(desen, deszh));
        }

        public static void RegisterAbility(string en, string zh)
        {
            Abilities.Add(en, zh);
        }

        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for Magnificus Mod");
            // SetText
            //LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "New Magnificus Run", "新的蔓尼菲科冒险", Language.ChineseSimplified);
            //LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NEW MAGNIFICUS RUN", "新的蔓尼菲科冒险", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "View Deck", "查看牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "TOWER OF MAGICKS", "魔法之塔", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GOO DUNGEON", "黏液地牢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LAVA DUNGEON", "熔岩地牢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "VOID DUNGEON", "虚空地牢", Language.ChineseSimplified);

            // Config
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Automatically unlocks every challenge and starter deck in Magnificus' Kaycees Mod. This does NOT change your magnificus challenge point value. If you have a change of heart and decide to unlock the challenges fairly, your challenge points will remain the same.", "自动解锁蔓尼菲科凯茜模组中的所有挑战与初始牌组。这不会改变你的蔓尼菲科挑战点数。若你改变主意想公平解锁挑战，你的挑战点数将保持不变。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Base wizard cards from act 2 will keep their original statlines.", "第二章的基础巫师卡牌将保持原版数值。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Use the old 2D flat card designs instead of the new 3D models.", "使用旧版2D平面卡牌设计而非新版3D模型。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Add paint splashes to the background of every card (like in the original magnificus finale).", "为所有卡牌背景添加颜料飞溅效果（如同原版蔓尼菲科终局）。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Third person perspective for magnificus' game. Disable if you want the classic first person experience.", "启用蔓尼菲科游戏的第三人称视角。若需经典第一人称体验请关闭此选项。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Show a grid around the player in tabletop mode.", "在桌面模式下显示玩家周围的网格。", Language.ChineseSimplified);

            // Ability
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blank Mox", "空白玛珂", Language.ChineseSimplified);
            RegisterAbility("Blank Mox", "空白玛珂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is drawn, it will materialize into a random Mox Crystal. \n When on another card, the card will generate a random Mox Crystal.", "抽到带有该印记的卡牌时，它会实体化为随机一种玛珂水晶。\n当该印记存在于其他卡牌上时，该卡牌会生成随机一种玛珂水晶。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undecided Mox", "无形玛珂", Language.ChineseSimplified);
            RegisterAbility("Undecided Mox", "无形玛珂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, select a mox type for this card to provide.", "当带有该印记的卡牌打出时，选择一种玛珂类型供其提供", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruby Heart", "红宝石之心", Language.ChineseSimplified);
            RegisterAbility("Ruby Heart", "红宝石之心");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil perishes, it creates a Ruby Mox in its place.", "带有该印记的卡牌阵亡时，会在原地生成一张红宝石玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sapphire Heart", "蓝宝石之心", Language.ChineseSimplified);
            RegisterAbility("Sapphire Heart", "蓝宝石之心");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil perishes, it creates a Sapphire Mox in its place.", "带有该印记的卡牌阵亡时，会在原地生成一个蓝宝石玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Marrow", "骨髓", Language.ChineseSimplified);
            RegisterAbility("Bone Marrow", "骨髓");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When one of your non-gem cards perishes, a card bearing this sigil gains 1 power, maxing out at 5.", "当你的非宝石卡牌阵亡时，带有该印记的卡牌获得1点力量，最高可叠加至5点", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stimulation", "刺激", Language.ChineseSimplified);
            RegisterAbility("Stimulation", "刺激");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of every turn, a card bearing this sigil gains 1 power, maxing out at 4.", "每回合结束时，带有该印记的卡牌增加1点力量，最高不超过4点", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stimulation (Health)", "刺激（生命）", Language.ChineseSimplified);
            RegisterAbility("Stimulation (Health)", "刺激（生命）");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of every turn, a card bearing this sigil gains 2 health, maxes out at 10.", "每回合结束时，带有该印记的卡牌获得2点生命值，上限为10点", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dead Draw", "死亡掠夺", Language.ChineseSimplified);
            RegisterAbility("Dead Draw", "死亡掠夺");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a non-gem card dies, draw a card from your deck.", "当非宝石卡牌阵亡时，从牌组中抽取一张卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Emerald Heart", "绿宝石之心", Language.ChineseSimplified);
            RegisterAbility("Emerald Heart", "绿宝石之心");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil perishes, it creates an Emerald Mox in its place.", "带有该印记的卡牌阵亡时，会在原地生成一张绿宝石玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gooey", "黏液", Language.ChineseSimplified);
            RegisterAbility("Gooey", "黏液");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is struck, the striker loses 1 attack.", "带有该印记的卡牌受到攻击时，攻击者失去1点力量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mental Gemnastics", "头脑风宝", Language.ChineseSimplified);
            RegisterAbility("Mental Gemnastics", "头脑风宝");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, draw cards from your deck based on how many Gems are on the board.", "当使用带有该印记的卡牌时，根据牌桌上宝石数量从牌组抽取相应数量的卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Loot", "劫掠者", Language.ChineseSimplified);
            RegisterAbility("Loot", "劫掠者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil deals direct damage, draw cards from your deck based on how much damage was dealt.", "当带有该印记的卡牌造成直接伤害时，根据造成的伤害数值从牌组抽取相应数量的牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Life Steal", "生命窃取", Language.ChineseSimplified);
            RegisterAbility("Life Steal", "生命窃取");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil deals direct damage, the amount dealt will be healed to the owner of this card.", "当带有该印记的卡牌造成直接伤害时，伤害值将转化为持牌人的生命恢复", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Knockback Hit", "驱时之触", Language.ChineseSimplified);
            RegisterAbility("Knockback Hit", "驱时之触");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil hits an opposing card, the opposing card will be kicked in the direction inscrybed in the sigil.", "带有该印记的卡牌击中对手卡牌时，会将对手卡牌朝印记所示方向击退", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Impaled", "长矛召唤", Language.ChineseSimplified);
            RegisterAbility("Impaled", "长矛召唤");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil perishes, it creates a Spear in its placed. A spear is defined as Sharp, 0 power, 3 health.", "带有该印记的卡牌阵亡时，会在其位置生成一柄长矛。长矛具有：0点力量，3点生命，尖刺铠甲。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magnus Mox", "至尊玛珂", Language.ChineseSimplified);
            RegisterAbility("Magnus Mox", "至尊玛珂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "While a card bearing this sigil is on the board, it provides an orange gem, a blue gem and a green gem to its owner.", "当牌桌上有带有该印记的卡牌时，可为持牌人提供橙、蓝、绿三色玛珂各一颗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Resurrection", "复活苏生", Language.ChineseSimplified);
            RegisterAbility("Resurrection", "复活苏生");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a non-gem card perishes, the dead card will be brought back to life, but this card loses 3 health.", "当非宝石卡阵亡时，这张死亡的卡牌会复活，但此卡失去3点生命值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rerolls", "骰子力量", Language.ChineseSimplified);
            RegisterAbility("Rerolls", "骰子力量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of every turn, a card bearing this sigils' base power will be increased by a random value between 0 and 3.", "每回合结束时，带有该印记的卡牌基础力量会变成0至3的随机数", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Steel Trap", "铁兽夹", Language.ChineseSimplified);
            RegisterAbility("Steel Trap", "铁兽夹");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil perishes, the opposing card also perishes.", "带有该印记的卡牌阵亡时，对面的卡牌也会同时阵亡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Shield", "宝石护盾", Language.ChineseSimplified);
            RegisterAbility("Gem Shield", "宝石护盾");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, all gems on the board gain a shield.", "使用带有该印记的卡牌时，牌桌上所有宝石均获得护盾", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Plating Work", "镀层工艺", Language.ChineseSimplified);
            RegisterAbility("Plating Work", "镀层工艺");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "While a card bearing this sigil is on the board, all gems on your side of the board gain the Sharp Quills sigil, and 2 health.", "当带有该印记的卡牌在场时，持牌人侧牌桌上所有宝石获得尖刺铠甲印记和2点生命值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Animator", "操偶师", Language.ChineseSimplified);
            RegisterAbility("Animator", "操偶师");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "While a card bearing this sigil is on the board, all non-mox cards with 0 power gain 2 power", "当带有该印记的卡牌在场时，所有力量为0的非玛珂卡牌获得2点力量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Absorber", "宝石吸收者", Language.ChineseSimplified);
            RegisterAbility("Gem Absorber", "宝石吸收者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, all gems on your side of the board will perish. For each gem absorbed, gain 1 power and 2 health.", "当带有该印记的卡牌使用时，持牌人侧牌桌上的所有宝石将被摧毁。每吸收一个宝石，获得1点力量和2点生命。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Submerge", "水袭", Language.ChineseSimplified);
            RegisterAbility("Submerge", "水袭");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of the turn, a card bearing this sigil will submerge. Upon resubmerging, this card will become a random Tentacle Card.", "回合结束时，带有该印记的卡牌会下潜。重新上浮时，该卡牌会变为随机触手卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Familiar", "使魔", Language.ChineseSimplified);
            RegisterAbility("Familiar", "使魔");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A card bearing this sigil will perish if there are no non-gem cards on the board.", "若牌桌上没有非宝石卡牌，带有该印记的卡牌将会阵亡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fading", "消逝", Language.ChineseSimplified);
            RegisterAbility("Fading", "消逝");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A card bearing this sigil will perish at the end of the turn.", "带有该印记的卡牌会在回合结束时消亡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Morph", "不定变体", Language.ChineseSimplified);
            RegisterAbility("Morph", "不定变体");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, it will mimic the card opposing it. If there is no card opposing it, this card will perish.", "当带有该印记的卡牌被使用时，会复制对面位置的卡牌。若对面无卡牌，则该卡牌会死亡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Multiplication", "矩阵乘法", Language.ChineseSimplified);
            RegisterAbility("Multiplication", "矩阵乘法");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, draw another of this card, but with a different gem cost.", "使用带有该印记的卡牌时，抽一张同名卡牌，但其宝石需求会发生变化", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Cycle", "玛珂循环", Language.ChineseSimplified);
            RegisterAbility("Mox Cycle", "玛珂循环");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of every turn, all the mox on the board will cycle into different gems.", "每回合结束时，牌桌上所有玛珂牌会循环转换为其他宝石类型", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Strafe", "玛珂掉落", Language.ChineseSimplified);
            RegisterAbility("Mox Strafe", "玛珂掉落");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of the turn, this card will move to the direction inscrybed on the sigil, and leave behind a mox.", "回合结束时，此卡牌会按照印记标记的方向突进，并在原地留下一颗随机玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Purist", "纯粹主义", Language.ChineseSimplified);
            RegisterAbility("Purist", "纯粹主义");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Any card directly opposing this one will have all it's sigils removed.", "任何直接与该卡牌对位的卡牌将失去所有印记", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Brewery", "酿造坊", Language.ChineseSimplified);
            RegisterAbility("Brewery", "酿造坊");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of every turn, you automatically draw a mox card from your side deck.", "每回合结束时，自动从副牌组抽取一张玛珂牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ignite", "引火", Language.ChineseSimplified);
            RegisterAbility("Ignite", "引火");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, every empty opposing slot will be filled with flames. A flame is defined as a 0/1, Annoying.", "当带有该印记的卡牌被使用时，所有对侧空位将被火焰填满。火焰具有：0点力量，1点生命值，惹人生厌印记。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Projection", "投影", Language.ChineseSimplified);
            RegisterAbility("Projection", "投影");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is stuck, it will move and leave behind an astral projection of itself.", "带有该印记的卡牌受击时会移动，并留下自身的星界投影", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell Book", "法术大全", Language.ChineseSimplified);
            RegisterAbility("Spell Book", "法术大全");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, draw a random spell card.", "带有该印记的卡牌打出时，随机抽取一张法术牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Scholar", "法术学者", Language.ChineseSimplified);
            RegisterAbility("Scholar", "法术学者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, draw a random one of Bleene's Books.", "带有该印记的卡牌打出时，随机抽取一本蓝绿橙大师的书", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Midas' Touch", "黄金之触", Language.ChineseSimplified);
            RegisterAbility("Midas' Touch", "黄金之触");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil attacks another card, the attacked card will lose all of it's attack and turn to gold.", "带有该印记的卡牌攻击其他卡牌时，被攻击的卡牌将失去所有力量并转化为黄金", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Made of Gold", "黄金之躯", Language.ChineseSimplified);
            RegisterAbility("Made of Gold", "黄金之躯");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil perishes, the killer will gain 2 crystals.", "带有该印记的卡牌阵亡时，击杀者将获得2颗水晶", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Summon Runes", "引爆召唤", Language.ChineseSimplified);
            RegisterAbility("Summon Runes", "引爆召唤");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, it will summon two runes beside it. A rune is defined as 0 power, 1 health, Detonator.", "当带有该印记的卡牌被使用时，会在其相邻位置召唤两个魔法炸弹符文。符文具有：0点力量、1点生命，引爆器。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell of Health", "生命咒术", Language.ChineseSimplified);
            RegisterAbility("Spell of Health", "生命咒术");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, all cards on your side of the board gain +2 health.", "当带有该印记的法术牌被使用时，持牌人侧牌桌上所有卡牌获得+2生命值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell of Attack", "攻击咒术", Language.ChineseSimplified);
            RegisterAbility("Spell of Attack", "攻击咒术");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, all cards on your side of the board gain +1 attack.", "当带有该印记的咒术被使用时，持牌人侧牌桌上所有卡牌获得+1攻击力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frost Spell", "寒霜咒", Language.ChineseSimplified);
            RegisterAbility("Frost Spell", "寒霜咒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, all cards belonging to the opponent will have their attack set to 0, but given +2 health.", "当使用带有该印记的咒术牌时，对手所有卡牌的攻击力将归零，但生命值+2", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell of Wind", "强风咒", Language.ChineseSimplified);
            RegisterAbility("Spell of Wind", "强风咒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, all cards on your side of the board will become airborne.", "当使用带有该印记的法术时，持牌人侧牌桌上的所有卡牌将获得空袭能力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruckus", "时针顺碎语", Language.ChineseSimplified);
            RegisterAbility("Ruckus", "时针顺碎语");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is played, all cards on the board will move clockwise.", "当带有该印记的卡牌被使用时，牌桌上所有卡牌均会按顺时针方向移动", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell of Water", "净水咒", Language.ChineseSimplified);
            RegisterAbility("Spell of Water", "净水咒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, every card on the board will have their sigils erased.", "当带有该印记的咒语牌被使用时，牌桌上所有卡牌的印记将被清除", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell of Flame", "火焰咒", Language.ChineseSimplified);
            RegisterAbility("Spell of Flame", "火焰咒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a side of the board, every card on that side will lose 2 health (without perishing) and have their attack increased by 1.", "选择牌桌一侧，该侧所有卡牌生命值减少2点（但不会死亡）且攻击力增加1点", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Set Ablaze", "点燃", Language.ChineseSimplified);
            RegisterAbility("Set Ablaze", "点燃");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every card on the opposite side will lose 2 health (without perishing) and have their attack increased by 1.", "对方所有卡牌将失去2点生命值（不会死亡）且攻击力增加1点", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One Time Spell", "一次性法术", Language.ChineseSimplified);
            RegisterAbility("One Time Spell", "一次性法术");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When the turn ends, a spell bearing this sigil will perish and be removed from your deck.", "当回合结束时，带有该印记的法术会阵亡并从你的牌组移除", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vase of Greed", "贪欲之壶", Language.ChineseSimplified);
            RegisterAbility("Vase of Greed", "贪欲之壶");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, discard your current hand and draw 4 new cards.", "当带有该印记的法术牌被使用时，弃掉当前手牌并抽取4张新牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gnomification", "侏儒化", Language.ChineseSimplified);
            RegisterAbility("Gnomification", "侏儒化");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a slot to summon a Gnome card in.", "选择一个空位召唤侏儒卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cursed", "诅咒", Language.ChineseSimplified);
            RegisterAbility("Cursed", "诅咒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a spell bearing this sigil is played, it will immediately perish.", "带有该印记的法术牌打出时会立即阵亡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inspiration", "灵感", Language.ChineseSimplified);
            RegisterAbility("Inspiration", "灵感");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a card to give Airborne + Looter for 1 turn.", "选择一张卡牌使其获得空袭与劫掠者效果，持续1回合", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Calculus", "微积", Language.ChineseSimplified);
            RegisterAbility("Calculus", "微积");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a card to swap stats.", "选择一张卡牌交换其属性", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rage", "狂怒", Language.ChineseSimplified);
            RegisterAbility("Rage", "狂怒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a card to kill. The opponent of the card will recieve damage equal to the amount of health the card had.", "选择一张卡牌消灭。该卡牌对面的造物将受到等同于被消灭卡牌生命值的伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fireball", "火球术", Language.ChineseSimplified);
            RegisterAbility("Fireball", "火球术");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a card to take 2 damage.", "选择一张卡牌使其受到2点伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cold to the Touch", "冰封之触", Language.ChineseSimplified);
            RegisterAbility("Cold to the Touch", "冰封之触");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigils attack another card, that card will lose 1 attack.", "带有该印记的卡牌攻击其他卡牌时，被攻击卡牌会失去1点力量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frozen", "冰封", Language.ChineseSimplified);
            RegisterAbility("Frozen", "冰封");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of each turn, this card will lose its frozen health. When all frozen health is depleted, or this card is struck, it will defrost.", "每回合结束时，该卡牌会失去冰封生命值。当冰封生命值耗尽或该卡牌受到攻击时，将解除冰封状态", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Strong Pull", "强力牵引", Language.ChineseSimplified);
            RegisterAbility("Strong Pull", "强力牵引");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every opposing card will be inclined to hit this card instead of any other.", "所有敌方卡牌都会优先攻击此卡而非其他目标", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Displacement", "置换反应", Language.ChineseSimplified);
            RegisterAbility("Displacement", "置换反应");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When a card bearing this sigil is drawn, another of this card will be added randomly into your deck", "抽到带有该印记的卡牌时，会随机将一张同名卡牌加入你的牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Reckoning", "宝石清算", Language.ChineseSimplified);
            RegisterAbility("Gem Reckoning", "宝石清算");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At the end of each turn, if the owner of this card does not control any gems, the leftmost card in your hand is discarded.", "每回合结束时，若持牌人未控有任何宝石，则弃置你手牌最左侧的卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Power", "玛珂力量", Language.ChineseSimplified);
            RegisterAbility("Mox Power", "玛珂力量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to the number of Mox Cards that the owner has on their side of the table.", "该印记代表的数值等于持牌人侧牌桌上存在的玛珂牌数量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Health", "玛珂生命", Language.ChineseSimplified);
            RegisterAbility("Mox Health", "玛珂生命");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to the number of Mox Cards that the owner has on their side of the table.", "该印记代表的数值等于持牌人侧牌桌上存在的玛珂牌数量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Candle Proximity", "烛火临近", Language.ChineseSimplified);
            RegisterAbility("Candle Proximity", "烛火临近");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to how close this card is to the Candle on the table.", "该印记代表的数值等于此卡牌与桌上蜡烛之间的距离", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Murder Power", "杀戮之力", Language.ChineseSimplified);
            RegisterAbility("Murder Power", "杀戮之力");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal the total amount of power on the opponents board.", "该印记代表的数值等于对手牌桌上所有造物的力量总和", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to half the total amount of power on your board.", "该印记代表的数值等于你牌桌上所有造物力量总和的一半", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spell Power", "法术力量", Language.ChineseSimplified);
            RegisterAbility("Spell Power", "法术力量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to total amount of spells played during this current dungeon.", "该印记代表的数值等于当前地牢中已施放的法术总数", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to total amount of spells played during the battle.", "该印记代表的数值等于战斗期间已施放的法术总数", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Counterbattery Power", "反击力量", Language.ChineseSimplified);
            RegisterAbility("Counterbattery Power", "反击力量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The value represented with this sigil will be equal to the amount of damage taken by you this battle, divided by two.", "该印记代表的数值等于本场战斗你受到的总伤害值除以二", Language.ChineseSimplified);
            foreach (Ability ability in Enum.GetValues(typeof(Ability)))
            {
                var info = AbilitiesUtil.GetInfo(ability);
                if (info == null || info.rulebookName == null || Abilities.ContainsKey(info.rulebookName))
                {
                    Debug.LogWarning($"Ability {ability} 没有有效的 info 或 rulebookName，或本身已注册，已跳过。");
                    continue;
                }
                RegisterAbility(info.rulebookName, Localization.Translate(info.rulebookName));
            }

            // Card
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox", "玛珂", Language.ChineseSimplified);
            RegisterCard("Mox", "玛珂", "its a me moxio", "是我，玛珂奥");
            RegisterCard("Ruby Mox", "红宝石玛珂", "its a me moxio", "是我，玛珂奥");
            RegisterCard("Emerald Mox", "绿宝石玛珂", "its a me moxio", "是我，玛珂奥");
            RegisterCard("Sapphire Mox", "蓝宝石玛珂", "its a me moxio", "是我，玛珂奥");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "its a me moxio", "是我，玛珂奥", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spear", "长矛", Language.ChineseSimplified);
            RegisterCard("Spear", "长矛", "ayo", "哎呦");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ayo", "哎呦", Language.ChineseSimplified);
            RegisterCard("Mage Pupil", "法师学徒", "Though weak, it can always be useful in the right situation.", "虽显羸弱，但在合适的时机总能派上用场。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though weak, it can always be useful in the right situation.", "虽显羸弱，但在合适的时机总能派上用场。", Language.ChineseSimplified);
            RegisterCard("Junior Sage", "初级贤者", "Although simple, it can prove itself to be useful.", "虽显粗浅，却也能派上用场。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Although simple, it can prove itself to be useful.", "虽显粗浅，却也能派上用场。", Language.ChineseSimplified);
            RegisterCard("Muscle Mage", "肌肉法师", "An abomination of muscles, developed from drinking too many potions of the alchemist..", "由过量饮用炼金药剂催生出的畸形肌肉造物");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An abomination of muscles, developed from drinking too many potions of the alchemist..", "由过量饮用炼金药剂催生出的畸形肌肉造物", Language.ChineseSimplified);
            RegisterCard("Green Mage", "绿色法师", "It draws its power from the mana of the mox on the board.", "它从牌桌上玛珂的法力中汲取力量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It draws its power from the mana of the mox on the board.", "它从牌桌上玛珂的法力中汲取力量", Language.ChineseSimplified);
            RegisterCard("Blue Mage", "蓝色法师", "Never doubt its utility.", "永远不要质疑它的实用性");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Never doubt its utility.", "永远不要质疑它的实用性", Language.ChineseSimplified);
            RegisterCard("Blue Sporemage", "蓝色孢子法师", "", "");
            RegisterCard("Force Mage", "强力法师", "A mage, proficient in a martial stance which allows it block nearly anything..", "精通武学架势的法师，几乎能格挡一切攻击。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A mage, proficient in a martial stance which allows it block nearly anything..", "精通武学架势的法师，几乎能格挡一切攻击。", Language.ChineseSimplified);
            RegisterCard("Gem Fiend", "宝石魔鬼", "A wretched, unstable creature of gems. It can tear through anything.", "可悲而不稳定的宝石造物。它能撕碎任何东西。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A wretched, unstable creature of gems. It can tear through anything.", "可悲而不稳定的宝石造物。它能撕碎任何东西。", Language.ChineseSimplified);
            RegisterCard("Hover Mage", "悬浮法师", "Using its spells it soars high to hit directly", "借助法术腾空而起，可直接攻击");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Using its spells it soars high to hit directly", "借助法术腾空而起，可直接攻击", Language.ChineseSimplified);
            RegisterCard("Mage Knight", "法师骑士", "An intimidating and towering defense, however requiring gems to stay stable.", "令人望而生畏的巍峨防御，但需消耗玛珂来维持稳定。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An intimidating and towering defense, however requiring gems to stay stable.", "令人望而生畏的巍峨防御，但需消耗玛珂来维持稳定。", Language.ChineseSimplified);
            RegisterCard("Orange Mage", "橙色法师", "Using its spells, it boosts the damage of all gems.", "运用他的法术，能强化所有宝石的攻击力");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Using its spells, it boosts the damage of all gems.", "运用他的法术，能强化所有宝石的攻击力", Language.ChineseSimplified);
            RegisterCard("Practice Wizard", "陪练巫师", "A lifeless practice target.. standing tall enough to block any attacks.", "无生命的练习靶标……巍然矗立，足以格挡一切攻击。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A lifeless practice target.. standing tall enough to block any attacks.", "无生命的练习靶标……巍然矗立，足以格挡一切攻击。", Language.ChineseSimplified);
            RegisterCard("Ruby Golem", "红宝石魔像", "A construct powered by Mox.As it perishes it leaves behind parts of itself.", "由玛珂供能的构装体。阵亡时会留下部分残骸");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A construct powered by Mox.As it perishes it leaves behind parts of itself.", "由玛珂供能的构装体。阵亡时会留下部分残骸", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magnus Mox", "至尊玛珂", Language.ChineseSimplified);
            RegisterCard("Magnus Mox", "至尊玛珂", "is the return of bin laden", "是本·拉登的回归");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "is the return of bin laden", "是本·拉登的回归", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wolf Familiar", "熟悉的狼", Language.ChineseSimplified);
            RegisterCard("Wolf Familiar", "熟悉的狼", "It rips into its enemies with little to no remorse.", "这头使魔撕咬敌人时几乎毫无悔意");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It rips into its enemies with little to no remorse.", "这头使魔撕咬敌人时几乎毫无悔意", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Trading Obelisk", "交易用方尖碑", Language.ChineseSimplified);
            RegisterCard("Trading Obelisk", "交易用方尖碑", "draft token aka pelt no way jose", "草稿代币，也叫“毛皮那必不可能”");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "draft token aka pelt no way jose", "草稿代币，也叫“毛皮那必不可能”", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crystal Worm", "水晶蠕虫", Language.ChineseSimplified);
            RegisterCard("Crystal Worm", "水晶蠕虫", "Its body is made out of pure mana.. Gleaming and transforming into other gems.", "它的身躯由纯粹魔力构成……闪耀着光芒并能转化为其他宝石");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its body is made out of pure mana.. Gleaming and transforming into other gems.", "它的身躯由纯粹魔力构成……闪耀着光芒并能转化为其他宝石", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Larva", "宝石幼虫", Language.ChineseSimplified);
            RegisterCard("Mox Larva", "宝石幼虫", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Beast", "宝石魔兽", Language.ChineseSimplified);
            RegisterCard("Mox Beast", "宝石魔兽", "", "");
            RegisterCard("Snowy Fir", "雪压冷杉", "", "");
            RegisterCard("Grand Fir", "大冷杉", "", "");
            RegisterCard("Stump", "树桩", "", "");
            RegisterCard("Boulder", "磐石", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Arch", "拱门", Language.ChineseSimplified);
            RegisterCard("Arch", "拱门", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pillar", "石柱", Language.ChineseSimplified);
            RegisterCard("Pillar", "石柱", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruined Pillar", "残破石柱", Language.ChineseSimplified);
            RegisterCard("Ruined Pillar", "残破石柱", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruined Arch", "残破拱门", Language.ChineseSimplified);
            RegisterCard("Ruined Arch", "残破拱门", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Techno Mage", "科技法师", Language.ChineseSimplified);
            RegisterCard("Techno Mage", "科技法师", "sponsored by me", "由我赞助");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "sponsored by me", "由我赞助", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Necro Mage", "亡灵法师", Language.ChineseSimplified);
            RegisterCard("Necro Mage", "亡灵法师", "sponsored by me again", "再次由我赞助");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "sponsored by me again", "再次由我赞助", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ouroberyl", "衔宝蛇", Language.ChineseSimplified);
            RegisterCard("Ouroberyl", "衔宝蛇", "It gleams and takes different forms.. How majestic..", "它闪烁着光芒，形态万千……何等威严……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It gleams and takes different forms.. How majestic..", "它闪烁着光芒，形态万千……何等威严……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spellcaster", "法术大使", Language.ChineseSimplified);
            RegisterCard("Spellcaster", "法术大使", "It reads out spells from its book and casts them directly to your hand.", "它会从书中诵读咒语，并直接施放到你的手牌中。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It reads out spells from its book and casts them directly to your hand.", "它会从书中诵读咒语，并直接施放到你的手牌中。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chaos Magician", "混沌法师", Language.ChineseSimplified);
            RegisterCard("Chaos Magician", "混沌法师", "A scholar proficient in Chaos Theory, channeling a scramble unto the entire board.", "精通混沌理论的学者，能将全场搅得天翻地覆");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A scholar proficient in Chaos Theory, channeling a scramble unto the entire board.", "精通混沌理论的学者，能将全场搅得天翻地覆", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magic Spell", "魔法咒印", Language.ChineseSimplified);
            RegisterCard("Magic Spell", "魔法咒印", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Detonator", "宝石引爆者", Language.ChineseSimplified);
            RegisterCard("Gem Detonator", "宝石引爆者", "It went berserk after hearing mysterious whispers in a crypt.", "它在墓穴中听到神秘低语后陷入了狂暴");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It went berserk after hearing mysterious whispers in a crypt.", "它在墓穴中听到神秘低语后陷入了狂暴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "he", "他", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "its he.", "正是他", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Homunculus", "人造人", Language.ChineseSimplified);
            RegisterCard("Homunculus", "人造人", "A strange, to say the least creature.", "至少可以说，这是个奇怪的造物");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A strange, to say the least creature.", "至少可以说，这是个奇怪的造物", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mimagius", "幻形兽", Language.ChineseSimplified);
            RegisterCard("Mimagius", "幻形兽", "It distorts itself into the form of the opposing card.", "它会扭曲变形为对面卡牌的模样");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It distorts itself into the form of the opposing card.", "它会扭曲变形为对面卡牌的模样", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Deflector", "偏转器", Language.ChineseSimplified);
            RegisterCard("Deflector", "偏转器", "You would not want to end up on the wrong side of it..", "你不会想站错边的……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You would not want to end up on the wrong side of it..", "你不会想站错边的……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Auspex", "占星师", Language.ChineseSimplified);
            RegisterCard("Auspex", "占星师", "It harnesses the power of the stars for you..", "它能为你汲取星辰之力");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It harnesses the power of the stars for you..", "它能为你汲取星辰之力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Astral Sorcerer", "星界巫师", Language.ChineseSimplified);
            RegisterCard("Astral Sorcerer", "星界巫师", "A sorcerer proficient in summoning astral projections to protect itself when in danger", "擅长在危急时刻召唤星界投影保护自身的巫师");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A sorcerer proficient in summoning astral projections to protect itself when in danger", "擅长在危急时刻召唤星界投影保护自身的巫师", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Astral Projection", "星体投影", Language.ChineseSimplified);
            RegisterCard("Astral Projection", "星体投影", "real", "真实");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "real", "真实", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Trinket Bearer", "道具商", Language.ChineseSimplified);
            RegisterCard("Trinket Bearer", "道具商", "A mischevious little goblin creature. It carries around valueables in its backpack.", "鬼鬼祟祟的小妖精。它总在背包里藏着些值钱玩意儿。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A mischevious little goblin creature. It carries around valueables in its backpack.", "鬼鬼祟祟的小妖精。它总在背包里藏着些值钱玩意儿。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Backpack", "背包", Language.ChineseSimplified);
            RegisterCard("Backpack", "背包", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stimbot", "刺激机器人", Language.ChineseSimplified);
            RegisterCard("Stimbot", "刺激机器人", "Powered by stimulation, and steam..", "由刺激与蒸汽驱动");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Powered by stimulation, and steam..", "由刺激与蒸汽驱动", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magimorph", "变形法师", Language.ChineseSimplified);
            RegisterCard("Magimorph", "变形法师", "Its disgusting gooey body warps and distorts into distant forms. It's wonderous if you look at it right.", "它那令人作呕的黏稠身躯扭曲变形为各种形态。若以正确方式观察，反而显得奇妙非凡。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its disgusting gooey body warps and distorts into distant forms. It's wonderous if you look at it right.", "它那令人作呕的黏稠身躯扭曲变形为各种形态。若以正确方式观察，反而显得奇妙非凡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Performer", "表演者", Language.ChineseSimplified);
            RegisterCard("Performer", "表演者", "Watch it create a rabbit out of its wand..", "看它从魔杖中变出一只兔子。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Watch it create a rabbit out of its wand..", "看它从魔杖中变出一只兔子。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Senior Sage", "高级贤者", Language.ChineseSimplified);
            RegisterCard("Senior Sage", "高级贤者", "A Junior Sage that has mastered the art of Magicks.", "掌握魔法技艺的初级贤者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A Junior Sage that has mastered the art of Magicks.", "掌握魔法技艺的初级贤者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sapphire Mech", "蓝宝石机甲", Language.ChineseSimplified);
            RegisterCard("Sapphire Mech", "蓝宝石机甲", "A mage-like automaton piloted by a sapphire mox.. Admirable.", "由蓝宝石玛珂驱动的类法师自动机……令人赞叹。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A mage-like automaton piloted by a sapphire mox.. Admirable.", "由蓝宝石玛珂驱动的类法师自动机……令人赞叹。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruby Titan", "红宝石泰坦", Language.ChineseSimplified);
            RegisterCard("Ruby Titan", "红宝石泰坦", "A perfected construct of a ruby golem, a monstrous machine of destruction.", "红宝石魔像的完美造物，一台恐怖的毁灭机器");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A perfected construct of a ruby golem, a monstrous machine of destruction.", "红宝石魔像的完美造物，一台恐怖的毁灭机器", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bleene's Scholar", "蓝绿橙的学徒", Language.ChineseSimplified);
            RegisterCard("Bleene's Scholar", "蓝绿橙的学徒", "A scholar in training, currently studying the works of Master Bleene.", "受训中的学者，正在研习蓝绿橙大师的著作");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A scholar in training, currently studying the works of Master Bleene.", "受训中的学者，正在研习蓝绿橙大师的著作", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Goranj's Warrior", "绿橙蓝的战士", Language.ChineseSimplified);
            RegisterCard("Goranj's Warrior", "绿橙蓝的战士", "A foe mentored by Master Goranj, proficient at dual striking.", "由绿橙蓝大师指导的敌人，擅长双重攻击");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A foe mentored by Master Goranj, proficient at dual striking.", "由绿橙蓝大师指导的敌人，擅长双重攻击", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cider Mage", "苹果酒法师", Language.ChineseSimplified);
            RegisterCard("Cider Mage", "苹果酒法师", "This mage has a secret formula of cider that nullifies the opponents spells..", "该法师掌握着能无效化敌方法术的苹果酒秘方");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This mage has a secret formula of cider that nullifies the opponents spells..", "该法师掌握着能无效化敌方法术的苹果酒秘方", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Brewer Sage", "酿造贤者", Language.ChineseSimplified);
            RegisterCard("Brewer Sage", "酿造贤者", "A sage, sitting still and perfecting his art of brewing..", "一位静坐冥想的贤者，正精进其酿造技艺");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A sage, sitting still and perfecting his art of brewing..", "一位静坐冥想的贤者，正精进其酿造技艺", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soda Mage", "碳酸法师", Language.ChineseSimplified);
            RegisterCard("Soda Mage", "碳酸法师", "This pathetic mage melted away from drinking too much carbonated liquid..", "这个可悲的法师因饮用过多碳酸饮料而融化了");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This pathetic mage melted away from drinking too much carbonated liquid..", "这个可悲的法师因饮用过多碳酸饮料而融化了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Whitesmith", "神宝工匠", Language.ChineseSimplified);
            RegisterCard("Whitesmith", "神宝工匠", "Their life's work was dedicated to reinforcing gems.", "他们毕生致力于强化玛珂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Their life's work was dedicated to reinforcing gems.", "他们毕生致力于强化玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Puppeteer", "傀儡师", Language.ChineseSimplified);
            RegisterCard("Puppeteer", "傀儡师", "Its mastery of control magicks lets even Practice Wizards contribute.", "它精通的操控魔法能让陪练巫师也派上用场");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its mastery of control magicks lets even Practice Wizards contribute.", "它精通的操控魔法能让陪练巫师也派上用场", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Juggler", "杂耍者", Language.ChineseSimplified);
            RegisterCard("Juggler", "杂耍者", "It juggles around your mox cards, as if they were juggling balls..", "它会像杂耍球般摆弄你的玛珂牌");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It juggles around your mox cards, as if they were juggling balls..", "它会像杂耍球般摆弄你的玛珂牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Joker", "小丑", Language.ChineseSimplified);
            RegisterCard("Joker", "小丑", "Dedicated to the art of fun.. though most only find it annoying.", "执着于搞笑的艺术……尽管多数人只觉得它烦人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dedicated to the art of fun.. though most only find it annoying.", "执着于搞笑的艺术……尽管多数人只觉得它烦人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Valkyrie", "女武神", Language.ChineseSimplified);
            RegisterCard("Valkyrie", "女武神", "A student that has trained under Master Orlu. It has become an expert in airborne magicks.", "师从橙蓝绿大师的学徒。已精通空战魔法。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A student that has trained under Master Orlu. It has become an expert in airborne magicks.", "师从橙蓝绿大师的学徒。已精通空战魔法。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Valkyrie Thief", "女武神盗贼", Language.ChineseSimplified);
            RegisterCard("Valkyrie Thief", "女武神盗贼", "liar liar chicken friar.", "骗子骗子鸡毛掸子");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "liar liar chicken friar.", "骗子骗子鸡毛掸子", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Emerald Maniac", "绿宝石狂徒", Language.ChineseSimplified);
            RegisterCard("Emerald Maniac", "绿宝石狂徒", "A crazed maniac.. Drawing out health from the mox..", "疯狂的暴徒……能从玛珂中汲取生命能量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A crazed maniac.. Drawing out health from the mox..", "疯狂的暴徒……能从玛珂中汲取生命能量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruby Daemon", "红宝石恶魔", Language.ChineseSimplified);
            RegisterCard("Ruby Daemon", "红宝石恶魔", "If not properly sustained, it will destroy your hand to fuel itself..", "若未能持续供给，它将摧毁你的手牌以维持自身");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If not properly sustained, it will destroy your hand to fuel itself..", "若未能持续供给，它将摧毁你的手牌以维持自身", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Friend", "宝石之友", Language.ChineseSimplified);
            RegisterCard("Gem Friend", "宝石之友", "fren", "友");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "fren", "友", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Druid", "德鲁伊", Language.ChineseSimplified);
            RegisterCard("Druid", "德鲁伊", "Just look at what you've done..", "看看你都干了些什么……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just look at what you've done..", "看看你都干了些什么……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chained Legs", "链锁之腿", Language.ChineseSimplified);
            RegisterCard("Chained Legs", "链锁之腿", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sealed Body", "封印之躯", Language.ChineseSimplified);
            RegisterCard("Sealed Body", "封印之躯", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bound Arms", "束缚之臂", Language.ChineseSimplified);
            RegisterCard("Bound Arms", "束缚之臂", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Imprisoned Tyrant", "囚禁的暴君", Language.ChineseSimplified);
            RegisterCard("Imprisoned Tyrant", "囚禁的暴君", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Multiplication mage", "矩阵法师", Language.ChineseSimplified);
            RegisterCard("Multiplication mage", "矩阵法师", "This cycle can go on forever..", "此循环可永续不止");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This cycle can go on forever..", "此循环可永续不止", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Invisible mage", "隐形法师", Language.ChineseSimplified);
            RegisterCard("Invisible mage", "隐形法师", "It drank the wrong potion and ended up invisible. How clumsy.", "它喝错了药水，结果隐形了。真笨拙。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It drank the wrong potion and ended up invisible. How clumsy.", "它喝错了药水，结果隐形了。真笨拙。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crystal Sage", "水晶贤者", Language.ChineseSimplified);
            RegisterCard("Crystal Sage", "水晶贤者", "A young scholar, profoundly studying mana crystals", "一位潜心研究法力水晶的年轻学者");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A young scholar, profoundly studying mana crystals", "一位潜心研究法力水晶的年轻学者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Guardian", "宝石守护者", Language.ChineseSimplified);
            RegisterCard("Gem Guardian", "宝石守护者", "The inverse of the Gem Detonator, this one seeks to protect all mox.", "与宝石引爆器效果相反，此卡旨在保护所有玛珂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The inverse of the Gem Detonator, this one seeks to protect all mox.", "与宝石引爆器效果相反，此卡旨在保护所有玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gembound Ripper", "宝石收割者", Language.ChineseSimplified);
            RegisterCard("Gembound Ripper", "宝石收割者", "It is unstable, but such is the price for unending power.", "它并不稳定，但这就是无尽力量所要付出的代价");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is unstable, but such is the price for unending power.", "它并不稳定，但这就是无尽力量所要付出的代价", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Absorber", "宝石吞噬者", Language.ChineseSimplified);
            RegisterCard("Gem Absorber", "宝石吞噬者", "It seeks out to consume all mana within Mox to grow stronger.", "它会吞噬玛珂中的所有魔力以增强自身");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seeks out to consume all mana within Mox to grow stronger.", "它会吞噬玛珂中的所有魔力以增强自身", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skelemagus", "骷髅法师", Language.ChineseSimplified);
            RegisterCard("Skelemagus", "骷髅法师", "Great power for a few, fleeting moments..", "转瞬即逝的强大力量");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Great power for a few, fleeting moments..", "转瞬即逝的强大力量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skelesage", "骸骨贤者", Language.ChineseSimplified);
            RegisterCard("Skelesage", "骸骨贤者", "One of my own Junior Sages, lost and revived.", "我曾失去又复生的初级贤者之一。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One of my own Junior Sages, lost and revived.", "我曾失去又复生的初级贤者之一。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Erratic Scholar", "烦躁学者", Language.ChineseSimplified);
            RegisterCard("Erratic Scholar", "烦躁学者", "A panicked scholar.. Always running from its problems..", "惊慌失措的学者……永远在逃避自己的问题……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A panicked scholar.. Always running from its problems..", "惊慌失措的学者……永远在逃避自己的问题……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mox Mage", "玛珂法师", Language.ChineseSimplified);
            RegisterCard("Mox Mage", "玛珂法师", "A Mox disguised as a mage.. It's not going to fool anyone.", "伪装成法师的玛珂...这骗不了任何人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A Mox disguised as a mage.. It's not going to fool anyone.", "伪装成法师的玛珂...这骗不了任何人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Aurumtact", "点金术士", Language.ChineseSimplified);
            RegisterCard("Aurumtact", "点金术士", "An elder scholar, cursed for his greed, entombing anything he touches in pure gold.", "一位因贪婪而被诅咒的年迈学者，能将触碰之物尽数化为纯金");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An elder scholar, cursed for his greed, entombing anything he touches in pure gold.", "一位因贪婪而被诅咒的年迈学者，能将触碰之物尽数化为纯金", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chained Mox", "连环玛珂", Language.ChineseSimplified);
            RegisterCard("Chained Mox", "连环玛珂", "A collection of 3 moxen, tangled together, combining their mana energy.", "三颗玛珂纠缠而成的集合体，能融合它们的魔力能量。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A collection of 3 moxen, tangled together, combining their mana energy.", "三颗玛珂纠缠而成的集合体，能融合它们的魔力能量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Maux", "马可", Language.ChineseSimplified);
            RegisterCard("Maux", "马可", "In all my years, I have NEVER seen an imitation cruder than this.", "老夫平生从未见过如此拙劣的仿品");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "In all my years, I have NEVER seen an imitation cruder than this.", "老夫平生从未见过如此拙劣的仿品", Language.ChineseSimplified);
            RegisterCard("Stim Mage", "强化法师", "It strives to grow stronger, disregarding its own wellbeing..", "它不顾自身安危，执意追求力量……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It strives to grow stronger, disregarding its own wellbeing..", "它不顾自身安危，执意追求力量……", Language.ChineseSimplified);
            RegisterCard("Gourmage", "暴食法师", "A gluttonous mage who devours the corpses of your fallen to grow stroner.. Disgusting.", "暴食成性的法师，靠吞食阵亡者的尸体来增强力量……真恶心。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A gluttonous mage who devours the corpses of your fallen to grow stroner.. Disgusting.", "暴食成性的法师，靠吞食阵亡者的尸体来增强力量……真恶心。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dunce", "呆瓜法师", Language.ChineseSimplified);
            RegisterCard("Dunce", "呆瓜法师", "This one can never seem to hit its target..", "这家伙似乎永远打不中目标");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This one can never seem to hit its target..", "这家伙似乎永远打不中目标", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grootslang", "巨蟒", Language.ChineseSimplified);
            RegisterCard("Grootslang", "巨蟒", "The mere graze of its fangs is enough to kill any creature. No matter the size.", "凶名昭著的巨蟒。只需被它的獠牙轻轻擦过，任何造物都难逃一死——无论体型大小。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The mere graze of its fangs is enough to kill any creature. No matter the size.", "凶名昭著的巨蟒。只需被它的獠牙轻轻擦过，任何造物都难逃一死——无论体型大小。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bookworm", "书虫", Language.ChineseSimplified);
            RegisterCard("Bookworm", "书虫", "A rare kind of insect that absorbs knowledge out of books.", "一种能从书本中汲取知识的稀有昆虫");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A rare kind of insect that absorbs knowledge out of books.", "一种能从书本中汲取知识的稀有昆虫", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Alchemist", "炼金术士", Language.ChineseSimplified);
            RegisterCard("Alchemist", "炼金术士", "A supporting one. It brews potions to empower your cards.", "辅助型单位。它能调配药剂来强化你的卡牌。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A supporting one. It brews potions to empower your cards.", "辅助型单位。它能调配药剂来强化你的卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chime Mage", "鸣钟法师", Language.ChineseSimplified);
            RegisterCard("Chime Mage", "鸣钟法师", "Its chime can prove to be quite annoying..", "它的铃声确实烦人得很……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its chime can prove to be quite annoying..", "它的铃声确实烦人得很……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Revivor", "复生者", Language.ChineseSimplified);
            RegisterCard("Revivor", "复生者", "It brings a mage back from the dead, at the cost of its own health.", "它能以自身生命为代价，让一名法师从死亡中复活");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It brings a mage back from the dead, at the cost of its own health.", "它能以自身生命为代价，让一名法师从死亡中复活", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rune Mage", "符文法师", Language.ChineseSimplified);
            RegisterCard("Rune Mage", "符文法师", "It conjures explosive runes alongside it when summoned. Not a good idea, I must say.", "召唤时会同时生成爆炸符文。说真的，这可不是个好主意。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It conjures explosive runes alongside it when summoned. Not a good idea, I must say.", "召唤时会同时生成爆炸符文。说真的，这可不是个好主意。", Language.ChineseSimplified);
            RegisterCard("--~~--~~--", "--~~--~~--", "So it arrives.", "它来了");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So it arrives.", "它来了", Language.ChineseSimplified);
            RegisterCard("~-~-~-~-~-~", "~-~-~-~-~-~", "I foresaw its arrival.", "我早已预见它的到来");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I foresaw its arrival.", "我早已预见它的到来", Language.ChineseSimplified);
            RegisterCard("~~--~~--~~", "~~--~~--~~", "At last, it is here.", "终于，它来了");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "At last, it is here.", "终于，它来了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sniper Sage", "狙击贤者", Language.ChineseSimplified);
            RegisterCard("Sniper Sage", "狙击贤者", "A mage whose training allows it to cast spells from afar.", "经过训练的法师，可从远处施放法术");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A mage whose training allows it to cast spells from afar.", "经过训练的法师，可从远处施放法术", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rune", "符文", Language.ChineseSimplified);
            RegisterCard("Rune", "符文", "This is the last call, for alcohol.", "这是最后的召唤，为了烈酒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This is the last call, for alcohol.", "这是最后的召唤，为了烈酒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flame", "魔焰", Language.ChineseSimplified);
            RegisterCard("Flame", "魔焰", "This is the last call, for alcohol.", "这是最后的召唤，为了烈酒。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This is the last call, for alcohol.", "这是最后的召唤，为了烈酒。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rabbit", "兔子", Language.ChineseSimplified);
            RegisterCard("Rabbit", "兔子", "This is the last call, for alcohol.", "这是最后的召唤，为了烈酒");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This is the last call, for alcohol.", "这是最后的召唤，为了烈酒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This is the last call, for booze.", "这是最后的召唤，为了豪饮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This is the last call, for ale.", "这是最后的召唤，为了麦啤", Language.ChineseSimplified);
            RegisterCard("Master Goranj", "绿橙蓝大师", "The towering Master Goranj. Not only a caster of fearsome Magicks, but possessed of a sturdy poise as well.", "巍然耸立的绿橙蓝大师。不仅是可怖魔法的施法者，更拥有坚不可摧的体魄。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The towering Master Goranj. Not only a caster of fearsome Magicks, but possessed of a sturdy poise as well.", "巍然耸立的绿橙蓝大师。不仅是可怖魔法的施法者，更拥有坚不可摧的体魄。", Language.ChineseSimplified);
            RegisterCard("Master Bleene", "蓝绿橙大师", "The selfless Master Bleene. It shall help you in times of dire need… At the cost of its own ability to defend itself. Admirable", "无私的蓝绿橙大师。它会在危难时刻伸出援手……代价是丧失自卫能力。可敬");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The selfless Master Bleene. It shall help you in times of dire need… At the cost of its own ability to defend itself. Admirable", "无私的蓝绿橙大师。它会在危难时刻伸出援手……代价是丧失自卫能力。可敬", Language.ChineseSimplified);
            RegisterCard("Master Orlu", "橙蓝绿大师", "The great Master Orlu, soaring on pale wings, it attacks from above and draws in cards from below..", "伟大的橙蓝绿大师，展苍翼翱翔天际，既可凌空突袭又能从下方汲取卡牌。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The great Master Orlu, soaring on pale wings, it attacks from above and draws in cards from below..", "伟大的橙蓝绿大师，展苍翼翱翔天际，既可凌空突袭又能从下方汲取卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "my name is.. Shake-Zula! The Mic rula! The Old Schoola! You want a trip? I'll bring it to ya...", "吾名震祖拉！麦霸之主！旧学派宗师！欲寻幻旅？吾当引汝往之……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Master Magnus", "至尊大师", Language.ChineseSimplified);
            RegisterCard("Master Magnus", "至尊大师", "Frylock yeah Im on top rock you like a cop, meatwad you're up next with your knock knock!", "弗莱洛克！我站在巅峰像条子一样压制你，肉团子该你上场敲敲门了！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frylock yeah Im on top rock you like a cop, meatwad you're up next with your knock knock!", "弗莱洛克！我站在巅峰像条子一样压制你，肉团子该你上场敲敲门了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Meatwad get the money, see. Meatwad get the honeys, G. ", "肉团得钱财，肉团得美人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Phoenix", "凤凰", Language.ChineseSimplified);
            RegisterCard("Phoenix", "凤凰", "Majestic avian, rumoured to have been an accomplice to Master Orlu...", "威严的飞禽，据传曾是橙蓝绿大师的同谋……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Majestic avian, rumoured to have been an accomplice to Master Orlu...", "威严的飞禽，据传曾是橙蓝绿大师的同谋……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bleenehound", "寻宝猎犬", Language.ChineseSimplified);
            RegisterCard("Bleenehound", "寻宝猎犬", "Loyalist canine, rumoured to have been Master Bleene's loyal companion.", "忠诚犬类，据传曾是蓝绿橙大师的忠实伙伴");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Loyalist canine, rumoured to have been Master Bleene's loyal companion.", "忠诚犬类，据传曾是蓝绿橙大师的忠实伙伴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Alchemy 101", "炼金术入门", Language.ChineseSimplified);
            RegisterCard("Alchemy 101", "炼金术入门", "[c:g2]Alchemy 101[c:]\n[c:g3]I[c:] [c:g1]never[c:] [c:g3]was[c:] [c:g1]that[c:] [c:g3]great[c:] [c:g1]at[c:] [c:g3]alchemy..[c:]", "[c:g2]《炼金术入门》[c:]\n[c:g3]我[c:][c:g1]在[c:][c:g3]炼金术[c:][c:g1]方面[c:][c:g3]一直[c:][c:g1]不[c:][c:g3]太擅长……[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Alchemy 101[c:]\n[c:g3]I[c:] [c:g1]never[c:] [c:g3]was[c:] [c:g1]that[c:] [c:g3]great[c:] [c:g1]at[c:] [c:g3]alchemy..[c:]", "[c:g2]《炼金术入门》[c:]\n[c:g3]我[c:][c:g1]在[c:][c:g3]炼金术[c:][c:g1]方面[c:][c:g3]一直[c:][c:g1]不[c:][c:g3]太擅长……[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Guide to Attack", "攻击指南", Language.ChineseSimplified);
            RegisterCard("Guide to Attack", "攻击指南", "[c:g2]Guide to Attack[c:]\n[c:g3]One[c:] [c:g1]of[c:] [c:g3]the[c:] [c:g1]first[c:] [c:g3]books[c:] [c:g1]I[c:] [c:g3]ever[c:] [c:g1]read.[c:]", "[c:g2]《攻击指南》[c:]\n[c:g3]这是[c:][c:g1]我[c:][c:g3]读过的[c:][c:g1]第一本[c:][c:g3]书[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Guide to Attack[c:]\n[c:g3]One[c:] [c:g1]of[c:] [c:g3]the[c:] [c:g1]first[c:] [c:g3]books[c:] [c:g1]I[c:] [c:g3]ever[c:] [c:g1]read.[c:]", "[c:g2]《攻击指南》[c:]\n[c:g3]这是[c:][c:g1]我[c:][c:g3]读过的[c:][c:g1]第一本[c:][c:g3]书[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Art of Surprise", "突袭艺术", Language.ChineseSimplified);
            RegisterCard("Art of Surprise", "突袭艺术", "[c:g2]The art of Surprise[c:]\n[c:g3]Looks[c:] [c:g1]like[c:] [c:g3]a[c:] [c:g1]frustrated[c:] [c:g3]mage[c:] [c:g1]stabbed[c:] [c:g3]it.[c:]", "[c:g2]《突袭艺术》[c:]\n[c:g3]看起来[c:][c:g1]像是[c:][c:g3]某个[c:][c:g1]沮丧的[c:][c:g3]法师[c:][c:g1]捅了[c:][c:g3]它[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]The art of Surprise[c:]\n[c:g3]Looks[c:] [c:g1]like[c:] [c:g3]a[c:] [c:g1]frustrated[c:] [c:g3]mage[c:] [c:g1]stabbed[c:] [c:g3]it.[c:]", "[c:g2]《突袭艺术》[c:]\n[c:g3]看起来[c:][c:g1]像是[c:][c:g3]某个[c:][c:g1]沮丧的[c:][c:g3]法师[c:][c:g1]捅了[c:][c:g3]它[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, " Forbidden Secrets", "禁忌秘典", Language.ChineseSimplified);
            RegisterCard(" Forbidden Secrets", "禁忌秘典", "[c:g2]The Tome of Forbidden Secrets[c:]\n[c:g3]Quite[c:] [c:g1]tough[c:] [c:g3]to[c:] [c:g1]open.[c:]", "[c:g2]《禁忌秘典》[c:]\n[c:g3]相当[c:][c:g1]难[c:][c:g3]打开[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]The Tome of Forbidden Secrets[c:]\n[c:g3]Quite[c:] [c:g1]tough[c:] [c:g3]to[c:] [c:g1]open.[c:]", "[c:g2]《禁忌秘典》[c:]\n[c:g3]相当[c:][c:g1]难[c:][c:g3]打开[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Secrets of Life and Death", "生死秘术", Language.ChineseSimplified);
            RegisterCard("Secrets of Life and Death", "生死秘术", "[c:g2]The Secrets of Life and Death[c:]\n[c:g3]A[c:] [c:g1]forbidden[c:] [c:g3]book,[c:] [c:g1]I[c:] [c:g3]had[c:] [c:g1]to[c:] [c:g3]read[c:] [c:g1]it[c:] [c:g3]in[c:] [c:g1]secret![c:]", "[c:g2]《生死秘术》[c:]\n[c:g3]一本[c:][c:g1]禁书，[c:][c:g3]我[c:][c:g1]只能[c:][c:g3]偷偷[c:][c:g1]阅读[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]The Secrets of Life and Death[c:]\n[c:g3]A[c:] [c:g1]forbidden[c:] [c:g3]book,[c:] [c:g1]I[c:] [c:g3]had[c:] [c:g1]to[c:] [c:g3]read[c:] [c:g1]it[c:] [c:g3]in[c:] [c:g1]secret![c:]", "[c:g2]《生死秘术》[c:]\n[c:g3]一本[c:][c:g1]禁书，[c:][c:g3]我[c:][c:g1]只能[c:][c:g3]偷偷[c:][c:g1]阅读[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Book of War", "战争之书", Language.ChineseSimplified);
            RegisterCard("Book of War", "战争之书", "[c:g2]Book of War[c:]\n[c:g3]A[c:] [c:g1]painful,[c:] [c:g3]yet[c:] [c:g1]informative[c:] [c:g3]read.[c:]", "[c:g2]《战争之书》[c:]\n[c:g3]读得[c:][c:g1]痛苦，[c:][c:g3]但[c:][c:g1]很有[c:][c:g3]收获[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Book of War[c:]\n[c:g3]A[c:] [c:g1]painful,[c:] [c:g3]yet[c:] [c:g1]informative[c:] [c:g3]read.[c:]", "[c:g2]《战争之书》[c:]\n[c:g3]读得[c:][c:g1]痛苦，[c:][c:g3]但[c:][c:g1]很有[c:][c:g3]收获[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gilded Codex", "镀金法典", Language.ChineseSimplified);
            RegisterCard("Gilded Codex", "镀金法典", "[c:g2]Gold-Encrusted Codex[c:]\n[c:g3]Possibly[c:] [c:g1]the[c:] [c:g3]most[c:] [c:g1]valueable[c:] [c:g3]book[c:] [c:g1]I[c:] [c:g3]own.[c:]", "[c:g2]《镀金法典》[c:]\n[c:g3]可能[c:][c:g1]是[c:][c:g3]我[c:][c:g1]最珍贵[c:][c:g3]的书[c:][c:g1]了[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Gold-Encrusted Codex[c:]\n[c:g3]Possibly[c:] [c:g1]the[c:] [c:g3]most[c:] [c:g1]valueable[c:] [c:g3]book[c:] [c:g1]I[c:] [c:g3]own.[c:]", "[c:g2]《镀金法典》[c:]\n[c:g3]可能[c:][c:g1]是[c:][c:g3]我[c:][c:g1]最珍贵[c:][c:g3]的书[c:][c:g1]了[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Introduction to Runes", "符文导论", Language.ChineseSimplified);
            RegisterCard("Introduction to Runes", "符文导论", "[c:g2]Introduction to Runes[c:]\n[c:g3]'Twas[c:] [c:g1]an[c:] [c:g3]absolute[c:] [c:g1]nightmare[c:] [c:g3]learning[c:] [c:g1]all[c:] [c:g3]those[c:] [c:g1]runes.[c:]", "[c:g2]《符文导论》[c:]\n[c:g3]学习[c:][c:g1]所有[c:][c:g3]这些[c:][c:g1]符文[c:][c:g3]简直是[c:][c:g1]噩梦[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Introduction to Runes[c:]\n[c:g3]'Twas[c:] [c:g1]an[c:] [c:g3]absolute[c:] [c:g1]nightmare[c:] [c:g3]learning[c:] [c:g1]all[c:] [c:g3]those[c:] [c:g1]runes.[c:]", "[c:g2]《符文导论》[c:]\n[c:g3]学习[c:][c:g1]所有[c:][c:g3]这些[c:][c:g1]符文[c:][c:g3]简直是[c:][c:g1]噩梦[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gooey Book", "黏糊的书", Language.ChineseSimplified);
            RegisterCard("Gooey Book", "黏糊的书", "[c:g2]A Brief Hist-[c:] [c:g3]Wait[c:] [c:g1]a[c:] [c:g3]minute..[c:] [c:g1]Some[c:] [c:g3]vandal[c:] [c:g1]ruined[c:] [c:g3]this[c:] [c:g1]one![c:]", "[c:g2]《简史-[c:] [c:g3]等等……[c:][c:g1]有[c:g3]人[c:][c:g1]毁了[c:g3]这本[c:][c:g1]书！[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]A Brief Hist-[c:] [c:g3]Wait[c:] [c:g1]a[c:] [c:g3]minute..[c:] [c:g1]Some[c:] [c:g3]vandal[c:] [c:g1]ruined[c:] [c:g3]this[c:] [c:g1]one![c:]", "[c:g2]《简史-[c:] [c:g3]等等……[c:][c:g1]有[c:][c:g3]人[c:][c:g1]毁了[c:][c:g3]这本[c:][c:g1]书！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bogbound Spells", "沼泽咒术", Language.ChineseSimplified);
            RegisterCard("Bogbound Spells", "沼泽咒术", "[c:g2]Bogbound Spells[c:]\n[c:g3]Eurgh,[c:] [c:g1]it's[c:] [c:g3]in[c:] [c:g1]way[c:] [c:g3]worse[c:] [c:g1]condition[c:] [c:g3]than[c:] [c:g1]I[c:] [c:g3]remember.[c:]", "[c:g2]《沼泽咒术》[c:]\n[c:g3]呃[c:][c:g1]它的[c:g3]状况[c:][c:g1]比[c:g3]我[c:][c:g1]记忆[c:g3]中的[c:][c:g1]更糟[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Bogbound Spells[c:]\n[c:g3]Eurgh,[c:] [c:g1]it's[c:] [c:g3]in[c:] [c:g1]way[c:] [c:g3]worse[c:] [c:g1]condition[c:] [c:g3]than[c:] [c:g1]I[c:] [c:g3]remember.[c:]", "[c:g2]《沼泽咒术》[c:]\n[c:g3]呃[c:][c:g1]它的[c:g3]状况[c:][c:g1]比[c:][c:g3]我[c:][c:g1]记忆[c:][c:g3]中的[c:][c:g1]更糟[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Taming Familiars", "驯服使魔", Language.ChineseSimplified);
            RegisterCard("Taming Familiars", "驯服使魔", "[c:g2]Guide to Taming Familiars[c:]\n[c:g3]Borrowed[c:] [c:g1]this[c:] [c:g3]one[c:] [c:g1]from[c:] [c:g3]a[c:] [c:g1]friend[c:] [c:g3]in[c:] [c:g1]the[c:] [c:g3]wood.[c:]", "[c:g2]《驯服使魔指南》[c:]\n[c:g3]从[c:][c:g1]森林里[c:][c:g3]的[c:][c:g1]朋友[c:][c:g3]那里[c:][c:g1]借[c:][c:g3]的[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Guide to Taming Familiars[c:]\n[c:g3]Borrowed[c:] [c:g1]this[c:] [c:g3]one[c:] [c:g1]from[c:] [c:g3]a[c:] [c:g1]friend[c:] [c:g3]in[c:] [c:g1]the[c:] [c:g3]wood.[c:]", "[c:g2]《驯服使魔指南》[c:]\n[c:g3]从[c:][c:g1]森林里[c:][c:g3]的[c:][c:g1]朋友[c:][c:g3]那里[c:][c:g1]借[c:][c:g3]的[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Raising the Horde", "亡灵大军", Language.ChineseSimplified);
            RegisterCard("Raising the Horde", "亡灵大军", "[c:g2]Raising the Horde[c:]\n[c:g3]I[c:] [c:g1]had[c:] [c:g3]to[c:] [c:g1]sneak[c:] [c:g3]into[c:] [c:g1]a[c:] [c:g3]crypt[c:] [c:g1]to[c:] [c:g3]get[c:] [c:g1]this[c:] [c:g3]one![c:]", "[c:g2]《亡灵大军》[c:]\n[c:g3]我[c:][c:g1]不得不[c:][c:g3]倒了[c:][c:g1]一座[c:][c:g3]斗[c:][c:g1]才[c:][c:g3]得到[c:][c:g1]它[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Raising the Horde[c:]\n[c:g3]I[c:] [c:g1]had[c:] [c:g3]to[c:] [c:g1]sneak[c:] [c:g3]into[c:] [c:g1]a[c:] [c:g3]crypt[c:] [c:g1]to[c:] [c:g3]get[c:] [c:g1]this[c:] [c:g3]one![c:]", "[c:g2]《亡灵大军》[c:]\n[c:g3]我[c:][c:g1]不得不[c:][c:g3]倒了[c:][c:g1]一座[c:][c:g3]斗[c:][c:g1]才[c:][c:g3]得到[c:][c:g1]它[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Art of Possesion", "附身之术", Language.ChineseSimplified);
            RegisterCard("Art of Possesion", "附身之术", "[c:g2]The Art of Possesion[c:]\n[c:g3]Animating[c:] [c:g1]other[c:] [c:g3]mages[c:] [c:g1]was[c:] [c:g3]considered[c:] [c:g1]taboo[c:] [c:g3]back[c:] [c:g1]when[c:] [c:g3]I[c:] [c:g1]was[c:] [c:g3]around.[c:]", "[c:g2]《附身之术》[c:]\n[c:g3]在我[c:][c:g1]那个[c:][c:g3]年代，[c:][c:g1]操纵[c:][c:g3]其他[c:][c:g1]法师[c:][c:g3]是[c:][c:g1]禁忌[c:]");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]The Art of Possesion[c:]\n[c:g3]Animating[c:] [c:g1]other[c:] [c:g3]mages[c:] [c:g1]was[c:] [c:g3]considered[c:] [c:g1]taboo[c:] [c:g3]back[c:] [c:g1]when[c:] [c:g3]I[c:] [c:g1]was[c:] [c:g3]around.[c:]", "[c:g2]《附身之术》[c:]\n[c:g3]在我[c:][c:g1]那个[c:][c:g3]年代，[c:][c:g1]操纵[c:][c:g3]其他[c:][c:g1]法师[c:][c:g3]是[c:][c:g1]禁忌[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Moon", "月亮", Language.ChineseSimplified);
            RegisterCard("The Moon", "月亮", "OH THE MOON O HTHEMOON OH THE MOON O H THE MOON.", "月亮啊月亮月亮啊月亮月亮啊月亮");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH THE MOON O HTHEMOON OH THE MOON O H THE MOON.", "月亮啊月亮月亮啊月亮月亮啊月亮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Earth", "地球", Language.ChineseSimplified);
            RegisterCard("The Earth", "地球", "The urth.", "原初之土");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The urth.", "原初之土", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cause we are the aqua teens, make the homies say ho and the girlies wanna scream", "因为我们是水行少年 让兄弟喊哇塞 让妹子尖叫", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Head of Emerald", "绿宝石之首", Language.ChineseSimplified);
            RegisterCard("Head of Emerald", "绿宝石之首", "trogdor", "特罗格多");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "trogdor", "特罗格多", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Head of Ruby", "红宝石之首", Language.ChineseSimplified);
            RegisterCard("Head of Ruby", "红宝石之首", "haha goarnj", "哈哈戈安吉");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "haha goarnj", "哈哈戈安吉", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Head of Sapphire", "蓝宝石之首", Language.ChineseSimplified);
            RegisterCard("Head of Sapphire", "蓝宝石之首", "mind gaames", "心灵卜弈");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "mind gaames", "心灵卜弈", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Heads of Void", "虚空之首", Language.ChineseSimplified);
            RegisterCard("Heads of Void", "虚空之首", "evil", "邪祟");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "evil", "邪祟", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Moon Shards", "月之碎片", Language.ChineseSimplified);
            RegisterCard("Moon Shards", "月之碎片", "OH THE MOON O HTHEMOON OH THE MOON O H THE MOON.", "月啊月啊月啊月啊月啊月啊");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "OH THE MOON O HTHEMOON OH THE MOON O H THE MOON.", "月啊月啊月啊月啊月啊月啊", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Venus", "金星", Language.ChineseSimplified);
            RegisterCard("Venus", "金星", "Its a me venus!", "是我，金星！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its a me venus!", "是我，金星！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mars", "火星", Language.ChineseSimplified);
            RegisterCard("Mars", "火星", "Its a me mars!", "是我，火星！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its a me mars!", "是我，火星！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mercury", "水星", Language.ChineseSimplified);
            RegisterCard("Mercury", "水星", "Its a me mercury!", "是我，水星！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its a me mercury!", "是我，水星！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Neptune", "海王星", Language.ChineseSimplified);
            RegisterCard("Neptune", "海王星", "Its a me neptune!", "是我，海王星！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its a me neptune!", "是我，海王星！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Jupiter", "木星", Language.ChineseSimplified);
            RegisterCard("Jupiter", "木星", "Its a me jupiter!", "是我，木星！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its a me jupiter!", "是我，木星！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Saturn", "土星", Language.ChineseSimplified);
            RegisterCard("Saturn", "土星", "Its a me saturn!", "是我，土星！");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Its a me saturn!", "是我，土星！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Horven", "魔法克拉肯", Language.ChineseSimplified);
            RegisterCard("The Horven", "魔法克拉肯", "A terrible creature of the sea.. Posessing 3 strange and powerful appendages.", "深海中的恐怖存在……生有三条诡异而强壮的触须");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A terrible creature of the sea.. Posessing 3 strange and powerful appendages.", "深海中的恐怖存在……生有三条诡异而强壮的触须", Language.ChineseSimplified);
            RegisterCard("Bleene's Mox", "蓝绿橙的玛珂", "", "");
            RegisterCard("Goranj's Mox", "绿橙蓝的玛珂", "", "");
            RegisterCard("Orlu's Mox", "橙蓝绿的玛珂", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Goobert", "沽伯特", Language.ChineseSimplified);
            RegisterCard("Goobert", "沽伯特", "A replica of my goo mage.. Its loyalty is only matched by its suffering.", "我的黏液法师的复制品……他的忠诚与痛苦同样深重");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A replica of my goo mage.. Its loyalty is only matched by its suffering.", "我的黏液法师的复制品……他的忠诚与痛苦同样深重", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Goo", "黏液", Language.ChineseSimplified);
            RegisterCard("Goo", "黏液", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Scarecrow", "稻草人", Language.ChineseSimplified);
            RegisterCard("Scarecrow", "稻草人", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Scarecrow Twins", "双子稻草人", Language.ChineseSimplified);
            RegisterCard("Scarecrow Twins", "双子稻草人", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stim Sage", "强化贤者", Language.ChineseSimplified);
            RegisterCard("Stim Sage", "强化贤者", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Enchanted Spear", "附魔长矛", Language.ChineseSimplified);
            RegisterCard("Enchanted Spear", "附魔长矛", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Portrait Mage", "肖像法师", Language.ChineseSimplified);
            RegisterCard("Portrait Mage", "肖像法师", "Your own creation.. How did it get here?", "你自己的造物……它怎么到这儿来了？");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your own creation.. How did it get here?", "你自己的造物……它怎么到这儿来了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Revitilization", "复苏术", Language.ChineseSimplified);
            RegisterCard("Revitilization", "复苏术", "This spell casts several healing auras to all of your cards.", "该法术会为你的所有卡牌施加多道治疗光环");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This spell casts several healing auras to all of your cards.", "该法术会为你的所有卡牌施加多道治疗光环", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Carnage", "屠戮", Language.ChineseSimplified);
            RegisterCard("Carnage", "屠戮", "This spell channels raw hellcow energy unto your cards.. Boosting their attack.", "该法术将地狱蛮牛之力灌注至你的卡牌中，提升其攻击力");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This spell channels raw hellcow energy unto your cards.. Boosting their attack.", "该法术将地狱蛮牛之力灌注至你的卡牌中，提升其攻击力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blizzard", "暴风雪", Language.ChineseSimplified);
            RegisterCard("Blizzard", "暴风雪", "Freeze over your opponents side with a mighty blizzard..", "用强大的暴雪冻结对手的战场");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Freeze over your opponents side with a mighty blizzard..", "用强大的暴雪冻结对手的战场", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cyclone", "强风咒", Language.ChineseSimplified);
            RegisterCard("Cyclone", "强风咒", "This spell shall summon a whirlwind that boosts your cards into the air.", "此法术将召唤旋风使你的卡牌获得飞行能力");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This spell shall summon a whirlwind that boosts your cards into the air.", "此法术将召唤旋风使你的卡牌获得飞行能力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flood", "洪流", Language.ChineseSimplified);
            RegisterCard("Flood", "洪流", "When used, it will summon a tsunami that wipes away the sigils of every card on the board.", "使用时将召唤海啸，清除牌桌上所有卡牌的印记");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When used, it will summon a tsunami that wipes away the sigils of every card on the board.", "使用时将召唤海啸，清除牌桌上所有卡牌的印记", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Engulf", "吞噬", Language.ChineseSimplified);
            RegisterCard("Engulf", "吞噬", "Select a side of the board to be set ablaze.", "选择牌桌一侧将其点燃");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a side of the board to be set ablaze.", "选择牌桌一侧将其点燃", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Erm.,, erxcsqueeze me sauce?.", "呃……源酱挤何？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ethereal Gems", "虚空宝石", Language.ChineseSimplified);
            RegisterCard("Ethereal Gems", "虚空宝石", "A frail spirit of a late magnus mox.. Only sustains for a turn.", "已逝至尊玛珂的脆弱精魄..仅能存续一回合");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A frail spirit of a late magnus mox.. Only sustains for a turn.", "已逝至尊玛珂的脆弱精魄..仅能存续一回合", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vase of Greed", "贪欲之壶", Language.ChineseSimplified);
            RegisterCard("Vase of Greed", "贪欲之壶", "The vase of greed.. Look at its smug face..", "贪欲之壶……瞧瞧它那副得意的嘴脸……");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The vase of greed.. Look at its smug face..", "贪欲之壶……瞧瞧它那副得意的嘴脸……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gnomification", "侏儒化", Language.ChineseSimplified);
            RegisterCard("Gnomification", "侏儒化", "Conjure a plain old garden gnome on the board..", "在牌桌上召唤一个普通的老旧花园地精。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Conjure a plain old garden gnome on the board..", "在牌桌上召唤一个普通的老旧花园地精。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cursed Skull", "诅咒头骨", Language.ChineseSimplified);
            RegisterCard("Cursed Skull", "诅咒头骨", "Hmm, a cursed skull. Handle it with care.", "嗯，一个被诅咒的头骨。务必小心处理。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm, a cursed skull. Handle it with care.", "嗯，一个被诅咒的头骨。务必小心处理。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inspiration", "灵感", Language.ChineseSimplified);
            RegisterCard("Inspiration", "灵感", "A culmination of the great Master Orlu's essence.", "凝聚了橙蓝绿大师精髓的结晶");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A culmination of the great Master Orlu's essence.", "凝聚了橙蓝绿大师精髓的结晶", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rage", "怒火", Language.ChineseSimplified);
            RegisterCard("Rage", "怒火", "The embodiement of the tenacious Master Goranj.", "顽强不屈的绿橙蓝大师的具现化");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The embodiement of the tenacious Master Goranj.", "顽强不屈的绿橙蓝大师的具现化", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Calculus", "微积", Language.ChineseSimplified);
            RegisterCard("Calculus", "微积", "The spirit of the brave Master Bleene.", "勇者蓝绿橙大师的精魂");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The spirit of the brave Master Bleene.", "勇者蓝绿橙大师的精魂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fireball", "火球术", Language.ChineseSimplified);
            RegisterCard("Fireball", "火球术", "Conjure up a fireball, and shoot it towards your enemy.", "召唤火球并射向敌人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Conjure up a fireball, and shoot it towards your enemy.", "召唤火球并射向敌人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Potion", "魔药", Language.ChineseSimplified);
            RegisterCard("Potion", "魔药", "Conjure up a fireball, and shoot it towards your enemy.", "召唤一枚火球，射向你的敌人");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Conjure up a fireball, and shoot it towards your enemy.", "召唤一枚火球，射向你的敌人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gnome", "侏儒", Language.ChineseSimplified);
            RegisterCard("Gnome", "侏儒", "joem", "乔姆");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "joem", "乔姆", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Scuba Gnome", "潜水侏儒", Language.ChineseSimplified);
            RegisterCard("Scuba Gnome", "潜水侏儒", "Huber", "胡伯");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Huber", "胡伯", Language.ChineseSimplified);
            RegisterCard("Free Legs", "自由之足", "", "");
            RegisterCard("Unsealed Body", "解封之躯", "", "");
            RegisterCard("Released Arms", "解放之臂", "", "");
            RegisterCard("Unleashed Tyrant", "解缚的暴君", "", "");
            foreach (var kvp in Cards)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "~" + kvp.Key + "~", "~" + kvp.Value + "~", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cardpack sapphire", "蓝宝石卡包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cardpack ruby", "红宝石卡包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cardpack emerald", "绿宝石卡包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fill In Minimap", "填充小地图", Language.ChineseSimplified);

            // Achievement
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magnificus Mod Achievements", "蔓尼菲科模组成就", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magical Labyrinth", "魔法迷宫", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat the final boss.", "击败最终首领", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crystal Skull", "水晶头骨", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Complete a run with every challenge active, and no anti challenges. (You may use the map)", "在激活所有挑战且无反挑战的情况下完成一轮游戏（可使用地图）", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Humanoid Slime", "人形黏液", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat the first boss without having any cards get their power reduced at the start of phase 2.", "在第二阶段开始时没有任何卡牌力量被削弱的情况下击败第一首领", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Headless Knight", "无头骑士", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat the second boss without triggering any Enchanted Spears.", "在不触发任何附魔长矛的情况下击败第二首领", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Quick Summon", "快速召唤", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat the third boss without letting the turn timer expire once.", "在回合计时器从未耗尽的情况下击败第三首领", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mischief of the Time Goddess", "时间女神的恶作剧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Let the third boss's timer run out 5 times, and still win the fight.", "让第三首领的计时器耗尽5次后仍赢得战斗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rush Recklessly", "鲁莽突进", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Defeat the first boss after using only 3 or less events.", "仅使用3次或更少事件后击败第一首领", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crowning of the Emperor", "帝王加冕", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blue Eyes White Dragon", "青眼白龙", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Deal 10 damage in a single turn.", "单回合造成10点伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Card of Sacrifice", "牺牲之卡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Have 10 or less cards by the time you reach the final boss.", "在抵达最终首领时持有10张或更少卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Owl of the Black Forest", "黑森林猫头鹰", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Banish the Ficticious Master Magnus.", "放逐虚构的至尊大师", Language.ChineseSimplified);

            // Consumable

            // ShowUntilInput
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT? BUT DON'T I GET TO LEAVE?", "什么？难道我不能离开吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I STILL HAVE SO MUCH STIMULATION TO GET!!", "我还有那么多刺激没体验呢！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]PLEASE, CHALLENGER,[c:] YOU HAVE TO GET ME-", "[c:g2]求你了挑战者[c:]，你必须带我-", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hush.", "肃静", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm?", "嗯？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Did you expect me to restore your [c:g1]life painting[c:]?", "你以为我会修复你的[c:g1]生命画作[c:]？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm.. That's not how it works here, challenger..", "哼..这里的规则可非如此，挑战者..", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bleach is not easily restorable.", "漂白之痕难以复原", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You may only pick a [c:g3]rare card[c:].", "你只能选择一张[c:g3]稀有卡牌[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "As you engage in combat, you notice ethereal runes surrounding you..", "当你投入战斗时，注意到周围浮现出虚幻的符文……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems as though they were placing a [c:g2]pact[c:] on you..", "这些符文似乎正在对你施加[c:g2]契约[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your olden sigils shant be of any use in this battle.", "你原有的印记在这场战斗中毫无用处", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "As the smoke of combat clears, the mysterious runes reveal themselves to you.", "当战斗的硝烟散去，神秘的符文在你面前显现。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ah, but this one does not interest the runes.", "啊，但这张可引不起符文的兴趣。", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The pact takes its effect on your " + kvp.Key + "..", "契约正在对你的" + kvp.Value + "生效……", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The sigil, replaced, for better or for worse.", "印记已被替换，福祸难料。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Hmm..?[c:] [c:g1]Another[c:] [c:g3]student[c:] [c:g1]here?[c:]", "[c:g3]嗯…？[c:][c:g1]又来[c:][c:g3]一个[c:][c:g1]学徒？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Have[c:] [c:g1]you[c:] [c:g3]come[c:] [c:g1]to[c:] [c:g3]assist[c:] [c:g1]my[c:] [c:g3]studies?[c:]", "[c:g3]是[c:][c:g1]来[c:][c:g3]协助[c:][c:g1]我[c:][c:g3]研习[c:][c:g1]的吗？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Hmm..[c:] [c:g1]I[c:] [c:g3]think[c:] [c:g1]it's[c:] [c:g3]time[c:] [c:g1]to[c:] [c:g3]play[c:] [c:g1]some[c:] [c:g3]more...[c:]  [c:g2]forbidden[c:] [c:g1]books[c:]", "[c:g3]嗯……[c:][c:g1]是时候[c:][c:g3]再[c:][c:g1]玩些……[c:][c:g3]禁书[c:][c:g1]了[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]An[c:] [c:g1]excellent[c:] [c:g3]portrait[c:] [c:g1]by[c:] [c:g3]the[c:] [c:g1]Master.[c:]", "[c:g3]大师[c:][c:g1]的[c:][c:g3]杰作[c:][c:g1]肖像[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Looks[c:] [c:g1]like[c:] [c:g3]you[c:] [c:g1]got[c:] [c:g3]a[c:] [c:g1]hound[c:] [c:g3]of[c:] [c:g1]your[c:] [c:g3]own![c:]", "[c:g3]看来[c:][c:g1]你[c:][c:g3]也[c:][c:g1]有[c:][c:g3]自己[c:][c:g1]的[c:][c:g3]猎犬[c:][c:g1]了[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Oh[c:] [c:g1]yes,[c:] [c:g3]I[c:] [c:g1]do[c:] [c:g3]love[c:] [c:g1]a[c:] [c:g3]good[c:] [c:g1]book.[c:]", "[c:g3]啊[c:][c:g1]没错，[c:][c:g3]我[c:][c:g1]确实[c:][c:g3]喜欢[c:][c:g1]读[c:][c:g3]好[c:][c:g1]书[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Let[c:] [c:g1]me[c:] [c:g3]share[c:] [c:g1]some[c:] [c:g3]of[c:] [c:g1]my[c:] [c:g3]favourites[c:] [c:g1]with[c:] [c:g3]you.[c:]", "[c:g3]让[c:][c:g1]我[c:][c:g3]来[c:][c:g1]分享[c:][c:g3]几本[c:][c:g1]我[c:][c:g3]最爱[c:][c:g1]的[c:][c:g3]作品[c:][c:g1]吧[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just imagine.. You are an ice cube, slowly melting in a hot pan..", "……想象你是一个冰块，在热锅上慢慢融化……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "These enchanted spears won't just damage your cards..", "这些附魔长矛可不只是摧毁你的卡牌……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hah! Using one of my own spells against me?", "哈！用我自己的法术来对付我？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Don't you think those cards are a little too powerful?", "你不觉得这些卡牌有点太强了吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "That's better.", "这样好多了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]How did you get that?[c:]", "[c:g1]你是怎么得到这个的？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, ".. Where on earth is my [c:g1]Goo Mage[c:]?", "……我的[c:g1]黏液法师[c:]到底在哪？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Have your.. Modifications removed him?", "莫非是你的…模组把他移除了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This tampering has gone on for far too long. I shall not allow it anymore.", "这般篡改持续太久了。我绝不会再容忍。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When we face off, I won't be holding myself back.", "待我们对决时，我绝不会手下留情。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Halt![c:] [c:g2]A[c:] [c:g1]challenger[c:] [c:g2]dare[c:] [c:g1]approach?![c:]", "[c:g1]止步！[c:][c:g2]竟有[c:][c:g1]挑战者[c:][c:g2]胆敢[c:][c:g1]近前？！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Quaint,[c:] [c:g2]I[c:] [c:g1]shall[c:] [c:g2]make[c:] [c:g1]mince[c:] [c:g2]meat[c:] [c:g1]out[c:] [c:g2]of[c:] [c:g1]you.[c:]", "[c:g1]可笑，[c:][c:g2]我[c:][c:g1]必将[c:][c:g2]把[c:][c:g1]你[c:][c:g2]剁[c:][c:g1]成[c:][c:g2]肉[c:][c:g1]酱[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Irritating,[c:] [c:g2]you[c:] [c:g1]persist.[c:] [c:g2]You[c:] [c:g1]have[c:] [c:g2]bound[c:] [c:g1]me[c:] [c:g2]to[c:] [c:g1]excert[c:] [c:g2]my[c:] [c:g1]blade.[c:]", "[c:g1]恼人的是，[c:][c:g2]你[c:][c:g1]执意如此。[c:][c:g2]你[c:][c:g1]已[c:][c:g2]逼得[c:][c:g1]我[c:][c:g2]必须[c:][c:g1]出剑。[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Eh?[c:] [c:g2]Some[c:] [c:g1]sort[c:] [c:g2]of[c:] [c:g1]immitation[c:] [c:g2]of[c:] [c:g1]me?[c:]", "[c:g1]嗯？[c:][c:g2]某种[c:][c:g1]拙劣地[c:][c:g2]模仿[c:][c:g1]我[c:][c:g2]的[c:][c:g1]东西[c:][c:g2]吗？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "c:g1]Pathetic.[c:] [c:g2]My[c:] [c:g1]Drake[c:] [c:g2]was[c:] [c:g1]much[c:] [c:g2]grander[c:] [c:g1]than[c:] [c:g2]that.[c:]", "[c:g1]可悲。[c:] [c:g2]我的[c:][c:g1]巨龙[c:][c:g2]可比[c:][c:g1]那个[c:][c:g2]宏伟[c:][c:g1]多了。[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "W-What? A challenger?", "什-什么？挑战者？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "FINALLY!! STIMULATION!", "终于！！来点刺激的！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'M STILL NOT STIMULATED ENOUGH!!", "我还不够兴奋！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I HAVE THE URGE TO SEARCH A CARD PILE!", "我忍不住想翻卡堆了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'M GROWING IMPATIENT!\nI NEED MORE STIMULATION!!", "我已经失去耐心了！\n我需要更多刺激！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WOW!! I REMEMBER BREWING THAT!", "哇哦！！我记得调制过这个！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HEY.. YOU DON'T HAVE ANY CARDS LEFT?", "嘿……你一张牌都不剩了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BORING!", "无聊！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WOW! COOL CARD!!", "哇！好酷的卡牌！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "FINDERS KEEPERS!", "谁捡到归谁！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'm afraid you've doomed us all, challenger..", "恐怕你把我们所有人都祸害了，挑战者……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Perhaps I am slowing down with age..", "或许我确实是年岁渐长，动作迟缓了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I must use the brush to my advantage yet again.", "我必须再次动用画笔的力量了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You have impressed me, you truly have..", "你令我刮目相看，确实如此……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "2 lives down now.", "已失两条性命。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Unfortunately for you, I still have a few tricks up my sleeve.", "可惜你算漏了，我尚有几招未出。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I could never allow myself to go down that easily.", "我绝不会让自己这么轻易倒下。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Utter folly.. Getting outside assitance, are we?", "愚蠢至极……竟寻求外援？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Free Legs", "自由之足", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Unsealed Body", "解封之躯", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Released Arms", "解放之臂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Unleashed Tyrant", "解缚的暴君", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just what do you think you're doing?", "你以为你在干什么？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Do not.", "住手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Trying to pull a trick as dirty as that..", "竟敢耍这种下作把戏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "...", "……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Upsetting. I seem to be losing.", "真令人沮丧。我似乎要输了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "How about a new rule.", "不如来条新规则。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Everytime [c:g2]you[c:] play a mox, [c:g2]I[c:] restore 1 health.", "每当[c:g2]你[c:]打出玛珂牌，[c:g2]我[c:]就恢复1点生命。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frustrating. I must use my last resort.", "太糟了。我不得不用最后手段了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]We[c:] [c:g2]have[c:] [c:g3]become[c:] four!", "[c:g1]我们[c:][c:g2]成[c:][c:g3]了[c:]四个！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Hmm?[c:] [c:g3]An[c:] [c:g2]opponent..?[c:]", "[c:g2]嗯？[c:][c:g3]一个[c:][c:g2]对手…？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]I[c:] [c:g3]haven't[c:] [c:g2]had[c:] [c:g3]a[c:] [c:g2]duel[c:] [c:g3]in[c:] [c:g2]a[c:] [c:g3]century![c:]", "[c:g2]我[c:][c:g3]已经[c:][c:g2]有[c:][c:g3]一个[c:][c:g2]世纪[c:][c:g3]没有[c:][c:g2]对决[c:][c:g3]过了！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Have[c:] [c:g3]at[c:] [c:g2]thee![c:]", "[c:g2]接[c:][c:g3]招[c:][c:g2]吧！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]A[c:] [c:g3]fierce[c:] [c:g2]opponent[c:] [c:g3]you[c:] [c:g2]are![c:]", "[c:g2]真[c:][c:g3]是个[c:][c:g2]难缠[c:][c:g3]的[c:][c:g2]对手！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]I'll[c:] [c:g3]just[c:] [c:g2]have[c:] [c:g3]to[c:] [c:g2]use[c:] [c:g3]some[c:] [c:g2]more[c:] [c:g3]dirty[c:] [c:g2]tricks[c:] [c:g3]to[c:] [c:g2]beat[c:] [c:g3]you![c:]", "[c:g2]看来[c:][c:g3]得[c:][c:g2]用些[c:][c:g3]下三滥[c:][c:g2]的[c:][c:g3]手段[c:][c:g2]才能[c:][c:g3]打败[c:][c:g2]你[c:][c:g3]了！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]And[c:] [c:g3]something[c:] [c:g2]else,[c:] [c:g3]why[c:] [c:g2]not.[c:]", "[c:g2]再[c:][c:g3]来点[c:][c:g2]别的[c:][c:g3]花样[c:][c:g2]也[c:][c:g3]未尝不可[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Ooh![c:] [c:g3]What[c:] [c:g2]a[c:] [c:g3]great[c:] [c:g2]portrait![c:]", "[c:g2]噢！[c:][c:g3]多么[c:][c:g2]绝妙的[c:][c:g3]肖像画[c:][c:g2]啊！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]A[c:] [c:g3]replica[c:] [c:g2]of[c:] [c:g3]my[c:] [c:g2]loyal[c:] [c:g3]phoenix,[c:] [c:g2]isn't[c:] [c:g3]she[c:] [c:g2]absolutely[c:] [c:g3]stunning?[c:]", "[c:g2]这是[c:][c:g3]我[c:][c:g2]忠诚的[c:][c:g3]凤凰[c:][c:g2]的[c:][c:g3]复制品，[c:][c:g2]难道[c:][c:g3]她不[c:][c:g2]美得[c:][c:g3]惊心动魄吗？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]I[c:] [c:g3]see[c:] [c:g2]you've[c:] [c:g3]done[c:] [c:g2]a[c:] [c:g3]fair[c:] [c:g2]bit[c:] [c:g3]of[c:] [c:g2]damage![c:]", "[c:g2]我[c:][c:g3]看[c:][c:g2]你[c:][c:g3]打出[c:][c:g2]了[c:][c:g3]不少[c:][c:g2]伤害！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Don't[c:] [c:g3]mind[c:] [c:g2]if[c:] [c:g3]I[c:] [c:g2]just[c:] [c:g3]place[c:] [c:g2]my[c:] [c:g3]thieves..[c:]", "[c:g2]不[c:][c:g3]介意[c:][c:g2]我[c:][c:g3]放些[c:][c:g2]小偷[c:][c:g3]吧……[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Out of cards..", "没牌了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dissapointing. I had high hopes for you.", "真令人失望。我曾对你寄予厚望。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Such a tiny collection of cards..", "就这点可怜的卡牌……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I highly doubt you will win.", "我严重怀疑你能赢", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "With a blaze of Magick, you end the battle. You managed to deal more damage than needed.", "在魔法的烈焰中，你终结了战斗。你造成的伤害远超所需。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The excess Magick you cast turns into [c:g3] Crystals. [c:] You may spend them at any meek store you happen to find.", "溢出的魔法能量将转化为[c:g3]水晶[c:]。你可以在遇到的任何商店中使用它们。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Welcome back.", "欢迎回来。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You're the first in a while to get this far.", "许久未见能走到这一步的挑战者了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I will now bestow upon you, the highest honour I can possibly give.", "现在，我将授予你至高无上的荣耀。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "To be painted, and immortalised forever, as a card.", "以画笔将你永恒铭刻，化作一张卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The dummy stares lifelessly back at you.", "假人毫无生气地回瞪着你。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Then, suddenly it springs to motion!", "然后，它突然动了起来！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The dummy's hinges creak back into position, and it returns to it's lifeless stare.", "假人的铰链吱吱嘎嘎地回归原位，恢复了毫无生气的茫然凝视状态。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So you finally arrive..", "你终于来了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hopefully you have prepared yourself well enough to face the Scrybe of Magicks.", "但愿你已经做好充分准备来面对魔法冥刻者了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This will be your final exam.", "这将是你最终的考验", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Let us dance.", "该我们起舞了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]You[c:] are finally here.", "[c:g2]你[c:]终于现身了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I hope you realise that this is truly it.", "希望你明白这次是真正的终局", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You may have removed my student's battles,", "你或许移除了我学生的战斗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You may have tampered with my entire game..", "你或许篡改了我的整个游戏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is time.", "是时候了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Greetings, challenger.", "向你问候，挑战者。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It appears that all of your mox has been erased.", "看来你的所有玛珂都被抹除了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Curiosity killed the cat..", "好奇心害死猫……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It's a shame you got defeated so early..", "真遗憾你这么快就败下阵来……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It's a shame you got defeated so easily.", "真遗憾你如此轻易就被击败了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It's a shame you got defeated so far in.", "真遗憾你在深入之际落败。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I had such high hopes, but you lost it all..", "我曾寄予厚望，可你辜负了一切……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems my slime mage got the best of you. How dissapointing.", "看来我的黏液法师技高一筹。真令人失望。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It looks like my pike mage tactically took you out..", "看来我的长矛法师用战术解决了你……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Looks like that lonely mage got to you..", "看来那位孤独的巫师得手了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though it does not matter.", "不过无所谓了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I do not have any more use for you.", "你对我已无价值。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Please, take your leave.", "请自行离开吧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Looking for something?", "在找什么东西吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'm afraid the object you seek has been.. [c:g1]relocated[c:]..", "恐怕你要找的东西已经……[c:g1]转移他处[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Look at what you've unleashed..", "看看你都释放了些什么……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Was it truly worth finding?", "这真的值得寻找吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmph.. I did not intend for you to get out here..", "哼……我本没打算让你走到这一步……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I have forseen it though. Despite my best attempts you persist.", "不过我已预见了。尽管竭力阻拦，你仍执意前行。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We shall duel here..", "我们就在此决斗吧……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though, lets up the stakes.", "但这次，我们加点赌注。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you lose here, your entire [c:g1]life painting[c:] will get bleached..", "若你败北，你的全部[c:g1]生命画作[c:]都将被漂白……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Step forth if you dare.", "若敢应战，便上前来。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You persist again?", "你还要继续？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I see..", "原来如此……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "We shall duel again!", "我们再来一局！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ah.. Finally, you arrive.", "啊……你终于来了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I've been watching you from up here, for your entire journey.", "我在此处俯瞰着你全部的旅程。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You've come a long way, challenger.", "挑战者，你已跋涉甚远。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Unfortunately, that will all come to an end here.", "可惜这一切都将在此时终结。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One last duel, to decide your fate..", "最后一战，决定你的命运……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is time to put an end to this.. [c:g1]foolery[c:] of yours.", "是时候终结你这[c:g1]愚行[c:]了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you consider these cheats fair, then I might as well use some cheats of my own.", "若你视这些作弊手段为公平，那我不妨也动用些自己的伎俩。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Normally, I would have you expelled right on the spot.. But I'm feeling generous.", "按常理我该当场将你除名……不过今日我格外宽容。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Let us duel.", "开始对决吧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Whats the matter? Stumped?", "怎么了？卡住了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Try searching around the dungeon.. There may be certain [c:g1]markings[c:] you missed..", "在地牢里再找找……你可能漏掉了一些[c:g1]标记[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm?", "嗯？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Are you wondering what this book is for?", "在好奇这本书的用途吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "That is your [c:g1]spell book[c:]. You may use it to draw one of your [c:g3]spell cards[c:].", "这是你的[c:g1]法术书[c:]，可用它抽取一张[c:g3]法术牌[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "But only [c:g1]one[c:] per turn..", "但每回合仅限[c:g1]一次[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You land in a sticky puddle of goo, stretching out into what seems like an endless void..", "你跌入一滩黏稠的黏液，延伸向看似无尽的虚空……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ruined pillars and ancient walls surround your vision, overtaken by yet more slime..", "断裂的立柱与古老墙壁充斥视野，又被更多黏液吞没……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The glistening heavens above shine brightly unto you.", "头顶闪烁的天穹向你投下耀眼辉光", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You arrive in the..", "你抵达了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A sudden influx of heat surrounds you..", "突如其来的热浪将你包围……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dimly lit and dingy chambers spread out as far as you can see.", "昏暗肮脏的厅室在视野中无尽延展", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Long forgotten echoes of ancient sparring fill the room.", "远古比斗的回响在厅内萦绕不绝", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You find yourself in the..", "你发现自己置身于……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A dusty old smell fills your nostrills..", "陈腐的尘埃气息涌入鼻腔……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hundreds of walls containing books, laying untouched for eons, fill the quiet landscape.", "沉寂的景致中，无数书墙已尘封万古", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ethereal runes, containing lost, forbidden knowledge surround you.", "蕴含禁忌知识的缥缈符文将你环绕", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You awake in the..", "你苏醒于……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmmm. It seems a new student is woven onto my canvas.", "嗯。看来又有新学徒被绘入我的画布了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you look behind yourself, you may see a [c:g1]shop[c:].", "若你回头望去，或能看见一间[c:g1]商店[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You may view your deck and rearange your side deck.", "你可以查看牌组并调整副牌组。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though, do not be alarmed. You may find a shop later on your adventures.", "不过莫要惊慌，冒险途中自会遇到商店。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you are ready to proceed, you may step forth and enter into the unknown.", "若你已准备就绪，便可踏入未知之境。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm.. A young student appears,", "唔...又来了个年轻学徒，", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So foolish, your predesscor didn't even manage to get past my [c:g1]Goo Mage[c:].", "愚不可及，你的前辈连我的[c:g1]黏液法师[c:]都未能击败。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ah well.. Maybe you will manage such a feat.", "也罢...或许你能创造此等壮举。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Another appears.", "又来一个。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Maybe you will manage to get further than those before you.", "兴许你能比前人走得更远。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You young understudies still have much to learn.", "你们这些年轻学徒还有太多要学。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ah. I had expectations for my previous mage,", "啊，我对前任法师寄予厚望，", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They even managed to get past my [c:g2]Pike Mage[c:].", "他们甚至击败了我的[c:g2]长矛法师[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A great feat, it seems now you must follow in their footsteps...", "了不起的壮举，现在该你追随其脚步了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So, yet another steps up to be my student.", "那么，又一位自荐成为我的学徒之人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You must learn yourself, to overcome my many obstacles and challenges.", "你需自行领悟，方能跨越我设下的重重考验。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "If you do succeed, I shall bestow upon you a great honour..", "若你真能成功，我自会赐予你无上荣耀……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm.. Something feels off..", "嗯…有些不对劲……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Have you [c:g1]modded[c:] my game, challenger?", "挑战者，你可是[c:g1]修改了[c:]我的游戏？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmph! How disrespectful!", "哼！何等无礼！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Was my game not enough for you?", "莫非我的游戏还不足以满足你？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Alas, I have no choice but to allow it..", "唉，我也只能听之任之……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just what is going on here..?", "这是怎么回事…？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "These cards,", "这些卡牌，", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Did that [c:g2]foul little..[c:] get in here..?", "那个[c:g2]肮脏的小东西…[c:]闯进来了…？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I believe you are in the wrong place, challenger.", "挑战者，你恐怕来错地方了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hold still.", "别动", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You are a simpleton for expecting scales.", "指望天平？你可真天真。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This is a simple race to 0.", "这不过是场看谁先归零的简单竞赛。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NOW ITS TIME FOR ME TO PRACTICE MY BREWING MAGICKS!!", "现在该让我施展酿造魔法了！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT IS DONE!!! GO TAKE IT!!", "完成了！！！快去拿吧！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GO!!", "快走！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]GET OUT OF HERE!![c:]", "[c:g2]给我滚出去！！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WOAH! LOOKS LIKE SOMETHING YOU PUT INTO THE POTION MADE IT A BIT.. [c:g1]PRICY[c:][c:]..", "哇哦！看来你往药剂里加的东西让它有点……[c:g1]贵[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "W-What? Am I finally free?", "什-什么？我终于自由了吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A break from that endless darkness?", "从那无尽黑暗中解脱了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Nevermind.. It's just potion making..", "算了…不过是调制药水罢了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh, Hi Challenger!!", "噢，你好啊挑战者！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wow, someone new!!", "哇，新面孔！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just give me two cards of yours and we'll make a potion out of them!!", "给我两张你的卡牌，咱们就能调制药水啦！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You can later give this potion to your cards and they gain some silly effects!", "之后你可以把药水赋予卡牌，让它们获得些有趣的效果！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Come on!! It will be fun!!", "来吧！！可好玩了！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "And stimulating..", "而且超刺激……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So stimulating", "太刺激了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hello there challenger!!", "嘿你好啊挑战者！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You know how this works now", "现在你懂流程了吧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just give me two cards and we'll make a potion!", "随便给我两张卡就能调制药水！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Woah.. What.. Is this place?", "哇哦…这是…什么地方？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So bright..", "好亮啊……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh, Hi there!!", "噢，你好呀！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Let's make some potions!!", "咱们来调制药水吧！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just hand over two cards and we'll be done with it..", "递给我两张卡就完事……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WAIT!! YOUR SPELLBOOK IS FULL", "等等！！你的法术书满了！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GET RID OF ONE OF YOUR SPELLS, OR YOU WONT BE ABLE TO TAKE OUR POTION!!", "先丢弃一个法术，否则你拿不走我们的药水！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your card's cost has been changed..", "你的卡牌消耗已经更改……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Do you have a card that has a cost you are unsatisfied with?", "你有对费用不满意的卡牌吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "No. It appears not.", "看来没有。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "LETS SEE HERE..", "让我看看……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "HMM?", "唔？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT DO YOU THINK?", "你觉得呢？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WELL?", "怎么样？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT WOULD THE MASTER THINK?", "大师会怎么想？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WOULD THE MASTER BE PROUD?", "大师会为我骄傲吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IS IT GOOD?", "这样行吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GRREETINGS CHALLENGER!", "向挑战者致意！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU'RE ALREADY HERE?", "你竟已至此？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I DON'T REALLY RECALL US BATTLING..", "我确实不记得与你交战过……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WELL ANYWAYS.. WHAT CARD WHOULD I PRACTICE ON?", "总之…我该拿哪张牌练习？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "IT WOULD SEEM THAT YOU HAVE DISGRACED ME!", "看来你已使我蒙羞！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "BUT IT IS ALRIGHT, I FORGIVE YOU.", "不过无妨，我宽恕你", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "SAY, CHALLENGER, I WOULD LIKE TO PRACTICE MY [c:g2]ART[c:]..", "听着挑战者，我想练习我的[c:g2]美术[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ONE DAY I MIGHT EVEN BE AS GOOD AS THE MASTER!", "终有一日我将比肩大师！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU WOULDN'T MIND GIVING ME ONE OF YOUR THERE CARDS, RIGHT?", "你不介意给我张牌对吧？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "WHAT CARD SHOULD I PRACTICE ON?", "我该练习哪张牌？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'LL NEED A CARD TO HONE MY SKILLS ON.", "我需要张牌来磨砺技艺", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I DON'T THINK WE'VE MET BEFORE!", "我们素未谋面！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "YOU ARENT SUPPOSED TO SEE ME UNTILL LATER, BUT..", "你本不该此时见我，但……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, ".. It appears you have nothing else to offer..", "..看来你已无物可供……", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your" + value + " sits on the enchanted grounds...\nYou could either leave it there, to enchant it..", "你的" + value + "正位于附魔之地……\n你可以选择让它留在那里接受附魔……", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Or you can slaughter it to improve the enchantment, dictated by the [c:g1]Ethereal Sigils[c:].", "或者根据[c:g1]虚空印记[c:]的指引，献祭它以强化附魔效果", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The choice is yours.", "选择权在你手中", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Ethereal Sigils[c:] hover around the grounds.", "[c:g1]虚空印记[c:]在场地周围浮动", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You may use them to predict a possible outcome..", "你可以借此预判可能的结果……", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + value + " has been burdened with Glass Cannon!", "你的" + value + "被施加了玻璃大炮的诅咒！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + value + " has been burdened with Tank!", "你的" + value + "被施加了坦克的诅咒！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + value + " has been blessed!", "你的" + value + "获得了祝福！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + value + " has been burdened!", "你的" + value + "被施加了诅咒！", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + value + " is now free.. But more unstable..", "你的" + value + "现已费用全免……但变得更加不稳定……", Language.ChineseSimplified);
                foreach (var kvp in Abilities)
                {
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your" + value + " has been blessed with " + kvp.Key + "!", "你的" + value + "获得了" + kvp.Value + "祝福！", Language.ChineseSimplified);
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your" + value + " has been burdened with " + kvp.Key + "!", "你的" + value + "被施加了" + kvp.Value + "诅咒！", Language.ChineseSimplified);
                }
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The [c:g1]Sacrifical Grounds[c:] stand before you.\nLegends tell of cards growing exponentially in power here, under the right circumstances..", "[c:g1]献祭之地[c:]矗立眼前。\n传说在特定条件下，卡牌能在此获得指数级的力量提升……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, ".. However, it appears that you don't have anything to offer to the enchanted grounds..", "……但看来你并未携带适合这片附魔之地的祭品", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds seem to be slightly improved.", "附魔之地似乎略有擢升。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "are unsatisfied..", "附魔之地显得不太满意……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds dimly light up with sacrifical energy.", "附魔之地因献祭能量而微微发亮。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds are displeased..", "显得很不悦……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds light up with supernatural energy.", "因超凡能量而闪耀。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds are angered..", "附魔之地被激怒了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds The Enchanted Grounds are absolutely bursting with sacrifical energy.", "附魔之地因献祭能量而剧烈翻腾。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Enchanted Grounds The Enchanted Grounds are furious.", "附魔之地震怒不已……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Eurgh.. This place is disgusting..", "呃..这地方真恶心……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Seems like I'm forced to train spellcasting in here.", "看来我被迫要在这儿练习法术了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Give me a [c:g1]spell[c:] of yours, and make it quick.", "给我一个你的[c:g1]法术[c:]，动作快点", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Greetings..", "你好……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Give me one of your [c:g1]spells[c:]", "给我一个你的[c:g1]法术[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Give me one of your [c:g1]spells[c:].", "给我一个你的[c:g1]法术[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh.. Greetings... I don't believe we've been introduced..", "哦…你好……我们似乎还没正式认识……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I've been force- er.. asked to train my spellcasting here.", "我被强制-呃…受邀来这儿练习法术", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Why don't you give me some of your [c:g1]spells[c:]?", "不如给我些你的[c:g1]法术[c:]如何？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hm? Oh, hello again.. We still haven't been formally introduced.", "嗯？哦，又见面了…我们还没正式介绍过", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'll need one of your [c:g1]spells[c:] for my training..", "我需要一个你的[c:g1]法术[c:]来训练……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh.. Hello there.", "哦…你好啊", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The master asked me to practice my spellcasting..", "大师让我来练习法术……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh.. Spellcasting. Right..", "哦…法术练习。对……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "What? Oh.. This must be.. [c:g3]his[c:] area..", "什么？哦…这一定是…[c:g3]他[c:]的地盘……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Well, anyway.. The master asked me to train my spellcasting.", "好吧不管怎样…大师让我来练习法术……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm..?", "嗯…？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Here already? We haven't even battled..", "这么快？我们还没对战过……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Well anyways, just hand over a [c:g1]spell[c:].", "总之，交出一个[c:g1]法术[c:]就行……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Oh.. You don't have any spells?", "哦…你一个法术都没有吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I guess I could give you one of my upgraded ones.. Hopefully they're good.", "也许我可以给你一个强化过的…希望我的这些足够强……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Now your spell will last forever..", "现在，你的法术将永世长存……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "So, you truly wish to release that tyrant..", "所以，你当真要释放那个暴君……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I hope you understand the type of power you are dealing with..", "希望你明白自己正在染指何种力量……", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                foreach (var kvp2 in Abilities)
                {
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + kvp.Key + " is now free of its " + kvp2.Key + "...", "你的" + kvp.Value + "现已摆脱了" + kvp2.Value + "的束缚……", Language.ChineseSimplified);
                }
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm.. The essence of that sigil does not resonate with your card..", "嗯……该印记的精髓与你的卡牌并不契合……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "..It appears nothing was gained", "……看来一无所获", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The essence of the sigil has imbued the card with more power.", "印记的精髓使卡牌获得了更多能量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The essence of the sigil has imbued the card with more gourd.", "印记的精髓使卡牌获得了更多脑瓜", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The essence of the sigil has imbued the card with more strength.", "印记的精髓使卡牌获得了更多力量", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmph.. My bleach.. failed?", "哼……我的漂白剂……失效了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Was this your doing, challenger?", "这是你的手笔吗，挑战者？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmph..", "哼……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select a card to imbue with a lost sigils strength..", "选择一张卡牌漂白印记，并灌注等同于已失去印记的力量……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Here I will allow you to [c:g1]bleach[c:] a card of one of its sigils..", "在此我将允许你[c:g1]漂白[c:]一张卡牌的某个印记……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When bleached, the card will imbue the power of its lost sigil,", "被漂白后，该卡牌将继承已失去印记的力量，", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "and get much [c:g2]stronger[c:] depending on the sigils raw strength.", "并根据印记的原始强度变得[c:g2]更强[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ah, but your [c:g1]spell book[c:] is full...", "啊，但你的[c:g1]法术书[c:]已经满了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You step foot into a small store.. A brief respite from your winding travels.", "你踏入一家小店…漫长旅途中的短暂休憩", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You step foot into a small store...", "你踏入一家小店……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your [c:g1]deck[c:] is stored in this pile.. ", "你的[c:g1]牌组[c:]存放在这堆卡牌中……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, ".. And your [c:g1]side deck[c:] is stored here, where you can adjust it as you see fit. ", "……而你的[c:g1]副牌组[c:]存放在此，可随时调整", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, ".. Hmmph, I guess it was not meant to be..", "…哼，看来缘分未到……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Twisted and warped by the fungi, a new card emerges. Only through pain can one grow…", "在真菌的扭曲与侵蚀下，一张新卡牌诞生了。唯有经历痛苦，方能成长……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Now the mushrooms require a card that they will attach.. Increasing the stats of the host.", "现在蘑菇们需要一张卡牌来寄生…从而提升宿主的属性", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You encounter the abnormally disgusting fungi that infests this dungeon.", "你遭遇了侵染地牢的异常恶心的真菌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It is said to possess strange properties..", "据说它们具有奇特的性质……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The mushrooms yearn for a card they can use as a.. [c:g1]host[c:] of sorts.", "这些蘑菇渴望找到一张能作为…[c:g1]宿主[c:]的卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "One that they will attack to.", "它们将依附其上", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You encounter the disgusting fungi yet again..", "你再次遭遇了那些恶心的真菌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The fungi yearn for a card they can use as a [c:g1]host[c:].. to attach to.", "真菌渴求着能作为[c:g1]宿主[c:]…来依附的卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Yet... It seems you do not have two cards worthy of the fungi's touch. Wearisome.", "然而……你似乎没有两张值得真菌触碰的卡牌。真扫兴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You have the honours of naming it.", "命名权就交给你了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Finished?", "完成了吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The [c:g1]cost[c:] and [c:g2]portrait[c:] I will handle myself..", "[c:g1]费用[c:]和[c:g2]肖像[c:]由我来处理", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It was nice meeting you, my student.", "很高兴认识你，我的学徒", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "But this is where we say farewell..", "但此刻我们该道别了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just hold still for a second.", "保持片刻别动", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I will base it off of cards in your deck.", "我会根据你牌组里的卡牌来决定。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "First, the stats.", "首先，是属性。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The [c:g1]sigils[c:].", "然后是[c:g1]印记[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmm.. You're out of paint.", "唔……你的颜料用完了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You can bleach your drawing.. or consider it finished.", "你可以漂白画作……或者就此收笔。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A neccesary part of each student's training is art..", "每位学徒的必修课都包含美术训练……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Let's start with the portrait..", "先从肖像画开始吧……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You can use the bleach on the left to wipe your work..", "左侧的漂白剂可用来擦除作品……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You are currently holding a [c:g1]replica brush[c:].. If you feel you need a smaller one, you can grab the one on the right.", "你正握着[c:g1]仿制画笔[c:]……若需要更细的笔，可取用右侧那支", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Use that brush in the back to change your color.", "用后排那支笔切换颜色", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My pupil's portraits never fail to amuse me..", "学徒们的肖像总能取悦我……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Now let's choose which card's [c:g1]stats[c:] to imbue.", "现在选择要为哪张卡的[c:g1]属性[c:]注入魔力", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Now, the [c:g1]sigils[c:].", "现在，是[c:g1]印记[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ah, but your spell book is full..", "啊，但你的法术书已经满了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Either discard this one...", "要么丢弃这张……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Or, remove one of your spells..", "要么移除你的一张法术……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You don't have any cards to use that [c:g1]potion[c:] on.", "没有可施加[c:g1]药剂[c:]的卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You won't have any cards to use that spell on.", "你已无卡牌可施法。", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your " + value + " wields no mana.", "你的" + value + "未持有魔力。", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "That doesn't have any mana.", "该单位未持有任何魔力。", Language.ChineseSimplified);
            foreach (var value in Cards.Values)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The " + value + " has no mana.", value + "未持有魔力。", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You can not draw mana from that.", "你无法从中汲取魔力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Through this maze of paintings and illusions, there may be some that deign to join your deck.\nChoose carefully.", "穿越这幅画作与幻象的迷宫，或有存在愿屈尊加入你的牌组\n认真选吧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "... Curious.", "……有点意思", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I thought I had completely removed this.. [c:g2]filth[c:].", "我还以为我已经彻底清除了这…[c:g2]污秽[c:]。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You humor me challenger..", "你倒挺会逗我开心啊，挑战者……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Did you expect your measely [c:g1]hammer[c:] to work on such a creature as the [c:g1]ouroberyl[c:]?", "你以为区区[c:g1]锤子[c:]能对[c:g1]衔宝蛇[c:]起作用？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "How foolish.", "何其愚蠢。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your hammer is now [c:g1]broken[c:], and may not be used for the remainder of the battle.", "你的锤子现已[c:g1]损毁[c:]，本场战斗无法再使用。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems that you lost..", "看来你输了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "See this portrait?", "看到这幅肖像了吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This portrait will act as your life counter.", "这幅肖像将作为你的生命计数器。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Once all the [c:g1]m[c:][c:g2]o[c:][c:g3]x[c:] [c:g1]g[c:][c:g2]e[c:][c:g3]m[c:][c:g1]s[c:] go out.. You lose the game.", "当所有[c:g1]玛[c:][c:g2]珂[c:][c:g3]宝[c:][c:g1]石[c:]熄灭时…你就输了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Since you lost.. I will have to remove one gem.", "既然你输了…我得移除一颗宝石。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The deed has been done.", "事情已成定局。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Looks like you have been knocked down by your opponent.", "看来你被对手击倒了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stand tall, and continue forth.", "挺直腰杆，继续前进。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems as though you should study up on mox.", "看来你该好好研究下玛珂了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though you should not lose hope, as you still have 2 more lives.", "但别绝望，你还有两次机会。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You make a last effort to succeed, yet fail. It seems you lose, again.", "你做了最后挣扎却仍失败。看来你又输了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You shall continue forward.", "你应当继续前进。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It takes just one more blow for you to fall to the ground.", "再受一击你就会倒下。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Losing a life, you must continue forward.", "失去一条命后，你必须继续前进。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It seems the show shall end… for now..", "看来表演该落幕了…暂时如此……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Just what is going on here?", "这到底是怎么回事？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "'Master Magnus'..", "“至尊大师”……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "There is [c:g2]NO[c:] such master!", "根本[c:g2]没有[c:]这号大师！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Argh.. I guess, if you truly wish to play with such additions, I am truly unable to stop you.", "呃……若你执意要玩这些把戏，我确实无力阻止。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Though, I do NOT approve of this.", "但我绝不认可这种行为。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "It appears that the ficticious Master Magnus has showed itself.", "看来那个虚构的至尊大师现身了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "That horrid [c:g1]thing[c:] rears it's ugly head.", "那[c:g1]怪物[c:]正探出它丑陋的脑袋。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The released Master Magnus approaches.", "解缚的至尊大师正在逼近。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Careful. That horrible master is here.", "当心，那个可怕的大师来了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Master Magnus has arrived. Be cautious.", "至尊大师已至，务必小心", Language.ChineseSimplified);
            foreach (var kvp in Cards)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You glance at a " + kvp.Key + ". " + CardsDescription[kvp.Key].Key, "你瞥见一张" + kvp.Value + "。" + CardsDescription[kvp.Key].Value, Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A " + kvp.Key + " appears from within the portrait. " + CardsDescription[kvp.Key].Key, kvp.Value + "从肖像画中浮现。" + CardsDescription[kvp.Key].Value, Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You gaze at a " + kvp.Key + ". " + CardsDescription[kvp.Key].Key, "你凝视着一张" + kvp.Value + "。" + CardsDescription[kvp.Key].Value, Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You glance at an " + kvp.Key + ". " + CardsDescription[kvp.Key].Key, "你瞥见一张" + kvp.Value + "。" + CardsDescription[kvp.Key].Value, Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An " + kvp.Key + " appears from within the portrait. " + CardsDescription[kvp.Key].Key, kvp.Value + "从肖像画中浮现。" + CardsDescription[kvp.Key].Value, Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You gaze at an " + kvp.Key + ". " + CardsDescription[kvp.Key].Key, "你凝视着一张" + kvp.Value + "。" + CardsDescription[kvp.Key].Value, Language.ChineseSimplified);
            }

            // ShowThenClear
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Choose wisely.", "认真选吧", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "ARRGH!!!", "呃啊！！！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]STRIKE![c:]", "[c:g1]攻击！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]STRIKE![c:]", "[c:g2]攻击！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Au Revoir", "永别了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "How reckless.", "真是鲁莽。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, ";Hmm.. I see..", "唔……我明白了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "But you'll [c:g2]NEVER[c:] delete me, the Scrybe of Magicks!", "但你[c:g2]永远[c:]无法删除我——魔法冥刻者！", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GRRAHH!!", "嘎啊啊啊！！", Language.ChineseSimplified);
            Dictionary<GemType, string> gemTypes = new Dictionary<GemType, string>
            {
                { GemType.Orange, "橙色" },
                { GemType.Blue, "蓝色" },
                { GemType.Green, "绿色" },
            };
            foreach (var gemType in gemTypes.Keys)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You don't have two " + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color> gems to play that.", "你的" + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color>玛珂不足两颗，无法使用此牌", Language.ChineseSimplified);
                foreach (var value in Cards.Values)
                {
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You'll need two " + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color> gems to play your " + value + ".", "需要两颗" + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color>玛珂才能使用你的" + value, Language.ChineseSimplified);
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You don't have enough " + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color> gems on the board to play that " + value + ".", "牌桌上的" + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color>玛珂数量不足，无法使用这张" + value, Language.ChineseSimplified);
                }
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You need two " + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color> gems on the board.", "牌桌上需要有两颗" + HintsHandler.GetColorCodeForGem(gemType) + Localization.Translate(gemType.ToString()) + "</color>玛珂", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You need at least one [v:1] gem on the board to play that [v:0].", "牌桌上至少需有一颗[v:1]宝石才能使用这张[v:0]。", Language.ChineseSimplified); // 原版翻译修正

            // ShowMessage
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "whats up", "咋了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My [c:g1]Goo Mage[c:] falls by your hands.. I expected more from him..", "我的[c:g1]黏液法师[c:]败于你手……我本对他期望更高些……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hmph.. My [c:g1]Goo Mage[c:] dissapoints me again..", "哼……我的[c:g1]黏液法师[c:]又一次让我失望……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Yet again, my pathetic [c:g1]Goo Mage[c:] falls..", "再一次，我可怜的[c:g1]黏液法师[c:]倒下了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]What..?[c:] [c:g2]Me,[c:] [c:g1]defeated..?[c:]", "[c:g1]什么……？[c:][c:g2]我，[c:][c:g1]败了……？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Blargh..[c:] [c:g2]I've[c:] [c:g1]been[c:] [c:g2]taken[c:] [c:g1]out[c:] [c:g2]by[c:] [c:g1]you??[c:] ", "[c:g1]呃啊……[c:][c:g2]我[c:][c:g1]被[c:][c:g2]你[c:][c:g1]击败了？？[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Impossible..[c:] [c:g2]I've[c:] [c:g1]been[c:] [c:g2]defeated..[c:]", "[c:g1]不可能……[c:][c:g2]我[c:][c:g1]居然[c:][c:g2]输了……[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ahh.. I see you've defeated my [c:g2]Pike Mage[c:]..", "啊……看来你打败了我的[c:g2]长矛法师[c:]……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My [c:g2]Pike Mage[c:] falls.. Dissapointing.", "我的[c:g2]长矛法师[c:]倒下了……真令人失望", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I'll admit challenger.. You've gotten farther than most.", "我承认挑战者……你比大多数人都走得更远", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]A[c:] [c:g3]fantastic[c:] [c:g2]duel[c:] [c:g3]we[c:] [c:g2]had![c:]", "[c:g2]真是[c:][c:g3]一场[c:][c:g2]精彩[c:][c:g3]对决[c:][c:g2]啊！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]'Twas[c:] [c:g3]an[c:] [c:g2]excellent[c:] [c:g3]battle.[c:]", "[c:g2]这[c:][c:g3]是[c:][c:g2]场[c:][c:g3]绝妙[c:][c:g2]战斗[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Great[c:] [c:g3]fighting,[c:] [c:g2]young[c:] [c:g3]mage.[c:]", "[c:g2]打[c:][c:g3]得[c:][c:g2]漂亮[c:][c:g3]年轻法师[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Well challenger.. Now that you have defeated the [c:g3]Lonely Mage[c:]. You may now face me.", "很好挑战者……既然你已击败[c:g3]孤独巫师[c:]，现在可以面对我了", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You've defeated all my students.. I will await your arrival.", "你已击败我所有学徒……我将恭候你的到来", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My [c:g3]Lonely Mage[c:] falls.. this is unexpected.. But now, I await your arrival.", "我的[c:g3]孤独巫师[c:]败北了……出乎意料……但现在，我静候你的到来", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]An[c:] [c:g1]excellent[c:] [c:g3]fight![c:]", "[c:g3]真是[c:][c:g1]场[c:][c:g3]精彩[c:][c:g1]较量！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Despite[c:] [c:g1]my[c:] [c:g3]deadliest[c:] [c:g1]books,[c:] [c:g3]you[c:] [c:g1]still[c:] [c:g3]won![c:]", "[c:g3]即便[c:][c:g1]动用[c:][c:g3]最致命的[c:][c:g1]典籍，[c:][c:g3]你仍[c:][c:g1]获胜了！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]You[c:] [c:g1]managed[c:] [c:g3]to[c:] [c:g1]overcome[c:] [c:g3]my[c:] [c:g1]deadliest[c:] [c:g3]tomes,[c:] [c:g1]impressive![c:]", "[c:g3]你竟[c:][c:g1]能[c:][c:g3]破解[c:][c:g1]我最[c:][c:g3]致命的[c:][c:g1]魔典，[c:][c:g3]令人[c:][c:g1]印象深刻！[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]Whoops![c:] [c:g1]Looks[c:] [c:g3]you[c:] [c:g1]need[c:] [c:g3]to[c:] [c:g1]study[c:] [c:g3]up[c:] [c:g1]on[c:] [c:g3]mox.[c:]", "[c:g3]哎哟！[c:][c:g1]看来[c:][c:g3]你[c:][c:g1]得[c:][c:g3]好好[c:][c:g1]钻研[c:][c:g3]玛珂[c:][c:g1]了[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "My Pike Mage bests another opponent...", "我的长矛法师又击败了一个对手……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dissapointing...", "太令人失望了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g1]Yet[c:] [c:g2]another[c:] [c:g1]soul[c:] [c:g2]I[c:] [c:g1]claim.[c:] [c:g2]Banish[c:] [c:g1]yourself[c:] [c:g2]to[c:] [c:g1]the[c:] [c:g2]depths,[c:] [c:g1]and[c:] [c:g2]do[c:] [c:g1]not[c:] [c:g2]return.[c:]", "[c:g1]又[c:][c:g2]一个[c:][c:g1]灵魂[c:][c:g2]归[c:][c:g1]我[c:][c:g2]所有[c:][c:g1]了。[c:][c:g2]滚[c:][c:g1]去[c:][c:g2]深渊[c:][c:g1]吧，[c:][c:g2]永远[c:][c:g1]别[c:][c:g2]回来[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Yet another student, hit off guard by my Lonely Mage..", "又一位学徒，被我的孤独巫师偷袭得手……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You got so far.....", "你都走到这一步了……", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Weak.", "真弱。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g2]Farewell,[c:] [c:g3]young[c:] [c:g2]mage![c:] [c:g3]'Twas[c:] [c:g2]a[c:] [c:g3]fantastic[c:] [c:g2]duel.[c:]", "[c:g2]再会了，[c:][c:g3]年轻的[c:][c:g2]法师！[c:][c:g3]真是[c:][c:g2]一场[c:][c:g3]精彩[c:][c:g2]对决。[c:]", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "~ Goo Dungeon ~", "~ 黏液地牢 ~", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "~ Lava Dungeon ~", "~ 熔岩地牢 ~", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "~ Void Dungeon ~", "~ 虚空地牢 ~", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "~ Tower of Magicks ~", "~ 魔法之塔 ~", Language.ChineseSimplified);
            for (int currency = 0; currency <= 100; currency++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "[c:g3]~ " + currency + " Crystals ~[c:]", "[c:g3]~ " + currency + "枚水晶 ~[c:]", Language.ChineseSimplified);
            }

            // Challenge
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Blank Mox", "空白玛珂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your sidedeck's mox is completely random.", "你的副牌组玛珂效果完全随机", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Weaker Bleach", "弱漂白剂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Bleaching Event can no longer remove negative sigils.", "漂白事件将不再能移除负面印记", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Turn Wipeout", "回合崩盘", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When you ring the bell past turn 6 (12 on bosses) you take 1 damage.", "若在第6回合后（首领战为第12回合）敲换手铃，你将受到1点伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stronger Opponent", "更强对手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your battle opponent starts with 5 extra health points.", "对战对手初始额外获得5点生命值", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Tiny Spellbook", "微型法术书", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your spellbook can only hold 4 spells instead of 8.", "你的法术书只能容纳4个法术，而非8个", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Displeased Spirits", "怨灵缠身", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The enchanted grounds will always be displeased.", "这片被诅咒的土地永远充满怨念", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Armored Shell", "坚甲之壳", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Your opponent cant take more than 4 damage per turn.", "每回合敌方最多承受4点伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Iron Maiden", "铁处女", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every turn, each mox on your side of the board takes 1 damage.", "每回合开始时，持牌人侧牌桌上的每张玛珂牌会受到1点伤害", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magickal Paint", "魔法涂料", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Queued cards will occasionally get additional sigils painted on them.", "待出卡牌偶尔会被额外绘制上印记", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fleeting Life", "转瞬生命", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "You have 75 health, but it does not replenish inbetween battles.", "初始生命值为75，但战斗间不会恢复", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Intrusive Presence", "侵扰之影", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An unwelcome prescence will follow you into card battles.", "不受欢迎的存在将跟随你进入卡牌对战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Master Bosses", "大师头目", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every bossfight is replaced with one of the Mox Masters.", "所有头目战都会替换为玛珂大师之一", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Gem Dependant Starters", "宝石依赖的开局", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cards in your starting deck have the gem dependant sigil.", "起始手牌中的卡牌均带有宝石依赖印记", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magnificus Challenge Level: {0}", "蔓尼菲科挑战关卡：{0}", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Magnificus Challenge Points: {0}", "蔓尼菲科挑战点数：{0}", Language.ChineseSimplified);

        }
    }

    public class UndeadTempleINKCMMod
    {

        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for UndeadTempleINKCM Mod");
            // Card
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Banshee", "觉醒的女妖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A pile of bones, paying for bones in exchange for strength.", "一堆骨头，用骨头换取力量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Bone Heap", "觉醒的骨堆", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Bonehound", "觉醒的寻骨猎犬", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Even after being dead, it remains loyal.", "即使死了，它仍然忠诚。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Dead Hand", "觉醒的死人手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The hand of death, but with life.", "死亡之手，却于苍生长存。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Draugr", "觉醒的尸鬼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frozen ghouls, break and come out.", "冰封的恶魔，出来吧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened DrownedSoul", "觉醒的淹死鬼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The drowned soul wanders with resentment in the water.", "溺水的灵魂带着怨恨在水中游荡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Family", "觉醒的行师走人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A family that died unexpectedly.", "意外死亡的家庭。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Frankenstein.", "科学怪人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A ghost ship that produces a steady stream of skeletons.", "产生源源不断的骷髅的幽灵船。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Ghost Ship", "觉醒的幽灵船", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Frank & Stein", "觉醒的弗兰肯和斯坦", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Gravedigger", "觉醒的掘墓人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A diligent gravedigger, he constantly supplies bones.", "作为一个勤劳的掘墓人，他不断地提供骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Death Knight, the assassin in hell.", "死亡骑士，地狱中的刺客。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Knight", "觉醒骑士", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Horn", "觉醒的号角", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "the bonelord sheds its old horns, they take on a life of their own, to one day usurp their masters.", "骨王摆脱了它的旧角，开始了自己的魔生，有朝一日将篡夺其主。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mummy God", "木乃伊之神", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The King of Terror.", "此乃恐怖之王。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Necromancer", "觉醒的死灵法师", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Born solely for revenge.", "生来就是为了复仇。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Revenant", "觉醒的复生亡灵", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A formidable sarcophagus with terrifying creations sealed inside.", "一个可怕的石棺，里面封印着恶魔。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Pile", "一堆骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Bone Pile", "觉醒的一堆骨头", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Tomb Robber", "觉醒的盗墓贼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Even if he dies, he still robs tombs.", "即使死了，仍然盗墓。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A desperate man.", "一个绝望之人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Zombie", "觉醒的丧尸", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Devouring Soul", "噬魂亡灵", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A skeleton devouring the soul.", "一个噬魂的骷髅。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Devouring Soul", "觉醒的噬魂亡灵", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Dead Eye", "觉醒的死人眼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Both Deadeye and Dead Hand are said to be body parts of the same, now dead, god.", "与死人手一同，犹如某个神的一部分身体。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ferry Crow", "渡灵骨鸦", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Ferry Crow", "觉醒的渡灵骨鸦", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The mournful cry of looking down upon the undead after death.", "死亡的灵鸦，俯视众生的哀嚎", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grave", "墓碑", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I hope no one will disturb it.", "我希望不会有人来打扰它", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Headless Man", "无头人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An incompetent headless person, as if searching for something he had lost.", "一个不称职的无头人，好像在寻找他丢失的东西。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Kennel", "觉醒的犬舍", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A dog house, hopefully no one will mess with the things inside.", "一个犬舍，希望没人会打扰里面的东西。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pharmacist", "药剂师", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Pharmacist", "觉醒的药剂师", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A dead pharmacist who poisons all creations that oppose him.", "一个死去的药剂师，他将毒死所有反对他的造物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeleader", "亡灵领袖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A skeleton leader, once on stage, is surrounded by skeletons.", "亡灵领袖一旦上场，便会被骷髅包围。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Skeleader", "觉醒的亡灵领袖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeleton Sniper", "骷髅狙击手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A dead sniper.", "一位死去的狙击手。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Skeleton Sniper", "觉醒的骷髅狙击手", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Threaded Skeleton", "欺诈者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Some people are born puppets, while others still control others after death.", "有些人生来就是傀儡，有些人死后仍掌控他人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Threaded Skeleton", "觉醒的欺诈者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undead Elk", "不死麋鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The undead elk, a former husk of of what it once was.", "不死麋鹿，生前的躯壳。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undead Elk Cub", "不死小麋鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Even death carries vitality and desire.", "甚至死后也带着活力和欲望。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undead Moose", "不死驼鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A rotting carcass of a long-departed imposing beast.", "一具久已逝去的雄伟野兽腐烂的尸体。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Undead Moose", "觉醒的不死驼鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undead Predator", "劫掠亡灵", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Warriors who die in war will never bow down.", "在战争中牺牲的战士永远不会屈服。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Undead Predator", "觉醒的劫掠亡灵", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undead RedHart", "不死红鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "its decaying mind retains the strength of sacrifice.", "它腐朽的心灵保留着牺牲的力量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Undead RedHart", "觉醒的不死红鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Undead Snapper", "鳄龟残骸", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Awakened Undead Snapper", "觉醒的鳄龟残骸", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The corpse of a stiff terrestrial creation.", "僵硬的陆地生物的尸体。", Language.ChineseSimplified);


            // Ability / Pack
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Skeleader", "亡灵领袖", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When placing [creature], skeleton cards will appear in nearby empty spaces. Skeleton has: 1 power, 1 health, Brittle.", "当放置[creature]时，骷髅牌将出现在相邻的空位。骷髅有：1力量，1生命，脆骨。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Original Undead Card", "原版亡灵部落卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The cards for the Undead Tribe are in the original game.(ACT2)", "原版第二幕中的亡灵部落卡包。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "NonOriginal Undead Card", "非原版亡灵部落卡包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The expansion cards for the Undead Tribe are not in the original game.", "由模组作者原创的非原版亡灵部落卡包。", Language.ChineseSimplified);

        }
    }

    public class WildernessLegendMod
    {

        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for WildernessLegend Mod");
            // Card
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Amalgam Pup", "缝合兽幼崽", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When you grow up, you can see that it is terrible.", "当其长大之后，你便能知晓其可怕之处。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chicken", "鸡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dud Egg", "废物蛋", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An egg that doesn't grow? Maybe you can help it.", "一颗无法成长的蛋？你能帮帮它吗？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Funny chiking", "有趣的鸡", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A very stinky chicken, but it has a sharp beak.", "一只很臭的鸡，但它有着锋利的喙。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Roc", "大鹏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stinky Chiking", "臭鸡丁", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Every chicken has a dream.", "每一只小鸡都有梦想。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Annoying Dog", "神烦狗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Such an annoying dog, perhaps, is the author of a certain pixel game.", "这样一只讨厌的狗，也许是某个像素游戏的作者。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Arctic Fox", "北极狐", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A solitary Vulpes lagopus with great strength.", "一只孤独的、具有神力的北极狐。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone Dog", "寻骨小狗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Running and running, just to find its bones.", "跑来跑去，只为了找到它的骨头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Fox", "狐狸", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hyena", "鬣狗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bone seeking bandits in the wilderness.", "荒野中的寻骨强盗。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The Loky", "狼王洛基", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The king of the whole pack of wolves, very, very powerful.", "狼中之王，非常非常强大。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pastoral Dog", "中华田园犬", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Loyal Chinese pastoral dogs, they guard and protect their owners' houses.", "忠诚的中华田园犬，守卫和保护主人的房子。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spotted Hyena", "斑鬣狗", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Spotted hyenas searching for bones, they grow stronger with their thirst for blood.", "斑鬣狗寻找骨头，它们因渴望血液而变得更强壮。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lion", "狮子", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A strong lion with a fairly strong attack.", "攻击力相当强的健壮狮子。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lioness", "雌狮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The lioness guarding the lion herd are always on guard against external invasions.", "守护狮子群的母狮总是警惕外来入侵。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Lynx", "猞猁", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The solitary Lynx attacks with its sharp claws and teeth.", "孤独的猞猁用锋利的爪子和牙齿攻击。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Puma", "美洲狮", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Strong Puma, the leader among feline animals.", "强壮的美洲狮，猫科动物中的领头。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Puma Cub", "美洲狮幼崽", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The immature Puma cub. It will grow into a Puma after a turn.", "幼年的美洲狮幼崽。它一回合就会长成一只美洲狮。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Thunder Tiger", "雷虎", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They came with thunder and then suddenly left.", "它随雷声而来，然后忽的离去。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Axolotl", "美西螈", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This cute little guy has a very special tail.", "这个可爱的小家伙有一条非常特别的尾巴。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Axolotl Tail", "美西螈尾巴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Carp", "鲤鱼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The fish in the Chinese totem is said to have unfathomable powers.", "中国图腾中的鲤鱼据说有着不可估量的力量。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Coral Polyp", "珊瑚虫", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They coexist with the terrain.", "它们与地形相伴相生。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Globefish", "河豚", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Any creature that dreams of harming it will regret it.", "任何想伤害它的生物都会后悔的。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Shark Egg", "鲨鱼蛋", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "I've never seen a shark egg look like this before.", "我从来没见过鲨鱼蛋，原来长这样。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Squidge", "鱿鱼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "What kind of creature will the little one grow into?", "这个小家伙会长成什么样的造物？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Poor little ones......", "可怜的小家伙们....", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Joannes", "约安尼斯", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A peculiar creature that only exists in nightmares.", "一种只存在于噩梦中的奇特生物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "God Joannes", "约安尼斯神", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Miemie Method", "方法放寒假", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A little cute who can write code.", "一只会写代码的小可爱。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Potato Elk", "土豆鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The potatoes have sprouted.", "如今土豆已经发芽了。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Potato Elk Cub", "土豆小鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A deer with potatoes on its antlers, it seems that the potato is the owner.", "一只鹿角上有土豆的小鹿，看起来土豆才是它的主人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wapiti", "马鹿", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A strong and vital deer.", "强壮而有活力的鹿。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cicada", "蝉", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They gather in groups, calling on friends, which is annoying.", "它们聚在一起，走亲访友，这很烦人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dragonfly", "蜻蜓", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Dragonflies that point to where to hit.", "指哪打哪的蜻蜓。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Giant Centipede", "巨人蜈蚣", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The giant centipedes hidden deep underground use their sharp fangs to defend their territory.", "隐藏在地下深处的巨型蜈蚣用锋利的尖牙保卫自己的领地。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Leafcutter ant", "切叶蚁", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "They have sharp claws.", "它们有锋利的爪子。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Locust swarms", "蝗虫群", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A large number of locusts swept in, and it was a disaster for the peasants.", "大批蝗虫飞来，对农民来说是一场灾难。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Shield bug", "臭蝽", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Disgusting stink bugs, no one wants to approach them.", "恶心的臭蝽，没人想接近它们。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soldier Ant", "军蚁", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Soldier Ant that point to where to hit.", "指哪打哪的军蚁。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Acorn", "橡果", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Armadillo", "犰狳", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The 'Shield Dwarves' of the wilderness have both offense and defense when curled up.", "荒野中的“坚盾矮人”，蜷缩在一起时攻防兼备。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CowBoy", "西部牛仔", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The skilled marksman cowboy who hits every shot.", "百发百中的神枪手牛仔。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Elephant", "大象", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The largest creation on land, it has tenacious vitality and defense.", "陆地上最大的创造物，它有顽强的生命力和防御力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Grizzly Cub", "灰熊幼崽", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The little bear has not yet grown up, but it is already prepared to face the darkness.", "小熊还没有长大，但它已经准备好面对黑暗。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Honey badger", "蜜獾", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The vengeful honey badgers never feel afraid.", "复仇心强的蜜獾从不畏惧。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Meerkat", "猫鼬", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The watchful Meerkat, it attacks swiftly upon detecting a threat.", "警惕的猫鼬，一旦发现威胁就迅速攻击。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Mongoose", "狐獴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The incorruptable Mongoose is resistent to most toxins.", "永不腐败的狐獴对大多数毒素都有抵抗力。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Stunted Grizzly", "弱熊", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Such a poor, scarred beast- what must have befallen it?", "这么一只可怜的、伤痕累累的野兽，它怎么了？", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Uri", "小毛球", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Abandoned children learn to be independent outside.", "被遗弃的孩子将在野外学会独立。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Uryli", "野人", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A wild man who has learned to be independent.", "学会了独立的野人。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Chipmunk", "花栗鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A small striped rodent of the forest, carrying an acorn with it as a meal.", "森林中的一种带条纹的小啮齿动物，带着橡子作为食物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Pushing Mouse", "推推鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A huge southern mouse.", "一只巨大的南方老鼠。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rat Cub", "鼠崽", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A weak rat can grow into a noble rat king.", "弱小的老鼠可以成长为高贵的鼠王。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Buff Frog", "变异牛蛙", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A mutated frog that has gained power.", "获得力量的变异青蛙。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "God Frog", "变异牛蛙神", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Creeper", "苦力怕", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A terrifying creature from the world of Minecraft.", "我的世界里的可怕生物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Crocodile", "鳄鱼", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "An animal with a strong biting force.", "有很强咬合力的动物。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Rattler egg", "响尾蛇蛋", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A snake egg that is about to hatch, although it is very fragile.", "即将孵化的蛇卵，虽然很脆弱。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sea Turtle", "大海龟", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Vibrant sea turtles will not die even after being sacrificed.", "生命力顽强的海龟即使被献祭也不会死亡。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Thorny Devil", "刺蜥", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This guy's characteristics are just like its name.", "这家伙的性格和名字一模一样。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Thorny Devil Tail", "刺蜥的尾巴", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Free Rattler egg", "免费响尾蛇蛋", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Amalgam Egg", "缝合蛋", Language.ChineseSimplified);

            // Other
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Wilderness Legend", "荒野传说", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Add some simple cards based on the original imprint.", "在原有印记的基础上添加一些简单的卡片。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Acorns", "找寻橡果", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When placing [creature], draw an acorn.", "当放置[creature]时，获得一张橡果卡牌。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cutting Wings", "剪翼者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Flying cards struck by [creature] will take 1 damage each time it declares an attack, and renders their wings useless.", "被[creature]击中的带有空袭印记的造物每次宣告攻击时将受到1点伤害，并使其空袭印记失效。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Swarm", "鸣蝉之夏", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "when [creature] is placed, the remaining slots on the owner's side are filled with cicadas", "当[creature]被放置时，持牌人一侧的剩余空位将被蝉群填满。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Terrain Creator", "地形创建者", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "When placing [creature] on the field, randomly draw a terrain card.", "将[creature]放置到场上时，随机抽取一张地形卡。", Language.ChineseSimplified);

        }
    }

    public class OriginalModifiedMod
    {

        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for OriginalModified Mod");
            // All
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Amoeba Squirrel", "阿米巴松鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Annoying Aquasquirrel", "恼人水松鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bloody Stone", "献祭之石", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Explosion Aquasquirrel", "自爆水松鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Explosion Squirrel", "自爆松鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Killer Bee", "杀人蜂", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Quality Squirrel", "优质松鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Reach Squirrel", "高跳松鼠", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Sacrificable Boulder", "可祭磐石", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Tail Squirrel", "长尾松鼠", Language.ChineseSimplified);


        }
    }
    public class CustomSideDeck
    {

        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for CustomSideDeck Mod");
            // Config
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "How the mod should handle side deck card backs for side decks that don't add their own custom card back. If enabled, automatically generates a unique card back based on the side deck's main card's portrait. Otherwise, the default squirrel back will be used.", "模组作者应该如何处理副牌组的卡牌背面，不添加自己的自定义卡背面。如果启用，将根据副牌的卡面自动生成唯一的卡牌背面纹理。否则，将使用默认的松鼠卡背纹理。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Whether to automatically add an Aqua version of all custom side decks. Buggy, not recommended.", "是否自动添加所有自定义副牌组的水生版本。不推荐。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Whether or not Aquasquirrels and custom side decks marked as `CSDIsAqua` should be shown as options even when the Squirrel Fish challenge isn't on.", "即使松鼠鱼挑战未开启，是否应将水生松鼠和标记为“仅水生”的自定义副牌组显示为选项。", Language.ChineseSimplified);

            // ShowText
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select Side Deck", "选择副牌组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Configure Side Deck", "配置副牌组", Language.ChineseSimplified);
            for (int point = 0; point <= 100; point++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CURRENT SIDE DECK: <color=#eef4c6>" + point.ToString() + "</color> Challenge Points", "当前副牌组：<color=#eef4c6>" + point.ToString() + "</color>挑战点数", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "CURRENT SIDE DECK: <color=#eef4c6>+" + point.ToString() + "</color> Challenge Points", "当前副牌组：<color=#eef4c6>" + point.ToString() + "</color>挑战点数", Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Total Challenge Points: <color=#eef4c6>" + point.ToString() + "</color>", "总挑战点数：<color=#eef4c6>" + point.ToString() + "</color>", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "\nContains {0} cards", "\n包含{0}张卡牌", Language.ChineseSimplified); // todo

        }
    }

    public class PackManagement
    {

        public static Dictionary<string, string> EncountersTitle = new();
        public static Dictionary<string, KeyValuePair<string, string>> EncountersDescription = new();

        public static void RegisterEncounter(string en, string zh, string endes, string zhdes)
        {
            EncountersTitle.Add(en, zh);
            EncountersDescription.Add(en, new KeyValuePair<string, string>(endes, zhdes));
        }
        public static void RegisterTranslations()
        {
            Debug.Log("Registering Tanslations for PackManagement Mod");
            // SetText
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select Card Packs", "选择卡包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Select Encounter Packs", "选择遭遇战卡包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Choose Active Packs", "选择激活的卡包", Language.ChineseSimplified);

            // Packs
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inscryption: Beastly Card Expansion Pack", "邪恶冥刻：野兽卡牌扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The original set of cards featured in Leshy's cabin. Featuring wolves, mantises, and the occasional cockroach.", "莱西小屋中的原始卡牌系列。包含狼、螳螂以及偶尔出现的蟑螂。", Language.ChineseSimplified);
            RegisterEncounter("Inscryption: Beastly Card Expansion Pack", "邪恶冥刻：野兽卡牌扩展包", "The original set of cards featured in Leshy's cabin. Featuring wolves, mantises, and the occasional cockroach.", "莱西小屋中的原始卡牌系列。包含狼、螳螂以及偶尔出现的蟑螂。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inscryption: Techno Card Expansion Pack", "邪恶冥刻：科技卡牌扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The original set of robotic cards, exclusively using the energy mechanic.", "采用能量机制的原始机器人卡牌系列。", Language.ChineseSimplified);
            RegisterEncounter("Inscryption: Techno Card Expansion Pack", "邪恶冥刻：科技卡牌扩展包", "The original set of robotic cards, exclusively using the energy mechanic.", "采用能量机制的原始机器人卡牌系列。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inscryption: Undead Card Expansion Pack", "邪恶冥刻：死亡卡牌扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "GrimoraMod", "格里魔拉模组", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Powered by the bones of the dead, these cards have come back from the grave to fight for you.", "这些卡牌由亡者之骨驱动，从坟墓归来为你而战。", Language.ChineseSimplified);
            RegisterEncounter("Inscryption: Undead Card Expansion Pack", "邪恶冥刻：死亡卡牌扩展包", "Powered by the bones of the dead, these cards have come back from the grave to fight for you.", "这些卡牌由亡者之骨驱动，从坟墓归来为你而战。");
            RegisterEncounter("GrimoraMod", "格里魔拉模组", "", "");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inscryption: Magickal Card Expansion Pack", "邪恶冥刻：魔法卡牌扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Harness the might of the moxen to summon forth apprentices and fight in the most honorable of duels.", "驾驭玛珂之力召唤学徒，在最荣耀的决斗中作战。", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Harness the might of the moxen to summon forth apprentices and fight in the most honorable of duels. (Magnificus Mod Cards)", "驾驭玛珂之力召唤学徒，在最荣耀的决斗中作战。（蔓尼菲科模组卡牌）", Language.ChineseSimplified);
            RegisterEncounter("Inscryption: Magickal Card Expansion Pack", "邪恶冥刻：魔法卡牌扩展包", "Harness the might of the moxen to summon forth apprentices and fight in the most honorable of duels.", "驾驭玛珂之力召唤学徒，在最荣耀的决斗中作战。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Miscellaneous Community Cards", "社区杂项卡牌", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The unusual, unsorted, and unruly cards that have been added by mods but not properly sorted into packs.", "由模组添加但未妥善分类的非常规杂乱卡牌。", Language.ChineseSimplified);
            RegisterEncounter("Miscellaneous Community Cards", "社区杂项卡牌", "The unusual, unsorted, and unruly cards that have been added by mods but not properly sorted into packs.", "由模组添加但未妥善分类的非常规杂乱卡牌。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Inscryption: Beastly Encounters", "邪恶冥刻：野兽遭遇战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "The original set of [summary] that Leshy has carefully curated for the ideal gaming experience.", "莱西精心策划的包含[summary]的原始系列，旨在提供理想游戏体验。", Language.ChineseSimplified);
            RegisterEncounter("Inscryption: Beastly Encounters", "邪恶冥刻：野兽遭遇战", "The original set of [summary] that Leshy has carefully curated for the ideal gaming experience.", "莱西精心策划的包含[summary]的原始系列，旨在提供理想游戏体验。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Unsorted Regions and Encounters", "未分类区域与遭遇战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "These [summary] have been added by mods but not properly sorted into packs.", "这里的[summary]由模组添加但未妥善归类至卡包", Language.ChineseSimplified);
            RegisterEncounter("Unsorted Regions and Encounters", "未分类区域与遭遇战", "These [summary] have been added by mods but not properly sorted into packs.", "这里的[summary]由模组添加但未妥善归类至卡包");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Eri Card Expansion", "艾瑞卡牌扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "From the [randomcard] to the [randomcard], this pack contains [count] wild animals that feel right at home in the wild world of Inscryption.", "从[randomcard]到[randomcard]，此卡包内含[count]种野生动物，它们与《邪恶冥刻》的蛮荒世界完美契合。", Language.ChineseSimplified); // todo
            RegisterEncounter("Eri Card Expansion", "艾瑞卡牌扩展包", "From the [randomcard] to the [randomcard], this pack contains [count] wild animals that feel right at home in the wild world of Inscryption.", "从[randomcard]到[randomcard]，此卡包内含[count]种野生动物，它们与《邪恶冥刻》的蛮荒世界完美契合。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Ara's Card Expansion", "阿拉的卡牌扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This expansion contains [count] cards that offer a unique twist on Inscryption's core gameplay. Cards like [randomcard] and [randomcard] will give a little additional spice to your next run.", "该扩展包包含[count]张卡牌，为《邪恶冥刻》核心玩法带来独特变化。[randomcard]与[randomcard]等卡牌将为你的下次冒险增添别样趣味。", Language.ChineseSimplified); // todo
            RegisterEncounter("Ara's Card Expansion", "阿拉的卡牌扩展包", "This expansion contains [count] cards that offer a unique twist on Inscryption's core gameplay. Cards like [randomcard] and [randomcard] will give a little additional spice to your next run.", "该扩展包包含[count]张卡牌，为《邪恶冥刻》核心玩法带来独特变化。[randomcard]与[randomcard]等卡牌将为你的下次冒险增添别样趣味。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Hallownest Expansion", "圣巢扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "A large expansion containing [count] creatures from Hollow Knight. Up from peaceful Crossroads, down into the Abyss.", "大型扩展包，内含[count]种来自《空洞骑士》的生物。从宁静的十字路，下至深渊之底。", Language.ChineseSimplified); // todo
            RegisterEncounter("Hallownest Expansion", "圣巢扩展包", "A large expansion containing [count] creatures from Hollow Knight. Up from peaceful Crossroads, down into the Abyss.", "大型扩展包，内含[count]种来自《空洞骑士》的生物。从宁静的十字路，下至深渊之底。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bitty's Regions", "比蒂的区域扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Bitty's Regions adds [summary].", "比蒂的区域扩展包新增了[summary]。", Language.ChineseSimplified);
            RegisterEncounter("Bitty's Regions", "比蒂的区域扩展包", "Bitty's Regions adds [summary].", "比蒂的区域扩展包新增了[summary]。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Void Region Expansion", "虚空区域扩展包", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This region expansion from Void adds [summary].", "来自虚空的区域扩展包新增了[summary]。", Language.ChineseSimplified);
            RegisterEncounter("Void Region Expansion", "虚空区域扩展包", "This region expansion from Void adds [summary].", "来自虚空的区域扩展包新增了[summary]。");
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Eri's Card Pack Encounters", "艾瑞的卡包遭遇战", Language.ChineseSimplified);
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "This expansion adds [summary] featuring cards from Eri's Card Expansion.", "该扩展新增了[summary]，包含来自艾瑞卡牌扩展包的卡牌", Language.ChineseSimplified);
            RegisterEncounter("Eri's Card Pack Encounters", "艾瑞的卡包遭遇战", "This expansion adds [summary] featuring cards from Eri's Card Expansion.", "该扩展新增了[summary]，包含来自艾瑞卡牌扩展包的卡牌");
            RegisterEncounter("Original Undead Card", "原版亡灵部落卡牌", "The cards for the Undead Tribe are in the original game.(ACT2)", "原版第二幕中的亡灵部落卡包。"); // UndeadTempleINKCM
            RegisterEncounter("NonOriginal Undead Card", "非原版亡灵部落卡包", "The expansion cards for the Undead Tribe are not in the original game.", "由模组作者原创的非原版亡灵部落卡包。"); // UndeadTempleINKCM
            RegisterEncounter("Wilderness Legend", "荒野传说", "Add some simple cards based on the original imprint.", "在原有印记的基础上添加一些简单的卡片。"); // WildernessLegend
            RegisterEncounter("P03KCM", "P03KCM", "", ""); 
            foreach (var kvp in EncountersTitle)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Card Pack: " + kvp.Value, "卡包：" + kvp.Value, Language.ChineseSimplified);
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Encounters Pack: " + kvp.Value, "遭遇战卡包：" + kvp.Value, Language.ChineseSimplified);
                for (int count = 0; count <= 100; count++)
                {
                    LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Contains " + count + " encounters from " + kvp.Value + ".", "包含来自于" + kvp.Value + "的" + count + "场遭遇战。", Language.ChineseSimplified);
                }
            }
            for (int count = 0; count <= 100; count++)
            {
                LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Contains " + count + " encounters.", "包含" + count + "场遭遇战。", Language.ChineseSimplified);
            }
            LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, "Cards in this pack: {0} and {1} other{2}.", "包含：{0}以及更多的{1}张卡牌。", Language.ChineseSimplified); // todo
            //foreach (var kvp in EncountersDescription)
            //{
            //    Dictionary<string, string> ToTranslate = new();
            //    string template = "\nAverage Power Level: [powerlevel]";
            //    string templatezh = "\n平均强度等级：[powerlevel]";
            //    for (int i = 0; i < 3000; i++)
            //    {
            //        double value = i * 0.01;
            //        string replaced = template.Replace("[powerlevel]", value.ToString("F2"));
            //        string replacedzh = templatezh.Replace("[powerlevel]", value.ToString("F2"));
            //        ToTranslate[kvp.Value.Value.Replace("[name]", kvp.Key) + replaced] = kvp.Value.Value.Replace("[name]", EncountersTitle[kvp.Key]) + replacedzh;
            //    }
            //    Dictionary<string, string> ToTranslate2 = new();
            //    for (int region = 0; region <= 100; region++)
            //    {
            //        for (int encounter = 0; encounter <= 100; encounter++)
            //        {
            //            string rt = region.ToString() + " region";
            //            string rtt = region.ToString() + "个区域";
            //            string et = encounter.ToString() + " encounter";
            //            string ett = encounter.ToString() + "场遭遇战";
            //            if (region > 1)
            //            {
            //                rt += "s";
            //            }
            //            if (encounter > 1)
            //            {
            //                et += "s";
            //            }
            //            string st = rt + " and " + et;
            //            string stt = rtt + "和" + ett;
            //            foreach (var kvp2 in ToTranslate)
            //            {

            //                ToTranslate2[kvp2.Key.Replace("[encountercount]", et).Replace("[regioncount]", rt).Replace("[summary]", st)] = kvp2.Value.Replace("[encountercount]", ett).Replace("[regioncount]", rtt).Replace("[summary]", stt);
            //            }
            //        }
            //    }
            //    Dictionary<string, string> ToTranslate3 = new();
            //    for (int count = 0; count <= 100; count++)
            //    {
            //        foreach (var kvp3 in ToTranslate2)
            //        {
            //            ToTranslate3[kvp3.Key.Replace("[count]", count.ToString())] = kvp3.Value.Replace("[count]", count.ToString());
            //        }
            //    }
            //    foreach (var kvp4 in ToTranslate3)
            //    {
            //        LocalizationManager.Translate(SimplifiedChineseLanguagePackPlugin.GUID, null, kvp4.Key, kvp4.Value, Language.ChineseSimplified);
            //    }
            //}
        }
    }
}
