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
    public sealed class AppAcceptTermsAndConditionsTest : BaseStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        public AppAcceptTermsAndConditionsTest(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }


        [Given(@"권한 안내 확인 버튼 클릭")]
        public void 조건권한안내확인버튼클릭()
        {
            PageManager.Instance.CurrentPage = GetInstance<AuthPage>();
            var nextPage = PageManager.Instance.CurrentPage.As<AuthPage>().ClickAuthConfirm();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Given(@"시작하기 클릭")]
        public void 조건시작하기클릭()
        {
            PageManager.Instance.CurrentPage.As<AcceptTermsAndConditionsPage>().CheckTheAll();
            
            var nextPage = PageManager.Instance.CurrentPage.As<AcceptTermsAndConditionsPage>().ClickStartButton();
            
            PageManager.Instance.CurrentPage = nextPage;
        }

        [Given(@"권한 동의 클릭")]
        public void 조건권한동의클릭()
        {
            var nextPage = PageManager.Instance.CurrentPage.As<PermissionPage>().ClickPermissionAllowButton();

            PageManager.Instance.CurrentPage = nextPage;
        }

        [Then(@"배달 주소 검색 화면 이동")]
        public void 그러면배달주소검색화면이동()
        {
            //PageManager.Instance.CurrentPage.As<DeliveryAddressPage>().

        }



    }
}
