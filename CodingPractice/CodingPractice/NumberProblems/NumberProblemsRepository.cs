using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingPractice.Helpers;
using CodingPractice.RealProblems;

namespace CodingPractice.NumberProblems
{
    public static class NumberProblemsRepository
    {
        private static int[] numArray = new int[] { 2, 7, 11, 15 };

        private static int[] numArray2 = new int[] { 3,3 };

        private static int[] numArray3 = new int[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 };

        private static int[] palindromeList = new int[] { 121, -121, 10, -101 };

        private static int number = 50;

        private static int[] sortedNumArray1 = new int[] {1,3,4,7};

        private static int[] sortedNumArray2 = new int[] {2, 3, 5, 6 };

        public static void InitAllNumberProblems()
        {
            //TwoSumIndices();
            //IsPalindromeNoString();
            //GetOddFactorial();
            //ExecuteRotateArray();
            //ExecutePascalTriangle();
            //ExecuteMedianSortedArrays(); 
            //ExecuteStringToInteger();
            ExecuteIntegerToROman();
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

        private static void GetOddFactorial()
        {
            var response = Factorial.GetOddFactorial(number);
            PrintHelper.Print(response);
        }

        private static void ExecuteRotateArray()
        {
            RotateArray.Rotate(sortedNumArray1, 3);
        }

        private static void ExecutePascalTriangle()
        {
            PascalsTriangle.Generate(5);
        }

        private static void ExecuteMedianSortedArrays()
        {
            MedianSortedArrays.FindMedianSortedArrays(new int[] { 1,2}, new int[] { 3,4 });
        }

        private static void ExecuteStringToInteger()
        {
            StringToInteger.MyAtoi("   -42");
        }

        private static void ExecuteIntegerToROman()
        {
            IntegerToRoman.IntToRoman(3);
        }
    }
}
