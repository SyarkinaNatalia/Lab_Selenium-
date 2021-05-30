using Lab2;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Lab4.Steps
{
    [Binding]
    public class CheckTheCreatedProductSteps
    {
        private IWebDriver driver;

        [When(@"I click on the created product")]
        public void WhenIClickOnTheCreatedProduct()
        {
            new AllProducts(driver).clickprod();
        }
        
        [Then(@"Check product elements")]
        public void ThenCheckProductElements()
        {
            new CreateNew(driver).chkelempoduct();
        }
    }
}
