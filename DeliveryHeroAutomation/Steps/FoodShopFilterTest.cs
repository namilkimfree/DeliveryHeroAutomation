using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeliveryHeroAutomation.Framework.Services;
using DeliveryHeroAutomation.Pages;
using TechTalk.SpecFlow;

namespace DeliveryHeroAutomation.Steps
{
    [Binding]
    public sealed class FoodShopFilterTest
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public FoodShopFilterTest(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"음식점 필터 노출")]
        public void 만일음식점필터노출()
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().IsLoaded();
        }

        [When(@"뒤로가기 버튼 클릭")]
        public void 만일뒤로가기버튼클릭()
        {
            var nextPage= 
                PageManager.Instance.CurrentPage.As<FilterPage>().CloseFilter();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [When(@"익스프레스 체크 박스 체크")]
        public void 만일익스프레스체크박스체크()
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().ClickExpress();
        }

        [When(@"적용하기 버튼 클릭")]
        public void 만일적용하기버튼클릭()
        {
            var nextPage =
                PageManager.Instance.CurrentPage.As<FilterPage>().ClickApplyButton();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [When(@"랭킹 정렬 '(.*)' 클릭")]
        public void 만일랭킹정렬클릭(string rankingSortType)
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().ClickRankingSortType(rankingSortType);

        }

        [When(@"결제 방법 '(.*)' 클릭")]
        public void 만일결제방법클릭(string paymentSortType)
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().ClickPaymentSortType(paymentSortType);
        }

        [Then(@"음식점 리스트 정렬 변경")]
        public void 그러면음식점리스트정렬변경()
        {
            //Restful API 값 불러온 후
            //TestCode에서 따로 또 정렬을 해서
            //실제 노출순서와 같은지 검증
        }

        [When(@"초기화 버튼 클릭")]
        public void 만일초기화버튼클릭()
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().FilterResetClick();

        }

        [Then(@"음식점 필터 초기화")]
        public void 그러면음식점필터초기화()
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().FilterIsReset();
        }


    }
}
