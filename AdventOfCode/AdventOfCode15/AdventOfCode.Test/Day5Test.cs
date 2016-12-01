using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Domain;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day5Test
    {
        Day5 dayFive;

        [TestInitialize]
        public void Setup()
        {
            dayFive = new Day5();
        }

        [TestMethod]
        public void Test_ContainsAtLeastThreeVowels_ReturnsFalseWhenStingContainsTwoVowels()
        {
            //Arrange
            string testInput = "qwertyu";
            bool expected = false;

            //Act
            bool actual = dayFive.ContainsAtLeastThreeVowels(testInput);

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
            bool actual = dayFive.ContainsAtLeastThreeVowels(testInput);

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
            bool actual = dayFive.ContainsAtLeastThreeVowels(testInput);

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
            bool actual = dayFive.ContainsADoubleLetter(testInput);

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
            bool actual = dayFive.ContainsADoubleLetter(testInput);

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
            bool actual = dayFive.ContainsADoubleLetter(testInput);

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
            bool actual = dayFive.ContainsADoubleLetter(testInput);

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
            bool actual = dayFive.ContainsNaughtyString(testInput);

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
            bool actual = dayFive.ContainsNaughtyString(testInput);

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
            bool actual = dayFive.ContainsNaughtyString(testInput);

            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsAPairThatAppearsTwice_ReturnsTrueWhenPairsAreNotOverlapping()
        {
            //Arrange
            string testInput = "qwertyqwasd";
            bool expected = true;

            //Act
            bool actual = dayFive.ContainsAPairThatAppearsTwice(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsAPairThatAppearsTwice_ReturnsFalseWhenPairsAreOverlapping()
        {
            //Arrange
            string testInput = "aaa";
            bool expected = false;

            //Act
            bool actual = dayFive.ContainsAPairThatAppearsTwice(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsAPairThatAppearsTwice_ReturnsFalseWhenThereAreNoRepeatingPairs()
        {
            //Arrange
            string testInput = "qwerty";
            bool expected = false;

            //Act
            bool actual = dayFive.ContainsAPairThatAppearsTwice(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsARepeatingCharacterSeparatedByASingleCharacter_ReturnsTrueWhenARepeatedCharacterIsSeperatedByASingleCharacter()
        {
            //Arrange
            string testInput = "aaa";
            bool expected = true;

            //Act
            bool actual = dayFive.ContainsASeperatedRepeatingCharacter(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsARepeatingCharacterSeparatedByASingleCharacter_ReturnsFalseWhenARepeatedCharacterIsNotSeperatedByASingleCharacter()
        {
            //Arrange
            string testInput = "aa";
            bool expected = false;

            //Act
            bool actual = dayFive.ContainsASeperatedRepeatingCharacter(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_ContainsARepeatingCharacterSeparatedByASingleCharacter_ReturnsFalseWhenTheIsNoRepeatedCharacter()
        {
            //Arrange
            string testInput = "abc";
            bool expected = false;

            //Act
            bool actual = dayFive.ContainsASeperatedRepeatingCharacter(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsStringNiceWithUpdatedRules_ReturnsTrueWhenGivenAStringWithAPairAndARepeat()
        {
            //Arrange
            string testInput = "qjhvhtzxzqqjkmpb";
            bool expected = true;

            //Act
            bool actual = dayFive.IsStringNiceWithUpdatedRules(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsStringNiceWithUpdatedRules_ReturnsFalseWhenGivenAStringWithAPairButNoRepeat()
        {
            //Arrange
            string testInput = "uurcxstgmygtbstg";
            bool expected = false;

            //Act
            bool actual = dayFive.IsStringNiceWithUpdatedRules(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_IsStringNiceWithUpdatedRules_ReturnsFalseWhenGivenAStringWithARepeatButNoPair()
        {
            //Arrange
            string testInput = "ieodomkazucvgmuy";
            bool expected = false;

            //Act
            bool actual = dayFive.IsStringNiceWithUpdatedRules(testInput);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
