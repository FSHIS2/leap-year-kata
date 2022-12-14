using FluentAssertions;
using NUnit.Framework;

namespace LeapYear.Test {
    public class LeapYearShould {

        /*All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
        All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
        All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
        All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).*/

        [TestCase(400)]
        [TestCase(2000)]
        [TestCase(2008)]
        [TestCase(2012)]
        [TestCase(2016)]
        public void say_that_are_leap_years(int input) {
            var year = input;

            var isLeapYear = LeapYear.IsLeap(year);

            isLeapYear.Should().BeTrue();
        }

        [TestCase(1700)]
        [TestCase(1800)]
        [TestCase(1900)]
        [TestCase(2017)]
        [TestCase(2018)]
        [TestCase(2019)]
        [TestCase(2100)]
        public void say_that_are_not_leap_years(int input) {
            var year = input;

            var isLeapYear = LeapYear.IsLeap(year);

            isLeapYear.Should().BeFalse();
        }

    }
}