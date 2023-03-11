using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public static class MathUtil
    {
        public static double Lm = 1e-5;

        public static void CheckNegative(double num, String msg)
        {
            if (num < 0)
            {
                throw new ArgumentException(msg);
            }
        }

        public static bool DoubleEqual(double a, double b)
        {
            return Math.Abs(a - b) < Lm;
        }
    }
}
