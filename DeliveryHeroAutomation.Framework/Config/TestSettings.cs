using System.Reflection.Metadata.Ecma335;
using DeliveryHeroAutomation.Framework.Model.Base;

namespace DeliveryHeroAutomation.Framework.Config
{
    public class TestSettings
    {
        public Platform PlatformName { get; set; }
        public string App { get; set; }
        public string DeviceName { get; set; }
        public string AutomationName { get; set; }
    }
}