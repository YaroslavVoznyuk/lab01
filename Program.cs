using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("double a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("double b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("int A=");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.Write("int B=");
            int B = Convert.ToInt32(Console.ReadLine());
            MathOperationsClass math = new MathOperationsClass(a,b,A,B);

            Console.WriteLine($"a+b={math.Sum(a, b)}");
            Console.WriteLine($"a-b={math.Minus(a, b)}");
            Console.WriteLine($"log10(a)={math.Log10(a)}");
            Console.WriteLine($"fac(A)={math.Fac(A)}"); 
            Console.WriteLine($"A^B={math.Degree(A, B)}");
            Console.WriteLine($"sqrt(A)={math.Sqrt(A)}");

        }
    }
}
