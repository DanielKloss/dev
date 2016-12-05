using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode16.Domain;
using System.IO;

namespace AdventOfCode16.Tests
{
    [TestClass]
    public class DayOneTests
    {
        [TestMethod]
        public void Test_Input_R5L5R5R3_Give12Blocks()
        {
            //Arrange
            int expected = 12;
            string[] input = { "R5, L5, R5, R3" };
            DayOne dayOne = new DayOne();

            //Act
            dayOne.FindHq(input);

            //Assert
            Assert.AreEqual(expected, dayOne.hqDistance);
        }

        [TestMethod]
        public void Test_Input_R8R4R4R8_Give4Blocks_WhenLookingForCoordinate()
        {
            //Arrange
            int expected = 4;
            string[] input = File.ReadAllLines(@"TestData/DayOneTestInput.txt");
            DayOne dayOne = new DayOne();

            //Act
            dayOne.FindHq(input);

            //Assert
            Assert.AreEqual(expected, dayOne.realHqDistance);
        }
    }
}
