using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{

    [Allure.NUnit.AllureNUnit]
    [TestFixture, Category("Smoke")]
    internal class TestOrders
    {

        [Test,Order(1)]
        public void login()
        {

            Console.WriteLine("Logging into application");


        }

        [Test,Order(2)]
        public void products()
        {

            Console.WriteLine("Selecting the products");
        }

        [Test,Order(3)]
        public void addtocart()
        {

            Console.WriteLine("Products added to the cart");
        }
    }

}