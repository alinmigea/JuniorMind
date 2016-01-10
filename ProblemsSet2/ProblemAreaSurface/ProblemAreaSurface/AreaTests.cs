using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemAreaSurface
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void ZeroBoughtZeroInitial()
        {
            double area = CalculateAreaOfRectangle(0, 0);
            Assert.AreEqual(0, 0);
        }

        [TestMethod]
        public void OneHundredBoughtOneThousandInitial()
        {
            double area = CalculateAreaOfRectangle(100, 1000);
            Assert.AreEqual(9, area);
        }


        [TestMethod]
        public void TwoHundredThirtyBoughtSevenHundredThousandInitial()
        {
            double area = CalculateAreaOfRectangle(230, 770000);
            Assert.AreEqual(770, area);
        }

        double CalculateAreaOfRectangle(double widthArea, double totalArea)
        {
            //formula for that equation x^2 + widthArea*x - totalArea = 0
            double delta = Math.Pow(widthArea, 2) + 4 * totalArea;
            double positiveArea = (Math.Sqrt(delta) - widthArea) / 2;
            //gives a result with aproximation
            return Math.Truncate(positiveArea);
        }
    }
}
