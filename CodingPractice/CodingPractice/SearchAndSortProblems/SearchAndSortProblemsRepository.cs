using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.SearchAndSortProblems
{
    public static class SearchAndSortProblemsRepository
    {
        private static int[] numArray = new int[] { -1,0,3,5,9,12 };

        public static void InitAllProblems()
        {
            ExecuteBinarySearch();
        }

        private static void ExecuteBinarySearch()
        {
            var response = BinarySearch.Search(numArray, 2);
            Console.WriteLine(response);
        }

    }
}
