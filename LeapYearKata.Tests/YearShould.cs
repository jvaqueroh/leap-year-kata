using System;
using NUnit.Framework;

namespace LeapYearKata.Tests {
    /// <summary>
    /// Returns if a given Year is a leap year or not
    ///   Year that is divisible by 400 IS a leap year
    ///   Year that is divisible by 100 but not by 400 IS NOT a leap year
    ///   Year that is divisible by 4 but not by 100 IS a leap year
    ///   Year that is not divisible by 4 IS NOT a leap year
    /// </summary>
    public class YearShould {
        [Test]
        public void returns_true_for_400()
        {
            var year = new Year(400);
            var result = year.IsLeapYear();
            Assert.IsTrue(result);
        }

        [Test]
        public void returns_true_for_800()
        {
            var year = new Year(800);
            var result = year.IsLeapYear();
            Assert.IsTrue(result);
        }

        [Test]
        public void returns_false_for_401()
        {
            var year = new Year(401);
            var result = year.IsLeapYear();
            Assert.IsFalse(result);
        }
    }
}
