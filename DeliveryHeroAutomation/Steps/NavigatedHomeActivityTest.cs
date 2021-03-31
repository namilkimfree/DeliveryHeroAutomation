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
    public sealed class NavigatedHomeActivityTest
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public NavigatedHomeActivityTest(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"주소 '(.*)' 입력")]
        public void 만일주소입력(string address)
        {
            PageManager.Instance.CurrentPage.As<DeliveryAddressPage>().SetDeliveryAddress(address);

        }

        [When(@"주소가 있다면")]
        public void 만일주소가있다면()
        {
            PageManager.Instance.CurrentPage.As<DeliveryAddressPage>().IsSearched();
        }

        [Given(@"검색된 주소 클릭")]
        public void 조건검색된주소클릭()
        {
            var nextPage =
                PageManager.Instance.CurrentPage.As<DeliveryAddressPage>().SelectMyAddress();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Given(@"요기로 배달 버튼 클릭")]
        public void 조건요기로배달버튼클릭()
        {
            var nextPage =
                PageManager.Instance.CurrentPage.As<AddressDetailPage>().ClickHereDeliveryButton();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Given(@"권한 허용 클릭")]
        public void 조건권한허용클릭()
        {
            var nextPage =
                PageManager.Instance.CurrentPage.As<AdvertisingPopup>().CloseClick();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Then(@"요기요 홈 화면 이동")]
        public void 그러면요기요홈화면이동()
        {
            PageManager.Instance.CurrentPage.As<HomePage>().IsLoaded();
        }

    }
}
