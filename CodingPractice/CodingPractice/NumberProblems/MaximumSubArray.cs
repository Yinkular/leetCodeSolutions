using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class MaximumSubArray
    {
        public static int MaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;

            for(int i=0;i< nums.Length;i++)
            {
                sum += nums[i];
                max = Math.Max(sum, max);

               sum =  sum <= 0 ?  0 : sum;
            }

            return max;
        }

        public static int GetIndexOfMaxSubArray(int[] nums)
        {
            int max = int.MinValue;
            int sum = 0;
            int start = 0;
            int prevStart = 0;
            int end = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

                if(sum > max)
                {
                    max = sum;
                    start = prevStart;
                    end = i;
                }

                if(sum<0)
                {
                    sum = 0;
                    prevStart = i + 1;
                }
            }

            return max;
        }
    }
}
