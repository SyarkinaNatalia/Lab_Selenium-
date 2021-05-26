using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;


namespace Lab2
{
    class AllProducts : AbstrPage
    {
        public AllProducts(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        private IWebElement creatnw;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Beef  steak')]")]
        private IWebElement prod;
        [FindsBy(How = How.XPath, Using = "(//a[contains(text(),'Remove')])[78]")]
        private IWebElement delete;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        private IWebElement logout;
        [FindsBy(How = How.XPath, Using = "(//a[contains(@href, '/Product')])[1]")]
        private IWebElement allp;


        public CreateNew clicklinkcr()
        {
            creatnw.Click();
            return new CreateNew(driver);
        }
        public AllProducts clickprod()
        {
            prod.Click();
            return new AllProducts(driver);
        }
        public AllProducts del()
        {
            delete.Click();
            return new AllProducts(driver);
        }

        public MainPage lout()
        {
            logout.Click();
            return new MainPage(driver);
        }
        public AllProducts clicklinkallpr()
        {
            allp.Click();
            return new AllProducts(driver);
        }
    }
}
