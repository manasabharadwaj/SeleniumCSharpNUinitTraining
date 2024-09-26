using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class MultipleCheckboxes
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());
            driver = new ChromeDriver();


        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);
            IReadOnlyList<IWebElement>  Checkboxs = driver.FindElements(By.XPath("//input[@type='checkbox']"));
            foreach(IWebElement ch in Checkboxs)
            {
                //fetches the text of the element
                Console.WriteLine(ch.Text);
                //clicks on the checkboxes on eby one
                ch.Click();
            }
            
        }

        [TearDown]
        public void tearDownbrowser()
        {
            //closes the current browser session
            driver.Close();


        }
    }
}
