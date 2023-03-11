using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Triangle : Figure
    {
        private double a;
        private double b;
        private double c;

        public double A
        {
            get
            {
                return a;
            }
            protected set
            {
                MathUtil.CheckNegative(value, "Triangle argument can't be negative");
                a = value;
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            protected set
            {
                MathUtil.CheckNegative(value, "Triangle argument can't be negative");
                b = value;
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            protected set
            {
                MathUtil.CheckNegative(value, "Triangle argument can't be negative");
                c = value;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a < b + c && b < a + c && c < a + b)
            {
                A = a;
                B = b;
                C = c;
            }
            else
            {
                throw new ArgumentException("Triangle can not have sides: " + a + ", " + b + ", " + c);
            }
        }

        public double Area()
        {
            double H;
            double L1;
            double L2;

            if (A >= B && A >= C)
            {
                H = A;
                L1 = B;
                L2 = C;
            }
            else if (B >= A && B >= C)
            {
                H = B;
                L1 = A;
                L2 = C;
            }
            else
            {
                H = C;
                L1 = A;
                L2 = B;
            }

            if (MathUtil.DoubleEqual(H * H, L1 * L1 + L2 * L2))
            {
                return L1 * L2 / 2;
            }
            else
            {
                double p = (A + B + C) / 2;
                return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
        }
    }
}
