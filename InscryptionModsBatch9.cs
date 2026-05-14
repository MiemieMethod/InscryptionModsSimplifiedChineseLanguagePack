using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch9
    {
        public static void RegisterTranslations()
        {
            RegisterGrimoraPiratesAndRelics();
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

        private static void RegisterGrimoraPiratesAndRelics()
        {
            // 骷髅
            AddTranslation("Skeleton", "枯骨");
            // 他的船歌只能鼓舞骷髅兵的士气，毕竟其他人都欣赏不来。
            AddTranslation("His songs raise the morale of only Skeletons, as no one else seems to like it.", "其歌惟振枯骨之气，馀众皆不好之。");
            // 尖叫颅骨的远亲，如今已成为全球海盗的象征
            AddTranslation("A DISTANT RELATIVE OF THE SCREAMING SKULL, HE IS NOW THE SYMBOL OF PIRACY ALL AROUND THE WORLD", "啸颅之远裔，今为四海之盗表。");
            // 十字骨
            AddTranslation("Crossbones", "十字骨");
            // 戴维·琼斯
            AddTranslation("Davy Jones", "戴维·琼斯");
            // 这位才是船员们公认的船长，备受尊敬却行踪诡秘。黄胡子那家伙捞的油水总比他多。
            AddTranslation("The true captain of the crew, respected by all yet still elusive. YELLOWBEARD ALWAYS GETS MORE BOOTY THAN HE DOES.", "真舟长也，众所敬而迹犹诡；黄须所得，常多于彼。");
            // 抱着满满一桶火药可能不是个好主意。我不确定他是否注意到了。
            AddTranslation("MAYBE IT WASN'T THE BEST IDEA TO HOLD A BARREL FULL OF GUNPOWDER. I'M NOT SURE WETHER HE NOTICED.", "抱满桶火药，未必善谋；余不知彼觉之否。");
            // 自爆海盗
            AddTranslation("Exploding Pirate", "爆裂海盗");
            // 他为了那个大钩子背叛了船长，现在他肯定能让任何人变成叛徒！
            AddTranslation("He betrayed his captain for that large hook, now he is sure to make anyone a double-crosser!", "彼为大钩叛其舟长，今必使人尽为贰臣。");
            // 大副斯纳格
            AddTranslation("First Mate Snag", "大副斯纳格");
            // 鹦鹉通常是绝佳的海滨伙伴，但这只刚吞了块毒饼干。
            AddTranslation("Parrots usually make great sea-side companions, this one just ate a poisoned cracker.", "鹦鹉恒为海滨良伴，此一甫啖毒饼。");
            // 波利
            AddTranslation("Polly", "波利");
            // 敏锐的眼窝使他能攻击任意位置，火枪也功不可没。妙极！
            AddTranslation("A keen eye socket allows him to attack anywhere, his musket helps too. marvelous indeed!", "目窟甚利，故能击诸处；火铳亦助之，妙哉。");
            // 私掠船长
            AddTranslation("Privateer", "私掠者");
            // 豪侠
            AddTranslation("Swashbuckler", "豪侠");
            // 自古老埃及陵墓现世，专为供奉往昔之主而铸。
            AddTranslation("EMERGING FROM AN OLD EGYPTIAN TOMB, MADE TO HOUSE THE LORDS OF OLD.", "自古埃及之陵中出，昔所以藏旧主者也。");
            // 石棺
            AddTranslation("Sarcophagus", "石椁");
            // 尖叫颅骨
            AddTranslation("Screaming Skull", "啸颅");
            // 唯有痛苦与折磨，这具骸骨头颅感受不到其他任何事物。真可悲。
            AddTranslation("ONLY PAIN AND SUFFERING, NOTHING ELSE IS FELT BY THIS SKELETAL HEAD. WHAT A PITY.", "此枯颅所觉，惟痛与苦耳。可哀也。");
            // 技艺精湛的猎手。当你听到它那令人毛骨悚然的口哨声时，千万别相信自己的耳朵。
            AddTranslation("A SKILLED HUNTER. DON'T TRUST YOUR EARS WHEN YOU HEAR ITS HAUNTING WHISTLE.", "善猎者也。闻其祟哨，毋信乃耳。");
            // 希尔邦
            AddTranslation("Silbon", "希尔邦");
            // 它们习得了远古的死亡咒术。然而这股力量过于强大，难以驾驭。
            AddTranslation("THEY HAVE LEARNED THE ANCIENT SPELL OF DEATH. YET IT IS TOO MUCH POWER TO BE WIELDED.", "彼习上古死咒，然其力太甚，不可御也。");
            // 骷髅法师
            AddTranslation("Skelemagus", "枯骨巫");
            // [c:bR]苏醒吧我的军团，苏——醒——！[c:]
            AddTranslation("[c:bR]RISE MY ARMY, RIIIIIISE[c:]", "[c:bR]起，吾军，起——！[c:]");
            // 骷髅军团
            AddTranslation("Skeleton Army", "枯骨军");
            // 西部最快的出枪手之一，但还不够快。
            AddTranslation("One of the faster draws in the west, but not fast enough.", "西土捷手之一，然犹未及。");
            // 枪手之魂
            AddTranslation("Slinger's Soul", "铳手之魂");
            // 它们凭空出现，随心所欲地转移人类。
            AddTranslation("THEY SHOW UP OUT OF NOWHERE AND RELOCATE PEOPLE AS THEY PLEASE.", "忽然而至，恣徙人。");
            // 幽魂军团
            AddTranslation("Sluagh", "幽魂众");
            // 不给糖就捣蛋！
            AddTranslation("Trick or treat!", "予糖，不然见祟！");
            // 糖果桶
            AddTranslation("Candy Bucket", "糖桶");
            // 万圣节快乐！
            AddTranslation("HAPPY HALLOWEEN!", "万圣夕乐哉！");
            // 糖果怪兽
            AddTranslation("Candy Monster", "糖兽");
            // 幽灵兔
            AddTranslation("Spectrabbit", "幽兔");
            // 大幽灵发出笛声般的哀鸣，既是死亡的预兆，也是毁灭的凶兆。
            AddTranslation("THE SPECTRE EMITS A FLUTE LIKE CALL, AN OMEN OF BOTH DEATH AND DESCTRUCTION", "此魅发哨如笛，为死与毁之兆。");
            // 大幽灵
            AddTranslation("Spectre", "幽魅");
            // 死亡何其残酷。饥饿更甚。为何而战，饥饿的孩子。
            AddTranslation("DEATH IS A CRUEL FATE. STARVATION AN EVEN CRUELER ONE. WHY DO YOU FIGHT, OH HUNGRY CHILD.", "死酷矣，饥尤酷焉。饥子乎，汝何战哉？");
            // 饿殍
            AddTranslation("Starved Man", "饿殍");
            // 他在书房中耗费数年光阴，不知疲倦地试图改写命运。然而命运终究是位残酷的情人。
            AddTranslation("HE HAS SPENT YEARS IN HIS STUDY, IN A TIRELESS ATTEMPT TO CHANGE HIS FATE. YET FATE IS A CRUEL MISTRESS.", "彼居书斋积年，不倦以图易命；然命诚酷妇也。");
            // 召唤师
            AddTranslation("Summoner", "召者");
            // 捣毁之棺
            AddTranslation("Tampered Coffin", "坏棺");
            // 枯树
            AddTranslation("Dead Tree", "枯木");
            // 低廉的代价只配得上它贫弱的身板。
            AddTranslation("Its low cost is justified only by its low stats.", "其直之下，特称其数之下耳。");
            // 惊扰之墓
            AddTranslation("Disturbed Grave", "扰墓");
            // 一座简陋的坟墓。长眠于此者，吾亦不识。
            AddTranslation("A LOWLY GRAVE. WHOEVER IS LAID TO REST HERE, I DO NOT KNOW.", "鄙墓一耳。安此者谁，余不识也。");
            // 犬舍
            AddTranslation("Kennel", "犬舍");
            // 方尖碑
            AddTranslation("Obelisk", "方尖碑");
            // 沉船残骸
            AddTranslation("Shipwreck", "沉舟");
            // 浮木
            AddTranslation("Flotsam", "浮木");
            // 水瓮
            AddTranslation("Water Urn", "水瓮");
            // 巫毒人偶
            AddTranslation("Voodoo Doll", "巫蛊偶");
            // 空空如也……又是空空如也……再没有宝藏可寻了。
            AddTranslation("NOTHING... NOTHING AGAIN... NO TREASURE IS LEFT ANYMORE.", "无……无矣……复无宝可求矣。");
            // 盗墓贼
            AddTranslation("Tomb Robber", "盗冢者");
            // 厄菲阿尔忒斯
            AddTranslation("Ephialtes", "厄菲阿尔忒斯");
            // 奥提斯
            AddTranslation("Otis", "奥提斯");
            // 殡葬师
            AddTranslation("Undertaker", "殡者");
            // 这个迷失的灵魂已无人需要其服务，只能漫无目的地埋葬亡者。
            AddTranslation("His service no longer needed, this lost soul buries without purpose..", "其役既无人需，此迷魂徒葬而无所为。");
            // 行走之棺
            AddTranslation("Walking Coffin", "行棺");
            // 奔走之棺
            AddTranslation("Running Coffin", "奔棺");
            // 占位符
            AddTranslation("Placeholder", "虚位");
            // 传说中的吸血鬼。现实中，等人都死光了哪还有血可吸。
            AddTranslation("THE VAMPIRE IS A CREATURE OF LEGENDS. IN REALITY, LITTLE BLOOD TO DRINK AFTER EVERYONE HAS DIED.", "饮血鬼者，传闻之物也。今人尽死，少有血可饮矣。");
            // 吸血伯爵
            AddTranslation("Vampire", "饮血鬼");
        }
    }
}
