using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class LaunchEdge
    {

        IWebDriver driver;

        [SetUp]
        public void startbrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            // intialize the web driver 
            driver = new EdgeDriver();
        }

        [Test]
        public void testcase1()
        {

            // launch the chrome browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

    }
}
