using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Geometry;

namespace UnitTest
{
    [TestClass]
    public class CircleTest
    {
        [TestMethod]
        public void TestNegative()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure f = new Circle(-3);
            });
        }

        [TestMethod]
        public void TestZeroCircleArea()
        {
            Figure f = new Circle(0);
            Assert.AreEqual(f.Area(), 0);
        }

        [TestMethod]
        public void TestGenericCircle()
        {
            Figure f = new Circle(5);
            Assert.IsTrue(MathUtil.DoubleEqual(f.Area(), Math.PI * 25));
        }
    }
}
