using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParamaterizationForLogin : Base
    {
        [TestCase("Admin", "admin123")]
        [TestCase("Pram", "asdfg123")]
        [TestCase("Hero", "qwert")]
        public void testcase1(string user, string pass)
        {
            Thread.Sleep(1000);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(user);

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(pass);

            IWebElement LoginButton = driver.FindElement(By.XPath("//button [@type = 'submit']"));
            LoginButton.Click();
            Thread.Sleep(2000);

            IWebElement errmsg = driver.FindElement(By.XPath("//p[@class='oxd-text oxd-text--p oxd-alert-content-text']"));
            string err = errmsg.Text;
            Console.WriteLine(err);
            Assert.AreEqual("Invalid credentials", errmsg);
        }
    }
}
