using System;
using System.Dynamic;
using DeliveryHeroAutomation.Framework.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.iOS;
using OpenQA.Selenium.Appium.Service;
using Platform = DeliveryHeroAutomation.Framework.Model.Base.Platform;

namespace DeliveryHeroAutomation.Framework.Services
{
    public class DriverManager
    {
        public AppiumDriver<AppiumWebElement> AppiumDriver;

        private static Lazy<DriverManager> _instance = new Lazy<DriverManager>( () => new DriverManager());

        public static DriverManager Instance => _instance.Value;

        private DriverManager()
        {
        }


        public void DriverInitialize(Platform targetPlatform)
        {
            AppiumDriver = targetPlatform switch
            {
                Platform.Android =>
                    new AndroidDriver<AppiumWebElement>(AppiumService.LocalServiceBuild(), GetDriverOptions(), TimeSpan.FromSeconds(30)),
                Platform.iOS =>
                    new IOSDriver<AppiumWebElement>(AppiumLocalService.BuildDefaultService(), GetDriverOptions(), TimeSpan.FromSeconds(30)),
                _ => throw new InvalidOperationException("Invalid platform type")

            };
        }

        public AppiumOptions GetDriverOptions()
        {
            var appiumOptions = new AppiumOptions();
         
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.PlatformName, Setting.TestSettings.PlatformName);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.AutomationName, Setting.TestSettings.AutomationName);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.DeviceName, Setting.TestSettings.DeviceName);
            appiumOptions.AddAdditionalCapability(MobileCapabilityType.App, Setting.TestSettings.App);


            return appiumOptions;
        }

    }
}