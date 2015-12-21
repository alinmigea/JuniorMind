using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemSports
{
    [TestClass]
    public class SportsTests
    {
        [TestMethod]
        public void FirstRound()
        {
            int repetitions = CalculateRepetitions(1);
            Assert.AreEqual(1, repetitions);
        }

        [TestMethod]
        public void SecondRound()
        {
            int repetitions = CalculateRepetitions(2);
            Assert.AreEqual(4, repetitions);
        }

        [TestMethod]
        public void TenthRound()
        {
            int repetitions = CalculateRepetitions(10);
            Assert.AreEqual(100, repetitions);
        }

        int CalculateRepetitions(int round)
        {
            //finalNumberOfRepetitions = (n*(n + 1))/2 + ((n-1)*n)/2 = n^2
            int finalNumberOfRepetitions = round * round;

            return finalNumberOfRepetitions;
        }
    }
}
