using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class CategoryTesting
    {
        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("Logging into the application");
        }
        [Test, Ignore("Defect ID 45667")]
        //[Test, Category("Sanity")]
        public void products()
        {
            Console.WriteLine("Selectting the products");
        }
        [Test, Category("Regression")]
        public void addtocart()
        {
            Console.WriteLine("Products added to cart");
        }
    }
}
