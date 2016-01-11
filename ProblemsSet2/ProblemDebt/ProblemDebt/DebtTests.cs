using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemDebt
{
    [TestClass]
    public class DebtTests
    {
        [TestMethod]
        public void DebtZero()
        {
            double debt = CalculateDebtToPay(0, 0);
            Assert.AreEqual(0, debt);
        }

        [TestMethod]
        public void DebtOneHundredAndTwo()
        {
            double debt = CalculateDebtToPay(3, 100);
            Assert.AreEqual(102, debt);
        }

        [TestMethod]
        public void DebtTwoHundredAndTen()
        {
            double debt = CalculateDebtToPay(11, 200);
            Assert.AreEqual(210, debt);
        }

        [TestMethod]
        public void OneThousandAndTenHundreds()
        {
            double debt = CalculateDebtToPay(34, 1000);
            Assert.AreEqual(1100, debt);
        }

        double CalculateDebtToPay(int daysLate, int rent)
        {
            //the number of late pay days in not greater then 40,
            //if this will be needed then I'll set just a margin for the last condition
            if ((daysLate >= 1) && (daysLate <= 10))
            {
                return CalculatePenalty(2, rent);
            }
            if ((daysLate > 10) && (daysLate <= 30))
            {
                return CalculatePenalty(5, rent);
            }
            if ((daysLate > 30) && (daysLate <= 40))
            {
                return CalculatePenalty(10, rent);
            }
            return rent;
        }

        double CalculatePenalty(int penaltyPercentage, int sum)
        {
            return sum + CalculatePercentageFromSum(penaltyPercentage, sum);
        }

        double CalculatePercentageFromSum(int percentage, int sum)
        {
            return (percentage * sum) / 100;
        }
    }
}
