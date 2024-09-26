using NUnitSeleniumC_Training.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class LoginVerfWithValidCred : Base
    {

        [TestCase("Admin", "admin123")]
        public void LoginTest(string username, string password)
        {
            Thread.Sleep(3000);

            // Find the element usibg the By class locators 
            IWebElement Username = driver.FindElement(By.Name("username"));
            // inputing text using send keys 
            Username.SendKeys("Admin");

            Thread.Sleep(1000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            // inputing text using send keys 
            Password.SendKeys("admin123");


            IWebElement LoginButton = driver.FindElement(By.XPath("//button[@type = 'submit']"));
            LoginButton.Click();

            Thread.Sleep(1000);

          
           

        }
    }
}
