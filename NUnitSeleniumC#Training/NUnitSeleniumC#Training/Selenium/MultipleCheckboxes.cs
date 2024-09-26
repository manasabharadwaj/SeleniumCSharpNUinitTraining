using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class MultipleCheckboxes
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
      
            Thread.Sleep(1000);
            // store the list of checkboxes
            IReadOnlyList<IWebElement> Checkboxs = driver.FindElements(By.XPath("//input[@type = 'checkbox']"));
       
            foreach(IWebElement e in Checkboxs)
            {
                // fetches the text of the element
                Console.WriteLine(e.Text);
                // clicks on the check boxes one by one
                e.Click();
            }


        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }


    }
}
