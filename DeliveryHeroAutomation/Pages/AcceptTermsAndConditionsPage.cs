using DeliveryHeroAutomation.Framework.Model.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class AcceptTermsAndConditionsPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/chk_agreement_all")]
        public IWebElement AgreementAllCheckBox { get; set; }

        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/btn_start")]
        public IWebElement StartButton { get; set; }

        public void CheckTheAll()
        {
            AgreementAllCheckBox.Click();
        }

        public void ClickStartButton()
        {
            StartButton.Click();
        }
        
    }
}