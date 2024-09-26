/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class RegularExp
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

            driver.Navigate().GoToUrl("https://www.cavai.com/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            IWebElement element1 = driver.FindElement(By.XPath("//div[starts-with(@class, 'Footer') and contains(@class,'links')]"));


            
            
        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
*/