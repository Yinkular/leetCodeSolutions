using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class MoveZeroes
    {
        public static void DoMoveZeroes(int[] nums)
        {
            if(nums.Length == 0 || nums.Length ==1)
            {
                return;
            }

            int lastZero = 0;

            for(int i=0;i<nums.Length;i++)
            {
                if(nums[i] !=0)
                {
                    var tmp = nums[i];
                    nums[i] = nums[lastZero];
                    nums[lastZero] = tmp;
                }

                if(nums[lastZero]!=0)
                {
                    lastZero++;
                }
            }
        }
    }
}
