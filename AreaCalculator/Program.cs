using System;
using Geometry;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure f = new Circle(10);
            Console.WriteLine(f.Area());
        }
    }
}
