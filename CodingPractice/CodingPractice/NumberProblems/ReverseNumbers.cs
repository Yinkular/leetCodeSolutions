using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class ReverseNumbers
    {
        public static int ReverseSignedInt(int x)
        {
            int reversedInt = 0;
            bool isNegative = false;

            if(x < 0)
            {
                isNegative = true;
                x = x * -1;
            }

            while (x > 0)
            {
                int mod = x % 10;
                x = x / 10;

                if( reversedInt > int.MaxValue/10 || (reversedInt == int.MaxValue/10 && mod > 7)
                    || (-1 * reversedInt) < int.MinValue/10 || ((-1 * reversedInt) == int.MinValue/10 && mod < -8))
                {
                    return 0;
                }

                reversedInt = (reversedInt * 10) + mod;
            }

            if(isNegative)
            {
                reversedInt *= -1;
            }

            return reversedInt;
        }
    }
}
