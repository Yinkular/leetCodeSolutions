using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class RotateArray
    {
        public static void Rotate(int[] nums, int k)
        {
            int length = nums.Length;

            if(length == 0)
            {
                return;
            }

            int zeroIndexLenth = length - 1;
            int[] rotatedArray = new int[length];

            for(int i=0;i<length;i++)
            {
                var newPosition = (i + k) % length;
                rotatedArray[newPosition] = nums[i];
            }

            for (int i = 0; i < length; i++)
            {
                nums[i] = rotatedArray[i];
            }
        }
    }
}
