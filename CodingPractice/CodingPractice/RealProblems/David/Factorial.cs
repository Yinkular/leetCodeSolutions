using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.RealProblems
{
    public static class Factorial
    {
        public static List<UInt64> GetOddFactorial(int num)
        {
            var response = new List<UInt64>();

            for (int i = 0; i <= num;i++)
            {
                if (i % 2 != 0)
                {
                    response.Add(GetNumFactorialIterative(i));
                }
            }

            return response;
        }

        private static UInt64 GetNumFactorialIterative(int num)
        {
            UInt64 factorial = 1;

            if( num == 0 || num == 1)
            {
                return factorial;
            }

            for(int i= num;i>0;i--)
            {
                factorial *= (UInt64)i;
            }

            return factorial;
        }

        private static List<int> GetNumFactorialPreComputed(int num)
        {
            var response = new List<int>();

            for(int i=0;i<=num;i++)
            {
                if(i==0 || i==1)
                {
                    response.Add(1);
                }
                else
                {
                    response.Add(num * response[i - 1]);
                }
            }

            return response;
        }
    }
}
