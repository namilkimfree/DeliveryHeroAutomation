using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class HomePage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@resource-id = 'com.fineapp.yogiyo:id/category_item'  and ./android.widget.TextView[@text='전체']]")]
        public IWebElement AllRestaurantButton { get; set; }


        public HomePage() : base()
        {
            
        }

        public void IsLoaded()
        {
            AllRestaurantButton.IsCompleted();
        }

        public RestaurantListPage ClickAllRestaurantButton()
        {
            AllRestaurantButton.FluentClick();

            var nextPage = GetInstance<RestaurantListPage>();

            return nextPage;
        }
        
    }
}