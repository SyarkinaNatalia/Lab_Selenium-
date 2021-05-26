using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
    class MainPage : AbstrPage
    {
        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "Name")]
        private IWebElement login;
        [FindsBy(How = How.Id, Using = "Password")]
        private IWebElement pas;
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Logout')]")]
        private IWebElement chklogout;
 
        public HomePage enterlogin()
        {
            new Actions(driver).Click(login).SendKeys("user").Build().Perform();
            new Actions(driver).Click(pas).SendKeys("user").SendKeys(Keys.Enter).Build().Perform();
            return new HomePage(driver);
        }

        public HomePage chkelem()
        {
            Assert.AreEqual("Logout", chklogout.Text);
            return new HomePage(driver);
        }

    }
}
