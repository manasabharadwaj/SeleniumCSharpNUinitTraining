using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class OneTimeSetupAndTearDown
    {
        [OneTimeSetUp]
        public void dbconectionopen()
        {
            Console.WriteLine("Opening the DB connection");
        }
        [OneTimeTearDown]
        public void dbconectionclose()
        {
            Console.WriteLine("Closing the DB connection");
        }
    }
}
