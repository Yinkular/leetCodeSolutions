using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class ArrayIntersect
    {
        public static int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> numberFrequency = new Dictionary<int, int>();
            int left = 0;
            int right = 0;
            int leftLength = nums1.Length;
            int rightLength = nums2.Length;

            List<int> response = new List<int>();

            for(int i=0;i<leftLength;i++)
            {
                if(!numberFrequency.ContainsKey(nums1[i]))
                {
                    numberFrequency.Add(nums1[i],0);
                }

                numberFrequency[nums1[i]]++;
            }

            for(int i=0;i<rightLength;i++)
            {
                if(numberFrequency.ContainsKey(nums2[i]))
                {
                    int freq = numberFrequency[nums2[i]];
                    if(freq>0)
                    {
                        response.Add(nums2[i]);

                        numberFrequency[nums2[i]]--;
                    }
                }
            }

            return response.ToArray();
        }
    }
}
