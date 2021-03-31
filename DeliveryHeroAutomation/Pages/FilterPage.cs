using System;
using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using NuGet.Frameworks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DeliveryHeroAutomation.Pages
{
    public class FilterPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/img_close_btn']")]
        public IWebElement FilterCloseImageButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/tv_reset_btn']")]
        public IWebElement FilterResetButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/cb_express_restaurant']")]
        public IWebElement FilterExpressCheckBox { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']")]
        public IWebElement FilterSortRadio{ get; set; }


        #region 랭킹정렬
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='요기요 랭킹순']")]
        public IWebElement FilterSortRankingDescRadio { get; set; }
       



        #endregion


        #region 결제타입

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']")]
        public IWebElement FilterMethodPaymentRadio { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']//*[@text='결제수단 전체']")]
        public IWebElement FilterMethodPaymentAllRadio { get; set; }
      
        #endregion

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/tv_tab_name']")]
        public IWebElement ApplyButton { get; set; }



        public void IsLoaded()
        {
            FilterSortRadio.IsCompleted();
            FilterMethodPaymentRadio.IsCompleted();
        }

        public RestaurantListPage CloseFilter()
        {
            FilterCloseImageButton.FluentClick();

            var nextPage = GetInstance<RestaurantListPage>();

            return nextPage;
        }

        public RestaurantListPage ClickApplyButton()
        {
            ApplyButton.FluentClick();

            var nextPage = GetInstance<RestaurantListPage>();

            return nextPage;
        }

        public void ClickExpress()
        {
            FilterExpressCheckBox.FluentClick();

            IsChecked(FilterExpressCheckBox);
        }

        public void ClickRankingSortType(string rankingSortType)
        {
            var sortType =
            By.XPath($"//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='{rankingSortType}']")
                .FluentFindElement();
            sortType.FluentClick();

           IsChecked(sortType);
        }

        public void ClickPaymentSortType(string paymentSortType)
        {
            var sortType =
                By.XPath($"//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']//*[@text='{paymentSortType}']]")
                    .FluentFindElement();
            sortType.FluentClick();

            IsChecked(sortType);
        }

        public void IsChecked(IWebElement element)
        {
            var value = element.GetAttribute("checked");

            var check = Convert.ToBoolean(value);
            Assert.True(check);
        }

        public void FilterResetClick()
        {
            FilterResetButton.FluentClick();
        }

        public void FilterIsReset()
        {
            IsChecked(FilterMethodPaymentAllRadio);
            IsChecked(FilterSortRankingDescRadio);

        }
    }
}