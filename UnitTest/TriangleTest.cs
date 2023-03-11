using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Geometry;

namespace UnitTest
{
    [TestClass]
    public class TriangleTest
    {
        [TestMethod]
        public void TestNegativeTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure f = new Triangle(-1, 2, 1.5);
            });
        }

        [TestMethod]
        public void TestWrongTriangle()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure f = new Triangle(1, 2, 3);
            });

            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure f = new Triangle(1, 2, 4);
            });

            Figure p = new Triangle(1, 2, 1.5);
        }

        [TestMethod]
        public void TestGenericArea()
        {
            Figure f = new Triangle(2, 3, 4);
            Assert.IsTrue(MathUtil.DoubleEqual(f.Area(), 2.904738));
        }

        [TestMethod]
        public void TestRightArea()
        {
            Figure f = new Triangle(3, 5, 4);
            Assert.IsTrue(MathUtil.DoubleEqual(f.Area(), 6));
        }

    }
}
