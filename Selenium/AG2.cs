using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace Selenium
{
    internal class Saucedemo
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
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            Thread.Sleep(5000);
            IWebElement Username = driver.FindElement(By.Id("user-name"));
            Username.SendKeys("standard_user");
            Thread.Sleep(5000);
            IWebElement Password = driver.FindElement(By.Id("password"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(5000);
            IWebElement LoginButton = driver.FindElement(By.Id("login-button"));
            LoginButton.Click();

        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}