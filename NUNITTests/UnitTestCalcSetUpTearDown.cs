using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class UnitTestCalcSetUpTearDown
    {
        public Calculator calc;
        [SetUp]
        public void setup()
        {
            calc=new Calculator();
            Console.WriteLine("Executing the setup");
        }
        [Test, Order(1)]
        public void AddTest()
        {
            int result = calc.Add(2, 3);
            int result1 = calc.Add(3, -4);
            //Assertion of NUNIT to compare actualvs expected results
            Assert.AreEqual(5, result);
            Assert.AreEqual(-1, result1);

        }
        [Test, Order(2)]
        public void SubTest()
        {
            int result = calc.Sub(5, 2);
            Assert.AreEqual(3, result);
        }
        [Test, Order(3)]
        public void MulTest()
        {
            int result = calc.Mul(2, 5);
            Assert.AreEqual(10, result);
        }
        [Test]
        public void DivTest()
        {
            int result = calc.Div(10, 5);
            Assert.AreEqual(2, result);
        }

        [TearDown]
        public void tearDown()
        {
            Console.WriteLine("Closing the calculator");
        }
    }
}
