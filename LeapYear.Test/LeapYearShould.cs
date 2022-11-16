using FluentAssertions;
using NUnit.Framework;

namespace LeapYear.Test {
    public class LeapYearShould {

        /*All years divisible by 400 ARE leap years (so, for example, 2000 was indeed a leap year),
        All years divisible by 100 but not by 400 are NOT leap years (so, for example, 1700, 1800, and 1900 were NOT leap years, NOR will 2100 be a leap year),
        All years divisible by 4 but not by 100 ARE leap years (e.g., 2008, 2012, 2016),
        All years not divisible by 4 are NOT leap years (e.g. 2017, 2018, 2019).*/

        [Test]
        public void say_that_400_is_leap_year() {
            var year = 400;

            var isLeapYear = LeapYear.IsLeap(year);

            isLeapYear.Should().BeTrue();
        }

        [Test]
        public void say_that_2000_is_leap_year() {
            var year = 2000;

            var isLeapYear = LeapYear.IsLeap(year);

            isLeapYear.Should().BeTrue();
        }

        [Test]
        public void say_that_1700_is_not_leap_year() {
            var year = 1700;

            var isLeapYear = LeapYear.IsLeap(year);

            isLeapYear.Should().BeFalse();
        }

    }
}