using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnitTesting
    {

        Calculator cl = new Calculator();

        [Test]
        public void TestAdd()
        {

            int result = cl.Add(2, 3);

            int result1 = cl.Add(3, -4);

            // Assertion on NUNIT to compare the expected results with actual results 

            Assert.AreEqual(5, result);

            Assert.AreEqual(-1, result1);

        }

        [Test]
        public void TestSub()
        {

            int result = cl.Sub(5, 2);

            int result1 = cl.Add(9, -4);

            // Assertion on NUNIT to compare the expected results with actual results 

            Assert.AreEqual(3, result);

            Assert.AreEqual(5, result1);
        }

        [Test]
        public void TestDiv()
        {

            int result = cl.Div(5, 2);

            // Assertion on NUNIT to compare the expected results with actual results 

            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestMul()
        {

            int result = cl.Sub(5, 2);

            int result1 = cl.Add(9, -4);

            // Assertion on NUNIT to compare the expected results with actual results 

            Assert.AreEqual(3, result);

            Assert.AreEqual(5, result1);




        }
    }

}
