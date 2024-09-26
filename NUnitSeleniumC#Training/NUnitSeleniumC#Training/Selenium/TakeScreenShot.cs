using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.Extensions;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class TakeScreenShot
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

           // Take screen shot class and getscreenshotAs  - method 


            

            Screenshot ss = driver.TakeScreenshot();

            ss.SaveAsFile("C:\\Users\\Harsha Patil\\source\\repos\\NUnitSeleniumC#Training\\NUnitSeleniumC#Training\\Screenshots\\err.jpg");
                
                }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

    }
}
