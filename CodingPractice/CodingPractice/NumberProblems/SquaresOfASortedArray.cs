using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class SquaresOfASortedArray
    {
        public static  int[] SortedSquares(int[] nums)
        {
            var arrLength = nums.Length;

            if(arrLength == 0)
            {
                return null;
            }

            int start = 0;
            int end = arrLength - 1;
            int[] responseArray = new int[arrLength];

            for(int i= arrLength-1; i>=0;i--)
            {
                if(Math.Abs(nums[start]) > Math.Abs(nums[end]))
                {
                    responseArray[i] = nums[start] * nums[start];
                    start++;
                }
                else
                {
                    responseArray[i] = nums[end] * nums[end];
                    end--;
                }
            }

            return responseArray;
        }
    }
}
