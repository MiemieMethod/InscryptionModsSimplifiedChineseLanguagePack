using DiskCardGame;

namespace ClassicChineseLanguagePack
{
    internal static class InscryptionModsBatch56
    {
        public static void RegisterTranslations()
        {
            RegisterP03InKayceesCardsTwo();
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

        private static void RegisterP03InKayceesCardsTwo()
        {
            // 实验体1号
            AddTranslation("Experiment #1", "验体一");
            // 骷髅大师
            AddTranslation("Skeleton Master", "枯骨主");
            // 机械燃油弹
            AddTranslation("M0l0t0v", "机燃壶");
            // 钢铁战狼
            AddTranslation("B30WULF", "钢狼");
            // 铁脊蟒
            AddTranslation("PYTH0N", "铁蟒");
            // 拟态螳螂
            AddTranslation("Asmanteus", "拟螳");
            // 种子机器人
            AddTranslation("SeedBot", "种机");
            // 传带传递者
            AddTranslation("Conveyor Latcher", "传带遗契者");
            // 天空传递者
            AddTranslation("Sky Latcher", "天遗契者");
            // 机械蠕虫
            AddTranslation("W0rm", "机蠕");
            // 鱼骨
            AddTranslation("Fishbones", "鱼骨");
            // 锦鲤
            AddTranslation("Koi", "锦鲤");
            // 鲑鱼
            AddTranslation("Salmon", "鲑");
            // 机械兽群大师
            AddTranslation("B3A5T GR4ND M4ST3R", "机兽大宗");
            // 机械野兽大师
            AddTranslation("B3A5T M4ST3R", "机兽师");
            // 机械公牛
            AddTranslation("T4URU5", "机牛");
            // 搜索机器人
            AddTranslation("SearchBot", "索机");
            // 弹药机器人
            AddTranslation("AmmoBot", "弹机");
            // 油罐杰瑞
            AddTranslation("Oil Jerry", "油杰里");
            // 死灵机甲
            AddTranslation("Necronomaton", "死灵机偶");
            // 僵尸进程
            AddTranslation("Zombie Process", "尸程");
            // 天使机器人
            AddTranslation("AngelBot", "天使机");
            // 管道守卫
            AddTranslation("Conduit Protector", "护渠者");
            // 骷髅电池
            AddTranslation("Skel-E-Cell", "骨电匣");
            // 空域管道
            AddTranslation("Airspace Conduit", "翔域渠");
            // 污秽管道
            AddTranslation("Foul Conduit", "秽渠");
            // 侦察机
            AddTranslation("Spyplane", "谍机");
            // 执行器
            AddTranslation("Executor", "执者");
            // 复制粘贴
            AddTranslation("Copypasta", "摹贴");
            // 弗兰肯电池
            AddTranslation("FrankenCell", "缝电匣");
            // 时钟:先生
            AddTranslation("Mr:Clock", "先生钟");
            // 机械小鸭
            AddTranslation("Roboducky", "机鸭");
            // 红宝石泰坦
            AddTranslation("Ruby Titan", "红玉巨神");
            // 蓝宝石泰坦
            AddTranslation("Sapphire Titan", "蓝玉巨神");
            // 绿宝石泰坦
            AddTranslation("Emerald Titan", "绿玉巨神");
            // 交换传递者
            AddTranslation("Swapper Latcher", "易数遗契者");
            // 箱型机器人
            AddTranslation("Box Bot", "箱机");
            // 废料机器人
            AddTranslation("Scrap Bot", "废机");
            // 压缩炸弹
            AddTranslation("Zip Bomb", "疾爆");
        }
    }
}
