using Lab2;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace Lab4.Steps
{
    [Binding]
    public class DeleteSteps
    {
        private IWebDriver driver;

        [When(@"I click on All Products")]
        public void WhenIClickOnAllProducts()
        {
            new HomePage(driver).clicklink();
        }
        
        [Then(@"I delete new product")]
        public void ThenIDeleteNewProduct()
        {
            new AllProducts(driver).del();
            driver.SwitchTo().Alert().Accept();
        }
    }
}
