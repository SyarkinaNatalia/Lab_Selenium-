using Lab2;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Lab4.Steps
{
    [Binding]
    public class LogoutSteps
    {
        private IWebDriver driver;

        [When(@"I logout")]
        public void WhenILogout()
        {
            new AllProducts(driver).lout();
        }
        
        [Then(@"Check elem login")]
        public void ThenCheckElemLogin()
        {
            new HomePage(driver).chkelemlogin();

        }
    }
}
