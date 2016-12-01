using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode16.Domain;

namespace AdventOfCode16.Tests
{
    [TestClass]
    public class DayOneTests
    {
        [TestMethod]
        public void Test_Input_R2L3_Give5Blocks()
        {
            //Arrange
            int expected = 5;
            string input = "R2, L3";
            DayOne dayOne = new DayOne();

            //Act
            int actual = dayOne.FindHqDistance(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void Test_Input_R2R2R2_Give2Blocks()
        {
            //Arrange
            int expected = 2;
            string input = "R2, R2, R2";
            DayOne dayOne = new DayOne();

            //Act
            int actual = dayOne.FindHqDistance(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Input_R5L5R5R3_Give12Blocks()
        {
            //Arrange
            int expected = 12;
            string input = "R5, L5, R5, R3";
            DayOne dayOne = new DayOne();

            //Act
            int actual = dayOne.FindHqDistance(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
