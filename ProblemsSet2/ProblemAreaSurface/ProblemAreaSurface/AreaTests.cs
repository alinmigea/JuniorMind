using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemAreaSurface
{
    [TestClass]
    public class AreaTests
    {
        [TestMethod]
        public void TestInitialArea()
        {
            double area = CalculateAreaOfRectangle();
            Assert.AreEqual(770, area);
        }

        double CalculateAreaOfRectangle()
        {
            //initial masurements of the Area
            double totalArea = 770000;
            double widthArea = 230;

            //formula for that equation x^2 + 230*x - totalArea = 0
            double delta = Math.Pow(widthArea, 2) + 4 * totalArea;
            double positiveArea = (Math.Sqrt(delta) - widthArea) / 2;
            return Math.Truncate(positiveArea);
        }
    }
}
