using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class AcceptTermsAndConditionsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/chk_agreement_all']")]
        public IWebElement AgreementAllCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/btn_start']")]
        public IWebElement StartButton { get; set; }

        public void CheckTheAll()
        {
            AgreementAllCheckBox.FluentClick();
        }

        public PermissionPage ClickStartButton()
        {
            StartButton.FluentClick();

            var nextPage = GetInstance<PermissionPage>();
            return nextPage;
        }
        
    }
}