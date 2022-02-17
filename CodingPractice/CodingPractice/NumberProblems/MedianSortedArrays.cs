using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class MedianSortedArrays
    {
        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;

            bool odd = (nums1.Length + nums2.Length) % 2 == 1;

            var mid = (int)Math.Ceiling((decimal)(nums1.Length + nums2.Length) / 2);

            int left = 0, right = 0;
            int start = 0;

            int[] mergedarray = new int[nums1.Length + nums2.Length];

            while(left<nums1.Length ||  right<nums2.Length)
            {
                if(left < nums1.Length && right < nums2.Length)
                {
                    var currentleft = nums1[left];
                    var currentRight = nums2[right];

                    if(currentleft<currentRight)
                    {
                        mergedarray[start] = currentleft;
                        left++;
                    }
                    else
                    {
                        mergedarray[start] = currentRight;
                        right++;
                    }
                }
                else if(nums2.Length==right)
                {
                    mergedarray[start] = nums1[left];
                    left++;
                }
                else if (nums1.Length == left)
                {
                    mergedarray[start] = nums2[right];
                    right++;
                }

                start++;
            }

            if(odd)
            {
                median = (double)mergedarray[mid-1];
            }
            else
            {
                median = ((double)mergedarray[mid-1] + (double)mergedarray[mid]) / 2;
            }

            return median;

        }
    }
}
