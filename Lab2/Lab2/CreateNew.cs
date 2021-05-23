using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;

namespace Lab2
{
    class CreateNew : AbstrPage
    {
        public CreateNew(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);

        }

        [FindsBy(How = How.Id, Using = "ProductName")]
        private IWebElement prdname;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        private IWebElement categ;
        [FindsBy(How = How.Id, Using = "SupplierId")]
        private IWebElement sup;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        private IWebElement unitpr;
        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        private IWebElement qupunit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        private IWebElement unist;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        private IWebElement unitsonord;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        private IWebElement reorlvl;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        private IWebElement btn;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        private IWebElement btncreate;



        public AllProducts crproduct()
        {
            new Actions(driver).Click(prdname).SendKeys("Beef  steak").Build().Perform();
            new Actions(driver).Click(categ).SendKeys("Meat/Poultry").Build().Perform();
            new Actions(driver).Click(sup).SendKeys("Tokyo Traders").Build().Perform();
            new Actions(driver).Click(unitpr).SendKeys("30").Build().Perform();
            new Actions(driver).Click(qupunit).SendKeys("20 - 1 kg tins").Build().Perform();
            new Actions(driver).Click(unist).SendKeys("13").Build().Perform();
            new Actions(driver).Click(unitsonord).SendKeys("40").Build().Perform();
            new Actions(driver).Click(reorlvl).SendKeys("10").Build().Perform();
            btn.Click();
            return new AllProducts(driver);
        }

        public AllProducts chkelempoduct()
        {

            Assert.AreEqual("Beef  steak", prdname.GetAttribute("value"));
            Assert.IsTrue(categ.Text.Contains("Meat/Poultry"));
            Assert.IsTrue(sup.Text.Contains("Tokyo Traders"));
            Assert.AreEqual("30,0000", unitpr.GetAttribute("value"));
            Assert.AreEqual("20 - 1 kg tins", qupunit.GetAttribute("value"));
            Assert.AreEqual("13", unist.GetAttribute("value"));
            Assert.AreEqual("40", unitsonord.GetAttribute("value"));
            Assert.AreEqual("10", reorlvl.GetAttribute("value"));
            return new AllProducts(driver);
        }
    }
}
