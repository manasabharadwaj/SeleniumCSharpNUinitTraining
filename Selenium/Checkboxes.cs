using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Checkboxes
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new EdgeDriver();


        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(1000);
            IWebElement Checkbox2 = driver.FindElement(By.XPath("(//input[@type='checkbox'])[2]"));
            Checkbox2.Click();
        }

        [TearDown]
        public void tearDownbrowser()
        {
            //closes the current browser session
            driver.Close();

        
        }
    }
}
