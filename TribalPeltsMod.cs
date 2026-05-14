using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    public class TribalPeltsMod
    {
        public static void RegisterTranslations()
        {
            // 渡鸦羽毛皮
            AddTranslation("Raven Epidermis", "渡鸦革");
            // 郊狼皮
            AddTranslation("Coyote Pelt", "郊狼革");
            // 鹿皮
            AddTranslation("Deer Pelt", "鹿革");
            // 飞蛾蜕皮
            AddTranslation("Moth Molt", "蛾蜕");
            // 鳄鱼皮
            AddTranslation("Crocodile Hide", "鳄革");
            // 死人遗骸
            AddTranslation("Human Remains", "人骸");
            // 鲨鱼皮
            AddTranslation("Shark Leather", "鲨革");
            // 虎皮
            AddTranslation("Tiger Pelt", "虎革");
            // 爆破者皮
            AddTranslation("Blaster Pelt", "爆者革");
            // 块状皮
            AddTranslation("Block Pelt", "块革");
            // 墨鱼怪皮
            AddTranslation("Blooper Pelt", "墨鱼怪革");
            // 炸弹兵壳
            AddTranslation("Bob-Omb Pelt", "炸弹兵革");
            // 幽灵皮
            AddTranslation("Boo Pelt", "幽灵革");
            // 链球怪皮
            AddTranslation("Chain Chomp Pelt", "链颌怪革");
            // 啾啾鱼皮
            AddTranslation("Cheep-Cheep Pelt", "啾啾鱼革");
            // 撞头秃鹫皮
            AddTranslation("Conkdor Pelt", "撞鹫革");
            // 龙皮
            AddTranslation("Dragon Pelt", "龙革");
            // 枯骨皮
            AddTranslation("Dry Bones Pelt", "枯骨革");
            // 板栗仔壳
            AddTranslation("Goomba Pelt", "栗仔革");
            // 库巴皮
            AddTranslation("Koopa Pelt", "库巴革");
            // 食人花皮
            AddTranslation("Piranha Plant Pelt", "食人花革");
            // 仙人掌怪皮
            AddTranslation("Pokey Pelt", "棘怪革");
            // 增益皮
            AddTranslation("Power-Up Pelt", "益力革");
            // 公羊皮
            AddTranslation("Ram Pelt", "羊公革");
            // 许鲁布皮
            AddTranslation("Shroob Pelt", "许鲁布革");
            // 害羞小子皮
            AddTranslation("Shy Guy Pelt", "羞仔革");
            // 尖刺怪皮
            AddTranslation("Spike Pelt", "棘怪革");
            // 星皮
            AddTranslation("Star Pelt", "星革");
            // 狸猫皮
            AddTranslation("Tanuki Pelt", "狸猫革");
            // 石锤怪皮
            AddTranslation("Thwomp Pelt", "石锤怪革");
            // 摇摆翼怪皮
            AddTranslation("Waddlewing Pelt", "摇翼怪革");
            // 摇摆虫皮
            AddTranslation("Wiggler Pelt", "摇虫革");
            // 龙虾壳
            AddTranslation("Lobster Shell", "虾甲");
            // 蜘蛛壳
            AddTranslation("Spider Skin", "蛛皮");
            // 河狸皮
            AddTranslation("Beaver Pelt", "河狸革");
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
    }
}
