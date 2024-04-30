using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class5
    {
        public class Sine
        {
            public static double Calculate(double angleDegrees)
            {
                double angleRadians = angleDegrees * Math.PI / 180;
                return Math.Sin(angleRadians);
            }
        }
    }
}
