using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class AdvertisingPopup : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/tv_close']")]
        public IWebElement AdvertisingPopupCloseButton { get; set; }


        public HomePage CloseClick()
        {
            AdvertisingPopupCloseButton.FluentClick();

            var nextPage = GetInstance<HomePage>();

            return nextPage;
        }
    }
}