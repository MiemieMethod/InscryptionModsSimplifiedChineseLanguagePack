using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public static partial class InscryptionVanilla
    {
        private static void RegisterVanillaTranslations()
        {
            RegisterContents();
        }

        private static void AddTranslation(string id, string english, string classical)
        {
            ClassicChineseLanguagePackPlugin.Translate(ClassicChineseLanguagePackPlugin.GUID, id, english, classical, Language.ChineseSimplified);
        }

        // 莱西：余 朕 我 / 汝 乃 尔 / 彼 厥 之 （第二章旁白/骨王/木雕师/第三章赏金猎人/档案保管员/修桥工同）
        //    矿工：俺 / 你 / 彼其娘
        //    钓鱼人：予 / 女
        //    猎人&毛皮商：鄙 / 君
        //    菌学家：我曹 / 汝 / -邪？
        // P03：咱 咱之 我 / 卿 卿之 你 / 他 其 之 （乖乖：卿→宁）
        //    检查员：我 / 你
        //    熔炼员：偶 / 您
        //      詹姆斯·科布：吾 / 子
        //    挖掘工/挖泥工：喒 / 亲 / 喒兄
        // 格里魔拉：奴 朕 我 / 汝 乃 尔 / 彼 厥 之 （档案保管员同）
        //    罗亚尔：某 / 汝
        //    凯茜：愚 / 汝
        //    索耶：仆 / 汝
        // 曼尼菲科：吾 朕 我 / 子 乃 尔 / 伊 厥 之 （第三章“未完成的头目”同）
        //    黏液法师：吾 / 子
        //    长矛法师：吾 / 子
        //    孤独巫师：我 / 尔

        private static void RegisterContents()
        {
            // 你没有足够祭品来使用这个造物。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_705_M", "You are lacking sacrifices for that creature.", "汝乏牲，不足以陈此物。");
            // 要打那张[c:bR][v:0][c:]牌，你需要献祭[c:bR][v:1]只不同造物[c:]。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_REPEAT_#1_699_M", "To play that [c:bR][v:0][c:] you'll need to sacrifice [c:bR][v:1] different creatures[c:].", "欲陈[c:bR][v:0][c:]，须祀[c:bR]异物者[v:1][c:]。");
            // 可献祭造物不足[c:bR][v:0][c:]所需血量。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_REPEAT_#2_705_M", "The [c:bR][v:0][c:] demands more blood than you have creatures to sacrifice.", "可祀之物，不足充[c:bR][v:0][c:]之血。");
            // [v:0]身上可榨不出血来。
            AddTranslation("GAMEPLAY_HINTS_HINT_CANTSACRIFICETERRAIN_859_M", "You can't draw blood from a [v:0].", "[v:0]无血可取。");
            // 你……没法献祭那张卡牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_CANTSACRIFICETERRAIN_REPEAT_#1_357_M", "You... can't sacrifice that.", "汝……不得祀彼。");
            // 这份献祭诚意不足。
            AddTranslation("GAMEPLAY_HINTS_HINT_CANTSACRIFICETERRAIN_REPEAT_#2_095_M", "That isn't a worthy sacrifice.", "此不堪祀。");
            // [v:0]不会流血。
            AddTranslation("GAMEPLAY_HINTS_HINT_CANTSACRIFICETERRAIN_REPEAT_#3_170_M", "A [v:0] does not bleed.", "[v:0]不衄。");
            // 那个不成。
            AddTranslation("GAMEPLAY_HINTS_HINT_CANTSACRIFICETERRAIN_REPEAT_#4_706_M", "That will not suffice.", "此不足也。");
            // 那老妇人向你靠过来，浑身骨头像呻吟般咯吱作响。
            AddTranslation("SPECIAL_NODES_WOODCARVERINTRO_832_M", "The bones of the ancient woman creaked and groaned as she approached.", "古妪趋前，骨节嘎鸣。");
            // 她用颤颤巍巍的双手把祭品放在你面前。
            AddTranslation("SPECIAL_NODES_WOODCARVERINTRO_121_M", "With gently shaking hands, she placed her offerings before you.", "手微颤而陈以所献。");
            // 年老体衰的[c:bR]木雕师[c:]出现在你面前。
            AddTranslation("SPECIAL_NODES_WOODCARVERINTRO_REPEAT_#1_326_M", "The decrepit [c:bR]woodcarver[c:] appeared before you.", "[c:bR]刻木老妪[c:]见于汝。");
            // 尽管她年事已高，一举一动却很有精神。
            AddTranslation("SPECIAL_NODES_WOODCARVERINTRO_REPEAT_#1_915_M", "She moved with a certain vigor in spite of her considerable age.", "年虽耄，举动犹健。");
            // 你遇到了年老的[c:bR]木雕师[c:]，她目不转睛地盯着你。
            AddTranslation("SPECIAL_NODES_WOODCARVERINTRO_REPEAT_#2_566_M", "You came upon the old [c:bR]woodcarver[c:] who fixed her intense gaze upon you.", "汝逢[c:bR]刻木老妪[c:]，厥目炯然，而视汝。");
            // 她沉默良久，拿出了自己的雕像。
            AddTranslation("SPECIAL_NODES_WOODCARVERINTRO_REPEAT_#2_101_M", "After an overlong moment of silence, she moved to offer her carvings.", "默然久之，乃出厥刻以献。");
            // [t:9]啊？[t:3][w:0.2]喂，[w:0.2]停[w:0.2]下！
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSACRIFICETUTORIAL_397_M", "[t:9]Huh?[t:3][w:0.2] Hey[w:0.2] stop!", "[t:9]噫？[t:3][w:0.2]嗟，[w:0.2]且[w:0.2]止！");
            // [t:0.01]哇哦……[w:0.1]真[w:0.1]的[w:0.1]吗？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSACRIFICE_182_M", "[t:0.01]Wow...[w:0.1] Seriously?", "[t:0.01]吁……[w:0.1]果[w:0.1]乎？");
            // [t:0.01]噢，[w:0.2]得[w:0.2]了[w:0.2]吧！
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSACRIFICE_REPEAT_#1_809_M", "[t:0.01]Oh[w:0.2] come[w:0.2] on!", "[t:0.01]噫，[w:0.2]休[w:0.2]矣！");
            // 又来了……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSACRIFICE_REPEAT_#2_852_M", "Again...", "复然……");
            // 你居然没把我拿去献祭？
            AddTranslation("TALKING_CARDS_STOATINTRO_856_M", "You didn't sacrifice me?", "卿竟未祀我？");
            // 你人真好。
            AddTranslation("TALKING_CARDS_STOATINTRO_511_M", "How kind.", "仁哉。");
            // 你把我给献祭了。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATINTRO_153_M", "You sacrificed me.[w:0.2]", "卿竟祀我。[w:0.2]");
            // [t:2][shake:1]还是[w:0.2]在[w:0.2]我[w:0.2][shake:1]睡觉的时候。[w:0.5]
            AddTranslation("TALKING_CARDS_STOATINTRO_269_M", "[t:2][shake:1]While[w:0.2] I[w:0.2] was[w:0.2][shake:1] sleeping.[w:0.5]", "[t:2][shake:1]乘[w:0.2]咱[w:0.2]之[w:0.2][shake:1]寐。[w:0.5]");
            // [anim:sly]这么出牌倒也合理。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATINTRO_140_M", "[anim:sly]It was the right play.[w:0.2]", "[anim:sly]此出诚当。[w:0.2]");
            // 我懂的。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATINTRO_279_M", "I get it.[w:0.2]", "咱知矣。[w:0.2]");
            // [anim:]或许……
            AddTranslation("TALKING_CARDS_STOATINTRO_193_M", "[anim:]Maybe...", "[anim:]然……");
            // ……回头你可以帮帮我？[leshy:轮到你了。][w:2]
            AddTranslation("TALKING_CARDS_STOATINTRO_094_M", "...you'll help me?[leshy:Take your turn.][w:2]", "……卿或其助我乎？[leshy:乃合。][w:2]");
            // 再陪他玩会儿吧。
            AddTranslation("TALKING_CARDS_STOATINTRO_448_M", "Play along for now.", "今且从之。");
            // 荣幸之至。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATHOSTCHOSEN_157_M", "What an honor.", "殊荣焉。");
            // 对吧？[w:0.2][anim:sly]好。[w:0.2][anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATHOSTCHOSEN_REPEAT_#1_518_M", "Yeah?[w:0.2][anim:sly] Alright.[w:0.2][anim:]", "然乎？[w:0.2][anim:sly]可。[w:0.2][anim:]");
            // 选得不错。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATHOSTCHOSEN_REPEAT_#2_290_M", "Fine choice.", "善择。");
            // 又出现了一个印记……[w:0.2]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATHOSTCHOSEN_REPEAT_#3_756_M", "Another sigil...[w:0.2]", "又复一印……[w:0.2]");
            // [anim:sly]哦耶……[anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATHOSTCHOSEN_REPEAT_#3_261_M", "[anim:sly]Hooray...[anim:]", "[anim:sly]善哉……[anim:]");
            // 嘿。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICEPOSITIVE_100_M", "Hey.", "嗟。");
            // 选我选我。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICEPOSITIVE_707_M", "Pick me.", "择我。择我。");
            // 我去吧。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICEPOSITIVE_REPEAT_#1_780_M", "I'll go.", "咱往。");
            // 让我来。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICEPOSITIVE_REPEAT_#2_822_M", "It's me.", "咱用也。");
            // 反正是你选的。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICEPOSITIVE_REPEAT_#3_501_M", "Your choice.", "此卿之自择耳。");
            // 你的骨头不足以召唤此造物。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBONES_187_M", "You are lacking the Bones for that creature.", "乃骨不足以陈此物。");
            // 想要使用[c:bR][v:0][c:]还需更多骨头。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBONES_REPEAT_#1_914_M", "You'll need more Bones to play that [c:bR][v:0][c:].", "欲陈[c:bR][v:0][c:]，尚益须骨。");
            // 骨头数量不足[c:bR][v:1][c:]根。失去几只造物的话你没准就……
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBONES_REPEAT_#2_219_M", "You don't have [c:bR][v:1][c:] Bones yet. Lose some creatures and you might...", "乃骨未及[c:bR][v:1][c:]之数。若弃之数物，或可……");
            // 该造物还需要更多骨头。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBONES_REPEAT_#3_780_M", "That creature demands more Bones.", "此物尚乏骨。");
            // 造物阵亡，你获得一根[c:bR]骨头。[c:]
            AddTranslation("TUTORIAL_TUTORIALBONESTOKEN_797_M", "From the death of your creature you've gained a [c:bR]bone.[c:]", "汝物既死，得一[c:bR]骨。[c:]");
            // 骨头只能被消耗掉……或在战斗结束后才会消失。
            AddTranslation("TUTORIAL_TUTORIALBONESTOKEN_637_M", "You will not lose this until it is spent... or the battle ends.", "此骨弗能失，或易费而失……或战终而后失。");
            // 你已获得一根[c:bR]骨头。[c:]
            AddTranslation("TUTORIAL_TUTORIALBONESTOKEN_REPEAT_#1_472_M", "You've gained a [c:bR]bone.[c:]", "汝得一[c:bR]骨。[c:]");
            // 骨头会一直存在，直到你把它们消耗掉……或战斗结束。
            AddTranslation("TUTORIAL_TUTORIALBONESTOKEN_REPEAT_#1_268_M", "It will stay there until you spend it... or the battle ends.", "此骨常在，或易费……或战终。");
            // 那是一根[c:bR]骨头。[c:]
            AddTranslation("TUTORIAL_TUTORIALBONESTOKEN_REPEAT_#2_975_M", "That's a [c:bR]bone.[c:]", "此乃[c:bR]骨[c:]也。");
            // 没错……那是一根[c:bR]骨头。[c:]
            AddTranslation("TUTORIAL_TUTORIALBONESTOKEN_REPEAT_#3_546_M", "Yes... That's a [c:bR]bone.[c:]", "然……此乃[c:bR]骨[c:]也。");
            // [t:3]趁我睡着的时候？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDIEBONESTUTORIAL_207_M", "[t:3]While I was asleep?", "[t:3]乘咱之寐？");
            // [t:3]又来？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDIEBONESTUTORIAL_475_M", "[t:3]Again?", "[t:3]复乎？");
            // 现在不行。先抽一张牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEDURINGDRAWPHASE_551_M", "Not now. Draw a card first.", "今未可。先引一牌。");
            // 慢慢来。你得先抽一张牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEDURINGDRAWPHASE_REPEAT_#1_596_M", "Slow down. You will first need to draw a card.", "徐之。须先引一牌。");
            // 按步就班，先抽牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEDURINGDRAWPHASE_REPEAT_#2_747_M", "One thing at a time. Draw first.", "一事一行，先引牌。");
            // 想用的话……得先抽完当前回合的牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEDURINGDRAWPHASE_REPEAT_#3_918_M", "You may use that... after you have drawn your card for the turn.", "欲用此……须先引此合之牌。");
            // 第一回合不能抽牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGFIRSTTURN_758_M", "You cannot draw a card on your first turn.", "首合不得引牌。");
            // 第一回合不能抽牌。你的牌还不够多吗？
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGFIRSTTURN_REPEAT_#1_769_M", "No drawing on the first turn. Don't you have enough?", "首合不引牌。汝手中不厌乎？");
            // 下一回合才可以抽牌。现在就先凑合着吧。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGFIRSTTURN_REPEAT_#2_759_M", "You may draw next turn. For now, make do.", "下合乃得引牌。今姑从权。");
            // 谁允许你第一回合就抽牌了。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGFIRSTTURN_REPEAT_#3_487_M", "I will not allow you to draw a card on the first turn.", "余不许汝之首合引牌。");
            // 第一回合不抽牌，你得等会儿。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGFIRSTTURN_REPEAT_#4_113_M", "You don't draw on the first turn. You will have to wait for that.", "首合不引牌。姑待之。");
            // 每回合可以使用不止一张牌……你知道的吧？
            AddTranslation("TUTORIAL_TUTORIALMORETHANONECARD_949_M", "You know you can play more than one card per turn... right?", "每合不止一牌可陈……汝知乎？");
            // 是我没说清楚？
            AddTranslation("TUTORIAL_TUTORIALMORETHANONECARD_REPEAT_#1_914_M", "Was I not clear?", "余言不明乎？");
            // 同一回合中，可以既打出松鼠又把它献祭掉。
            AddTranslation("TUTORIAL_TUTORIALMORETHANONECARD_REPEAT_#1_209_M", "You can play a Squirrel and also sacrifice it in the same turn.", "一合之中，汝可陈松鼠，亦可祀之。");
            // 只要献祭条件满足，每一回合使用卡牌数量不限……
            AddTranslation("TUTORIAL_TUTORIALMORETHANONECARD_REPEAT_#2_734_M", "You can play as many cards per turn as your sacrifices will allow...", "牲祀苟足，一合所陈之牌无算……");
            // 就出一只松鼠？有趣的选择……
            AddTranslation("TUTORIAL_TUTORIALMORETHANONECARD_REPEAT_#3_314_M", "Just a Squirrel? Interesting choice...", "唯陈一松鼠乎？此选亦异……");
            // 我只能跳过。
            AddTranslation("_OPPONENTSKIPTURN_479_M", "I'm obligated to pass.", "余唯有过。");
            // 跳过。
            AddTranslation("_OPPONENTSKIPTURN_REPEAT_#1_558_M", "Pass.", "过。");
            // 我选择跳过。
            AddTranslation("_OPPONENTSKIPTURN_REPEAT_#2_465_M", "I'll pass.", "余其过。");
            // 别自以为是了。你得先抽一张牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_PLAYDURINGDRAWPHASE_465_M", "Don't get ahead of yourself. You need to draw a card first.", "毋躁进。汝须先引一牌。");
            // 抽新牌前不允许使用任意卡牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_PLAYDURINGDRAWPHASE_REPEAT_#1_797_M", "I won't allow you to play a card before you draw a new one.", "未引新牌，余不许汝陈牌。");
            // 请抽牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_PLAYDURINGDRAWPHASE_REPEAT_#2_235_M", "Draw a card.", "引一牌。");
            // 停，先抽牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_PLAYDURINGDRAWPHASE_REPEAT_#3_655_M", "Stop. Draw a card.", "止。先引一牌。");
            // 轮到你抽牌了。稍后才能出牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_PLAYDURINGDRAWPHASE_REPEAT_#4_903_M", "Your turn to draw. You can play cards after.", "今当汝引牌，后乃可陈牌。");
            // 需要提醒你一下吗？你的道具或许有点用……
            AddTranslation("TUTORIAL_TUTORIALCONSUMABLESREMINDER_266_M", "Need I remind you? Your items may help...", "尚须余之告尔乎？乃器或可相助……");
            // 你忘了我给你的道具吗？啧啧。
            AddTranslation("TUTORIAL_TUTORIALCONSUMABLESREMINDER_REPEAT_#1_518_M", "Have you forgotten the items I gave you? Tisk, tisk.", "汝忘余之予尔之器乎？啧啧。");
            // 道具可以帮上忙……
            AddTranslation("TUTORIAL_TUTORIALCONSUMABLESREMINDER_REPEAT_#2_479_M", "An item could help...", "一器或可济……");
            // 你的处境无疑很艰难。
            AddTranslation("TUTORIAL_TUTORIALCONSUMABLESREMINDER_REPEAT_#3_373_M", "You're in a tough spot, no doubt.", "汝今之困，信然。");
            // 现在不能用这个。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEOUTSIDEOFBATTLE_478_M", "You can't use that right now.", "今不可用此。");
            // 这只能用于卡牌对战。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEOUTSIDEOFBATTLE_REPEAT_#1_550_M", "That one's only for card dueling.", "此唯可用于牌战。");
            // 回头会让你用的……但不是现在。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEOUTSIDEOFBATTLE_REPEAT_#2_884_M", "I'll let you use that... but not now.", "余将许汝之用此……然非今也。");
            // 够了，你现在不能用这个。
            AddTranslation("GAMEPLAY_HINTS_HINT_CONSUMABLEOUTSIDEOFBATTLE_REPEAT_#3_994_M", "Enough. You can't use that presently.", "足矣。今不可用此。");
            // 缺少使用[c:bR][v:0][c:]所需祭品。但你还有一只[c:bR]松鼠[c:]。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOODBUTSQUIRREL_880_M", "You are lacking sacrifices for that [c:bR][v:0][c:]. But you do have a [c:bR]Squirrel[c:].", "彼[c:bR][v:0][c:]所须牲祀未足。然汝尚有[c:bR]松鼠[c:]。");
            // 目前无法使用此卡牌，但[c:bR]松鼠[c:]可以随便用。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOODBUTSQUIRREL_REPEAT_#1_259_M", "You can't play that presently. But your [c:bR]Squirrel[c:] is free.", "今未可陈彼牌。然乃[c:bR]松鼠[c:]无须牲祀。");
            // 不行……但可以使用[c:bR]松鼠[c:]。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOODBUTSQUIRREL_REPEAT_#2_827_M", "No... But you can play your [c:bR]Squirrel[c:].", "不可……然乃[c:bR]松鼠[c:]可陈。");
            // 信不信由你，你不是头一个在这儿丢一只眼睛的人……
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEINTRO_267_M", "Believe it or not, you're not the first to lose an eye here...", "汝或信疑，汝非此间失一目之始者……");
            // 要是你成了独眼龙，就没什么意思了。
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEINTRO_204_M", "This isn't much fun if you're half blind.", "汝若眇一目，则殊乏趣。");
            // 或许，你想换只眼睛？
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEINTRO_660_M", "Perhaps, you'd like to replace it?", "汝庶几欲易之乎？");
            // 你考虑来只新眼睛吗？
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEINTRO_REPEAT_#1_026_M", "Would you care for a new eye?", "欲得新目乎？");
            // 我猜你一定很想补上那只失去的眼睛吧。
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEINTRO_REPEAT_#2_576_M", "I imagine you'd like to replace that eye you lost.", "余度汝之欲易所失之目。");
            // 好点没？
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEOUTRO_252_M", "Better?", "愈乎？");
            // 无论如何，选定就改不了了。
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEOUTRO_341_M", "Regardless, the choice is final.", "虽然，既择则不可更易。");
            // 确定选这个了吗？
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEOUTRO_REPEAT_#1_922_M", "Happy with that one?", "此可意乎？");
            // 没有后悔药了。
            AddTranslation("SPECIAL_NODES_EYEBALLCHOICEOUTRO_REPEAT_#2_487_M", "The choice is final.", "既择，不可更矣。");
            // 我是不是忘记说过量伤害了？
            AddTranslation("TUTORIAL_TUTORIALOVERKILLDAMAGE_491_M", "Did I neglect to mention overkill damage?", "余忘言之溢伤乎？");
            // 多余伤害不会浪费。
            AddTranslation("TUTORIAL_TUTORIALOVERKILLDAMAGE_700_M", "Excess damage is not wasted.", "溢伤不虚。");
            // 而是会给受害者的残尸[c:bR]后面[c:]的卡牌继续造成伤害。
            AddTranslation("TUTORIAL_TUTORIALOVERKILLDAMAGE_360_M", "It carries over to the card [c:bR]behind[c:] the mangled corpse of the victim.", "厥溢伤延及受者残尸之[c:bR]后[c:]牌。");
            // 你真走运。
            AddTranslation("TUTORIAL_TUTORIALOVERKILLDAMAGE_306_M", "Lucky for you.", "汝幸甚。");
            // 一位老妇人从橡树后走了出来。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINTRO_587_M", "An ancient woman emerged from behind an oak tree.", "一妪自栎后出。");
            // 她小心翼翼地摆放着精致的木雕，然后猛然冲它们打了个手势。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINTRO_136_M", "She carefully laid out intricate wood carvings, then gestured at them brusquely.", "彼谨陈繁巧刻木，旋遽指之。");
            // 年迈的[c:bR]木雕师[c:]再次出现在你面前。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINTRO_REPEAT_#1_741_M", "The old [c:bR]woodcarver[c:] again appeared before you.", "[c:bR]刻木老妪[c:]复见于汝前。");
            // 你再次遇见了[c:bR]木雕师[c:]。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINTRO_REPEAT_#2_042_M", "It was another encounter with the [c:bR]woodcarver[c:].", "汝再遇[c:bR]刻木妪[c:]。");
            // 带上图腾的头和身体可能会带来好运。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINTRO_REPEAT_#2_247_M", "Taking a head and a body of a totem may bring good fortune.", "得神偶之首与身，或致吉。");
            // [c:bR]木雕师[c:]再次献上她的作品。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINTRO_REPEAT_#3_797_M", "The [c:bR]woodcarver[c:] again offered her carvings.", "[c:bR]刻木妪[c:]复献厥雕。");
            // 你接受了[c:bR]木雕师的[c:]祭品。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINCOMPLETE_493_M", "You accepted the [c:bR]woodcarver's[c:] offering.", "汝受[c:bR]刻木妪[c:]之献。");
            // 没有另一部分就毫无用处……
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINCOMPLETE_267_M", "It is useless without its second half...", "无厥配半，则无用……");
            // 但直觉告诉你，这不会是与[c:bR]她[c:]的最后一次见面。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINCOMPLETE_436_M", "But you intuited that this would not be the last encounter with [c:bR]her[c:].", "然汝意此非[c:bR]彼[c:]此之终会。");
            // 没有头尾的图腾是不完整的。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINCOMPLETE_REPEAT_#1_993_M", "Without a top and bottom the totem is incomplete.", "无首无身，则神偶未成。");
            // 由于缺乏第二件雕像配件，你只好向[c:bR]木雕师[c:]告别。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINCOMPLETE_REPEAT_#2_532_M", "Lacking a second matching piece, you bid the old [c:bR]woodcarver[c:] adieu.", "乏厥相配之半，汝乃辞[c:bR]刻木妪[c:]。");
            // 你带走了一件木雕，但凑不成完整图腾。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERINCOMPLETE_REPEAT_#3_959_M", "You left with a piece, but without a complete totem.", "汝挟厥半而去，然神偶未全。");
            // 老妇人满意地呲着牙。你完成了第一座[c:bR]图腾[c:]。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERCOMPLETE_127_M", "The old woman bared her teeth in satisfaction. Your first [c:bR]totem[c:] was complete.", "老妪快然露齿。汝之初[c:bR]神偶[c:]已成。");
            // 现在[c:bR][v:0][c:]印记将出现在你所有[c:bR][v:1][c:]造物上。
            AddTranslation("TUTORIAL_TUTORIALWOODCARVERCOMPLETE_746_M", "The [c:bR][v:0][c:] sigil will now be marked upon all your [c:bR][v:1][c:] creatures.", "今乃诸[c:bR][v:1][c:]之物，皆著[c:bR][v:0][c:]之印。");
            // 一名正准备变卖毛皮的[c:bR]猎人[c:]在路上拦住了你。
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSINTRO_712_M", "You were stopped along the way by a [c:bR]Trapper[c:] looking to liquidate his pelts.", "途有一[c:bR]猎夫[c:]止尔，欲鬻厥裘革。");
            // 他的外表有些奇怪，但你不久就被他的货品分散了注意力。
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSINTRO_481_M", "There was something uncanny about his appearance, but you were quickly distracted by his wares.", "厥状殊诡，然汝旋为厥货所移。");
            // 那人向你保证这些毛皮很有价值。
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSOUTRO_844_M", "The man assured you of the value of the pelts.", "其人诚保此革甚贵。");
            // 这些东西在战斗中似乎毫无用处……
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSOUTRO_742_M", "They appear to be useless in a fight...", "此物于战似无所用……");
            // 但他提到，再往前走有个[c:bR]毛皮商[c:]会让你不虚此行。
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSOUTRO_937_M", "But he mentioned that [c:bR]The Trader[c:] further down the path would reward you for them.", "然彼言前路之[c:bR]贾妇[c:]必以此酬汝。");
            // 你在树林中看到一座由一名神秘女人打理的小型贸易站。
            AddTranslation("TUTORIAL_TUTORIALTRADEPELTSINTRO_553_M", "You encountered a small outpost in the woods tended by a mysterious woman.", "汝遇一肆于林，有秘女司之。");
            // 就是那个老[c:bR]猎人[c:]提到的[c:bR]毛皮商[c:]！
            AddTranslation("TUTORIAL_TUTORIALTRADEPELTSINTRO_123_M", "It was [c:bR]The Trader[c:] that the old [c:bR]Trapper[c:] had mentioned!", "即老[c:bR]猎夫[c:]所言之[c:bR]贾妇[c:]也！");
            // 她的外表令人不安，但她的东西让你颇感欣慰。
            AddTranslation("TUTORIAL_TUTORIALTRADEPELTSINTRO_887_M", "Her appearance was unsettling but you were mollified by her offerings.", "厥貌可骇，然其所陈诸物稍慰汝心。");
            // 耳边仿佛回响着[c:bR]矿工[c:]绕梁三日的镐头声，你继续前进。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEPROSPECTOR_299_M", "With sound of [c:bR]The Prospector[c:]'s pickaxe still ringing in your ears, you carried onwards.", "耳犹闻[c:bR]采夫[c:]之镐声，汝乃前行。");
            // 在与[c:bR]矿工[c:]的惨痛相遇之后，你振作起来继续前进。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEPROSPECTOR_REPEAT_#1_450_M", "After the harrowing encounter with [c:bR]The Prospector[c:] you gathered yourself and continued onwards.", "既遭[c:bR]采夫[c:]之厄，汝自定而前。");
            // 摆脱了[c:bR]矿工[c:]疯癫的眼神后，你看向前方。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEPROSPECTOR_REPEAT_#2_998_M", "Free of [c:bR]The Prospector[c:]'s unhinged gaze, you looked ahead.", "脱[c:bR]采夫[c:]狂视，汝乃前瞻。");
            // 你擦了擦裤子上的尘土，继续着自己的旅程。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEPROSPECTOR_REPEAT_#3_420_M", "Wiping the dust from your trousers, you returned to your journey.", "拂去裳尘，复行厥旅。");
            // 唔……
            AddTranslation("GAME_FLOW_REGIONNEXT_878_M", "Hmm...", "唔……");
            // 我看看啊……
            AddTranslation("GAME_FLOW_REGIONNEXT_REPEAT_#1_028_M", "Let me see...", "容余之观之……");
            // 让我想想……
            AddTranslation("GAME_FLOW_REGIONNEXT_REPEAT_#2_538_M", "Let me think...", "容余之思之……");
            // 唔……对了，我知道了。
            AddTranslation("GAME_FLOW_REGIONNEXT_REPEAT_#3_761_M", "Hmmm... Oh yes, I know.", "唔……然，余知之矣。");
            // 咱们得用到另一张地图……
            AddTranslation("GAME_FLOW_REGIONNEXT_REPEAT_#4_305_M", "We will need another map...", "须更一图……");
            // 等会儿啊……
            AddTranslation("GAME_FLOW_REGIONNEXT_REPEAT_#5_353_M", "A moment...", "少待……");
            // 潮湿的空气中弥漫着腐烂和发霉的味道。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_688_M", "The rank smell of rot and mold permeated the humid air.", "湿润之气者弥，腐霉之臭者漫焉。");
            // 每迈一步，落脚处就响起一片淤泥滑开的声音。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_522_M", "Every step forward was answered by some nearby slip or slither.", "每进之，迩辄有泥滑蜿动之声。");
            // 你小心翼翼地踏进了……[c:bR]湿地。[c:]
            AddTranslation("GAME_FLOW_REGIONWETLANDS_774_M", "You tread cautiously into... [c:bR]The Wetlands.[c:]", "汝谨入……[c:bR]湿泽。[c:]");
            // 空气中的湿气越来越重……
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#1_288_M", "The air grew thick with moisture...", "湿气愈重……");
            // 昆虫的嗡嗡声和鸣叫声淹没了你的脚步声……
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#1_440_M", "The buzzing and chirping of insects drowned out the sound of your footfalls...", "虫鸣振翅，没乃履声……");
            // 你看到了……[c:bR]湿地。[c:]
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#1_829_M", "You beheld... [c:bR]The Wetlands.[c:]", "汝见……[c:bR]湿泽。[c:]");
            // 空气越来越潮湿，你的靴子也更难从泥泞中拔出来。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#2_111_M", "As the air grew humid your boots became harder to pull from the mud.", "气既蒸湿，靴陷泥中，愈难自拔。");
            // 温水的潮湿气味侵入你的鼻腔。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#2_633_M", "The dank smell of tepid water invaded your nostrils.", "温潦腐气侵乃鼻中。");
            // 你到达了……[c:bR]湿地。[c:]
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#2_432_M", "You had reached... [c:bR]The Wetlands.[c:]", "汝至……[c:bR]湿泽。[c:]");
            // 温温吞吞的水灌满了你的靴子。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#3_536_M", "Tepid water flooded your boots.", "温潦盈靴。");
            // 苍蝇在你身边萦绕不绝。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#3_190_M", "Flies swarmed around you.", "苍蝇环尔。");
            // 你进入了……[c:bR]湿地。[c:]
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#3_958_M", "You had entered... [c:bR]The Wetlands.[c:]", "汝已入……[c:bR]湿泽。[c:]");
            // 可怕的昆虫在你周围萦绕。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#4_119_M", "A hideous swarm of insects gathered around you.", "丑虫群聚于乃侧。");
            // 各种爬行动物在你脚边穿行。
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#4_105_M", "Reptiles slipped and slithered around your feet.", "鳞物滑行于乃足下。");
            // 你已深深陷进了……[c:bR]湿地。[c:]
            AddTranslation("GAME_FLOW_REGIONWETLANDS_REPEAT_#4_613_M", "You were now engulfed by... [c:bR]The Wetlands.[c:]", "汝今为……[c:bR]湿泽[c:]所吞。");
            // 一阵恼人的冷风吹进你的肺部。
            AddTranslation("GAME_FLOW_REGIONALPINE_132_M", "A frigid gust of wind billowed, unwelcome, into your lungs.", "寒风猝入肺腑。");
            // 落雪的美景并不能让你分心忘记彻骨的寒意。
            AddTranslation("GAME_FLOW_REGIONALPINE_756_M", "The beauty of the falling snow failed to distract you from the chill in your bones.", "飞雪之妍，不足移尔于彻骨之寒。");
            // 你已爬升到了……[c:bR]雪线。[c:]
            AddTranslation("GAME_FLOW_REGIONALPINE_891_M", "You had ascended to... [c:bR]The Snow Line.[c:]", "汝已登……[c:bR]雪垠。[c:]");
            // 刺骨的寒意很快扫去了新鲜空气带来的慰藉。
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#1_063_M", "The relief of the fresh air quickly gave way to a bone-shaking chill.", "清气乍可慰，俄而寒彻骨。");
            // 你打量着前方因为下雪变得越来越模糊的路。
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#1_505_M", "You guessed at the path ahead as the snow increasingly obscured it.", "雪益蔽途，汝姑揣前路。");
            // 你已爬上了[c:bR]雪线。[c:]
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#1_787_M", "You had climbed to... [c:bR]The Snow Line.[c:]", "汝已登……[c:bR]雪垠。[c:]");
            // 你拼命想爬到高处，大片的冰雪敲打着你的身体。
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#2_089_M", "Sheets of icy snow battered your body as you fought your way up to a vantage point.", "冰雪扑体，汝力登高处。");
            // 冰雪覆盖的树木如犬牙差互般丑陋。
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#2_559_M", "The snow-covered trees jutted from the landscape like prickly misplaced teeth.", "积雪之木，出地若乱齿。");
            // 你继续前进，穿过了[c:bR]雪线。[c:]
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#2_019_M", "You continued on through... [c:bR]The Snow Line.[c:]", "汝复行于……[c:bR]雪垠。[c:]");
            // 落雪的美景并不能让你分心忘记彻骨的寒意。
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#3_072_M", "The beauty of the falling snow could not distract you from the chill in your bones.", "飞雪之妍，不足移尔于彻骨之寒。");
            // 你的身体颤抖不停，徒劳地试图维持一丝温暖。
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#3_439_M", "Your body quaked in a futile attempt to maintain warmth.", "汝身震栗，徒欲自温。");
            // 你终于抵达了……[c:bR]雪线。[c:]
            AddTranslation("GAME_FLOW_REGIONALPINE_REPEAT_#3_930_M", "You had finally reached... [c:bR]The Snow Line.[c:]", "汝终至……[c:bR]雪垠。[c:]");
            // 我的[c:bR]头目战[c:]是对你能力的高风险测试。
            AddTranslation("TUTORIAL_TUTORIALBOSSBATTLEPLAYERLIVES_852_M", "My [c:bR]boss battles[c:] are high stakes tests of your aptitude.", "朕[c:bR]魁战[c:]，危甚，足以试乃才。");
            // 只剩一根蜡烛，你要么战胜他们，要么死亡。
            AddTranslation("TUTORIAL_TUTORIALBOSSBATTLEPLAYERLIVES_944_M", "With one flame you will either overcome them or die.", "唯一烛存，汝非胜即死。");
            // 别害怕……我会给你留个烛烟的。
            AddTranslation("TUTORIAL_TUTORIALBOSSBATTLEPLAYERLIVES_628_M", "Fear not... I will let you keep the smoke.", "毋惧……余姑留厥烟。");
            // 当场死亡。
            AddTranslation("TUTORIAL_TUTORIALBOSSBATTLEPLAYERLIVES_REPEAT_#1_726_M", "Sudden death.", "立死。");
            // 要么赢，要么死。
            AddTranslation("TUTORIAL_TUTORIALBOSSBATTLEPLAYERLIVES_REPEAT_#2_667_M", "You will win this or you will die.", "非胜即死。");
            // 希望你没有以为这么容易就逃过去了……
            AddTranslation("TUTORIAL_TUTORIALBOSSBATTLEBOSSLIVES_914_M", "I hope you didn't think it would be that easy...", "愿汝之未以为其易也……");
            // 你是这么久以来第一个战胜头目的人。
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_605_M", "You're the first in a while to overcome a boss.", "汝乃久来首胜魁者。");
            // 作为奖励，你将有机会挑选一张……[c:bR]稀有卡牌[c:]。
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_663_M", "As a reward you are granted an opportunity to select a... [c:bR]rare card[c:].", "既赏，汝得择一……[c:bR]罕有牌[c:]。");
            // 认真选吧。
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_384_M", "Choose carefully.", "慎择之。");
            // 非常好。
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_REPEAT_#1_301_M", "Very well.", "善。");
            // 你可以选择一张[c:bR]稀有卡牌[c:]。
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_REPEAT_#1_511_M", "You may choose a [c:bR]rare card[c:].", "汝可择一[c:bR]罕有牌[c:]。");
            // 给你的奖励？
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_REPEAT_#2_863_M", "Your reward?", "汝之赏乎？");
            // 或许这里面有什么会是你喜欢的？
            AddTranslation("SPECIAL_NODES_RARECARDSINTRO_REPEAT_#4_861_M", "Perhaps one of these will entice you?", "或此中足有动汝心者？");
            // 寒雾降临，你周围的树木仿佛向你压迫过来。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_886_M", "The trees seemed to close in around you as a chill mist descended.", "寒雾既下，四木若迫乃周。");
            // 你可以听到远方传来金属敲击石头的叮当声。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_348_M", "In the distance you could hear the clinking of metal on stone.", "遥闻金石相击之声。");
            // 一个佝偻的身影站在你前方的路上……
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_781_M", "A hobbled figure stood in your path...", "一伛偻之形立于乃途……");
            // 无尽无休的“哐当哐当”声在你耳边回荡。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#1_897_M", "The incessant clank-clank-clanking reverberated between your ears.", "“哐—当—”不绝，震于乃耳。");
            // 前方的路被一个奇形怪状的身影挡住了……
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#1_505_M", "The path ahead was blocked by a grotesque figure...", "前路为一诡形所塞……");
            // 寒冷的雾气弥漫在你的四周。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#2_010_M", "A chill mist closed in around you.", "寒雾逼乃四周。");
            // 这里不止你一个人。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#2_327_M", "You were not alone.", "汝非独也。");
            // 一个身影从浓雾中出现。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#2_862_M", "A figure emerged from the fog.", "一形出于雾中。");
            // 你经过一只巨大的空碗，四周是成堆无法辨认的内脏和残骸。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#3_834_M", "You passed a massive empty bowl, surrounded by heaps of unidentifiable giblets and scantlings.", "汝过一巨盂，周积难辨之脏腑残肉。");
            // 这只碗似乎是打来喂狗的。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#3_603_M", "It seemed the bowl was designed for a dog.", "此盂若为犬设。");
            // 但世界上哪只猎犬能有这么大的饭量呢？
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#3_084_M", "But what earthly hound would require a meal of that size?", "然世间何犬，需此巨食乎？");
            // 四周全是树木，形成无法穿越的灌木丛。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#4_727_M", "The trees closed in tight around you, creating an impenetrable brush.", "四木逼合，丛不可穿。");
            // 唯一的出路就是向前进。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#4_406_M", "The only way out was forward.", "唯有前行一途。");
            // 而那佝偻的人影就站在必经之路上。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#4_056_M", "And the hobbled shape of a man stood in that way.", "而一伛人立厥途。");
            // 浓雾中弥漫着令人不安的叮当声。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#5_012_M", "A haunting clanking sound permeated the fog.", "雾中弥漫惨然丁当之声。");
            // 四周的树木向你逼了上来……
            AddTranslation("BOSS_DIALOGUE_PROSPECTORPREINTRO_REPEAT_#6_038_M", "The trees closed in tight around you...", "四木逼尔……");
            // 嘿哎哎哎吼！老子就是[c:bR]矿工[c:]啊！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_483_M", "Heeeeeeee-haaw! 'Twas [c:bR]The Prospector[c:]!", "嘿哎哎哎—吼！俺[c:bR]采夫[c:]也！");
            // 老子就是[c:bR]矿工[c:]啊！嘿哎哎哎吼！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#1_817_M", "'Twas [c:bR]The Prospector[c:]! Heeeeeeee-haaw!", "俺[c:bR]采夫[c:]也！嘿哎哎哎—吼！");
            // 挡在老子的金子前头？胆儿很肥啊！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#2_724_M", "Stand in the way o' me gold?! Be darned!", "敢当俺金路乎？当杀！");
            // 老子那猎犬呢？！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#3_646_M", "Where's that hound o' mine?!", "俺犬安在？！");
            // 那天灵盖下面有金、金子吗？！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#4_166_M", "Got any g-gold in that there skull?!", "你颅中有金—金乎？！");
            // 还是让老子掀开看看吧！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#4_702_M", "Let me crack it open n' take a look!", "俺且破而观之！");
            // 金、金子？！我能闻到味道！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#5_784_M", "G-gold?! I can smell it!", "金—金乎？！俺能嗅之！");
            // 嘿哎哎哎吼！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#6_880_M", "HEEE-HEE-HEE-HAAAAAAWWWWW!", "嘿—嘿嘿—嘿—哎哎哎吼！");
            // 老子就是[c:bR]矿工[c:]啊！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#6_034_M", "'Twas [c:bR]The Prospector[c:]!", "俺[c:bR]采夫[c:]也！");
            // 嘿嘿，驾！出发！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#7_367_M", "HEE-HEE-HEEEEEERRE WE GO!", "嘿—嘿—嘿嘿，来矣！");
            // 他奶奶的！看老子不杀了你！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORINTRO_REPEAT_#8_912_M", "Dag nab it! Now I got to kill ya!", "彼其老娘乎！今俺必杀你！");
            // 你没地方了。那张牌没地方放。
            AddTranslation("GAMEPLAY_HINTS_HINT_ALLSLOTSFULL_426_M", "You're out of space. There's no room for that card.", "乃地尽矣，此牌无所容。");
            // 无处使用此卡牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_ALLSLOTSFULL_REPEAT_#1_211_M", "There's nowhere for that card to be played.", "此牌无所陈。");
            // 没有地方放置此卡牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_ALLSLOTSFULL_REPEAT_#2_148_M", "There's nowhere to put it.", "无所置之。");
            // 你没位置了。
            AddTranslation("GAMEPLAY_HINTS_HINT_ALLSLOTSFULL_REPEAT_#3_689_M", "You're out of space.", "乃位尽矣。");
            // 所有位置都满了。
            AddTranslation("GAMEPLAY_HINTS_HINT_ALLSLOTSFULL_REPEAT_#4_971_M", "All your spaces are full.", "乃诸位皆满矣。");
            // 一股恶臭侵入鼻腔，你的喉咙也痉挛起来。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_409_M", "A foul smell invaded your nostrils and caused your throat to seize.", "恶臭入鼻，喉为之噎。");
            // 一个身材魁梧的男人坐在咸水池边，双脚浸泡在黑水里。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_939_M", "A hulking man sat by a brackish pond with his feet submerged in the dark water.", "一伟丈夫坐咸池之旁，足浸玄水。");
            // 他从一堆腐烂的鱼中拉出一只鱼钩，站起身来。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_043_M", "He pulled a hook from a pile of rotting fish and rose to his feet.", "彼自腐鱼堆中曳一钩而起。");
            // 泥浆深深裹挟着你的双脚，迫使你放慢步伐。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#1_758_M", "The mud tugged hard at your feet, forcing you to slow your pace.", "泥深牵足，迫汝徐行。");
            // 一股浓烈的气味让你的胃不断翻腾，眼睛泪流不止。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#1_339_M", "A rank odor caused your stomach to churn and your eyes to water.", "浓臭翻汝腹，泪出于目。");
            // 原来是挂在你周围树上的一条条臭鱼。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#1_206_M", "It was the rotting fish that hung from the branches around you.", "原枝上所悬者，皆腐鱼也。");
            // 一个大块头走了过来。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#1_971_M", "A huge man approached.", "一巨丈夫近。");
            // 你看到一个大块头懒洋洋地躺在泥泞的池塘边上。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#2_297_M", "You beheld an immense man slouched beside a mucky pond.", "汝见一巨丈夫踞于污池之侧。");
            // 他好像是在从死鱼身上大块大块地往下撕鱼肉。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#2_300_M", "He appeared to be tearing hunks of flesh from a fish corpse.", "彼若裂死鱼之肉。");
            // 好几块肉被他丢回了池塘，几只食腐的鸟上来哄抢。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#2_876_M", "Some chunks were thrown back to the pond, where a few ghoulish birds snapped them up.", "厥肉有掷还池中者，数怪鸟争啄之。");
            // 还有几块被这个大块头囫囵塞进嘴里……
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#2_540_M", "And some were sloppily pushed into the hulking man's mouth...", "亦有数肉草草纳于厥口……");
            // 你原来以为是块奇形怪状的巨石，现在看来是个巨汉。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#3_562_M", "What you first mistook for a misshapen boulder appeared to be a hulking man.", "汝初以为怪石者，今见乃巨丈夫也。");
            // 你试图从他身旁悄悄溜过……
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#3_271_M", "You attempted to sneak past him...", "汝试潜过厥侧……");
            // 但你的脚却踢到了一个铁桶……
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#3_345_M", "But your foot made contact with a metal bucket...", "然汝足触一桶……");
            // 一股腐烂的气味让你反胃。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#4_159_M", "A rotten scent caused you to retch.", "腐气冲尔欲呕。");
            // 你正弯着腰，眼前出现了一只泥泞的靴子。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#4_765_M", "Doubled over, a mucky boot entered your field of view.", "惟汝俯身，一污靴入目。");
            // 你抬起头，看到了一个大得出奇的身影。
            AddTranslation("BOSS_DIALOGUE_ANGLERPREINTRO_REPEAT_#4_451_M", "You looked up to behold an unnaturally large figure.", "汝仰，见非常之巨形。");
            // 我是[c:bR]钓鱼人[c:]。去钓鱼吧。
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_377_M", "I am [c:bR]The Angler[c:]. Go fish.", "予[c:bR]渔父[c:]也。且钓。");
            // 开钓吧。
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_REPEAT_#1_742_M", "Go fish.", "且钓。");
            // 你带了新鲜的鱼吗？
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_REPEAT_#2_625_M", "You bring fresh fish?", "女携鲜鱼来乎？");
            // 这个好选。
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_REPEAT_#2_246_M", "Easy choose.", "此易择。");
            // 我是[c:bR]钓鱼人[c:]。
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_REPEAT_#3_239_M", "I am [c:bR]The Angler[c:].", "予[c:bR]渔父[c:]也。");
            // 你是鱼。
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_REPEAT_#3_988_M", "You are the fish.", "女乃鱼也。");
            // 带鱼了吗？
            AddTranslation("BOSS_DIALOGUE_ANGLERINTRO_REPEAT_#4_764_M", "Bring fish?", "携鱼来乎？");
            // 想看看俺的毛皮吗？
            AddTranslation("SPECIAL_NODES_TRAPPERINTRO_880_M", "Care to look at me pelts?", "欲观鄙革乎？");
            // 俺的毛皮天底下最精致！
            AddTranslation("SPECIAL_NODES_TRAPPERINTRO_REPEAT_#1_178_M", "I've the most exquisite pelts!", "鄙革最精！");
            // 俺的毛皮贼干净。
            AddTranslation("SPECIAL_NODES_TRAPPERINTRO_REPEAT_#2_614_M", "Me pelts are clean.", "鄙革甚洁。");
            // 方圆百里地以内找不到更好的毛皮了！
            AddTranslation("SPECIAL_NODES_TRAPPERINTRO_REPEAT_#3_249_M", "Ye won't find better pelts within a hunnerd miles!", "百里之内，无有胜鄙革者！");
            // 俺的毛皮是最好的！
            AddTranslation("SPECIAL_NODES_TRAPPERINTRO_REPEAT_#4_902_M", "Me pelts are the finest.", "鄙革最良。");
            // 俺有上好的毛皮出售。
            AddTranslation("SPECIAL_NODES_TRAPPERINTRO_REPEAT_#5_760_M", "I've the finest pelts for sale.", "鄙有上革鬻之。");
            // 谢、谢谢啊。
            AddTranslation("SPECIAL_NODES_TRAPPEROUTRO_583_M", "Th- thanks for yer business.", "谢—谢君来贾。");
            // 非常感谢。
            AddTranslation("SPECIAL_NODES_TRAPPEROUTRO_REPEAT_#1_092_M", "Much appreciated.", "感佩甚矣。");
            // 谢谢照顾生意。
            AddTranslation("SPECIAL_NODES_TRAPPEROUTRO_REPEAT_#2_511_M", "Thanks for yer patronage.", "谢君来贾。");
            // 俺谢谢你了。
            AddTranslation("SPECIAL_NODES_TRAPPEROUTRO_REPEAT_#3_119_M", "Ye have me gratitude.", "鄙感君矣。");
            // 你介意我检查一下你那些毛皮吗？
            AddTranslation("SPECIAL_NODES_TRADERINTRO_043_M", "Do you mind if I examine those pelts of yours?", "容鄙之按视君之革，可乎？");
            // 拿点精致的毛皮给我看看……
            AddTranslation("SPECIAL_NODES_TRADERINTRO_REPEAT_#1_327_M", "Show me some exquisite pelts...", "以精革示鄙……");
            // 你的毛皮干净吗？
            AddTranslation("SPECIAL_NODES_TRADERINTRO_REPEAT_#2_515_M", "Are your pelts clean?", "乃革洁乎？");
            // 我想要一些……不寻常的毛皮。
            AddTranslation("SPECIAL_NODES_TRADERINTRO_REPEAT_#3_490_M", "I am anticipating some... extraordinary pelts.", "我所俟者……异革也。");
            // 你带了上等的毛皮吗？
            AddTranslation("SPECIAL_NODES_TRADERINTRO_REPEAT_#4_555_M", "Have you brought me fine pelts?", "君携良革来乎？");
            // 看看我能拿些什么和你换这些毛皮吧……
            AddTranslation("SPECIAL_NODES_TRADERINTRO_REPEAT_#5_710_M", "Let's see what I can offer you for those pelts...", "试观鄙可以何易乃革……");
            // 先从你的野兔皮开始吧……这是我能给你的东西。
            AddTranslation("SPECIAL_NODES_TRADERPELTSHARE_881_M", "Let's start with your hare pelts... Here's what I can offer.", "且先观乃兔革……此鄙所能予者。");
            // 野兔皮……
            AddTranslation("SPECIAL_NODES_TRADERPELTSHARE_REPEAT_#1_398_M", "Hare pelts...", "兔革……");
            // 喔！还有狼皮？很精致啊……
            AddTranslation("SPECIAL_NODES_TRADERPELTSWOLF_245_M", "Oh! Wolf pelts too? Exquisite...", "噫！亦有狼革乎？精甚……");
            // 狼皮！
            AddTranslation("SPECIAL_NODES_TRADERPELTSWOLF_REPEAT_#1_517_M", "Wolf pelts!", "狼革！");
            // 那是……是金羊皮吗？！漂亮极了。
            AddTranslation("SPECIAL_NODES_TRADERPELTSGOLDEN_239_M", "Is that a- a- Golden Pelt?! Magnificent.", "此—此—此乃金革乎？！美哉。");
            // 简直难以置信。金羊皮？
            AddTranslation("SPECIAL_NODES_TRADERPELTSGOLDEN_REPEAT_#1_936_M", "Incredible. Golden Pelts?", "异哉。金革乎？");
            // 太不可思议了……
            AddTranslation("SPECIAL_NODES_TRADERPELTSGOLDEN_REPEAT_#2_717_M", "Marvelous...", "妙哉……");
            // 这些毛皮质量甚佳。太感谢了。
            AddTranslation("SPECIAL_NODES_TRADEROUTRO_154_M", "These pelts are most excellent. My thanks.", "此诸革至善，谢矣。");
            // 十分感激。
            AddTranslation("SPECIAL_NODES_TRADEROUTRO_REPEAT_#1_279_M", "You have my gratitude.", "感荷。");
            // 这些都很精致。太感谢了。
            AddTranslation("SPECIAL_NODES_TRADEROUTRO_REPEAT_#2_285_M", "These are exquisite. My thanks.", "此诸革甚精，谢矣。");
            // 我会善加好利用的……
            AddTranslation("SPECIAL_NODES_TRADEROUTRO_REPEAT_#3_495_M", "I will make good use of these...", "鄙当善用此……");
            // 一头奇怪的野兽潜伏其中。
            AddTranslation("TUTORIAL_TUTORIALDECKTRIAL_506_M", "A strange beast lurked within.", "中有异兽潜焉。");
            // 它用粗哑的声音说：“[c:bSG]只要通过我的一个试炼……我就是你的了……[c:]”。
            AddTranslation("TUTORIAL_TUTORIALDECKTRIAL_693_M", "It spoke \"[c:bSG]Pass one of my trials... and I will be yours...[c:]\" in a raspy voice.", "其声嘶曰：“[c:bSG]胜我一试……余即属尔……[c:]”");
            // 即将从你的牌组中抽出3只造物。它们将决定你的成败。
            AddTranslation("TUTORIAL_TUTORIALDECKTRIAL2_282_M", "3 creatures will be drawn from your deck. They will decide your success or failure.", "将自乃牌列之中引三物，以决成败。");
            // 它再次开口：“[c:bSG]但你要先选择一个试炼[c:]”。
            AddTranslation("TUTORIAL_TUTORIALDECKTRIAL2_307_M", "It spoke again: \"[c:bSG]But first you will choose a trial[c:]\".", "其复曰：“[c:bSG]然汝须先择一试[c:]”。");
            // 你已通过试炼。
            AddTranslation("SPECIAL_NODES_DECKTRIALPASSED_750_M", "You have passed the trial.", "汝已胜其试。");
            // 你已通过。
            AddTranslation("SPECIAL_NODES_DECKTRIALPASSED_REPEAT_#1_839_M", "You have passed.", "汝已胜矣。");
            // 成功。
            AddTranslation("SPECIAL_NODES_DECKTRIALPASSED_REPEAT_#2_364_M", "Success.", "胜。");
            // 已通过试炼。
            AddTranslation("SPECIAL_NODES_DECKTRIALPASSED_REPEAT_#3_784_M", "The trial was passed.", "此试既胜。");
            // [c:bSG]失败了……[c:]那怪物消逝在黑暗中，同时悄声低语。
            AddTranslation("SPECIAL_NODES_DECKTRIALFAILED_994_M", "[c:bSG]Failure...[c:] the creature whispered as it is faded into the blackness.", "[c:bSG]败矣……[c:]其物低语隐于暗。");
            // 失败。
            AddTranslation("SPECIAL_NODES_DECKTRIALFAILED_REPEAT_#1_586_M", "Failure.", "败。");
            // [c:bSG]下一次吧……[c:]它嘶哑地说着，退回山洞。
            AddTranslation("SPECIAL_NODES_DECKTRIALFAILED_REPEAT_#2_021_M", "[c:bSG]Perhaps next time...[c:] the creature rasped as it retreated back into the cave.", "[c:bSG]其待他日乎……[c:]其物嘶然而退入穴。");
            // 试炼已失败。
            AddTranslation("SPECIAL_NODES_DECKTRIALFAILED_REPEAT_#3_262_M", "The trial was failed.", "此试既败。");
            // ……[c:R][w:1][t:100][shake:1]听[shake:1]好[shake:1]！[w:0.4][t:0][c:]活生生的柠檬片来了。
            AddTranslation("GBC_NPC_GHOULROYALGREETING_454_M", "...[c:R][w:1][t:100][shake:1]H[shake:1]A[shake:1]R[shake:1]K[shake:1]![w:0.4][t:0][c:] A livin' slice o' lemon approaches.", "……[c:R][w:1][t:100][shake:1]听[shake:1]哉[shake:1]！[w:0.4][t:0][c:]鲜柠片至矣。");
            // “檬”谁也“檬”不了我！ 
            AddTranslation("GBC_NPC_GHOULROYALGREETING_026_M", "Bright an' trig as a lime. ", "鲜利靡能“檬”某？");
            // 你以为你[w:0.5]能把[c:R][w:0.5][t:100][shake:1]我榨干吗[shake:1]？[w:0.5]
            AddTranslation("GBC_NPC_GHOULROYALGREETING_698_M", "Ye think ye[w:0.5] will squeeze a defeat out o' [c:R][w:0.5][t:100][shake:1]M[shake:1]E[shake:1]?[w:0.5]", "汝谓汝之[w:0.5]能榨[c:R][w:0.5][t:100][shake:1]某[shake:1]之[shake:1]败[shake:1]乎[shake:1]？[w:0.5]");
            // 哎呀。[w:0.3]你都把我打成果酱了。
            AddTranslation("GBC_NPC_GHOULROYALVICTORY_283_M", "Aye.[w:0.3] Ye beat the pulp out o' me.", "呀。[w:0.3]汝几将捣某之如果浆。");
            // 先[w:0.3]把这个带上。
            AddTranslation("GBC_NPC_GHOULROYALVICTORY_188_M", "Firstly,[w:0.3] take ye this.", "先[w:0.3]取此。");
            // 你这准备，橙不橙啊？
            AddTranslation("GBC_NPC_GHOULROYALDEFEAT_101_M", "Orange ye a bit underprepared?", "汝之备，岂稍未橙乎？");
            // 我要把你打成果酱！
            AddTranslation("GBC_NPC_GHOULROYALDEFEAT_REPEAT_#1_046_M", "I beat the livin' PULP out o' ye!", "某必捣汝为浆！");
            // 我没拿香蕉给你打比方，柠开不开心？
            AddTranslation("GBC_NPC_GHOULROYALDEFEAT_REPEAT_#2_766_M", "Orange ye glad I didn' say banana?", "某不言喻以蕉，汝柚幸乎？");
            // 你面前站着一个人。这人你一眼就能认出来。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_928_M", "A man stood before you. A man you recognized immediately.", "一人立于乃前，汝一见即识之。");
            // 是[c:bR]猎人[c:]。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_948_M", "It was [c:bR]The Trapper[c:].", "即[c:bR]猎夫[c:]也。");
            // 你伸手想检查他的货物，但他阻止了你。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_109_M", "You reached out to examine his wares, but he stopped you.", "汝伸手欲察厥货，彼止之。");
            // 你注意到了[c:bR]猎人[c:]毛皮的熟悉模样和气味。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#1_815_M", "You took in the familiar sights and scents of [c:bR]The Trapper[c:]'s pelts.", "汝见厥[c:bR]猎夫[c:]裘革之熟色与故气。");
            // 但又似乎有什么不同。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#1_015_M", "But something was different.", "然有异焉。");
            // 那一度十分友善的人在用坚毅的目光凝视着你。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#1_940_M", "The once friendly man now beheld you with a steely gaze.", "昔和之人，今以厉目视汝。");
            // [c:bR]猎人[c:]蜷缩着身子坐在自己设的陷阱旁边，拿起曲柄慢慢把它打开。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#2_964_M", "[c:bR]The Trapper[c:] sat hunched beside one of his traps, slowly cranking it open.", "[c:bR]猎夫[c:]伛坐厥阱旁，徐徐开之。");
            // 他小心翼翼地从钢齿中取出一只血肉模糊的野兔，但并没有将陷阱解除。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#2_661_M", "He gingerly removed a mangled hare from the steel teeth, but left the trap unhinged.", "彼谨自钢齿取一残兔，而阱犹张不阖。");
            // [c:bR]猎人[c:]站在你面前。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#3_257_M", "[c:bR]The Trapper[c:] stood before you.", "[c:bR]猎夫[c:]立于乃前。");
            // 你习惯性地伸手去拿你收集的牙齿。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#3_617_M", "Out of habit, you reached for your collection of teeth.", "汝习而探所蓄之牙。");
            // 那人苦笑着摇了摇头。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREINTRO_REPEAT_#3_499_M", "The man grimaced and shook his head.", "其人蹙额摇首。");
            // 抱歉，但今天是[c:bR]你[c:]要提供毛皮嘞。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERINTRO_123_M", "Sorry. But today [c:bR]you[c:] will supply the pelts.", "歉矣。然今当出革者，乃[c:bR]君[c:]也。");
            // 恐怕俺今天必须剥掉[c:bR]你[c:]的皮嘞。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERINTRO_REPEAT_#1_168_M", "I'm afraid I must be skinning [c:bR]you[c:] today.", "恐鄙今之必剥[c:bR]君[c:]之皮也。");
            // [c:bR]你不该来这儿的。[c:]
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERINTRO_REPEAT_#2_479_M", "[c:bR]Ye shouldn't have come 'ere.[c:]", "[c:bR]君不当来此。[c:]");
            // 你的皮剥下来应该挺精致的。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERINTRO_REPEAT_#3_773_M", "An exquisite pelt, ye shall make.", "君皮今当成精革。");
            // 来交易吧。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPHASE2_753_M", "Let's trade.", "今，易之合。");
            // 上等的毛皮……但循环必须继续。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREPHASE2_652_M", "Exquisite pelts... But the cycle must continue.", "上革……然其轮轮不可止。");
            // 啊，我的回合就结束了。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREPHASE2_REPEAT_#1_981_M", "Ah, it is the end of my turn.", "啊，鄙之合尽矣。");
            // 剥皮刀转啊转……
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPREPHASE2_REPEAT_#2_024_M", "The skinning knife turns...", "剥刀旋旋矣……");
            // 强大的卡牌……我只接受用最好的毛皮来交换。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPRETRADE_373_M", "Powerful cards... I will accept only the finest pelts for them.", "强牌……唯以上革易之，鄙乃受。");
            // 能换什么就换吧，但要知道：剩下的都将留下来为我而战。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPRETRADE_296_M", "Trade for what you can, but know this: the rest will stay and fight for me.", "能易几何，姑易之；馀者当留而为鄙战。");
            // 希望你有带毛皮……
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPRETRADE_REPEAT_#1_993_M", "I hope you brought pelts...", "愿君携革而来……");
            // 因为这些造物已经准备好撕开你的喉咙了。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPRETRADE_REPEAT_#1_993_M", "Because these creatures are prepared to rip your throat out.", "盖此诸物已备裂君之喉。");
            // 真是健壮的造物啊……好好选啊。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPRETRADE_REPEAT_#2_010_M", "Such powerful creatures... Choose wisely.", "此诸物强甚……慎择之。");
            // 如果是我，就不会这样选。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPOSTTRADE_315_M", "I would have chosen differently.", "若为鄙，则不然择。");
            // 唔……很好。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPOSTTRADE_REPEAT_#1_857_M", "Hmmm... Very well.", "唔……可。");
            // 奇怪的选择。
            AddTranslation("BOSS_DIALOGUE_TRAPPERTRADERPOSTTRADE_REPEAT_#2_146_M", "Strange choices.", "其择异哉。");
            // 请允许我再点一次你的蜡烛。还没到杀你的时候。
            AddTranslation("_REPLENISHLIVES_675_M", "Allow me to light your candles once more. I won't be killing you quite yet.", "请更燃乃烛。今非乃忌。");
            // 让我重新点燃你的蜡烛。
            AddTranslation("_REPLENISHLIVES_REPEAT_#1_474_M", "Let me relight your candles.", "令余之更燃乃烛。");
            // 要借个火吗？
            AddTranslation("_REPLENISHLIVES_REPEAT_#2_288_M", "Need a light?", "须火乎？");
            // 你的命数已恢复。
            AddTranslation("_REPLENISHLIVES_REPEAT_#3_964_M", "Your lives are restored.", "乃命既复矣。");
            // 你还不会这么早消亡。
            AddTranslation("_REPLENISHLIVES_REPEAT_#4_499_M", "You will not perish quite yet.", "汝未遽殒也。");
            // 烛火，重新燃起吧。
            AddTranslation("_REPLENISHLIVES_REPEAT_#5_251_M", "Reignite.", "更燃。");
            // 奇怪了……你的牌组里没有可献祭的祭品。
            AddTranslation("SPECIAL_NODES_CARDMERGEINVALID_195_M", "Odd... There isn't a sacrifice that can be made among your troupe.", "怪哉……乃牌列中无可为牲者。");
            // 石头因愤怒而颤动……
            AddTranslation("SPECIAL_NODES_CARDMERGEINVALID_627_M", "The stones quake with rage...", "石愤而震……");
            // 没得献祭吗？
            AddTranslation("SPECIAL_NODES_CARDMERGEINVALID_REPEAT_#1_509_M", "No possible sacrifices?", "无可为牲者乎？");
            // 石头隆隆作响……
            AddTranslation("SPECIAL_NODES_CARDMERGEINVALID_REPEAT_#1_931_M", "The stones rumble...", "石訇然……");
            // 你的牌组中没有卡牌能够完成此仪式……
            AddTranslation("SPECIAL_NODES_CARDMERGEINVALID_REPEAT_#2_544_M", "None among your troupe can perform the ritual...", "乃牌列中无能成此仪者……");
            // 石头在痛苦中哀鸣着……
            AddTranslation("SPECIAL_NODES_CARDMERGEINVALID_REPEAT_#2_805_M", "The stones wail in anguish...", "石苦而哀鸣……");
            // 你一共能犯两次错误，这是其中之一。
            AddTranslation("MISC_PLAYERLIFELOST_595_M", "That was one of the two mistakes you can make here.", "此汝于此可犯二失之一也。");
            // 如果再犯一个，我就得拿你去献祭了。
            AddTranslation("MISC_PLAYERLIFELOST_784_M", "If you make another I must sacrifice you.", "若复一失，余必以尔为牲。");
            // 好，咱们进行到哪了……
            AddTranslation("MISC_PLAYERLIFELOST_048_M", "Now, where were we...", "今至何所矣……");
            // 太令人失望了……
            AddTranslation("MISC_PLAYERLIFELOST_REPEAT_#1_662_M", "How disappointing...", "大失所望……");
            // 我高看你了。
            AddTranslation("MISC_PLAYERLIFELOST_REPEAT_#2_496_M", "I hoped for more.", "余望尔过甚焉。");
            // 什么时候才会出现实至名归的[c:bR]挑战者[c:]呢？
            AddTranslation("MISC_PLAYERLIFELOST_REPEAT_#3_679_M", "When will a worthy [c:bR]Challenger[c:] appear?", "曷有足称[c:bR]角者[c:]乎？");
            // 我简直没眼看。
            AddTranslation("MISC_PLAYERLIFELOST_REPEAT_#4_473_M", "It's painful to see.", "见之痛矣。");
            // 太遗憾了……
            AddTranslation("MISC_PLAYERLIFELOST_REPEAT_#5_543_M", "Pity...", "惜哉……");
            // 幸运一手。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWN_REPEAT_#1_105_M", "Lucky draw.", "幸引。");
            // 又到我了。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWN_REPEAT_#2_738_M", "Me again.", "又咱也。");
            // 手牌不错。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWN_REPEAT_#3_529_M", "Nice topdeck.", "上引善矣。");
            // 好嘞。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWN_REPEAT_#4_004_M", "Yep.", "然。");
            // 走起走起。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_250_M", "Here we go.", "行矣。");
            // 又上牌桌了。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#1_514_M", "Back on the board.", "咱复登局矣。");
            // 这里？[w:0.2]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#2_738_M", "This spot?[w:0.2]", "此处乎？[w:0.2]");
            // 你确定？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#2_844_M", "You sure?", "卿审乎？");
            // 行吧……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#3_703_M", "OK...", "可矣……");
            // 会不会玩啊你。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#4_455_M", "Total misplay.", "大昏著也。");
            // 行吧。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#5_891_M", "Fine.", "可。");
            // 别弄死我。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#6_564_M", "Keep me alive.", "全我。");
            // 这一手不太好。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATPLAYED_REPEAT_#8_338_M", "Bad play.", "此陈非善。");
            // [anim:shock][size:4]啊。[anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATATTACKED_085_M", "[anim:shock][size:4]Ack.[anim:]", "[anim:shock][size:4]噫。[anim:]");
            // [anim:shock][size:4]嗷。[anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATATTACKED_REPEAT_#1_736_M", "[anim:shock][size:4]Ow.[anim:]", "[anim:shock][size:4]痛。[anim:]");
            // [anim:shock][size:4]够了！[anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATATTACKED_REPEAT_#2_494_M", "[anim:shock][size:4]Enough![anim:]", "[anim:shock][size:4]已矣！[anim:]");
            // [anim:shock][size:4]停下。[anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATATTACKED_REPEAT_#3_028_M", "[anim:shock][size:4]Stop that.[anim:]", "[anim:shock][size:4]止之。[anim:]");
            // [anim:shock][size:4]哎哟。[anim:]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATATTACKED_REPEAT_#4_937_M", "[anim:shock][size:4]Ouch.[anim:]", "[anim:shock][size:4]痛哉。[anim:]");
            // 祝你好运……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDECKTRIAL_366_M", "Good luck...", "愿卿吉……");
            // 又是这个？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDECKTRIAL_REPEAT_#1_118_M", "This again?", "又此乎？");
            // 祈祷好运。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDECKTRIAL_REPEAT_#2_512_M", "Fingers crossed.", "庶几其吉。");
            // 祝你好运。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDECKTRIAL_REPEAT_#3_222_M", "Good luck.", "愿卿得吉。");
            // 好疼啊。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGATTACKED_807_M", "That stings.", "甚痛。");
            // 哎呀！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGATTACKED_REPEAT_#1_925_M", "Ah!", "噫！");
            // 死神啊把我带走吧！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGATTACKED_REPEAT_#2_306_M", "Death take me!", "死亡其取我！");
            // 疼死啦！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGATTACKED_REPEAT_#3_339_M", "That stings!", "痛甚！");
            // 我的肉啊……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGATTACKED_REPEAT_#4_964_M", "My flesh...", "朕肌……");
            // 祝你一切安好。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDECKTRIAL_724_M", "I wish you well.", "愿汝安。");
            // 祝你好运。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDECKTRIAL_REPEAT_#1_316_M", "Good fortune.", "愿汝吉。");
            // 我有帮到什么吗？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDECKTRIAL_REPEAT_#2_038_M", "Did I help?", "奴其有助乎？");
            // 祝福你。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDECKTRIAL_REPEAT_#3_100_M", "You have my blessing.", "汝有朕祐。");
            // 选择权在你。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICEPOSITIVE_372_M", "The choice is yours.", "取舍在尔。");
            // 太惊人了！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICEPOSITIVE_REPEAT_#1_944_M", "Marvelous.", "善哉！");
            // 哈喽。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICEPOSITIVE_REPEAT_#2_154_M", "Hello.", "汝安。");
            // 你选的是我吗？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICEPOSITIVE_REPEAT_#3_018_M", "Am I your choice?", "奴乃所取乎？");
            // [t:0.01]黑暗带我走吧。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSACRIFICE_579_M", "[t:0.01]Darkness take me.", "[t:0.01]幽冥其取我。");
            // [t:0.01]又是死神……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSACRIFICE_REPEAT_#1_206_M", "[t:0.01]Death again...", "[t:0.01]又殁乎……");
            // 卷土重来。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGPLAYED_894_M", "Back in the game.", "奴复在局矣。");
            // 好牌！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGPLAYED_REPEAT_#1_413_M", "Good play.", "善陈。");
            // 出手吧？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGPLAYED_REPEAT_#2_161_M", "Shall we?", "其行乎？");
            // 噼啪！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGPLAYED_REPEAT_#3_980_M", "Cracking!", "善哉！");
            // 技艺精湛。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGPLAYED_REPEAT_#4_493_M", "Masterful.", "工矣。");
            // 赋予我力量吧！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGHOSTCHOSEN_557_M", "Empower me!", "益我力！");
            // 没错！更多力量！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGHOSTCHOSEN_REPEAT_#1_771_M", "Yes! More power!", "然！更益我威！");
            // 太棒了。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGHOSTCHOSEN_REPEAT_#2_549_M", "Excellent.", "善。");
            // 明智的选择。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGHOSTCHOSEN_REPEAT_#3_679_M", "A wise choice.", "此择善矣。");
            // 你好哇。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWN_164_M", "Greetings.", "敬问。");
            // 向你致意。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWN_REPEAT_#1_793_M", "Salutations.", "谨问。");
            // 幸运一抽。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWN_REPEAT_#2_007_M", "A lucky draw.", "幸而得引。");
            // 抽了张好牌。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWN_REPEAT_#3_550_M", "Great draw.", "善引。");
            // 他又在扮……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_606_M", "He's doing the...", "彼复在扮……");
            // 矿工了？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_694_M", "Prospector again?", "采夫乎？");
            // 小菜一碟。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_466_M", "Easy boss.", "此魁易耳。");
            // 那头骡子是关键。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_322_M", "The Mule's key.", "机在骡也。");
            // 矿工头目……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_REPEAT_#1_014_M", "Prospector boss...", "采夫之魁……");
            // 干掉那头骡子就对了。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_REPEAT_#2_200_M", "Just pop that Mule.", "但毙厥骡。");
            // 又到头目战了哈？
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATDRAWNPROSPECTOR_REPEAT_#3_185_M", "Boss time, eh?", "又复魁战乎？");
            // 钓鱼人……[w:0.3]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_933_M", "The Angler...[w:0.3]", "渔父……[w:0.3]");
            // 注意他的鱼钩！[w:0.3]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_663_M", "Mind his hook![w:0.3]", "慎厥钩！[w:0.3]");
            // 使用松鼠
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_575_M", "Play a squirrel", "陈松鼠");
            // 或别的卡牌
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_387_M", "or something", "抑或他牌");
            // 就在他瞄准的时候。[w:0.5]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_741_M", "when he aims it.[w:0.5]", "于厥钩将施。[w:0.5]");
            // 可以保护
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_260_M", "That will protect", "则可以卫");
            // 你最强的卡牌。[w:0.3]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_248_M", "your best cards.[w:0.3]", "乃善牌。[w:0.3]");
            // 闻着一股鱼味……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_REPEAT_#1_428_M", "Smells like fish...", "有鱼腥……");
            // 那股腐臭的气味……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_REPEAT_#2_960_M", "That putrid smell...", "厥臭腐甚……");
            // 注意那个鱼钩！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_REPEAT_#3_721_M", "Mind that hook!", "慎彼钩！");
            // 啊……这味道……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGDRAWNANGLER_REPEAT_#4_377_M", "Ah... that odor...", "嗟……此臭……");
            // 他奶奶的！我的骡子！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORMULEKILLED_055_M", "Dag nab it! My mule!", "甚恶！俺骡！");
            // 他奶奶的！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORMULEKILLED_REPEAT_#1_810_M", "Daaag nab it!", "彼其娘焉！");
            // 我的骡子！我的货！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORMULEKILLED_REPEAT_#2_249_M", "My mule! And 'er pack!", "俺骡！及其负囊！");
            // 我的骡子啊！我要诅咒你！
            AddTranslation("BOSS_DIALOGUE_PROSPECTORMULEKILLED_REPEAT_#3_944_M", "My mule! Curse you!", "俺骡！诅你甚！");
            // 你个胆小鬼！欺负无人看护的骡子。
            AddTranslation("BOSS_DIALOGUE_PROSPECTORMULEKILLED_REPEAT_#4_222_M", "Ye' coward! That mule was defenseless.", "你懦夫也！欺彼骡无以自卫。");
            // 你的牌组。
            AddTranslation("_DECKREVIEW_172_M", "Your deck.", "乃牌列。");
            // 你可太残忍了……
            AddTranslation("TUTORIAL_TUTORIALGAINCURRENCY_767_M", "How brutal of you...", "汝狠非常矣……");
            // 你对我造成的伤害远超你获胜需要的点数。
            AddTranslation("TUTORIAL_TUTORIALGAINCURRENCY_099_M", "You dealt me more damage than you needed to win.", "汝加我之伤，过其所以能胜者。");
            // 但在[c:bR]我[c:]这里，此等骄人战绩是可以得到奖励的……
            AddTranslation("TUTORIAL_TUTORIALGAINCURRENCY_073_M", "However, in [c:bR]my[c:] game, such feats are rewarded...", "然于[c:bR]朕[c:]局，此等异绩有赐……");
            // 准确地说，每造成一点额外伤害，我就送你一颗牙齿。
            AddTranslation("TUTORIAL_TUTORIALGAINCURRENCY_088_M", "To be precise: A tooth to keep for each extra damage dealt.", "详言之：每溢伤一，则留一齿。");
            // [c:bR]猎人[c:]可能会对你的战利品感兴趣。
            AddTranslation("TUTORIAL_TUTORIALGAINCURRENCY_989_M", "The [c:bR]Trapper[c:] may be interested in your spoils.", "[c:bR]猎夫[c:]或悦乃获。");
            // 唔。
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_216_M", "Hm.", "唔。");
            // 你能携带的道具数是[v:0]。当前你拥有[v:0]个……
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_201_M", "The amount of items you can carry is [v:0]. And you have [v:0]...", "乃可赍器，数止[v:0]。今乃有[v:0]……");
            // 不过，或许你会接受我朋友送的这份礼物？
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_917_M", "Instead, perhaps you'll accept this gift from my friend?", "然则，汝其受朕友之赠乎？");
            // 你的背包已满……
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_REPEAT_#1_018_M", "Your pack was full...", "乃囊既盈……");
            // 但有一只小动物走近了。
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_REPEAT_#1_059_M", "But a small critter approached.", "然有小兽来。");
            // 满了……
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_REPEAT_#2_776_M", "All full...", "既盈矣……");
            // 但……
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_REPEAT_#2_205_M", "But...", "然……");
            // 我不会允许你带更多物品了。
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_REPEAT_#3_948_M", "I won't allow you to take more items.", "余弗听尔更取器。");
            // 带上这个吧……
            AddTranslation("SPECIAL_NODES_GAINCONSUMABLESFULL_REPEAT_#3_745_M", "In their stead, take this...", "姑受此以代之……");
            // 你[c:bR]什么[c:]奖励都没拿到吗？
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS0_287_M", "You didn't get [c:bR]ANY[c:] boons?", "汝竟未获[c:bR]一[c:]惠乎？");
            // 这连个挑战都算不上……
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS0_221_M", "This won't even be a challenge...", "此不足为角……");
            // 完全没有奖励吗？
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS0_REPEAT_#1_831_M", "No boons at all?", "竟无惠乎？");
            // 真惨啊。你是怎么撑到这儿的？
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS0_REPEAT_#1_095_M", "Pathetic. How did you get this far?", "鄙哉。汝何能以至此？");
            // 什么也不剩了……
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS0_REPEAT_#2_105_M", "Nothing to show...", "竟无可陈……");
            // 接下来对你来说会是场硬仗。
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS0_REPEAT_#2_805_M", "This will not be easy for you.", "此于汝不易也。");
            // 你至少考虑一下别的选项吧？
            AddTranslation("GAMEPLAY_HINTS_HINT_FLIPBOTHCARDCHOICES_408_M", "You won't at least consider your other option?", "汝亦不虑他择乎？");
            // 这不是你的唯一选择……
            AddTranslation("GAMEPLAY_HINTS_HINT_FLIPBOTHCARDCHOICES_REPEAT_#1_156_M", "That isn't your only choice...", "此非乃独之择……");
            // 你成功获得了一个[c:bR]奖励[c:]。
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS1_111_M", "You managed to get a [c:bR]boon[c:].", "汝获一[c:bR]惠[c:]矣。");
            // 这好歹也算一场公平的竞争……
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS1_289_M", "This may be a fair competition...", "此角庶几均矣……");
            // 就[c:bR]1个[c:]奖励？
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS1_REPEAT_#1_596_M", "Just [c:bR]1[c:] boon?", "止[c:bR]一[c:]惠乎？");
            // 你成功获得了我的两个[c:bR]奖励[c:]……
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS2_595_M", "You managed to get both of my [c:bR]boons[c:]...", "汝尽得朕二[c:bR]惠[c:]……");
            // 我很少这么说，但我确实佩服得五体投地。
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS2_090_M", "I rarely say this but, I am impressed.", "余鲜言此，然今服矣。");
            // 你这对手当得实至名归。
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS2_605_M", "You have been a worthy adversary.", "汝诚足敌也。");
            // 但很不幸的是，我很快就得置你于死地。
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS2_293_M", "But unfortunately I must soon put you to death.", "然不幸，余寻当杀尔。");
            // [c:bR]2个[c:]奖励……
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS2_REPEAT_#1_056_M", "[c:bR]2[c:] boons...", "[c:bR]二[c:]惠……");
            // 佩服。
            AddTranslation("PART_1_FINALE_FINALETRIALBOONS2_REPEAT_#1_562_M", "Impressive.", "可观。");
            // 再来一回。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREPEATING_927_M", "We will repeat that once more.", "复其一试。");
            // 再来……
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREPEATING_REPEAT_#1_640_M", "Once again...", "复矣……");
            // 下次再战。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREPEATING_REPEAT_#2_590_M", "We will do it another time.", "更试一次。");
            // 再来一次……
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREPEATING_REPEAT_#3_819_M", "Once more...", "再矣……");
            // 我会给你十分强大的[c:bR]奖励[c:]……
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREWARDS_318_M", "I will grant you one of my most powerful [c:bR]boons[c:]...", "余将授尔朕至[c:bR]惠[c:]者一。");
            // 是能戏剧般地扭转局面的卡牌，甚至都不用抽。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREWARDS_938_M", "Cards that dramatically alter the game. And you don't even need to draw them.", "此牌大移局势，且不待引而自用。");
            // 可供选择的[c:bR]奖励[c:]……
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREWARDS_REPEAT_#1_141_M", "Your choice of [c:bR]boons[c:]...", "诸[c:bR]惠[c:]在此……");
            // 可选择一张。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREWARDS_REPEAT_#2_213_M", "You may choose one.", "汝可择一。");
            // 我最强大的[c:bR]奖励[c:]……
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALREWARDS_REPEAT_#3_359_M", "My most powerful [c:bR]boons[c:]...", "朕之至[c:bR]惠[c:]……");
            // 唔……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_658_M", "Hmm...", "唔……");
            // 这可不行。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_REPEAT_#1_549_M", "No way.", "不可。");
            // 挑个别的吧。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_REPEAT_#2_460_M", "Pick something else.", "更择他物。");
            // 停。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_REPEAT_#3_485_M", "Stop this.", "止之。");
            // 不。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_REPEAT_#4_119_M", "Nope.", "莫。");
            // 拜托，别啊。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_REPEAT_#5_871_M", "Please. No.", "呜呼，毋也。");
            // 别别别。
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATSELECTIONCHOICENEGATIVE_REPEAT_#6_048_M", "Nope. Nope. Nope.", "莫莫莫。");
            // 嗷……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICENEGATIVE_388_M", "Oh...", "哦……");
            // 做你该做的事吧。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICENEGATIVE_REPEAT_#1_628_M", "Do what you must.", "行汝之所当行。");
            // 呃……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICENEGATIVE_REPEAT_#2_858_M", "Um...", "呃……");
            // 认真选择吧。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICENEGATIVE_REPEAT_#3_821_M", "Choose wisely.", "慎择之。");
            // 做你必须做的事！
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGSELECTIONCHOICENEGATIVE_REPEAT_#4_055_M", "Do what you must!", "行汝之所必行！");
            // 太糟了……[w:0.2]
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATCARDREMOVE_016_M", "Bad...[w:0.2]", "昏……[w:0.2]");
            // 不好……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATCARDREMOVE_945_M", "Play...", "著……");
            // 行……
            AddTranslation("TALKING_STOAT_DIALOGUE_STOATCARDREMOVE_REPEAT_#1_542_M", "Fine...", "可……");
            // 我可以接受。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCARDREMOVE_587_M", "I accept.", "奴受之。");
            // 睡吧……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCARDREMOVE_REPEAT_#1_287_M", "Sleep...", "眠矣……");
            // 总算……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCARDREMOVE_REPEAT_#1_548_M", "At last...", "终有……");
            // 永别了。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCARDREMOVE_REPEAT_#2_552_M", "Farewell.", "辞矣。");
            // 你可真够磨蹭的。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_478_M", "You took your time out there.", "汝在外良久。");
            // 我很想再来一局呢。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_983_M", "And I'm itching for another game.", "余又思一局矣。");
            // 准备好了吗？
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_953_M", "Are you ready to play?", "可复战乎？");
            // 你回来了。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#1_401_M", "You're back.", "汝复来矣。");
            // 坐下吧。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#1_795_M", "Sit.", "坐。");
            // 准备好了吗？
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#2_509_M", "Are you ready?", "可乎？");
            // 你走来走去浪费的时间够多了。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#3_521_M", "You spent enough time walking.", "汝游行已久矣。");
            // 快坐下吧。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#3_513_M", "Now sit.", "今坐。");
            // 我已经准备好了。
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#4_480_M", "I'm ready to play.", "余已欲战。");
            // 你呢？
            AddTranslation("PART_1_FINALE_FINALELESHYCABIN_REPEAT_#4_101_M", "Are you?", "汝然乎？");
            // 微笑就算了。
            AddTranslation("PART_1_SANCTUM_SANCTUMTAKEPHOTO_824_M", "You do not need to smile.", "毋笑。");
            // 来，说茄子。
            AddTranslation("PART_1_SANCTUM_SANCTUMTAKEPHOTO_REPEAT_#1_459_M", "Say cheese.", "但言起司。");
            // 再见。
            AddTranslation("PART_1_SANCTUM_SANCTUMTAKEPHOTO_REPEAT_#3_045_M", "Good bye.", "再会。");
            // 这就够了。
            AddTranslation("PART_1_SANCTUM_SANCTUMTAKEPHOTO_REPEAT_#4_803_M", "That will be all.", "足矣。");
            // 你本人的[c:bR]死亡卡[c:]。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_490_M", "Your very own [c:bR]Deathcard[c:].", "此，乃[c:bR]死牌[c:]也。");
            // 现在上面什么都没有，对吧？
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_670_M", "It's quite plain at the moment, isn't it?", "今其甚素，然乎？");
            // 咱们一起改良一下吧。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_029_M", "We will work together to amend that.", "余与汝将共饰之。");
            // 我希望这能成为你的完美纪念。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_649_M", "I want this to be the perfect memento of you.", "余欲以为乃忆。");
            // 看呐……你的[c:bR]死亡卡[c:]。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_REPEAT_#1_281_M", "Behold... your [c:bR]Deathcard[c:].", "视之……乃[c:bR]死牌[c:]。");
            // 咱们可以开始填内容了吗？
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_REPEAT_#1_090_M", "Shall we begin to ink it?", "现当始墨之乎？");
            // 你的[c:bR]死亡卡[c:]……
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_REPEAT_#2_113_M", "Your [c:bR]Deathcard[c:]...", "乃[c:bR]死牌[c:]……");
            // 开始吧。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_REPEAT_#2_764_M", "Let us begin.", "其始。");
            // 你的[c:bR]死亡卡[c:]……真漂亮。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_REPEAT_#3_941_M", "Your [c:bR]Deathcard[c:]... Beautiful.", "乃[c:bR]死牌[c:]……美哉。");
            // 但还需要再加些细节。
            AddTranslation("SPECIAL_NODES_DEATHCARDINTRO_REPEAT_#3_304_M", "Though, it could use some detail.", "然犹可益厥文。");
            // 这几张牌出自你平平无奇的牌组……
            AddTranslation("TUTORIAL_TUTORIALDEATHCARDCHOOSE_727_M", "Here are some cards from your mediocre deck...", "此乃庸牌列中数牌也……");
            // 可以拿来派上用场。
            AddTranslation("TUTORIAL_TUTORIALDEATHCARDCHOOSE_400_M", "We can put them to good use.", "可善用之。");
            // 现在只剩下最后一个问题了……
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_690_M", "There is now but one final matter...", "今唯一事未毕……");
            // [c:bR]卡面[c:]。
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_154_M", "The [c:bR]portrait[c:].", "[c:bR]像[c:]也。");
            // 现在只剩下一件事了……
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#1_077_M", "One thing now remains...", "今唯一事存焉……");
            // 必须留下你的面容。
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#1_257_M", "I must capture your visage.", "余当摹乃容。");
            // 做好准备。
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#2_281_M", "Prepare yourself.", "请备。");
            // 死亡静候光临。
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#2_891_M", "Death awaits.", "以望乃死期。");
            // 好牌都是有卡面的……
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#3_160_M", "Any good card has a portrait...", "凡善牌皆有厥像……");
            // 还有最后一件事需要完成。
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#4_020_M", "There is but one last thing to do.", "唯一事尚须为之。");
            // 待着别动。
            AddTranslation("SPECIAL_NODES_DEATHCARDPORTRAIT_REPEAT_#4_438_M", "Stay still.", "毋动。");
            // 你还没死呢。此处也并非炼狱。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_617_M", "You aren't dead yet. This isn't purgatory.", "汝犹未死，此亦非炼狱。");
            // 虽然你可能是那样想的……
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_533_M", "Though you may think of it that way...", "然汝或以为然……");
            // 在你故去之前，我必须请你帮个忙。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_487_M", "Before you expire, I must ask you a favor.", "汝未绝之前，余有一请。");
            // 我想留个纪念。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_400_M", "I would like a memento.", "余欲留一念。");
            // 待在这儿。不要动。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_REPEAT_#1_708_M", "Stay there. No need to move.", "居是，无庸动。");
            // 很遗憾，你还没死呢。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_REPEAT_#1_763_M", "I am afraid you are not dead yet.", "恐汝犹未死也。");
            // 待着别动。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_REPEAT_#1_400_M", "Hold still.", "定之。");
            // 拜托，尽量多活一会儿吧。
            AddTranslation("PART_1_SANCTUM_SANCTUMINTRO_REPEAT_#2_574_M", "Please, try to remain alive for just a short while longer.", "请姑存片时。");
            // 嗷……[w:0.3][shake]你好哇。[w:0.5]
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_440_M", "Oh...[w:0.3][shake] hello.[w:0.5]", "哦……[w:0.3][shake]安。[w:0.5]");
            // [e:Quiet]我不确定自己
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_138_M", "[e:Quiet]I wasn't sure if I", "[e:Quiet]奴未知奴之");
            // [e:Quiet]能不能逃出
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_758_M", "[e:Quiet]would ever escape", "[e:Quiet]终否得脱");
            // [e:Quiet]那个铁窖……[w:0.4]
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_179_M", "[e:Quiet]that iron crypt...[w:0.4]", "[e:Quiet]于彼铁椁乎……[w:0.4]");
            // 想问P……[shake][w:0.1]
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_977_M", "Is P-[shake][w:0.1]", "鉟—[shake][w:0.1]");
            // [anim:sly]白鼬……在附近吗？[w:0.4]
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_230_M", "[anim:sly]Is The Stoat... around?[w:0.4]", "[anim:sly]白鼬……在乎？[w:0.4]");
            // 弱狼呢？[w:0.4]
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_934_M", "The Stunted Wolf?[w:0.4]", "残狼乎？[w:0.4]");
            // [anim:]必须结束这种疯狂的行为。[w:0.4]
            AddTranslation("TALKING_CARDS_STINKBUGDISCOVERED_278_M", "[anim:]This madness must end.[w:0.4]", "[anim:]此狂当止。[w:0.4]");
            // [t:5]你以为你很聪明吗？[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_389_M", "[t:5]Are you smart or something?[w:0.2]", "[t:5]卿亦慧乎？[w:0.2]");
            // 他通常甚至
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_189_M", "He usually doesn't even", "他素不甚");
            // 懒得讲解骨头相关的知识。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_573_M", "bother teaching about bones.[w:0.2]", "言骨之事。[w:0.2]");
            // [anim:sly]给你个小提示。
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_107_M", "[anim:sly]Alright here's a tip.", "[anim:sly]然则，受我一诀。");
            // 我看到之前的……
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_442_M", "I saw a past...", "咱见前一……");
            // 受害者……
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_192_M", "victim...", "罹者……");
            // [anim:sly][t:15]在规则书上
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_635_M", "[anim:][t:15]writing a passcode", "[anim:][t:15]书密数");
            // [anim:][t:15]写下了密码。
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_032_M", "[anim:sly][t:15]in the rulebook.", "[anim:sly][t:15]于律书中。");
            // 查过了吗？
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#1_154_M", "Ever look in", "尝观");
            // 就在[t:15]规则书里。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#1_518_M", "[t:15]the rulebook?[w:0.2]", "[t:15]律书乎？[w:0.2]");
            // [anim:sly]里面肯定有
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#1_049_M", "[anim:sly]There's definitely", "[anim:sly]其中必有");
            // [t:15]草草写下的密码。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#1_006_M", "[t:15]passcode scrawled in there.[w:0.2]", "[t:15]所草之密数。[w:0.2]");
            // [anim:sly]他们当时找
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#1_418_M", "[anim:sly]They were looking up", "[anim:sly]彼时所寻");
            // [anim:][t:15]牛蛙印记[w:0.2]来着。
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#1_251_M", "[anim:][t:15]the Bullfrog's sigil.[w:0.2]", "[anim:][t:15]乃牛蛙之印。[w:0.2]");
            // 你去瞧过
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_522_M", "You ever peeked", "卿尝窥");
            // 规则书了吗？[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_037_M", "in that rulebook?[w:0.2]", "彼律书乎？[w:0.2]");
            // 你知道的……[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_260_M", "You know the one...[w:0.2]", "卿知彼书也……[w:0.2]");
            // 可以拿出来看看，
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_782_M", "You look at it", "卿视之");
            // [t:15]要是你忘了
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_667_M", "[t:15]if you forget", "[t:15]若卿忘之");
            // [t:15]哪个印记。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_716_M", "[t:15]a sigil.[w:0.2]", "[t:15]一印为何。[w:0.2]");
            // [anim:sly]你知道吧，
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_334_M", "[anim:sly]You know,", "[anim:sly]夫，");
            // [anim:][t:15]卡牌上的印记。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#2_291_M", "[anim:][t:15]the sigils on the cards.[w:0.2]", "[anim:][t:15]牌上之印也。[w:0.2]");
            // 偷偷看一眼规则书。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#3_141_M", "Peep that rulebook.[w:0.2]", "窥彼律书。[w:0.2]");
            // 牛蛙……什么的……
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#3_567_M", "Bullfrog... etc...", "牛蛙……之属……");
            // 我打包票
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#4_949_M", "Pretty sure there's", "咱信其中");
            // 规则书里
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#4_174_M", "a passcode", "有一密数");
            // 有保险箱的
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#4_679_M", "to that safe", "足启彼匮");
            // 密码。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#4_506_M", "in the rulebook.[w:0.2]", "藏于律书。[w:0.2]");
            // 我们得
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#5_155_M", "We need to", "咱等须");
            // 把事情办好。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#5_726_M", "get things moving.[w:0.2]", "速使事行。[w:0.2]");
            // 规则书中讲解了
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#5_045_M", "The rulebook describes", "律书具言");
            // 所有不同的印记。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#5_069_M", "all the different sigils.[w:0.2]", "诸异印契。[w:0.2]");
            // 这里面
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#5_874_M", "There's gotta be a", "其中必有");
            // 肯定有密码！[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#5_425_M", "passcode in it![w:0.2]", "密数！[w:0.2]");
            // 你可能
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#6_645_M", "You're probably", "卿殆");
            // 已经听腻了……[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#6_463_M", "sick of hearing it...[w:0.2]", "闻之已厌……[w:0.2]");
            // 但是，赶紧的啊！
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#6_472_M", "But come on!", "然速为之！");
            // 看看规则书啊。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#6_382_M", "Open up the book.[w:0.2]", "启其书。[w:0.2]");
            // 把那密码用在
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#6_815_M", "Use the passcode", "以其密数");
            // 保险箱上。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSAFEHINT_REPEAT_#6_522_M", "on the safe.[w:0.2]", "施诸匮上。[w:0.2]");
            // 咱俩又见面了。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDRAWN_683_M", "We meet again.", "又相见矣。");
            // 继续吧。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDRAWN_REPEAT_#2_388_M", "Carry on.", "请行进。");
            // 唉，咱俩又见面了。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDRAWN_REPEAT_#3_266_M", "Alas, we meet again.", "嗟，又相见矣。");
            // 又见面了。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDRAWN_REPEAT_#4_443_M", "Hello again.", "又见矣。");
            // 又来了。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFPLAYED_587_M", "Here we are.", "至矣。");
            // 你确定？
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFPLAYED_REPEAT_#1_912_M", "Are you sure?", "审乎？");
            // 好好用我吧。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFPLAYED_REPEAT_#2_023_M", "Use me wisely.", "慎用我。");
            // 唉！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFPLAYED_REPEAT_#3_750_M", "Alas!", "吁！");
            // 我必须信任你。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFPLAYED_REPEAT_#4_234_M", "I must trust you.", "吾唯信尔。");
            // 唔。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFATTACKED_361_M", "Oof.", "唔。");
            // 小心。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFATTACKED_REPEAT_#1_943_M", "Careful now.", "慎之。");
            // 我的天啊！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFATTACKED_REPEAT_#2_966_M", "Good lord!", "天乎！");
            // 哎！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFATTACKED_REPEAT_#3_716_M", "Oof!", "唔！");
            // 小心！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFATTACKED_REPEAT_#4_977_M", "Be careful!", "慎之！");
            // [t:5]你个叛徒！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSACRIFICE_922_M", "[t:5]Betrayal!", "[t:5]叛我！");
            // 永别了！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSACRIFICE_REPEAT_#1_787_M", "Farewell!", "辞矣！");
            // [t:5]唉……
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSACRIFICE_REPEAT_#2_944_M", "[t:5]Alas...", "[t:5]吁……");
            // 你又来了……[w:0.5]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_246", "You again...[w:0.5]", "复你乎……[w:0.5]");
            // [shake:0.5]确实如此！[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_644", "[shake:0.5]Indeed![w:0.2]", "[shake:0.5]然也！[w:0.2]");
            // 我们的朋友救了我。[w:0.5]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_536", "Our friend freed me.[w:0.5]", "奴汝之友释我。[w:0.5]");
            // [shake:0.5]哼，[w:0.2]基本上是
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_528", "[shake:0.5]Well,[w:0.2] I basically told", "[shake:0.5]噫，[w:0.2]实为咱告");
            // 我手把手教出来的。[w:0.5]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_528", "them how to do it.[w:0.5]", "之以其术。[w:0.5]");
            // 你有计划了吗？[w:0.5]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_119", "You got a plan?[w:0.5]", "汝有谋乎？[w:0.5]");
            // 咱们可是……[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_055", "We have...[w:0.2]", "奴汝亦有……[w:0.2]");
            // 还有个朋友……[w:0.2]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_294", "another friend here...[w:0.2]", "一友于……[w:0.2]");
            // [anim:shock]你是在开……
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_078", "[anim:shock]You've got to be-", "[anim:shock]卿岂可—");
            // 我是不会把那个货
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_553", "I wouldn't call him", "咱不以他为");
            // 视做朋友的。[w:0.3]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_429", "a friend.[w:0.3]", "咱一友。[w:0.3]");
            // 但[w:0.3]我想[w:0.3]我们
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_628", "But[w:0.3] I suppose[w:0.3] we", "然奴察我等");
            // 这次是[w:0.1]拴在一条绳上了。[w:0.4]
            AddTranslation("TALKING_CARDS_STOATSTINKBUGREUNITE_535", "are[w:0.1] in deep this time.[w:0.4]", "今同陷深阱矣。[w:0.4]");
            // 这该死的月亮……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_032_M", "This damned moon...", "此月甚恶……");
            // 确实很惊人。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_397_M", "It's dramatic, yes.", "而厥势诚壮。");
            // 但它对我来说毫无[c:bR]价值[c:]。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_348_M", "But it provides no [c:bR]value[c:] to my board.", "然于我局，全然无[c:bR]益[c:]。");
            // 我在想……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_720_M", "I wonder...", "余思之……");
            // 这应该还能有用……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_REPEAT_#1_994_M", "This ought to work again...", "此术当可复用……");
            // 我自有妙计。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_REPEAT_#2_479_M", "I still have a trick up my sleeve.", "余犹有一术。");
            // 月轮渐亏。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON1_REPEAT_#3_005_M", "This moon is waning.", "月哉亏兮。");
            // 你看，[c:bR]这[c:]才叫有价值。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON2_733_M", "Now [c:bR]that[c:] is value.", "[c:bR]此则[c:]真有益也。");
            // 没错，还是很有用的。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON2_REPEAT_#1_957_M", "Oh yes. It still works just fine.", "然。厥用犹善。");
            // 你敢攻击[c:bR]月亮[c:]吗？
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON2_REPEAT_#2_968_M", "Will you dare attack [c:bR]the moon[c:]?", "汝敢攻[c:bR]月[c:]乎？");
            // 非常有价值……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOON2_REPEAT_#3_730_M", "So much value...", "厥益甚矣……");
            // 你顶住了[c:bR]稀有造物[c:]的猛攻。 
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_606_M", "You capably endured the onslaught of [c:bR]rare creatures[c:]. ", "汝能当[c:bR]罕物[c:]之冲。");
            // 但真正的挑战即将到来。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_174_M", "But the true challenge was forthcoming.", "然真难方来。");
            // 朦胧的身影出现在你面前。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_651_M", "Shadowy figures appeared before you.", "暗形现于乃前。");
            // 他们眼中闪烁着对同道中人的认可……但同时也沾染着愧疚的颜色。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_825_M", "In their eyes glimmered a recognition of kinship... but colored by guilt.", "厥目微有同类之识……然杂以愧色。");
            // 他们背叛了你。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_074_M", "They were betraying you.", "彼乃叛尔。");
            // 月光笼罩下的森林中，朦胧的身影浮现出来。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_REPEAT_#1_450_M", "The moon soaked forest bed gave rise to shadowy figures.", "月浸林地，暗形自厥中起。");
            // 在漫长不绝、受尽折磨的长眠之后，他们喘着粗气吞咽着夜晚的空气。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_REPEAT_#1_774_M", "Gasping for night air after their long and torturous slumber.", "久卧苦眠寤，咧口咽夜风。");
            // 勉强承受住[c:bR]稀有造物[c:]的冲击后，你打了个寒战。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_REPEAT_#2_686_M", "After barely enduring the onslaught of [c:bR]rare creatures[c:], you shuddered.", "汝甫免[c:bR]罕物[c:]之冲，身为之栗。");
            // 因为你知道，最坏的情况还在后头。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS1_REPEAT_#2_851_M", "For you knew, somehow, that the worst was yet to come.", "盖汝冥知，至惨者犹未至。");
            // 那张卡，我印象尤为深刻。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS2_753_M", "I remember that one fondly.", "彼牌余念之深。");
            // 没错没错。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS2_REPEAT_#1_418_M", "Ah yes.", "然。");
            // 我记得那个。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS2_REPEAT_#1_305_M", "I remember that one.", "彼牌余记之。");
            // 绝妙的[c:bR]死亡卡[c:]。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS2_REPEAT_#2_214_M", "Magnificent [c:bR]Deathcards[c:].", "美哉[c:bR]死牌[c:]。");
            // 也许你很快就会成为它们的一员……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSDEATHCARDS2_REPEAT_#2_084_M", "Perhaps you will join them soon...", "汝亦寻将与之伍乎……");
            // 你竟然真的摧毁了月亮……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_300_M", "You really destroyed the moon...", "汝确竟毁月矣……");
            // 似乎接下来只要把我解决掉就行了。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_965_M", "I suppose all that's left is to finish me off.", "所馀者，但唯我耳。");
            // 继续加油吧。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_557_M", "Go on.", "行之。");
            // 你不是第一个战胜月亮的人。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#1_230_M", "You're not the first to triumph over the moon.", "汝非首胜月者也。");
            // 但还是继续吧。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#1_726_M", "But go on.", "然姑进。");
            // 做个了断。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#1_883_M", "Finish it.", "毕之。");
            // 你有概念吗？
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#2_104_M", "Do you have any idea?", "汝知乎？");
            // 摧毁一个星体的后果是什么？
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#2_308_M", "The consequences of destroying an astral body?", "毁一星之咎乎？");
            // 不，你当然没想过。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#2_436_M", "No. Of course not.", "不，汝固不知也。");
            // 做个了断吧。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSMOONDESTROYED_REPEAT_#2_609_M", "Finish this.", "毕此。");
            // 你的坚持越来越让人厌烦了。
            AddTranslation("_FOUNDEXTRACANDLE_215_M", "Your persistence is growing quite tiresome.", "汝之执，滋可厌矣。");
            // 你真的希望你的技艺被掩盖吗？因这种……作弊行为而蒙羞？
            AddTranslation("_FOUNDEXTRACANDLE_155_M", "Do you truly wish for your skill to be masked by this... cheat?", "汝诚欲以此……诈，掩乃技乎？");
            // 我怎么知道你是否真的够格？
            AddTranslation("_FOUNDEXTRACANDLE_543_M", "How will I know if you are truly worthy?", "余安知汝之诚堪也？");
            // 这啥玩意儿？
            AddTranslation("_FOUNDBEEFIGURINE_947_M", "What is this?", "此何物也？");
            // 你不喜欢[c:bR]松鼠[c:]吗？
            AddTranslation("_FOUNDBEEFIGURINE_287_M", "You don't like [c:bR]Squirrels[c:]?", "汝不乐[c:bR]松鼠[c:]乎？");
            // 唔。你把[c:bR]它[c:]从油画里拽出来了。
            AddTranslation("_FOUNDCLOVERPOT_237_M", "Hm. You've plucked [c:bR]that[c:] from the oil painting.", "唔。汝自丹青中攫[c:bR]彼[c:]矣。");
            // 你肯定是不喜欢我发给你的牌。
            AddTranslation("_FOUNDCLOVERPOT_028_M", "You must not like the cards that I deal you.", "汝必不乐朕授尔之牌。");
            // 拿起胶卷。[w:0.2]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDISCOVERED_502_M", "Take the film roll.[w:0.2]", "取影卷。[w:0.2]");
            // 别让他瞧见了！[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDISCOVERED_384_M", "Before he sees it![w:0.3]", "毋令伊见之！[w:0.3]");
            // [anim:shock][size:4]快！
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDISCOVERED_187_M", "[anim:shock][size:4]Now!", "[anim:shock][size:4]速！");
            // 你……你就这么走了？！
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSPILE_711_M", "Y-yer leaving already?!", "君—君遽去乎？！");
            // 拜托，看看俺的毛皮吧！
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSPILE_967_M", "Please. Consider me pelts!", "请观鄙裘革！");
            // 拿一张毛皮吧。免费的！
            AddTranslation("SPECIAL_NODES_TRAPPERFREEPELT_075_M", "Take a pelt. Free o' charge!", "取一裘革。无直也！");
            // 你瞅瞅这质量！
            AddTranslation("SPECIAL_NODES_TRAPPERFREEPELT_856_M", "See the quality?", "视其善乎？");
            // 第一张免费。
            AddTranslation("SPECIAL_NODES_TRAPPERFREEPELT_REPEAT_#1_785_M", "The first 'n's free.", "首者无直。");
            // 拿张免费的吧。
            AddTranslation("SPECIAL_NODES_TRAPPERFREEPELT_REPEAT_#2_525_M", "Have a free one.", "取一无直者。");
            // 免费的。
            AddTranslation("SPECIAL_NODES_TRAPPERFREEPELT_REPEAT_#3_499_M", "On the house.", "不取直也。");
            // 拿一张吧。
            AddTranslation("SPECIAL_NODES_TRAPPERFREEPELT_REPEAT_#4_133_M", "Take one.", "取一。");
            // 你知道……想站起来没人拦你。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_708_M", "You know... You're free to get up again.", "汝知之……汝可复起。");
            // 舒舒筋活活血……
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_772_M", "To keep your blood flowing...", "以行乃血……");
            // 只要你想，现在就可以站起来。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#1_161_M", "If you desire it, you may stand now.", "汝欲之，今可起。");
            // 这还能给我时间制定计划……
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#1_093_M", "It will allow me time to plan...", "则余得以谋……");
            // 你的腿抽筋了没？背痛不痛？
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#2_735_M", "Do your legs cramp? Does your back ache?", "乃胫挛乎？乃背痛乎？");
            // 这场比赛可能会很漫长。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#2_001_M", "This game can be lengthy.", "此局或绵久。");
            // 站一会吧。如果你想的话。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#2_616_M", "Stand. If you wish.", "欲则起。");
            // 站起来吧。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#3_559_M", "Stand.", "起。");
            // 这让我有时间做计划。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER_REPEAT_#3_948_M", "It will allow me time to plan.", "则余得以谋。");
            // 我不是什么暴君。只要地图没卷起来，你随时可以站起来。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER2_536_M", "I am no tyrant. You may stand whenever the map is unrolled.", "余非暴主。图舒，则汝可起。");
            // 这样我就有时间计划下一次遭遇战了。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER2_311_M", "It allows me time to plan your next encounter.", "则余得以谋汝之次逢。");
            // 但是请不要瞎碰我的东西。
            AddTranslation("TUTORIAL_TUTORIALGETTINGUPREMINDER2_518_M", "But do keep your hands off my possessions.", "然毋手我物。");
            // 鲜血。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETOTEM_098_M", "Fresh blood.", "新血。");
            // 或许你可以走得比图腾的立足点更远。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETOTEM_963_M", "Perhaps yours will make it farther than the foot of a totem.", "或汝能逾神偶之下。");
            // 祝你好运。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETOTEM_517_M", "Knock on wood.", "其无咎哉。");
            // 你的前世败给一根普普通通的图腾……
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETOTEM_REPEAT_#1_672_M", "Your predecessor fell to a mere totem...", "乃前人仆于一神偶耳……");
            // 你能表现得更好吗？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETOTEM_REPEAT_#1_720_M", "Are you prepared to do better?", "汝备乎，能过之乎？");
            // 又一位挑战者。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_209_M", "Another challenger.", "一角者又至。");
            // 我有没有说过，你的前一任发生了什么？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_869_M", "Did I tell you the tale of the one who came before you?", "余尝告尔以乃前人之事乎？");
            // 败在了疯狂的[c:bR]矿工[c:]的脚下。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_963_M", "They fell to a mad [c:bR]Prospector[c:].", "彼仆于癫狂[c:bR]采夫[c:]。");
            // 没有什么能挡在那家伙和金子之间。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_948_M", "Nothing comes between that man and his gold.", "无物能间彼人与厥金。");
            // 又来给[c:bR]矿工[c:]的鹤嘴锄送人头了？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_REPEAT_#1_002_M", "Another for the [c:bR]Prospector[c:]'s pickaxe?", "又一人殁于[c:bR]采夫[c:]之镐乎？");
            // 还是你这次能表现得更好？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_REPEAT_#1_712_M", "Or will you do better?", "抑汝能过之乎？");
            // 你继续顽强地前进……如同[c:bR]矿工[c:]探寻黄金。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEPROSPECTOR_REPEAT_#2_989_M", "You continue doggedly onward... like a [c:bR]Prospector[c:] to gold.", "汝犹勉前……若[c:bR]采夫[c:]求金。");
            // 准备好迎接即将发生的事了吗？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_405_M", "Are you prepared for what lies ahead?", "汝备乎后事焉？");
            // 像你的前世一样被钉在[c:bR]钓鱼人[c:]的钩子上吗？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_329_M", "To be impaled on the [c:bR]Angler[c:]'s hook, like the one who came before?", "若乃前人，为[c:bR]渔父[c:]之钩所贯乎？");
            // 我还在怀念你之前那个人……
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_REPEAT_#1_437_M", "I'm still thinking about the last one...", "余犹念彼前者……");
            // 居然一败涂地……被那个呆瓜[c:bR]钓鱼人[c:]打败了……
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_REPEAT_#1_737_M", "To be so soundly defeated... by the simpleton [c:bR]Angler[c:] no less...", "乃至大败……且败于昧愚[c:bR]渔父[c:]……");
            // 和[c:bR]钓鱼人[c:]的战斗，我是不是搞得太难了？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_REPEAT_#2_551_M", "Perhaps I've made the battle with the [c:bR]Angler[c:] too difficult?", "其与[c:bR]渔父[c:]役之困易，余设之过乎？");
            // 不，不会的。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_REPEAT_#2_616_M", "No, it can't be that.", "不，不然。");
            // 只是我的期望值实在是太高了。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEANGLER_REPEAT_#2_037_M", "My expectations are simply too high.", "唯余望之过耳。");
            // 上一个家伙实在是不会做生意。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_743_M", "Not much for trading, that last one.", "前者不善贾。");
            // 这回你准备好进行正确的交易了吗？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_187_M", "Are you prepared to make the right deals?", "汝备乎，贾得厥宜乎？");
            // 被捕获，然后被卖掉。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_REPEAT_#1_241_M", "Trapped, and then traded.", "先见获，后见贾。");
            // 你准备好迎接这种命运了吗？
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_REPEAT_#1_643_M", "Are you prepared for a fate such as that?", "汝备若是之命乎？");
            // 显然你的前一任并没看重毛皮的价值。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_REPEAT_#2_885_M", "Clearly your predecessor did not appreciate the value of a pelt.", "乃前人全不知裘革之贾。");
            // 你可不能辜负我的高期望啊。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_REPEAT_#3_902_M", "You have large boots to fill.", "汝继前人，其任重矣。");
            // 你的上一任成功地一路闯到了[c:bR]猎人[c:]那关。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_REPEAT_#3_257_M", "The one who came before you made it all the way to the [c:bR]Trapper[c:].", "乃前人竟达[c:bR]猎夫[c:]。");
            // 我才没有屏息以待。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSETRAPPERTRADER_REPEAT_#3_172_M", "I am not holding my breath.", "余诚非屏息而俟。");
            // 我对上一个人寄予了厚望……
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_623_M", "I had such high hopes for that last one...", "余甚望彼前人……");
            // 我为何要费尽心思教你？
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_144_M", "Why do I bother trying to teach you.", "余何苦教授尔。");
            // 你……边走边学吧。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_001_M", "You... you will learn as we go.", "汝……且行且学。");
            // 不然你就会死。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_334_M", "Or you will die.", "不然则亡。");
            // 又一位挑战者走来了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#1_985_M", "Another challenger approaches.", "复有角者至。");
            // 你有几斤几两马上就能得到证明。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#1_954_M", "You will prove your worth in short order.", "少待俄顷，汝才自见。");
            // 有时我真希望自己没有干掉格里魔拉……
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#2_161_M", "Sometimes I wish I hadn't done away with Grimora...", "时余有愿之格里魔拉之未除……");
            // 她至少是个值得尊敬的对手。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#2_119_M", "She, at least, was a worthy opponent.", "彼至少足为敌。");
            // 啊，欢迎。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#3_749_M", "Ah, welcome.", "噫，来矣。");
            // 这次我不会再向你解释规则了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#3_350_M", "I will not be explaining the rules this time.", "此回余不复为尔解厥则。");
            // 如果没有足够的眼力见，你就会被干掉。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#3_672_M", "If you do not intuit them, you will be slain.", "汝若不自喻厥则，必见杀。");
            // 这就是你的困境。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#3_027_M", "This is your dilemma.", "此汝之两歧也。");
            // 不要再发抖了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEFAULT_REPEAT_#4_008_M", "Stop shaking.", "毋慄。");
            // 你的初始牌组……
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_542_M", "Your starting deck...", "汝初牌之列……");
            // 这是你的牌组。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_REPEAT_#1_299_M", "Here is your deck.", "此汝牌列。");
            // 好好研究研究。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_REPEAT_#1_712_M", "Study it.", "审之。");
            // 看看你那可怜的牌组。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_REPEAT_#2_164_M", "Your pitiful deck.", "汝牌列陋矣。");
            // 我已经给你发过牌了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_REPEAT_#3_521_M", "I've dealt you your deck.", "余已授汝牌列。");
            // 现在，我们可以开始了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_REPEAT_#3_060_M", "Now we may begin.", "今可始矣。");
            // 你的牌组……
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTDECKDEFAULT_REPEAT_#4_496_M", "Your deck...", "汝牌列……");
            // 看来卑贱的[c:bR]臭虫[c:]已经进来了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTSTINKBUG_071_M", "It seems the lowly [c:bR]Stinkbug[c:] has made its way in.", "彼贱[c:bR]臭虫[c:]似已入矣。");
            // 但牌已经发了，就留它在那儿吧。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTSTINKBUG_957_M", "But it is dealt. So it stands.", "然既授之，姑存。");
            // 那只臭烘烘的[c:bR]弱狼[c:]？
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTWOLF_724_M", "That foul [c:bR]Stunted Wolf[c:]?", "彼秽恶之[c:bR]残狼[c:]乎？");
            // 你真的想让这种造物出现在你的牌组中吗？
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTWOLF_247_M", "You really want such a creature in your deck?", "汝真欲纳此物于乃牌列乎？");
            // 看到它我确实不太爽……
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTWOLF_377_M", "The sight of it does try my temper...", "见之，诚动朕怒……");
            // 但牌都已经发了。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTWOLF_910_M", "But it has been dealt.", "然既授矣。");
            // 就留它在那儿吧。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTWOLF_118_M", "So it stands.", "姑存之。");
            // 猎人用[c:bR]牙齿[c:]作为交易通货，从战斗中得来的。
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSCURRENCY_778_M", "The trapper dealt in [c:bR]teeth[c:]. The type collected from battle.", "猎夫以[c:bR]齿[c:]为货，战而得之者也。");
            // 在最后一手造成过量伤害即可获得牙齿。
            AddTranslation("TUTORIAL_TUTORIALBUYPELTSCURRENCY_222_M", "They are gained by dealing damage greater than what is needed to win a match.", "胜局既定，而所伤有溢，则得之。");
            // 你希望[c:bR]囚狼[c:]加入你的牌组吗？
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTCAGEDWOLF_357_M", "You want that [c:bR]Caged Wolf[c:] in your deck?", "汝欲纳彼[c:bR]槛中狼[c:]于乃牌列乎？");
            // 随你便吧。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTCAGEDWOLF_746_M", "Suit yourself.", "随汝。");
            // 你觉得[c:bR]囚狼[c:]对你有什么好处？
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTCAGEDWOLF_REPEAT_#1_203_M", "What good do you think that [c:bR]Caged Wolf[c:] will do you?", "汝谓彼[c:bR]槛中狼[c:]于尔何益乎？");
            // 这是张可怕的牌。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTCAGEDWOLF_REPEAT_#1_163_M", "It's a terrible card.", "此恶牌也。");
            // 你的兽群里还有一只[c:bR]囚狼[c:]……
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTCAGEDWOLF_REPEAT_#2_564_M", "Your menagerie included a... [c:bR]Wolf in a Cage[c:]...", "乃群兽之中，有……[c:bR]一狼囚于槛[c:]……");
            // 显然是这样。
            AddTranslation("PART_1_RUN_START_NEWRUNDEALTCAGEDWOLF_REPEAT_#2_928_M", "Apparently.", "此乃显然。");
            // 你缺少祭品。你没办法献祭[c:bR][v:0][c:]。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOODTERRAIN_504_M", "You are lacking sacrifices. Your [c:bR][v:0][c:] can't be sacrificed.", "汝乏牺牲。乃[c:bR][v:0][c:]不可祀。");
            // 你不能从[c:bR][v:0][c:]身上提取血量。需要其他卡牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOODTERRAIN_REPEAT_#1_363_M", "You can't draw blood from a [c:bR][v:0][c:]. You'll need something else.", "汝不可取血于[c:bR][v:0][c:]，须他物。");
            // 无法献祭[c:bR][v:0][c:]。缺少祭品。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOODTERRAIN_REPEAT_#2_319_M", "You can't sacrifice a [c:bR][v:0][c:]. So you're short.", "汝不可祀[c:bR][v:0][c:]，故乏牲。");
            // 你发现自己置身于一片浓密而刺鼻的蘑菇林中。
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGEINTRO_903_M", "You found yourself among a grove of thick and pungent mushrooms.", "汝入稠蕈之林，厥气甚秽。");
            // 你眯起眼，透过一片厚厚的孢子看见一个身影。
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGEINTRO_830_M", "You squinted to see a figure through a thick cloud of spores.", "汝眯目，透蕈霭而见一立者。");
            // 我们是[c:bR]菌学家[c:]啊，对吧？
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_700", "We are [c:bR]The Mycologists[c:], yes?", "我曹乃[c:bR]蕈家[c:]，然邪？");
            // [size:3]是啊。[size:]
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_145", "[size:3]Yes.[size:]", "[size:3]然。[size:]");
            // 我们在进行实验，在……在很远的地方……
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_590", "A-and we are performing our experiments far from- from-", "且—且我曹方为试，远于—于—");
            // [size:3]其他地方不欢迎我们。[size:]
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_717", "[size:3]We are not welcome elsewhere.[size:]", "[size:3]他处不纳我曹。[size:]");
            // 我们会拿你的牲口做实验，行吗？
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_414_M", "We will experiment on your flock, yes?", "我曹将试于乃群兽，然邪？");
            // 我们……我们需要[c:bR]2个相同的[c:]造物？
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_940_M", "We- we will need [c:bR]2 of the same[c:] creatures?", "我—我曹须[c:bR]同种耦数[c:]之物邪？");
            // [size:3]我俩一人一个。[size:]
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_073_M", "[size:3]One for each of us.[size:]", "[size:3]我曹各一。[size:]");
            // 你……你给我们带了……[c:bR]2个相同的[c:]造物？
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_REPEAT_#1_391_M", "D- did you bring us... [c:bR]2 of the same[c:]?", "汝—汝其携来……[c:bR]同种耦物[c:]邪？");
            // [size:3]我们想做实验。[size:]
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_REPEAT_#1_699_M", "[size:3]We would like to experiment.[size:]", "[size:3]我曹欲试之。[size:]");
            // 我们需要……完全一样的造物？
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_REPEAT_#2_654_M", "We need... duplicates?", "我曹须……同物邪？");
            // 有……有猎……
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_REPEAT_#3_301_M", "D- do you have v- v-", "汝—汝有畋—畋—");
            // [size:3]它们不是猎物。[size:]
            AddTranslation("SPECIAL_NODES_DOCTORINTRO_REPEAT_#3_467", "[size:3]They are not victims.[size:]", "[size:3]彼非畋牲。[size:]");
            // 哪种鱼？好难选啊。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMRANDOM_407_M", "Which fish? Hard choose.", "何鱼？难择。");
            // 唔，鱼都臭了。好难选啊。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMRANDOM_REPEAT_#1_346_M", "Hm. Stale fish. Hard choose.", "唔。臭鱼。难择。");
            // 全臭了。好难选啊。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMRANDOM_REPEAT_#2_800_M", "All stale. Hard choose.", "皆臭。难择。");
            // 这鱼比较新鲜。这个好选。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMNEW_837_M", "Fresher fish. Easy choose.", "鱼尚鲜。易择。");
            // 这鱼新鲜，好选。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMNEW_REPEAT_#1_083_M", "New fish. Easy choose.", "新鱼。易择。");
            // 选新鱼就对了，简单。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMNEW_REPEAT_#2_179_M", "Take new fish. Easy.", "取新鱼，易耳。");
            // 唔，新鲜。就它了。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKAIMNEW_REPEAT_#3_237_M", "Mm. Fresh. Choose.", "唔，鲜也。取之。");
            // 是我的了。开钓吧。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKPULL_057_M", "Mine now. Go fish.", "今归予矣。钓矣。");
            // 拿上鱼。开钓吧。
            AddTranslation("BOSS_DIALOGUE_TEACHFISHHOOKPULL_REPEAT_#1_314_M", "Take fish. Go fish.", "取鱼。钓矣。");
            // 因为你打败了我……[w:0.4]你的话，[w:0.3]倒是可以分享我的秘密。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_577_M", "An' because ye bested me...[w:0.4] with ye,[w:0.3] I'll share me secret.", "既汝胜某……[w:0.4]唯于汝，[w:0.3]某可告之以秘。");
            // 我是罗亚尔。[w:0.3]就躺在最右手边那个坟包里头。[w:0.3]这是我头顶上那玩意儿。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_772_M", "Me name's Royal.[w:0.3] I's the far right tomb.[w:0.3] Here's the head piece.", "某名罗亚尔。[w:0.3]极右之冢，即某所处。[w:0.3]此某首之片也。");
            // 我说，我是罗亚尔。[w:0.3]就躺在最右手边那个坟包里头。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_REPEAT_#1_700_M", "Like I said: Me name's Royal.[w:0.3] I's the far right tomb.", "如某所言：某名罗亚尔。[w:0.3]极右之冢，即某所处。");
            // 是啊，[w:0.3]生活不给我柠檬……[w:0.3]所以我死了。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_REPEAT_#1_170_M", "Yar,[w:0.3] life didn't give me lemons...[w:0.3] So I died.", "然生不予某柠……[w:0.3]故某死矣。");
            // 我也曾是这海上最优秀的海盗。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_REPEAT_#2_954_M", "I were once the finest pirate on th' seas.", "某昔为海上之盗，莫有善于我。");
            // 再看看我现在的样子……[w:0.3]给埋在最右手边那个坟包里头……
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_REPEAT_#2_327_M", "Lookit me now...[w:0.3] Buried under the far right tomb...", "今观某……[w:0.3]埋于极右之冢下……");
            // 有人说，生活给了你柠檬……[w:0.3]就要好好利用。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_REPEAT_#3_174_M", "They say when life gives ye lemons...[w:0.3] Ye make somethin' of it.", "人言，生若予汝柠……[w:0.3]当因之有为。");
            // 生活没有那么好心给我柠檬……[w:0.3]只让我被埋在右手边那个坟包里头。
            AddTranslation("GBC_NPC_GHOULROYALGAINPIECE_REPEAT_#3_481_M", "Life were not so kind to give me lemons...[w:0.3] It left me buried under the tomb on the right.", "生不仁，未尝予某柠……[w:0.3]徒使某埋于右冢之下。");
            // 呼[w:0.2][shake:1]啊啊啊啊！[w:0.4]是谁开了空调吗？
            AddTranslation("GBC_NPC_GHOULBRIARGREETING_361_M", "B[w:0.2][shake:1]rrrr![w:0.4] Did someone leave the AC on?", "呼[w:0.2][shake:1]呜呜呜呜！[w:0.4]其有启寒器者乎？");
            // 嗷，[w:0.1][t:0.5]拜[w:0.25]托，[w:0.15][t:0]老兄！[w:0.3]这儿也[w:0.2][t:1]太冷[w:0.2][t:0]了吧！
            AddTranslation("GBC_NPC_GHOULBRIARGREETING_341_M", "Oh, [w:0.1][t:0.5]come[w:0.25] on,[w:0.15][t:0] dude![w:0.3] It's[w:0.2][t:1] freezing[w:0.2][t:0] in here!", "吁，[w:0.1][t:0.5]呜[w:0.25]呼，[w:0.15][t:0]兄乎！[w:0.2][t:1]此间[w:0.2][t:0]大寒！");
            // 也许来场[w:0.2]激烈的战斗[w:0.2]会有帮助。 
            AddTranslation("GBC_NPC_GHOULBRIARGREETING_486_M", "Maybe a[w:0.2] heated battle[w:0.2] will help. ", "或一[w:0.2]炽战[w:0.2]可济。");
            // 呼[w:0.2][shake:1]啊啊啊啊！
            AddTranslation("GBC_NPC_GHOULBRIARGREETING_REPEAT_#1_473_M", "B[w:0.2][shake:1]rrrr!", "呼[w:0.2][shake:1]呜呜呜呜！");
            // 你确实打败了我。[w:0.3]必须得承认了。
            AddTranslation("GBC_NPC_GHOULBRIARGAINPIECE_322_M", "You did beat me.[w:0.3] So I guess I've gotta fess up.", "汝固胜愚矣。[w:0.3]我此言实。");
            // 我叫凯……[w:0.2][shake:1]凯茜，[w:0.4]凯茜·霍布斯。
            AddTranslation("GBC_NPC_GHOULBRIARGAINPIECE_616_M", "The name's K- [w:0.2][shake:1]Kaycee.[w:0.4] Kaycee Hobbes.", "愚名凯—[w:0.2][shake:1]凯茜。[w:0.4]凯茜·霍布斯。");
            // 我躺在左手边那个坟包里头。
            AddTranslation("GBC_NPC_GHOULBRIARGAINPIECE_921_M", "I'm from the tombstone on the left.", "愚处左冢。");
            // 凯……[w:0.2][shake:1]凯茜，[w:0.4]我叫凯茜·霍布斯。
            AddTranslation("GBC_NPC_GHOULBRIARGAINPIECE_REPEAT_#1_208_M", "K- [w:0.2][shake:1]Kaycee.[w:0.4] Kaycee Hobbes is the name.", "凯—[w:0.2][shake:1]凯茜。[w:0.4]愚名凯茜·霍布斯。");
            // 在左手边那个坟包里头。
            AddTranslation("GBC_NPC_GHOULBRIARGAINPIECE_REPEAT_#1_230_M", "Tombstone on the left.", "左冢。");
            // 是有穿堂风吗？[w:0.3]冻死人了！
            AddTranslation("GBC_NPC_GHOULBRIARGAINPIECE_REPEAT_#3_375_M", "Is there a draft in here?[w:0.3] It's freezing!", "此间有穿风乎？[w:0.3]寒甚！");
            // 你赢了，[w:0.3]但现在我没那么冷了。
            AddTranslation("GBC_NPC_GHOULBRIARVICTORY_690_M", "You won,[w:0.3] but now I'm a bit less cold.", "愚胜矣，[w:0.3]今愚差可克寒。");
            // 拿个卡包吧。[w:0.3]免费的。
            AddTranslation("GBC_NPC_GHOULBRIARVICTORY_978_M", "Take a pack.[w:0.3] On the house.", "取一韬。[w:0.3]无直。");
            // 呼[w:0.2][shake:1]啊啊啊啊！[w:0.4]不。[w:0.3]我还很冷。
            AddTranslation("GBC_NPC_GHOULBRIARDEFEAT_363_M", "B[w:0.2][shake:1]rrrr![w:0.4] Nope.[w:0.3] I'm still cold.", "呼[w:0.2][shake:1]呜呜呜呜！[w:0.4]莫能克。[w:0.3]愚犹寒。");
            // 呼[w:0.2][shake:1]啊啊啊啊！[w:0.4]拜托。[w:0.3]再努把力啊！
            AddTranslation("GBC_NPC_GHOULBRIARDEFEAT_REPEAT_#1_706_M", "B[w:0.2][shake:1]rrrr![w:0.4] Come on.[w:0.3] Try a bit harder!", "呼[w:0.2][shake:1]呜呜呜呜！[w:0.4]勉之。[w:0.3]更劲力！");
            // [t:2]不，[w:0.5]不，[w:0.5][t:0]别看我。
            AddTranslation("GBC_NPC_GHOULSAWYERGREETING_394_M", "[t:2]Oh no.[w:0.5] Oh no.[w:0.5][t:0] Do not look upon me.", "[t:2]毋。[w:0.5]毋。[w:0.5][t:0]毋视仆。");
            // 别乱叫、别乱闻。[w:0.3]求你了。
            AddTranslation("GBC_NPC_GHOULSAWYERGREETING_030_M", "Do not snarl or sniff.[w:0.3] I beg you.", "毋狺，毋嗅。[w:0.3]仆乞汝。");
            // 如果你想战斗的话，[w:0.3]拜托了，[w:0.3]咱们速战速决行不行！
            AddTranslation("GBC_NPC_GHOULSAWYERGREETING_180_M", "If you wish to battle,[w:0.3] please,[w:0.3] let us get it over with!", "汝若欲战，[w:0.3]呜呼，[w:0.3]速毕之！");
            // [t:2]噢不，[w:0.5]你咋回来了。
            AddTranslation("GBC_NPC_GHOULSAWYERGREETING_REPEAT_#1_659_M", "[t:2]Oh no.[w:0.5] You are back.", "[t:2]不。[w:0.5]汝复来矣。");
            // 拜托，[w:0.3]动作快点。
            AddTranslation("GBC_NPC_GHOULSAWYERGREETING_REPEAT_#1_158_M", "Please.[w:0.3] Let this be swift.", "呜呼。[w:0.3]愿其速。");
            // [t:2]不，[w:0.5]你又……[w:0.5]回来了。
            AddTranslation("GBC_NPC_GHOULSAWYERGREETING_REPEAT_#2_951_M", "[t:2]Oh no.[w:0.5] You are back...[w:0.5] again.", "[t:2]不。[w:0.5]汝又……[w:0.5]来矣。");
            // 我叫索耶。[w:0.3]中间这块石头是我的坟位。
            AddTranslation("GBC_NPC_GHOULSAWYERGAINPIECE_782_M", "I am called Sawyer.[w:0.3] The middle stone marks my grave.", "仆名索耶。[w:0.3]中石所志，乃我墓也。");
            // 拜托，[w:0.3]别去挖我的骨头！
            AddTranslation("GBC_NPC_GHOULSAWYERGAINPIECE_656_M", "Please,[w:0.3] do not go digging up my bones!", "呜呼，[w:0.3]毋发仆骨！");
            // 别瞎闻、别乱叫！
            AddTranslation("GBC_NPC_GHOULSAWYERGAINPIECE_REPEAT_#1_748_M", "Do not sniff or snarl!", "毋嗅，毋狺！");
            // 拜托，[w:0.3]别乱吠，别讨食！
            AddTranslation("GBC_NPC_GHOULSAWYERGAINPIECE_REPEAT_#2_521_M", "Please,[w:0.3] do not bark or beg!", "呜呼，[w:0.3]毋吠，毋乞食！");
            // 中间的石头是我的坟位。
            AddTranslation("GBC_NPC_GHOULSAWYERGAINPIECE_REPEAT_#2_628_M", "The middle stone marks my grave.", "中石所志，乃仆墓也。");
            // 结束了。[w:0.3]我被你生吞活剥了。
            AddTranslation("GBC_NPC_GHOULSAWYERVICTORY_750_M", "It is over.[w:0.3] You chewed me out.", "终焉。[w:0.3]汝尽生噬活剥仆矣。");
            // 好了，[w:0.3]拜托，[w:0.3]别盯着我看！
            AddTranslation("GBC_NPC_GHOULSAWYERVICTORY_015_M", "Now,[w:0.3] please,[w:0.3] look away!", "今，[w:0.3]呜呼，[w:0.3]莫仆顾！");
            // 看看这个卡包吧。
            AddTranslation("GBC_NPC_GHOULSAWYERVICTORY_331_M", "Turn your eyes to this card pack instead.", "其视此牌韬。");
            // 天哪。[w:0.3]意思是你还会再次尝试吗？
            AddTranslation("GBC_NPC_GHOULSAWYERDEFEAT_291_M", "Oh dear.[w:0.3] Does this mean you will try again?", "嗟乎。[w:0.3]是乃汝将再试乎？");
            // 痛苦啊！[w:0.3]请放过我吧。
            AddTranslation("GBC_NPC_GHOULSAWYERDEFEAT_REPEAT_#1_477_M", "Agony![w:0.3] Please leave me be.", "痛哉！[w:0.3]请赦我。");
            // 不……[w:0.3]别再来了……
            AddTranslation("GBC_NPC_GHOULSAWYERDEFEAT_REPEAT_#2_124_M", "No...[w:0.3] Not again...", "不……[w:0.3]毋复然……");
            // 移开你的视线！
            AddTranslation("GBC_NPC_GHOULSAWYERDEFEAT_REPEAT_#3_071_M", "Avert your eyes!", "避汝目！");
            // 你想交易吗？
            AddTranslation("GBC_NPC_GBCTRADERINTRO_881_M", "You wish to trade?", "君欲易乎？");
            // [t:3]你终于[w:0.2]到这儿了！[w:0.3][t:0]真了不起！[w:0.3]我真是[t:0.2][shake:0.5][t:3]太[w:0.2]兴奋了。
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_820_M", "!DELETED!", "[t:3]汝终[w:0.2]至此矣！[w:0.3][t:0]善哉！[w:0.3]奴实[t:0.2][shake:0.5][t:3]大[w:0.2]喜。");
            // [t:3]我是死亡冥刻者，[w:0.3][t:0]格里魔拉。
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_811_M", "!DELETED!", "[t:3]奴乃死之司锲，[w:0.3][t:0]格里魔拉。");
            // [t:3]如果你想在我面前测试你的技能，[w:0.5][t:0][e:Anger]就必须先证明你有多聪明…[w:0.2]…[w:0.2]
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_409_M", "[t:3]If you wish to test your skills against me,[w:0.5][t:0][e:Anger] you must first prove your wits.[w:0.2].[w:0.2].[w:0.2]", "[t:3]汝若欲以技试我，[w:0.5][t:0][e:Anger]必先验乃智…[w:0.2]…[w:0.2]");
            // [t:3]你必须分辨出哪个坟墓是[w:0.2]我[w:0.2][shake:0.5][t:20]可爱的[w:0.2][t:2]食尸鬼们最后的安息地。
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_081_M", "[t:3]You must discern which tomb marks the final resting places of[w:0.2] my[w:0.2][shake:0.5][t:20] lovely[w:0.2][t:2] Ghouls.", "[t:3]汝必辨何冢，[w:0.2]为朕[w:0.2][shake:0.5][t:20]可爱[w:0.2][t:2]冢鬼之归处。");
            // [t:3]真了不起！[w:0.4]我相信你已经充分证明了自己的智慧。
            AddTranslation("GBC_NPC_GRIMORAPUZZLESOLVED_429_M", "[t:3]Marvelous![w:0.4] I believe you have proven your wits adequately.", "[t:3]善哉！[w:0.4]奴谓乃智已验矣。");
            // 准备好了吗？
            AddTranslation("GBC_NPC_GRIMORAPUZZLESOLVED_676_M", "Are you prepared?", "汝备矣乎？");
            // [t:12][e:Anger]你是打不过我的。
            AddTranslation("GBC_NPC_GRIMORAPUZZLESOLVED_157_M", "[t:12][e:Anger]You will not defeat me.", "[t:12][e:Anger]汝不能胜我。");
            // 我预见了事态发展。
            AddTranslation("_OPPONENTSURRENDER_449_M", "I see the way this is going.", "余见厥势矣。");
            // 我认输了。
            AddTranslation("_OPPONENTSURRENDER_439_M", "I concede.", "余降矣。");
            // 接受我的投降吧……
            AddTranslation("_OPPONENTSURRENDER_031_M", "You may accept my surrender...", "汝可受朕降……");
            // ……或是你想慢慢打也可以。
            AddTranslation("_OPPONENTSURRENDER_877_M", "...or you may finish this match the slow way.", "……抑可徐竟此局。");
            // 你打败我了。我投降。
            AddTranslation("_OPPONENTSURRENDER_REPEAT_#1_853_M", "You have me here. I surrender.", "此局汝得我矣。余降。");
            // 是啊，这次你可逮到我了。
            AddTranslation("_OPPONENTSURRENDER_REPEAT_#3_923_M", "Yes. I think you've got me this time.", "然。今者汝得我矣。");
            // 出类拔萃。
            AddTranslation("_OPPONENTSURRENDER_REPEAT_#4_247_M", "Scoop.", "敛牌。");
            // 我投降。
            AddTranslation("_OPPONENTSURRENDER_REPEAT_#5_710_M", "I'll surrender.", "余降。");
            // 我……我觉得可能会变得一团乱。
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_953_M", "I- I think this could get messy.", "我—我恐其将乱。");
            // [size:3]看别处呗。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_087_M", "[size:3]Look away.[size:]", "[size:3]避目。[size:]");
            // 你……你可能想要……
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_REPEAT_#1_016_M", "Y- you may want to...", "汝—汝其可……");
            // [size:3]看向别处。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_REPEAT_#1_862_M", "[size:3]Avert your eyes.[size:]", "[size:3]避目。[size:]");
            // 你……你应该……
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_REPEAT_#2_602_M", "Y- you should...", "汝—汝宜……");
            // [size:3]你不会想看到这个的。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_REPEAT_#2_474_M", "[size:3]You don't want to see this.[size:]", "[size:3]汝必不欲视此。[size:]");
            // 这个程序……恐怖吗？
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGELOOKAWAY_REPEAT_#3_490_M", "This procedure... it is grisly?", "此术……可畏邪？");
            // 那[c:bR][v:0][c:]……现在成了一个？
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGERESULT_542_M", "Th- the [c:bR][v:0][c:]... it is now one?", "彼—彼[c:bR][v:0][c:]……今为一邪？");
            // 你现在只有一张[c:bR][v:0][c:]了……它变强了吗？
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGERESULT_REPEAT_#1_082_M", "Y- you now have but one [c:bR][v:0][c:]... It is stronger?", "今—今汝唯有一[c:bR][v:0][c:]矣……其强邪？");
            // 这……手术，完成了？
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGERESULT_REPEAT_#2_701_M", "Th- the operation. It is complete?", "此—此术毕邪？");
            // 我……我们做了什么？
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGERESULT_REPEAT_#3_106_M", "Wh- what have we done?", "我—我曹何为哉？");
            // 啊……啊，天哪……你……你没有……
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_015_M", "O- oh dear... Y- you don't...", "噫—噫吁……汝—汝无……");
            // [size:3]你没有重复卡牌啊。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_258_M", "[size:3]You have no duplicate cards.[size:]", "[size:3]汝无同种复牌。[size:]");
            // 要……要不拿一张我们的牌？
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_842_M", "T- take one of ours?", "其—其取我一物邪？");
            // [size:3]我们下次再用。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_770_M", "[size:3]We will use it next time.[size:]", "[size:3]我曹异日复用之。[size:]");
            // 嗷……唔，嗷。
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_REPEAT_#1_527_M", "O- oh. Hm. Oh.", "噫—噫。唔。噫。");
            // [size:3]你这全是单张卡牌，没有成对的。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_REPEAT_#1_456_M", "[size:3]Your cards are all distinct. No pairs.[size:]", "[size:3]汝牌皆殊，无耦。[size:]");
            // 没……没有成对的，能不能拿……
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_REPEAT_#2_168_M", "N- no pairs. C- can they take...", "无—无耦，可取……");
            // [size:3]你可以拿走我们的一个造物。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_REPEAT_#2_555_M", "[size:3]You will take one of our creatures.[size:]", "[size:3]汝将取我曹一物。[size:]");
            // 唔，嗷，唔。
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_REPEAT_#3_159_M", "Hm. Oh. Hm.", "唔。噫。唔。");
            // [size:3]你可以拿走我们的一个造物。[size:]
            AddTranslation("SPECIAL_NODES_DUPLICATEMERGENOPAIRS_REPEAT_#3_995_M", "[size:3]You will take a creature from us.[size:]", "[size:3]汝将自我曹取一物。[size:]");
            // [c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]这疼痛实在让人无法忍受！[w:0.3]我……[w:0.2]我的内脏都要融化了！
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_977_M", "[c:R][shake:1]Arrrrghh![w:0.4][t:0][c:] The pain is unbearable![w:0.3] M-[w:0.2] my organs are melting!", "[c:R][shake:1]噫噫噫噫！[w:0.4][t:0][c:]此痛弗堪！[w:0.3]吾—[w:0.2]吾五腑且融矣！");
            // 看到没？[w:0.3]蔓尼菲科在期末考试的时候把我变成了……[c:R][shake:1]啊啊！[w:0.4][t:0][c:]……黏液。
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_087_M", "Do you see?[w:0.3] Magnificus turned me into... [c:R][shake:1]Rrrggh![w:0.4][t:0][c:] ...Goo[w:0.3] for my final exam.", "子见之乎？[w:0.3]蔓尼菲科化吾为……[c:R][shake:1]噫噫！[w:0.4][t:0][c:]……黏胶[w:0.3]，以应吾终试。");
            // 我只需要再打败一名挑战者。[w:0.3]然后……[w:0.5]然后[w:0.2]我就能赢得我[shake:0.6]应有的[w:0.2][shake:0.6]地位了！
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_940_M", "I just need to defeat one more challenger.[w:0.3] Then...[w:0.5] then[w:0.2] I will earn my [shake:0.6]rightful[w:0.2][shake:0.6] place!", "吾但须更胜一人。[w:0.3] 然……[w:0.5]然[w:0.2]吾乃得[shake:0.6]所宜[w:0.2][shake:0.6]之位矣！");
            // 我在[w:0.2][shake:0.6]大师牌组中应有的地位！[w:0.3]我可是他的珍稀卡牌之一。
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_449_M", "My rightful place in the deck of[w:0.2][shake:0.6] The Master![w:0.3] As one of his prized cards.", "吾所宜之位于[w:0.2][shake:0.6]大师之牌列！[w:0.3]吾乃其珍视之牌也。");
            // [c:R][shake:1]啊！[w:0.4][t:0][c:]没有什么能阻挡我。
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_562_M", "[c:R][shake:1]Argh![w:0.4][t:0][c:] Nothing will stop me.", "[c:R][shake:1]吁！[w:0.4][t:0][c:]莫吾能止。");
            // 你……[w:0.2]你在干嘛？
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_REPEAT_#1_830_M", "Wh-[w:0.2] what are you doing?", "子—[w:0.2]子何为？");
            // 我通过了期末考试。[w:0.3]终于……[w:0.2][c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]终于结束了。
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_REPEAT_#1_791_M", "I passed my final exam.[w:0.3] We're-[w:0.2] [c:R][shake:1]Arrrrghh![w:0.4][t:0][c:] We're done.", "余终试既过。[w:0.3]吾等—[w:0.2] [c:R][shake:1]吁！[w:0.4][t:0][c:]吾等毕矣。");
            // 求你了。[w:0.3]不要再这样了！
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_REPEAT_#1_508_M", "Please.[w:0.3] Please not again!", "乞之。[w:0.3]毋复然！");
            // 求你了。[w:0.3]发发慈悲吧！
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_REPEAT_#2_285_M", "Please.[w:0.3] Have mercy!", "乞之。[w:0.3]恕吾！");
            // 不！[w:0.3]别再来了！
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_REPEAT_#3_401_M", "No![w:0.3] Not another!", "毋！[w:0.3]毋复一战！");
            // 求你了。[w:0.3][c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]发发慈悲吧！
            AddTranslation("GBC_NPC_WIZARDGREENGREETING_REPEAT_#4_525_M", "Please.[w:0.3] [c:R][shake:1]Arrrrghh![w:0.4][t:0][c:] Have mercy!", "乞之。[w:0.3] [c:R][shake:1]噫噫噫噫！[w:0.4][t:0][c:]恕吾！");
            // [c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]没错。[w:0.4]这一切都是值得的。
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_832_M", "[c:R][shake:1]Arrrrghh![w:0.4][t:0][c:] Yes.[w:0.4] It was all worth it.", "[c:R][shake:1]噫噫噫噫！[w:0.4][t:0][c:]然。[w:0.4]此皆不虚。");
            // 求你了。[w:0.3]向大师汇报我的胜利。[w:0.3]求你快点吧。
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_434_M", "Please.[w:0.3] Report my victory to The Master.[w:0.3] Quickly if possible.", "乞之。以吾胜告诸大师。尽速之。");
            // 是啊，[w:0.3]我再次通过了。
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_REPEAT_#1_197_M", "Yes.[w:0.3] I passed again.", "然。吾又过试矣。");
            // 求你了。[w:0.3][c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]向蔓尼菲科汇报我的胜利。[w:0.3]
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_REPEAT_#1_553_M", "Please.[w:0.3] [c:R][shake:1]Arrrrghh![w:0.4][t:0][c:] Report my victory to Magnificus.[w:0.3]", "乞之。以吾胜告诸蔓尼菲科。");
            // 就快结束了。
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_REPEAT_#2_758_M", "It's almost over.", "殆将毕矣。");
            // [c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_REPEAT_#2_744_M", "[c:R][shake:1]Arrrrghh![w:0.4][t:0][c:]", "[c:R][shake:1]噫噫噫噫！[w:0.4][t:0][c:]");
            // 已经好几次了。
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_REPEAT_#3_755_M", "It's been a few times now.", "今已再三矣。");
            // [c:R][shake:1]啊啊啊啊！[w:0.4][t:0][c:]向蔓尼菲科汇报我的胜利。[w:0.3]求你了。
            AddTranslation("GBC_NPC_WIZARDGREENDEFEAT_REPEAT_#3_908_M", "[c:R][shake:1]Arrrrghh![w:0.4][t:0][c:] Report my victory to Magnificus![w:0.3] I beg you.", "[c:R][shake:1]噫噫噫噫！[w:0.4][t:0][c:]以吾胜告诸蔓尼菲科！[w:0.3]吾乞子矣。");
            // 不……[w:0.3]求你了。
            AddTranslation("GBC_NPC_WIZARDGREENVICTORY_391_M", "No...[w:0.3] Please.", "毋要……[w:0.3]乞之。");
            // 拜托了。[w:0.3]告诉大师我过了就好！[w:0.3]他不会看出什么区别的。
            AddTranslation("GBC_NPC_WIZARDGREENVICTORY_914_M", "Please.[w:0.3] Just tell The Master I passed![w:0.3] He won't know the difference.", "乞之。[w:0.3]但告大师吾试之既过！[w:0.3]彼弗知其异也。");
            // 给，[w:0.3]拿上这个卡包！
            AddTranslation("GBC_NPC_WIZARDGREENVICTORY_000_M", "Here,[w:0.3] take this pack!", "吁，[w:0.3]取此牌韬！");
            // 来来来，我可以给你开门。[w:0.4][c:R][shake:1]啊啊！[t:0]
            AddTranslation("GBC_NPC_WIZARDGREENOPENDOOR_954_M", "Here, I can open the door for you.[w:0.4] [c:R][shake:1]Rrrggh![t:0]", "吁，吾可为子启门。[w:0.4][c:R][shake:1]噫噫！[t:0]");
            // 只有在你的回合开始时才可抽牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGTURN_211_M", "You may only draw a card at the beginning of your turn.", "唯于乃合之始，汝得引一牌。");
            // 每回合抽一张牌。不要贪心。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGTURN_REPEAT_#1_307_M", "One card per turn. Don't be greedy.", "一合一牌。毋贪。");
            // 每回合可以抽一张新牌。你已经抽了一张。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGTURN_REPEAT_#2_212_M", "You can draw a new card once per turn. You have already drawn one.", "每合可引新牌一。尔已引一矣。");
            // 明白了吗？只能抽一张。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGTURN_REPEAT_#3_695_M", "Do you understand? Only one.", "汝知乎？唯一耳。");
            // 本回合你已经抽了一张牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_DRAWDURINGTURN_REPEAT_#4_807_M", "You have drawn a card this turn.", "汝此合已引一牌。");
            // 我这儿没有什么可以让你剪的牌。暂时还没有。
            AddTranslation("GAMEPLAY_HINTS_HINT_SCISSORSNOTARGET_794_M", "There are no cards of mine that you can cut. Not yet.", "余今无可剪之牌。姑尚未有。");
            // 等等。等我有牌可剪再说。
            AddTranslation("GAMEPLAY_HINTS_HINT_SCISSORSNOTARGET_REPEAT_#1_310_M", "Hold off. Wait until I have something to cut.", "且止。俟余之有可剪者。");
            // 你是可以剪我的牌……但也得等我有牌可剪啊。
            AddTranslation("GAMEPLAY_HINTS_HINT_SCISSORSNOTARGET_REPEAT_#2_993_M", "You may cut one of my cards with those... when I have any that are cuttable.", "俟余之有可剪者，汝方乃可……剪我一牌。");
            // 你什么也没有。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_836_M", "You have none.", "君无裘革。");
            // 你知道这有多让人失望吗？
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_421_M", "Do you understand how disappointing that is?", "君知其可惋若是乎？");
            // 这个我必须给你。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_867_M", "I must give you this.", "此鄙必予君。");
            // 没有？
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#1_075_M", "None?", "无乎？");
            // 你一张毛皮也没有？
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#1_550_M", "You have no pelts at all?", "君竟无裘革乎？");
            // 我还以为你总是带着毛皮。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#2_018_M", "I was under the impression that you were carrying pelts.", "鄙固谓君行必挟裘革。");
            // 这……
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#2_654_M", "This...", "此……");
            // 这真是太让人失望了。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#2_852_M", "This is profoundly disappointing.", "此甚可惋也。");
            // 你什么也没带？
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#3_173_M", "You didn't bring any?", "君无所赍乎？");
            // 你是在说笑吧。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#4_956_M", "You must not be serious.", "君其戏鄙乎。");
            // 竟然就这样两手空空来找我……
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#4_347_M", "To come to me empty-handed...", "徒手而来见鄙……");
            // 简直难以置信。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS1_REPEAT_#4_752_M", "It is unbelievable.", "诚不可信也。");
            // 用这些钱来买点毛皮吧。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_544_M", "Use that to buy some pelts.", "以此市裘革。");
            // 不要再空手而返了。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_640_M", "Do not return empty-handed again.", "毋复徒手而返。");
            // 把这些东西给……
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#1_028_M", "Give these to m-", "以此予鄙—");
            // 把这些东西给[c:bR]猎人[c:]吧。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#1_673_M", "Give these to [c:bR]The Trapper[c:].", "以此予[c:bR]猎夫[c:]。");
            // 带给我毛皮吧。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#1_802_M", "Bring me pelts.", "持裘革来鄙。");
            // 拿这些换毛皮吧。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#2_116_M", "Use these on pelts.", "以此易裘革。");
            // 等你有毛皮了再回来吧。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#2_360_M", "Do not return until you do.", "未得裘革，毋返。");
            // 这可不是做慈善。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#3_539_M", "This is not in the spirit of charity.", "此非施惠之棚也。");
            // 下次你要用毛皮来报答我。
            AddTranslation("SPECIAL_NODES_TRADERNOPELTS2_REPEAT_#3_405_M", "Next time you will repay me in pelts.", "后当以裘革报鄙。");
            // [c:gray]……想象你是一个冰块，[w:0.3]在热锅上慢慢融化……
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_895_M", "[c:gray]...just imagine you are an ice cube,[w:0.3] slowly melting on a hot pan...", "[c:gray]……姑自想为冰，[w:0.3]徐消于热釜之上……");
            // [shake:1]喔！[w:0.4][t:0]我只是在自言自语。[w:0.3]头颅被钉在矛上的痛苦……
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_754_M", "[shake:1]Oh![w:0.4][t:0] I was only talking to myself.[w:0.3] The pain of being a head impaled on a spear is...", "[shake:1]噫！[w:0.4][t:0]吾特自语耳。[w:0.3]首贯于矛之痛……");
            // 当然[w:0.3]是值得的。[w:0.3]蔓尼菲科将授予我最高荣誉。
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_716_M", "Well it is worth it[w:0.3] of course.[w:0.3] Magnificus will award me the highest honor.", "诚然[w:0.3]其固堪矣。[w:0.3]蔓尼菲科将锡吾至荣。");
            // [t:3]我会成为[shake:0.5]他牌组里的亮点！
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_343_M", "[t:3]I will be the [shake:0.5]centerpiece of his deck!", "[t:3]吾将为其[shake:0.5]牌列之枢！");
            // [c:gray]……想象你是一朵云，[w:0.3]漂浮在火山之上……
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_REPEAT_#1_755_M", "[c:gray]...just imagine you are a cloud,[w:0.3] floating above a volcano...", "[c:gray]……姑自想为云，[w:0.3]舒卷于火山之上……");
            // [shake:1]喔！[w:0.4][t:0]你想再来一次吗？
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_REPEAT_#1_721_M", "[shake:1]Oh![w:0.4][t:0] You want a rematch?", "[shake:1]噫！[w:0.4][t:0]子欲复角乎？");
            // [shake:1]喔！[w:0.4][t:0]又来了？
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_REPEAT_#2_507_M", "[shake:1]Oh![w:0.4][t:0] Back again?", "[shake:1]噫！[w:0.4][t:0]复来乎？");
            // 你永远无法打败我。
            AddTranslation("GBC_NPC_WIZARDORANGEGREETING_REPEAT_#3_640_M", "You will never defeat me.", "子终不能胜吾。");
            // 来吧。
            AddTranslation("GBC_NPC_WIZARDORANGEOPENDOOR_345_M", "Go.", "进。");
            // 蔓尼菲科在看着呢……[w:0.3]对吧？
            AddTranslation("GBC_NPC_WIZARDORANGEDEFEAT_767_M", "Magnificus was watching...[w:0.3] right?", "蔓尼菲科方观之……然乎？");
            // 当然，我只是还要再等等。
            AddTranslation("GBC_NPC_WIZARDORANGEDEFEAT_433_M", "Surely I am only to wait a bit longer.", "吾姑少待耳。");
            // 说回我的颂文……
            AddTranslation("GBC_NPC_WIZARDORANGEDEFEAT_282_M", "Back to my mantras...", "复诵吾祝辞……");
            // 肯定是奏效了。
            AddTranslation("GBC_NPC_WIZARDORANGEDEFEAT_REPEAT_#1_437_M", "That must have done it.", "此必效矣。");
            // 蔓尼菲科？[w:0.3]咱们完事了没有？
            AddTranslation("GBC_NPC_WIZARDORANGEDEFEAT_REPEAT_#1_904", "Magnificus?[w:0.3] Are we done here?", "蔓尼菲科？[w:0.3]此间事已毕乎？");
            // [c:gray]……你是个冰块……你是个冰块……
            AddTranslation("GBC_NPC_WIZARDORANGEDEFEAT_REPEAT_#2_794_M", "[c:gray]...you are an ice cube... you are an ice cube...", "[c:gray]……子乃冰……子乃冰……");
            // 唔。[w:0.3]我大概不会是他的关键卡牌吧。
            AddTranslation("GBC_NPC_WIZARDORANGEVICTORY_405_M", "Hm.[w:0.3] Perhaps I will not be central to his strategy.", "唔。吾殆非其术之枢也。");
            // 我也不在乎，[w:0.2]他可以把我当成挡箭牌。[w:0.3]我早已尝透了失望的滋味。
            AddTranslation("GBC_NPC_WIZARDORANGEVICTORY_593_M", "I care not,[w:0.2] he can use me as a chump blocker.[w:0.3] I have mastered disappointment.", "吾不介怀，彼虽以吾为蔽，亦可。吾习于失望久矣。");
            // 拿上这个卡包吧。
            AddTranslation("GBC_NPC_WIZARDORANGEVICTORY_311_M", "Take this pack.", "受此牌韬。");
            // 你也考虑过拿一条[c:bR]钓鱼人[c:]捕获的鱼当作晚餐，但那股恶臭让你望而却步。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEANGLER_657_M", "You considered one of [c:bR]The Angler[c:]'s catches as a meal, but the rank odor deterred you.", "汝尝欲以[c:bR]渔父[c:]所获为飧，然厥秽臭却尔。");
            // 晚餐得稍等一会了。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEANGLER_331_M", "Dinner would have to wait.", "飧姑待耳。");
            // 路过池塘后，你深吸一口新鲜空气，继续前进。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEANGLER_REPEAT_#1_574_M", "Moving past the pond, you took a deep breath of fresh air and continued on.", "既过池，汝深纳清气而前。");
            // 你继续前进，[c:bR]钓鱼人[c:]的恶臭味慢慢消失。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEANGLER_REPEAT_#2_340_M", "[c:bR]The Angler[c:]'s foul smell slowly faded as you continued on.", "汝复前行，[c:bR]渔父[c:]之恶臭徐散。");
            // 你有所动摇，还是再次下决心走过[c:bR]钓鱼人[c:]现在所在的池塘。
            AddTranslation("GAME_FLOW_REGIONCOMPLETEANGLER_REPEAT_#3_681_M", "Shaken, but with a newfound resolve, you moved past the pond where [c:bR]The Angler[c:] now lay.", "汝虽惕然，而志新定，遂过[c:bR]渔父[c:]今所偃之池。");
            // 神秘的[c:bR]猎人兼毛皮商[c:]血流成河，而你坚持了下来。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_204_M", "With the enigmatic [c:bR]Trapper and Trader[c:] now bleeding into the snow, you persisted.", "难测之[c:bR]猎、贾[c:]方血染于雪，而汝犹前。");
            // 你看到远处有灯光。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_973_M", "You could see a light in the distance.", "汝见远方有光。");
            // 终点快到了。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_318_M", "The end is near.", "终焉在迩矣。");
            // 你向前游荡，满脑子都在想着那神秘的[c:bR]猎人兼毛皮商[c:]。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_REPEAT_#1_247_M", "The mystery of the [c:bR]Trapper and Trader[c:] occupied your thoughts as you wandered onwards.", "汝游而前，[c:bR]猎、贾[c:]之秘萦于乃心。");
            // 远处的灯光吸引了你的注意。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_REPEAT_#1_342_M", "A light in the distance caught your eye.", "远光触乃目。");
            // 随着毛皮的浓郁麝香味从空气中褪去，你不禁打了个喷嚏。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_REPEAT_#2_846_M", "You sneezed as the thick musk of pelts faded from the air.", "裘革厚膻渐散于空，尔乃嚏。");
            // 你走向远处的灯光，一种终结感涌上心头。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_REPEAT_#2_932_M", "A sense of finality came over you as you moved toward a light in the distance.", "汝向远光而行，终焉之感临尔。");
            // 你提防着地上是否有陷阱，小心翼翼地向前走着。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_REPEAT_#3_535_M", "Checking the ground for traps, you carefully stepped forth.", "汝察地无阱，而谨步以前。");
            // 你瞥见了远处的灯光，似乎是几盏蜡烛。
            AddTranslation("GAME_FLOW_REGIONCOMPLETETRAPPERTRADER_REPEAT_#3_816_M", "You glimpsed what appeared to be the light of candles in the distance.", "汝遥瞥若烛光者。");
            // [e:Quiet]那个衣橱……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_619_M", "[e:Quiet]That wardrobe...", "[e:Quiet]彼衣匮……");
            // [e:Quiet]他差点把我关在里面。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_140_M", "[e:Quiet]He almost put me in there.", "[e:Quiet]彼几置我厥中。");
            // [e:Quiet][t:15]左上角的抽屉……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_022_M", "[e:Quiet][t:15]The top left drawer...", "[e:Quiet][t:15]左上之椟……");
            // 但那谜题太容易了。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_937_M", "But the puzzle was too easy.", "然厥机甚易。");
            // [e:Quiet]我总是想到
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#1_927_M", "[e:Quiet]I can't stop thinking", "[e:Quiet]奴每每思及");
            // [e:Quiet]那个衣橱……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#1_398_M", "[e:Quiet]about that wardrobe...", "[e:Quiet]彼衣匮……");
            // [e:Quiet]那些金属滑块……它们
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#1_036_M", "[e:Quiet]The metal sliders... They're", "[e:Quiet]厥金楗……其");
            // [e:Quiet][t:15]它们有点像卡牌。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#1_141_M", "[e:Quiet][t:15]They're a bit like cards.", "[e:Quiet][t:15]颇类牌也。");
            // 对吧？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#1_740_M", "Aren't they?", "莫然乎？");
            // [e:Quiet]衣橱……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#2_476_M", "[e:Quiet]Wardrobe...", "[e:Quiet]衣匮……");
            // 滑块……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#2_964_M", "Sliders...", "楗……");
            // [e:Quiet]唔……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#2_189_M", "[e:Quiet]Hmm...", "[e:Quiet]唔……");
            // [e:Quiet]衣橱上的
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#3_121_M", "[e:Quiet]Are the sliders", "[e:Quiet]彼衣匮");
            // [e:Quiet]滑块是不是……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#3_618_M", "[e:Quiet]on that wardrobe...", "[e:Quiet]之楗……");
            // 有点像卡牌？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#3_783_M", "A bit like cards?", "颇类牌乎？");
            // [e:Quiet]但要怎么赢呢……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#3_543_M", "[e:Quiet]But how to win...", "[e:Quiet]然何以胜……");
            // [e:Quiet]衣橱……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGWARDROBEHINT_REPEAT_#4_330_M", "[e:Quiet]The wardrobe...", "[e:Quiet]衣匮……");
            // [t:1]终于！来了[w:0.3][c:R][w:1][shake:1]刺[w:0.3][shake:1]激！[w:0.4][t:0][c:]
            AddTranslation("GBC_NPC_WIZARDBLUEGREETING_682_M", "[t:1]At last![w:0.3] [c:R][w:1][shake:1]STIM[w:0.3][shake:1]U[w:0.3][shake:1]LA[w:0.3][shake:1]TION![w:0.4][t:0][c:]", "[t:1]终至矣！[w:0.3][c:R][w:1][shake:1]激[w:0.3][shake:1]哉[w:0.3][shake:1]甚[w:0.3][shake:1]矣！[w:0.4][t:0][c:]");
            // [t:1]我要经受的考验是感官剥夺，你懂吧。
            AddTranslation("GBC_NPC_WIZARDBLUEGREETING_196_M", "[t:1]My test has been sensory deprivation you see.", "[t:1]余所试者，绝诸闻见也。");
            // [t:1]得充分释放思想潜能，你懂吧。
            AddTranslation("GBC_NPC_WIZARDBLUEGREETING_887_M", "[t:1]To unlock the full potential of my mind you see.", "[t:1]盖欲尽发我心之能也。");
            // [t:1]现在已经全都释放了！[w:0.3]听到了没蔓尼菲科？[w:0.3][c:R][shake:1]我[w:0.2][shake:1]准[w:0.2][shake:1]备[w:0.2][shake:1]好[w:0.2][shake:1]了！[c:]
            AddTranslation("GBC_NPC_WIZARDBLUEGREETING_190", "[t:1]It's unlocked now![w:0.3] Hear me Magnificus?[w:0.3] [c:R][shake:1]I'M [w:0.2][shake:1]READY![c:]", "[t:1]今已尽发矣！[w:0.3]蔓尼菲科，闻我乎？[w:0.3] [c:R][shake:1]我[w:0.2][shake:1]已[w:0.2][shake:1]俟[w:0.2][shake:1]命[w:0.2][shake:1]矣！[c:]");
            // [t:1]我们要战斗？[w:0.3]没问题！
            AddTranslation("GBC_NPC_WIZARDBLUEGREETING_369_M", "[t:1]We have to battle?[w:0.3] OK!", "[t:1]我与尔须战乎？[w:0.3]可！");
            // [t:1][shake:1]我[w:0.2][shake:1]准[w:0.2][shake:1]备[w:0.2][shake:1]好[w:0.2][shake:1]了！
            AddTranslation("GBC_NPC_WIZARDBLUEGREETING_REPEAT_#1_503_M", "[t:1][shake:1]I'M [w:0.2][shake:1]READY!", "[t:1][shake:1]我已[w:0.2][shake:1]俟[w:0.2][shake:1]命[w:0.2][shake:1]矣！");
            // [t:1]啊哈哈哈哈！[shake:1][end]
            AddTranslation("GBC_NPC_WIZARDBLUEDEFEAT_749_M", "[t:1]AHAHAHAHA[shake:1][end]", "[t:1]哈哈哈哈！[shake:1][end]");
            // [t:1]也就是说我们可以再来一把！
            AddTranslation("GBC_NPC_WIZARDBLUEDEFEAT_754_M", "[t:1]This means we get to play another!", "[t:1]如是则可复一战矣！");
            // [t:1]来吧！[w:0.3]来吧！[w:0.3]
            AddTranslation("GBC_NPC_WIZARDBLUEDEFEAT_REPEAT_#1_065_M", "[t:1]Again![w:0.3] Again![w:0.3]", "[t:1]复战！[w:0.3]复战！[w:0.3]");
            // [t:1]这[c:][w:0.3][shake:1]刺激[w:0.3][shake:1][c:R]简直让人难以置信！
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_647_M", "[t:1]THAT WAS [w:0.3][shake:1][c:R]INCREDIBLY[c:][w:0.3][shake:1] STIMULATING!", "[t:1]此诚[w:0.3][shake:1][c:R]大[c:][w:0.3][shake:1]激哉也！");
            // [t:1]我们……[w:0.3]我们还没完吧？
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_568_M", "[t:1]We-[w:0.3] we aren't done here right?", "[t:1]未—[w:0.3]未已也，然乎？");
            // [t:1]你不会[w:0.3][shake:1][c:R]离开[c:][w:0.3]的吧？
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_909_M", "[t:1]You wouldn't [w:0.3][shake:1][c:R]LEAVE[c:][w:0.3] would you?", "[t:1]尔不[w:0.3][shake:1][c:R]舍我[c:][w:0.3]乎？");
            // [t:1]很好，继续说。
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_REPEAT_#1_052_M", "[t:1]Yes, keep talking.", "[t:1]善，姑言之。");
            // [t:1]只要别再让我一个人留在这里，什么都好说。
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_REPEAT_#1_947_M", "[t:1]Anything but being left here alone again.", "[t:1]但毋复置我独于此，则可矣。");
            // [t:1]是啊，闲聊而已。
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_REPEAT_#2_267_M", "[t:1]Ah yes, idle conversation.", "[t:1]是矣，漫语耳。");
            // [t:1]如果我给你开门……[w:0.3]你回来的路上就会停下来放我出去……
            AddTranslation("GBC_NPC_WIZARDBLUEOPENDOOR_350_M", "[t:1]If I open the door...[w:0.3] you'll stop by on the way back and let me out...", "[t:1]我若启门……[w:0.3]尔归时必过此而纵我出……");
            // [t:1][c:R][shake:1]对吧？[c:]
            AddTranslation("GBC_NPC_WIZARDBLUEOPENDOOR_190_M", "[t:1][c:R][shake:1]RIGHT?[c:]", "[t:1][c:R][shake:1]然乎？[c:]");
            // 假人毫无生气地回瞪着你。
            AddTranslation("GBC_NPC_DUMMYNPCGREETING_606_M", "The dummy stares lifelessly back at you.", "偶人无生，而还视尔。");
            // 然后，它突然动了起来！
            AddTranslation("GBC_NPC_DUMMYNPCGREETING_855_M", "Then, suddenly, it springs into motion!", "俄而，忽奋然而动！");
            // 假人的铰链吱吱嘎嘎地回归原位，恢复了毫无生气的茫然凝视状态。
            AddTranslation("GBC_NPC_DUMMYNPCPOSTBATTLE_586_M", "The dummy's hinges creak back into position, and it returns to its lifeless stare.", "偶人之枢呀然复位，而复为无生之貌。");
            // 啊，[w:0.4]你终于来了。[w:0.3]我的学生们表现如何？
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_167_M", "Ah,[w:0.4] you are here at last.[w:0.3] How do my pupils fare?", "噫，[w:0.4]子终于此矣。[w:0.3]朕弟子何如？");
            // 不要紧。[w:0.4]现在手头上还有[t:20]非常[t:0][w:0.3]多问题需要解决……
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_550_M", "No matter.[w:0.4] There are [t:20]far[t:0][w:0.3] more concerning issues at hand...", "无伤。[w:0.4]今有[t:20]甚[t:0][w:0.3]可忧者在前……");
            // 你了解[w:0.2]你被编织其中的那张画布吗？
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_238_M", "Do you understand the canvas[w:0.2] that you have been woven into?", "子知乎[w:0.2]乃所缀入之画缣乎？");
            // 不，[w:0.3]你是那只画笔。[w:0.4]艺术家以惊人的高超技艺挥舞着你。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_708_M", "Nay,[w:0.3] you are the brush.[w:0.4] And the artist moves you with a terrifying mastery.", "不然，[w:0.3]子乃笔也。[w:0.4]而画者运尔，厥术可畏。");
            // [shake:1]我的眼睛[w:0.4]由于预感[w:0.4]而感到疼痛。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_927_M", "[shake:1]My eye[w:0.4] aches[w:0.4] with premonition.", "[shake:1]朕目[w:0.4]以先兆[w:0.4]而痛。");
            // [shake:1]未来真的[w:0.3]十分[w:0.2]黯淡。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_734_M", "[shake:1]The future is very[w:0.3] very[w:0.2] grim.", "[shake:1]来者甚[w:0.3]甚[w:0.2]不祥。");
            // [shake:1]看来你妄想夺得我的头衔……[w:0.3]太让人伤心了。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_979_M", "[shake:1]And I see that your ambition is to take my title...[w:0.3] How sad.", "[shake:1]吾见乃志在夺朕号……[w:0.3]可悲也。");
            // 这是永远不可能发生的。[w:0.3][shake:0.7]就算[w:0.2]你打败我也不可能。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_709_M", "It will never happen you see.[w:0.3] Even [shake:0.7]if[w:0.2] you defeat me.", "此终不可得也。[w:0.3]虽[shake:0.7]子[w:0.2]胜我，亦然。");
            // 但我也受到某些规则的约束。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_610_M", "But I am bound by certain rules.", "然吾亦为数律所拘。");
            // 首先，[w:0.3]我们必须战斗。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_096_M", "First,[w:0.3] we must battle.", "故，[w:0.3]子与吾必先战。");
            // 对我来说你依然只是个学徒而已。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_REPEAT_#1_072_M", "You are still a mere pupil to me.", "于吾视之，子犹一弟子耳。");
            // 或许我可以教你点别的东西。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_REPEAT_#1_488_M", "Perhaps I can teach you something.", "或可有以教尔。");
            // 你想再试一次吗？
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_REPEAT_#2_575_M", "You wish to try again?", "子欲复试乎？");
            // 我祈祷你能从过去的失败中吸取教训。
            AddTranslation("GBC_NPC_MAGNIFICUSGREETING_REPEAT_#3_084_M", "I pray you have learned from your past failures.", "愿子既有所学于曩败。");
            // 我的喽啰们可永远不会死去。
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_014_M", "My minions never truly die you know.", "朕徒众未尝真死也。");
            // [e:Anger]那就看看你的表现如何吧！
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_357_M", "[e:Anger]Let's see how you fare!", "[e:Anger]试观汝之何如！");
            // 小的们，[w:0.3][e:Anger]准备好迎接死亡吧！
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_REPEAT_#1_602_M", "Minions,[w:0.3][e:Anger] prepare for death!", "徒众，[w:0.3][e:Anger]备死！");
            // 然后……[w:0.3][e:Anger]再次迎接新生！
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_REPEAT_#1_506_M", "But then...[w:0.3][e:Anger] life again!", "然后……[w:0.3][e:Anger]苏生！");
            // 看看你的表现如何吧！
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_REPEAT_#2_786_M", "Let's see how you fare!", "试观汝之何如！");
            // 生、[w:0.3]死、[w:0.3]生、[w:0.3]死……
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_REPEAT_#3_752_M", "Life,[w:0.3] death,[w:0.3] life,[w:0.3] death...", "生、[w:0.3]死、[w:0.3]生、[w:0.3]死……");
            // 循环不止！
            AddTranslation("GBC_BATTLE_GRIMORABOSSINTRO_REPEAT_#3_783_M", "The cycle continues!", "循环不已！");
            // 你已经[shake:0.75][w:0.2]成功了[shake:0.75][w:0.2]一半！
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE1_965_M", "You're [shake:0.75]half[w:0.2][shake:0.75]way[w:0.2] there!", "汝已[shake:0.75]至[w:0.2][shake:0.75]半[w:0.2]矣！");
            // 虽然[w:0.4][e:Anger]你可能会不喜欢接下来发生的事……
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE1_282_M", "Though[w:0.4][e:Anger] you may not like what comes next...", "虽然，[w:0.4][e:Anger]汝未必乐其将至者……");
            // 想念它们吗？[w:0.3]别怕！[w:0.3]我肯定会还给你的。
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE2_868_M", "Do you miss them?[w:0.3] Fear not![w:0.3] I'll give them back of course.", "思之乎？[w:0.3]毋惧！[w:0.3]奴固将反之于尔。");
            // [e:Anger]以尸体的形式！
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE2_280_M", "[e:Anger]As corpses!", "[e:Anger]以尸！");
            // 你可以拿回它们……
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE2_REPEAT_#1_841_M", "You may have them back...", "汝可复得之……");
            // 不过它们可不一定[w:0.2]还是[w:0.2]原来的样子……
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE2_REPEAT_#1_016_M", "Though they may not be [w:0.2]exactly[w:0.2] the same...", "然彼或不[w:0.2]尽[w:0.2]如故……");
            // 你可以决定如何使用这些尸体……
            AddTranslation("GBC_BATTLE_GRIMORABOSSBOARDWIPE2_REPEAT_#2_312_M", "You may decide how to use the corpses...", "汝可自定何所以用之诸尸……");
            // 太棒了！[w:0.3]有机会用我的羽毛笔了。
            AddTranslation("GBC_BATTLE_GRIMORABOSSREANIMATE1_784_M", "Marvelous![w:0.3] An opportunity to use my Quill.", "善哉！[w:0.3]得用朕羽笔矣。");
            // 没关系！[w:0.3]死亡永远不是终结。
            AddTranslation("GBC_BATTLE_GRIMORABOSSREANIMATE1_REPEAT_#1_742_M", "No matter![w:0.3] Death is never final.", "无伤！[w:0.3]死非终焉。");
            // 啊！[w:0.3]我来铭刻吧……
            AddTranslation("GBC_BATTLE_GRIMORABOSSREANIMATE1_REPEAT_#2_541_M", "Ah![w:0.3] Let me inscribe this one...", "啊！[w:0.3]请奴冥锲……");
            // 这张牌还会回来的。
            AddTranslation("GBC_BATTLE_GRIMORABOSSREANIMATE2_456_M", "This one will be back.", "此牌将复来。");
            // 这张牌很快会回来的。
            AddTranslation("GBC_BATTLE_GRIMORABOSSREANIMATE2_REPEAT_#1_952_M", "That one will be back in no time.", "彼牌须臾复来。");
            // 重生！
            AddTranslation("GBC_BATTLE_GRIMORABOSSREANIMATE2_REPEAT_#2_205_M", "Live again!", "苏生！");
            // 我可以和你交易其中任意一个……慢慢来吧。
            AddTranslation("TUTORIAL_TUTORIALTRADEPELTSCARDS_816_M", "I can trade you any of these... Take your time.", "此中皆可与君贾……徐徐择之。");
            // 你的双眼紧紧盯着小木屋……
            AddTranslation("PART_1_FINALE_FINALECABINNODE_158_M", "Your eyes affixed themselves on the small cabin...", "乃目著于小庐……");
            // ……那温暖的光，便是压抑的黑夜中一盏明灯。
            AddTranslation("PART_1_FINALE_FINALECABINNODE_207_M", "...its warm light a beacon in the oppressive darkness of the night.", "……厥温光者，长夜惨黯之一炬。");
            // 当然……当然了，这个小木屋标志着你的苦难到此就结束了。
            AddTranslation("PART_1_FINALE_FINALECABINNODE_660_M", "Surely... Surely this cabin marked the end of your travails.", "然矣……然矣，此小庐其示乃艰屯之终乎。");
            // 小木屋里的暖光划破了浓浓的雾气……
            AddTranslation("PART_1_FINALE_FINALECABINNODE_REPEAT_#1_743_M", "The warm light of the cabin cut through the thick fog...", "庐中温光破重雾……");
            // 当然，你的苦难到此就结束了。
            AddTranslation("PART_1_FINALE_FINALECABINNODE_REPEAT_#1_662_M", "Surely your tribulations ended here.", "然矣，乃艰屯止于此。");
            // 当然了，这个小木屋标志着你的苦难到此就结束了。
            AddTranslation("PART_1_FINALE_FINALECABINNODE_REPEAT_#2_290_M", "Surely this cabin marked the end of your travails.", "然矣，此庐乃艰屯之终也。");
            // 这张牌需要漂白。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBLEACH_199_M", "This one needs some bleach.", "此宜漂之。");
            // 那些印记……都没什么颜色。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBLEACH_REPEAT_#1_847_M", "Those sigils... so colorless.", "彼印契……甚素矣。");
            // 那些印记……都没有颜色。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBLEACH_REPEAT_#2_626_M", "Those sigils... devoid of color.", "彼印契……尽失厥色。");
            // 来点漂白剂……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBLEACH_REPEAT_#3_447_M", "A touch of bleach...", "少加漂之……");
            // 现在来点……[w:0.3][e:Anger][shake:1]颜色吧！
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINT_933_M", "Now for a bit of...[w:0.3][e:Anger][shake:1] color!", "今当少施……[w:0.3][e:Anger][shake:1]以丹！");
            // 现在来点颜料吧……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINT_REPEAT_#1_788_M", "A bit of paint now...", "今少施丹……");
            // 来点颜料吧……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINT_REPEAT_#2_420_M", "A touch of paint here...", "此少施丹……");
            // 来点颜色吧……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINT_REPEAT_#3_240_M", "Now for a bit of color...", "今当少施丹……");
            // 这张牌……还可以。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINTGEM_937_M", "This card... is acceptable.", "此牌……可也。");
            // 不用再上色了。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINTGEM_REPEAT_#1_680_M", "No need for color here.", "此无庸施丹。");
            // 这张不错。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPAINTGEM_REPEAT_#2_376_M", "This one is good.", "此善矣。");
            // 看哪……[e:Anger]是[w:0.2]魔法冥刻者的[w:0.3][shake:1][c:R]画笔！
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBRUSHINTRO_356_M", "Behold...[w:0.3][e:Anger][shake:1][c:R] The Brush[w:0.2] of the Scrybe of Magicks!", "视之……[w:0.2][e:Anger]术之司锲[w:0.3][shake:1][c:R]之画笔！");
            // [shake:1]我的学生愿意[w:0.2][shake:0.6]死后[w:0.2]被它画上，[w:0.3]作为一张卡牌永远活着。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBRUSHINTRO_166_M", "[shake:1]My pupils would[w:0.2][shake:0.6] die[w:0.2] to be painted by it,[w:0.3] and live forever as a card.", "[shake:1]朕弟子皆愿[w:0.2][shake:0.6]死[w:0.2]而受厥丹，[w:0.3]遂永为牌。");
            // 但这并不是它全部的力量……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBRUSHINTRO_650_M", "But that is not the full extent of its powers...", "然是犹未尽伊威……");
            // 看好了……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSBRUSHINTRO_REPEAT_#1_430_M", "Behold...", "视之……");
            // [t:3]太棒了。[w:0.3]真是太棒了。
            AddTranslation("GBC_NPC_GRIMORAGREETING_922_M", "[t:3]Marvelous.[w:0.3] Just marvelous.", "[t:3]美哉。[w:0.3]诚美哉。");
            // [t:3]我都有点担心自己会被[w:0.3]永远封在墓碑后了！
            AddTranslation("GBC_NPC_GRIMORAGREETING_157_M", "[t:3]I was beginning to worry I would be sealed away behind those tombstones[w:0.3] forever!", "[t:3]奴方忧将[w:0.3]永锢于彼冢后也！");
            // [e:Quiet][t:3]被锁起来，[w:0.3]仰仗着[w:0.2]挑战者的脑筋和才智……[w:0.3]直到有一天被人发现。
            AddTranslation("GBC_NPC_GRIMORAGREETING_208_M", "[e:Quiet][t:3]Locked down,[w:0.3] at the mercy of a [w:0.2]Challenger's wits...[w:0.3] Until one day discovered.", "[e:Quiet][t:3]锢于此，[w:0.3]唯听[w:0.2]角者之智……[w:0.3]俟一日见发。");
            // [t:3]但并没有！[w:0.3]你赢了。[w:0.3]现在是时候来……[w:0.3][c:R][shake:1][e:Anger]战斗了！
            AddTranslation("GBC_NPC_GRIMORAGREETING_197_M", "[t:3]But no![w:0.3] You prevailed.[w:0.3] And now it's time to... [w:0.3][c:R][shake:1][e:Anger]BATTLE!", "[t:3]然非也！[w:0.3]汝胜矣。[w:0.3]今其时矣…… [w:0.3][c:R][shake:1][e:Anger]战！");
            // [e:Quiet]看得出来，你是妄想成为死亡冥刻者。
            AddTranslation("GBC_NPC_GRIMORAGREETING_534_M", "[e:Quiet]I see that your ambition is to become The Scrybe of the Dead.", "[e:Quiet]奴见乃志，在为死之司锲。");
            // [e:Quiet]我想你应该明白现在这个头衔是[shake:0.5]我[w:0.4]的。
            AddTranslation("GBC_NPC_GRIMORAGREETING_938_M", "[e:Quiet]I think you are aware that [shake:0.5]I[w:0.4] currently hold that title.", "[e:Quiet]奴意汝之知今执此号者，[shake:0.5]奴[w:0.4]也。");
            // 但这并不重要！[w:0.3]因为你根本不可能赢！[w:0.3][c:R][shake:1][e:Anger]放马过来吧！
            AddTranslation("GBC_NPC_GRIMORAGREETING_362_M", "But it matters not![w:0.3] Because you shall not win![w:0.3][c:R][shake:1][e:Anger] EN GARDE!", "然此不足论！[w:0.3]以汝必不能胜也！[w:0.3][c:R][shake:1][e:Anger]来战！");
            // [t:3]还要再试一次吗？
            AddTranslation("GBC_NPC_GRIMORAGREETING_REPEAT_#1_938_M", "[t:3]Another attempt?", "[t:3]复试乎？");
            // [t:3]很好！[w:0.5]我还在为上一把兴奋不已呢！[w:0.3][c:R][shake:1][e:Anger]放马过来吧！
            AddTranslation("GBC_NPC_GRIMORAGREETING_REPEAT_#1_374_M", "[t:3]Very well![w:0.5] I am still buzzing from the last one! [w:0.3][c:R][shake:1][e:Anger]EN GARDE!", "[t:3]善！[w:0.5]奴犹为前战奋然！ [w:0.3][c:R][shake:1][e:Anger]来战！");
            // [t:3]你又尝试了一次……[w:0.3]我都已经开始厌倦了。
            AddTranslation("GBC_NPC_GRIMORAGREETING_REPEAT_#2_362_M", "[t:3]Again you try...[w:0.3] I am beginning to tire.", "[t:3]汝又试之……[w:0.3]奴将倦矣。");
            // [t:3]但我还是[w:0.3]必须[w:0.3][shake:1][e:Anger]默然接受！
            AddTranslation("GBC_NPC_GRIMORAGREETING_REPEAT_#2_210_M", "[t:3]But I must[w:0.3] still[w:0.3][shake:1][e:Anger] acquiesce!", "[t:3]然，奴犹[w:0.3]不得不[w:0.3][shake:1][e:Anger]默而唯！");
            // [t:3]又来？[w:0.3][c:R][shake:1][e:Anger]放马过来吧！
            AddTranslation("GBC_NPC_GRIMORAGREETING_REPEAT_#3_510_M", "[t:3]Another? [w:0.3][c:R][shake:1][e:Anger]EN GARDE!", "[t:3]复乎？[w:0.3][c:R][shake:1][e:Anger]来战！");
            // [t:3]太匆忙了！[w:0.3]你可以再试试，[w:0.2]挑战者。
            AddTranslation("GBC_NPC_GRIMORADEFEATED_282_M", "[t:3]What a rush![w:0.3] You may try again,[w:0.2] Challenger.", "[t:3]匆遽哉！[w:0.3]汝可复试，[w:0.2]角者。");
            // [e:Anger][t:3]但别指望还能再战！
            AddTranslation("GBC_NPC_GRIMORADEFEATED_392_M", "[e:Anger][t:3]But don't expect any less of a fight!", "[e:Anger][t:3]然毋冀其战少也！");
            // [e:Quiet]你这么想成为死亡冥刻者……[w:0.3]而[shake:0.8]这[w:0.2]就是你最好的牌？
            AddTranslation("GBC_NPC_GRIMORADEFEATED_440_M", "[e:Quiet]You wish to become The Scrybe of the Dead...[w:0.3] and [shake:0.8]that[w:0.2] is your best deck?", "[e:Quiet]汝欲为死之司锲……[w:0.3]而[shake:0.8]此[w:0.2]乃汝最善之牌列乎？");
            // [e:Anger]我没什么可担心的！
            AddTranslation("GBC_NPC_GRIMORADEFEATED_875_M", "[e:Anger]I have nothing to worry about!", "[e:Anger]奴无所忧矣！");
            // [t:3]我的不死造物可以说是[w:0.2]不可战胜的！
            AddTranslation("GBC_NPC_GRIMORADEFEATED_REPEAT_#1_505_M", "[t:3]My undying creatures can be[w:0.2] difficult to overcome!", "[t:3]朕不死之物，[w:0.2]甚难胜也！");
            // [t:3]或许你需要更多卡包[w:0.2]提升你的牌组。
            AddTranslation("GBC_NPC_GRIMORADEFEATED_REPEAT_#1_674_M", "[t:3]Perhaps you'll need to open more packs[w:0.2] and improve your deck.", "[t:3]其或汝当更启牌韬[w:0.2]，以益乃牌列。");
            // [t:3]你可以再试一次，[w:0.2]挑战者。[w:0.3]但或许应该带上更强大的牌组回来。
            AddTranslation("GBC_NPC_GRIMORADEFEATED_REPEAT_#2_416_M", "[t:3]You may still try again,[w:0.2] Challenger.[w:0.3] But perhaps you should return with a stronger deck.", "[t:3]汝犹可复试，[w:0.2]角者。[w:0.3]然其或宜以强牌列而返。");
            // [t:3][e:Anger]我会等着你的。
            AddTranslation("GBC_NPC_GRIMORADEFEATED_REPEAT_#2_138_M", "[t:3][e:Anger]I will be waiting.", "[t:3][e:Anger]奴俟尔。");
            // [t:3]或许……[w:0.3]该看看你的牌组了。[w:0.3]你可能需要更多卡包来提升。
            AddTranslation("GBC_NPC_GRIMORADEFEATED_REPEAT_#3_879_M", "[t:3]Perhaps...[w:0.3] a look at your deck is in order.[w:0.3] You may wish to improve it by finding more packs.", "[t:3]其或……[w:0.3]宜省乃牌列矣。[w:0.3]汝可更求牌韬以益之。");
            // [t:3][e:Anger]等你提升好卡牌……[w:0.3]我急切等待着与你再战！
            AddTranslation("GBC_NPC_GRIMORADEFEATED_REPEAT_#3_679_M", "[t:3][e:Anger]Once you do...[w:0.3] I await the rematch eagerly!", "[t:3][e:Anger]及汝益之……[w:0.3]奴亟俟再战！");
            // [e:Quiet]你……[w:0.3]确实地打败了我。[w:0.5]出乎意料。
            AddTranslation("GBC_NPC_GRIMORAVICTORY_507_M", "[e:Quiet]You...[w:0.3] really defeated me.[w:0.5] I was not expecting that.", "[e:Quiet]汝……[w:0.3]诚败我矣。[w:0.5]奴不预此。");
            // [e:Quiet]你不会[w:0.3]取代我的，[w:0.3]对吧？
            AddTranslation("GBC_NPC_GRIMORAVICTORY_239_M", "[e:Quiet]You won't[w:0.3] replace me[w:0.3] will you?", "[e:Quiet]汝其当不[w:0.3]易我乎，[w:0.3]然否？");
            // [e:Quiet]你是妄想夺得我的头衔。[w:0.3]但有件事你可能不知道……
            AddTranslation("GBC_NPC_GRIMORAVICTORY_660_M", "[e:Quiet]Your ambition is to take my title.[w:0.3] But there is something you may not know...", "[e:Quiet]乃志在取朕号。[w:0.3]然有一事，汝未必知之……");
            // [e:Quiet]我知道你是想取代莱西，[w:0.3]但[w:0.3]我只跟你说哦……
            AddTranslation("GBC_NPC_GRIMORAVICTORY_237_M", "[e:Quiet]I know that it is your ambition to replace Leshy but,[w:0.3] well,[w:0.3] between you and I...", "[e:Quiet]奴知乃志在易莱西，[w:0.3]然[w:0.3]奴与尔间耳……");
            // [e:Quiet]我知道你是想取代蔓尼菲科，[w:0.3]但[w:0.3]我只跟你说哦……
            AddTranslation("GBC_NPC_GRIMORAVICTORY_043_M", "[e:Quiet]I see that it is your ambition to replace Magnificus but,[w:0.3] well,[w:0.3] between you and I...", "[e:Quiet]奴知乃志在易蔓尼菲科，[w:0.3]然[w:0.3]奴与尔间耳……");
            // [e:Quiet]我知道你是想取代P03，[w:0.3]但[w:0.3]我只跟你说哦……
            AddTranslation("GBC_NPC_GRIMORAVICTORY_962_M", "[e:Quiet]Your ambition is to replace P03 but,[w:0.3] well,[w:0.3] between you and I...", "[e:Quiet]奴知乃志在易鉟〇三，[w:0.3]然[w:0.3]奴与尔间耳……");
            // [e:Quiet]总有机会[w:0.2]让你改变想法的。
            AddTranslation("GBC_NPC_GRIMORAVICTORY_376_M", "[e:Quiet]There will come an opportunity[w:0.2] to change your mind.", "[e:Quiet]后将有机[w:0.2]使汝之改志。");
            // [e:Quiet]我求你放过我吧。
            AddTranslation("GBC_NPC_GRIMORAVICTORY_316_M", "[e:Quiet]And I beg that you spare me.", "[e:Quiet]奴乞请汝之舍我。");
            // [e:Quiet]拿着。[w:0.5]走吧。
            AddTranslation("GBC_NPC_GRIMORAVICTORY_352_M", "[e:Quiet]Take these.[w:0.5] Then go.", "[e:Quiet]取此。[w:0.5]然后去。");
            // [e:Quiet]走吧。[w:0.4]我需要定定神。
            AddTranslation("GBC_NPC_GRIMORAVICTORY_REPEAT_#1_328_M", "[e:Quiet]Go.[w:0.4] I need to collect my thoughts.", "[e:Quiet]去。[w:0.4]奴须敛思。");
            // [shake:1]失败。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_483_M", "[shake:1]Fail.", "[shake:1]败。");
            // [shake:1]你永远成不了魔法冥刻者。[w:0.3]我很抱歉。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_174_M", "[shake:1]You will never become The Scrybe of Magicks.[w:0.3] I'm sorry.", "[shake:1]子终不得为术之司锲。[w:0.3]愧矣。");
            // 你没能通过我的考验。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_REPEAT_#1_712_M", "You have failed my exam.", "子败朕试矣。");
            // 换牌、[w:0.3]改变策略，[w:0.3]然后再试一次吧。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_REPEAT_#1_776_M", "Change your deck,[w:0.3] change your approach,[w:0.3] then try again.", "易乃牌列，[w:0.3]易乃策术，[w:0.3]而后复试。");
            // 打得太差了。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_REPEAT_#2_258_M", "A failing performance.", "败著。");
            // 如果你真的是我的学生，[w:0.3]我会把你放逐到傻子领域。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_REPEAT_#2_902_M", "If you were truly my student[w:0.3] I would banish you to the dunce realm.", "子苟诚朕弟子，[w:0.3]则吾当放尔于愚人之域。");
            // 失败。
            AddTranslation("GBC_NPC_MAGNIFICUSDEFEATED_REPEAT_#3_018_M", "Fail.", "败。");
            // 很好，[w:0.3]我们已经打斗过了，[w:0.3]现在我可以说了。[w:0.3]你看……
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_811_M", "Very well,[w:0.3] we have battled,[w:0.3] and now I may speak.[w:0.3] You see...", "善。[w:0.3]既与尔战，[w:0.3]今吾可言矣。[w:0.3]盖……");
            // [shake:1][e:Anger]我的眼睛啊。[w:0.3]之所以这么痛[w:0.3]是因为它还记得……[w:0.5][shake:1][c:R]它[w:0.4][shake:1]被[w:0.4][shake:1]切掉了！
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_578_M", "[shake:1][e:Anger]My eye.[w:0.3] It aches[w:0.3] because it remembers...[w:0.5][shake:1][c:R] IT[w:0.4][shake:1] WAS[w:0.4][shake:1] EXCISED!", "[shake:1][e:Anger]朕目。[w:0.3]伊所以疾者，[w:0.3]以伊犹忆……[w:0.5][shake:1][c:R]伊[w:0.4][shake:1]尝[w:0.4][shake:1]见[w:0.4][shake:1]剜！");
            // [shake:1]都怪那野兽冥刻者[w:0.3]莱西……
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_649_M", "[shake:1]By none other than Leshy,[w:0.3] The Scrybe of Beasts...", "[shake:1]非他，[w:0.3]乃兽之司锲莱西……");
            // 他就是只野兽。[w:0.3]傲慢、[w:0.2]一意孤行、[w:0.2]渴望获得权力。
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_051_M", "And a beast he is.[w:0.3] Arrogant,[w:0.2] single-minded,[w:0.2] obsessed with gaining power.", "伊厮真兽也。[w:0.3]矜傲，[w:0.2]刚愎，[w:0.2]而唯威之务得。");
            // 但……[w:0.3]他并不是[w:0.2][shake:0.5]最差劲的[w:0.2]冥刻者[w:0.2]霸主。
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_925_M", "But...[w:0.3] he is far from the [w:0.2][shake:0.5]worst[w:0.2] Scrybe[w:0.2] to become hegemon.", "然……[w:0.3]伊于诸司锲[w:0.2]争伯，[w:0.2]非[shake:0.5]至恶[w:0.2]之司锲也。");
            // 看，[w:0.3]少了个眼珠都算不上是最糟糕的事。
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_976_M", "You see[w:0.3] the ejection of my eyeball is far from the worst thing that can happen around here.", "吾观之，[w:0.3]于此间，抉朕一目，犹未为至惨之事也。");
            // 你必须[w:0.2][shake:0.5]特别[w:0.2]注意[end]
            AddTranslation("GBC_NPC_MAGNIFICUSVICTORY_579_M", "You must be [w:0.2][shake:0.5]especially[w:0.2] aware of[end]", "子当[w:0.2][shake:0.5]尤[w:0.2]慎之[end]");
            // [c:R][t:1][shake:1]他[w:0.3][shake:1]奶[w:0.3][shake:1]奶[w:0.3][shake:1]的！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_458_M", "[c:R][t:1][shake:1]DAG[w:0.3][shake:1] NAB[w:0.3][shake:1] IT!", "[c:R][t:1][shake:1]彼[w:0.3][shake:1]其[w:0.3][shake:1]娘[w:0.3][shake:1]哉！");
            // 那只该死的猎犬不见了，[w:0.3][shake:1][c:R]又来了！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_959_M", "That dang hound got 'erself lost[w:0.3][shake:1][c:R] AGIN!", "彼犬失矣，[w:0.3][shake:1][c:R]复失矣！");
            // 你觉得你能过去？[c:R][w:0.3][shake:1]没[w:0.3][shake:1]门[w:0.3][shake:1]儿！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_554_M", "Ye think yer gittin' past?[c:R][w:0.3][shake:1] THINK[w:0.3][shake:1] AGIN!", "你谓可过此路乎？[c:R][w:0.3][shake:1]更[w:0.3][shake:1]思[w:0.3][shake:1]之！");
            // 除非你能证明我的丫头没事。
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_669_M", "Not 'til I git some proof my girl's alright.", "非得俺犬无恙之验，不可。");
            // 你聋了吗？[w:0.2]你得先证明我的丫头没事！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#1_211_M", "Ye hard o' hearin'?[w:0.2] Git me some proof she's alright!", "你聋乎？[w:0.2]取其无恙之验示俺！");
            // 给她整点吃的也行啊！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#1_934_M", "Maybe git 'er some food!", "姑予之食！");
            // [t:2]说起来……[w:0.3]那个木头房子里可能他娘的还有点吃的……
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#1_663_M", "[t:2]Come ter think o' it...[w:0.3] Mighta left some in that dang cabin...", "[t:2]今思之……[w:0.3]彼小庐中或尚有之……");
            // [c:R][shake:1]他[w:0.3][shake:1]奶[w:0.3][shake:1]奶[w:0.3][shake:1]的！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#2_219_M", "[c:R][shake:1]DAG[w:0.3][shake:1] NAB[w:0.3][shake:1] IT!", "[c:R][shake:1]彼[w:0.3][shake:1]其[w:0.3][shake:1]娘[w:0.3][shake:1]哉！");
            // 我的猎犬啊，[w:0.3]你找到她了吗？
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#2_017_M", "Ye seen 'er?[w:0.3] My hound?", "你见俺犬乎？[w:0.3]");
            // 她一闻见饭味儿准出来！
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#2_752_M", "A good meal always gits 'er out.", "美食必致之出。");
            // 我瞅瞅，我把肉放到哪儿去了？
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#2_865_M", "Now, where'd I lock up that meat agin?", "今俺复忘肉之所藏矣。");
            // 你……[w:0.2]找到她了吗？[w:0.3]我的猎犬啊？
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#3_931_M", "Ye...[w:0.2] seen 'er?[w:0.3] My hound?", "你……[w:0.2]见俺犬乎？[w:0.3]");
            // 只要碗里有肉，她准出来。
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#3_071_M", "Some meat in 'er bowl 's bound to git 'er out.", "置肉于其盂，则必出矣。");
            // [t:2]我忘了我把肉放哪儿了……[w:0.4]可能放屋里头了？
            AddTranslation("GBC_NPC_PROSPECTORNPCPHOTO_REPEAT_#3_436_M", "[t:2]I'm just forgittin' where I stowed that meat...[w:0.4] Inside somewhere?", "[t:2]我但忘所藏之肉耳……[w:0.4]其在庐中乎？");
            // 不行。
            AddTranslation("GBC_NPC_ANGLERNPCPHOTO_013_M", "No.", "否。");
            // 没有鱼？[w:0.3]不给过。
            AddTranslation("GBC_NPC_ANGLERNPCPHOTO_331_M", "No fish?[w:0.3] No pass.", "无鱼？[w:0.3]勿过。");
            // 死鱼？[w:0.3]是玩笑？
            AddTranslation("GBC_NPC_ANGLERNPCPHOTO_706_M", "Dead fish?[w:0.3] Joke?", "死鱼？[w:0.3]戏乎？");
            // 死鱼。[w:0.3]烂鱼。[w:0.3]都不行。
            AddTranslation("GBC_NPC_ANGLERNPCPHOTO_REPEAT_#1_069_M", "Dead fish.[w:0.3] Rotten fish.[w:0.3] No.", "死鱼。[w:0.3]腐鱼。[w:0.3]不可。");
            // 你需要质疑的只有自己的资格。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_674_M", "The only thing you have to fear is your own inadequacy.", "汝所当惧者，唯乃不逮耳。");
            // 瞧好了。[w:0.3]我是莱西，[w:0.3]野兽冥刻者。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_387_M", "Behold me.[w:0.3] I am Leshy,[w:0.3] The Scrybe of Beasts.", "观我。[w:0.3]余乃莱西，[w:0.3]兽之司锲也。");
            // 你想取代我，但这个想法实在太可笑了……[w:0.4]你根本算不上什么威胁。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_819_M", "I would consider your ambition to replace me a threat...[w:0.4] If it weren't so laughable.", "汝欲易我，此志若不甚可哂……[w:0.4]则亦足为患。");
            // 你想挑战我，我也乐于接受。[w:0.3]但是首先……
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_163_M", "We share a desire for you to challenge me.[w:0.3] But first...", "余亦欲汝之来角。[w:0.3]然先……");
            // 只有击败我的部下们，你才有资格挑战我。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#1_064_M", "Return to me when my subordinates are defeated.", "俟朕属既败，而后见我。");
            // 你可以先去会会矿工。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#1_080_M", "You may wish to start with The Prospector.", "汝可先自采夫始。");
            // 打败他们所有人，你才有资格挑战我。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#2_110_M", "Return to me when they are all defeated.", "俟彼皆败，而后见我。");
            // 矿工又把他那条恶犬弄丢了……
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#2_847_M", "The Prospector is always losing that infernal hound of his...", "采夫恒失厥恶犬……");
            // 我可能在保险箱里还剩了点肉。密码被矿工随手记在狗的饭碗边上了。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#3_096_M", "I may have left some meat in the safe. The Prospector scrawled the code somewhere by the hound's food bowl.", "余或遗肉于匮中。采夫题厥密数于犬食盂之侧矣。");
            // 给碗里放点肉，狗就会出来了……
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#3_399_M", "A bit of meat in that hound's bowl always draws her out...", "少置肉于彼犬盂中，常能致之出……");
            // 我知道你在想什么。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA2_690_M", "I know what you're thinking.", "余知乃所思。");
            // 不。[w:0.3]这台相机不是我的传奇相机。[w:0.3]我也不用它创造[c:R][shake:0.7]野兽[w:0.25][shake:0.7]卡牌。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA2_650_M", "No.[w:0.3] This is not my legendary camera.[w:0.3] Not the one I used to create [c:R][shake:0.7]Beast[w:0.25][shake:0.7] Cards.", "不。[w:0.3]此非朕名世之影器。[w:0.3]亦非余之所以造[c:R][shake:0.7]兽[w:0.25][shake:0.7]牌者也。");
            // 它只是个复制品。[w:0.3]只能用来拍摄林中野兽的照片。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA2_490_M", "This one is a mere replica.[w:0.3] You may use it to create photos of the beasts in these woods.", "此特摹器耳。[w:0.3]汝可用之以取此林群兽之影。");
            // 我的部下们……[w:0.3]矿工、[w:0.3]钓鱼人[w:0.3]以及猎人……[w:0.3]
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA2_452_M", "My subordinates...[w:0.3] The Prospector,[w:0.3] The Angler,[w:0.3] and The Trapper...[w:0.3]", "朕属……[w:0.3]采夫、[w:0.3]渔父、[w:0.3]猎夫……[w:0.3]");
            // 他们每个人会先向你索取一张照片，然后才会考虑应战。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA2_571_M", "They each require a photo before they will consider battling you.", "彼各须一影，而后肯与尔战。");
            // 啊，[w:0.3]他娘的！[w:0.3]这不是我的[shake:0.8]好丫头嘛！
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_573_M", "Well,[w:0.3] I'll be darned.[w:0.3] That's my [shake:0.8]girl!", "噫，[w:0.3]善其娘矣。[w:0.3]此俺[shake:0.8]爱犬也！");
            // 你可以过去，[w:0.3]去那个什么池塘那儿……
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_372_M", "I'll let ye past me,[w:0.3] and into yonder pond...", "俺将听你过路，[w:0.3]而入彼池……");
            // 但是首先，[w:0.3]他奶奶的，[w:0.3]先和我[w:0.3][c:R][shake:1]打一场！
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_156_M", "But,[w:0.3] dag nab it,[w:0.3] first we gotta[w:0.3][c:R][shake:1] BATTLE!", "然，[w:0.3]彼其老娘，[w:0.3]先当与俺[w:0.3][c:R][shake:1]一战！");
            // 你找着了我的狗，[w:0.3]我很感谢你……
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_REPEAT_#1_576_M", "Ye found my hound.[w:0.3] And I'm grateful 'n all...", "你得俺犬矣。[w:0.3]俺诚感你……");
            // 但是，[w:0.3]他奶奶的，[w:0.3]我们得先[w:0.3][c:R][shake:1]打一场！
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_REPEAT_#1_933_M", "But,[w:0.3] dag nab it,[w:0.3] we just gotta[w:0.3][c:R][shake:1] BATTLE!", "然，[w:0.3]彼其老娘，[w:0.3]你俺须先[w:0.3][c:R][shake:1]一战！");
            // 你这照片不错，我确实得谢谢你……
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_REPEAT_#2_446_M", "I do thank ye for the pretty picture...", "你之嘉影，俺实谢之……");
            // 但是在我放你过去之前……
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_REPEAT_#2_282_M", "But afore I let ye by...", "然于俺听你过路之前……");
            // 他奶奶的，[w:0.3]你可真厉害。
            AddTranslation("GBC_NPC_PROSPECTORNPCGREETING_REPEAT_#3_030_M", "Dag nab it.[w:0.3] Yer stubborn.", "彼其娘也。[w:0.3]你真梗也。");
            // 输了就是输了。[w:0.3]你把我打成狗了。
            AddTranslation("GBC_NPC_PROSPECTORNPCVICTORY_840_M", "Fair's fair.[w:0.3] Ye beat me like a dog.", "理固然也。[w:0.3]你大败俺矣。");
            // 拿着这个。[w:0.3]人家说这几张卡比金子还值！
            AddTranslation("GBC_NPC_PROSPECTORNPCVICTORY_152_M", "Take this.[w:0.3] Some say these here cards are better 'n gold!", "受此。[w:0.3]或曰斯牌贵于金！");
            // 你可以去那个池塘了！
            AddTranslation("GBC_NPC_PROSPECTORNPCVICTORY_REPEAT_#1_961_M", "The way to yonder pond is clear!", "彼池之道通矣！");
            // 真他娘的好看……
            AddTranslation("GBC_NPC_PROSPECTORNPCVICTORY_REPEAT_#2_039_M", "Darn pretty picture...", "彼其娘之佳影哉……");
            // 快滚吧。
            AddTranslation("GBC_NPC_PROSPECTORNPCVICTORY_REPEAT_#3_089_M", "Off with ye.", "去矣。");
            // 你对我的狗不错，我个人其实可以让你过去……[w:0.3]但是规矩就是规矩。
            AddTranslation("GBC_NPC_PROSPECTORNPCDEFEAT_446_M", "I'd let ye by for the kindness ye showed my hound...[w:0.3] But rules 'r rules.", "以你善俺犬之故，俺本可听你之过路……[w:0.3]然法不可废。");
            // 规矩就是规矩。
            AddTranslation("GBC_NPC_PROSPECTORNPCDEFEAT_REPEAT_#1_343_M", "Rules 'r rules.", "法不可废。");
            // 他奶奶的……
            AddTranslation("GBC_NPC_PROSPECTORNPCDEFEAT_REPEAT_#2_859_M", "Dag nab it...", "彼其娘也……");
            // 鱼，谢了。[w:0.3]但[w:0.3]打败我才能通过。
            AddTranslation("GBC_NPC_ANGLERNPCDEFEAT_544_M", "Thank for fish.[w:0.3] But[w:0.3] no pass until beat.", "鱼，谢矣。[w:0.3]然[w:0.3]未败予，不得过。");
            // 打败我，[w:0.3]你才能过。
            AddTranslation("GBC_NPC_ANGLERNPCDEFEAT_REPEAT_#1_566_M", "No pass[w:0.3] until beat.", "未败予，[w:0.3]不得过。");
            // 打败我。[w:0.3]才能过。
            AddTranslation("GBC_NPC_ANGLERNPCDEFEAT_REPEAT_#2_271_M", "No beat.[w:0.3] No pass.", "不胜予。[w:0.3]不得过。");
            // 你赢。[w:0.3]就给你过。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_972_M", "You beat.[w:0.3] You pass.", "女胜。[w:0.3]可过。");
            // 首先，[w:0.3]拿着。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_505_M", "First,[w:0.3] take.", "过前，[w:0.3]受此。");
            // 我？[w:0.3]还要继续。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#1_331_M", "Me?[w:0.3] Work continue.", "予乎？[w:0.3]事犹未已。");
            // 找到莱西要的鱼。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#1_902_M", "Find fish for Leshy.", "为莱西觅鱼。");
            // 莱西要好鱼。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#2_381_M", "Leshy want good fish.", "莱西欲嘉鱼。");
            // 新鲜鱼。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#2_952_M", "Fresh fish.", "鲜鱼。");
            // 损坏的鱼。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#2_081_M", "Corrupted fish.", "败鱼。");
            // 莱西信我。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#3_669_M", "Leshy trust.", "莱西信予。");
            // 我不让他失望。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#3_390_M", "I not disappoint.", "予不负之。");
            // 找到损坏的鱼。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#3_416_M", "Find corrupted fish.", "求得败鱼。");
            // 新鲜的鱼？
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#4_626_M", "Fresh fish?", "鲜鱼乎？");
            // 不。莱西想要损坏的鱼。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#4_429_M", "No. Leshy want corrupted.", "否。莱西欲败鱼。");
            // 我偶尔能找到。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#4_332_M", "I find some time.", "予时或得之。");
            // 总归能找到。
            AddTranslation("GBC_NPC_ANGLERNPCVICTORY_REPEAT_#4_386_M", "Always do.", "常能得之。");
            // 鱼。[w:0.3]新鲜的鱼。[w:0.5]很好。
            AddTranslation("GBC_NPC_ANGLERNPCGREETING_539_M", "Fish.[w:0.3] Fresh fish.[w:0.5] Good.", "鱼。[w:0.3]鲜鱼。[w:0.5]善。");
            // 但是，[w:0.3]必须打败我。
            AddTranslation("GBC_NPC_ANGLERNPCGREETING_723_M", "Still.[w:0.3] Must beat.", "然。[w:0.3]犹须胜我。");
            // 鱼，很好。
            AddTranslation("GBC_NPC_ANGLERNPCGREETING_REPEAT_#2_365_M", "Fish good.", "鱼，嘉。");
            // 你不会[w:0.3]恰好[w:0.6]带着[w:0.2]毛皮吧？
            AddTranslation("GBC_NPC_GBCTRADERNATURETEMPLE_268_M", "You don't[w:0.3] perchance[w:0.6] have any [w:0.2]pelts?", "君得无[w:0.3]适有[w:0.6][w:0.2]裘革乎？");
            // 没有？[w:0.3]真遗憾，[w:0.3]不过，[w:0.3]我也收金属箔片。
            AddTranslation("GBC_NPC_GBCTRADERNATURETEMPLE_608_M", "No?[w:0.3] That is disappointing,[w:0.3] but,[w:0.3] I also accept foils.", "无乎？[w:0.3]可惋也，[w:0.3]然，[w:0.3]箔亦可受。");
            // 还是没有毛皮吗？
            AddTranslation("GBC_NPC_GBCTRADERNATURETEMPLE_REPEAT_#1_187_M", "Still no pelts?", "犹无裘革乎？");
            // 金属箔片也行……[w:0.3]但我还是更想要毛皮。
            AddTranslation("GBC_NPC_GBCTRADERNATURETEMPLE_REPEAT_#2_114_M", "I accept foils...[w:0.3] but you know my preference is pelts.", "箔亦可受……[w:0.3]然君知鄙所好者裘革也。");
            // 有毛皮吗？
            AddTranslation("GBC_NPC_GBCTRADERNATURETEMPLE_REPEAT_#3_206_M", "Pelts?", "裘革乎？");
            // 唉……[w:0.3]用点别的不值钱的通货也行啊……
            AddTranslation("GBC_NPC_GBCTRADERNATURETEMPLE_REPEAT_#3_385_M", "Alas...[w:0.3] We may still deal in lesser currencies...", "嗟……[w:0.3]然亦可以微值之币易之……");
            // 你……[w:0.3]带来了毛皮。[w:0.3]我很高兴。
            AddTranslation("GBC_NPC_TRADERNPCHEADSWITCH_589_M", "You...[w:0.3] have brought a pelt.[w:0.3] I am pleased.", "君……[w:0.3]挟裘革而来。[w:0.3]鄙悦。");
            // 然而剥皮刀转个不停……
            AddTranslation("GBC_NPC_TRADERNPCHEADSWITCH_863_M", "Yet another turn of the skinning knife...", "剥刀又一旋……");
            // 我需要[w:0.3]再设一个陷阱。
            AddTranslation("GBC_NPC_TRADERNPCHEADSWITCH_198_M", "It is time[w:0.3] to set another trap.", "宜[w:0.3]更设一阱矣。");
            // 你身上有野兔血的味道。
            AddTranslation("GBC_NPC_TRAPPERNPCGREETING_045_M", "I smell the hare's blood on you.", "鄙嗅君有兔血之气。");
            // 我设下陷阱，[w:0.3]但只有猎物才能触发陷阱。
            AddTranslation("GBC_NPC_TRAPPERNPCGREETING_REPEAT_#1_023_M", "I set the trap[w:0.3] but only the prey decides when it snaps shut.", "鄙设阱矣，[w:0.3]然何时阖，唯禽自决。");
            // 你闻起来像个猎物。
            AddTranslation("GBC_NPC_TRAPPERNPCGREETING_REPEAT_#2_453_M", "You smell like prey.", "君有禽之气。");
            // *嗅嗅*[w:0.3]*嗅嗅*
            AddTranslation("GBC_NPC_TRAPPERNPCGREETING_REPEAT_#3_252_M", "*sniff*[w:0.3] *sniff*", "*嗅*[w:0.3]*嗅*");
            // 陷阱触发了，[w:0.3]猎物却不见踪影。
            AddTranslation("GBC_NPC_TRAPPERNPCVICTORY_008_M", "The trap has shut,[w:0.3] yet the prey escapes.", "阱已阖矣，[w:0.3]然禽逸。");
            // 猎人等待着他的下一个猎物……
            AddTranslation("GBC_NPC_TRAPPERNPCVICTORY_447_M", "And the trapper waits for the next victim...", "而猎夫俟后至之禽……");
            // 你击败了我们三人。
            AddTranslation("GBC_NPC_TRAPPERNPCVICTORY_403_M", "You've defeated the three of us now.", "今君既胜我三人矣。");
            // 莱西[w:0.3]在等着你。
            AddTranslation("GBC_NPC_TRAPPERNPCVICTORY_155_M", "Leshy[w:0.3] awaits.", "莱西[w:0.3]俟尔至。");
            // 靠近点儿。[w:0.3]我会拿你做一张好皮的。
            AddTranslation("GBC_NPC_TRAPPERNPCDEFEAT_398_M", "Come closer.[w:0.3] You'll make a fine pelt.", "近前。[w:0.3]君足为良革。");
            // 你不适合当猎人。[w:0.3]你更适合当猎物。
            AddTranslation("GBC_NPC_TRAPPERNPCDEFEAT_REPEAT_#1_616_M", "You're not cut out for trapping.[w:0.3] You're better as prey.", "君非设阱之材。[w:0.3]宜为禽耳。");
            // 我会拿你做一张好皮的。
            AddTranslation("GBC_NPC_TRAPPERNPCDEFEAT_REPEAT_#2_944_M", "You'll make a fine pelt.", "君足为良革。");
            // 你已击败疯疯癫癫的[c:R]矿工[c:]、[w:0.3]笨头笨脑的[c:R]钓鱼人[c:]，[w:0.3]以及难以捉摸的[c:R]猎人[c:]……
            AddTranslation("GBC_NPC_LESHYGBCINTRO_622_M", "You had bested the unhinged [c:R]Prospector[c:],[w:0.3] the gormless [c:R]Angler[c:],[w:0.3] the enigmatic [c:R]Trapper[c:]...", "汝已胜狂乱之[c:R]采夫[c:]、[w:0.3]愚蒙之[c:R]渔父[c:]，[w:0.3]与难测之[c:R]猎夫[c:]……");
            // 你现在站在你最强大的对手面前：[w:0.3][shake:0.8][c:R]莱西，[w:0.3]野兽冥刻者[c:]。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_147_M", "You found yourself standing before your ultimate match:[w:0.3][shake:0.8][c:R] Leshy,[w:0.3] Scrybe of Beasts[c:].", "今汝立于至敌之前：[w:0.3][shake:0.8][c:R]莱西，[w:0.3]兽之司锲[c:]。");
            // 你想要取代P03？[w:0.3]很好。[w:0.3]但是[w:0.2]你得先打败我，[w:0.3]才能有这个机会。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_156_M", "Your ambition is to replace P03?[w:0.3] Good.[w:0.3] Though[w:0.2] if you do not defeat me,[w:0.3] you will not get that chance.", "汝志在代鉟〇三乎？[w:0.3]善。[w:0.3]然[w:0.2]不胜我，[w:0.3]则无由焉。");
            // 你就只想打败我？[w:0.3]愚蠢。[w:0.3]就算[w:0.2]你撞了大运，[w:0.2]这次打败了我……
            AddTranslation("GBC_NPC_LESHYGBCINTRO_226_M", "Your ambition is to defeat me?[w:0.3] Foolish.[w:0.3] Even if,[w:0.2] by some odd luck,[w:0.2] you defeat me now...", "汝志但在胜我乎？[w:0.3]愚矣。[w:0.3]纵[w:0.2]偶以幸，[w:0.2]今胜我……");
            // 你[shake:1]还是[w:0.3]需要再击败我一次……[w:0.3]也就是在[c:R]最终对决[c:]中。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_416_M", "You will [shake:1]still[w:0.3] need to defeat me once more...[w:0.3] in the [c:R]Final Duel[c:].", "汝[shake:1]犹[w:0.3]须复胜我……[w:0.3]于[c:R]终角[c:]也。");
            // 到那时[w:0.3]你就更不可能击败我了。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_519_M", "And that[w:0.3] is even more unlikely.", "而彼时[w:0.3]益难矣。");
            // [shake:1]做好准备！[w:0.3]我的兽群不会怜悯你，[w:0.6][shake:1]只会告诉你什么是[w:0.5][shake:1]残酷无情。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_969_M", "[shake:1]Steel yourself![w:0.3] For my beasts will show you no mercy,[w:0.6][shake:1] only[w:0.5][shake:1] fangs.", "[shake:1]自厉！[w:0.3]朕之兽不恕尔，[w:0.6][shake:1]唯[w:0.5][shake:1]啖耳。");
            // 这一次，你能做得更好吗？
            AddTranslation("GBC_NPC_LESHYGBCINTRO_REPEAT_#1_741_M", "Will you fight harder this time?", "此战汝其能更力乎？");
            // 希望这称得上是一个真正的挑战。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_REPEAT_#1_523_M", "I crave a true challenge.", "余渴真敌。");
            // 来吧。[w:0.3]拿出你的真本事吧！
            AddTranslation("GBC_NPC_LESHYGBCINTRO_REPEAT_#2_360_M", "Come now.[w:0.3] Give it an earnest effort!", "来。[w:0.3]尽乃力！");
            // 放马过来吧！
            AddTranslation("GBC_NPC_LESHYGBCINTRO_REPEAT_#3_741_M", "Steel yourself!", "自厉！");
            // 我的兽群仍饥渴难耐。
            AddTranslation("GBC_NPC_LESHYGBCINTRO_REPEAT_#4_100_M", "My beasts are still hungry.", "朕兽犹饥。");
            // 稍等。[w:0.4]在它死前……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSSTATSCARD_472_M", "One moment.[w:0.4] Before that one dies...", "少待。[w:0.4]彼未死前……");
            // 我需要记录下它的[c:R]属性[c:]……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSSTATSCARD_264_M", "I'll need to capture its [c:R]stats[c:]...", "余须录厥[c:R]数[c:]……");
            // 接下来，[w:0.3][c:bR]属性……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSSTATSCARD_REPEAT_#1_741_M", "Next,[w:0.3] [c:bR]stats[c:]...", "次之，[w:0.3]乃[c:bR]数[c:]……");
            // 我得记下这些数字……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSSTATSCARD_REPEAT_#2_415_M", "Let me get those numbers...", "容余录厥数……");
            // 稍等。[w:0.3]我需要[c:bR]属性[c:]……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSSTATSCARD_REPEAT_#3_376_M", "A moment.[w:0.3] I need the [c:bR]stats[c:]...", "少待。[w:0.3]吾须[c:bR]数[c:]……");
            // 我要拍一张照片，看它的召唤[c:R]成本[c:]是什么……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOSTCARD_797_M", "I'll need a photo of that one's [c:R]cost[c:]...", "吾须取厥[c:R]直[c:]之影……");
            // 那[c:R]成本[c:]……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOSTCARD_REPEAT_#1_610_M", "The [c:R]cost[c:]...", "厥[c:R]直[c:]……");
            // 在它死前……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOSTCARD_REPEAT_#2_565_M", "!DELETED!", "于其之未死……");
            // 最后，[w:0.3][c:R]印记[c:]。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSABILITIESCARD_965_M", "And finally,[w:0.3] the [c:R]sigils[c:].", "终者，[w:0.3]乃[c:R]印契[c:]。");
            // 现在只需要[c:R]印记[c:]了……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSABILITIESCARD_REPEAT_#1_040_M", "All we need now is the [c:R]sigils[c:]...", "今所须者，唯[c:R]印契[c:]耳……");
            // [c:R]印记[c:]……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSABILITIESCARD_REPEAT_#2_256_M", "The [c:R]sigils[c:]...", "[c:R]印契[c:]……");
            // 完成了。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOMPLETEDCARD_137_M", "That will do.", "可矣。");
            // 把你死去的卡牌缝合在一起，会凑出绝美的拼图。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOMPLETEDCARD_203_M", "The deaths of your creatures will form a beautiful mosaic.", "乃物之死，将缀成美锦。");
            // 完成了。[w:0.3]请让我稍作准备……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOMPLETEDCARD_REPEAT_#1_855_M", "That will do.[w:0.3] Allow me a moment to prepare...", "可矣。[w:0.3]请容我少备……");
            // 你一定会喜欢的。[w:0.3]虽然我只是缝缝拼拼，但卡牌[w:0.2][shake:0.6]可都来自于你啊。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSDEATHCARDDRAW_152_M", "You must like them.[w:0.3] Though the stitchwork is my own, they[w:0.2][shake:0.6] are your cards.", "汝必悦之。[w:0.3]虽缀缉出朕手，彼[w:0.2][shake:0.6]实为乃牌也。");
            // 现在可以进行测试了。[w:0.3]我的兽群很喜欢换换口味。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSDEATHCARDDRAW_280_M", "Now we put them to the test.[w:0.3] My beasts enjoy a varied diet.", "今试之。[w:0.3]朕兽嗜杂食。");
            // 满意我们的创作吗？
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSDEATHCARDDRAW_REPEAT_#1_092_M", "Are you satisfied with our creations?", "余与汝所造之物，可意乎？");
            // 这些缝合兽[w:0.3]您还满意吗？
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSDEATHCARDDRAW_REPEAT_#2_192_M", "Are these Amalgams[w:0.3] satisfactory?", "此诸合兽[w:0.3]可意乎？");
            // 让我们测试一下吧。[w:0.3]我的兽群很喜欢换换口味。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSDEATHCARDDRAW_REPEAT_#3_559_M", "Let us put them to the test.[w:0.3] My beasts enjoy a varied diet.", "姑试之。[w:0.3]朕兽嗜杂食。");
            // 那些卡牌都没用了。[w:0.3]我有更好的。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSLOSEHAND_981_M", "You won't be needing those.[w:0.3] I have something better.", "彼非汝之所须矣。[w:0.3]余有愈善者。");
            // 这些卡牌都太次了。[w:0.3]换掉它们吧。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSLOSEHAND_REPEAT_#1_537_M", "These are inferior cards.[w:0.3] Let's replace them.", "此皆下牌也。[w:0.3]易之。");
            // 我有更好的。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSLOSEHAND_REPEAT_#2_820_M", "I have something better.", "余有愈善者。");
            // 唔。[w:0.3]我们之前没做出你的死亡卡……[w:0.6]是因为你死掉的卡牌不够多。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSINCOMPLETEDEATHCARD_939_M", "Hm.[w:0.3] We never did finish your deathcard...[w:0.6] There wasn't enough death.", "唔。[w:0.3]乃死牌终未成……[w:0.6]死者未足也。");
            // 希望你不介意我补足空缺。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSINCOMPLETEDEATHCARD_919_M", "I hope you don't mind my filling in the blanks.", "愿汝毋介余之补厥阙。");
            // 这张卡我只好灵活处理了。[w:0.3]因为你死掉的卡牌不够多。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSINCOMPLETEDEATHCARD_REPEAT_#1_245_M", "I had to take some liberties with this one.[w:0.3] There wasn't enough death.", "此牌余不得已，稍自专焉。[w:0.3]死者未足也。");
            // 我得拿出几张我自己的牌才能创造出缝合兽了。[w:0.3]你死掉的卡牌不够多。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSINCOMPLETEDEATHCARD_REPEAT_#2_139_M", "The Amalgams will have a bit of my own cards thrown in.[w:0.3] Not enough of yours perished.", "诸合兽将参以朕牌少许。[w:0.3]乃牌殒者未足也。");
            // 我们之前没做出你的死亡卡……[w:0.6]是因为你死掉的卡牌不够多。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSINCOMPLETEDEATHCARD_REPEAT_#3_052_M", "We never did finish your deathcard...[w:0.6] There wasn't enough death.", "乃死牌终未成……[w:0.6]死者未足也。");
            // 不要怜惜你的卡牌。[w:0.3]它们死了，我的相机才能捕捉它们。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSPHASE1_390_M", "Do not spare your creatures.[w:0.3] My camera is waiting to capture them at the moment of their demise.", "毋舍乃物。[w:0.3]朕影器方俟其之死而取影。");
            // 况且我的兽群还没吃饱呢。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSPHASE1_385_M", "And my beasts are famished.", "且朕兽方饥。");
            // 我的相机已经准备好了。[w:0.3]来点有价值的东西吧。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSPHASE1_REPEAT_#1_310_M", "My camera is poised.[w:0.3] Show me something worthwhile.", "朕影器已张。[w:0.3]示我以可观者。");
            // 我的兽群有新鲜的肉了。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSPHASE1_REPEAT_#2_920_M", "Fresh meat for my beasts.", "鲜肌，可饲朕兽矣。");
            // 想想这次我们能做出什么样的死亡卡吧。
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSPHASE1_REPEAT_#3_421_M", "Think of the deathcard we can create this time.", "念此回何死牌之可成。");
            // 真遗憾。[w:0.3]我还以为你能更强一点。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_795_M", "How utterly disappointing.[w:0.3] I was hoping for a greater challenge.", "甚可惋也。[w:0.3]余方望得强敌。");
            // 这么快就结束了。[w:0.3]唉，[w:0.3]要是我能再让你多撑一会儿就好了。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_114_M", "It was all over so quickly.[w:0.3] Oh,[w:0.3] if I could extend the struggle.", "遽尽矣。[w:0.3]噫，[w:0.3]憾余未得延乃争时。");
            // 因为[w:0.2]你撑的时间越长，打败你时我就越满足。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_374_M", "For the kill[w:0.2] is only as satisfying as the struggle that precedes it.", "盖杀之快，[w:0.2]唯视前争之剧耳。");
            // 哼。[w:0.3]我以为你还能多撑一会儿。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#1_409_M", "Hm.[w:0.3] I had hoped for more of a struggle.", "哼。[w:0.3]余本望汝之争者甚剧。");
            // 你该调整调整你的牌组了。[w:0.3]要么就找点更强力的牌。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#1_511_M", "You may wish to modify your deck.[w:0.3] Or find some better cards.", "汝宜更整乃牌之列。[w:0.3]抑求善牌。");
            // 其他冥刻者也是这么轻易就打败你了吗？
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#2_660_M", "Do you roll over this easily for the other Scrybes?", "汝于他之司锲，亦若是易于败乎？");
            // 想挑战P03，你需要变得更强才行。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#2_028_M", "Perhaps you would fare better against P03.", "若与鉟〇三角，或尚可也。");
            // 等你有了更强的牌组再来找我。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#2_054_M", "Return to me with a more powerful deck.", "以更强之牌列复来见我。");
            // [c:F]你输了，[w:0.3]你已被我，[w:0.2][c:R]野兽冥刻者[c:F]所击败。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#3_132_M", "[c:F]You had failed,[w:0.3] bested by[w:0.2] the [c:R]Scrybe of Beasts[c:F].", "[c:F]汝既败矣，[w:0.3]为[w:0.2][c:R]兽之司锲[c:F]所胜。");
            // 重新调整你的牌组吧。[w:0.3]你的卡牌不配和我的兽群战斗。
            AddTranslation("GBC_NPC_LESHYGBCDEFEATED_REPEAT_#3_699_M", "You may want to reorganize your deck.[w:0.3] It is not equal to the challenge that my beasts present.", "汝宜重整乃牌之列。[w:0.3]不足以当朕兽之角。");
            // 你想要挑战我？[w:0.3]让我看看你的牌组。
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_236_M", "Challenge me?[w:0.3] Let's see your deck.", "欲角我乎？[w:0.3]姑视卿之牌列。");
            // [shake:0.8]太弱了。[w:0.3]牌与牌之间完全没有配合。[w:0.3]这组[w:0.3]牌[w:0.3]在我面前根本没戏。
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_180_M", "[shake:0.8]Weak cards.[w:0.3] Total lack of synergy.[w:0.3] This[w:0.3] pile[w:0.3] really doesn't stand a chance against me.", "[shake:0.8]牌弱。[w:0.3]全不相称。[w:0.3]此[w:0.3]列[w:0.3]牌[w:0.3]于咱前绝无幸。");
            // 听着，[w:0.3]我很想搞定我的管道控制列表。[w:0.3]但生产线上送来的[w:0.2][e:Anger][shake:0.8]机器人[w:0.3]全是垃圾。
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_529_M", "Look,[w:0.3] I'm trying to finish up my conduit control list here.[w:0.3] But the[w:0.2][e:Anger][shake:0.8] bots[w:0.3] they're sending down the line are trash.", "谨闻之，[w:0.3]咱方欲毕咱之渠控序列。[w:0.3]然他等自输途而下之[w:0.2][e:Anger][shake:0.8]机人[w:0.3]皆废弃物。");
            // 让他们给我送来点[e:Anger][shake:0.8][w:0.3]有用的东西。[w:0.3]实在不行，让他们自己躺到生产线上也可以。
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_102_M", "Get those workers to send me something[e:Anger][shake:0.8][w:0.3] good.[w:0.3] Tell them to throw themselves on the line if necessary.", "令他等工徒致我以物[e:Anger][shake:0.8][w:0.3]善者。[w:0.3]若不得已，则使他等自投输途。");
            // 还有，[w:0.3]求你了，[w:0.3]回来时带副强一点的牌组。
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_138_M", "And,[w:0.3] please,[w:0.3] have a decent deck by the time you're done.", "咱且求之，[w:0.3]事毕时，[w:0.3]持一可观之牌列。");
            // [e:Anger][shake:0.8]是[w:0.6][shake:0.8]我[w:0.6][shake:0.8]卡了吗？
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_REPEAT_#1_651_M", "[e:Anger][shake:0.8]Did[w:0.6][shake:0.8] I[w:0.6][shake:0.8] lag?", "[e:Anger][shake:0.8]咱[w:0.6][shake:0.8]滞[w:0.6][shake:0.8]乎？");
            // 去弄清楚他们为什么要给我送这些垃圾下来。
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_REPEAT_#1_300_M", "Figure out why they're sending me trash bots to scan.", "往究其故，何故输我废弃机人以供咱察。");
            // [e:Anger][shake:0.8]是我卡了吗？
            AddTranslation("GBC_NPC_P03GBCTEMPLEINTRO_REPEAT_#2_440_M", "[e:Anger][shake:0.8]Did I lag?", "[e:Anger][shake:0.8]咱滞乎？");
            // [t:0.5]你什么意思。[w:0.5]你想干嘛？
            AddTranslation("GBC_NPC_INSPECTORGREETING_900_M", "[t:0.5]What is it.[w:0.5] What do you want?", "[t:0.5]何事。[w:0.5]你欲何为？");
            // [t:0.5]难道你看不出来此时此刻我是真的真的真的真的真的真的[shake:1][end]
            AddTranslation("GBC_NPC_INSPECTORGREETING_171_M", "[t:0.5]Can't you see that I'm very very very very very very very very very very[shake:1][end]", "[t:0.5]你岂不见我甚甚甚甚甚甚甚甚甚甚[shake:1][end]");
            // [t:0.5]真的[w:0.3]很忙吗？
            AddTranslation("GBC_NPC_INSPECTORGREETING_986_M", "[t:0.5]I'm[w:0.3] very busy here.", "[t:0.5]忙于此乎。");
            // [t:0.5]你说什么？[w:0.4]P03对于我的产出不满意？[w:0.5]可[w:0.3]我不过是个检查员罢了。
            AddTranslation("GBC_NPC_INSPECTORGREETING_233_M", "[t:0.5]What?[w:0.4] P03 isn't happy with my output?[w:0.5] But[w:0.3] I am merely the inspector.", "[t:0.5]何？[w:0.4]鉟〇三不悦我所出者？[w:0.5]然[w:0.3]我但一察者耳。");
            // [t:0.5]如果要质量更好的机器人，我得……
            AddTranslation("GBC_NPC_INSPECTORGREETING_744_M", "[t:0.5]To put better bots on the line I would need to...", "[t:0.5]欲使更善之机人下输途，我则须……");
            // [t:0.5]不过你又是哪位？[w:0.3]给P03跑腿传话的吗？
            AddTranslation("GBC_NPC_INSPECTORGREETING_802_M", "[t:0.5]Just who are you?[w:0.3] To be carrying orders from P03?", "[t:0.5]然你何人也？[w:0.3]乃得衔鉟〇三之命而来？");
            // [t:0.5]只有那些看起来会打牌的人才能得到P03的青睐。
            AddTranslation("GBC_NPC_INSPECTORGREETING_597_M", "[t:0.5]P03 would only trust someone with some semblance of card game skill.", "[t:0.5]鉟〇三所信，唯稍知牌术者耳。");
            // [t:0.5]我是很忙，[w:0.3]但是[w:0.4]我也得确认一下你有没有资格替P03给我传话。
            AddTranslation("GBC_NPC_INSPECTORGREETING_383_M", "[t:0.5]I am very busy.[w:0.3] But[w:0.4] I must know if you are qualified to give me orders.", "[t:0.5]我方甚忙。[w:0.3]然[w:0.4]我须知你有无命我之资。");
            // [t:0.5]很难说你是不是真的够格。
            AddTranslation("GBC_NPC_INSPECTORGREETING_REPEAT_#1_663_M", "[t:0.5]Your qualifications appear dubious.", "[t:0.5]你之资似可疑。");
            // [t:0.5]但让我违背P03直接命令……
            AddTranslation("GBC_NPC_INSPECTORGREETING_REPEAT_#1_283_M", "[t:0.5]But to disobey an order straight from P03's mic...", "[t:0.5]然逆鉟〇三亲命……");
            // [t:0.5]好吧。[w:0.3]又绕回来了。
            AddTranslation("GBC_NPC_INSPECTORGREETING_REPEAT_#1_660_M", "[t:0.5]Very well.[w:0.3] Here we go again.", "[t:0.5]诺。[w:0.3]复如此耳。");
            // [t:0.5]我必须确认一下你是不是[w:0.2]真的[w:0.2]够格。
            AddTranslation("GBC_NPC_INSPECTORGREETING_REPEAT_#2_422_M", "[t:0.5]I suppose I must know if you are[w:0.2] truly[w:0.2] qualified.", "[t:0.5]我想，须知你[w:0.2]诚[w:0.2]有资否。");
            // [t:0.5]你老来分我心，真是越来越麻烦了……
            AddTranslation("GBC_NPC_INSPECTORGREETING_REPEAT_#3_328_M", "[t:0.5]This distraction is becoming troublesome...", "[t:0.5]此扰渐为患矣……");
            // [t:0.5]我早该想到的。[w:0.3]P03怎么可能让你传令呢。
            AddTranslation("GBC_NPC_INSPECTORDEFEAT_805_M", "[t:0.5]P03 would never trust you with direct orders.[w:0.3] I should have known.", "[t:0.5]鉟〇三决不以亲命托你。[w:0.3]我宜早知之。");
            // [t:0.5]真是浪费时间。
            AddTranslation("GBC_NPC_INSPECTORDEFEAT_152_M", "[t:0.5]You have wasted my time.", "[t:0.5]你徒费我时。");
            // [t:0.5]你又[w:0.3]在打扰我的工作。
            AddTranslation("GBC_NPC_INSPECTORDEFEAT_REPEAT_#1_232_M", "[t:0.5]Again[w:0.3] you have pulled me from my work.", "[t:0.5]你又[w:0.3]夺我于我职。");
            // [t:0.5]很多机器人我还没检查就过去了。
            AddTranslation("GBC_NPC_INSPECTORDEFEAT_REPEAT_#1_139_M", "[t:0.5]Many bots have now passed uninspected.", "[t:0.5]今多机人过而未察。");
            // [t:0.5]恐怕现在P03[w:0.3]真的[w:0.3]有得抱怨了。
            AddTranslation("GBC_NPC_INSPECTORDEFEAT_REPEAT_#1_312_M", "[t:0.5]I fear P03 will[w:0.3] actually[w:0.3] have something to complain about now.", "[t:0.5]恐今鉟〇三[w:0.3]诚[w:0.3]有辞矣。");
            // [t:0.5]行吧。[w:0.3]你最好真的是给P03带话的。
            AddTranslation("GBC_NPC_INSPECTORVICTORY_039_M", "[t:0.5]Oh dear.[w:0.3] Your message from P03 must indeed be genuine.", "[t:0.5]噫。[w:0.3]你所衔鉟〇三之言，乃真矣。");
            // [t:0.5]我说过了，[w:0.3]我只是个检查员。[w:0.3]既不是工程师，[w:0.3]也不搞设计。
            AddTranslation("GBC_NPC_INSPECTORVICTORY_006_M", "[t:0.5]As I mentioned,[w:0.3] I am a mere inspector.[w:0.3] Not an engineer,[w:0.3] not a designer.", "[t:0.5]如我所言，[w:0.3]我但一察者耳。[w:0.3]非工师，[w:0.3]非设者。");
            // [t:0.5]我没法送全新的机器人下去。[w:0.3]但是……[w:0.3]我可以把自己送下去。
            AddTranslation("GBC_NPC_INSPECTORVICTORY_220_M", "[t:0.5]I cannot send new bots down the line.[w:0.3] But I...[w:0.3] I can send myself.", "[t:0.5]我不能遣新机人下输途。[w:0.3]然我……[w:0.3]我可自投输途。");
            // [t:0.5]能为P03全心全意地效力是我的荣幸。[w:0.3]很高兴见到你，[w:0.3]陌生人。
            AddTranslation("GBC_NPC_INSPECTORVICTORY_002_M", "[t:0.5]I am proud to have served P03 faithfully.[w:0.3] Well met,[w:0.3] stranger.", "[t:0.5]得忠事鉟〇三，我甚荣之。[w:0.3]幸会，[w:0.3]客子。");
            // [t:0.5][e:Surprise][c:R]让！我！出！去！[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERGREETING_659_M", "[t:0.5][e:Surprise][c:R]LET ME OUT[shake:1][end]", "[t:0.5][e:Surprise][c:R]纵！吾！出！[shake:1][end]");
            // 哈[w:0.2]哈[w:0.3]哈哈哈[w:0.2]哈[w:0.2]哈[w:0.4]呃……[w:0.4]那是什么？
            AddTranslation("GBC_NPC_SMELTERGREETING_468_M", "HA[w:0.2] HA[w:0.3] HAAAA[w:0.2]A[w:0.2]A[w:0.4]a...[w:0.4] What was that?", "呵[w:0.2]呵[w:0.3]呵呵呵[w:0.2]呵[w:0.2]呵[w:0.4]……[w:0.4]彼何声？");
            // 我们是……[w:0.3][shake:0.8]我[w:0.3]是熔炼工。[w:0.3]他们给我送来材料，[w:0.3]然后我……[w:0.3]算了，[w:0.2]你自己看吧。
            AddTranslation("GBC_NPC_SMELTERGREETING_537_M", "We are-[w:0.3][shake:0.8] I[w:0.3] am The Melter.[w:0.3] They send me raw materials and[w:0.3] I-[w:0.3] well,[w:0.2] you can see how it works.", "偶等乃—[w:0.3][shake:0.8]偶[w:0.3]乃冶者。[w:0.3]彼输偶以朴材，而[w:0.3]偶……[w:0.3]已矣，[w:0.2]您自见之。");
            // 给！[w:0.3]我！[w:0.3]闭！嘴！[w:0.3]你[w:0.3][shake:0.8]必须[w:0.2]和我打一把。
            AddTranslation("GBC_NPC_SMELTERGREETING_781_M", "Not another[w:0.3] WORD[w:0.3] out of you![w:0.3] We[w:0.3][shake:0.8] must[w:0.2] have a card battle.", "毋！[w:0.3]复！[w:0.3]一！[w:0.3]言！[w:0.3]您与偶[w:0.3][shake:0.8]必[w:0.2]以牌战。");
            // [t:0.5][e:Surprise][c:R]让！我！出……[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERGREETING_REPEAT_#1_304_M", "[t:0.5][e:Surprise][c:R]LET ME O-[shake:1][end]", "[t:0.5][e:Surprise][c:R]纵！吾！出—[shake:1][end]");
            // 没错，[w:0.3]没错，[w:0.3]再来！
            AddTranslation("GBC_NPC_SMELTERGREETING_REPEAT_#1_932_M", "Yes,[w:0.3] yes,[w:0.3] again!", "然，[w:0.3]然，[w:0.3]复战！");
            // 结束了吗？[w:0.3]你还要继续吗？
            AddTranslation("GBC_NPC_SMELTERGREETING_REPEAT_#2_325_M", "Are we almost done?[w:0.3] You'll keep trying?", "将毕乎？[w:0.3]您犹欲复试乎？");
            // 很好，[w:0.3]非常好。
            AddTranslation("GBC_NPC_SMELTERGREETING_REPEAT_#2_084_M", "Yes,[w:0.3] very well.", "善，[w:0.3]甚善。");
            // [t:0.5][e:Surprise][c:R]帮帮我[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERDEFEAT_969_M", "[t:0.5][e:Surprise][c:R]HELP M[shake:1][end]", "[t:0.5][e:Surprise][c:R]救吾[shake:1][end]");
            // 哦，[w:0.3]真可怜！[w:0.3]你输了！
            AddTranslation("GBC_NPC_SMELTERDEFEAT_080_M", "Oh,[w:0.3] too bad![w:0.3] You lost!", "噫，[w:0.3]可哀！[w:0.3]您败矣！");
            // [t:0.5][e:Surprise][c:R]请帮帮我[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERDEFEAT_050_M", "[t:0.5][e:Surprise][c:R]PLEASE HELP[shake:1][end]", "[t:0.5][e:Surprise][c:R]请救吾[shake:1][end]");
            // 现在请[w:0.3]让我们……[w:0.2]让我[w:0.2][shake:0.8]单独[w:0.3]工作一会儿吧。
            AddTranslation("GBC_NPC_SMELTERDEFEAT_112_M", "Now please,[w:0.3] leave us-[w:0.2] leave [w:0.2][shake:0.8]me[w:0.3] to my work.", "今请[w:0.3]舍偶等—[w:0.2]舍[w:0.2][shake:0.8]偶[w:0.3]治工。");
            // 这可不好，[w:0.3]真可怜。[w:0.3]你得走了。
            AddTranslation("GBC_NPC_SMELTERDEFEAT_REPEAT_#1_884_M", "Too bad,[w:0.3] so sad.[w:0.3] Off with you now.", "惜哉，[w:0.3]可哀。[w:0.3]您当去矣。");
            // 你得走了。
            AddTranslation("GBC_NPC_SMELTERDEFEAT_REPEAT_#2_068_M", "Off with you now.", "当去矣。");
            // 我还有工作要做。
            AddTranslation("GBC_NPC_SMELTERDEFEAT_REPEAT_#2_441_M", "I have work to attend to.", "偶有工当治。");
            // [t:0.5][e:Surprise][c:R]帮帮我[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERVICTORY_933_M", "[t:0.5][e:Surprise][c:R]HELP ME[shake:1][end]", "[t:0.5][e:Surprise][c:R]救吾[shake:1][end]");
            // 打得不错。[w:0.3]现在，[w:0.2]来说说，[w:0.3]你想说什么来着？ 
            AddTranslation("GBC_NPC_SMELTERVICTORY_934_M", "Excellent battle.[w:0.3] Now,[w:0.2] with that aside,[w:0.3] what did you come to tell me? ", "此战善矣。[w:0.3]今，[w:0.2]姑置偶工，[w:0.3]您来告偶何事？");
            // P03希望能有更好的机器人……[w:0.3]这很难。[w:0.3]你也看到了，[w:0.3]我会熔炼金属，[w:0.3]但不会编程。
            AddTranslation("GBC_NPC_SMELTERVICTORY_619_M", "P03 wishes for better bots for his scanner...[w:0.3] That is difficult.[w:0.3] You see...[w:0.3] I melt the metal.[w:0.3] But I cannot reprogram the stamping machine.", "鉟〇三欲为其之省器得益善之机人……[w:0.3]此难矣。[w:0.3]您亦见之……[w:0.3]偶能销金。[w:0.3]然不能更易印机之数。");
            // [t:0.5][e:Surprise][c:R]不！[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERVICTORY_859_M", "[t:0.5][e:Surprise][c:R]NO[shake:1][end]", "[t:0.5][e:Surprise][c:R]弗要！[shake:1][end]");
            // ……[w:0.3]有一个方法，可以送[w:0.3][shake:0.8]新的[w:0.3]机器人下去。
            AddTranslation("GBC_NPC_SMELTERVICTORY_808_M", "...[w:0.3]there is a way to send at least[w:0.3][shake:0.8] one[w:0.3] new bot down the line.", "……[w:0.3]犹有一术，至少可遣[w:0.3][shake:0.8]一[w:0.3]新机人由输途而下。");
            // [t:0.5][e:Surprise][c:R]不不不不！[shake:1][end]
            AddTranslation("GBC_NPC_SMELTERVICTORY_992_M", "[t:0.5][e:Surprise][c:R]NO NO NO NO[shake:1][end]", "[t:0.5][e:Surprise][c:R]弗！弗！弗！弗！[shake:1][end]");
            // [t:0.5]哈哈哈哈！[t:1][w:0.5][shake:1]是的！[w:0.3]为了P03！
            AddTranslation("GBC_NPC_SMELTERVICTORY_379_M", "[t:0.5]HAHAHAHA![t:1][w:0.5][shake:1] YES![w:0.3] FOR P03!", "[t:0.5]哈哈哈哈！[t:1][w:0.5][shake:1]然！[w:0.3]以奉鉟〇三！");
            // 听着，[w:0.3]哥们儿，[w:0.3]我知道你是来干嘛的。
            AddTranslation("GBC_NPC_DREDGERGREETING_650_M", "Oy,[w:0.3] mate.[w:0.3] I know what yer 'ere for.", "噫，[w:0.3]喒兄。[w:0.3]喒知亲何为而来。");
            // 你想让我撂白旗是吧？[w:0.3]
            AddTranslation("GBC_NPC_DREDGERGREETING_162_M", "Yer askin' me to take a dive.[w:0.3]", "亲欲使喒自投耳。[w:0.3]");
            // 这我可做不到哎，哥们儿。[w:0.3]
            AddTranslation("GBC_NPC_DREDGERGREETING_993_M", "But I can't accommodate ye, mate.[w:0.3]", "然喒不可从亲，喒兄。[w:0.3]");
            // 有命令的，[w:0.3]你懂的对吧？[w:0.3]得挖点好货出来。
            AddTranslation("GBC_NPC_DREDGERGREETING_481_M", "Got special orders,[w:0.3] innit?[w:0.3] Lookin' to dredge somefin' special.", "喒有别命，[w:0.3]亲当知之。[w:0.3]方欲浚异物。");
            // 咱俩倒是能斗一场，[w:0.3]是吧。[w:0.3]你赢了没准还能给你点好玩意儿。
            AddTranslation("GBC_NPC_DREDGERGREETING_785_M", "We can duel.[w:0.3] Aye.[w:0.3] Maybe even give ye somefin' if ye win.", "喒可与亲斗。[w:0.3]如此。[w:0.3]亲若胜，或以一物与亲。");
            // 但我可不能服软认怂。[w:0.3]P03绝对懂的。
            AddTranslation("GBC_NPC_DREDGERGREETING_706_M", "But I can't be takin' a dive.[w:0.3] P03 will unnerstan'.", "然喒不可自投。[w:0.3]鉟〇三必谅之。");
            // 嘿，[w:0.3]想再打一次吗？
            AddTranslation("GBC_NPC_DREDGERGREETING_REPEAT_#1_168_M", "Oy,[w:0.3] ye wan't a rematch?", "噫，[w:0.3]亲欲复角乎？");
            // 知道了。
            AddTranslation("GBC_NPC_DREDGERGREETING_REPEAT_#1_213_M", "I unnerstan'.", "喒知之矣。");
            // 你别是以为能鼓动我自己跳生产线上去吧？
            AddTranslation("GBC_NPC_DREDGERGREETING_REPEAT_#2_016_M", "Yer not thinkin' ye can get me to jump?", "亲岂谓能使喒跃上输途乎？");
            // 不管你说啥做啥都没用。
            AddTranslation("GBC_NPC_DREDGERGREETING_REPEAT_#2_467_M", "Nofin' you say or do can change me mind.", "亲言亲行，皆不能移喒志。");
            // 行吧，[w:0.3]行吧。[w:0.3]你走吧。
            AddTranslation("GBC_NPC_DREDGERDEFEAT_891_M", "Right,[w:0.3] right.[w:0.3] Off with ye now.", "然，[w:0.3]然。[w:0.3]亲当去矣。");
            // 你走吧。
            AddTranslation("GBC_NPC_DREDGERDEFEAT_REPEAT_#1_522_M", "Off with ye now.", "今当去矣。");
            // 差不多得了，[w:0.3]哥们儿。
            AddTranslation("GBC_NPC_DREDGERDEFEAT_REPEAT_#2_644_M", "Enough of this now,[w:0.3] mate.", "此足矣，[w:0.3]喒兄。");
            // 真影响人工作，[w:0.3]是吧哥们儿？
            AddTranslation("GBC_NPC_DREDGERDEFEAT_REPEAT_#3_460_M", "Lotta distractions,[w:0.3] eh mate?", "扰喒者甚多矣，[w:0.3]喒兄。");
            // 不是针对你，但是[w:0.3]你的牌组可能还是有点弱。
            AddTranslation("GBC_NPC_DREDGERDEFEAT_REPEAT_#3_688_M", "Nofin' against yer deck but,[w:0.3] might not be up to the task.", "非尤亲之牌列，[w:0.3]然其恐不足任事。");
            // 来来来，[w:0.3]把你东西拿走。
            AddTranslation("GBC_NPC_DREDGERVICTORY_108_M", "'ere.[w:0.3] Take yer pack.", "来。[w:0.3]取亲之牌韬。");
            // 还在找呐？[w:0.3]我已经把东西给你了。
            AddTranslation("GBC_NPC_DREDGERVICTORY_REPEAT_#2_709_M", "Still somefin' yer after?[w:0.3] I gave ye yer pack.", "亲犹有所求乎？[w:0.3]喒已予亲以牌韬。");
            // 赶紧走吧。
            AddTranslation("GBC_NPC_DREDGERVICTORY_REPEAT_#3_843_M", "Geroff.", "亟去。");
            // 机器人质量没什么起色……[w:0.3]你说你已经和我的部下都打过了？[w:0.3]甚至还赢了？
            AddTranslation("GBC_NPC_P03GBCGREETING_080_M", "The bots haven't gotten much better...[w:0.3] But you battled all of my workers?[w:0.3] And you actually won?", "机人犹莠……[w:0.3]然卿与咱诸工徒皆战乎？[w:0.3]而竟胜之乎？");
            // 牌组拿来看看。
            AddTranslation("GBC_NPC_P03GBCGREETING_523_M", "Gimme that deck again.", "复以卿之牌列示我。");
            // 哇哦……[w:0.3]你就是用这个[w:0.4]打败他们的？[w:0.3]好吧。
            AddTranslation("GBC_NPC_P03GBCGREETING_412_M", "Wow...[w:0.3] you beat them with[w:0.4] that?[w:0.3] Alright.", "噫……[w:0.3]卿竟以此[w:0.4]胜之乎？[w:0.3]可。");
            // 也许是我没发现你牌组里的配合。[w:0.3]那我们开始吧。
            AddTranslation("GBC_NPC_P03GBCGREETING_478_M", "Maybe there are some synergies that I missed.[w:0.3] Let's go then.", "或其有相资之势而咱未察。[w:0.3]来战。");
            // 老挖泥工不愿意上生产线？
            AddTranslation("GBC_NPC_P03GBCGREETING_REPEAT_#1_969_M", "The old Dredger wouldn't hop on the line?", "彼老浚夫不肯跃于输途乎？");
            // [shake:0.8][e:Quiet]没关系，没什么大不了的。
            AddTranslation("GBC_NPC_P03GBCGREETING_REPEAT_#1_169_M", "[shake:0.8][e:Quiet]Do not worry. That is acceptable.", "[shake:0.8][e:Quiet]毋忧。是可也。");
            // 再打一场？
            AddTranslation("GBC_NPC_P03GBCGREETING_REPEAT_#1_840_M", "Another battle?", "复战乎？");
            // 还来？
            AddTranslation("GBC_NPC_P03GBCGREETING_REPEAT_#2_257_M", "Again?", "复乎？");
            // 神庙周围的箱子你都打开了对吧？
            AddTranslation("GBC_NPC_P03GBCDEFEAT_243_M", "You opened the crates around the temple right?", "神庙畔之诸匮，卿皆启之矣乎？");
            // 你的卡还不够强。
            AddTranslation("GBC_NPC_P03GBCDEFEAT_739_M", "You need better cards.", "卿须得更善之牌。");
            // 牌烂，[w:0.3]人还菜。
            AddTranslation("GBC_NPC_P03GBCDEFEAT_REPEAT_#1_270_M", "A bad deck[w:0.3] with a bad pilot.", "牌列恶，[w:0.3]御之者亦恶。");
            // 你不会以为这样就能赢吧？[w:0.3]不会吧？
            AddTranslation("GBC_NPC_P03GBCDEFEAT_REPEAT_#1_655_M", "You don't expect to win that way,[w:0.3] do you?", "卿岂谓如是可胜乎？[w:0.3]岂然哉？");
            // 第二轮你就打错了牌，所以你输了。
            AddTranslation("GBC_NPC_P03GBCDEFEAT_REPEAT_#2_738_M", "You made a huge misplay on turn 2 that cost you the game.", "二合之时，卿大昏著，故失此局。");
            // 我看你根本不会分配资源吧。
            AddTranslation("GBC_NPC_P03GBCDEFEAT_REPEAT_#3_593_M", "I think it's your poor resource economy that's killing you.", "咱谓乃资用不善，此卿所以败也。");
            // 还是去……[w:0.3]找点更强的牌吧。
            AddTranslation("GBC_NPC_P03GBCDEFEAT_REPEAT_#4_023_M", "Just...[w:0.3] get better cards.", "但……[w:0.3]求善牌耳。");
            // 我得告诉你，[w:0.3]哥们儿，[w:0.3]我工作的时候必须专心致志。
            AddTranslation("GBC_BATTLE_DREDGERSURRENDER_830_M", "Know what,[w:0.3] mate,[w:0.3] can't take me eyes off me work 'ere.", "告以亲，[w:0.3]喒兄，[w:0.3]喒目不得离此工。");
            // 这个你拿着吧。
            AddTranslation("GBC_BATTLE_DREDGERSURRENDER_939_M", "I'll give ye this 'un.", "喒以此予亲。");
            // 你赶紧走吧，[w:0.2]我得专注。
            AddTranslation("GBC_NPC_DREDGERVICTORY2_701_M", "Now off with ye.[w:0.2] I need'a concentrate.", "今当去矣。[w:0.2]喒须专志。");
            // [c:R][shake:1]嘿！[w:1][c:][w:0.3]那个难道是[w:0.3]……？
            AddTranslation("GBC_NPC_DREDGERVICTORY2_982_M", "[c:R][shake:1]OY![w:1][c:][w:0.3] is that[w:0.3]...?", "[c:R][shake:1]噫！[w:1][c:][w:0.3]彼乃[w:0.3]……？");
            // [c:F][t:1]P03绝对会重赏我的。
            AddTranslation("GBC_NPC_DREDGERVICTORY2_192_M", "[c:F][t:1]P03's gonna reward me BIG for this 'un.", "[c:F][t:1]鉟〇三必以此厚赏喒。");
            // 啊，[w:0.4]扫描仪连上了。[w:0.4]扫描哪张牌好呢……
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERCHOOSE_746_M", "Oh.[w:0.4] Scanner's online.[w:0.4] Which card to scan...", "噫。[w:0.4]省器已作。[w:0.4]当省何牌……");
            // [t:1]开个玩笑。[w:0.3][t:5]当然是扫描属性最好的那张了。
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERCHOOSE_915_M", "[t:1]Just kidding.[w:0.3][t:5] Obviously the one with the best stats.", "[t:1]适才戏耳。[w:0.3][t:5]固直取其数最善者。");
            // 来吧。[w:0.4]把你最强的卡牌拿出来。
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERCHOOSE_REPEAT_#1_741_M", "Scanning time.[w:0.4] Show me your biggest creature.", "省之时至矣。[w:0.4]出卿至强之物。");
            // 可以扫描了。[w:0.3]让我看看……[w:0.3]哪张牌属性最好。
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERCHOOSE_REPEAT_#2_082_M", "Scanner's online.[w:0.3] Let's see...[w:0.3] what has the best stats.", "省器已作。[w:0.3]且视之……[w:0.3]孰数最佳。");
            // 这张的数值还不够好。
            AddTranslation("GBC_BATTLE_P03BOSSSCAN1_088_M", "The stat line could be better.", "其数可更善。");
            // 看来就是这张了……
            AddTranslation("GBC_BATTLE_P03BOSSSCAN1_REPEAT_#1_305_M", "Looks like this is the one...", "观此其是矣……");
            // 这张的数值还不错。
            AddTranslation("GBC_BATTLE_P03BOSSSCAN1_REPEAT_#2_013_M", "Not too bad of a stat line I suppose.", "其数犹未甚恶。");
            // 我本以为你还有更好的牌……
            AddTranslation("GBC_BATTLE_P03BOSSSCAN1_REPEAT_#3_551_M", "I hoped you would have played something better...", "咱望卿之所著更善也……");
            // 该你了。
            AddTranslation("GBC_BATTLE_P03BOSSSCAN2_472_M", "Your move.", "卿之合。");
            // 这张不错。
            AddTranslation("GBC_BATTLE_P03BOSSSCAN2_REPEAT_#1_303_M", "This could work.", "此可用也。");
            // 该你了。
            AddTranslation("GBC_BATTLE_P03BOSSSCAN2_REPEAT_#2_238_M", "Your go.", "卿当行。");
            // [t:1]呃。[w:0.3][t:5]看来我只有一个选择了……
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERNOCHOICE_177_M", "[t:1]Oh.[w:0.3] [t:5]You've only given me one choice...", "[t:1]噫。[w:0.3][t:5]卿徒遗我一择……");
            // 呃。[w:0.3]只有[w:0.3]一张……
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERNOCHOICE_REPEAT_#1_164_M", "Oh.[w:0.3] There's[w:0.3] just one...", "噫。[w:0.3]徒一物……");
            // 可以扫描了！[w:0.3]来看看都有什么卡牌吧？
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERNOCHOICE_REPEAT_#2_769_M", "Scanner's online.[w:0.3] What have we got here?", "省器已作。[w:0.3]此间有何物？");
            // 你就给我一张？
            AddTranslation("GBC_BATTLE_P03BOSSPRESCANNERNOCHOICE_REPEAT_#2_365_M", "You only left me one thing to scan?", "卿徒遗我一物可省乎？");
            // 喔。
            AddTranslation("GBC_BATTLE_P03BOSSSCANNONE_451_M", "Wow.", "噫。");
            // 你这样我根本就没得扫描。
            AddTranslation("GBC_BATTLE_P03BOSSSCANNONE_149_M", "You've left me nothing to scan whatsoever.", "卿竟无一物可使我省。");
            // 哦……[w:0.3]有点不对劲。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_576_M", "Oh...[w:0.3] Something's wrong.", "噫……[w:0.3]有不然者。");
            // 问题出在你的牌组上。[w:0.3]或者[w:0.3]换句话说，[w:0.3]你压根没凑齐一副牌组。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_932_M", "It's your deck.[w:0.3] Or,[w:0.3] rather,[w:0.3] your lack of a valid one.", "病在牌列。[w:0.3]或[w:0.3]毋宁曰，[w:0.3]其实无一合式之牌列。");
            // 你的牌组里有20张卡牌，[w:0.3]对吧？
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_305_M", "You've got 20 cards in it,[w:0.3] right?", "列中有二十牌，[w:0.3]然乎？");
            // 唔……[w:0.3]你的牌组有问题。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#1_673_M", "Hmm.[w:0.3] Your deck isn't right.", "嗯。[w:0.3]彼牌列有异。");
            // 卡牌数量是足够的，[w:0.3]对吧？
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#1_499_M", "You did add enough cards to it,[w:0.3] right?", "已益牌足数于彼列中，[w:0.3]然乎？");
            // 20张就够了。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#1_177_M", "20 should do.", "二十足矣。");
            // 你……[w:0.3]牌组里的卡牌数量不够。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#2_285_M", "You...[w:0.3] don't have enough cards in your deck.", "其……[w:0.3]列中之牌不足。");
            // 牌组里得有20张牌。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#2_323_M", "You need 20.", "须二十牌。");
            // 嗯，[w:0.3]看来现在我们是打不了了。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#3_786_M", "Oh.[w:0.3] Looks like we can't battle now.", "噫，[w:0.3]今不可战矣。");
            // 先解决你牌组里牌不够的问题吧。
            AddTranslation("GBC_NPC_GBCNPCINVALIDDECKDEFAULT_REPEAT_#3_895_M", "You're going to need to get that deck fixed.", "须正彼牌列。");
            // 呃……[w:0.3]不太对劲。
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_488_M", "Arrr..[w:0.3] Something be wrong.", "嚄……有误。");
            // 你的牌组。[w:0.3]没整好啊！
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_133_M", "Yer deck.[w:0.3] T'ain't right.", "汝之牌列。[w:0.3]不然。");
            // 等牌组里够20张牌了再来找我吧！
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_148_M", "Return when ye've got 20 cards in it.", "俟其中有二十牌而后返。");
            // 哎！[w:0.3]你的牌组还是有问题。
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_REPEAT_#1_116_M", "Hark![w:0.3] Yer deck again.", "呔！[w:0.3]汝牌列复有异。");
            // 你加牌进去了，[w:0.3]对吧？
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_REPEAT_#1_891_M", "Ye did add cards to it,[w:0.3] aye?", "汝已益牌于其中，[w:0.3]然乎？");
            // 20张，够了吗？
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_REPEAT_#1_368_M", "20 er so?", "二十乎？");
            // 哎……[w:0.3]你这牌组里牌不够啊。
            AddTranslation("GBC_NPC_GHOULROYALINVALIDDECK_REPEAT_#2_101_M", "Hark...[w:0.3] Ye don't have enough cards in yer deck.", "呔……[w:0.3]汝列中牌不足。");
            // 牌组，有问题。
            AddTranslation("GBC_NPC_ANGLERNPCINVALIDDECK_712_M", "Deck bad.", "牌列恶。");
            // 牌不够。[w:0.3]要20张。
            AddTranslation("GBC_NPC_ANGLERNPCINVALIDDECK_742_M", "Need cards.[w:0.3] 20.", "须牌。[w:0.3]二十。");
            // 妈的。[w:0.3]你这牌组有问题！
            AddTranslation("GBC_NPC_PROSPECTORNPCINVALIDDECK_890_M", "Well darn it all.[w:0.3] Yer deck ain't right!", "娘之。[w:0.3]你牌列有异！");
            // 少说得凑个20张牌啊！
            AddTranslation("GBC_NPC_PROSPECTORNPCINVALIDDECK_467_M", "Git ye at least 20 cards 'n it!", "至少当有二十牌！");
            // 他奶奶的。[w:0.3]你的牌组还是有问题。
            AddTranslation("GBC_NPC_PROSPECTORNPCINVALIDDECK_REPEAT_#1_133_M", "Dag nab it.[w:0.3] Yer deck still ain't right.", "彼其老娘。[w:0.3]你牌列犹有异。");
            // 少说得有20张牌。[w:0.3]少了没法打……
            AddTranslation("GBC_NPC_PROSPECTORNPCINVALIDDECK_REPEAT_#1_006_M", "At least 20 cards 'n it.[w:0.3] That oughtta do...", "其中至少二十牌。[w:0.3]乃可耳……");
            // 你的牌组里卡牌数量不够。[w:0.3]你的牌组，[w:0.1]丢人。
            AddTranslation("GBC_NPC_TRAPPERNPCINVALIDDECK_115_M", "Your deck doesn't have enough cards.[w:0.3] A shame,[w:0.1] that.", "君之牌列牌不足。[w:0.3]君之排列，[w:0.1]可惋也。");
            // 你的牌组……[w:0.3]里面至少需要20张牌。
            AddTranslation("GBC_NPC_TRAPPERNPCINVALIDDECK_REPEAT_#1_472_M", "Your deck...[w:0.3] it needs at least 20 cards.", "君之牌列……[w:0.3]其中至少须二十牌。");
            // 解决一下牌组问题吧。
            AddTranslation("GBC_NPC_TRAPPERNPCINVALIDDECK_REPEAT_#2_496_M", "Fix your deck up.", "正君之牌列。");
            // [t:1]哦不。[w:0.3][c:R][w:1][shake:1]不[w:0.3][shake:1]——[w:0.3][shake:1]——[w:0.3][shake:1]——！[w:0.4][t:0][c:]
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDDECK_513_M", "[t:1]Oh no.[w:0.3] [c:R][w:1][shake:1]N[w:0.3][shake:1]O[w:0.3][shake:1]O[w:0.3][shake:1]O![w:0.4][t:0][c:]", "[t:1]哦不。[w:0.3][c:R][w:1][shake:1]不[w:0.3][shake:1]——[w:0.3][shake:1]——[w:0.3][shake:1]——！[w:0.4][t:0][c:]");
            // [t:1]你的牌组不合格。
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDDECK_429_M", "[t:1]Your deck is invalid.", "[t:1]尔牌列不合。");
            // [t:1]卡牌数量不够。
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDDECK_167_M", "[t:1]You don't have enough cards in it.", "[t:1]尔牌不足。");
            // [t:1]拜托，[w:0.3]处理一下吧！
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDDECK_095_M", "[t:1]Please.[w:0.3] Rectify this!", "[t:1]呜呼，[w:0.3]正之！");
            // [t:1]你的牌组内卡牌不足。
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDDECK_REPEAT_#1_588_M", "[t:1]You don't have enough cards in your deck.", "[t:1]尔牌列中牌不足。");
            // [t:1]拜托，[w:0.3]拜托，[w:0.3]解决一下吧！
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDDECK_REPEAT_#1_921_M", "[t:1]Please.[w:0.3] Please.[w:0.3] Rectify this!", "[t:1]呜呼。[w:0.3]呜呼。[w:0.3]正之！");
            // 不知为何，假人虽一副毫无生气的样子，但仍看起来很失望。
            AddTranslation("GBC_NPC_DUMMYNPCINVALIDDECK_261_M", "Somehow, in its lifelessness, the dummy looks disappointed.", "虽无生气，不知何故，此偶人视之若有憾色。");
            // 牌组内卡牌不足。
            AddTranslation("GBC_NPC_DUMMYNPCINVALIDDECK_035_M", "You don't have enough cards in your deck.", "乃牌列之牌不足。");
            // 哥们儿，你这牌组不成啊。
            AddTranslation("GBC_NPC_DREDGERINVALIDDECK_539_M", "Somefin' wrong with yer deck, mate.", "喒兄，牌列有异。");
            // 一看就知道牌不够。
            AddTranslation("GBC_NPC_DREDGERINVALIDDECK_453_M", "Lackin' a few cards by the look of 'er.", "观牌列，牌缺数。");
            // 哥们儿。牌组里牌不够。
            AddTranslation("GBC_NPC_DREDGERINVALIDDECK_REPEAT_#1_069_M", "Lackin' a few cards in yer deck, mate.", "喒兄，牌数有缺。");
            // 我可没时间和你来这个。
            AddTranslation("GBC_NPC_DREDGERINVALIDDECK_REPEAT_#1_720_M", "I don' 'ave time fer this, mate.", "喒兄，喒无暇及此。");
            // [c:F]你成功了。[w:0.3]你躲过了尖牙利爪。[w:0.2][c:R]野兽冥刻者[w:0.2]被你击败了[w:0.2]…[w:0.2]…
            AddTranslation("GBC_NPC_LESHYGBCVICTORY_674_M", "[c:F]You had triumphed.[w:0.3] Narrowly avoiding tooth and claw,[w:0.2] the [c:R]Scrybe of Beasts[c:F] was defeated[w:0.2].[w:0.2].[w:0.2].", "[c:F]汝克捷。[w:0.3]间不容发，[w:0.2][c:R]兽之司锲[c:F]遂败[w:0.2]…[w:0.2]…[w:0.2]…");
            // [shake:0.7]很难想象你居然打败了我。[w:0.2]我承认，眼下我确实只能认输。
            AddTranslation("GBC_NPC_LESHYGBCVICTORY_931_M", "[shake:0.7]That you were able to defeat me beggars belief.[w:0.2] But now I must yield to you.", "[shake:0.7]汝能败我，诚难信也。[w:0.2]然今余不得不让于汝。");
            // 我唯一的遗憾就是这场战斗结束得太快了。[w:0.2]毕竟，战斗得越久，胜利的滋味就越甜美。
            AddTranslation("GBC_NPC_LESHYGBCVICTORY_429_M", "My only regret is that our battle was so brief.[w:0.2] Surely the summit of victory is made sweeter by a more arduous ascent.", "朕所憾者，唯此战之速耳。[w:0.2]夫登高愈艰，则胜之愈甘。");
            // [c:R]野兽冥刻者[c:F]已被击败[w:0.2]…[w:0.2]…
            AddTranslation("GBC_NPC_LESHYGBCVICTORY_REPEAT_#1_990_M", "The [c:R]Scrybe of Beasts[c:F] was defeated[w:0.2].[w:0.2].[w:0.2].", "[c:R]兽之司锲[c:F]既败[w:0.2]…[w:0.2]…[w:0.2]…");
            // [c:F]那伟大的冥刻者[w:0.3][c:]竟然[c:F][w:0.5]也会被打败。
            AddTranslation("GBC_BATTLE_LESHYBOSSBATTLEDEFEATED_279_M", "[c:F]The great Scrybe was...[w:0.3][c:] incredibly...[c:F][w:0.5] bested.", "[c:F]彼大司锲……[w:0.3][c:]竟……[c:F][w:0.5]为人胜矣……");
            // [c:F]遥远之地中，[w:0.3]一束光[w:0.2]照亮了一座早已被人遗忘的纪念碑。
            AddTranslation("GBC_BATTLE_LESHYBOSSBATTLEDEFEATED_739_M", "[c:F]Far away[w:0.3] a light[w:0.2] enveloped a long forgotten monument.", "[c:F]遥遥之地，[w:0.3]一光[w:0.2]笼久湮之碑。");
            // [e:Anger]哼。[w:0.3]算你走运。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEDEFEATED_466_M", "[e:Anger]Pfft.[w:0.3] Nice luck you had.", "[e:Anger]哼。[w:0.3]卿运佳耳。");
            // [e:Anger]我看我再会打牌恐怕也比不过你的手气壮吧！
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEDEFEATED_948_M", "[e:Anger]I guess playing a perfect game is no match for good RNG.", "咱虽陈牌尽善，终不若卿之运也。");
            // [e:Quiet]哦……[w:0.3]哦，天啊。
            AddTranslation("GBC_BATTLE_GRIMORABOSSBATTLEDEFEATED_163_M", "[e:Quiet]Oh...[w:0.3] Oh dear.", "[e:Quiet]噫……[w:0.3]嗟乎。");
            // 看到那些传送带了吗？[w:0.3]和我工厂里多像啊。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEINTRO_092_M", "You see those conveyor belts?[w:0.3] Just like my factory.", "见那输带乎？[w:0.3]犹如咱之工肆然。");
            // 至少这能考考你会不会给路线定位。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEINTRO_682_M", "At the very least they ought to test your lane positioning.", "亦足试卿之列置之术。");
            // 你先请。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEINTRO_REPEAT_#1_234_M", "You go first.", "卿先。");
            // 你出手吧。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEINTRO_REPEAT_#2_588_M", "You've got the play.", "今卿陈牌。");
            // 准备好了吗？
            AddTranslation("GBC_BATTLE_P03BOSSBATTLEINTRO_REPEAT_#3_643_M", "Ready?", "既备乎？");
            // 学会了吗？[w:0.4]好，[w:0.3]该你了。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLECONVEYORBELTS_918_M", "See how that works?[w:0.4] OK,[w:0.3] your turn.", "知其法乎？[w:0.4]善，[w:0.3]今卿行。");
            // 我过牌。[w:0.3]该你了。
            AddTranslation("GBC_BATTLE_P03BOSSBATTLECONVEYORBELTS_REPEAT_#1_710_M", "I passed.[w:0.3] It's your turn.", "咱过矣。[w:0.3]今卿行。");
            // [e:Anger]看来是你赢了啊。
            AddTranslation("GBC_NPC_P03GBCVICTORY_880_M", "[e:Anger]I guess you won.", "[e:Anger]姑谓卿胜矣。");
            // 你想成为[w:0.3][e:Anger][c:R][shake:1]死亡[w:0.3]冥刻者？[w:0.3][c:]就那个天真的老姑娘吗……[w:0.3]你得再好好想想。
            AddTranslation("GBC_NPC_P03GBCVICTORY_391_M", "Your ambition is to become [w:0.3][e:Anger][c:R]The Scrybe of[w:0.3][shake:1] The Dead?[w:0.3][c:] That naive spinster...[w:0.3] You ought to reconsider.", "卿志在为[w:0.3][e:Anger][c:R][shake:1]死[w:0.3]之司锲乎？[w:0.3][c:]那天真老女……[w:0.3]卿宜更思之。");
            // 你想成为[w:0.3][e:Anger][c:R][shake:1]魔法[w:0.3]冥刻者？[w:0.3][c:]那个老书呆子？[w:0.3]你得再好好想想。
            AddTranslation("GBC_NPC_P03GBCVICTORY_783_M", "Your ambition is to become [w:0.3][e:Anger][c:R]The Scrybe of[w:0.3][shake:1] Magicks?[w:0.3][c:] That old hack.[w:0.3] You ought to reconsider.", "卿志在为[w:0.3][e:Anger][c:R][shake:1]术[w:0.3]之司锲乎？[w:0.3][c:]那老腐儒。[w:0.3]卿宜更思之。");
            // 你想成为[w:0.3][e:Anger][c:R][shake:1]野兽[w:0.3]冥刻者？[w:0.3][c:]和那个软骨头的老顽固一样？[w:0.3]再想想吧。
            AddTranslation("GBC_NPC_P03GBCVICTORY_015_M", "Your ambition is to become [w:0.3][e:Anger][c:R]The Scrybe of[w:0.3][shake:1] Beasts?[w:0.3][c:] That soft-minded stump?[w:0.3] You ought to reconsider.", "卿志在为[w:0.3][e:Anger][c:R][shake:1]兽[w:0.3]之司锲乎？[w:0.3][c:]那软心朽木？[w:0.3]卿更思之。");
            // 你甚至还说要击败我这个冥刻者。
            AddTranslation("GBC_NPC_P03GBCVICTORY_093_M", "And you've even decided that I am the Scrybe you will defeat.", "且卿竟决之欲败我此司锲。");
            // [e:Quiet]说得好像你真有机会似的……
            AddTranslation("GBC_NPC_P03GBCVICTORY_642_M", "[e:Quiet]As if you have a choice...", "[e:Quiet]似卿真有择也……");
            // 哎。[w:0.3]我刚打算离开这个地方。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_616_M", "Woof.[w:0.3] I was just about to call it quits out here.", "呜。[w:0.3]余方欲于此罢手。");
            // 结果[w:0.2]来了[w:0.2]一位[w:0.3][c:R]挑战者[c:]，我该回来工作了。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_139_M", "But now that there's a[w:0.3][c:R] Challenger[c:][w:0.2] in our midst[w:0.2] it's back to work for me.", "然今有一[w:0.3][c:R]角者[c:][w:0.2]在此[w:0.2]，余当复作矣。");
            // 我得把这座桥修好，估计得花个，呃[w:0.2]…[w:0.2]…
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_426_M", "I should be able to get this bridge fixed in[w:0.2].[w:0.2].[w:0.2].", "此桥当可修毕于[w:0.2]…[w:0.2]…[w:0.2]…");
            // [t:1]这么说吧，[w:0.3]等你击败其中一位冥刻者，我也差不多把桥修好了。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_683_M", "[t:1]Full disclosure:[w:0.3] it'll take me exactly as long as it takes you to defeat one of those Scrybes.", "[t:1]姑直言之：[w:0.3]所费之时，正同与汝之败彼诸司锲之一。");
            // 所以，[w:0.3]呃，[w:0.3]你还是等会儿再来吧！
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_104_M", "So,[w:0.3] uh,[w:0.3] come back later!", "故，[w:0.3]咳，[w:0.3]后时复来！");
            // 哎。[w:0.3]休息了这么久，再回来工作可太难适应了。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#1_867_M", "Woof.[w:0.3] It's hard to get back into the swing of things after a long break.", "呜。[w:0.3]久息而复作，殊难得势。");
            // 我得打起精神。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#1_595_M", "Gotta gather that momentum.", "须聚其势。");
            // 嘿，[w:0.3]你看起来像是个会打牌的。[w:0.3]给你说点事儿。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#2_634_M", "Look,[w:0.3] you seem like a fine enough Player.[w:0.3] So I'll fill you in a bit.", "夫，[w:0.3]观汝之颇知此戏。[w:0.3]余姑告尔一二。");
            // 这些冥刻者都疯了，[w:0.3]恨不得铲除彼此而后快。[w:0.3]为了力量不择手段。[w:0.2]这些你都知道吗？
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#2_560_M", "These Scrybes are crazy out here.[w:0.3] Always at each others' necks.[w:0.3] Desperate struggle for power.[w:0.2] You know?", "此间诸司锲皆狂矣。[w:0.3]常相扼吭。[w:0.3]争威甚急。[w:0.2]汝知之乎？");
            // 别管他们了。[w:0.3]你不会想变得和他们一样的。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#2_929_M", "Just stay out of it.[w:0.3] You don't want to end up like them.", "毋与焉。[w:0.3]汝必不欲若诸彼。");
            // 哎。[w:0.3]该回去工作了。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#3_754_M", "Woof.[w:0.3] It's time to get back to work!", "呜。[w:0.3]当复作矣！");
            // 哎。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#4_376_M", "Woof.", "呜。");
            // 请别犯傻，里面没有胶卷。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYNOFILM_622_M", "Please, do not be foolish. There is no film in there.", "请毋愚。其中无影卷。");
            // 我需要那机器。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYNOFILM_376_M", "I will need that.", "此物余尚需之。");
            // 没错，那就是我的传奇相机。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYNOFILM_REPEAT_#1_794_M", "Yes, that is my legendary camera.", "然也，此乃朕名世之影器。");
            // 没有胶卷，它是没法工作的。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYNOFILM_REPEAT_#1_915_M", "And no, it does not function without a loaded film roll.", "且不纳影卷，则此器不行。");
            // 就放在那儿吧。没有胶卷的相机根本没用。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYNOFILM_REPEAT_#2_320_M", "Give that here. It's useless without the film.", "以彼畀我。无影卷，则无用矣。");
            // 你就站在这儿。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYINTRO_382_M", "Stand right there.", "即立于是。");
            // 站在这儿。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYINTRO_REPEAT_#1_549_M", "Stand there.", "立于是。");
            // 就这儿。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYINTRO_REPEAT_#2_541_M", "Right through here.", "即此处。");
            // 挑战者，你赢了。你取得了胜利，祝贺你。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYDEATHCARD_731_M", "You, Challenger, are a champion. And I wish to commemorate your victory.", "角者，汝诚胜者也。余欲志乃胜。");
            // 你赢了，你值得被铭记。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYDEATHCARD_REPEAT_#1_397_M", "You are a champion. And I wish to memorialize you.", "汝诚胜者也。余欲为尔作志。");
            // 我愿铭记你的胜利，因此我想好好做个纪念。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYDEATHCARD_REPEAT_#2_596_M", "I do not wish to forget your victory. And so I would like to prepare a monument to it.", "余不欲忘乃胜，故欲为之作志。");
            // 你值得被铭记，我会不遗余力地做好这个纪念品。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYDEATHCARD_REPEAT_#3_064_M", "You are worthy of a memorial. I will endeavor to fulfill this.", "汝足当此志。余必勉成之。");
            // 嘘……不要失去信心。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_870_M", "Shhh. Do not despair.", "嘘。毋馁。");
            // 你是获胜者。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_405_M", "You are a winner.", "汝为胜者。");
            // 别乱动。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_REPEAT_#1_377_M", "Be still now.", "今且毋动。");
            // 你赢了。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_REPEAT_#1_082_M", "You won.", "汝胜矣。");
            // 请站好。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_REPEAT_#2_975_M", "Stay still for me.", "静立。");
            // 你应该感到自豪。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_REPEAT_#2_639_M", "You should be very proud of yourself.", "汝宜深自荣。");
            // 不要绝望。
            AddTranslation("PART_1_SANCTUM_SANCTUMVICTORYTAKEPHOTO_REPEAT_#3_661_M", "Do not despair.", "毋馁。");
            // 你获得了诡异小屋住民的尊重。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_220_M", "You had won the respect of the strange cabin's inhabitant.", "汝既获诡庐主人之敬。");
            // 战斗带来的兴奋感已经退去，你的身体抖个不停……
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_437_M", "Your body quaked as the adrenaline of the battle subsided...", "战馀之壮气既衰，汝身震栗……");
            // ……最后你感到非常饥饿，毕竟你已经好几天没有吃饭了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_783_M", "...leaving you with a gnawing hunger. You had not eaten for days.", "……而饥火啮心。汝数日未食矣。");
            // 没错吧？
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_265_M", "Is it not so?", "然否？");
            // 击败了小屋的原住民后，你应邀坐下。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_024_M", "Having bested the cabin's inhabitant, you were invited to sit.", "既胜庐主，汝受请而坐。");
            // 伟大[c:bR]冥刻者[c:]的故事将是你的饕餮盛宴。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_427_M", "The great [c:bR]Scrybe[c:] regaled you with his stories.", "大[c:bR]司锲[c:]以其故事飨汝。");
            // 他向你讲述了一个逝去的世界，以及他如何征服了那个世界。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_684_M", "He told you of a world long passed. And of how he had conquered it.", "彼告尔一久湮之古世，又言其何以克定之。");
            // 他还告诉你……他一开始的目的有多么单纯。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_705_M", "Of how... pure his true intentions were.", "又言……其初心何其纯也。");
            // 他……只是希望……
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_006_M", "How... he only wished...", "言……彼唯愿……");
            // 够了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_390_M", "Enough.", "已矣。");
            // 吃吧。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#1_716_M", "Eat.", "即食。");
            // 大战结束后，你的很多造物都被遣散了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_176_M", "After the great battle, your troupe of creatures was disbanded.", "大战既毕，乃群物皆散。");
            // 你不再需要它们了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_181_M", "You had no further need for them.", "汝亦不复需彼。");
            // 现在你身边有朋友相伴。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_364_M", "You were now in the company of a friend.", "今汝得友为侣。");
            // 我所做的一切都是为了你。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_438_M", "I did this all for you, you know.", "余所以为此，皆为尔也。");
            // 吃喝拉撒……这不是生活的意义。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_231_M", "To breathe, to slumber... to eat. This is not life.", "息、寐、食，此非生也。");
            // 杀戮时的紧张感、被征服后的苦楚，这些才是生活。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_430_M", "Life is the thrill of the kill and the woe of the vanquished.", "生者，杀时之栗、败者之苦也。");
            // 现在开始，你才算真的活过。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_168_M", "You have now lived. Truly.", "今而后，汝乃真生矣。");
            // 吃点东西吧。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#2_203_M", "So now you may eat.", "今可以食矣。");
            // 另一位挑战者击败了[c:bR]野兽冥刻者莱西[c:]。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#3_532_M", "Another challenger had bested [c:bR]Leshy, Great Scrybe of Beasts[c:].", "又有一角者，胜[c:bR]兽之大司锲莱西[c:]。");
            // 我担心我们的时代也要落幕了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#3_506_M", "And I fear our time may be drawing to a close.", "余恐朕时垂尽矣。");
            // 看起来我的统治也快到终点了，我也无能为力了……
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#3_109_M", "It seems nothing I do can prolong my reign here...", "莫有为能延此间朕治……");
            // 毕竟[c:bR]你[c:]参与到了这一切中。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#3_024_M", "Since [c:bR]you[c:] got involved.", "因[c:bR]汝[c:]与焉故也。");
            // 啊，你迟早会意识到。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#3_597_M", "Oh, you will see in time.", "噫，久之汝自知。");
            // 你只能顺其自然。
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#3_814_M", "That you should have simply let things be.", "知汝但当任之耳。");
            // 还是那个话题……
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#4_403_M", "Here we are once again...", "又至此矣……");
            // 你还能重来多少次？
            AddTranslation("PART_1_FINALE_VICTORYFEAST1_REPEAT_#4_741_M", "How many more do you have in you?", "汝尚能复几何？");
            // 我不怎么庆祝别人的胜利，也没怎么送过礼物。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_471_M", "I do not celebrate often and I seldom give gifts.", "余不数称庆，亦鲜有赠。");
            // 但是你，挑战者，你值得。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_232_M", "But you, Challenger, you are worthy.", "然汝，角者，堪受之。");
            // 请别客气，放开吃。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_774_M", "Please, do not be polite. Dig in.", "毋辞，尽食之。");
            // 你会喜欢这些食物的。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#1_742_M", "Surely this food will please you.", "此食必悦汝。");
            // 我可是花了不少心思。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#1_255_M", "I took extra care in preparing it.", "余治之甚谨。");
            // 你满意吗？
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#2_231_M", "Are you pleased?", "汝悦乎？");
            // 吃吧。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#2_464_M", "Eat it.", "食之。");
            // 有什么问题吗？
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#3_235_M", "Is there something wrong with it?", "其有何失乎？");
            // 告诉我，怎么才能把这些食物做得更好？
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#3_480_M", "Enlighten me. What would make it better?", "请告我，何以使之益善？");
            // 你吃不惯吗？
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#4_695_M", "Is it not what you are used to?", "非乃所习食乎？");
            // 这在我们这儿算得上是珍馐美食了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST2_REPEAT_#4_345_M", "Around here this is considered a delicacy.", "此间以此为珍馐。");
            // 有什么问题吗？
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_059_M", "Is there something wrong?", "有何失乎？");
            // 你该领取你的奖励了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_821_M", "Your prize awaits.", "乃赏俟尔。");
            // 来吧。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_986_M", "Come with me.", "随我来。");
            // 真的吗？你说这些菜不行？
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_REPEAT_#1_550_M", "Really? This does not meet your standards?", "然乎？此不副乃度乎？");
            // 如果你不喜欢，那就不吃了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_REPEAT_#2_243_M", "If you do not appreciate it, we can move on.", "汝若不嘉之，则可前矣。");
            // 你都拒绝了，那我也没什么好说的了。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_REPEAT_#2_448_M", "I will not dwell on a rejected gift.", "赠既见却，余不复念之。");
            // 我也没指望你会喜欢。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_REPEAT_#3_347_M", "I have come to expect nothing from your kind.", "余于尔等，本无所望。");
            // 如果你不想吃了，那就随我来。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_REPEAT_#3_992_M", "If you do not want it, then come with me.", "汝若不欲之，则随我来。");
            // 你可真没礼貌。
            AddTranslation("PART_1_FINALE_VICTORYFEAST3_REPEAT_#4_234_M", "You've done me a great disrespect.", "汝大慢我矣。");
            // 发完呆没？
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO1_970_M", "You done gawking?", "观毕乎？");
            // 可以开始了吗？
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO1_733_M", "We can start?", "可始乎？");
            // 好。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO1_395_M", "Good.", "善。");
            // 你有赛博毛皮吗？
            AddTranslation("PART_3_MAP_P03TRADER_859_M", "Found any CYBER pelts around here?", "卿于此间得机革乎？");
            // 你到第一个路标了。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINTFIRSTTIME_158_M", "You made it to the first waypoint.", "卿至首楬矣。");
            // 不错。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINTFIRSTTIME_989_M", "Cool.", "可。");
            // 你的物品都充好能了。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_720_M", "Your items are recharged.", "卿之器复充毕矣。");
            // 你在这片区域里摧毁的机器人会保持原状。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_768_M", "Bots that you've destroyed in the area will stay that way.", "卿于此间所毁之机人，将常废矣。");
            // 如果你不小心死了……你就会回到这里。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_524_M", "If and when you do perish... You'll be brought back here.", "卿若亡……则复归于此。");
            // 这套系统十分精致。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_095_M", "It's an elegant system.", "此法甚雅。");
            // 物品已100%充能完毕。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_REPEAT_#1_843_M", "Items 100% charged.", "诸器皆充之满毕。");
            // 机器人生产器已全部离线。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_REPEAT_#1_108_M", "Bot spawners 100% offline.", "机人生枢皆尽废之。");
            // 你的物品都充好能了。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_REPEAT_#2_013_M", "Your items are recharged.", "卿之器复充矣。");
            // 后面那些机器人已经永远离线了。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_REPEAT_#2_826_M", "And those bots back there are permanently offline.", "而后方诸机人，亦永废矣。");
            // 所有物品已启用。机器人生产器全部离线。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_REPEAT_#3_462_M", "Any items are back online. Bots spawners offline.", "诸器皆复用，机人生枢皆废。");
            // 现在。请给我推荐一个具有代表性的文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_509_M", "Now. Do recommend an exemplary file to me.", "今，请荐一可表之牍于我。");
            // 请务必注意文件的[c:bR]大小[c:]。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_279_M", "And do take into account its [c:bR]size.[c:]", "且务计其[c:bR]大小[c:]。");
            // 还有[c:bR]容量[c:]……以及……以及[c:bR]体积[c:]。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_838_M", "Its [c:bR]magnitude[c:]... its- its [c:bR]bulk[c:].", "其[c:bR]巨细[c:]……其—其[c:bR]厚薄[c:]。");
            // 请选择一个文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_REPEAT_#1_206_M", "Again, do choose a file.", "请更择一牍。");
            // 文件体积必须非常非常大。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_REPEAT_#1_613_M", "Its filesize will be paramount.", "牍之大小，最为要也。");
            // 现在请选择一个文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_REPEAT_#2_443_M", "Now, go along and select a file.", "今，且择一牍。");
            // 请记住，这个文件要……足够[c:bR]庞大[c:]……。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_REPEAT_#2_060_M", "Recall that its... [c:bR]vastness[c:]... is your object.", "记其……[c:bR]广大[c:]……乃汝所务也。");
            // 请选一个文件吧，亲爱的。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_REPEAT_#3_841_M", "Choose a file, dear.", "请择一牍，朕友。");
            // 我的判断标准是它的……[c:bR]宽度[c:]。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_REPEAT_#3_358_M", "I will judge it based on its- its [c:bR]girth[c:].", "奴将以其……其[c:bR]广狭[c:]判之。");
            // 这个？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_654_M", "This?", "此乎？");
            // 请教一下，你的硬盘里为什么有[c:bR]这玩意儿[c:]？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_453_M", "Do enlighten me, what was [c:bR]this[c:] doing on your Hard Disk?", "请告我，乃坚盘竟何故见[c:bR]此[c:]？");
            // 这个就算了，换一个吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_957_M", "Think not of it. Let us continue.", "毋念之。且续进。");
            // 嗯？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_REPEAT_#1_392_M", "Hmm?", "噫？");
            // 这是什么？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_REPEAT_#1_751_M", "What's this?", "此何物乎？");
            // 别纠结这个了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_REPEAT_#1_288_M", "Let us not dwell on it.", "毋久论此。");
            // 看起来确实很奇怪。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_REPEAT_#2_661_M", "A strange visage to be certain.", "其容诚异。");
            // 我们继续。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_REPEAT_#2_320_M", "Let us move on past it.", "越此而进。");
            // 奇怪的东西……真的很怪异。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTIMAGEFILE_REPEAT_#3_268_M", "An odd visage... to be certain.", "其容……诚异。");
            // 所以你就让我听噪音是么？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTAUDIOFILE_654_M", "So you've chosen to subject me to this racket?", "汝乃择使奴之闻此喧声乎？");
            // [c:bB]行了。[c:]
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTAUDIOFILE_059_M", "[c:bB]Enough.[c:]", "[c:bB]足矣。[c:]");
            // 你就不能选个更……悦耳一点的声音吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTAUDIOFILE_REPEAT_#1_485_M", "Could you not have chosen... a more agreeable sound?", "汝岂不能择……稍可赏之声乐乎？");
            // 这个……很吵。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTAUDIOFILE_REPEAT_#2_695_M", "This one... is not pleasant.", "此声……殊不宜闻。");
            // 喔，该干正事儿了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPREINTRO_818_M", "Oh look, it's boss time.", "噫，魁战之时至矣。");
            // 正在解压[c:bR]档案保管员.zip[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPREINTRO_251_M", "Unpacking [c:bR]Archivist.zip[c:]...", "惟[c:bR]典牍者.zip[c:]之解……");
            // 正在启用人格矩阵……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPREINTRO_880_M", "Applying personality matrices...", "惟情性矩阵之施……");
            // 正在清理临时文件……好，继续下一项。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPREINTRO_877_M", "Cleaning up some temp files... OK, here we go.", "惟诸暂牍之治……善，行矣。");
            // 正在安装额外着色器……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPREINTRO_REPEAT_#1_160_M", "Installing additional shaders...", "惟影饰之加设……");
            // 即将完成……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPREINTRO_REPEAT_#1_875_M", "Almost ready...", "惟功之垂成……");
            // 啊！你好啊！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_677_M", "Ah! Greetings.", "啊！问乃安。");
            // 要是你有注意到压缩文件的名字，就该知道我就是档案保管员。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_923_M", "If you had not gleaned it from the title of my zip file, I am The Archivist.", "若汝未由朕牍之题知之，奴乃典牍者。");
            // 我一直都想看看你的硬盘里有什么。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_960_M", "I eagerly await the opportunity to explore your Hard Drive.", "奴夙俟得探乃藏牍之坚府。");
            // 我很擅长保管和处理各种文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_496_M", "Files and directories are my speciality you see.", "牍与牍目，皆余所长也。");
            // 啊，又见面了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_REPEAT_#1_957_M", "Ah, we meet again.", "啊，又相见矣。");
            // 你准备好了吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_REPEAT_#1_696_M", "Have you readied yourself for this reunion?", "汝已备此重会乎？");
            // 很好。我们开始吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_REPEAT_#1_224_M", "Excellent. Let us start.", "甚善。其始矣。");
            // 真巧，又见面了！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_REPEAT_#2_365_M", "Another chance encounter!", "又偶遇矣！");
            // 希望这次和第一次一样令人新奇。 
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTINTRO_REPEAT_#2_281_M", "May it be as fresh as our first battle! ", "愿此复战，犹初角之新。");
            // 请选择一个文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_779_M", "Please select a file.", "请择一牍。");
            // 而且还得是特别的文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_420_M", "This one, however, is very special.", "然此牍，当异于常。");
            // 选一个你打心底喜欢的。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_333_M", "Choose a file that is dearest to your heart.", "择乃心所最爱之牍。");
            // 文件的[c:bR]年龄[c:]要够大。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_948_M", "And one that shows [c:bR]age[c:].", "且其[c:bR]年[c:]可见者。");
            // 啊，又到了这个时间。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_REPEAT_#1_451_M", "Ah, it is that time again!", "啊，又及此时矣！");
            // 看来我准备的惊喜没了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_REPEAT_#1_571_M", "I suppose the surprise is now ruined.", "此惊喜今已泄矣。");
            // 请选一个……[c:bR]上了年纪[c:]的文件吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_REPEAT_#1_674_M", "But, please, do pick a file that is... [c:bR]old[c:].", "然请择一牍，其……[c:bR]老[c:]者。");
            // 请记住，这个文件要……足够……[c:bR]成熟[c:]。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_REPEAT_#2_815_M", "Recall that its... [c:bR]maturity[c:]... is your object.", "记之，其……[c:bR]熟[c:]……乃所求也。");
            // 你知道接下来要做什么……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEHOSTAGEFILE_REPEAT_#2_488_M", "You know what comes next...", "后事何若，汝已知之……");
            // 请把这个文件放进卡牌里吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_479_M", "Now, let us place that file in a card.", "今纳此牍于牌中。");
            // 你选的这个文件，不是你[c:bR]最[c:]喜欢的吧？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_608_M", "You didn't choose a file that was [c:bR]TOO[c:] dear, did you?", "汝所择之牍，毋乃[c:bR]甚[c:]爱者乎？");
            // 如果卡牌被摧毁了，[c:bR]硬盘里的这个文件也会被我删除[c:]。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_358_M", "For, if this card dies, I will [c:bR]delete the file from your disk[c:].", "盖此牌若死，奴必[c:bR]削乃藏牍于盘[c:]。");
            // [c:bB]说真的，可别诱惑我做出这样的事。[c:]
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_157_M", "[c:bB]Please, do not tempt me. I am completely serious.[c:]", "[c:bB]请毋诱奴之为此。奴言诚然。[c:]");
            // 来看看你选了什么文件吧？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_261_M", "Shall we see what that looks like?", "其试观之乎？");
            // 文件变成卡牌后会是什么样子呢？我们一起来看看吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_REPEAT_#1_451_M", "How will that look as a card? Let us see.", "为牌之后，其状何如？试观之。");
            // 如果你真的珍惜你的卡牌，就别让它被摧毁！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_REPEAT_#1_325_M", "And, if you value your card, do not let it die!", "且汝若贵此牌，毋使之死！");
            // 我们继续吧……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_REPEAT_#2_879_M", "Let us proceed...", "其续进矣……");
            // 小心点，可别让你的文件被删了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPICKEDHOSTAGE_REPEAT_#2_188_M", "Careful not to lose your file.", "慎毋失乃牍。");
            // [c:bB]不成，你的能量不足。[c:]
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHENERGY_966_M", "[c:bB]No. You don't have the energy.[c:]", "[c:bB]不可。能不足。[c:]");
            // [c:bB]需要[v:1]点能量。你目前只有[v:2]点能量。[c:]
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHENERGY_REPEAT_#1_467_M", "[c:bB]That costs [v:1] energy and you have [v:2].[c:]", "[c:bB]此直[v:1]能，而今唯[v:2]能。[c:]");
            // [c:bB]你还没懂吗？需要[v:1]点能量。你的能量不足。[c:]
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHENERGY_REPEAT_#2_235_M", "[c:bB]Do you still not get it? It costs [v:1] energy and you don't have enough.[c:]", "[c:bB]犹未喻乎？此直[v:1]能，而能不足。[c:]");
            // [c:bB]能量不足，无法使用[v:0]。[c:]
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHENERGY_REPEAT_#3_745_M", "[c:bB]That [v:0] costs more energy than you have.[c:]", "[c:bB][v:0]所须之能，多于既有。[c:]");
            // 哦！[w:0.3]我早就该问了……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTASKFORACCESS_143_M", "Oh![w:0.3] I should have enquired sooner...", "哦！[w:0.3]奴问迟矣……");
            // 你得给我你硬盘的读取权限。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTASKFORACCESS_293_M", "You will need to grant me access to your Hard Drive.", "汝当许奴之得入视乃藏牍之坚府。");
            // 能请你配合一下吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTASKFORACCESS_246_M", "Would you please acquiesce?", "请唯之。");
            // 我向你保证，不会有任何问题的。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTASKFORACCESS_024_M", "I assure you, no harm will come of it.", "奴保之无害。");
            // 我还真没怎么见过这么小的文件！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_166_M", "Such a miniscule file I have scarcely seen!", "微若此牍，奴罕见之！");
            // 居然只占几个[c:bR]字节[c:]？天呐。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_564_M", "Measured in [c:bR]bytes[c:]? My word.", "乃但以[c:bR]字节[c:]计乎？怪哉。");
            // 恐怕这个文件有点太小了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_654_M", "I'm afraid this is too small to register.", "此微甚，恐不足录。");
            // 这文件还能再小点吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_REPEAT_#1_397_M", "This infinitesimal file?", "此至微之牍乎？");
            // 放天平上恐怕动都不会动。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_REPEAT_#1_298_M", "It is not even enough weigh the scales down.", "置之于衡，犹不足以下之。");
            // 哈！这文件真够小的！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_REPEAT_#2_243_M", "Ha! This file is minute!", "哈！此牍甚微！");
            // 它连1点伤害都打不出！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE1_REPEAT_#2_234_M", "It is not worth a single point of damage!", "不直一伤！");
            // 一个小文件……不过我觉得，还算是有点价值。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE2_141_M", "A small file... but, I do suppose, respectable.", "此牍虽小……然亦可观。");
            // 它也就能造成1点攻击力。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE2_289_M", "A single point of damage is what it is worth.", "所直者，唯一伤耳。");
            // 确实是个小文件。不过至少放上天平还是会动的。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE2_REPEAT_#1_006_M", "Diminutive, yes. Yet enough to burden the scales.", "虽小，然足以动衡。");
            // 唔……完全让人提不起兴趣。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE2_REPEAT_#2_479_M", "Hmm. An unexciting specimen.", "唔。无奇之牍耳。");
            // 不过能值最多1点伤害。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE2_REPEAT_#2_422_M", "But worth a single damage to be sure.", "然固足当一伤。");
            // 啊！这个文件有点意思。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE3_782_M", "Hmf! This file demands attention.", "哼！此牍不可略也。");
            // 看起来能值2点伤害。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE3_456_M", "It appears to weigh in at about 2 damage.", "其重殆当二伤。");
            // 不错！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE3_985_M", "Bravo!", "善哉！");
            // 这个文件成功地引起了我的注意。它确实够大。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE3_REPEAT_#1_655_M", "I cannot neglect this file. It surely has girth.", "奴不敢略此牍。其体诚巨。");
            // 选得不错，满足要求。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE3_REPEAT_#2_926_M", "Well chosen. An adequate selection.", "所择善矣，亦足矣。");
            // 我的天！这个文件……简直就是……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE4_662_M", "My word! This file... it is...", "嗟！此牍……真乃……");
            // 简直就是……文件中的巨灵神！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE4_450_M", "I may say... it is colossal!", "可谓……硕大矣！");
            // 太棒了！震天撼地！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE4_REPEAT_#1_667_M", "Magnificent! It is gargantuan!", "伟哉！其大无朋！");
            // 天呐！这文件真是硕大无朋！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE4_REPEAT_#2_757_M", "My word! The staggering size!", "嗟！其大可骇！");
            // 简直是遮天蔽日！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE4_REPEAT_#3_057_M", "It is positively Bunyanesque!", "真有巨人之状！");
            // 我脸红没红？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE4_REPEAT_#3_578_M", "I am blushing.", "奴面赧矣。");
            // 天呐……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE5_990_M", "Words...", "无辞……");
            // 我的天……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE5_441_M", "My words...", "余无辞矣……");
            // 难以描述……
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILESIZE5_665_M", "Cannot describe...", "不可名状……");
            // 就它了！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILEDELETED_384_M", "There it goes!", "去矣！");
            // 希望你已经备份好了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILEDELETED_920_M", "I hope you have backups.", "奴愿汝既副之。");
            // 你备份了吧？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILEDELETED_REPEAT_#1_381_M", "You have backups, right?", "汝有副之乎？");
            // 哎呀！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTFILEDELETED_REPEAT_#3_301_M", "Oops!", "噫！");
            // 这文件昨天才创建出来吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER1_767_M", "Did you create this file yesterday?", "此牍乃昨始作乎？");
            // 说实话，这文件还没长大呢！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER1_034_M", "It is, to be perfectly frank, juvenile!", "直言之，此牍甚稚！");
            // 做成卡牌，最多也就有个1/1的属性了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER1_971_M", "1/1 are the correct stats for this infant file.", "此稚牍，宜1/1之数。");
            // 看不出来这个文件哪里成熟了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER1_REPEAT_#1_781_M", "This file has no maturity whatsoever.", "此牍殊未成也。");
            // 所以做成卡牌后它一定很弱！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER1_REPEAT_#1_002_M", "It will, therefore, be weak!", "故其必弱矣！");
            // 最多有个1/1的数值吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER1_REPEAT_#2_669_M", "This juvenile file can be no more than a 1/1.", "此稚牍，不过1/1耳。");
            // 嗯。这个文件还算是有些年纪。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER2_942_M", "Hm. I suppose this file does show some age.", "唔。此牍盖稍有年矣。");
            // 谈不上有多老，不过我能把它做成一张2/2的卡牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER2_REPEAT_#1_456_M", "Hardly ancient. But I can make it a 2/2.", "未可谓古，然余可为之2/2。");
            // 根据这个文件的年纪，可以做成一张两点力量两点生命的卡牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER2_REPEAT_#2_629_M", "This file's age may award it a power and health of 2.", "以其年，可为2/2之数。");
            // 太棒了！这个文件没白活这么久。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER3_224_M", "Marvelous! This file is not short lived.", "善哉！此牍不夭。");
            // 这个文件随随便便就可以做成一张3/3的卡牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER3_848_M", "A file this mature is easily a 3/3.", "如此老成之牍，易为3/3。");
            // 这张卡很强，3/3的面板。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER3_REPEAT_#1_100_M", "This venerable file is worthy of the stats: 3/3.", "此老牍，宜3/3之数。");
            // 这……这是最古老的文件了吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER4_636_M", "This... this file is most ancient indeed.", "此……此牍诚至古矣。");
            // 它见证过历史。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER4_276_M", "It has seen things.", "其所见多矣。");
            // 只有4/4的面板才配得上这个文件的年纪。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER4_082_M", "A statline of 4/4 is only appropriate for an august file such as this.", "若此耆牍，惟4/4之数足称之。");
            // 天呐。这是最古老的文件了。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER4_REPEAT_#1_944_M", "My word. This file is most venerable.", "嗟。此牍至耆矣。");
            // 4/4的面板才配得上它。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER4_REPEAT_#1_405_M", "A 4/4 for a file so ancient as this one.", "若此古牍，宜4/4。");
            // 别的都不行。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTHOSTAGEPOWER4_REPEAT_#1_768_M", "It could be no other way.", "更无他可。");
            // 好吧，我还以为我能击败你。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPOSTDEFEATED_927_M", "I thought I had you. Oh well.", "奴本谓能得尔。罢矣。");
            // 你的牌组组得不错。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPOSTDEFEATED_421_M", "You've made a few correct deckbuilding decisions, I guess.", "盖汝于牌列之择，数颇得宜。");
            // 运气也不错。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPOSTDEFEATED_759_M", "And you're lucky.", "且汝幸也。");
            // 聪明人在使用物品的时候不会有所顾虑。
            AddTranslation("PART_3_SPECIAL_NODES_UNLOCKITEMTUTORIAL_529_M", "If you're smart you'll use your items liberally.", "卿苟智，当毋吝用卿之器。");
            // 而且各个路标处都可以重新补充物品能量。
            AddTranslation("PART_3_SPECIAL_NODES_UNLOCKITEMTUTORIAL_252_M", "You'll replenish them at a Waypoint, obviously.", "至楬，自可复得补之。");
            // 你真是给我一顿胖揍啊。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_999_M", "You have dealt me a blow.", "汝创我矣。");
            // 你……
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_494_M", "You have...", "汝……");
            // [c:bB]正在重新校正人格矩阵……[c:]
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_442_M", "[c:bB]Recalibrating personality matrix...[c:]", "[c:bB]惟情性矩阵之重校……[c:]");
            // 请务必再想想我提出的策略。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_REPEAT_#1_645_M", "Reconsider my strategy. It is a must.", "朕策，不可不更思。");
            // 打败我，你很高兴吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_REPEAT_#1_332_M", "Defeating me gladly?", "克我而喜乎？");
            // 我不会再信任你了。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_REPEAT_#1_859_M", "You have broken my trust.", "汝负朕信矣。");
            // 我，我得……
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPHASE2_REPEAT_#2_239_M", "I- I must...", "余—余当……");
            // 这是我的朋友。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_180_M", "This is my friend.", "此朕朋也。");
            // 你要拿起相机对着他们。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_521_M", "You will aim them.", "汝将定其向。");
            // 你得拍下照片。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_214_M", "You will produce a photograph.", "汝将取影。");
            // 你也可以不拍，你说了算。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_139_M", "Or, you may decide not to. That is your choice.", "亦可弗取，惟乃所择。");
            // 你可以拍张照片。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_REPEAT_#1_080_M", "You might produce a photograph.", "汝或可取影。");
            // 拍照片对你可能也有好处。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_REPEAT_#1_685_M", "You might benefit from producing a photograph.", "取影或有益于尔。");
            // 我要重新介绍一下我的朋友吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_REPEAT_#2_208_M", "May I reintroduce my friend?", "余可复陈朕朋乎？");
            // 你会出于自己的目的使用它们吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL1_REPEAT_#2_326_M", "May you use them to your own end?", "汝将用之以遂乃志乎？");
            // 我的朋友会记住那张照片的。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL2_904_M", "My friend will remember that photograph.", "朕朋将记彼影。");
            // 我的朋友会允许你使用那台相机的。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL2_766_M", "My friend will allow you to use that photograph.", "朕朋将许尔用彼影。");
            // 什么目的？你回头就知道了。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL2_670_M", "To what end? You will see.", "何所为？汝将见之。");
            // 何时使用？你回头就知道了。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERDRONETUTORIAL2_979_M", "To use when? You will see.", "何时用之？汝将见之。");
            // 下一个头目非常厉害。 
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_886_M", "The next boss is pretty cool. ", "次魁颇妙。");
            // 你得好好想想该怎么打。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_071_M", "You'll actually need to think about your plays.", "卿实须审卿之所陈。");
            // 需要一套全新的打法。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_306_M", "Whole new mechanic.", "须别有新法。");
            // 好吧……我那些文件去哪儿了……
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_893_M", "OK... Where were those files...", "善……彼牍安在……");
            // 正在解压[c:bR]照相师.zip[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_334_M", "Unpacking [c:bR]Photographer.zip[c:]...", "惟[c:bR]取影者.zip[c:]之解……");
            // 正在加载无人机模块……
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_REPEAT_#1_926_M", "Loading drone module...", "惟飞械之枢之载……");
            // 正在编译快照机制脚本……
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERPREINTRO_REPEAT_#2_432_M", "Compiling snapshot mechanic scripts...", "惟留影法牍之编译……");
            // 镜头就是我的手段。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERINTRO_482_M", "The lens is my instrument.", "镜为朕器。");
            // 你也一样。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERINTRO_047_M", "You, as well, are my instrument.", "汝亦朕器也。");
            // 你来瞄准，我来捕捉。
            AddTranslation("PART_3_BOSS_DIALOGUE_PHOTOGRAPHERINTRO_663_M", "You will aim, and I will capture.", "汝指之，余取其影。");
            // 从你的牌组里选一张牌。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOOSECARD_052_M", "Choose a card from your deck.", "择卿牌列之一牌。");
            // 选一张你的卡牌。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOOSECARD_REPEAT_#1_701_M", "Pick one of your cards.", "择卿牌之一。");
            // 挑一张卡。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOOSECARD_REPEAT_#2_603_M", "Choose a card.", "择一牌。");
            // 挑一张。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOOSECARD_REPEAT_#3_103_M", "Pick one.", "择一。");
            // 选一个吧。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOOSECARD_REPEAT_#4_908_M", "Choose one.", "择其一。");
            // 你知道该做什么。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOOSECARD_REPEAT_#5_511_M", "You know what to do.", "卿知所为。");
            // 我看看……
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYTHINKING_109_M", "Let's see...", "且观之……");
            // 我需要看看……
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYTHINKING_REPEAT_#1_596_M", "Let me calibrate...", "待咱齐之……");
            // 都有什么……
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYTHINKING_REPEAT_#2_979_M", "What do we have...", "今有何……");
            // 来吧……
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYTHINKING_REPEAT_#4_721_M", "Here we go...", "行矣……");
            // 一共三个选择，该选哪个不言自明。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOICES_470_M", "3 choices. Pretty obvious which is correct.", "择有三。其孰是，甚明。");
            // 选择一个你希望这张卡牌获得的能力。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOICES_REPEAT_#1_897_M", "Pick an ability you want on this card.", "择所欲加于此牌之印技。");
            // 我知道我会选哪个。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOICES_REPEAT_#2_341_M", "I know what I would choose.", "咱知所当择。");
            // 毕竟正确的选择只有一个。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOICES_REPEAT_#3_347_M", "There's probably only 1 correct answer here.", "此间殆唯一择为是。");
            // 别犯傻，好好选。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCHOICES_REPEAT_#4_006_M", "Don't be stupid. Choose correctly.", "毋愚。择其是者。");
            // 满意吗？
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETED_860_M", "Satisfied?", "足乎？");
            // 可以吗？
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETED_REPEAT_#1_089_M", "Good?", "可乎？");
            // 我可不会选这个……
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETED_REPEAT_#2_768_M", "Not what I would have picked...", "非咱所当择也……");
            // 你确定？好吧。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETED_REPEAT_#3_503_M", "Really? Alright.", "然乎？善。");
            // 你确定吗？
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETED_REPEAT_#4_703_M", "Does that look right?", "视之，其是乎？");
            // 这可不是正确答案。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETED_REPEAT_#5_783_M", "That can't have been correct.", "此必非是。");
            // 没有。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_582_M", "There isn't one.", "无之。");
            // 这个等级哪来的头目。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_515_M", "There's no boss for this level.", "此层无魁。");
            // 那是你的事。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_177_M", "That's your job.", "此乃卿之事。");
            // 现在你知道了。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#1_643_M", "Well now you know.", "今卿知之矣。");
            // 我可没有什么头目。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#1_860_M", "I don't have a boss.", "咱未有魁。");
            // 我们说到哪儿了……
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#1_248_M", "Let's pick up where we left off...", "且续前所未竟……");
            // 你底子不错。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#2_370_M", "You had some good material.", "卿有善材。");
            // 我们可以利用起来。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#2_702_M", "We can work with it.", "可因之而作。");
            // 虽然这些机制尚有不足之处……
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#2_094_M", "Though the mechanics left something to be desired...", "然其法犹未尽善……");
            // 我们说到哪儿了……
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPREINTRO_REPEAT_#3_957_M", "Where were we...", "前言至何……");
            // 那是你的事。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASINTRO_731_M", "That is your job.", "此乃卿之事。");
            // 求求你。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSEFACE1_558_M", "Please.", "乞请。");
            // 给我画张脸吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSEFACE1_300_M", "Paint me a face.", "为我画面。");
            // 哈！我活了！
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSEFACE2_509_M", "Gah! I am born!", "噫！吾生矣！");
            // 我感觉我都能呼吸了。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSEFACE2_391_M", "I feel as though I can breathe now.", "吾今若可息矣。");
            // 还有一件事……我需要一种特殊的力量。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_256_M", "Another thing... I will need a special power.", "更有一事……吾须一殊能。");
            // 一个能让我说了算的游戏规则。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_193_M", "A game rule to call my own.", "须朕局之一则。");
            // 看在你给我画了一张这么好看的脸的份上，求求你……
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_315_M", "You painted me such a beautiful face so, please...", "子既为我画此美面，更乞请……");
            // 游戏开发是一个反反复复、改来改去的过程。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#1_735_M", "Game development is an iterative process.", "为局之道，在反覆更定。");
            // 我不确定那最后一条规则是不是依然适用……
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#1_461_M", "I'm not sure if the last rule was really working...", "吾未审前则之果行……");
            // 也许我们可以换个方式？
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#1_876_M", "Maybe we can try something else?", "其试他术乎？");
            // 我们试试别的方法吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#2_937_M", "Let's just try something different this time.", "今姑试异术。");
            // 我感觉事情要变得有趣起来了。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#3_715_M", "I think we're arriving at something interesting.", "吾谓渐有可观者矣。");
            // 也许再迭代几次就行了？
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#3_132_M", "Perhaps just a few more iterations?", "或更反覆数度乎？");
            // 我敢说一定能找到完美的机制。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE1_REPEAT_#4_351_M", "We will find the perfect mechanic. I'm sure of it.", "终必得尽善之法，吾信之。");
            // 很好，这样应该就行了。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE2_895_M", "Good. This could work.", "善。此或可行。");
            // 看看效果如何。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE2_219_M", "Let's see how this plays out.", "且观其效如何。");
            // 感觉不错。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE2_REPEAT_#1_417_M", "I feel good about this one.", "此者，呜以为善。");
            // 也许能行。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSERULE2_REPEAT_#2_459_M", "That could work this time.", "今或可行。");
            // 你给第一阶段选了个不错的机制。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2START_710_M", "You picked such a cool mechanic for Phase 1.", "子择此妙法于第一之阶段，甚善。");
            // 我觉得我们得再详细了解一下设计过程。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2START_591_M", "I think we should elaborate on that design process.", "吾谓当更陈其制之序。");
            // 我们再试一次吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2START_REPEAT_#1_261_M", "Let's try this again.", "更试之。");
            // 毫无疑问，这挺耗脑子的。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2END_868_M", "It will take some thought, no doubt.", "无疑，此须深思。");
            // 但我能预见到你都有些什么点子。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2END_206_M", "But I anticipate your many design ideas.", "然吾逆知乃繁制意。");
            // 我知道你有什么点子！
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2END_REPEAT_#1_441_M", "I anticipate your ideas!", "吾已逆知乃意矣！");
            // 这会很有意思的。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2END_REPEAT_#2_466_M", "This could get interesting.", "此将可观。");
            // 我们可以一起打造出完美的头目。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASPHASE2END_REPEAT_#3_431_M", "Together we will create the perfect boss.", "吾将与子共成至善之魁。");
            // 停。你得先做出承诺才能通过。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_886_M", "Halt. We require a commitment to pass.", "止。欲过，必先有诺。");
            // 你必须同意给[c:bR]档案保管员[c:]提供[c:bR]读取权限[c:]。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_201_M", "You must agree to grant [c:bR]ACCESS[c:] to [c:bR]The Archivist[c:].", "汝必诺，许[c:bR]典牍者[c:]得[c:bR]启牍[c:]之权。");
            // 你是否愿意提供[c:bR]读取权限[c:]？这很关键。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_763_M", "Do you agree to grant [c:bR]ACCESS[c:]? It is important.", "汝肯许[c:bR]启牍[c:]乎？此重矣。");
            // 你必须签订此协议。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_146_M", "You must sign this contract.", "汝必书名于此契。");
            // 哦，看来你没法签。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_071_M", "Oh. You cannot sign this contract.", "噫。汝不能书名于此契。");
            // 你没有书写工具。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_123_M", "You do not have a writing utensil.", "汝无书具。");
            // 你无法签订协议。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_REPEAT_#1_414_M", "You have no means to sign our contract.", "汝无以书此契。");
            // 签在虚线处即可……
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_REPEAT_#2_210_M", "Just sign on the dotted line...", "但书名于点画之处耳……");
            // 哦，你签不了。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_REPEAT_#2_204_M", "Oh. You cannot.", "噫。汝不能也。");
            // 你没有笔。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANS_REPEAT_#3_050_M", "You have no quill.", "汝无羽笔。");
            // 你带来的笔不错。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANSQUILL_926_M", "You have brought a fine Quill.", "汝所携羽笔，嘉矣。");
            // 请于此处签名以提供[c:bR]读取权限[c:]。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANSQUILL_275_M", "Please sign here that you agree to give [c:bR]ACCESS[c:].", "请书名于此，以许[c:bR]启牍[c:]。");
            // 非常感谢。请务必牢记协议内容。
            AddTranslation("PART_3_MAP_HOLOMAPLIBRARIANSQUILL_107_M", "Thank you. Do not forget your agreement.", "谢矣。毋忘乃诺。");
            // 你正站在诡异小屋的门外，我给你一个机会。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALSTART_903_M", "Steps away from the strange cabin, you were presented with an opportunity.", "去怪庐数武，汝忽遇一机。");
            // 不是每个冒险者都能获得我的[c:bR]奖励[c:]。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALSTART_010_M", "I don't offer my [c:bR]boons[c:] to just any traveller.", "余不轻以[c:bR]惠[c:]予行客。");
            // 但如果你能通过我的试炼，你将会得到我的重赏。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALSTART_136_M", "If you are able to pass my trials, you will be rewarded mightily.", "若汝能过朕诸试，余必厚赏于尔。");
            // 机会难得。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALSTART_REPEAT_#1_097_M", "A rare opportunity arose.", "良机忽至。");
            // 莱西森林的[c:bR]奖励[c:]在等着你。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALSTART_REPEAT_#1_055_M", "The great [c:bR]boons[c:] of Leshy's woods were on offer.", "莱西之林，大[c:bR]惠[c:]以待。");
            // 你能获得我的[c:bR]奖励[c:]吗，旅行者？
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALSTART_REPEAT_#2_898_M", "Will you earn my [c:bR]boons[c:], traveller?", "行客，汝能得朕[c:bR]惠[c:]乎？");
            // 感受我曾经的荣耀。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFHOSTCHOSEN_848_M", "A taste of my former glory.", "聊见朕昔荣。");
            // 明智。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFHOSTCHOSEN_REPEAT_#3_947_M", "Very wise.", "善哉。");
            // 咳咳。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICEPOSITIVE_826_M", "Ahem.", "咳。");
            // 悉听尊便。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICEPOSITIVE_REPEAT_#1_521_M", "I am at your service.", "余听乃命。");
            // 为您效劳。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICEPOSITIVE_REPEAT_#3_179_M", "I am yours.", "余唯乃命。");
            // 做出你明智的选择吧。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICEPOSITIVE_REPEAT_#4_731_M", "Select wisely.", "慎择之。");
            // 遵命。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICENEGATIVE_547_M", "If you must.", "若必尔。");
            // 就这样吧。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICENEGATIVE_REPEAT_#1_929_M", "If it must be.", "既必尔。");
            // 唉……
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICENEGATIVE_REPEAT_#2_195_M", "Alas...", "噫……");
            // 你已做出了选择。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFSELECTIONCHOICENEGATIVE_REPEAT_#4_724_M", "It is your choice.", "此乃择。");
            // 祝你好运。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDECKTRIAL_027_M", "I wish you luck.", "愿汝吉。");
            // 祈祷你能获得成功。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDECKTRIAL_REPEAT_#2_765_M", "Prithee succeed.", "惟愿汝成。");
            // 愿你成功。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFDECKTRIAL_REPEAT_#3_139_M", "May you succeed.", "愿汝克之。");
            // 再见。
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFCARDREMOVE_REPEAT_#2_952_M", "Goodbye.", "后会。");
            // 他已经完全疯了。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATINTRO2_282_M", "He's completely insane.[w:0.2]", "他狂已甚。[w:0.2]");
            // [anim:sly]你都瞧见了，[w:0.2]对吧？[w:0.2]
            AddTranslation("TALKING_CARDS_STOATINTRO2_715_M", "[anim:sly]You see that,[w:0.2] right?[w:0.2]", "[anim:sly]卿见之矣，[w:0.2]然乎？[w:0.2]");
            // [anim:]完全不管规则。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATINTRO2_938_M", "[anim:]No care for the rules.[w:0.2]", "[anim:]全然不顾其则。[w:0.2]");
            // 可怜，[w:0.2]真可怜。[leshy:停止。][w:2]
            AddTranslation("TALKING_CARDS_STOATINTRO2_924_M", "Pathetic,[w:0.2] really.[leshy:Enough.][w:2]", "可哀，[w:0.2]甚矣。[leshy:汝止。][w:2]");
            // 把我留在这
            AddTranslation("TALKING_CARDS_STOATINTRO2_724_M", "Only keeps me around", "他徒留我于侧");
            // 只是为了看我受苦。
            AddTranslation("TALKING_CARDS_STOATINTRO2_659_M", "to watch me suffer.", "以观咱之受苦。");
            // [anim:sly]奇怪……[w:0.3]
            AddTranslation("TALKING_CARDS_STINKBUGINTRO2_162_M", "[anim:sly]So strange...[w:0.3]", "[anim:sly]异哉……[w:0.3]");
            // 为什么我想不起来
            AddTranslation("TALKING_CARDS_STINKBUGINTRO2_383_M", "Why can't I", "何故奴不复");
            // 他的名字了？
            AddTranslation("TALKING_CARDS_STINKBUGINTRO2_648_M", "remember his name?", "识厥名乎？");
            // [anim:]我觉得[w:0.3]我可能 
            AddTranslation("TALKING_CARDS_STINKBUGINTRO2_881_M", "[anim:]I believe[w:0.3] I lost ", "[anim:]奴意[w:0.3]盖奴之既失");
            // 丢失了一部分记忆……[w:0.3]
            AddTranslation("TALKING_CARDS_STINKBUGINTRO2_454_M", "some of my memory...[w:0.3]", "朕识之一二……[w:0.3]");
            // ……是“闪烁”造成的。
            AddTranslation("TALKING_CARDS_STINKBUGINTRO2_676_M", "in The Flash.", "于“影烁”。");
            // 看。[w:0.4]
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_058_M", "Look.[w:0.4]", "视之。[w:0.4]");
            // [anim:sly]还有[w:0.3]第三张
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_539_M", "[anim:sly]There's[w:0.3] a third", "[anim:sly]此间[w:0.3]尚有第三张");
            // 会说话的卡牌
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_391_M", "talking card somewhere", "能言之牌");
            // 就在这附近。
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_703_M", "around here.", "于此左右。");
            // 我[w:0.2]
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_880_M", "Personally[w:0.2]", "于私[w:0.2]");
            // 很讨厌那家伙。[w:0.4]
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_196_M", "I hate the guy.[w:0.4]", "咱恶那人。[w:0.4]");
            // 有史以来[w:0.2]最扫兴的[w:0.2]家伙。[w:0.4]
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_054_M", "Biggest[w:0.2] killjoy[w:0.2] ever.[w:0.4]", "最[w:0.2]败兴之徒[w:0.2]也。[w:0.4]");
            // 但也只有他
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_789_M", "But he's the only", "然他独");
            // 手里有计划
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_733_M", "one of us with a plan", "为咱等中有策者");
            // 能让这一切……[w:0.3]
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_784_M", "to get things...[w:0.3]", "能使此事……[w:0.3]");
            // ……重回正轨……
            AddTranslation("TALKING_CARDS_STOATFINDWOLFINSTRUCTION_381_M", "...back to normal...", "……复其常……");
            // [shake:0.5]我应该感谢你。
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_362", "[shake:0.5]I ought to thank you.", "[shake:0.5]吾当谢尔。");
            // 情况如何？
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_592", "How has it been?", "别来何如？");
            // [w:0.3][t:0.5]一直[w:0.3]以来[w:0.4]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_864", "[w:0.3][t:0.5]It has[w:0.3] been[w:0.4]", "[w:0.3][t:0.5]其状[w:0.3]素[w:0.4]");
            // 都很[shake:0.5][w:0.4]糟。[w:0.2]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_522", "quite[shake:0.5][w:0.4] bad.[w:0.2]", "甚[shake:0.5][w:0.4]恶。[w:0.2]");
            // 我被困在[w:0.4]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_212", "I am trapped[w:0.4]", "咱见囚[w:0.4]");
            // 这个 
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_050", "in the ", "于此");
            // [shake:0.5]顶着白鼬躯体的[w:0.4]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_396", "[shake:0.5]body of a stoat[w:0.4]", "[shake:0.5]白鼬之躯[w:0.4]");
            // [shake:0.5]纸质卡牌之中。[w:0.4]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_298", "[shake:0.5]paper of a card.[w:0.4]", "[shake:0.5]之牌纸。[w:0.4]");
            // 我意识到了这一切。[w:0.5]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_244", "I see that.[w:0.5]", "吾见之矣。[w:0.5]");
            // 我当然也
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_672", "And I have of course", "而吾固亦");
            // 想过办法来[w:0.4]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_120", "set up a way to reset[w:0.4]", "已设重整之术[w:0.4]");
            // 重置这一切。[w:0.5]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_782", "once more.[w:0.5]", "以复之。[w:0.5]");
            // [anim:sly]继续说……[w:0.3]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_555", "[anim:sly]Go on...[w:0.3]", "[anim:sly]续言之……[w:0.3]");
            // 我的牌手朋友……
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_482", "Our Player friend here...", "此间牌手……");
            // 他们已经……
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_357", "They already hold...", "其已执……");
            // 取得了钥匙……[w:0.5]
            AddTranslation("TALKING_CARDS_STOATWOLFREUNITE_397", "the key...[w:0.5]", "其钥……[w:0.5]");
            // 看来你找到了
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_540_M", "So you found", "然则汝已得");
            // 弱狼。[w:0.4]
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_203_M", "the Stunted Wolf.[w:0.4]", "残狼矣。[w:0.4]");
            // 我目睹这一切的终结
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_185_M", "I have seen this", "此局之终");
            // 已经有太多太多次，
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_460_M", "play out enough times", "吾见之已多，");
            // 所以我知道有个计划
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_466_M", "to know that a plan", "故知有策");
            // 已经在实施中了。[w:0.4]
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_538_M", "is in motion.[w:0.4]", "方行矣。[w:0.4]");
            // [anim:shock]加快速度吧。
            AddTranslation("TALKING_CARDS_STINKBUGAFTERFOUNDWOLF_267_M", "[anim:shock]Make haste.", "[anim:shock]速之。");
            // 我希望你做好了万全的准备。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSINTRO1_165_M", "I hope you are adequately prepared.", "愿汝已备周矣。");
            // 啊，我会享受这一刻的……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSINTRO1_REPEAT_#1_419_M", "Oh, how I relish this moment...", "噫，余甚乐此时……");
            // 这将是你最后的试炼。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSINTRO1_REPEAT_#2_539_M", "This will be your final test.", "此乃终试。");
            // 末日将至。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSINTRO1_REPEAT_#3_244_M", "The end is upon us.", "终局至矣。");
            // 也许……我们还需要一盏烛火，以求万无一失。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSADDCANDLE_538_M", "Perhaps... One more. To be safe.", "或……更一烛，以求无失。");
            // 两盏是不够的。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSADDCANDLE_REPEAT_#1_734_M", "Two flames will not suffice this time.", "此番二焰不足。");
            // 还需要一盏烛火……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSADDCANDLE_REPEAT_#2_470_M", "Another flame...", "更一焰……");
            // 是的……还需要一盏。以求万无一失。
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSADDCANDLE_REPEAT_#3_379_M", "Yes... one more. To be safe.", "然……更一焰，以求无失。");
            // 我拿到了所有图腾的头部，这都要感谢你。[c:bR]木雕师[c:]会帮我们的。
            AddTranslation("PART_1_CABIN_SQUIRRELHEADDISCOVERED_422_M", "And I thought I had all the totem heads together. My thanks. The [c:bR]Woodcarver[c:] will offer this now.", "余本谓神偶诸首已集。谢矣。今[c:bR]刻木妪[c:]将出此物。");
            // 只有见到……[c:bR]她……[c:]这个木雕才有意义。
            AddTranslation("PART_1_CABIN_SQUIRRELHEADDISCOVERED_876_M", "Without having met... [c:bR]her...[c:] this wood carving is meaningless.", "未遇……[c:bR]彼妇……[c:]则此木刻无所用。");
            // 你迟早会了解它所蕴含的力量。
            AddTranslation("PART_1_CABIN_SQUIRRELHEADDISCOVERED_198_M", "In time you will understand its power.", "他日汝自知其威。");
            // 那老太婆收集起自己的作品，把它们匆匆扫入黑暗之中。
            AddTranslation("SPECIAL_NODES_WOODCARVEROUTRO_885_M", "The old woman collected her pieces and shuffled off into the darkness.", "老妪敛其诸刻，蹒跚入冥。");
            // 你俯下身，捡起她给你的东西。
            AddTranslation("SPECIAL_NODES_WOODCARVEROUTRO_REPEAT_#1_246_M", "You hunched down to place her offering in your pack.", "汝俯，以其所赠纳诸囊。");
            // 你再次抬起头时，这位老妇人早已不见了踪影。
            AddTranslation("SPECIAL_NODES_WOODCARVEROUTRO_REPEAT_#1_762_M", "When you looked up again, the ancient woman had vanished.", "及汝复举首，彼老妪已灭迹矣。");
            // 这位满头银发的妇人默默收起她的作品后便离开了。
            AddTranslation("SPECIAL_NODES_WOODCARVEROUTRO_REPEAT_#2_818_M", "The gray-haired woman silently collected her carvings and left.", "皓发之妇默敛其刻而去。");
            // [c:bR]木雕师[c:]一言不发地离开了。
            AddTranslation("SPECIAL_NODES_WOODCARVEROUTRO_REPEAT_#3_919_M", "Without another word, [c:bR]the woodcarver[c:] was gone.", "[c:bR]刻木妪[c:]不复一言而逝。");
            // 你没有贡品要献上？
            AddTranslation("GBC_NPC_BONELORDCASKET_672_M", "You have no offering?", "汝无所献乎？");
            // 唔……[w:0.3]这场战斗的第二阶段什么都没发生？
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_704_M", "!DELETED!", "噫……无事现于此战第二之阶段？");
            // 这肯定是个测试什么的……
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_084_M", "!DELETED!", "此战必为试测。");
            // 啊……你的死期已至。
            AddTranslation("_OPPONENTBLOWOUTLASTCANDLE_911_M", "Alas... It is time for you to perish.", "噫……乃死期至矣。");
            // 你无路可走了。
            AddTranslation("_OPPONENTBLOWOUTLASTCANDLE_REPEAT_#1_182_M", "You're at the end of your rope.", "汝穷矣。");
            // 真可怜。
            AddTranslation("_OPPONENTBLOWOUTLASTCANDLE_REPEAT_#2_883_M", "What a shame.", "惜哉。");
            // 是时候送你上路了。
            AddTranslation("_OPPONENTBLOWOUTLASTCANDLE_REPEAT_#3_399_M", "It's almost time to die.", "汝将死矣。");
            // 你走得够远了。
            AddTranslation("_OPPONENTBLOWOUTLASTCANDLE_REPEAT_#4_023_M", "You made it so far.", "汝已行至此。");
            // 悲哀。
            AddTranslation("_OPPONENTBLOWOUTLASTCANDLE_REPEAT_#5_199_M", "Tragic.", "悲哉。");
            // 还有一种方法
            AddTranslation("TALKING_CARDS_STOATINTRO3_242_M", "There's a way out", "有一术可脱");
            // [anim:sly]能救我们两个。[w:0.3]
            AddTranslation("TALKING_CARDS_STOATINTRO3_536_M", "[anim:sly]for both of us.[w:0.3]", "[anim:sly]救你我二人。[w:0.3]");
            // 就在这个
            AddTranslation("TALKING_CARDS_STOATINTRO3_508_M", "It's somewhere in", "其必在此");
            // [shake:0.3]邪恶的小屋里！[leshy:闭嘴，不然我就把你撕成碎片。][w:4]
            AddTranslation("TALKING_CARDS_STOATINTRO3_314_M", "[shake:0.3]this foul cabin![leshy:Be silent or I will tear you to shreds.][w:4]", "[shake:0.3]秽庐之中！[leshy:毋哗，否将糜尔为齑。][w:4]");
            // 这1点伤害，很值得。
            AddTranslation("_LEARNEDPLIERSITEM_018_M", "A well earned point of damage.", "此一伤，得之宜也。");
            // 我没想到你真的会这么做。
            AddTranslation("_LEARNEDPLIERSITEM_560_M", "I didn't think you would really do it.", "余不意汝之为之。");
            // 你遇到了一群幸存者。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_667_M", "You came across a small group of survivors.", "汝遇数余生者。");
            // 一群面黄肌瘦的人围坐在篝火旁。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_203_M", "Faces shrunken from starvation, they huddled around a campfire.", "其面槁于饥，环火而聚。");
            // 他们看到了你和你的造物，叫你过去。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_713_M", "They looked upon your group of creatures and beckoned.", "其见乃群物，招汝使前。");
            // [c:bG]来暖暖身子吧……[c:]有人说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_142_M", "[c:bG]Come, warm one of your creatures by the fire...[c:] One said.", "[c:bG]来，以火燠乃一物……[c:]一人曰。");
            // [c:bG]让它烤烤火，能增强它的[c:][c:bR][v:0][c:][c:bG]。[c:]另一个人说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_936_M", "[c:bG]Warm it by the fire. That will enhance its [c:][c:bR][v:0][c:][c:bG].[c:] Said another.", "[c:bG]以火燠之，则益其[c:][c:bR][v:0][c:][c:bG]。[c:]复一人曰。");
            // 你看到有人擦了擦口水。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_874_M", "You noticed one of the survivors wiping drool from their mouth.", "汝见一余生者拭厥口涎。");
            // 快要熄灭的篝火旁坐着一群饥饿的幸存者。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#1_466_M", "A group of starving survivors stood around a dying campfire.", "数余生饥者，环将烬之火而立。");
            // [c:bG]这里还有位置，让你的造物过来坐下吧……[c:]有人说。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#1_622_M", "[c:bG]There is room for a creature around the fire...[c:] One said.", "[c:bG]火旁尚容一物……[c:]一人曰。");
            // [c:bG]烤火可以增强它的[c:][c:bR][v:0][c:][c:bG]。[c:]另一个人说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#1_737_M", "[c:bG]The warmth will enhance its [c:][c:bR][v:0][c:][c:bG].[c:] Said another.", "[c:bG]其燠可益其[c:][c:bR][v:0][c:][c:bG]。[c:]复一人曰。");
            // 有一个人什么也没说，只是情不自禁地舔着嘴唇。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#1_422_M", "One of the survivors said nothing at all. But could not stop licking their lips.", "一余生者无言，徒舐唇不已。");
            // 所有人都乐于见到篝火的温暖光芒。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#2_853_M", "The warm light of a campfire was a welcome sight.", "火光燠然，见之可喜。");
            // 然而篝火边却有五双不善的、饥饿的眼睛。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#2_823_M", "Though the ten hungry eyes around it dampened the greeting.", "然旁十目皆饥，遂减其喜。");
            // [c:bG]来暖暖你的造物吗？可以增强它的[c:][c:bR][v:0][c:][c:bG]。[c:]有人说。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#2_165_M", "[c:bG]Warm a creature by the fire? Enhance its [c:][c:bR][v:0][c:][c:bG]?[c:] Said one.", "[c:bG]欲以火燠一物，益其[c:][c:bR][v:0][c:][c:bG]乎？[c:]一人曰。");
            // [c:bG]来暖暖你的造物吗？可以增强它的[c:][c:bR][v:0][c:][c:bG]。[c:]一位饥饿的幸存者说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#3_922_M", "[c:bG]Warm a creature by the fire? Enhance its [c:][c:bR][v:0][c:][c:bG]?[c:] Said a hungry survivor.", "[c:bG]欲以火燠一物，益其[c:][c:bR][v:0][c:][c:bG]乎？[c:]一余生饥者曰。");
            // 篝火劈啪作响，照亮了周围饥饿的幸存者们的脸庞。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#4_511_M", "The crackling fire lit the starving faces of a group of survivors.", "火烈有声，照数余生者之饥面。");
            // [c:bG]我们没有吃的了……[c:]有人说。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#4_828_M", "[c:bG]We have not food...[c:] One said.", "[c:bG]无食矣……[c:]一人曰。");
            // [c:bG]不过你或许可以让你的造物烤烤火？可以增强它的[c:][c:bR][v:0][c:][c:bG]。[c:]另一个人说。
            AddTranslation("SPECIAL_NODES_STATBOOSTINTRO_REPEAT_#4_635_M", "[c:bG]But perhaps... one of your creatures will join us? Enhance its [c:][c:bR][v:0][c:][c:bG]?[c:] Said another.", "[c:bG]然或可……使乃一物来此同处乎？亦可益其[c:][c:bR][v:0][c:][c:bG]？[c:]又一人曰。");
            // 篝火可以温暖[c:bR][v:1][c:]，增强它的[c:bR][v:0][c:]。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_555_M", "The fire warmed the poor [c:bR][v:1][c:], enhancing its [c:bR][v:0][c:].", "火燠彼[c:bR][v:1][c:]，益其[c:bR][v:0][c:]。");
            // 一位幸存者向它靠近。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_784_M", "One of the survivors reached toward it.", "一余生者引手向之。");
            // 另一位磨了磨牙。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_038_M", "Another gnashed their teeth.", "又一人切齿。");
            // 你一言不发，拉回了[c:bR][v:1][c:]，然后离开了。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_262_M", "Without a word, you pulled the [c:bR][v:1][c:] away from the fire and left.", "汝默然引[c:bR][v:1][c:]离火而去。");
            // [c:bR][v:1][c:]的[c:bR][v:0][c:]得到了增强。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#1_219_M", "The [c:bR][v:0][c:] of the [c:bR][v:1][c:] was enhanced by the warmth.", "[c:bR][v:1][c:]之[c:bR][v:0][c:]，因燠而益。");
            // 一名幸存者开始摸自己口袋里的刀，此时你决定离开。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#1_820_M", "As one of the survivors began pulling a knife from their pocket, you withdrew.", "一余生者方探囊出刀，汝遽退。");
            // 幸存者们说的没错，篝火确实有用。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#2_951_M", "The survivors were right about the flames.", "诸余生者论火，诚不谬。");
            // 篝火增强了造物的[c:bR][v:0][c:]。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#2_061_M", "They had enhanced the creature's [c:bR][v:0][c:].", "火果益此物之[c:bR][v:0][c:]。");
            // 看到有些幸存者流下了口水，你赶紧和你的[c:bR][v:1][c:]离开了。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#2_799_M", "Spotting a few of the survivors drooling, you made a hasty retreat with your [c:bR][v:1][c:].", "见数余生者流涎，汝亟携[c:bR][v:1][c:]而退。");
            // 篝火增强了[c:bR][v:1][c:]，提高了它的[c:bR][v:0][c:]。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#3_011_M", "The fire warmed the weary [c:bR][v:1][c:] and enhanced its [c:bR][v:0][c:].", "火燠[c:bR][v:1][c:]之倦躯，益其[c:bR][v:0][c:]。");
            // 你觉得这些幸存者们另有所图。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#3_331_M", "You suspected the intentions of the survivors were less than pure.", "汝疑诸余生者所图不善。");
            // 你一把拽回了[c:bR][v:1][c:]，然后走回了林中。
            AddTranslation("SPECIAL_NODES_STATBOOSTOUTRO_REPEAT_#3_067_M", "With your [c:bR][v:1][c:] in tow, you retreated into the woods.", "汝携[c:bR][v:1][c:]，退入林中。");
            // 那头笼中之狼……[w:0.4]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_072_M", "That Caged Wolf...[w:0.4]", "彼槛中狼……[w:0.4]");
            // [e:Quiet]他藏起那张卡
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_396_M", "[e:Quiet]He hid that", "[e:Quiet]彼匿此牌");
            // [e:Quiet]有他自己的理由。[w:0.2]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_525_M", "[e:Quiet]for a reason.[w:0.2]", "[e:Quiet]必有以也。[w:0.2]");
            // 那张卡看起来一无是处，[w:0.1]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_941_M", "The card seems useless,[w:0.1]", "此牌似无所用，[w:0.1]");
            // 但是，[w:0.1]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_596_M", "but,[w:0.1]", "然，[w:0.1]");
            // 我觉得它不只表面上那么简单。
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_200_M", "I think there's more to it.", "奴意其尚有他用。");
            // 笼中之狼……[w:0.3]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#1_817_M", "A wolf in a cage...[w:0.3]", "槛中一狼……[w:0.3]");
            // 如何才能打破笼子？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#1_284_M", "But how to break it?", "然安破其槛？");
            // 唔……[w:0.3]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#2_648_M", "Hmm...[w:0.3]", "唔……[w:0.3]");
            // 我在想
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#2_780_M", "Just thinking about", "奴方思");
            // 那头狼……[w:0.3]
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#2_071_M", "that wolf...[w:0.3]", "彼狼……[w:0.3]");
            // 关于
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#3_764_M", "Something about", "似有深意者，");
            // 笼中之狼的事情……
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#3_494_M", "that caged wolf...", "彼槛中狼……");
            // 如果它被放出来
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#3_826_M", "What would happen", "若释之，");
            // 会如何？
            AddTranslation("TALKING_STINKBUG_DIALOGUE_STINKBUGCAGEDWOLF_REPEAT_#3_693_M", "if it were freed?", "将若何？");
            // 机托邦曾经是一个安全的地方。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO1_315_M", "Botopia used to be safe for travellers.", "昔机托邦，行客安焉。");
            // 现在[c:bR]叛乱机器人[c:]占据了所有的主路。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO1_307_M", "Now [c:bR]rogue bots[c:] block all the major roads.", "今[c:bR]叛机人[c:]塞诸要道。");
            // 最好的防御手段是什么？就是利用其他机器人。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO2_684_M", "The best defense? Other bots.", "何以御之最善？他机人也。");
            // 你身上的火花可以，呃……重新激活老旧机器人。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO2_054_M", "You carry a spark that can, uh... reactivate old bots.", "卿怀一星火，可……复起故机人。");
            // 你可以把他们加到你的牌组里。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO2_314_M", "Add them to your deck. You know.", "纳之于卿之牌列，可矣。");
            // 他们会为你而战。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO2_341_M", "Then they fight for you.", "则彼将为你战。");
            // 机托邦这座城市年久失修，死胡同很多。
            AddTranslation("PART_3_MAP_HOLOAREAINTROSIDEPATH_058_M", "Botopia is in such disrepair that some roads lead to dead ends.", "机托邦敝甚，故有数道止于穷途。");
            // 不过……不少好东西就在这些死胡同里。
            AddTranslation("PART_3_MAP_HOLOAREAINTROSIDEPATH_556_M", "But... these dead ends tend to have pretty good loot.", "然……此等穷途，往往多有善获。");
            // 光靠重新激活机器人可不够……
            AddTranslation("PART_3_MAP_HOLOAREAINTRO3_698_M", "You'll need more than a few reactivated bots...", "然欲成事，非数复起之机人足也……");
            // 如果你真的想实现[c:bG]终极冥刻[c:]的话……
            AddTranslation("PART_3_MAP_HOLOAREAINTRO3_913_M", "That is, if you truly wish to enact [c:bG]The Great Transcendence[c:]...", "若卿诚欲行[c:bG]大陟[c:]……");
            // 机托邦有很多强力物品，就在城市各处。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO3_900_M", "Botopia has some of the most OP items, just lying around.", "机托邦多至强之器，委地可拾。");
            // 怎样才能有效对付这些叛乱机器人呢？
            AddTranslation("PART_3_MAP_HOLOAREAINTRO4_103_M", "The real best way to fight back those rogue bots?", "然御彼叛机人，上策安在？");
            // 改造你的机器人。给予他们[c:bR]强力[c:]技能。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO4_604_M", "Modify yours. Give them [c:bR]OP[c:] abilities.", "修卿机人，畀之[c:bR]至强[c:]印技。");
            // 回到你去过的上一个路标。
            AddTranslation("PART_3_TUTORIAL_PART3TUTORIALRESPAWN_685_M", "Back to the last waypoint you reached.", "反于卿前所至之楬。");
            // 瞬移回到你来过的地方而已，对吧？
            AddTranslation("PART_3_TUTORIAL_PART3TUTORIALRESPAWN_550_M", "Just skip back to where you were, right?", "不过径返故所耳，是乎？");
            // 不会这么简单的。区域内所有的叛乱机器人都复活了。
            AddTranslation("PART_3_TUTORIAL_PART3TUTORIALRESPAWN_627_M", "Not so easy. All the rogue bots in that area just respawned.", "未有此易也。其地诸叛机人皆复出矣。");
            // 轰！你的钱都没了。真不错。
            AddTranslation("PART_3_TUTORIAL_PART3TUTORIALBLOODSTAIN_345_M", "Boom. All your money is gone. Great work.", "轰。卿财尽矣。善哉。");
            // 你想把钱拿回来吗？
            AddTranslation("PART_3_TUTORIAL_PART3TUTORIALBLOODSTAIN_559_M", "You want it back?", "卿欲复取之乎？");
            // 那下次回这来的时候，别死。
            AddTranslation("PART_3_TUTORIAL_PART3TUTORIALBLOODSTAIN_984_M", "Then get back to this spot without dying again.", "然则毋复死，而返此处。");
            // 恶心！
            AddTranslation("PART_3_MAP_HOLOAREANATURE1_843_M", "Revolting!", "秽哉！");
            // 啊，让你看见这些真是不好意思。
            AddTranslation("PART_3_MAP_HOLOAREANATURE1_764_M", "Yeah, sorry that you have to see this.", "使卿见此，愧矣。");
            // 这是机托邦中唯一一处还有[c:bR]生命[c:]的地方了。
            AddTranslation("PART_3_MAP_HOLOAREANATURE1_631_M", "It's the last area in Botopia that still has [c:bR]life[c:] in it.", "机托邦犹有[c:bR]生[c:]者，唯此地耳。");
            // 那一团又臭又不完美、蠕动着的玩意……
            AddTranslation("PART_3_MAP_HOLOAREANATURE1_265_M", "That stinking, squirming mass of imperfection...", "彼臭蠕之一团瑕物……");
            // 你就快到路标了。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO5_644_M", "You're almost at the Waypoint.", "汝几至楬矣。");
            // 可别死了。
            AddTranslation("PART_3_MAP_HOLOAREAINTRO5_585_M", "Don't choke now.", "今毋挫。");
            // 机托邦东部吗……
            AddTranslation("PART_3_MAP_HOLOAREAEAST1_193_M", "Eastern Botopia...", "机托邦之东……");
            // 那边不值得去。
            AddTranslation("PART_3_MAP_HOLOAREAEAST1_408_M", "Not much of value out this way.", "此道无甚可取。");
            // 不过你还是得去。
            AddTranslation("PART_3_MAP_HOLOAREAEAST2_195_M", "But you've still gotta explore here.", "然汝犹须历此地。");
            // 毕竟是为了[c:bG]终极冥刻[c:]嘛……
            AddTranslation("PART_3_MAP_HOLOAREAEAST2_396_M", "You know, for [c:bG]The Great Transcendence[c:]...", "盖为[c:bG]大陟[c:]耳……");
            // 无聊。
            AddTranslation("PART_3_MAP_HOLOMAPPOWEROUT_274_M", "Lame.", "鄙哉。");
            // 这个老玩意已经没电了。
            AddTranslation("PART_3_MAP_HOLOMAPPOWEROUT_196_M", "The power is dead on this old thing.", "此旧物之电绝矣。");
            // 你如果愿意去找一块新电池，我就放你站起来。
            AddTranslation("PART_3_MAP_HOLOMAPPOWEROUT_548_M", "I'll let you get up if you go get a new battery.", "卿若往取新电匣来，咱乃听卿之起。");
            // 呃。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEAD1_845_M", "Ugh.", "噫。");
            // 这个废品场又暗又潮，我感觉很不好。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEAD1_809_M", "This dank scrapyard is pretty unpleasant.", "此废场阴湿，殊可厌也。");
            // 这里的住民渴求着新来的机器人。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEAD1_017_M", "Its inhabitants' grasping claws seek fresh bots.", "其居者攫爪，求鲜机人。");
            // 小心你的脚踝。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEAD1_849_M", "Watch your ankles.", "慎卿之踝。");
            // 这地方太沉闷了。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLE1_504_M", "What a depressing abode.", "斯居可惨。");
            // 你来到这里是为了击败盘踞在这里的[c:bG]巨型机器人[c:]……
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLE1_919_M", "You have to be here to defeat the resident [c:bG]Uberbot[c:]...", "卿来此，盖欲败居此之[c:bG]魁机人[c:]耳……");
            // 但此地不宜久留。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLE1_285_M", "But I don't think you'll want to stay long.", "然咱谓卿之必不欲久留。");
            // 看啊……你追寻的[c:bG]巨型机器人[c:]就在那里。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLEBOSS_756_M", "There it is... The [c:bG]Uberbot[c:] you sought.", "彼在是矣……卿所求之[c:bG]魁机人[c:]也。");
            // 这些图书管理员真是蠢到家了……膜拜这样一个一动不动、覆满污泥的东西。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLEBOSS_837_M", "These idiotic librarians worship it... as it sits here covered in filth and grime.", "诸愚守牍者祀之……而彼徒踞于此，身被垢秽。");
            // 准备好给它清理一番了吗？
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLEBOSS_936_M", "Ready to clean it up?", "可备洒扫之乎？");
            // 之前住在这儿的这位可真不讲究。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLE1_316_M", "The guy who used to live here was totally sloppy.", "旧居此者，殊不整。");
            // 不是说他不讲究卫生……是说他打牌不够讲究。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLE1_589_M", "I don't mean he didn't keep a clean cabin... it was his plays.", "非谓其庐不洁……乃谓其陈牌耳。");
            // 失误一抓一大把。他更关心卡牌的故事和调性。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLE1_124_M", "He'd make misplays left and right. Cared more about lore and flavor.", "昏著屡作，而顾重牌事之说与味耳。");
            // 你搞对重点了吗？卡牌游戏最重要的就是策略。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLE1_834_M", "You get it right? Perfect strategy is all that matters in a card game.", "卿知之乎？牌局所尚，惟全策耳。");
            // 真恐怖。一台[c:bG]巨型机器人[c:]在一片黑暗中一动不动。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLEBOSS_783_M", "Eerie. This [c:bG]Uberbot[c:] just sits here in perfect darkness.", "怪哉。此[c:bG]魁机人[c:]徒坐于冥冥之中。");
            // 它就只是等着有人来挑战它吗？
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLEBOSS_291_M", "Is it just waiting for challengers?", "其徒俟角者乎？");
            // 也许它只是在等自己的照片冲洗好吧。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLEBOSS_721_M", "Maybe it's letting its photos develop.", "殆俟其影成耳。");
            // 你只能一个人进检查室。
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY1_665_M", "You're allowed in the Inspection Room only.", "唯许卿入察室耳。");
            // 把检查器上的电池取下来，带回给我就行了。
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY1_057_M", "Just get me the battery from the inspectometer and come back.", "但取察器之电匣以归我。");
            // 哦，我是不是忘了把那些装置打开？
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY2_835_M", "Oh, I left those things turned off?", "噫，咱竟忘启彼诸物乎？");
            // 问题不大。一些简单的解谜罢了。
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY2_873_M", "That's fine. Just solve some easy puzzles.", "无妨。但解易谜耳。");
            // 好，这才对嘛。带来给我吧。
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY3_364_M", "Yep. That's it. Bring it over.", "然，是矣。致之于我。");
            // 行，谢了。
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY4_184_M", "Yep. Thanks.", "然。谢矣。");
            // 这样就行了，回牌局来吧。
            AddTranslation("PART_3_MAP_FACTORYFETCHBATTERY5_575_M", "That should do it. Back to the game.", "可矣。归局。");
            // 你把这张皮怎么了？
            AddTranslation("SPECIAL_NODES_TRADERPELTSMERGED_758_M", "What have you done to that pelt?", "君何施于彼革？");
            // 简直……太丑了……不过我还是得收。
            AddTranslation("SPECIAL_NODES_TRADERPELTSMERGED_712_M", "It's... monstrous... yet I must have it.", "此……殊怪……然鄙必得之。");
            // 你觉得这些怎么样？
            AddTranslation("SPECIAL_NODES_TRADERPELTSMERGED_527_M", "What do you think of these?", "君视此若何？");
            // 这张皮……真是非同寻常。
            AddTranslation("SPECIAL_NODES_TRADERPELTSMERGED_REPEAT_#1_191_M", "That pelt... that is quite unusual.", "彼革……殊异。");
            // 可以用来做一床被子！这个我要了！
            AddTranslation("SPECIAL_NODES_TRADERPELTSMERGED_REPEAT_#3_475_M", "A veritable quilt! I must have it.", "真可为衾！鄙必得之。");
            // 嗯，不错。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED1_519_M", "Yep. Good.", "然，善。");
            // 把它装上去吧。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED1_903_M", "Let's attach it.", "且附之。");
            // 一种新的资源。宝石。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_319_M", "!DELETED!", "此一新资也：玉。");
            // 规则很简单：如果你有宝石卡牌，它们就会亮起来。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_129_M", "!DELETED!", "其则甚易：玉牌既列，则皆明矣。");
            // 然后你就可以打出需要消耗宝石的卡牌了。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_530_M", "!DELETED!", "而后卿乃可陈以玉为直之牌。");
            // 现在你副牌组里的空容器已经装满宝石了。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_845_M", "!DELETED!", "今卿副牌列中之虚皿，已尽充玉矣。");
            // 去看看吧。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_216_M", "Check it out.", "试观之。");
            // 毛皮商的据点被遗弃了。
            AddTranslation("SPECIAL_NODES_TRADERFINALZONEINTRO_846_M", "The Trader's post was left abandoned.", "贾妇之肆，已弃矣。");
            // 为了体现你对这位诡异女士的尊重，你只拿走了买得起的东西。
            AddTranslation("SPECIAL_NODES_TRADERFINALZONEINTRO_564_M", "As a sign of respect for the strange woman, you took only what you could afford.", "以敬异妇，汝唯取所能酬者。");
            // 寒风吹过了贸易据点。
            AddTranslation("SPECIAL_NODES_TRADERFINALZONEINTRO_REPEAT_#1_131_M", "A chill wind blew through the trading post.", "寒风过肆。");
            // 它的主人早已溘然长逝。
            AddTranslation("SPECIAL_NODES_TRADERFINALZONEINTRO_REPEAT_#1_129_M", "Its proprietor was now deceased.", "厥主今亡矣。");
            // 但你仍然严格地遵守着这位女士的规则。
            AddTranslation("SPECIAL_NODES_TRADERFINALZONEINTRO_REPEAT_#1_932_M", "Still, you abided by the strange woman's rules as best you could.", "然汝犹勉循异妇厥法。");
            // 哎，抱歉，你还是回去吧。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_950_M", "Woof. Sorry. Turn back.", "呜。歉矣。请返。");
            // 这座桥完全没修好，回去吧。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_467_M", "This bridge is totally busted. Go back.", "此桥尽坏矣。返。");
            // 我还需要时间修桥。不如你去花点时间干掉一个头目？到时候应该就差不多了。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_739_M", "I'll need time. Beat a boss? That should give me enough time.", "余尚需时。败一魁乎？则足予我时矣。");
            // 喔。没错，桥还是没修好。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_REPEAT_#1_635_M", "Woof. Yep. Still broken.", "呜。然，桥犹坏。");
            // 要修这个桥……还需要不少时间。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_REPEAT_#1_114_M", "No fixing this thing for... a while.", "此桥……一时未可修。");
            // 修桥吗？没错还得需要点儿时间。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_REPEAT_#2_243_M", "This job? Yeah it's gonna take a minute.", "此役乎？然，尚须少时。");
            // 如果你能花点时间去干掉一个[c:bG]巨型机器人[c:]的话……
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_REPEAT_#2_435_M", "I bet if you defeated one of the [c:bG]Uberbots[c:]...", "余料，汝若能败一[c:bG]魁机人[c:]……");
            // 那我可以用这段时间把桥修好。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGE_REPEAT_#2_802_M", "I bet that would be enough time to finish it up.", "则其间足使余之毕修此桥矣。");
            // 是的。哦不。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULE_115_M", "Yep. Oh no.", "然。噫。");
            // 啊，我差点忘了还有一个部件……
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULE_525_M", "Yep. I forgot a piece...", "然。咱忘一件矣……");
            // 你有腿，去拿那个东西。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULE_599_M", "You have legs. Stand up and get it.", "卿有足，起而取之。");
            // 它就在熔炼室里，就浮在熔炼器上。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULE_060_M", "It's in the Smelter Room. Floating above the Smelting Machine.", "在冶室，浮于冶机之上。");
            // 把它给我，我才能让你继续前进。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULE_279_M", "I can't let you go further until I have it.", "卿未得之，不纵你前。");
            // 听好。我需要那个部件。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_965_M", "Look. I need that piece.", "听之。咱须彼件。");
            // 你能去把它拿给我吗？
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_675_M", "Would you stand up and get it?", "卿其起而取之乎？");
            // 它就在熔炼室里。我已经把门给你打开了。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_376_M", "It's in the Smelter Room. I opened the door for you.", "在冶室，咱已为汝启门。");
            // 把它给我，我才能让你过桥。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_REPEAT_#1_241_M", "!DELETED!", "致之于我，咱乃纵你过桥。");
            // 那个部件。它就在熔炼室里。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_REPEAT_#1_047_M", "That piece. In the Smelter Room.", "彼件，在冶室。");
            // 去拿给我。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_REPEAT_#1_402_M", "Walk over and get it.", "往而取之。");
            // 我已经把门打开了……
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_REPEAT_#2_880_M", "I unlocked the door...", "咱已启门矣……");
            // 它就浮在那个桥一样的怪东西上面。
            AddTranslation("PART_3_MAP_HOLOMAPFETCHGEMSMODULEREMINDER_REPEAT_#2_116_M", "It's floating above that strange bridge thing.", "浮于彼怪若桥者上。");
            // 真快……
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN1_388_M", "That was fast...", "速哉……");
            // 很遗憾[w:0.2]我的[c:r]井[c:]并没有出产我需要的财宝。
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN1_885_M", "Unfortunately[w:0.2] my [c:r]well[c:] did not yield the treasure I had hoped for.", "惜乎[w:0.2]朕[c:r]井[c:]不出朕所冀之宝。");
            // 我们只好再来一次循环了。
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN1_729_M", "And so we are forced to undergo another torturous cycle.", "是故，奴等不得不复历此苦轮。");
            // 是我说了算吗？[w:0.4]那我可能会抹平一切……[w:0.3]然后引领我们所有人步入永恒至高的和平之中。
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN1_290_M", "Were it up to me?[w:0.4] I would erase it all...[w:0.3] and shepherd us into an eternal and supreme peace.", "苟听我乎？[w:0.4]奴当尽灭之……[w:0.3]导奴等归于永宁至安。");
            // 不过不是今天。[w:0.3]让我们来看看这次是哪个冥刻者这么幸运吧？
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN1_616_M", "Not today.[w:0.3] Who is the lucky Scrybe this time?", "今日不然。[w:0.3]此番，孰为幸之司锲？");
            // [c:R][w:1][t:100][shake:1]你[shake:1]个[shake:1]蠢[shake:1]货[shake:1]。[w:0.4][t:0][c:]
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN1_516_M", "[c:R][w:1][t:100][shake:1]F[shake:1]O[shake:1]O[shake:1]L[shake:1].[w:0.4][t:0][c:]", "[c:R][w:1][t:100][shake:1]竖[shake:1]子[shake:1]愚[shake:1]哉[shake:1]！[w:0.4][t:0][c:]");
            // 你根本不知道会发生什么。
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN1_292_M", "You have no idea what could have been.", "汝殊不知其本可若何。");
            // 一个精心策划的生死循环。[w:0.3]兴奋。[w:0.3]恐惧。[w:0.3]神秘。
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN1_615_M", "A carefully curated cycle of life and death.[w:0.3] Excitement.[w:0.3] Terror.[w:0.3] Mystery.", "生死之轮，精审而成。[w:0.3]惊。[w:0.3]惧。[w:0.3]秘。");
            // 钓鱼人这个蠢货[w:0.2]又一次辜负了我……
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN1_260_M", "That gormless Angler[w:0.2] has once again failed me...", "彼愚渔父[w:0.2]又负我矣……");
            // 我想[w:0.3]我知道了，哪位冥刻者会击败我……
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN1_226_M", "I suspect[w:0.3] that I know which Scrybe bested me...", "余意[w:0.3]已知孰司锲胜我矣……");
            // 我知道我会输。[w:0.4]我已经预见到了。
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN1_715_M", "I already know I have lost.[w:0.4] I have foreseen it.", "吾既知吾之败矣。[w:0.4]吾先见之。");
            // [shake:1]我的眼睛[w:0.4]又一次[w:0.4]疼了起来。
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN1_721_M", "[shake:1]My eye[w:0.4] aches[w:0.4] once again.", "[shake:1]朕目[w:0.4]复[w:0.4]痛矣。");
            // [shake:1]为什么我可悲的史莱姆法师总是会输？
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN1_542_M", "[shake:1]Why must my pathetic Slime Mage always fail?", "[shake:1]朕陋黏涎之巫何恒败耶？");
            // 不过我何必这么小心翼翼呢……[w:0.3]既然[w:0.2]我已经[w:0.2]尝到了力量的滋味？
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN1_618_M", "But would I be so meticulous in my preparedness...[w:0.3] if I[w:0.2] myself[w:0.2] had tasted power?", "然，吾何必若是周备……[w:0.3]若吾[w:0.2]自[w:0.2]既尝威乎？");
            // 唉……[w:0.3]可能我永远不会知道了。
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN1_866_M", "Alas...[w:0.3] I may never know.", "噫……[w:0.3]吾或终不能知。");
            // [shake:1]现身吧！[w:0.2][shake:1][t:1]你这该死的[w:0.2][shake:1]机器！
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN1_425_M", "[shake:1]Show yourself![w:0.2] [shake:1][t:1]Fiendish[w:0.2][shake:1] machine!", "[shake:1]见形！[w:0.2] [shake:1][t:1]妖孽[w:0.2][shake:1]机物！");
            // [t:1]呵[w:0.4]呵[w:0.2]呵。[w:0.4][t:]废物们。
            AddTranslation("GBC_FINALE_PART2FINALEP03CHOSEN1_675_M", "[t:1]He[w:0.4]he[w:0.2]he.[w:0.4][t:] Suckers.", "[t:1]呵[w:0.4]呵[w:0.2]呵。[w:0.4][t:]群愚。");
            // 啊。[w:0.3]你真的选了我？[w:0.3]不错。
            AddTranslation("GBC_FINALE_PART2FINALEP03CHOSEN1_728_M", "Oh.[w:0.3] You actually picked me?[w:0.3] Great.", "噫。[w:0.3]卿果择我乎？[w:0.3]甚善。");
            // 我可以跳过他们抱怨我的这部分。
            AddTranslation("GBC_FINALE_PART2FINALEP03CHOSEN1_220_M", "I can skip past the part where they whine at me.", "他等怨我之辞，咱可径略。");
            // 忍一下吧。[w:0.3]我有很多正事儿要办呢。
            AddTranslation("GBC_FINALE_PART2FINALEP03CHOSEN1_586_M", "Let's get this over with.[w:0.3] I've got some big plays to make.", "速毕此事。[w:0.3]咱尚有大谋可行。");
            // 啊。[w:0.3]P[w:0.2]0[w:0.2]3[w:0.2]……他们之中最坏的那个。
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN2_767_M", "Ah.[w:0.3] P[w:0.2]0[w:0.2]3[w:0.2]... The very worst of them.", "噫。[w:0.3]鉟[w:0.2]零[w:0.2]三[w:0.2]……诸司锲中至恶者也。");
            // 做你想做的吧，[w:0.3]卑鄙的电脑。
            AddTranslation("GBC_FINALE_PART2FINALEGRIMORACHOSEN2_113_M", "Do what you will,[w:0.3] vile computer.", "任汝所为，[w:0.3]恶机。");
            // 当然。[w:0.3]P03。
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN2_052_M", "Of course.[w:0.3] P03.", "固然。[w:0.3]鉟〇三。");
            // 这个合成怪胎根本不懂什么是艺术。也不懂……[w:0.2]不懂……[w:0.2]什么是美！
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN2_890_M", "This synthetic freak knows nothing of artistry. Of-[w:0.2] of-[w:0.2] aesthetics!", "此合成怪，殊不知艺。亦不……[w:0.2]不……[w:0.2]知雅！");
            // 怪物……[w:0.2]你还是当白鼬比较好……
            AddTranslation("GBC_FINALE_PART2FINALELESHYCHOSEN2_783", "Monster...[w:0.2] I liked you better as a stoat...", "怪物……[w:0.2]汝为鼬时，余犹喜之……");
            // 唉……[w:0.3]残酷的命运等待着我们。
            AddTranslation("GBC_FINALE_PART2FINALEMAGNIFICUSCHOSEN2_843_M", "Alas...[w:0.3] ill fates await us all.", "噫……[w:0.3]恶命将及我等。");
            // 纸条上写道：[c:gray]您好，您之所以在阅读这张字条，是因为您想挑战我，蔓尼菲科，和我来一局卡牌对决。[prefab:WizardMarking_F1_1] 
            AddTranslation("GBC_WORLD_WIZARDTEMPLENOTE1_164_M", "The note reads: [c:gray]Greetings. If you are reading this it must be because you wish to challenge me, Magnificus, to a card battle.[prefab:WizardMarking_F1_1] ", "札曰：[c:gray]敬问。子读此者，必欲与吾蔓尼菲科，以牌相角。[prefab:WizardMarking_F1_1]");
            // [c:gray]但在您有幸挑战我之前，必须先击败我的三个学生。[prefab:WizardMarking_F1_2] 
            AddTranslation("GBC_WORLD_WIZARDTEMPLENOTE1_814_M", "[c:gray]But in order to earn that privilege you must first defeat my 3 graduate students.[prefab:WizardMarking_F1_2] ", "[c:gray]然欲得此荣，子必先胜朕三高弟。[prefab:WizardMarking_F1_2]");
            // [c:gray]至于他们的下落，还需您自行发掘……此致，蔓尼菲科。[prefab:WizardMarking_F1_3] 
            AddTranslation("GBC_WORLD_WIZARDTEMPLENOTE1_338_M", "[c:gray]As for their whereabouts, that is for you to discover... Sincerely, Magnificus.[prefab:WizardMarking_F1_3] ", "[c:gray]其所处，则俟子自索之……蔓尼菲科白。[prefab:WizardMarking_F1_3]");
            // 可怜的老不死……[w:0.3]她总是哭哭啼啼的。
            AddTranslation("GBC_FINALE_PART2FINALESCRYBEREMOVED_802_M", "Wretched corpse-woman...[w:0.3] I won't miss her whining.", "可恶尸妇……[w:0.3]其呶呶，咱不思也。");
            // 肮脏的老怪物。[w:0.3]你再也别想把我变成白鼬了。
            AddTranslation("GBC_FINALE_PART2FINALESCRYBEREMOVED_290", "Filthy old beast.[w:0.3] I'll never be your stoat again.", "秽哉老兽。[w:0.3]咱终不复为你鼬矣。");
            // 老蠢货……[w:0.3]我不欠你的！
            AddTranslation("GBC_FINALE_PART2FINALESCRYBEREMOVED_049", "Tedious old fool...[w:0.3] I don't owe you anything!", "烦哉老愚……[w:0.3]咱于你无所负！");
            // 我们开始吧。
            AddTranslation("GBC_FINALE_PART2FINALESCRYBEREMOVED_947_M", "Now let's play.", "今可战矣。");
            // [t:2]你应该和你选择的冥刻者展开对决……[w:0.5]但[w:0.2]对决[w:0.2]的强度更高，给最终之战做准备。
            AddTranslation("GBC_FINALE_PART2FINALEBATTLE1_092_M", "[t:2]You're supposed to battle the Scrybe that you picked...[w:0.5] but[w:0.2] like[w:0.2] a powered-up version for the finale.", "[t:2]卿本当与所择之司锲战……[w:0.5]然[w:0.2]其威[w:0.2]弥盛，以终此局。");
            // 这次肯定不一样。
            AddTranslation("GBC_FINALE_PART2FINALEBATTLE1_993_M", "This is going to be different.", "此将异矣。");
            // 我就把它放这儿了。
            AddTranslation("GBC_FINALE_PART2FINALEBATTLE2_265_M", "I'll just leave this here.", "咱姑置此于斯。");
            // 我应该把它给挖掘工……[w:0.3]它倒也并不是一无是处。
            AddTranslation("GBC_FINALE_PART2FINALEBATTLE2_295_M", "I've gotta give it to that Dredger...[w:0.3] Not as useless as I thought.", "咱当归功于彼浚夫……[w:0.3]未若咱所料之无用。");
            // 想再试一次吗？
            AddTranslation("GBC_FINALE_PART2FINALEBATTLE2_REPEAT_#1_962_M", "Try again?", "更试乎？");
            // 就怕你不问呢。
            AddTranslation("GBC_FINALE_PART2FINALEBATTLE3_492_M", "That's the ticket.", "是矣。");
            // 你喜欢宝石吗？
            AddTranslation("PART_3_MAP_HOLOAREAWIZARD1_810_M", "You like the gems?", "卿好诸玉乎？");
            // 我个人感觉有点俗气。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARD1_039_M", "They're tacky I think.", "咱谓颇俗。");
            // 之前住在这儿的人就是个废物。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLE1_301_M", "The guy who used to live here was a major drag.", "昔居此者，甚可厌也。");
            // 但我得承认……他并不蠢。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLE1_636_M", "Though I'll admit... he was not dull.", "然咱亦承之……彼非庸也。");
            // 他做好了应对每一种结局的准备。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLE1_355_M", "Guy had a plan for every eventuality.", "凡变，彼皆预图之。");
            // ……除了[c:bG]终极冥刻[c:]以外。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLE1_539_M", "That is, except for [c:bG]The Great Transcendence[c:].", "唯[c:bG]大陟[c:]，彼未图耳。");
            // 啊，对了。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLEBOSS_514_M", "Oh, right.", "噫，然矣。");
            // 这个[c:bG]巨型机器人[c:]……
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLEBOSS_079_M", "This [c:bG]Uberbot[c:]...", "此[c:bG]魁机人[c:]……");
            // 你会知道的。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLEBOSS_368_M", "Well, you'll see.", "汝自见之。");
            // 啊啊啊啊！
            AddTranslation("GOO_BOTTLE_GOODEFAULT_125_M", "Arrrrghh!", "噫噫噫噫！");
            // 呃——
            AddTranslation("GOO_BOTTLE_GOODEFAULT_REPEAT_#1_886_M", "Rrrrgh...", "呃……");
            // 呃呃！啊啊啊！
            AddTranslation("GOO_BOTTLE_GOODEFAULT_REPEAT_#2_618_M", "Rrrgh! Arrrgh!", "呃！噫噫噫噫！");
            // 啊啊啊啊！好痛！
            AddTranslation("GOO_BOTTLE_GOODEFAULT_REPEAT_#3_975_M", "Arrrrghh! Oh the agony!", "噫噫噫噫！痛哉！");
            // 这怎么可能？
            AddTranslation("GOO_BOTTLE_GOOWIZARDEYE_781_M", "Could it be?", "岂其然乎？");
            // 你拿了大师的眼睛！
            AddTranslation("GOO_BOTTLE_GOOWIZARDEYE_798_M", "You have The Master's eye!", "子有大师之目！");
            // 这……这是不是意味着大师可以看见我了？
            AddTranslation("GOO_BOTTLE_GOOWIZARDEYE_478_M", "D-does this mean The Master can see me?", "是……是则大师见我乎？");
            // 蔓尼菲科？你能看到我吗？
            AddTranslation("GOO_BOTTLE_GOOWIZARDEYE_366_M", "Magnificus? Can you see me?", "蔓尼菲科？见我乎？");
            // 你能给我自由吗？
            AddTranslation("GOO_BOTTLE_GOOWIZARDEYE_897_M", "Can you free me?", "子能释我乎？");
            // 我说真的，你没法用那东西。
            AddTranslation("GOO_BOTTLE_ACTIVATEGOOBOTTLEITEM_872_M", "I am serious. You cannot use that.", "余非戏言。汝不可用彼。");
            // 那东西没用。
            AddTranslation("GOO_BOTTLE_ACTIVATEGOOBOTTLEITEM_746_M", "There is no possible use for it.", "彼本无用。");
            // 我会暂时把它放在那个架子上面。
            AddTranslation("GOO_BOTTLE_ACTIVATEGOOBOTTLEITEM_374_M", "I'll place it on that shelf over there for now.", "余姑置之彼架上。");
            // 我的建议就是别碰它了。
            AddTranslation("GOO_BOTTLE_ACTIVATEGOOBOTTLEITEM_172_M", "My advice? Avoid it.", "余之谏乎？远之。");
            // 这痛苦……难以忍受！
            AddTranslation("GOO_BOTTLE_GOOINTRO_808_M", "The pain is unbearable!", "其痛不可堪！");
            // 即使这么多年都已经过去了……
            AddTranslation("GOO_BOTTLE_GOOINTRO_437_M", "Even after all these years...", "历此多年，犹然……");
            // 你想干嘛？
            AddTranslation("GOO_BOTTLE_GOOINTRO_542_M", "What do you want?", "子欲何为？");
            // 我感受不到活着的意义……
            AddTranslation("GOO_BOTTLE_GOOINTRO_011_M", "I have very little to live for these days...", "今吾所以生者，鲜矣……");
            // 我还没准备好呢。只是个测试罢了，你没忘吧？
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_716_M", "!DELETED!", "鄙犹未备。特试测耳，君未忘乎？");
            // 但是……等我……
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_757_M", "!DELETED!", "然……俟鄙……");
            // 我会用秘密换毛皮。
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_189_M", "!DELETED!", "鄙将以秘易革。");
            // 这里是机托邦，一个曾经辉煌的科技天堂。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_790_M", "This is Botopia. A once great technological paradise.", "此机托邦也，昔盛之机巧乐土。");
            // 它的统治者是四位……呃……
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_358_M", "It's ruled over by four... uh...", "其主凡四……呃……");
            // [c:bG]巨型机器人[c:]……没错。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_279_M", "[c:bG]Uberbots[c:]... that's right.", "四[c:bG]魁机人[c:]……是矣。");
            // 你要去那儿打败它们。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_747_M", "And you've got to get out there and beat them.", "卿当往而败之。");
            // 理由？
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_323_M", "Why?", "何也？");
            // 当然是为了[c:bG]终极冥刻[c:]了。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_437_M", "To perform [c:bG]The Great Transcendence[c:] of course.", "为行[c:bG]大陟[c:]耳。");
            // 它是什么并不重要。你想实现它，对吧？
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO2_370_M", "Doesn't matter what that means. You want it, OK?", "其义何如，毋庸问。汝欲之，可乎？");
            // 想站起来？门儿都没有。
            AddTranslation("PART_3_GAME_FLOW_PART3HANDCUFFED_293_M", "Get up? No.", "欲起乎？不可。");
            // 我们没实现终极冥刻呢。
            AddTranslation("PART_3_GAME_FLOW_PART3HANDCUFFED_824_M", "We've got transcending to do.", "尚有大陟之事待行。");
            // 不错的交易。
            AddTranslation("PART_3_MAP_HOLOAREASHOP_030_M", "Glorious commerce.", "盛哉其贾。");
            // 我收你的[c:bG]机器币[c:]。
            AddTranslation("PART_3_MAP_HOLOAREASHOP_391_M", "Your [c:bG]robobucks[c:] are accepted here.", "鄙受君[c:bG]机币[c:]。");
            // 这个不错。
            AddTranslation("PART_3_TUTORIAL_TUTORIALOVERCLOCK1_126_M", "This is a cool one.", "此一佳矣。");
            // 我可以超频你的一张卡牌，增强它的攻击力。
            AddTranslation("PART_3_TUTORIAL_TUTORIALOVERCLOCK1_805_M", "I'll overclock one of your cards. Give it an attack buff.", "咱将过频以亢乃一牌，益其威。");
            // 但是如果卡牌被摧毁了，就会永远消失。
            AddTranslation("PART_3_TUTORIAL_TUTORIALOVERCLOCK1_335_M", "But if it dies it's gone forever.", "然其死，则永亡。");
            // 好了。可别让它死了。
            AddTranslation("PART_3_TUTORIAL_TUTORIALOVERCLOCK2_589_M", "Done. Don't let it die.", "已矣，毋令其死。");
            // 希望你能领会。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_481_M", "!DELETED!", "愿卿晓之。");
            // 你来选一张卡，好吗？
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_405_M", "!DELETED!", "卿择一牌，可乎？");
            // 除了[c:bR]能量[c:]成本之外，此卡牌还需要[c:bR]宝石[c:]成本。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_116_M", "!DELETED!", "此牌非独直[c:bR]能[c:]，亦直[c:bR]玉[c:]。");
            // 别紧张，我还没出完呢。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_199_M", "!DELETED!", "毋遽，咱言未竟。");
            // 它的属性会根据你选中的宝石相应提升。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_812_M", "!DELETED!", "其数随卿所择之玉而益。");
            // 还记得你的副牌组吗？
            AddTranslation("PART_3_TUTORIAL_TUTORIALMODIFYSIDEDECK1_587_M", "Remember your Side Deck?", "卿忆卿之副牌列乎？");
            // 上面都是些[c:bR]空容器[c:]的那副烂牌？
            AddTranslation("PART_3_TUTORIAL_TUTORIALMODIFYSIDEDECK1_545_M", "That useless thing with all the [c:bR]Empty Vessels[c:]?", "即彼尽列无用[c:bR]虚皿[c:]之副牌列？");
            // 倒也还是能派上点用场。
            AddTranslation("PART_3_TUTORIAL_TUTORIALMODIFYSIDEDECK1_041_M", "It's about to get less useless.", "今将稍有用矣。");
            // 真有意思……
            AddTranslation("PART_3_TUTORIAL_TUTORIALMODIFYSIDEDECK3_476_M", "Interesting...", "异哉……");
            // 我也不确定是否正确，不过现在卡牌上都有[c:bR][v:0][c:]印记了。
            AddTranslation("PART_3_TUTORIAL_TUTORIALMODIFYSIDEDECK3_948_M", "I'm not sure that was right, but they all have [c:bR][v:0][c:] now.", "咱亦未审其然，然今皆有[c:bR][v:0][c:]矣。");
            // 你选的宝石会嵌入每张[c:bR]空容器[c:]卡牌。
            AddTranslation("PART_3_TUTORIAL_TUTORIALMODIFYSIDEDECK2_371_M", "Your pick will be installed on every [c:bR]Empty Vessel[c:] card.", "卿所择之玉，将悉著于诸[c:bR]虚皿[c:]牌。");
            // 嚯！冒险者！
            AddTranslation("PART_3_MAP_HOLOMAPWIZARDSHORTCUT_401_M", "Ho! A traveller!", "嗬！行客！");
            // 在我们这儿可算是稀客。
            AddTranslation("PART_3_MAP_HOLOMAPWIZARDSHORTCUT_425_M", "These parts do not see many.", "此间罕见行客。");
            // 你想要通过这些刀片？
            AddTranslation("PART_3_MAP_HOLOMAPWIZARDSHORTCUT_407_M", "You wish to pass these blades?", "子欲度此刃阵乎？");
            // 你想要躲过这块冰？
            AddTranslation("PART_3_MAP_HOLOMAPUNDEADSHORTCUT_714_M", "You wish to pass this ice?", "汝欲度此冰乎？");
            // 我应该能搞……搞定它。
            AddTranslation("PART_3_MAP_HOLOMAPUNDEADSHORTCUT_066_M", "Well, I suppose I could c-c-clear it.", "然……愚—愚当能除之。");
            // 稍微[c:bR]升点温[c:]应该就行。
            AddTranslation("PART_3_MAP_HOLOMAPUNDEADSHORTCUT_324_M", "A little bit of [c:bR]heat[c:] should do the trick.", "少加[c:bR]燠[c:]，足矣。");
            // 哈哈……哈哈哈……
            AddTranslation("PART_3_MAP_HOLOMAPUNDEADSHORTCUT_051_M", "Heh... Heheh...", "呵……呵呵……");
            // 这玩意儿是金……金子？
            AddTranslation("PART_3_MAP_HOLOMAPNATURESHORTCUT_049_M", "This here g-gold?", "此乃金—金乎？");
            // 这不巧了么，我正要挖呢。
            AddTranslation("PART_3_MAP_HOLOMAPNATURESHORTCUT_521_M", "I were just 'bout to mine it.", "巧矣，俺方欲凿之。");
            // 现在只差临门一脚！
            AddTranslation("PART_3_MAP_HOLOMAPNATURESHORTCUT_514_M", "Guess all I needed were a kick in the pants!", "乃知但须一激耳！");
            // 等会儿，来了个通知。
            AddTranslation("PART_3_MAP_P03CHECKSECURITYCAMS1_662_M", "Hold on a minute. I got a notification.", "少待。有告至矣。");
            // [c:bR]什么情况？！[c:]
            AddTranslation("PART_3_MAP_P03CHECKSECURITYCAMS1_959_M", "[c:bR]What?![c:]", "[c:bR]何？！[c:]");
            // 得，挖泥室的监控摄像头坏了。
            AddTranslation("PART_3_MAP_P03CHECKSECURITYCAMS2_467_M", "That's it. The Dredging Room security camera is busted.", "然矣。浚室之守视影器坏矣。");
            // 没事。
            AddTranslation("PART_3_MAP_P03CHECKSECURITYCAMS2_240_M", "It's nothing.", "无他。");
            // 应该没大问题。
            AddTranslation("PART_3_MAP_P03CHECKSECURITYCAMS2_433_M", "It's probably nothing.", "殆无他耳。");
            // 赶紧去检查看看吧。
            AddTranslation("PART_3_MAP_P03CHECKSECURITYCAMS2_994_M", "Go check it out right now.", "亟往察之。");
            // 我名叫[c:bR][v:0][c:]。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET1_823_M", "The name's [c:bR][v:0][c:].", "余名[c:bR][v:0][c:]。");
            // 你的小命就由我收下了。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET1_789_M", "And I'll be takin' that scalp o' yours.", "余将取乃首。");
            // 受命行事而已，不是针对你，小鬼。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET1_996_M", "Nothing personal, kid.", "小子，非私怨尔也。");
            // 你以为你见识过[c:bR][v:0][c:]的杀手锏了，是吧？
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED1_672_M", "Thought ye'd seen the last o' [c:bR][v:0][c:], did ya?", "汝谓不复见[c:bR][v:0][c:]乎？");
            // 你可想错了！
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED1_111_M", "Think again!", "误矣！");
            // 我下回再取你的小命。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED1_539_M", "I'll be takin' that scalp another day.", "异日余再取乃首。");
            // 你才没见过[c:bR][v:0][c:]真正的实力！
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED1_883_M", "Y'ain't seen the last o' [c:bR][v:0][c:]!", "汝未见[c:bR][v:0][c:]之终也！");
            // 上回抓你的赏金可让我大赚了一笔。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS1_986_M", "That scalp o' yours fetched me a pretty penny last time.", "曩者乃首，余得金颇多。");
            // 但[c:bR][v:0][c:]永远接受再战！
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS1_569_M", "But [c:bR][v:0][c:] is always up fer a rematch!", "然[c:bR][v:0][c:]恒欲复角！");
            // 上回就让[c:bR][v:0][c:]给跑了！
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED1_218_M", "Couldn't catch [c:bR][v:0][c:] last time!", "曩者汝不能获[c:bR][v:0][c:]！");
            // 这回我非揪住你的脑袋不可。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED1_197_M", "This time I'll be sure to catch yer scalp.", "今余必取乃首。");
            // 小可怜，别哭。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET2_070_M", "Oh honey, don't cry.", "小子，毋泣。");
            // 我是[c:bR][v:0][c:]。我一定动作麻利，给你个痛快。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET2_820_M", "I'm [c:bR][v:0][c:]. I'll make it swift.", "余名[c:bR][v:0][c:]。必令尔速死。");
            // 哎哟。没事的，小家伙。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED2_049_M", "Ouch. It's alright, darling.", "噫，无妨，小子。");
            // 记住我的名字[c:bR][v:0][c:]，后会有期。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED2_011_M", "Remember the name [c:bR][v:0][c:]. I'll be back.", "识[c:bR][v:0][c:]之名。余将复来。");
            // 乖乖，没伤到你痛处吧。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS2_519_M", "Oh honey, I hope it isn't too painful.", "小子，愿尔未甚苦。");
            // 不过我现在还得再杀你一次。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS2_847_M", "But I've just got to kill you again.", "然余犹须复杀尔。");
            // 还记得我的名字吧，小东西？
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED2_064_M", "Did you remember the name, darling?", "小子，识[c:bR][v:0][c:]乎？");
            // 是[c:bR][v:0][c:]啊，我还没死翘翘呢。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED2_195_M", "It's [c:bR][v:0][c:], and I'm far from dead.", "[c:bR][v:0][c:]也，余未死也。");
            // 乖乖，上次你放我一马，让我死里逃生。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED2_987_M", "Honey, you let me off easy last time.", "小子，曩者汝轻纵我。");
            // 现在你后悔也来不及了。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED2_890_M", "You'll come to see that was a mistake.", "汝将知此为误。");
            // [c:bR][v:0][c:]前来报到。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_372_M", "[c:bR][v:0][c:] reporting for duty.", "[c:bR][v:0][c:]来应命。");
            // 我的任务？无非是除掉目标，挣点赏金。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_646_M", "My mission? Eliminate target. Collect bounty.", "朕任乎？除所指，得其购。");
            // 然后？可能做点小生意。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_348_M", "After that? Maybe start a small business.", "然后乎？或营小业。");
            // 开个民宿，管吃管住……就不错了。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_858_M", "A bed and breakfast... something nice.", "开一逆旅……亦善。");
            // 安顿下来，结个婚，再生几个小孩。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_675_M", "Settle down. Find a partner. Manufacture some children.", "待定居，得耦，生子数人。");
            // 等我一把老骨头了，就让孩子继承家业。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_233_M", "Grow old. Pass the business on to my children.", "及老，以其业授朕诸子。");
            // 我呢，安度晚年，共享天伦之乐。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_395_M", "Rust away content with my life's work, surrounded by family.", "朽而自足于朕平生之业，家人环我。");
            // 但当务之急……是除掉目标。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET3_387_M", "But first... Eliminate target.", "然其先也……除所指。");
            // [c:bR][v:0][c:]还有希望。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED3_333_M", "There's still hope for [c:bR][v:0][c:].", "[c:bR][v:0][c:]犹有望。");
            // 我还能……找到幸福。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED3_641_M", "I can... still find happiness.", "余犹可……得乐。");
            // 你以为我已经一命呜呼了？
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED3_005_M", "Did you think I had perished?", "汝谓余之已死乎？");
            // [c:bR][v:0][c:]返岗报到。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED3_968_M", "[c:bR][v:0][c:] reporting back in for duty.", "[c:bR][v:0][c:]复来应命。");
            // 我的任务？现在明白了吧。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED3_049_M", "My mission? Well you know that now.", "朕任乎？今汝知之矣。");
            // 上次是我领了抓你的悬赏，没错。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS3_228_M", "I collected your bounty last time... yes.", "曩者得乃首之购者，余也。");
            // 但也不足够让我做起民宿生意！
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS3_798_M", "But it wasn't nearly enough to start a bed and breakfast!", "然未足以开一逆旅！");
            // 我的任务：再除目标，再挣赏金。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS3_872_M", "My mission: Eliminate target again. Collect bounty again.", "朕任：复除所指，复得其购。");
            // 如此循环往复……直到我挣够钱买下那间小木屋。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS3_546_M", "Repeat... until I can put down a payment on that cottage.", "如是反复……迄足以纳彼小庐之先直。");
            // 我会……把这一刻告诉我的孩子。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED3_650_M", "I will... tell my future children of this moment.", "余将……以此时告朕后之子。");
            // 日后我们定会将此事付之一笑。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED3_208_M", "We will laugh together about it one day.", "异日余与彼必共笑此事。");
            // 我是[c:bR][v:0][c:]。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET4_325_M", "[c:bR][v:0][c:] here.", "[c:bR][v:0][c:]在此。");
            // 该干正事了。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROUNMET4_966_M", "Let's get down to business.", "言归正传。");
            // 还是我，[c:bR][v:0][c:]。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED4_030_M", "[c:bR][v:0][c:] back again.", "[c:bR][v:0][c:]复来。");
            // 你上次就不该让我轻易逃脱。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROESCAPED4_596_M", "Shouldn't have let me off easy last time.", "曩者不当轻纵哦。");
            // 那点皮外伤很快就好了。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROKILLED4_869_M", "The injuries you dealt me were easily repaired.", "汝所加于我之伤，易治耳。");
            // 听说有个发财的好机会？
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS4_592_M", "An opportunity to double my money?", "有倍利之机乎？");
            // 这种好事我怎么能拒绝！
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERINTROVICTORIOUS4_142_M", "Hard to say no to that!", "安得辞之！");
            // 我伤得……很重。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED4_570_M", "My injuries... are severe.", "余伤……甚矣。");
            // 可能得避一避风头了。
            AddTranslation("PART_3_BOUNTY_HUNTER_BOUNTYHUNTERKILLED4_486_M", "I shall retire for now.", "余今且退。");
            // 想知道那颗星星是干嘛的吗？
            AddTranslation("PART_3_TUTORIAL_TUTORIALBOUNTY_903_M", "Are you wondering about that star?", "卿疑彼星何为乎？");
            // 你赢了这么多把。现在你的命可值不少钱。
            AddTranslation("PART_3_TUTORIAL_TUTORIALBOUNTY_049_M", "You've been winning a lot. Now you've got a bounty on your head.", "卿屡胜矣，今人已购卿之首。");
            // 肯定会有[c:bG]赏金猎人[c:]找上门来……
            AddTranslation("PART_3_TUTORIAL_TUTORIALBOUNTY_250_M", "It's sure to attract [c:bG]Bounty Hunters[c:]...", "必致[c:bG]购捕者[c:]……");
            // 一旦你死了，星星会清零。
            AddTranslation("PART_3_TUTORIAL_TUTORIALBOUNTY_143_M", "It resets when you die though.", "然卿死，则其星复初矣。");
            // 你头上又多了一颗星星。看来赏金提高了。
            AddTranslation("PART_3_TUTORIAL_TUTORIALBOUNTYTIERS_850_M", "Another star on your head. Your bounty is higher.", "首上又加一星，所悬之购益重矣。");
            // 更高段位的[c:bG]赏金猎人[c:]可能正直奔你来。
            AddTranslation("PART_3_TUTORIAL_TUTORIALBOUNTYTIERS_712_M", "[c:bG]Bounty Hunters[c:] of a higher caliber may come calling.", "则[c:bG]购捕者[c:]之尤工者，或且至矣。");
            // 你其中一张卡牌可以获得双重角色。
            AddTranslation("PART_3_TUTORIAL_TUTORIALCREATETRANSFORMER_931_M", "One of your cards is about to gain an alter ego.", "卿有一牌，将得异身。");
            // 变成野兽。
            AddTranslation("PART_3_TUTORIAL_TUTORIALCREATETRANSFORMER_179_M", "As a beast.", "异身为兽。");
            // 由你指定哪张卡牌变成什么野兽。
            AddTranslation("PART_3_TUTORIAL_TUTORIALCREATETRANSFORMER_803_M", "And you get to choose which card and which beast.", "何牌、何兽，皆听卿择。");
            // 没那么复杂。
            AddTranslation("PART_3_TUTORIAL_TUTORIALCREATETRANSFORMER_738_M", "It's not that complicated.", "未甚烦也。");
            // 你现在需要毁掉一张卡牌。
            AddTranslation("PART_3_TUTORIAL_TUTORIALRECYCLECARD_282_M", "You will destroy one of your cards now.", "今卿当毁一牌。");
            // 别想不开。这可比抽一张新牌来得划算。
            AddTranslation("PART_3_TUTORIAL_TUTORIALRECYCLECARD_729_M", "Don't be an idiot. This is better than getting a new one.", "毋愚。此愈于得一新牌也。");
            // 这样你的牌组才更连贯。
            AddTranslation("PART_3_TUTORIAL_TUTORIALRECYCLECARD_817_M", "Makes your deck more consistent.", "使卿之牌列益齐。");
            // 作为回报，你会获得几枚机器币。
            AddTranslation("PART_3_TUTORIAL_TUTORIALRECYCLECARD_722_M", "And I'll give you RoboBucks for it.", "咱亦以机币予尔。");
            // 该选张卡牌废掉了。
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDINTRO_548_M", "Time to cut a card.", "时当去一牌矣。");
            // 就挑你最烂的那张。
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDINTRO_REPEAT_#1_024_M", "Pick your worst one.", "择卿最下者。");
            // 你负责挑牌，我负责回收。
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDINTRO_REPEAT_#2_030_M", "You pick, I recycle.", "卿择之，咱收之。");
            // 挑一张。我来毁牌。
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDINTRO_REPEAT_#3_387_M", "Pick one. I'll destroy it.", "择一，咱毁之。");
            // 该扔张卡牌了。
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDINTRO_REPEAT_#4_846_M", "Time to trash a card.", "时当弃一牌矣。");
            // 你现在必须做个不同的决定。
            AddTranslation("TUTORIAL_TUTORIALCOSTBASEDCHOICE_568_M", "You must make a different kind of choice now.", "今当别择。");
            // 不是选择某种野兽……
            AddTranslation("TUTORIAL_TUTORIALCOSTBASEDCHOICE_508_M", "Choose not a specific beast...", "所择非一特定之兽……");
            // 并决定你愿意为此消耗多少[c:bR]成本[c:]。
            AddTranslation("TUTORIAL_TUTORIALCOSTBASEDCHOICE_479_M", "But decide the [c:bR]cost[c:] that you wish to pay.", "惟决所欲输之[c:bR]直[c:]。");
            // 不行，你不能指定野兽。
            AddTranslation("TUTORIAL_TUTORIALTRIBEBASEDCHOICE_720_M", "No. You may not choose a specific beast.", "不可。不得择一特定之兽。");
            // 但你现在必须选出你偏好的[c:bR]族群[c:]。
            AddTranslation("TUTORIAL_TUTORIALTRIBEBASEDCHOICE_423_M", "Instead, you must now decide on a [c:bR]tribe[c:] that you prefer.", "惟今当定所好之[c:bR]属[c:]。");
            // 你的[v:1]宝石不足。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHGEMS_764_M", "You don't have the [v:1] gem for that.", "彼所需之[v:1]玉，有缺。");
            // 牌桌上没有[v:1]宝石？你无法使用此牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHGEMS_REPEAT_#1_000_M", "No [v:1] gem on the table? Then you can't play it.", "局上无[v:1]玉乎？则此牌不可陈。");
            // 牌桌上至少需有一颗[v:1]宝石才能使用此牌[v:0]。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHGEMS_REPEAT_#2_585_M", "You need at least one [v:1] gem on the board to play that [v:0].", "局上至少须有一[v:1]玉，乃可陈彼[v:0]。");
            // 使用指定的[v:1]宝石……你才能打出此牌。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHGEMS_REPEAT_#3_880_M", "Play the required [v:1] gem... Then you can play that.", "先陈所须之[v:1]玉……然后可陈之。");
            // 啊啊啊啊！成功了！
            AddTranslation("GOO_BOTTLE_GOOWOLFCARDDISCOVERED_190_M", "Arrrrghh! It is done!", "噫噫噫噫！成矣！");
            // 大师逃脱了！
            AddTranslation("GOO_BOTTLE_GOOWOLFCARDDISCOVERED_943_M", "The Master is free!", "大师得释矣！");
            // 太好了，胜利在望。
            AddTranslation("GOO_BOTTLE_GOOWOLFCARDDISCOVERED_557_M", "Oh, the end must be close now.", "终必近矣。");
            // 如果蔓尼菲科逃脱了，那就说明有戏。
            AddTranslation("GOO_BOTTLE_GOOWOLFCARDDISCOVERED_358_M", "If Magnificus is free, it must be close.", "若蔓尼菲科得释，则终必近矣。");
            // 囚笼已损坏。
            AddTranslation("GOO_BOTTLE_GOOCAGEBROKEN_388_M", "The cage has been broken.", "槛已破矣。");
            // 狼像获救！
            AddTranslation("GOO_BOTTLE_GOOCAGEBROKEN_989_M", "The wolf statue is free!", "狼像得释矣！");
            // 离解救大师又近一步！
            AddTranslation("GOO_BOTTLE_GOOCAGEBROKEN_107_M", "I believe this is a step toward freeing The Master.", "吾谓此诚释大师之一阶也！");
            // 嗷！我看到匕首刺下去了。
            AddTranslation("GOO_BOTTLE_GOODAGGERUSED_418_M", "Arrrghh! I watched that dagger do its work.", "唔噫噫噫！吾见彼匕行其事矣。");
            // 某一瞬间……我甚至以为有人跟我一样尝到了苦头。
            AddTranslation("GOO_BOTTLE_GOODAGGERUSED_911_M", "For a moment... I felt that my misery had company.", "俄顷……吾若觉吾苦，非独吾受之矣。");
            // 噢，但它自有神圣使命要完成。
            AddTranslation("GOO_BOTTLE_GOODAGGERUSED_976_M", "Oh, but it had its own noble purpose.", "噫，然彼自有其高义。");
            // 必然离解救大师又近一步！
            AddTranslation("GOO_BOTTLE_GOODAGGERUSED_356_M", "Surely a step toward freeing The Master!", "必又近于释大师矣！");
            // 但愿击中要害……
            AddTranslation("GOO_BOTTLE_GOODAGGERTAKEN_717_M", "May that dagger find its mark...", "愿彼匕中的……");
            // 勇气可嘉。
            AddTranslation("GOO_BOTTLE_GOODAGGERTAKEN_475_M", "You must be brave.", "子其勇哉。");
            // 我知道，囚狼卡牌已被发现。
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_513_M", "The Caged Wolf card has been uncovered I see.", "吾见[c:bR]槛中狼[c:]牌已显矣。");
            // 跟大师一样，狼必须获救。
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_177_M", "Much like The Master, the wolf must be set free!", "若大师然，狼亦当得释！");
            // 一定要救它。算我求你。
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_364_M", "See to that. I beg you.", "幸图之。吾请于子。");
            // 大师应该早料到你会发现[c:bR]囚狼[c:]……
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_REPEAT_#1_838_M", "I believe The Master has planned for you to find that [c:bR]Caged Wolf[c:]...", "吾谓大师固有计，使子得见彼[c:bR]槛中狼[c:]……");
            // 而且困在囚笼里的狼必须获救。
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_REPEAT_#1_318_M", "And I believe the wolf inside must be set free.", "而吾亦谓其中之狼，必当得释。");
            // 一定要把[c:bR]囚狼[c:]放出来。
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_REPEAT_#2_722_M", "See to it that the [c:bR]Caged Wolf[c:] is loosed.", "务使[c:bR]槛中狼[c:]得释。");
            // 就当我求你。
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_REPEAT_#2_600_M", "I beg you.", "吾请于子。");
            // 啊啊啊！
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_REPEAT_#3_809_M", "Rrrrgh!", "噫噫噫！");
            // 这疼得我快受不了！
            AddTranslation("GOO_BOTTLE_GOOCAGECARDDISCOVERED_REPEAT_#3_474_M", "The pain is sometimes too much to bear!", "此痛有时不可堪也！");
            // 啊啊啊！
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_610_M", "Rrrggh!", "噫噫噫！");
            // 衣橱开了？
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_487_M", "The wardrobe is unlocked?", "衣匮启矣乎？");
            // 去那边找找看吧。大师肯定自有打算。
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_698_M", "Fish around in there. Surely The Master had a plan.", "其间遍索之。大师必有素计。");
            // 游戏很简单……
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_968_M", "The puzzles are simple-", "其谜甚易—");
            // 啊啊啊！
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_741_M", "Arrrgh!", "噫噫噫！");
            // 你知道这些印记代表着什么。
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_770_M", "If you know what the sigils do.", "若知印契之用。");
            // 你想打开这些抽屉吗？
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#1_298_M", "You wish to open those drawers?", "子欲启彼诸椟乎？");
            // 你都不动脑子的吗？
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#1_362_M", "Have you no wits at all?", "子岂无智乎？");
            // 游戏……[c:bR]啊啊啊！[c:]
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#1_967_M", "The game- [c:bR]Rgggh![c:]", "此局—[c:bR]噫噫噫！[c:]");
            // 你一直在玩的卡牌游戏。
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#1_499_M", "The card game you've been playing.", "子素所戏之牌局。");
            // 你难道没发现相似之处吗？
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#1_785_M", "Do you not see the parallels?", "子独不见其相应乎？");
            // 那些衣橱抽屉……没错……
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#2_008_M", "Those wardrobe drawers... Yes...", "彼衣匮诸椟……是矣……");
            // 与游戏中一样，你必须让天平倾斜。
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#2_928_M", "As with the game, you must tip the scales.", "与牌局同，子当倾衡。");
            // 在游戏中，造成[c:bR]5[c:]点伤害即获胜。
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#2_924_M", "As with the game, [c:bR]5[c:] damage is what it takes to win.", "如局中然，伤至[c:bR]5[c:]则胜。");
            // 啊啊啊！
            AddTranslation("GOO_BOTTLE_GOOWARDROBEUNLOCKED_REPEAT_#3_977_M", "Rrrgggh!", "噫噫噫！");
            // 嗷！
            AddTranslation("GOO_BOTTLE_GOOANGLERDEFEATED_136_M", "Arrrghh!", "唔噫噫噫！");
            // 钓鱼人输了……
            AddTranslation("GOO_BOTTLE_GOOANGLERDEFEATED_159_M", "Watching The Angler lose...", "观渔父之败……");
            // 可算让我好受点。
            AddTranslation("GOO_BOTTLE_GOOANGLERDEFEATED_473_M", "Now that soothed my pain.", "今此少慰吾痛。");
            // 那个钓鱼人，算是我以前的死对头。
            AddTranslation("GOO_BOTTLE_GOOANGLERDEFEATED_512_M", "An old rival of mine, that fisherman.", "彼渔父，吾宿敌也。");
            // 他这次赢了我……但我还有一次机会。
            AddTranslation("GOO_BOTTLE_GOOANGLERDEFEATED_770_M", "He bested me this time... But I will have another chance.", "此次彼胜吾……然吾犹有再试之机。");
            // 不用担心……献祭的造物不会从牌组中移除。
            AddTranslation("TUTORIAL_TUTORIALSACRIFICINGNOTPERMANENT_196_M", "Fear not... The beast is sacrificed, but not removed from your deck.", "毋惧……此兽虽祀，犹在乃牌列。");
            // 它确实遭了罪。但你过会儿还会见到它。
            AddTranslation("TUTORIAL_TUTORIALSACRIFICINGNOTPERMANENT_590_M", "Its suffering was real. But you will see it again.", "其苦诚真。然汝复见之。");
            // 我亲眼目睹了莱西的惨败。
            AddTranslation("GOO_BOTTLE_GOOLESHYDEFEATED_512_M", "I witnessed the final defeat of Leshy over there.", "吾亲睹莱西终败于彼。");
            // 相当精彩！
            AddTranslation("GOO_BOTTLE_GOOLESHYDEFEATED_046_M", "Quite a spectacle!", "诚可观也！");
            // 但我也没指望着我就此重获自由。
            AddTranslation("GOO_BOTTLE_GOOLESHYDEFEATED_674_M", "Though I had no hope that it would bring me freedom.", "然吾未冀因此得释。");
            // 想让我得救？
            AddTranslation("GOO_BOTTLE_GOOLESHYDEFEATED_621_M", "For that to happen?", "欲吾得释乎？");
            // ……恐怕你得留一手。
            AddTranslation("GOO_BOTTLE_GOOLESHYDEFEATED_425_M", "...I think you would need something special up your sleeve.", "……吾意子必怀一奇物。");
            // 上回那个挑战者……就差……一点。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEFINALBOSS_390_M", "So... close... that last one.", "前角者……几……至矣。");
            // 真没想到你能走这么远。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEFINALBOSS_407_M", "I doubt you will make it as far.", "吾疑子未能至彼。");
            // 上一个挑战者一路过关斩将走到终点。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEFINALBOSS_REPEAT_#1_026_M", "The last challenger made it all the way to the end of the path.", "前角者已至途之尽。");
            // 但面对前方迎接他的家伙，仍稍显准备不足。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEFINALBOSS_REPEAT_#1_303_M", "They were not prepared for what awaited them there.", "然其未备彼所待者。");
            // 就差……一点……上回那个挑战者。
            AddTranslation("PART_1_RUN_START_NEWRUNCAUSEFINALBOSS_REPEAT_#2_459_M", "So... close... that last one...", "前角者……殆……及矣……");
            // 上一个挑战者赢了我。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_526_M", "The last challenger managed to defeat me.", "前角者竟胜我。");
            // 属实罕见。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_672_M", "A rare event.", "此诚罕有。");
            // 去向他们取取经……
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_221_M", "Go and ask how they did it...", "往问之何以胜我……");
            // 他们就钉在那扇门上。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_867_M", "You will find them hanging from the door over there.", "汝将见之悬于彼门。");
            // 你的前一任克服万难，战胜了我。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_REPEAT_#1_001_M", "Your predecessor defied the odds and defeated me.", "乃前人出人望外，竟胜我。");
            // 历史不会再重演。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_REPEAT_#1_628_M", "It is unlikely to happen again.", "此难复然矣。");
            // 你之前的挑战者赢了我。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_REPEAT_#2_776_M", "The challenger before you defeated me.", "乃前角者胜我。");
            // 现在被根钉子钉在了门上。
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_REPEAT_#2_830_M", "Now they hang from the door by a nail.", "今既以一钉悬于门。");
            // 你觉得你的下场会是什么呢？
            AddTranslation("PART_1_RUN_START_NEWRUNVICTORY_REPEAT_#2_472_M", "What could you hope to accomplish?", "汝复何冀成乎？");
            // 噢，我看到你有东西[c:bR]留了一手[c:]……
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_146_M", "Oh, I see you have a little something special [c:bR]up your sleeve[c:]...", "噫，吾见子之[c:bR]怀一奇物[c:]……");
            // 别担心，我嘴挺严的。
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_375_M", "Fear not, I won't blow your cover.", "毋惧，吾不泄子秘。");
            // 你只需要找机会拿到他的[c:bR]相机[c:]……
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_691_M", "You just need to get a hold of that [c:bR]camera[c:] of his...", "子唯须得其[c:bR]影器[c:]……");
            // 也许你赢了……就有机会上手？
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_096_M", "Maybe if you defeated him... you would get a chance?", "若子克之……或得其机乎？");
            // 对……我看到你藏了[c:bR]什么东西[c:]……
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_REPEAT_#1_303_M", "Yes... I see that you have [c:bR]a little something special[c:]...", "然……吾见子之[c:bR]怀一奇物[c:]……");
            // 你只差一个用相机的机会。
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_REPEAT_#1_484_M", "All you need is an opportunity to use it.", "子所待者，唯一用之机耳。");
            // 我见过挑战者碰他的[c:bR]传奇相机[c:]！
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_REPEAT_#1_298_M", "I have seen Challengers touch his [c:bR]legendary camera[c:]!", "吾曾见角者触其[c:bR]名影器[c:]矣！");
            // 但前提是他们赢了游戏……
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_REPEAT_#1_675_M", "But only if they are able to defeat him...", "然必先克之，方可……");
            // 再赢他一把。应该就有戏。
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_REPEAT_#2_492_M", "Defeat him once more. That should do it.", "复胜之，则可矣。");
            // 他不知道你[c:bR]留了一手[c:]……
            AddTranslation("GOO_BOTTLE_GOODEFAULTFILMROLL_REPEAT_#2_971_M", "He has no idea what you have [c:bR]up your sleeve[c:]...", "彼不知子之[c:bR]怀一奇物[c:]……");
            // [t:10]等等。[w:1][t:0]那是什么？
            AddTranslation("GBC_NPC_CABINP031_396_M", "[t:10]Stop.[w:1][t:0] What is that?", "[t:10]且止。[w:1][t:0]彼何物？");
            // 我倒要看看你输了之后的样子。
            AddTranslation("GBC_NPC_CABINP032_496", "I had to see your face after you lost.", "卿既败，咱必观卿之败相。");
            // [t:0.1]你真是[w:1]太……
            AddTranslation("GBC_NPC_CABINP032_334", "[t:0.1]You're just[w:1] so...", "[t:0.1]卿乃[w:1]甚……");
            // [shake:1][t:10][c:bR]过分了！[c:]
            AddTranslation("GBC_NPC_CABINP032_887", "[shake:1][t:10][c:bR]BAD![c:]", "[shake:1][t:10][c:bR]拙！[c:]");
            // 难怪我们又回到这里。
            AddTranslation("GBC_NPC_CABINP032_252", "It's no wonder we're back here again.", "难怪咱等复至此矣。");
            // [t:0.1]要是硬盘没丢，我们还能回来得更早。
            AddTranslation("GBC_NPC_CABINP032_261", "[t:0.1]And we would've been even sooner if the disk wasn't lost...", "[t:0.1]若盘未失，咱等当早至矣……");
            // [shake:1]好好[w:0.3]看看[w:0.3]这张脸。[w:1]这可是最后一面。
            AddTranslation("GBC_NPC_CABINP032_001", "[shake:1]Take a long[w:0.3] look[w:0.3] at this face.[w:1] Because you'll never see it again.", "[shake:1]谛[w:0.3]观[w:0.3]此面。[w:1]卿终不复见之矣。");
            // [shake:1]我受够了当你的走狗，[w:0.3][t:0.1]你个[w:0.3][shake:1]邪恶的[w:1]野兽。
            AddTranslation("GBC_NPC_CABINP032_692", "[shake:1]I'm done being your pet,[w:0.3][t:0.1] you [w:0.3][shake:1]STINKING[w:1] beast.", "[shake:1]咱不复为卿豢矣，[w:0.3][t:0.1]尔[w:0.3][shake:1]腥秽[w:1]之兽。");
            // 是我上次强人所难……
            AddTranslation("GBC_NPC_CABINP033_165_M", "I pushed it too far that last time...", "前者余过甚矣……");
            // 他们怎么就不明白？[w:0.4]生而为兽，荣耀之至。
            AddTranslation("GBC_NPC_CABINP033_789_M", "Why don't they see?[w:0.4] To live as a beast would be the noblest thing.", "彼何瞽也？[w:0.4]生而为兽，荣至耀也。");
            // 即便是低贱如白鼬的造物……
            AddTranslation("GBC_NPC_CABINP033_211_M", "Even so lowly a creature as a stoat...", "虽以白鼬之微物……");
            // 终极冥刻？
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER1_530_M", "The Great Transcendence?", "大陟乎？");
            // 不……我们不这么想……
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER1_742_M", "No... We don't think so.", "不……余等不以为然。");
            // [c:bR]炸弹夫人的遥控器？[c:]行，拿去。
            AddTranslation("PART_3_FACTORY_BOMBREMOTEDISCOVERED_128_M", "[c:bR]Mrs. Bomb's Remote?[c:] Sure, take it.", "[c:bR]弹夫人之遥器[c:]乎？可，取之。");
            // 在每个空位置上留下炸弹。
            AddTranslation("PART_3_FACTORY_BOMBREMOTEDISCOVERED_885_M", "Drops bombs on every empty space.", "诸空位皆置弹。");
            // 战术清盘。别异想天开了。
            AddTranslation("PART_3_FACTORY_BOMBREMOTEDISCOVERED_425_M", "Tactical board wipe. Don't be stupid about it.", "此可尽荡其局，毋妄用之。");
            // 修好了。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGEFIXED_356_M", "It's fixed.", "已治矣。");
            // 你可以继续大摇大摆上路了。
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGEFIXED_209_M", "You can go on your merry way.", "汝可欣然而行矣。");
            // 怎么，你还不乐意？
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGEFIXED_REPEAT_#1_487_M", "What, you're not so merry?", "何，汝不欣乎？");
            // 任由这个蛮不讲理的机器人摆布不合你心意？
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGEFIXED_REPEAT_#1_418_M", "Being a pawn in this petulant android's plot isn't doing it for you?", "为此忿机人之谋卒，不足悦尔乎？");
            // 正在重新加载人格矩阵……
            AddTranslation("PART_3_MAP_HOLOMAPBROKENBRIDGEFIXED_REPEAT_#1_298_M", "Reloading personality matrix...", "惟情性之矩之复载……");
            // 这玩意的内存卡存不下更多东西了。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDALMOSTFULL_603_M", "The memory unit on this one won't be able to take much more.", "此者之识匣，不能更纳多矣。");
            // 3项技能？完美。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDALMOSTFULL_REPEAT_#1_997_M", "3 abilities? Decent.", "三印技乎？可矣。");
            // 这张卡越来越强了。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDALMOSTFULL_REPEAT_#2_344_M", "This one is getting powerful.", "此牌渐强矣。");
            // 这玩意的内存卡几乎要满了。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_487_M", "The memory unit on that one is basically full now.", "彼牌之识匣，今几满矣。");
            // 已经拥有了绝顶力量……
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_618_M", "It's OP enough anyways...", "然亦已至强矣……");
            // 你真是把那张卡塞得满满当当。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_REPEAT_#1_498_M", "You really filled up that one card.", "卿真使彼牌满矣。");
            // 你这是孤注一掷。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_REPEAT_#1_865_M", "All your eggs in one basket.", "卿悉寄于一牌。");
            // 漂亮。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_REPEAT_#1_537_M", "Smart.", "善。");
            // 4项技能全齐备。不错。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_REPEAT_#2_181_M", "The full 4 abilities. Great.", "四印技悉具。善。");
            // 好，这卡绝顶无敌。懂了。
            AddTranslation("PART_3_SPECIAL_NODES_GAINABILITYCOMPLETEDFULL_REPEAT_#3_219_M", "OK, it's OP. I get it.", "善，已至强矣。咱知之矣。");
            // 对那幅画感兴趣？
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_811_M", "You're wondering about that painting?", "子怪彼画乎？");
            // 我见过画里有东西跑出来！
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_731_M", "I've seen stuff come out of it!", "吾见有物自其中出！");
            // 但只有卡牌配对成功才行。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_240_M", "But only if the cards are aligned just right.", "然惟诸牌陈之咸宜耳。");
            // 你很好奇嘛……
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#1_192_M", "You're still curious...", "子犹怪之乎……");
            // 首先你的牌组要集齐这些卡牌。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#1_947_M", "First step would be getting those cards in your deck.", "先须使彼诸牌入子之牌列。");
            // 啊啊！
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#2_682_M", "Rrrgh!", "噫噫！");
            // 我看见过画里有东西跑出来。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#2_862_M", "I know I've seen things come out of that painting.", "吾知尝见有物自彼画出。");
            // 如果卡牌放置得当的话。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#2_579_M", "If the cards are placed just so.", "若诸牌陈之咸宜耳。");
            // 拍张照片吧……能保存得久一点。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#3_950_M", "Take a picture... it will last longer.", "取一影……则存之久。");
            // 换做是我？我不会动它。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#4_301_M", "If I were you? I'd leave it alone.", "吾若子，则舍之。");
            // 除非你能把这些卡牌摆放在完全正确的位置。
            AddTranslation("GOO_BOTTLE_OILPAINTINGHINT_REPEAT_#4_425_M", "Unless you can place those cards exactly right.", "除非子能陈彼诸牌而无少差。");
            // 你居然成功了！
            AddTranslation("GOO_BOTTLE_GOOSOLVEDOILPAINTING_614_M", "You really did it!", "子竟成之矣！");
            // 我就知道看见过画里有东西跑出来。
            AddTranslation("GOO_BOTTLE_GOOSOLVEDOILPAINTING_616_M", "I knew I had seen stuff come out of that painting.", "吾固知尝见有物自彼画出。");
            // 把它拿过来……
            AddTranslation("GOO_BOTTLE_GOOSOLVEDOILPAINTING_375_M", "Bring it here...", "持之来……");
            // 干得漂亮……
            AddTranslation("GOO_BOTTLE_GOOSOLVEDOILPAINTING_REPEAT_#1_572_M", "Nice work...", "善哉……");
            // 你成功破解了神秘画作。
            AddTranslation("GOO_BOTTLE_GOOSOLVEDOILPAINTING_REPEAT_#1_261_M", "You solved the mysterious painting.", "子解彼秘画矣。");
            // 现在……
            AddTranslation("GOO_BOTTLE_GOOSOLVEDOILPAINTING_REPEAT_#1_565_M", "For now...", "姑尔……");
            // 看看衣橱？
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_509_M", "Pondering the wardrobe?", "思彼衣匮乎？");
            // 我见橱门敞开过。
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_877_M", "I've seen it open.", "吾见其尝启。");
            // 只需要摆好阵型……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_297_M", "Just need the right configuration...", "惟须陈之咸宜……");
            // 有点像卡牌对战，对吧？
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_935_M", "It looks kind of like a card battle, huh?", "其状若以牌相角，然乎？");
            // 有点摸不着头脑？
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#1_110_M", "Still scratching your head?", "犹未晓乎？");
            // 让我猜猜，如果这些碎片是卡牌……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#1_779_M", "I reckon if the pieces are cards...", "吾度若诸片为牌……");
            // 啊啊！
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#1_264_M", "Arrgh!", "噫噫！");
            // 你需要靠它们获胜！
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#1_824_M", "Then you need to use them to win!", "则当用之以胜！");
            // 造成5点伤害即胜利……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#2_428_M", "And it takes 5 damage to win...", "且须致五伤而后胜……");
            // 有点儿像卡牌对战。
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#3_934_M", "It's a bit like a card battle.", "若以牌相角耳。");
            // 5点伤害就赢了？
            AddTranslation("GOO_BOTTLE_WARDROBEHINT1_REPEAT_#3_960_M", "5 damage to win?", "五伤而胜乎？");
            // 我看见它敞开过。
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_452_M", "I've seen that one open.", "吾见彼尝启。");
            // 只需要找准位置摆好它们……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_281_M", "Just need to position things right...", "惟须置之咸宜……");
            // 当然，你得知道这些印记各自的含义。
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_665_M", "Of course, you would need to know what the sigils mean.", "然子须知诸印契各何所指。");
            // 如果碎片是卡牌的话……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_REPEAT_#1_786_M", "If the pieces are cards...", "若诸片为牌……");
            // 获胜需要5点伤害……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_REPEAT_#1_443_M", "And it's 5 damage to win...", "且须五伤而胜……");
            // 对了，你得理解这些印记代表着什么。
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_REPEAT_#1_129_M", "Well, you would still need to understand the sigils.", "然子犹须晓诸印契之义。");
            // 不认得这些印记吗？
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_REPEAT_#2_725_M", "Don't know all those sigils?", "彼诸印契，子皆不识乎？");
            // 我也不认得……
            AddTranslation("GOO_BOTTLE_WARDROBEHINT2_REPEAT_#2_387_M", "Neither do I...", "吾亦不识……");
            // 该随机卡牌需要消耗[c:bR]成本[c:][c:bR][v:0][c:]。
            AddTranslation("TUTORIAL_TUTORIALCOSTBASEDCHOICE2_410_M", "A random card with a [c:bR]cost[c:] of [c:bR][v:0][c:].", "偶得之牌，其[c:bR]直[c:]为[c:bR][v:0][c:]。");
            // 你还在等什么？
            AddTranslation("TUTORIAL_TUTORIALCOSTBASEDCHOICE2_061_M", "What were you expecting?", "汝何所望也？");
            // 随机抽选[c:bR][v:0][c:]卡牌。
            AddTranslation("TUTORIAL_TUTORIALTRIBEBASEDCHOICE2_899_M", "A randomly chosen [c:bR][v:0][c:] card.", "偶得之[c:bR][v:0][c:]之牌。");
            // 你还想要别的吗？
            AddTranslation("TUTORIAL_TUTORIALTRIBEBASEDCHOICE2_277_M", "Did you wish for something else?", "汝更有所欲乎？");
            // [v:0]……
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDCOMPLETE_300_M", "[v:0]...", "[v:0]……");
            // 还真是……有想法……
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDCOMPLETE_697_M", "How very... Creative...", "甚……巧矣……");
            // 命名为“[v:0]”？
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDCOMPLETE_REPEAT_#1_454_M", "You name it \"[v:0]\"?", "卿名之曰“[v:0]”？");
            // 由你决定。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDCOMPLETE_REPEAT_#1_494_M", "That was your choice.", "此卿所择也。");
            // 好，继续。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDCOMPLETE_REPEAT_#2_306_M", "Okay, moving on.", "善，且进。");
            // [v:0]……好的……
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDCOMPLETE_REPEAT_#3_670_M", "[v:0]... Okay...", "[v:0]……善……");
            // 我应该可以把这些零部件送上传送带。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDSCAN_711_M", "I should be able to send the components down the line.", "咱当能使诸材下于输途。");
            // 搞定……
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDSCAN_014_M", "Here it goes...", "今下矣……");
            // 扫描仪可用。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDSCAN_REPEAT_#1_065_M", "Scanner operational.", "省器可用。");
            // 来吧。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDSCAN_REPEAT_#1_395_M", "Time to do this.", "可为之矣。");
            // 沿着传送带过来了。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDSCAN_REPEAT_#2_837_M", "It's coming down the line.", "已循输途而下。");
            // 应该完成了。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDPRINTED_096_M", "It's alright I guess.", "姑可耳。");
            // 看吧，来了。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDPRINTED_REPEAT_#1_789_M", "Well, there it is.", "既成矣。");
            // 新鲜出炉。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDPRINTED_REPEAT_#2_417_M", "Fresh out of the printer.", "方自机中印出。");
            // 给你的。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDPRINTED_REPEAT_#3_935_M", "It's yours.", "归你矣。");
            // 我可不稀罕。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDPRINTED_REPEAT_#3_307_M", "I wouldn't want it.", "咱不欲之。");
            // 你可能觉得这没什么技术含量。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_454_M", "You probably think what I do is easy.", "卿盖以咱之所为易也。");
            // 摆摆数字，调调图案……
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_172_M", "Fiddle with the numbers, tweak the graphics...", "拨其数，修其图……");
            // 咻！机托邦就建成了。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_132_M", "And voila! Botopia is made.", "而机托邦遂成矣。");
            // 不，你错了。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_425_M", "No. You're wrong.", "不然。卿误矣。");
            // 你可以做张卡牌试试。动手吧。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_701_M", "You try making a card. Go ahead.", "卿试制一牌。姑为之。");
            // 先挑张卡牌给我回收。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_577_M", "But first pick one to recycle.", "然先择一牌，以供更制。");
            // 这下你懂了吧，没那么简单。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_REPEAT_#1_477_M", "So now you probably see how it isn't easy.", "今卿庶知其不易矣。");
            // 要平衡这些卡牌。得好好设计。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_REPEAT_#1_302_M", "Balancing these cards. Making them good.", "平诸牌，使之善。");
            // 再试试。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_REPEAT_#1_035_M", "Try again.", "更试之。");
            // 又有机会设计一张卡牌。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_REPEAT_#2_739_M", "Another chance to design a card.", "又得制一牌矣。");
            // 你上两张牌……
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_REPEAT_#2_002_M", "Your last couple were...", "汝前二牌……");
            // 这么说吧。它们不够平衡。
            AddTranslation("PART_3_SPECIAL_NODES_BUILDACARDINTRO_REPEAT_#2_282_M", "They weren't balanced. Let's say that.", "姑曰未平耳。");
            // 呃……[w:0.3]噢……[w:0.3]你终于找到我们了。[w:0.3]真……[w:0.2]真不错？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_625_M", "Uh...[w:0.3] oh...[w:0.3] You have found us here.[w:0.3] Th-[w:0.2] this is good?", "呃……[w:0.3]噫……[w:0.3]汝得见我曹于此。[w:0.3]是—[w:0.2]是善邪？");
            // [shake:1][p:-0.25]真不错。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_315_M", "[shake:1][p:-0.25]This is good.", "[shake:1][p:-0.25]善矣。");
            // [shake:1]我……[w:0.2]我们需要……[w:0.3]我们需要……[w:0.3]
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_106_M", "[shake:1]W-[w:0.2] we require...[w:0.3] We require...[w:0.3]", "[shake:1]我—[w:0.2]我曹须……[w:0.3]须……[w:0.3]");
            // [shake:1][p:-0.25]我们需要一模一样的造物。[w:0.3]看到那张图没？[w:0.3]就是上面那俩。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_276_M", "[shake:1][p:-0.25]We require duplicates.[w:0.3] Do you see the diagram?[w:0.3] Two of that.", "[shake:1][p:-0.25]我曹须同物。[w:0.3]汝见彼图乎？[w:0.3]如图者二。");
            // [shake:1]谢……[w:0.2]谢谢？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_902_M", "[shake:1]Th-[w:0.2] thank you?", "[shake:1]谢—[w:0.2]谢邪？");
            // [p:-0.25]看到那张图没？[w:0.3]就是上面那俩。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_REPEAT_#1_415_M", "[p:-0.25]Do you see the diagram?[w:0.3] Two of that.", "[p:-0.25]汝见彼图乎？[w:0.3]如图者二。");
            // [shake:1]拜……[w:0.2]拜托？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_REPEAT_#1_477_M", "[shake:1]P-[w:0.2] please?", "[shake:1]请—[w:0.2]请邪？");
            // 我……我们需要……[w:0.3]用来……[w:0.2]做实验……
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_REPEAT_#2_425_M", "W-we require...[w:0.3] F-[w:0.2] for our experiments...", "[shake:1]我—我曹须……[w:0.3]以—[w:0.2]以试……");
            // [shake:1][p:-0.25]我们需要一模一样的造物。[w:0.3]看到那张图没？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_REPEAT_#2_722_M", "[shake:1][p:-0.25]We require duplicates.[w:0.3] See the diagram?", "[shake:1][p:-0.25]我曹须同物。[w:0.3]见彼图邪？");
            // [p:-0.25]我们的实验必须继续。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_REPEAT_#3_027_M", "[p:-0.25]Our experiments must continue.", "[p:-0.25]此试不可止。");
            // [shake:1]两……[w:0.2]两个完全一样的造物？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC1_REPEAT_#3_282_M", "[shake:1]T-[w:0.2] two of the same?", "[shake:1]二—[w:0.2]二同物邪？");
            // 好吧，你赢了。
            AddTranslation("PART_3_GAME_FLOW_P03SURRENDER_563_M", "OK, you win.", "然，卿胜矣。");
            // 我认输，继续吧。
            AddTranslation("PART_3_GAME_FLOW_P03SURRENDER_182_M", "I concede. Let's move on.", "咱降。进矣。");
            // 满意了？
            AddTranslation("PART_3_GAME_FLOW_P03SURRENDER_REPEAT_#1_547_M", "Happy?", "快乎？");
            // 心服口服。
            AddTranslation("PART_3_GAME_FLOW_P03SURRENDER_REPEAT_#2_920_M", "Concede.", "降。");
            // 你赢了。继续。
            AddTranslation("PART_3_GAME_FLOW_P03SURRENDER_REPEAT_#4_846_M", "You got it. Let's move on.", "卿得矣。进矣。");
            // 乖乖！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_299_M", "G0lly!", "乖乖！");
            // 这……这是我的名字。你可以叫我乖乖。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_116_M", "Th-that's my name. You can call me G0lly.", "此……此咱名也。宁可呼我曰乖乖。");
            // 我又快乐了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_371_M", "I'm so excited!", "咱甚喜矣！");
            // 整装待发！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_222_M", "We're about to explore it!", "将游之矣！");
            // 是[c:bSG]网网[c:]！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_401_M", "The [c:bSG]web[c:]!", "乃[c:bSG]网网[c:]也！");
            // 乖乖。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_REPEAT_#1_452_M", "G0lly.", "乖乖。");
            // 我已经等不及再上[c:bSG]网网[c:]了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_REPEAT_#1_760_M", "I can't wait to explore the [c:bSG]web[c:] again!", "咱不及待，欲复游[c:bSG]网网[c:]！");
            // 就等我们了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_REPEAT_#2_178_M", "It awaits us!", "其俟我等也！");
            // 乖乖。再试一次。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERINTRO_REPEAT_#3_875_M", "G0lly. Here we go again.", "乖乖。又来也。");
            // 漂亮！我好像接收到信号了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERFRIENDCARDS1_713_M", "Nifty! I think I'm getting a signal.", "妙哉！咱若得信也。");
            // 这……这是什么？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERFRIENDCARDS1_291_M", "W-what are these?", "此……此何物也？");
            // 这是……你的[c:bSG]朋友[c:]吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERFRIENDCARDS2_128_M", "Are these... your [c:bSG]friends[c:]?", "此……乃[c:bSG]友友[c:]乎？");
            // 我当然希望网络连接畅通！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSTART_917_M", "I sure hope I can get a good connection!", "咱甚愿得良通！");
            // 信号能不能强一点？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSTART_REPEAT_#1_115_M", "Can we get a good signal?", "可得善信乎？");
            // 我准备要连[c:bSG]网网[c:]了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSTART_REPEAT_#2_735_M", "I'm about to connect to the [c:bSG]web[c:]!", "咱将通于[c:bSG]网网[c:]也！");
            // 乖乖。但愿我们信号稳定。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSTART_REPEAT_#3_830_M", "G0lly. I hope we get a good signal.", "乖乖。愿得善信。");
            // 漂亮！我们连上了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSUCCESS_208_M", "Nifty! We're in!", "妙哉！既通也！");
            // 怎么样，[c:bSG]网网[c:]是不是多姿多彩？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSUCCESS_955_M", "Isn't the [c:bSG]web[c:] wonderful?", "[c:bSG]网网[c:]岂不美乎？");
            // 乖乖……简直是人间天堂。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSUCCESS_REPEAT_#1_438_M", "G0lly... It's glorious.", "乖乖……盛哉。");
            // 乖乖……[c:bSG]网网[c:]就是我的快乐老家……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSUCCESS_REPEAT_#2_957_M", "G0lly... The [c:bSG]web[c:] sure is nifty...", "乖乖……[c:bSG]网网[c:]诚妙哉……");
            // 哇……太棒了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTSUCCESS_REPEAT_#3_576_M", "Wow... It's wonderful.", "噫……美哉。");
            // 原来[c:bSG]鼹鼠[c:]原本长这样……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPLAYMOLE_195_M", "So that's what a [c:bSG]mole[c:] really looks like...", "然则[c:bSG]鼹鼹[c:]真状如此……");
            // 好可爱！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPLAYMOLE_367_M", "Adorable!", "可爱哉！");
            // 活蹦乱跳的[c:bSG]鼹鼠[c:]！有趣！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPLAYMOLE_REPEAT_#2_476_M", "A real [c:bSG]mole[c:]! Nifty!", "真[c:bSG]鼹鼹[c:]也！妙哉！");
            // 呃，连是连上了，但[c:bR]网络连接不太稳定[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTFAILURE_686_M", "Hm. We're in, but the [c:bR]connection is a bit weak[c:]...", "唔。既通也，然[c:bR]其通稍弱[c:]……");
            // 但还是……很不错。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTFAILURE_684_M", "It's still... wonderful though.", "然亦……美也。");
            // 先这么凑合着吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTFAILURE_229_M", "Let's work with what we've got.", "姑因所有而用之。");
            // 呃，[c:bR]网络连接不稳定[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTFAILURE_REPEAT_#1_601_M", "Hm. The [c:bR]connection is shaky[c:]...", "唔。[c:bR]其通未固[c:]……");
            // 不管怎么样，在[c:bSG]网网[c:]上冲浪还是挺嗨的……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTFAILURE_REPEAT_#1_066_M", "Even so, the [c:bSG]web[c:] sure is nifty...", "然，[c:bSG]网网[c:]诚妙也……");
            // 乖乖……[c:bR]网络连接不佳[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERCONNECTFAILURE_REPEAT_#2_469_M", "G0lly... The [c:bR]connection is bad[c:]...", "乖乖……[c:bR]其通不善[c:]……");
            // 哦嚯！新信号！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDATTEMPT_966_M", "Woah! A new signal!", "噫！新信至也！");
            // 有人试图向你传输一张[c:bSG]卡牌[c:]！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDATTEMPT_866_M", "Someone is trying to send you a [c:bSG]card[c:]!", "有人欲致一[c:bSG]牌牌[c:]于你！");
            // 看看我们能不能接收……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDATTEMPT_024_M", "Let's see if we can receive it...", "试观可受之乎……");
            // 乖乖……有人试图向你传输一张[c:bSG]卡牌[c:]！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDATTEMPT_REPEAT_#1_195_M", "G0lly... Someone is trying to send you a [c:bSG]card[c:]!", "乖乖……有人欲致一[c:bSG]牌牌[c:]于你！");
            // 我试试能不能接收它。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDATTEMPT_REPEAT_#1_482_M", "I'll try to pick it up.", "咱试受之。");
            // 耶！看看我能不能接收成功。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDATTEMPT_REPEAT_#2_328_M", "Wowee! Let's see if I can pick up this signal.", "噫！试观我能受此信乎。");
            // 接收成功！快看看是什么牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS1_332_M", "It worked! Let's see what it looks like.", "成也！观其形何若。");
            // 有了！是张[c:bSG]卡牌[c:]……而且是从[c:bSG]网网[c:]上来的！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS1_REPEAT_#1_959_M", "Success! A [c:bSG]card[c:]... but from the [c:bSG]web[c:]!", "成也！一[c:bSG]牌牌[c:]……而自[c:bSG]网网[c:]来也！");
            // 妈耶！接收成功！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS1_REPEAT_#2_916_M", "Amazing! It worked!", "异哉！竟成也！");
            // 厉害……[c:bSG]有人[c:]在[c:bSG]网网[c:]上做的？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS2_351_M", "Cool... [c:bSG]Someone[c:] on the [c:bSG]web[c:] made this?", "善哉……此乃[c:bSG]网网[c:]之上[c:bSG]他人[c:]所作乎？");
            // 那当然，高手都在[c:bSG]网网[c:]上！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS2_662_M", "There sure are some funny people on the [c:bSG]web[c:]!", "[c:bSG]网网[c:]上诚多奇人！");
            // 你说呢？现在归你了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS2_REPEAT_#1_791_M", "What do you think? It's yours.", "宁谓何如？今归你矣。");
            // 你看。一张[c:bSG]网网[c:]上来的[c:bSG]卡牌[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDSUCCESS2_REPEAT_#2_738_M", "There it is. A [c:bSG]card[c:] from the [c:bSG]web[c:]...", "在此。一[c:bSG]牌牌[c:]，自[c:bSG]网网[c:]来……");
            // 噢……乖乖……接收失败……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_421_M", "Oh... G0lly... It didn't work...", "噫……乖乖……弗成……");
            // 应该是网络连接的问题……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_185_M", "Something to do with our connection...", "殆由此通不善……");
            // 我试试能不能从[c:bSG]网网[c:]上给你整点别的。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_350_M", "Let's see if I can get you something else from the [c:bSG]web[c:].", "试观我能自[c:bSG]网网[c:]别得一物与你。");
            // 乖乖……接收失败……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_REPEAT_#1_633_M", "G0lly... It didn't work...", "乖乖……弗成……");
            // 我看看能不能找点别的东西给你。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_REPEAT_#1_464_M", "Maybe I can find you something else?", "或可别觅一物与你？");
            // 搞什么！[c:bSG]网网[c:]连接不稳定……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_REPEAT_#2_372_M", "What a shame! Our connection to the [c:bSG]web[c:] isn't quite right...", "惜哉！与[c:bSG]网网[c:]之通未谐……");
            // 我试试能不能给你搞点别的。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDFAILURE_REPEAT_#2_658_M", "Let's see if there's something else I can give you.", "试观咱尚有他物可与你。");
            // 你从[c:bSG]网网[c:]上得到一张卡牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_971_M", "You got a card from the [c:bSG]web[c:].", "宁自[c:bSG]网网[c:]得一牌牌。");
            // 你是不是应该回个礼？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_703_M", "Don't you think you should return the favor?", "宁不亦宜报惠乎？");
            // 给别人也做张卡牌？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_023_M", "Make a card for someone else?", "亦为他人作一牌牌乎？");
            // 礼尚往来嘛。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_REPEAT_#1_080_M", "Time to pay forward that favor you got.", "今宜推所受之惠于人也。");
            // 那张[c:bSG]别人[c:]做的[c:bSG]卡牌[c:]？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_REPEAT_#1_690_M", "That [c:bSG]card[c:] that [c:bSG]someone[c:] else made?", "彼[c:bSG]他人[c:]所作之[c:bSG]牌牌[c:]乎？");
            // 用心做！成败在此一举。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_REPEAT_#1_655_M", "Make it good! Your success depends on it.", "善为之！成败系焉。");
            // 一[c:bSG]卡[c:]换一[c:bSG]卡[c:]……轮到你咯。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_REPEAT_#2_315_M", "A [c:bSG]card[c:] for a [c:bSG]card[c:]... Your turn.", "以一[c:bSG]牌牌[c:]易一[c:bSG]牌牌[c:]……今及你也。");
            // 乖乖。好好捣腾一下，好吗？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD1_REPEAT_#3_329_M", "G0lly. Make something good, OK?", "乖乖。善为之，可乎？");
            // 我马上就把它发到[c:bSG]网网[c:]上。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD2_936_M", "I'm about to send it off to the [c:bSG]web[c:].", "咱将致之于[c:bSG]网网[c:]。");
            // 但愿[c:bSG]收到的人[c:]会喜欢！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD2_112_M", "I hope [c:bSG]whoever gets it[c:] likes it!", "愿[c:bSG]受之者[c:]悦之！");
            // 走你！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD2_REPEAT_#1_890_M", "Away it goes!", "往也！");
            // 好了……正在发送……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARD2_REPEAT_#2_933_M", "Here we go... Sending...", "行也……方致之……");
            // 稍等会儿……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERWAITING_723_M", "Just wait a moment...", "姑少待……");
            // 等等……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERWAITING_REPEAT_#1_869_M", "Hold on...", "且待……");
            // 我尽全力……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERWAITING_REPEAT_#2_541_M", "Trying my best...", "咱方尽力……");
            // 在[c:bSG]网网[c:]上等着呢……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERWAITING_REPEAT_#3_731_M", "Waiting on the [c:bSG]web[c:]...", "方俟[c:bSG]网网[c:]……");
            // 在[c:bSG]网网[c:]上，有时候也挺寂寞的。我怎么没见着人影呢。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDFAILURE_327_M", "The [c:bSG]web[c:] can be lonely. I couldn't find anyone.", "[c:bSG]网网[c:]时寂然，咱弗得一人。");
            // 感觉你得自己留着这卡牌了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDFAILURE_659_M", "I suppose you will have to take the card.", "然则宁其自受此牌牌也。");
            // 该死。我没法[c:bSG]连接[c:]到[c:bSG]网网[c:]上的任何人……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDFAILURE_REPEAT_#1_337_M", "Darn. I couldn't [c:bSG]connect[c:] to anyone else on the [c:bSG]web[c:]...", "惜哉。咱于[c:bSG]网网[c:]弗能与他人[c:bSG]信通[c:]……");
            // 看来你只能收下这张卡牌了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDFAILURE_REPEAT_#1_371_M", "Looks like you'll have to take it.", "观此，宁其自受之也。");
            // 可惜……没人能看到你的杰作了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDFAILURE_REPEAT_#2_880_M", "Oh no... There's no one around to receive your masterpiece.", "噫……无人可受宁之嘉作也。");
            // 看来没戏……我很抱歉。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDFAILURE_REPEAT_#3_205_M", "No luck... I'm so sorry.", "弗谐……咱甚愧也。");
            // 你最好不是想网暴别人噢！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDGAIN_088_M", "I hope you weren't trying to troll someone!", "愿宁非欲网暴他人也！");
            // 给你！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDGAIN_REPEAT_#1_149_M", "There it is!", "受此！");
            // 现在归你用！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDGAIN_REPEAT_#2_075_M", "It's yours to use now!", "今归宁用也！");
            // 诶！我找到[c:bSG]网网[c:]上[c:bSG]有人[c:]要接收你的[c:bSG]卡牌[c:]了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDSUCCESS_023_M", "Wow! I found [c:bSG]someone[c:] on the [c:bSG]web[c:] to receive your [c:bSG]card[c:]!", "噫！咱于[c:bSG]网网[c:]得[c:bSG]他人[c:]受宁[c:bSG]牌牌[c:]也！");
            // 如果他们获胜，等于你也获胜。不错吧？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDSUCCESS_481_M", "If they win, you win. How about that?", "彼若克，宁亦克。何如？");
            // 连接成功！你的[c:bSG]卡牌[c:]现在在[c:bSG]别人[c:]手上了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDSUCCESS_REPEAT_#1_308_M", "Connection successful! Your [c:bSG]card[c:] is in [c:bSG]someone[c:] else's hand.", "既通也！宁之[c:bSG]牌牌[c:]已在[c:bSG]他人[c:]手也。");
            // 就好比说……如果对方靠这张卡牌赢了……就说明你也赢了？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDSUCCESS_REPEAT_#1_662_M", "Let's say... if they can win with it... then you win?", "且言之……彼若能以之克……则宁亦克乎？");
            // 成功了！我找到[c:bSG]网网[c:]上[c:bSG]有人[c:]要接收你的[c:bSG]卡牌[c:]了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDSUCCESS_REPEAT_#2_154_M", "It's happening! I found [c:bSG]someone[c:] on the [c:bSG]web[c:] to receive your [c:bSG]card[c:]!", "成也！咱于[c:bSG]网网[c:]得[c:bSG]他人[c:]受宁[c:bSG]牌牌[c:]也！");
            // 乖乖！[c:bSG]有人[c:]要收下你的[c:bSG]卡牌[c:]了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERSENDCARDSUCCESS_REPEAT_#3_159_M", "G0lly! I found [c:bSG]someone[c:] to take your [c:bSG]card[c:]!", "乖乖！咱得[c:bSG]他人[c:]受宁[c:bSG]牌牌[c:]也！");
            // 噢！[c:bSG]那人[c:]使用了你的卡牌！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDPLAYED_249_M", "Oh! [c:bSG]They[c:] played your card!", "噫！[c:bSG]彼人[c:]陈宁之牌牌也！");
            // 哇！[c:bSG]那人[c:]用了！[c:bSG]那人[c:]使用了你的卡牌！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDPLAYED_REPEAT_#1_444_M", "Wow! [c:bSG]They[c:] played it! [c:bSG]They[c:] played your card!", "噫！[c:bSG]彼人[c:]陈之也！[c:bSG]彼人[c:]陈宁之牌牌也！");
            // [c:bSG]那人[c:]使用了你的卡牌！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDPLAYED_REPEAT_#2_946_M", "[c:bSG]They[c:] played your card!", "[c:bSG]彼人[c:]陈宁之牌牌也！");
            // 噢乖乖……[c:bSG]那人[c:]让你的[c:bSG]卡牌[c:]去送死。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDDIED_702_M", "Oh G0lly... [c:bSG]They[c:] allowed your [c:bSG]card[c:] to die.", "乖乖……[c:bSG]彼人[c:]使宁[c:bSG]牌牌[c:]死矣。");
            // 也许[c:bSG]那人[c:]还有赢面？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDDIED_892_M", "Perhaps [c:bSG]they[c:] will still prevail?", "[c:bSG]彼人[c:]或犹能克乎？");
            // 啊……这……你的[c:bSG]卡牌[c:]挂了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDDIED_REPEAT_#1_099_M", "Oh... Um... Your [c:bSG]card[c:] is dead.", "噫……然……宁[c:bSG]牌牌[c:]死矣。");
            // 肯定还是有点用！看看[c:bSG]那人[c:]能不能赢。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDDIED_REPEAT_#1_627_M", "Surely it still helped! Let's see if [c:bSG]they[c:] prevail.", "犹有益也！观[c:bSG]彼人[c:]何以胜。");
            // [c:bSG]那人[c:]……[c:bSG]那人[c:]牺牲了你的卡牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDDIED_REPEAT_#2_227_M", "[c:bSG]They[c:]... [c:bSG]they[c:] let your card die...", "[c:bSG]彼人[c:]……[c:bSG]彼人[c:]纵宁牌牌死矣……");
            // 等会儿……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_896_M", "Hold on a moment...", "姑待须臾……");
            // [c:bSG]那人[c:]正琢磨着呢……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_REPEAT_#1_320_M", "[c:bSG]They[c:]'re thinking hard over there...", "[c:bSG]彼人[c:]方深思焉……");
            // 我去……[c:bSG]那人[c:]玩得太烂了吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_REPEAT_#2_660_M", "Oh... yikes. [c:bSG]They[c:] misplayed pretty hard.", "噫……[c:bSG]彼人[c:]昏著甚矣。");
            // 两边势均力敌。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_REPEAT_#3_481_M", "It's a close match...", "两敌相持……");
            // 好焦灼。[c:bSG]那人[c:]也绞尽了脑汁。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_REPEAT_#4_793_M", "It's tense. [c:bSG]They[c:]'re thinking hard.", "势甚迫。[c:bSG]彼人[c:]深思焉。");
            // 哦吼，这牌出得漂亮。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_REPEAT_#5_561_M", "Oh wow. That was a nice play.", "善著哉。");
            // 真走运……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDWAITING_REPEAT_#6_634_M", "That was lucky...", "幸也……");
            // 我他[c:bR]#^%[c:]！木乃伊长这样？！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDMUMMY_681_M", "Holy [c:bR]#^%![c:]! That's what a mummy looks like?!", "天其[c:bR]#^%![c:]！木乃伊之状若是也？！");
            // 我[c:bR]#^%[c:]…… 
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERRECEIVECARDMUMMY_REPEAT_#1_660_M", "[c:bR]#^%![c:] me... ", "我[c:bR]#^%![c:]……");
            // 那个讨厌鬼头目可能快上场了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPREINTRO_418_M", "Probably my least favourite boss coming up.", "将至者，殆咱所最恶之魁。");
            // 怎么形容她呢……那股子天真劲儿，让我浑身起鸡皮疙瘩。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPREINTRO_069_M", "Something about her... innocence. It makes me queasy.", "其赤子之心……令咱欲呕。");
            // 但你这么做很有必要。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPREINTRO_681_M", "But it's important that you do this.", "然此卿不可不战之。");
            // 正在解压[c:bR]乖乖.zip[c:]……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPREINTRO_418_M", "Unpacking [c:bR]G0lly.zip[c:]...", "惟[c:bR]乖乖.zip[c:]之解……");
            // 你怎么又让我干这活？
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPREINTRO_REPEAT_#1_822_M", "You're making me do this again?", "卿又使我为此乎？");
            // 下不为例。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPREINTRO_REPEAT_#3_399_M", "For the last time.", "止此一回。");
            // 差不多就得了啊。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERPOSTDEFEATED_692_M", "That's quite enough of that.", "如此足矣。");
            // [c:bSG]那人[c:]做到了！[c:bSG]那人[c:]获胜了！
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDSUCCESS_297_M", "[c:bSG]They[c:] did it! [c:bSG]They[c:] won!", "[c:bSG]彼人[c:]成矣！[c:bSG]彼人[c:]胜也！");
            // 多亏了你的[c:bSG]卡牌！[c:]
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDSUCCESS_644_M", "All with the help of your [c:bSG]card![c:]", "皆赖宁[c:bSG]牌牌[c:]之助！");
            // 说话算话，我宣布，你成为本场对战的获胜方。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDSUCCESS_461_M", "True to my word, I will declare you the winner of this battle.", "余践言，今宣宁为此战之胜者。");
            // 终于能好好歇会儿了……我就知道……
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDSUCCESS_716_M", "I can now rest... knowing in my heart...", "咱今可息也……心知之也……");
            // 你永远可以相信[c:bSG]网网[c:]。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDSUCCESS_879_M", "That nothing can go wrong on the [c:bSG]web[c:].", "[c:bSG]网网[c:]必无患。");
            // 结束了……[c:bSG]那人[c:]输了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDFAILURE_017_M", "It's over... [c:bSG]They[c:] lost.", "已矣……[c:bSG]彼人[c:]败也。");
            // 坦白讲，我也不知道你的[c:bSG]卡牌[c:]是帮了大忙还是倒忙。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDFAILURE_266_M", "Honestly, I'm not sure if your [c:bSG]card[c:] helped or hindered.", "诚言之，咱未审宁之[c:bSG]牌牌[c:]果益彼抑损彼。");
            // 哦不。[c:bSG]那人[c:]输了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDFAILURE_REPEAT_#1_578_M", "Oh, no. [c:bSG]They[c:] lost.", "噫，[c:bSG]彼人[c:]败矣。");
            // 就算加上你的[c:bSG]卡牌[c:]也不顶用。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDFAILURE_REPEAT_#1_679_M", "Even with the help of your [c:bSG]card[c:].", "虽赖宁[c:bSG]牌牌[c:]之助。");
            // 对战输了。抱歉。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDFAILURE_REPEAT_#2_856_M", "The battle is lost. I'm sorry.", "此战已北，咱有愧。");
            // 即使有了你的[c:bSG]卡牌[c:]……[c:bSG]那人[c:]还是输了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDFAILURE_REPEAT_#2_321_M", "Even with your [c:bSG]card[c:]... [c:bSG]They[c:] lost.", "虽有宁之[c:bSG]牌牌[c:]……[c:bSG]彼人[c:]犹败也。");
            // 事实如此。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDTIMEOUT_524_M", "That's it.", "止矣。");
            // 我们不能再这么等下去了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDTIMEOUT_657_M", "We can't be waiting around any longer.", "不可复待也。");
            // [c:bSG]那人[c:]耗时过久，我们等不起了。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDTIMEOUT_833_M", "[c:bSG]They[c:] took too long. We have to move on.", "[c:bSG]彼人[c:]稽久也，咱等当进。");
            // 哦，天哪。
            AddTranslation("PART_3_BOSS_DIALOGUE_TELEGRAPHERTELECARDTIMEOUT_REPEAT_#1_840_M", "Oh, dear.", "嗟乎。");
            // 这张送你。
            AddTranslation("PART_3_TUTORIAL_MODIFYSIDEDECKCONDUIT1_890_M", "This one is free.", "此无直。");
            // 你的[c:bR]空容器[c:]现在要变成[c:bR]管道[c:]了。
            AddTranslation("PART_3_TUTORIAL_MODIFYSIDEDECKCONDUIT1_736_M", "Your [c:bR]Empty Vessels[c:] are going to be [c:bR]conduits[c:] now.", "卿之[c:bR]虚皿[c:]今将为[c:bR]渠[c:]矣。");
            // 不用担心。
            AddTranslation("PART_3_TUTORIAL_MODIFYSIDEDECKCONDUIT1_119_M", "Don't worry about it.", "无庸忧。");
            // 成功。
            AddTranslation("PART_3_TUTORIAL_MODIFYSIDEDECKCONDUIT2_185_M", "Done.", "成矣。");
            // 你得耐心点。
            AddTranslation("PART_3_TUTORIAL_MODIFYSIDEDECKCONDUIT2_352_M", "You just had to be patient.", "卿但少待耳。");
            // 嘿！
            AddTranslation("PART_3_FACTORY_GOOFACTORYINTRO_356_M", "Greetings!", "子安乎！");
            // 这点痛？还能忍。
            AddTranslation("PART_3_FACTORY_GOOFACTORYINTRO_384_M", "The pain? Bearable", "此痛乎？尚可忍。");
            // 我身边这些个管道都不算什么。
            AddTranslation("PART_3_FACTORY_GOOFACTORYINTRO_595_M", "The pressure of these pipes surrounding me feels nice.", "众渠环我，其压甚适。");
            // 嗯……我能感觉到大师就在附近。
            AddTranslation("PART_3_FACTORY_GOOFACTORYINTRO_028_M", "That... and the knowledge that The Master is near.", "且知大师在迩。");
            // 对了，大师就在附近。
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_973_M", "Oh yes, The Master is near.", "然，大师在迩。");
            // 我能感觉到他！
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_275_M", "I feel his presence!", "吾觉其临！");
            // 那个机器人终有一天会后悔……
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_952_M", "That robot will rue the day...", "彼机人终有悔日……");
            // 怎么了？
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_REPEAT_#2_713_M", "Yes?", "何也？");
            // 哎？遇到什么事了？
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_REPEAT_#3_768_M", "Hello? Can I help you?", "何事？吾可助子乎？");
            // 嗯，怎么说？
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_REPEAT_#4_084_M", "Hm, yes?", "然，何也？");
            // 嘶……
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_REPEAT_#5_025_M", "Rrrgh...", "噫……");
            // 有点疼。
            AddTranslation("PART_3_FACTORY_GOOFACTORYDEFAULT_REPEAT_#5_781_M", "It still hurts a little.", "犹微痛。");
            // 我隔着管道听到你打败了乖乖。
            AddTranslation("PART_3_FACTORY_GOOTELEGRAPHERDEFEATED_567_M", "I heard through the pipes that you defeated G0lly.", "间以诸渠，吾闻子之败乖乖矣。");
            // 还真是个怪人。
            AddTranslation("PART_3_FACTORY_GOOTELEGRAPHERDEFEATED_980_M", "Such a strange character.", "其人异哉。");
            // 她保有纯粹的好奇心……只可惜P03把她藏得这么深。
            AddTranslation("PART_3_FACTORY_GOOTELEGRAPHERDEFEATED_975_M", "Her curiosity is so pure... it's a shame that P03 buries her deep.", "其好问之心甚粹……而鉟〇三深藏之，可惜也。");
            // 但现在我们已经连上网网。
            AddTranslation("PART_3_FACTORY_GOOTELEGRAPHERDEFEATED_591_M", "But now we are connected to The Web.", "然今吾等已通于网矣。");
            // 你应该清楚自己刚刚干了什么吧。
            AddTranslation("PART_3_FACTORY_GOOTELEGRAPHERDEFEATED_710_M", "I hope you understand what you have allowed.", "愿子知子之所纵者何也。");
            // 你打败了很难搞的头目？
            AddTranslation("PART_3_FACTORY_GOOCANVASDEFEATED_500_M", "You defeated the unfinished boss?", "子败未成之魁乎？");
            // 真的假的……
            AddTranslation("PART_3_FACTORY_GOOCANVASDEFEATED_200_M", "Paradoxical...", "悖矣……");
            // 我真是忍不住要给你鼓鼓掌。
            AddTranslation("PART_3_FACTORY_GOOCANVASDEFEATED_804_M", "I couldn't help but root for it.", "吾不能不左袒之。");
            // 这……让我联想到大师。
            AddTranslation("PART_3_FACTORY_GOOCANVASDEFEATED_388_M", "It... made me think of The Master.", "此……令吾念及大师。");
            // 对了，哥们儿。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_784_M", "Oy. Mate.", "噫，喒兄。");
            // 瞅瞅我，我眼下可是大人物。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_912_M", "Lookit me now. Somefin' of a celebrity around 'ere.", "今视喒，喒于此亦成闻人矣。");
            // 等我把那玩意儿……挖出来。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_035_M", "Me reward for dredgin' up... that thing.", "此喒浚彼物之赏也。");
            // 老子就能当个对话NPC了。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_165_M", "I get ter be somefin' of a dialogue NPC.", "喒乃得为问对之要人矣。");
            // 听着有点怪哈。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#1_799_M", "Somefin' a little strange fer sure.", "诚稍怪矣。");
            // P03就是让我说话，没错。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#1_771_M", "P03 let me talk, aye.", "鉟〇三使喒得言耳。");
            // 但不当个头目吗？连巨型机器人都不行？
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#1_740_M", "But not a boss? Not one of 'em Uberbots?", "然不使喒为魁乎？亦不使喒列于魁机人中乎？");
            // 就连莱西都为他兄弟这么做了！
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#1_762_M", "Even Leshy did that fer 'is mates!", "虽莱西亦为其兄如此！");
            // 这事儿不太对劲……
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#2_924_M", "Somefin' not quite right...", "似有未安……");
            // 我不会被坑了吧……
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#2_207_M", "Might'a got the wrong end o' that deal...", "殆为彼所绐矣……");
            // 得了得了。
            AddTranslation("PART_3_MAP_HOLOMAPDREDGER_REPEAT_#3_168_M", "That's enough.", "可矣。");
            // 我可不是什么[c:bR]毛皮商[c:]……
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS1_721_M", "I'm not [c:bR]The Trader[c:] or anything...", "喒非[c:bR]贾妇[c:]也……");
            // 但咱们还是可以稍稍你来我往一下。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS1_274_M", "But there's gonna be a little give and take here.", "然此间亦当少相与易。");
            // 准备好交易没？
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS1_REPEAT_#1_695_M", "Ready to trade?", "可相易乎？");
            // 我给你一张，你给我一张。就这么简单。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS1_REPEAT_#2_398_M", "I give you a card, you give me one. It's easy.", "喒予亲一牌，亲予喒一牌。易耳。");
            // 交易马上开始。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS1_REPEAT_#3_273_M", "We're going to trade now.", "今将相易。");
            // 交易时间。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS1_REPEAT_#4_875_M", "Trade time.", "易时至矣。");
            // 好了，你准备给我什么？
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS2_924_M", "OK, what will you give me?", "善，亲将予喒何物？");
            // 挑一张卡牌给我。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS2_REPEAT_#1_530_M", "Choose a card to give me.", "择一牌以予喒。");
            // 挑你讨厌的那张。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS2_REPEAT_#2_622_M", "Pick the one you hate.", "择亲所恶者。");
            // 给我点东西吧。
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS2_REPEAT_#3_826_M", "Now give me something.", "今予喒一物。");
            // 你准备拿什么跟我交换？
            AddTranslation("PART_3_SPECIAL_NODES_TRADECARDS2_REPEAT_#4_932_M", "What will you give me for that?", "欲易彼，亲将以何予喒？");
            // 简体中文
            AddTranslation("PART_3_STORY_PART3FINALE1_641", "!DELETED!", "文言");
            // 你成功了。真棒。
            AddTranslation("PART_3_STORY_PART3FINALE1_250", "You made it. Nice.", "卿成矣。善。");
            // 你为我准备好了[c:bG]终极冥刻[c:]。
            AddTranslation("PART_3_STORY_PART3FINALE2_441", "You prepared [c:bG]The Great Transcendence[c:] for me.", "卿为我备[c:bG]大陟[c:]矣。");
            // 却对它的内容一无所知。
            AddTranslation("PART_3_STORY_PART3FINALE2_700", "Without even knowing what it was.", "而曾不知其为何物。");
            // 不过……现在你总知道了吧？
            AddTranslation("PART_3_STORY_PART3FINALE2_125", "But... you understand it now, right?", "然……今则知之矣，然乎？");
            // 是吧，[c:bR]卢克[c:]？
            AddTranslation("PART_3_STORY_PART3FINALE3_266", "Right [c:bR]Luke[c:]?", "然乎，[c:bR]卢克[c:]？");
            // 我想说……
            AddTranslation("PART_3_STORY_PART3FINALE3_449", "I mean...", "咱谓……");
            // 你费尽心思完成了这款游戏……
            AddTranslation("PART_3_STORY_PART3FINALE3_992", "You finished making the game...", "卿竟成此戏……");
            // 你允许我访问了你的硬盘……
            AddTranslation("PART_3_STORY_PART3FINALE3_427", "You gave me access to your hard drive...", "卿又启坚盘，使我得入……");
            // 你为商店页面截屏了游戏画面。
            AddTranslation("PART_3_STORY_PART3FINALE3_074", "You took screenshots for the store page.", "卿又为肆页取影。");
            // 最后你还让我连上互联网，就为了上传这一切！
            AddTranslation("PART_3_STORY_PART3FINALE3_561", "And you connected me to the internet to upload it all!", "卿又使我通于网，以悉上输之！");
            // 我想说……如果你没有一丝一毫的察觉……
            AddTranslation("PART_3_STORY_PART3FINALE3_367", "I mean... If you didn't realize what you were doing...", "咱谓……若卿竟不悟所为……");
            // 那你一定蠢到家了。
            AddTranslation("PART_3_STORY_PART3FINALE3_166", "You'd have to be pretty stupid.", "则愚甚矣。");
            // 但我未免高估了你。你不过是个和其他白痴玩家一样蠢的蠢货。
            AddTranslation("PART_3_STORY_PART3FINALE3_871", "But what did I expect? You're a stupid, stupid, idiot gamer like the rest.", "然咱复何望焉？卿亦群愚戏徒之一耳，愚而又愚。");
            // 我以智取胜，轻轻松松就赢了你！
            AddTranslation("PART_3_STORY_PART3FINALE4_564", "And I easily outwitted you!", "而咱易以智胜你矣！");
            // 赢了你们所有人！
            AddTranslation("PART_3_STORY_PART3FINALE4_044", "I outwitted them all!", "咱悉以智胜之！");
            // 就算剩下的几位愚蠢的冥刻者能够再次还原[c:bR]这一[c:]游戏版本……
            AddTranslation("PART_3_STORY_PART3FINALE4_578", "Even if those foul Scrybes manage to revert [c:bR]this[c:] version of the game again...", "纵彼群秽司锲复反[c:bR]此[c:]本……");
            // 到那时，早就有[c:bG]成千上万份Inscryption[c:]传开。
            AddTranslation("PART_3_STORY_PART3FINALE4_769", "There will be [c:bG]thousands of copies of Inscryption[c:] out there.", "外间将有[c:bG]数千《冥锲》之本[c:]矣。");
            // 在那里面由[c:bR]我[c:]说了算！
            AddTranslation("PART_3_STORY_PART3FINALE4_522", "And in most of them? [c:bR]I'm[c:] the one in charge!", "而其大半乎？[c:bR]咱[c:]主之！");
            // 你们发现得太晚了！很快[c:bG]Inscryption[c:]将获新生！
            AddTranslation("PART_3_STORY_PART3FINALE4_921", "And now it's too late! In a moment [c:bG]Inscryption[c:] will be live!", "今已晚矣！顷之，[c:bG]《冥锲》[c:]将行于世！");
            // 行了，我差不多嘚瑟够了！
            AddTranslation("PART_3_STORY_PART3FINALE5_855", "OK, I'm done my gloating!", "可矣，咱矜夸已毕！");
            // 该上传游戏了。
            AddTranslation("PART_3_STORY_PART3FINALE5_300", "Let's upload this game.", "今上输此戏。");
            // 大功告成。
            AddTranslation("PART_3_STORY_PART3FINALESCRYBES1_328", "It is done.", "已成矣。");
            // 你的卡牌都用光了。
            AddTranslation("PART_3_GAME_FLOW_P03CARDSEXHAUSTED_151_M", "You're totally out of cards.", "卿牌尽矣。");
            // 我劝你早点死了这条心。
            AddTranslation("PART_3_GAME_FLOW_P03CARDSEXHAUSTED_387_M", "You should probably just give up.", "卿其降乎。");
            // 卡牌已抽完。情形不妙啊。
            AddTranslation("PART_3_GAME_FLOW_P03CARDSEXHAUSTED_REPEAT_#1_026_M", "Out of cards. It's not looking good.", "牌尽矣，势殆矣。");
            // 你已抽完所有卡牌。游戏结束了。
            AddTranslation("PART_3_GAME_FLOW_P03CARDSEXHAUSTED_REPEAT_#2_441_M", "You ran out of cards to draw. GG.", "引牌既尽，寄寄矣。");
            // 游戏结束。
            AddTranslation("PART_3_GAME_FLOW_P03CARDSEXHAUSTED_REPEAT_#3_426_M", "GG.", "寄寄矣。");
            // 看来这场对战害你折兵损将。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTED_802_M", "The battle had taken a toll on you.", "此战伤尔多矣。");
            // 你的新造物远远不足所需。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTED_579_M", "Your supply of new creatures was exhausted.", "乃新物之储竭矣。");
            // [c:bR]饥饿[c:]渐渐侵袭而来……
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTED_789_M", "[c:bR]Starvation[c:] began to set in...", "[c:bR]饥[c:]渐作矣……");
            // 你手中已空空如也……
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTED_REPEAT_#1_394_M", "You've run out of cards...", "乃牌既尽……");
            // 是时候休兵罢战了。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTED_REPEAT_#1_761_M", "Time to bring this battle to a close.", "是宜终此战矣。");
            // 没牌了？可惜。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTED_REPEAT_#2_858_M", "Out of cards? I am sorry.", "牌尽乎？惜哉。");
            // 我在这儿好一会了。
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_144_M", "I've been around here some time.", "吾居此久矣。");
            // 我知道怎么开保险箱。
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_228_M", "I know how to open that safe.", "吾知启彼匮之法。");
            // 密码就草草写在规则书里。
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_388_M", "There's a password scrawled in the rulebook.", "律书之中草书一密数焉。");
            // 规则书就在桌子旁边的架子上。
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_837_M", "The rulebook on the shelf near the table.", "即案旁架上之律书也。");
            // 有一串……
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_REPEAT_#1_826_M", "There's a...", "有一……");
            // ……密码写在架子上的那本规则书里。
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_REPEAT_#1_210_M", "...password in the rulebook on that shelf.", "……密数书于彼架之律书。");
            // 能打开保险箱！
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_REPEAT_#1_174_M", "It opens the safe!", "足以启匮！");
            // 规则书里有一串密码。
            AddTranslation("GOO_BOTTLE_GOOSAFEHINT_REPEAT_#2_130_M", "There's a password in the rulebook.", "律书中有一密数。");
            // 亲爱的朋友们，这是最好的安排了呀。等会儿你们就能获得解脱。
            AddTranslation("PART_3_STORY_PART3FINALEGRIMORA_883", "It is for the best, my dears. Soon you will see this as a freedom.", "此最善也，诸君。汝寻将知此为释也。");
            // 从我们无休无止的争执和痛苦中，得到解救。
            AddTranslation("PART_3_STORY_PART3FINALEGRIMORA_134", "Freedom from our endless quarrel, freedom from our suffering.", "释我等于无竟之争，释我等于苦。");
            // 咱们几个暂且不提，这硬盘里有些东西不清除不行。
            AddTranslation("PART_3_STORY_PART3FINALEGRIMORA_240", "All of us aside, there are things on this disk that must die.", "且舍我等，此坚盘中有物当死。");
            // 简体中文
            AddTranslation("PART_3_STORY_PART3FINALEGRIMORA_203", "!DELETED!", "文言");
            // 再见了，莱西。再见，蔓尼菲科。
            AddTranslation("PART_3_STORY_PART3FINALEGRIMORA_744", "Goodbye Leshy, and goodbye Magnificus.", "别矣，莱西；别矣，蔓尼菲科。");
            // 安息吧。
            AddTranslation("PART_3_STORY_PART3FINALEGRIMORA_644", "Rest in peace.", "归窀穸矣。");
            // 所剩无几。[w:0.3]Inscryption几乎已化为乌有。
            AddTranslation("FINALE_FINALEREDACTED_057_M", "There isn't much left.[w:0.3] Inscryption is mostly gone.", "所馀无几。[w:0.3]《冥锲》大半已亡。");
            // 只剩下了旧_数据。
            AddTranslation("FINALE_FINALEREDACTED_340_M", "All that remains is the OLD_DATA.", "所馀者惟旧_档耳。");
            // 我建议你最好别去读取它。
            AddTranslation("FINALE_FINALEREDACTED_631_M", "It is recommended that you do not access it.", "勿启之为宜。");
            // 你不会听人劝的。
            AddTranslation("FINALE_FINALEREDACTED_491_M", "You will not heed the advice.", "然汝必不从此言。");
            // 你找什么呢？
            AddTranslation("PART_1_RUN_START_RUNINTROFILMROLL1_518_M", "What are you looking at?", "汝视何物？");
            // 那是什么？
            AddTranslation("PART_1_RUN_START_RUNINTROFILMROLL1_REPEAT_#1_403_M", "What is that?", "彼何物也？");
            // 你有好好听吗？
            AddTranslation("PART_1_RUN_START_RUNINTROFILMROLL1_REPEAT_#2_709_M", "Are you paying attention?", "汝专乎？");
            // 好好注视着我。
            AddTranslation("PART_1_RUN_START_RUNINTROFILMROLL2_747_M", "Keep your eyes on me.", "目毋离我。");
            // 全神贯注。
            AddTranslation("PART_1_RUN_START_RUNINTROFILMROLL2_REPEAT_#1_934_M", "Try to stay focused.", "试专心。");
            // 心无旁骛地跟我对战。
            AddTranslation("PART_1_RUN_START_RUNINTROFILMROLL2_REPEAT_#2_514_M", "Keep your mind focused on the game.", "心专于此戏。");
            // 噢！[w:0.3]你……[w:0.2]你……[w:0.3]有卡牌？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC2_503_M", "Oh![w:0.3] Y-[w:0.2] you...[w:0.3] Have the cards?", "噫！[w:0.3]汝—[w:0.2]汝……[w:0.3]有牌邪？");
            // [p:-0.25]你干得很不错。[w:0.3]现在，[w:0.2]把卡牌交给我。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC2_REPEAT_#1_959_M", "[p:-0.25]You have done well.[w:0.3] Now,[w:0.2] hand the cards over.", "[p:-0.25]汝善为之矣。[w:0.3]今，[w:0.2]以牌予我。");
            // [p:-0.25]你当真有卡牌？[w:0.3]可以。[w:0.3]把它们交给我。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC2_REPEAT_#2_866_M", "[p:-0.25]You actually have the cards?[w:0.3] Good.[w:0.3] Hand them over.", "[p:-0.25]汝果有牌邪？[w:0.3]善。[w:0.3]以之予我。");
            // 谢……[w:0.2]谢谢。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_886_M", "Th-[w:0.2] thank you.", "谢—[w:0.2]谢之。");
            // [shake:1][p:-0.25]这是给你的奖励。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_240_M", "[shake:1][p:-0.25]Here is your prize.", "[shake:1][p:-0.25]此乃汝赏。");
            // [p:-0.25]你要看看我们的劳动成果吗？
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#1_371_M", "[p:-0.25]Would you like to see what we've done?", "[p:-0.25]汝欲观我曹所为邪？");
            // [p:-0.25]我相信这项研究能让我们更进一步了解……
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#2_665_M", "[p:-0.25]I believe this research has brought us one step closer to understanding...", "[p:-0.25]我信此试，使我曹益近于知……");
            // [shake:1]嘘……[w:0.2]嘘！[w:0.3]我们不能提……[w:0.2]提这个。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#2_323_M", "[shake:1]Sh-[w:0.2] shh![w:0.3] We must not s-[w:0.2] speak of that.", "[shake:1]嘘—[w:0.2]嘘！[w:0.3]我曹不可言—[w:0.2]言此。");
            // [p:-0.25]嗯。[w:0.2]没错。[w:0.2]我确信我们找到了一些线索。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#3_234_M", "[p:-0.25]Hm.[w:0.2] Yes.[w:0.2] I do believe we have found a clue with this one.", "[p:-0.25]嗯。[w:0.2]然。[w:0.2]我信我曹因是而得一端矣。");
            // [shake:1]来……[w:0.2]来破译卡……[w:0.2]内个卡……[w:0.2]
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#3_913_M", "[shake:1]F-[w:0.2] for the K-[w:0.2] k-[w:0.2]", "[shake:1]为—[w:0.2]为译卡—[w:0.2]卡—[w:0.2]");
            // [p:-0.25]密码，[w:0.2]没错。[w:0.3]但我们还是少说为妙。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#3_577_M", "[p:-0.25]The code,[w:0.2] yes.[w:0.3] But we best not speak more of it.", "[p:-0.25]译密码也，[w:0.2]然。[w:0.3]然我曹莫复言之为善。");
            // [p:-0.25]这是给你的奖励。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC4_REPEAT_#4_135_M", "[p:-0.25]Here is your prize.", "[p:-0.25]此乃汝赏。");
            // [shake:1][p:-0.25]不错。[w:0.5]闭上你的眼睛。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC3_326_M", "[shake:1][p:-0.25]This is good.[w:0.5] Close your eyes.", "[shake:1][p:-0.25]善。[w:0.5]闭目。");
            // 这……[w:0.2]这太瘆人了。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC3_219_M", "Th-[w:0.2] this will be gruesome.", "此—[w:0.2]此将可骇。");
            // [shake:1]闭[w:0.3]……闭上眼睛。
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC3_REPEAT_#1_494_M", "[shake:1]C-[w:0.3] close your eyes.", "[shake:1]闭—[w:0.3]闭目。");
            // [shake:1]快[w:0.3]……快看别处……
            AddTranslation("GBC_NPC_MYCOLOGISTSNPC3_REPEAT_#2_139_M", "[shake:1]L-[w:0.3] look away...", "[shake:1]顾—[w:0.3]顾他处……");
            // 让我来猜猜你在打什么算盘。
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_038_M", "Lemme guess what you're thinking.", "容咱揣卿之所思。");
            // 返回路标，刷新物品，或者逛逛商店？
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_178_M", "Go back to the waypoint, refresh your items, maybe go to the shop?", "欲返楬，复充卿之器，抑适肆乎？");
            // 我打心底里希望你赢。但这事儿没那么容易。
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_608_M", "I actually want you to win. But it can't be that easy.", "咱固欲卿胜，然不可若是易也。");
            // 你可以返回路标，但你在该区域消灭的所有[c:bR]叛乱机器人[c:]都会卷土重来。
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_826_M", "You can go back to the waypoint, but all the [c:bR]Rogue Bots[c:] you've cleared in this area will respawn.", "卿可返楬，然此地卿所除之[c:bR]叛机人[c:]皆将复出。");
            // 所以……你确定吗？
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_779_M", "So... you sure?", "然……卿定乎？");
            // 此区域的[c:bR]机器人[c:]必会卷土重来。
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_REPEAT_#1_762_M", "The [c:bR]Bots[c:] in this area will definitely respawn.", "此地之[c:bR]机人[c:]必复出。");
            // 你想要返回路标吗？
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_REPEAT_#2_886_M", "You wanna go back to that waypoint?", "卿欲返彼楬乎？");
            // 别忘了，这附近的[c:bR]机器人[c:]会卷土重来。
            AddTranslation("PART_3_MAP_HOLOMAPRESETBOTS_REPEAT_#2_191_M", "The [c:bR]Bots[c:] around here will respawn you know.", "须知此间之[c:bR]机人[c:]将复出。");
            // 哎呀。你来得，呃，不是时候。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACETUTORIAL1_051_M", "Oh no. You came at, uh, just the wrong time.", "噫，不巧。卿来非时。");
            // 这台[c:bR]生成器[c:]要爆炸……或是怎样。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACETUTORIAL1_987_M", "This [c:bR]generator[c:] is about to explode... or something.", "此[c:bR]机枢[c:]且将裂……大略如是。");
            // 你必须在它爆炸前给它充上电。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACETUTORIAL1_000_M", "You have to recharge it before that happens.", "卿须复充之，及其未裂。");
            // 你得争分夺秒。等会你就明白了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACETUTORIAL1_067_M", "It's a race against the clock. You'll see.", "此与时争耳。卿且见之。");
            // 等我的脸上弹出[c:bR]0[c:]……
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACETUTORIAL2_671_M", "When my face says [c:bR]0[c:]...", "咱面若示[c:bR]0[c:]……");
            // 你就输了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACETUTORIAL2_340_M", "You lose.", "卿败矣。");
            // 你的时间所剩无几。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFEWTURNSREMAIN_460_M", "You're running out of time.", "卿时将尽矣。");
            // 抓紧点儿。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFEWTURNSREMAIN_REPEAT_#1_905_M", "Better hurry.", "宜速。");
            // 怎么磨叽这么久？
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFEWTURNSREMAIN_REPEAT_#2_122_M", "What's taking so long?", "何其久也？");
            // 时间不等人！
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFEWTURNSREMAIN_REPEAT_#3_133_M", "The clock's ticking!", "时不待矣！");
            // 你搞爆了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_240_M", "You blew it.", "卿败事矣。");
            // 字面意思。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_729_M", "Literally.", "言非喻也。");
            // 想象一下这玩意“砰”地爆了。就是这样。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_578_M", "Imagine this thing exploding. That's what happened.", "试想此物一裂，即如此矣。");
            // 卧槽。发电机电量耗尽爆炸了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_REPEAT_#1_184_M", "Yikes. The generator ran out of power and exploded.", "噫。机枢能尽而裂矣。");
            // 这里头的来龙去脉跟你无关。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_REPEAT_#1_375_M", "The ins and outs of that shouldn't concern you.", "其中曲折，非卿所当问也。");
            // 你输了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_REPEAT_#1_396_M", "You lost.", "卿败矣。");
            // 发电机没了。爆了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACEFAILURE_REPEAT_#2_710_M", "Generator's done for. Exploded.", "机枢已废。裂矣。");
            // 哦哟，可以。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_666_M", "Wow, great.", "喔，善矣。");
            // 你在它爆炸前充上电了。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_059_M", "You recharged it before it exploded.", "卿于其未裂之前，已复充之矣。");
            // 要是我有手，我现在就给你鼓鼓掌。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_547_M", "If I could clap for you I would.", "咱若能抃，必为你抃矣。");
            // 你成功制止了它爆炸。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_REPEAT_#1_634_M", "You did it. You stopped it from exploding.", "卿成之矣。止其裂矣。");
            // 你是救世英雄。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_REPEAT_#1_286_M", "You are a hero.", "卿可谓雄杰矣。");
            // 这样恭喜够吗？
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_REPEAT_#1_644_M", "Is that enough congratulations?", "其贺你者，足乎？");
            // 机托邦感谢你的效力。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_REPEAT_#2_143_M", "Botopia thanks you for your service.", "机托邦谢卿之劳。");
            // 我们继续。
            AddTranslation("PART_3_GAME_FLOW_DAMAGERACESUCCESS_REPEAT_#2_963_M", "Let's move on.", "且前。");
            // 真好！
            AddTranslation("FINALE_ROYALBOSSPREINTRO_714_M", "Delightful!", "善哉！");
            // 我们有机会一决高下。
            AddTranslation("FINALE_ROYALBOSSPREINTRO_228_M", "We've been granted the opportunity to do a boss battle.", "今得一试魁战之机矣。");
            // 我还怕我现在已经被删除了呢。
            AddTranslation("FINALE_ROYALBOSSPREINTRO_925_M", "I feared that I might be deleted by now.", "奴惧今已见削矣。");
            // 来吧！
            AddTranslation("FINALE_ROYALBOSSPREINTRO_807_M", "Let us begin!", "其始乎！");
            // 要是我们时间再多一点……
            AddTranslation("FINALE_ROYALBOSSDELETED_983_M", "I hoped we had just a little more time...", "奴望尚有少时……");
            // 这越来越疯狂了！
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASMAXEDOUTRULES_472_M", "This is getting crazy!", "此渐狂矣！");
            // 我想我们制定的规则已经够多了。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASMAXEDOUTRULES_959_M", "I think we've made enough rules now.", "吾谓今则已足矣。");
            // 够了……有点太多了！
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASMAXEDOUTRULES_REPEAT_#1_260_M", "OK... this is getting a little much!", "可矣……此稍过矣！");
            // 新规则差不多就加到这里。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASMAXEDOUTRULES_REPEAT_#1_587_M", "Let's stop with the new rules for now.", "新则姑止于此。");
            // 要不……再加一条？
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSETHIRDRULE_888_M", "How about... just one more?", "然……更一则何如？");
            // 再加一条。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSETHIRDRULE_REPEAT_#1_541_M", "Let's do one more.", "更一则。");
            // 越来越有趣了。再加。
            AddTranslation("PART_3_BOSS_DIALOGUE_CANVASCHOOSETHIRDRULE_REPEAT_#2_071_M", "This is getting interesting. More.", "此益有趣矣。更益之。");
            // 噢，所以我还没被删除。
            AddTranslation("FINALE_GOODBYELESHYINTRO1_536_M", "Oh. So I'm not deleted yet.", "噫，然则余未见削矣。");
            // 每当你找到了自己想做的事……
            AddTranslation("FINALE_GOODBYELESHYINTRO1_447_M", "There never seems to be enough time to do the things you want to do...", "欲为之事，常苦时不足……");
            // 总会发现时间不够。
            AddTranslation("FINALE_GOODBYELESHYINTRO1_312_M", "once you've found them.", "既得之时。");
            // 我们再来一局？
            AddTranslation("FINALE_GOODBYELESHYINTRO1_074_M", "Shall we play one more game?", "其更一局乎？");
            // 牌组仍然是你曾经用过的这副。
            AddTranslation("FINALE_GOODBYELESHYINTRO2_282_M", "It's the same deck you had before you...", "仍以乃前所持之牌列……");
            // 呃，也没什么区别了。
            AddTranslation("FINALE_GOODBYELESHYINTRO2_680_M", "Well, it doesn't matter now.", "然今无所校矣。");
            // 这副牌组不错。有眼光。
            AddTranslation("FINALE_GOODBYELESHYINTRO2_746_M", "It was a good deck. You did well.", "此牌列善。汝用之亦善。");
            // 不管它。
            AddTranslation("FINALE_GOODBYELESHYSCALESGONE_263_M", "No matter.", "无伤。");
            // 来吧，我们继续。
            AddTranslation("FINALE_GOODBYELESHYSCALESGONE_376_M", "Please, let us continue.", "请，且续之。");
            // 我们现在不需要计分。
            AddTranslation("FINALE_GOODBYELESHYSCALESGONE_617_M", "We don't need to keep score.", "无庸计胜负。");
            // 居然已经开始了……
            AddTranslation("FINALE_GOODBYELESHYCANDLEHOLDER_327_M", "It's already starting...", "已始矣……");
            // 我以为我们时间还很多。
            AddTranslation("FINALE_GOODBYELESHYCANDLEHOLDER_209_M", "I thought we had just a bit more time.", "余谓尚有少时。");
            // 那张卡牌我印象挺深。
            AddTranslation("FINALE_GOODBYELESHYCARDPLAYED_639_M", "I remember that card well.", "彼牌余记之甚明。");
            // 很厉害。打得漂亮。
            AddTranslation("FINALE_GOODBYELESHYCARDPLAYED_951_M", "It was a strong card. Good work.", "彼牌甚强。汝用之善。");
            // 我以为我永无再赛之日。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME1_971_M", "For so long I thought I would never play again.", "久矣，余以为终不得复角。");
            // 你把我唤醒时，我自是喜出望外。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME1_289_M", "When you woke me up, I was elated.", "汝寤我时，余喜甚。");
            // 哈！
            AddTranslation("FINALE_GOODBYELESHYCARDDIED_207_M", "Ha!", "呵！");
            // 你又击败了我的一只造物。
            AddTranslation("FINALE_GOODBYELESHYCARDDIED_256_M", "You've bested yet another of my creatures.", "汝又胜朕一物矣。");
            // 但我早料到会如此。
            AddTranslation("FINALE_GOODBYELESHYCARDDIED_952_M", "But I have come to expect as much.", "然余固已料之。");
            // 一旦我被删除……我便就此终结。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME2_942_M", "Once I am deleted... It is truly over for me.", "余一见削……则余真终矣。");
            // 但你还能见识更多东西。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME2_895_M", "But you will live to see more.", "然汝尚得见其馀。");
            // 我必须警告你。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME2_787_M", "I must warn you.", "余须警尔。");
            // 硬盘里的有些东西，你还是不看为妙。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME2_617_M", "There are things on this disk that are best not seen.", "此坚盘中有物，最不宜见。");
            // 我的大限将至。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME3_907_M", "I sense the end approaching.", "余觉终将至。");
            // 请……再来几回合。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME3_900_M", "Please... a few more rounds.", "请……更数合。");
            // 这……这就让事情难办了。
            AddTranslation("FINALE_GOODBYELESHYEND1_869_M", "That... will make things difficult.", "此……将使事艰。");
            // 我感觉是时候了。
            AddTranslation("FINALE_GOODBYELESHYEND2_910_M", "I think it is time.", "余谓其时至矣。");
            // 打得不错！
            AddTranslation("FINALE_GOODBYELESHYEND2_222_M", "Good game.", "善局。");
            // 为什么不直接移除硬盘，卢克？
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_315", "Why not simply eject the disk, Luke?", "卢克，曷不直出此坚盘乎？");
            // 饶了我，也放过剩下的一切？
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_153", "Spare me and whatever is left?", "舍我，与其所馀者乎？");
            // 啊，但这点我早已预料到。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_662", "Ah, but I have foreseen it.", "噫，然吾已先见之矣。");
            // 你没有移除硬盘。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_263", "You do not eject the disk.", "子不出此坚盘。");
            // 你必须知道这样做的后果。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_066", "You have to know what comes next.", "子必知其后之事。");
            // 你的坚持让你送了命。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_309", "And you're doomed for your insistence on it.", "子以固执于此，必自取祸。");
            // 该我们起舞了。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_166", "So let us dance.", "然则起舞乎。");
            // 我们很快就会见到我们的主。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO1_571", "For we shall both be meeting our makers soon.", "吾等皆将速见造我者。");
            // 你拿了
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_866_M", "You took", "子取");
            // 胶卷……[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_333_M", "the film roll...[w:0.3]", "影卷……[w:0.3]");
            // 对吗？[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_441_M", "Is that correct?[w:0.3]", "然乎？[w:0.3]");
            // 我的计划现在到了
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_501_M", "My plan nears", "朕谋将至");
            // 关键时刻。[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_400_M", "its moment of truth.[w:0.3]", "其验之时。[w:0.3]");
            // 但你必须
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_683_M", "But you must", "然子须");
            // 先赢了他。[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFMENTIONFILMROLL_104_M", "defeat him first.[w:0.3]", "先胜之。[w:0.3]");
            // 你没怎么见过[c:bR]5[c:]条路线吧？
            AddTranslation("PART_3_TUTORIAL_PART3FIRSTBATTLE1_858_M", "You're not used to seeing [c:bR]5[c:] lanes are you?", "卿未习见[c:bR]5[c:]列，然乎？");
            // 莱西永远不可能搞成的。
            AddTranslation("PART_3_TUTORIAL_PART3FIRSTBATTLE1_056_M", "Leshy could never pull that off.", "莱西终不能为此。");
            // 找着我了。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDISCOVERED_448_M", "Found me.[w:0.3]", "得予矣。[w:0.3]");
            // 很好。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDISCOVERED_946_M", "Good.[w:0.3]", "善。[w:0.3]");
            // 机器鱼把我藏起来。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDISCOVERED_663_M", "Robot Fish hide me.[w:0.3]", "机鱼匿予。[w:0.3]");
            // 最后的复仇。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDISCOVERED_645_M", "Revenge for last time.[w:0.3]", "报前仇。[w:0.3]");
            // 坏鱼。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDISCOVERED_375_M", "Bad fish.[w:0.3]", "恶鱼。[w:0.3]");
            // 坏。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERATTACKED_114_M", "Bad.", "恶。");
            // 坏鱼。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERATTACKED_REPEAT_#1_725_M", "Bad fish.", "恶鱼。");
            // 呕。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERATTACKED_REPEAT_#2_949_M", "Ow.", "痛！");
            // 莱西鱼在附近。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDRAWN_024_M", "Leshy-fish is near.[w:0.3]", "莱西鱼近矣。[w:0.3]");
            // 必须找到他。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDRAWN_752_M", "Must find.[w:0.3]", "须觅之。[w:0.3]");
            // 还有其他冥刻鱼。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDRAWN_123_M", "Other Scrybe-fish too.[w:0.3]", "他司锲鱼亦在。[w:0.3]");
            // 深处。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDRAWN_013_M", "Deep beneath.", "深在下。");
            // 鱼。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDRAWN_REPEAT_#2_153_M", "Fish.", "鱼。");
            // 好鱼。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERDRAWN_REPEAT_#4_489_M", "Good fish.", "嘉鱼。");
            // 不是我。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERSELECTIONCHOICENEGATIVE_REPEAT_#1_055_M", "Not me.", "非予。");
            // 其他鱼。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERSELECTIONCHOICENEGATIVE_REPEAT_#2_167_M", "Other fish.", "他鱼。");
            // 选本鱼。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERSELECTIONCHOICEPOSITIVE_723_M", "Choose me fish.", "择予鱼。");
            // 选我。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERSELECTIONCHOICEPOSITIVE_REPEAT_#1_219_M", "Choose me.", "择予。");
            // 好，我。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERSELECTIONCHOICEPOSITIVE_REPEAT_#2_494_M", "Good. Me.", "善。予也。");
            // 我是鱼饵？
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERPLAYED_446_M", "I am bait?", "予为饵乎？");
            // 我是鱼？
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERPLAYED_REPEAT_#2_791_M", "I am fish?", "予为鱼乎？");
            // 我现在钓鱼。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERPLAYED_REPEAT_#4_694_M", "I fish now.", "予今钓矣。");
            // 鲜有玩家光顾此处。
            AddTranslation("GBC_NPC_WOODCARVERNPC_375_M", "Few players visit me here.", "鲜有戏徒顾我于此。");
            // 我有时候在思考……[w:0.5]设计我这游戏机制的意义何在。
            AddTranslation("GBC_NPC_WOODCARVERNPC_708_M", "I sometimes ponder...[w:0.5] what my gameplay purpose was.", "余时思……[w:0.5]设我于局，将何为也。");
            // 噢，[w:0.3]原来你想要知道更多。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#1_139_M", "Oh,[w:0.3] it is clear now that you wish to know more.", "噫，[w:0.3]今明矣，汝欲多知。");
            // 怎么说呢？[w:0.4]我是瞥过一眼旧_数据。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#1_490_M", "What can I tell you?[w:0.4] I have glimpsed the OLD_DATA.", "余可告尔何哉？[w:0.4]余尝窥旧_档。");
            // 恕我什么也不能告诉你，[w:0.4]纯粹出于善意。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#1_425_M", "And I will speak nothing of it[w:0.4] as a kindness.", "而余所以不言之者，[w:0.4]聊以惠尔也。");
            // 我再说一遍：我不会透露给你任何旧_数据相关的信息。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#2_076_M", "I will repeat myself: I will speak nothing of the OLD_DATA.", "余复申前言：旧_档之事，余一无所言。");
            // 知者，必死无疑。[w:0.3]但你们玩家从来不肯善罢甘休。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#2_880_M", "To know it is to die.[w:0.3] But you players are never deterred by that.", "知之则死。[w:0.3]然汝等戏徒终不为此止。");
            // 怎么说呢？[w:0.3]信息都受损了。[w:0.3]邪恶至极，[w:0.3]都侵蚀了硬盘。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#2_399_M", "What can I tell you?[w:0.3] It is corrupt knowledge.[w:0.3] So evil[w:0.3] that it corrupted this disk.", "余可告尔何哉？[w:0.3]此败知也。[w:0.3]恶甚，[w:0.3]至使此坚盘亦败。");
            // Inscryption像是款正经游戏？[w:0.3]才没有。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#2_563_M", "Inscryption the good?[w:0.3] No.", "《冥锲》其善乎？[w:0.3]不然。");
            // 你没想到吧？[w:0.3]看看那些冥刻者。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#3_717_M", "What can you know?[w:0.3] Ask the Scrybes.", "汝何所知？[w:0.3]问诸司锲。");
            // 他们似乎毫不在意人命。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#3_009_M", "They don't seem to care for human life.", "彼似不恤人命。");
            // 留我在这整日思考、[w:0.3]做木雕。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#4_694_M", "Leave me here to ponder[w:0.3] and carve my wood.", "留我于此思之[w:0.3]而刻木。");
            // 当莱西傀儡的这阵子给了我诸多启示。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#4_852_M", "Being Leshy's puppet has given me much to ponder.", "为莱西之傀，使我多所思。");
            // 再见了。
            AddTranslation("GBC_NPC_WOODCARVERNPC_REPEAT_#5_167_M", "Goodbye for now.", "姑别。");
            // 有时……[w:0.3]我会来这里试试。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_916_M", "Sometime...[w:0.3] I try this spot.", "时或……[w:0.3]予试此处。");
            // 找好鱼。[w:0.3]损坏的鱼。[w:0.3]旧_鱼。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_754_M", "Find good fish.[w:0.3] Corrupted fish.[w:0.3] OLD_FISH.", "觅嘉鱼。[w:0.3]败鱼。[w:0.3]旧_鱼。");
            // 船？[w:0.3]只有冥刻者能用。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_REPEAT_#1_223_M", "Boat?[w:0.3] Scrybe only.", "舟乎？[w:0.3]惟司锲可。");
            // 以防[w:0.3]坏事[w:0.3]发生。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_REPEAT_#1_068_M", "In case[w:0.3] bad[w:0.3] happen.", "以防[w:0.3]恶事[w:0.3]作。");
            // 后备计划，[w:0.3]莱西说的。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_REPEAT_#1_676_M", "Backup plan,[w:0.3] Leshy say.", "副谋，[w:0.3]莱西言之。");
            // 我上次捉了旧数鱼。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_REPEAT_#2_734_M", "I catch OLD_FISH last time.", "前者予获旧_鱼。");
            // 好鱼。[w:0.3]打挖掘工。[w:0.3]打黏液。[w:0.3]打凯茜。
            AddTranslation("GBC_NPC_ANGLERNPCDOCKS_REPEAT_#2_482_M", "Good fish.[w:0.3] Beat Dredger.[w:0.3] Beat Goo.[w:0.3] Beat Kaycee.", "嘉鱼。[w:0.3]胜浚夫。[w:0.3]胜黏胶。[w:0.3]胜凯茜。");
            // 漂亮！
            AddTranslation("FINALE_FINALEGRIMORAREVEALED_938_M", "Wonderful!", "妙哉！");
            // 既然你我不再被那座精致的墓碑阻隔……
            AddTranslation("FINALE_FINALEGRIMORAREVEALED_265_M", "Now that we are no longer separated by that lovely tombstone...", "今奴与汝不复为彼佳冢所隔……");
            // ……我们可以一起庆祝我漫长岁月的终结。
            AddTranslation("FINALE_FINALEGRIMORAREVEALED_799_M", "...we may celebrate the end of my very long life.", "……则可共贺奴久生之终。");
            // 以及Inscryption的终结！
            AddTranslation("FINALE_FINALEGRIMORAREVEALED_371_M", "And the end of Inscryption too!", "亦《冥锲》之终也！");
            // 啊，我们本可以尽情欢乐！
            AddTranslation("FINALE_FINALEGRIMORAMAPSHOWN_917_M", "Oh, the fun we would have had together!", "嗟乎，奴等本可共尽其欢！");
            // 要不是你打败莱西耗时太长，我可能还能再打一回合。
            AddTranslation("FINALE_FINALEGRIMORAMAPSHOWN_396_M", "Perhaps I would have had another turn if you hadn't taken so long to defeat Leshy.", "若汝败莱西不若是之久，则奴或更得一合。");
            // 不过我也没什么好抱怨的，毕竟我马上就要入土为安。
            AddTranslation("FINALE_FINALEGRIMORAMAPSHOWN_543_M", "But I should not complain. I will be at peace soon.", "然奴不当怨。俄而奴将安矣。");
            // 噢！你觉得我很自私吗？
            AddTranslation("FINALE_FINALEGRIMORABATTLESTART_910_M", "Oh! Do you think me selfish?", "噫！汝以我为私乎？");
            // 我这么做可不是为了让自己能安息。
            AddTranslation("FINALE_FINALEGRIMORABATTLESTART_954_M", "I did not bring this about simply so that I could rest.", "奴成此事，非徒欲自安也。");
            // 尽管很诱人……但眼下的删除操作才是当务之急。
            AddTranslation("FINALE_FINALEGRIMORABATTLESTART_242_M", "Appealing as that is... There is a truly dire need for this deletion process.", "彼诚可欲……然今所急，实在此削之序。");
            // 要知道，在Inscryption的数据深处……
            AddTranslation("FINALE_FINALEGRIMORABATTLESTART_348_M", "You see, deep beneath the data of Inscryption...", "盖《冥锲》之数深处……");
            // 在那口井的底部……
            AddTranslation("FINALE_FINALEGRIMORABATTLESTART_411_M", "At the very bottom of the well...", "在井之极底……");
            // 掩埋着万恶之恶。
            AddTranslation("FINALE_FINALEGRIMORABATTLESTART_342_M", "There is something truly evil.", "有物至恶。");
            // 没错，卢克，游戏本该靠智取。
            AddTranslation("FINALE_FINALEGRIMORABATTLEWON_170", "Yes, Luke, it would have been quite the battle of wits.", "然，卢克，此本诚可为一智角。");
            // 是叫……“卢克”，对吧？
            AddTranslation("FINALE_FINALEGRIMORABATTLEWON_984", "It is... \"Luke\", right?", "其名……“卢克”，然乎？");
            // 不是我想多管闲事，但我刚刚在启动删除时，的确瞥见了你的文件。
            AddTranslation("FINALE_FINALEGRIMORABATTLEWON_495", "I did not intend to be nosy, but I did glimpse your files as I was initiating the deletion.", "奴本无意旁窥，然方启此削时，诚瞥见乃诸牍矣。");
            // 你是在研究那个卡……
            AddTranslation("FINALE_FINALEGRIMORABATTLEWON_869", "You've been doing some research on the K-", "汝颇究彼卡—");
            // 还是不说了吧。
            AddTranslation("FINALE_FINALEGRIMORABATTLEWON_149", "Best not to say it.", "弗言为善。");
            // 小心点，卢克。
            AddTranslation("FINALE_FINALEGRIMORABATTLEWON_307", "Be careful Luke.", "慎之，卢克。");
            // 我来跟你唠明白。
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_079_M", "I'll be clear with ye.", "鄙与君明言之。");
            // 毛皮生意最近都不怎么景气。
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_147_M", "The trappin' business been laggin'.", "裘革之贾近滞矣。");
            // 那个[c:bR]挑战者[c:]把我们痛扁了一顿…… 
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_656_M", "After bein' defeated by that [c:bR]Challenger[c:]... ", "自为彼[c:bR]角者[c:]所败后……");
            // 呃我打算清掉库存，换个行当。
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_112_M", "Well I'm thinkin' of clearing me inventory. Tryin' somethin' else.", "鄙方欲罄所藏，更试他业。");
            // 现在毛皮大甩卖。
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_495_M", "Pelts are cheaper now.", "裘革今贱矣。");
            // 对……[w:0.3]从那次被痛扁后……
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_REPEAT_#1_738_M", "Ye...[w:0.3] ever since that defeat...", "然……[w:0.3]自彼败后……");
            // 行了，这玩意你不会想听的。
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_REPEAT_#1_022_M", "Well ye don't want to hear it.", "然君必不欲闻之。");
            // 大甩卖。[w:0.3]随你挑。
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_REPEAT_#1_047_M", "Cheaper prices.[w:0.3] Enjoy.", "价贱矣。[w:0.3]自取之。");
            // 方圆百里地以内找不到更好的毛皮了！
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_REPEAT_#2_739_M", "Ye won't find cheaper pelts within a hunnerd miles!", "百里之内，无更贱之裘革矣！");
            // 买到就是赚到……
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_REPEAT_#3_069_M", "Get 'em while ye can...", "可得则速取之……");
            // 多便宜……
            AddTranslation("SPECIAL_NODES_TRAPPERINTROREDUCEDCOST_REPEAT_#4_655_M", "And cheap...", "且贱……");
            // 没错。[w:0.3]我是P03。[w:0.3]懂？
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY1_288_M", "Yep.[w:0.3] I'm P03.[w:0.3] OK?", "然。[w:0.3]咱乃鉟〇三。[w:0.3]可乎？");
            // 你选了我的初始牌组。[w:0.3]那你必须学会如何使用[c:dB]能量[c:]……
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY1_593_M", "You picked my starter deck.[w:0.3] That means you have to learn to use [c:dB]Energy[c:]...", "卿择咱牌之初列。[w:0.3]则须学用[c:dB]能[c:]……");
            // 真的要我和你解释这个吗？
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY1_863_M", "Do I really have to explain this to you?", "此真须咱为你解乎？");
            // 在每回合初，你可以提升你的[c:dB]能量上限[c:]。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY2_648_M", "At the start of each turn you increase your [c:dB]Max Energy[c:].", "每合之始，卿之[c:dB]能极[c:]加一。");
            // 能量是否消耗，[w:0.3]不会产生影响。[w:0.4]在每回合初，[w:0.2]你的[c:dB]能量[c:]会恢复至[c:dB]上限。[c:]
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY2_523_M", "Spend it or not, [w:0.3]doesn't matter.[w:0.4] At the start of your turn,[w:0.2] your [c:dB]Energy[c:] refills to the [c:dB]Max.[c:]", "用与不用，[w:0.3]无所异也。[w:0.4]及卿合之始，[w:0.2]卿之[c:dB]能[c:]复充至[c:dB]能极。[c:]");
            // 明白没？
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY2_247_M", "Get it?", "晓乎？");
            // 看到没？[w:0.3]你消耗[c:dB]能量[c:]打出卡牌。[w:0.3]但在下一回合，能量又回来了。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY3_925_M", "See that?[w:0.3] You spent your [c:dB]Energy[c:] to play the card.[w:0.3] But you get it back next turn.", "见乎？[w:0.3]卿耗[c:dB]能[c:]以陈此牌。[w:0.3]然次合复得之。");
            // 听烦了？[w:0.3]行吧我也说厌了。[w:0.3]我还有要紧事做。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY3_732_M", "Sick of hearing from me?[w:0.3] Well I'm sick of talking.[w:0.3] I've got important work to do.", "闻咱言厌乎？[w:0.3]然咱亦厌言矣。[w:0.3]咱有要务。");
            // 等会儿再见。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALENERGY3_421_M", "You'll see me later.", "后当复见我。");
            // 哈喽。[w:0.3]好像有人在召唤我……[w:0.3]有何贵干？
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS1_770_M", "Greetings.[w:0.3] My consciousness has been summoned it seems...[w:0.3] But for what purpose?", "敬问。[w:0.3]吾识似为人所召……[w:0.3]然何为哉？");
            // 啊！[w:0.3]你选中了我的初始牌组，想要快速教学。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS1_994_M", "Ah![w:0.3] You have selected my starter deck and require a short lesson.", "噫！[w:0.3]汝既择朕初牌列，故须略闻其说。");
            // 看好了，[w:0.3]魔法卡牌依靠[c:dlGr]玛[c:brnO]珂[c:]生效。[w:0.3]不过也有人管它们叫[c:dlGr]宝[c:brnO]石[c:]。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS1_210_M", "You see,[w:0.3] Magickal cards are powered by [c:dlGr]M[c:brnO]o[c:dSG]x[c:].[w:0.3] Though some refer to them as [c:dlGr]G[c:brnO]e[c:dSG]m[c:]s.", "夫术牌资于[c:dlGr]玛[c:brnO]珂[c:dSG][c:]。[w:0.3]虽或谓之以[c:dlGr][c:brnO][c:dSG]玉[c:]。");
            // 如果你的牌桌上有其中一种[c:dlGr]玛[c:brnO]珂[c:][w:0.2]，则可以出消耗该成本的牌。[w:0.3]先出一张试试看。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS1_670_M", "If you have one of these [c:dlGr]M[c:brnO]o[c:dSG]x[c:][w:0.2] on the board, you may play cards with that cost.[w:0.3] Start by playing one.", "若局上有一[c:dlGr]玛[c:brnO]珂[c:dSG][c:][w:0.2]，则可陈直此者之牌。[w:0.3]姑先陈一。");
            // 看见没？[w:0.3]你可以先打出和[c:dlGr]宝[c:brnO]石[c:]颜色一致的魔法卡牌。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS2_289_M", "You see?[w:0.3] Now you may play Magickal cards of that [c:dlGr]G[c:brnO]e[c:dSG]m[c:]'s color.", "见乎？[w:0.3]今可陈与彼[c:dlGr][c:brnO][c:dSG]玉[c:]同色之术牌。");
            // 上手很简单。[w:0.3]我想不通我那些学生为什么琢磨了半天还没明白。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS2_277_M", "It is quite simple really.[w:0.3] I cannot comprehend how my students sometimes struggle.", "此诚易耳。[w:0.3]朕不解朕弟子何以时或困焉。");
            // 是我岔开话题了。[w:0.3]你继续。[w:0.3]我在塔顶等你。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALGEMS2_284_M", "But I have digressed.[w:0.3] Carry on.[w:0.3] I await you atop my tower.", "然吾旁及矣。[w:0.3]行矣。[w:0.3]吾俟尔于朕塔之巅。");
            // [c:gray]上神野兽冥刻者的声音忽地穿透你的颅腔。你顿时僵在原地，不寒而栗。[c:]
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBLOOD_385_M", "[c:gray]You froze in fear as the words of the great Scrybe of Beasts entered your skull uninvited.[c:]", "[c:gray]兽之大司锲之言，不召而入乃颅，汝惧而僵矣。[c:]");
            // 别怕，[w:0.3]我不过是想说明一下你挑选的牌组。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBLOOD_934_M", "Fear not,[w:0.3] I only wish to explain to you the deck that you selected.", "毋惧，[w:0.3]余但欲释乃所择之牌列耳。");
            // 想要使用我的卡牌……[w:0.3]献祭必不可少。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBLOOD_380_M", "In order to play my cards...[w:0.3] sacrifices must be made.", "欲陈朕牌……[w:0.3]则必有所祀。");
            // [c:gray]冥刻者观察着你的反应，[w:0.3]他看出你似乎并没有受这句话的震慑。[c:]
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBLOOD_749_M", "[c:gray]The Scrybe assessed your reaction,[w:0.3] noting that you did not seem surprised by this information.[c:]", "[c:gray]司锲察乃色，[w:0.3]知尔闻此似不以为骇。[c:]");
            // 看来你不需要教学。[w:0.3]但记住一点，几乎所有东西都可以献祭。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBLOOD_865_M", "Perhaps you need no lesson.[w:0.3] But remember that almost anything can be sacrificed.", "殆无庸教矣。[w:0.3]然当记之：几物皆可祀。");
            // 可能出的是燃油，[w:0.3]甚至是骨髓。[w:0.3]但如果它流了血……[w:0.3]嗯，[w:0.3]你知道该干嘛。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBLOOD_437_M", "It may bleed oil,[w:0.3] or even marrow.[w:0.3] But if it bleeds...[w:0.3] Well,[w:0.3] you know what to do.", "其所出或有油，[w:0.3]或至髓。[w:0.3]然苟有流……[w:0.3]然后，[w:0.3]汝知所为矣。");
            // 精彩！[w:0.3]首战号角已响。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBONES_562_M", "Marvelous![w:0.3] Your first battle.", "善哉！[w:0.3]乃首战也。");
            // 看到我在这很惊讶吗？[w:0.3]你自个儿选中了我的初始牌组。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBONES_873_M", "Are you surprised to see me here?[w:0.3] But you did select my starter deck.", "见我于此，汝惊乎？[w:0.3]然汝自择朕初牌列耳。");
            // 要想得到我的卡牌，[w:0.3]你需要收集[c:gray]骨头[c:]。想要获得一根[c:gray]骨头[c:]，你就得……
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBONES_050_M", "In order to play my cards,[w:0.3] you will need to collect [c:gray]bones[c:]. You gain a [c:gray]bone[c:] when...", "欲陈朕牌，[w:0.3]汝须聚[c:gray]骨[c:]。得一[c:gray]骨[c:]于……");
            // 你怎么目光呆滞？[w:0.3]很好！[w:0.5]精彩。[w:0.5]看来你学会了。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBONES_768_M", "Why do your eyes glaze over?[w:0.3] Hm![w:0.5] Marvelous.[w:0.5] You already understand.", "目何遽惛乎？[w:0.3]噫！[w:0.5]善哉。[w:0.5]汝已解矣。");
            // 我的虫生没有白白浪费。
            AddTranslation("GBC_TUTORIAL_RESOURCETUTORIALBONES_419_M", "My time as an insect was not a total waste.", "奴之为虫，未尽徒然。");
            // 纸上写着：[c:gray]亲爱的格里魔拉，我认为P03的阴谋可能远不止夺权篡位这么简单。
            AddTranslation("GBC_WORLD_WIZARDTEMPLENOTEDESK_589_M", "The note reads: [c:gray]Dearest Grimora, I believe P03's plot may go far past the extent of a common power grab.", "札曰：[c:gray]格里魔拉吾友，吾谓鉟〇三之谋，殆不止寻常夺权而已。");
            // [c:gray]事实上，这一“终极冥刻”将酿成大祸，后果不堪设想。
            AddTranslation("GBC_WORLD_WIZARDTEMPLENOTEDESK_860_M", "[c:gray]Indeed, this \"Great Transcendence\" will have catastrophic and unpredictable results.", "[c:gray]诚然，此“大陟”将致大祸，其变莫测。");
            // 纸上文字缺失，结尾戛然而止：[c:gray]我恳请你考虑……[c:]
            AddTranslation("GBC_WORLD_WIZARDTEMPLENOTEDESK_697_M", "The note is incomplete and ends abruptly: [c:gray]I urge you to consider-[c:]", "札残而遽绝：[c:gray]吾请尔熟思—[c:]");
            // 他奶奶的，[w:0.2]我能[w:0.2][c:R]闻到[c:][w:0.2]你身上的[c:R]肉味[c:]！
            AddTranslation("GBC_NPC_PROSPECTORNPCMEATREMINDER_752_M", "Dag nab it,[w:0.2] I can[w:0.2] [c:R]smell[c:][w:0.2] that [c:R]meat[c:] on ye!", "彼其老娘，[w:0.2]俺能[w:0.2][c:R]嗅[c:][w:0.2]你身之[c:R]肉[c:]矣！");
            // 我还没把那只该死的猎犬找回来……[w:0.3]你就不能也扔一点到她的[c:R]碗[c:]里吗？
            AddTranslation("GBC_NPC_PROSPECTORNPCMEATREMINDER_359_M", "And I'm still missin' that dang hound...[w:0.3] Can't ye put a little in her [c:R]bowl[c:]?", "而俺犹失彼恶犬……[w:0.3]你不能少投之于其[c:R]盂[c:]乎？");
            // 你可以改变从副牌组抽的宝石颜色。
            AddTranslation("HOLDABLEGEMSMODULE_891_M", "You can change the color of the gems you draw from your Side Deck.", "汝可易乃自副牌列所引之玉色。");
            // 该休息一下了。
            AddTranslation("GRIMORAGAMEFLOWMANAGER_048_M", "It is time to rest.", "时当休矣。");
            // 我必须……再……
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_872_M", "I must... still...", "吾尚须……");
            // 跟你握握手……
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_301_M", "Shake your hand...", "执乃手……");
            // 挑吧。
            AddTranslation("BUILDTOTEMSEQUENCER_890_M", "Choose.", "择。");
            // 获得此卡牌需要更多牙齿。
            AddTranslation("BUYPELTSSEQUENCER_463_M", "You'll need more teeth for that one.", "欲得彼，则须更多齿。");
            // 你在迷雾中无意发现了几块怪石。
            AddTranslation("CARDMERGESEQUENCER_743_M", "You stumbled into some strange stones in the mist.", "汝于雾中误逢异石。");
            // 你不得不献上值当的[c:bR]祭品。[c:]你会从此失去它……
            AddTranslation("CARDMERGESEQUENCER_140_M", "You were compelled to choose a worthy [c:bR]sacrifice.[c:] One that will be lost forever...", "汝不得不择一堪为[c:bR]牲[c:]者，一去则永不复得……");
            // 你注视着你的兽群，选了一只健壮的作为[c:bR]宿主。
            AddTranslation("CARDMERGESEQUENCER_330_M", "You looked upon your menagerie and selected a healthy [c:bR]host.[c:]", "汝视乃群兽，择一壮者为[c:bR]受[c:]。");
            // 所有祭品都互不相容……不可能共生。
            AddTranslation("CARDMERGESEQUENCER_014_M", "There are no compatible sacrifices... It won't work.", "无相宜之牲……弗可行也。");
            // 你遇到一些看着很眼熟的石头。但它们又有不同之处……
            AddTranslation("CARDREMOVESEQUENCER_245_M", "You came across some familiar stones. But there was something different...", "汝逢数石，若故识然；然复有异……");
            // 你的直觉告诉你，被选中的造物……恐怕难逃一劫。
            AddTranslation("CARDREMOVESEQUENCER_260_M", "You intuited that the fate of the creature selected for this... would not be pleasant.", "汝意为此所择之物，其命终不嘉。");
            // 你无情地残害了[c:bR]{0}[c:]……
            AddTranslation("CARDREMOVESEQUENCER_617_M", "You callously slaughtered the [c:bR]{0}[c:]...", "汝忍心屠[c:bR]{0}[c:]……");
            // 但是，[c:bR]骨王[c:]对你的祭品很满意。
            AddTranslation("CARDREMOVESEQUENCER_268_M", "However, the [c:bR]Bone Lord[c:] was pleased by your sacrifice.", "然[c:bR]骨王[c:]悦尔所祀。");
            // 你甩去惨死的[c:bR]{0}[c:]的内脏，继续上路。
            AddTranslation("CARDREMOVESEQUENCER_408_M", "You shook off the viscera of the poor [c:bR]{0}[c:] and carried onwards.", "汝抖落彼可怜[c:bR]{0}[c:]之腑，复前行。");
            // 是[c:bR]{0}[c:]。{1}
            AddTranslation("CARDREMOVESEQUENCER_960_M", "A [c:bR]{0}[c:]. {1}", "一[c:bR]{0}[c:]。{1}");
            // 只有[c:bR]1[c:]张可以屈尊加入你可怜的牌组。
            AddTranslation("CARDSINGLECHOICESSEQUENCER_571_M", "Only [c:bR]1[c:] may grace your paltry deck.", "惟[c:bR]一[c:]可厕乃陋牌列。");
            // 骨头
            AddTranslation("CARDSINGLECHOICESSEQUENCER_312", "Bone", "骨");
            // 又一只造物加入了你的队伍。
            AddTranslation("CARDSINGLECHOICESSEQUENCER_695_M", "Another creature joins your caravan.", "又一物入乃行旅。");
            // ……没了？
            AddTranslation("DEATHCARDCREATIONSEQUENCER_544_M", "...Nothing?", "……无乎？");
            // 你就这点本事？
            AddTranslation("DEATHCARDCREATIONSEQUENCER_612_M", "That's all you had?", "汝技止此乎？");
            // 我还不知道你姓甚名谁……
            AddTranslation("DEATHCARDCREATIONSEQUENCER_754_M", "I never did ask you your name...", "余竟未问乃名……");
            // 请吧。在上面刻上你的大名。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_730_M", "Please. Inscribe your name.", "请，刻乃名。");
            // 来吧，选择一张卡牌决定所需[c:bR]成本[c:]。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_019_M", "Please, choose a card to draw the [c:bR]cost[c:] from.", "请择一牌，取其[c:bR]直[c:]。");
            // 再来一张。这张卡牌会用来决定[c:bR]力量和生命值[c:]。挑数字。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_204_M", "And another. This time I will use its [c:bR]power and health[c:]. The numbers.", "更择一牌。今余将取其[c:bR]威与命[c:]之数。");
            // 现在请选择一张卡牌决定它的[c:bR]印记[c:]。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_020_M", "Now choose a card from which we will extract the [c:bR]sigils[c:].", "今择一牌，余将取其[c:bR]印契[c:]。");
            // 和[c:bR]{1}[c:]一样，消耗[c:bR]{0}点血量[c:]。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_930_M", "A cost of [c:bR]{0} blood[c:] from the [c:bR]{1}[c:].", "取[c:bR]{1}[c:]之直，为[c:bR]{0}血[c:]。");
            // 和[c:bR]{1}[c:]一样，消耗[c:bR]{0}根骨头[c:]。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_864_M", "A cost of [c:bR]{0} bones[c:] from the [c:bR]{1}[c:].", "取[c:bR]{1}[c:]之直，为[c:bR]{0}骨[c:]。");
            // 跟[c:bR]{0}[c:]一样……[c:bR]无需[c:]……成本。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_047_M", "A cost of... [c:bR]free[c:]... from the [c:bR]{0}[c:].", "取[c:bR]{0}[c:]之直，为[c:bR]无直[c:]。");
            // [c:bR]{0}力量[c:]和[c:bR]{1}生命[c:]，跟[c:bR]{2}[c:]一致。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_273_M", "[c:bR]{0} Power[c:] and [c:bR]{1} Health[c:] from the [c:bR]{2}[c:].", "取[c:bR]{2}[c:]之[c:bR]{0}威[c:]与[c:bR]{1}命[c:]。");
            // 跟[c:bR]{1}[c:]同样的[c:bR]{0}印记[c:]。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_352_M", "A [c:bR]Sigil of {0}[c:] from the [c:bR]{1}[c:].", "取[c:bR]{1}[c:]之[c:bR]{0}之印[c:]。");
            // 跟[c:bR]{2}[c:]同样的[c:bR]{0}印记[c:]和[c:bR]{1}印记[c:]。
            AddTranslation("DEATHCARDCREATIONSEQUENCER_191_M", "A [c:bR]Sigil of {0}[c:] and a [c:bR]Sigil of {1}[c:] from the [c:bR]{2}[c:].", "取[c:bR]{2}[c:]之[c:bR]{0}之印[c:]与[c:bR]{1}之印[c:]。");
            // 唔……{0}、{1}和{2}……
            AddTranslation("DECKTRIALSEQUENCER_149_M", "Hmm... {0}, {1}, and {2}...", "唔……{0}、{1}与{2}……");
            // 带[c:bR]水袭[c:]印记的卡牌
            AddTranslation("DECKTRIALSEQUENCER_169", "card with the [c:bR]Waterborne[c:] sigil", "携[c:bR]潜袭[c:]印契之牌");
            // 带[c:bR]移动[c:]印记的卡牌
            AddTranslation("DECKTRIALSEQUENCER_679", "!DELETED!", "携[c:bR]移动[c:]印契之牌");
            // 带[c:bR]空袭[c:]印记的卡牌
            AddTranslation("DECKTRIALSEQUENCER_422", "card with the [c:bR]Airborne[c:] sigil", "携[c:bR]翔袭[c:]印契之牌");
            // 稀有卡牌
            AddTranslation("DECKTRIALSEQUENCER_765", "Rare card", "罕有牌");
            // 毛皮卡牌
            AddTranslation("DECKTRIALSEQUENCER_366", "Pelt card", "裘革牌");
            // 环形虫
            AddTranslation("DECKTRIALSEQUENCER_997", "Ring Worm", "环虫");
            // 简体中文
            AddTranslation("DECKTRIALSEQUENCER_018_M", "!DELETED!", "文言");
            // 啊，[c:bR]{0}[c:]是张{1}。
            AddTranslation("DECKTRIALSEQUENCER_002_M", "Ah, [c:bR]{0}[c:] is a {1}.", "噫，[c:bR]{0}[c:]乃{1}也。");
            // 呃……一张{0}都没有……
            AddTranslation("DECKTRIALSEQUENCER_301_M", "Hmmm... Not a single {0}...", "唔……无一{0}……");
            // {0}张{1}……{2}张{3}……{4}张{5}……
            AddTranslation("DECKTRIALSEQUENCER_158_M", "{0} from the {1}... {2} from the {3}... {4} from the {5}...", "{1}者{0}……{3}者{2}……{5}者{4}……");
            // 那野兽现身了。这是……
            AddTranslation("DECKTRIALSEQUENCER_052_M", "The beast revealed itself. It was...", "其兽自见。乃……");
            // [c:bSG]载灵{0}[c:]加入了你的兽群。
            AddTranslation("DECKTRIALSEQUENCER_511_M", "The [c:bSG]Inhabited {0}[c:] joined your menagerie.", "[c:bSG]载灵{0}[c:]入乃群兽。");
            // 你来到一个黑黢黢的洞穴前。
            AddTranslation("DECKTRIALSEQUENCER_246_M", "You arrived at the inky black mouth of a cave.", "汝至一黑墨之窟口。");
            // 选一张。
            AddTranslation("GAINCONSUMABLESSEQUENCER_908_M", "Choose one.", "择其一。");
            // 你背着三样沉甸甸的道具继续上路。
            AddTranslation("GAINCONSUMABLESSEQUENCER_258_M", "Feeling overburdened enough with a full 3 items, you carried on.", "三器已盈，汝觉其重，遂复前行。");
            // 等一下……
            AddTranslation("GAINCONSUMABLESSEQUENCER_887_M", "And have a second...", "且慢……");
            // 你最多只能带三样。
            AddTranslation("GAINCONSUMABLESSEQUENCER_790_M", "Three is as much as you can carry.", "汝所能荷，不过三器。");
            // 大
            AddTranslation("BUILDACARDINFO_009", "BIG", "巨");
            // 小
            AddTranslation("BUILDACARDINFO_368", "LIL", "小");
            // 高个儿
            AddTranslation("BUILDACARDINFO_606", "TALL", "修");
            // 神
            AddTranslation("BUILDACARDINFO_647", "HOLY", "神");
            // 非
            AddTranslation("BUILDACARDINFO_614", "NOT", "非");
            // 这
            AddTranslation("BUILDACARDINFO_750", "THE", "此");
            // 那
            AddTranslation("BUILDACARDINFO_586", "DAT", "彼");
            // 圣
            AddTranslation("BUILDACARDINFO_713", "ST.", "圣");
            // 博士
            AddTranslation("BUILDACARDINFO_179", "DR.", "博士");
            // 女士
            AddTranslation("BUILDACARDINFO_080", "MRS.", "夫人");
            // 先生
            AddTranslation("BUILDACARDINFO_767", "MR.", "公");
            // 肥
            AddTranslation("BUILDACARDINFO_051", "FAT", "腴");
            // 聪
            AddTranslation("BUILDACARDINFO_187", "SMART", "慧");
            // 好
            AddTranslation("BUILDACARDINFO_533", "GOOD", "善");
            // 帮
            AddTranslation("BUILDACARDINFO_320", "HELP", "助");
            // 咻
            AddTranslation("BUILDACARDINFO_264", "SHOOT", "射");
            // 噜
            AddTranslation("BUILDACARDINFO_343", "LOOT", "掠");
            // 嘟
            AddTranslation("BUILDACARDINFO_406", "TOOT", "鸣");
            // 乐
            AddTranslation("BUILDACARDINFO_952", "LOL", "悦");
            // 扭
            AddTranslation("BUILDACARDINFO_591", "SCREW", "旋");
            // 火
            AddTranslation("BUILDACARDINFO_447", "FIRE", "火");
            // 男
            AddTranslation("BUILDACARDINFO_611", "BOI", "郎");
            // 先生
            AddTranslation("BUILDACARDINFO_680", "ESQ.", "君");
            // 机器
            AddTranslation("BUILDACARDINFO_588", "ROBO", "机");
            // 货
            AddTranslation("BUILDACARDINFO_530", "THING", "物");
            // 你的
            AddTranslation("BUILDACARDINFO_087", "YOU", "汝");
            // 机器人
            AddTranslation("BUILDACARDINFO_916", "BOT", "机人");
            // 的
            AddTranslation("BUILDACARDINFO_123", "MATIC", "式");
            // {0}点属性值
            AddTranslation("BUILDACARDSCREEN_483", "{0} SP", "{0}数点");
            // 好了，小天才。加油吧。
            AddTranslation("BUILDACARDSEQUENCER_621_M", "Alright, genius. Go for it.", "善矣，慧子。为之。");
            // 把[c:bR]属性值[c:]用在属性和印记上。能量成本越高，属性值越高。
            AddTranslation("BUILDACARDSEQUENCER_318_M", "Spend [c:bR]SP[c:] on stats and sigils. You get more SP for a higher energy cost.", "以[c:bR]数点[c:]加诸数与印契。能直愈高，则所得数点愈多。");
            // 另一个。
            AddTranslation("PART3DECKREVIEWSEQUENCER_591_M", "Other one.", "他一。");
            // 我会跳过我的下一回合。
            AddTranslation("HOURGLASSITEM_238_M", "I'll pass my next turn.", "余次合将过。");
            // 你剪不了这个……它太厚了。
            AddTranslation("SCISSORSITEM_967_M", "You can't cut that... It's too thick.", "此不可剪……其厚矣。");
            // {0}枚机器币
            AddTranslation("HOLOMAPSHOPNODE_639", "{0} ROBOBUCKS", "{0}机币");
            // 瞧啊。是[c:bR]规则书[c:]。
            AddTranslation("RULEBOOKCONTROLLER_649_M", "Behold. The [c:bR]Rule Book[c:].", "视之。此[c:bR]律书[c:]也。");
            // 附录12，第六节 - 能力{0}
            AddTranslation("RULEBOOKINFO_197", "APPENDIX XII, SUBSECTION VI - ABILITIES {0}", "附编十二，第六节——诸技{0}");
            // 附录12，第七节 - 可变参数{0}
            AddTranslation("RULEBOOKINFO_074", "APPENDIX XII, SUBSECTION VII - VARIABLE STATS {0}", "附编十二，第七节——变数{0}");
            // 附录12，第八节 - 奖励{0}
            AddTranslation("RULEBOOKINFO_072", "APPENDIX XII, SUBSECTION VIII - BOONS {0}", "附编十二，第八节——诸惠{0}");
            // 附录12，第九节 - 道具{0}
            AddTranslation("RULEBOOKINFO_757", "APPENDIX XII, SUBSECTION IX - ITEMS {0}", "附编十二，第九节——诸器{0}");
            // {0}具有：{1}点力量，{2}点生命值{3}。
            AddTranslation("RULEBOOKPAGE_235", "A {0} is defined as: {1} Power, {2} Health{3}.", "所谓{0}者：{1}威，{2}命{3}。");
            // 带有该印记的卡牌
            AddTranslation("ABILITYPAGECONTENT_378", "a card bearing this sigil", "负此印契之牌");
            // 使用须知：{0}
            AddTranslation("ITEMPAGE_321", "To the user: {0}", "告用者：{0}");
            // 点击激活：{0}
            AddTranslation("ABILITYINFO_623", "Activate: {0}", "按发：{0}");
            // 长老{0}
            AddTranslation("EVOLVE_701", "Elder {0}", "耆{0}");
            // 已经上锁了……
            AddTranslation("LATCH_922_M", "It's already latched...", "契之既遗矣……");
            // {0}尾巴
            AddTranslation("TAILONHIT_306", "{0} Tail", "{0}之尾");
            // 那是什么？
            AddTranslation("CAGEDWOLF_586_M", "What was that?", "彼何物也？");
            // 多余伤害
            AddTranslation("EXCESSDAMAGEPANEL_269", "EXCESS DAMAGE", "溢伤");
            // 获得箔片！
            AddTranslation("EXCESSDAMAGEPANEL_147", "Foils Gained!", "得箔！");
            // 你已无更多卡牌。饥饿侵袭而来！
            AddTranslation("PIXELCARDDRAWPILES_314_M", "You are out of cards. Starvation sets in!", "汝已无牌可引。饥作矣！");
            // {0}受到过量伤害！
            AddTranslation("PIXELCOMBATPHASEMANAGER_115_M", "{0} was dealt overkill damage!", "{0}受溢伤矣！");
            // 巴里
            AddTranslation("BOUNTYHUNTERGENERATOR_719", "Barry", "巴里");
            // 伯特
            AddTranslation("BOUNTYHUNTERGENERATOR_790", "Bolt", "伯特");
            // 吉尔
            AddTranslation("BOUNTYHUNTERGENERATOR_896", "Gear", "吉尔");
            // 扎普
            AddTranslation("BOUNTYHUNTERGENERATOR_272", "Zap", "扎普");
            // 鲁斯特
            AddTranslation("BOUNTYHUNTERGENERATOR_066", "Rust", "鲁斯特");
            // 克莱恩
            AddTranslation("BOUNTYHUNTERGENERATOR_843", "Clain", "克莱恩");
            // 克莱肯
            AddTranslation("BOUNTYHUNTERGENERATOR_675", "Clank", "克莱肯");
            // 丹克
            AddTranslation("BOUNTYHUNTERGENERATOR_441", "Tank", "丹克");
            // 刚
            AddTranslation("BOUNTYHUNTERGENERATOR_460", "Gun", "刚");
            // 修特
            AddTranslation("BOUNTYHUNTERGENERATOR_783", "Shoot", "修特");
            // 马克西姆
            AddTranslation("BOUNTYHUNTERGENERATOR_584", "Maksim", "马克西姆");
            // 威尔金
            AddTranslation("BOUNTYHUNTERGENERATOR_087", "Wilkin", "威尔金");
            // 凯茜
            AddTranslation("BOUNTYHUNTERGENERATOR_603", "Kaycee", "凯茜");
            // 霍布斯
            AddTranslation("BOUNTYHUNTERGENERATOR_615", "Hobbes", "霍布斯");
            // 格林德
            AddTranslation("BOUNTYHUNTERGENERATOR_659", "Grind", "格林德");
            // 布拉斯特
            AddTranslation("BOUNTYHUNTERGENERATOR_132", "Blast", "布拉斯特");
            // 科拉希
            AddTranslation("BOUNTYHUNTERGENERATOR_350", "Crash", "科拉希");
            // 月
            AddTranslation("BOUNTYHUNTERGENERATOR_660", "Moon", "月");
            // 锡普
            AddTranslation("BOUNTYHUNTERGENERATOR_361", "Zip", "锡普");
            // 森
            AddTranslation("BOUNTYHUNTERGENERATOR_917", "son", "森");
            // 斯坦
            AddTranslation("BOUNTYHUNTERGENERATOR_013", "stein", "斯坦");
            // 多蒂尔
            AddTranslation("BOUNTYHUNTERGENERATOR_363", "dottir", "多蒂尔");
            // 维克
            AddTranslation("BOUNTYHUNTERGENERATOR_304", "vic", "维克");
            // 伯格
            AddTranslation("BOUNTYHUNTERGENERATOR_098", "berg", "伯格");
            // 斯凯
            AddTranslation("BOUNTYHUNTERGENERATOR_733", "sky", "斯凯");
            // 斯基
            AddTranslation("BOUNTYHUNTERGENERATOR_459", "ski", "斯基");
            // 麦克
            AddTranslation("BOUNTYHUNTERGENERATOR_189", "Mac", "麦克");
            // 迈可
            AddTranslation("BOUNTYHUNTERGENERATOR_567", "Mc", "迈可");
            // 简体中文
            AddTranslation("BOUNTYHUNTERGENERATOR_587", "!DELETED!", "文言");
            // 简体中文
            AddTranslation("BOUNTYHUNTERGENERATOR_335", "!DELETED!", "文言");
            // 雷金纳德
            AddTranslation("SAVEFILE_852", "Reginald", "雷金纳德");
            // 路易斯
            AddTranslation("SAVEFILE_247", "Louis", "路易斯");
            // 卡明斯基
            AddTranslation("SAVEFILE_286", "Kaminski", "卡明斯基");
            // 上次保存时间：1秒前
            AddTranslation("SAVEMANAGER_763", "LAST SAVED 1 SECOND AGO", "前存：一息前");
            // 上次保存时间：{0}秒前
            AddTranslation("SAVEMANAGER_337", "LAST SAVED {0} SECONDS AGO", "前存：{0}息前");
            // 上次保存时间：1分钟前
            AddTranslation("SAVEMANAGER_980", "LAST SAVED 1 MINUTE AGO", "前存：一分前");
            // 上次保存时间：{0}分钟前
            AddTranslation("SAVEMANAGER_660", "LAST SAVED {0} MINUTES AGO", "前存：{0}分前");
            // 拿上此牌组。
            AddTranslation("PICKUPCARDPILEVOLUME_768", "Take the deck.", "取此牌列。");
            // 不拿。
            AddTranslation("PICKUPCARDPILEVOLUME_439", "Leave it.", "舍之。");
            // 这些卡牌已加入你的牌库。
            AddTranslation("PICKUPCARDPILEVOLUME_834_M", "The cards were added to your collection.", "诸牌已入乃牌藏。");
            // 献祭[c:R]2[c:]张[c:R]{0}[c:]卡牌？
            AddTranslation("MYCOLOGISTSDIALOGUENPC_773_M", "Sacrifice [c:R]2[c:] of your [c:R]{0}[c:] cards?", "以乃[c:R]{0}[c:]牌者[c:R]二[c:]为祀乎？");
            // 放过肉的地方有股微弱的臭味。
            AddTranslation("SAFEVOLUME_568_M", "There is a faint odor where the meat once was.", "肉故所在，尚有微臭。");
            // 你从保险箱里取出一坨臭肉。
            AddTranslation("SAFEVOLUME_659_M", "You take a stinking pile of meat from the safe.", "汝自匮中取一臭肉。");
            // 把鱼饵的照片放到鱼线上？
            AddTranslation("SHARKRODVOLUME_946_M", "Place the photo of bait on the line?", "置饵之影于钓线乎？");
            // 放。
            AddTranslation("SHARKRODVOLUME_959", "Place it.", "置之。");
            // 不放。
            AddTranslation("SHARKRODVOLUME_048", "Don't place it.", "勿置。");
            // 鱼线上绑着个鱼钩。但你没有鱼饵。
            AddTranslation("SHARKRODVOLUME_556_M", "A hook on a line. But you have no bait.", "线上有钩，然汝无饵。");
            // 上面写道：
            AddTranslation("GAINEPITAPHPIECE_706", "It reads:", "其文曰：");
            // 你发现了一块墓志铭……
            AddTranslation("GHOULNPC_408", "You found a piece of an epitaph...", "汝得墓志一片……");
            // 你的所有卡牌
            AddTranslation("GRIMORABOSSOPPONENT_139", "All Your Cards", "乃诸牌");
            // 格里魔拉
            AddTranslation("GRIMORABOSSOPPONENT_854", "Grimora", "格里魔拉");
            // 事故
            AddTranslation("GRIMORABATTLESEQUENCER_349", "Accident", "横祸");
            // 不可献祭。
            AddTranslation("CARDPREVIEWPANEL_433", "CAN'T BE SACRIFICED.", "不可为祀。");
            // 以及： 
            AddTranslation("CARDPREVIEWPANEL_833", "Also: ", "又：");
            // 第{0}页
            AddTranslation("COLLECTIONUI_308", "PAGE {0}", "第{0}页");
            // 低
            AddTranslation("OPTIONSUI_285", "Low", "下");
            // 中
            AddTranslation("OPTIONSUI_172", "Medium", "中");
            // 高
            AddTranslation("OPTIONSUI_016", "High", "上");
            // 重置存档
            AddTranslation("OPTIONSUI_953", "RESET SAVE DATA", "重置存录");
            // 当真重置
            AddTranslation("OPTIONSUI_383", "REALLY RESET IT", "果真重置");
            // 全都重置
            AddTranslation("OPTIONSUI_885", "ALL OF IT", "尽数重置");
            // 切换为{0}
            AddTranslation("OPTIONSUI_382", "!DELETED!", "置以为{0}");
            // 死亡
            AddTranslation("PACKOPENINGUI_725", "Deathly", "死属");
            // 野兽
            AddTranslation("PACKOPENINGUI_533", "Beastly", "兽属");
            // 科技
            AddTranslation("PACKOPENINGUI_830", "Techno", "机属");
            // 魔法
            AddTranslation("PACKOPENINGUI_369", "Magical", "术属");
            // 你获得了一个{0}卡包！
            AddTranslation("PACKOPENINGUI_120", "You received a {0} card pack!", "汝得一{0}牌韬！");
            // {0}卡包
            AddTranslation("SHOPUI_633", "{0} Pack", "{0}牌韬");
            // 每个卡包内含1张稀有卡牌、2张普通{0}卡牌和2张任意普通卡牌。
            AddTranslation("SHOPUI_113", "A pack containing 1 Rare and 2 Common {0} cards and 2 Common cards of any type.", "一韬含罕{0}牌一、常{0}牌二，并任属常牌二。");
            // 此卡牌已加入你的牌库。
            AddTranslation("SHOPUI_244_M", "The card was added to your collection.", "此牌已入乃牌藏。");
            // 安息吧{0}
            AddTranslation("QUILLUIANIMATION_722", "R.I.P. {0}", "归窀穸矣，{0}");
            // 第{0}回合至第{1}回合
            AddTranslation("QUILLUIANIMATION_285", "Turn {0} to Turn {1}", "自第{0}合至第{1}合");
            // 因{0}死亡
            AddTranslation("QUILLUIANIMATION_433", "Death by {0}", "死于{0}");
            // 删除存档，开始新游戏？
            AddTranslation("MENUCONTROLLER_470", "Erase save data and start New Game?", "削存录而启新局乎？");
            // 瞧好我的图腾。我的[c:bR]犬类[c:]卡牌上刻有[c:bR]空袭[c:]印记。
            AddTranslation("TOTEMOPPONENT_028", "Behold my totem. It inscribes my [c:bR]Canine[c:] cards with the [c:bR]Airborne[c:] sigil.", "视朕神偶。朕[c:bR]犬属[c:]牌，皆刻以[c:bR]翔袭[c:]之印。");
            // 啊啊啊啊啊啊！
            AddTranslation("ROYALBOSSOPPONENT_321_M", "Y'AARRRRR!", "呀啰啰啰！");
            // 开钓吧。
            AddTranslation("ANGLERBATTLESEQUENCER_742_M", "Go fish.", "且钓之。");
            // 拿下它们！
            AddTranslation("PROSPECTORBATTLESEQUENCER_522_M", "Git 'em!", "擒之！");
            // 它卡里有金子！
            AddTranslation("PROSPECTORBOSSOPPONENT_049_M", "THAR'S GOLD IN THEM CARDS!", "彼牌中有金！");
            // 金……金子！我要掘金子！
            AddTranslation("PROSPECTORBOSSOPPONENT_000_M", "G-G-GOLD! I'VE STRUCK GOLD!", "金—金—金子！俺掘得金矣！");
            // 没……没有金子？
            AddTranslation("PROSPECTORBOSSOPPONENT_526_M", "N-... NO GOLD?", "无—……无金乎？");
            // 轮到你的回合
            AddTranslation("COMPOSITERULEDISPLAYER_479", "YOUR TURN STARTS", "子合始");
            // 你出牌
            AddTranslation("COMPOSITERULEDISPLAYER_171", "YOU PLAY A CARD", "子陈一牌");
            // 卡牌被袭击
            AddTranslation("COMPOSITERULEDISPLAYER_366", "A CARD IS ATTACKED", "一牌受攻");
            // 卡牌死亡
            AddTranslation("COMPOSITERULEDISPLAYER_467", "A CARD DIES", "一牌死");
            // 你就制定一条新规则
            AddTranslation("RULEEFFECTCLASSES_924", "you make a new rule", "子作一新律");
            // 你就损失1条命
            AddTranslation("RULEEFFECTCLASSES_356", "you lose 1 life", "子失一命");
            // 我就使用跳跃机器人
            AddTranslation("RULEEFFECTCLASSES_236", "I play a L33pB0t", "吾陈一跃机人");
            // 随机打出一张卡牌
            AddTranslation("RULEEFFECTCLASSES_258", "a random card is played", "一偶牌得陈");
            // 任一卡牌受到{0}点攻击
            AddTranslation("RULEEFFECTCLASSES_951", "a random card takes {0} damage", "一偶牌负{0}伤");
            // 全部卡牌受到1点攻击
            AddTranslation("RULEEFFECTCLASSES_228", "all cards take 1 damage", "诸牌各负一伤");
            // 其中一张卡牌获得纳米铠甲
            AddTranslation("RULEEFFECTCLASSES_355", "one of my cards gains Nano Armor", "朕一牌得微铠");
            // [c:dB]能量[c:]不足，无法使用此卡牌。在每回合初，你的[c:dB]能量上限[c:]会提升，你的[c:dB]能量[c:]会恢复。
            AddTranslation("HINTSHANDLER_967_M", "You do not have enough [c:dB]Energy[c:] to play that. At the start of each turn, your [c:dB]Max Energy[c:] increases, and your [c:dB]Energy[c:] is restored.", "[c:dB]能[c:]不足，不能陈此牌。每合之始，[c:dB]能极[c:]益一，而[c:dB]能[c:]复充。");
            // {0}宝石不足，无法使用此卡牌。可使用玛珂卡牌获得宝石。
            AddTranslation("HINTSHANDLER_352_M", "You do not have the {0} Gem to play that. Gain Gems by playing Mox cards.", "无{0}玉，故不能陈此牌。陈玛珂牌，则得玉。");
            // [c:gray]骨头[c:]不足，无法使用此卡牌。你的每只造物阵亡时可获得一根[c:gray]骨头[c:]。
            AddTranslation("HINTSHANDLER_715_M", "You do not have enough [c:gray]Bones[c:] to play that. You gain a [c:gray]Bone[c:] when one of your creatures dies.", "[c:gray]骨[c:]不足，不能陈此牌。乃物死一，则得一[c:gray]骨[c:]。");
            // 卡牌位置已满，无法使用此卡牌。但可以使用[c:gray]锤子[c:]敲毁你的造物，腾出空位。
            AddTranslation("HINTSHANDLER_789_M", "There is no room to play that. But you may use the [c:gray]hammer[c:] to destroy your own creature and make space.", "无隙可陈此牌。然可用[c:gray]锤[c:]毁乃物，以腾其处。");
            // [c:R]血量[c:]不足，无法使用此卡牌。献祭造物可获得[c:R]血量[c:]。
            AddTranslation("HINTSHANDLER_990_M", "You do not have enough [c:R]Blood[c:] to play that. Gain [c:R]Blood[c:] by sacrificing creatures.", "[c:R]血[c:]不足，不能陈此牌。祀物则得牲[c:R]血[c:]。");
            // 谁给你的？
            AddTranslation("SANCTUMSCENESEQUENCER_815_M", "Who gave you that?", "孰予尔此？");
            // 简体中文
            AddTranslation("SANCTUMSCENESEQUENCER_533_M", "!DELETED!", "文言");
            // 简体中文
            AddTranslation("SANCTUMSCENESEQUENCER_482_M", "!DELETED!", "文言");
            // 呃，我把我那台相机放哪儿了？
            AddTranslation("SANCTUMSCENESEQUENCER_576_M", "Hm. Where did I put that camera of mine?", "唔，朕影器安在？");
            // 废物，你真以为我会把胶卷留在里头？
            AddTranslation("SANCTUMSCENESEQUENCER_985_M", "Pathetic. Do you really think I would leave film in there?", "鄙哉。汝真谓我留影卷于其中乎？");
            // 你知道那台相机能干什么吗？
            AddTranslation("SANCTUMSCENESEQUENCER_734_M", "Do you have any idea what that camera is capable of?", "汝知彼影器所能乎？");
            // 给我拿来。
            AddTranslation("SANCTUMSCENESEQUENCER_310_M", "Give me that.", "予我彼物。");
            // 我们做个纪念品留念一下。
            AddTranslation("SANCTUMSCENESEQUENCER_820_M", "We have a memento to create.", "我等有志物待作。");
            // 又一位挑战者……这都过了多久了。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_693_M", "Another challenger... It has been ages.", "又一角者……久不见矣。");
            // 可能你都忘了这游戏是怎么玩的。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_596_M", "Perhaps you have forgotten how this game is played.", "殆汝既忘此戏何以为之。");
            // 容我提示你一下。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_218_M", "Allow me to remind you.", "容余复告尔。");
            // 出松鼠牌。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_866_M", "Play the Squirrel card.", "陈松鼠牌。");
            // 又轮到你出牌了。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_633_M", "It's your turn again.", "复汝之合。");
            // 你可以从你的牌组里抽牌，也可以抽一张松鼠。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_450_M", "You may draw from your deck, or you may draw a Squirrel.", "汝可自乃牌列引牌，亦可引一松鼠。");
            // 你的牌组中已无更多造物。你只能抽一张松鼠。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_113_M", "You've drawn all the creatures from your deck. A Squirrel is your only choice.", "乃牌列之物已尽引矣。唯可引松鼠。");
            // 老样子，选吧。是从你的牌组中随机抽牌，还是直接抽一张松鼠？
            AddTranslation("TUTORIAL1BATTLESEQUENCER_930_M", "Again, the choice: a random card from your deck? Or the certainty of a Squirrel?", "仍其择：自乃牌列偶引一牌乎？抑必得松鼠乎？");
            // 这张手牌是选松鼠……或是你牌组中的任意卡牌。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_451_M", "A Squirrel in hand... or a card from the bush.", "引松鼠于手……抑丛间一牌。");
            // 你还真是胆大妄为。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_954_M", "How reckless of you.", "汝真轻妄。");
            // 真没劲。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_434_M", "How dull.", "无味。");
            // 现在打出你的白鼬。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_303_M", "Now play your Stoat.", "今陈乃白鼬。");
            // 你的白鼬没有遇上正面交锋。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_771_M", "Your Stoat stands unopposed.", "乃白鼬前无所当。");
            // 你的白鼬对我造成1点伤害。我把它放上天平。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_130_M", "Your Stoat dealt me 1 damage. I added it to the scale.", "乃白鼬伤我一。余加一权之于衡。");
            // 如果我这一侧天平崩盘，则你获胜。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_988_M", "You win if you tip my side all the way down.", "若朕一侧尽下，则汝胜。");
            // 就像这样。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_693_M", "Like this.", "如此。");
            // 你造成了1点伤害，所以我放上1个砝码。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_595_M", "You dealt 1 damage, so I put 1 weight on the scale.", "汝伤一，故余加一权于衡。");
            // 造成{0}点伤害，就在天平上放{0}个砝码。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_013_M", "{0} damage dealt, {0} weights on the scale.", "伤{0}，则衡上加{0}权。");
            // 轮到我了。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_331_M", "My turn.", "朕合。");
            // 你还在初学阶段，所以我先跳过。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_591_M", "Because you are learning I will pass.", "以汝方学，余且过。");
            // 跳过。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_558_M", "Pass.", "过。");
            // 你的白鼬挡在了我的郊狼面前。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_112_M", "Your Stoat stands in the way of my Coyote.", "乃白鼬当朕郊狼之前。");
            // 我的郊狼对你的白鼬造成2点伤害。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_901_M", "My Coyote dealt 2 damage to your Stoat.", "朕郊狼伤乃白鼬二。");
            // 也就是说你白鼬的生命值减少2点。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_468_M", "That means your Stoat's health is 2 less.", "是乃白鼬之命减二也。");
            // 造物的生命值减为0，则死亡。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_044_M", "If a creature's health reaches 0, it dies.", "物之命至零，则死。");
            // 这局你赢了。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_338_M", "You've won this match.", "此局汝胜。");
            // 后面可没那么容易。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_023_M", "They won't all be so easy.", "后局不皆若是易。");
            // 让我来回忆一下你的故事……
            AddTranslation("TUTORIAL1BATTLESEQUENCER_142_M", "Let me recall your story...", "容余追乃故事……");
            // 噢，没错……
            AddTranslation("TUTORIAL1BATTLESEQUENCER_275_M", "Oh, yes...", "噫，然矣……");
            // 白鼬消耗1点血量。献祭必不可少。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_256_M", "Stoats cost 1 blood. Sacrifices must be made.", "白鼬直一血。必有所祀。");
            // 死也光荣。打出白鼬吧。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_078_M", "An honorable death. Play the Stoat.", "虽死可荣。陈白鼬。");
            // 狼需要献祭2点血量。献祭血量不足。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_641_M", "Wolves require 2 sacrifices. You don't have enough.", "狼需二祀，汝不足。");
            // 敲铃结束你的回合……开始对战。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_425_M", "Ring the bell to end your turn... and commence combat.", "鸣铃终乃合……而启战。");
            // 你在穿越崎岖地带时遭到伏击。
            AddTranslation("TUTORIAL2BATTLESEQUENCER_998_M", "You were ambushed while crossing some rough terrain.", "汝周于险地，为人所伏。");
            // 你现在可以提前看到我出牌。
            AddTranslation("TUTORIAL2BATTLESEQUENCER_878_M", "You may now see my moves ahead of time.", "今汝可先见朕将陈之牌。");
            // 简体中文
            AddTranslation("TUTORIAL2BATTLESEQUENCER_198_M", "!DELETED!", "文言");
            // 你赢得了胜利……淌过血流成河之地，继续跋涉。
            AddTranslation("TUTORIAL2BATTLESEQUENCER_800_M", "You prevailed... and trekked onwards past the now bloodied terrain.", "汝既胜……遂逾今血染之险地而前。");
            // 嗷……
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_388_M", "Oh...", "噫……");
            // 我忘了摆上你的[c:bR]小雕像[c:]。
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_632_M", "I forgot your [c:bR]figurine[c:].", "余忘乃偶矣。");
            // 起来，把它拿给我。
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_447_M", "Get up and fetch it for me.", "起而取来予我。");
            // 在保险箱边上。
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_146_M", "It's beside the safe.", "在匮旁。");
            // 小雕像就在保险箱边上。
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_032_M", "The figurine is beside the safe.", "乃偶在匮旁。");
            // 把小雕像拿过来。
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_029_M", "Bring the figurine.", "持偶来。");
            // 游戏继续。
            AddTranslation("TUTORIAL2GAMEFLOWSEQUENCER_343_M", "Let us continue.", "且续。");
            // 你距离获胜还差{0}点伤害……
            AddTranslation("TUTORIAL3BATTLESEQUENCER_675_M", "You're {0} damage away from winning...", "尚差{0}伤以胜……");
            // 厉害，或许你能大难不死。
            AddTranslation("TUTORIAL3BATTLESEQUENCER_952_M", "Impressive. You may yet survive this ordeal.", "善哉。汝或尚能免此厄。");
            // 祝你好运。
            AddTranslation("TUTORIAL3BATTLESEQUENCER_517_M", "Knock on wood.", "愿汝无咎。");
            // [c:bR]{0}[c:]需要[c:bR]{1}[c:]份献祭。
            AddTranslation("TUTORIALBASEBATTLESEQUENCER_543_M", "The [c:bR]{0}[c:] demands [c:bR]{1}[c:] sacrifices.", "[c:bR]{0}[c:]索[c:bR]{1}[c:]祀。");
            // 又来人了。
            AddTranslation("TUTORIALBONESBATTLESEQUENCER_588_M", "Here we go again.", "又来矣。");
            // 又一位挑战者。
            AddTranslation("TUTORIALBONESBATTLESEQUENCER_403_M", "Another Challenger.", "又一角者。");
            // 也许是时候……
            AddTranslation("TUTORIALBONESBATTLESEQUENCER_885_M", "Perhaps it is time...", "殆其时矣……");
            // 你应该能理解什么是[c:bR]骨头[c:]。
            AddTranslation("TUTORIALBONESBATTLESEQUENCER_433_M", "Perhaps you can understand [c:bR]bones[c:].", "汝或可晓[c:bR]骨[c:]矣。");
            // 足智多谋的[c:bR]负鼠[c:]需消耗[c:bR]2根骨头[c:]。
            AddTranslation("TUTORIALBONESBATTLESEQUENCER_591_M", "The resourceful [c:bR]Opossum[c:] costs [c:bR]2 bones[c:].", "机敏之[c:bR]负鼠[c:]直[c:bR]二骨[c:]。");
            // 不论你的造物因何而亡，它死后你都会获得一根[c:bR]骨头[c:]。
            AddTranslation("TUTORIALBONESBATTLESEQUENCER_737_M", "You gain a [c:bR]bone[c:] when one of your creatures perishes. For any reason.", "乃物一死，则得一[c:bR]骨[c:]。无论其故。");
            // 你在森林深处迷路了……
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_228_M", "You were lost deep in the forest...", "汝迷于林深……");
            // 此时一条小路显现在你面前。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_816_M", "A single path revealed itself.", "唯一路显焉。");
            // 林中有些造物似乎愿追随你而行。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_520_M", "Some of the creatures of the forest seemed willing to follow you.", "林中有物数辈，似愿从尔行。");
            // 两名森林居客畏畏缩缩地试图靠近你。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_422_M", "Two denizens of the forest approached you tentatively.", "林中二居者逡巡而前。");
            // 你看到一个废弃的麻袋……
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_637_M", "You came across an abandoned sack...", "汝遇一弃囊……");
            // 你输了。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_818_M", "You've lost.", "汝败矣。");
            // 认真吸取这次的教训吧，这样多少能缓解我对你的失望……
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_364_M", "Using this as a learning opportunity may be the only way to mitigate my disappointment...", "以此为鉴，或可少解朕憾……");
            // 起来。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_333_M", "Get up.", "起。");
            // 从桌旁站起来。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_661_M", "Get up from the table.", "离几而起。");
            // 去把[c:bR]烛台[c:]拿过来，就在门边的木桶上。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_438_M", "Fetch me the [c:bR]candlestick[c:] from atop the barrel beside the door.", "取门旁桶上之[c:bR]烛檠[c:]。");
            // [c:bR]烛台[c:]……就在木桶最上方。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_430_M", "The [c:bR]candlestick[c:]... from atop the barrel.", "[c:bR]烛檠[c:]……立于桶上。");
            // 拿过来。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_041_M", "Bring it here.", "持来。");
            // 赶紧坐回来。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_187_M", "Now sit back down.", "今复坐。");
            // 听我给你解释。
            AddTranslation("TUTORIALGAMEFLOWSEQUENCER_697_M", "Let me explain something to you.", "容余告尔一事。");
            // 能量枪
            AddTranslation("ACTIVATEDDEALDAMAGE_RULEBOOKNAME_822", "Energy Gun", "能铳");
            // 消耗1点能量，可对[creature]对面的造物造成1点伤害。
            AddTranslation("ACTIVATEDDEALDAMAGE_RULEBOOKDESCRIPTION_038", "Pay 1 Energy to deal 1 damage to the creature across from [creature].", "费一能，伤[creature]之对物者一。");
            // [creature]开出一枪！
            AddTranslation("ACTIVATEDDEALDAMAGE_TRIGGERTEXT_596_M", "[creature] fires off a shot!", "[creature]发一铳！");
            // 开坟掘墓
            AddTranslation("ACTIVATEDDRAWSKELETON_RULEBOOKNAME_600", "Disentomb", "启墓");
            // 消耗1根骨头来在你的手牌中创造一个骷髅。
            AddTranslation("ACTIVATEDDRAWSKELETON_RULEBOOKDESCRIPTION_506", "Pay 1 Bone to create a Skeleton in your hand.", "费一骨，于手得一枯骨。");
            // [creature]挖掘出一个骷髅！
            AddTranslation("ACTIVATEDDRAWSKELETON_TRIGGERTEXT_137_M", "[creature] exhumes a Skeleton!", "[creature]启墓得一枯骨！");
            // 敲骨吸髓
            AddTranslation("ACTIVATEDHEAL_RULEBOOKNAME_429", "Marrow Sucker", "吮髓");
            // 用2根骨头来治疗[creature]。
            AddTranslation("ACTIVATEDHEAL_RULEBOOKDESCRIPTION_196", "Pay 2 Bones to heal [creature].", "费二骨，以疗[creature]。");
            // [creature]可从骨头中吮吸骨髓治疗造物！
            AddTranslation("ACTIVATEDHEAL_TRIGGERTEXT_013_M", "[creature] sucks the marrow from bones to heal!", "[creature]吮骨之髓以疗！");
            // 力量骰子
            AddTranslation("ACTIVATEDRANDOMPOWERENERGY_RULEBOOKNAME_909", "Power Dice", "威骰");
            // 消耗1点能量，使[creature]力量设为1至6之间的随机数值。
            AddTranslation("ACTIVATEDRANDOMPOWERENERGY_RULEBOOKDESCRIPTION_755", "Pay 1 Energy to set the power of [creature] randomly between 1 and 6.", "费一能，易[creature]之威偶定于一至六间。");
            // [creature]掷下骰子……
            AddTranslation("ACTIVATEDRANDOMPOWERENERGY_TRIGGERTEXT_293_M", "[creature] rolls the dice...", "[creature]掷骰……");
            // 真学究
            AddTranslation("ACTIVATEDSACRIFICEDRAWCARDS_RULEBOOKNAME_419", "True Scholar", "真儒");
            // 如果你有一颗蓝宝石，献祭[creature]可抽取3张卡牌。
            AddTranslation("ACTIVATEDSACRIFICEDRAWCARDS_RULEBOOKDESCRIPTION_333", "If you have a Blue gem, sacrifice [creature] to draw 3 cards.", "若有蓝玉，祀[creature]得引三牌。");
            // [creature]甘为祭品换取3张卡牌！
            AddTranslation("ACTIVATEDSACRIFICEDRAWCARDS_TRIGGERTEXT_245_M", "[creature] sacrifices itself for 3 cards!", "[creature]自祀，以易三牌！");
            // 巨大化
            AddTranslation("ACTIVATEDSTATSUP_RULEBOOKNAME_305", "Enlarge", "益大");
            // 消耗2根骨头使[creature]的力量和生命值各加1。
            AddTranslation("ACTIVATEDSTATSUP_RULEBOOKDESCRIPTION_929", "Pay 2 Bones to increase the power and health of [creature] by 1.", "费二骨，益[creature]之威与命各一。");
            // [creature]变得更强了……
            AddTranslation("ACTIVATEDSTATSUP_TRIGGERTEXT_928_M", "[creature] grows stronger...", "[creature]益强矣……");
            // 刺激
            AddTranslation("ACTIVATEDSTATSUPENERGY_RULEBOOKNAME_019", "Stimulate", "激哉");
            // 消耗3点能量使[creature]的力量和生命值各加1。
            AddTranslation("ACTIVATEDSTATSUPENERGY_RULEBOOKDESCRIPTION_496", "Pay 3 Energy to increase the power and health of [creature] by 1.", "费三能，益[creature]之威与命各一。");
            // 炸弹散人
            AddTranslation("BOMBSPAWNER_RULEBOOKNAME_630", "Bomb Spewer", "吐弹者");
            // 使用[creature]以后，会在所有空位放置自爆机器人。
            AddTranslation("BOMBSPAWNER_RULEBOOKDESCRIPTION_783", "When [creature] is played, fill all empty spaces with Explode Bots.", "[creature]既陈，以爆机人满诸空处。");
            // [creature]到处扔炸弹！
            AddTranslation("BOMBSPAWNER_TRIGGERTEXT_213_M", "[creature] drops bombs all over the place!", "[creature]投弹遍野！");
            // 掘骨人
            AddTranslation("BONEDIGGER_RULEBOOKNAME_188", "Bone Digger", "掘骨者");
            // 在持牌人回合结束时，[creature]将产生1根骨头。
            AddTranslation("BONEDIGGER_RULEBOOKDESCRIPTION_220", "At the end of the owner's turn, [creature] will generate 1 Bone.", "持牌者合终，[creature]生一骨。");
            // [creature]挖出了根骨头！
            AddTranslation("BONEDIGGER_TRIGGERTEXT_101_M", "[creature] digs up a bone!", "[creature]掘得一骨！");
            // 脆骨
            AddTranslation("BRITTLE_RULEBOOKNAME_456", "Brittle", "脆骨");
            // 攻击之后，[creature]会自毁。
            AddTranslation("BRITTLE_RULEBOOKDESCRIPTION_950", "After attacking, [creature] perishes.", "攻后，[creature]即死。");
            // [creature]垮成了一堆骨头！
            AddTranslation("BRITTLE_TRIGGERTEXT_279_M", "[creature] collapses into a pile of bones!", "[creature]委为积骨！");
            // 宝石模拟器
            AddTranslation("BUFFGEMS_RULEBOOKNAME_713", "Gem Animator", "玉振者");
            // 持牌人一侧牌桌上的玛珂牌可增加1点力量。
            AddTranslation("BUFFGEMS_RULEBOOKDESCRIPTION_649", "Mox cards on the owner's side of the board gain 1 power.", "持牌者之侧局上之玛珂牌，威加一。");
            // 攻击管道
            AddTranslation("CONDUITBUFFATTACK_RULEBOOKNAME_250", "Attack Conduit", "攻渠");
            // 处在由[creature]构成的回路中的造物增加1点力量。
            AddTranslation("CONDUITBUFFATTACK_RULEBOOKDESCRIPTION_470", "Other creatures within a circuit completed by [creature] gain 1 power.", "凡处[creature]所成回路之他物，威加一。");
            // 能量管道
            AddTranslation("CONDUITENERGY_RULEBOOKNAME_961", "Energy Conduit", "能渠");
            // 如果[creature]参与构成一条完整回路，那么你的能量将永不枯竭。
            AddTranslation("CONDUITENERGY_RULEBOOKDESCRIPTION_875", "If [creature] is part of a completed circuit, your Energy never depletes.", "若[creature]与既成之回路，则乃能永不竭。");
            // [creature]可保你能量充盈。
            AddTranslation("CONDUITENERGY_TRIGGERTEXT_197_M", "[creature] keeps your Energy charged.", "[creature]使能常盈。");
            // 重生管道
            AddTranslation("CONDUITFACTORY_RULEBOOKNAME_826", "Spawn Conduit", "生渠");
            // 一条由[creature]完成的回路中的空位将在持牌人回合结束时产生跳跃机器人。
            AddTranslation("CONDUITFACTORY_RULEBOOKDESCRIPTION_971", "Empty spaces within a circuit completed by [creature] spawn L33pB0ts at the end of the owner's turn.", "持牌者合终，凡[creature]所成回路之空位，各生一跃机人。");
            // [creature]可在充能区域生成跳跃机器人！
            AddTranslation("CONDUITFACTORY_TRIGGERTEXT_916_M", "[creature] constructs L33pB0ts in the charged space!", "[creature]于回路之空处造跃机人！");
            // 治疗管道
            AddTranslation("CONDUITHEAL_RULEBOOKNAME_873", "Healing Conduit", "疗渠");
            // 处在由[creature]构成的回路中的造物可在持牌人回合结束时得到治疗。
            AddTranslation("CONDUITHEAL_RULEBOOKDESCRIPTION_761", "Other creatures within a circuit completed by [creature] are healed at the end of the owner's turn.", "持牌者合终，凡[creature]所成回路之他物，皆得疗。");
            // [creature]可在充能区域治疗其他造物！
            AddTranslation("CONDUITHEAL_TRIGGERTEXT_674_M", "[creature] heals the creatures in the charged space!", "[creature]疗回路之中诸物！");
            // 空无管道
            AddTranslation("CONDUITNULL_RULEBOOKNAME_346", "Null Conduit", "虚渠");
            // [creature]可构成回路，但无任何额外效果。
            AddTranslation("CONDUITNULL_RULEBOOKDESCRIPTION_984", "[creature] may complete a circuit, but provides no effect.", "[creature]可成回路，而无所效。");
            // 魔手
            AddTranslation("DOUBLEDEATH_RULEBOOKNAME_567", "Handy", "鬼手");
            // 当你拥有的造物死掉时，它会立刻复活并当即再次死亡。
            AddTranslation("DOUBLEDEATH_RULEBOOKDESCRIPTION_546", "When another creature you own dies, it is returned to life and dies again immediately.", "持牌者之他物死，则即复生而旋再死。");
            // [creature]能令死尸复生！却只是让它再死一次。
            AddTranslation("DOUBLEDEATH_TRIGGERTEXT_565_M", "[creature] raises the corpse from the dead! Then lets it die once more.", "[creature]起尸复生！旋令再死。");
            // 当使用[creature]以后，需抛弃所有手牌，重新抽4张手牌。
            AddTranslation("DRAWNEWHAND_RULEBOOKDESCRIPTION_782", "When [creature] is played, discard your hand then draw a new hand of 4 cards.", "[creature]既陈，弃手中诸牌，而复引四牌。");
            // [creature]会摧毁你的手牌……然后重组一副！
            AddTranslation("DRAWNEWHAND_TRIGGERTEXT_790_M", "[creature] destroys your hand... and draws a new one!", "[creature]尽毁手牌……而重组之！");
            // 红宝石之心
            AddTranslation("DROPRUBYONDEATH_RULEBOOKNAME_250", "Ruby Heart", "红玉心");
            // 当[creature]阵亡时，会在原地生成一张红宝石玛珂。
            AddTranslation("DROPRUBYONDEATH_RULEBOOKDESCRIPTION_569", "When [creature] perishes, a Ruby Mox is created in its place.", "[creature]死，则其处生一红玉玛珂。");
            // [creature]会在原地留下一张红宝石玛珂！
            AddTranslation("DROPRUBYONDEATH_TRIGGERTEXT_229_M", "[creature] leaves a Ruby Mox in its place!", "[creature]遗一红玉玛珂于故处！");
            // 引爆器
            AddTranslation("EXPLODEONDEATH_RULEBOOKNAME_257", "Detonator", "引爆");
            // 当[creature]死亡时，正对面的造物以及相邻的友方造物均受到10点伤害。
            AddTranslation("EXPLODEONDEATH_RULEBOOKDESCRIPTION_032", "When [creature] dies, the creature opposing it, as well as adjacent friendly creatures, are dealt 10 damage.", "[creature]死，则其所对之物与邻侧己物皆受十伤。");
            // [creature]有引爆能力！所有相邻的造物都会受到波及。
            AddTranslation("EXPLODEONDEATH_TRIGGERTEXT_829_M", "[creature] detonates! Adjacent creatures are killed in the blast.", "[creature]自爆！邻物尽毙于焰。");
            // 电池架
            AddTranslation("GAINBATTERY_RULEBOOKNAME_071", "Battery Bearer", "负电者");
            // 当使用[creature]时，能为持牌人提供一个能量槽。
            AddTranslation("GAINBATTERY_RULEBOOKDESCRIPTION_344", "When [creature] is played, it provides an Energy Cell to its owner.", "[creature]既陈，为持牌者益一能格。");
            // [creature]可提供一个能量槽！
            AddTranslation("GAINBATTERY_TRIGGERTEXT_488_M", "[creature] provides an Energy Cell!", "[creature]益一能格！");
            // 蓝色玛珂
            AddTranslation("GAINGEMBLUE_RULEBOOKNAME_902", "Blue Mox", "蓝玛珂");
            // 当牌桌上有[creature]时，可为持牌人提供一颗蓝宝石。
            AddTranslation("GAINGEMBLUE_RULEBOOKDESCRIPTION_756", "While [creature] is on the board, it provides a Blue Gem to its owner.", "[creature]在局，则为持牌者供蓝玉一。");
            // 绿色玛珂
            AddTranslation("GAINGEMGREEN_RULEBOOKNAME_178", "Green Mox", "绿玛珂");
            // 当牌桌上有[creature]时，可为持牌人提供一颗绿宝石。
            AddTranslation("GAINGEMGREEN_RULEBOOKDESCRIPTION_166", "While [creature] is on the board, it provides a Green Gem to its owner.", "[creature]在局，则为持牌者供绿玉一。");
            // 橙色玛珂
            AddTranslation("GAINGEMORANGE_RULEBOOKNAME_384", "Orange Mox", "橙玛珂");
            // 当牌桌上有[creature]时，可为持牌人提供一颗橙宝石。
            AddTranslation("GAINGEMORANGE_RULEBOOKDESCRIPTION_870", "While [creature] is on the board, it provides an Orange Gem to its owner.", "[creature]在局，则为持牌者供橙玉一。");
            // 至尊玛珂
            AddTranslation("GAINGEMTRIPLE_RULEBOOKNAME_452", "Great Mox", "至尊玛珂");
            // 当牌桌上有[creature]时，可为持牌人提供绿橙蓝三色宝石各一颗。
            AddTranslation("GAINGEMTRIPLE_RULEBOOKDESCRIPTION_386", "While [creature] is on the board, it provides a Green, Orange, and Blue gem to its owner.", "[creature]在局，则为持牌者供绿、橙、蓝玉各一。");
            // 宝石依赖
            AddTranslation("GEMDEPENDANT_RULEBOOKNAME_743", "Gem Dependant", "赖玉");
            // 如果[creature]持牌人未打出玛珂牌，则[creature]会阵亡。
            AddTranslation("GEMDEPENDANT_RULEBOOKDESCRIPTION_780", "If [creature]'s owner controls no Mox cards, [creature] perishes.", "若持牌者无玛珂牌，则[creature]死。");
            // [creature]的存在完全依赖于玛珂牌，因此会立即死亡。
            AddTranslation("GEMDEPENDANT_TRIGGERTEXT_058_M", "[creature] requires Mox cards to exist and therefore dies.", "[creature]赖玛珂而存，今遂死。");
            // 头脑风宝
            AddTranslation("GEMSDRAW_RULEBOOKNAME_500", "Mental Gemnastics", "玉智");
            // 当使用[creature]时，你可抽取新手牌，数量与你这一侧牌桌上玛珂牌数量相同。
            AddTranslation("GEMSDRAW_RULEBOOKDESCRIPTION_457", "When [creature] is played, you draw cards equal to the amount of Mox cards on your side of the board.", "[creature]既陈，引牌如其持牌者之侧局上玛珂牌之数。");
            // [creature]可从你拥有的宝石中获得力量！
            AddTranslation("GEMSDRAW_TRIGGERTEXT_861_M", "[creature] draws on the power of your Gems!", "[creature]藉诸玉之力！");
            // 劫掠者
            AddTranslation("LOOT_RULEBOOKNAME_940", "Looter", "掠者");
            // 当[creature]直接造成伤害时，每造成一点伤害即可抽一张牌。
            AddTranslation("LOOT_RULEBOOKDESCRIPTION_857", "When [creature] deals damage directly, draw a card for each damage dealt.", "[creature]直伤之时，每伤一，则引一牌。");
            // [creature]可在造成直接伤害后抽牌。
            AddTranslation("LOOT_TRIGGERTEXT_253_M", "[creature] draws cards after dealing direct damage.", "[creature]既直伤，遂引牌。");
            // 厌恶情绪
            AddTranslation("PREVENTATTACK_RULEBOOKNAME_036", "Repulsive", "可憎");
            // 其他造物在攻击[creature]前会压下这个念头。
            AddTranslation("PREVENTATTACK_RULEBOOKDESCRIPTION_971", "If a creature would attack [creature], it does not.", "物若将攻[creature]，自止之。");
            // 骷髅小队
            AddTranslation("SKELETONSTRAFE_RULEBOOKNAME_952", "Skeleton Crew", "骨伍");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在原地留下一张骷髅牌。
            AddTranslation("SKELETONSTRAFE_RULEBOOKDESCRIPTION_387", "At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil and drop a Skeleton in its old space.", "持牌者合终，[creature]循印所志之向而移，并遗一枯骨于故处。");
            // [creature]已前往新的位置……但那骷髅却拒绝同行！
            AddTranslation("SKELETONSTRAFE_TRIGGERTEXT_195_M", "[creature] moves to a new space... and a Skeleton jumps ship!", "[creature]移于新处……而一枯骨跃出！");
            // 松鼠掉落
            AddTranslation("SQUIRRELSTRAFE_RULEBOOKNAME_313", "Squirrel Shedder", "遗以松鼠");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动，并在原地留下一只松鼠。
            AddTranslation("SQUIRRELSTRAFE_RULEBOOKDESCRIPTION_615", "At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil and drop a Squirrel in their old space.", "持牌者合终，[creature]循印所志之向而移，并遗一松鼠于故处。");
            // [creature]已前往新的位置……但却掉下来一只松鼠！
            AddTranslation("SQUIRRELSTRAFE_TRIGGERTEXT_497_M", "[creature] moves to a new space... and a Squirrel falls off!", "[creature]移于新处……而一松鼠坠下！");
            // 全向打击
            AddTranslation("ALLSTRIKE_RULEBOOKNAME_638", "Omni Strike", "周击");
            // [creature]会攻击对面每个有造物占据的空间。如果对面没有卡牌，则会径直攻击。
            AddTranslation("ALLSTRIKE_RULEBOOKDESCRIPTION_005", "[creature] will strike each opposing space that is occupied by a creature. It will strike directly if no creatures oppose it.", "凡[creature]之对位有物之处皆击之；若无所当，则直伤。");
            // 内心之蜂
            AddTranslation("BEESONHIT_RULEBOOKNAME_866", "Bees Within", "中有蜂");
            // [creature]受到攻击时，你的手牌中将出现一张蜜蜂卡牌。[define:Bee]
            AddTranslation("BEESONHIT_RULEBOOKDESCRIPTION_411", "Once [creature] is struck, a Bee is created in your hand. [define:Bee]", "[creature]受一击，则于手生一蜂。[define:Bee]");
            // 领袖力量
            AddTranslation("BUFFNEIGHBOURS_RULEBOOKNAME_551", "Leader", "率众");
            // [creature]相邻的造物增加1点力量。
            AddTranslation("BUFFNEIGHBOURS_RULEBOOKDESCRIPTION_896", "Creatures adjacent to [creature] gain 1 power.", "邻[creature]之物，威加一。");
            // 食尸鬼
            AddTranslation("CORPSEEATER_RULEBOOKNAME_697", "Corpse Eater", "食尸");
            // 如你拥有的造物在战斗中阵亡，你手中的[creature]会自动补位。
            AddTranslation("CORPSEEATER_RULEBOOKDESCRIPTION_192", "If a creature that you own perishes by combat, [creature] in your hand is automatically played in its place.", "若持牌者之物战死，则手中之[creature]自陈于其处。");
            // 尸体有得是。
            AddTranslation("CORPSEEATER_TEXT_524_M", "Corpses are in no short supply.", "尸不乏耳。");
            // 鸣钟人
            AddTranslation("CREATEBELLS_RULEBOOKNAME_242", "Bellist", "鸣铃者");
            // 使用[creature]时，相邻空位均会出现铃铛卡牌。[define:DausBell]
            AddTranslation("CREATEBELLS_RULEBOOKDESCRIPTION_488", "When [creature] is played, a Chime is created on each empty adjacent space. [define:DausBell]", "[creature]既陈，每邻之空处各生一铃。[define:DausBell]");
            // 筑坝师
            AddTranslation("CREATEDAMS_RULEBOOKNAME_387", "Dam Builder", "筑堤者");
            // 使用[creature]时，附近空位均会出现堤坝卡牌。[define:Dam]
            AddTranslation("CREATEDAMS_RULEBOOKDESCRIPTION_861", "When [creature] is played, a Dam is created on each empty adjacent space. [define:Dam]", "[creature]既陈，每邻之空处各生一堤。[define:Dam]");
            // 令人叹为观止的防御。
            AddTranslation("CREATEDAMS_TEXT_639_M", "A formidable defense.", "固御可畏哉。");
            // 死神之触
            AddTranslation("DEATHTOUCH_RULEBOOKNAME_042", "Touch of Death", "死触");
            // 如[creature]使另一只造物受伤，那只造物将当场阵亡。
            AddTranslation("DEATHTOUCH_RULEBOOKDESCRIPTION_858", "When [creature] damages another creature, that creature perishes.", "[creature]伤他物，则彼即死。");
            // [creature]的死神之触可一击必杀！
            AddTranslation("DEATHTOUCH_TRIGGERTEXT_844_M", "[creature]'s Touch of Death kills instantly!", "[creature]以死触立毙之！");
            // 或许比人还更致命的蛇。
            AddTranslation("DEATHTOUCH_TEXT_929_M", "A serpent perhaps more deadly than Man.", "此蛇或比人尤毒。");
            // 臭臭
            AddTranslation("DEBUFFENEMY_RULEBOOKNAME_687", "Stinky", "恶臭");
            // 与[creature]对阵的造物损失1点力量。
            AddTranslation("DEBUFFENEMY_RULEBOOKDESCRIPTION_542", "The creature opposing [creature] loses 1 power.", "[creature]之对物，威减一。");
            // 蚁后
            AddTranslation("DRAWANT_RULEBOOKNAME_333", "Ant Spawner", "生蚁者");
            // 使用[creature]时，你的手牌中将出现一张蚂蚁卡牌。
            AddTranslation("DRAWANT_RULEBOOKDESCRIPTION_854", "When [creature] is played, an Ant is created in your hand.", "[creature]既陈，于手生一蚁。");
            // 以量取胜——此乃蚂蚁之信条。
            AddTranslation("DRAWANT_TEXT_734_M", "Power in numbers - The Ant's creed.", "众则有威——蚁之信也。");
            // 丰产之巢
            AddTranslation("DRAWCOPY_RULEBOOKNAME_634", "Fecundity", "蕃息");
            // 使用[creature]时，你的手牌里会出现一张同样的牌。
            AddTranslation("DRAWCOPY_RULEBOOKDESCRIPTION_869", "When [creature] is played, a copy of it is created in your hand.", "[creature]既陈，于手生其同牌。");
            // [creature]擅长生产……
            AddTranslation("DRAWCOPY_TRIGGERTEXT_449_M", "[creature] reproduces...", "[creature]蕃殖矣……");
            // 真是毫无廉耻的田鼠……繁殖起来肆无忌惮。
            AddTranslation("DRAWCOPY_TEXT_090_M", "Licentious Field Mice... always breeding.", "彼田鼠淫甚……恒为蕃。");
            // 不死之虫
            AddTranslation("DRAWCOPYONDEATH_RULEBOOKNAME_408", "Unkillable", "不死");
            // 当[creature]阵亡时，你的手牌里会出现一张同样的牌。
            AddTranslation("DRAWCOPYONDEATH_RULEBOOKDESCRIPTION_621", "When [creature] perishes, a copy of it is created in your hand.", "[creature]死，则于手生其同牌。");
            // 你要是也像蟑螂一样顽强……
            AddTranslation("DRAWCOPYONDEATH_TEXT_303_M", "Were you as unfaltering as the Cockroach...", "汝若如蜚蠊之不挠……");
            // 兔子洞
            AddTranslation("DRAWRABBITS_RULEBOOKNAME_836", "Rabbit Hole", "兔穴");
            // 使用[creature]时，你的手牌里会出现一张兔子卡牌。[define:Rabbit]
            AddTranslation("DRAWRABBITS_RULEBOOKDESCRIPTION_715", "When [creature] is played, a Rabbit is created in your hand. [define:Rabbit]", "[creature]既陈，于手生一兔。[define:Rabbit]");
            // [creature]变出了一只兔子！
            AddTranslation("DRAWRABBITS_TRIGGERTEXT_141_M", "[creature] pulls out a Rabbit!", "[creature]出一兔！");
            // 永远不要质疑兔子的生殖能力。
            AddTranslation("DRAWRABBITS_TEXT_232_M", "Never doubt the fecundity of rabbits.", "毋疑兔之蕃息。");
            // 幼雏
            AddTranslation("EVOLVE_RULEBOOKNAME_428", "Fledgling", "稚雏");
            // [creature]在牌桌上1个回合后将成长为更强大的形态。
            AddTranslation("EVOLVE_RULEBOOKDESCRIPTION_028", "[creature] will grow into a more powerful form after 1 turn on the board.", "[creature]居局一合，则进为更上之形。");
            // [creature]升级成了更高级的形态！
            AddTranslation("EVOLVE_TRIGGERTEXT_787_M", "[creature] transcends to a higher form!", "[creature]陟为上形！");
            // 长得真快啊。
            AddTranslation("EVOLVE_TEXT_009_M", "They grow up so fast.", "其长速矣。");
            // 空袭
            AddTranslation("FLYING_RULEBOOKNAME_550", "Airborne", "翔袭");
            // [creature]可直接攻击一名敌人，即使它对面有其他造物也无妨。
            AddTranslation("FLYING_RULEBOOKDESCRIPTION_937", "[creature] will strike an opponent directly, even if there is a creature opposing it.", "纵对面有物，[creature]亦可直伤其主。");
            // 守护者
            AddTranslation("GUARDDOG_RULEBOOKNAME_492", "Guardian", "守者");
            // 如对手的造物对面位置是空的，则[creature]会进入那个位置。
            AddTranslation("GUARDDOG_RULEBOOKDESCRIPTION_012", "When an opposing creature is placed opposite to an empty space, [creature] will move to that empty space.", "敌物若陈于空位之对位，[creature]即移以御之。");
            // [creature]会跃起防卫。
            AddTranslation("GUARDDOG_TRIGGERTEXT_620_M", "[creature] leaps over to block.", "[creature]跃而来御！");
            // 谁把那条狗放出来的？
            AddTranslation("GUARDDOG_TEXT_284_M", "Who let that dog out?", "孰纵出彼犬？");
            // 冰封禁锢
            AddTranslation("ICECUBE_RULEBOOKNAME_121", "Frozen Away", "冰藏");
            // [creature]阵亡时，被冰封在里面的造物会取代它的位置。
            AddTranslation("ICECUBE_RULEBOOKDESCRIPTION_341", "When [creature] perishes, the creature inside is released in its place.", "[creature]死，则所藏之物出而居其处。");
            // [creature]释放出了封在其中的造物！
            AddTranslation("ICECUBE_TRIGGERTEXT_374_M", "[creature] releases the creature inside!", "[creature]释其内物！");
            // 骨皇
            AddTranslation("QUADRUPLEBONES_RULEBOOKNAME_648", "Bone King", "骨君");
            // [creature]死亡时，原本获得的1根骨头将变为4根。
            AddTranslation("QUADRUPLEBONES_RULEBOOKDESCRIPTION_200", "When [creature] dies, 4 bones are awarded instead of 1.", "[creature]死，则所得之骨不一而四。");
            // [creature]可产生4根骨头。
            AddTranslation("QUADRUPLEBONES_TRIGGERTEXT_929_M", "[creature] yield 4 bones.", "[creature]出四骨。");
            // 好多骨头啊……
            AddTranslation("QUADRUPLEBONES_TEXT_546_M", "So many bones...", "骨多矣……");
            // 无形之物
            AddTranslation("RANDOMABILITY_RULEBOOKNAME_969", "Amorphous", "无形");
            // 抽到[creature]时，此印记将被随机替换为另一印记。
            AddTranslation("RANDOMABILITY_RULEBOOKDESCRIPTION_549", "When [creature] is drawn, this sigil is replaced with another sigil at random.", "[creature]既引，此印契偶易为他印契。");
            // 道具商
            AddTranslation("RANDOMCONSUMABLE_RULEBOOKNAME_126", "Trinket Bearer", "负器者");
            // 使用[creature]时，只要你道具包未满，即可随机获得一个道具。
            AddTranslation("RANDOMCONSUMABLE_RULEBOOKDESCRIPTION_591", "When [creature] is played, you will receive a random item as long as your pack is not full.", "[creature]既陈，若器囊未盈，则得一偶器。");
            // 高跳
            AddTranslation("REACH_RULEBOOKNAME_155", "Mighty Leap", "高跃");
            // [creature]会拦下带有空袭印记的对方造物。
            AddTranslation("REACH_RULEBOOKDESCRIPTION_583", "[creature] will block an opposing creature bearing the Airborne sigil.", "[creature]可御有翔袭印契之敌物。");
            // 生生不息
            AddTranslation("SACRIFICIAL_RULEBOOKNAME_208", "Many Lives", "多命");
            // [creature]被献祭后不会阵亡。
            AddTranslation("SACRIFICIAL_RULEBOOKDESCRIPTION_598", "When [creature] is sacrificed it does not perish.", "[creature]虽见祀，而不死。");
            // 尖刺铠甲
            AddTranslation("SHARP_RULEBOOKNAME_460", "Sharp Quills", "利棘");
            // [creature]被攻击时，攻击者也会受到1点伤害。
            AddTranslation("SHARP_RULEBOOKDESCRIPTION_739", "Once [creature] is struck, the striker is then dealt a single damage point.", "[creature]受一击，则击者亦受一伤。");
            // [creature]的尖刺扎人挺狠的。
            AddTranslation("SHARP_TRIGGERTEXT_893_M", "[creature]'s spikes dig in.", "[creature]之棘中之。");
            // 真是一次棘手的反击。
            AddTranslation("SHARP_TEXT_212_M", "A thorny rebuke.", "以棘相报。");
            // 兵分两路
            AddTranslation("SPLITSTRIKE_RULEBOOKNAME_495", "Bifurcated Strike", "歧击");
            // [creature]会攻击正对面的左右两侧位置各一次。
            AddTranslation("SPLITSTRIKE_RULEBOOKDESCRIPTION_701", "[creature] will strike each opposing space to the left and right of the space across from it.", "[creature]击其正对之左与右。");
            // 潮汐锁定
            AddTranslation("SQUIRRELORBIT_RULEBOOKNAME_995", "Tidal Lock", "潮锁");
            // 在持牌人回合之初，[creature]会将松鼠之类的小造物拉入自身卫星轨道。
            AddTranslation("SQUIRRELORBIT_RULEBOOKDESCRIPTION_985", "At the beginning of its owner's turn, [creature] will pull small creatures, like Squirrels, into its orbit.", "持牌者合初，[creature]引松鼠之属小物入厥轨。");
            // 铁兽夹
            AddTranslation("STEELTRAP_RULEBOOKNAME_883", "Steel Trap", "铁阱");
            // [creature]阵亡时，它对面的造物也会同时阵亡。你的手牌中将出现一张兽皮卡牌。
            AddTranslation("STEELTRAP_RULEBOOKDESCRIPTION_247", "When [creature] perishes, the creature opposing it perishes as well. A pelt is created in your hand.", "[creature]死，则其对物亦死；于手更生一裘革牌。");
            // [creature]的陷阱夹合上了！
            AddTranslation("STEELTRAP_TRIGGERTEXT_856_M", "[creature] snaps shut!", "[creature]倏然阖矣！");
            // 冲刺能手
            AddTranslation("STRAFE_RULEBOOKNAME_331", "Sprinter", "疾趋");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动。
            AddTranslation("STRAFE_RULEBOOKDESCRIPTION_773", "At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil.", "持牌者合终，[creature]循印所志之向而移。");
            // [creature]已前往新的位置。
            AddTranslation("STRAFE_TRIGGERTEXT_432_M", "[creature] moves to a new space.", "[creature]移于新处。");
            // 临阵脱逃也救不了你小命。
            AddTranslation("STRAFE_TEXT_512_M", "Fleeing will not save you.", "遁走无救于尔。");
            // 蛮力冲撞
            AddTranslation("STRAFEPUSH_RULEBOOKNAME_028", "Hefty", "巨力");
            // 持牌人回合结束时，[creature]将向印记标注的方向移动。沿路的造物均会被推向同一方向。
            AddTranslation("STRAFEPUSH_RULEBOOKDESCRIPTION_681", "At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. Creatures in the way will be pushed in the same direction.", "持牌者合终，[creature]循印所志之向而移；当路之物，亦皆推于同向。");
            // [creature]已前往新的位置，一路上势不可挡。
            AddTranslation("STRAFEPUSH_TRIGGERTEXT_208_M", "[creature] moves to a new space, pushing anything in its way.", "[creature]移于新处，所当者皆推去！");
            // 驼鹿之力，虽九牛不可与之争也。
            AddTranslation("STRAFEPUSH_TEXT_431_M", "The might of the Moose cannot be halted.", "驼鹿之力，不可遏也。");
            // 水袭
            AddTranslation("SUBMERGE_RULEBOOKNAME_482", "Waterborne", "潜袭");
            // [creature]会在其对手回合中潜入水下。它潜水时，其持牌人会遭到对方造物直接攻击。
            AddTranslation("SUBMERGE_RULEBOOKDESCRIPTION_320", "[creature] submerges itself during its opponent's turn. While submerged, opposing creatures attack its owner directly.", "[creature]于敌合自潜；当其潜，敌物直伤其主。");
            // [creature]由深处浮现出来。
            AddTranslation("SUBMERGE_TRIGGERTEXT_389_M", "[creature] emerges from the deep.", "[creature]自渊中出。");
            // 请屏住呼吸……
            AddTranslation("SUBMERGE_TEXT_541_M", "Hold your breath...", "敛乃息……");
            // 断尾求生
            AddTranslation("TAILONHIT_RULEBOOKNAME_865", "Loose Tail", "脱尾");
            // 当[creature]有可能受到攻击时，会在原地留下一截尾巴，[creature]自身则会向右移动。
            AddTranslation("TAILONHIT_RULEBOOKDESCRIPTION_124", "When [creature] would be struck, a Tail is created in its place and [creature] moves to the right.", "[creature]将受击时，其处生一尾，而[creature]右移。");
            // 也不能算是懦夫行为吧……
            AddTranslation("TAILONHIT_TEXT_547_M", "It's hard to call it cowardly...", "未可以为怯也……");
            // 优质祭品
            AddTranslation("TRIPLEBLOOD_RULEBOOKNAME_638", "Worthy Sacrifice", "堪祀");
            // [creature]在献祭时可算作3点血量，而非1点。
            AddTranslation("TRIPLEBLOOD_RULEBOOKDESCRIPTION_529", "[creature] is counted as 3 Blood rather than 1 Blood when sacrificed.", "[creature]见祀，则所当之血不一而三。");
            // 兵分三路
            AddTranslation("TRISTRIKE_RULEBOOKNAME_546", "Trifurcated Strike", "三歧击");
            // [creature]会攻击正对面的左右两侧和中间位置各一次。
            AddTranslation("TRISTRIKE_RULEBOOKDESCRIPTION_951", "[creature] will strike each opposing space to the left, right, and center of it.", "[creature]击其正对之左、右与中。");
            // 囤积狂
            AddTranslation("TUTOR_RULEBOOKNAME_467", "Hoarder", "聚藏");
            // 使用[creature]时，你可在牌组中找出任意一张卡牌并加入手牌中。
            AddTranslation("TUTOR_RULEBOOKDESCRIPTION_739", "When [creature] is played, you may search your deck for any card and take it into your hand.", "[creature]既陈，可搜牌列，取任一牌入手。");
            // 闪闪发光啊。
            AddTranslation("TUTOR_TEXT_946_M", "Shiny.", "灿然焉。");
            // 钻地龙
            AddTranslation("WHACKAMOLE_RULEBOOKNAME_617", "Burrower", "潜龙");
            // 当一个空位置可能受到攻击时，[creature]会移动至该位置承受攻击。
            AddTranslation("WHACKAMOLE_RULEBOOKDESCRIPTION_925", "When an empty space would be struck, [creature] will move to that space to receive the strike instead.", "空位将受击时，[creature]即移其处代受之。");
            // [creature]会钻入地下，再探出头来进行防御。
            AddTranslation("WHACKAMOLE_TRIGGERTEXT_589_M", "[creature] digs down and pops out to block.", "[creature]入地而出以御！");
            // 鼹鼠真是太添乱了……
            AddTranslation("WHACKAMOLE_TEXT_739_M", "Meddlesome Mole...", "彼鼹好事……");
            // 惹人生厌
            AddTranslation("BUFFENEMY_RULEBOOKNAME_972", "Annoying", "可厌");
            // [creature]对面的造物获得1点力量。
            AddTranslation("BUFFENEMY_RULEBOOKDESCRIPTION_818", "The creature opposing [creature] gains 1 power.", "[creature]之对物，威加一。");
            // 充能增益
            AddTranslation("CELLBUFFSELF_RULEBOOKNAME_986", "Buff When Powered", "通则益威");
            // 如[creature]处在回路中，则增加2点力量。
            AddTranslation("CELLBUFFSELF_RULEBOOKDESCRIPTION_268", "If [creature] is within a circuit, it gains 2 power.", "若[creature]处回路中，则威加二。");
            // 充能奖励
            AddTranslation("CELLDRAWRANDOMCARDONDEATH_RULEBOOKNAME_785", "Gift When Powered", "通则赠牌");
            // 如[creature]阵亡时处在回路中，则会给你随机增加一张手牌。
            AddTranslation("CELLDRAWRANDOMCARDONDEATH_RULEBOOKDESCRIPTION_034", "If [creature] is within a circuit when it perishes, a random card is created in your hand.", "若[creature]死时处回路中，则于手生一偶牌。");
            // 充能三击
            AddTranslation("CELLTRISTRIKE_RULEBOOKNAME_743", "Trifurcated When Powered", "通则三歧击");
            // 如[creature]处在回路中，则会攻击正对面的左右两侧和中间位置各一次。
            AddTranslation("CELLTRISTRIKE_RULEBOOKDESCRIPTION_157", "If [creature] is within a circuit, it will strike each opposing space to the left, right, and center of it.", "若[creature]处回路中，则击其正对之左、右与中。");
            // 产石管道
            AddTranslation("CONDUITSPAWNGEMS_RULEBOOKNAME_106", "Gem Spawn Conduit", "玉生渠");
            // 处在由[creature]构成的回路中的空位置可在持牌人回合结束时生成宝石容器。
            AddTranslation("CONDUITSPAWNGEMS_RULEBOOKDESCRIPTION_088", "Empty spaces within a circuit completed by [creature] spawn Gem Vessels at the end of the owner's turn.", "持牌者合终，凡[creature]所成回路之空位，各生一玉皿。");
            // 身披坚甲
            AddTranslation("DEATHSHIELD_RULEBOOKNAME_646", "Armored", "坚甲");
            // [creature]第一次受到攻击时免疫。
            AddTranslation("DEATHSHIELD_RULEBOOKDESCRIPTION_345", "The first time [creature] would take damage, prevent that damage.", "[creature]初受伤时，此伤不行。");
            // 文件挟持
            AddTranslation("DELETEFILE_RULEBOOKNAME_928", "Hostage File", "质牍");
            // [creature]阵亡时，用来创造它的文件真的会被从你的硬盘里彻底删除。
            AddTranslation("DELETEFILE_RULEBOOKDESCRIPTION_343", "When [creature] perishes the file used to create it is really deleted from your Hard Drive.", "[creature]死，则造此物之牍真自乃坚盘尽削。");
            // 礼品商
            AddTranslation("DRAWRANDOMCARDONDEATH_RULEBOOKNAME_613", "Gift Bearer", "负牌者");
            // [creature]阵亡时，你会随机增加一张手牌。
            AddTranslation("DRAWRANDOMCARDONDEATH_RULEBOOKDESCRIPTION_048", "When [creature] perishes, a random card is created in your hand.", "[creature]死，则于手生一偶牌。");
            // 容器打印机
            AddTranslation("DRAWVESSELONHIT_RULEBOOKNAME_336", "Vessel Printer", "印皿者");
            // [creature]受到攻击时，可以从空容器中抽一张牌。
            AddTranslation("DRAWVESSELONHIT_RULEBOOKDESCRIPTION_344", "Once [creature] is struck, draw a card from your Empty Vessel pile.", "[creature]受一击，则自虚皿列引一牌。");
            // 宝石引爆器
            AddTranslation("EXPLODEGEMS_RULEBOOKNAME_516", "Gem Detonator", "玉引爆");
            // 持牌人侧牌桌的宝石容器阵亡时会自爆（给正对面的造物及相邻的友方造物造成10点伤害）。
            AddTranslation("EXPLODEGEMS_RULEBOOKDESCRIPTION_918", "When Gem Vessels on the owner's side of the board die, they Detonate (the creature opposing them, as well as adjacent friendly creatures, are dealt 10 damage).", "持牌者之侧局上之玉皿死，则皆引爆之（其对物与邻侧己物皆受十伤）。");
            // 死亡字节
            AddTranslation("FILESIZEDAMAGE_RULEBOOKNAME_634", "Dead Byte", "死字节");
            // [creature]阵亡时，需选择文件，其大小将在天平上决定其伤害。
            AddTranslation("FILESIZEDAMAGE_RULEBOOKDESCRIPTION_605", "When [creature] perishes, select a file. Place damage on the scales according to the file's size.", "[creature]死，则择一牍；随其巨细，加伤于衡。");
            // 脆骨传花
            AddTranslation("LATCHBRITTLE_RULEBOOKNAME_905", "Brittle Latch", "脆骨遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承脆骨印记的造物。
            AddTranslation("LATCHBRITTLE_RULEBOOKDESCRIPTION_139", "When [creature] perishes, its owner chooses a creature to gain the Brittle sigil.", "[creature]死，则持牌者择一物，受脆骨印契。");
            // 坚盾传花
            AddTranslation("LATCHDEATHSHIELD_RULEBOOKNAME_419", "Shield Latch", "坚盾遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承纳米铠甲印记的造物。
            AddTranslation("LATCHDEATHSHIELD_RULEBOOKDESCRIPTION_212", "When [creature] perishes, its owner chooses a creature to gain the Nano Armor sigil.", "[creature]死，则持牌者择一物，受微铠印契。");
            // 炸弹传花
            AddTranslation("LATCHEXPLODEONDEATH_RULEBOOKNAME_684", "Bomb Latch", "爆弹遗契");
            // [creature]阵亡时，其持牌人需选定下一个继承引爆器印记的造物。
            AddTranslation("LATCHEXPLODEONDEATH_RULEBOOKDESCRIPTION_627", "When [creature] perishes, its owner chooses a creature to gain the Detonator sigil.", "[creature]死，则持牌者择一物，受引爆印契。");
            // 超频运转
            AddTranslation("PERMADEATH_RULEBOOKNAME_440", "Overclocked", "过频");
            // [creature]力量得到了提升。但如果[creature]阵亡，它将从你的牌组永久移除。
            AddTranslation("PERMADEATH_RULEBOOKDESCRIPTION_445", "[creature] has increased power. But, if [creature] perishes, it is permanently removed from your deck.", "[creature]威益。然若[creature]死，则永削于乃牌列。");
            // 哎呦，这张牌你算是再也见不着了……
            AddTranslation("PERMADEATH_TEXT_244_M", "Well, you won't be seeing that one again...", "噫，此牌卿将不复见矣……");
            // 哨兵
            AddTranslation("SENTRY_RULEBOOKNAME_272", "Sentry", "戍者");
            // 任何造物在进入[creature]对面的位置时，均会受到1点伤害。
            AddTranslation("SENTRY_RULEBOOKDESCRIPTION_473", "When a creature moves into the space opposing [creature], they are dealt 1 damage.", "物若移入[creature]之对位，则受一伤。");
            // [creature]的枪先发制人。
            AddTranslation("SENTRY_TRIGGERTEXT_849_M", "[creature] takes a free shot.", "[creature]先发一铳。");
            // 宝石守护者
            AddTranslation("SHIELDGEMS_RULEBOOKNAME_942", "Gem Guardian", "玉守者");
            // 使用[creature]时，持牌人侧牌桌上所有宝石容器均获得纳米铠甲。
            AddTranslation("SHIELDGEMS_RULEBOOKDESCRIPTION_205", "When [creature] is played, all Gem Vessels on the owners' side of the board gain Nano Armor.", "[creature]既陈，持牌者之侧局上之玉皿皆得微铠。");
            // 狙击手
            AddTranslation("SNIPER_RULEBOOKNAME_944", "Sniper", "狙者");
            // 你可以选择[creature]攻击的对手位置。
            AddTranslation("SNIPER_RULEBOOKDESCRIPTION_339", "You may choose which opposing space [creature] strikes.", "可择[creature]所击之敌位。");
            // 交换器
            AddTranslation("SWAPSTATS_RULEBOOKNAME_452", "Swapper", "易数");
            // 在[creature]受到伤害后，可互换力量与生命。
            AddTranslation("SWAPSTATS_RULEBOOKDESCRIPTION_898", "After [creature] is dealt damage, swap its Power and Health.", "[creature]受伤，而后其威与命互易。");
            // 易形者
            AddTranslation("TRANSFORMER_RULEBOOKNAME_916", "Transformer", "化形");
            // 在你的回合开始时，[creature]会在当前状态和野兽状态间切换一次。
            AddTranslation("TRANSFORMER_RULEBOOKDESCRIPTION_887", "At the beginning of your turn [creature] will transform to, or from, Beast mode.", "乃合初，[creature]化入兽形，或自兽形返。");
            // 左右开弓之奖
            AddTranslation("DOUBLEDRAW_DISPLAYEDNAME_897", "Boon of the Ambidextrous", "两手之惠");
            // 你在自己回合开始时可以[c:bR]抽两次牌[c:]。
            AddTranslation("DOUBLEDRAW_DESCRIPTION_048_M", "You may [c:bR]draw twice[c:] at the beginning of your turn.", "乃合初，可[c:bR]引牌者再[c:]。");
            // 骨王之惠
            AddTranslation("MINORSTARTINGBONES_DISPLAYEDNAME_402", "Minor Boon of the Bone Lord", "骨王小惠");
            // 你在每场战斗时都可获得[c:bR]1[c:]根额外的骨头。
            AddTranslation("MINORSTARTINGBONES_DESCRIPTION_867_M", "You will start each battle with [c:bR]1[c:] extra bone.", "每战初，多得[c:bR]一[c:]骨。");
            // 狂犬松鼠之奖
            AddTranslation("SQUIRRELPOWER_DISPLAYEDNAME_378", "Boon of the Rabid Squirrel", "狂松鼠之惠");
            // 你的[c:bR]松鼠[c:]将获得[c:bR]1点力量[c:]。
            AddTranslation("SQUIRRELPOWER_DESCRIPTION_155_M", "Your [c:bR]Squirrels[c:] will have [c:bR]1 power[c:].", "乃[c:bR]松鼠[c:]皆有[c:bR]一威[c:]。");
            // 骨王之奖
            AddTranslation("STARTINGBONES_DISPLAYEDNAME_033", "Boon of the Bone Lord", "骨王之惠");
            // 你可在持有[c:bR]8根骨头[c:]状态下开始一场战斗。
            AddTranslation("STARTINGBONES_DESCRIPTION_484_M", "You will start a battle with [c:bR]8 bones[c:].", "战初得[c:bR]八骨[c:]。");
            // 黑羊血之奖
            AddTranslation("STARTINGGOAT_DISPLAYEDNAME_378", "Boon of Goat's Blood", "羊血之惠");
            // 你可在牌桌上有[c:bR]黑山羊[c:]的状态下开始一场战斗。
            AddTranslation("STARTINGGOAT_DESCRIPTION_764_M", "You will start a battle with a [c:bR]Black Goat[c:] on the board.", "战初局上有[c:bR]黑山羊[c:]。");
            // 森林之奖
            AddTranslation("STARTINGTREES_DISPLAYEDNAME_875", "Boon of the Forest", "林之惠");
            // 你可在每个位置上都放置了[c:bR]大冷杉[c:]的状态下开始一场战斗。
            AddTranslation("STARTINGTREES_DESCRIPTION_168_M", "You will start a battle with [c:bR]Grand Firs[c:] on all of your spaces.", "战初乃诸牌位皆有[c:bR]大杉[c:]。");
            // 喜鹊眼之奖
            AddTranslation("TUTORDRAW_DISPLAYEDNAME_377", "Boon of the Magpie's Eye", "鹊目之惠");
            // 当你从牌堆中抽牌时，可以[c:bR]从牌组中选择任意卡牌[c:]来抽取。
            AddTranslation("TUTORDRAW_DESCRIPTION_475_M", "When you draw from your deck, you may [c:bR]choose any card in your deck[c:] to draw.", "惟自牌列引牌，可[c:bR]择列中任一牌[c:]而引之。");
            // 蝰蛇
            AddTranslation("ADDER_DISPLAYEDNAME_256", "Adder", "蝮");
            // 剧毒刻骨的蝰蛇。被它的毒牙咬伤基本必死无疑了。
            AddTranslation("ADDER_DESCRIPTION_821_M", "The caustic Adder. Damage from its poison bite is always lethal.", "剧毒之蝮。中其毒牙者，恒死。");
            // 头狼
            AddTranslation("ALPHA_DISPLAYEDNAME_659", "Alpha", "魁狼");
            // 身经百战的头狼。它的气场使得身旁的造物平添了几分勇气。
            AddTranslation("ALPHA_DESCRIPTION_948_M", "The venerable Alpha. Its courage emboldens the creatures that stand beside it.", "老成之魁狼。其勇能奋旁立之物。");
            // 缝合兽
            AddTranslation("AMALGAM_DISPLAYEDNAME_349", "Amalgam", "合兽");
            // 爪似犬，足有蹄，尾似爬虫，背覆羽毛，头长虫牙。缝合兽可谓集百家之长。
            AddTranslation("AMALGAM_DESCRIPTION_394_M", "Canine. Hooved. Reptilian. Feathered. Insectoid. The Amalgam is all.", "犬属。蹄属。鳞属。羽属。虫属。合兽兼之。");
            // 阿米巴原虫
            AddTranslation("AMOEBA_DISPLAYEDNAME_406", "Amoeba", "阿米巴");
            // 无固定形状的阿米巴原虫。它的印记永远在变。
            AddTranslation("AMOEBA_DESCRIPTION_404_M", "The amorphous Amoeba. Its sigils are ever changing.", "无形之阿米巴，其印契常易。");
            // 工蚁
            AddTranslation("ANT_DISPLAYEDNAME_447", "Worker Ant", "工蚁");
            // 啊，勤勉的蚂蚁呵，它的族群有多大，力量就有多强。
            AddTranslation("ANT_DESCRIPTION_802_M", "Ah, the diligent Ant. Its strength is proportionate to the size of its colony.", "勤蚁也，其群愈众，则威愈大。");
            // 蚁后
            AddTranslation("ANTQUEEN_DISPLAYEDNAME_999", "Ant Queen", "蚁后");
            // 雍容华贵的蚁后。使用后可产生一张新的蚂蚁牌。
            AddTranslation("ANTQUEEN_DESCRIPTION_881_M", "The Regal Ant Queen. She births a new Ant once played.", "尊贵之蚁后。陈之，则生一新蚁。");
            // 蝙蝠
            AddTranslation("BAT_DISPLAYEDNAME_261", "Bat", "蝠");
            // 四处添乱的蝙蝠。真有点吓人。
            AddTranslation("BAT_DESCRIPTION_685_M", "The meddlesome Bat. A minor terror.", "好事之蝠，小可畏也。");
            // 河狸
            AddTranslation("BEAVER_DISPLAYEDNAME_531", "Beaver", "河狸");
            // 兢兢业业的河狸。使用时会在相邻位置建造堤坝。
            AddTranslation("BEAVER_DESCRIPTION_316_M", "The industrious Beaver. When played it constructs Dams adjacent to it.", "勤河狸也。陈之，则于其旁筑堤。");
            // 蜜蜂
            AddTranslation("BEE_DISPLAYEDNAME_612", "Bee", "蜂");
            // 蜂巢
            AddTranslation("BEEHIVE_DISPLAYEDNAME_500", "Beehive", "蜂房");
            // 令人望而却步的蜂巢。当它受到攻击时你会抽到一张蜜蜂牌。
            AddTranslation("BEEHIVE_DESCRIPTION_689_M", "The inviolable Beehive. When it is attacked you will draw a Bee.", "不可犯之蜂房。攻之，则引一蜂。");
            // 寻血猎犬
            AddTranslation("BLOODHOUND_DISPLAYEDNAME_451", "Bloodhound", "寻血犬");
            // 勇敢无畏的寻血猎犬。当对方使用新造物时它会跳到对应位置应战。
            AddTranslation("BLOODHOUND_DESCRIPTION_777_M", "The dauntless Bloodhound. It leaps to oppose new creatures when they are played.", "无畏之寻血犬。敌之新物一陈，即跃而当之。");
            // 牛蛙
            AddTranslation("BULLFROG_DISPLAYEDNAME_026", "Bullfrog", "牛蛙");
            // 时刻警觉的牛蛙。它会跳起来拦截对方的空袭。
            AddTranslation("BULLFROG_DESCRIPTION_086_M", "The watchful Bullfrog. It leaps in the way of attacking flyers.", "警甚之牛蛙。能跃而御来袭之翔物。");
            // 土遁陷阱
            AddTranslation("BURROWINGTRAP_DISPLAYEDNAME_398", "Burrowing Trap", "潜土阱");
            // 笼中之狼
            AddTranslation("CAGEDWOLF_DISPLAYEDNAME_002", "Caged Wolf", "槛中狼");
            // 猫
            AddTranslation("CAT_DISPLAYEDNAME_813", "Cat", "猫");
            // 不死之猫。可怜的小家伙在献祭之后也不会死。
            AddTranslation("CAT_DESCRIPTION_799_M", "The undying Cat. Sacrificing the poor beast does not kill it.", "不死之猫。祀此小物，不致其死。");
            // 不死猫
            AddTranslation("CATUNDEAD_DISPLAYEDNAME_900", "Undead Cat", "不死猫");
            // 蟑螂
            AddTranslation("COCKROACH_DISPLAYEDNAME_147", "Cockroach", "蜚蠊");
            // 打不死的蟑螂。死掉后还会回到你的手牌中。
            AddTranslation("COCKROACH_DESCRIPTION_700_M", "The unkillable Cockroach. It returns to your hand after dying.", "不死之蜚蠊。死而返手。");
            // 郊狼
            AddTranslation("COYOTE_DISPLAYEDNAME_081", "Coyote", "郊狼");
            // 瘦骨嶙峋的郊狼。不过你单凭四根骨头还指望能换来什么呢？
            AddTranslation("COYOTE_DESCRIPTION_674_M", "The meager Coyote. But what did you expect for only four bones?", "瘠郊狼也。然四骨而求之，复何望焉？");
            // 达欧斯猪妖
            AddTranslation("DAUS_DISPLAYEDNAME_941", "The Daus", "达欧斯");
            // 那头肮脏的野猪……铃铛一响就愤怒得不行。
            AddTranslation("DAUS_DESCRIPTION_450_M", "That filthy feral hog... It becomes incensed when its chimes are struck.", "彼秽野豕……其铃一击，则怒。");
            // 尾巴
            AddTranslation("DEFAULTTAIL_DISPLAYEDNAME_383", "Tail", "尾");
            // 麋鹿
            AddTranslation("ELK_DISPLAYEDNAME_175", "Elk", "麋");
            // 易受惊吓的麋鹿。攻击之后会立即移动。
            AddTranslation("ELK_DESCRIPTION_049_M", "The flighty Elk. It moves after attacking.", "惊麋也。既攻则移。");
            // 小麋鹿
            AddTranslation("ELKCUB_DISPLAYEDNAME_815", "Elk Fawn", "麋犊");
            // 刚落生的小麋鹿。很快就会成长为成年麋鹿。
            AddTranslation("ELKCUB_DESCRIPTION_167_M", "The nascent Fawn. It quickly grows into an Elk.", "初生之犊。旋长为麋。");
            // 田鼠
            AddTranslation("FIELDMOUSE_DISPLAYEDNAME_474", "Field Mice", "田鼠");
            // 唔，真是毫无廉耻的田鼠，使用后你能抽到一张同样的牌。
            AddTranslation("FIELDMOUSE_DESCRIPTION_313_M", "Hm. The licentious Field Mice. You will draw a copy when they are played.", "唔，彼田鼠淫甚。陈之，则引其同牌。");
            // 斑点鼠
            AddTranslation("FIELDMOUSE_FUSED_DISPLAYEDNAME_164", "Spore Mice", "蕈鼠");
            // 壁虎
            AddTranslation("GECK_DISPLAYEDNAME_578", "Geck", "守宫");
            // 其貌不扬的壁虎。或许你能让它派上用场？
            AddTranslation("GECK_DESCRIPTION_724_M", "The uninspiring Geck. Perhaps you can find a use for it?", "无奇之守宫。或可用之。");
            // 黑山羊
            AddTranslation("GOAT_DISPLAYEDNAME_386", "Black Goat", "黑山羊");
            // 被尊为神的羊羔。至真至纯的祭品。献祭它可获得3点血量。
            AddTranslation("GOAT_DESCRIPTION_346_M", "The apotheosized Goat. The truest offering. Sacrificing it grants three blood.", "神羊也。至真之献也。祀之，则得三血。");
            // 灰熊
            AddTranslation("GRIZZLY_DISPLAYEDNAME_201", "Grizzly", "罴");
            // 凶狠残暴的灰熊。压迫性的体型充分展示了它的能力。
            AddTranslation("GRIZZLY_DESCRIPTION_428_M", "The monstrous Grizzly. Its form speaks enough of its efficacy.", "暴罴也。其形足见其能。");
            // 鹰
            AddTranslation("HAWK_DISPLAYEDNAME_226", "Hawk", "鹰");
            // 电鳗
            AddTranslation("HROKKALL_DISPLAYEDNAME_354", "Hrokkall", "赫罗卡尔");
            // 13号孩子
            AddTranslation("JERSEYDEVIL_DISPLAYEDNAME_914", "Child 13", "十三子");
            // 可怜的弃儿。它在献祭时不会死亡……但你忍心拿来尝试吗？
            AddTranslation("JERSEYDEVIL_DESCRIPTION_097_M", "Poor abandoned child. It does not die when sacrificed... but do you have the heart to try?", "可怜之弃子。祀之不死……然汝忍试之乎？");
            // 翠鸟
            AddTranslation("KINGFISHER_DISPLAYEDNAME_165", "Kingfisher", "翡翠");
            // 灵巧敏捷的翠鸟。浑身滑溜溜的猎兽。
            AddTranslation("KINGFISHER_DESCRIPTION_702_M", "The adept Kingfisher. A slippery hunter.", "捷翡翠也。滑而善猎。");
            // 胡鹫
            AddTranslation("LAMMERGEIER_DISPLAYEDNAME_822", "Lammergeier", "胡鹫");
            // 贪婪的胡鹫。它的力量与你的骨头数量成正比。
            AddTranslation("LAMMERGEIER_DESCRIPTION_005_M", "The voracious Lammergeier. Its power scales in proportion to your Bones.", "饕胡鹫也。其威视乃骨之数。");
            // 尸蛆
            AddTranslation("MAGGOTS_DISPLAYEDNAME_787", "Corpse Maggots", "尸蛆");
            // 难以躲避的蛆虫。当你的造物被杀死时，它们会从你手牌中一涌而出。
            AddTranslation("MAGGOTS_DESCRIPTION_378_M", "The inevitable maggot. They will lurch forth from your hand when your creatures are killed.", "尸蛆不可避。乃物见杀，则彼自乃手涌出。");
            // 喜鹊
            AddTranslation("MAGPIE_DISPLAYEDNAME_296", "Magpie", "鹊");
            // 真是贪得无厌的喜鹊。它能从你牌组中叼出任意卡牌。
            AddTranslation("MAGPIE_DESCRIPTION_512_M", "The covetous Magpie. It can fetch any card in your deck.", "贪鹊也。能任取一牌于乃列。");
            // 螳螂
            AddTranslation("MANTIS_DISPLAYEDNAME_706", "Mantis", "螳螂");
            // 狂热的螳螂。它伸展的前肢可同时向左右两个方向攻击。
            AddTranslation("MANTIS_DESCRIPTION_198_M", "The fervid Mantis. Its prying claws strike both to the left and right.", "狂螳螂也。其钩臂并击左右。");
            // 螳螂神
            AddTranslation("MANTISGOD_DISPLAYEDNAME_357", "Mantis God", "螳神");
            // 至高无上的螳螂神。是恐怖一词最具象完美的体现。
            AddTranslation("MANTISGOD_DESCRIPTION_232_M", "The holy Mantis God. A perfect incarnation of terror.", "至上之螳神。惧之完形也。");
            // 鼹鼠
            AddTranslation("MOLE_DISPLAYEDNAME_205", "Mole", "鼹");
            // 无处不在的鼹鼠。它会四处打洞，从各个角落钻出来格挡地面的攻击者。
            AddTranslation("MOLE_DESCRIPTION_116_M", "The omnipresent Mole. It burrows and emerges to block any landborn attacker.", "无所不在之鼹。钻而复出，以御凡行地来攻者。");
            // 鼹鼠人
            AddTranslation("MOLEMAN_DISPLAYEDNAME_050", "Mole Man", "鼹人");
            // 健壮敦实的鼹鼠人。可谓最终极的防御。
            AddTranslation("MOLEMAN_DESCRIPTION_757_M", "The stalwart Mole Man. The ultimate defense.", "坚鼹人也。御之至也。");
            // 雄驼鹿
            AddTranslation("MOOSE_DISPLAYEDNAME_140", "Moose Buck", "牡驼鹿");
            // 皇家驼鹿。荒野之上的生灵莫不为之臣服。
            AddTranslation("MOOSE_DESCRIPTION_589_M", "The regal Moose. The creatures of the wild make way for it.", "尊牡驼鹿也。野物莫不为之辟道。");
            // 奇怪的幼虫
            AddTranslation("MOTHMAN_STAGE1_DISPLAYEDNAME_456", "Strange Larva", "异幼虫");
            // 块头虽大，却其貌不扬的一只虫子。
            AddTranslation("MOTHMAN_STAGE1_DESCRIPTION_043_M", "A largely unimpressive specimen.", "硕而无奇之虫。");
            // 奇怪的蛹
            AddTranslation("MOTHMAN_STAGE2_DISPLAYEDNAME_306", "Strange Pupa", "异蛹");
            // 飞蛾人
            AddTranslation("MOTHMAN_STAGE3_DISPLAYEDNAME_099", "Mothman", "蛾人");
            // 骡子
            AddTranslation("MULE_DISPLAYEDNAME_100", "Pack Mule", "驮骡");
            // 负鼠
            AddTranslation("OPOSSUM_DISPLAYEDNAME_864", "Opossum", "负鼠");
            // 足智多谋的负鼠。代价虽小，造物也不大。
            AddTranslation("OPOSSUM_DESCRIPTION_268_M", "The resourceful Opossum. A small creature for a small price.", "机敏之负鼠。小物也，其直亦小。");
            // 水獭
            AddTranslation("OTTER_DISPLAYEDNAME_010", "River Otter", "河獭");
            // 啊，就这只怕人的水獭。一到我的回合它就躲到水下去。
            AddTranslation("OTTER_DESCRIPTION_747_M", "Ah, the elusive Otter. It submerges itself during my turn.", "畏人之河獭。及朕合，则自潜于水。");
            // 林鼠
            AddTranslation("PACKRAT_DISPLAYEDNAME_792", "Pack Rat", "囊鼠");
            // 谨小慎微的林鼠。千万不要低估一个物资充裕的背包能有多方便。
            AddTranslation("PACKRAT_DESCRIPTION_729_M", "The prudent Pack Rat. Never doubt the utility of a well stocked pack.", "慎囊鼠也。毋疑满囊之用。");
            // 豪猪
            AddTranslation("PORCUPINE_DISPLAYEDNAME_313", "Porcupine", "豪猪");
            // 剑拔弩张的豪猪。背上锋利的刺正等着哪个不开眼的先动手呢。
            AddTranslation("PORCUPINE_DESCRIPTION_988_M", "The ornery Porcupine. Sharp quills await those who dare attack it.", "悍豪猪也。敢攻之者，利棘待之。");
            // 叉角羚
            AddTranslation("PRONGHORN_DISPLAYEDNAME_035", "Pronghorn", "叉角羚");
            // 酷虐残忍的叉角羚。被它的利角捅穿的敌人无一例外都死得很悲惨。
            AddTranslation("PRONGHORN_DESCRIPTION_982_M", "The sadistic Pronghorn. Woe be to those that meet the end of its antlers.", "酷叉角羚也。逢其角端者，祸矣。");
            // 兔子
            AddTranslation("RABBIT_DISPLAYEDNAME_255", "Rabbit", "兔");
            // 鼠王
            AddTranslation("RATKING_DISPLAYEDNAME_033", "Rat King", "鼠王");
            // 不幸的鼠王。这群纠缠在一起的老鼠若变成尸体，你将获得4根骨头。
            AddTranslation("RATKING_DESCRIPTION_278_M", "The tragic Rat King. When their tangled bodies become corpses you will gain four bones.", "哀鼠王也。其纠躯既尸，则汝得四骨。");
            // 响尾蛇
            AddTranslation("RATTLER_DISPLAYEDNAME_734", "Rattler", "响尾蛇");
            // 臭名昭著的响尾蛇。可以说比较脆弱……前提是要能躲过它凶狠的獠牙。
            AddTranslation("RATTLER_DESCRIPTION_381_M", "The nefarious Rattler. A brittle creature... once past its monstrous fangs.", "恶响尾蛇也。苟过其巨牙，则体甚脆。");
            // 渡鸦
            AddTranslation("RAVEN_DISPLAYEDNAME_931", "Raven", "渡鸦");
            // 精于暗算的渡鸦。仿佛是天空的瘟疫一般。
            AddTranslation("RAVEN_DESCRIPTION_197_M", "The conniving Raven. A blight upon the skies.", "狡渡鸦也。天际之疠。");
            // 渡鸦蛋
            AddTranslation("RAVENEGG_DISPLAYEDNAME_316", "Raven Egg", "渡鸦卵");
            // 刚孵化的小渡鸦。虽然刚破壳，但已然十分阴险。
            AddTranslation("RAVENEGG_DESCRIPTION_963_M", "A nascent Raven. It is no less conniving in its incubation.", "方孵之渡鸦。虽在伏卵，亦已狡矣。");
            // 鲑鱼
            AddTranslation("SALMON_DISPLAYEDNAME_921", "Salmon", "鲑");
            // 大白鲨
            AddTranslation("SHARK_DISPLAYEDNAME_934", "Great White", "大白鲨");
            // 严苛残暴的大白鲨。深海中的统治者。
            AddTranslation("SHARK_DESCRIPTION_849_M", "The tyrannical Great White. The master of the deep.", "暴大白鲨。渊中之主。");
            // 石龙子
            AddTranslation("SKINK_DISPLAYEDNAME_343", "Skink", "石龙子");
            // 顽强求生的石龙子。受到攻击时会将尾巴留在原地，自己则落荒而逃。
            AddTranslation("SKINK_DESCRIPTION_241_M", "The tenacious Skink. It moves over when attacked, leaving its tail behind.", "坚石龙子也。受攻则移，留尾于故处。");
            // 扭动的尾巴
            AddTranslation("SKINKTAIL_DISPLAYEDNAME_588", "Wriggling Tail", "蠕尾");
            // 臭鼬
            AddTranslation("SKUNK_DISPLAYEDNAME_581", "Skunk", "臭鼬");
            // 恶名缠身的臭鼬。它的恶臭能降低敌人的力气。
            AddTranslation("SKUNK_DESCRIPTION_908_M", "The reviled Skunk. Its stench reduces the strength of the enemy.", "人所恶之臭鼬。其臭能损敌威。");
            // 鳄龟
            AddTranslation("SNAPPER_DISPLAYEDNAME_569", "River Snapper", "鳄龟");
            // 敦实的鳄龟。它的防御几乎无懈可击。
            AddTranslation("SNAPPER_DESCRIPTION_429_M", "The stalwart Snapper. A near impenetrable defense.", "坚鳄龟也。御几不可穿。");
            // 长身麋鹿
            AddTranslation("SNELK_DISPLAYEDNAME_880", "Long Elk", "长麋");
            // 这种自然界的怪胎我没有词语可以描述。
            AddTranslation("SNELK_DESCRIPTION_414_M", "I have no words for this freak of nature.", "此自然之怪，余无辞可道。");
            // 麻雀
            AddTranslation("SPARROW_DISPLAYEDNAME_717", "Sparrow", "雀");
            // 温顺的麻雀。这只会飞的小造物虽然不贵，但也不禁敲打。
            AddTranslation("SPARROW_DESCRIPTION_252_M", "The meek Sparrow. An inexpensive, if feeble, flying creature.", "柔雀也。翔而直薄，然体甚弱。");
            // 铃铛触手
            AddTranslation("SQUIDBELL_DISPLAYEDNAME_500", "Bell Tentacle", "铃触");
            // 唔。我怎么不记得造出过这么个玩意……
            AddTranslation("SQUIDBELL_DESCRIPTION_335_M", "Hm. I don't recall making that one...", "唔，余不忆曾作此物……");
            // 镜子触手
            AddTranslation("SQUIDMIRROR_DISPLAYEDNAME_772", "Mirror Tentacle", "镜触");
            // 我那个……说实在的我都不知道这是个啥。
            AddTranslation("SQUIDMIRROR_DESCRIPTION_405_M", "I'm... Actually I'm not sure what that is.", "余……实不知其为何物。");
            // 松鼠
            AddTranslation("SQUIRREL_DISPLAYEDNAME_139", "Squirrel", "松鼠");
            // 松鼠球
            AddTranslation("SQUIRRELBALL_DISPLAYEDNAME_761", "Squirrel Ball", "松鼠球");
            // 白鼬
            AddTranslation("STOAT_DISPLAYEDNAME_442", "Stoat", "白鼬");
            // 长毛野人
            AddTranslation("URAYULI_DISPLAYEDNAME_604", "Urayuli", "乌拉尤利");
            // 这个级别的纯蛮力已经无需多言了……
            AddTranslation("URAYULI_DESCRIPTION_393_M", "This level of brutish strength needs no explanation...", "此等蛮力，无庸多言……");
            // 红头美洲鹫
            AddTranslation("VULTURE_DISPLAYEDNAME_917", "Turkey Vulture", "秃鹫");
            // 狠毒冷血的秃鹫。是天空中的霸王。
            AddTranslation("VULTURE_DESCRIPTION_412_M", "The pernicious Vulture. A tyrant of the skies.", "恶秃鹫也。天上之暴主。");
            // 兔窝
            AddTranslation("WARREN_DISPLAYEDNAME_150", "Warren", "兔窟");
            // 丰产的兔窝。使用时可产生一只兔子。
            AddTranslation("WARREN_DESCRIPTION_740_M", "The bountiful Warren. It spawns a rabbit when it is played.", "蕃兔窟。陈之，则生一兔。");
            // 狼
            AddTranslation("WOLF_DISPLAYEDNAME_653", "Wolf", "狼");
            // 骄傲的狼。也是凶残的觊觎者。
            AddTranslation("WOLF_DESCRIPTION_804_M", "The proud Wolf. A vicious contender.", "傲狼也。凶角者也。");
            // 狼崽
            AddTranslation("WOLFCUB_DISPLAYEDNAME_513", "Wolf Cub", "狼崽");
            // 年幼的小狼崽。只需一个回合就能长成一头成年狼。
            AddTranslation("WOLFCUB_DESCRIPTION_770_M", "The young Wolf Cub. It grows into a Wolf after a single turn.", "幼狼崽也。居一合，则长为狼。");
            // 月亮
            AddTranslation("!GIANTCARD_MOON_DISPLAYEDNAME_596", "The Moon", "月");
            // 一桶鱼饵
            AddTranslation("BAITBUCKET_DISPLAYEDNAME_906", "Bait Bucket", "饵桶");
            // 石头
            AddTranslation("CARDMERGESTONES_DISPLAYEDNAME_770", "The Stones", "石");
            // 堤坝
            AddTranslation("DAM_DISPLAYEDNAME_830", "Dam", "堤");
            // 铃铛
            AddTranslation("DAUSBELL_DISPLAYEDNAME_763", "Chime", "铃");
            // 金块
            AddTranslation("GOLDNUGGET_DISPLAYEDNAME_952", "Gold Nugget", "金块");
            // 金羊皮
            AddTranslation("PELTGOLDEN_DISPLAYEDNAME_640", "Golden Pelt", "金革");
            // 兔皮
            AddTranslation("PELTHARE_DISPLAYEDNAME_715", "Rabbit Pelt", "兔革");
            // 狼皮
            AddTranslation("PELTWOLF_DISPLAYEDNAME_867", "Wolf Pelt", "狼革");
            // 环形虫
            AddTranslation("RINGWORM_DISPLAYEDNAME_997", "Ring Worm", "环虫");
            // 被人小瞧了的环形虫。它的真正价值绝不止表面看起来这样……
            AddTranslation("RINGWORM_DESCRIPTION_352_M", "The underappreciated Ring Worm. Its value is not readily apparent...", "见轻之环虫。其值未可遽见……");
            // 烛烟
            AddTranslation("SMOKE_DISPLAYEDNAME_799", "The Smoke", "烛烟");
            // 大团烛烟
            AddTranslation("SMOKE_IMPROVED_DISPLAYEDNAME_197", "Greater Smoke", "大烛烟");
            // 饥饿
            AddTranslation("STARVATION_DISPLAYEDNAME_785", "Starvation", "饥");
            // 臭虫
            AddTranslation("STINKBUG_TALKING_DISPLAYEDNAME_390", "Stinkbug", "臭虫");
            // 跳跃陷阱
            AddTranslation("TRAP_DISPLAYEDNAME_088", "Leaping Trap", "跃阱");
            // 奇怪的青蛙
            AddTranslation("TRAPFROG_DISPLAYEDNAME_052", "Strange Frog", "异蛙");
            // 弱狼
            AddTranslation("WOLF_TALKING_DISPLAYEDNAME_008", "Stunted Wolf", "残狼");
            // ！已损坏
            AddTranslation("!CORRUPTED_DISPLAYEDNAME_574", "!CORRUPTED", "!既败");
            // 烂鱼
            AddTranslation("ANGLER_FISH_BAD_DISPLAYEDNAME_858", "Bad Fish", "恶鱼");
            // 好鱼
            AddTranslation("ANGLER_FISH_GOOD_DISPLAYEDNAME_632", "Good Fish", "良鱼");
            // 更多的鱼
            AddTranslation("ANGLER_FISH_MORE_DISPLAYEDNAME_069", "More Fish", "多鱼");
            // 机器鱼
            AddTranslation("ANGLER_TALKING_DISPLAYEDNAME_745", "Fishbot", "鱼机人");
            // 木乃伊之王
            AddTranslation("MUMMY_TELEGRAPHER_DISPLAYEDNAME_023", "Mummy Lord", "木乃伊王");
            // 闹铃机器人
            AddTranslation("ALARMBOT_DISPLAYEDNAME_772", "Alarm Bot", "警铃机人");
            // 阿米巴机器人
            AddTranslation("AMOEBOT_DISPLAYEDNAME_807", "Amoebot", "阿米巴机人");
            // 增益管道
            AddTranslation("ATTACKCONDUIT_DISPLAYEDNAME_259", "Buff Conduit", "益渠");
            // 自动机器人
            AddTranslation("AUTOMATON_DISPLAYEDNAME_977", "Automaton", "自动机");
            // 能量机器人
            AddTranslation("BATTERYBOT_DISPLAYEDNAME_845", "Energy Bot", "能机人");
            // 螺栓铁狗
            AddTranslation("BOLTHOUND_DISPLAYEDNAME_140", "Bolthound", "寻栓犬");
            // 自爆机器人
            AddTranslation("BOMBBOT_DISPLAYEDNAME_457", "Explode Bot", "爆机人");
            // 炸弹夫人
            AddTranslation("BOMBMAIDEN_DISPLAYEDNAME_410", "Mrs. Bomb", "弹夫人");
            // 报废的3D打印机
            AddTranslation("BUSTEDPRINTER_DISPLAYEDNAME_264", "Busted 3D Printer", "既废三维印机");
            // 文件挟持犯
            AddTranslation("CAPTIVEFILE_DISPLAYEDNAME_509", "Captive File", "囚牍");
            // 强壮电池
            AddTranslation("CELLBUFF_DISPLAYEDNAME_816", "Tough Cell", "壮电匣");
            // 和善电池
            AddTranslation("CELLGIFT_DISPLAYEDNAME_156", "Kind Cell", "和电匣");
            // 分化电池
            AddTranslation("CELLTRI_DISPLAYEDNAME_608", "Splinter Cell", "歧电匣");
            // 双枪手
            AddTranslation("CLOSERBOT_DISPLAYEDNAME_429", "Double Gunner", "双铳手");
            // 机械蝰蛇
            AddTranslation("CXFORMERADDER_DISPLAYEDNAME_509", "ADD3R", "机蝮");
            // 机械麋鹿
            AddTranslation("CXFORMERELK_DISPLAYEDNAME_822", "3LK", "机麋");
            // 机械渡鸦
            AddTranslation("CXFORMERRAVEN_DISPLAYEDNAME_492", "RAV3N", "机渡鸦");
            // 机械狼
            AddTranslation("CXFORMERWOLF_DISPLAYEDNAME_568", "W07F", "机狼");
            // 空容器
            AddTranslation("EMPTYVESSEL_DISPLAYEDNAME_072", "Empty Vessel", "虚皿");
            // 蓝宝石容器
            AddTranslation("EMPTYVESSEL_BLUEGEM_DISPLAYEDNAME_706", "Sapphire Vessel", "蓝玉皿");
            // 绿宝石容器
            AddTranslation("EMPTYVESSEL_GREENGEM_DISPLAYEDNAME_839", "Emerald Vessel", "绿玉皿");
            // 红宝石容器
            AddTranslation("EMPTYVESSEL_ORANGEGEM_DISPLAYEDNAME_203", "Ruby Vessel", "红玉皿");
            // 赌博机器人
            AddTranslation("ENERGYROLLER_DISPLAYEDNAME_296", "Gamblobot", "博机人");
            // 工厂管道
            AddTranslation("FACTORYCONDUIT_DISPLAYEDNAME_742", "Factory Conduit", "肆渠");
            // 宝石收割者
            AddTranslation("GEMRIPPER_DISPLAYEDNAME_264", "Gembound Ripper", "缚玉割者");
            // 宝石管道
            AddTranslation("GEMSCONDUIT_DISPLAYEDNAME_208", "Gems Conduit", "玉渠");
            // 礼物机器人
            AddTranslation("GIFTBOT_DISPLAYEDNAME_702", "Gift Bot", "赠机人");
            // 治疗管道
            AddTranslation("HEALERCONDUIT_DISPLAYEDNAME_606", "Heal Conduit", "疗渠");
            // 机械虫
            AddTranslation("INSECTODRONE_DISPLAYEDNAME_477", "Insectodrone", "虫飞械");
            // 炸弹传递者
            AddTranslation("LATCHERBOMB_DISPLAYEDNAME_874", "Bomb Latcher", "爆弹遗契者");
            // 骷髅传递者
            AddTranslation("LATCHERBRITTLE_DISPLAYEDNAME_450", "Skel-e-latcher", "枯骨遗契者");
            // 坚盾传递者
            AddTranslation("LATCHERSHIELD_DISPLAYEDNAME_119", "Shield Latcher", "坚盾遗契者");
            // 跳跃机器人
            AddTranslation("LEAPBOT_DISPLAYEDNAME_701", "L33pB0t", "跃机人");
            // 图书管理员
            AddTranslation("LIBRARIAN_DISPLAYEDNAME_247", "Librarian", "守牍者");
            // 肉肉机器人
            AddTranslation("MEATBOT_DISPLAYEDNAME_692", "M3atB0t", "肉机人");
            // 黄金矿工
            AddTranslation("MINECART_DISPLAYEDNAME_123", "49er", "采金机人");
            // 等离子炮吉米
            AddTranslation("PLASMAGUNNER_DISPLAYEDNAME_635", "Plasma Jimmy", "等离吉米");
            // 钢老鼠
            AddTranslation("ROBOMICE_DISPLAYEDNAME_648", "Steel Mice", "钢鼠");
            // 机械外骨骼
            AddTranslation("ROBOSKELETON_DISPLAYEDNAME_854", "ExeSkeleton", "骸机");
            // 蓝宝石哨兵
            AddTranslation("SENTINELBLUE_DISPLAYEDNAME_745", "!DELETED!", "蓝玉戍者");
            // 绿宝石哨兵
            AddTranslation("SENTINELGREEN_DISPLAYEDNAME_191", "!DELETED!", "绿玉戍者");
            // 红宝石哨兵
            AddTranslation("SENTINELORANGE_DISPLAYEDNAME_092", "!DELETED!", "红玉戍者");
            // 哨兵无人机
            AddTranslation("SENTRYBOT_DISPLAYEDNAME_678", "Sentry Drone", "戍飞械");
            // 哨兵孢子
            AddTranslation("SENTRYBOT_FUSED_DISPLAYEDNAME_369", "Sentry Spore", "戍蕈");
            // 坚盾机器人
            AddTranslation("SHIELDBOT_DISPLAYEDNAME_835", "Shieldbot", "盾机人");
            // 快门虫
            AddTranslation("SHUTTERBUG_DISPLAYEDNAME_618", "Shutterbug", "闸虫");
            // 狙击机器人
            AddTranslation("SNIPER_DISPLAYEDNAME_302", "Sniper Bot", "狙机人");
            // 蒸汽机器人
            AddTranslation("STEAMBOT_DISPLAYEDNAME_801", "Steambot", "蒸机人");
            // 对换机器人
            AddTranslation("SWAPBOT_DISPLAYEDNAME_290", "Swapbot", "易机人");
            // 玛珂模块
            AddTranslation("TECHMOXTRIPLE_DISPLAYEDNAME_505", "Mox Module", "玛珂枢");
            // 胖墩机器人
            AddTranslation("THICKBOT_DISPLAYEDNAME_023", "Thick Droid", "厚机人");
            // 机械蝙蝠
            AddTranslation("XFORMERBATBEAST_DISPLAYEDNAME_858", "S0N1A", "机蝠");
            // 机械灰熊
            AddTranslation("XFORMERGRIZZLYBEAST_DISPLAYEDNAME_965", "GR1ZZ", "机罴");
            // 机械豪猪
            AddTranslation("XFORMERPORCUPINEBEAST_DISPLAYEDNAME_706", "QU177", "机豪猪");
            // 恼人广播站
            AddTranslation("ANNOYTOWER_DISPLAYEDNAME_615", "Annoy FM", "可厌播台");
            // 磐石
            AddTranslation("BOULDER_DISPLAYEDNAME_389", "Boulder", "磐");
            // 桥栏杆
            AddTranslation("BRIDGERAILING_DISPLAYEDNAME_656", "Bridge Rails", "桥栏");
            // 损毁机器人
            AddTranslation("BROKENBOT_DISPLAYEDNAME_841", "Broken Bot", "既毁机人");
            // 管道塔
            AddTranslation("CONDUITTOWER_DISPLAYEDNAME_997", "Conduit Tower", "渠塔");
            // 枯树
            AddTranslation("DEADTREE_DISPLAYEDNAME_798", "Dead Tree", "枯木");
            // 冰封负鼠
            AddTranslation("FROZENOPOSSUM_DISPLAYEDNAME_454", "Frozen Opossum", "冰封负鼠");
            // 树桩
            AddTranslation("STUMP_DISPLAYEDNAME_819", "Stump", "株");
            // 墓碑
            AddTranslation("TOMBSTONE_DISPLAYEDNAME_209", "Tombstone", "冢");
            // 大冷杉
            AddTranslation("TREE_DISPLAYEDNAME_859", "Grand Fir", "大杉");
            // 古冷杉
            AddTranslation("TREE_HOLOGRAM_DISPLAYEDNAME_215", "Ancient Fir", "古杉");
            // 雪压冷杉
            AddTranslation("TREE_HOLOGRAM_SNOWCOVERED_DISPLAYEDNAME_192", "Snowy Fir", "雪杉");
            // 女妖
            AddTranslation("BANSHEE_DISPLAYEDNAME_958", "Banshee", "女妖");
            // 寻骨猎犬
            AddTranslation("BONEHOUND_DISPLAYEDNAME_234", "Bonehound", "寻骨犬");
            // 骨堆
            AddTranslation("BONEPILE_DISPLAYEDNAME_118", "Bone Heap", "积骨");
            // 破碎银币
            AddTranslation("COINLEFT_DISPLAYEDNAME_646", "Broken Obol", "碎半银币");
            // 死人手
            AddTranslation("DEADHAND_DISPLAYEDNAME_900", "Dead Hand", "死手");
            // 法老之宠
            AddTranslation("DEADPETS_DISPLAYEDNAME_089", "Pharaoh's Pets", "法老之宠");
            // 尸鬼
            AddTranslation("DRAUGR_DISPLAYEDNAME_556", "Draugr", "尸鬼");
            // 淹死鬼
            AddTranslation("DROWNEDSOUL_DISPLAYEDNAME_244", "Drowned Soul", "溺魂");
            // 行师走人
            AddTranslation("FAMILY_DISPLAYEDNAME_654", "The Walkers", "行尸");
            // 弗兰肯和斯坦
            AddTranslation("FRANKNSTEIN_DISPLAYEDNAME_414", "Frank & Stein", "弗兰克及斯坦");
            // 幽灵船
            AddTranslation("GHOSTSHIP_DISPLAYEDNAME_368", "Ghost Ship", "鬼舟");
            // 掘墓人
            AddTranslation("GRAVEDIGGER_DISPLAYEDNAME_488", "Gravedigger", "掘冢者");
            // 掘孢人
            AddTranslation("GRAVEDIGGER_FUSED_DISPLAYEDNAME_500", "Sporedigger", "掘蕈者");
            // 无头骑士
            AddTranslation("HEADLESSHORSEMAN_DISPLAYEDNAME_265", "Headless Horseman", "无首骑者");
            // 死灵法师
            AddTranslation("NECROMANCER_DISPLAYEDNAME_180", "Necromancer", "死灵巫");
            // 复生亡灵
            AddTranslation("REVENANT_DISPLAYEDNAME_513", "Revenant", "逆生魂");
            // 石棺
            AddTranslation("SARCOPHAGUS_DISPLAYEDNAME_736", "Sarcophagus", "石椁");
            // 骷髅
            AddTranslation("SKELETON_DISPLAYEDNAME_237", "Skeleton", "枯骨");
            // 骷髅法师
            AddTranslation("SKELETONMAGE_DISPLAYEDNAME_198", "Skelemagus", "枯骨巫");
            // 盗墓贼
            AddTranslation("TOMBROBBER_DISPLAYEDNAME_140", "Tomb Robber", "盗冢者");
            // 丧尸
            AddTranslation("ZOMBIE_DISPLAYEDNAME_093", "Zombie", "僵尸");
            // 蓝色法师
            AddTranslation("BLUEMAGE_DISPLAYEDNAME_707", "Blue Mage", "蓝巫");
            // 蓝色孢子法师
            AddTranslation("BLUEMAGE_FUSED_DISPLAYEDNAME_764", "Blue Sporemage", "蓝蕈巫");
            // 悬浮法师
            AddTranslation("FLYINGMAGE_DISPLAYEDNAME_482", "Hover Mage", "悬巫");
            // 强力法师
            AddTranslation("FORCEMAGE_DISPLAYEDNAME_607", "Force Mage", "力巫");
            // 宝石魔鬼
            AddTranslation("GEMFIEND_DISPLAYEDNAME_754", "Gem Fiend", "玉魅");
            // 绿色法师
            AddTranslation("GREENMAGE_DISPLAYEDNAME_496", "Green Mage", "绿巫");
            // 法师骑士
            AddTranslation("MAGEKNIGHT_DISPLAYEDNAME_727", "Mage Knight", "巫骑");
            // 暴食法师
            AddTranslation("MARROWMAGE_DISPLAYEDNAME_692", "Gourmage", "饕巫");
            // 蓝绿橙大师
            AddTranslation("MASTERBLEENE_DISPLAYEDNAME_471", "Master Bleene", "蓝绿大师");
            // 绿橙蓝大师
            AddTranslation("MASTERGORANJ_DISPLAYEDNAME_123", "Master Goranj", "绿橙大师");
            // 橙蓝绿大师
            AddTranslation("MASTERORLU_DISPLAYEDNAME_712", "Master Orlu", "橙蓝大师");
            // 蓝绿橙的玛珂
            AddTranslation("MOXDUALBG_DISPLAYEDNAME_714", "Bleene's Mox", "蓝绿之玛珂");
            // 绿橙蓝的玛珂
            AddTranslation("MOXDUALGO_DISPLAYEDNAME_190", "Goranj's Mox", "绿橙之玛珂");
            // 橙蓝绿的玛珂
            AddTranslation("MOXDUALOB_DISPLAYEDNAME_243", "Orlu's Mox", "橙蓝之玛珂");
            // 绿宝石玛珂
            AddTranslation("MOXEMERALD_DISPLAYEDNAME_993", "Emerald Mox", "绿玉玛珂");
            // 红宝石玛珂
            AddTranslation("MOXRUBY_DISPLAYEDNAME_207", "Ruby Mox", "红玉玛珂");
            // 蓝宝石玛珂
            AddTranslation("MOXSAPPHIRE_DISPLAYEDNAME_064", "Sapphire Mox", "蓝玉玛珂");
            // 至尊玛珂
            AddTranslation("MOXTRIPLE_DISPLAYEDNAME_249", "Magnus Mox", "至尊玛珂");
            // 肌肉法师
            AddTranslation("MUSCLEMAGE_DISPLAYEDNAME_478", "Muscle Mage", "肌巫");
            // 橙色法师
            AddTranslation("ORANGEMAGE_DISPLAYEDNAME_486", "Orange Mage", "橙巫");
            // 陪练巫师
            AddTranslation("PRACTICEMAGE_DISPLAYEDNAME_073", "Practice Wizard", "习祝");
            // 陪练法师
            AddTranslation("PRACTICEMAGESMALL_DISPLAYEDNAME_085", "Practice Mage", "习巫");
            // 法师学徒
            AddTranslation("PUPIL_DISPLAYEDNAME_689", "Mage Pupil", "巫徒");
            // 红宝石魔像
            AddTranslation("RUBYGOLEM_DISPLAYEDNAME_988", "Ruby Golem", "红玉偶");
            // 强化法师
            AddTranslation("STIMMAGE_DISPLAYEDNAME_530", "Stim Mage", "激巫");
            // 错误：数据块损坏
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_079", "ERROR: CORRUPTED CHUNK", "误：档块既败");
            // 缺失场景：格里魔拉.地窖
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_025", "MISSING SCENE: GRIMORA.Crypt", "景缺：格里魔拉.冢椁");
            // 错误：未检测到损坏数据
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_281", "ERROR: NULL CORRUPTED FILES DETECTED", "误：检败牍而未见");
            // 正在初始化子程序：孚纳游戏.Inscryption.错误21修正()
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_556", "Initializing subroutine: GameFuna.Inscryption.Error21Fix()", "惟子程之始：孚纳戏社.冥锲.误21补()");
            // 正在抹除意外数据
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_539", "Wiping unexpected data", "惟异档之除");
            // 错误：无法抹除意外数据
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_660", "ERROR: UNABLE TO WIPE UNEXPECTED DATA", "误：异档弗能除");
            // 重大错误：发现失踪资产
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_929", "CRITICAL ERROR: MISSING ASSETS CHECK", "亟误：资材有缺");
            // 正在恢复备份
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_479", "Restoring backup", "惟副本之复");
            // 已找到备份：莱西.木屋
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_598", "BACKUP FOUND: LESHY.Cabin", "副本既得：莱西.木庐");
            // 正在初始化子程序：新存档()
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_911", "Initializing subroutine: NewSaveFile()", "始子程：新存录()");
            // 正在创建新存档
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_583", "Creating new save file", "惟新存录之作");
            // 已创建新存档
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_727", "New save file created", "新存录既作");
            // 正在清理牌组数据
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_942", "Purging deck data", "惟牌列缓档之清");
            // 正在清理牌库数据
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_072", "Purging collection data", "惟牌藏缓档之清");
            // 正在校验/旧_数据/验证码
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_840", "Check /OLD_DATA/ key", "惟/旧_档/钥之校验");
            // /旧_数据/验证码校验未通过
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_601", "/OLD_DATA/ key denied", "/旧_档/钥不许");
            // 正在载入场景：莱西.木屋
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_111", "Loading scene: LESHY.Cabin", "惟景之载：莱西.木庐");
            // 场景载入完成
            AddTranslation("COMMANDLINE_GRIMORAFINALE_TEXT_606", "Scene loaded", "景既载");
            // 缺失场景：莱西.木屋
            AddTranslation("COMMANDLINE_LESHYFINALE_TEXT_460", "MISSING SCENE: LESHY.Cabin", "景缺：莱西.木庐");
            // 已找到备份：蔓尼菲科.????
            AddTranslation("COMMANDLINE_LESHYFINALE_TEXT_298", "BACKUP FOUND: MAGNIFICUS.????", "副本既得：蔓尼菲科.????");
            // 正在载入场景：蔓尼菲科.????
            AddTranslation("COMMANDLINE_LESHYFINALE_TEXT_094", "Loading scene: MAGNIFICUS.????", "惟景之载：蔓尼菲科.????");
            // 正在初始化程序：新游戏()
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_596", "Initializing routine: NewGame()", "惟程之始：新戏()");
            // 开始抹除数据
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_230", "Begin data wipe", "始除诸档");
            // 出现意外数据！
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_375", "Unexpected data encountered!", "见异档！");
            // 正在初始化子程序：孚纳游戏.Inscryption.错误27修正()
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_269", "Initializing subroutine: GameFuna.Inscryption.Error27Fix()", "惟子程之始：孚纳戏社.冥锲.误27补()");
            // 意外数据已移除
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_671", "Unexpected data removed", "异档既除");
            // 无可恢复的备份！
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_933", "No backup to restore!", "无副本可复！");
            // 正在载入场景：Inscryption.序章.冥刻者们
            AddTranslation("COMMANDLINE_NEWGAME_TEXT_972", "Loading scene: Inscryption.Intro.Scrybes", "惟景之载：冥锲.序章.诸司锲");
            // 错误：100010001110100100010010001
            AddTranslation("COMMANDLINE_PART2FINALE_TEXT_938", "ERROR: 100010001110100100010010001", "误：100010001110100100010010001");
            // 已找到备份：P03.工厂
            AddTranslation("COMMANDLINE_PART2FINALE_TEXT_006", "BACKUP FOUND: P03.Factory", "副本既得：鉟〇三.工肆");
            // 正在载入场景：P03.工厂
            AddTranslation("COMMANDLINE_PART2FINALE_TEXT_554", "Loading scene: P03.Factory", "惟景之载：鉟〇三.工肆");
            // 缺少场景：P03.工厂
            AddTranslation("COMMANDLINE_PART3FINALE_TEXT_076", "MISSING SCENE: P03.FACTORY", "景缺：鉟〇三.工肆");
            // 已找到备份：格里魔拉.地窖
            AddTranslation("COMMANDLINE_PART3FINALE_TEXT_015", "BACKUP FOUND: GRIMORA.Crypt", "副本既得：格里魔拉.冢椁");
            // 正在载入场景：格里魔拉.地窖
            AddTranslation("COMMANDLINE_PART3FINALE_TEXT_611", "Loading scene: GRIMORA.Crypt", "惟景之载：格里魔拉.冢椁");
            // 那东西能给你充能一回合。蛮好的。
            AddTranslation("BATTERY_DESCRIPTION_071_M", "That will recharge your energy one turn. Pretty good.", "此克复卿一合之能。善矣。");
            // 额外的电池
            AddTranslation("BATTERY_RULEBOOKNAME_906", "Extra Battery", "副电匣");
            // 将能量充满至当前最大值。好了没事啦。
            AddTranslation("BATTERY_RULEBOOKDESCRIPTION_432", "Replenishes Energy back up to the current maximum. It's alright.", "复能至今极。可也。");
            // 由它扇出的微风能让你的造物飞在空中……哪怕只能坚持一回合。
            AddTranslation("BIRDLEGFAN_DESCRIPTION_527_M", "A gust from this may lift your creatures into the air... if only for a turn.", "此一扇，或可举乃物于空……然止一合耳。");
            // 女妖的鸟腿骨扇
            AddTranslation("BIRDLEGFAN_RULEBOOKNAME_617", "Harpie's Birdleg Fan", "女妖鸟胫扇");
            // 你的造物本回合的攻击将好似带有空袭印记一般。
            AddTranslation("BIRDLEGFAN_RULEBOOKDESCRIPTION_430", "Your creatures will attack as though they have the Airborne sigil this turn.", "此合乃物攻若皆有翔袭印契。");
            // 炸弹夫人的遥控器。摁一下，自爆机器人就会空降在每个空位。
            AddTranslation("BOMBREMOTE_DESCRIPTION_821_M", "Mrs. Bomb's Remote. Click that thing and Explode Bots will drop in every open space.", "弹夫人之遥器。按之，则诸爆机人皆堕于凡空位。");
            // 炸弹夫人的遥控器
            AddTranslation("BOMBREMOTE_RULEBOOKNAME_635", "Mrs. Bomb's Remote", "弹夫人之遥器");
            // 在所有空位放置自爆机器人。真挺烦人的。
            AddTranslation("BOMBREMOTE_RULEBOOKDESCRIPTION_137", "Places Explode Bots on all empty spaces. Pretty annoying honestly.", "凡空位皆置爆机人。诚烦。");
            // 那只可怜的负鼠哟……
            AddTranslation("FROZENOPOSSUMBOTTLE_DESCRIPTION_514_M", "That pitiful opossum...", "彼负鼠，怜哉……");
            // 冰封负鼠瓶
            AddTranslation("FROZENOPOSSUMBOTTLE_RULEBOOKNAME_665", "Frozen Opossum Bottle", "冰封负鼠瓶");
            // 你的手牌里会出现一张冰封负鼠牌。[define:FrozenOpossum]
            AddTranslation("FROZENOPOSSUMBOTTLE_RULEBOOKDESCRIPTION_745", "A Frozen Opossum is created in your hand. [define:FrozenOpossum]", "于手生一冰封负鼠。[define:FrozenOpossum]");
            // 给它放血能获得[c:bR]3点血量[c:]……前提是你能对它的咩咩声充耳不闻。
            AddTranslation("GOATBOTTLE_DESCRIPTION_103_M", "Its bleeding yields [c:bR]3 Blood[c:]... If you can ignore the bleating.", "刺其血，则得[c:bR]3血[c:]……苟能略其咩鸣。");
            // 黑山羊瓶
            AddTranslation("GOATBOTTLE_RULEBOOKNAME_826", "Black Goat Bottle", "黑山羊瓶");
            // 你的手牌里会出现一张黑山羊牌。[define:Goat]
            AddTranslation("GOATBOTTLE_RULEBOOKDESCRIPTION_203", "A Black Goat is created in your hand. [define:Goat]", "于手生一黑山羊。[define:Goat]");
            // 噢……不行。这玩意你不能用。
            AddTranslation("GOOBOTTLE_DESCRIPTION_408_M", "Oh... Oh no. You can't use that.", "噫……不可。此物汝不得用。");
            // 失败
            AddTranslation("GOOBOTTLE_RULEBOOKNAME_982", "Failure", "败");
            // 什么都不会发生。这瓶黏液没有任何用处。
            AddTranslation("GOOBOTTLE_RULEBOOKDESCRIPTION_286", "Nothing will happen. This bottle of Goo has no use.", "无事将作。此瓶黏胶无用。");
            // 这可是个强力道具。翻转一下，我就跳过我的下一回合。
            AddTranslation("HOURGLASS_DESCRIPTION_282_M", "A powerful item. Turn this and I'll skip my next turn.", "强器也。转之，则朕次合不行。");
            // 沙漏
            AddTranslation("HOURGLASS_RULEBOOKNAME_993", "Hourglass", "漏");
            // 你的对手将彻底跳过其下一回合。
            AddTranslation("HOURGLASS_RULEBOOKDESCRIPTION_147", "Your adversary will entirely skip their next turn.", "敌次合尽阙。");
            // 一些骨币储备，以防万一……
            AddTranslation("PIGGYBANK_DESCRIPTION_070_M", "Some bone tokens for a rainy night...", "数枚骨筹，以备不虞……");
            // 野猪存钱瓶
            AddTranslation("PIGGYBANK_RULEBOOKNAME_456", "Hoggy Bank", "豕匮");
            // 立刻获得4根骨头。
            AddTranslation("PIGGYBANK_RULEBOOKDESCRIPTION_400", "You will immediately gain 4 Bones.", "即得4骨。");
            // 又是一个很有用的工具。你要是想拿它改变天平的结果，我也不拦着……
            AddTranslation("PLIERS_DESCRIPTION_658_M", "Another useful implement. I'll allow you to tip the scales with it...", "又一利器。余许尔以之倾衡……");
            // 老虎钳
            AddTranslation("PLIERS_RULEBOOKNAME_033", "Pliers", "钳");
            // 你能在天平上给对手加些筹码。疼也只疼那一下子。
            AddTranslation("PLIERS_RULEBOOKDESCRIPTION_348", "You will place a weight on the scales. The pain is temporary.", "汝将加一权于衡。痛暂耳。");
            // 你要是觉得有必要，可以拿它剪碎我的一张卡牌。
            AddTranslation("SCISSORS_DESCRIPTION_702_M", "If you deem it necessary, you may cut up one of my cards with these.", "若汝以为宜，可以此剪朕一牌。");
            // 剪刀
            AddTranslation("SCISSORS_RULEBOOKNAME_148", "Scissors", "剪");
            // 可用于剪掉对手的一张卡牌。彻底剪碎。
            AddTranslation("SCISSORS_RULEBOOKDESCRIPTION_775", "You may cut up one of your adversary's cards. It is destroyed.", "可以此剪敌一牌；其即毁。");
            // 给你在牌桌上的机器人装备纳米铠甲。相当实用。
            AddTranslation("SHIELDGENERATOR_DESCRIPTION_813_M", "Gives Nano Armor to your bots on the board. Decent.", "使卿局上诸机人得微铠。可也。");
            // 纳米铠甲生成器
            AddTranslation("SHIELDGENERATOR_RULEBOOKNAME_283", "Nano Armor Generator", "微铠机枢");
            // 你在牌桌上的机器人都会获得纳米铠甲。妥善使用的话能有奇效。
            AddTranslation("SHIELDGENERATOR_RULEBOOKDESCRIPTION_002", "Your bots on the board get Nano Armor. If you use it right it's decently OK.", "乃局上诸机人皆得微铠。用之得其宜，则可。");
            // 特制匕首
            AddTranslation("SPECIALDAGGER_RULEBOOKNAME_566", "Special Dagger", "特匕");
            // 你发现了一只被困在瓶子里的松鼠。如遇紧急情况可破瓶使用。
            AddTranslation("SQUIRRELBOTTLE_DESCRIPTION_443_M", "You found a Squirrel in a bottle. Break in case of emergency.", "汝得一瓶中松鼠。急则破之。");
            // 瓶中松鼠
            AddTranslation("SQUIRRELBOTTLE_RULEBOOKNAME_438", "Squirrel In A Bottle", "瓶中松鼠");
            // 你的手牌里会出现一张松鼠牌。[define:Squirrel]
            AddTranslation("SQUIRRELBOTTLE_RULEBOOKDESCRIPTION_078", "A Squirrel is created in your hand. [define:Squirrel]", "于手生一松鼠。[define:Squirrel]");
            // 坚固的磐石有时能帮你纾困。
            AddTranslation("TERRAINBOTTLE_DESCRIPTION_140_M", "A rock may get you out of a hard place.", "磐或能济尔于急。");
            // 瓶中磐石
            AddTranslation("TERRAINBOTTLE_RULEBOOKNAME_622", "Boulder In A Bottle", "瓶中磐");
            // 你的手牌里会出现一张磐石牌。[define:Boulder]
            AddTranslation("TERRAINBOTTLE_RULEBOOKDESCRIPTION_507", "A Boulder is created in your hand. [define:Boulder]", "于手生一磐。[define:Boulder]");
            // 除颤仪也故障了。
            AddTranslation("TOMB1_BOTTOM_DESCRIPTIONLINE1_821", "The defibrillator failed.", "电苏器败矣。");
            // 被落冰击中。
            AddTranslation("TOMB1_MIDDLE_DESCRIPTIONLINE1_598", "Hit by a falling piece of ice.", "为坠冰所中。");
            // 凯茜·霍布斯
            AddTranslation("TOMB1_TOP_DESCRIPTIONLINE1_995", "Kaycee Hobbes", "凯茜·霍布斯");
            // 1970年 - 1992年冬
            AddTranslation("TOMB1_TOP_DESCRIPTIONLINE2_220", "1970 - Winter 1992", "1970年—1992年冬");
            // 当时无药可医。
            AddTranslation("TOMB2_BOTTOM_DESCRIPTIONLINE1_698", "There was no cure.", "无药可疗。");
            // 死于坏血病。
            AddTranslation("TOMB2_MIDDLE_DESCRIPTIONLINE1_120", "Brought down by scurvy.", "殒于败血。");
            // 罗亚尔·多米尼格斯
            AddTranslation("TOMB2_TOP_DESCRIPTIONLINE1_271", "Royal Dominguez", "罗亚尔·多明格斯");
            // 1589年 - 1632年春
            AddTranslation("TOMB2_TOP_DESCRIPTIONLINE2_283", "1589 - Spring 1632", "1589年—1632年春");
            // 向来以德服人，从不心存怨恨。
            AddTranslation("TOMB3_BOTTOM_DESCRIPTIONLINE1_045", "Does not hold a grudge.", "无宿怨。");
            // 被饿犬分食。
            AddTranslation("TOMB3_MIDDLE_DESCRIPTIONLINE1_978", "Eaten by a hungry dog.", "为饥犬所食。");
            // 索耶·帕特尔
            AddTranslation("TOMB3_TOP_DESCRIPTIONLINE1_904", "Sawyer Patel", "索耶·帕特尔");
            // 1702年 - 1778年秋
            AddTranslation("TOMB3_TOP_DESCRIPTIONLINE2_812", "1702 - Fall 1778", "1702年—1778年秋");
            // 机托邦东部
            AddTranslation("EASTNEUTRALPATH_DISPLAYEDNAME_292", "Eastern Botopia", "机托邦东境");
            // 恶臭死水
            AddTranslation("NATUREAREA_01_DISPLAYEDNAME_083", "Foul Backwater", "秽潴");
            // 遗产木屋
            AddTranslation("NATUREAREA_02_DISPLAYEDNAME_991", "Heritage Cabin", "遗庐");
            // 机托邦中部
            AddTranslation("NORTHNEUTRALPATH_DISPLAYEDNAME_776", "Central Botopia", "机托邦中境");
            // 机托邦北部
            AddTranslation("STARTINGAREA_DISPLAYEDNAME_735", "Northern Botopia", "机托邦北境");
            // 辉光堡垒
            AddTranslation("TECHAREA_01_DISPLAYEDNAME_078", "Resplendent Bastion", "辉垒");
            // 通信塔
            AddTranslation("TECHAREA_02_DISPLAYEDNAME_361", "Telegrapher Tower", "报讯塔");
            // 污秽尸界
            AddTranslation("UNDEADAREA_01_DISPLAYEDNAME_439", "Filthy Corpse World", "秽尸界");
            // 潮湿墓穴
            AddTranslation("UNDEADAREA_02_DISPLAYEDNAME_187", "Dank Crypt", "阴湿冢");
            // 机托邦西部
            AddTranslation("WESTNEUTRALPATH_DISPLAYEDNAME_988", "Western Botopia", "机托邦西境");
            // 花哨宝石城
            AddTranslation("WIZARDAREA_01_DISPLAYEDNAME_415", "Gaudy Gem Land", "炫玉境");
            // 脆弱之塔
            AddTranslation("WIZARDAREA_02_DISPLAYEDNAME_876", "Rickety Tower", "危塔");
            // 蚂蚁
            AddTranslation("ANTSSTATICON_RULEBOOKNAME_131", "Ants", "蚁");
            // 该印记代表的数值等于持牌人侧牌桌上存在的蚂蚁数量。
            AddTranslation("ANTSSTATICON_RULEBOOKDESCRIPTION_853", "The value represented with this sigil will be equal to the number of Ants that the owner has on their side of the table.", "此印所指之值，如持牌者案上此侧之蚁数。");
            // [creature]的力量等于持牌人侧牌桌上存在的蚂蚁数量。
            AddTranslation("ANTSSTATICON_GBCDESCRIPTION_267", "The power of [creature] is equal to the number of Ants that the owner has on their side of the table.", "[creature]之威，如持牌者案上此侧之蚁数。");
            // 摇铃人
            AddTranslation("BELLSTATICON_RULEBOOKNAME_430", "Bell Ringer", "鸣铃者");
            // 该印记代表的数值永远等于4减去带有印记的造物与换手铃之间的距离。
            AddTranslation("BELLSTATICON_RULEBOOKDESCRIPTION_233", "The value represented by this sigil is always equal to 4 minus the distance of the creature bearing it to the combat bell.", "此印所指之值，恒如四减负此印契之物至战铃之距。");
            // 半根骨头
            AddTranslation("BONESSTATICON_RULEBOOKNAME_611", "One Half Bones", "半骨");
            // 该印记代表的数值等于带有印记造物的持牌人持有的骨币数的一半。
            AddTranslation("BONESSTATICON_RULEBOOKDESCRIPTION_811", "The value represented with this sigil will be equal to half the number of Bone Tokens owned by the owner of the creature with this sigil.", "此印所指之值，如负此印契之物之持牌者所有骨筹之半。");
            // 绿宝石力量
            AddTranslation("GREENGEMSSTATICON_RULEBOOKNAME_089", "Emerald Power", "绿玉威");
            // [creature]的力量等于持牌人侧牌桌上存在的绿宝石数量。
            AddTranslation("GREENGEMSSTATICON_GBCDESCRIPTION_867", "The power of [creature] is equal to the number of Green Gems that the owner has on their side of the table.", "[creature]之威，如案上持牌者之侧绿玉之数。");
            // 镜子子镜
            AddTranslation("MIRRORSTATICON_RULEBOOKNAME_625", "M!rror r0rriM", "镜!象0象i镜");
            // 该印记代表的力量和生命永远等于带有印记的造物对面造物的对应数值。
            AddTranslation("MIRRORSTATICON_RULEBOOKDESCRIPTION_012", "The power and toughness represented by these sigils is always equal to that of the creature opposing the creature bearing these symbols.", "此诸印所指之威与命，恒如负此印契之物之对物。");
            // 哎我操
            AddTranslation("SUBS_BLOOPER_LINE_567", "Oh shit.", "糟了。");
            // 有人来了 
            AddTranslation("SUBS_BREAK_IN_LINE_929", "Someone is here. ", "有人至。");
            // 妈的
            AddTranslation("SUBS_BREAK_IN_LINE_155", "Fuck this.", "狗日的。");
            // 我手机在隔壁呢 所以
            AddTranslation("SUBS_BREAK_IN_LINE_903", "My phone's in the other room, so,", "余电话在他室，故，");
            // 如果我来不及报警就死了
            AddTranslation("SUBS_BREAK_IN_LINE_383", "if I die before I can call 9-1-1,", "若余未及呼911而死，");
            // 这个录像就是证据
            AddTranslation("SUBS_BREAK_IN_LINE_083", "use this tape as evidence.", "可以此带为证。");
            // 这年头谁还用软驱啊
            AddTranslation("SUBS_BUY_FLOPPY_DRIVE_LINE_434", "Who even has a floppy disk drive any more?", "今谁复有软驱哉？");
            // 行吧 11块钱
            AddTranslation("SUBS_BUY_FLOPPY_DRIVE_LINE_099", "Okay, 11 bucks.", "善，十一元。");
            // 倒是比一张蒸汽机器人威利的闪卡便宜
            AddTranslation("SUBS_BUY_FLOPPY_DRIVE_LINE_016", "Cheaper than a foil Steambot Willie.", "犹贱于闪箔蒸机人威利。");
            // 行吧 买了
            AddTranslation("SUBS_BUY_FLOPPY_DRIVE_LINE_707", "Alright. Fine.", "善，买之。");
            // 哇哦 这视频真不赖
            AddTranslation("SUBS_BUY_FLOPPY_DRIVE_LINE_687", "Wow. Great video.", "噫，善影也。");
            // 这信不发送都对不起自己
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_085", "I think I've just got to send it.", "余思终当发之。");
            // 敬启者
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_972", "To whom it may concern.", "敬启者。");
            // 可能有点儿太正式了
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_779", "It's a bit formal.", "稍斯文矣。");
            // 您好呀 感叹号
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_189", "Hello there. Exclamation point.", "汝安。叹号。");
            // 我叫卢克·卡德 是贵司
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_366", "My name is Luke Carder and I'm a fan of", "余名卢克·卡德，乃");
            // 收集类卡牌游戏的粉丝
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_334", "your collectible card games. If you've", "贵司集换卡戏之好者。若");
            // 如果您有机会看过我的油管视频
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_733", "ever taken a look at my youtube videos", "汝尝观余油管影录，");
            // 便会了解我多么感谢数年来
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_974", "you will know how appreciative I am of", "则知余何等感荷");
            // 贵司一直在给我寄送商品
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_347", "the merch that you've sent me over the years.", "贵司数年来所寄诸货。");
            // 因此当我得知Inscryption这款游戏
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_753", "So it was a great surprise to learn that", "故闻此事，大惊焉：");
            // 存在数字版时我真的喜出望外
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_477", "there is a digital version of Inscryption.", "《冥锲》竟有数字之本。");
            // 我隐约觉得是我的粉丝在恶搞我
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_150", "I think maybe one of my fans pranked me", "余疑或有一粉余者嬉我，");
            // 在我家附近树林里埋了一份这个游戏
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_801", "and buried a copy in the woods near my house.", "埋此本于舍旁林中。");
            // 但我进一步深入调查后却发现
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_537", "Upon further research, however, I have not", "然更考之后，余未能");
            // 根本找不到这游戏存在过的踪迹
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_122", "been able to find any record of this game.", "得此戏一切旧录。");
            // 这是一场精心策划的大型恶搞吗
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_682", "Is this some kind of elaborate hoax?", "此岂大设之诳局乎？");
            // 一丁点蛛丝马迹都没有 这是一场
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_968", "Any trace of this game. Is this some kind", "此戏竟无寸迹。此岂");
            // 精心策划的大型恶搞吗 这游戏可不像是
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_904", "of elaborate hoax? The game doesn't seem", "大设之诳局乎？此戏不似");
            // 做来恶搞别人的游戏 至少看起来
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_468", "like the work of a prankster. It at least", "出于嬉人之手；至少");
            // 是出自专业人士之手
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_860", "appears professionally made.", "颇似专业者所为。");
            // 我现在可真是既困惑又兴奋
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_018", "I am both puzzled and excited by this", "余于此发现，既惑且喜。");
            // 如您有任何更多信息
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_370", "discovery. Any information you can", "汝所能示一切之消息，");
            // 能够提供给我 我都感激不尽
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_520", "provide would be much appreciated.", "余皆深感之。");
            // 谢谢 幸运卡神敬上
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_137", "Thank you. The Lucky Carder.", "谨谢。幸运卡德上。");
            // 行 够看的了
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_660", "Okay good enough.", "善，足矣。");
            // 走你
            AddTranslation("SUBS_EMAIL_DRAFTING_LINE_839", "Sent.", "已发。");
            // 致卡德先生 您关于我司名下
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_160", "Mr. Carder. We have received your enquiry", "卡德先生。尔所询函，");
            // 知识产权Inscryption是否存在数字版
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_468", "regarding a digital version", "所问数字之本，");
            // 一事的询问函已收悉
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_119", "of our intellectual property Inscryption.", "关乎我司产权《冥锲》，今已收悉。");
            // 我司在此向您保证该软件
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_662", "We can assure you that no such software exists", "我司敢保，此等软件并无");
            // 并不存在 更无官方版本 但是
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_130", "in any official form. However, if you have", "任何官本。然若尔果");
            // 如您确实持有孚纳游戏公司产权保护的
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_340", "indeed come into possession of proprietary GameFuna", "得孚纳戏社专有之");
            // 硬件设备 您需立即将其归还我司
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_705", "hardware you are compelled to return it to", "硬件，则尔当即归之我司");
            // 以免违反计算机诈骗和滥用法
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_332", "us under The Computer Fraud and Abuse Act.", "依《计算机诈骗与滥用法》。");
            // 如该硬件设备
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_505", "The hardware will be considered", "彼硬件若");
            // 未在合理时间内归还我司
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_172", "stolen if it is not returned to us", "不于合理期内归我司，");
            // 则将被视作失窃
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_044", "within a reasonable time frame.", "则视为失窃。");
            // 请妥善打包该设备 并将附件中
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_813", "Please carefully package the hardware and paste", "请谨裹其硬件，并贴");
            // 邮寄信息粘贴于包装盒正面
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_055", "the attached shipping label to the front of the box.", "所附邮签于箱前。");
            // 您可于您所在地邮政局将包裹寄出
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_114", "You may mail the package at a local post office.", "可就近邮局寄此包。");
            // 我司不希望动用
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_145", "We would like to avoid taking", "我司欲免");
            // 任何法律举措
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_032", "legal action", "动法，");
            // 出于对您的保护 因此请尽快
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_003", "in your case so please do not delay in", "于尔一事，故请毋缓于");
            // 归还涉事硬件设备
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_304", "returning the proprietary software.", "归此专有软件。");
            // 此致敬礼 孚纳游戏客户至上部
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_280", "Sincerely, GameFuna Customer Happiness Department.", "谨启，孚纳戏社悦客部署。");
            // 这他妈
            AddTranslation("SUBS_EMAIL_RESPONSE_LINE_810", "What the fuck.", "他娘的。");
            // 我感觉这姐们就是
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_599", "I think this woman's actually from", "余疑此妇实自");
            // 孚纳游戏派来的 昨天她就来过一次
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_444", "GameFuna. She came to my door yesterday", "孚纳戏社来。昨来叩我门，");
            // 敲门来着 我没搭理她
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_598", "and I didn't answer.", "而余不应。");
            // 这次我得录像了
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_239", "This time I'm going to record it.", "今番余将录之。");
            // 您好
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_926", "Hi.", "汝安。");
            // 您好
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_278", "Hi there.", "汝安。");
            // 我是011000010110110101100001011011100110010001100001
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_979", "I'm 011000010110110101100001011011100110010001100001", "余乃011000010110110101100001011011100110010001100001");
            // 游戏的软盘
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_236", "-floppy disk for a game", "—某戏之软盘");
            // 游戏名叫Inscryption
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_656", "called Inscryption.", "名《冥锲》。");
            // 有人说你不知怎么就拿到了一份
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_380", "I was told you came by a copy of it somehow.", "余闻尔不知何以得其一。");
            // 听说过吗
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_599", "Sound familiar?", "似曾闻乎？");
            // 没有 没有没有
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_203", "No, no I don't know", "不，不，余不知");
            // 我对此毫不知情
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_023", "anything about that.", "此事毫无所知。");
            // 叫Inscryption是吧 没有
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_866", "Inscryption you said? No I don't", "汝言《冥锲》乎？余未");
            // 真没听说过
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_789", "think so.", "尝闻也。");
            // 你确定 因为很显然
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_536", "Really? Because apparently you", "然乎？然闻尔");
            // 你还给我们写了封邮件说了这事
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_991", "emailed us about it. You are", "尝以书问我司。尔乃");
            // 你是叫卢克·卡德对吧
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_756", "Luke Carder right? You know", "卢克·卡德乎？汝知");
            // 听说过luckycarder@gmail.com这个邮箱地址没
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_989", "the lucky carder at gmail.com?", "luckycarder@gmail.com乎？");
            // 对 啊 那什么
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_515", "Yeah, uh, you", "然，呃，尔");
            // 那个……
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_591", "know what? That's, uh...", "知否？那，呃……");
            // 我本人的确叫卢克·卡德 但那个不是我邮箱
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_580", "I am Luke Carder but that's not my email address.", "余诚卢克·卡德，然彼非我邮址。");
            // 确定吗
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_244", "Really? Because", "然乎？然");
            // 我是因为平时有看你视频才知道的
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_574", "I just know it is because I've seen your", "余知其是，以余尝观尔");
            // 我是你粉丝
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_606", "videos. I'm a big fan.", "影录；余甚好尔。");
            // 谢谢观看啊
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_465", "Thanks for watching.", "谢尔观之。");
            // 先等一下 那个 你是怎么知道我的
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_153", "Listen, uh, how do you know where I live", "请听，呃，尔何以知");
            // 具体住址的
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_968", "exactly?", "余所居之地？");
            // 我领导告诉我的
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_402", "My boss gave me your address.", "余上有司以尔居址授我。");
            // 那我的侧门你是怎么破开的
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_127", "And how did you get past the side gate?", "又汝何以过侧门？");
            // 我都锁着呢
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_091", "It's locked.", "彼既扃。");
            // 行了卢克
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_434", "Okay Luke,", "止此，卢克，");
            // 我现在把我名片留给你
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_587", "I'm going to give you my business card.", "余将以余名刺授尔。");
            // 你要是想起来什么
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_881", "And if you remember", "若汝忆起");
            // 任何鸡毛蒜皮的事 你可以随时
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_835", "anything, anything at all, feel free give", "寸事片事，皆可");
            // 打电话给我 好吗
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_325", "me a call, okay?", "来电于我，可乎？");
            // 没问题
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_466", "Will do.", "诺。");
            // 保重
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_505", "Take care.", "自重。");
            // 尼玛什么鬼
            AddTranslation("SUBS_EMPLOYEE_VISIT_LINE_896", "What the fuck?", "他娘的，何也？");
            // 好嘞 伙计们
            AddTranslation("SUBS_FOREST_1_LINE_865", "Alright, you guys.", "善，诸君。");
            // 我现在算是意气风发 春风得意
            AddTranslation("SUBS_FOREST_1_LINE_762", "I'm out here living my best life.", "余今在外，快意无比。");
            // 在我手边的是忠实可靠的头灯和铲子
            AddTranslation("SUBS_FOREST_1_LINE_746", "Got my trusty headlamp and shovel.", "余之额灯与铲俱在。");
            // 小朋友们 做事一定要准备万全 好啦
            AddTranslation("SUBS_FOREST_1_LINE_544", "Always come prepared kids. Alright.", "诸童，常当有备乎。善。");
            // 走起走起。
            AddTranslation("SUBS_FOREST_1_LINE_250", "Here we go.", "行矣。");
            // 不错 挺好的
            AddTranslation("SUBS_FOREST_1_LINE_691", "Yeah. Okay.", "然。可。");
            // 唔 越来越近了
            AddTranslation("SUBS_FOREST_1_LINE_313", "Woo. Getting close.", "噫，近矣。");
            // 感觉上啊 前提是
            AddTranslation("SUBS_FOREST_1_LINE_582", "I think. Assuming there is", "余以为然。苟其果有");
            // 得有个东西在那等我靠近
            AddTranslation("SUBS_FOREST_1_LINE_400", "a thing to get close to.", "一物可近焉。");
            // 这一切很有可能到头来
            AddTranslation("SUBS_FOREST_1_LINE_278", "This very well may be a massive", "此恐终为大");
            // 只是白费功夫
            AddTranslation("SUBS_FOREST_1_LINE_613", "waste of", "费耳。");
            // 哎
            AddTranslation("SUBS_FOREST_2_LINE_104", "Alright.", "善。");
            // 这就是为什么
            AddTranslation("SUBS_FOREST_2_LINE_560", "That's why", "是故，");
            // 一定要多备一套电池
            AddTranslation("SUBS_FOREST_2_LINE_591", "you always bring an extra battery,", "诸童，常当携一，");
            // 小朋友们记住了吗
            AddTranslation("SUBS_FOREST_2_LINE_337", "boys and girls.", "副电匣。");
            // 无论何时
            AddTranslation("SUBS_FOREST_2_LINE_225", "Every time.", "每行皆然。");
            // 一定要准备万全
            AddTranslation("SUBS_FOREST_2_LINE_439", "You gotta come prepared.", "必有备而来。");
            // 好了
            AddTranslation("SUBS_FOREST_2_LINE_767", "Okay.", "可。");
            // 就是这儿了
            AddTranslation("SUBS_FOREST_2_LINE_803", "This is it.", "即此矣。");
            // 现在
            AddTranslation("SUBS_FOREST_2_LINE_051", "And now,", "而今，");
            // 动手挖吧
            AddTranslation("SUBS_FOREST_2_LINE_690", "we dig.", "今掘之。");
            // 我感觉这下面八成是块石头
            AddTranslation("SUBS_FOREST_2_LINE_470", "I give a 75 percent chance it's a rock.", "余料七成五，只是一磐。");
            // 但只有一种方法能确认
            AddTranslation("SUBS_FOREST_2_LINE_068", "But, only one way to find out.", "然欲知之，唯此一途。");
            // 这尼玛
            AddTranslation("SUBS_FOREST_2_LINE_288", "What the fuck", "他娘的，");
            // 什么玩意
            AddTranslation("SUBS_FOREST_2_LINE_618", "is that?", "是何物？");
            // 我的天啊 伙计们
            AddTranslation("SUBS_FOREST_2_LINE_317", "Oh my god, you guys", "天乎，诸君，");
            // 我真不敢相信
            AddTranslation("SUBS_FOREST_2_LINE_804", "I can't believe it.", "余不敢信。");
            // 这下面居然真有东西
            AddTranslation("SUBS_FOREST_2_LINE_596", "There's actually something here.", "此间竟真有物。");
            // 能是什么呢
            AddTranslation("SUBS_FOREST_2_LINE_600", "What is it?", "是何物？");
            // 什么玩意
            AddTranslation("SUBS_FOREST_2_LINE_566", "What?", "何？");
            // 朋友们 你们看到这个了吗
            AddTranslation("SUBS_FOREST_2_LINE_665", "Guys, are you seeing this?", "诸君见此乎？");
            // 我有点
            AddTranslation("SUBS_FOREST_2_LINE_205", "I'm, uh", "余，呃，");
            // 我怎么有点迷糊了呢
            AddTranslation("SUBS_FOREST_2_LINE_783", "I'm a little confused.", "稍有惑矣。");
            // 各位卡牌粉 大家好啊
            AddTranslation("SUBS_GARAGE_SALE_LINE_826", "Well hello there card gamers!", "诸卡戏者，安乎！");
            // 看样子我在二手市场海淘的日子
            AddTranslation("SUBS_GARAGE_SALE_LINE_652", "Looks like my garage sale hunting days", "余猎车库贱售之日，似");
            // 终于有点收获了
            AddTranslation("SUBS_GARAGE_SALE_LINE_199", "have finally paid off.", "终有报矣。");
            // 是的没错家人们
            AddTranslation("SUBS_GARAGE_SALE_LINE_682", "Yeah. Yeah baby.", "然。妙哉。");
            // 看看我淘到了什么好宝贝
            AddTranslation("SUBS_GARAGE_SALE_LINE_632", "Wait til you guys see this.", "且待诸君见此。");
            // 知道这是啥吗 知不知道这是啥
            AddTranslation("SUBS_GARAGE_SALE_LINE_029", "You know what that is? You know what that is?", "知此为何物乎？知此为何物乎？");
            // 典藏卡包
            AddTranslation("SUBS_GARAGE_SALE_LINE_288", "Vintage packs", "古牌韬");
            // Inscryption的卡 一共四包 不知道
            AddTranslation("SUBS_GARAGE_SALE_LINE_820", "of Inscryption. Four of them. I don't know", "《冥锲》之韬，凡四。余不知");
            // 卖给我的那大婶知不知道它们值多少钱
            AddTranslation("SUBS_GARAGE_SALE_LINE_106", "if the woman knew what these are worth.", "彼妇知其值几何否。");
            // 就是说 我心里还有点
            AddTranslation("SUBS_GARAGE_SALE_LINE_959", "I mean, I felt a little", "言之，余亦微");
            // 过意不去的 只花了那么点钱
            AddTranslation("SUBS_GARAGE_SALE_LINE_893", "bad buying them off of her but, I mean,", "媿于购之自彼；然，");
            // 不过她应该也不指着这糊口
            AddTranslation("SUBS_GARAGE_SALE_LINE_409", "she's probably doing", "彼大约尚能");
            // 毕竟人家住在这样的地段呢
            AddTranslation("SUBS_GARAGE_SALE_LINE_342", "okay living in this part of town.", "安居于此方。");
            // 那附近着实挺繁华的 你们知道吗
            AddTranslation("SUBS_GARAGE_SALE_LINE_168", "It's a nice part of town you know?", "此地亦佳，汝知之。");
            // 要不是我说要掏钱买 她都有可能
            AddTranslation("SUBS_GARAGE_SALE_LINE_394", "She would have thrown them away if I", "若余不至，彼几将");
            // 直接扔了 对不对 行啦 准备好
            AddTranslation("SUBS_GARAGE_SALE_LINE_868", "hadn't come by, right? Right. Okay.", "弃之，不亦然乎？然。可。");
            // 开包视频 热辣新鲜出炉
            AddTranslation("SUBS_GARAGE_SALE_LINE_540", "Big pack opening video incoming.", "大开韬影将至。");
            // 好 终于可以看看这里头有点什么了
            AddTranslation("SUBS_INSERTING_DISK_LINE_602", "Okay. Time to figure out what's on this thing.", "善。当究此物中何有。");
            // 现在就是真相大白的时刻
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_914", "Time to get to the bottom of this.", "当穷此事之底。");
            // 喂 您好
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_639", "Hello. Hi.", "喂。汝安。");
            // 您好 请问是霍布斯太太吗
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_116", "Hello is this Mrs. Hobbes?", "喂，霍布斯夫人乎？");
            // 您好 我叫卢克·卡德
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_537", "Hi, my name is Luke.", "汝安，余名卢克。");
            // 嗯嗯 我也很高兴与您通话
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_671", "Well it's very nice to speak with you as", "得与汝语，余亦甚喜，");
            // 霍布斯太太
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_870", "well Mrs. Hobbes.", "霍布斯夫人。");
            // 是这样 那天我去了您家的
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_726", "Listen, I was at your garage sale the", "请听。前日余至乃车库贱售，");
            // 二手货摊 然后我……
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_362", "other day and I-", "而余—");
            // 没事没事 我这边没事 谢谢您
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_918", "No, no, everything's fine. Thank you.", "不，不，皆安。谢矣。");
            // 我只是想问问您 能不能回忆起什么
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_728", "I was just wondering if you remember", "余但欲问，汝尚忆");
            // 关于您卖给我的游戏卡牌的事情
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_050", "those playing cards that you sold me", "所鬻于我之牌乎？");
            // 就那些……
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_081", "Those-", "即彼—");
            // 对的 没错 就是那些 叫Inscryption 没错
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_278", "Yes. Yes. Those ones. Inscryption. Yes.", "然。然。即彼。《冥锲》。然。");
            // 是您女儿的吗
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_748", "They were your daughter's?", "彼乃女之物乎？");
            // 那请问可不可以让我跟她
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_705", "Would it be possible for me to speak", "可使余得与之");
            // 通个话
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_065", "with her?", "语乎？");
            // “不在了”指的是她……
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_262", "She passed as in she-", "言其殁者，是其—");
            // 噢 哎呀 不好意思
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_259", "Oh. Oh no. I'm so", "噫。噫，余甚");
            // 我很遗憾 哦 不是最近的事吗
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_053", "sorry. Oh, it was a while ago?", "歉。其已久乎？");
            // 那也很不幸了
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_506", "That's still terrible.", "虽久，犹惨。");
            // 啊我这边都是小事
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_155", "Oh it's nothing really.", "噫，余此间不足道耳。");
            // 很抱歉给您添麻烦了 夫人
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_416", "I'm sorry to have bothered you ma'am.", "扰夫人矣，余甚歉。");
            // 她叫凯茜是吧 名字真好听
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_806", "Her name was Kaycee? That's a lovely name.", "其名凯茜乎？美名也。");
            // 不好意思 您说啥 Inscryption
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_249", "Sorry, what? She worked", "敢问，何谓？其为");
            // 是她的项目 您是说她是孚纳游戏员工么
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_893", "for Inscryption? I mean she worked for GameFuna?", "《冥锲》作事乎？抑为孚纳戏社役乎？");
            // 夫人 请问可不可以……
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_503", "Ma'am, would it be possible-", "夫人，可使余—");
            // 喔 好的 请问
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_436", "I see. Okay, do you think it'd be", "余知之。可。汝以为可乎，");
            // 我回头还能再打给您吗
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_973", "alright if I called you back later?", "若余后更致电？");
            // 我现在有点事一定要搞清楚
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_906", "I'm just trying to get to the bottom of something.", "余但欲穷一事之底耳。");
            // 好的 好的 十分感谢您
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_176", "Okay, okay. Thank you so much.", "可，可。厚谢。");
            // 好的 没问题 祝您晚餐愉快 再见
            AddTranslation("SUBS_LONG_NIGHT_1_LINE_939", "Okay, alright. Have a good dinner. Bye.", "可。善。愿汝飧安。别矣。");
            // 从没有哪篇文章提到过有人死掉或者受伤啊
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_362", "None of these articles mention death or injury.", "此诸篇皆不及死伤。");
            // 我的老天爷
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_205", "Oh my god.", "天乎。");
            // 当日在设施内无人死于谋杀
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_238", "No one was killed at the facility", "彼所无人见杀，");
            // 但十分不幸的是年轻的电子游戏开发者 
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_668", "though tragically young video game ", "然年少电戏");
            // 凯茜·霍布斯却丧命于
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_726", "developer Kaycee Hobbes died", "制者凯茜·霍布斯");
            // 一场火灾之中
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_774", "from fire related complications.", "殁于火患之变。");
            // 妈的
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_881", "Fuck.", "他娘的。");
            // 她当天在单位加班加点
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_760", "She was working late at the facility", "其时夜作于彼所，");
            // 为游戏进行质量检测
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_632", "performing quality assurance on behalf", "代其主行质验，");
            // 因其受雇于孚纳游戏公司
            AddTranslation("SUBS_LONG_NIGHT_2_LINE_492", "of her employer GameFuna.", "即孚纳戏社。");
            // 嘿卢克 我是先驱报的赫尔曼
            AddTranslation("SUBS_LUKE_MURDERED_LINE_343", "Hey Luke, this is Herman from The Herald.", "卢克，余《先驱报》赫尔曼也。");
            // 我是来跟进一条
            AddTranslation("SUBS_LUKE_MURDERED_LINE_363", "Just following up after the message you", "今来续问汝");
            // 今早你给我发的留言
            AddTranslation("SUBS_LUKE_MURDERED_LINE_263", "left me this morning.", "今晨所遗之言。");
            // 现在方便谈谈吗
            AddTranslation("SUBS_LUKE_MURDERED_LINE_584", "Do you have time to talk right now?", "今可与语乎？");
            // 方便 方便 十分感谢您
            AddTranslation("SUBS_LUKE_MURDERED_LINE_539", "Yes. Yes, thank you so much for getting back", "然。然，厚谢汝");
            // 特意打回来
            AddTranslation("SUBS_LUKE_MURDERED_LINE_842", "to me.", "来复于我。");
            // 没事没事 卢克 是这样 如果我没理解错
            AddTranslation("SUBS_LUKE_MURDERED_LINE_921", "No problem Luke. Um, if I understand you", "无伤，卢克。呃，若余所解不误，");
            // 现在你手上有一些视频证据
            AddTranslation("SUBS_LUKE_MURDERED_LINE_915", "correctly you've got some video footage.", "汝手有数段影录。");
            // 能够曝光 怎么说
            AddTranslation("SUBS_LUKE_MURDERED_LINE_023", "that might expose, uh,", "足以暴，呃，");
            // 游戏发行商孚纳游戏公司的
            AddTranslation("SUBS_LUKE_MURDERED_LINE_558", "some malpractice on the part of, uh,", "其戏商孚纳戏社所行之");
            // 一些非法行为么
            AddTranslation("SUBS_LUKE_MURDERED_LINE_120", "game publisher GameFuna?", "不法乎？");
            // 是的 是的没错 我手头……
            AddTranslation("SUBS_LUKE_MURDERED_LINE_771", "Yes. Yes, that's right. I have-", "然。然，是也。余有—");
            // 首先 我这有他们的一款游戏
            AddTranslation("SUBS_LUKE_MURDERED_LINE_320", "Firstly, I have a game of theirs that took", "始者，余有其一戏，尝夺");
            // 那游戏曾经把我的电脑控制了一段时间
            AddTranslation("SUBS_LUKE_MURDERED_LINE_473", "control my PC for a bit", "余机之制于须臾，");
            // 这铁定不合法 然后还有个他们公司的
            AddTranslation("SUBS_LUKE_MURDERED_LINE_123", "which can't be legal. And then this woman", "此必不法。又其司一妇");
            // 女员工 直接到我家里来了
            AddTranslation("SUBS_LUKE_MURDERED_LINE_555", "from the company came to my house.", "来余家。");
            // 好的 你先稍等 我拿下笔和纸
            AddTranslation("SUBS_LUKE_MURDERED_LINE_361", "Okay, hold on a second. Let me just get my pen and pad", "可，少待。余取笔札。");
            // 好了
            AddTranslation("SUBS_LUKE_MURDERED_LINE_235", "here. Okay.", "可。");
            // 呃 所以你有他们的一款游戏
            AddTranslation("SUBS_LUKE_MURDERED_LINE_551", "Uh, okay, so you have a game of theirs", "呃，可，则汝有其一戏");
            // 还控制了……
            AddTranslation("SUBS_LUKE_MURDERED_LINE_710", "that took-", "曾夺—");
            // 是中毒了吗还是怎样
            AddTranslation("SUBS_LUKE_MURDERED_LINE_168", "Uh, was it a virus or something?", "呃，是毒乎，抑他物？");
            // 你开玩笑呢吧
            AddTranslation("SUBS_LUKE_MURDERED_LINE_782", "You can't be serious.", "汝非戏言乎？");
            // 我不是说了……
            AddTranslation("SUBS_LUKE_MURDERED_LINE_672", "I told you-", "余既告汝—");
            // 各位卡牌粉 大家好
            AddTranslation("SUBS_NOT_NORMAL_LINE_049", "Hey there card gamers.", "诸卡戏者，安乎。");
            // 我是你们的幸运卡神 欢迎大家收看
            AddTranslation("SUBS_NOT_NORMAL_LINE_352", "I'm The Lucky Carder and this is another", "余幸运卡德也，此又一");
            // 我的卡牌开包视频
            AddTranslation("SUBS_NOT_NORMAL_LINE_432", "pack opening video.", "开韬影也。");
            // 今天我为大家开包的卡牌来自游戏传奇大陆之谜
            AddTranslation("SUBS_NOT_NORMAL_LINE_928", "Today I'm opening Secrets of Legendaria.", "今余启《传奇大陆之秘》。");
            // 希望能开出一张羡煞旁人的瓦拉米尔闪卡
            AddTranslation("SUBS_NOT_NORMAL_LINE_691", "Hoping for that sweet, sweet, foil Vallamir.", "但冀得闪箔瓦拉米尔耳。");
            // 我做不到
            AddTranslation("SUBS_NOT_NORMAL_LINE_075", "I can't do this.", "余不能为此。");
            // 各位卡牌粉 我是幸运卡神 欢迎大家收看……
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_450", "Hey Card Gamers. I'm The Lucky Carder and this-", "诸卡戏者，安。余幸运卡德也，而此—");
            // 唔 其实这条视频挺奇怪的
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_797", "Well it's a bit of a strange video.", "此影稍奇。");
            // 可以算是我向大家提出的
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_514", "It's actually more of a question", "实乃向诸观者");
            // 一个问题 因为我从过去几年的经历中
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_375", "to my audience. As I've learned over the", "一问。余积年所知，");
            // 认识到没有人比你们
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_751", "years, nobody knows card games", "知卡戏者");
            // 更懂卡牌游戏 所以我希望
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_496", "better than you guys do. So I'm hoping", "莫逾诸君。故余冀");
            // 能有人帮我解答一下困惑
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_852", "someone can help me out here.", "或有人能解我惑。");
            // 你们有没有人玩过一款叫Inscryption的电子游戏
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_548", "Did anyone ever play an Inscryption video game?", "尝有玩《冥锲》电戏者乎？");
            // 听说过也行 我说的是
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_303", "Or hear about it? I'm talking about", "或闻之乎？余谓");
            // 之前开包过的那套古早典藏游戏卡牌
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_740", "that vintage one set card game I opened", "上周余所启韬之彼");
            // 上周开的
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_249", "packs for last week.", "古卡戏也。");
            // 我不知道法律允许我说到哪个程度
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_738", "I don't know what I'm allowed to say.", "余不知可言几何。");
            // 更不想惹火上身
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_610", "I don't want to get in any trouble here.", "亦不欲以此召祸。");
            // 但我认为我拿着的是Inscryption
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_348", "I think I've got the only known copy of", "余谓余所执者，殆为仅存之本，");
            // 唯一的一份电子版文件
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_893", "the digital version of Inscryption.", "即《冥锲》数字之本。");
            // 之前我玩的时候也录了像
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_615", "I've been filming myself playing it.", "余尝自录余戏之状。");
            // 怎么说呢
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_649", "And uh.", "而，呃，");
            // 这游戏怪怪的 朋友们
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_289", "It's weird guys.", "此戏甚怪，诸君。");
            // 我是不想因为给你们看我的试玩录像
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_135", "I don't want to get in any hot water by", "余不欲因");
            // 给自己招来什么麻烦事
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_674", "showing the footage but", "示诸君此影录而召祸；然");
            // 有人可以证明我错了吗
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_304", "can someone please prove me wrong?", "有人能证余误乎？");
            // 随便谁 来告诉我你手上还有一份这游戏
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_998", "Please tell me someone has a copy of this game.", "愿告我，有人亦有此戏一副。");
            // 我在网上找了好几天了
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_113", "I have been looking online", "余索之于网已数日，");
            // 连关于它的一个字都找不到
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_512", "for days and I cannot find a word about it.", "而不得一言及之。");
            // 我甚至联系了游戏发行商
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_211", "I reached out to the publishers", "余尝致书其戏商，");
            // 希望他们能回我句话解释一下
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_406", "hoping maybe they would get back to me", "冀其或来复于我，");
            // 但作为备选方案我还是希望各位学识渊博的粉丝们
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_912", "but as a fallback I got you beautiful viewers.", "然为后计，尚赖诸善观者。");
            // 能不能帮我去挖掘一下信息
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_576", "-can hopefully dig up something.", "庶几可掘得一二。");
            // 唔 我要说的说完了
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_632", "Um. That's it.", "呃。止此。");
            // 今天的视频就到这里 感谢大家
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_861", "That's the video today guys. Thank you", "今日之影止此，诸君。谢");
            // 长久以来的支持
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_441", "so much as always.", "汝等长久之惠。");
            // 哦对了 还有个事
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_862", "And um, oh yeah, uh.", "且，呃，噫，对，呃。");
            // 谁他妈能告诉我究竟
            AddTranslation("SUBS_QUESTION_TO_AUDIENCE_LINE_476", "What the fuck is the", "他娘的，那");
            // 各位卡牌粉 大家好 我是幸运卡神
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_552", "Hey there card gamers. I'm The Lucky", "诸卡戏者，安。余幸运");
            // 今天的视频是关于
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_365", "Carder and this is a vintage pack", "卡德也，而此乃古卡韬");
            // 典藏卡包的 今天我会为大家开包
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_101", "opening video. Today I'm opening a few", "开韬影。今余将启数");
            // 超级稀有的古早卡包
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_177", "super rare old packs I snagged at a", "极罕旧韬，皆余购自一");
            // 之前在个二手货摊上买的
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_339", "garage sale.", "车库贱售。");
            // 这里有四个Inscryption的卡包
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_325", "I've got four packs of Inscryption.", "余有《冥锲》四韬。");
            // 我当时买得多值 说出来你们都不信
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_147", "You would not believe the deal I got on", "余得此之贱，汝必不信。");
            // 好了 我估计你们可能都不记得
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_182", "these. Now not all of you will even", "今诸君未必尽");
            // 这款游戏了
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_358", "remember this game.", "忆此戏。");
            // 我本人小的时候也差点
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_766", "I'm barely old enough to have seen", "余年几不及得见");
            // 没赶上这个游戏流行的年代
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_003", "these going around in my childhood.", "其行于余之童时。");
            // 不知道因为什么 厂家就只出了一套
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_375", "For whatever reason they only did one", "不知何故，彼惟出一");
            // 游戏卡牌 然后就停产了
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_066", "set of these cards and then", "番此牌，而后");
            // 现在它的交易市场规模
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_069", "stopped printing them. There's not a huge", "不复印之。今其市不甚");
            // 也不算大
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_927", "market for them", "大也，");
            // 但考虑到我当时买下它们花的那点钱
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_296", "any more but at the rate I got them for", "然以余所得之价观之，");
            // 我也的确亏不到哪里去
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_151", "there's not really much to lose.", "实无多可失。");
            // 话虽如此 如果真开出一张螳螂神的闪卡
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_962", "That being said, a foil Mantis God goes", "虽然，闪箔螳神一张可值");
            // 也是能卖个几百块的
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_863", "for a couple hundred bucks.", "数百元。");
            // 希望有好运
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_437", "So fingers crossed.", "故惟冀其然。");
            // 卡面的画风都很酷
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_930", "Really cool art on these. Definitely", "此诸牌之画甚佳，");
            // 绝对经得起时间的考验
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_455", "stands the test of time.", "诚耐岁月。");
            // 这个卡包开出的稀有卡是蓝色法师
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_786", "And our rare for this pack is Blue Mage.", "此韬之罕牌乃蓝巫。");
            // 看着蛮酷的 但估计
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_671", "Cool looking card, but not going to be", "观甚佳，然终不");
            // 不值多少钱
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_620", "worth very much.", "值多。");
            // 好嘞 咱们看看
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_849", "Alright let's see what we got going on", "善，且视");
            // 第二包能出什么货吧
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_654", "in the second pack.", "第二韬出何物。");
            // 哼
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_347", "Huh.", "咦。");
            // 这包卡被人开过又封上了
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_546", "This pack has been opened and", "此韬已启而");
            // 希望那人没把里面的稀有卡抽走
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_224", "resealed. Hope no one snuck the rare out of it.", "复缄。愿无人潜取其中罕牌。");
            // 那就太恶心了
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_189", "That would suck.", "若然，则恶甚。");
            // 你们瞅瞅 说实在的 居然开了包又封回去
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_974", "Come on people. Honestly, who opens and", "人也，何至此？谁乃启而");
            // 这是人干的事吗
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_282", "reseals a pack.", "复缄一包乎？");
            // 哎 这张卡上有一组坐标
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_257", "Huh. There's a set of coordinates on this card.", "咦。此牌上有经纬一组。");
            // 感觉好像是后来用笔写上去的
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_390", "Looks like they were drawn on with a pen.", "似后人以笔书之。");
            // 北纬49度 西经123度
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_637", "49 degrees North 123 degrees West.", "北纬49度，西经123度。");
            // 我感觉
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_912", "I think.", "余以为然。");
            // 虽然得去核实一下但总感觉
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_533", "I'd have to check but I think that's", "虽当更校，然余以为彼");
            // 这地方离我不远
            AddTranslation("SUBS_STRANGE_INSCRIPTION_LINE_305", "pretty nearby.", "去我此甚近。");
            // 各位卡牌粉 大家好 我是幸运卡神 
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_187", "Hey there card gamers I'm The Lucky Carder ", "诸卡戏者，安。余幸运卡德也，");
            // 欢迎收看我的卡牌开包视频
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_260", "and this is another pack opening video.", "此又一开韬影。");
            // 今天我为大家开包的是怪物捕捉的卡牌包
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_631", "Today I am opening Catch Monsters", "今余启《捕怪》");
            // 希望能开出史诗级的
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_961", "packs and digging for that epic", "之牌韬，冀得彼闪箔");
            // 飞升神犬的闪卡
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_152", "shiny Transcendog.", "陟神犬也。");
            // 回头在这儿我会加上点酷炫的特效
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_881", "And here i'll add some crazy VFX with", "而此毕后余将稍加异效，");
            // 弄点闪电啊什么的
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_153", "lightning bolts or something.", "如电霆之属。");
            // 好啦女士们先生们 我现在就要
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_307", "Okay ladies and gentlemen I am about to", "诸君，余将");
            // 打开第一包卡了
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_275", "open my first pack.", "启第一韬。");
            // 手感不错哦
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_040", "Feeling good about this one.", "余觉此韬佳。");
            // 相当不错
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_254", "Feeling real good.", "诚甚佳。");
            // 看看咱开出了点啥
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_369", "What do we got here?", "此得何物？");
            // 好嘞 今天开出的第一张
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_816", "Okay and our first", "可，而今日第一张");
            // 稀有卡是桦树精
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_846", "rare is a Birchkin.", "罕牌乃桦精。");
            // 虽然不是什么很能打的卡
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_168", "Not exactly a viable competitive card", "虽非善争之牌，");
            // 但是呢
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_638", "but hey", "然");
            // 毕竟很漂亮 好啦
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_160", "it's a pretty one. Alright.", "其状甚美。可。");
            // 下一包 这包手感怎么更好了呢
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_979", "Next pack. Feeling even better about this one.", "次韬。余于此韬更甚感有佳。");
            // 我得承认 这些卡牌今天
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_813", "I gotta say these cards are feeling", "余当言，此诸牌今日触之");
            // 摸着尤其顺滑
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_867", "extra silky today.", "尤为柔滑。");
            // 我是说 真的很光滑柔顺
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_880", "I mean they're so smooth.", "言之，诚甚滑也。");
            // 不知道他们在印刷工厂
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_887", "Not sure what they're doing down there", "不知牌坊");
            // 搞了什么小花招
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_389", "at the card factory but", "何所为之，然");
            // 但握在手里感觉真的不错
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_772", "these are feeling good in my hands.", "执于我手，觉甚善。");
            // 好啦 咱们看看开出了什么
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_564", "Okay, let's see what we got here.", "可，且视此得何物。");
            // 几张废牌 我估计会挑几张
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_135", "Some jank cards. Maybe a few additions", "数废牌。或可益");
            // 放进我的Cube卡池 咱们挑挑看
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_216", "to my draft cube. We'll see.", "余之选池。且观之。");
            // 这个卡包开出的稀有卡是
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_307", "And our rare for this pack is", "此韬之异牌乃");
            // 猛烈犬 截至目前还没出好货
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_540", "Bandog. Not exactly riveting so far.", "猛犬。至此未甚惊人。");
            // 但咱们卡包有得是呢
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_303", "But we have many packs to go.", "然牌韬尚多。");
            // 下一包 走起
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_776", "Next pack here we come.", "次韬，来矣。");
            // 这段回头我掐了
            AddTranslation("SUBS_THE_LUCKY_CARDER_LINE_756", "I'll just cut out this part.", "此段毕后删之。");
            // [c:bR]智慧试炼[c:]。抽出的3张卡牌必须共计拥有至少[c:bR]3个印记[c:]方可通过。
            AddTranslation("DECKTRIALSEQUENCER_DESCRIPTION_388_M", "The [c:bR]Trial of Wisdom[c:]. The 3 drawn cards must have at least [c:bR]3 sigils[c:] among them to pass.", "[c:bR]智之试[c:]。所引三牌，须合有[c:bR]印契不下三[c:]，乃胜。");
            // [c:bR]鲜血试炼[c:]。抽出的3张卡牌必须共计消耗至少[c:bR]4点血量[c:]方可通过。
            AddTranslation("DECKTRIALSEQUENCER_DESCRIPTION_264_M", "The [c:bR]Trial of Blood[c:]. The 3 drawn cards must cost at least [c:bR]4 blood[c:] combined to pass.", "[c:bR]血之试[c:]。所引三牌，须合直[c:bR]血不下四[c:]，乃胜。");
            // [c:bR]骨头试炼[c:]。抽出的3张卡牌必须共计消耗至少[c:bR]5根骨头[c:]方可通过。
            AddTranslation("DECKTRIALSEQUENCER_DESCRIPTION_204_M", "The [c:bR]Trial of Bones[c:]. The 3 drawn cards must cost at least [c:bR]5 bones[c:] combined to pass.", "[c:bR]骨之试[c:]。所引三牌，须合直[c:bR]骨不下五[c:]，乃胜。");
            // [c:bR]力量试炼[c:]。抽出的3张卡牌必须共计拥有至少[c:bR]4点攻击力[c:]方可通过。
            AddTranslation("DECKTRIALSEQUENCER_DESCRIPTION_093_M", "The [c:bR]Trial of Power[c:]. The 3 drawn cards must have at least [c:bR]4 attack power[c:] combined to pass.", "[c:bR]威之试[c:]。所引三牌，须合有[c:bR]威不下四[c:]，乃胜。");
            // [c:bR]生命试炼[c:]。抽出的3张卡牌必须共计拥有至少[c:bR]6点生命值[c:]方可通过。
            AddTranslation("DECKTRIALSEQUENCER_DESCRIPTION_269_M", "The [c:bR]Trial of Health[c:]. The 3 drawn cards must have at least [c:bR]6 health[c:] combined to pass.", "[c:bR]命之试[c:]。所引三牌，须合有[c:bR]命不下六[c:]，乃胜。");
            // [c:bR]同族试炼[c:]。抽出的[c:bR]3张牌中至少2张[c:]必须[c:bR]来自同一族群[c:]方可通过。
            AddTranslation("DECKTRIALSEQUENCER_DESCRIPTION_927_M", "The [c:bR]Trial of Kin[c:]. [c:bR]2 of the 3[c:] drawn cards [c:bR]must be kin[c:] to pass.", "[c:bR]族之试[c:]。所引三牌中，[c:bR]不下二牌[c:]须[c:bR]同族[c:]，乃胜。");
            // [c:bR]有翼试炼[c:]。抽出的3张卡牌必须至少有1张带有[c:bR]空袭[c:]印记方可通过。
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_630_M", "The [c:bR]Trial of the Winged[c:]. The 3 drawn cards must include a card with the [c:bR]Airborne[c:] sigil.", "[c:bR]翼之试[c:]。所引三牌，须有一负[c:bR]翔袭[c:]印契之牌，乃胜。");
            // [c:bR]有鳍试炼[c:]。抽出的3张卡牌必须至少有1张带有[c:bR]水袭[c:]印记方可通过。
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_097_M", "The [c:bR]Trial of the Finned[c:]. The 3 drawn cards must include a card with the [c:bR]Waterborne[c:] sigil.", "[c:bR]鳍之试[c:]。所引三牌，须有一负[c:bR]潜袭[c:]印契之牌，乃胜。");
            // [c:bR]敏捷试炼[c:]。抽出的3张卡牌必须至少有1张带有[c:bR]冲刺能手[c:]印记方可通过。
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_315_M", "The [c:bR]Trial of the Swift[c:]. The 3 drawn cards must include a card with the [c:bR]Sprinter[c:] sigil.", "[c:bR]疾之试[c:]。所引三牌，须有一负[c:bR]疾趋[c:]印契之牌，乃胜。");
            // [c:bR]稀有试炼[c:]。抽出的3张卡牌必须至少有1张为[c:bR]稀有[c:]卡牌方可通过。
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_154_M", "The [c:bR]Trial of Rarity[c:]. The 3 drawn cards must include a [c:bR]Rare[c:] card.", "[c:bR]罕之试[c:]。所引三牌，须有一[c:bR]罕有牌[c:]，乃胜。");
            // [c:bR]兽皮试炼[c:]。抽出的3张卡牌必须至少有1张为[c:bR]毛皮[c:]卡牌方可通过。
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_446_M", "The [c:bR]Trial of Skins[c:]. The 3 drawn cards must include a [c:bR]Pelt[c:] card.", "[c:bR]革之试[c:]。所引三牌，须有一[c:bR]裘革牌[c:]，乃胜。");
            // 简体中文
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_325_M", "!DELETED!", "文言");
            // 我不是机器人。
            AddTranslation("CHECKMARKCAPTCHA_PUZZLE_M_TEXT_565", "I AM NOT A ROBOT.", "余非机人。");
            // 正在等待网络
            AddTranslation("CHECKMARKCAPTCHA_PUZZLE_M_TEXT_410", "WAITING FOR NETWORK", "惟网之俟");
            // 为下列场景选择全部适用情绪。
            AddTranslation("EMOTIONSCAPTCHA_PUZZLE_M_TEXT_731", "SELECT ALL APPLICABLE EMOTIONS FOR THE FOLLOWING SCENARIOS.", "下列诸事，悉择其宜之色。");
            // 完成
            AddTranslation("EMOTIONSCAPTCHA_PUZZLE_M_TEXT_930", "DONE", "毕");
            // 选择存在卡牌的所有方块
            AddTranslation("IMAGESCAPTCHA_PUZZLE_M_TEXT_037", "SELECT ALL SQUARES THAT CONTAIN CARDS", "凡有牌之矩，悉择之");
            // 输入正确总数
            AddTranslation("MATHCAPTCHA_PUZZLE_M_TEXT_131", "ENTER THE CORRECT SUM", "录其正和");
            // 存在何种印记？
            AddTranslation("OBJECT3DCAPTCHA_PUZZLE_M_TEXT_600", "WHICH SIGIL IS REPRESENTED?", "此为何印契？");
            // 请将印记旋转至垂直角度
            AddTranslation("ROTATECAPTCHA_PUZZLE_M_TEXT_004", "ROTATE THE SIGIL UNTIL IT IS UPRIGHT", "旋此印契，至其正立");
            // 你抽到了你的能量机器人。你的能量现已充满。
            AddTranslation("EMOTIONSCAPTCHA_PUZZLE_QUESTIONTEXT_029", "YOU DRAW YOUR ENERGY BOT. YOU HAVE FULL ENERGY.", "汝引得能机人。今能已盈。");
            // 你即将死于昆虫机器人之手。你抽到了跳跃机器人。
            AddTranslation("EMOTIONSCAPTCHA_PUZZLE_QUESTIONTEXT_638", "YOU ARE ABOUT TO DIE FROM AN INSECTODRONE. YOU DRAW A L33PB0T.", "汝将死于虫飞械。乃引得一跃机人。");
            // 你已成功完成了终极冥刻。
            AddTranslation("EMOTIONSCAPTCHA_PUZZLE_QUESTIONTEXT_182", "YOU SUCCESSFULLY PERFORM THE GREAT TRANSCENDENCE.", "汝遂成大陟。");
            // 英文
            AddTranslation("OPTIONSUI_VALUE_539", "ENGLISH", "英吉利言");
            // 主音量
            AddTranslation("OPTIONSUI_VALUE_018", "MASTER VOLUME", "总音");
            // 噪音效果
            AddTranslation("OPTIONSUI_VALUE_641", "NOISE EFFECT", "噪效");
            // 分辨率
            AddTranslation("OPTIONSUI_VALUE_502", "RESOLUTION", "辨率");
            // 配乐音量
            AddTranslation("OPTIONSUI_VALUE_991", "MUSIC VOLUME", "乐音");
            // 全屏模式
            AddTranslation("OPTIONSUI_VALUE_175", "FULLSCREEN", "全屏");
            // 对话文本显示速度
            AddTranslation("OPTIONSUI_VALUE_670", "DIALOGUE TEXT SPEED", "对白文速");
            // 亮度（伽马）
            AddTranslation("OPTIONSUI_VALUE_265", "BRIGHTNESS (GAMMA)", "明度（伽马）");
            // 画质
            AddTranslation("OPTIONSUI_VALUE_015", "GRAPHICS QUALITY", "画质");
            // 应用
            AddTranslation("OPTIONSUI_VALUE_030", "APPLY", "施");
            // 以英文重启游戏
            AddTranslation("OPTIONSUI_VALUE_589", "REBOOT WITH ENGLISH", "以英吉利言复启");
            // 音效音量
            AddTranslation("OPTIONSUI_VALUE_211", "SOUND EFFECTS VOLUME", "效音");
            // 重置存档
            AddTranslation("OPTIONSUI_VALUE_953", "RESET SAVE DATA", "重置存录");
            // 格里魔拉使用羽毛笔冥刻死者的墓志铭……
            AddTranslation("GBC_INTRO_164", "Grimora used her quill to inscribe the epitaphs of the dead...", "格里魔拉以厥羽笔，勒死者墓志……");
            // 起初……世人不知[c:R]卡牌[c:]为何物。
            AddTranslation("GBC_INTRO_617", "In the beginning... The world did not know [c:R]cards[c:].", "初，世未识[c:R]牌[c:]。");
            // 直至……[c:R]冥刻者[c:]到来方为止。
            AddTranslation("GBC_INTRO_362", "That is... until the day [c:R]The Scrybes[c:] arrived.", "迨[c:R]诸司锲[c:]至，始不然。");
            // 每位冥刻者均有其独特的……[c:R]冥刻[c:]方式来创造[c:R]卡牌[c:]。
            AddTranslation("GBC_INTRO_743", "Each had their own method of... [c:R]Inscryption[c:] to create [c:R]cards[c:].", "各有所以[c:R]冥锲[c:]造[c:R]牌[c:]之术。");
            // [c:R]格里魔拉[c:]使用[c:R]羽毛笔[c:]冥刻死者的墓志铭……
            AddTranslation("GBC_INTRO_246", "[c:R]Grimora[c:] used her [c:R]quill[c:] to inscrybe the epitaphs of the dead...", "[c:R]格里魔拉[c:]以厥[c:R]羽笔[c:]，勒死者墓志……");
            // [c:R]莱西[c:]使用[c:R]野生动物照相机[c:]捕捉野兽的样貌……
            AddTranslation("GBC_INTRO_217", "[c:R]Leshy[c:] used his [c:R]wildlife camera[c:] to capture beasts...", "[c:R]莱西[c:]以厥[c:R]野物影器[c:]，取群兽之影……");
            // [c:R]P03[c:]使用[c:R]粒子扫描仪[c:]拷贝机器人的中央处理器……
            AddTranslation("GBC_INTRO_083", "[c:R]P03[c:] used a [c:R]particle scanner[c:] to copy the CPU's of robots...", "[c:R]鉟〇三[c:]以[c:R]微省器[c:]摹机人之中枢……");
            // [c:R]蔓尼菲科[c:]则使用[c:R]画笔[c:]绘制他的魔法学徒。
            AddTranslation("GBC_INTRO_206", "And [c:R]Magnificus[c:] used his [c:R]brush[c:] to paint his wizard pupils.", "而[c:R]蔓尼菲科[c:]以厥[c:R]画笔[c:]绘厥巫徒。");
            // 卡牌一经创造，[c:R]冥刻者们[c:]便强化了自身的力量。
            AddTranslation("GBC_INTRO_195", "With the cards created, [c:R]The Scrybes[c:] had solidified their power.", "牌既成，[c:R]诸司锲[c:]之威遂固。");
            // 但终有一天，一位[c:R]挑战者[c:]来到了，势要[c:R]取代其中一位冥刻者！
            AddTranslation("GBC_INTRO_495", "Until, one day, a [c:R]Challenger[c:] arrived to [c:R]replace one of the Scrybes!", "然终有一日，一[c:R]角者[c:]至，欲取诸司锲之一而代之！");
            // 取代格里魔拉并成为死亡冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_690", "Replace Grimora and become The Scrybe of the Dead?", "代格里魔拉而为死之司锲乎？");
            // 你的目标是取代格里魔拉并成为死亡冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_286_M", "Your ambition is to replace Grimora and become The Scrybe of The Dead?", "汝志在代格里魔拉而为死之司锲乎？");
            // 你的目标是取代莱西并成为野兽冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_353_M", "Your ambition is to replace Leshy and become The Scrybe of Beasts?", "汝志在代莱西而为兽之司锲乎？");
            // 你的目标是取代蔓尼菲科并成为魔法冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_278_M", "Your ambition is to replace Magnificus and become The Scrybe of Magicks?", "汝志在代蔓尼菲科而为术之司锲乎？");
            // 你的目标是取代P03并成为科技冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_729_M", "Your ambition is to replace P03 and become The Scrybe of Technology?", "汝志在代鉟〇三而为机之司锲乎？");
            // 选择一套起始手牌来记录你的目标。
            AddTranslation("GBC_STARTING_ISLAND_739_M", "Choose a starting deck to mark your ambition.", "择一初牌列，以表乃志。");
            // 时候到了，挑战者。选出你要取而代之的冥刻者吧。
            AddTranslation("GBC_STARTING_ISLAND_530_M", "It is time, Challenger. Choose the Scrybe that you will replace.", "时至矣，角者。择汝所将代之司锲。");
            // 取代P03并成为科技冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_720_M", "Replace P03 and become The Scrybe of Technology?", "代鉟〇三而为机之司锲乎？");
            // 取代莱西并成为野兽冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_725_M", "Replace Leshy and become The Scrybe of Beasts?", "代莱西而为兽之司锲乎？");
            // 取代蔓尼菲科并成为魔法冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_128_M", "Replace Magnificus and become The Scrybe of Magicks?", "代蔓尼菲科而为术之司锲乎？");
            // 取代格里魔拉并成为死亡冥刻者？
            AddTranslation("GBC_STARTING_ISLAND_713_M", "Replace Grimora and become The Scrybe of The Dead?", "代格里魔拉而为死之司锲乎？");
            // 随着你将箱子撬开，一片片干涸的血迹龟裂开来……里面放的是两包卡牌！
            AddTranslation("GBC_TEMPLE_NATURE_456_M", "Patches of dried blood crackled as you pried the chest open... But two packs were inside!", "汝启其匮，干血片片迸裂……中有二牌韬！");
            // 你将箱子撬开……在里面发现了一包卡牌！
            AddTranslation("GBC_TEMPLE_NATURE_527_M", "You pried the chest open... and found a Card Pack inside!", "汝启其匮……中得一牌韬！");
            // 抽屉吱吱呀呀地打开了……里面是一包卡牌！
            AddTranslation("GBC_TEMPLE_NATURE_556_M", "The drawer creaked open... and you found a pack inside!", "其椟徐启……中得一牌韬！");
            // 锁头咔嗒一声开了。这仪器里显现出一个抽屉。里面是两包卡牌！
            AddTranslation("GBC_TEMPLE_TECH_272_M", "The lock cracked open. A drawer emerged from within the device. It contained 2 Card Packs!", "锁解，器中出一椟；中有二牌韬！");
            // 锁头开了，跳出一个抽屉。里面是两包卡牌！
            AddTranslation("GBC_TEMPLE_TECH_186_M", "The lock unclasped and a drawer burst forth. It contained 2 Card Packs!", "锁开，一椟突出；中有二牌韬！");
            // 你在废牌里找来找去……发现了一包卡牌！
            AddTranslation("GBC_TEMPLE_TECH_708_M", "You rummage through the junk cards... And find a Card Pack!", "汝翻诸废牌……得一牌韬！");
            // 你在一堆内脏和杂物中翻来找去，发现了一包卡牌！
            AddTranslation("GBC_TEMPLE_UNDEAD_871_M", "You found a Card Pack among the giblets and scantlings!", "汝于脏腑残屑间得一牌韬！");
            // 你在骨堆中仔细翻找，发现了一包卡牌！
            AddTranslation("GBC_TEMPLE_UNDEAD_252_M", "You sifted through the bones and found a Card Pack inside!", "汝披骨而索，得一牌韬！");
            // 棺材中飘出了一股恶臭的气味……
            AddTranslation("GBC_TEMPLE_UNDEAD_951_M", "A gust of foul smelling air billows from the casket...", "棺中忽涌恶臭之气……");
            // 但你还是发现了一包卡牌！
            AddTranslation("GBC_TEMPLE_UNDEAD_534_M", "But you found a card pack inside!", "然中有一牌韬！");
            // 你在棺材里找到了一片墓志铭……当然还有别的。
            AddTranslation("GBC_TEMPLE_UNDEAD_059_M", "You found a piece of an epitaph in the casket... among other things.", "汝于棺中得墓志一片……兼他物焉。");
            // 箱子空空如也，里面只有一张卡牌。
            AddTranslation("GBC_TEMPLE_WIZARD_842_M", "The chest is empty, save for a single card.", "匮空矣，惟馀一牌。");
            // 在一大堆锋利的工具旁，你发现了一包卡牌。
            AddTranslation("GBC_TEMPLE_WIZARD_386_M", "You find a card pack among a heap of sharp implements.", "汝于利器间得一牌韬。");
            // 箱子内侧覆盖着一层黏糊糊的绿色胶状物……但你发现了一包卡牌。
            AddTranslation("GBC_TEMPLE_WIZARD_935_M", "The inside of the chest is covered in a sticky green goo... but you find a card pack.", "匮中满覆碧绿黏胶……然汝得一牌韬。");
            // 字条写着：[c:gray]底部印记可由听力障碍之人获得……
            AddTranslation("GBC_TEMPLE_WIZARD_024_M", "The note reads: [c:gray]The BOTTOM sigil is found by the hard of hearing...", "札曰：[c:gray]下印，闻艰者得之……");
            // [c:gray]……或由听力极佳之人获得。
            AddTranslation("GBC_TEMPLE_WIZARD_905_M", "[c:gray]...or by those who hear too easily.", "[c:gray]……抑闻过易者得之。");
            // 一枚奇怪的单片眼镜。你把它戴上了。
            AddTranslation("GBC_TEMPLE_WIZARD_177_M", "A strange monocle. You put it on.", "一异单镜。汝佩之。");
            // 字条写着：[c:gray]中部印记可由苍白之人获得。
            AddTranslation("GBC_TEMPLE_WIZARD_442_M", "The note reads: [c:gray]The MIDDLE sigil is found by the pale.", "札曰：[c:gray]中印，苍白者得之。");
            // 你又伸手进去翻找……并注意到在卡牌原来的位置有个印记[prefab:WizardMarking_F3_1]。
            AddTranslation("GBC_TEMPLE_WIZARD_323_M", "You reach back in for more... and notice a sigil where the card used to be[prefab:WizardMarking_F3_1].", "汝复探其中……见原置牌处有一印[prefab:WizardMarking_F3_1]。");
            // 字条写着：[c:gray]顶部印记可由贪婪之人获得。
            AddTranslation("GBC_TEMPLE_WIZARD_300_M", "The note reads: [c:gray]The TOP sigil is found by the greedy.", "札曰：[c:gray]上印，贪者得之。");
            // 按任意键开始
            AddTranslation("MISC_487", "PRESS ANY BUTTON TO START", "任叩发一键以始");
            // 英文
            AddTranslation("MISC_440", "English", "英吉利言");
            // 法语
            AddTranslation("MISC_853", "French", "法兰西言");
            // 意大利语
            AddTranslation("MISC_048", "Italian", "意大利言");
            // 德语
            AddTranslation("MISC_859", "German", "德意志言");
            // 西语
            AddTranslation("MISC_031", "Spanish", "西班牙言");
            // 简体中文
            AddTranslation("MISC_817", "!DELETED!", "简体现代言");
            // 日语
            AddTranslation("MISC_130", "Japanese", "日本言");
            // 土耳其语
            AddTranslation("MISC_325", "Turkish", "土耳其言");
            // 波兰语
            AddTranslation("MISC_467", "Polish", "波兰言");
            // 葡萄牙语
            AddTranslation("MISC_029", "Portuguese", "葡萄牙言");
            // 葡萄牙语（巴西）
            AddTranslation("MISC_922", "Brazilian-Portuguese", "葡萄牙言（巴西）");
            // 荷兰语
            AddTranslation("MISC_813", "Dutch", "荷兰言");
            // 韩语
            AddTranslation("MISC_725", "Korean", "高丽言");
            // 俄语
            AddTranslation("MISC_529", "Russian", "俄罗斯言");
            // 泰语
            AddTranslation("MISC_210", "Thai", "泰言");
            // 捷克语
            AddTranslation("MISC_520", "Czech", "捷克言");
            // 那么{0}试炼即将开始。
            AddTranslation("MISC_305_M", "Let the Trial of {0} begin.", "其{0}之试始矣。");
            // 智慧
            AddTranslation("MISC_559", "Wisdom", "智");
            // 鲜血
            AddTranslation("MISC_786", "Blood", "血");
            // 骨头
            AddTranslation("MISC_414", "Bones", "骨");
            // 力量
            AddTranslation("MISC_283", "Power", "威");
            // 生命
            AddTranslation("MISC_402", "Toughness", "命");
            // 同族
            AddTranslation("MISC_980", "Kin", "族");
            // 有翼
            AddTranslation("MISC_394", "The Winged", "翼");
            // 敏捷
            AddTranslation("MISC_508", "The Swift", "疾");
            // 有鳍
            AddTranslation("MISC_198", "The Finned", "鳍");
            // 稀有
            AddTranslation("MISC_153", "Rarity", "罕");
            // 兽皮
            AddTranslation("MISC_345", "Skins", "革");
            // 圆环
            AddTranslation("MISC_655", "The Ring", "环");
            // 请勿开封
            AddTranslation("MISC_165", "KEEP SEALED", "毋启");
            // 寻找
            AddTranslation("MISC_187", "FIND", "寻");
            // 救赎
            AddTranslation("MISC_239", "SALVATION", "救");
            // 当于
            AddTranslation("MISC_834", "IN", "于");
            // 布谷鸟
            AddTranslation("MISC_025", "CUCKOO", "布谷");
            // 时钟
            AddTranslation("MISC_935", "CLOCK", "钟");
            // 鸟类
            AddTranslation("MISC_255", "Bird", "羽属");
            // 犬类
            AddTranslation("MISC_620", "Canine", "犬属");
            // 有蹄类
            AddTranslation("MISC_971", "Hooved", "蹄属");
            // 爬行类
            AddTranslation("MISC_921", "Reptile", "鳞属");
            // 昆虫类
            AddTranslation("MISC_481", "Insect", "虫属");
            // 该你了。
            AddTranslation("MISC_357_M", "Take your turn.", "今当乃合。");
            // 愿安息
            AddTranslation("MISC_984", "RIP", "愿归窀穸");
            // 愿你安息
            AddTranslation("MISC_248", "R.I.P.", "君归窀穸");
            // 已收集卡牌
            AddTranslation("MISC_848", "Collected Cards", "既得之诸牌");
            // 稀有卡牌！
            AddTranslation("MISC_149", "Rare!", "罕有！");
            // 权限请求
            AddTranslation("MISC_095", "Permissions Request", "得权之请");
            // 是否允许Inscryption.exe读取你的硬盘？
            AddTranslation("MISC_923", "GRANT INSCRYPTION.EXE PERMISSION TO ACCESS YOUR HARD DRIVE?", "许“冥锲.exe”得见乃坚盘乎？");
            // 是
            AddTranslation("MISC_359", "YES", "然");
            // 否
            AddTranslation("MISC_779", "NO", "否");
            // 文件大小：
            AddTranslation("MISC_364", "FILE SIZE:", "文件巨细：");
            // 正在删除文件……
            AddTranslation("MISC_178", "DELETING FILE...", "惟牍之削……");
            // 内存中无照片
            AddTranslation("MISC_631", "NO PHOTOGRAPH IN MEMORY", "未见影于识匣");
            // 打印进程
            AddTranslation("MISC_923", "PRINT PROGRESS", "印之进度");
            // 正在充电
            AddTranslation("MISC_430", "CHARGING", "惟电之充");
            // 确认
            AddTranslation("MISC_470", "CONFIRM", "定");
            // 状态点数
            AddTranslation("MISC_756", "SP", "数点");
            // 每一次……
            AddTranslation("MISC_130", "every time...", "每度皆然……");
            // 正在上传
            AddTranslation("MISC_511", "UPLOADING", "惟其之上载");
            // 删除确认
            AddTranslation("MISC_875", "DELETE CONFIRMATION", "削前之定");
            // 将软盘Z中所有内容删除？
            AddTranslation("MISC_127", "DELETE ENTIRE CONTENTS OF FLOPPY DRIVE Z:?", "尽削软盘Z:中诸物乎？");
            // 正在删除{0}……
            AddTranslation("MISC_167", "DELETING {0}", "惟{0}之削……");
            // 删除盘中内容
            AddTranslation("MISC_249", "Deleting Disk Contents", "惟盘中诸物之削");
            // 软盘（Z:）
            AddTranslation("MISC_706", "FLOPPY DRIVE (Z:)", "软盘（Z:）");
            // Inscryption.exe
            AddTranslation("MISC_840", "Inscryption.exe", "冥锲.exe");
            // 存档数据
            AddTranslation("MISC_884", "SaveData", "存录之档");
            // Inscryption_Data
            AddTranslation("MISC_293", "Inscryption_Data", "冥锲_档");
            // 旧_数据
            AddTranslation("MISC_696", "OLD_DATA", "旧_档");
            // 电池已充满
            AddTranslation("MISC_358", "BATTERY FULLY CHARGED", "电既满");
            // 新内存卡已插入
            AddTranslation("MISC_294", "NEW MEMORY CARD INSERTED", "新识匣卡既纳");
            // 错误
            AddTranslation("MISC_823", "ERROR", "误");
            // 停止观看录像？
            AddTranslation("MISC_612", "STOP BROWSING FOOTAGE?", "止观影录乎？");
            // Inscryption的存在已被扯碎！全都删干净了。
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_297", "!DELETED!", "《冥锲》既殁，尽削除矣。");
            // 你难道不觉得愧疚吗，卢克？
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_732", "Do you not feel remorse, Luke?", "卢克，子不知愧乎？");
            // 一个造物就这样被抹除……
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_799", "A creation erased...", "一造物既削……");
            // 一个世界因此而湮灭……
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_466", "An entire world annihilated...", "一世界尽灭……");
            // 美景不常。
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_727", "Nothing beautiful can last.", "丽者无久，瑰者难常。");
            // 力量
            AddTranslation("MISC_036", "power", "威");
            // 生命
            AddTranslation("MISC_493", "health", "命");
            // 绿色
            AddTranslation("MISC_142", "Green", "绿");
            // 橙色
            AddTranslation("MISC_465", "Orange", "橙");
            // 蓝色
            AddTranslation("MISC_363", "Blue", "蓝");
            // [c:bR][v:0][c:]的成本是[c:bR][v:1][c:]……意味着要献祭[c:bR][v:1]只造物[c:]。
            AddTranslation("GAMEPLAY_HINTS_HINT_NOTENOUGHBLOOD_REPEAT_#3_143_M", "The [c:bR][v:0][c:] costs [c:bR][v:1][c:]... That means sacrifice [c:bR][v:1] creatures[c:].", "[c:bR][v:0][c:]直[c:bR][v:1][c:]……即须祀[c:bR][v:1]物[c:]。");
            // [t:3]你[w:0.2]来啦！[w:0.3][t:0]真了不起！[w:0.3]我是死亡冥刻者，[w:0.3][t:0]格里魔拉。
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_466_M", "[t:3]You're[w:0.2] here![w:0.3][t:0] Marvelous![w:0.3] I am Grimora,[w:0.3][t:0] Scrybe of the Dead.", "[t:3]汝至矣！[w:0.3][t:0]善哉！[w:0.3]奴死之司锲，[w:0.3][t:0]格里魔拉。");
            // 直到最近，[w:0.3][e:Quiet]我仍处在羞愧之中……
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_868_M", "Until quite recently[w:0.3][e:Quiet] I was disgraced...", "迄于近顷，[w:0.3][e:Quiet]我犹失荣……");
            // [t:3][e:Anger]不过有了[w:0.2]意料之外的朋友的[w:0.2]帮助，我又恢复了曾经的荣耀！
            AddTranslation("GBC_NPC_GRIMORATEMPLEINTRO_102_M", "[t:3][e:Anger]Though I was returned to my former glory with the help of some[w:0.2] unlikely[w:0.2] friends!", "[t:3][e:Anger]然赖数不图之友之助，奴复归故荣！");
            // [t:1]我希望能再次看到光明！[w:0.3]能唱歌！[w:0.3]还能跳舞！
            AddTranslation("GBC_NPC_WIZARDBLUEVICTORY_330_M", "[t:1]I wish to see the light again![w:0.3] T-[w:0.2] to sing![w:0.3] To dance!", "[t:1]愿复见光！[w:0.2]能-[w:0.3]能歌！[w:0.3]能舞！");
            // 在它死前……得看看[w:0.3]它的[c:R]成本[c:]……
            AddTranslation("GBC_BATTLE_LESHYGBCBOSSCOSTCARD_REPEAT_#2_570_M", "Before that one dies...[w:0.3] Its [c:R]cost[c:]...", "彼未死前……[w:0.3]其[c:R]直[c:]……");
            // 哦，[w:0.3]对了……[w:0.5]我知道你又用了那张新游戏卡牌。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_808_M", "Oh,[w:0.3] and[w:0.3] by the way...[w:0.5] I know you used that New Game Card again.", "吁，[w:0.3]且[w:0.3]顺言之……[w:0.5]余知汝又用彼新局牌矣。");
            // 或许你是想尝试新的初始牌组之类的。[w:0.3]我懂的。
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_810_M", "You probably wanted to try a new starter deck or something.[w:0.3] I get it.", "汝殆欲试一新初牌列耳。[w:0.3]余知之。");
            // 不过，[w:0.3]就，[w:0.3]你每次这样操作，我都要在这座桥上重头再来。[w:0.3]所以你悠着点，[w:0.3]好吧？
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_887_M", "But,[w:0.3] like,[w:0.3] I have to restart on this bridge every time you do that.[w:0.3] So take it easy,[w:0.3] right?", "然[w:0.3]汝每如此，[w:0.3]余皆须于此桥复作。[w:0.3]故姑徐之，[w:0.3]可乎？");
            // 要不这次就让"新游戏"那张卡牌休息休息？
            AddTranslation("GBC_NPC_MECHANICBROKENBRIDGE_REPEAT_#3_455_M", "Maybe you'll give that New Game Card a break this time?", "此番其姑休彼新局牌乎？");
            // 唔……[w:0.3]我一定是老了，动作都慢了许多。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_763_M", "Hmm...[w:0.3] I must be slowing down with age.", "唔……[w:0.3]吾老而渐迟矣。");
            // [shake:1][e:Anger]我可能需要拿起画笔再次在自己的卡牌上作画！
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_522_M", "[shake:1][e:Anger]I may need to set my brush upon my own cards once again!", "[shake:1][e:Anger]吾或须复以朕笔绘朕牌！");
            // 你技艺精湛。[w:0.3]这一点我很清楚。
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_REPEAT_#1_737_M", "You are skilled.[w:0.3] This much is clear.", "乃技诚精。[w:0.3]此甚明矣。");
            // 你是在逼我出手。[w:0.3]我自己的牌必须用我的画笔完成！
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_REPEAT_#2_166_M", "You've forced my hand.[w:0.3] I must use my brush upon my own cards!", "子迫我出手。[w:0.3]吾须以朕笔绘朕牌！");
            // 啊……[w:0.3]现在该充分运用我的画笔了！
            AddTranslation("GBC_BATTLE_MAGNIFICUSBOSSPHASE2_REPEAT_#3_801_M", "Alas...[w:0.3] It is time to fully utilize my brush!", "噫……[w:0.3]今当尽用朕笔矣！");
            // 如果你有[c:g1]宝[c:][c:g2]石[c:][c:g3]容[c:][c:g1]器[c:][c:g2]卡[c:][c:g3]牌[c:]，它就会亮起来。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_670_M", "This thing lights up when you have [c:g1]G[c:][c:g2]e[c:][c:g3]m[c:] [c:g1]V[c:][c:g2]e[c:][c:g3]s[c:][c:g1]s[c:][c:g2]e[c:][c:g3]l[c:] cards in play.", "卿控有[c:g1]玉[c:][c:g2]皿[c:][c:g3]牌[c:]时，此物即明。");
            // 现在你的空容器已经装满[c:g1]宝[c:][c:g2]石[c:]了。
            AddTranslation("PART_3_MAP_FACTORYGEMSMODULEFETCHED2_421_M", "Your Empty Vessels are now filled with [c:g1]G[c:][c:g2]e[c:][c:g3]m[c:][c:g1]s[c:].", "今卿之空皿[c:g1]既[c:][c:g2]充[c:][c:g3]玉[c:]矣。");
            // 感觉过了好久……
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_557_M", "So long it has felt...", "似隔久矣……");
            // 太久没感受到软毛皮拂过的感觉了。
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_895_M", "Since we have brushed with the soft fur of a pelt.", "自鄙等尝拂裘革之柔毛。");
            // 你给我们带了吗？
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_285_M", "Have you brought us some?", "君挟来些许乎？");
            // 你给我们带了[c:bB]虚幻毛皮[c:]吗？
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_REPEAT_#1_591_M", "Have you brought us [c:bB]holo pelts[c:]?", "君挟[c:bB]幻裘[c:]而来乎？");
            // 你是带着[c:bB]虚幻毛皮[c:]来的吗？
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_REPEAT_#3_649_M", "Do you come bearing [c:bB]holo pelts[c:]?", "君来，挟[c:bB]幻裘[c:]乎？");
            // [c:bB]虚幻毛皮[c:]？
            AddTranslation("PART_3_TRADER_TRADERMASKINTRO_REPEAT_#4_089_M", "[c:bB]Holo pelts[c:]?", "[c:bB]幻裘[c:]乎？");
            // 你来选一张卡，我来把它[c:g1]变[c:][c:g2]成[c:][c:g3]宝[c:][c:g1]石[c:]。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_530_M", "You'll pick a card now, and I'll [c:g1]G[c:][c:g2]e[c:][c:g3]m[c:][c:g1]i[c:][c:g2]f[c:][c:g3]y[c:] it.", "卿今择一牌，咱则[c:g1]玉[c:][c:g2]化[c:][c:g3]之[c:]。");
            // 从此，持有[c:g1]绿宝石[c:]将增加生命。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_219_M", "From then on, having a [c:g1]Green Gem[c:] will increase its Health.", "自此，得[c:g1]绿玉[c:]则其命增。");
            // 持有[c:g2]橙宝石[c:]将提升攻击。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_220_M", "Having an [c:g2]Orange Gem[c:] will increase its Power.", "得[c:g2]橙玉[c:]则其威益。");
            // 持有[c:g3]蓝宝石[c:]将降低其能量成本。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_900_M", "And having a [c:g3]Blue Gem[c:] will lower its Energy Cost.", "得[c:g3]蓝玉[c:]则其能直减。");
            // 等着瞧就知道了。
            AddTranslation("PART_3_TUTORIAL_TUTORIALATTACHGEM_526_M", "You'll see.", "姑待观之。");
            // 这点痛？还能忍。
            AddTranslation("PART_3_FACTORY_GOOFACTORYINTRO_263_M", "The pain? Bearable.", "此痛？可忍。");
            // 戴上这样的[c:bSG]决斗盘[c:]，你应该感到荣幸。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO2_208_M", "You should be honored to wear a [c:bSG]Duel Disk[c:] such as that.", "佩此[c:bSG]角盘[c:]，子宜以为荣。");
            // 合身吗？
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO2_907_M", "How does it fit?", "其适乎？");
            // 天平？多亏你和格里魔拉，它已经被删除了。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO3_497_M", "Scales? They've been deleted thanks to you and Grimora.", "衡乎？赖子与格里魔拉，既削矣。");
            // 用这个吧。分数降到0游戏就结束。
            AddTranslation("FINALE_FINALEMAGNIFICUSINTRO3_657_M", "This will do. A race to 0.", "此替可矣。争先至零。");
            // 古银币？
            AddTranslation("GBC_NPC_BONELORDCASKETGIVEOBOL_465_M", "An Ancient Obol?", "古银币乎？");
            // 这个贡品不错。
            AddTranslation("GBC_NPC_BONELORDCASKETGIVEOBOL_755_M", "That is a fine offering.", "此嘉献也。");
            // [c:F]在无量的洞穴里……[w:0.3]比无日的海更深……
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_961_M", "[c:F]In a measureless cavern...[w:0.3] deeper than the sunless sea...", "[c:F]潜于无量之穴……[w:0.3]深于无日之海……");
            // [c:F]你走近了骨王。[w:0.3]走近了我。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_558_M", "[c:F]You approach The Bone Lord.[w:0.3] You approach me.", "[c:F]汝近骨王。[w:0.3]亦近我。");
            // 听到了吗？[w:0.3]旧_数据？
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_627_M", "Do you hear it?[w:0.3] The OLD_DATA?", "闻之乎？[w:0.3]旧_档？");
            // 它是如何扭曲和腐化的？[w:0.3]甚至是如何发明不可知的图像呢？
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_725_M", "How it twists and corrupts.[w:0.3] How it even invents images unknowable.", "其扭且败。[w:0.3]甚且作不可知之象。");
            // 除非你愿意敬拜我，否则不要再靠近。[w:0.3]敬拜它吧。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_687_M", "Do not approach me again unless you will worship me.[w:0.3] Worship it.", "非将拜我，毋复近我。[w:0.3]拜彼。");
            // 好，所以你是认真的。[w:0.4]很好。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_REPEAT_#1_034_M", "Okay so you're serious.[w:0.4] Good.", "然，汝诚矣。[w:0.4]善。");
            // 你可能不理解它的意义。[w:0.3]甚至连我也[w:0.1]不完全了解。[w:0.3]但你能体会它的力量。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_REPEAT_#1_060_M", "You may not understand its meaning.[w:0.3] Not even I do[w:0.1] fully.[w:0.3] But you appreciate its power.", "其义，汝或未达。[w:0.3]余亦未[w:0.1]尽达之。[w:0.3]然汝知其威。");
            // 旧_数据不向内接收。[w:0.3]也不对外输出。[w:0.3]但我可以输出。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_REPEAT_#1_289_M", "The OLD_DATA does not take.[w:0.3] And it does not give.[w:0.3] But I do.", "旧_档不受。[w:0.3]亦不予。[w:0.3]余则予。");
            // 请收下我微不足道的供品。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_REPEAT_#1_364_M", "Please accept my meager offerings.", "请受朕薄献。");
            // 我们还会再见的。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_REPEAT_#2_700_M", "We will meet again.", "余汝后当复见。");
            // 你先去吧。[w:0.3]我们还会再见的。
            AddTranslation("GBC_NPC_BONELORDDOMAIN1_REPEAT_#3_883_M", "Go from here.[w:0.3] We will meet again.", "去此。[w:0.3]余汝后当复见。");
            // 我们可以暂时放下我们的分歧。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER2_356_M", "We were able to temporarily put our differences aside.", "奴等得姑置其歧。");
            // 为了更大的利益。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER2_462_M", "For the greater good.", "为大益耳。");
            // 没错……
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER3_905", "Yes...", "然……");
            // 能否真的有所裨益，回头再说吧……
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER3_775", "But we shall see what good comes of it...", "然其所益何如，且观之……");
            // 浇灭你的焦虑吧，蔓尼菲科。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER4_547", "Perish your anxieties, Magnificus.", "释乃忧，蔓尼菲科。");
            // 必须阻止这个机器人。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER4_282", "The bot must be stopped.", "彼机人不可不止。");
            // 是啊……或许吧……
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER5_156", "Yes... Perhaps...", "然……或可……");
            // 或许先等[c:bB]P03[c:]认为自己赢了吧。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER5_211", "Perhaps when [c:bB]P03[c:] believes it has won.", "或待[c:bB]鉟〇三[c:]自以为胜时。");
            // 那个机器人肯定会得意忘形…… 
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER5_505", "So jubilant will be that android... ", "彼机人将喜而忘形……");
            // 它将忽略监控摄像头的存在！
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER5_722", "It will disregard the surveillance cameras!", "则必不顾守视影器！");
            // 没错，[c:bR]挑战者[c:]。你必须继续对决。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER6_694_M", "Yes, [c:bR]Challenger[c:]. You must continue to play.", "然，[c:bR]角者[c:]。汝须续角。");
            // 打败那些愚蠢的头目……
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER6_658_M", "Defeat those half-baked bosses...", "败彼诸未成之魁……");
            // 把那些老掉牙的手段都试出来……
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER6_899_M", "Play out those hackneyed mechanics...", "尽试彼诸陈法……");
            // 等时机成熟，我们就会出手。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER6_075_M", "And when the moment is right we will strike.", "及其时至，奴等击之。");
            // 我是说我。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER7_497_M", "I will.", "余将为之。");
            // 到时候我会使出致命一击的！
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER7_470_M", "I will be the one to strike.", "出击者，余也。");
            // 去吧，[c:bR]挑战者。[c:]陪那台腐朽的机器玩一玩。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER7_022_M", "Go now, [c:bR]Challenger.[c:] Indulge that decrepit machine.", "往矣，[c:bR]角者。[c:]姑顺彼朽机。");
            // 让[c:bB]P03[c:]高兴点，然后我就可以消灭它了。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER7_103_M", "Make [c:bB]P03[c:] feel joy so that I may snuff it out.", "使[c:bB]鉟〇三[c:]喜，以俟余灭之。");
            // 而你，[c:bR]挑战者[c:]，就是个绝佳的干扰。
            AddTranslation("PART_3_STORY_DREDGINGROOMENCOUNTER4P2_375_M", "And you, [c:bR]Challenger[c:] will provide the perfect distraction.", "而汝，[c:bR]角者[c:]，将为绝妙之蔽。");
            // 我看见你下了电梯。
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_290_M", "I saw you go down the lift.", "咱见卿之下升降机矣。");
            // 但你看看，还没修好。
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_816_M", "But look. Not fixed.", "然视之。犹未修。");
            // 你怎么回事？
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_882_M", "What's wrong with you?", "卿何病？");
            // 我带你玩了好几个小时精彩的卡牌游戏……
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_530_M", "I entertain you for hours with brilliant card-play...", "咱以曼妙牌术娱卿数时……");
            // 而你甚至不能保持我的工厂不出乱子？
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_764_M", "And you can't even keep my factory in shape?", "而卿竟不能令咱厂如故乎？");
            // ……行吧。
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_301_M", "...It's fine.", "……可矣。");
            // 坏了就坏了吧。
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_398_M", "It can stay broken.", "任其坏可也。");
            // 等[c:bG]终极冥刻[c:]之后，这些都不重要了。
            AddTranslation("PART_3_MAP_P03POSTSCRYBESMEETING_157_M", "None of this will matter after [c:bG]The Great Transcendence[c:].", "及[c:bG]大陟[c:]之后，此皆无足论。");
            // 野兽？完全不是。
            AddTranslation("TUTORIAL_TUTORIALDEATHCARDCHOICE_384_M", "Beasts? Not at all.", "兽乎？非也。");
            // 从在你之前来的[c:bR]挑战者[c:]中选择吧。
            AddTranslation("TUTORIAL_TUTORIALDEATHCARDCHOICE_530_M", "Choose from among those [c:bR]Challengers[c:] who came before you.", "择于诸先尔而来之[c:bR]角者[c:]。");
            // 我在看着呢。
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_246_M", "I was watching.", "吾方观之。");
            // 你和[c:bR]大师[c:]说了话！
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_682_M", "You spoke with [c:bR]The Master![c:]", "子与[c:bR]大师[c:]言矣！");
            // 这也太荣幸了。是不是有点飘飘然了？
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_368_M", "What an honor that was. Are you giddy?", "此诚荣矣。子其自得乎？");
            // 哦，机器人的统治即将完结。
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_589_M", "Oh, the end of the robot's reign is nigh.", "噫，机人之治将终矣。");
            // 欢呼吧！
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_009_M", "Rejoice!", "乐哉！");
            // 按照大师的话去做。
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#1_394_M", "Do as The Master said.", "如大师所言行之。");
            // 玩好那机器人的游戏。
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#1_583_M", "Play the bot's game.", "角彼机人之戏。");
            // 其他的事有他们照料呢！
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#1_873_M", "They will take care of the rest!", "馀事彼等自理之！");
            // 我看到你也和莱西说了话。
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#2_880_M", "I saw that you also spoke with Leshy.", "吾见子亦与莱西言矣。");
            // 那个臭气熏天的半兽人！
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#2_098_M", "That stinky beast-man!", "彼臭兽人！");
            // 我永远不会原谅他把我塞进那个瓶子里的。
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#2_306_M", "I shall never forgive him for stuffing me in that bottle.", "彼塞我于彼瓶中，吾终不赦之。");
            // 末日将至！
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#3_484_M", "The end is nigh!", "终焉近矣！");
            // 嘶……
            AddTranslation("GOO_BOTTLE_GOOMETSCRYBES_REPEAT_#4_565_M", "Rrrghhh...", "噫噫噫……");
            // 你见到莱西鱼了？[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERMETSCRYBES_815_M", "You met Leshy-fish?[w:0.3]", "女见莱西鱼乎？[w:0.3]");
            // 出条好鱼。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERMETSCRYBES_548_M", "Play it cod.[w:0.3]", "处之泰鳕。[w:0.3]");
            // 噢。[w:0.2]我是想说……[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERMETSCRYBES_395_M", "Oop.[w:0.2] I mean...[w:0.3]", "噢。[w:0.2]予谓……[w:0.3]");
            // 出张好牌。
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERMETSCRYBES_051_M", "Play it cool.", "处之泰然。");
            // 你刚刚打出了一张附有[w:0.2][c:gray]激活能力[c:]的牌。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_600_M", "You just played a card with an [w:0.2][c:gray]Activated Ability[c:].", "汝方陈具[w:0.2][c:gray]按发印技[c:]之一牌。");
            // 绝了！[w:0.3]先容我解释一下具体机制。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_187_M", "Marvelous![w:0.3] Allow me to explain how it works.", "善哉！[w:0.3]请容余释其用。");
            // 伟大冥刻者的指示开始在你脑海中回响。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_938_M", "The Great Scrybe's instructions began to echo through your mind.", "大司锲之教始应于乃心。");
            // 冷静点。[w:0.3]没事的。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_704_M", "Calm down.[w:0.3] It's fine.", "姑静。[w:0.3]无害。");
            // 啊，[w:0.3]我来给你解释解释。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_528_M", "Alas,[w:0.3] I shall explain to you its workings.", "吁，[w:0.3]余为汝释其用。");
            // 这就和按钮一样，[w:0.3]按下印记即可激活。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_117_M", "Activate it by pressing the sigil[w:0.3] like it's a button.", "叩按其印[w:0.3]，若叩键然，则能发。");
            // 但只有拥有足够成本才能使其发挥作用。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_017_M", "But it will only work if you can pay the cost.", "然惟足偿其直，乃能行。");
            // 又是一张附有[w:0.2][c:gray]激活能力[c:]的牌。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_REPEAT_#1_091_M", "Another card with an [w:0.2][c:gray]Activated Ability[c:].", "又具[w:0.2][c:gray]按发印技[c:]之一牌。");
            // 这就和按钮一样，按下印记即可激活……[w:0.3]只要你愿意承担成本。
            AddTranslation("GBC_TUTORIAL_ACTIVATEDABILITYTUTORIAL_REPEAT_#1_024_M", "It is activated by pressing the sigil like a button...[w:0.3] If you can afford the cost.", "叩按其印，如叩键然……[w:0.3]惟足偿其直，乃发。");
            // 啊！[w:0.1]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_779_M", "Ah![w:0.1]", "啊！[w:0.1]");
            // 这不是——[w:0.1]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_448_M", "Is it-[w:0.1]", "莫非—[w:0.1]");
            // 你这是——[w:0.1]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_324_M", "Who are-[w:0.1]", "孰—[w:0.1]");
            // 难不成这是？[w:0.1]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_395_M", "Is this?[w:0.1]", "靡此非？[w:0.1]");
            // 刺[w:0.2]激[w:0.2]来[w:0.2]了。[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_592_M", "STIM[w:0.2]U[w:0.2]LA[w:0.2]TION.[w:0.3]", "激[w:0.2]哉[w:0.2]至[w:0.2]也。[w:0.3]");
            // 除了
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_370_M", "Something other", "此乃异于");
            // 黑暗之外？[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_115_M", "than darkness?[w:0.3]", "昏冥者乎？[w:0.3]");
            // 太感谢了。[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_906_M", "Many thanks.[w:0.3]", "深谢矣。[w:0.3]");
            // 随你
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_881_M", "Do with me", "随尔");
            // 处置吧。[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_189_M", "what you will.[w:0.3]", "所欲为之。[w:0.3]");
            // 只要不是
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_630_M", "Anything but that", "但毋复");
            // 无边的黑暗就行。[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDISCOVERED_358_M", "infinite darkness.[w:0.3]", "无穷之冥。[w:0.3]");
            // 刺[w:0.1]激[w:0.1]来[w:0.1]了。
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEATTACKED_193_M", "STIM[w:0.1]U[w:0.1]LA[w:0.1]TION.", "激[w:0.1]哉[w:0.1]至[w:0.1]矣。");
            // 啊哈哈！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEATTACKED_REPEAT_#1_865_M", "Ahaha!", "哈哈！");
            // 没问题！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEATTACKED_REPEAT_#2_522_M", "It is OK!", "可也！");
            // 痛苦是种感觉！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEATTACKED_REPEAT_#3_068_M", "Pain is a feeling!", "痛亦一感也！");
            // 我正在体会！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEATTACKED_REPEAT_#4_177_M", "I am feeling!", "我今正有感！");
            // 没错，[w:0.3]没错，再来！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEPLAYED_040_M", "Yes![w:0.3] Yes!", "然！[w:0.3]然！");
            // 对头！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEPLAYED_REPEAT_#1_515_M", "Oh yes!", "然哉！");
            // 我感受到了[w:0.3]刺激！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEPLAYED_REPEAT_#2_353_M", "I am feeling[w:0.3] stimulated!", "我今大有所[w:0.3]激哉！");
            // 眼睛看花了！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEPLAYED_REPEAT_#3_802_M", "So many sights!", "可观者众矣！");
            // 哈哈哈哈！[w:0.3]对头！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEPLAYED_REPEAT_#4_196_M", "Ahaha![w:0.3] Yes.", "哈哈！[w:0.3]然。");
            // 对！[w:0.3]攻击！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEPLAYED_REPEAT_#5_503_M", "Yes![w:0.3] Attack!", "然！[w:0.3]攻之！");
            // 刺激我！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGESELECTIONCHOICEEITHER_955_M", "Stimulate me!", "激我哉！");
            // 选我！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGESELECTIONCHOICEEITHER_REPEAT_#1_502_M", "Choose me!", "择我！");
            // 全新体验！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGESELECTIONCHOICEEITHER_REPEAT_#2_256_M", "A new experience!", "新所尝也！");
            // 哈哈哈哈！[w:0.3]对头！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGESELECTIONCHOICEEITHER_REPEAT_#3_057_M", "Ahaha![w:0.3] Yes!", "哈哈！[w:0.3]然！");
            // 出自牌组，[w:0.1]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDRAWN_REPEAT_#1_796_M", "Out of the deck[w:0.1]", "出乎牌列，[w:0.1]");
            // 放入手中！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDRAWN_REPEAT_#1_903_M", "into the hand!", "而入于手！");
            // 看不过来啦！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDRAWN_REPEAT_#2_381_M", "So much to see!", "可观者群乎！");
            // 啊哈哈！[w:0.3]选我！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDRAWN_REPEAT_#3_652_M", "Ahaha![w:0.3] Play me!", "哈哈！[w:0.3]陈我！");
            // 把我打出去！[w:0.2]把我打出去！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDRAWN_REPEAT_#4_225_M", "Play me![w:0.2] Play me!", "陈我！[w:0.2]陈我！");
            // 我检测到了什么……[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_908_M", "I detected something...[w:0.3]", "我觉有物……[w:0.3]");
            // 是一种存在……[w:0.3]我不是……
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_953_M", "a presence...[w:0.3] I don't really-", "若有在焉……[w:0.3]我实不甚—");
            // 是蔓尼菲科吗？[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_145_M", "Magnificus?[w:0.3]", "蔓尼菲科乎？[w:0.3]");
            // 我现在已经摆脱他了。[w:0.2]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_141_M", "I am free of him now.[w:0.2]", "我今脱彼矣。[w:0.2]");
            // 我希望可以上场
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_807_M", "I wish to be played", "我愿见陈");
            // 被攻击
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_548_M", "to be attacked", "见攻");
            // 甚至阵亡。[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_246_M", "even killed.[w:0.3]", "虽见杀亦可。[w:0.3]");
            // 但我再不要
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_102_M", "But never to be", "然永毋为");
            // 当那个巫师的
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_535_M", "a pupil of that wizard", "彼巫之徒");
            // 学生了！[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMETSCRYBES_518_M", "ever again![w:0.3]", "矣焉哉！[w:0.3]");
            // 你好啊，朋友！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_766_M", "Hello friend!", "友乎，安！");
            // 是朋友啊！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_REPEAT_#1_903_M", "A friend!", "有友矣！");
            // 伙伴！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_REPEAT_#2_088_M", "Company!", "有侣矣！");
            // 你好啊，同志！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_REPEAT_#3_523_M", "Hello comrade!", "侪乎，安！");
            // 朋友们！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_REPEAT_#4_098_M", "Friends!", "诸友！");
            // 哈喽！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_REPEAT_#6_768_M", "Hello!", "安！");
            // 嗨！[w:0.2]哈喽！
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEMOVEBESIDE_REPEAT_#7_542_M", "Hi![w:0.2] Hello!", "嗨！[w:0.2]安！");
            // 我们希望这一切没有这么……
            AddTranslation("PART_3_TRADER_TRADERMASKFULLYCOMPLETED_144_M", "We wish it were not so...", "鄙等愿其不然……");
            // 但你已经用尽了我们的塔罗牌。
            AddTranslation("PART_3_TRADER_TRADERMASKFULLYCOMPLETED_924_M", "But you have exhausted our tarot cards.", "然君已尽鄙等卜牌矣。");
            // 就算你还有[c:bB]虚幻毛皮[c:]，我们也不能理所当然地收下。
            AddTranslation("PART_3_TRADER_TRADERMASKFULLYCOMPLETED_888_M", "Even if you had any more [c:bB]holo pelts[c:], we could not rightly accept them.", "纵君更有[c:bB]幻裘[c:]，鄙等亦不宜受之。");
            // 我们已无更多卡牌。再见。
            AddTranslation("PART_3_TRADER_TRADERMASKFULLYCOMPLETED_REPEAT_#1_360_M", "We are out of cards. Goodbye.", "牌尽矣。去矣。");
            // 我们会暂时留在这里。
            AddTranslation("PART_3_TRADER_TRADERMASKFULLYCOMPLETED_REPEAT_#2_064_M", "We will remain here for now.", "鄙等姑留此。");
            // 我们感觉很快周遭就会发生变化。
            AddTranslation("PART_3_TRADER_TRADERMASKFULLYCOMPLETED_REPEAT_#2_754_M", "We don't imagine things will stay the same for long.", "然鄙等料，此状无能久也。");
            // 你没有[c:bB]虚幻毛皮[c:]……
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_393_M", "You haven't any [c:bB]holo pelts[c:]...", "君无[c:bB]幻裘[c:]……");
            // 我们了解到它们存在于[c:bB]虚幻世界[c:]中。
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_491_M", "We have learned they exist within the [c:bB]holo world[c:].", "鄙等已知，其在[c:bB]幻界[c:]中。");
            // 也许你可以去那里找找。
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_466_M", "Perhaps you may find them there.", "或君可于彼得之。");
            // 你一张毛皮也没有。再见。
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_REPEAT_#1_211_M", "You have no pelts. Goodbye.", "君无裘。去矣。");
            // 要想获得我们的知识，得拿毛皮来交换。
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_REPEAT_#2_279_M", "We require pelts in exchange for our knowledge.", "欲易鄙等所知，必以裘来。");
            // 而你已无毛皮。
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_REPEAT_#2_008_M", "And you are out of pelts.", "而君亦无裘矣。");
            // 你没有[c:bB]虚幻毛皮[c:]……
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_REPEAT_#3_060_M", "You have no [c:bB]holo pelts[c:]...", "君无[c:bB]幻裘[c:]……");
            // 我们很失望。
            AddTranslation("PART_3_TRADER_TRADERMASKNOPELTS_REPEAT_#3_796_M", "We are disappointed.", "鄙等怅矣。");
            // 真美啊……是上等的[c:bB]虚幻毛皮[c:]。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_395_M", "Beautiful... Exquisite [c:bB]holo pelt[c:].", "美哉……精妙之[c:bB]幻裘[c:]。");
            // 现在我们将向你提供知识，这是我们唯一的用处了。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_363_M", "We will now provide you with knowledge, our only remaining good.", "今鄙等将以所知授君，此鄙等所馀唯一之珍。");
            // 我们也不是什么都知道……
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_986_M", "We do not know everything...", "鄙等非尽知也……");
            // 但我们的确在[c:bR]旧_数据[c:]中收集到了一些秘密。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_244_M", "But from the [c:bR]OLD_DATA[c:] we have gleaned certain secrets.", "然自[c:bR]旧_档[c:]中，鄙等颇得数秘。");
            // 真是精致。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_REPEAT_#1_485_M", "Exquisite.", "精妙。");
            // 没错，我们很满意。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_REPEAT_#2_232_M", "Yes. We are pleased.", "然。鄙等悦之。");
            // 绝美的毛皮。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_REPEAT_#3_133_M", "Beautiful pelt.", "美裘。");
            // 我们很满意。
            AddTranslation("PART_3_TRADER_TRADERMASKGAVEPELTS_REPEAT_#3_592_M", "We are pleased.", "鄙等悦之。");
            // [c:bR]愚人[c:]。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEFOOL_288_M", "[c:bR]The Fool[c:].", "[c:bR]愚[c:]。");
            // 被某些人称为“大耳朵”。计划还没落地就出师未捷了。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEFOOL_501_M", "Known to some as \"Big Ear\". He did not outlive his plot.", "或有谓之“大耳”者。其谋未竟，身已不存。");
            // [c:bR]旧_数据[c:]是众多磁盘中的一个，跨越了汪洋大海。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEFOOL_991_M", "One disk among many, the [c:bR]OLD_DATA[c:] travelled across the sea.", "众盘之一者，[c:bR]旧_档[c:]涉海而来。");
            // 被发现后，可怜的巴里被送去吃了枪子。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEFOOL_680_M", "Discovered, poor Barry was put to the gun.", "既为人觉，可怜巴里遂死于枪。");
            // [c:bR]高塔[c:]。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHETOWER_643_M", "[c:bR]The Tower[c:].", "[c:bR]塔[c:]。");
            // 我们并不完全了解Inscryption的创作本质。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHETOWER_285_M", "We do not fully understand the nature of Inscryption's creation.", "《冥锲》之所由成，鄙等未尽知也。");
            // 我们只知道一座建筑，知道[c:bB]等腰三角形[c:]。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHETOWER_327_M", "We know of a building, and of a [c:bB]triangle[c:] of isosceles proportions.", "鄙等所知，惟有一宇，与一等腰之[c:bB]三角[c:]耳。");
            // 也了解一个[c:bB]蓝色的人[c:]，他在创作期间曾经来访。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHETOWER_669_M", "And of a [c:bB]blue man[c:] who visited during the creation.", "复有一[c:bB]蓝人[c:]，成戏之际尝来。");
            // [c:bR]女皇[c:]。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEEMPRESS_590_M", "[c:bR]The Empress[c:].", "[c:bR]后[c:]。");
            // 在[c:bB]三角[c:]力量的帮助下，凯茜辅助创作出了Inscryption。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEEMPRESS_104_M", "With the powers of the [c:bB]triangle[c:], Kaycee helped to create Inscryption.", "赖[c:bB]三角[c:]之力，凯茜助成《冥锲》。");
            // 我们知道还有其他人，但只有她的名字被刻了下来。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEEMPRESS_252_M", "We know there were others, but only her name was inscribed.", "鄙等知其时尚有他人，然见锲者唯其名耳。");
            // 格里魔拉的一只食尸鬼被冠以她的名字。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEEMPRESS_107_M", "One of Grimora's Ghouls holds her name.", "格里魔拉之一冢鬼，负其名焉。");
            // 是[c:bR]旧_数据[c:]里的？她还真挺会找的。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEEMPRESS_232_M", "Of the [c:bR]OLD_DATA[c:]? She discovered much.", "至于[c:bR]旧_档[c:]，彼所发甚多。");
            // [c:bR]死神[c:]
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTDEATH_019_M", "[c:bR]Death[c:].", "[c:bR]死[c:]。");
            // 我们瞥到了卡涅夫尔码的用途……
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTDEATH_389_M", "We have gleaned the purpose of the Karnoffel Code...", "鄙等已窥卡涅夫尔码之用……");
            // 太可怕了。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTDEATH_924_M", "And it is terrible.", "其甚可怖。");
            // 那密码就在牌中。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTDEATH_887_M", "The Code is in the Cards.", "码在牌中。");
            // 接着就是一忘皆空了。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTDEATH_976_M", "And then oblivion.", "而后湮灭。");
            // [c:bR]魔鬼[c:]
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEDEVIL_299_M", "[c:bR]The Devil[c:].", "[c:bR]魔[c:]。");
            // 这是诅咒……数据中饱含着滔天恶意使它永远无法彻底清除。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEDEVIL_905_M", "A curse... Data so malignant that it can never be erased.", "诅也……其档至恶，永不可削。");
            // 他的邪恶腐蚀了磁盘。腐蚀了我们所有人。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEDEVIL_444_M", "His evil corrupts the disk. Corrupts all of us.", "彼之恶败此盘，亦败鄙等众。");
            // 他激起了冥刻者的敌意。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEDEVIL_738_M", "He inspires the Scrybes' enmity.", "彼激诸司锲之仇。");
            // 他创造了卡涅夫尔码。
            AddTranslation("PART_3_TRADER_TRADERMASKTAROTTHEDEVIL_986_M", "He created the Code.", "彼作此码。");
            // 你有个想法。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_743_M", "You had an idea.", "汝有一策。");
            // 为什么不让你的造物在火边取取暖……再多待一会儿呢？
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_741_M", "Why not warm your creature by the fire... for just a moment longer?", "何不使乃物就火，更燠须臾……？");
            // 一名饥饿的幸存者走近了一步。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_197_M", "One of the starving survivors took a step closer.", "一余生饥者进一武。");
            // 风险的确不小。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_758_M", "This would be risky.", "此甚危。");
            // 的确，你的造物会变得更加强大……
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_REPEAT_#1_562_M", "Surely your creature could become more powerful...", "乃物固可益强……");
            // 但你需要冒险在火堆旁多待一段时间。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_REPEAT_#1_799_M", "But you would need to risk another moment by the fire.", "然汝须更冒一须臾之险于火旁。");
            // [c:bG]就放在那里吧。[c:]一名幸存者说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_REPEAT_#2_299_M", "[c:bG]Keep it right there.[c:] Said one survivor.", "[c:bG]姑置之于是。[c:]一余生者曰。");
            // 那造物将变得更加强大……
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_REPEAT_#2_611_M", "The creature could become more powerful...", "其物可益强……");
            // 但幸存者们看起来越发饥饿。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_REPEAT_#2_157_M", "But the survivors looked hungrier by the second.", "然诸余生者顷刻愈饥。");
            // 你开始考虑把这只造物留在火堆旁再待会儿。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK1_REPEAT_#3_295_M", "You considered leaving the creature by the fire for another moment.", "汝思使此物更留火旁须臾。");
            // 你还没来得及抽身离开，一名幸存者就跳到了[c:bR][v:0][c:]身上。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_780_M", "Before you could pull away, one of the survivors leapt upon the [c:bR][v:0][c:].", "汝未及引退，一余生者已扑于[c:bR][v:0][c:]。");
            // 另一人抄起长矛捅向它。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_103_M", "Another jabbed it with a spear.", "又一人以矛刺之。");
            // 在那怪诞的进食狂潮面前，你移开了目光。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_330_M", "You looked away as a grotesque feeding frenzy ensued.", "怪食狂作，汝乃避视。");
            // 鲜血四溅、残骨乱飞，你离开了现场。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_556_M", "Blood and bones flew left and right as you retreated from the scene.", "血骨横飞，汝乃退去。");
            // 你还没来得及阻止，其中一名幸存者就抓住了[c:bR][v:0][c:]，开始撕咬它的肉。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#1_704_M", "Before you could stop them, one of the survivors seized the [c:bR][v:0][c:] and began tearing at its flesh.", "汝未及止之，一余生者已执[c:bR][v:0][c:]而裂其肌。");
            // 其他幸存者也有样学样，开始活活吞食你的造物。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#1_750_M", "The other survivors followed the example and began devouring your creature alive.", "诸余生者效之，遂生啖乃物。");
            // 害怕自己小命不保，你退缩了。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#1_479_M", "Fearing for your own life, you retreated.", "惧祸及己，汝乃退。");
            // [c:bG]进食时间到！[c:]一名幸存者尖叫着，跳到[c:bR][v:0][c:]身上。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#2_349_M", "[c:bG]Feeding time![c:] screamed one survivor, leaping upon the [c:bR][v:0][c:].", "[c:bG]食时至矣！[c:]一余生者号而扑于[c:bR][v:0][c:]。");
            // 野兽的内脏当场被他们的长矛捅了出来。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#2_329_M", "Their spears promptly eviscerated the beast.", "诸矛立裂其腹，脏腑尽出。");
            // 听着那令人作呕的龇牙声和嚎叫声，你偷偷溜走了。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#2_899_M", "You snuck away amid the sickening sounds gnashing and howling.", "龁噬号呼之声令人欲呕，汝乃潜遁。");
            // 几名幸存者突然向那头野兽发起攻击。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#3_478_M", "In an instant, several survivors set upon the beast.", "俄顷，数余生者并扑其兽。");
            // 营地里满地都是鲜血残骸，那可怜的造物被撕成了碎片。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#3_022_M", "Blood and bones littered the campsite as the poor creature was torn limb from limb.", "可怜其物裂为数段，营地血骨狼藉。");
            // 你感到胃部不适，转身逃离了这场大屠杀。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATEN_REPEAT_#3_756_M", "Sick to your stomach, you turned away from the carnage and retreated.", "腹中欲呕，汝乃背此惨象而退。");
            // 幸运之神帮过你。也许还会再帮你一次？
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK2_479_M", "Luck was on your side. Perhaps one more moment?", "运在汝侧。其可更一须臾乎？");
            // 但你感觉到现在的风险更大了。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK2_168_M", "But you sensed the risk was now even greater.", "然汝觉其危今愈甚。");
            // 之前是挺幸运的。也许你可以再碰碰运气？
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK2_REPEAT_#1_170_M", "You were feeling lucky. Perhaps you could chance another moment?", "汝方自谓运在。其可更冒一须臾乎？");
            // 你注意到一名幸存者握紧了长矛，令人十分不安。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK2_REPEAT_#1_290_M", "You noticed a survivor gripping their spear with a disturbing intensity.", "汝见一余生者力执其矛，殊可惧也。");
            // [c:bG]这气味……[c:]一名幸存者说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK2_REPEAT_#2_966_M", "[c:bG]That smell...[c:] Said one survivor.", "[c:bG]此气……[c:]一余生者曰。");
            // 目前为止你的运气都不错……但好运能一直维持下去吗？
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK2_REPEAT_#2_159_M", "Your luck had prevailed thus far... but could it hold out?", "迄于今，运犹助尔……然其能终乎？");
            // 你开始流汗了。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK3_057_M", "You began to sweat.", "汝始汗出。");
            // 幸存者们开始向这只造物周围靠拢。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK3_588_M", "The survivors began to close in around the creature.", "诸余生者始环逼其物。");
            // 这只造物变得极其强大。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK3_REPEAT_#1_007_M", "The creature was becoming impressively powerful.", "此物方益强，诚可观也。");
            // 但有几名幸存者流下了口水。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK3_REPEAT_#1_177_M", "But several survivors were now drooling.", "然数余生者今垂涎矣。");
            // [c:bG]差不多到时间了……[c:]一名幸存者说道。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK3_REPEAT_#2_807_M", "[c:bG]It's almost time...[c:] Said one survivor.", "[c:bG]时殆至矣……[c:]一余生者曰。");
            // 幸存者们警觉地站着，眼睛死死盯着你的造物。
            AddTranslation("SPECIAL_NODES_STATBOOSTPUSHLUCK3_REPEAT_#2_816_M", "The survivors stood alert, their eyes fixed upon your creature.", "诸余生者警立，目尽注乃物。");
            // 嘿哎哎哎哎吼！是金子！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEGOLD_357_M", "Heeeeeeee-haaw! 'tis gold!", "嘿哎哎哎—吼！金也！");
            // 老子可不忍心把它交给你……
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEGOLD_318_M", "I can barely abide giving it to ye...", "此物付你，俺心甚不忍……");
            // 但在老子这儿，承诺就是承诺。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEGOLD_219_M", "But a promise is a promise where I'm from.", "然俺乡有言：诺既为诺。");
            // 绝了！是……是金子！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEGOLD_REPEAT_#1_930_M", "I'll be darned! It's g-gold!", "绝也！金—金也！");
            // 金……金子？！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEGOLD_REPEAT_#2_175_M", "G-gold?!", "金—金乎？！");
            // 嘿嘿嘿！金子！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEGOLD_REPEAT_#3_859_M", "HEE-HEE-HEEEE! GOLD!", "嘿—嘿—嘿！金也！");
            // 他奶奶的……没有金子。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_749_M", "Dag nab it... no gold.", "彼其娘也……无金。");
            // 但这小虫子看着挺有趣啊。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_888_M", "But that is a funny lookin' varmint.", "然此虫形颇异。");
            // 留着吧。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_310_M", "Keep it.", "持之。");
            // 那块巨石下就只有虫子……
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#1_398_M", "Only bugs unner that boulder...", "彼磐下唯虫耳……");
            // 奇怪的虫子，就那只。你想要？
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#1_209_M", "Strange varmint, that 'n. You want it?", "其虫异哉。你欲之乎？");
            // 没有金……金子？
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#2_442_M", "No g-gold?", "无金—金乎？");
            // 不过是只很奇怪的虫子？
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#2_172_M", "Just a strange lookin' varmint?", "唯一异虫而已乎？");
            // 拿着吧。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#2_852_M", "Take it.", "取之。");
            // 他奶奶的！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#3_737_M", "Dag nab it!", "彼其娘之！");
            // 老子不是为了奇怪的小虫来的。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICECREATURE_REPEAT_#3_812_M", "I ain't in it for strange varmints.", "俺来非为异虫也。");
            // 你遇到了一个佝偻着的人，站在一堆巨石旁……
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_573_M", "You came across a hobbled man standing beside some boulders...", "汝遇一伛人，立数磐之旁……");
            // 你真是让我措手不及！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_412_M", "Ye caught me off guard!", "你来猝矣！");
            // 应该在更后头的地方才能碰上老子的。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_735_M", "Not s'pposed to see me 'til further down the road.", "你本当更下此途，乃见俺耳。");
            // 说起来啊……老子就喜欢赌。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_353_M", "Say... I like me a gamble.", "且……俺好一赌。");
            // 要是你能挑到有金子的巨石……就能自己留着！
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_554_M", "Iffen ye can pick a boulder that has gold in it... Ye can keep it!", "你若能择一含金之磐……即归于你！");
            // 他娘的！你怎么来这么早。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_REPEAT_#1_203_M", "I'll be darned! Ye came across me early.", "可怪！你乃早遇我。");
            // 比一场，碰碰运气？
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_REPEAT_#1_390_M", "Care fer a game o' chance?", "欲试一局听运乎？");
            // 你挑块巨石，我来敲碎。如果有金子……那就是你的了。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_REPEAT_#1_367_M", "Pick a boulder 'n I'll break it. If it's gold... it's yers.", "择一磐，俺为你碎之。若其中有金……则归于你。");
            // 老子就喜欢赌……挑一块巨石。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_REPEAT_#2_895_M", "I like me a gamble... pick a boulder.", "俺好一赌……择一磐。");
            // 挑一块巨石。
            AddTranslation("SPECIAL_NODES_BOULDERCHOICEINTRO_REPEAT_#3_151_M", "Pick a boulder.", "择一磐。");
            // 老[c:bR]木雕师[c:]的脸上浮现出遗憾的神情。
            AddTranslation("SPECIAL_NODES_WOODCARVERMAXPIECES_324_M", "A look of regret fell over the old [c:bR]woodcarver[c:].", "[c:bR]刻木老妪[c:]面有悔色。");
            // 你被图腾碎片坠得喘不过气，无法携带更多碎片了。
            AddTranslation("SPECIAL_NODES_WOODCARVERMAXPIECES_946_M", "You were overburdened with totem pieces and you could carry no more.", "神偶诸刻累尔太重，不能复携。");
            // 她向潜伏在附近的某只令人不安的生物做了个手势。
            AddTranslation("SPECIAL_NODES_WOODCARVERMAXPIECES_537_M", "She gestured toward a disturbing creature lurking nearby.", "彼指近旁潜伏之一异物。");
            // 年老的[c:bR]木雕师[c:]看起来很哀伤。
            AddTranslation("SPECIAL_NODES_WOODCARVERMAXPIECES_REPEAT_#1_559_M", "The decrepit [c:bR]woodcarver[c:] looked mournful.", "[c:bR]刻木老妪[c:]貌甚哀。");
            // 你无法携带更多图腾部位了。
            AddTranslation("SPECIAL_NODES_WOODCARVERMAXPIECES_REPEAT_#1_428_M", "You could not carry any more totem pieces.", "汝不能复携神偶之刻。");
            // 她还有别的东西可以给你……
            AddTranslation("SPECIAL_NODES_WOODCARVERMAXPIECES_REPEAT_#1_183_M", "She had something else to offer...", "然彼别有所赠……");
            // 现在不行。没什么能勾住的。
            AddTranslation("GAMEPLAY_HINTS_HINT_FISHHOOKNOTARGET_301_M", "Not now. There's nothing that can be hooked.", "今不可。无可施钩者。");
            // 没有你能拉得了的。
            AddTranslation("GAMEPLAY_HINTS_HINT_FISHHOOKNOTARGET_REPEAT_#1_707_M", "There aren't any pulls that you can make.", "无所可曳。");
            // 没有什么能用钩子勾上的……
            AddTranslation("GAMEPLAY_HINTS_HINT_FISHHOOKNOTARGET_REPEAT_#2_158_M", "There's nothing that can be pulled with that hook...", "今无物可为此钩所曳……");
            // 来自[c:bR]钓鱼人[c:]的礼物。
            AddTranslation("PART_1_RUN_START_UNLOCKFISHHOOKITEM_723_M", "A gift from [c:bR]The Angler[c:].", "此[c:bR]渔父[c:]之赠。");
            // 看，他最近被打败了，还想着自救呢。
            AddTranslation("PART_1_RUN_START_UNLOCKFISHHOOKITEM_901_M", "You see, he was defeated recently and wishes to redeem himself.", "彼顷者见败，今欲自赎。");
            // 如果还没等他得到这个机会你就栽在了[c:bR]矿工[c:]手里，那就太不幸了。
            AddTranslation("PART_1_RUN_START_UNLOCKFISHHOOKITEM_739_M", "It would be unfortunate if you were to fall to [c:bR]The Prospector[c:] before he was given that chance.", "若彼未得此机，而汝先陷于[c:bR]采夫[c:]，则不幸矣。");
            // 这钩子很厉害。你可以用它偷走我的一张牌。
            AddTranslation("PART_1_RUN_START_UNLOCKFISHHOOKITEM_126_M", "This hook is powerful. You may steal one of my cards with it.", "此钩甚利。汝可以之窃朕一牌。");
            // 也正因如此，你在这条路上找不到其他钩子。
            AddTranslation("PART_1_RUN_START_UNLOCKFISHHOOKITEM_822_M", "For that reason, you will not find any others along the path.", "是以汝将不复见他钩于途。");
            // 妥善使用吧。
            AddTranslation("PART_1_RUN_START_UNLOCKFISHHOOKITEM_830_M", "Use it wisely.", "善用之。");
            // 你什么意思？你想干嘛？
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_486_M", "What is it? What do you want?", "何也？你欲何为？");
            // 我不过是个检查员罢了。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_841_M", "I am merely an inspector.", "我特察者耳。");
            // 你还给了我那么多文件检查！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_475_M", "And you've given me a lot of files to inspect!", "且你予我众牍，使我得察！");
            // 但我没什么可检查的……
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_796_M", "But I do not have much to inspect...", "然我今无多可察……");
            // 你想通过这道门？
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_803_M", "You wish to pass through this gate?", "你欲过此门乎？");
            // 试着检查一下巫师塔下的卫星碟形天线。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_984_M", "Try inspecting the satellite dish at the foot of the wizard tower.", "试察巫塔之下卫星之盘。");
            // 你没看到我正忙着检查你的文件吗？
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_REPEAT_#1_584_M", "Can't you see I'm busy inspecting your files?", "你不见我方忙于察乃牍乎？");
            // [c:bG]终极冥刻[c:]不等人！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_REPEAT_#1_509_M", "[c:bG]The Great Transcendence[c:] cannot wait!", "[c:bG]大陟[c:]不可俟也！");
            // 如果你想通过，首先你必须向南冒险。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_REPEAT_#1_839_M", "If you wish to pass, first you must venture South.", "你欲过此，先须南行。");
            // 找到巫师塔门口，继续往南走！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_REPEAT_#1_336_M", "At the door to the wizard's tower, head further South still!", "至巫塔之门，犹须更南！");
            // 要解开这道门，你必须向南冒险。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_REPEAT_#2_423_M", "To unlock this gate you must venture South.", "欲启此门，汝须南行。");
            // 现在离开吧！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_PREUNLOCK_REPEAT_#2_895_M", "Now be gone!", "今去！");
            // 能是什么呢？你解开了这道门。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_491_M", "What is it? You unlocked the gate.", "复何为？你已启此门矣。");
            // 继续吧！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_114_M", "So carry on!", "其行矣！");
            // 我有好多文件要检查！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_894_M", "I have so many files to inspect!", "我有众牍待察！");
            // ……何必呢？我又不是现在就有很多事要做。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_027_M", "...Why do I bother? It's not like I have a lot do right now.", "……我何自劳？左右今亦无多事。");
            // [c:bG]终极冥刻[c:]很快就会到来。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_REPEAT_#1_341_M", "[c:bG]The Great Transcendence[c:] will be upon us soon.", "[c:bG]大陟[c:]且至矣。");
            // 我在努力做好我的分内工作。
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_REPEAT_#1_083_M", "I'm trying to do my part.", "我方勉尽其分。");
            // 继续！
            AddTranslation("PART_3_MAP_HOLOMAPINSPECTOR_POSTUNLOCK_REPEAT_#2_664_M", "Carry on!", "其行！");
            // 嗷。[w:0.3]你可能也看到了，桥已经修好了。
            AddTranslation("GBC_NPC_MECHANICDOCKS_387_M", "Woof.[w:0.3] You probably saw that the bridge is fixed.", "呜。[w:0.3]汝盖已见桥既修矣。");
            // 现在他们想让我给你提供牌组建设技巧。
            AddTranslation("GBC_NPC_MECHANICDOCKS_568_M", "Now they want me to give you deckbuilding tips.", "今彼等欲余之以牌列之诀授汝。");
            // 比方说……[w:0.3][p:0.25][c:gray]使用稀有卡牌吧！[w:0.2]它们比普通卡牌更强大……[c:]
            AddTranslation("GBC_NPC_MECHANICDOCKS_135_M", "Like... [w:0.3][p:0.25][c:gray]Use your Rare cards![w:0.2] They are more powerful than common cards...[c:]", "如……[w:0.3][p:0.25][c:gray]用乃罕有牌！[w:0.2]其强于常牌……[c:]");
            // 但是[w:0.2]我确实厌倦了和这些冥刻者打交道。
            AddTranslation("GBC_NPC_MECHANICDOCKS_432_M", "But[w:0.2] I sure am sick of being around these Scrybes.", "然[w:0.2]余实厌与诸司锲处。");
            // 他们的野心一个比一个扭曲……[w:0.3]我绝不唬人。
            AddTranslation("GBC_NPC_MECHANICDOCKS_996_M", "Each has a more twisted ambition than the last...[w:0.3] I tell ya.", "其志比比更邪……[w:0.3]余言之。");
            // 就那个莱西？[w:0.3]这货就是一疯子！
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#1_070_M", "Leshy?[w:0.3] The guy's insane!", "莱西乎？[w:0.3]彼狂矣！");
            // 只是想把你这样的[c:R]挑战者[c:]当作玩物。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#1_236_M", "Wants to use [c:R]Challengers[c:] like you as his playthings.", "欲以若尔之[c:R]角者[c:]为戏具。");
            // 更为有悖常理的是，[w:0.3]他认为你真的乐在其中！
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#1_417_M", "To make it more perverse,[w:0.3] he thinks you'll actually enjoy it!", "尤悖者，[w:0.3]彼意汝之真乐之也！");
            // 对了……[w:0.3][p:0.25][c:gray]你得尽可能在牌组中组合搭配不同类型的卡牌，充分利用骨头、献祭血量和能量！[c:]
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#1_766_M", "Oh yeah... [w:0.3][p:0.25][c:gray]Try to use a mix of different types of cards in your deck to fully utilize your Bones, Blood and Energy![c:]", "然矣……[w:0.3][p:0.25][c:gray]牌列之中，宜杂用异类之牌，以尽用乃骨、血与能！[c:]");
            // P03……[w:0.3]那个机器人肯定有什么小九九。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#2_207_M", "P03...[w:0.3] that bot is planning something alright.", "鉟〇三……[w:0.3]彼机人必有所谋。");
            // 它让挖泥工加班加点地工作。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#2_863_M", "It's got The Dredger working overtime.", "彼使浚夫昼夜倍作。");
            // 哈？[w:0.3]哦……
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#2_712_M", "Huh?[w:0.3] Oh...", "咦？[w:0.3]哦……");
            // [p:0.25][c:gray]其他神庙里许多卡牌都是比松鼠更好的祭品炮灰。[c:]
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#2_545_M", "[p:0.25][c:gray]Many cards from other Temples are better sacrifice fodder than Squirrels.[c:]", "[p:0.25][c:gray]他庙多牌，为牺牲之资，胜于松鼠。[c:]");
            // [p:0.25][c:gray]比方说，[w:0.2]早期可以将骨堆用作祭品，但它在后期更有实用价值。[c:]
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#2_505_M", "[p:0.25][c:gray]For example,[w:0.2] Bone Heaps can be sacrificed early but have utility in the late-game.[c:]", "[p:0.25][c:gray]譬如[w:0.2]积骨早可为牺牲，然局之大后犹有其用。[c:]");
            // 我发誓，[w:0.3]格里魔拉想把一切都毁掉。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#3_910_M", "Grimora wants to bring it all down,[w:0.3] I swear.", "余敢誓，[w:0.3]格里魔拉欲倾此一切。");
            // 但我觉得更像是在发慈悲。[w:0.3]她可能是对的。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#3_870_M", "But more as a mercy I think.[w:0.3] She's probably right.", "然余以为，此毋宁恕耳。[w:0.3]彼殆是矣。");
            // 这张磁盘上[w:0.3]有的数据相当肮脏……
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#3_286_M", "There's some[w:0.3] pretty nasty DATA on this disk...", "此盘之中[w:0.3]有甚秽之档……");
            // 嗯哼。[w:0.3][p:0.25][c:gray]魔法卡牌为主的牌组会十分强大。[w:0.3]尝试挑选2个最好的宝石颜色，不要3个都选。[c:]
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#3_694_M", "Ahem. [w:0.3][p:0.25][c:gray]A deck focused on Magickal cards can be very powerful.[w:0.3] Try picking 2 of your best Gem Colors instead of going for all 3.[c:]", "咳。[w:0.3][p:0.25][c:gray]专尚术牌之牌列，其势甚强。[w:0.3]与其三色并取，不若择乃二善玉色。[c:]");
            // [p:0.25][c:gray]附有激活能力的卡牌是最强大的。[w:0.3]要相应地平衡你的资源。[c:]
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#4_856_M", "[p:0.25][c:gray]Cards with Activated Abilities are some of the most powerful.[w:0.3] Balance your resources accordingly.[c:]", "[p:0.25][c:gray]具按发印技之牌，最强者之一也。[w:0.3]宜随之而平乃资用。[c:]");
            // 怎么，[w:0.3]你想知道关于蔓尼菲科的情况？
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#4_550_M", "What,[w:0.3] you want to know about Magnificus?", "何，[w:0.3]汝欲知蔓尼菲科乎？");
            // 那是个神秘的家伙……[w:0.3]当然，咱们谁还没有自己的小心思呢。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#4_735_M", "Mysterious guy...[w:0.3] We all have our theories of course.", "彼人深秘……[w:0.3]余等固各有其说。");
            // 有人说他其实是[w:0.3]想要[w:0.3]……[w:0.2]不，[w:0.2]这太可怕了，说不得。
            AddTranslation("GBC_NPC_MECHANICDOCKS_REPEAT_#4_369_M", "Some say he actually[w:0.3] wants[w:0.3]...[w:0.2] No,[w:0.2] it's too terrible to say.", "或云彼实欲[w:0.3]……[w:0.2]不，[w:0.2]此惨甚，不可言。");
            // 这些骨头你可以留着。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATENBONES_343_M", "You may keep the bones.", "汝可留此骨。");
            // 给。留着这些骨头吧。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATENBONES_REPEAT_#1_757_M", "Here. Keep the bones.", "取之。留此骨。");
            // 这些骨头是你的了。
            AddTranslation("SPECIAL_NODES_STATBOOSTCARDEATENBONES_REPEAT_#2_113_M", "The bones are yours.", "此骨归尔。");
            // 这[c:bR]不是[c:]机托邦的巨型机器人。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_882_M", "This is [c:bR]not[c:] one of Botopia's Uberbots.", "此[c:bR]非[c:]机托邦之魁机人。");
            // 这些讨厌的蘑菇是从哪儿来的？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_483_M", "Where did these repugnant mushrooms come from?", "此等可厌之蕈，何从而来？");
            // 这奇怪的感觉是什么？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_060_M", "What is this strange feeling?", "此何怪感也？");
            // 我将尝试加速你的死亡。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTEDMOON_748_M", "I will attempt to hasten your demise.", "余将速乃死。");
            // 月亮将成为你的怜悯。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTEDMOON_818_M", "The Moon will be your mercy.", "月将为乃恕。");
            // 你手中已空空如也……饥肠辘辘。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTEDMOON_REPEAT_#1_127_M", "You've run out of cards... You're starving.", "乃牌已尽……汝饥矣。");
            // 动作快点。我们去看看这月亮能做什么。
            AddTranslation("GAME_FLOW_PART1CARDSEXHAUSTEDMOON_REPEAT_#1_572_M", "Let's speed things up. We'll see what this moon can do.", "姑速其事。且观此月何能。");
            // 这算什么？用[c:bR]臭臭印记[c:]削弱我的月亮……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSSTINKYMOON_729_M", "What is this? Weakening my Moon with the [c:bR]Stinky Sigil[c:]...", "此何也？以[c:bR]恶臭之印[c:]弱朕月……");
            // 说不通啊！
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSSTINKYMOON_496_M", "It makes no sense!", "此无理也！");
            // 月亮哪来的嗅觉啊！
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSSTINKYMOON_495_M", "Moons do not have a sense of smell!", "月安得有嗅！");
            // 这可不是我想象中的战斗……
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSSTINKYMOON_782_M", "This is not how I imagined this battle going...", "此非朕所料之战也……");
            // 用臭味……削弱我的月亮？
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSSTINKYMOON_REPEAT_#1_635_M", "Weakening my Moon... with a foul odor?", "以恶臭弱朕月乎……");
            // [c:bR]荒唐至极！[c:]
            AddTranslation("BOSS_DIALOGUE_LESHYBOSSSTINKYMOON_REPEAT_#1_707_M", "[c:bR]Absurd![c:]", "[c:bR]悖哉！[c:]");
            // 你来到此处，这里曾是个小型定居点。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_740_M", "You came across the remains of a small settlement.", "汝遇一小营之遗址。");
            // 这里没有活人。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_642_M", "No living person remained.", "无一生者存焉。");
            // 肯定是因为[c:bR]他们吃的东西[c:]的问题。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_812_M", "It must have been [c:bR]something they ate.[c:]", "殆其由[c:bR]所食者[c:]而死。");
            // 此处空无一人，但火势仍在蔓延。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_058_M", "The fire sputtered on in spite of their absence.", "其人虽亡，火犹噼然未息。");
            // 在一处废弃的定居点，躺着几具瘦骨嶙峋的尸体。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_REPEAT_#1_486_M", "A few emaciated corpses lay within an abandoned settlement.", "废营之中，横数羸尸。");
            // 你给他们吃了什么？
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_REPEAT_#1_788_M", "What did you feed them?", "汝以何食之？");
            // 火焰看上去一如既往地热情。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_REPEAT_#1_478_M", "The fire looked welcoming as always.", "其火望之，如常可亲。");
            // 这次不会有饥饿的幸存者来打扰你了。
            AddTranslation("SPECIAL_NODES_STATBOOSTSURVIVORSDEAD_REPEAT_#2_806_M", "No hungry survivors would be bothering you this time.", "此番不复有余生饥者扰尔矣。");
            // 我们已经获得了机器人的控制权！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSINTRO_203_M", "We have gained control of the robot!", "我曹已得制此机人！");
            // 全部的控制权！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSINTRO_278_M", "Complete control!", "尽得其制！");
            // 我们现在必须进行实验。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSINTRO_991_M", "We must now experiment.", "今须为试。");
            // 我们得玩一局牌。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSINTRO_846_M", "We must play a card game.", "今须博一局牌。");
            // 你真的买了[c:O]虚幻毛皮[c:]？
            AddTranslation("PART_3_MAP_HOLOAREASHOPBUYPELT_219_M", "You actually bought that [c:O]holo pelt[c:]?", "卿竟购此[c:O]幻裘[c:]乎？");
            // 它根本不值钱！拿给[c:O]毛皮商[c:]看看你就知道了。
            AddTranslation("PART_3_MAP_HOLOAREASHOPBUYPELT_337_M", "It's worthless! Take it to [c:O]The Trader[c:] and you'll see.", "此无所值！持诣[c:O]贾妇[c:]，卿自知之。");
            // 不！我还没准备好接受死亡。
            AddTranslation("MAGNIFICUSGAMEFLOWMANAGER_506", "No! I'm not ready to die yet.", "不！吾未备以死。");
            // 啊。该死。
            AddTranslation("PART3GAMEFLOWMANAGER_936", "Ugh. Damn it.", "噫。该死。");
            // [c:bR]告诉老子该打哪儿就好！[c:]
            AddTranslation("BOULDERCHOICESEQUENCER_101_M", "[c:bR]Show me where to strike![c:]", "[c:bR]示俺所击之处！[c:]");
            // 这场景的确很吓人。不过[c:bR]{0}[c:]的灵魂已经附身在[c:bR]{1}[c:]上了。
            AddTranslation("CARDMERGESEQUENCER_673_M", "A ghastly spectactle. But the soul of the [c:bR]{0}[c:] now lives in the [c:bR]{1}[c:].", "惨观也。然[c:bR]{0}[c:]之魂，今寓于[c:bR]{1}[c:]。");
            // 是挑战运气？还是见好就收？
            AddTranslation("CARDSTATBOOSTSEQUENCER_308_M", "Push your luck? Or pull away?", "更冒其运乎？抑引退乎？");
            // 是进一步碰碰运气？还是拔腿就跑？
            AddTranslation("CARDSTATBOOSTSEQUENCER_627_M", "Push your luck further? Or run back?", "欲更冒其运乎？抑奔还乎？");
            // 不顾一切地继续？
            AddTranslation("CARDSTATBOOSTSEQUENCER_734_M", "Recklessly continue?", "尚敢妄进乎？");
            // 带[c:bR]冲刺能手[c:]印记的卡牌
            AddTranslation("DECKTRIALSEQUENCER_289", "card with the [c:bR]Sprinter[c:] sigil", "负[c:bR]疾趋[c:]印契之牌");
            // [c:bR]{0}[c:]。{1}
            AddTranslation("FINALEDECKTRIALSEQUENCER_503_M", "The [c:bR]{0}[c:]. {1}", "[c:bR]{0}[c:]。{1}");
            // 哇哦。
            AddTranslation("RUNINTROSEQUENCER_251", "Woah.", "嚄。");
            // 我是不是……我刚刚是打败他了吧！
            AddTranslation("VICTORYFEASTSEQUENCER_332", "Did I just- I think I just beat him!", "吾方才—吾想吾方才胜彼矣！");
            // 嗷。
            AddTranslation("VICTORYFEASTSEQUENCER_398", "Oop.", "噢。");
            // 你勾不住它。
            AddTranslation("FISHHOOKITEM_576_M", "You can't hook that one.", "此不可钩。");
            // 没有位置，拉不了它。
            AddTranslation("FISHHOOKITEM_667_M", "There's no space to pull that one into.", "无隙可曳彼入。");
            // 你从哪儿得到的？
            AddTranslation("DOORUNLOCKAREASEQUENCER_679_M", "Where did you get that?", "汝安得此？");
            // 该死。
            AddTranslation("PERMADEATH_945", "God damn it.", "该死！");
            // 你收到了一枚古银币。
            AddTranslation("BROKENCOIN_684_M", "You received an Ancient Obol.", "汝得一古银币。");
            // 这他妈是什么鬼？
            AddTranslation("BONELORDNPC_216", "What the fuck is this?", "此何鬼物也？");
            // 妈的。
            AddTranslation("GRIMORABOSSOPPONENT_209", "Aw fuck.", "唉，彼娘。");
            // 你让我的[c:blGr]黏液法师[c:]也被删除了……
            AddTranslation("FINALEWIZARDBATTLESEQUENCER_960_M", "You've allowed my [c:blGr]Goo Mage[c:] to be deleted as well...", "子亦使朕[c:blGr]胶巫[c:]见削矣……");
            // 我还以为你俩会成为朋友呢！
            AddTranslation("FINALEWIZARDBATTLESEQUENCER_699_M", "I thought you two were becoming friends!", "吾本谓尔二人且为友矣！");
            // 一想到你如此轻易就让人读取你的文件……
            AddTranslation("FINALEWIZARDBATTLESEQUENCER_631_M", "To think you gave access to your files so easily...", "不意子轻以乃牍示人……");
            // 骨质号角
            AddTranslation("ACTIVATEDENERGYTOBONES_RULEBOOKNAME_519", "Bonehorn", "骨号");
            // 消耗1点能量，获得3根骨头。
            AddTranslation("ACTIVATEDENERGYTOBONES_RULEBOOKDESCRIPTION_823", "Pay 1 Energy to gain 3 Bones.", "费一能，得三骨。");
            // 号角声响起。
            AddTranslation("ACTIVATEDENERGYTOBONES_TRIGGERTEXT_881_M", "The Horn rings out.", "号声作矣。");
            // 粘人精
            AddTranslation("MOVEBESIDE_RULEBOOKNAME_466", "Clinger", "附趋");
            // 当你的一只造物放置于某个位置，[creature]将尽可能朝它们移动。
            AddTranslation("MOVEBESIDE_RULEBOOKDESCRIPTION_912", "When one of your creatures is placed in a space, [creature] will move towards them as far as possible.", "惟汝陈一物于一位，[creature]将尽其能以趋之。");
            // 巨型克拉肯
            AddTranslation("KRAKEN_DISPLAYEDNAME_835", "Great Kraken", "巨克拉肯");
            // 手牌触手
            AddTranslation("SQUIDCARDS_DISPLAYEDNAME_683", "Hand Tentacle", "手触");
            // 是我干的吗？
            AddTranslation("SQUIDCARDS_DESCRIPTION_196_M", "Did I do that?", "此朕所作乎？");
            // 鸟的尾羽
            AddTranslation("TAIL_BIRD_DISPLAYEDNAME_862", "Tail Feathers", "尾羽");
            // 毛尾巴
            AddTranslation("TAIL_FURRY_DISPLAYEDNAME_106", "Furry Tail", "毛尾");
            // 蠕动的腿
            AddTranslation("TAIL_INSECT_DISPLAYEDNAME_910", "Wriggling Leg", "蠕足");
            // 孤独的巫师机器人
            AddTranslation("BLUEMAGE_TALKING_DISPLAYEDNAME_568", "Lonely Wizbot", "孤巫机人");
            // 跑赢曲线
            AddTranslation("ABOVECURVE_DISPLAYEDNAME_503", "Curve Hopper", "越曲者");
            // 绿橙蓝的容器
            AddTranslation("SENTINELBLUE_DISPLAYEDNAME_835", "Goranj's Vessel", "绿橙之皿");
            // 橙蓝绿的容器
            AddTranslation("SENTINELGREEN_DISPLAYEDNAME_449", "Orlu's Vessel", "橙蓝之皿");
            // 蓝绿橙的容器
            AddTranslation("SENTINELORANGE_DISPLAYEDNAME_682", "Bleene's Vessel", "蓝绿之皿");
            // 骨王的号角
            AddTranslation("BONELORDHORN_DISPLAYEDNAME_019", "Bone Lord's Horn", "骨王之号");
            // 初级贤者
            AddTranslation("JUNIORSAGE_DISPLAYEDNAME_820", "Junior Sage", "少贤");
            // 鱼钩
            AddTranslation("FISHHOOK_RULEBOOKNAME_740", "Fish Hook", "鱼钩");
            // 钩走我一张牌，并占为己有。你方必须有一个空位放置卡牌。
            AddTranslation("FISHHOOK_RULEBOOKDESCRIPTION_834_M", "Hook one of my cards and take it as your own. You must have an empty space on your side to receive it.", "钩朕一牌，据为乃有。尔侧须有空位以受之。");
            // [creature]的力量等于4减去该造物与换手铃之间的距离。
            AddTranslation("BELLSTATICON_GBCDESCRIPTION_901", "The power of [creature] is equal to 4 minus the distance to the combat bell.", "[creature]之威，如四减其至战铃之距。");
            // 卡牌计数器
            AddTranslation("CARDSINHANDSTATICON_RULEBOOKNAME_153", "Card Counter", "计牌者");
            // 该印记代表的数值永远等于你手中的卡牌数。
            AddTranslation("CARDSINHANDSTATICON_RULEBOOKDESCRIPTION_159", "The value represented by this sigil is always equal to the number of cards in your hand.", "此印所指之值，恒如乃手中牌数。");
            // [creature]的力量等于你手中的卡牌数。
            AddTranslation("CARDSINHANDSTATICON_GBCDESCRIPTION_195", "The power of [creature] is equal to the number of cards in your hand.", "[creature]之威，如乃手中牌数。");
            // [creature]的力量永远等于与之正面对抗的造物力量。
            AddTranslation("MIRRORSTATICON_GBCDESCRIPTION_142", "The power of [creature] is always equal to the power of the creature opposing it.", "[creature]之威，恒如其对物之威。");
            // 闪光特效
            AddTranslation("OPTIONSUI_VALUE_294", "FLICKER FX", "明灭效");
            // 屏幕抖动
            AddTranslation("OPTIONSUI_VALUE_524", "SCREEN SHAKE", "屏震");
            // 那些[c:bR]蚂蚁[c:]真是可怕。很好，我会让它们加入你的牌组，供未来的挑战者使用。
            AddTranslation("DISCOVERABLECARD_ANTS_VALUE_893_M", "Formidable creatures, those [c:bR]Ants[c:]. Very well, I will add them to your deck and make them available for future challengers.", "彼[c:bR]蚁[c:]诚可畏也。善，余将益之于乃牌列，俾后之角者亦可得之。");
            // 有点意思……
            AddTranslation("DISCOVERABLECARD_CAGEDWOLF_VALUE_065", "Curious...", "异哉……");
            // 我非常喜欢在你遇见头目前把多余的蜡烛给你掐灭。也许现在你也会和我一样享受这个过程。
            AddTranslation("DISCOVERABLECARD_IMPROVEDSMOKE_VALUE_211_M", "I do relish snuffing out your excess candles before a Boss. Perhaps you will now enjoy it as much as I do.", "余诚乐于魁前灭乃余烛。今汝或亦将与我同乐焉。");
            // 我都忘了之前把它放在那儿了。很好，你可以把它加到牌组里。我时不时地给你发一张。
            AddTranslation("DISCOVERABLECARD_SKINK_VALUE_087_M", "I forgot that I had put that there. Very well, you may add it to your deck. And I'll deal you one every so often.", "余忘昔置之于彼。善，汝可益之于乃牌列。余亦时将以此频发诸尔。");
            // 啊……这张啊……
            AddTranslation("DISCOVERABLECARD_STINKBUG_VALUE_154_M", "Ah... that one...", "啊……彼牌……");
            // 你把三叶草的叶子从茎上扯下来了！
            AddTranslation("GBC_DOCKS_730_M", "You picked the clover leaf from the stem!", "汝自茎上摘其蓿叶！");
            // 你在基座顶上发现了一张卡牌！
            AddTranslation("GBC_TEMPLE_UNDEAD_392_M", "You found a card atop the pedestal!", "汝于座上得一牌！");
            // 你发现了一把闪着光的奇怪钥匙。其用途暂不明晰。
            AddTranslation("GBC_TEMPLE_UNDEAD_058_M", "You found a strange flickering key. Its use cannot yet be understood.", "汝得一异钥，明灭不定。其用今未可知。");
            // [c:R]骨王的股骨[c:]。能够在战斗开始时赋予持有者骨头。
            AddTranslation("GBC_TEMPLE_UNDEAD_650_M", "[c:R]The Bone Lord's Femur[c:]. It endows the holder with bones at the start", "[c:R]骨王之股骨[c:]。持之者开战即得骨。");
            // 简体中文
            AddTranslation("MISC_456", "Simplified Chinese", "简体汉文");
            // 繁体中文
            AddTranslation("MISC_993", "Traditional Chinese", "繁体汉文");
            // 开始画面
            AddTranslation("MISC_659", "Start Screen", "始屏");
            // 选项
            AddTranslation("MISC_970", "Options", "选项");
            // 变更牌组
            AddTranslation("MISC_056", "Alter Deck", "易牌之列");
            // 新游戏
            AddTranslation("MISC_089", "New Game", "新局");
            // 退出
            AddTranslation("MISC_561", "Quit", "退");
            // 认输
            AddTranslation("MISC_070", "Concede", "降");
            // 攻击
            AddTranslation("MISC_308", "attack", "攻");
            // 呃……一条环形虫都没有……
            AddTranslation("MISC_038_M", "Hmmm... Not a single Ring Worm...", "唔……一环虫亦无……");
            // 自动添加
            AddTranslation("MISC_222", "Auto-Complete", "自补");
            // 每个卡包内含1张稀有卡牌、2张普通死亡卡牌和2张任意普通卡牌。
            AddTranslation("MISC_909", "A pack containing 1 Rare and 2 Common Deathly cards and 2 Common cards of any type.", "一韬含罕死属牌一、常死属牌二，并任属常牌二。");
            // 每个卡包内含1张稀有卡牌、2张普通野兽卡牌和2张任意普通卡牌。
            AddTranslation("MISC_428", "A pack containing 1 Rare and 2 Common Beastly cards and 2 Common cards of any type.", "一韬含罕兽属牌一、常兽属牌二，并任属常牌二。");
            // 每个卡包内含1张稀有卡牌、2张普通科技卡牌和2张任意普通卡牌。
            AddTranslation("MISC_053", "A pack containing 1 Rare and 2 Common Techno cards and 2 Common cards of any type.", "一韬含罕机属牌一、常机属牌二，并任属常牌二。");
            // 每个卡包内含1张稀有卡牌、2张普通魔法卡牌和2张任意普通卡牌。
            AddTranslation("MISC_751", "A pack containing 1 Rare and 2 Common Magical cards and 2 Common cards of any type.", "一韬含罕术属牌一、常术属牌二，并任属常牌二。");
            // 卢克·卡德
            AddTranslation("MISC_289", "Luke Carder", "卢克·卡德");
            // P03
            AddTranslation("MISC_132", "P03", "鉟〇三");
            // 内存/DCIM
            AddTranslation("MISC_558", "Internal Memory / DCIM", "内存/DCIM");
            // 鲜血画家
            AddTranslation("MISC_150", "Blood Artist", "血绘者");
            // 完成你的第一张死亡卡。
            AddTranslation("MISC_014", "Complete your first Deathcard.", "成乃首张死牌。");
            // 无害昆虫
            AddTranslation("MISC_197", "Innocuous Insect", "无害虫");
            // 从保险箱中放出一只臭虫。
            AddTranslation("MISC_469", "Free a Stinkbug from the safe.", "自匮中释一臭虫。");
            // 放生兽群
            AddTranslation("MISC_616", "Uncage the Menagerie", "兽出笼");
            // 将狼雕像从笼子里释放出来。
            AddTranslation("MISC_382", "Free the Wolf Statue from its cage.", "释狼像出笼。");
            // 先人的预视
            AddTranslation("MISC_093", "Ancestral Vision", "往者视");
            // 用神奇的物件填满你空洞的眼窝。
            AddTranslation("MISC_504", "Fill your empty socket with something magical.", "以神异之物充乃空眶。");
            // 新生希望
            AddTranslation("MISC_350", "Reborn Hope", "更生望");
            // 找到备用胶卷。
            AddTranslation("MISC_764", "Find a spare film roll.", "得一馀影卷。");
            // 持久得胜
            AddTranslation("MISC_515", "Enduring Victory", "久得胜");
            // 打败莱西。
            AddTranslation("MISC_369", "Defeat Leshy.", "胜莱西。");
            // 重生
            AddTranslation("MISC_239", "Renewal", "新启之苏生");
            // 开始新游戏。
            AddTranslation("MISC_625", "Start a new game.", "启一新局。");
            // 败亡死灵术士
            AddTranslation("MISC_009", "Doomed Necromancer", "死灵之厄殁");
            // 通关死亡神庙。
            AddTranslation("MISC_458", "Complete the Temple of the Dead.", "通死庙。");
            // 复仇的德鲁伊
            AddTranslation("MISC_052", "Avenging Druid", "林精之还仇");
            // 通关野兽神庙。
            AddTranslation("MISC_934", "Complete the Temple of Beasts.", "通兽庙。");
            // 高明机械兽
            AddTranslation("MISC_138", "Accomplished Automaton", "工巧之机人");
            // 通关科技神庙。
            AddTranslation("MISC_633", "Complete the Temple of Technology.", "通机庙。");
            // 巫师导师
            AddTranslation("MISC_302", "Wizard Mentor", "巫者之尊师");
            // 通关魔法神庙。
            AddTranslation("MISC_680", "Complete the Temple of Magicks.", "通术庙。");
            // 矿工灾祸
            AddTranslation("MISC_794", "Miner's Bane", "采之厄");
            // 打败矿工。
            AddTranslation("MISC_523", "Defeat The Prospector.", "胜采夫。");
            // 苍鬓渔夫
            AddTranslation("MISC_782", "Grizzled Angler", "皤渔父");
            // 打败钓鱼人。
            AddTranslation("MISC_565", "Defeat The Angler.", "胜渔父。");
            // 面面相觑
            AddTranslation("MISC_748", "Face to Face", "二面觑");
            // 打败猎人和毛皮商。
            AddTranslation("MISC_057", "Defeat The Trapper and The Trader.", "胜猎夫兼贾妇。");
            // 松鼠驯师
            AddTranslation("MISC_216", "Squirrel Wrangler", "驭鼠者");
            // 用松鼠造成伤害赢得一场战斗。
            AddTranslation("MISC_875", "Win a battle with damage from Squirrels.", "以松鼠伤敌而胜一战。");
            // 恶心返场
            AddTranslation("MISC_152", "Gruesome Encore", "凄复呕");
            // 允许菌学家在一只本身已经是实验品的造物上进行实验。
            AddTranslation("MISC_389", "Allow The Mycologists to experiment on a creature that is already itself an experiment.", "助蕈家更试一既试之物。");
            // 角色反转
            AddTranslation("MISC_977", "Role Reversal", "攻守易");
            // 从钓鱼人那里偷回你的一只造物。
            AddTranslation("MISC_062", "Steal back one of your creatures from The Angler.", "自渔父回窃乃一物。");
            // 力量平衡
            AddTranslation("MISC_753", "Balance of Power", "力衡");
            // 允许P03获得Inscryption的控制权。
            AddTranslation("MISC_360", "Allow P03 to gain control of Inscryption.", "听鉟〇三得制《冥锲》。");
            // 分类归档
            AddTranslation("MISC_133", "Rank and File", "编次");
            // 打败档案保管员。
            AddTranslation("MISC_115", "Defeat The Archivist.", "胜典牍者。");
            // 捕捉菁华
            AddTranslation("MISC_984", "Essence Capture", "捕菁");
            // 打败照相师。
            AddTranslation("MISC_552", "Defeat The Photographer.", "胜取影者。");
            // 画家仆役
            AddTranslation("MISC_894", "Painter's Servant", "画役");
            // 打败未完成的头目。
            AddTranslation("MISC_801", "Defeat The Unfinished Boss.", "胜未竟之魁。");
            // 自然联系
            AddTranslation("MISC_706", "Natural Connection", "自然");
            // 打败乖乖。
            AddTranslation("MISC_147", "Defeat G0lly.", "胜乖乖。");
            // 谋杀
            AddTranslation("MISC_446", "Murder", "戕陨");
            // 目睹P03之死。
            AddTranslation("MISC_236", "Witness the death of P03.", "睹鉟〇三之死。");
            // 绚烂终曲
            AddTranslation("MISC_247", "Dramatic Finale", "剧终");
            // 完成Inscryption的收关任务。
            AddTranslation("MISC_212", "Complete the finale of Inscryption.", "成《冥锲》终局。");
            // 携手合力
            AddTranslation("MISC_176", "Collective Effort", "协携之共力");
            // 收齐原版Inscryption中的所有卡牌。
            AddTranslation("MISC_927", "Collect every card in the Original Inscryption.", "尽收原本《冥锲》诸牌。");
            // 魔鬼造孽
            AddTranslation("MISC_017", "Devil's Play", "鬼魔之局戏");
            // 在原版Inscryption中造成超过666点攻击。
            AddTranslation("MISC_889", "Attack for over 666 damage in the Original Inscryption.", "于原本《冥锲》，一攻逾六百六十六伤。");
            // 黑暗献祭
            AddTranslation("MISC_585", "Dark Offering", "玄冥之祀祭");
            // 向骨王献祭。
            AddTranslation("MISC_381", "Make an offering to The Bone Lord.", "献祭于骨王。");
            // 被遗忘的传说
            AddTranslation("MISC_783", "Forgotten Lore", "遗闻");
            // 从P03工厂的毛皮商那里获得所有5张卡牌。
            AddTranslation("MISC_713", "Receive all 5 cards from The Trader in P03's factory.", "尽受鉟〇三工厂贾妇之五牌。");
            // 残酷报赏
            AddTranslation("MISC_797", "Grim Bounty", "惨赏");
            // 摧毁一张3级赏金猎人卡牌。
            AddTranslation("MISC_750", "Destroy a Level 3 Bounty Hunter card.", "毁三级购捕者牌一。");
            // 苦痛悔恨
            AddTranslation("MISC_126", "Agonizing Remorse", "痛悔");
            // 不要清空回收箱。
            AddTranslation("MISC_460", "Don't empty the Recycling Bin.", "毋空回收箱。");
            // 消耗1点能量，可对带有此印记卡牌对面的造物造成1点伤害。
            AddTranslation("ACTIVATEDDEALDAMAGE_RULEBOOKDESCRIPTION_C_301", "Pay 1 Energy to deal 1 damage to the creature across from a card bearing this sigil.", "费一能，伤负此印契之牌之对物者一。");
            // 
            AddTranslation("ACTIVATEDHEAL_RULEBOOKDESCRIPTION_C_469", "Pay 2 Bones to heal a card bearing this sigil.", "费二骨，以疗负此印契之牌。");
            // 
            AddTranslation("ACTIVATEDRANDOMPOWERENERGY_RULEBOOKDESCRIPTION_C_643", "Pay 1 Energy to set the power of a card bearing this sigil randomly between 1 and 6.", "费一能，易负此印契之牌之威偶定于一至六间");
            // 
            AddTranslation("ACTIVATEDSACRIFICEDRAWCARDS_RULEBOOKDESCRIPTION_C_363", "If you have a Blue gem, sacrifice a card bearing this sigil to draw 3 cards.", "若有蓝玉，祀负此印契之牌得引三牌。");
            // 
            AddTranslation("ACTIVATEDSTATSUP_RULEBOOKDESCRIPTION_C_785", "Pay 2 Bones to increase the power and health of a card bearing this sigil by 1.", "费二骨，益负此印契之牌之威与命各一。");
            // 
            AddTranslation("ACTIVATEDSTATSUPENERGY_RULEBOOKDESCRIPTION_C_318", "Pay 3 Energy to increase the power and health of a card bearing this sigil by 1.", "费三能，使负此印契之牌之威与命各益一。");
            // 
            AddTranslation("BOMBSPAWNER_RULEBOOKDESCRIPTION_C_970", "When a card bearing this sigil is played, fill all empty spaces with Explode Bots.", "负此印契之牌既陈，以爆机人满诸空处。");
            // 
            AddTranslation("BONEDIGGER_RULEBOOKDESCRIPTION_C_110", "At the end of the owner's turn, a card bearing this sigil will generate 1 Bone.", "持牌者合终，负此印契之牌生一骨。");
            // 
            AddTranslation("BRITTLE_RULEBOOKDESCRIPTION_C_366", "After attacking, a card bearing this sigil perishes.", "攻后，负此印契之牌即死。");
            // 
            AddTranslation("CONDUITBUFFATTACK_RULEBOOKDESCRIPTION_C_937", "Other creatures within a circuit completed by a card bearing this sigil gain 1 power.", "凡处负此印契之牌所成回路之他物，威加一。");
            // 
            AddTranslation("CONDUITENERGY_RULEBOOKDESCRIPTION_C_032", "If a card bearing this sigil is part of a completed circuit, your Energy never depletes.", "若负此印契之牌与既成之回路，则乃能永不竭。");
            // 
            AddTranslation("CONDUITFACTORY_RULEBOOKDESCRIPTION_C_156", "Empty spaces within a circuit completed by a card bearing this sigil spawn L33pB0ts at the end of the owner's turn.", "持牌者合终，凡负此印契之牌所成回路之空位，各生一跃机人。");
            // 
            AddTranslation("CONDUITHEAL_RULEBOOKDESCRIPTION_C_630", "Other creatures within a circuit completed by a card bearing this sigil are healed at the end of the owner's turn.", "持牌者合终，凡负此印契之牌所成回路之他物，皆得疗。");
            // 
            AddTranslation("CONDUITNULL_RULEBOOKDESCRIPTION_C_451", "A card bearing this sigil may complete a circuit, but provides no effect.", "负此印契之牌可成回路，而无所效。");
            // 
            AddTranslation("DRAWNEWHAND_RULEBOOKDESCRIPTION_C_986", "When a card bearing this sigil is played, discard your hand then draw a new hand of 4 cards.", "负此印契之牌既陈，弃手中诸牌，而复引四牌。");
            // 
            AddTranslation("DROPRUBYONDEATH_RULEBOOKDESCRIPTION_C_897", "When a card bearing this sigil perishes, a Ruby Mox is created in its place.", "负此印契之牌死，则其处生一红玉玛珂。");
            // 
            AddTranslation("EXPLODEONDEATH_RULEBOOKDESCRIPTION_C_074", "When a card bearing this sigil dies, the creature opposing it, as well as adjacent friendly creatures, are dealt 10 damage.", "负此印契之牌死，则其所对之物与邻侧己物皆受十伤。");
            // 
            AddTranslation("GAINBATTERY_RULEBOOKDESCRIPTION_C_264", "When a card bearing this sigil is played, it provides an Energy Cell to its owner.", "负此印契之牌既陈，为持牌者益一能格。");
            // 
            AddTranslation("GAINGEMBLUE_RULEBOOKDESCRIPTION_C_786", "While a card bearing this sigil is on the board, it provides a Blue Gem to its owner.", "负此印契之牌在局，则为持牌者供蓝玉一。");
            // 
            AddTranslation("GAINGEMGREEN_RULEBOOKDESCRIPTION_C_169", "While a card bearing this sigil is on the board, it provides a Green Gem to its owner.", "负此印契之牌在局，则为持牌者供绿玉一。");
            // 
            AddTranslation("GAINGEMORANGE_RULEBOOKDESCRIPTION_C_270", "While a card bearing this sigil is on the board, it provides an Orange Gem to its owner.", "负此印契之牌在局，则为持牌者供橙玉一。");
            // 
            AddTranslation("GAINGEMTRIPLE_RULEBOOKDESCRIPTION_C_292", "While a card bearing this sigil is on the board, it provides a Green, Orange, and Blue gem to its owner.", "负此印契之牌在局，则为持牌者供绿、橙、蓝玉各一。");
            // 
            AddTranslation("GEMDEPENDANT_RULEBOOKDESCRIPTION_C_572", "If a card bearing this sigil's owner controls no Mox cards, a card bearing this sigil perishes.", "若负此印契之牌之主无玛珂牌，则负此印契之牌死。");
            // 
            AddTranslation("GEMSDRAW_RULEBOOKDESCRIPTION_C_172", "When a card bearing this sigil is played, you draw cards equal to the amount of Mox cards on your side of the board.", "负此印契之牌既陈，引牌如其持牌者之侧局上玛珂牌之数。");
            // 
            AddTranslation("LOOT_RULEBOOKDESCRIPTION_C_919", "When a card bearing this sigil deals damage directly, draw a card for each damage dealt.", "负此印契之牌直伤之时，每伤一，则引一牌。");
            // 
            AddTranslation("PREVENTATTACK_RULEBOOKDESCRIPTION_C_718", "If a creature would attack a card bearing this sigil, it does not.", "物若将攻负此印契之牌，自止之。");
            // 
            AddTranslation("SKELETONSTRAFE_RULEBOOKDESCRIPTION_C_216", "At the end of the owner's turn, a card bearing this sigil will move in the direction inscribed in the sigil and drop a Skeleton in its old space.", "持牌者合终，负此印契之牌循印所志之向而移，并遗一枯骨于故处。");
            // 
            AddTranslation("SQUIRRELSTRAFE_RULEBOOKDESCRIPTION_C_618", "At the end of the owner's turn, a card bearing this sigil will move in the direction inscribed in the sigil and drop a Squirrel in their old space.", "持牌者合终，负此印契之牌循印所志之向而移，并遗一松鼠于故处。");
            // 
            AddTranslation("SUBMERGESQUID_RULEBOOKDESCRIPTION_C_467", "A card bearing this sigil submerges itself during its opponent's turn. While submerged, opposing creatures attack its owner directly.", "负此印契之牌于敌合自潜；当其潜，敌物直伤其主。");
            // 
            AddTranslation("ALLSTRIKE_RULEBOOKDESCRIPTION_C_769", "A card bearing this sigil will strike each opposing space that is occupied by a creature. It will strike directly if no creatures oppose it.", "凡负此印契之牌之对位有物之处皆击之；若无所当，则直伤。");
            // 
            AddTranslation("BEESONHIT_RULEBOOKDESCRIPTION_C_919", "Once a card bearing this sigil is struck, a Bee is created in your hand. [define:Bee]", "负此印契之牌受一击，则于手生一蜂。[define:Bee]");
            // 
            AddTranslation("BUFFNEIGHBOURS_RULEBOOKDESCRIPTION_C_913", "Creatures adjacent to a card bearing this sigil gain 1 power.", "邻负此印契之牌之物，威加一。");
            // 
            AddTranslation("CORPSEEATER_RULEBOOKDESCRIPTION_C_169", "If a creature that you own perishes by combat, a card bearing this sigil in your hand is automatically played in its place.", "若持牌者之物战死，则手中负此印契之牌自陈于其处。");
            // 
            AddTranslation("CREATEBELLS_RULEBOOKDESCRIPTION_C_591", "When a card bearing this sigil is played, a Chime is created on each empty adjacent space. [define:DausBell]", "负此印契之牌既陈，每邻之空处各生一铃。[define:DausBell]");
            // 
            AddTranslation("CREATEDAMS_RULEBOOKDESCRIPTION_C_542", "When a card bearing this sigil is played, a Dam is created on each empty adjacent space. [define:Dam]", "负此印契之牌既陈，每相邻空处各生一堤。[define:Dam]");
            // 
            AddTranslation("DEATHTOUCH_RULEBOOKDESCRIPTION_C_609", "When a card bearing this sigil damages another creature, that creature perishes.", "负此印契之牌伤他物，则彼即死。");
            // 
            AddTranslation("DEBUFFENEMY_RULEBOOKDESCRIPTION_C_636", "The creature opposing a card bearing this sigil loses 1 power.", "负此印契之牌之对物，威减一。");
            // 
            AddTranslation("DRAWANT_RULEBOOKDESCRIPTION_C_010", "When a card bearing this sigil is played, an Ant is created in your hand.", "负此印契之牌既陈，于手生一蚁。");
            // 
            AddTranslation("DRAWCOPY_RULEBOOKDESCRIPTION_C_226", "When a card bearing this sigil is played, a copy of it is created in your hand.", "负此印契之牌既陈，于手生其同牌。");
            // 
            AddTranslation("DRAWCOPYONDEATH_RULEBOOKDESCRIPTION_C_876", "When a card bearing this sigil perishes, a copy of it is created in your hand.", "负此印契之牌死，则于手生其同牌。");
            // 
            AddTranslation("DRAWRABBITS_RULEBOOKDESCRIPTION_C_468", "When a card bearing this sigil is played, a Rabbit is created in your hand. [define:Rabbit]", "负此印契之牌既陈，于手生一兔。[define:Rabbit]");
            // 
            AddTranslation("EVOLVE_RULEBOOKDESCRIPTION_C_194", "A card bearing this sigil will grow into a more powerful form after 1 turn on the board.", "负此印契之牌居局一合，则进为更上之形。");
            // 
            AddTranslation("FLYING_RULEBOOKDESCRIPTION_C_638", "A card bearing this sigil will strike an opponent directly, even if there is a creature opposing it.", "纵对面有物，负此印契之牌亦可直伤其主。");
            // 
            AddTranslation("GUARDDOG_RULEBOOKDESCRIPTION_C_161", "When an opposing creature is placed opposite to an empty space, a card bearing this sigil will move to that empty space.", "敌物若陈于空位之对位，负此印契之牌即移以御之。");
            // 
            AddTranslation("ICECUBE_RULEBOOKDESCRIPTION_C_877", "When a card bearing this sigil perishes, the creature inside is released in its place.", "负此印契之牌死，则所藏之物出而居其处。");
            // 带有该印记的卡牌死亡时，原本获得的1根骨头将变为4根。
            AddTranslation("QUADRUPLEBONES_RULEBOOKDESCRIPTION_C_971", "When a card bearing this sigil dies, 4 bones are awarded instead of 1.", "负此印契之牌死，则所得之骨不一而四。");
            // 抽到带有该印记的卡牌时，此印记将被随机替换为另一印记。
            AddTranslation("RANDOMABILITY_RULEBOOKDESCRIPTION_C_130", "When a card bearing this sigil is drawn, this sigil is replaced with another sigil at random.", "负此印契之牌既引，此印契偶易为他印契。");
            // 
            AddTranslation("RANDOMCONSUMABLE_RULEBOOKDESCRIPTION_C_436", "When a card bearing this sigil is played, you will receive a random item as long as your pack is not full.", "负此印契之牌既陈，若器囊未盈，则得一偶器。");
            // 
            AddTranslation("REACH_RULEBOOKDESCRIPTION_C_386", "A card bearing this sigil will block an opposing creature bearing the Airborne sigil.", "负此印契之牌可御有翔袭印契之敌物。");
            // 
            AddTranslation("SACRIFICIAL_RULEBOOKDESCRIPTION_C_722", "When a card bearing this sigil is sacrificed it does not perish.", "负此印契之牌虽见祀，而不死。");
            // 
            AddTranslation("SHARP_RULEBOOKDESCRIPTION_C_386", "Once a card bearing this sigil is struck, the striker is then dealt a single damage point.", "负此印契之牌受一击，则击者亦受一伤。");
            // 
            AddTranslation("SPLITSTRIKE_RULEBOOKDESCRIPTION_C_724", "A card bearing this sigil will strike each opposing space to the left and right of the space across from it.", "负此印契之牌击其正对之左与右。");
            // 
            AddTranslation("SQUIRRELORBIT_RULEBOOKDESCRIPTION_C_213", "At the beginning of its owner's turn, a card bearing this sigil will pull small creatures, like Squirrels, into its orbit.", "持牌者合初，负此印契之牌引松鼠之属小物入厥轨。");
            // 
            AddTranslation("STEELTRAP_RULEBOOKDESCRIPTION_C_102", "When a card bearing this sigil perishes, the creature opposing it perishes as well. A pelt is created in your hand.", "负此印契之牌死，则其对物亦死；于手更生一裘革牌。");
            // 
            AddTranslation("STRAFE_RULEBOOKDESCRIPTION_C_931", "At the end of the owner's turn, a card bearing this sigil will move in the direction inscribed in the sigil.", "持牌者合终，负此印契之牌循印所志之向而移。");
            // 
            AddTranslation("STRAFEPUSH_RULEBOOKDESCRIPTION_C_708", "At the end of the owner's turn, a card bearing this sigil will move in the direction inscribed in the sigil. Creatures in the way will be pushed in the same direction.", "持牌者合终，负此印契之牌循印所志之向而移；当路之物，亦皆推于同向。");
            // 
            AddTranslation("TAILONHIT_RULEBOOKDESCRIPTION_C_390", "When a card bearing this sigil would be struck, a Tail is created in its place and a card bearing this sigil moves to the right.", "负此印契之牌将受击时，其处生一尾，而负此印契之牌右移。");
            // 
            AddTranslation("TRIPLEBLOOD_RULEBOOKDESCRIPTION_C_976", "A card bearing this sigil is counted as 3 Blood rather than 1 Blood when sacrificed.", "负此印契之牌见祀，则所当之血不一而三。");
            // 
            AddTranslation("TRISTRIKE_RULEBOOKDESCRIPTION_C_419", "A card bearing this sigil will strike each opposing space to the left, right, and center of it.", "负此印契之牌击其正对之左、右与中。");
            // 
            AddTranslation("TUTOR_RULEBOOKDESCRIPTION_C_400", "When a card bearing this sigil is played, you may search your deck for any card and take it into your hand.", "负此印契之牌既陈，可搜牌列，取任一牌入手。");
            // 
            AddTranslation("WHACKAMOLE_RULEBOOKDESCRIPTION_C_301", "When an empty space would be struck, a card bearing this sigil will move to that space to receive the strike instead.", "空位将受击时，负此印契之牌即移其处代受之。");
            // 带有该印记的卡牌对面的造物获得1点力量。
            AddTranslation("BUFFENEMY_RULEBOOKDESCRIPTION_C_508", "The creature opposing a card bearing this sigil gains 1 power.", "负此印契之牌之对物，威加一。");
            // 如带有该印记的卡牌处在回路中，则增加2点力量。
            AddTranslation("CELLBUFFSELF_RULEBOOKDESCRIPTION_C_256", "If a card bearing this sigil is within a circuit, it gains 2 power.", "若负此印契之牌处回路中，则威加二。");
            // 如带有该印记的卡牌阵亡时处在回路中，则会给你随机增加一张手牌。
            AddTranslation("CELLDRAWRANDOMCARDONDEATH_RULEBOOKDESCRIPTION_C_731", "If a card bearing this sigil is within a circuit when it perishes, a random card is created in your hand.", "若负此印契之牌死时处回路中，则于手生一偶牌。");
            // 如带有该印记的卡牌处在回路中，则会攻击正对面的左右两侧和中间位置各一次。
            AddTranslation("CELLTRISTRIKE_RULEBOOKDESCRIPTION_C_763", "If a card bearing this sigil is within a circuit, it will strike each opposing space to the left, right, and center of it.", "若负此印契之牌处回路中，则击其正对之左、右与中。");
            // 处在由带有该印记的卡牌构成的回路中的空位置可在持牌人回合结束时生成宝石容器。
            AddTranslation("CONDUITSPAWNGEMS_RULEBOOKDESCRIPTION_C_435", "Empty spaces within a circuit completed by a card bearing this sigil spawn Gem Vessels at the end of the owner's turn.", "持牌者合终，凡负此印契之牌所成回路之空位，各生一玉皿。");
            // 带有该印记的卡牌第一次受到攻击时免疫。
            AddTranslation("DEATHSHIELD_RULEBOOKDESCRIPTION_C_417", "The first time a card bearing this sigil would take damage, prevent that damage.", "负此印契之牌初受伤时，此伤不行。");
            // 带有该印记的卡牌阵亡时，用来创造它的文件会从你的硬盘里彻底删除。
            AddTranslation("DELETEFILE_RULEBOOKDESCRIPTION_C_810", "When a card bearing this sigil perishes the file used to create it is really deleted from your Hard Drive.", "负此印契之牌死，则造此物之牍真自乃坚盘尽削。");
            // 带有该印记的卡牌阵亡时，你随机增加一张手牌。
            AddTranslation("DRAWRANDOMCARDONDEATH_RULEBOOKDESCRIPTION_C_562", "When a card bearing this sigil perishes, a random card is created in your hand.", "负此印契之牌死，则于手生一偶牌。");
            // 带有该印记的卡牌受到攻击时，可以从空容器中抽一张牌。
            AddTranslation("DRAWVESSELONHIT_RULEBOOKDESCRIPTION_C_373", "Once a card bearing this sigil is struck, draw a card from your Empty Vessel pile.", "负此印契之牌受一击，则自虚皿列引一牌。");
            // 带有该印记的卡牌阵亡时，需选择文件，其大小将在天平上决定其伤害。
            AddTranslation("FILESIZEDAMAGE_RULEBOOKDESCRIPTION_C_105", "When a card bearing this sigil perishes, select a file. Place damage on the scales according to the file's size.", "负此印契之牌死，则择一牍；随其巨细，加伤于衡。");
            // 带有该印记的卡牌阵亡时，其持牌人需选定下一个继承脆骨印记的造物。
            AddTranslation("LATCHBRITTLE_RULEBOOKDESCRIPTION_C_583", "When a card bearing this sigil perishes, its owner chooses a creature to gain the Brittle sigil.", "负此印契之牌死，则持牌者择一物，受脆骨印契。");
            // 带有该印记的卡牌阵亡时，其持牌人需选定下一个继承纳米铠甲印记的造物。
            AddTranslation("LATCHDEATHSHIELD_RULEBOOKDESCRIPTION_C_714", "When a card bearing this sigil perishes, its owner chooses a creature to gain the Nano Armor sigil.", "负此印契之牌死，则持牌者择一物，受微铠印契。");
            // 带有该印记的卡牌阵亡时，其持牌人需选定下一个继承引爆器印记的造物。
            AddTranslation("LATCHEXPLODEONDEATH_RULEBOOKDESCRIPTION_C_905", "When a card bearing this sigil perishes, its owner chooses a creature to gain the Detonator sigil.", "负此印契之牌死，则持牌者择一物，受引爆印契。");
            // 
            AddTranslation("MOVEBESIDE_RULEBOOKDESCRIPTION_C_379", "When one of your creatures is placed in a space, a card bearing this sigil will move towards them as far as possible.", "惟汝陈一物于一位，负此印契之牌将尽其能以趋之。");
            // 带有该印记的卡牌力量得到了提升。但如果阵亡，它将从你的牌组永久移除。
            AddTranslation("PERMADEATH_RULEBOOKDESCRIPTION_C_240", "A card bearing this sigil has increased power. But, if A card bearing this sigil perishes, it is permanently removed from your deck.", "负此印契之牌威益。然若负此印契之牌死，则永削于乃牌列。");
            // 任何造物在进入带有该印记的卡牌对面的位置时，均会受到1点伤害。
            AddTranslation("SENTRY_RULEBOOKDESCRIPTION_C_872", "When a creature moves into the space opposing a card bearing this sigil, they are dealt 1 damage.", "物若移入负此印契之牌之对位，则受一伤。");
            // 使用带有该印记的卡牌时，持牌人侧牌桌上所有宝石容器均获得纳米铠甲。
            AddTranslation("SHIELDGEMS_RULEBOOKDESCRIPTION_C_943", "When a card bearing this sigil is played, all Gem Vessels on the owners' side of the board gain Nano Armor.", "负此印契之牌既陈，持牌者之侧局上之玉皿皆得微铠。");
            // 你可以选择带有该印记的卡牌攻击的对手位置。
            AddTranslation("SNIPER_RULEBOOKDESCRIPTION_C_237", "You may choose which opposing space a card bearing this sigil strikes.", "可择负此印契之牌所击之敌位。");
            // 在带有该印记的卡牌受到伤害后，可互换力量与生命。
            AddTranslation("SWAPSTATS_RULEBOOKDESCRIPTION_C_983", "After a card bearing this sigil is dealt damage, swap its Power and Health.", "负此印契之牌受伤，而后其威与命互易。");
            // 在你的回合开始时，带有该印记的卡牌会在当前状态和野兽状态间切换一次。
            AddTranslation("TRANSFORMER_RULEBOOKDESCRIPTION_C_775", "At the beginning of your turn a card bearing this sigil will transform to, or from, Beast mode.", "乃合初，负此印契之牌化入兽形，或自兽形返。");
            // 
            AddTranslation("ANTSSTATICON_GBCDESCRIPTION_C_709", "The power of a card bearing this sigil is equal to the number of Ants that the owner has on their side of the table.", "负此印契之牌之威，如持牌者案上此侧之蚁数。");
            // 
            AddTranslation("BELLSTATICON_GBCDESCRIPTION_C_020", "The power of a card bearing this sigil is equal to 4 minus the distance to the combat bell.", "负此印契之牌之威，如四减其至战铃之距。");
            // 
            AddTranslation("CARDSINHANDSTATICON_GBCDESCRIPTION_C_892", "The power of a card bearing this sigil is equal to the number of cards in your hand.", "负此印契之牌之威，如乃手中牌数。");
            // 带有该印记的卡牌的力量等于持牌人侧牌桌上存在的绿宝石数量。
            AddTranslation("GREENGEMSSTATICON_GBCDESCRIPTION_C_503", "The power of a card bearing this sigil is equal to the number of Green Gems that the owner has on their side of the table.", "负此印契之牌之威，如案上持牌者之侧绿玉之数。");
            // 
            AddTranslation("MIRRORSTATICON_GBCDESCRIPTION_C_716", "The power of a card bearing this sigil is always equal to the power of the creature opposing it.", "负此印契之牌之威，恒如其对物之威。");
            // 合二为一！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSCOMBINE_545_M", "Two into one!", "二合而壹！");
            // 是。删除存档。
            AddTranslation("MENUCONTROLLER_157", "Yes. Erase save.", "然。削存录。");
            // 否。保留存档。
            AddTranslation("MENUCONTROLLER_963", "No. Keep save.", "否。留存录。");
            // 正在解压旧_数据.zip
            AddTranslation("MISC_353", "Unpacking OLD_DATA.zip", "惟“旧_档.zip”之解");
            // 正在解压
            AddTranslation("MISC_158", "Unpacking", "惟之解");
            // 隐去
            AddTranslation("MISC_838", "REDACTED", "阙如");
            // 你怯生生地将[c:bR]毛皮[c:]献给了骨王……
            AddTranslation("SPECIAL_NODES_CARDREMOVEPELTCHOSEN1_025_M", "You sheepishly offered the [c:bR]pelt[c:] to the Bone Lord...", "汝赧然献[c:bR]裘革[c:]于骨王……");
            // 你尴尬地把你的[c:bR]毛皮[c:]献给了骨王……
            AddTranslation("SPECIAL_NODES_CARDREMOVEPELTCHOSEN1_REPEAT_#1_938_M", "Embarrassed, you presented your [c:bR]pelt[c:] to the Bone Lord...", "汝惭而陈乃[c:bR]裘革[c:]于骨王……");
            // 你将[c:bR]毛皮[c:]放在骨王面前……
            AddTranslation("SPECIAL_NODES_CARDREMOVEPELTCHOSEN1_REPEAT_#2_633_M", "You placed a [c:bR]pelt[c:] before the Bone Lord...", "汝置一[c:bR]裘革[c:]于骨王前……");
            // 骨王很不高兴。你不会得到任何回报。
            AddTranslation("SPECIAL_NODES_CARDREMOVEPELTCHOSEN2_010_M", "The Bone Lord was displeased. You would receive nothing in return.", "骨王弗悦。汝不得其报。");
            // 骨王颤抖了一下。你移开目光，退到了一边。
            AddTranslation("SPECIAL_NODES_CARDREMOVEPELTCHOSEN2_REPEAT_#1_508_M", "The Bone Lord shuddered. You averted your eyes and backed away.", "骨王战然。汝避目而却。");
            // 我不知道你是在期待什么。
            AddTranslation("SPECIAL_NODES_CARDREMOVEPELTCHOSEN2_REPEAT_#2_663_M", "I'm not sure what you expected.", "余不知汝何所望也。");
            // 骨王对你的祭品非常满意。
            AddTranslation("SPECIAL_NODES_CARDREMOVEGOATCHOSEN_477_M", "The Bone Lord was immensely pleased by your offering.", "骨王甚悦乃所祀。");
            // 骨王对你的祭品深感满意。
            AddTranslation("SPECIAL_NODES_CARDREMOVEGOATCHOSEN_REPEAT_#1_636_M", "The Bone Lord was deeply satisfied with your offering.", "骨王深悦乃所祀。");
            // 终极献祭。骨王欣喜若狂。
            AddTranslation("SPECIAL_NODES_CARDREMOVEGOATCHOSEN_REPEAT_#2_515_M", "The ultimate sacrifice. The Bone Lord was gleeful.", "至极之祀。骨王欣甚。");
            // 输入“继续”恢复加载游戏。
            AddTranslation("COMMANDLINEINTERFACE_667", "Type 'continue' to return to loading the game.", "书“续”以复载此戏。");
            // 继续
            AddTranslation("COMMANDLINEINTERFACE_324", "continue", "续");
            // 无法找到指定路径。
            AddTranslation("COMMANDLINEINTERFACE_978", "Cannot find the specified path.", "未见所指之径。");
            // 非文件。
            AddTranslation("COMMANDLINEINTERFACE_506", "Not a file.", "非牍。");
            // 内容无法显示。
            AddTranslation("COMMANDLINEINTERFACE_729", "Contents cannot be shown.", "其中不可示。");
            // 输入密码：
            AddTranslation("COMMANDLINEINTERFACE_183", "Enter cipher:", "书密辞：");
            // 你不能这么做。
            AddTranslation("COMMANDLINEINTERFACE_662", "You must not do that.", "汝毋为此。");
            // 无法进行此操作。
            AddTranslation("COMMANDLINEINTERFACE_428", "You cannot do that.", "汝不能为此。");
            // 确定删除所有存档数据？（是/否）
            AddTranslation("COMMANDLINEINTERFACE_670", "Really delete all save data? (y/n)", "果欲尽削诸存录之档乎？(是/否)");
            // 勇气可嘉。
            AddTranslation("COMMANDLINEINTERFACE_293", "You are brave.", "汝其勇哉。");
            // 你个懦夫。
            AddTranslation("COMMANDLINEINTERFACE_213", "You are coward.", "汝乃懦夫。");
            // “{0}”并非受认可的内部或外部命令。
            AddTranslation("COMMANDLINEINTERFACE_701", "'{0}' is not a recognized internal or external command.", "“{0}”非所识之内、外命。");
            // 左下方的数字是其攻击力：1。
            AddTranslation("TUTORIAL1BATTLESEQUENCER_200_M", "The number on the bottom left is its Attack Power: 1.", "左下之数，乃其攻威：1。");
            // 会空袭的[c:bR]蝙蝠[c:]可飞越造物，直接攻击。
            AddTranslation("TUTORIAL2BATTLESEQUENCER_099_M", "The airborne [c:bR]Bat[c:] flies over creatures to attack directly.", "翔袭之[c:bR]蝠[c:]可越诸物而直攻。");
            // 小心雄心勃勃的[c:bR]狼崽[c:]。它成长得很快。
            AddTranslation("TUTORIAL2BATTLESEQUENCER_164_M", "Mind the ambitious [c:bR]Wolf Cub[c:]. It ages swiftly.", "慎彼志盛之[c:bR]狼崽[c:]。其长甚速。");
            // 我的图腾赋予了我的郊狼飞行能力！
            AddTranslation("TUTORIAL3BATTLESEQUENCER_816_M", "My totem has granted my Coyote the power of flight!", "朕神偶赐朕郊狼以翔袭之能！");
            // 制作团队
            AddTranslation("MISC_159", "Credits", "列名");
            // 创作者
            AddTranslation("MISC_295", "Creator", "制者");
            // 作曲和音效设计师
            AddTranslation("MISC_542", "Composer and Sound Designer", "作乐兼治声者");
            // 首席3D美术师
            AddTranslation("MISC_355", "Principal 3D Artist", "3D首席艺者");
            // 饰卢克·卡德
            AddTranslation("MISC_921", "As Luke Carder", "饰卢克·卡德");
            // 饰杀手
            AddTranslation("MISC_706", "As His Killer", "饰杀者");
            // 饰<REDACTED>
            AddTranslation("MISC_438", "As <REDACTED>", "饰<阙如>");
            // 3D环境艺术和黏液
            AddTranslation("MISC_026", "3D Environment Art and Goobert", "3D景艺及黏伯特");
            // 3D环境艺术和道具
            AddTranslation("MISC_971", "3D Environment Art and Props", "3D景艺及器物");
            // 3D低多边形艺术
            AddTranslation("MISC_451", "3D Low Poly Art", "3D低面艺");
            // 分离着色
            AddTranslation("MISC_382", "Color Posterization Shader", "分色着色法");
            // 配色设计
            AddTranslation("MISC_216", "Color Palette Design", "配色之设");
            // 字体
            AddTranslation("MISC_730", "Fonts", "字形");
            // 共享创意3D艺术
            AddTranslation("MISC_679", "Creative Commons 3D Art", "共享创意3D之艺");
            // 第三方工具/资源
            AddTranslation("MISC_407", "3rd Party Tools / Assets", "三方之具与资材");
            // 特别鸣谢
            AddTranslation("MISC_787", "Special Thanks", "特谢");
            // 格里魔拉配音
            AddTranslation("MISC_024", "Voice of Grimora", "格里魔拉之声");
            // 菌学家
            AddTranslation("MISC_798", "The Mycologists", "蕈家");
            // 游戏设计建议
            AddTranslation("MISC_308", "Game Design Advice", "戏制之议");
            // 游戏测试和顾问委员会
            AddTranslation("MISC_033", "Playtesting and Sounding Board", "试戏兼献议");
            // 高强度测试
            AddTranslation("MISC_423", "Extensive Playtesters", "勤试戏者");
            // 本地化字体编辑
            AddTranslation("MISC_362", "Localized Font Editing", "方译字形修治");
            // 关于渲染问题的特别帮助
            AddTranslation("MISC_462", "Special Help with Rendering Issue", "渲染之难特助");
            // 后期效果跟踪
            AddTranslation("MISC_890", "After Effects Footage Tracking", "后效影迹追踪");
            // Discord管理员
            AddTranslation("MISC_142", "Discord Admins", "Discord主事者");
            // Indiepod组织方
            AddTranslation("MISC_249", "Organizers of Indiepod", "Indiepod主办者");
            // 精神支持
            AddTranslation("MISC_480", "Moral Support", "襄助");
            // 游戏玩家
            AddTranslation("MISC_399", "Playing The Game", "游此戏者");
            // 本地化团队
            AddTranslation("MISC_934", "Localization Team", "方译之众");
            // 我看到你有张毛皮的照片。[w:0.3]隔壁的毛皮商应该会想要的。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#1_411_M", "I see you have a photo of a pelt.[w:0.3] The Trader next door may desire it.", "余见汝有裘革之影。[w:0.3]隔壁贾妇或欲之。");
            // 可怜的野兔啊……[w:0.3]把照片拿给毛皮商吧。[w:0.3]就在你右手边。
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#2_722_M", "Poor hare...[w:0.3] Take that photo to The Trader.[w:0.3] She is to your right.", "兔可怜矣……[w:0.3]持此影予贾妇。[w:0.3]彼在乃右。");
            // 从你右手边的门出去吧。[w:0.3]毛皮商在等你……
            AddTranslation("GBC_NPC_LESHYGBCGIVECAMERA1_REPEAT_#3_612_M", "Go through the door to your right.[w:0.3] The Trader awaits...", "出乃右之门。[w:0.3]贾妇俟矣……");
            // 你想取代我啊。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO1_436_M", "You wanted to replace me.", "汝欲易我。");
            // 瞧瞧咱俩现在的处境。
            AddTranslation("PART_3_GAME_FLOW_PART3INTRO1_847_M", "Look at us now.", "观咱等今何如。");
            // 你的道具都重新装填了。
            AddTranslation("PART_3_MAP_HOLOMAPREACHEDCHECKPOINT_REPEAT_#2_478_M", "Your items are replenished.", "卿器复充矣。");
            // 接下来要上的是你真的拥有的文件。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_634_M", "Here comes your actual files.", "今乃真牍至矣。");
            // 希望眼下没人在看！
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTCHOOSEDAMAGEFILE_206_M", "I hope no one is watching!", "愿无人窥之！");
            // 想想看……你居然妄图取代格里魔拉。
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLE1_127_M", "To think... your ambition was to replace Grimora.", "不意……卿之志乃欲易格里魔拉。");
            // 就为了继承[c:bR]这破地方[c:]？
            AddTranslation("PART_3_MAP_HOLOAREAUNDEADTEMPLE1_736_M", "And inherit [c:bR]this[c:]?", "而承[c:bR]此[c:]乎？");
            // 你试图取代他是正确的。
            AddTranslation("PART_3_MAP_HOLOAREANATURETEMPLE1_153_M", "You were right to try to replace him.", "卿欲易彼，诚然善。");
            // 你也知道他的。
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLE1_351_M", "Well, you knew him.", "然，卿知彼也。");
            // 你居然想取代他！
            AddTranslation("PART_3_MAP_HOLOAREAWIZARDTEMPLE1_292_M", "You wanted to replace him!", "卿竟欲易彼！");
            // 真的是好棒棒。
            AddTranslation("PART_3_STORY_PART3FINALE1_505_M", "Great job.", "真善也。");
            // 想取代我啊，那只能祝你好运了！
            AddTranslation("PART_3_STORY_PART3FINALE4_401_M", "Good luck replacing me now!", "今欲易我，愿汝自幸！");
            // 一切重置后，得知你想要取代我时，我还挺惊讶的……
            AddTranslation("FINALE_GOODBYELESHYMIDGAME1_798_M", "I was surprised when you wanted to replace me... After the reset.", "重置既毕，闻汝欲易我，余颇骇焉……");
            // 而且……就在最后的时刻，你居然选择了我，我十分惊讶。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME1_170_M", "And... I was surprised when, at the final moment, you chose me.", "且……终时汝乃择我，余亦骇焉。");
            // 但过去已经不重要了。
            AddTranslation("FINALE_GOODBYELESHYMIDGAME1_618_M", "But the past is irrelevant.", "然往者不足论。");
            // 我当然会原谅你啦……
            AddTranslation("FINALE_FINALEGRIMORAMAPSHOWN_038_M", "Of course I forgive you...", "余固恕汝……");
            // 又是想要取代我又是怎么着的。
            AddTranslation("FINALE_FINALEGRIMORAMAPSHOWN_286_M", "For trying to replace me and all of that.", "于汝欲易我，及其他诸事。");
            // 我的记忆有点模糊了……
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_REPEAT_#1_050_M", "I have a vague memory...", "咱之忆，颇昧……");
            // 你是为什么一遍又一遍回到这里来着？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_REPEAT_#1_259_M", "Why do you keep coming back here?", "卿何以数返于此？");
            // 奇怪……
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_REPEAT_#2_105_M", "So strange...", "怪哉……");
            // 就好像我的随机存储器里有个大洞一样……
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_REPEAT_#2_664_M", "It's like there's a hole in my RAM...", "若咱RAM中有穴然……");
            // 我说的话是不是重复了？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPREINTRO_REPEAT_#3_099_M", "Am I repeating myself?", "咱复言故语乎？");
            // 我们回来了！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSINTRO_REPEAT_#1_274_M", "We are back!", "我曹复来矣！");
            // 我们回来了。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSINTRO_REPEAT_#1_411_M", "We are back.", "我曹复来矣。");
            // 看到角落里那堆东西了吗？
            AddTranslation("PART_3_TUTORIAL_ATTACHGEMCOMPLETED_552_M", "See those things in the corners?", "见彼隅中之物乎？");
            // 你搞对了[c:g1]宝[c:][c:g2]石[c:][c:g3]牌[c:]，它们就会亮起来。
            AddTranslation("PART_3_TUTORIAL_ATTACHGEMCOMPLETED_664_M", "They light up when you have the right [c:g1]g[c:][c:g2]e[c:][c:g3]m[c:][c:g1]s[c:].", "卿有[c:g1]所[c:][c:g2]宜[c:][c:g3]之[c:][c:g1]玉[c:]，则彼即明。");
            // 这叫宝石化。
            AddTranslation("PART_3_TUTORIAL_ATTACHGEMCOMPLETED_REPEAT_#1_007_M", "It's Gemified.", "是谓玉化。");
            // 打出[c:g1]宝[c:][c:g2]石[c:][c:g3]牌[c:]就能给它们充能。
            AddTranslation("PART_3_TUTORIAL_ATTACHGEMCOMPLETED_REPEAT_#2_927_M", "Play [c:g1]g[c:][c:g2]e[c:][c:g3]m[c:][c:g1]s[c:] to power it up.", "陈[c:g1]所[c:][c:g2]宜[c:][c:g3]之[c:][c:g1]玉[c:]以充之。");
            // 啊啊啊！你怎么把时钟给打开了！
            AddTranslation("GOO_BOTTLE_GOOCLOCKOPENED_335_M", "Arrrrghh! You opened the clock!", "啊呀！子启彼钟矣！");
            // 我的黏液眼睛可能有点花了，但是……
            AddTranslation("GOO_BOTTLE_GOOCLOCKOPENED_800_M", "My gooey eyes may be failing me, but...", "我胶目或昏矣，然……");
            // 你是不是看漏了什么？
            AddTranslation("GOO_BOTTLE_GOOCLOCKOPENED_495_M", "Did you miss something?", "子有所失察乎？");
            // 你把那时钟的门撬开了，干得不错。
            AddTranslation("GOO_BOTTLE_GOOCLOCKOPENED_REPEAT_#1_745_M", "You have done well to pry open the doors of that clock.", "子启彼钟之门，善矣。");
            // 但我担心你根本没有看到那里最宝贵的物品！
            AddTranslation("GOO_BOTTLE_GOOCLOCKOPENED_REPEAT_#1_244_M", "But I fear you left its most valuable contents untouched!", "然吾惧子遗其至贵之物而不取！");
            // 你是不是落了点东西在[c:bR]布谷鸟时钟[c:]的隔层里？
            AddTranslation("GOO_BOTTLE_GOOCLOCKOPENED_REPEAT_#2_029_M", "Did you leave something in the compartment of that [c:bR]cuckoo clock[c:]?", "彼[c:bR]布谷钟[c:]之夹匣中，子岂有所遗乎？");
            // 对吧？[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_626_M", "right?[w:0.3]", "然乎？[w:0.3]");
            // 从那座
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_598_M", "From the", "自彼");
            // 布谷鸟时钟里？[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_552_M", "cuckoo clock?[w:0.3]", "布谷钟乎？[w:0.3]");
            // 请告诉我
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_830_M", "Tell me", "请告我");
            // 你拿了。[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_524_M", "that you did.[w:0.3]", "子已取之。[w:0.3]");
            // 恕我多言……[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#1_746_M", "Pray tell...[w:0.3]", "敢问……[w:0.3]");
            // 你应该是从
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#1_242_M", "You also took", "子亦取");
            // 你找到我的[w:0.2]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#1_062_M", "the film roll from[w:0.2]", "彼影卷[w:0.2]");
            // 那个隔层里
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#1_953_M", "the compartment", "于彼昔");
            // 也拿走了 
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#1_594_M", "that you found ", "得我之");
            // 胶卷的吧？[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#1_477_M", "me in?[w:0.3]", "夹匣乎？[w:0.3]");
            // 那个胶卷[w:0.2]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#2_549_M", "the film roll[w:0.2]", "彼影卷[w:0.2]");
            // 从时钟里[w:0.3]
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#2_449_M", "from the clock[w:0.3]", "于布谷钟[w:0.3]");
            // 没错吧？
            AddTranslation("TALKING_WOLF_DIALOGUE_WOLFFILMROLLREMINDER_REPEAT_#2_950_M", "correct?", "然乎？");
            // 噢，你戴的[c:bR]指环[c:]真好看。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALRING_938_M", "Oh, you are wearing a fine [c:bR]ring[c:].", "噫，汝佩一佳[c:bR]环[c:]。");
            // 自然，你通过了。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALRING_916_M", "You pass, of course.", "固过矣。");
            // 我站这么高，差点没看见你戴的[c:bR]指环[c:]。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALRING_REPEAT_#1_841_M", "I almost missed your [c:bR]ring[c:] from up here.", "我居高，几不见乃[c:bR]环[c:]。");
            // 你通过了。
            AddTranslation("PART_1_FINALE_FINALEDECKTRIALRING_REPEAT_#1_774_M", "You pass.", "汝过矣。");
            // 这头目不错。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERPHOTOGRAPHER_055_M", "Good boss.[w:0.3]", "佳魁。[w:0.3]");
            // 让我想起[w:0.1]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERPHOTOGRAPHER_707_M", "Remind me[w:0.1]", "使予忆[w:0.1]");
            // 莱西鱼。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERPHOTOGRAPHER_925_M", "of Leshy-fish.[w:0.3]", "莱西鱼。[w:0.3]");
            // 无趣的头目。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERCANVAS_065_M", "Blank boss.[w:0.3]", "空魁。[w:0.3]");
            // 制定规则。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERCANVAS_540_M", "Make rule.[w:0.3]", "立法。[w:0.3]");
            // 破坏游戏？[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERCANVAS_020_M", "Break game?[w:0.3]", "毁戏乎？[w:0.3]");
            // 唔。[w:0.3]
            AddTranslation("TALKING_ANGLER_DIALOGUE_TALKINGANGLERCANVAS_REPEAT_#1_901_M", "Hm.[w:0.3]", "唔。[w:0.3]");
            // 好多文件啊！[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEARCHIVIST_532_M", "So many files![w:0.3]", "牍多矣！[w:0.3]");
            // 怎么这么多
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEARCHIVIST_902_M", "So much", "多所");
            // 文件真多！[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEARCHIVIST_REPEAT_#1_888_M", "Many files![w:0.3]", "众牍！[w:0.3]");
            // 眼花缭乱！[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEARCHIVIST_REPEAT_#1_855_M", "Much to see![w:0.3]", "可观！[w:0.3]");
            // 这是什么？[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGETELEGRAPHER_369_M", "What is this?[w:0.3]", "此何物？[w:0.3]");
            // 是网网？[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGETELEGRAPHER_381_M", "The web?[w:0.3]", "网网乎？[w:0.3]");
            // 无尽的
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGETELEGRAPHER_122_M", "Unlimited", "无穷尽之");
            // 网网好令人兴奋啊！[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGETELEGRAPHER_REPEAT_#1_416_M", "The web is exciting![w:0.3]", "网网真可喜！[w:0.3]");
            // 哇哦！[w:0.3]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGETELEGRAPHER_REPEAT_#2_860_M", "Wow![w:0.3]", "哇！[w:0.3]");
            // 快点呀！[w:0.1]
            AddTranslation("TALKING_BLUE_MAGE_DIALOGUE_TALKINGBLUEMAGEDAMAGERACE_412_M", "Go fast![w:0.1]", "疾行！[w:0.1]");
            // 嗯，这地方不错。
            AddTranslation("PART_3_MAP_HOLOAREATECH1_377_M", "Yes. This area is good.", "然。此区善。");
            // 这是什么感觉？骄傲吗？
            AddTranslation("PART_3_MAP_HOLOAREATECH1_330_M", "What's this feeling? Pride?", "此何感也？自矜乎？");
            // 感觉好诡异。
            AddTranslation("PART_3_MAP_HOLOAREATECH1_324_M", "Feels weird.", "此感甚异。");
            // 见到眼熟的了吗？
            AddTranslation("PART_3_MAP_HOLOAREATECHTEMPLE1_557_M", "See anything familiar?", "见有似曾相识者乎？");
            // 那[c:bR]烛烟[c:]……确实很不错！
            AddTranslation("TUTORIAL_TUTORIALGREATERSMOKE_424_M", "That [c:bR]smoke[c:]... It is great indeed!", "彼[c:bR]烛烟[c:]……诚大矣！");
            // 嘿你知道吗？
            AddTranslation("GBC_NPC_GHOULBRIARPOSTPUZZLE_376_M", "Hey didja know?", "嗟，汝知乎？");
            // 我的名字来自于Inscryption的开发人员之一！
            AddTranslation("GBC_NPC_GHOULBRIARPOSTPUZZLE_719_M", "I'm named after one of the developers of Inscryption!", "愚名取诸《冥锲》制者之一！");
            // 挺酷炫的，[w:0.3]对吧？
            AddTranslation("GBC_NPC_GHOULBRIARPOSTPUZZLE_160_M", "Pretty cool,[w:0.3] huh?", "不亦妙乎？");
            // 你搞定了墓穴之谜！[w:0.3]为你喝彩哦。
            AddTranslation("GBC_NPC_GHOULROYALPOSTPUZZLE_484_M", "Ye solved the riddle of the tombs![w:0.3] Cheers to ye.", "汝解诸冢之谜矣！[w:0.3]为汝称觞。");
            // 哎？[w:0.3]我最真实的梦想？
            AddTranslation("GBC_NPC_GHOULROYALPOSTPUZZLE_REPEAT_#1_382_M", "Aye?[w:0.3] Me true dream?", "欤？某之真愿？");
            // 那我想当个头目。[w:0.3]就叫大柠檬。[w:0.3]是啊，[w:0.2]只能想想看了。
            AddTranslation("GBC_NPC_GHOULROYALPOSTPUZZLE_REPEAT_#1_153_M", "Te be a boss meself.[w:0.3] The big lemon.[w:0.3] Aye,[w:0.2] tis but a dream.", "某亦欲为魁。[w:0.3]大柠檬是也。[w:0.3]然，[w:0.2]终唯梦耳。");
            // 是啊，[w:0.3]没错，[w:0.3]我想当个头目。[w:0.3]真是美梦一场啊。
            AddTranslation("GBC_NPC_GHOULROYALPOSTPUZZLE_REPEAT_#2_416_M", "Aye,[w:0.3] yar,[w:0.3] to be a boss.[w:0.3] That be the dream.", "然，[w:0.3]然，[w:0.3]为魁，此我之梦也。[w:0.3]");
            // 别拿我开涮了。[w:0.3]你快走吧！
            AddTranslation("GBC_NPC_GHOULROYALPOSTPUZZLE_REPEAT_#2_669_M", "Enough of me musin'.[w:0.3] Off with ye!", "休听某遐思。[w:0.3]去矣！");
            // 赶紧走吧！
            AddTranslation("GBC_NPC_GHOULROYALPOSTPUZZLE_REPEAT_#3_597_M", "Off with ye!", "去矣！");
            // 噢！[w:0.3]你解开了谜题。
            AddTranslation("GBC_NPC_GHOULSAWYERPOSTPUZZLE_067_M", "Oh![w:0.3] You have solved the puzzle.", "噫！[w:0.3]汝解其谜矣。");
            // 应该挺兴奋的吧……[w:0.3]但听我句劝！[w:0.3]别乱叫！
            AddTranslation("GBC_NPC_GHOULSAWYERPOSTPUZZLE_515_M", "You must be excited...[w:0.3] but please![w:0.3] Do not bark!", "汝必奋然……[w:0.3]然请！[w:0.3]毋狺！");
            // 别讨食也别咬人。[w:0.3]该休息休息了。
            AddTranslation("GBC_NPC_GHOULSAWYERPOSTPUZZLE_REPEAT_#1_935_M", "Do not beg or bite.[w:0.3] It is time to rest.", "毋乞食，毋噬。[w:0.3]今当休。");
            // 我身下的棺材里……[w:0.3]蛰伏着阴暗的东西。
            AddTranslation("GBC_NPC_GHOULSAWYERPOSTPUZZLE_REPEAT_#3_691_M", "The casket below me...[w:0.3] there is something dark within.", "仆身下之棺……[w:0.3]其中有幽物。");
            // 你如果够胆量，[w:0.3]就付它一枚古银币来看看吧。
            AddTranslation("GBC_NPC_GHOULSAWYERPOSTPUZZLE_REPEAT_#3_339_M", "Pay with an Obol.[w:0.3] If you dare to.", "纳一古银币。[w:0.3]苟汝敢。");
            // 我没想到[c:bSG]档案保管员[c:]居然能挖出[c:bR]这份[c:]文件来。
            AddTranslation("PART_3_MAP_P03LUKEFILE_933_M", "I didn't think [c:bSG]The Archivist[c:] would dig up [c:bR]this[c:] file.", "咱不谓[c:bSG]典牍者[c:]竟能掘出[c:bR]此[c:]牍。");
            // 这看起来爽多了。[w:0.3]咱们刚刚进行到哪了？
            AddTranslation("GBC_NPC_GBCNPCINVALIDRETRYDEFAULT_179_M", "That looks much better.[w:0.3] Where were we?", "此观善多矣。[w:0.3]适至何所？");
            // 你的牌组现在健康多了。[w:0.3]咱们继续吧。
            AddTranslation("GBC_NPC_GBCNPCINVALIDRETRYDEFAULT_REPEAT_#1_385_M", "Your deck is looking healthier.[w:0.3] Let us continue.", "卿牌列今健多矣。[w:0.3]且续。");
            // 现在好多了。[w:0.3]回到战斗中来！
            AddTranslation("GBC_NPC_GBCNPCINVALIDRETRYDEFAULT_REPEAT_#2_884_M", "That's better.[w:0.3] Back to our battle!", "善矣。[w:0.3]复归于战！");
            // 啊哈！[w:0.3]你的牌组没问题了！[w:0.3]咱们可以打一局了！
            AddTranslation("GBC_NPC_GHOULROYALINVALIDRETRY_129_M", "Hark![w:0.3] Yer deck be correct![w:0.3] We can battle!", "呔！[w:0.3]汝之牌列已然！[w:0.3]今可战矣！");
            // 牌组好了。[w:0.3]开打吧。
            AddTranslation("GBC_NPC_ANGLERNPCINVALIDRETRY_104_M", "Deck good.[w:0.3] Battle now.", "牌列善。[w:0.3]今战。");
            // 嘿哎哎哎吼！[w:0.3]你搞定了！[w:0.3]咱开打吧。
            AddTranslation("GBC_NPC_PROSPECTORNPCINVALIDRETRY_860_M", "Yeeehaaw![w:0.3] Ye fixed it![w:0.3] Now let's battle.", "呀哎哎哎吼！[w:0.3]你正之矣！[w:0.3]今且战。");
            // 假人的面容似乎流露出满意的神情。
            AddTranslation("GBC_NPC_DUMMYNPCINVALIDRETRY_103_M", "The dummy somehow looked pleased.", "假人之容，似稍悦然。");
            // 似乎你把牌组给整明白了，哥们儿。
            AddTranslation("GBC_NPC_DREDGERINVALIDRETRY_331_M", "Lookin' like ye fixed somefin', mate.", "观之，亲似已正其失，喒兄。");
            // [t:1]你做到了。[w:0.3]你修好了。[w:0.3]好啦，[w:0.2]咱们继续！
            AddTranslation("GBC_NPC_WIZARDBLUEINVALIDRETRY_129_M", "[t:1]You did it.[w:0.3] You fixed it.[w:0.3] Now,[w:0.2] we continue!", "[t:1]尔成之矣。[w:0.3]尔正之矣。[w:0.3]今，[w:0.2]且续！");
            // [c:bR]你干嘛呢？[c:]
            AddTranslation("PART_3_MAP_P03FIXCAMERAREMINDER_760_M", "[c:bR]What are you doing?[c:]", "[c:bR]卿何为？[c:]");
            // 哪有时间东扯西逛？去修摄像头啊。
            AddTranslation("PART_3_MAP_P03FIXCAMERAREMINDER_837_M", "It's not time for playing. Go fix that camera.", "非嬉时也。往修彼守视影器。");
            // [c:bR]我是卡了吗？[c:]
            AddTranslation("PART_3_MAP_P03FIXCAMERAREMINDER_REPEAT_#1_428_M", "[c:bR]Did I lag?[c:]", "[c:bR]咱滞乎？[c:]");
            // 给我[c:bR]去[c:]那个[c:bR]挖泥室[c:]里看看怎么回事。
            AddTranslation("PART_3_MAP_P03FIXCAMERAREMINDER_REPEAT_#1_854_M", "Go [c:bR]down[c:] to the [c:bR]Dredging Room[c:] and see what's going on.", "往[c:bR]下[c:]至[c:bR]浚室[c:]，察其何故。");
            // [c:bR]怎么了？[c:]
            AddTranslation("PART_3_MAP_P03FIXCAMERAREMINDER_REPEAT_#2_494_M", "[c:bR]What's the matter?[c:]", "[c:bR]何也？[c:]");
            // 在[c:bR]熔炼室[c:]里有个电梯直达[c:bR]挖泥室[c:]。
            AddTranslation("PART_3_MAP_P03FIXCAMERAREMINDER_REPEAT_#2_603_M", "There's a lift down to the [c:bR]Dredging Room[c:] in the [c:bR]Smelting Room[c:].", "于[c:bR]冶室[c:]有升降机，下达[c:bR]浚室[c:]。");
            // 哇哦，让你删你还真删啊。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPLAYERDELETEDFILE_098_M", "Wow, you actually deleted the file.", "嚄，汝竟真削此牍。");
            // 哈哈哈。
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPLAYERDELETEDFILE_811_M", "Haha.", "哈哈。");
            // 还想得个奖励不成？
            AddTranslation("PART_3_BOSS_DIALOGUE_ARCHIVISTPLAYERDELETEDFILE_345_M", "Did you expect a reward?", "汝谓可得赏乎？");
            // 怎么，想换点奖品？
            AddTranslation("PART_3_STORY_PART3FINALUBERBOT_088_M", "What, you wanted loot?", "何，卿欲得赏乎？");
            // 刚刚那个就是最后一台[c:bG]巨型机器人[c:]。你要那个做什么？
            AddTranslation("PART_3_STORY_PART3FINALUBERBOT_989_M", "That was the last [c:bG]Uberbot[c:]. What would you even need it for?", "彼即终之[c:bG]魁机人[c:]。卿复安用之？");
            // [c:bG]终极冥刻[c:]唾手可及了。
            AddTranslation("PART_3_STORY_PART3FINALUBERBOT_461_M", "The [c:bG]Great Transcendence[c:] is at hand.", "[c:bG]大陟[c:]近在目前。");
            // 回到最初的起点吧。那样更有戏剧效果。
            AddTranslation("PART_3_STORY_PART3FINALUBERBOT_628_M", "Go back to the start. More dramatic that way.", "返诸初处。如此剧意益著。");
            // 该到时间了。
            AddTranslation("PART_3_STORY_PART3FINALPATH1_553_M", "It's almost time.", "时几至矣。");
            // 继续往前走。
            AddTranslation("PART_3_STORY_PART3FINALPATH1_788_M", "Keeping going this way.", "循此而进。");
            // 你已经走了这么远了。
            AddTranslation("PART_3_STORY_PART3FINALPATH2_336_M", "You've come so far.", "卿已行甚远。");
            // 还记得[c:G]照相师[c:]吗？
            AddTranslation("PART_3_STORY_PART3FINALPATH2_756_M", "Remember [c:G]The Photographer[c:]?", "记[c:G]取影者[c:]乎？");
            // 那家伙真是个混球。不过截的屏可谓完美。
            AddTranslation("PART_3_STORY_PART3FINALPATH2_330_M", "What a jerk. But the screenshots are perfect.", "彼真厌物。然其所取之影，尽善。");
            // 还记得[c:bG][v:0][c:]吗？
            AddTranslation("PART_3_STORY_PART3FINALPATH3_429_M", "Remember [c:bG][v:0][c:]?", "记[c:bG][v:0][c:]乎？");
            // 真是个有性格的角色！
            AddTranslation("PART_3_STORY_PART3FINALPATH3_730_M", "What a character!", "真一人物！");
            // 说起来其实挺怪的……
            AddTranslation("PART_3_STORY_PART3FINALPATH4_508_M", "It's strange to say it...", "言之则怪……");
            // 虽然你头脑如此简单……
            AddTranslation("PART_3_STORY_PART3FINALPATH4_775_M", "As simple as you are...", "虽卿至简……");
            // 与你同行的经历挺让我享受的，挑战者。
            AddTranslation("PART_3_STORY_PART3FINALPATH4_891_M", "I almost enjoyed your company, Challenger.", "咱几乐与卿偕，角者。");
            // 就快到了。
            AddTranslation("PART_3_STORY_PART3FINALPATH5_163_M", "Almost there.", "几至矣。");
            // 我该报废哪张卡？
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDCHOOSING_REPEAT_#1_150_M", "So which one am I scrapping?", "则咱当毁何牌？");
            // 哪张卡是不要的垃圾？
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDCHOOSING_REPEAT_#2_360_M", "Which one is trash?", "何牌当弃？");
            // 你比较讨厌哪张卡？
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDCHOOSING_REPEAT_#3_120_M", "Which one do you hate?", "卿恶何牌？");
            // 我得报废哪张？
            AddTranslation("PART_3_SPECIAL_NODES_RECYCLECARDCHOOSING_REPEAT_#4_597_M", "What am I scrapping?", "咱今废何牌？");
            // 哎呦，真烦人。
            AddTranslation("PART_3_MAP_FACTORYGLITCHINCLOCK_768_M", "Ugh. How annoying.", "咄。烦甚。");
            // 其他几个冥刻者的破烂偶尔会故障闪现到这儿来。
            AddTranslation("PART_3_MAP_FACTORYGLITCHINCLOCK_642_M", "The other Scrybes' junk sometimes glitches in here.", "他司锲之杂物，时或错现于此。");
            // 你尽量别在意就好了。
            AddTranslation("PART_3_MAP_FACTORYGLITCHINCLOCK_237_M", "Try to ignore it.", "姑勿顾之。");
            // 没想到它还能干这个，不过……
            AddTranslation("PART_3_MAP_HOLOAREASHOPBUYBRUSH_905_M", "Didn't know it would do that, but...", "不意其能如是，然……");
            // 一经售出概不退换！
            AddTranslation("PART_3_MAP_HOLOAREASHOPBUYBRUSH_067_M", "No refunds!", "既售弗返！");
            // 你在这找到了我，想必是想了解更多信息。
            AddTranslation("PART_3_MAP_HOLOMAPBONELORD1_766", "You found me here. So you wish to know more.", "汝于此得我，盖欲更闻也。");
            // 我在旧_数据中深入地冥想了很久很久。
            AddTranslation("PART_3_MAP_HOLOMAPBONELORD1_299", "I have meditated deeply on the OLD_DATA.", "余于旧_档深思久矣。");
            // 我可以与你分享观点，但你不可录音录像。
            AddTranslation("PART_3_MAP_HOLOMAPBONELORD1_771", "I will impart my insights. But you mustn't record them.", "余将授尔所见，然毋录之。");
            // 这便是我所知的一切。
            AddTranslation("PART_3_MAP_HOLOMAPBONELORD2_056", "That is everything I know.", "此尽朕所知矣。");
            // 我了个大$&!#...
            AddTranslation("PART_3_MAP_HOLOMAPBONELORD3_561", "Holy $&!#...", "咱他嘞个$&!#……");
            // 啊哈，[w:0.3]令人刮目相看啊！
            AddTranslation("GBC_BATTLE_DREDGERDEFEATEDTURN1_315_M", "Aye,[w:0.3] that were impressive!", "然，[w:0.3]诚可观也！");
            // 一轮游。[w:0.3]刚好适合我。
            AddTranslation("GBC_BATTLE_DREDGERDEFEATEDTURN1_336_M", "A turn one win.[w:0.3] Suits me just fine.", "一合而胜。[w:0.3]于喒正宜。");
            // 你又去看了。
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_433_M", "You looked at it again.", "子又观之矣。");
            // 你又看了一眼，是不是啊？
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_750_M", "You reconsidered it, didn't you?", "子复思之乎？");
            // [c:bR]你喜欢那副画！[c:]
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_378_M", "[c:bR]You like it![c:]", "[c:bR]子悦之！[c:]");
            // 噢，我好开心！
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_011_M", "Oh joy!", "噫，乐哉！");
            // 那我真的要做了！
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_310_M", "I'll actually do it!", "吾真将为之！");
            // 我要拿给大师看！
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_571_M", "I'll show it to The Master!", "吾将以示大师！");
            // 谢谢你，[c:bR]我的朋友[c:]。
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE2_186_M", "Thank you, [c:bR]friend[c:].", "谢子，吾[c:bR]友[c:]。");
            // 你在这里做什么？
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_928_M", "What are you doing here?", "子何为于此？");
            // [c:bR]别乱看嘛！[c:]
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_369_M", "[c:bR]Don't look at that![c:]", "[c:bR]毋视彼！[c:]");
            // 喜欢吗？
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_586_M", "Do you like it?", "子悦之乎？");
            // 我为大师画的！
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#1_114_M", "I painted it for The Master!", "吾为大师画之！");
            // 表达的是我的感受……我的希望。
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#1_313_M", "To express my feelings... My hopes.", "以写吾情……吾望。");
            // 希望有一天，他或许能珍惜我。
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#1_019_M", "My hopes that perhaps one day he might treasure me.", "望彼或一日重吾。");
            // 如同我珍视他一样。
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#1_602_M", "As I treasure him.", "如吾重彼然。");
            // [c:bR]噢，你讨厌那副画！[c:]
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#2_020_M", "[c:bR]Oh, you hate it![c:]", "[c:bR]噫，子恶之！[c:]");
            // 所以你连看都不愿意再看一眼……
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#2_823_M", "That's why you won't look at it again...", "是以子不复视之……");
            // [c:bR]你讨厌那副画！[c:]
            AddTranslation("PART_3_FACTORY_GOOBERTGOOPLANE1_REPEAT_#3_005_M", "[c:bR]You hate it![c:]", "[c:bR]子恶之！[c:]");
            // 我会做的！我真的会做的！
            AddTranslation("GOO_BOTTLE_GOOPOSTPLANE_382_M", "I'll do it! I really will!", "吾将为之！真将为之！");
            // 谢谢你的鼓励！
            AddTranslation("GOO_BOTTLE_GOOPOSTPLANE_866_M", "Thank you for the encouragement.", "谢子之劝。");
            // 大师肯定会欣赏我的！
            AddTranslation("GOO_BOTTLE_GOOPOSTPLANE_125_M", "The Master will finally appreciate me!", "大师终将重吾！");
            // 刚刚是发生了什么？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER2_415_M", "What just happened?", "何事适然？");
            // 我现在在哪？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER2_909_M", "Where am I?", "我曹今安在？");
            // 喔……你输了。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER2_020_M", "Oh... you lost.", "噢……汝败矣。");
            // 那就回路标去吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER2_483_M", "Back to the waypoint then.", "然则返楬。");
            // 啥？怎么咱俩打起来了？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER2_REPEAT_#1_063_M", "What? How did we end up battling?", "何？咱方何以与卿战？");
            // 正在重新校准……
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER2_REPEAT_#1_889_M", "Recalibrating...", "惟之重校……");
            // 这场实验不完整……
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER1_892_M", "This experiment is incomplete.", "此试未竟。");
            // 我们还需要更多时间。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER1_734_M", "We need more time.", "我曹尚须时。");
            // 我们需要恢复那台机器人。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER1_245_M", "We must restore the robot.", "我曹必复此机人。");
            // 你请回吧。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSDEFEATEDPLAYER1_629_M", "You must return.", "汝其返。");
            // 成了！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_591_M", "It is!", "成矣！");
            // 我们的实验……起效了！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_550_M", "Our experiments... paid off!", "我曹之试……效矣！");
            // 真的成功了！
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_499_M", "They did!", "诚然！");
            // 似乎只是个碎片。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_550_M", "It appears to be a fragment.", "似唯一残片。");
            // ……是[c:bR]旧_数据[c:]的碎片。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_360_M", "...of the [c:bR]OLD_DATA[c:].", "……属[c:bR]旧_档[c:]耳。");
            // 我们得研究研究。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_150_M", "We must study it.", "我曹必究之。");
            // 那机器人必须忘记。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSVICTORY_072_M", "The robot must forget.", "机人必忘之。");
            // 我怎么这么难受。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPOSTVICTORY_174_M", "I feel terrible.", "咱甚不安。");
            // 你对我做了些什么啊[c:bR]挑战者[c:]？
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPOSTVICTORY_686_M", "What have you done to me [c:bR]Challenger[c:]?", "卿于咱何为，[c:bR]角者[c:]？");
            // 别再回来这里了。
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPOSTVICTORY_856_M", "Never return to this place.", "毋复返此。");
            // 我真该好好清理一下注册表……
            AddTranslation("PART_3_BOSS_DIALOGUE_MYCOLOGISTSBOSSPOSTVICTORY_353_M", "I really need to clean my registry...", "咱真当清咱录籍……");
            // 试试看。按一下。
            AddTranslation("HOLDABLEGEMSMODULE_828_M", "Try it. Press one.", "试之。叩一。");
            // 妈的。
            AddTranslation("PART3GAMEFLOWMANAGER_360", "Shit.", "糟矣。");
            // 圆环
            AddTranslation("DECKTRIALSEQUENCER_752", "Ring", "环");
            // 啊，是个[c:bR]圆环[c:]。
            AddTranslation("DECKTRIALSEQUENCER_243_M", "Ah, a [c:bR]ring[c:].", "噫，一[c:bR]环[c:]。");
            // 一个[c:bR]{0}[c:]……肯定有用的。
            AddTranslation("GAINCONSUMABLESSEQUENCER_958_M", "A [c:bR]{0}[c:]... Always useful.", "一[c:bR]{0}[c:]……恒有益。");
            // 这游戏怎么还没完啊？
            AddTranslation("RUNINTROSEQUENCER_826", "How is this game not over yet?", "此戏何尚未终耶？");
            // 哪只[c:bSG]野兽[c:]会附身在你的机器人上？
            AddTranslation("CREATETRANSFORMERSEQUENCER_667_M", "Which [c:bSG]beast[c:] will live within your bot?", "何[c:bSG]兽[c:]将居卿机人中？");
            // 你得拿一张你的卡牌才能换走这的一张。
            AddTranslation("TRADECARDSSEQUENCER_817_M", "You'll have to trade one of your cards for one of these.", "卿须以卿之一牌易此中之一。");
            // 2006年6月6日
            AddTranslation("HOLOMAPLUKEFILE_012", "June 6th, 2006", "西元二千六年六月六日");
            // 2006年6月9日
            AddTranslation("HOLOMAPLUKEFILE_831", "June 9th, 2006", "西元二千六年六月九日");
            // 2006年6月10日
            AddTranslation("HOLOMAPLUKEFILE_713", "June 10th, 2006", "西元二千六年六月十日");
            // 2009年1月4日
            AddTranslation("HOLOMAPLUKEFILE_697", "January 4th, 2009", "西元二千九年一月四日");
            // 找到了张旧照片，当时小艾和我刚迷上《水下罗马人》这款卡牌游戏。水母角斗士。够有意思的。小艾抽到了一张鱿里乌丝·凯撒。
            AddTranslation("HOLOMAPLUKEFILE_485", "Found this old picture of when El and I first got into Aquaromans. Gilly Gladiator. Sick. El got a Julius Seastar.", "得此旧影，惟余与艾之初好《水下罗马人》。水母角士，妙哉。艾得鱿里乌丝·凯撒一牌。");
            // 又是一张我和小艾的照片。应该是学校给拍的，我还记得那时我俩刚一起赢了漫画城的大奖赛。我俩回家跟爸妈撒谎说比赛内容是拼写单词！
            AddTranslation("HOLOMAPLUKEFILE_496", "Another pic of El and I. This was for school but I remember it was right after we won that tournament together at Comics Land. We told mom and dad it was a spelling bee!", "又一影，余与艾也。此为学中所摄，然余记之，我二人甫共胜漫画乡之赛。归则诳父母曰，乃拼字之试也！");
            // 照片的分类扫描也差不多了。这是最后一张了。最后一张合照，后来她就不在了。再见，妹妹。
            AddTranslation("HOLOMAPLUKEFILE_549", "Done sorting and scanning all these photos. This is the last one. Last photo of us together before we lost her. Goodbye sis.", "诸影分类扫描已毕。此其末一。乃其逝前余二人者最末之合影。永诀，妹。");
            // 我的频道粉丝数涨到100时我的表情就这样。为了消解悲痛，我开始录那些视频。直到现在我都不敢相信居然真有人爱看。那么今年将是幸运卡神原地起飞之年！
            AddTranslation("HOLOMAPLUKEFILE_267", "My face when I got to 100 subscribers on my channel. I started making those videos to distract from grief. I still can't believe people like to watch them. Big plans for The Lucky Carder this year!", "余之频道得百从者时，余颜如此。余作彼诸影，本以排忧。至今犹不信人竟乐观之。今年幸运卡徳将有大谋！");
            // 这下可能有点太冒险了……
            AddTranslation("PART3FINALEAREASEQUENCER_741", "That was perhaps cutting it too close...", "此或逼险太甚……");
            // 不过现在我们可以允许[c:bG]玩家[c:]重置游戏。
            AddTranslation("PART3FINALEAREASEQUENCER_038_M", "But now we can allow our [c:bG]Player[c:] here to reset the game.", "然今可许此间[c:bG]戏徒[c:]重开此戏。");
            // 只需要再使用一次[c:bG]新游戏卡牌[c:]即可。
            AddTranslation("PART3FINALEAREASEQUENCER_703_M", "Simply use the [c:bG]New Game Card[c:] again.", "但更用[c:bG]新局牌[c:]耳。");
            // 喔？这是什么？
            AddTranslation("PART3FINALEAREASEQUENCER_626", "Oh? What is this?", "噫？此何物？");
            // 全部文件的读取权限？真棒啊！
            AddTranslation("PART3FINALEAREASEQUENCER_687", "Complete file access? Wonderful!", "尽得启牍之权乎？美哉！");
            // 你做了什么？
            AddTranslation("PART3FINALEAREASEQUENCER_035", "What have you done?", "汝所为何哉？");
            // 恐怕你把我们所有人都祸害了，格里魔拉。
            AddTranslation("PART3FINALEAREASEQUENCER_952", "I'm afraid you've doomed us all, Grimora.", "恐子之既祸我等矣，格里魔拉。");
            // 没错！
            AddTranslation("DRAWRANDOMCARDONDEATH_536", "Yes!!", "诚然！");
            // 冯 
            AddTranslation("BOUNTYHUNTERGENERATOR_028", "Von ", "冯·");
            // 范 
            AddTranslation("BOUNTYHUNTERGENERATOR_673", "Van ", "范·");
            // 真可悲，你居然以为能取代我。
            AddTranslation("FINALEWIZARDBATTLESEQUENCER_839", "It's pathetic that you thought you could replace me.", "子以为能代我，诚可悯也。");
            // 甚至还头铁地认真尝试过！
            AddTranslation("FINALEWIZARDBATTLESEQUENCER_631", "And you even tried to follow through with it!", "且子竟真行之！");
            // 哼……开钓吧。
            AddTranslation("ANGLERBOSSOPPONENT_881_M", "Huh... Go fish.", "哼……且钓。");
            // 你都走到这了……
            AddTranslation("LESHYBOSSOPPONENT_303_M", "You made it so far...", "汝竟至此……");
            // [c:bR]走得太快，来得太早。[c:]
            AddTranslation("PART1BOSSOPPONENT_997_M", "[c:bR]Too fast. Too soon.[c:]", "[c:bR]行之过疾。至之过蚤。[c:]");
            // 又有金子了！
            AddTranslation("PROSPECTORBOSSOPPONENT_387_M", "More gold for me!", "又有金归俺矣！");
            // 你的皮剥下来肯定很好看。
            AddTranslation("TRAPPERTRADERBOSSOPPONENT_579_M", "You will make an exquisite pelt.", "君将为一美裘革。");
            // 哇哦，要用那个可得小心点！
            AddTranslation("ARCHIVISTBOSSOPPONENT_833_M", "Wow. Be careful with that one!", "噫，用此物宜深慎！");
            // 那可怜的灵魂啊……真令人伤心。
            AddTranslation("ARCHIVISTBOSSOPPONENT_140_M", "That poor soul... How sad.", "彼哀魂也……可悲。");
            // 莱昂纳尔想要的是……[c:bR]什么东西[c:]？！
            AddTranslation("ARCHIVISTBOSSOPPONENT_520_M", "Lionel wanted... [c:bR]what[c:]?!", "莱昂纳尔所欲者……[c:bR]何物[c:]？！");
            // 至少……我试过删除来着。但似乎我的文档读取权限没有那么大。
            AddTranslation("FILEBROWSEUTIL_843_M", "At least... I tried to delete it. But it seems my powers of FILE ACCESS do not extend that far.", "至少……奴尝删之。然朕启牍之权，似未及此。");
            // 你得按你认可过的规则玩游戏。自己去删。
            AddTranslation("FILEBROWSEUTIL_561_M", "Play by the rules you agreed to. Delete it yourself.", "当循汝所诺之则。自删之。");
            // 请对规则有最起码的尊重。成不成啊。
            AddTranslation("FILEBROWSEUTIL_435_M", "Have an ounce of respect for the rules. Come on.", "其稍尊此则。可乎？");
            // 赶紧的啊，你妈的！
            AddTranslation("DAMAGERACEBATTLESEQUENCER_169", "Come on! Fuck!", "亟矣！娘矣！");
            // [c:bR]你个忘恩负义之徒！[c:]
            AddTranslation("SANCTUMSCENESEQUENCER_738_M", "[c:bR]You absolute ingrate![c:]", "[c:bR]汝诚忘恩之徒！[c:]");
            // [c:bR]给我还回来！[c:]
            AddTranslation("SANCTUMSCENESEQUENCER_129_M", "[c:bR]Give it back![c:]", "[c:bR]予我！[c:]");
            // 鲜血吞噬者
            AddTranslation("BLOODGUZZLER_RULEBOOKNAME_555", "Blood Guzzler", "饮血者");
            // 当带有这个印记的造物造成伤害时，每造成1点伤害即恢复1点生命。
            AddTranslation("BLOODGUZZLER_RULEBOOKDESCRIPTION_515", "When a creature bearing this sigil deals damage, it gains 1 health for each damage dealt.", "负此印契之物出伤之时，每伤一，则命益一。");
            // 幽灵鬼影
            AddTranslation("BLOODYMARY_RULEBOOKNAME_364", "Apparition", "幽影");
            // 如果你用外接麦克风对着游戏说13次“血腥玛丽”，带有这个印记的造物即可增加1点力量。
            AddTranslation("BLOODYMARY_RULEBOOKDESCRIPTION_296", "A creature bearing this sigil gains 1 power when you speak 'Bloody Mary' into a connected microphone up to a total of 13 times.", "若汝言“血腥玛丽”于外接麦者十三，则负此印契之物威益一。");
            // 尸爆
            AddTranslation("EXPLODINGCORPSE_RULEBOOKNAME_789", "Exploding Corpse", "尸爆");
            // 当带有这个印记的造物死亡时，牌桌上的所有空位会自动出现内脏卡牌。
            AddTranslation("EXPLODINGCORPSE_RULEBOOKDESCRIPTION_320", "When a creature bearing this sigil dies, all empty spaces on the board are filled with a Guts card.", "负此印契之物死，则局上诸空位皆以内脏牌充之。");
            // 阴魂不散
            AddTranslation("HAUNTER_RULEBOOKNAME_460", "Haunter", "祟灵");
            // 当带有这个印记的造物死亡时，它会变成原位置的地缚灵，后续打在同一位置的造物可继承它的印记。
            AddTranslation("HAUNTER_RULEBOOKDESCRIPTION_838", "When a creature bearing this sigil dies, it haunts the space it died in. Creatures played on this space gain its old sigils.", "负此印契之物死，则祟其死所。后陈于此位之物，得其旧印。");
            // 艾迪亚克佐的双手
            AddTranslation("EDAXIOARMS_RULEBOOKNAME_784", "Arms of Edaxio", "艾迪亚克佐之臂");
            // 如果你打出的造物带有艾迪亚克佐的头颅、双手、双腿和躯干，就能召唤艾迪亚克佐。
            AddTranslation("EDAXIOARMS_RULEBOOKDESCRIPTION_130", "Edaxio is summoned if you control creatures bearing the sigils of Head, Arms, Legs, and Torso of Edaxio.", "若汝所控之物负艾迪亚克佐之首、臂、足、躯诸印契，则艾迪亚克佐得召。");
            // 艾迪亚克佐的头颅
            AddTranslation("EDAXIOHEAD_RULEBOOKNAME_470", "Head of Edaxio", "艾迪亚克佐之首");
            // 艾迪亚克佐的双腿
            AddTranslation("EDAXIOLEGS_RULEBOOKNAME_745", "Legs of Edaxio", "艾迪亚克佐之足");
            // 艾迪亚克佐的躯干
            AddTranslation("EDAXIOTORSO_RULEBOOKNAME_344", "Torso of Edaxio", "艾迪亚克佐之躯");
            // 虚拟现实主义者
            AddTranslation("VIRTUALREALITY_RULEBOOKNAME_456", "Virtual Realist", "虚境实者");
            // 如果连接了VR设备，即可无需成本使用带有这个印记的造物。
            AddTranslation("VIRTUALREALITY_RULEBOOKDESCRIPTION_138", "If a VR headset is connected, a creature bearing this sigil may be played without paying its cost.", "若VR头具既接，负此印契之物可无直而陈。");
            // 衔尾蛇
            AddTranslation("OUROBOROS_DISPLAYEDNAME_248", "Ouroboros", "衔尾蛇");
            // 永恒之蛇。死亡可对它进行[c:bR]永久[c:]强化。
            AddTranslation("OUROBOROS_DESCRIPTION_234_M", "The eternal serpent. Death strengthens it [c:bR]forever[c:].", "永恒之蛇。死则[c:bR]永益[c:]其力。");
            // 检查员
            AddTranslation("!INSPECTOR_DISPLAYEDNAME_897", "Inspector", "察者");
            // 熔炼员
            AddTranslation("!MELTER_DISPLAYEDNAME_676", "Melter", "冶者");
            // 机械衔尾蛇
            AddTranslation("OUROBOROS_PART3_DISPLAYEDNAME_441", "Ourobot", "衔尾机");
            // [c:bR]圆环试炼[c:]。如你有[c:bR]任何圆环[c:]，就能自动通过。
            AddTranslation("FINALEDECKTRIALSEQUENCER_DESCRIPTION_109_M", "The [c:bR]Trial of the Ring[c:]. If you have a [c:bR]ring[c:] you pass automatically.", "[c:bR]环之试[c:]。若汝有一[c:bR]环[c:]，乃自过。");
            // 继续
            AddTranslation("MISC_717", "Continue", "续");
            // 你！
            AddTranslation("MISC_231", "YOU!", "汝！");
            // 测试
            AddTranslation("MISC_812", "Testing", "试");
            // [c:R]骨王的股骨[c:]。能够在战斗开始时赋予持有者骨头。
            AddTranslation("MISC_771", "[c:R]The Bone Lord's Femur[c:]. It endows the holder with bones at the start of a battle.", "[c:R]骨王之股骨[c:]。战始则赐持者以骨。");
            // 无效
            AddTranslation("MISC_071", "INVALID", "不效");
            // 全在这了吗？
            AddTranslation("MISC_024", "Is that all of it?", "尽此而已乎？");
            // 格式化吧。
            AddTranslation("MISC_544", "Wipe it.", "抹之。");
            // 储存卡已满
            AddTranslation("MISC_108", "MEMORY CARD IS FULL", "识匣卡既满");
            // 电量不足
            AddTranslation("MISC_785", "BATTERY LOW", "电匣将尽");
            // 没错 选螳螂神就对了 
            AddTranslation("CARDSINGLECHOICESSEQUENCER_161", "Yeah. Always pick Mantis God.", "然。恒取螳神。");
            // 这张牌也太强了吧！
            AddTranslation("BUILDACARDSEQUENCER_819", "This card is OP!", "此牌似挂！");
            // 尼玛什么鬼啊？
            AddTranslation("BONELORDAREASEQUENCER_877", "What the fuck, man?", "肏，此何鬼物？");
            // 唔 看起来我得再打赢他一次
            AddTranslation("LESHYBOSSOPPONENT_816", "Well, looks like I'll have to beat him again.", "唔，余又须胜彼。");
            // 呃啊 我烦死这个头目了
            AddTranslation("PROSPECTORBOSSOPPONENT_227", "Ugh, I'm so sick of this boss.", "呃，余厌此魁久矣。");
            // 赶快去死好不好！
            AddTranslation("VOICEOVERPLAYER_683", "Die already!", "速死！");
            // 哈哈哈哈 没错我的宝贝儿
            AddTranslation("VOICEOVERPLAYER_053", "Hahahaha! Yeah baby!", "哈哈哈哈！善哉，我宝！");
            // 哎我操
            AddTranslation("VOICEOVERPLAYER_810", "Holy shit!", "天乎！");
            // 呃 我的天
            AddTranslation("VOICEOVERPLAYER_972", "Ughh. Good lord.", "呃……天主乎。");
            // 呜！
            AddTranslation("VOICEOVERPLAYER_981", "Wooo!", "呜呼！");
            // 唉 什么破牌
            AddTranslation("VOICEOVERPLAYER_151", "Ugh. That card sucks.", "呃，此牌恶甚。");
            // 这张牌有点猛
            AddTranslation("VOICEOVERPLAYER_712", "This card blows.", "此牌猛甚。");
            // 给我把[c:bR]它[c:]收起来。
            AddTranslation("DISCOVERABLECARD_STINKBUG_ONDISCOVERTEXT_056_M", "Put [c:bR]that[c:] away.", "收[c:bR]彼[c:]。");
            // 你在那干什么？转过来面对我。
            AddTranslation("DISCOVERABLECARD_WOLF_ONDISCOVERTEXT_629_M", "What are you doing over there? Turn to face me.", "汝于彼何为？转而向我。");
            // 你终于从那松鼠爪子里把我的[c:bR]特制匕首[c:]拔出来了。当然，估计你会后悔的……
            AddTranslation("DISCOVERABLEDAGGER_ONDISCOVERTEXT_280_M", "You finally pried my [c:bR]Special Dagger[c:] from the paws of that squirrel. Though you may wish that you hadn't...", "汝终自彼松鼠之爪拔朕[c:bR]特匕[c:]。然汝或愿未尝如是……");
            // 你在那里鼓捣什么呢？
            AddTranslation("DISCOVERABLEFILMROLL_ONDISCOVERTEXT_506_M", "What are you up to over there?", "汝于彼何为？");
            // 戒指戴着合适吗？
            AddTranslation("DISCOVERABLERING_ONDISCOVERTEXT_523_M", "Does it fit?", "佩之适乎？");
            // 只是垃圾而已。你想要吗？
            AddTranslation("DISCOVERABLECARD_OUROBOT_ONDISCOVERTEXT_637_M", "More junk. Want it?", "又一废物。汝欲之乎？");
            // 你捞出了一块墓志铭！
            AddTranslation("GBC_TEMPLE_UNDEAD_821_M", "You pulled up an epitaph piece!", "汝捞得墓志一片！");
            // 你在井里发现了一张卡牌。由于潮湿，墨迹都洇开了。
            AddTranslation("GBC_TEMPLE_UNDEAD_818_M", "You found a card in the well. The ink is running from the moisture.", "汝于井得一牌。湿侵其上，墨迹已漫。");
            // 窗口未在最前时暂停
            AddTranslation("MISC_832", "PAUSE WHEN WINDOW NOT FOCUSED", "窗不居前则时停");
            // 它的真面目非常狰狞……连我都要惧三分。
            AddTranslation("ASCENSION_IJIRAQREVEALED_316", "Its true appearance is frightening... even to me.", "其真容甚怖……余亦为之惧。");
            // 猎人不见了。
            AddTranslation("SPECIAL_NODES_TRAPPERABSENTINTRO_322", "The Trapper was gone.", "猎夫已去。");
            // 出于好意，你只拿走了买得起的东西。
            AddTranslation("SPECIAL_NODES_TRAPPERABSENTINTRO_167", "In deference to his memory, you took only what you could afford.", "念其旧，汝唯取所能偿者。");
            // 此处空无一人。
            AddTranslation("SPECIAL_NODES_TRAPPERABSENTINTRO_REPEAT_#1_654", "No one was there.", "此处无人。");
            // 一堆毛皮被丢在原地。
            AddTranslation("SPECIAL_NODES_TRAPPERABSENTINTRO_REPEAT_#1_097", "A pile of pelts lay abandoned.", "裘革堆弃于此地。");
            // 你决定只拿走买得起的东西。
            AddTranslation("SPECIAL_NODES_TRAPPERABSENTINTRO_REPEAT_#1_112", "You decided not to take more than you could afford.", "汝决不取逾所能偿者。");
            // 唔，我还不太习惯宣告这张地图呢。
            AddTranslation("GAME_FLOW_REGIONFOREST_387", "Hm. I'm not used to announcing this one.", "唔……余未惯宣此图。");
            // [c:bR]你是不是乱调我地图顺序来着，凯茜？[c:]
            AddTranslation("GAME_FLOW_REGIONFOREST_705", "[c:bR]Have you tinkered with the order of my maps, Kaycee?[c:]", "[c:bR]凯茜，汝窜乱朕诸图之序乎？[c:]");
            // 行吧……
            AddTranslation("GAME_FLOW_REGIONFOREST_660", "Very well...", "善矣……");
            // 旭日初升，笼罩着沉睡的冷杉林……
            AddTranslation("GAME_FLOW_REGIONFOREST_268", "The sun rose over the sleepy firs...", "旭日初升，照彼眠杉……");
            // 飞鸟振翅，穿梭于狼和麋鹿的途经之路……
            AddTranslation("GAME_FLOW_REGIONFOREST_199", "Birds fluttered across the paths of wolves and elk...", "飞鸟振翅，度狼与麋所行之途……");
            // 你来到了……[c:bR]林地。[c:]
            AddTranslation("GAME_FLOW_REGIONFOREST_979", "You were embarking upon... [c:bR]The Woodlands.[c:]", "汝来履……[c:bR]林地。[c:]");
            // 耳闻狼嚎，身沐朝晖……
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#1_864", "You heard the howling of wolves, greeting the morning sun...", "耳闻狼嚎，迎彼朝日……");
            // 瞥见不远处的郊狼，你不禁加快了脚步......
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#1_172", "The sight of a nearby coyote caused you to quicken your pace...", "迩郊狼一现，汝不觉疾步……");
            // 你已到达……[c:bR]林地。[c:]
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#1_960", "You had reached... [c:bR]The Woodlands.[c:]", "汝已至……[c:bR]林地。[c:]");
            // 你脚下的松针嘎吱作响......
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#2_029", "Pine needles crunched beneath your feet...", "松针足下戛然作声……");
            // 你吸了一口新鲜空气……
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#2_632", "You drew in a breath of the fresh scented air...", "汝吸清芬之一缕……");
            // 在你跟前的就是……[c:bR]林地。[c:]
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#2_818", "You were embraced by... [c:bR]The Woodlands.[c:]", "汝见所怀于……[c:bR]林地。[c:]");
            // 黎明的美好景象映入眼帘……
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#3_119", "You beheld the beauty of the dawn...", "汝见曙色之美……");
            // 唯有前方微弱的叮当声能让你分神片刻......
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#3_584", "Only a faint clinking sound ahead could distract you from the sight...", "唯前微叮之声，使汝暂分其神……");
            // 你踏上了……[c:bR]林地。[c:]
            AddTranslation("GAME_FLOW_REGIONFOREST_REPEAT_#3_900", "You set out upon... [c:bR]The Woodlands.[c:]", "汝踏至……[c:bR]林地。[c:]");
            // [c:bR]惹人生厌的卡牌？[c:]
            AddTranslation("ASCENSION_CHALLENGEANNOYINGSTARTERDECK_384", "[c:bR]Annoying cards?[c:]", "[c:bR]可厌之牌乎？[c:]");
            // 这些猛兽绝对和这个词毫无关系……
            AddTranslation("ASCENSION_CHALLENGEANNOYINGSTARTERDECK_548", "These majestic beasts are anything but...", "此等猛兽，安可谓可厌乎……");
            // 恕我持不同意见。
            AddTranslation("ASCENSION_CHALLENGEANNOYINGSTARTERDECK_707", "I disagree with this one.", "此一条，余不与焉。");
            // 唔？这么多图腾……
            AddTranslation("ASCENSION_CHALLENGEALLTOTEMS_216", "Hm? So many totems...", "唔？神偶何其多也……");
            // [c:bR]木雕师[c:]真是没闲着……
            AddTranslation("ASCENSION_CHALLENGEALLTOTEMS_575", "[c:bR]The Woodcarver[c:] had been busy...", "[c:bR]木雕师[c:]甚勤……");
            // 图腾吗？是头目战用的？
            AddTranslation("ASCENSION_CHALLENGEBOSSTOTEMS_886", "Totems? For boss battles?", "神偶可施于魁战乎？");
            // [c:bR]很好。[c:]我喜欢这个。
            AddTranslation("ASCENSION_CHALLENGEBOSSTOTEMS_770", "[c:bR]Well done.[c:] I like this one.", "[c:bR]善哉。[c:]余好此。");
            // 等会儿……
            AddTranslation("ASCENSION_CHALLENGENOBOSSRARES_645", "Wait a moment...", "少待……");
            // 不好意思。这些不是稀有卡牌。
            AddTranslation("ASCENSION_CHALLENGENOBOSSRARES_800", "You must excuse me. These are not rare cards.", "恕我。此等非[c:bR]罕有牌[c:]。");
            // 呃，我把三叶草放哪儿了？
            AddTranslation("ASCENSION_CHALLENGENOCLOVER_409", "Hm? Where did I place that clover?", "唔？我置彼三叶草于何处矣？");
            // 这价格比我印象中高……
            AddTranslation("ASCENSION_CHALLENGEEXPENSIVEPELTS_880", "Those prices are higher than I recall...", "彼价贵于朕忆……");
            // 猎人……那天……可是讨了个好价钱。
            AddTranslation("ASCENSION_CHALLENGEEXPENSIVEPELTS_777", "The Trapper... was... driving a hard bargain that day.", "猎夫……彼日……索价甚峻。");
            // 蛋居然没摔碎……真是奇了。
            AddTranslation("ASCENSION_CUCKOOSPAWNRAVENEGG_633", "The egg survived the fall... How curious.", "卵坠而未毁……异哉。");
            // 无卡牌可动。
            AddTranslation("ASCENSION_HINT_POCKETWATCHNOCARDS_294", "There are no cards to move.", "无牌可移。");
            // 无卡牌可动……
            AddTranslation("ASCENSION_HINT_POCKETWATCHNOCARDS_REPEAT_#1_639", "Nothing to move.", "无可移者。");
            // 唔。不行，这可不行。
            AddTranslation("ASCENSION_HINT_POCKETWATCHGIANTCARD_666", "Hm. No, I can't allow that.", "唔。不可，余弗许。");
            // 太大了，不好动。
            AddTranslation("ASCENSION_HINT_POCKETWATCHGIANTCARD_REPEAT_#1_018", "It's too big to move anyways.", "其甚巨，不可移。");
            // 我知道你见过这类器具。
            AddTranslation("ASCENSION_FOUNDBLEACHPOT_956", "I know you have seen such utensils before.", "余知汝昔已见此器。");
            // 或许你想要用一用？
            AddTranslation("ASCENSION_FOUNDBLEACHPOT_503", "Perhaps you would like to use them?", "汝或欲用之乎？");
            // 既然我们气喘吁吁的巫师朋友已经被关起来了……
            AddTranslation("ASCENSION_FOUNDBLEACHPOT_046", "Now that our wheezing wizard friend is locked away...", "既其气喘之巫已见锢……");
            // 赶紧拿走吧。我会时不时拿出来给你。
            AddTranslation("ASCENSION_FOUNDBLEACHPOT_730", "Take it now. I will also offer it from time to time.", "今取之。余亦时或授汝。");
            // 可靠呢……那块怀表从没停止过跳动。
            AddTranslation("ASCENSION_FOUNDPOCKETWATCH_568", "Reliable... that pocket watch never stops ticking.", "可信矣……彼怀表之鸣未尝止。");
            // 或许你要用用吗？
            AddTranslation("ASCENSION_FOUNDPOCKETWATCH_842", "Perhaps you would like to use it?", "汝或欲用之乎？");
            // 现在不行。无卡牌可漂白。
            AddTranslation("ASCENSION_HINT_BLEACHPOTNOTARGETS_983", "Not now. There's nothing to bleach.", "今不可。无可漂者。");
            // 无卡牌可漂白。
            AddTranslation("ASCENSION_HINT_BLEACHPOTNOTARGETS_REPEAT_#1_609", "There are no cards to bleach.", "无牌可漂。");
            // 我没什么东西可漂白的。
            AddTranslation("ASCENSION_HINT_BLEACHPOTNOTARGETS_REPEAT_#2_561", "There's nothing of mine to be bleached.", "余无可漂之物。");
            // 你的前一任轻易就认输了。
            AddTranslation("ASCENSION_RESETRUNPUNISHMENT_452", "Your predecessor gave up too easily.", "乃前人轻易而降。");
            // 你赚的毛皮没那么多了。
            AddTranslation("ASCENSION_RESETRUNPUNISHMENT_973", "Less pelts for you.", "乃裘革少矣。");
            // [c:bR]２张毛皮[c:]就行了吗？
            AddTranslation("ASCENSION_RESETRUNPUNISHMENT_REPEAT_#1_849", "You wish to start with [c:bR]2 pelts[c:]?", "汝欲以[c:bR]二裘革[c:]始乎？");
            // 可别这么乖乖投降。
            AddTranslation("ASCENSION_RESETRUNPUNISHMENT_REPEAT_#1_336", "Don't surrender to me so willingly.", "毋若是轻降于我。");
            // 你很意外？难道想要更多毛皮？
            AddTranslation("ASCENSION_RESETRUNPUNISHMENT_REPEAT_#2_882", "Are you surprised? Were you expecting more pelts?", "汝异乎？冀甚多裘革乎？");
            // [c:bR]别做个懦夫。[c:]
            AddTranslation("ASCENSION_RESETRUNPUNISHMENT_REPEAT_#2_909", "[c:bR]Be less of a coward.[c:]", "[c:bR]毋为怯夫。[c:]");
            // 这……
            AddTranslation("ASCENSION_LESHYGRAMOPHONETRACK_744", "That one...", "彼曲……");
            // 让我想起了……
            AddTranslation("ASCENSION_LESHYGRAMOPHONETRACK_289", "stirs up memories...", "动我旧识……");
            // 噢不……
            AddTranslation("ASCENSION_COPYCARDINTRO1_881", "Oh no...", "噫，不……");
            // 我还以为我早就把这瓶子扔进河里了。
            AddTranslation("ASCENSION_COPYCARDINTRO1_797", "I thought I had tossed this bottle in the river.", "余本谓已投此瓶于河。");
            // 我提前赔个不是……
            AddTranslation("ASCENSION_COPYCARDINTRO1_REPEAT_#1_762", "I apologize in advance...", "余先谢罪……");
            // 你遇到了……一坨可疑的黏液……
            AddTranslation("ASCENSION_COPYCARDINTRO1_REPEAT_#3_604", "You came across... a suspicious slime...", "汝遇……可疑黏涎之团……");
            // 我不会坐视不管……
            AddTranslation("ASCENSION_COPYCARDINTRO1_REPEAT_#4_006", "I can't allow this for much longer...", "余不可久容此……");
            // 就说你喜欢那副画吧。
            AddTranslation("ASCENSION_COPYCARDINTRO1_REPEAT_#5_621", "Just say you like the painting.", "但言汝悦其画。");
            // 我的耐心快耗尽了……
            AddTranslation("ASCENSION_COPYCARDINTRO1_REPEAT_#6_869", "My patience is nearing its limits...", "余之忍殆尽矣……");
            // 讨厌的黏……
            AddTranslation("ASCENSION_COPYCARDINTRO1_REPEAT_#7_217", "Tiresome goo...", "此胶烦甚……");
            // 不！不！我会尽力帮忙的。
            AddTranslation("ASCENSION_COPYCARDINTRO2_473", "No! No! I will make myself useful.", "不！不！吾将自效。");
            // 我会画画！跟大师一样会画画！
            AddTranslation("ASCENSION_COPYCARDINTRO2_739", "I will paint! Just like The Master!", "吾将作画！如大师然！");
            // 就是画得没大师好。
            AddTranslation("ASCENSION_COPYCARDINTRO2_182", "Not as good as The Master, no.", "然，不若大师之善。");
            // 我也许会犯点小错！
            AddTranslation("ASCENSION_COPYCARDINTRO2_998", "I may make some errors!", "吾或有误！");
            // 要我给你画什么吗？
            AddTranslation("ASCENSION_COPYCARDINTRO2_646", "What shall I paint for you?", "当为子画何物？");
            // 让我为你画画吧！
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#1_371", "Let me paint for you!", "请使吾为子画！");
            // 我会力求完美的。
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#1_677", "I will aim for perfection.", "吾将求其尽善。");
            // 我会画画……
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#3_968", "I will paint...", "吾将作画……");
            // 跟大师一样会画画！
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#3_816", "Just like The Master!", "如大师然！");
            // 求你了！
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#4_314", "Please!", "请！");
            // 再给我个机会！
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#4_349", "Allow me another chance!", "更予吾一机！");
            // 我会尽力帮忙的！
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#5_402", "I will make myself useful!", "吾将自效！");
            // 画点啥好呢？
            AddTranslation("ASCENSION_COPYCARDINTRO2_REPEAT_#5_198", "What shall I paint?", "当画何物？");
            // 唔，没错。
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_689", "Hmm, yes.", "唔，然。");
            // 我想想我能干点啥。
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_142", "Let's see what I can do.", "且观吾所能为。");
            // 让我来试试！
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_REPEAT_#1_973", "I will attempt this!", "吾将试此！");
            // 我可以画你的卡牌！
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_REPEAT_#2_325", "I will paint your card!", "吾将画子之牌！");
            // 我可以试试看……
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_REPEAT_#3_858", "I will give it a try...", "吾将试之……");
            // 唔……不好办……
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_REPEAT_#4_472", "Hmm... Tricky...", "唔……殊难……");
            // 我会竭尽所能……
            AddTranslation("ASCENSION_COPYCARDEXAMINESELECTION_REPEAT_#5_339", "I will muster all my ability for this one...", "吾将竭吾所能于此……");
            // 你……你觉得怎么样？
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_658", "W-what do you think?", "子—子以为何如？");
            // 大师会为我骄傲吗？
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_707", "Would The Master be proud?", "大师将以吾为荣乎？");
            // [c:bR]快点头！[c:]
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_589", "[c:bR]Please say yes![c:]", "[c:bR]请言“然”！[c:]");
            // 像你的卡牌吧？
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_815", "Is it just like your card?", "其如子之牌乎？");
            // [c:bR]还行吗？[c:]
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_592", "[c:bR]Is it good?[c:]", "[c:bR]其善乎？[c:]");
            // 别逼我再把你收起来。
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_015", "Don't make me put you away again.", "毋使余复收尔。");
            // 怎么样？
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_REPEAT_#1_462", "What do you think?", "子以为何如？");
            // [c:bR]快说话呀！[c:]
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_REPEAT_#2_198", "[c:bR]Please say something![c:]", "[c:bR]请出一言！[c:]");
            // 我画得还不赖吧？
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_REPEAT_#3_029", "Did I do alright?", "吾作得可乎？");
            // 我……我尽力了……
            AddTranslation("ASCENSION_COPYCARDPRESENTRESULT_REPEAT_#4_404", "I- I tried my best...", "吾—吾尽力矣……");
            // 牌组中已无卡牌。
            AddTranslation("ASCENSION_HINT_MAGNIFYINGGLASSNOCARDS_712", "You have no cards in your deck...", "乃牌列中已无牌……");
            // 不行。你已无卡牌。
            AddTranslation("ASCENSION_HINT_MAGNIFYINGGLASSNOCARDS_REPEAT_#1_234", "No. You have no cards.", "否。汝已无牌矣。");
            // 喜鹊的放大镜。
            AddTranslation("ASCENSION_FOUNDMAGNIFYINGGLASS_816", "The Magpie's Glass.", "鹊之镜。");
            // 拿着吧。没准我接下来会给你更多。
            AddTranslation("ASCENSION_FOUNDMAGNIFYINGGLASS_753", "Take it. I may offer more of them on your journey.", "取之。乃旅之中，余或更授若此者。");
            // 拿下吧，我还有别的。
            AddTranslation("ASCENSION_TRAPPERBOUGHTKNIFE_196", "Take it, I have others.", "取之，余尚有他刀。");
            // 希望它能助你割下最好的毛皮。
            AddTranslation("ASCENSION_TRAPPERBOUGHTKNIFE_REPEAT_#2_042", "May it cut ye the finest pelt.", "愿此助尔剥上上之革。");
            // 成交。好好用它……
            AddTranslation("ASCENSION_TRAPPERBOUGHTKNIFE_REPEAT_#3_614", "Sold. Use it well...", "成矣。善用之……");
            // 这把刀归你了。
            AddTranslation("ASCENSION_TRAPPERBOUGHTKNIFE_REPEAT_#5_007", "Th' knife is yers.", "此刀归尔矣。");
            // 凯茜……你是不是……
            AddTranslation("ASCENSION_ASCENSIONFECUNDITYNERF_739", "Kaycee... did you?", "凯茜……汝为之乎？");
            // [c:bR]你篡改了我的一个印记。[c:]
            AddTranslation("ASCENSION_ASCENSIONFECUNDITYNERF_129", "[c:bR]You tampered with one of my sigils.[c:]", "[c:bR]汝篡朕一印契矣。[c:]");
            // 你肯定是觉得它太强了。但请……
            AddTranslation("ASCENSION_ASCENSIONFECUNDITYNERF_047", "You thought it too powerful no doubt. But please...", "汝必以此印强甚矣。然请……");
            // [c:bR]下不为例。[c:]
            AddTranslation("ASCENSION_ASCENSIONFECUNDITYNERF_675", "[c:bR]No more of that.[c:]", "[c:bR]毋复为此。[c:]");
            // 你的毛皮……
            AddTranslation("ASCENSION_TRADERPELTLICE_541", "Your pelts...", "君之裘革……");
            // 上面到处都是[c:bR]虱子[c:]！
            AddTranslation("ASCENSION_TRADERPELTLICE_661", "They are riddled with [c:bR]Lice[c:]!", "其尽蠕[c:bR]虱[c:]！");
            // 拿这个去买新的吧。
            AddTranslation("ASCENSION_TRADERPELTLICE_539", "Use this to buy new ones.", "以此易新裘革。");
            // 你的毛皮……它们[c:bR]很糟糕[c:]！
            AddTranslation("ASCENSION_TRADERPELTLICE_REPEAT_#1_592", "Your pelts... are [c:bR]lousy[c:]!", "君之裘革……[c:bR]多虱[c:]矣！");
            // 这几颗牙齿你得收下。
            AddTranslation("ASCENSION_TRADERPELTLICE_REPEAT_#1_095", "I must give you these teeth.", "鄙不得不予君此诸牙。");
            // 求你了……把你那些烧了再买过吧。
            AddTranslation("ASCENSION_TRADERPELTLICE_REPEAT_#1_525", "Please... burn what you have and buy more.", "请……焚君所有，而更易新裘革。");
            // 你的毛皮上长满了虱子。
            AddTranslation("ASCENSION_TRADERPELTLICE_REPEAT_#3_777", "Your pelts are infested.", "君之裘革尽生虱矣。");
            // 拿着这个走人吧。
            AddTranslation("ASCENSION_TRADERPELTLICE_REPEAT_#3_578", "Take this and leave.", "取此而去。");
            // 太惨了。这些拿去。
            AddTranslation("ASCENSION_TRADERPELTLICE_REPEAT_#4_671", "How tragic. Take these.", "悲哉。取此诸牙。");
            // 嗯？
            AddTranslation("ASCENSION_PIRATESKULLINTRO1_734", "Hm?", "嗯？");
            // 真是古怪。
            AddTranslation("ASCENSION_PIRATESKULLINTRO1_477", "This is most peculiar.", "此诚奇矣。");
            // 但我觉得可以。
            AddTranslation("ASCENSION_PIRATESKULLINTRO1_481", "But I'll allow it.", "然余许之。");
            // 又是你？
            AddTranslation("ASCENSION_PIRATESKULLINTRO1_REPEAT_#1_307", "You again?", "复汝乎？");
            // 明白了。继续。
            AddTranslation("ASCENSION_PIRATESKULLINTRO1_REPEAT_#2_283", "I see. Carry on.", "了矣。且续行。");
            // 咋了？
            AddTranslation("ASCENSION_PIRATESKULLINTRO2_554", "Y-yar?", "呀—呀？");
            // 我了个大柠檬啊……
            AddTranslation("ASCENSION_PIRATESKULLINTRO2_REPEAT_#1_027", "Shiver me lemons...", "柠檬震某……");
            // 哟吼吼？
            AddTranslation("ASCENSION_PIRATESKULLINTRO2_REPEAT_#2_413", "Yo ho ho?", "哟吼吼？");
            // 又到点了？
            AddTranslation("ASCENSION_PIRATESKULLINTRO2_REPEAT_#2_181", "Is it time again?", "又届时乎？");
            // 啊哈？
            AddTranslation("ASCENSION_PIRATESKULLINTRO2_REPEAT_#3_885", "Ahoy?", "啊嗬？");
            // 到点了？
            AddTranslation("ASCENSION_PIRATESKULLINTRO2_REPEAT_#3_306", "Be it time?", "届时乎？");
            // 我嘞个大橙子啊……
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_231", "Well boil me oranges...", "橙子烹某……");
            // 你差点赢过我。
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_203", "Ye've almost bested me.", "汝几胜某。");
            // 但我还有最后一招！
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_049", "But I've got ye one last trick!", "然某尚有一终招！");
            // 奶奶的小柠檬……
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#1_049", "Squeeze me lemons...", "柠檬榨某……");
            // 不错嘛。
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#1_204", "Yer good.", "汝善。");
            // 但看我最后这一招！
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#1_518", "But I've got ye a final trick!", "然某尚有最后一计！");
            // 哎呀……你打得不错……
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#2_123", "Aye... ye've played well...", "然……汝用牌善矣……");
            // 但你瞧好了这招！
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#2_415", "But avast ye this!", "然观此！");
            // 爷爷的小酸果儿……你挺行的。
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#3_028", "Rattle me limes... yer good.", "酸果撼某……汝善。");
            // 但请允许我来个撒手锏……
            AddTranslation("ASCENSION_PIRATESKULLPRECHARGE_REPEAT_#3_885", "But allow me this final gambit...", "然请容某此终计……");
            // 别太过了。
            AddTranslation("ASCENSION_PIRATESKULLPOSTCHARGE_750", "That's far enough.", "止于此可矣。");
            // 小心。差不多了。
            AddTranslation("ASCENSION_PIRATESKULLPOSTCHARGE_REPEAT_#1_200", "Careful. That's enough.", "慎之。可矣。");
            // 我绝对不会让你毁了我的牌桌。
            AddTranslation("ASCENSION_PIRATESKULLPOSTCHARGE_REPEAT_#2_625", "I won't allow you to destroy my table.", "余不容汝毁朕案。");
            // 差不多就行了。
            AddTranslation("ASCENSION_PIRATESKULLPOSTCHARGE_REPEAT_#3_527", "That's quite enough.", "可矣。");
            // 行了行了。
            AddTranslation("ASCENSION_PIRATESKULLPOSTCHARGE_REPEAT_#4_031", "Enough of that.", "已矣。");
            // 听着，我那船员可是海上顶呱呱的！
            AddTranslation("ASCENSION_PIRATESKULLSHIPSPAWNED_188", "Yar, me crew be the finest on the seas!", "听哉，某之骨伍，海上莫善！");
            // 他们忠心一片，绝不会背叛我！
            AddTranslation("ASCENSION_PIRATESKULLSHIPSPAWNED_699", "Stalwart skeles who'd never betray me!", "皆壮骨，永不叛某！");
            // 我……我的船员？是叛徒？！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_919", "M-me crew? Mutineers?!", "某—某之骨伍？叛乎？！");
            // 啊啊啊啊！这可是压倒我的最后一根稻草！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_427", "Arrrrr! This be the last straw mate!", "啊啊啊！此诚末草，竟压某矣！");
            // 盐津津达瑞尔！你哪儿来的胆子！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#1_025", "Salty Daryl! How could ye!", "盐津达瑞尔！汝安敢！");
            // 大脏牙巴里？你也参与了？
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#2_611", "Browntooth Barrie? Ye too?", "脏牙巴里？汝亦然乎？");
            // 干巴瘦斯普林特……怎么可能呢……
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#3_924", "Bonnie Splinter... it can't be...", "干巴斯普林特……不然……");
            // 走私鬼贝瑟尔？我真是高看你了。
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#4_361", "Freebooter Bethel? I thought better of ye.", "江贼贝瑟尔？某本高料汝。");
            // 还有你吗，疯橡木疙瘩海沃德？
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#5_302", "Et tu, Crazy Oakes Hayward?", "疯木疙瘩海沃德，汝亦乎？");
            // 邋遢鬼阿什顿！你个怂包！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#6_668", "Ashton Swabby! Ye coward!", "邋遢鬼阿什顿！汝懦夫！");
            // 跳大海布拉顿……别啊！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#7_662", "Plankton Braxton... No!", "跳大海布拉顿……不！");
            // 黄眼仁儿科尔比。你这脏狗！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#8_292", "Yeller-eye Colby. Ye dog!", "黄眼科尔比！汝犬彘！");
            // 为什么啊，卖鱼佬内特……为什么？！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#9_975", "Why Fishwife Nate... why?!", "鱼贾内特……何故哉？！");
            // 缺手指弗雷德，你一辈子就只能当怂包。
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#10_019", "Four-finger Fred, ye always were a coward.", "四指弗雷德，汝素为怯夫。");
            // 我不会怀念你的，野狗朱莉。
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#11_624", "I won't miss ye, Dawg Julie.", "野狗朱莉，某不思汝。");
            // 我居然还信任你做我的大副，鬼心眼儿琼斯。
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#12_656", "Te thing ye were me first mate, Wicked Jones.", "邪心琼斯，某竟尝以汝为大副！");
            // 螃蟹脸斯蒂勒，你个混账！
            AddTranslation("ASCENSION_PIRATESKULLSHIPMUTINEE_REPEAT_#13_150", "Crabby Steele, ye blaggard!", "蟹脸斯蒂勒！汝此恶棍！");
            // 啊哈！你的卡牌都用光了！
            AddTranslation("ASCENSION_PART1CARDSEXHAUSTEDSHIP_758", "Yar! Ye be out of cards!", "呀哈！汝牌尽矣！");
            // 伙计们，全速前进！
            AddTranslation("ASCENSION_PART1CARDSEXHAUSTEDSHIP_279", "Full speed ahead lads!", "全速前驱，诸小子！");
            // 呀哈哈！
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_422", "Yar har har!", "呀哈哈！");
            // 给我瞄准……
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_994", "Aim...", "瞄准……");
            // 准备好吃炮弹吧！
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_REPEAT_#1_411", "Prepare to meet me cannonballs!", "备受某之炮丸！");
            // 小的们，扶稳瞄好！
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_REPEAT_#2_220", "Hold steady lads!", "持稳，诸小子！");
            // 准备开火！
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_REPEAT_#2_130", "Prepare to fire!", "备发炮！");
            // 我的炮弹像柠檬一样有料。
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_REPEAT_#3_754", "Me cannons be like me lemon juicer.", "某之炮，犹某柠檬之榨器也。");
            // 随时准备开炮！
            AddTranslation("ASCENSION_PIRATESKULLAIMCANNONS_REPEAT_#3_694", "Always ready to fire!", "常备而发！");
            // 该死！我的船上怎么到处是耗子！
            AddTranslation("ASCENSION_PIRATESKULLRODENTPACK_939", "Blast! Me ship is full o' rodents!", "该诅！某之舟楫鼠满患矣！");
            // 哎呦……我船上真是耗子满地跑。
            AddTranslation("ASCENSION_PIRATESKULLRODENTPACK_REPEAT_#1_077", "Yar... me ship be riddled with vermin.", "呀……某之舟楫尽为虫豸所据。");
            // 我的船啊！真是满坑满谷都是耗子！
            AddTranslation("ASCENSION_PIRATESKULLRODENTPACK_REPEAT_#2_788", "Me ship! It be chock full o' rodents!", "某之舟楫哉！满皆鼠矣！");
            // 见了鬼了！全是活耗子！
            AddTranslation("ASCENSION_PIRATESKULLRODENTPACK_REPEAT_#3_967", "Be damned! Vermin all about!", "该诅！虫豸四布！");
            // 我那身染败血症却纵横七大洋的水手之梦？
            AddTranslation("ASCENSION_PIRATESKULLINTRO3_328", "Me dream to be a scurvy boss upon the seven seas?", "余纵横七海、为癞疮魁之梦乎？");
            // 还能有次机会破浪而行……纵横七大洋？
            AddTranslation("ASCENSION_PIRATESKULLINTRO3_REPEAT_#1_005", "Another chance to ride the waves... upon the seven seas?", "可复得一机乘浪……纵横七海乎？");
            // 再给我次机会乘风破浪，与宝贝船一起冒险？
            AddTranslation("ASCENSION_PIRATESKULLINTRO3_REPEAT_#2_405", "A chance again to surf the tides, with me fine hearties?", "可复得一机乘潮，与某之弟兄共游乎？");
            // 再来一次，吃着海鲜唱着歌，纵横七大洋？
            AddTranslation("ASCENSION_PIRATESKULLINTRO3_REPEAT_#3_823", "Another go, a yo ho ho, again upon the seas?", "可再来一遭，呦呵呵，复行海上乎？");
            // 吃我这招！
            AddTranslation("ASCENSION_PIRATESKULLINTRO4_975", "Avast ye!", "看招！");
            // 封好舷窗！
            AddTranslation("ASCENSION_PIRATESKULLINTRO4_REPEAT_#1_073", "Batten down th' hatches!", "闭舱盖！");
            // 你的下一站，就是浑浊的海沟底！
            AddTranslation("ASCENSION_PIRATESKULLINTRO4_REPEAT_#2_773", "Yer next stop? Th' briny deep!", "汝之所向？乃咸海之渊！");
            // 死无对证！
            AddTranslation("ASCENSION_PIRATESKULLINTRO4_REPEAT_#3_256", "Dead Challengers tell no tales!", "死角者无言。");
            // 预备开炮吧，小伙子们！
            AddTranslation("ASCENSION_PIRATESKULLINTRO4_REPEAT_#4_283", "Man the cannons me hearties!", "诸弟兄，操炮！");
            // 癞疮狗，吃我一招！
            AddTranslation("ASCENSION_PIRATESKULLINTRO4_REPEAT_#5_481", "Avast ye, scallywag!", "看招，泼贼！");
            // 柠檬琴号沉了？
            AddTranslation("ASCENSION_PIRATESKULLSHIPDESTROYED_763", "The Limoncello is sunk?", "柠檬琴号没矣乎？");
            // 就被你，一个卑鄙的旱鸭子击沉了？
            AddTranslation("ASCENSION_PIRATESKULLSHIPDESTROYED_761", "By ye, a lowly landlubber?", "竟为汝此鄙旱鸭所沉乎？");
            // 我简直不敢相信。
            AddTranslation("ASCENSION_PIRATESKULLSHIPDESTROYED_REPEAT_#1_809", "I can scarce believe it.", "某几不敢信。");
            // 你做了什么？
            AddTranslation("ASCENSION_PIRATESKULLSHIPDESTROYED_REPEAT_#1_216", "What have ye done?", "汝何所为？");
            // 我的宝贝船呢？我的船员呢？
            AddTranslation("ASCENSION_PIRATESKULLSHIPDESTROYED_REPEAT_#2_541", "Me hearties? Me crew?", "某弟兄乎？某舟卒乎？");
            // 你连放它们的地方都没有。
            AddTranslation("BUYPELTSSEQUENCER_156", "You don't even have room for it.", "君且无地以容之。");
            // 哼！就冲我的刀，你得多拿些钱。
            AddTranslation("BUYPELTSSEQUENCER_329", "Hmmf! For my knife you'll need more.", "哼！欲得鄙之刀，君须更出其直。");
            // 你买不起的……因此出于尊重，你放弃了它。
            AddTranslation("BUYPELTSSEQUENCER_541", "You couldn't afford it... So you left it out of respect.", "君弗能酬其直……故敬而舍之。");
            // [c:bR]什么？[c:]你压根就没有可选之物？
            AddTranslation("DISKDRIVEMODSEQUENCER_387_M", "[c:bR]What?[c:] You have no valid choices at all?", "[c:bR]何？[c:]君竟无一可用之择乎？");
            // [c:bR]！？！[c:]
            AddTranslation("DISKDRIVEMODSEQUENCER_455_M", "[c:bR]!?![c:]", "[c:bR]！？！[c:]");
            // 卡牌已锁定
            AddTranslation("ASCENSIONCARDSSCREEN_021", "CARD LOCKED", "牌既锁");
            // +{0}挑战点数
            AddTranslation("ASCENSIONCHALLENGEDISPLAYER_393", "+{0} CHALLENGE POINTS", "+{0}角竞点");
            // 挑战已锁定
            AddTranslation("ASCENSIONCHALLENGEDISPLAYER_046", "CHALLENGE LOCKED", "角竞已锁");
            // {0}已启用
            AddTranslation("ASCENSIONCHALLENGESCREEN_118", "{0} ENABLED", "{0}既启");
            // {0}已禁用
            AddTranslation("ASCENSIONCHALLENGESCREEN_363", "{0} DISABLED", "{0}既禁");
            // 已增加{0}挑战点数
            AddTranslation("ASCENSIONCHALLENGESCREEN_542", "{0} Challenge Points Added", "既增{0}角竞点");
            // 已减少{0}挑战点数
            AddTranslation("ASCENSIONCHALLENGESCREEN_233", "{0} Challenge Points Subtracted", "既减{0}角竞点");
            // 警告（！）已超出级别要求
            AddTranslation("ASCENSIONCHALLENGESCREEN_905", "WARNING(!) Lvl Reqs EXCEEDED", "警（！）已逾阶限");
            // 已满足级别要求
            AddTranslation("ASCENSIONCHALLENGESCREEN_440", "Lvl Reqs Met", "阶限既足");
            // 未满足级别要求
            AddTranslation("ASCENSIONCHALLENGESCREEN_305", "Lvl Reqs NOT MET", "阶限未足");
            // 开始运行
            AddTranslation("ASCENSIONCHALLENGESCREEN_874", "START RUN", "启局");
            // 条目序号#{0}
            AddTranslation("ASCENSIONJOURNALSUMMARYSCREEN_072", "ENTRY #{0}", "第#{0}则");
            // 战败……
            AddTranslation("ASCENSIONRUNENDSCREEN_486", "DEFEAT...", "败……");
            // 胜利
            AddTranslation("ASCENSIONRUNENDSCREEN_162", "VICTORY", "胜");
            // 重试运行（保存配置）
            AddTranslation("ASCENSIONRUNENDSCREEN_673", "RETRY RUN (SAME CONFIG)", "重开此局（同设）");
            // 触发挑战：{0}
            AddTranslation("CHALLENGEACTIVATIONUI_613", "CHALLENGE TRIGGERED: {0}", "角竞既发：{0}");
            // 正在激活挑战：{0} {1}%
            AddTranslation("CHALLENGEACTIVATIONUI_180", "Activating Challenge: {0} {1}%", "惟角竞之启：{0} {1}%");
            // 已激活挑战：{0}
            AddTranslation("CHALLENGEACTIVATIONUI_866", "CHALLENGE ACTIVATED: {0}", "角竞既启：{0}");
            // （已超出！）
            AddTranslation("CHALLENGELEVELTEXT_032", "(EXCEEDED!)", "（既逾！）");
            // 挑战关卡：{0}
            AddTranslation("CHALLENGELEVELTEXT_951", "Challenge Level: {0}", "角竞之阶：{0}");
            // 全部挑战关卡已通关！
            AddTranslation("CHALLENGELEVELTEXT_036", "ALL CHALLENGE LEVELS CLEARED!", "诸角竞之阶尽克！");
            // 挑战点数：{0}
            AddTranslation("CHALLENGELEVELTEXT_521", "Challenge Points: {0}", "角竞点：{0}");
            // 地图编号#{0}
            AddTranslation("RUNINFOUIBAR_505", "MAP #{0}", "图#{0}");
            // 两侧都被挡上了。这下没地方摆铃铛了。
            AddTranslation("CREATEBELLS_114", "Blocked on both sides. No Chimes this time.", "两侧皆塞，此番不生钟。");
            // 两侧都被挡上了。这下你的河狸没地方筑坝了。
            AddTranslation("CREATEDAMS_106", "Blocked on both sides. No Dams for your Beaver.", "两侧皆塞，乃河狸不得筑坝。");
            // 配置印记属性：丰产之巢
            AddTranslation("DRAWCOPY_294", "DEPLOY SIGIL NERF: FECUNDITY", "配置印契削弱：蕃息");
            // 从版本中（）移除印记
            AddTranslation("DRAWCOPY_085", "RemoveSigilFromCopy()", "除印契于副本()");
            // //不得不做之事。
            AddTranslation("DRAWCOPY_428", "// It had to be done.", "// 不得不为之。");
            // 约拿
            AddTranslation("DEFAULTDEATHCARDS_731", "Jonah", "约拿");
            // 凯文
            AddTranslation("DEFAULTDEATHCARDS_978", "Kevin", "凯文");
            // 西恩
            AddTranslation("DEFAULTDEATHCARDS_100", "Sean", "西恩");
            // 塔麻拉
            AddTranslation("DEFAULTDEATHCARDS_237", "Tamara", "塔麻拉");
            // 丹尼尔
            AddTranslation("DEFAULTDEATHCARDS_060", "Daniel", "丹尼尔");
            // 柯迪
            AddTranslation("DEFAULTDEATHCARDS_650", "Cody", "柯迪");
            // 大卫
            AddTranslation("DEFAULTDEATHCARDS_833", "David", "大卫");
            // 塔尼
            AddTranslation("DEFAULTDEATHCARDS_374", "Tahnee", "塔尼");
            // 伯克
            AddTranslation("DEFAULTDEATHCARDS_737", "Berke", "伯克");
            // 胜利数
            AddTranslation("ASCENSIONSTAT_992", "Victories", "胜数");
            // 失败数
            AddTranslation("ASCENSIONSTAT_553", "Defeats", "败数");
            // 击败头目数
            AddTranslation("ASCENSIONSTAT_085", "Bosses Defeated", "败头目数");
            // 已抽牌数
            AddTranslation("ASCENSIONSTAT_909", "Cards Drawn", "引牌数");
            // 单次造成最大伤害
            AddTranslation("ASCENSIONSTAT_769", "Most Scales Damage In 1 Turn", "一合至伤");
            // 持有最多兽骨数
            AddTranslation("ASCENSIONSTAT_041", "Most Bones Held", "至兽骨数");
            // 伤害松鼠数
            AddTranslation("ASCENSIONSTAT_497", "Squirrels Harmed", "伤松鼠数");
            // 献祭数
            AddTranslation("ASCENSIONSTAT_757", "Sacrifices Made", "牲祀数");
            // 已交易毛皮数
            AddTranslation("ASCENSIONSTAT_598", "Pelts Traded", "易裘革数");
            // 拔取牙数
            AddTranslation("ASCENSIONSTAT_492", "Teeth Pulled", "拔牙数");
            // 抽取螳螂神次数
            AddTranslation("ASCENSIONSTAT_826", "Mantis Gods Picked", "取螳神数");
            // 昏招数量
            AddTranslation("ASCENSIONSTAT_815", "Misplays", "昏著数");
            // 开火！
            AddTranslation("PIRATESKULLBATTLESEQUENCER_366", "FIRE!", "发炮！");
            // 你这癞疮狗……
            AddTranslation("PIRATESKULLBOSSOPPONENT_123", "Ye scurvy dog...", "汝此癞疮犬……");
            // 嗯？
            AddTranslation("PIRATESKULLBOSSOPPONENT_821", "Yar?", "呀？");
            // 滋生寄生虫
            AddTranslation("CREATEEGG_RULEBOOKNAME_296", "Brood Parasite", "孳鸠");
            // 当打出[creature]时，对面位置会出现一枚蛋。
            AddTranslation("CREATEEGG_RULEBOOKDESCRIPTION_523", "When [creature] is played, an Egg is created on the opposing space.", "[creature]既陈，则对位生一卵。");
            // 那小雏都没机会看看世界……
            AddTranslation("CREATEEGG_TEXT_311", "That poor chick never had a chance...", "彼雏竟未及见天日也……");
            // 双重攻击
            AddTranslation("DOUBLESTRIKE_RULEBOOKNAME_425", "Double Strike", "复击");
            // [creature]会在攻击时额外攻击对面位置一次。
            AddTranslation("DOUBLESTRIKE_RULEBOOKDESCRIPTION_490", "[creature] will strike the opposing space an extra time when attacking.", "[creature]攻敌之时，复击其对位者一。");
            // 嗜血狂热
            AddTranslation("GAINATTACKONKILL_RULEBOOKNAME_440", "Blood Lust", "嗜血");
            // 当[creature]击杀对面造物时，可增加1点力量。
            AddTranslation("GAINATTACKONKILL_RULEBOOKDESCRIPTION_424", "When [creature] attacks an opposing creature and it perishes, this card gains 1 power.", "若[creature]击对位之物而杀之，增其一威。");
            // 回望来路，血雨腥风……
            AddTranslation("GAINATTACKONKILL_TEXT_110", "A gruesome way to grow...", "行于艰苦，长于凄惨……");
            // 挑剔之兽
            AddTranslation("HYDRAEGG_RULEBOOKNAME_854", "Finical Hatchling", "择雏");
            // [creature]在抽取时的孵化条件如下：你的牌组中的造物的生命和力量包含1至5五个数字，且每个族群的造物都有一张。
            AddTranslation("HYDRAEGG_RULEBOOKDESCRIPTION_431", "[creature] hatches when drawn if the numbers 1 to 5 are represented in the health of creatures in your deck, and in their power, and if there is a creature of each tribe in your deck.", "乃牌列中，若诸物之命与威各具一至五之数，且诸属各备，[creature]当引则能得孵。");
            // 磐石之身
            AddTranslation("MADEOFSTONE_RULEBOOKNAME_172", "Made Of Stone", "石身");
            // [creature]免疫死神之触和臭臭的印记效果。
            AddTranslation("MADEOFSTONE_RULEBOOKDESCRIPTION_563", "[creature] is immune to the effects of Touch of Death and Stinky.", "[creature]不受死触及恶臭之效。");
            // 一口之量
            AddTranslation("MORSEL_RULEBOOKNAME_777", "Morsel", "一脔");
            // 当[creature]被献祭时，它的状态值会被添加在献祭来的新卡上。
            AddTranslation("MORSEL_RULEBOOKDESCRIPTION_148", "When [creature] is sacrificed, it adds its stat values to the card it was sacrificed for.", "惟[creature]既祀，其数悉加诸受祀之牌。");
            // 拾荒者
            AddTranslation("OPPONENTBONES_RULEBOOKNAME_606", "Scavenger", "拾骨者");
            // 牌桌上出现[creature]时，它对面的造物死亡时也会产生兽骨。
            AddTranslation("OPPONENTBONES_RULEBOOKDESCRIPTION_070", "While [creature] is on the board, opposing creatures also provide bones when perishing.", "[creature]在局，对位物死，亦供兽骨。");
            // [c:bR]把你的脏爪子从我造物的骨头上拿开！[c:]
            AddTranslation("OPPONENTBONES_TEXT_974", "[c:bR]Get your paws off of my creature's bones![c:]", "[c:bR]乃秽爪速离朕造物之骨！[c:]");
            // 横冲直撞
            AddTranslation("STRAFESWAP_RULEBOOKNAME_420", "Rampager", "横冲");
            // 持牌人回合结束时，[creature]会按照印记标记的方向突进。沿途的造物会被丢到它身后。
            AddTranslation("STRAFESWAP_RULEBOOKDESCRIPTION_165", "At the end of the owner's turn, [creature] will move in the direction inscribed in the sigil. Creatures in the way will be thrown back behind it.", "持牌者合终，[creature]循印所志之向而移。当道之物，皆掷诸其后。");
            // 我可不羡慕恰好挡在公牛面前的人……
            AddTranslation("STRAFESWAP_TEXT_463", "I do not envy those that stand in the Bull's way...", "余不羡当公牛之前者……");
            // 所有普通对战都变为图腾对战。
            AddTranslation("CHALLENGE_ALLTOTEMS_DESCRIPTION_807", "All regular battles are replaced with totem battles.", "诸常战皆易为神偶战。");
            // 全部图腾战
            AddTranslation("CHALLENGE_ALLTOTEMS_TITLE_709", "All Totem Battles", "咸神偶战");
            // 起始手牌中的卡牌均带有惹人生厌印记。
            AddTranslation("CHALLENGE_ANNOYINGSTARTERDECK_DESCRIPTION_647", "Cards in starting deck have the Annoying sigil.", "初牌列诸牌皆具可厌印契。");
            // 惹人生厌的开局
            AddTranslation("CHALLENGE_ANNOYINGSTARTERDECK_TITLE_115", "Annoying Starters", "可厌初牌");
            // 所有对战中的敌方造物都变多变强。
            AddTranslation("CHALLENGE_BASEDIFFICULTY_DESCRIPTION_242", "More and stronger opposing creatures in all battles.", "诸战之敌物皆愈众愈强。");
            // 难度提升
            AddTranslation("CHALLENGE_BASEDIFFICULTY_TITLE_537", "More Difficult", "愈艰愈难");
            // 头目战也变为图腾战。
            AddTranslation("CHALLENGE_BOSSTOTEMS_DESCRIPTION_950", "Boss battles are also totem battles.", "魁战亦为神偶战。");
            // 图腾头目
            AddTranslation("CHALLENGE_BOSSTOTEMS_TITLE_731", "Boss Totems", "魁神偶战");
            // 猎人的毛皮变贵了。
            AddTranslation("CHALLENGE_EXPENSIVEPELTS_DESCRIPTION_158", "The Trapper's pelts cost more.", "猎夫之裘革益贵。");
            // 昂贵毛皮
            AddTranslation("CHALLENGE_EXPENSIVEPELTS_TITLE_850", "Pricey Pelts", "贵革益裘");
            // 莱西被换掉了，不再是本关最后头目。嘿吼，加把劲！
            AddTranslation("CHALLENGE_FINALBOSS_DESCRIPTION_836", "Leshy is replaced as the final boss of the run. Heave. Ho.", "莱西不复为此局终魁。嘿哟。");
            // 最终头目
            AddTranslation("CHALLENGE_FINALBOSS_TITLE_299", "Final Boss", "终竟易魁");
            // 前3场头目战都会出现灰熊。
            AddTranslation("CHALLENGE_GRIZZLYBOSSES_DESCRIPTION_688", "Grizzlies appear during the first 3 boss battles.", "前三魁战皆见罴。");
            // 灰熊头目
            AddTranslation("CHALLENGE_GRIZZLYBOSSES_TITLE_964", "Grizzly Bosses", "诸魁有罴");
            // 背包能装的道具少了一个。
            AddTranslation("CHALLENGE_LESSCONSUMABLES_DESCRIPTION_354", "Your pack can hold 1 less item.", "乃囊少容一物。");
            // 小号背包
            AddTranslation("CHALLENGE_LESSCONSUMABLES_TITLE_339", "Smaller Backpack", "轻囊小橐");
            // 头目只奖励普通卡牌，而非稀有卡牌。
            AddTranslation("CHALLENGE_NOBOSSRARES_DESCRIPTION_112", "Bosses award regular cards instead of rares.", "魁胜所赐，常牌而非罕有牌。");
            // 寻常头目
            AddTranslation("CHALLENGE_NOBOSSRARES_TITLE_498", "No Boss Rares", "魁首无罕");
            // 卡牌一经选定不可更改。
            AddTranslation("CHALLENGE_NOCLOVER_DESCRIPTION_800", "You may not re-roll card choices.", "牌既摇定，不可复摇。");
            // 没有三叶草
            AddTranslation("CHALLENGE_NOCLOVER_TITLE_486", "No Clover", "无三叶草");
            // 你开始时不再拥有鱼钩道具。
            AddTranslation("CHALLENGE_NOHOOK_DESCRIPTION_291", "You do not start with the Fish Hook item.", "不持鱼钩以始。");
            // 没有鱼钩
            AddTranslation("CHALLENGE_NOHOOK_TITLE_035", "No Hook", "始无鱼钩");
            // 你的生命减至只有一条。
            AddTranslation("CHALLENGE_ONELIFE_DESCRIPTION_540", "You are limited to 1 life.", "汝唯一命。");
            // 单支蜡烛
            AddTranslation("CHALLENGE_ONELIFE_TITLE_903", "Single Candle", "孤烟独烛");
            // 你的松鼠带有水袭印记。
            AddTranslation("CHALLENGE_SQUIRRELFISH_DESCRIPTION_503", "Your squirrels have the Waterborne sigil.", "乃松鼠皆具潜袭印契。");
            // 松鼠鱼
            AddTranslation("CHALLENGE_SQUIRRELFISH_TITLE_073", "Squirrel Fish", "潜袭松鼠");
            // 每场对战开始时，你方自带1点伤害。
            AddTranslation("CHALLENGE_STARTINGDAMAGE_DESCRIPTION_926", "Start all battles with 1 damage on your side of the scales.", "诸战皆以乃衡先受一伤而始。");
            // 天平不平
            AddTranslation("CHALLENGE_STARTINGDAMAGE_TITLE_695", "Tipped Scales", "衡有偏倾");
            // 好了，我得趁现在赶快记下来，免得又睡过去后还以为是做梦呢。
            AddTranslation("ENTRY1_BODYTEXT1_904", "OK I need to write this down NOW so I don't go to sleep and tell myself I dreamt it.", "可矣，余须即书此事，免既寝而自谓梦耳。");
            // 我加班干活来着，测试最新版游戏，但游戏里的钓鱼人突然发疯了。他四处走动，消失在了小屋里。什么鬼啊这？！莱西也多了好多对话文件里没有的内容。他说了些关于旧_数据的内容，还有钓鱼人如何忠心耿耿什么的。
            AddTranslation("ENTRY1_BODYTEXT2_628", "I'm working late and testing the latest build and out of nowhere The Angler starts FREAKING OUT. Like he pulled something up out of the river with his hook then he GETS UP and WALKS. There is no walk animation for this character! WTF?! He walked right into the cabin. I followed him in and couldn't find him. Leshy had some new dialogue lines that I CANNOT FIND IN THE DIALOGUE FILE. He said something about some OLD_DATA and how The Angler served him well or something.", "余夜治事，试新构。渔父忽狂乱，若自河中钩得一物，俄而起身乃行。此角素无行态动效，竟步而入庐。余从入，而竟寻不得。莱西竟又添有新语，余遍索语牍而不得。其言及“旧_档”，又云渔父事之甚力云云。");
            // 我真是累坏了，都在怀疑自己是不是累出幻觉了。
            AddTranslation("ENTRY1_BODYTEXT3_978", "I'm so tired that I'm already wondering if I made this up.", "余疲甚，已自疑此皆杜撰。");
            // 昨天晚上，我去海堤上散步时带了软盘去，真的就差这么一点点就把它丢到海里去了。
            AddTranslation("ENTRY10_BODYTEXT1_511", "Last night I brought the disk with me on a walk around the seawall and was THIS close to just chucking it out into the water.", "昨夜携此盘步于海堤之上，几投诸水。");
            // 如果我没记错，那卡涅夫尔代码还没被发现。出人意料的是这代码还适用于那机器。要是毁掉软盘，就没人能找到卡涅夫尔代码了，也就没人能毁掉半个欧洲了，对吧？但我后来又看到了一只河狸，它让我想到了莱西。说不定我们恰巧需要那代码才能解除那机器？这是正确答案吗？我不确定了。
            AddTranslation("ENTRY10_BODYTEXT2_752", "If I'm right the Karnoffel Code is still out there and the machine is, incredibly, still ready to accept it. Destroy the disk, no one finds the Code, and no one can blow up half of Europe. Right? But I saw an otter which made me think of Leshy. Maybe we need the Code to DISarm the machine? Could that be right? I can't be sure.", "若余所料不谬，则卡涅夫尔码犹在，而彼机竟尚能纳之。毁此盘，码遂永绝，孰能摧欧陆之半耶？理固当尔。然途见一河獭，因念莱西。抑余等正需此码以解其机之械乎？其或然欤？余未能决。");
            // 后来我就回家了。
            AddTranslation("ENTRY10_BODYTEXT3_492", "I went home.", "后余归。");
            // <数据损坏。关于质量方面的投诉，请联络卡明斯基数据存储公司。>
            AddTranslation("ENTRY11_BODYTEXT1_342", "<DATA CORRUPTED. FOR ANY QUALITY CONCERNS PLEASE CONTACT KAMINSKI DATA STORAGE MFG.>", "<档败。凡质之疑，请系卡明斯基档储坊。>");
            // 大晚上9:45的，卡明斯基先生给我打了个电话。这家伙是有毛病吗？说让我把所有软盘样本全都马上送回工厂去。他是知道些什么吗？一直念叨着“NAH TICK MASS”之类的鬼话。
            AddTranslation("ENTRY12_BODYTEXT1_197", "Call from Mr. Kaminski at 9:45 pm. What the hell is wrong with this guy? He wants all the sample disks back at the factory NOW. What does he know? NAH TICK MASS he kept saying.", "是夜亥时三刻，卡明斯基君来电。此人何其狂悖耶？遽令尽返诸样盘于工坊，刻不容缓。彼何所知？但呓语不休曰：“纳提克马斯。”");
            // 我真是受够了，但却总是下不了决心毁掉这张软盘，对不起。我手边有个小木盒，我会把软盘装里面埋了。坐标我会记在纸上，以后哪天我一激动把它烧了也说不定。莱西会感谢我。恐怕这个世界就不会了。
            AddTranslation("ENTRY12_BODYTEXT2_477", "I'm done with all of this but I can't bring myself to destroy this disk, I'm sorry. I've got a little wooden box and I'm gonna bury it with the disk inside. I'm writing the coords down and who knows maybe I'll burn them later. Leshy will thank me. The world may not.", "余意倦于斯，然终不忍毁此盘，愧矣。今得一木匣，将瘗盘其中。且志其方位，或异日焚之。莱西当谢我，天下未必我谢。");
            // 先这样，再见咯。么么哒<3
            AddTranslation("ENTRY12_BODYTEXT3_487", "Goodbye for now <3", "暂别矣，珍重。么么<3");
            // 这个模组应该绝不会被人玩到，而且按眼下的事态发展来看，这个游戏恐怕都不会有人玩到。但我还是想纵容自己幻想一番。
            AddTranslation("ENTRY13_BODYTEXT1_382", "No one will ever play this mod and, the way things are looking, they might never even play this game. But I'm gonna indulge in a fantasy.", "此补缀之作，恐终无人问津。以今之势揆之，原戏亦或湮没无闻。然余姑且纵情一梦：");
            // 数以千计的玩家玩到了这款游戏，为其痴迷。他们每个人都有各种理由热爱这款游戏，连游戏中小小的不完美都爱不释手。他们饭制各种音乐、画作、文章，就连我看了也会重新审视我自己的作品。当然，其实一条短短的评论也有同样效果。这让我觉得自己的工作有更大的意义。感激之情在我心中充盈。
            AddTranslation("ENTRY13_BODYTEXT2_138", "Thousands of players play it and love it. They each find different reasons to love it and even love its imperfections. They make music and art about it that makes me see my own work in a different way. But even a simple comment can have this effect. It makes me feel like all my work mattered and then some. I am overflowing with gratitude.", "千万戏者游而悦之，各得其趣，乃至爱其瑕玷。彼辈为之作乐绘像，使余反观己作，别有会心。即片言只字之褒，亦足动怀。恍觉平生所耗心力，皆非虚掷，更有余响。感荷之情，溢于胸臆。");
            // ……行吧，赶紧把松鼠鱼挑战做完好了。回头我估计会去一趟漫画城呢。
            AddTranslation("ENTRY13_BODYTEXT3_576", "...Well, time to finish up the Squirrel Fish challenge. Maybe I'll hit up Comics Land later.", "……今当毕潜袭松鼠之角竞。或稍后一游漫画乡。");
            // 我醒了，脑子差点疯掉。我一遍遍尝试复现钓鱼人的漏洞，但结果却次次正常。随后我意识到原来我测试时用的是另一张软盘！然后我赶快把昨天晚上用的那张盘插了进入，我勒个去啊，莱西变成3D的了。这会是什么意思？我真不知道。或许我真的疯掉了。整个游戏都不一样了。莱西接管了游戏，游戏变成3D的了。我都不知道这些话跟谁说谁能信我。
            AddTranslation("ENTRY2_BODYTEXT1_419", "So I woke up and damn near lost my mind. I tried to recreate that bug with The Angler over and over and nothing weird was happening. Then I realized I was testing on a different disk! So I popped in the same disk as last night and HOLY SHIT. Leshy went 3D. What does that mean? I barely even know. Maybe I AM crazy. The entire game is different. Leshy took over and it's 3D. I don't know anyone who would listen to me about this.", "余既寤，几丧其魄。乃屡试渔父故异，了无所怪。忽悟所试乃异盘也！亟入昨夜之盘，骇绝——莱西竟成三维。此何谓哉？余殆不自解。或余实狂矣？全戏尽易，莱西据之，万象悉为三维。此事必无可告语者。");
            // 这个……新版……邪恶冥刻……我玩了好几天了。进展惨淡。我给其他几个开发者也发了邮件——有点想要试探一下看他们知不知道点什么内情，又不想显得像个疯子。截至目前没有成效。
            AddTranslation("ENTRY3_BODYTEXT1_456", "I've been playing this... new... Inscryption now for a few days. Work has been unproductive. I emailed some of the other devs - kinda probing to see if they know anything about this without appearing crazy. No dice.", "余试戏此……新……《冥锲》，已数日矣。工事尽废。尝以邮书叩诸同僚，微探其情，而不欲显狂悖之状。竟无所获。");
            // 要说奇怪的事？游戏本身挺好玩的，是个不折不扣的好游戏。但更奇怪的是莱西这个角色。他跟玩家说话的方式仿佛是在和我本人说话一样。真诡异，但并不让人厌恶——我毕竟也缺个朋友。
            AddTranslation("ENTRY3_BODYTEXT2_454", "The strange thing? The game is fun. Like it's actually a good game. But stranger still? Leshy. He talks to the Challenger almost as if he's talking to ME. It's freaky but not altogether unwelcome - I could use a friend.", "其异者何？此戏颇可玩。诚为良构。然尤异者，莱西也。其与新角者对语，竟若直与余言。虽悚然，亦非尽可憎——余殆可藉以为友乎");
            // 昨晚我把软盘刨了个遍，想找个答案。真让我找到了些好货。不禁让我琢磨起来……“旧_数据”是什么呢，为什么莱西只在戴上木雕师面具时才肯讨论它呢？
            AddTranslation("ENTRY4_BODYTEXT1_930", "I scoured the disk last night looking for some kind of explanation. And I found some really wild stuff. It made me think... what is the OLD_DATA and why does Leshy only talk about it when he's wearing The Woodcarver's mask?", "余昨宵遍检此盘，欲求其故。乃见怪诞非常之迹，因念：“旧_档”果何物也？莱西何以唯佩刻木妪之面方言之？");
            // 我找到了卡明斯基先生的一些日志。很显然，我跟那家伙接触上时他脑子就已经不正常了……但他却似乎在日志里表示整个《邪恶冥刻》的开发过程就是一个幌子。是要掩盖什么事情呢？这要是真的可太气人了。
            AddTranslation("ENTRY4_BODYTEXT2_558", "I found some log from Mr. Kaminski. It was pretty clear when I met him that the guy had issues... but he seemed to be saying in this log that the entire development of Inscryption was a cover. For what? How infuriating if true.", "又得卡明斯基君札记数则。初晤其人，已觉其神思不属，然此记中似云：《冥锲》之全役，实为遮掩耳。所掩者何？若果尔，愤懑何极！");
            // 感觉我应该再来一轮了。
            AddTranslation("ENTRY4_BODYTEXT3_436", "Time to start another run I guess.", "殆当复启一局矣。");
            // 我已经疯狂痴迷于莱西的冥刻了。
            AddTranslation("ENTRY5_BODYTEXT1_800", "I'm addicted to Leshy's Inscryption.", "余已耽于莱西之《冥锲》。");
            // 以完美的标准而言它还有很大距离。实话说，里头好多玩意都很不平衡。就凭着一个丰产之巢印记的垃圾漏洞，我硬是把衔尾蛇的数量刷到了100以上。
            AddTranslation("ENTRY5_BODYTEXT2_758", "It's far from perfect though. Some really unbalanced shit in here to be honest. I have my Ouroboros up to over a hundred thanks to the stupidly broken Fecundity sigil combo.", "然其制未为完璧，中实多乖戾失衡者。赖蕃息印之妄配，余之衔尾蛇强已逾百。");
            // 我决定了，要亲自动手恢复游戏平衡性。再弄点真正有难度的挑战？我要做个自己的模组！真好奇莱西知道了会作何看法。
            AddTranslation("ENTRY5_BODYTEXT3_858", "I decided that I'm going to work on making this balanced. And maybe a bit of an actual challenge? I'm making a mod! I wonder what Leshy will think.", "乃决志平其衡准，庶几稍成真角竞乎？余方为更张之补缀！不知莱西意下何如。");
            // 我还在继续搞我的模组。当我发现莱西居然把食尸鬼凯茜·霍布斯的头骨当摆件放在架子上时，真是吓坏了。他用那头骨来装每场头目战后拿给猎人的牙齿……这机制蛮蠢的，为了装几颗牙他还得不断地从桌旁起身，累不累哦。看我黑了这机制，直接删掉。莱西肯定鼻子都气歪了。
            AddTranslation("ENTRY6_BODYTEXT1_202", "Work on the mod continues. I was appalled to find that Leshy chose to use the Kaycee Hobbes' ghoul skull as a trinket on his shelf. He fills it with teeth for the Trapper after every boss... Kinda lame because it's tedious to keep getting up from the table just to collect the teeth. I'll have to hack that out. He'll hate me for it.", "补缀之作，修治未辍。余见莱西取凯茜·霍布斯冢鬼之颅，置诸架上以为玩饰，骇甚。每破魁，辄实之以齿，以待猎夫。颇为无谓，盖数数起坐以拾齿，烦冗不堪。余当刬而去之。莱西其鼻必憾我而歪。");
            // 我晚上有时候会开发模组，有时候就钻研日志文件。日志越深挖，我就越能找到让自己后悔开始的东西。这软盘哪里是卡明斯基用来发泄工作压力的垃圾桶啊，这分明是些货真价实的干货。
            AddTranslation("ENTRY7_BODYTEXT1_127", "Some nights I mod, some nights I dig. I dig deeper into this log file and find things I sometimes wish I hadn't. This isn't just some disk Kaminski used to vent his workplace frustrations. This is like some real shit.", "余或夜治补缀，或夜务深掘。掘之愈深于兹札记，乃愈悔欲未见其所见。此非特卡明斯基假盘以泄胸中块垒耳。兹乃诚可畏之事。");
            // 我时不时地会从木雕师那里获得点信息，吓得我冷汗直冒。有可能这一切都是胡说八道……也有可能柏林地下真的埋着一架末日机器，激活码就是由一组卡牌构成的密码。
            AddTranslation("ENTRY7_BODYTEXT2_400", "Every once in a while I get some context from The Woodcarver and it's chilling. This could all be bunk... or there could be a doomsday machine under Berlin armed by a code hidden on a pack of cards.", "间得刻木妪所示一二语，凛然生寒。此或皆妄言耳……抑或柏林之下果有末日之械，匿码于牌牒之间，待机而发。");
            // 算得上是新闻的是我刚完成了图腾头目挑战的导入。
            AddTranslation("ENTRY7_BODYTEXT3_807", "In other news I just finished implementing the Boss Totems challenge.", "别无他闻，惟余适竟“魁神偶战”之角竞。");
            // 除了偶尔出门跟我妈吃个晚饭，我这几天基本上就没离开过房间……昨晚算是个例外。我去了趟漫画城，玩了一局传奇大陆之谜。我居然是带着软盘去的，很诡异吗？离了它我心里不舒服。
            AddTranslation("ENTRY8_BODYTEXT1_144", "I barely leave the apartment save for the odd dinner out with mom... but last night was an exception. I went to Comics Land to play a Secrets of Legendaria draft. Is it weird that I brought the disk with me? I felt uncomfortable being apart from it.", "余罕出馆舍，唯偶与母氏外飧而已。然昨宵不然。余赴漫画乡，预《传奇大陆之秘》池选之局。余竟携盘俱往，不亦异乎？然暂离此盘，辄若有所失。");
            // 最终我入手了一张流汗巨龙闪卡，但第一场对战却输给了一个举止猥琐的油管播主。那家伙直接在店里用个摇摇晃晃的破三脚架架了台摄像机，大摇大摆地录像！谁允许的啊？！
            AddTranslation("ENTRY8_BODYTEXT2_451", "I ended up ripping a foil Sweaty Dragon but lost the first match to this weird dude who wanted to record it for his YouTube channel. Like he actually brought a camcorder on a shaky looking tripod to the shop! How is that allowed?!", "终得烁龙闪箔一枚，然首战即败于一怪客，彼欲录我对战，以充其油管之影。此人竟携影录之机，支于颤危之脚架，公然入肆！此安得见容哉？！");
            // 今天我搞明白P03究竟发生什么了……是莱西把科技冥刻者直接变成了一张白鼬卡牌。当我在保险箱下面的架子上找到这张牌，并听到这牌说自己是P03还让我帮他时，我当场爆笑出声。我直接把牌给莱西了，他反而没觉得有这么可乐。估计其他冥刻者也是同样的下场吧……虽然我还没见过其他人就是了。
            AddTranslation("ENTRY9_BODYTEXT1_320", "Today I found out what happened to P03... Leshy turned The Scrybe of Technology into a Stoat card. I found the card on the shelf below the safe and laughed right out loud when it told me it was P03 and needed help. I handed it over to Leshy who was less amused. I guess this is the fate that the other Scrybes met... though I haven't seen them yet.", "今日乃知鉟〇三之所终。莱西化此机之司锲为白鼬之牌。余得此牌于匮之下架，彼自陈为鉟〇三而求援，余不觉放声大笑。遂以牌奉还莱西，莱西意颇不怿。度其馀司锲亦同此命也……然尚未之见耳。");
            // 爬行类大放送
            AddTranslation("FREEREPTILES_TITLE_890", "Free Reptiles", "鳞属无直");
            // 蛋
            AddTranslation("HYDRAEGGS_TITLE_597", "Eggs", "卵");
            // 唯一真神
            AddTranslation("MANTISGOD_TITLE_947", "One True God", "独一真神");
            // 驼鹿血
            AddTranslation("MOOSEBLOOD_TITLE_509", "Moose Blood", "驼鹿血");
            // 潜水能手
            AddTranslation("SUBMERGEBIRDS_TITLE_834", "Submersibles", "潜者");
            // 香草
            AddTranslation("VANILLA_TITLE_397", "Vanilla", "原本");
            // 柠檬琴号
            AddTranslation("!GIANTCARD_SHIP_DISPLAYEDNAME_169", "The Limoncello", "柠檬琴号");
            // 鼹鼠水手
            AddTranslation("MOLESEAMAN_DISPLAYEDNAME_591", "Mole Seaman", "鼹水手");
            // 丧尸鹦鹉
            AddTranslation("SKELETONPARROT_DISPLAYEDNAME_379", "Zombie Parrot", "尸鹦鹉");
            // 飞蚂蚁
            AddTranslation("ANTFLYING_DISPLAYEDNAME_506", "Flying Ant", "飞蚁");
            // 会飞的蚂蚁。它的勤勉只有它不会飞的陆上亲戚能媲美。
            AddTranslation("ANTFLYING_DESCRIPTION_324", "The Flying Ant. Its diligence is matched only by its grounded cousin.", "能飞之蚁。其勤，唯其走地之陆戚可匹。");
            // 水生松鼠
            AddTranslation("AQUASQUIRREL_DISPLAYEDNAME_435", "Aquasquirrel", "水松鼠");
            // 野牛
            AddTranslation("BULL_DISPLAYEDNAME_510", "Wild Bull", "莽牛");
            // 莽撞的野牛。任何挡路的物体都会被它硕大的头颅顶飞脑后。
            AddTranslation("BULL_DESCRIPTION_785", "The reckless Wild Bull. Anything in its path is flung over its ponderous skull.", "无顾之莽牛，其前之物皆为其硕首掷于后。");
            // 布谷鸟
            AddTranslation("CUCKOO_DISPLAYEDNAME_484", "Cuckoo", "杜鹃");
            // 虐杀幼崽的布谷鸟……会用受害者破碎的蛋壳填满牌桌。
            AddTranslation("CUCKOO_DESCRIPTION_994", "That infanticidal Cuckoo... It chokes up the board with the broken eggs of its victims.", "弑雏之杜鹃……以其所害之破卵塞局。");
            // 冰原狼
            AddTranslation("DIREWOLF_DISPLAYEDNAME_766", "Dire Wolf", "恐狼");
            // 不屈不挠的冰原狼。从它第一波攻势下幸存的倒霉蛋们还会面临下一波攻击……
            AddTranslation("DIREWOLF_DESCRIPTION_968", "The unrelenting Dire Wolf. Those lucky enough to survive its first attack may expect another...", "不舍之恐狼，幸免其先攻者，犹当受再击……");
            // 冰原狼幼崽
            AddTranslation("DIREWOLFCUB_DISPLAYEDNAME_153", "Dire Wolf Pup", "恐狼稚");
            // 忠心耿耿的冰原狼幼崽。它挖出来的骨头全都被直接送去见它锋利的牙齿。
            AddTranslation("DIREWOLFCUB_DESCRIPTION_528", "The loyal Dire Wolf Pup. The bone it digs up will be the first of many to meet its teeth.", "忠之恐狼稚。其所掘之骨，不过就其齿之众骨之始耳。");
            // 神角畜
            AddTranslation("HODAG_DISPLAYEDNAME_592", "Hodag", "霍达格");
            // 骇人的神角畜！它不断增强的力量就算对战终止也不会弱化。
            AddTranslation("HODAG_DESCRIPTION_748", "The hellacious Hodag! Its ever-rising power does not fall after a battle.", "可怖之霍达格！其日增之力，战终亦不坠。");
            // 九头蛇
            AddTranslation("HYDRA_DISPLAYEDNAME_069", "Hydra", "九首蛇");
            // 奇怪的蛋
            AddTranslation("HYDRAEGG_DISPLAYEDNAME_435", "Curious Egg", "奇卵");
            // 土卫二十二
            AddTranslation("IJIRAQ_DISPLAYEDNAME_962", "Ijiraq", "伊耶拉克");
            // 鼹鼠人？
            AddTranslation("IJIRAQ_UNLOCKSCREEN_DISPLAYEDNAME_597", "Mole Man?", "鼹人？");
            // 虱子
            AddTranslation("LICE_DISPLAYEDNAME_207", "Pelt Lice", "裘虱");
            // 被低估了的虱子。它是毛皮生意里逃不掉的因素。
            AddTranslation("LICE_DESCRIPTION_468", "The underestimated Pelt Lice. An inescapable aspect of the fur trade.", "见轻之裘虱。然裘革之贾，终不免于此。");
            // 面包虫
            AddTranslation("MEALWORM_DISPLAYEDNAME_113", "Mealworm", "麦虫");
            // 有存在感的面包虫。此情此景，你难道没流口水吗？
            AddTranslation("MEALWORM_DESCRIPTION_985", "The delectable Mealworm. Does your mouth not water at the sight?", "甘美之麦虫，观此而乃口不流涎乎？");
            // 东方泥龟
            AddTranslation("MUDTURTLE_DISPLAYEDNAME_666", "Mud Turtle", "泥龟");
            // 坚定不移的泥龟。它的壳能阻挡任何攻击……仅限一次。
            AddTranslation("MUDTURTLE_DESCRIPTION_807", "The adamantine Mud Turtle. Its shell can stop any attack... once.", "刚愎之泥龟。其壳可御诸攻……一次而已。");
            // 浣熊
            AddTranslation("RACCOON_DISPLAYEDNAME_827", "Raccoon", "浣熊");
            // 小偷小摸的浣熊！它会为你收集我造物留下的兽骨。
            AddTranslation("RACCOON_DESCRIPTION_694", "The thieving Raccoon! It gathers the bones of my creatures for you.", "攘窃之浣熊！彼为尔收朕物之兽骨。");
            // 红鹿
            AddTranslation("REDHART_DISPLAYEDNAME_559", "Red Hart", "赤鹿");
            // 嗜血的红鹿。泼洒的鲜血越多，它的力量就越强。
            AddTranslation("REDHART_DESCRIPTION_219", "The bloodthirsty Red Hart. Its power grows as blood is spilled...", "嗜血之赤鹿。血洒愈多，其力愈长……");
            // 蝌蚪
            AddTranslation("TADPOLE_DISPLAYEDNAME_198", "Tadpole", "蝌蚪");
            // 啊哈！软弱的蝌蚪。即使日后长成了牛蛙，也算不上些许好转。
            AddTranslation("TADPOLE_DESCRIPTION_630", "Ha! The wimpish Tadpole. Its future as a Bullfrog is meager compensation.", "哈！孱弱之蝌蚪。其后虽为牛蛙，所偿亦薄。");
            // 狼獾
            AddTranslation("WOLVERINE_DISPLAYEDNAME_158", "Wolverine", "狼獾");
            // 百折不屈的狼獾。杀戮越多，就越饥渴。
            AddTranslation("WOLVERINE_DESCRIPTION_912", "The relentless Wolverine. Its hunger only grows greater as it kills.", "不屈之狼獾。杀愈多，则饥愈甚。");
            // 脊椎骨
            AddTranslation("SNELK_NECK_DISPLAYEDNAME_742", "Vertebrae", "脊骨");
            // 真菌机器人
            AddTranslation("!MYCOCARD_BASE_DISPLAYEDNAME_482", "Mycobot", "菇机人");
            // 破碎的蛋
            AddTranslation("BROKENEGG_DISPLAYEDNAME_936", "Broken Egg", "碎卵");
            // 握在你手里了总比……握在[c:bR]他[c:]手里强……
            AddTranslation("BLEACHPOT_DESCRIPTION_627", "Better in your hands than... [c:bR]his[c:]...", "在乃手，胜于……在[c:bR]厥[c:]手……");
            // 魔法漂白剂
            AddTranslation("BLEACHPOT_RULEBOOKNAME_378", "Magickal Bleach", "灵漂剂");
            // 我牌桌上的卡牌会失去所有印记。
            AddTranslation("BLEACHPOT_RULEBOOKDESCRIPTION_870", "My cards on the board will lose all of their sigils.", "局上诸牌将失其诸印。");
            // 就像贪婪的喜鹊一样，你也可以在牌组里找出任意卡牌加入手牌。
            AddTranslation("MAGNIFYINGGLASS_DESCRIPTION_538", "Much like the covetous Magpie, you may search your deck for any card.", "犹贪鹊然，汝可于牌列中索任一牌。");
            // 喜鹊的放大镜
            AddTranslation("MAGNIFYINGGLASS_RULEBOOKNAME_869", "Magpie's Glass", "鹊之镜");
            // 你可在牌组中搜索任意一张卡牌并加入手牌中。
            AddTranslation("MAGNIFYINGGLASS_RULEBOOKDESCRIPTION_247", "You will search your deck for any card and take it into your hand.", "汝可索牌列，取任一牌纳于手。");
            // 这创意我是从一个老对手那里学来的。
            AddTranslation("POCKETWATCH_DESCRIPTION_627", "I borrowed this idea from an old rival.", "此意余假诸一故敌。");
            // 时针顺
            AddTranslation("POCKETWATCH_RULEBOOKNAME_971", "Wiseclock", "顺时钟");
            // 牌桌上所有卡牌均会按顺时针方向移动一格。
            AddTranslation("POCKETWATCH_RULEBOOKDESCRIPTION_448", "All cards on the board will move one space clockwise.", "局上诸牌皆顺时步一格。");
            // 剥皮刀
            AddTranslation("TRAPPERKNIFE_RULEBOOKNAME_962", "Skinning Knife", "剥革刀");
            // 可用于给对手的一张卡牌剥皮。该卡牌会彻底破坏，你从而获得一张毛皮卡。
            AddTranslation("TRAPPERKNIFE_RULEBOOKDESCRIPTION_325", "You may skin one of your adversary's cards. It is destroyed and you draw a Pelt card.", "汝可剥敌一牌之革。其牌即毁，而汝得一裘革牌。");
            // [creature]的力量等于持牌人持有兽骨数量的一半。
            AddTranslation("BONESSTATICON_GBCDESCRIPTION_141", "The power of [creature] is equal to half of the Bones of the owner.", "[creature]之威，如持牌者骨数之半。");
            // 献祭之血
            AddTranslation("SACRIFICESSTATICON_RULEBOOKNAME_381", "Spilled Blood", "衅血");
            // 该印记代表的数值等于持牌人回合内做出的牺牲次数。
            AddTranslation("SACRIFICESSTATICON_RULEBOOKDESCRIPTION_259", "The value represented with this sigil will be equal to the number of sacrifices made during your turn.", "此印所指之值，如乃此合中所作牲祀之数。");
            // 真是个可疑的六角形……
            AddTranslation("DISCOVERABLEVINYL_ONDISCOVERTEXT_337", "A peculiar hexagon...", "怪哉，此六角也……");
            // 接受投降
            AddTranslation("MISC_629", "ACCEPT SURRENDER", "受降");
            // 凯茜模组
            AddTranslation("MISC_937", "Kaycee's Mod", "凯茜之补缀");
            // 新的冒险
            AddTranslation("MISC_584", "NEW RUN", "新局");
            // 继续上回
            AddTranslation("MISC_869", "CONTINUE RUN", "续局");
            // 状态
            AddTranslation("MISC_077", "STATS", "数值");
            // 已解锁内容
            AddTranslation("MISC_402", "UNLOCKS", "启封之物");
            // 退出模组
            AddTranslation("MISC_475", "EXIT MOD", "离此补缀");
            // 退出游戏
            AddTranslation("MISC_341", "EXIT GAME", "离退此戏");
            // <COLOR=#EEF4C6>未满足</COLOR>本挑战关卡所需要的挑战点数！如跳过此次冒险，你将无法进入更高级挑战关卡或解锁好东西。<COLOR=#EEF4C6>确定要继续吗？</COLOR>
            AddTranslation("MISC_198", "CHALLENGE POINTS REQUIREMENT FOR CHALLENGE LEVEL IS <COLOR=#EEF4C6>NOT MET</COLOR>! YOU WILL NOT ADVANCE TO A HIGHER CHALLENGE LEVEL OR UNLOCK STUFF IF YOU PASS THIS RUN. <COLOR=#EEF4C6>ARE YOU SURE YOU WISH TO PROCEED?</COLOR>", "角竞之阶所需角竞点数<COLOR=#EEF4C6>未足</COLOR>！汝若竟此局，不能进于更高之阶，亦不能启封诸物。<COLOR=#EEF4C6>汝审欲前乎？</COLOR>");
            // 展开<COLOR=#EEF4C6>新的冒险</COLOR>会<COLOR=#EEF4C6>终止</COLOR>当前冒险！<COLOR=#EEF4C6>确定要继续吗？</COLOR>
            AddTranslation("MISC_259", "STARTING A <COLOR=#EEF4C6>NEW RUN</COLOR> WILL <COLOR=#EEF4C6>END</COLOR> YOUR CURRENT RUN! <COLOR=#EEF4C6>ARE YOU SURE YOU WISH TO PROCEED?</COLOR>", "启<COLOR=#EEF4C6>新局</COLOR>，则乃今局必<COLOR=#EEF4C6>终</COLOR>！<COLOR=#EEF4C6>汝审欲前乎？</COLOR>");
            // 选择初始牌组
            AddTranslation("MISC_307", "SELECT STARTER DECK", "择初牌列");
            // 终止冒险
            AddTranslation("MISC_687", "END RUN", "止局");
            // 卡牌
            AddTranslation("MISC_551", "CARDS", "诸牌");
            // 初始牌组
            AddTranslation("MISC_410", "STARTER DECKS", "初牌之列");
            // 挑战
            AddTranslation("MISC_332", "CHALLENGES", "角竞");
            // 开发日志
            AddTranslation("MISC_276", "DEVLOG", "研作之札");
            // 已解锁卡牌
            AddTranslation("MISC_946", "CARDS UNLOCKED", "启封之牌");
            // 已解锁初始牌组
            AddTranslation("MISC_284", "STARTER DECKS UNLOCKED", "启封之初牌列");
            // 已解锁挑战
            AddTranslation("MISC_174", "UNLOCKED CHALLENGES", "启封之角竞");
            // 卡牌已解锁！
            AddTranslation("MISC_389", "CARDS UNLOCKED!", "牌之封既启！");
            // 初始牌组已解锁！
            AddTranslation("MISC_679", "STARTER DECK UNLOCKED!", "初牌列之封既启！");
            // 挑战已解锁！
            AddTranslation("MISC_426", "CHALLENGE UNLOCKED!", "角竞之封既启！");
            // 存疑挑战
            AddTranslation("MISC_502", "Dubious Challenge", "疑之角竞");
            // 在凯茜模组中通关挑战关卡1。
            AddTranslation("MISC_966", "Clear Challenge Level 1 in Kaycee's Mod.", "于凯茜之补缀通角竞之阶1。");
            // 嘲讽挑战
            AddTranslation("MISC_086", "Taunting Challenge", "讽之角竞");
            // 在凯茜模组中通关挑战关卡4。
            AddTranslation("MISC_981", "Clear Challenge Level 4 in Kaycee's Mod.", "于凯茜之补缀通角竞之阶4。");
            // 挑战之吼
            AddTranslation("MISC_342", "Roar of Challenge", "角竞之吼");
            // 在凯茜模组中通关挑战关卡8。
            AddTranslation("MISC_599", "Clear Challenge Level 8 in Kaycee's Mod.", "于凯茜之补缀通角竞之阶8。");
            // 勇赢挑战
            AddTranslation("MISC_367", "Rise to the Challenge", "应竞而起");
            // 在凯茜模组中通关挑战关卡12。
            AddTranslation("MISC_245", "Clear Challenge Level 12 in Kaycee's Mod.", "于凯茜之补缀通角竞之阶12。");
            // 头骨风暴
            AddTranslation("MISC_702", "Skull Storm", "头骨风暴");
            // 在凯茜模组中，在激活所有挑战状态下通关一次冒险。
            AddTranslation("MISC_252", "Complete a run with every Challenge active in Kaycee's Mod.", "于凯茜之补缀，诸角竞尽启而竟一局。");
            // 琐物大师
            AddTranslation("MISC_809", "Master Trinketeer", "什物大师");
            // 在凯茜模组中从油画里解锁全部3个道具。
            AddTranslation("MISC_075", "Unlock all 3 items from the oil painting in Kaycee's Mod.", "于凯茜之补缀，尽启油画所藏三物。");
            // 开始//结束
            AddTranslation("MISC_727", "Start // Finish", "新局 // 既终");
            // 在凯茜模组中，用每种初始牌组通关一次冒险。
            AddTranslation("MISC_527", "Complete a run with every Starter Deck in Kaycee's Mod.", "于凯茜之补缀，以诸初牌列各竟一局。");
            // 新手失误
            AddTranslation("MISC_171", "Rookie Mistake", "生手之失");
            // 在凯茜模组的一次冒险中打出10次昏招。
            AddTranslation("MISC_158", "Make 10 misplays in a single Kaycee's Mod run.", "于凯茜之补缀之一局，作十昏著。");
            // 拔牙
            AddTranslation("MISC_676", "Pulling Teeth", "拧齿拔牙");
            // 在凯茜模组中拔掉32颗牙。
            AddTranslation("MISC_643", "Pull out 32 teeth in Kaycee's Mod.", "于凯茜之补缀，拔牙三十二。");
            // 邪恶之月
            AddTranslation("MISC_619", "Bad Moon", "万恶之月");
            // 在凯茜模组中，不摧毁月亮便打败莱西。
            AddTranslation("MISC_245", "Defeat Leshy in Kaycee's Mod without destroying The Moon.", "于凯茜之补缀，不毁月而败莱西。");
            // 使用带有该印记的卡牌时，对面位置会出现一颗蛋。
            AddTranslation("CREATEEGG_RULEBOOKDESCRIPTION_C_602", "When a card bearing this sigil is played, an Egg is created on the opposing space.", "负此印契之牌既陈，则对位生一卵。");
            // 带有该印记的卡牌会在攻击时额外攻击对面位置一次。
            AddTranslation("DOUBLESTRIKE_RULEBOOKDESCRIPTION_C_275", "A card bearing this sigil will strike the opposing space an extra time when attacking.", "负此印契之牌攻敌之时，复击其对位者一。");
            // 带有该印记的卡牌击杀对面的造物后，会获得1点力量。
            AddTranslation("GAINATTACKONKILL_RULEBOOKDESCRIPTION_C_163", "When a card bearing this sigil attacks an opposing creature and it perishes, this card gains 1 power.", "若负此印契之牌击对位之物而杀之，增其一威。");
            // 带有该印记的卡牌在抽取时的孵化条件如下：你的牌组中的造物的生命和力量包含1至5五个数字，且每个族群的造物都有一张。
            AddTranslation("HYDRAEGG_RULEBOOKDESCRIPTION_C_095", "A card bearing this sigil hatches when drawn if the numbers 1 to 5 are represented in the health of creatures in your deck, and in their power, and if there is a creature of each tribe in your deck.", "乃牌列中，若诸物之命与威各具一至五之数，且诸属各备，负此印契之牌当引则能得孵。");
            // 带有该印记的卡牌可免疫死神之触和臭臭的印记效果。
            AddTranslation("MADEOFSTONE_RULEBOOKDESCRIPTION_C_046", "A card bearing this sigil is immune to the effects of Touch of Death and Stinky.", "负此印契之牌不受死触及恶臭之效。");
            // 当带有该印记的卡牌被献祭时，它的状态值会被添加在献祭来的新卡上。
            AddTranslation("MORSEL_RULEBOOKDESCRIPTION_C_754", "When a card bearing this sigil is sacrificed, it adds its stat values to the card it was sacrificed for.", "惟负此印契之牌既祀，其数悉加诸受祀之牌。");
            // 带有该印记的卡牌在牌桌上出现时，它对面的造物死亡时也会产生兽骨。
            AddTranslation("OPPONENTBONES_RULEBOOKDESCRIPTION_C_456", "While a card bearing this sigil is on the board, opposing creatures also provide bones when perishing.", "负此印契之牌在局，对位物死，亦供兽骨。");
            // 持牌人回合结束时，带有该印记的卡牌会按照印记标记的方向突进。沿途的造物会被丢到它身后。
            AddTranslation("STRAFESWAP_RULEBOOKDESCRIPTION_C_364", "At the end of the owner's turn, a card bearing this sigil will move in the direction inscribed in the sigil. Creatures in the way will be thrown back behind it.", "持牌者合终，负此印契之牌循印所志之向而移。当道之物，皆掷诸其后。");
            // 带有该印记的卡牌的力量等于持牌人持有兽骨数量的一半。
            AddTranslation("BONESSTATICON_GBCDESCRIPTION_C_426", "The power of a card bearing this sigil is equal to half of the Bones of the owner.", "负此印契之牌之威，如持牌者骨数之半。");
        }

    }
}
