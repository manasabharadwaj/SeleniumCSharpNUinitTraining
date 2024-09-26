using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class ClickHold
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
            // launch the chrome browser
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement tdydeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));
            //Actions act = new Actions();
            new Actions(driver)
                .ClickAndHold(tdydeal)
                .Perform();
            Thread.Sleep(1000);

            //Assert.AreEqual("Prime", driver.FindElement(By.XPath("//span[normalize-space()='Prime']"));

        }
        [TearDown]
        public void tearDownBrowser()
        {
            driver.Close();
        }
    }
}
