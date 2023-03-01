using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT_UI_Tests.Pages
{
    public class HomePage
    {
        private IWebDriver _driver;

        public HomePage(IWebDriver driver) 
        { 
            _driver = driver;
        }

        private string _baseUrl = "http://localhost:5254/";

        public void NavigateToBasePage()
        {
            _driver.Navigate().GoToUrl(_baseUrl);
        }

    }
}
