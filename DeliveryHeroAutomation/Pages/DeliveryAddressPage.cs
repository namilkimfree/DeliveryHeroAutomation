using System;
using DeliveryHeroAutomation.Framework.Model.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class DeliveryAddressPage : BasePage
    {
        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/et_keyword")]
        public IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/ll_content_address_layout")]
        public IWebElement FirstAddress{ get; set; }

        [FindsBy(How = How.Id, Using = "com.fineapp.yogiyo:id/btn_location_go_delivery")]
        public IWebElement HereDeliveryButton { get; set; }


        public DeliveryAddressPage() :base()
        {
        }



        public void IsLoading()
        {

        }

        public void SetDeliveryAddress(string targetAddress)
        {
            Address.Click();

            Address.SendKeys(targetAddress);
        }

        public void SelectMyAddress()
        {
            FirstAddress.Click();
        }

        public void ClickHereDeliveryButton() => HereDeliveryButton.Click();

    }
}