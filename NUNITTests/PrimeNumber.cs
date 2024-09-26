using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnit_Selenium_c_Training.NUnitTesting
{
    internal class PrimeNumber
    {
        public bool Primer(int a)
        {
            for (int i = 2; i < a / 2; i++)
            {
                if (a % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}