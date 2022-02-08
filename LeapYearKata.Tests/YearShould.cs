using System;
using System.Collections;
using NUnit.Framework;

namespace LeapYearKata.Tests {
    /// <summary>
    /// Returns if a given Year is a leap year or not
    ///   Year that is divisible by 400 IS a leap year
    ///   Year that is divisible by 100 but not by 400 IS NOT a leap year
    ///   Year that is divisible by 4 but not by 100 IS a leap year
    ///   Year that is not divisible by 4 IS NOT a leap year
    /// </summary>
    [TestFixtureSource(typeof(LeapYearsFixtureData), nameof(LeapYearsFixtureData.FixtureParams))]
    public class YearShould {
        private readonly Year year;
        private readonly bool isLeapYear;

        public YearShould(int year, bool isLeapYear)
        {
            this.year = new Year(year);
            this.isLeapYear = isLeapYear;
        }

        [Test]
        public void check_is_leap_year()
        {
            var result = year.IsLeapYear();
            Assert.AreEqual(isLeapYear, result);
        }
    }

    public class LeapYearsFixtureData
    {
        public static IEnumerable FixtureParams
        {
            get
            {
                ///   Year that is divisible by 400 IS a leap year
                yield return new TestFixtureData(400, true);
                yield return new TestFixtureData(800, true);
                yield return new TestFixtureData(401, false);

                ///   Year that is divisible by 100 but not by 400 IS NOT a leap year
                yield return new TestFixtureData(100, false);
                yield return new TestFixtureData(300, false);

                ///   Year that is divisible by 4 but not by 100 IS a leap year
                yield return new TestFixtureData(4, true);
                
                ///   Year that is not divisible by 4 IS NOT a leap year
            }
        }
    }
}
