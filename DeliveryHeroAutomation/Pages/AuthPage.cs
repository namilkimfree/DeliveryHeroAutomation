using System;
using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class AuthPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='com.fineapp.yogiyo:id/btn_ok']")]
        public IWebElement AuthConfirmButton { get; set; }
        
        public AcceptTermsAndConditionsPage ClickAuthConfirm()
        {
            AuthConfirmButton.FluentClick();

            var nextPage = GetInstance<AcceptTermsAndConditionsPage>();

            return nextPage;
        }

     
    }
}