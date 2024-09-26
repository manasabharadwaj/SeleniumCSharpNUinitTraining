using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class DownloadFile
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

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            IWebElement ChooseFile = driver.FindElement(By.XPath("//a[contains(text(),'HR1.png')]"));
            //ChooseFile.SendKeys("C:\\Users\\Harsha Patil\\Documents\\dev\\image.png");

            //IWebElement Download = driver.FindElement(By.XPath("//input[@id = 'file-submit']"));
            ChooseFile.Click();

            /*Thread.Sleep(1000);

            IWebElement FileDownloadMsg = driver.FindElement(By.XPath("//h3[contains(text(),'File Downloaded!')]"));

            string textmsg = FileDownloadMsg.Text;

            string expectedtext = "File Downloaded!";

            Console.WriteLine(textmsg);

            Assert.AreEqual(textmsg, expectedtext);*/



        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
