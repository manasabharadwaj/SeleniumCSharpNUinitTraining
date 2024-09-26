using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class LaunchFirefox
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            // configure the web driver manager to set up the firefox capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            // intialize the web driver 
            driver = new FirefoxDriver();


        }

        [Test]
        public void testcase1()
        {

            // launch the firefox browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}