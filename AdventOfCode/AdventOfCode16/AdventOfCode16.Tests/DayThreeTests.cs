using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode16.Domain;
using System.IO;

namespace AdventOfCode16.Tests
{
    [TestClass]
    public class DayThreeTests
    {
        [TestMethod]
        public void Test_FindsThreePossibleTriangles_ReadingHorizontally()
        {
            //Arrange
            int expected = 3;
            string[] input = File.ReadAllLines(@"TestData/DayThreeTestData.txt");
            DayThree dayThree = new DayThree();

            //Act
            int actual = dayThree.CheckTriangles(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_FindsSixPossibleTriangles_ReadingVertically()
        {
            //Arrange
            int expected = 6;
            string[] input = File.ReadAllLines(@"TestData/DayThreeTestData.txt");
            DayThree dayThree = new DayThree();

            //Act
            int actual = dayThree.CheckTrianglesVertically(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
