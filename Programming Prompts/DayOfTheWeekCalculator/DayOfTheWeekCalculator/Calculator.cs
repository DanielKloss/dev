using System;
using System.Collections.Generic;

namespace DayOfTheWeekCalculator
{
    public class Calculator
    {
        private readonly List<string> _daysOfTheWeek = new List<string>
            {
                "Sunday",
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };
        private readonly List<int> _daysInMonths = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public string Calculate(DateTime date)
        {
            var year = date.Year;
            var month = date.Month;
            var day = date.Day;

            var yearsSince = year - 1900;

            var result = yearsSince * 365 + (yearsSince / 4);

            if (month < 3 && YearIsLeapYear(year))
            {
                result--;
            }

            for (var i = 1; i < month; i++)
            {
                result += _daysInMonths[i - 1];
            }

            result += day;

            var dayOfTheWeek = result % 7;

            return _daysOfTheWeek[dayOfTheWeek];
        }

        private static bool YearIsLeapYear(int year)
        {
            if (year % 4 != 0)
            {
                return false;
            }

            if (year % 100 != 0)
            {
                return true;
            }

            if (year % 400 != 0)
            {
                return false;
            }

            return true;
        }
    }
}
