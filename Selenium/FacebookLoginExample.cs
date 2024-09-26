/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.DevTools.V126.Overlay;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class FacebookLoginExample
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
            // launch the forefox browser

            driver.Navigate().GoToUrl("https://www.facebook.com/login/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            IWebElement gmail = driver.FindElement(By.XPath("//input[@id='email']"));
            gmail.Click();
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("a")
                .KeyUp(Keys.Shift)
                .SendKeys("bcd")
                .KeyDown(Keys.Shift)
                .SendKeys("2g")
                .KeyUp(Keys.Shift)
                .SendKeys("mail.")
                .KeyDown(Keys.Shift)
                .SendKeys("c")
                .KeyUp(Keys.Shift)
                .SendKeys("om")
                .Perform();
            Thread.Sleep(1000);
        }
       

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
*/