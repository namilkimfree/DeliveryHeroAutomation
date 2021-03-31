using OpenQA.Selenium.Appium.Service;

namespace DeliveryHeroAutomation.Framework.Services
{
    public class AppiumService
    {
        
        private static AppiumLocalService _appiumLocalService;

        public static AppiumLocalService LocalServiceBuild()
        {
            _appiumLocalService = new AppiumServiceBuilder().UsingAnyFreePort().Build();
            return _appiumLocalService;
        }

        public static void LocalServiceStart()
        {
            if (_appiumLocalService == null)
                LocalServiceBuild();

            if (!_appiumLocalService.IsRunning)
            {
                _appiumLocalService.Start();
            }
        }

        public static void LocalServiceStop()
        {
            _appiumLocalService?.Dispose();
        }

    }
}