using NUnit.Framework;
using OpenQA.Selenium.DevTools.V126.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.DataDrivenTesting
{
    internal class TestParUsingTestcase
    {
        
        [TestCase("abc.com","ghhjj")]
        [TestCase("ghh.com","fghhj")]
        [TestCase("mkk.com","ddffg")]
        public void LoginTest(string username , string password)
        {

            Console.WriteLine(username + ":" + password);

        }


    }
}
