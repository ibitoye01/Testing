using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace Test.FBAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
        }

        private By loginlink = By.XPath("/html/body/ui-view/unauthenticated-container/div/div/unauthenticated-header/div/div[3]/ul[2]/li[1]/a");
        private By emailField = By.Id("username");
        private By passwordField = By.Id("password");
        private By loginBtn = By.XPath("//input[@type='submit' and @value = 'Sign In']");
        private By profileName = By.XPath("/html/body/ui-view/nav-sidebar/div/nav/div[3]/nav-sidebar-user-info/div/div[2]/div[1]");


        public void ClickOnLoginLink()
        {
            _driver.FindElement(loginlink).Click();
        }
        public void FillEmailField(string email)
        {
            IWebElement emailLocator = _driver.FindElement(emailField);
            emailLocator.Clear();
            emailLocator.SendKeys(email);
        }

        public void FillPasswordField(string password)
        {
            IWebElement passwordLocator = _driver.FindElement(passwordField);
            passwordLocator.Clear();
            passwordLocator.SendKeys(password);
        }

        public void ClickOnLoginButton()
        {
            _driver.FindElement(loginBtn).Click();
        }

        public string VerifyProfilePage()
        {
            return _driver.FindElement(profileName).Text.Trim();
        }
    }
}
