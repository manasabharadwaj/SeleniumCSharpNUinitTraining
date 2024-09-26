/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class WebTableEx
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/iframe");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
        }

        [TearDown]
        public void Teardown()
        {
            Thread.Sleep(2000);
            driver.Close();
        }

        [Test]
        public void testcase1()
        {
            //xpath of the table
            IWebElement table = driver.FindElement(By.XPath("//table[@id= 'table1']"));
            //fetch all rows of table
            List<IWebElement> tr = new List<IWebElement>(table.FindElements(By.XPath("//table[@id ='table1']/tbody")));
            int rowcount = tr.Count();
            Console.WriteLine(rowcount);

            //fetch all columns of table
            List<IWebElement> tc = new List<IWebElement>(table.FindElements(By.XPath("//table[@id ='table1']/tbody")));
            int colcount = tc.Count();
            Console.WriteLine(colcount);

        }
    }
}*/