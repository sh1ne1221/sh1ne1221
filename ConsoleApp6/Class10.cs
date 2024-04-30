using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class10
    {
        public class SquareRoot
        {
            public static double Calculate(double num)
            {
                if (num < 0)
                {
                    throw new ArithmeticException("Квадратный корень из отрицательного числа не определен");
                }
                return Math.Sqrt(num);
            }
        }
    }
}
