using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        [Given(@"요기요 홈 탭 클릭")]
        public void 조건요기요홈탭클릭()
        {
            var homePage = new HomePage();

            homePage.Test();
        }

        [Then(@"요기요 홈 화면 로딩")]
        public void 그러면요기요홈화면로딩()
        {
        }


        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Pending();
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata 
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Pending();
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _scenarioContext.Pending();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            _scenarioContext.Pending();
        }
    }
}
