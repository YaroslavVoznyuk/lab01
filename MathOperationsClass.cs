using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator
{
    public class MathOperationsClass
    {
        #region Construtor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="a">переменная a типа double</param>
        /// <param name="b">переменная b типа double</param>
        /// <param name="A">переменная a типа int</param>
        /// <param name="B">переменная b типа int</param>
        public MathOperationsClass(double a, double b, int A, int B)
        {
            this.Da = a;
            this.Db = b;
            this.A = A;
            this.B = B;
        }

        #endregion

        #region Properties
        public double Da { get; set; }
        public double Db { get; set; }
        public int A { get; set; }
        public int B { get; set; }

        #endregion

        public double Sum(double Da, double Db)
        {
            return Da + Db;
        }

        public double Minus(double Da, double Db)
        {
            return Da - Db;
        }

        public double Log10(double Da)
        {
            return Math.Log10(Da);
        }

        public int Fac(int A)
        {
            if (A == 1) return 1;

            return A * Fac(A - 1);
        }

        public int Degree(int A, int B)
        {
            return (int)Math.Pow(A, B);
        }

        public int Sqrt(int A)
        {
            return (int)Math.Sqrt(A);
        }

    }
}
