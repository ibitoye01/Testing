using System;
using TechTalk.SpecFlow;
using Test.FBAutomation.Pages;
using Test.FBAutomation.SetUp;
using NUnit.Framework;

namespace Test.FBAutomation.StepDefinitions
{
    [Binding]
    public class LoginSteps
    {
        private Context _context;
        private LoginPage _loginPage;

        public LoginSteps(Context context, LoginPage loginPage)
        {
            _context = context;
            _loginPage = loginPage;
        }


        [Given(@"that utest application is loaded")]
        public void GivenThatUtestApplicationIsLoaded()
        {
            _context.LoadApplicationUnderTest();
        }

        [When(@"a user clicks on Log In link")]
        public void WhenAUserClicksOnLogInLink()
        {
            _loginPage.ClickOnLoginLink();
        }

        [When(@"a user fills-in email address field with (.*)")]
        public void WhenAUserFillsEmailAddressField(string email)
        {
            _loginPage.FillEmailField(email);
        }

        [When(@"a user fills-in password Field with (.*)")]
        public void WhenAUserFillsasswordField(string password)
        {
            _loginPage.FillPasswordField(password);
        }

        [When(@"a user click on Sign in button")]
        public void WhenAUserClickOnSignInButton()
        {
            _loginPage.ClickOnLoginButton();
        }

        [Then(@"user profile (.*) must be displayed")]
        public void ThenUserProfileMustBeDisplayed(string expectedResult)
        {
            Assert.IsTrue(expectedResult.Equals(_loginPage.VerifyProfilePage()));
        }



        [AfterScenario]
        public void CloseApplicationUnderTest()
        {
            _context.ShutDownApplicationUnderTest();
        }
    }
}
