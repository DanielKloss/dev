using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode16.Domain;
using System.IO;

namespace AdventOfCode16.Tests
{
    [TestClass]
    public class DayTwoTests
    {
        [TestMethod]
        public void Test_Input_ReturnsCode1985()
        {
            //Arrange
            string expected = "1985";
            string[] input = File.ReadAllLines(@"DayTwoTestData.txt");
            DayTwo dayTwo = new DayTwo();

            //Act
            string actual = dayTwo.FindToiletCode(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
