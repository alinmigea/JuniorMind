using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LotoProblem
{
    [TestClass]
    public class LotoTests
    {
        [TestMethod]
        public void ProbabilitySixFromFourtyNine()
        {
            double probability = CalculateProbability(6, 49);
            Assert.AreEqual("0.122", probability.ToString("0.000"));
        }


        [TestMethod]
        public void OneBallFromSixInFourtyNine()
        {
            string odds = CalculateChanceToWin(1, 6, 49);
            Assert.AreEqual("0.122448980", odds);
        }

        [TestMethod]
        public void TwoBallsFromSixInFourtyNine()
        {
            string odds = CalculateChanceToWin(2, 6, 49);
            Assert.AreEqual("0.012755102", odds);
        }

        [TestMethod]
        public void ThreeBallsFromSixInFourtyNine()
        {
            string odds = CalculateChanceToWin(3, 6, 49);
            Assert.AreEqual("0.001085541", odds);
        }

        [TestMethod]
        public void FourBallsFromSixInFourtyNine()
        {
            string odds = CalculateChanceToWin(4, 6, 49);
            Assert.AreEqual("0.000070796", odds);
        }

        [TestMethod]
        public void FiveBallsFromSixInFourtyNine()
        {
            string odds = CalculateChanceToWin(5, 6, 49);
            Assert.AreEqual("0.000003146", odds);
        }

        [TestMethod]
        public void SixBallsFromSixInFourtyNine()
        {
            string odds = CalculateChanceToWin(6, 6, 49);
            Assert.AreEqual("0.000000072", odds);
        }

        [TestMethod]
        public void FiveBallsFromFiveInFourty()
        {
            string odds = CalculateChanceToWin(5, 5, 40);
            Assert.AreEqual("0.000001520", odds);
        }

        string CalculateChanceToWin(int ballsToExtract, int totalNumberOfBallsNeededToBeExtracted, int totalNumberOfGameBalls)
        {
            double odds = 1.0;
            //this is the low margin to start calculating the probability
            int winningBalls = CalculateNumberOfSteps(totalNumberOfBallsNeededToBeExtracted, ballsToExtract);

            //repeat until we hit the maximum number of balls that can be extracted 
            while (winningBalls <= totalNumberOfBallsNeededToBeExtracted)
            {
                odds = odds * CalculateProbability(winningBalls, CalculateNumberOfSteps(totalNumberOfGameBalls, ballsToExtract));
                winningBalls += 1;
                ballsToExtract -= 1;
            }

            return odds.ToString("0.000000000");
        }

        //Calculates the number of favorable case over the total number of cases
        double CalculateProbability(int favorableCases, int totalCases)
        {
            return (double) favorableCases / (double) totalCases;
        }
        
        //Calculates the number of steps between two limits
        int CalculateNumberOfSteps(int highLimit, int lowerLimit)
        {
            return highLimit - lowerLimit + 1;
        }
    }
}
