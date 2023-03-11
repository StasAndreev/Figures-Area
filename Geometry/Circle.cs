using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                MathUtil.CheckNegative(value, "Circle radius can't be negative");
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
