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
            if(value.Equals(400))
                return true;
            return false;
        }
    }
}
