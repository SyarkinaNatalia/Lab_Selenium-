using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;


namespace Lab2
{
    class HomePage : AbstrPage
    {
        public HomePage(IWebDriver driver)
        {
            AbstrPage.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div/a[@href='/Product']")]
        public IWebElement allp;
        [FindsBy(How = How.XPath, Using = "//label")]
        public IWebElement name;
        [FindsBy(How = How.XPath, Using = "//div[2]/div/label")]
        public IWebElement pas;



        public AllProducts clicklink()
        {
            allp.Click();
            return new AllProducts(driver);
        }

        public MainPage chkelemlogin()
        {
            Assert.IsTrue(name.Text.Contains("Name"));
            Assert.IsTrue(pas.Text.Contains("Password"));
            return new MainPage(driver);
        }



    }
}
