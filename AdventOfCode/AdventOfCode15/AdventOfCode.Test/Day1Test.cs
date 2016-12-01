using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Domain;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day1Test
    {
        Day1 dayOne;

        [TestInitialize]
        public void Setup()
        {
            dayOne = new Day1();
        }

        [TestMethod]
        public void Test_StartsOnFloorZero()
        {
            //Arrange
            int expected = 0;

            //Act

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaDoesntMove_WhenGivenNoInstructions()
        {
            //Arrange
            int expected = 0;

            //Act
            dayOne.FindFloor("");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaGoesUp_WhenGivenLeftBracket()
        {
            //Arrange
            int expected = 1;

            //Act
            dayOne.FindFloor("(");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaGoesDown_WhenGivenRightBracket()
        {
            //Arrange
            int expected = -1;

            //Act
            dayOne.FindFloor(")");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaDoesntMove_WhenGivenRightAndLeftBracket()
        {
            //Arrange
            int expected = 0;

            //Act
            dayOne.FindFloor("()");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaGoesUpThree_WhenGivenThreeLeftBrackets()
        {
            //Arrange
            int expected = 3;

            //Act
            dayOne.FindFloor("(((");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaGoesDownThree_WhenGivenThreeRightBrackets()
        {
            //Arrange
            int expected = -3;

            //Act
            dayOne.FindFloor(")))");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_SantaGoesDownThree_WhenGivenThreeLeftAndSixRightBrackets()
        {
            //Arrange
            int expected = -3;

            //Act
            dayOne.FindFloor("()))(()))");

            //Assert
            Assert.AreEqual(expected, dayOne.floor);
        }

        [TestMethod]
        public void Test_FindFloor_BasementFoundOnFirstInstruction_WhenGivenOneRightBracket()
        {
            //Arrange
            int expected = 1;

            //Act
            dayOne.FindFloor(")");

            //Assert
            Assert.AreEqual(expected, dayOne.basementInstruction);
        }

        [TestMethod]
        public void Test_FindBasement_BasementFoundOnFifthInstruction_WhenGivenThreeRightAndTwoLeftBrackets()
        {
            //Arrange
            int expected = 5;

            //Act
            dayOne.FindFloor("()())");

            //Assert
            Assert.AreEqual(expected, dayOne.basementInstruction);
        }
    }
}
