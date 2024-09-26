using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class BrowserCommands
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

            // get the title of the page

            string title = driver.Title;
            Console.WriteLine(title);

            // get the current url 

            string currenturl = driver.Url;

            Console.WriteLine(currenturl);

            // fetch the page source of the html page

            string pagesource = driver.PageSource;

            Console.WriteLine(pagesource);

           

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
