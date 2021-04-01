using System;
using System.Runtime.InteropServices.ComTypes;
using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using Gherkin.Ast;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Interfaces;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class RestaurantListPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='tv_address_info Id']")] 
        public IWebElement Address { get; set; }

        #region Tab

        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='com.fineapp.yogiyo:id/pager_tab_layout']")]
        public IWebElement TabLayout { get; set; }

        

        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='com.fineapp.yogiyo:id/cb_express_restaurant']")]
        public IWebElement ExpressCheckBox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='com.fineapp.yogiyo:id/iv_restaurant_filter']")]
        public IWebElement FilterImageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='com.fineapp.yogiyo:id/img_ads_info']")]
        public IWebElement ShopInfoButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id ='com.fineapp.yogiyo:id/recycler_view']")]
        public IWebElement RecyclerScroll { get; set; }


        #endregion


        #region Navigation Bottom

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@text='홈']]")]
        public IWebElement BottomNavigationHome { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@text='찜']]")]
        public IWebElement BottomNavigationLove { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@text='검색']]")]
        public IWebElement BottomNavigationSearch { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@text='주문내역']]")]
        public IWebElement BottomNavigationOrderHistory { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@text='마이요기요']]")]
        public IWebElement BottomNavigationMyInfo { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@selected='true']]")]
        public IWebElement CurrentNavigation { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='android:id/background']//android.view.ViewGroup[ ./android.widget.TextView[@selected='true']]")]
        public IWebElement DefaultNavigation { get; set; }
        #endregion

        #region Tab

        [FindsBy(How = How.XPath, Using = "//*[@class='androidx.appcompat.app.ActionBar$Tab' and @selected='true']")]

        public IWebElement CurrentTab { get; set; }


        private By _defaultTabBy = By.XPath("//*[@content-desc='전체']");

        #endregion

        /// <summary>
        /// Page Loaded 확인용 Method
        /// 
        /// </summary>
        public void IsLoaded()
        {
            Assert.True(RecyclerScroll.Displayed);
        }

        /// <summary>
        /// I button Click
        /// Tooltip 노출되는지 확인
        /// </summary>
        public void ClickShopInfo()
        {
            ShopInfoButton.FluentClick();

            var tooltip = 
                By.XPath("//*[@resource-id='com.fineapp.yogiyo:id/tv_tooltip']").FluentFindElement();

            Assert.NotNull(tooltip);

            var filterLayout =
                By.XPath("//*[@resource-id='com.fineapp.yogiyo:id/cl_restaurant_filter']").FluentFindElement();

            filterLayout.Tap();
        }


        /// <summary>
        /// Tab 클릭은 Random하게
        /// 현재 보여지는 Tab증에
        /// Random하게 클릭한다.
        /// </summary>
        public void ClickRandomTab()
        {
            var tabs =
                AppiumDrvier.FindElements(By.XPath("//*[@class='androidx.appcompat.app.ActionBar$Tab' and @selected='false']"));

            var position = new Random().Next(1, tabs.Count - 1);

            tabs[position].FluentClick();

            CurrentTab = tabs[position];

            Assert.True(CurrentTab.Selected);
        }


        /// <summary>
        /// 현재 보여지는 Tab들을 가져오고
        /// 제일 끝에서 처음 있는 위치로 이동
        /// </summary>
        public void RollbackTab()
        {
            var tabs =
                AppiumDrvier.FindElements(By.XPath("//*[@class='androidx.appcompat.app.ActionBar$Tab']"));
            
            tabs[0].FluentScrollForClick(tabs[tabs.Count - 1], _defaultTabBy);

        }

        /// <summary>
        /// filter button 클릭
        /// </summary>
        /// <returns></returns>
        public FilterPage ClickFilter()
        {
            FilterImageButton.FluentClick();

            var nextPage = GetInstance<FilterPage>();

            return nextPage;
        }


        /// <summary>
        /// 요기요 익스프레스 체크박스 체크
        /// </summary>
        public void ClickExpress()
        {
            ExpressCheckBox.FluentClick();
            IsChecked(ExpressCheckBox);
            
        }

        /// <summary>
        /// 특정
        /// </summary>
        /// <param name="element"></param>
        public void IsChecked(IWebElement element = null)
        {
            element ??= ExpressCheckBox;

            var isChecked = element.IsChecked();

            Assert.True(isChecked);
        }

        public void ScrollTab()
        {
            var tab =
                AppiumDrvier.FindElement(By.XPath("//*[@class='androidx.appcompat.app.ActionBar$Tab' and @selected='false']"));
         
            _defaultTabBy.FluentFindElement().ScrollHorizontal(tab);
        }


        /// <summary>
        /// 음식점 List 스크롤
        /// </summary>
        public void ScrollRestaurantList()
        {
            var tabs =
                AppiumDrvier.FindElements(By.XPath("//*[@class='androidx.appcompat.app.ActionBar$Tab' and @selected='false']"));

            var source = tabs[tabs.Count - 1];

            var target = tabs[0];

            source.ScrollHorizontal(target);
        }


        /// <summary>
        /// 
        /// </summary>
        public void DefaultSelectedTab()
        {
            var tab =
                _defaultTabBy.FluentFindElement();

            Assert.True(tab.Selected);
        }

        /// <summary>
        /// Default Tab이 보이지 않을때
        /// 체크하는 함수
        /// </summary>
        public void DefaultTabIsNotDisplayed()
        {
            Assert.Throws<NoSuchElementException>(() =>
            {
                _defaultTabBy.FluentFindElement();
            });
        }

        public void IsEqualAddress(string address)
        {
            Assert.Equals(Address.Text, address);
        }

        public void ClickRandomBottomNavigation()
        {
            var navigation =
                AppiumDrvier.FindElements(By.XPath("//*[@resource-id='android:id/background']//android.view.ViewGroup[./android.widget.TextView[@selected='false']]"));

            var position = new Random().Next(0, navigation.Count - 1);

            navigation[position].FluentClick();

            CurrentNavigation = navigation[position];

            Assert.IsTrue(CurrentNavigation.Selected);
        }
    }
}