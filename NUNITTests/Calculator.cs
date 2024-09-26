using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitSeleniumC_Training.NUNITTests
{
    internal class Calculator
    {
        //Add
        public int Add(int a, int b)
        {
            int c = a + b; return c;
        }

        //Sub
        public int Sub(int a, int b)
        {
            int c = a - b; return c;
        }

        //Mul
        public int Mul(int a, int b)
        {
            int c = a * b; return c;
        }

        //Div
        public int Div(int a, int b)
        {
            int c = a / b; return c;
        }
    }
}
