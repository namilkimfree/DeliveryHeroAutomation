using System;
using DeliveryHeroAutomation.Framework.Config;
using DeliveryHeroAutomation.Framework.Services;
using OpenQA.Selenium.Appium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Framework.Model.Base
{
    public class BasePage
    {
        protected readonly AppiumDriver<AppiumWebElement> AppiumDrvier;


        public BasePage()
        {
            AppiumDrvier = DriverManager.Instance.AppiumDriver;
            PageFactory.InitElements(AppiumDrvier, this);
        }

        public TPage GetInstance<TPage>() where TPage : BasePage, new()
        {
            var T = Activator.CreateInstance(typeof(TPage));
            return (TPage)T;
        }

        public TPage As<TPage>() where TPage : BasePage
        {
            return (TPage)this;
        }
    }
}