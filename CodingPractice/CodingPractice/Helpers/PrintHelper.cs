using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.Helpers
{
    public static class PrintHelper
    {
        public static void Print(int[] nums)
        {
            foreach(var num in nums)
            {
                Console.Write(num+ " ");
            }
            Console.WriteLine("\n==============\n");
        }

        public static void Print(List<int> nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============\n");
        }

        public static void Print(List<UInt64> nums)
        {
            foreach (var num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("\n==============\n");
        }
    }
}
