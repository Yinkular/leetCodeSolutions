using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class MergeSortedArray
    {
        public static  void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int leftEnd = m - 1;
            int rightEnd = n - 1;
            int mergedEnd = m + n - 1;

            while(leftEnd>=0 && rightEnd>=0)
            {
                if (nums1[leftEnd] > nums2[rightEnd])
                {
                    nums1[mergedEnd] = nums1[leftEnd];
                    leftEnd--;
                }
                else
                {
                    nums1[mergedEnd] = nums2[rightEnd];
                    rightEnd--;
                }

                mergedEnd--;
            }

            // catch case where elements are still in right array
            // where all of left greater than right
            while(rightEnd>=0)
            {
                nums1[mergedEnd] = nums2[rightEnd];
                mergedEnd--;
                rightEnd--;
            }
        }
    }
}
