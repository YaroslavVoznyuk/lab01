using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class MathOperationsClass
    {

        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Minus(double a, double b)
        {
            return a - b;
        }

        public double Log(double a)
        {
            return Math.Log(a);
        }

        public int Fac(int a)
        {
            for (int i = 1; i <= a; i++)
            {
                a *= i;
            }
            return a;
        }

        public int Degree(int a, int b)
        {
            return (int)Math.Pow(a, b);
        }

        public int Sqrt(int a)
        {
            return (int)Math.Sqrt(a);
        }

    }
}
