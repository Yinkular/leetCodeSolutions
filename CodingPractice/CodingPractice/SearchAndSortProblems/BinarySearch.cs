using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.SearchAndSortProblems
{
    public static class BinarySearch
    {
        public static int Search(int[] nums, int target)
        {
            if(nums.Length ==0)
            { return -1; }
            if(nums.Length ==1 && target == nums[0])
            { return 0; }
            else if(nums.Length == 1 && target != nums[0])
            { return -1; }

            int start = 0;
            int end = nums.Length-1;

            while(start<= end)
            {
                int mid = (start + end) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                else if( target < nums[mid])
                {
                    end = mid-1;
                }

                else if(target > nums[mid])
                {
                    start = mid+1;
                }
            }

            return -1;
        }

        public static int ReturnTargetIndex(int[] nums, int target)
        {
            int start = 0;
            int end = nums.Length - 1;

            while (start <= end)
            {
                int mid = (start + end) / 2;

                if (target == nums[mid])
                {
                    return mid;
                }

                else if (target < nums[mid])
                {
                    end = mid - 1;
                }

                else if (target > nums[mid])
                {
                    start = mid + 1;
                }
            }

            return start;
        }
    }
}
