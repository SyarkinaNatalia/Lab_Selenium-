using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Lab2;

namespace Lab4.Features
{
    [Binding]
    public class StepsLogin
    {
        private IWebDriver driver;

        [Given(@"I open ""(.+)"" url")]
        public void GivenIOpenMainPage(string url)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }
        
        [Given(@"I enter login and password")]
        public void GivenIEnterLoginAndPassword()
        {
            new MainPage(driver).enterlogin();
        }
        
        [When(@"I click send button")]
        public void WhenIClickSendButton()
        {
            new MainPage(driver).sendBtn.Click();
        }
        
        [Then(@"the browser navigates to the HomePage")]
        public void ThenTheBrowserNavigatesToTheHomePage()
        {
            Assert.AreEqual("Logout", new MainPage(driver).chklogout.Text);
        }
    }
}
