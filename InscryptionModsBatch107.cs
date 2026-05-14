using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch107
    {
        public static void RegisterTranslations()
        {
            RegisterAgasMagnificusFour();
            RegisterMagModExpansionOne();
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

        private static void RegisterAgasMagnificusFour()
        {
            // 魔法爆发
            AddTranslation("Magic Burst", "术爆");
            // 死亡后，与其相邻的造物的力量加1。
            AddTranslation("After perishing, creatures adjascent to [creature] have their powers increased by 1.", "[creature]既死，其相邻诸物威皆益一。");
            // 精神破坏
            AddTranslation("Psystrike", "神击");
            // 在死亡后，它操纵与之相对的造物攻击其相邻的盟友。
            AddTranslation("After [creature] perishes, it manipulates the creature opposing it to strike both of it's adjascent allies.", "[creature]既死，则役其对位之物，使击其两旁之侣。");
            // 训蛇大师
            AddTranslation("Serpent Master", "御蛇");
            // 在每个回合开始时，都会在持牌人选择的一个空间产生蛇之召。蛇之召被定义为：1点力量，1点生命。
            AddTranslation("At the start of every turn, [creature] spawns a Summon Serpent on a space of it's owner's choosing. A Summon Serpent is defined as: 1 power, 1 health.", "每合始，[creature]于其主持所择之一位生一召蛇。召蛇者：一威，一命。");
            // 幻影冲击
            AddTranslation("Shadow Strike", "影击");
            // 也会召唤其目标附近造物的幻影来攻击它。
            AddTranslation("[creature] calls upon the shadows of creatures adjascent to it's target to strike it as well.", "[creature]亦呼其所攻近旁诸物之影，共击之。");
            // 潮汐锁定
            AddTranslation("Tidal Lock", "潮缚");
            // 在持牌人回合之初，会将松鼠之类的小造物拉入自身卫星轨道。
            AddTranslation("At the beginning of it's owner's turn, [creature] will pull small creatures, like squirrels, into it's orbit.", "其主持合始，[creature]引松鼠之类小物入其回环。");
            // 巫师之心
            AddTranslation("Wizard's Heart", "巫心");
            // 当死亡时，与您控制的当前宝石相对应的玛珂牌将取代其的位置。
            AddTranslation("When [creature] perishes, a Mox card corresponding to the current gems you control takes it's place.", "[creature]死，则与汝今所御诸玉相应之玛珂牌踵居其处。");
        }

        private static void RegisterMagModExpansionOne()
        {
            // 河狸防御
            AddTranslation("Beaver's Defense", "狸防");
            // 在使用时精心设计防御性水坝，这对可怕的情况来说并不坏。
            AddTranslation("Curating defensive dams upon use, not bad for a dire situation.", "用之则营防坝，于危局亦不恶。");
            // 炸弹贤者
            AddTranslation("Bomb Sage", "爆贤");
            // 当受到攻击时，这位贤者以爆炸而闻名。从字面上和隐喻上。
            AddTranslation("When attacked, this sage is known for blowing up.. Literally and metaphorically.", "见攻，则此贤每以爆著名，言内言外皆然。");
            // 拳击冠军
            AddTranslation("Boxing Champ", "拳魁");
            // 这位冠军拒绝使用魔杖，更喜欢用拳头解决问题。
            AddTranslation("Rejecting the use of wands, this champion prefers to settle things with his fists.", "此魁不用杖，而乐以拳决事。");
            // 雷龙
            AddTranslation("Brontosaurus", "雷龙");
            // 我爱恐龙模组！！！
            AddTranslation("I LOVE DINO MOD!!!!!", "我爱恐龙补缀！！！");
            // 奶酪巫师
            AddTranslation("Cheese Wizard", "酪巫");
            // 作为训练有素的大厨魔术师，奶酪奇才利用他们的智慧和神秘来实现他们的目标。
            AddTranslation("As trained Chef-Magi, Cheese Wizards use their intellect and Mysticality to accomplish their goals.", "酪巫既习厨术，以其智与玄，遂其所欲。");
            // 奶酪
            AddTranslation("Cheezling", "酪灵");
            // 有了这样的奶酪，谁还需要朋友？
            AddTranslation("With cheese like this, who needs friends?", "有此酪矣，谁复需友？");
            // 心灵感应
            AddTranslation("Telepathy", "心应");
            // 一个学生可以通过纯粹的意志来收集他们需要的所有资源。
            AddTranslation("A pupil can gather all the resources they need through sheer will alone.", "一弟子惟以意志，足聚其所需诸资。");
            // 直接伤害
            AddTranslation("Direct Hit", "直伤");
            // 一旦被放置，你的对手将立即受到三点伤害。
            AddTranslation("Upon being casted, your opponent will instantly take three damage.", "既施，则敌即受三伤。");
            // 神秘的蛋
            AddTranslation("Mysterious Egg", "玄卵");
            // 谁知道这个蛋会孵化出什么...
            AddTranslation("Who knows what could hatch from this egg...", "孰知此卵将孚何物……");
            // 无面者
            AddTranslation("Faceless", "无面者");
            // 一个法师的空壳，拼命寻找属于自己的东西。
            AddTranslation("A hollow shell of a mage, desperately looking for something to call its own.", "一术士之虚壳也，切求其所可自有者。");
            // 伪造者
            AddTranslation("Faker", "伪者");
            // 撒谎，作弊，否认。为了毫发无损地逃脱，伪造者会不择手段...
            AddTranslation("Lie. Cheat. Deny. The lengths the Faker will go to in order to escape unharmed...", "诳、欺、讳。伪者欲全身而遁，其所为无所不至……");
            // 菲格拉塔
            AddTranslation("Figletar", "菲格拉塔");
            // 一个给邪恶国王带来可怕命运的奇才，这个人在拳击场上知道一两件事。
            AddTranslation("A wiz who brought an evil king to a terrible fate, this one knows a thing or two in the ring.", "一巫尝使恶王罹惨祸，此人于拳圜亦颇知之。");
            // 星火燎原
            AddTranslation("Firestarter", "发火者");
            // 学生们报告说，在选角时要小心，决斗场地可能会有点烤。
            AddTranslation("Careful when casting this one, pupils have reported that the dueling grounds can get a little toasty.", "施此宜慎，诸徒云斗地或颇焦热。");
            // 冰箱法师
            AddTranslation("Fridge Mage", "寒柜术士");
            // 它的冰霜气氛会让敌人感到寒冷，削弱他们的进攻力量。
            AddTranslation("Its cold atmosphere will chill foes, weakening their offensive power.", "其寒气凛敌，而损其攻势。");
            // 宝石兄弟
            AddTranslation("Gembro", "玉兄");
            // 这名学生能够一次击中任何目标，他有很高的兴趣。
            AddTranslation("The ability to tank any hit once, this pupil has high gusto.", "此徒能当一击而不挠，气甚豪。");
            // 宝石蜱虫
            AddTranslation("Gem Tick", "玉蜱");
            // 一种难以捉摸的蜱虫，通过其魔力体赋予他人力量。
            AddTranslation("An elusive tick, which grants power to others via its mox body.", "一难捕之蜱也，假其玛珂之体以授他物之力。");
            // 鬼灵恐龙
            AddTranslation("Ghost Dinosaur", "鬼龙");
            // 第三只眼
            AddTranslation("Third Eye", "三目");
            // 利用第三只眼睛的力量，该法术允许施法者获得任何一张牌。
            AddTranslation("Harnessing the power of a third eye, the spell allows its caster to gain any card that it has.", "假三目之力，此术使施者得其所有之任一牌。");
        }
    }
}
