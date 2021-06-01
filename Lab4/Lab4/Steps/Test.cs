using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using Lab2;

namespace Lab4.Steps
{
    [Binding]
    public class Test
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
        
        [When(@"the browser navigates to the HomePage")]
        public void WhenIClickSendButton()
        {
            new MainPage(driver).chkelem();
        }

        [When(@"I Click on All Products")]
        public void GivenIClickOnAllProducts()
        {
            new HomePage(driver).clicklink();
        }

        [When(@"I Click on Create New")]
        public void GivenIClickOnCreateNew()
        {
            new AllProducts(driver).clicklinkcr();
        }

        [When(@"I enter values ​​into fields")]
        public void GivenIEnterValuesIntoFields()
        {
            new CreateNew(driver).createProduct();
        }

        [When(@"I click on the created product")]
        public void WhenIClickOnTheCreatedProduct()
        {
            new AllProducts(driver).clickprod();
        }

        [When(@"Check product elements")]
        public void ThenCheckProductElements()
        {
            new CreateNew(driver).chkelempoduct();
        }

        [When(@"I click on All Products")]
        public void WhenIClickOnAllProducts()
        {
            new AllProducts(driver).clicklinkallpr();
        }

        [When(@"I delete new product")]
        public void ThenIDeleteNewProduct()
        {
            new AllProducts(driver).del();
            driver.SwitchTo().Alert().Accept();
            Thread.Sleep(2000);
        }

        [When(@"I logout")]
        public void WhenILogout()
        {
            new AllProducts(driver).lout();
        }

        [Then(@"end")]
        public void End()
        {
            driver.Quit();
        }
    }
}
