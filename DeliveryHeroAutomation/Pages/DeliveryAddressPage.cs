using System;
using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class DeliveryAddressPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/et_keyword']")]
        public IWebElement Address { get; set; }



        public void IsLoaded()
        {
            Address.IsCompleted();
        }

        public void SetDeliveryAddress(string targetAddress)
        {
            Address.FluentClick();

            Address.SendKeys(targetAddress);

            ((AndroidDriver<IWebElement>)(AppiumDrvier)).PressKeyCode(AndroidKeyCode.Enter);
            
        }

        public AddressDetailPage SelectMyAddress()
        {
            var myAddress = AppiumDrvier.FindElementByXPath(
                "//*[@resource-id='com.fineapp.yogiyo:id/rv_location_address']/android.view.ViewGroup[@clickable='true']");

            myAddress.FluentClick();

            var nextPage = GetInstance<AddressDetailPage>();

            return nextPage;
        }

        public void IsSearched()
        {
            var myAddress =
            By.XPath("//*[@resource-id='com.fineapp.yogiyo:id/rv_location_address']/android.view.ViewGroup[@clickable='true']").FluentFindElement();

            Assert.NotNull(myAddress);

        }


       
    }

    public class AddressDetailPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/btn_location_go_delivery']")]
        public IWebElement HereDeliveryButton { get; set; }

        public AdvertisingPopup ClickHereDeliveryButton()
        {
            HereDeliveryButton.FluentClick();

            var nextPage = GetInstance<AdvertisingPopup>();

            return nextPage;
        }
    }
}