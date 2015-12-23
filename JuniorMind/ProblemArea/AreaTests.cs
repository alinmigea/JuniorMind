using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemArea
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void AreaZero()
        {
            decimal triangleArea = CalculateArea(1, 1, 1, 1, 1, 1);
            Assert.AreEqual(0m, triangleArea);
        }

        [TestMethod]
        public void AreaHalfOne()
        {
            decimal triangleArea = CalculateArea(1, 0, 0, 1, 1, 1);
            Assert.AreEqual(0.5m, triangleArea);
        }

        [TestMethod]
        public void AreaOne()
        {
            decimal triangleArea = CalculateArea(1, 2, 2, 2, 2, 0);
            Assert.AreEqual(1m, triangleArea);
        }

        decimal CalculateArea(decimal x1, decimal y1, decimal x2, decimal y2, decimal x3, decimal y3)
        {
            //Get the value of the determinant
            decimal determinantValue = ((x1 * y2) + (x2 * y3) + (x3 * y1)) - ((x3 * y2) + (x2 * y1) + (x1 * y3));
            decimal absDeterminantValue = Math.Abs(determinantValue);

            //The area of a triangle given by its coordonates is 1/2 from the absolute value of the determinant formed by its coordonates.
            return absDeterminantValue / 2;
        }
    }
}
