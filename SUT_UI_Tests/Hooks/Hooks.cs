using OpenQA.Selenium;
using SUT_UI_Tests.Drivers;
using TechTalk.SpecFlow;

namespace SUT_UI_Tests.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private IWebDriver _driver;
        private ScenarioContext _scenarioCntnext;

        public Hooks(ScenarioContext scenarioContext)
        {
            _scenarioCntnext = scenarioContext;
        }

        [BeforeScenario]
        public void FirstBeforeScenario()
        {
            _driver = DriverFactory.GenerateDriver();
            _scenarioCntnext.Add("Driver", _driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}