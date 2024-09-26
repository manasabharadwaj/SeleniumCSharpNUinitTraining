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


        [Description("Testcase verifies the login functionality with valid credentails")]
        [Test]
        public void testcase1() 
        {

            Console.WriteLine("This is the first testcase");

        }
    }
}
