using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Test.FBAutomation.SetUp
{
    [Binding]
    public class Context
    {
        private readonly IObjectContainer _objectContainer;
        private IWebDriver _driver;
        private string baseUrl = "https://www.utest.com/";

        public Context(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
            _driver = new ChromeDriver();
            _objectContainer.RegisterInstanceAs<IWebDriver>(_driver);
        }

        public void LoadApplicationUnderTest()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            _driver.Navigate().GoToUrl(baseUrl);
            _driver.Manage().Window.Maximize();
        }

        public void ShutDownApplicationUnderTest()
        {
            _driver?.Quit();
        }
    }
}
