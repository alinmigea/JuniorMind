using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace AnagramProblem
{
    [TestClass]
    public class AnagramTests
    {
        /*----- Tests for Factorial function -----*/
        [TestMethod]
        public void FactorialOfOne()
        {
            int factorial = CalculateFactorial(1);
            Assert.AreEqual(1, factorial);
        }

        [TestMethod]
        public void FactorialOfThree()
        {
            int factorial = CalculateFactorial(3);
            Assert.AreEqual(6, factorial);
        }

        [TestMethod]
        public void FactorialOfFour()
        {
            int factorial = CalculateFactorial(4);
            Assert.AreEqual(24, factorial);
        }


        /*----- Tests for Multiplication of factorials function -----*/
        [TestMethod]
        public void MultiplicationOfOneOneOne()
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('a', 1);
            dictionary.Add('b', 1);
            dictionary.Add('c', 1);

            int multiplication = CalculateValuesMultiplicationFromDictionary(dictionary);
            Assert.AreEqual(1, multiplication);
        }

        [TestMethod]
        public void MultiplicationOfOneTwoThree()
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('a', 1);
            dictionary.Add('b', 2);
            dictionary.Add('c', 3);

            int multiplication = CalculateValuesMultiplicationFromDictionary(dictionary);
            Assert.AreEqual(12, multiplication);
        }

        [TestMethod]
        public void MultiplicationOfThreeOneFour()
        {
            Dictionary<char, int> dictionary = new Dictionary<char, int>();
            dictionary.Add('x', 3);
            dictionary.Add('y', 1);
            dictionary.Add('z', 4);

            int multiplication = CalculateValuesMultiplicationFromDictionary(dictionary);
            Assert.AreEqual(144, multiplication);
        }


        /*----- Tests for the Numbers of the anagrams of a word function -----*/
        [TestMethod]
        public void OneLetterWordOccurrenceOne()
        {
            int anagrams = CalculculateNumberOfAnagrams("a");
            Assert.AreEqual(1, anagrams);
        }

        [TestMethod]
        public void ThreeLetterWordOccurrenceTwoOne()
        {
            int anagrams = CalculculateNumberOfAnagrams("aab");
            Assert.AreEqual(3, anagrams);
        }

        [TestMethod]
        public void ThreeLetterWordOccurrenceOneOneOne()
        {
            int anagrams = CalculculateNumberOfAnagrams("abc");
            Assert.AreEqual(6, anagrams);
        }

        [TestMethod]
        public void FiveLetterWordOccurrenceTwoOneOneOne()
        {
            int anagrams = CalculculateNumberOfAnagrams("alina");
            Assert.AreEqual(60, anagrams);
        }

        [TestMethod]
        public void ElevenLetterWordOccurrenceThreeTwoTwoOneOneOneOne()
        {
            int anagrams = CalculculateNumberOfAnagrams("abramburica");
            Assert.AreEqual(1663200, anagrams);
        }

        
        int CalculculateNumberOfAnagrams(string word)
        {
            Dictionary<char, int> occurrence = new Dictionary<char, int>();

            //if the key is present then just count the letter 
            //if not then initiate it with the first occourence
            for (int i = 0; i < word.Length; i++)
            {
                if (occurrence.ContainsKey(word[i]))
                {
                    occurrence[word[i]] += 1;
                }
                else
                {
                    occurrence[word[i]] = 1;
                }
            }

            //get the devision from the number of total permuatation possible
            //over the multiplication of letters occurences permutation
            return CalculateFactorial(word.Length) / CalculateValuesMultiplicationFromDictionary(occurrence);
        }

        //Calculate the Factorial for a number recursively
        int CalculateFactorial(int number)
        {
            if (number == 1)
            {
                return 1;
            }
            return number * CalculateFactorial(number -1);
        }

        //Calculate the multiplication of given values
        int CalculateValuesMultiplicationFromDictionary(Dictionary<char, int> dictionary)
        {
            int multiplicationResult = 1;

            foreach (KeyValuePair<char, int> pair in dictionary)
            {
                multiplicationResult *= CalculateFactorial(pair.Value);
            }
            return multiplicationResult;
        }
    }
}
