using System.Collections.Generic;
using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch73
    {
        public static void RegisterTranslations()
        {
            RegisterEndlessActTwoTwo();
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

        private static void RegisterEndlessActTwoTwo()
        {
            // 献祭亡灵卡牌会产生2根骨头而不是1根。
            AddTranslation("Sacrificing undead cards yields 2 bones instead of 1.", "祀亡牌则得骨二，不一。");
            // 当装备该奖励时，献祭亡灵卡牌会产生2根骨头而不是1根。
            AddTranslation("With this boon equipped, Sacrificing undead cards yields 2 bones instead of 1.", "有此惠，则祀亡牌得骨二，不一。");
            // 石中取血之奖
            AddTranslation("Boon of Bloodstone", "血石之惠");
            // 你可以献祭地形卡。
            AddTranslation("You may sacrifice terrain cards.", "地形牌可见祀。");
            // 当装备该奖励时，你可以献祭地形卡。
            AddTranslation("With this boon equipped, You may sacrifice terrain cards.", "有此惠，则地形牌可见祀。");
            // 衔尾蛇之奖
            AddTranslation("Boon of Ouroboros", "衔尾蛇之惠");
            // 根据区域不同，您会获得不同的效果：
            AddTranslation("You get a different effect depending on the region:\nBeast Dungeon:+2 Starting bones each battle.\nDeath Dungeon:+1 Starting Energy each battle\nTech Dungeon:Start the game with two random mox in your hand.\nMagick Dungeon:Start the game with 2 Squirrels in your hand.", "随所处之域而异其效：\n兽窟：每战始骨加二。\n死窟：每战始能加一。\n机窟：局始手得二偶玛珂。\n术窟：局始手得二松鼠。");
            // 当装备该奖励时，根据区域不同，您会获得不同的效果：
            AddTranslation("With this boon equipped, You get a different effect depending on the region:\nBeast Dungeon:+2 Starting bones each battle.\nDeath Dungeon:+1 Starting Energy each battle\nTech Dungeon:Start the game with two random mox in your hand.\nMagick Dungeon:Start the game with 2 Squirrels in your hand.", "有此惠，则随所处之域而异其效：\n兽窟：每战始骨加二。\n死窟：每战始能加一。\n机窟：局始手得二偶玛珂。\n术窟：局始手得二松鼠。");
            // 哎呀，你不能站在这儿。
            AddTranslation("Ay yo yaw cant stand right here", "汝不得立此。");
            // 大冷杉
            AddTranslation("Fir", "杉");
            // 墓石
            AddTranslation("Tombstone", "墓石");
            // 管道塔
            AddTranslation("Conduit Tower", "渠塔");
            // 损坏的机器人
            AddTranslation("Broken Bot", "废机");
            // 桥梁栏杆
            AddTranslation("Bridge Railing", "桥栏");
            // 绿宝磐石
            AddTranslation("Emerald Boulder", "绿玉磐");
            // 红宝磐石
            AddTranslation("Ruby Boulder", "红玉磐");
            // 蓝宝磐石
            AddTranslation("Sapphire Boulder", "蓝玉磐");
            // 赏金猎人
            AddTranslation("Bounty Hunter", "购捕者");
            // 哇哦，让所有的说唱歌手闭嘴。
            AddTranslation("Waddup, to all rappers shut up with your shutting up.", "诸饶舌者，其尽缄口。");
            // 我的伤……它们很严重。
            AddTranslation("My injuries.. They are severe.", "我之伤……甚矣。");
            // 看来我要在这里……提前退休了。
            AddTranslation("I am forced to retire.. for now.", "我今不得不退矣……姑尔。");
            // 啊！！你对我做了什么？
            AddTranslation("Argh!! What have you done to me?", "呀！！汝何施于我？");
            // 一切都让我感到痛苦……但……我会回来的……
            AddTranslation("Everything hurts... But.. I'll be back..", "无不痛也……然……我必复来……");
            // 嗯……你阻止了我……
            AddTranslation("Well.. you stopped me..", "然……汝止我矣……");
            // 我会抓住你……挑战者……
            AddTranslation("I WILL get you.. challenger..", "我必执汝……角者……");
            // 我被杀了！
            AddTranslation("I've been scrapped!", "我败矣！");
            // 你完全击败了我……
            AddTranslation("You beat me fair and square...", "汝正正而胜我矣……");
            // 所以我要先撤退了……打得不错……期待不久之后的再战。
            AddTranslation("So I will retreat.. well played.. Expect a rematch soon though..", "故我且退……汝战善矣……然后会不久复战。");
            // 所以，我们又见面了……
            AddTranslation("So, we meet again..", "然则，我等复见矣……");
            // 哦，是你。
            AddTranslation("Oh.. Its You..", "噫……乃汝也……");
            // 啊哈，找到你了！
            AddTranslation("Aha! Found you!", "啊哈！得汝矣！");
            // 我是来报仇的！
            AddTranslation("I've come to get my revenge!", "我来雪仇也！");
            // 惊喜吧！
            AddTranslation("Surprise!", "惊乎！");
            // 喂。
            AddTranslation("Hey.", "喂。");
            // 好的，欢迎来到这里。
            AddTranslation("Well, Hello there.", "善，汝来矣。");
            // 向你问候！
            AddTranslation("Greeetings!", "问汝安！");
            // 你以为你在干什么？四处游荡，摧毁我们的地牢。
            AddTranslation("Just what do YOU think you're doing? Wandering around and destroying our dungeons.", "汝意己何为？周行四方，而坏我等之窟。");
            // 一只小老鼠闯入我的视线……
            AddTranslation("A little mouse wanders into my sight..", "有小鼠入我目矣……");
            // 我终于找到你了……
            AddTranslation("At last, I have found you..", "终得汝矣……");
            // 野兽
            AddTranslation("Beasts", "兽");
            // 科技
            AddTranslation("Technology", "机");
            // 魔法
            AddTranslation("Magick", "术");
            // 死亡
            AddTranslation("Dead", "死");
            Dictionary<string, string> bountyName = new Dictionary<string, string>
            {
                { "Barry", "巴里" },
                { "Bolt", "伯特" },
                { "Gear", "吉尔" },
                { "Zap", "扎普" },
                { "Rust", "鲁斯特" },
                { "Clain", "克莱恩" },
                { "Clank", "克莱肯" },
                { "Tank", "丹克" },
                { "Gun", "刚" },
                { "Shoot", "修特" },
                { "Maksim", "马克西姆" },
                { "Wilkin", "威尔金" },
                { "Kaycee", "凯茜" },
                { "Hobbes", "霍布斯" },
                { "Grind", "格兰德" },
                { "Blast", "布拉斯特" },
                { "Crash", "科拉希" },
                { "Moon", "穆恩" },
                { "Zip", "锡普" },
                { "Jerry", "杰瑞" },
                { "Plasma", "普拉斯玛" },
                { "Jimmy", "吉米" },
                { "Silence", "赛伦斯" },
                { "Never", "内弗" },
                { "Hunt", "亨" },
                { "Hunter", "亨特" },
                { "Doom", "杜姆" },
                { "Const", "康斯特" },
                { "Boom", "布姆" },
                { "West", "韦斯特" }
            };
            Dictionary<string, string> bountySuffix = new Dictionary<string, string>
            {
                { "son", "森" },
                { "stein", "斯坦" },
                { "dottir", "多蒂尔" },
                { "vic", "维克" },
                { "berg", "伯格" },
                { "sky", "斯凯" },
                { "ski", "斯基" },
                { "sin", "辛" },
                { "sim", "西姆" },
                { "fellow", "费洛" },
                { "ed", "埃德" },
                { " II", "二世" },
                { " III", "三世" }
            };
            Dictionary<string, string> bountyPrefix = new Dictionary<string, string>
            {
                { "Mac", "麦克" },
                { "Mc", "迈可" },
                { "Von ", "冯·" },
                { "Van ", "范·" },
                { "Sir ", "爵士" },
                { "Madame ", "夫人" }
            };
            foreach (var n in bountyName)
            {
                foreach (var s in bountySuffix)
                {
                    var name = n.Key + s.Key;
                    var nameClassical = n.Value + s.Value;
                    AddTranslation(name, nameClassical);
                    AddTranslation("But this ain't the last of " + name + "!", "然此非 " + nameClassical + " 之终也！");
                    AddTranslation(name + ". Seeking revenge..", nameClassical + "。来雪仇也……");
                    AddTranslation("The one who destroyed " + name + "... You won't get away with it again.", "毁 " + nameClassical + " 者……今汝不得逸矣。");
                    AddTranslation("Didn't expect to see " + name + " again, did ya?", "不意复见 " + nameClassical + " 乎？");
                    AddTranslation("Unfortunately, " + name + " is back.", "不幸，" + nameClassical + " 复来矣。");
                    AddTranslation("They call me.. " + name + ".. You can't defeat ME!", "人皆呼我 " + nameClassical + "……汝不能胜我！");
                    AddTranslation("Let's see you stop " + name + ".", "观汝何以止 " + nameClassical + "。");
                    AddTranslation("Just remember that " + name + " can not be defeated.", "记 " + nameClassical + " 不可胜也。");
                    AddTranslation(name + " will be your executioner for the evening.", nameClassical + " 今夕将为汝刑人。");
                    foreach (var p in bountyPrefix)
                    {
                        name = p.Key + name;
                        nameClassical = p.Value + nameClassical;
                        AddTranslation(name, nameClassical);
                        AddTranslation("But this ain't the last of " + name + "!", "然此非 " + nameClassical + " 之终也！");
                        AddTranslation(name + ". Seeking revenge..", nameClassical + "。来雪仇也……");
                        AddTranslation("The one who destroyed " + name + "... You won't get away with it again.", "毁 " + nameClassical + " 者……今汝不得逸矣。");
                        AddTranslation("Didn't expect to see " + name + " again, did ya?", "不意复见 " + nameClassical + " 乎？");
                        AddTranslation("Unfortunately, " + name + " is back.", "不幸，" + nameClassical + " 复来矣。");
                        AddTranslation("They call me.. " + name + ".. You can't defeat ME!", "人皆呼我 " + nameClassical + "……汝不能胜我！");
                        AddTranslation("Let's see you stop " + name + ".", "观汝何以止 " + nameClassical + "。");
                        AddTranslation("Just remember that " + name + " can not be defeated.", "记 " + nameClassical + " 不可胜也。");
                        AddTranslation(name + " will be your executioner for the evening.", nameClassical + " 今夕将为汝刑人。");
                    }
                }
            }
        }
    }
}
