using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Domain;

namespace AdventOfCode.Test
{
    [TestClass]
    public class DayTwoTest
    {
        DayTwo dayTwo;

        [TestInitialize]
        public void Setup()
        {
            dayTwo = new DayTwo();
        }

        [TestMethod]
        public void Test_FindSquareFeetNeeded_GivesFiftyTwoSquareFeet_WhenGivenHeightSixWidthTwelveAndLengthEight()
        {
            //Arrange
            int expected = 52;
            int height = 2;
            int width = 3;
            int length = 4;

            //Act
            dayTwo.FindSquareFeetNeeded(height, width, length);

            //Assert
            Assert.AreEqual(expected, dayTwo.squareFeet);
        }

        [TestMethod]
        public void Test_FindSquareFeetNeeded_GivesSixSlack_WhenGivenHeightSixWidthTwelveAndLengthEight()
        {
            //Arrange
            int expected = 6;
            int height = 2;
            int width = 3;
            int length = 4;

            //Act
            dayTwo.FindSquareFeetNeeded(height, width, length);

            //Assert
            Assert.AreEqual(expected, dayTwo.slack);
        }

        [TestMethod]
        public void Test_FindSquareFeetNeeded_GivesFiftyEightSquareFeetNeeded_WhenGivenHeightSixWidthTwelveAndLengthEight()
        {
            //Arrange
            int expected = 58;
            int height = 2;
            int width = 3;
            int length = 4;

            //Act
            dayTwo.FindSquareFeetNeeded(height, width, length);

            //Assert
            Assert.AreEqual(expected, dayTwo.squareFeetNeeded);
        }

        [TestMethod]
        public void Test_FindSquareFeetNeeded_GivesFourtyTwoSquareFeet_WhenGivenHeightOneWidthOneAndLengthTen()
        {
            //Arrange
            int expected = 42;
            int height = 1;
            int width = 1;
            int length = 10;

            //Act
            dayTwo.FindSquareFeetNeeded(height, width, length);

            //Assert
            Assert.AreEqual(expected, dayTwo.squareFeet);
        }

        [TestMethod]
        public void Test_FindSquareFeetNeeded_GivesOneSlack_WhenGivenHeightOneWidthOneAndLengthTen()
        {
            //Arrange
            int expected = 1;
            int height = 1;
            int width = 1;
            int length = 10;

            //Act
            dayTwo.FindSquareFeetNeeded(height, width, length);

            //Assert
            Assert.AreEqual(expected, dayTwo.slack);
        }

        [TestMethod]
        public void Test_FindSquareFeetNeeded_GivesFourtyThreeSquareFeetNeeded_WhenGivenHeightOneWidthOneAndLengthTen()
        {
            //Arrange
            int expected = 43;
            int height = 1;
            int width = 1;
            int length = 10;

            //Act
            dayTwo.FindSquareFeetNeeded(height, width, length);

            //Assert
            Assert.AreEqual(expected, dayTwo.squareFeetNeeded);
        }
    }
}
