using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using NUnitSeleniumC_Training.Utilities;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Links : Base
    {

        [Test]
        public void linksselection()
        {
            IReadOnlyList<IWebElement> downloadLink = driver.FindElements(By.TagName("a"));
            foreach (IWebElement i in downloadLink)
            {
                Console.WriteLine(i.Text + "URL is - " + i.GetAttribute("href"));
                Console.WriteLine("Update to links.cs file");
            }


        }
    }
}