using DeliveryHeroAutomation.Framework.Model.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class HomePage : BasePage
    {

        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/tv_close")]
        public IWebElement AdvertisingPopupCloseButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id = 'com.fineapp.yogiyo:id/category_item'  and ./android.widget.TextView[@text='전체']]")]
        public IWebElement AllRestaurantButton { get; set; }


        

        public HomePage() : base()
        {
            
        }


        public void Test()
        {
            AdvertisingPopupCloseButton.Click();
        }
        
    }
}