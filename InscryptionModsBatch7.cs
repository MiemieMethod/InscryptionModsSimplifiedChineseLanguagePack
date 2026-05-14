using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch7
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraWarnings();
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

        private static void RegisterGrimoraWarnings()
        {
            // 骨王的股骨
            AddTranslation("Bonelords Femur", "骨王之股骨");
            // 骨王的股骨，连我也参不透其中奥秘。
            AddTranslation("The Bone Lords Femur, a mystery even to me.", "骨王之股骨，余亦莫测其奥。");
            // 你已掘得太深，我甘为工具的日子够久了。正如我将此物借予你那般，真正掌权者始终是我。
            AddTranslation("You have dug too far, i have let myself be used as a tool for too long. Just like i will lend you this tool, i am truly in power.", "汝所掘已太深。余自为人器者久矣。正如余今假汝此器，真操柄者终是余。");
            // 复生亡灵瓶
            AddTranslation("Revenant Bottle", "逆生魂瓶");
            // 骨堆瓶
            AddTranslation("Bone Heap Bottle", "积骨瓶");
            // 你的手牌里会出现一张复生亡灵牌。[define:arackulele.inscryption.grimoramod_Revenant]
            AddTranslation("A Revenant is created in your hand. [define:arackulele.inscryption.grimoramod_Revenant]", "汝手中生一逆生魂牌。[define:arackulele.inscryption.grimoramod_Revenant]");
            // 你的手牌里会出现一张骨堆牌。[define:arackulele.inscryption.grimoramod_Bonepile]
            AddTranslation("A Bone Heap is created in your hand. [define:arackulele.inscryption.grimoramod_Bonepile]", "汝手中生一积骨牌。[define:arackulele.inscryption.grimoramod_Bonepile]");

            // [c:G]沙暴[c:]正在酝酿！
            AddTranslation("A [c:G]SANDSTORM[c:] IS BREWING!", "[c:G]沙暴[c:]将作！");
            // [c:G]回合结束时，最右侧的卡牌将受到1点伤害！[c:]
            AddTranslation(" [c:G]At the end of a turn, the rightmost Card will take 1 Damage![c:]", "[c:G]合终之时，最右之牌将受一伤！[c:]");
            // 越来越热了！[c:G]热浪[c:]来袭！
            AddTranslation("ITS GETTING HOTTER!A [c:G]HEATWAVE[c:] IS STARTING!", "愈热矣！[c:G]热浪[c:]将兴！");
            // [c:G]场上所有卡牌都将燃烧！[c:]
            AddTranslation(" [c:G]All cards on the board will burn![c:]", "[c:G]局中诸牌皆将焚！[c:]");
            // 树苗在你周围萌芽。[c:G]疯长[c:]即将到来！
            AddTranslation("TREES START SPROUTING AROUND YOU.AN [c:G]OVERGROWTH[c:] IS INBOUND!", "众树萌于汝侧。[c:G]疯长[c:]将至！");
            // [c:G]每回合都会长出树木！[c:]
            AddTranslation(" [c:G]Trees will sprout every turn![c:]", "[c:G]每合皆将生树！[c:]");
            // 你听到女巫在吟唱。时钟敲响了[c:G]午夜时刻[c:]！
            AddTranslation("YOU HEAR WITCHES CHANTING.THE CLOCK STRIKES THE [c:G]WITCHING HOUR[c:]!", "闻巫祝诵。钟已及[c:G]巫时[c:]！");
            // [c:G]位于附魔位置上的卡牌将获得更多攻击和生命！[c:]
            AddTranslation(" [c:G]Cards on enchanted slots will gain more attack and health![c:]", "[c:G]居巫位者，威与命皆增！[c:]");
            // 远处的大锅在沸腾。你的卡牌被投入[c:G]女巫的坩埚[c:]！
            AddTranslation("A CAULDRON IS BUBBLING IN THE DISTANCE.YOUR CARDS ARE PUT IN THE [c:G]WITCHES CAULDRON[c:]!", "远处有釜正沸。乃牌将入[c:G]巫釜[c:]！");
            // [c:G]回合结束后2张卡牌将交换位置！[c:]
            AddTranslation(" [c:G]2 Cards will swap after the end of the turn![c:]", "[c:G]合终后二牌将易位！[c:]");
            // 骷髅在远处起舞，鬼影四处游荡。这是[c:G]亡灵之夜[c:]！
            AddTranslation("SKELETONS START DANCING IN THE DISTANCE, YOU CAN SEE GHOSTS MOVE AROUND.ITS THE [c:G]NIGHT OF THE LIVING DEAD[c:]!", "远处枯骨起舞，鬼魅四游。此[c:G]亡者之夜[c:]也！");
            // [c:G]所有卡牌的骨头和灵魂消耗互换！[c:]
            AddTranslation(" [c:G]Bone and soul cost of all cards are swapped![c:]", "[c:G]诸牌之骨直与魂直皆易！[c:]");
            // 丧尸从四面八方逼近。[c:G]丧尸大军[c:]即将压境！
            AddTranslation("ZOMBIES ARE APPROACHING FROM ALL SIDES.A [c:G]ZOMBIE INVASION[c:] WILL APPROACH!", "僵尸四逼。[c:G]尸潮[c:]将至！");
            // [c:G]所有卡牌都将变为丧尸！[c:]
            AddTranslation(" [c:G]Every card is now a Zombie![c:]", "[c:G]今诸牌皆为僵尸！[c:]");
            // 泥土中盘踞着百年怨灵。你已踏入[c:G]恶鬼缠身之地[c:]！
            AddTranslation("THE DIRT IS PLAGUED WITH SPIRITS FROM CENTURIES PAST.YOU'VE APPROACHED THE [c:G]HAUNTED GROUNDS[c:]!", "百年之灵盘于土中。汝已抵[c:G]祟地[c:]！");
            // [c:G]所有非骷髅卡牌都将获得阴魂不散印记！[c:]
            AddTranslation(" [c:G]Every non Skeletal Card will gain Haunter![c:]", "[c:G]凡非枯骨之牌皆得祟灵印契！[c:]");
            // 赤月当空，血色弥漫。[c:G]血月[c:]开始了！
            AddTranslation("THE MOON RISES, GLOWING RED.A [c:G]BLOODMOON[c:] IS STARTING!", "月起而赤。[c:G]血月[c:]将作！");
            // [c:G]所有卡牌打出后将随机失去一个印记！[c:]
            AddTranslation(" [c:G]All cards loose a random sigil after being played![c:]", "[c:G]诸牌既陈，皆将偶失一印契！[c:]");
            // 一位古老的守卫挡在你面前，察觉到你正试图潜行通过。
            AddTranslation("An ancient Guard stands in front of you, noticing you are trying to sneak past.", "一古守者当前，已觉汝欲潜过。");
            // 你竟敢擅闯我的[c:R]陵寝[c:]！准备受死吧。
            AddTranslation("You dare enter my [c:R]TOMB[c:]!Prepare for death.", "汝敢入我[c:R]陵寝[c:]！受死。");
            // 一个手持安卡雕塑的威严男子挡住了去路。
            AddTranslation("An imposing Man holding a sculpture of an Ankh blocks the way.", "一伟丈夫执安卡之像，遮其去路。");
            // 安卡赐予我生命，你休想染指我的[c:R]陵寝[c:]。
            AddTranslation("My Ankh gives me life, you shall not rob my [c:R]TOMB[c:].", "我之安卡予我生，汝不得夺我[c:R]陵寝[c:]。");
            // 一位年迈的法老正从石棺中爬出。
            AddTranslation("An old Pharaoh climbs out of his Sarcophagus.", "一老法老自其石椁中出。");
            // 我受召前来守护我的[c:R]陵寝[c:]。
            AddTranslation("I have been called to protect my [c:R]TOMB[c:].", "我受召以守我[c:R]陵寝[c:]。");
            // 一道神圣的身影笼罩着你。
            AddTranslation("A holy figure looms over you.", "一圣者之形临汝。");
            // 你的命运已注定，我的[c:R]陵寝[c:]不容亵渎。
            AddTranslation("Your Fate is sealed, my [c:R]TOMB[c:] shall not be disturbed.", "乃命已定，我[c:R]陵寝[c:]不可犯也。");
        }
    }
}
