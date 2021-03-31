using DeliveryHeroAutomation.Framework.Config;
using DeliveryHeroAutomation.Framework.Services;
using TechTalk.SpecFlow;

namespace DeliveryHeroAutomation.Hooks
{
    [Binding]
    public class HookInitialize
    {
        public HookInitialize()
        {
                
        }

        [BeforeTestRun]
        public static void InitializeTest()
        {
            ConfigReader.SetFrameworkSettings();
            DriverManager.Instance.DriverInitialize(Setting.TestSettings.PlatformName);
        }


        [BeforeFeature()]
        public static void InitializeFeature()
        {

        }

    }
}