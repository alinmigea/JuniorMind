using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemExcel
{
    [TestClass]
    public class ExcelTests
    {
        [TestMethod]
        public void FirstColumn()
        {
            string column = GetColumnStringAfterNumber(1);
            Assert.AreEqual("A", column);
        }

        [TestMethod]
        public void SecondColumn()
        {
            string column = GetColumnStringAfterNumber(2);
            Assert.AreEqual("B", column);
        }

        [TestMethod]
        public void ThirdColumn()
        {
            string column = GetColumnStringAfterNumber(3);
            Assert.AreEqual("C", column);
        }

        [TestMethod]
        public void TwentyFiveColumn()
        {
            string column = GetColumnStringAfterNumber(25);
            Assert.AreEqual("Y", column);
        }

        [TestMethod]
        public void TwentySixColumn()
        {
            string column = GetColumnStringAfterNumber(26);
            Assert.AreEqual("Z", column);
        }

        [TestMethod]
        public void TwentySevenColumn()
        {
            string column = GetColumnStringAfterNumber(27);
            Assert.AreEqual("AA", column);
        }

        [TestMethod]
        public void FiftyTwoColumn()
        {
            string column = GetColumnStringAfterNumber(52);
            Assert.AreEqual("AZ", column);
        }

        [TestMethod]
        public void FiftyThreeColumn()
        {
            string column = GetColumnStringAfterNumber(53);
            Assert.AreEqual("BA", column);
        }

        [TestMethod]
        public void FiftyFourColumn()
        {
            string column = GetColumnStringAfterNumber(54);
            Assert.AreEqual("BB", column);
        }

        [TestMethod]
        public void SevenHoundredAndTwentyEightColumn()
        {
            string column = GetColumnStringAfterNumber(728);
            Assert.AreEqual("ZZ", column);
        }

        [TestMethod]
        public void SevenHoundredAndTwentyNineColumn()
        {
            string column = GetColumnStringAfterNumber(729);
            Assert.AreEqual("AAA", column);
        }

        [TestMethod]
        public void SevenHoundredAndThirtyColumn()
        {
            string column = GetColumnStringAfterNumber(730);
            Assert.AreEqual("AAB", column);
        }

        string GetColumnStringAfterNumber(int columnNumber)
        {
            string columnCharacters = "";

            // situation for the number from [1-26]
            /*if (columnNumber < 27)
            {
                columnCharacters = GetAssociateCharAfterAsciiNumbers(columnNumber - 1) + columnCharacters;
                return columnCharacters;
            }*/

            //fix for the number > 100 because of the second character.
            int flag = 0;
            if (columnNumber > 100)
            {
                flag = 1;
            }

            //if it passed the first if then the number is greater then 26
            columnNumber -= 1;
            do
            {
                int digit = columnNumber % 26;
                columnNumber = columnNumber / 26 - 1;

                columnCharacters = GetAssociateCharAfterAsciiNumbers(digit) + columnCharacters;
                
                //the fix for the second character
                if (columnNumber > 0 && flag == 1)
                {
                    columnNumber -= 1;
                }
            } while (columnNumber > -1);

            return columnCharacters;
        }

        string GetAssociateCharAfterAsciiNumbers(int asciiNumber)
        {
            asciiNumber += 65;
            char character = (char)asciiNumber;

            return character.ToString();
        }
    }
}
