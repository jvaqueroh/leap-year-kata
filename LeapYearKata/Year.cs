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
            if ((value % 400) == 0) 
                return true;
            if((value % 100) == 0)
                return false;
            return (value % 4) == 0;
        }
    }
}
