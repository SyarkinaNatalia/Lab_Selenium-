using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;
using System.Threading;

namespace Lab2
{
    public class Tests
    {
        private IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/");

        }

        [Test]
        public void Test1()
        {
            MainPage mainPage = new MainPage(driver);
            HomePage enterlogin = mainPage.enterlogin();
            HomePage homePage = mainPage.chkelem();
            AllProducts allProducts = enterlogin.clicklink();
            CreateNew createNew = allProducts.clicklinkcr();
            AllProducts createpr = createNew.createProduct();
            AllProducts product = allProducts.clickprod();
            AllProducts chelem = createNew.chkelempoduct();
            AllProducts exit = product.clicklinkallpr();
            AllProducts delete = allProducts.del();
            driver.SwitchTo().Alert().Accept();
            MainPage logout = allProducts.lout();
            MainPage chelemlog = homePage.chkelemlogin();
        }



        [TearDown]

        public void tearDown()
        {
            driver.Quit();
        }
    }

}