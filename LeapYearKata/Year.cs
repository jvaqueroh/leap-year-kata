using System;

namespace LeapYearKata {
    public class Year {
        private readonly int value;

        public Year(int value)
        {
            this.value = value;
        }

        public bool IsLeapYear()
        {
            var module = value % 400;
            return module == 0;
        }
    }
}
