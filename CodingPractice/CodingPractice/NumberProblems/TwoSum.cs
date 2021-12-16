using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class TwoSum
    {
        public static int[] TwoSumIndices(int[] nums, int target)
        {
            int[] arrResponse = new int[2];

            int length = nums.Length;

            if(length == 0)
            {
                return arrResponse;
            }

            Dictionary<int, int> numAndIndex = new Dictionary<int, int>();

            for(int i=0;i<length;i++)
            {
                var num = nums[i];
                var diff = target - num;
                if(numAndIndex.ContainsKey(diff))
                {
                    arrResponse = new int[] { i, numAndIndex[diff] };
                    return arrResponse;
                }
                else if(!numAndIndex.ContainsKey(num))
                {
                    numAndIndex.Add(num, i);
                }
            }

            return arrResponse;
        }

        public static int[] TwoSimIndicesSorted(int[] nums, int target)
        {
            int[] arrResponse = new int[2];

            int length = nums.Length;

            if (length == 0)
            {
                return arrResponse;
            }

            int start = 0;
            int end = length-1;

            while(start<end)
            {
                if(nums[start] + nums[end] == target)
                {
                    return new int[] { start + 1, end + 1 };
                }
                
                if(nums[start] + nums[end] < target)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return new int[] { start + 1, end + 1 };
        }
    }
}
