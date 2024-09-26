using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class NavigationalCommands
    {

        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();
        }

        [Test]
        public void testcase1()
        {
            // launch the chrome browser - which will launch the URL on the browser.
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);

            driver.Navigate().Back();

            Thread.Sleep(3000);

            driver.Navigate().Forward();

            Thread .Sleep(3000);

            driver.Navigate().Refresh();






        }

        [TearDown]
        public void tearDownbrowser()
        {
            // will close the current browser session 
            driver.Close();

            // will close all the browser session of the browser

            //  driver.Quit();

        }

    }
}
