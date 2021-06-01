using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using Lab2.dto;
using Lab2.Services;

namespace Lab2
{
    class CreateNew : AbstrPage
    {
        public CreateNew(IWebDriver driver)
        {
            AbstrPage.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ProductName")]
        public IWebElement productName;
        [FindsBy(How = How.Id, Using = "CategoryId")]
        public IWebElement category;
        [FindsBy(How = How.Id, Using = "SupplierId")]
        public IWebElement supplier;
        [FindsBy(How = How.Id, Using = "UnitPrice")]
        public IWebElement unitPrice;
        [FindsBy(How = How.Id, Using = "QuantityPerUnit")]
        public IWebElement quantityPerUnit;
        [FindsBy(How = How.Id, Using = "UnitsInStock")]
        public IWebElement unitsInStock;
        [FindsBy(How = How.Id, Using = "UnitsOnOrder")]
        public IWebElement unitsOnOrder;
        [FindsBy(How = How.Id, Using = "ReorderLevel")]
        public IWebElement reorderLevel;
        [FindsBy(How = How.XPath, Using = "//input[@type='submit']")]
        public IWebElement btn;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Create new')]")]
        public IWebElement btncreate;



        public AllProducts createProduct()
        {
            Servprd.CreateNew(productName, category, supplier, unitPrice, quantityPerUnit, unitsInStock, unitsOnOrder, reorderLevel);
            btn.Click();
            return new AllProducts(driver);
        }

        public AllProducts enterbtn()
        {
            btncreate.Click();
            return new AllProducts(driver);
        }

        public AllProducts chkelempoduct()
        {

            Assert.AreEqual("Beef  steak", productName.GetAttribute("value"));
            Assert.IsTrue(category.Text.Contains("Meat/Poultry"));
            Assert.IsTrue(supplier.Text.Contains("Tokyo Traders"));
            Assert.AreEqual("30,0000", unitPrice.GetAttribute("value"));
            Assert.AreEqual("20 - 1 kg tins", quantityPerUnit.GetAttribute("value"));
            Assert.AreEqual("13", unitsInStock.GetAttribute("value"));
            Assert.AreEqual("40", unitsOnOrder.GetAttribute("value"));
            Assert.AreEqual("10", reorderLevel.GetAttribute("value"));
            return new AllProducts(driver);
        }
    }
}
