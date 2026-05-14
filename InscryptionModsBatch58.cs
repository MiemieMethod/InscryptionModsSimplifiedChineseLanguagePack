using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch58
    {
        public static void RegisterTranslations()
        {
            RegisterP03InKayceesMisc();
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

        private static void RegisterP03InKayceesMisc()
        {
            // 求你了！快帮我逃出这里！
            AddTranslation("Please! You've got to help me get out of here!", "请矣！速助我脱此！");
            // 谢谢！希望他没发现我在这儿……
            AddTranslation("Thank you! I hope he doesn't notice me here...", "谢矣！愿彼不觉我在此……");
            // 多谢！
            AddTranslation("Thank you!", "谢矣！");
            // 力量如此强大，痛苦却如此剧烈……
            AddTranslation("So much power, but so much pain...", "威甚巨，而痛亦甚深……");
            // 总算摆脱那个小怪物了。
            AddTranslation("Good riddance to that little freak.", "此小怪终去矣。");
            // 沽伯特
            AddTranslation("Goobert", "黏伯特");
            // 数据魔方
            AddTranslation("Data Cube", "数匣");
            // 可以放在天平上造成些伤害，如果你就好这口的话。
            AddTranslation("Can be placed on the scales for some damage, if you're into that sort of thing.", "若汝好此，可置于衡，以致些微之伤。");
            // 激光步枪
            AddTranslation("Laser Rifle", "光铳");
            // 本场战斗中为你的卡牌附加狙击印记。这可是把枪——你还想要啥？
            AddTranslation("This will give one of your cards the Sniper sigil for the rest of the battle. It's a gun - what else do you want?", "此战中，使汝一牌得狙印。铳也，更欲何乎？");
            // 增幅线圈
            AddTranslation("Amplification Coil", "益幅环");
            // 提升2点能量上限。这玩意儿应该能派上点用场。
            AddTranslation("Increases your max energy by 2. I suppose you can find some use for this.", "益能极二。庶几有用。");
            // UFO
            AddTranslation("UFO", "幽浮");
            // 可劫持任意一张卡牌。勉强能用吧
            AddTranslation("Abducts a card of your choice. It gets the job done I suppose", "可掠汝所择之一牌。庶几能用。");
            // 时针顺
            AddTranslation("Wiseclock", "顺时钟");
            // 能让牌桌顺时针旋转之类的。我从莱西那儿顺来的。你觉得他会发现吗？
            AddTranslation("It rotates the board clockwise or something. I stole it from Leshy. Do you think he'll notice?", "能使局顺时而转。余窃之于莱西。汝谓彼其觉乎？");
            // 我打出一张钟表:先生
            AddTranslation("I play a Mr:Clock", "我陈一先生钟。");
            // 随机一张卡牌变为鱼
            AddTranslation("a random card becomes a fish", "偶一牌化为鱼");
            // 你的1条路线燃起大火
            AddTranslation("1 of your lanes catches fire", "汝一列焚矣");
            // 陷阱
            AddTranslation("Traps", "阱");
            // 看起来这儿有几个陷阱
            AddTranslation("It seems there are some [c:bR]traps[c:] here", "似有数[c:bR]阱[c:]在此。");
            // 你的机器人得先解决它们才能碰到我
            AddTranslation("Your bots will have to fight past them to get to me", "汝诸机人须先胜之，而后及我。");
            // 随机规则
            AddTranslation("Random Rule", "偶律");
            // 这场对战我要加一条额外规则
            AddTranslation("For this battle, I'm going to add an additional rule.", "此战，吾将益一别律。");
            // 传送带
            AddTranslation("Conveyor", "输带");
            // 看来有人启动了传送带
            AddTranslation("It appears someone activated the [c:bR]conveyor belt[c:]", "似有人启[c:bR]输带[c:]矣。");
            // 卡牌每回合会顺时针轮转
            AddTranslation("Cards will rotate clockwise every turn", "诸牌每合皆顺时轮转。");
            // 爆炸性之物
            AddTranslation("Explosive", "爆");
            // 嗯，看来这场战斗中的卡牌死亡时会爆炸
            AddTranslation("Hm; it looks like the cards in this battle will [c:bR]explode[c:] when they die", "唔，此战诸牌死则将[c:bR]爆[c:]矣。");
            // 这看起来有点危险
            AddTranslation("That seems dangerous", "此似有危。");
            // 贴纸
            AddTranslation("Stickers", "贴签");
            // 看到那些贴纸了吗？它们能给我的卡牌附加额外能力。
            AddTranslation("See those [c:bR]stickers[c:]? They give my cards extra abilities.", "见彼[c:bR]贴签[c:]乎？能益我牌以别技。");
            // 你应该不介意多点儿挑战吧？
            AddTranslation("You don't mind an extra challenge, do you?", "汝不恶多一角竞乎？");
            // 导弹
            AddTranslation("Missiles", "飞弹");
            // 哦，这里好像有个故障的导弹发射器
            AddTranslation("Oh, there appears to be a malfunctioning missile launcher here", "噫，此似有一故障之飞弹机。");
            // 小心点，可能会有导弹乱飞
            AddTranslation("Watch out for rogue missile strikes I guess", "慎之，或有飞弹乱至。");
            // 最终头目
            AddTranslation("Final Boss", "终竟易魁");
            // 最终头目挑战的说明
            AddTranslation("Description for the Final Boss challenge", "终竟易魁角竞之说。");
            // 遥控器丢了
            AddTranslation("Missing Remote", "失遥器");
            // 你开局不再拥有炸弹夫人的遥控器
            AddTranslation("You do not start with Mrs. Bomb's Remote", "开局不复有弹夫人之遥器。");
            // 涡轮容器
            AddTranslation("Turbo Vessels", "迅皿");
            // 你的容器将带有双重冲刺印记。
            AddTranslation("Your vessels have the Double Sprinter sigil.", "汝诸皿皆有再驰之印。");
            // 断桥
            AddTranslation("Broken Bridges", "断桥");
            // 每次开局仅开放两个区域
            AddTranslation("Only two regions are available at the start of each run", "每局始，惟二境可行。");
            // 昂贵升级
            AddTranslation("Pricey Upgrades", "贵升");
            // 所有升级费用上涨
            AddTranslation("All upgrades cost more", "诸升级之费皆益。");
            // 古怪画师
            AddTranslation("Eccentric Painter", "诡画者");
            // 所有头目开局自带随机画布规则
            AddTranslation("All bosses start with a random canvas rule.", "诸魁战始，皆自有一偶画律。");
            // 能量锤
            AddTranslation("Energy Hammer", "能槌");
            // 使用锤子现在需要消耗2点能量
            AddTranslation("The hammer now costs 2 energy to use", "今用槌费能二。");
            // 昂贵复活
            AddTranslation("Costly Respawn", "贵复生");
            // 额外复活的费用变为三倍
            AddTranslation("The cost for additional respawns is tripled", "别复生之费，三其旧。");
            // 跳跃副牌组
            AddTranslation("Leaping Side Deck", "跃副牌列");
            // 用跳跃机器人替换你的空容器
            AddTranslation("Replace your Empty Vessels with L33pbots.", "以跃机易汝之虚皿。");
            // 通缉逃犯
            AddTranslation("Wanted Fugitive", "购逃者");
            // 你的悬赏等级永久提升2级
            AddTranslation("Your bounty level is permanently increased by 2", "汝之购赏之阶永久益二。");
            // 奇异遭遇
            AddTranslation("Strange Encounters", "异遭");
            // 每张地图的部分战斗将附加额外效果
            AddTranslation("Some battles on each map will have additional effects", "每图有数战将附别效。");
            // 终极冥刻
            AddTranslation("The Great Transcendence", "大陟");
            // 解锁终极冥刻的秘密
            AddTranslation("Unlock the secrets of the Great Transcendence", "发大陟之秘。");
            // 在此输入名称
            AddTranslation("ENTER NAME HERE", "于此书名");
            for (int count = 0; count <= 100; count++)
            {
                // 重抽：${count}
                AddTranslation("Redraw: $" + count.ToString(), "更引：$" + count.ToString());
                // 卖掉代币：{count}机器币
                AddTranslation("Sell Token: " + count.ToString() + " Robobucks", "鬻符：" + count.ToString() + "机币");
            }
            // 重置：$1
            AddTranslation("Reset: $1", "复置：$1");
            // 凯茜模组中的P03模组
            AddTranslation("P03 In Kaycee's Mod", "凯茜模组中之 P03");
            // 究极天启
            AddTranslation("Uber Apocalypse", "大劫");
            // 首次击败“凯茜模组中的P03”
            AddTranslation("Beat \"P03 in Kaycee's Mod\" for the first time", "始克“凯茜模组中之 P03”。");
            // 猩红头骨
            AddTranslation("Scarlet Skull", "绯髑");
            // 在第一页所有挑战头骨激活的状态下通关
            AddTranslation("Win a run with every challenge skull from the first page enabled", "首牍诸角髑尽启，而竟一局。");
            // 化身
            AddTranslation("Avatar", "化身");
            // 夺取乖乖珍爱的藏品之一
            AddTranslation("Take ownership of one of G0lly's beloved trinkets", "夺乖乖所珍之一器。");
            // 亡灵之书
            AddTranslation("Book of the Dead", "亡书");
            // 在档案保管员头目战的第二阶段存活6回合
            AddTranslation("During The Archivist's boss fight, survive 6 turns during phase 2", "于典牍者魁战之二段，存六合。");
            // 野性之魂
            AddTranslation("Feral Spirit", "野魂");
            // 不使用相机击败照相师
            AddTranslation("Defeat the Photographer without using the camera", "不用相机而败取影者。");
            // 画廊展览
            AddTranslation("Gallery Showcase", "画廊展");
            // 在未完成头目战中制造死循环
            AddTranslation("Create an infinite loop in the Unfinished Boss fight", "于未竟魁战中作无穷之环。");
            // 战斗狂热
            AddTranslation("Battle Frenzy", "战狂");
            // 累计消灭30名赏金猎人
            AddTranslation("Destroy 30 Bounty Hunters in your lifetime", "平生累毙购捕者三十。");
            // 呼叫支援
            AddTranslation("Calling for Backup", "召援");
            // 单次冒险中完成所有NPC任务
            AddTranslation("Complete all NPC quests that appear in a single run", "一局之中，尽竟诸 NPC 之事。");
            // 加速引信
            AddTranslation("Accelerated Fuse", "促燧");
            // 将NPC给予的卡牌进行外骨骼超频后摧毁
            AddTranslation("Skeleclock and destroy a card given to you by an NPC", "骨机化一 NPC 所与之牌，而后毁之。");
            // 法力闪烁
            AddTranslation("Mana Blink", "法闪");
            // 在第二回合时拥有6点可用能量
            AddTranslation("Have six energy available on turn two", "至第二合而有可用之能六。");
            // 无的放矢
            AddTranslation("Aimless Assault", "妄击");
            // 单场战斗中获得15机器币
            AddTranslation("Earn 15 Robobucks in a single battle", "一战而得机币十五。");
            // 废料重组
            AddTranslation("Rebuild From Scrap", "自废更构");
            // 牌组中拥有同时具备宝石化、外骨骼超频、可变形且能完成回路的卡牌
            AddTranslation("Have a card in your deck that is gemified, skeleclocked, transformable, and can complete a circuit", "牌列中有一牌，兼具玉化、骨机化、可易形而能成回路。");
            // 买下伙伴
            AddTranslation("Buy Your Buddy", "赎友");
            // 将属性点达到上限的卡牌交给机器人制作器
            AddTranslation("Give a card with the maximum amount of SP to the Bot Builder", "以 SP 满极之牌授机匠。");
            // 暴力输出
            AddTranslation("Me Smash", "吾碎之");
            // 单回合内对P03进行六次独立攻击
            AddTranslation("Strike P03 six separate times in a single turn", "一合之内，别击 P03 六。");
            // 绝对压制
            AddTranslation("Absolution", "尽压");
            // 在三个不同回合使天平向你的倾斜度达到4点
            AddTranslation("Have the scales tilted 4 points against you on three different turns", "于三异合中，使衡向汝倾至四。");
            // 完美犯罪
            AddTranslation("The Perfect Crime", "至完之罪");
            // 在不击杀赏金猎人的情况下赢得五场战斗
            AddTranslation("Win five battles with bounty hunters without killing them", "购捕者不死，而胜五战。");
            // 爆能5000超极炮
            AddTranslation("Blastenheimer 5000 Ultra Cannon", "爆能五千超炮");
            // 单回合内用等离子吉米造成6点伤害
            AddTranslation("Deal 6 damage with Plasma Jimmy in a single turn", "一合之内，以离子吉米致伤六。");
            // 双倍速
            AddTranslation("Double Time", "再速");
            // 对牌组中所有卡牌进行外骨骼超频
            AddTranslation("Skeleclock every card in your deck", "尽骨机化汝牌列诸牌。");
            // 合二为一
            AddTranslation("One And The Same", "合而为一");
            // 完成菌学家的实验并创造出科学怪胎
            AddTranslation("Complete the Mycologist's experiment and create an abomination of science", "竟蕈家之试，而作术怪。");
            // 燃烧肾素
            AddTranslation("Burning Adrenaline", "焚奋");
            // 在四回合内修复发电机
            AddTranslation("Repair the generator in four turns or less", "四合之内，治其电枢。");
            // 嘉年华小丑
            AddTranslation("Carnival Clown", "游宴丑");
            // 在力量测试中获得50分及以上的最高分
            AddTranslation("Achieve a high score of 50 or more on the test of strength", "于力试之中，得五十以上。");
            // 重冥叠宙
            AddTranslation("Verse Riff", "重冥叠宙");
            // 理解终极冥刻的真正含义
            AddTranslation("Understand the true meaning of the Great Transcendence", "悟大陟之真义。");
            // 原版
            AddTranslation("Vanilla", "素");
            // 炸弹
            AddTranslation("Bomb", "爆弹");
            // 护盾
            AddTranslation("Shield", "微铠");
            // 随机
            AddTranslation("Random", "偶");
            // 管道
            AddTranslation("Conduit", "渠");
            // 进化
            AddTranslation("Evolve", "进");
            // 宝石
            AddTranslation("Gems", "玉");
            // 拖延
            AddTranslation("Stall", "持");
            // 惹人生厌
            AddTranslation("Annoying", "可厌");
            // 燃烧
            AddTranslation("Fire", "焚");
            // 充能
            AddTranslation("Recharge", "复能");
            // 无充能
            AddTranslation("NoCharge", "无充");
            // 交换
            AddTranslation("Swap", "易");
            // 邪恶
            AddTranslation("Nefarious", "邪");
            // 廉价
            AddTranslation("Cheapo", "贱");
            // 全选
            AddTranslation("FullDraft", "尽择");
            // 消耗能量
            AddTranslation("Energy Expended", "费能");
            // 锤击次数
            AddTranslation("Hammer Blows Dealt", "槌击");
            // 创造怪胎
            AddTranslation("Abominations Created", "怪成");
            // 完成任务
            AddTranslation("Quests Completed", "竟事");
            // 击杀赏金猎人
            AddTranslation("Bounty Hunters Killed", "毙购捕者");
            // 特殊锤子模组
            AddTranslation("Special Hammer Mod", "异槌模组");
            // 绝赞选牌模组
            AddTranslation("Incredible Drafting Mod", "妙择模组");
            // 社区API
            AddTranslation("The Community API", "众人 API");
            // 超级无敌Unity编辑器
            AddTranslation("Super-Duper Unity Editor", "大一统辑器");
            // 凯茜的P03扩展包#1
            AddTranslation("Kaycee's P03 Expansion Pack #1", "凯茜之 P03 扩展包一");
            // 来自“凯茜模组中的P03模组”开发团队的首个扩展包，为机托邦四大区域新增[count]张卡牌。
            AddTranslation("The first expansion pack from the developers of 'P03 in Kaycees Mod' adds [count] new cards across all four regions of Botopia.", "“凯茜模组中之 P03”诸作者之首扩展包，于机邦四境增新牌[count]张。");
            // 凯茜的P03扩展包#2
            AddTranslation("Kaycee's P03 Expansion Pack #2", "凯茜之 P03 扩展包二");
            // 官方第二弹扩展包，内含[count]张能引发爆炸性反应的火热新卡！
            AddTranslation("The second official expansion pack, with [count] firey new cards that command an explosive reaction!", "官次扩展包，含炽然新牌[count]张，能致爆应。");
            // 邪恶冥刻：机托邦的失控机器人
            AddTranslation("Inscryption: Rogue Bots of Botopia", "冥勒：机邦失机");
            // 机托邦已被失控机器人占领！这些[count]个遭遇战已针对凯茜模组重新平衡。
            AddTranslation("Botopia has become overrun with rogue bots! These [count] encounters have been rebalanced for Kaycee's Mod.", "机邦已为失机所乱！此[count]遭已为凯茜模组重平之。");
            // 凯茜的P03遭遇战扩展#1
            AddTranslation("Kaycee's P03 Encounter Expansion #1", "凯茜之 P03 遭扩展一");
            // 新增[count]个包含首款P03官方扩展包卡牌的遭遇战。
            AddTranslation("[count] additional encounters that feature cards from the first official P03 expansion pack.", "增遭[count]，皆含首官 P03 扩展包之牌。");
            // 凯茜的P03遭遇战扩展#2
            AddTranslation("Kaycee's P03 Encounter Expansion #2", "凯茜之 P03 遭扩展二");
            // 新增[count]个包含第二款P03官方扩展包卡牌的遭遇战。
            AddTranslation("[count] additional encounters that feature cards from the second official P03 expansion pack.", "增遭[count]，皆含次官 P03 扩展包之牌。");
            // 莱昂内尔
            AddTranslation("LIONEL", "莱昂内尔");
            // 路易斯
            AddTranslation("LOUIS", "路易");
            // 卢
            AddTranslation("LOU", "卢");
            // 詹姆斯
            AddTranslation("JAMES", "詹姆斯");
            // 零件
            AddTranslation("PARTS", "零件");
            // 吉米
            AddTranslation("JIMMY", "吉米");
            // 警笛
            AddTranslation("KLAXON", "警笛");
            // 坡
            AddTranslation("POE", "坡");
            // 丹尼
            AddTranslation("DANNY", "丹尼");
            // 马林斯
            AddTranslation("MULLINS", "马林斯");
            // 卢克
            AddTranslation("LUKE", "卢克");
            // 炸弹
            AddTranslation("BOMB", "爆");
            // 卡德
            AddTranslation("KARD", "卡德");
            // 砖块
            AddTranslation("BRICK", "砖");
            // 重击
            AddTranslation("SMACK", "击");
            // 黑客
            AddTranslation("HACK", "骇");
            // 莽撞
            AddTranslation("BRASH", "莽");
            // 扎克
            AddTranslation("ZACK", "扎克");
            // 轰隆
            AddTranslation("BOOM", "轰");
            // 火箭
            AddTranslation("ROCKET", "箭");
            // 斯尼尔
            AddTranslation("SNILL", "斯尼尔");
            // 电击
            AddTranslation("ZAP", "电");
        }
    }
}
