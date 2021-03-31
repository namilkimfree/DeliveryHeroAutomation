using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DeliveryHeroAutomation.Framework.Model.Base;
using DeliveryHeroAutomation.Framework.Services;
using DeliveryHeroAutomation.Pages;
using TechTalk.SpecFlow;

namespace DeliveryHeroAutomation.Steps
{
    [Binding]
    public sealed class RestaurantListHomeTest
    {

        private readonly ScenarioContext _scenarioContext;

        public RestaurantListHomeTest(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"요기요 홈 화면 이동")]
        public void 만일요기요홈화면이동()
        {
            PageManager.Instance.CurrentPage.As<HomePage>().IsLoaded();
        }

        [When(@"음식점 카테고리 전체 클릭")]
        public void 만일음식점카테고리전체클릭()
        {
            var nextPage =
            PageManager.Instance.CurrentPage.As<HomePage>().ClickAllRestaurantButton();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Then(@"음식점 카테고리 화면 이동")]
        public void 그러면음식점카테고리화면이동()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().DefaultSelectedTab();
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().IsLoaded();

        }

        [Given(@"요기요 익스프레스 체크")]
        public void 조건요기요익스프레스체크()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().ClickExpress();
        }

        [Given(@"음식점 안내 클릭")]
        public void 조건음식점안내클릭()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().ClickShopInfo();

        }

        [Given(@"탭 스크롤")]
        public void 조건탭스크롤()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().ScrollTab();
        }
        [Then(@"기존 선택된 탭 보이지 않는다\.")]
        public void 그러면기존선택된탭보이지않는다_()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().DefaultTabIsNotDisplayed();
        }


        [Given(@"탭 변경")]
        public void 조건탭변경()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().ClickRandomTab();

        }

        [Given(@"바텀 네비게이션 변경")]
        public void 조건바텀네비게이션변경()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().ClickRandomBottomNavigation();
        }

        [Given(@"음식점 필터 클릭")]
        public void 조건음식점필터클릭()
        {
            var nextPage =
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().ClickFilter();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Then(@"음식점 필터 노출")]
        public void 그러면음식점필터노출()
        {
            PageManager.Instance.CurrentPage.As<FilterPage>().IsLoaded();
        }



        [Then(@"익스프레스 체크 박스 체크 됨")]
        public void 그러면익스프레스체크박스체크됨()
        {
            PageManager.Instance.CurrentPage.As<RestaurantListPage>().IsChecked();

        }

    }
}
