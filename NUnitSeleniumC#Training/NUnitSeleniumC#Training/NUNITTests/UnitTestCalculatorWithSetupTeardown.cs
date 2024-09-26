using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{

    [Allure.NUnit.AllureNUnit]
    internal class UnitTestCalculatorWithSetupTeardown
    {
        public Calculator cl;

        [SetUp]
        public void setup()
        {
            cl = new Calculator();
            Console.WriteLine("Executing the set up");
        }

        [TearDown]
        public void teardown()
        {

            Console.WriteLine("All the units tests for the calculator funcationality are executed");
        }

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

            int result1 = cl.Sub(9, -4);

            // Assertion on NUNIT to compare the expected results with actual results 

            Assert.AreEqual(3, result);

            Assert.AreEqual(13, result1);
         }

        

    }
}
