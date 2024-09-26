using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [TestFixture, Category("Regression")]
    internal class TestOrder
    {
        [Test]
        public void Login()
        {
            Console.WriteLine("Logging into application");
        }
        [Test]
        public void Products()
        {
            Console.WriteLine("Selectting the products");
        }
        [Test]
        public void Addtocart()
        {
            Console.WriteLine("Products added to cart");
        }
    }
}
