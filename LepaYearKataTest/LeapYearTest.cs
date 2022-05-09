using LeapYearKata;
using NUnit.Framework;

namespace LeapYearKataTest
{
    public class Tests
    {
        [TestCase(400)]
        [TestCase(800)]
        [TestCase(1200)]
        [TestCase(1600)]
        [TestCase(2000)]
        [TestCase(2400)]
        public void when_year_is_400_multiple_return_leap_year_true(int year)
        {
            var result = LeapYear.CheckLeapYear(year);

            Assert.IsTrue(result);
        }

        [TestCase(96)]
        [TestCase(104)]
        [TestCase(108)]
        public void when_year_is_4_multiple_and_not_100_multiple_leap_year_is_true(int year)
        {
            var result = LeapYear.CheckLeapYear(year);

            Assert.IsTrue(result);
        }

        [TestCase(100)]
        [TestCase(200)]
        [TestCase(300)]
        [TestCase(1900)]
        [TestCase(2100)]
        public void when_year_is_4_multiple_and_100_multiple_leap_year_is_false(int year)
        {
            var result = LeapYear.CheckLeapYear(year);

            Assert.IsFalse(result);
        }
    }
}