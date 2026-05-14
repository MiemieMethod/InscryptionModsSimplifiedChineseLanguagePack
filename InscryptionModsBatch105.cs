using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch105
    {
        public static void RegisterTranslations()
        {
            RegisterAgasMagnificusThree();
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

        private static void RegisterAgasMagnificusThree()
        {
            // 玛珂戮魔
            AddTranslation("Kickmoxer", "斗玛珂者");
            // 他毕生致力于战斗艺术，并可能适应他所面对的任何人。
            AddTranslation("He dedicated his life to the art of combat, and may adapt to whomever he faces", "其终身尽于斗艺，所向之敌，皆或随而应之。");
            // 万人冢
            AddTranslation("Mass Grave", "众冢");
            // 阿盖兰大师
            AddTranslation("Master Agairan", "阿盖兰大师");
            // 深红奇美拉。炼金术老师灌输最致命的毒素。
            AddTranslation("The Crimson Chimera. The teacher of alchemy instills the deadliest of toxins", "绛奇兽也。彼炼金之师，灌以至毒。");
            // 双蓝大师
            AddTranslation("Master Bluetwo", "双蓝大师");
            // 蓝宝石的钢铁骑士。即使死后，她的精神存在也指挥着我们的敌人。
            AddTranslation("The steel knight of sapphire. Even after death her psychic presence commands our foes", "蓝玉之钢骑也。身虽死，其神犹役我敌。");
            // 道布林大师
            AddTranslation("Master Doublin", "道布林大师");
            // 骨王的救世主。祈祷的老师学会了如何窃取精华。
            AddTranslation("The Bone Lord's messiah. The teacher of prayer has learned apt essence stealing.", "骨王之救者也。彼祷师已习善窃精髓。");
            // 超级巫师
            AddTranslation("Megawizard", "巨巫");
            // 他装腔作势，意味着他昏昏沉沉。这种原始力量永远不会持久。
            AddTranslation("Hulking he is in his menace, meanacing he is in his dim. Such raw power would never last an eternity", "其势硕而骇，其神昏而悍。如此朴力，终不能久。");
            // 气象学者
            AddTranslation("Meteorologist", "象天者");
            // 他们仔细观察宇宙，向他们认为合适的人投掷流星风暴。也许他们很残忍？也许不是？只有他们自己知道。
            AddTranslation("They carefully observe the universe, casting storms of meteors upon whom they see fit. Maybe they're cruel? Maybe not? Only they know", "彼审观宇宙，而陨星如雨，投其所可投者。其残忍乎？其不然乎？惟彼自知。");
            // 迷你巫师
            AddTranslation("Miniwizard", "小巫");
            // 一个被它的微小尺寸所诅咒的法师。不过不用担心，他找到了解决办法。
            AddTranslation("A mage accursed by it's miniscule size. Worry not though, to such ends he found a solution.", "一术士为其微形所厄。然毋忧，彼已得其解。");
            // 幻灵盗贼
            AddTranslation("Phantom Thief", "幻盗");
            // 滚滚罪孽乌云，进进出出，偷窃它之宿敌。
            AddTranslation("A billowing cloud of crime, darting in and out, and stealing his foes", "罪云翻涌，出入倏忽，而窃其敌。");
            // 序言法师
            AddTranslation("Preformence Mage", "前演术士");
            // 谁知道他的神秘兔子到底经历了什么。
            AddTranslation("Who knows to what ends his mystery rabbit has been through", "孰知其玄兔所历至于何极。");
            // 皇后使魔
            AddTranslation("Queen's Familiar", "后之使魔");
            // 美丽野兽的雄伟幻影。它其中关着一支军队。
            AddTranslation("A majestic chimera of beautiful beasts. It keeps it's armies close inside", "群美兽之雄奇合体也。其腹中自藏一军。");
            // 加剧的饥饿
            AddTranslation("RisingHunger", "益饥");
            // 蟑螂仆从
            AddTranslation("Roach Familiar", "螂使魔");
            // 一只由精神制造的蟑螂。这将使它具有压迫能力！这最终失败了。
            AddTranslation("A spiritually manufacrued cockroach. It's will allows it ressurection abilities! that ultimately fail.", "一神造之螂也。其志使之得苏生之能，然终亦败。");
        }
    }
}
