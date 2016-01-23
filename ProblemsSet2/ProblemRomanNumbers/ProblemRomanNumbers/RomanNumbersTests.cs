using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemRomanNumbers
{
    [TestClass]
    public class RomanNumbersTests
    {
        [TestMethod]
        public void OneAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(1);
            Assert.AreEqual("I", romanNumber);
        }

        [TestMethod]
        public void TwoAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(2);
            Assert.AreEqual("II", romanNumber);
        }

        [TestMethod]
        public void TenAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(10);
            Assert.AreEqual("X", romanNumber);
        }

        [TestMethod]
        public void TwelveAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(12);
            Assert.AreEqual("XII", romanNumber);
        }

        [TestMethod]
        public void FourtyFourAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(44);
            Assert.AreEqual("XLIV", romanNumber);
        }

        [TestMethod]
        public void EightySevenAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(87);
            Assert.AreEqual("LXXXVII", romanNumber);
        }

        [TestMethod]
        public void NinthyNineAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(99);
            Assert.AreEqual("XCIX", romanNumber);
        }

        [TestMethod]
        public void OneHoundredAsRomanNumber()
        {
            string romanNumber = GenerateRomanNumberFromArabic(100);
            Assert.AreEqual("C", romanNumber);
        }

        string GenerateRomanNumberFromArabic(int entryNumber)
        {
            string roNumber = "";
            //first nine numbers
            string[] firstDigit = {"I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX"};
            //the first nine decimal numbers
            string[] secondDigit = {"X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC"};

            if (entryNumber > 99)
            {
                return "C";
            }
            if (entryNumber >= 10)
            {
                //get the first digit
                int firstDecimal = entryNumber / 10;
                //set the first digit in the 'roman' string number
                roNumber += secondDigit[firstDecimal - 1];
                //now we have interes in the last digit
                entryNumber = entryNumber % 10;
            }
            if (entryNumber > 0)
            {
                roNumber += firstDigit[entryNumber - 1];
            }
            return roNumber;
        }
    }
}
