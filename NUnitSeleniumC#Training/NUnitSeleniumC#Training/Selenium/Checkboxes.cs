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
    internal class Checkboxes
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);



            // single check box click 

            Thread.Sleep(1000);
            IWebElement Checkbox2 = driver.FindElement(By.XPath("(//input[@type = 'checkbox'])[1]"));
            Checkbox2.Click();



        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

    }
}
