using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Backend
{
    internal class Calculate
    {
        public double Add(double a, double b)
        {
            return a + b;
        }  
        public void DoNothingg()
        {
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Denominator cannot be zero.");
            }
            return a / b;
        }
    }
}
