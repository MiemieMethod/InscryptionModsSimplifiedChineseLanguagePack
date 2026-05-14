using System.Collections.Generic;
using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch69
    {
        private static readonly Dictionary<string, string> ExpansionPack3Cards = new Dictionary<string, string>
        {
            { "Unpacker", "解包者" },
            { "Gunbot", "枪机" },
            { "KR4K3N", "机海妖" },
            { "Brain Cell", "脑胞" },
            { "Muscle Droid", "肌机" },
            { "D.A.N.N.Y.", "丹尼" },
            { "Butane Caster", "丁铸者" },
            { "Automatomaton", "自机" },
            { "Automatomatomaton", "再自机" },
            { "Demoted Automatomaton", "降自机" },
            { "Robipper", "机剥者" },
            { "GameKid", "戏机" },
            { "Green Energy Bot", "绿能机" },
            { "Molotov Launcher", "燃瓶机" },
            { "Tow Truck", "拖车" },
            { "Nitrous Tanker", "气罐车" },
            { "Bone Mill", "骨磨" },
            { "B4D A55", "坏胚" },
            { "Mucus Launcher", "涎机" },
            { "General Gunk", "黏将" },
            { "Gachabomb", "扭爆" },
            { "Submariner", "潜者" },
            { "Rot Latcher", "腐遗契者" },
            { "Time Latcher", "时遗契者" },
            { "Catapult", "抛车" },
            { "Cat-A-Pult", "猫抛车" },
            { "Synthesioid", "合成体" },
            { "Remote Detonator", "远爆器" },
            { "Scavenger", "拾荒者" },
            { "Corpse Looter", "尸掠者" },
            { "Looter Shooter", "掠射者" },
            { "Super Looter Shooter", "大掠射者" },
            { "Skin Droid", "皮机" },
            { "Emergence Latcher", "涌现遗契者" },
            { "Cottagecog", "屋齿" },
            { "Baristabot", "啡侍机" },
            { "Mystery Machine", "秘机" },
            { "Sticker King", "贴签王" },
            { "Booger Barrel", "涕桶" },
            { "Artificer", "巧工" },
            { "Gear Shifter", "齿移者" },
            { "Shrinker", "缩机" },
            { "Time Machine", "时机" },
            { "Open Sorcerer", "开术士" },
            { "Kiln", "炉" },
            { "Shield Projector", "盾射机" },
            { "Dredger Vessel", "挖泥皿" },
            { "Fuel Attendant", "司燃者" },
            { "Hot Rod", "烈车" },
            { "Bone Cracker", "碎骨者" },
            { "Hivemind", "蜂心" },
            { "Ramshackle", "残架" },
            { "N-GINN", "引擎机" },
            { "Iterator", "迭者" },
            { "Gas Generator", "燃气机" },
            { "Crypton", "密机" },
            { "UFO", "幽浮" },
        };

        public static void RegisterTranslations()
        {
            RegisterP03ExpansionPackThreeCardsAndDialogue();
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

        private static void RegisterP03ExpansionPackThreeCardsAndDialogue()
        {
            // 游戏小子
            AddTranslation("GameKid", "戏机");
            // 绿色能源机器人
            AddTranslation("Green Energy Bot", "绿能机");
            // 燃油弹发射器
            AddTranslation("Molotov Launcher", "燃瓶机");
            // 拖车机器人
            AddTranslation("Tow Truck", "拖车");
            // 氮气罐车
            AddTranslation("Nitrous Tanker", "气罐车");
            // 骨粉研磨机
            AddTranslation("Bone Mill", "骨磨");
            // 机械混蛋
            AddTranslation("B4D A55", "坏胚");
            // 黏液发射器
            AddTranslation("Mucus Launcher", "涎机");
            // 黏液将军
            AddTranslation("General Gunk", "黏将");
            // 扭蛋炸弹
            AddTranslation("Gachabomb", "扭爆");
            // 潜水员
            AddTranslation("Submariner", "潜者");
            // 腐化传递者
            AddTranslation("Rot Latcher", "腐遗契者");
            // 时间传递者
            AddTranslation("Time Latcher", "时遗契者");
            // 投石机
            AddTranslation("Catapult", "抛车");
            // 喵式投石机
            AddTranslation("Cat-A-Pult", "猫抛车");
            // 合成体
            AddTranslation("Synthesioid", "合成体");
            // 远程引爆器
            AddTranslation("Remote Detonator", "远爆器");
            // 拾荒者
            AddTranslation("Scavenger", "拾荒者");
            // 尸体劫掠者
            AddTranslation("Corpse Looter", "尸掠者");
            // 劫掠射手
            AddTranslation("Looter Shooter", "掠射者");
            // 超级劫掠射手
            AddTranslation("Super Looter Shooter", "大掠射者");
            // 皮肤机器人
            AddTranslation("Skin Droid", "皮机");
            // 奔涌传递者
            AddTranslation("Emergence Latcher", "涌现遗契者");
            // 小屋齿轮
            AddTranslation("Cottagecog", "屋齿");
            // 咖啡师机器人
            AddTranslation("Baristabot", "啡侍机");
            // 神秘机器
            AddTranslation("Mystery Machine", "秘机");
            // 贴纸之王
            AddTranslation("Sticker King", "贴签王");
            // 鼻涕桶
            AddTranslation("Booger Barrel", "涕桶");
            // 巧匠
            AddTranslation("Artificer", "巧工");
            // 齿轮变速器
            AddTranslation("Gear Shifter", "齿移者");
            // 缩小机器人
            AddTranslation("Shrinker", "缩机");
            // 时光机
            AddTranslation("Time Machine", "时机");
            // 开放术士
            AddTranslation("Open Sorcerer", "开术士");
            // 熔炉
            AddTranslation("Kiln", "炉");
            // 护盾投射器
            AddTranslation("Shield Projector", "盾射机");
            // 挖泥工容器
            AddTranslation("Dredger Vessel", "挖泥皿");
            // 燃料管理员
            AddTranslation("Fuel Attendant", "司燃者");
            // 飞车党
            AddTranslation("Hot Rod", "烈车");
            // 碎骨者
            AddTranslation("Bone Cracker", "碎骨者");
            // 蜂群意识
            AddTranslation("Hivemind", "蜂心");
            // 破铜烂铁
            AddTranslation("Ramshackle", "残架");
            // 引擎机器人
            AddTranslation("N-GINN", "引擎机");
            // 迭代器
            AddTranslation("Iterator", "迭者");
            // 燃气发电机
            AddTranslation("Gas Generator", "燃气机");
            // 加密战机
            AddTranslation("Crypton", "密机");
            // UFO
            AddTranslation("UFO", "幽浮");
            foreach (var value in ExpansionPack3Cards)
            {
                string name;
                string nameLoc;
                if (value.Key != null && value.Key.ToLowerInvariant().Contains("skel-e"))
                {
                    name = "Skel-E-" + value.Key.Replace(" ", "-");
                    nameLoc = value.Value + "枯骨";
                }
                else
                {
                    name = "Skele " + value.Key;
                    nameLoc = value.Value + "骨机";
                }

                AddTranslation(name, nameLoc);
                for (int score = 0; score <= 100; score++)
                {
                    AddTranslation(value.Key + " " + score.ToString() + ".0", value.Value + " " + score.ToString() + ".0");
                }
            }
            // 咕噜咕噜咕噜
            AddTranslation("Glug glug glug", "咕噜咕噜咕噜");
            // 我们好像有个触手问题
            AddTranslation("We seem to have a [c:bR]tentacle[c:] problem", "我等似有[c:bR]触手[c:]之患。");
            // 想帮忙的话就再跟我聊聊
            AddTranslation("If you want to help out, talk to me again.", "若欲相助，更与我言。");
            // 感谢你的帮助
            AddTranslation("Thank you for your help", "谢汝之助。");
            // 这里有3条触手需要被摧毁。
            AddTranslation("There are [c:bR]3[c:] tentacles that need to be destroyed.", "此有[c:bR]三[c:]触手，当毁之。");
            // 搞定之后再来找我。
            AddTranslation("Once you've done that, come talk to me again.", "既竟此，复来见我。");
            // 咕噜咕噜咕噜
            AddTranslation("Glug glug glug", "咕噜咕噜咕噜");
            // 你已经干掉了[v:0]条触手。
            AddTranslation("You have killed [c:bR][v:0][c:] tentacles.", "汝已毙[c:bR][v:0][c:]触手。");
            // 等你把它们全干掉再来见我。
            AddTranslation("See me once you've killed them all.", "尽毙之而后见我。");
            // 咕噜咕噜咕噜
            AddTranslation("Glug glug glug", "咕噜咕噜咕噜");
            // 触手的祸患已被抹除
            AddTranslation("The scourge of the tentacles has been erased", "触手之祸已除矣。");
            // 请收下这份谢礼
            AddTranslation("Please take this as a token of my gratitude.", "请受此以志我谢。");
            // 警告！警告！
            AddTranslation("[c:bR]WARNING! WARNING![c:]", "[c:bR]警！警！[c:]");
            // 该区域已发现不明飞行物
            AddTranslation("[c:bR]Unidentified flying objects[c:] have been spotted in the area", "此域已见[c:bR]不识之飞物[c:]。");
            // 你最好在它们返回前立即撤离
            AddTranslation("You should leave [c:bR]immediately[c:] before they return.", "彼辈未返之前，汝宜[c:bR]速[c:]去。");
            // 警告！警告！
            AddTranslation("[c:bR]WARNING! WARNING![c:]", "[c:bR]警！警！[c:]");
            // UFO正在接近！
            AddTranslation("The [c:bR]UFOs[c:] are arriving!", "[c:bR]幽浮[c:]将至矣！");
            // 恭喜！
            AddTranslation("[c:bR]CONGRATULATIONS![c:]", "[c:bR]贺矣！[c:]");
            // UFO已被击败！
            AddTranslation("The [c:bR]UFOs[c:] have been defeated!", "[c:bR]幽浮[c:]已败矣！");
            // 它们甚至还落下一架！
            AddTranslation("And they event left one behind!", "彼辈竟遗其一！");
            // 灾难！灾难！
            AddTranslation("[c:bR]DISASTER! DISASTER![c:]", "[c:bR]灾！灾！[c:]");
            // UFO们大获全胜！
            AddTranslation("The [c:bR]UFOs[c:] were victorious!", "[c:bR]幽浮[c:]大胜矣！");
            // 这次失败恐怕永远无法挽回了！
            AddTranslation("We may never recover from this failure!", "此败恐终不可复也！");
            // 咕噜咕噜咕噜
            AddTranslation("GLUG GLUG GLUG", "咕噜咕噜咕噜");
            // 对抗触手
            AddTranslation("FIGHT THE TENTACLES", "击触手");
            // 继续对抗触手
            AddTranslation("FIGHT THE TENTACLES", "续击触手");
            // 触手必死
            AddTranslation("DEATH TO THE TENTACLES", "触手必死");
            // 警告！！！
            AddTranslation("WARNING!!!", "警！！！");
            // 它们来了！！！
            AddTranslation("HERE THEY COME!!!", "彼至矣！！！");
            // 恭喜！！！
            AddTranslation("CONGRATULATIONS!!!", "贺矣！！！");
            // 灾难！！！
            AddTranslation("DISASTER!!!", "灾矣！！！");
        }
    }
}
