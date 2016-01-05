using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Domain;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day5Test
    {
        Day5 dayThree;

        [TestInitialize]
        public void Setup()
        {
            dayThree = new Day5();
        }

        [TestMethod]
        public void Test_ContainsAtLeastThreeVowels_ReturnsFalseWhenStingContainsTwoVowels()
        {
            //Arrange
            string testInput = "qwertyu";
            bool expected = false;

            //Act
            bool actual = dayThree.ContainsAtLeastThreeVowels(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsAtLeastThreeVowels_ReturnsTrueWhenStingContainsThreeVowels()
        {
            //Arrange
            string testInput = "qwertyui";
            bool expected = true;

            //Act
            bool actual = dayThree.ContainsAtLeastThreeVowels(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsAtLeastThreeVowels_ReturnsTrueWhenStingContainsFourVowels()
        {
            //Arrange
            string testInput = "qwertyuio";
            bool expected = true;

            //Act
            bool actual = dayThree.ContainsAtLeastThreeVowels(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsADoubleLetter_ReturnsFalseWhenThereIsNoDoubleLetter()
        {
            //arrange
            string testInput = "qwertyuiopabcba";
            bool expected = false;

            //act
            bool actual = dayThree.ContainsADoubleLetter(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsADoubleLetter_ReturnsTrueWhenThereIsADoubleLetter()
        {
            //arrange
            string testInput = "qwertyuiopp";
            bool expected = true;

            //act
            bool actual = dayThree.ContainsADoubleLetter(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsADoubleLetter_ReturnsTrueWhenThereIsATripleLetter()
        {
            //arrange
            string testInput = "qwerrrtyuiop";
            bool expected = true;

            //act
            bool actual = dayThree.ContainsADoubleLetter(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsADoubleLetter_ReturnsTrueWhenThereIsAreTwoDoubleLetters()
        {
            //arrange
            string testInput = "qwerrrtyuuiop";
            bool expected = true;

            //act
            bool actual = dayThree.ContainsADoubleLetter(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsNaughtyString_ReturnsFalseWhenThereIsNoNaughtyString()
        {
            //arrange
            string testInput = "qwerrrtyuiop";
            bool expected = false;

            //act
            bool actual = dayThree.ContainsNaughtyString(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsNaughtyString_ReturnsTrueWhenThereIsANaughtyString()
        {
            //arrange
            string testInput = "qwerrabrtyuiop";
            bool expected = true;

            //act
            bool actual = dayThree.ContainsNaughtyString(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsNaughtyString_ReturnsTrueWhenThereIsTwoNaughtyStrings()
        {
            //arrange
            string testInput = "qwerrabrtyucdiop";
            bool expected = true;

            //act
            bool actual = dayThree.ContainsNaughtyString(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
