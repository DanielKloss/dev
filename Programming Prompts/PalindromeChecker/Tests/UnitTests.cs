using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeChecker;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        Checker checker = new Checker();

        [TestMethod]
        public void WhenPassedATwoLetterPalindromeShouldReturnTrue()
        {
            Assert.AreEqual(true, checker.CheckWord("aa"));
        }

        [TestMethod]
        public void WhenPassedAThreeLetterPalindromeShouldReturnTrue()
        {
            Assert.AreEqual(true, checker.CheckWord("aba"));
        }

        [TestMethod]
        public void WhenPassedAFourLetterPalindromeShouldReturnTrue()
        {
            Assert.AreEqual(true, checker.CheckWord("abba"));
        }

        [TestMethod]
        public void WhenPassedAFiveLetterPalindromeShouldReturnTrue()
        {
            Assert.AreEqual(true, checker.CheckWord("ababa"));
        }

        [TestMethod]
        public void WhenPassedATwoLetterNonPalindromeShouldReturnFalse()
        {
            Assert.AreEqual(false, checker.CheckWord("ab"));
        }

        [TestMethod]
        public void WhenPassedAThreeLetterNonPalindromeShouldReturnFalse()
        {
            Assert.AreEqual(false, checker.CheckWord("abb"));
        }

        [TestMethod]
        public void WhenPassedAFourLetterNonPalindromeShouldReturnFalse()
        {
            Assert.AreEqual(false, checker.CheckWord("abra"));
        }

        [TestMethod]
        public void WhenPassedAFiveLetterNonPalindromeShouldReturnFalse()
        {
            Assert.AreEqual(false, checker.CheckWord("abrra"));
        }

        [TestMethod]
        public void WhenPassedAGroupOfWordsWithNoPalindromesShouldReturnAnEmptyList()
        {
            List<string> expected = new List<string>();

            CollectionAssert.AreEqual(expected, checker.CheckText("abbra kadabera alakazam, this is a great magic trick!"));
        }

        [TestMethod]
        public void WhenPassedAGroupOfWordsWithOnePalindromeShouldReturnAListOfThePalindromicWords()
        {
            List<string> expected = new List<string>
            {
                "abba"
            };

            CollectionAssert.AreEqual(expected, checker.CheckText("abbra kadabera abba, this is a great magic trick!"));
        }

        [TestMethod]
        public void WhenPassedAGroupOfWordsWithTwoPalindromesShouldReturnAListOfThePalindromicWords()
        {
            List<string> expected = new List<string>
            {
                "abba", "baab"
            };

            CollectionAssert.AreEqual(expected, checker.CheckText("abbra kadabera abba baab, this is a great magic trick!"));
        }

        [TestMethod]
        public void WhenPassedAGroupOfWordsWithTwoIdenticalPalindromesShouldReturnAListOfThePalindromicWords()
        {
            List<string> expected = new List<string>
            {
                "abba", "abba"
            };

            CollectionAssert.AreEqual(expected, checker.CheckText("abbra kadabera abba abba, this is a great magic trick!"));
        }

        [TestMethod]
        public void WhenPassedATextFileWithNoPalindromesShouldReturnAnEmptyList()
        {
            List<string> expected = new List<string>();

            string fileLocation = "../../NoPalindromeFile.txt";

            CollectionAssert.AreEqual(expected, checker.CheckFile(fileLocation));
        }

        [TestMethod]
        public void WhenPassedATextFileWithOnePalindromeShouldReturnAListOfThePalindromicWords()
        {
            List<string> expected = new List<string>
            {
                "abba"
            };

            string fileLocation = "../../OnePalindromeFile.txt";

            CollectionAssert.AreEqual(expected, checker.CheckFile(fileLocation));
        }

        [TestMethod]
        public void WhenPassedATextFileWithTwoPalindromesShouldReturnAListOfThePalindromicWords()
        {
            List<string> expected = new List<string>
            {
                "abba", "baab"
            };

            string fileLocation = "../../TwoPalindromeFile.txt";

            CollectionAssert.AreEqual(expected, checker.CheckFile(fileLocation));
        }
    }
}
