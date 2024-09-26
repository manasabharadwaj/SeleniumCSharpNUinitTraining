using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    [Allure.NUnit.AllureNUnit]
    internal class CategoryTesting
    {
        

        [Test, Category("Regression")]
        public void login()
        {

            Console.WriteLine("Logging into application");


        }

        [Test, Ignore("Defect ID 45667")]
        public void products()
        {

            Console.WriteLine("Selecting the products");
        }

        [Test, Category("Regression")]
        public void addtocart()
        {

            Console.WriteLine("Products added to the cart");
        }


    }
}
