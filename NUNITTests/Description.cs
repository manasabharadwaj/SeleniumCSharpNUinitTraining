using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Description("Testcase verifies the login functionality with valid credentials")]
        [Test]
        
        public void desctestcase1()
        {
            Console.WriteLine("Test case 1 has been executed");
        }
    }
}
