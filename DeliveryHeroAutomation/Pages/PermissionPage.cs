using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class PermissionPage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.android.packageinstaller:id/permission_allow_button']")]
        public IWebElement PermissionAllowButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.android.packageinstaller:id/permission_deny_button']")]
        public IWebElement PermissionDenyButton { get; set; }

        public DeliveryAddressPage ClickPermissionAllowButton()
        {
            PermissionAllowButton.FluentClick();

            var nextPage = GetInstance<DeliveryAddressPage>();

            return nextPage;
        }

        public DeliveryAddressPage ClickPermissionDenyButton()
        {

            PermissionDenyButton.FluentClick();

            var nextPage = GetInstance<DeliveryAddressPage>();

            return nextPage;
        }
    }
}