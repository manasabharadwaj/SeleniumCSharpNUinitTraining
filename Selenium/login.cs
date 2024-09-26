﻿
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

    internal class Login

    {

        IWebDriver driver;


        [SetUp]

        public void startbrowser()

        {

            // configure the web driver manager to set up the chrome capabilities

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());

            // intialize the web driver 

            driver = new ChromeDriver();

            // launch the chrome browser

            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            driver.Manage().Window.Maximize();

        }

        [Test]

        public void testcase1()

        {

            Thread.Sleep(2000);

            //Find the element using the By class locators

            IWebElement Username = driver.FindElement(By.Name("username"));

            //Sending inputting text using send keys

            Username.SendKeys("Admin");

            //Find the element using the By class locators

            IWebElement Password = driver.FindElement(By.Name("password"));

            //Sending inputting text using send keys

            Password.SendKeys("admin123");

            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));

            LoginButton.Click();

        }

        [TearDown]

        public void tearDownbrowser()

        {

            driver.Close();

        }

    }

}

