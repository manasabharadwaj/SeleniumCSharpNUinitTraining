using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class BrowserCommands
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();


        }

        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            
            //get the page title
            string title = driver.Title;
            Console.WriteLine(title);

            //get current url
            string currenturl = driver.Url;
            Console.WriteLine(currenturl);

            //fetch the page source of the HTML page
            string pagesrc=driver.PageSource;
            Console.WriteLine(pagesrc);

            
        }

        [TearDown]
        public void tearDownbrowser()
        {
            //closes the current browser session
            driver.Close();

            //will close all browser sessions
            driver.Quit();
        }

    }
}

