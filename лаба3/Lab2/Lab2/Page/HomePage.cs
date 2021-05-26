using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Lab2
{
    class HomePage : AbstrPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[contains(@href, '/Product')])[2]")]
        private IWebElement allp;
        [FindsBy(How = How.XPath, Using = "//label")]
        private IWebElement name;
        [FindsBy(How = How.XPath, Using = "//div[2]/div/label")]
        private IWebElement pas;



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
