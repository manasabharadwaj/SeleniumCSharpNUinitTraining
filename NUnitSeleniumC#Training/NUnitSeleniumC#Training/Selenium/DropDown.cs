using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DropDown
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

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);
            var select = new SelectElement(DropDown);

            // selct by visible text
            Thread.Sleep(1000);
            select.SelectByText("Option2");

            // selct by index select option1 
            Thread.Sleep(1000);
            select.SelectByIndex(1);


            // select by attribute value 
            select.SelectByValue("option3");

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
