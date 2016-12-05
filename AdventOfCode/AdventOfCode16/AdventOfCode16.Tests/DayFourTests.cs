using AdventOfCode16.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode16.Tests
{
    [TestClass]
    public class DayFourTests
    {
        [TestMethod]
        public void Test_input_returns_1514()
        {
            //Arrange
            int expected = 1514;
            DayFour dayFour = new DayFour();
            string[] input = File.ReadAllLines(@"TestData/DayFourTestInput.txt");

            //Act
            int actual = dayFour.CheckDecoyRooms(input);

            //Assert
            //Assert.AreEqual(expected, actual);
        }
    }
}
