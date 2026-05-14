using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch5
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraLateBatch();
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

        private static void RegisterGrimoraLateBatch()
        {
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
        }
    }
}
