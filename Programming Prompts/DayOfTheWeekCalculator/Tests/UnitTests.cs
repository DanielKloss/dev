using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DayOfTheWeekCalculator;

namespace Tests
{
    [TestClass]
    public class UnitTests
    {
        readonly Calculator _calculator = new Calculator();

        [TestMethod]
        public void ShouldReturnCorrectDayOfWeekWhenDateIsPassed()
        {
            var date = DateTime.Now;

            var expected = date.DayOfWeek.ToString();

            var result = _calculator.Calculate(date);

            Assert.AreEqual(expected, result);
        }
    }
}
