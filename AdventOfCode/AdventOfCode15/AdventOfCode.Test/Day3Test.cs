using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Domain;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day3Test
    {
        Day3 dayThree;

        [TestInitialize]
        public void Setup()
        {
            dayThree = new Day3();
        }

        [TestMethod]
        public void Test_MoveSanta_SantaMovesOneToTheRight_WhenGivenRightCheveron()
        {
            //Arrange
            char input = '>';
            int expected = 1;

            //Act
            dayThree.MoveSanta(input);

            //Assert
            Assert.AreEqual(expected, dayThree.santaX);
        }

        [TestMethod]
        public void Test_MoveSanta_SantaMovesOneToTheLeft_WhenGivenLeftCheveron()
        {
            //Arrange
            char input = '<';
            int expected = -1;

            //Act
            dayThree.MoveSanta(input);

            //Assert
            Assert.AreEqual(expected, dayThree.santaX);
        }

        [TestMethod]
        public void Test_MoveSanta_SantaMovesOneUp_WhenGivenUpCheveron()
        {
            //Arrange
            char input = '^';
            int expected = 1;

            //Act
            dayThree.MoveSanta(input);

            //Assert
            Assert.AreEqual(expected, dayThree.santaY);
        }

        [TestMethod]
        public void Test_MoveSanta_SantaMovesOneDown_WhenGivenDownCheveron()
        {
            //Arrange
            char input = 'v';
            int expected = -1;

            //Act
            dayThree.MoveSanta(input);

            //Assert
            Assert.AreEqual(expected, dayThree.santaY);
        }

        [TestMethod]
        public void Test_DeliverPresents_DeliversToTwoHouses_WhenGivenARightCheveron()
        {
            //Arrange
            string input = ">";
            int expected = 2;

            //Act
            dayThree.DeliverPresents(input);

            //Assert
            Assert.AreEqual(expected, dayThree.housesDeliveredTo);
        }

        [TestMethod]
        public void Test_DeliverPresents_DeliversToFourHouses_WhenGivenALoopOfCheverons()
        {
            //Arrange
            string input = "^>v<";
            int expected = 4;

            //Act
            dayThree.DeliverPresents(input);

            //Assert
            Assert.AreEqual(expected, dayThree.housesDeliveredTo);
        }

        [TestMethod]
        public void Test_DeliverPresents_DeliversToTwoHouses_WhenGivenAUpDownUpDownSequenceOfCheverons()
        {
            //Arrange
            string input = "^v^v^v^v^v^v";
            int expected = 2;

            //Act
            dayThree.DeliverPresents(input);

            //Assert
            Assert.AreEqual(expected, dayThree.housesDeliveredTo);
        }

        [TestMethod]
        public void Test_DeliverPresentsWithRobot_DeliversToThreeHouses_WhenGivenAnUpAndADownCheveron()
        {
            //Arrange
            string input = "^v";
            int expected = 3;

            //Act
            dayThree.DeliverPresentsWithRobot(input);

            //Assert
            Assert.AreEqual(expected, dayThree.housesDeliveredTo);
        }

        [TestMethod]
        public void Test_DeliverPresentsWithRobot_DeliversToThreeHouses_WhenGivenALoopOfCheverons()
        {
            //Arrange
            string input = "^>v<";
            int expected = 3;

            //Act
            dayThree.DeliverPresentsWithRobot(input);

            //Assert
            Assert.AreEqual(expected, dayThree.housesDeliveredTo);
        }

        [TestMethod]
        public void Test_DeliverPresentsWithRobot_DeliversToElevenHouses_WhenGivenAUpDownUpDownSequenceOfCheverons()
        {
            //Arrange
            string input = "^v^v^v^v^v";
            int expected = 11;

            //Act
            dayThree.DeliverPresentsWithRobot(input);

            //Assert
            Assert.AreEqual(expected, dayThree.housesDeliveredTo);
        }
    }
}
