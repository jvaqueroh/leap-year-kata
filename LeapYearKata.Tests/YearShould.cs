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
        [TestCase(400)]
        [TestCase(800)]
        [TestCase(2000)]
        [TestCase(2400)]
        public void return_true_is_divisible_by_400(int value)
        {
            var year1 = new Year(value);
            Assert.IsTrue(year1.IsLeapYear());
        }

        [TestCase(100)]
        [TestCase(1300)]
        [TestCase(2100)]
        [TestCase(2200)]
        public void return_false_if_divisible_by_100_nor_by_400(int value)
        {
            var year1 = new Year(value);
            Assert.IsFalse(year1.IsLeapYear());
        }

        [TestCase(4)]
        [TestCase(8)]
        [TestCase(2004)]
        [TestCase(2024)]
        public void return_true_if_divisible_by_4_nor_by_100(int value)
        {
            var year1 = new Year(value);
            Assert.IsTrue(year1.IsLeapYear());
        }

        [TestCase(5)]
        [TestCase(2001)]
        [TestCase(2021)]
        [TestCase(2023)]
        public void return_false_if_not_divisible_by_4(int value)
        {
            var year1 = new Year(value);
            Assert.IsFalse(year1.IsLeapYear());
        }
    }
}
