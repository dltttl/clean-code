using System;
using System.Collections.Generic;

namespace ControlDigit
{
    public static class UpcExtensions
    {
        public static int CalculateUpc(this long number)
        {
            var sum = 0;
            var position = 0;

            var digit = 0;
            while (number > 0)
            { 
                digit = (int) (number % 10);
                sum += position % 2 == 0 ? digit * 3 : digit;
                position++;
                number /= 10;
            }

            sum %= 10;

            return sum == 0 ? 0 : 10 - sum;
        }

       
    }
}
