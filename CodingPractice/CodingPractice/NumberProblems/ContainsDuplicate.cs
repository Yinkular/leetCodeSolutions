using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class ContainsDuplicate
    {
        public static bool ContainsDuplicateMethod(int[] nums)
        {
            if(nums.Length == 0 || nums.Length ==1)
            {
                return false;
            }

            HashSet<int> numbers = new HashSet<int>();

            foreach(var num in nums)
            {
                if(!numbers.Add(num))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
