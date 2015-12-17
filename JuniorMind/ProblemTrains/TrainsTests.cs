using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemTrains
{
    [TestClass]
    public class TrainsTests
    {
        [TestMethod]
        public void DistanceDone()
        {
            float distance = CalculateDistanceTraveled(0);
            Assert.AreEqual(0 , distance);
        }

        [TestMethod]
        public void DistanceDone2()
        {
            float distance = CalculateDistanceTraveled(1);
            Assert.AreEqual(2, distance);
        }

        [TestMethod]
        public void DistanceDone3()
        {
            float distance = CalculateDistanceTraveled(2);
            Assert.AreEqual(4, distance);
        }

        [TestMethod]
        public void DistanceDone4()
        {
            float distance = CalculateDistanceTraveled(10);
            Assert.AreEqual(20, distance);
        }

        [TestMethod]
        public void DistanceDone5()
        {
            float distance = CalculateDistanceTraveled(1005);
            Assert.AreEqual(2010, distance);
        }

        float CalculateDistanceTraveled(int DistanceTraveled)
        {
            int TotalDistance = 4 * DistanceTraveled;
            float DistanceNeedsTraveling;

            DistanceNeedsTraveling = (float) 0.5 * TotalDistance;

            return DistanceNeedsTraveling;
        }
    }
}
