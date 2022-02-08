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
            var isDivisibleBy400 = (value % 400) == 0;
            if (isDivisibleBy400) 
                return true;
            
            var isDivisibleBy100 = (value % 100) == 0;
            if(isDivisibleBy100 && !isDivisibleBy400)
                return false;

            var isDivisibleBy4 = (value % 4) == 0;
            if (isDivisibleBy4 && !isDivisibleBy100)
                return true;
            
            return false;
        }
    }
}
