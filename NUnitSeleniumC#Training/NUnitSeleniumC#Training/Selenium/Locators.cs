using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Locators
    {

        IWebDriver driver;

        [SetUp]
        public void StartBrowser()
        {
            // confifgure the web driver manager to set up the chrome capabilities
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // intialize the web driver 
            driver = new ChromeDriver();

            // launch the chrome browser
            driver.Navigate().GoToUrl("https://automationexercise.com/contact_us");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);

            // Find the element usibg the By class locators

            // Name locator
            IWebElement Name = driver.FindElement(By.Name("name"));
            // inputing text using send keys 
            Name.SendKeys("Raman");

            Thread.Sleep(1000);

            // CSS selector 
            IWebElement Email = driver.FindElement(By.CssSelector("input[placeholder='Email']"));
            // inputing text using send keys 
            Email.SendKeys("abc@gmail.com");

            //Name locator
            IWebElement Subject  = driver.FindElement(By.Name("subject"));
            Subject.SendKeys("Leave application");

            // id locators
            IWebElement Message = driver.FindElement(By.Id("message"));
            Message.SendKeys("Sick down with fever");

            Thread.Sleep(2000);

            //LInk text 

            IWebElement SubmitButton = driver.FindElement(By.Name("submit"));
            SubmitButton.Click();

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }



    }
}
