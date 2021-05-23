using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Lab1
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

            IWebElement login = driver.FindElement(By.Id("Name"));
            IWebElement pasw = driver.FindElement(By.Id("Password"));
            IWebElement btn = driver.FindElement(By.XPath("//input[@type='submit']"));

            login.SendKeys("user");
            pasw.SendKeys("user");
            btn.Click();

        }

        [Test]
        public void Test1()
        {
            
            IWebElement lgt = driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
            Assert.AreEqual("Logout", lgt.Text);
        }

        [Test]
        public void Test2()
        {
            IWebElement alprd = driver.FindElement(By.XPath("(//a[contains(@href, '/Product')])[2]"));
            alprd.Click();
            IWebElement newcr = driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
            newcr.Click();

            IWebElement prdname = driver.FindElement(By.Id("ProductName"));
            IWebElement categ = driver.FindElement(By.Id("CategoryId"));
            IWebElement sup = driver.FindElement(By.Id("SupplierId"));
            IWebElement unitpr = driver.FindElement(By.Id("UnitPrice"));
            IWebElement qupunit = driver.FindElement(By.Id("QuantityPerUnit"));
            IWebElement unist = driver.FindElement(By.Id("UnitsInStock"));
            IWebElement unitsonord = driver.FindElement(By.Id("UnitsOnOrder"));
            IWebElement reorlvl = driver.FindElement(By.Id("ReorderLevel"));
            IWebElement btn = driver.FindElement(By.XPath("//input[@type='submit']"));


            prdname.SendKeys("Beef  steak");
            new SelectElement(driver.FindElement(By.Id("CategoryId"))).SelectByText("Meat/Poultry");
            driver.FindElement(By.Id("CategoryId")).Click();
            new SelectElement(driver.FindElement(By.Id("SupplierId"))).SelectByText("Tokyo Traders");
            driver.FindElement(By.Id("SupplierId")).Click();
            unitpr.SendKeys("30");
            qupunit.SendKeys("20 - 1 kg tins");
            unist.SendKeys("13");
            unitsonord.SendKeys("40");
            reorlvl.SendKeys("10");
            btn.Click();

            IWebElement but = driver.FindElement(By.XPath("//a[contains(text(),'Create new')]"));
            Assert.AreEqual("Create new", but.Text);

        }

        [Test]
        public void Test3()
        {
            IWebElement alprd = driver.FindElement(By.XPath("(//a[contains(@href, '/Product')])[2]"));
            alprd.Click();
            IWebElement creatprd = driver.FindElement(By.XPath("//a[contains(text(),'Beef  steak')]"));
            creatprd.Click();

            IWebElement prdname = driver.FindElement(By.Id("ProductName"));
            Assert.AreEqual("Beef  steak", prdname.GetAttribute("value"));

            IWebElement categ = driver.FindElement(By.Id("CategoryId"));
            Assert.IsTrue(categ.Text.Contains("Meat/Poultry"));

            IWebElement sup = driver.FindElement(By.Id("SupplierId"));
            Assert.IsTrue(sup.Text.Contains("Tokyo Traders"));

            IWebElement unitpr = driver.FindElement(By.Id("UnitPrice"));
            Assert.AreEqual("30,0000", unitpr.GetAttribute("value"));

            IWebElement qupunit = driver.FindElement(By.Id("QuantityPerUnit"));
            Assert.AreEqual("20 - 1 kg tins", qupunit.GetAttribute("value"));

            IWebElement unist = driver.FindElement(By.Id("UnitsInStock"));
            Assert.AreEqual("13", unist.GetAttribute("value"));

            IWebElement unitsonord = driver.FindElement(By.Id("UnitsOnOrder"));
            Assert.AreEqual("40", unitsonord.GetAttribute("value"));

            IWebElement reorlvl = driver.FindElement(By.Id("ReorderLevel"));
            Assert.AreEqual("10", reorlvl.GetAttribute("value"));
        }

        [Test]
        public void Test4()
        {
            IWebElement alprd = driver.FindElement(By.XPath("(//a[contains(@href, '/Product')])[2]"));
            alprd.Click();
            driver.FindElement(By.XPath("(//a[contains(text(),'Remove')])[78]")).Click();
            driver.SwitchTo().Alert().Accept();
            Assert.IsTrue(driver.PageSource.Contains("Beef  steak"));


        }

        [Test]
        public void Test5()
        {
            IWebElement logout = driver.FindElement(By.XPath("//a[contains(text(),'Logout')]"));
            logout.Click();

            IWebElement name = driver.FindElement(By.XPath("//label"));
            Assert.IsTrue(name.Text.Contains("Name"));
            IWebElement pas = driver.FindElement(By.XPath("//div[2]/div/label"));
            Assert.IsTrue(pas.Text.Contains("Password"));
        }




        [TearDown]

        public void tearDown()
        {
            driver.Quit();
        }
    }
}