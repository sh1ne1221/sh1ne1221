using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Class7
    {
        public class Tangent
        {
            public static double Calculate(double angleDegrees)
            {
                double angleRadians = angleDegrees * Math.PI / 180;
                return Math.Tan(angleRadians);
            }
        }
    }
}
