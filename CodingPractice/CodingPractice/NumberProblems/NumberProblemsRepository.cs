using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.Helpers;

namespace CodingPractice.NumberProblems
{
    public static class NumberProblemsRepository
    {
        private static int[] numArray = new int[] { 2, 7, 11, 15 };

        private static int[] numArray2 = new int[] { 3,3 };

        private static int[] numArray3 = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };

        private static int[] palindromeList = new int[] { 121, -121, 10, -101 };

        public static void InitAllNumberProblems()
        {
            //TwoSumIndices();
            IsPalindromeNoString();
        }

        private static void TwoSumIndices()
        {
            //var response = TwoSum.TwoSumIndices(numArray, 9);
            //PrintHelper.Print(response);

            var response = TwoSum.TwoSumIndices(numArray3, 11);
            PrintHelper.Print(response);
        }

        private static void IsPalindromeNoString()
        {
            foreach (var number in palindromeList)
            {
                var isPalindrome = PalindromeNumber.IsPalindromeNoString(number);
                Console.WriteLine(number + " " + isPalindrome);
            }
        }
    }
}
