using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Frameseg
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

            driver.Navigate().GoToUrl("https://jqueryui.com/checkboxradio/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {


            IWebElement Frame1 =  driver.FindElement(By.XPath("//iframe[@class='demo-frame']"));

            // select the frame using xpath of the frame

            // driver.SwitchTo().Frame(Frame1);

            // select the frame using index

            driver.SwitchTo().Frame(0);

            // select the frame using ID or name 

          //  driver.SwitchTo().Frame("Frameone");

            // click in the radio button new york

            IWebElement radiobutton = driver.FindElement(By.XPath("(//span[@class='ui-checkboxradio-icon ui-corner-all ui-icon ui-icon-background ui-icon-blank'])[1]"));

            radiobutton.Click();

            Thread.Sleep(1000);

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
