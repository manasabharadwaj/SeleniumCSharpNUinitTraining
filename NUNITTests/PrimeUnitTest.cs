using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium_c_Training.NUnitTesting
{
    internal class PrimeUnitTest
    {
        PrimeNumber primmie = new PrimeNumber();
        [Test]
        public void Primetest()
        {
            bool res = primmie.Primer(7);
            Assert.IsTrue(res);
        }
    }
}
