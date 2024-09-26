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
    internal class VerticalScrolling
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

            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {


            // scroll down

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            // 0 - x coordinates 

            // 500 - y cordinates 

            js.ExecuteScript("window.scrollBy(0,800)", "");

            Thread.Sleep(3000);


            // scroll up

          
            // 0 - x coordinates 

            // -500 - y cordinates 

            js.ExecuteScript("window.scrollBy(0,-300)", "");

            Thread.Sleep(3000);

            // scroll to the bottom of the page

            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");

            Thread.Sleep(3000);


        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
