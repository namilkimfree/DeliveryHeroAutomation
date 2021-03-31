using DeliveryHeroAutomation.Framework.Model.Base;
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
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='배달요금순']")]
        public IWebElement FilterSortRankingDeliveryPayAscRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='별점순']")]
        public IWebElement FilterSortRankingStarDescRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='리뷰 많은순']")]
        public IWebElement FilterSortRankingReviewDescRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='최소 주문 금액순']")]
        public IWebElement FilterSortRankingOrderPayAscRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='거리순']")]
        public IWebElement FilterSortRankingStreetAscRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='할인율 순']")]
        public IWebElement FilterSortRankingSaleDescRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='사장님 댓글순']")]
        public IWebElement FilterSortRankingBossCommentDescRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_sort_type']//*[@text='배달 시간순']")]
        public IWebElement FilterSortRankingDeliveryTimeAscRadio { get; set; }



        #endregion


        #region 결제타입




        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']//*[@text='결제수단 전체']")]
        public IWebElement FilterMethodPaymentAllRadio { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']//*[@text='현금']")]
        public IWebElement FilterMethodPaymentCashRadio { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']//*[@text='현장카드']")]
        public IWebElement FilterMethodPaymentOnSiteRadio { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/radioGroup_payment_type']//*[@text='요기서결제']")]
        public IWebElement FilterMethodPaymentHereRadio { get; set; }
        #endregion

        [FindsBy(How = How.XPath, Using = "//*[@resource-id='com.fineapp.yogiyo:id/tv_tab_name']")]
        public IWebElement ApplyButton { get; set; }



    }
}