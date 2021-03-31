using DeliveryHeroAutomation.Framework.Model.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Service;
using SeleniumExtras.PageObjects;
using TechTalk.SpecFlow.Tracing;

namespace DeliveryHeroAutomation.Pages
{
    public class AuthPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/btn_ok")]
        public IWebElement AuthConfirmButton { get; set; }


        public AcceptTermsAndConditionsPage ClickAuthConfirm()
        {
            AuthConfirmButton.Click();

            var nextPage = GetInstance<AcceptTermsAndConditionsPage>();

            return nextPage;
        }

        public void GetActivity()
        {
            var andDriver = AppiumDrvier as AndroidDriver<AppiumWebElement>;

        }
    }
}