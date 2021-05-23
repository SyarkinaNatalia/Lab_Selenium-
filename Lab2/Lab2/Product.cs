using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class Product : AbstrPage
    {
        public Product(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "(//a[contains(@href, '/Product')])[1]")]
        private IWebElement allp;

        public AllProducts clicklinkallpr()
        {
            allp.Click();
            return new AllProducts(driver);
        }
    }
}
