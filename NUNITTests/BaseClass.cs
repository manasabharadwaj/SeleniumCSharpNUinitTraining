using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class BaseClass
    {
        [OneTimeSetUp]
        public void dbconectionopen()
        {
            TestContext.Progress.WriteLine("Opening the DB connection");
        }
        [OneTimeTearDown]
        public void dbconectionclose()
        {
            TestContext.WriteLine("Closing the DB connection");
        }
    }
}
