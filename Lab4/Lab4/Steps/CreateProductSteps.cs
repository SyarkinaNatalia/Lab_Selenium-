using Lab2;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Lab4.Steps
{
    [Binding]
    public class CreateProductSteps
    {
        private IWebDriver driver;


        [Given(@"I logging in")]
        public void GivenILoggingIn()
        {
            new MainPage(driver).enterlogin();
            new MainPage(driver).sendBtn.Click();
        }
        
        [Given(@"I Click on All Products")]
        public void GivenIClickOnAllProducts()
        {
            new HomePage(driver).clicklink();
        }
        
        [Given(@"I Click on Create New")]
        public void GivenIClickOnCreateNew()
        {
            new AllProducts(driver).clicklinkcr();
        }
        
        [When(@"I enter values ​​into fields")]
        public void GivenIEnterValuesIntoFields()
        {
            new CreateNew(driver).createProduct();
        }
        
        [Then(@"I click on button")]
        public void WhenIClickOnButton()
        {
            new CreateNew(driver).btn.Click();
        }
    }
}
