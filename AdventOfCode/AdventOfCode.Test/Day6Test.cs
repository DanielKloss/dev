using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode.Domain;
using System.Collections.Generic;

namespace AdventOfCode.Test
{
    [TestClass]
    public class Day6Test
    {
        Day6 daySix;

        [TestInitialize]
        public void Setup()
        {
            daySix = new Day6();
        }

        [TestMethod]
        public void Test_CreateGrid_CreatesAGridWith1000RowsAnd1000Columns()
        {
            //Arrange
            int expected = 1000;

            //Act
            daySix.CreateGrid();
            int rows = daySix.grid.Count();
            int columns = daySix.grid[0].Count();

            //Assert
            Assert.AreEqual(expected, columns);
            Assert.AreEqual(expected, rows);
        }

        [TestMethod]
        public void Test_TurnLightsOn_TurnsFourLightsOnWhenGiven00Through11()
        {
            //Arrange
            string startInput = "0,0";
            string endInput = "1,1";
            List<List<bool>> expected = daySix.CreateTestGrid();
            expected[0][0] = true;
            expected[0][1] = true;
            expected[1][0] = true;
            expected[1][1] = true;

            //Act
            daySix.TurnOnLights(startInput, endInput);

            //Assert
            Assert.AreEqual(expected, daySix.grid);
        }

        [TestMethod]
        public void Test_TurnLightsOff_TurnsFourLightsOffWhenGiven00Through11()
        {
            //Arrange
            string startInput = "0,0";
            string endInput = "1,1";
            List<List<bool>> expected = daySix.CreateTestGrid();

            //Act
            daySix.TurnOffLights(startInput, endInput);

            //Assert
            Assert.AreEqual(expected, daySix.grid);
        }

        [TestMethod]
        public void Test_ToggleLights_TurnsTogglesFourLightsWhenGiven00Through11()
        {
            //Arrange
            string startInput = "0,0";
            string endInput = "1,1";
            List<List<bool>> expected = daySix.CreateTestGrid();
            expected[0][0] = true;
            expected[0][1] = true;
            expected[1][0] = true;
            expected[1][1] = true;

            //Act
            daySix.ToggleLights(startInput, endInput);

            //Assert
            Assert.AreEqual(expected, daySix.grid);
        }

        [TestMethod]
        public void Test_SplitInput_SplitsInputIntoCommandAndCoordinatesWhenGivenTurnOnInput()
        {
            //Arrange
            string testInput = "turn on 461,550 through 564,900";
            List<string> expected = new List<string> { "turn on", "461,550", "through", "564,900" };

            //Act
            daySix.SplitInput(testInput);

            //Assert
            CollectionAssert.AreEqual(expected, daySix.splitList);
        }

        [TestMethod]
        public void Test_SplitInput_SplitsInputIntoCommandAndCoordinatesWhenGivenToggleInput()
        {
            //Arrange
            string testInput = "toggle 461,550 through 564,900";
            List<string> expected = new List<string> { "toggle", "461,550", "through", "564,900" };

            //Act
            daySix.SplitInput(testInput);

            //Assert
            CollectionAssert.AreEqual(expected, daySix.splitList);
        }
    }
}
