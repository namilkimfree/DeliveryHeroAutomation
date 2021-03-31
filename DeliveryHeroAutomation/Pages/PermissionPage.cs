using DeliveryHeroAutomation.Framework.Model.Base;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class PermissionPage : BasePage
    {

        [FindsBy(How = How.Id, Using = "com.android.packageinstaller:id/permission_allow_button")]
        public IWebElement PermissionAllowButton { get; set; }

        [FindsBy(How = How.Id, Using = "com.android.packageinstaller:id/permission_deny_button")]
        public IWebElement PermissionDenyButton { get; set; }

        public DeliveryAddressPage ClickPermissionAllowButton()
        {
            PermissionAllowButton.Click();

            var nextPage = GetInstance<DeliveryAddressPage>();

            return nextPage;
        }

        public DeliveryAddressPage ClickPermissionDenyButton()
        {
            PermissionDenyButton.Click();

            var nextPage = GetInstance<DeliveryAddressPage>();

            return nextPage;
        }
    }
}