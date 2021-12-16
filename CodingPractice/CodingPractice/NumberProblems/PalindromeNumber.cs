using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class PalindromeNumber
    {
        public static bool IsPalindromeNoString(int num)
        {
            if(num < 0)
            {
                return false;
            }
            else if(num >=0 && num <10 )
            {
                return true;
            }

            var reverseNumber = 0;
            var tempNumber = num;

            while(tempNumber > 0)
            {
                var mod = tempNumber % 10;

                reverseNumber = (reverseNumber * 10) + mod;

                tempNumber = tempNumber / 10;
            }

            if(reverseNumber == num)
            {
                return true;
            }

            return false;
        }
    }
}
