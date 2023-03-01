using OpenQA.Selenium;
using SUT_UI_Tests.Drivers;
using SUT_UI_Tests.Pages;

namespace SUT_UI_Tests.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private HomePage _homePage;
        private IWebDriver _driver;
        private ScenarioContext _scenarioContext;


        public LoginStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _driver = _scenarioContext.Get<IWebDriver>("Driver");
            _homePage = new HomePage(_driver);
        }


        [StepDefinition(@"I am on the home page")]
        public void GivenIAmOnTheHomePage()
        {
            _homePage.NavigateToBasePage();
        }

        [When(@"I fill in login with valid credentials")]
        public void WhenIFillInLoginWithValidCredentials()
        {
            throw new PendingStepException();
        }

        [Then(@"I should be logged in")]
        public void ThenIShouldBeLoggedIn()
        {
            throw new PendingStepException();
        }

        [When(@"I fill in login with invalid credentials")]
        public void WhenIFillInLoginWithInvalidCredentials()
        {
            throw new PendingStepException();
        }

        [Then(@"I should not be logged in")]
        public void ThenIShouldNotBeLoggedIn()
        {
            throw new PendingStepException();
        }


    }
}
