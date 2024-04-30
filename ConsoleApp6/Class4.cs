using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class4
    {
        public class Division
        {
            public static double Calculate(double num1, double num2)
            {
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Невозможно разделить на ноль");
                }
                return num1 / num2;
            }
        }
    }
}
