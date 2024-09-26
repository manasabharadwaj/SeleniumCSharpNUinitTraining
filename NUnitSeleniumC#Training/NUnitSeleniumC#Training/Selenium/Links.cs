using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using NUnitSeleniumC_Training.Utilities;

namespace NUnitSeleniumC_Training.Selenium
{
    internal class Links : Base
    {


       
        [Test]
        public void testcase1()
        {

            Thread.Sleep(1000);
            // store the list of checkboxes
            IReadOnlyList<IWebElement> links = driver.FindElements(By.TagName("a"));

            foreach (IWebElement l in links)
            {
                // fetches the text of the element
                Console.WriteLine(l.Text + "URL is" + l.GetAttribute("href"));
                
            }





        }

      




    }
}
