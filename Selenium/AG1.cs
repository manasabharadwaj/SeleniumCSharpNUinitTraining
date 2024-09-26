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
    internal class AG1
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
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
            Thread.Sleep(5000);
            IWebElement male = driver.FindElement(By.Id("gender-male"));
            Thread.Sleep(5000);
            IWebElement Firstname = driver.FindElement(By.XPath("//*[@id=\"FirstName\"]"));
            Firstname.SendKeys("Admin");
            Thread.Sleep(5000);
            IWebElement Lastname = driver.FindElement(By.Id("LastName"));
            Lastname.SendKeys("Abc");
            Thread.Sleep(5000);
            IWebElement email = driver.FindElement(By.Id("Email"));
            email.SendKeys("Admin@gmail.com");
            Thread.Sleep(5000);
            IWebElement Password = driver.FindElement(By.Id("Password"));
            Password.SendKeys("Password");
            Thread.Sleep(5000);
            IWebElement ConfirmPassword = driver.FindElement(By.Id("ConfirmPassword"));
            ConfirmPassword.SendKeys("Password");
            Thread.Sleep(5000);
            IWebElement LoginButton = driver.FindElement(By.Id("register-button"));
            male.Click();
            LoginButton.Click();
        }

        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close();
        }
    }
}
