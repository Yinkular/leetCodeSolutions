using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class StringProblemsRepository
    {
        public static void InitAllStringProblems()
        {
            CallFirstUniqChar();
            CallSortedStringByFrequency();
        }

        private static void CallFirstUniqChar()
        {
            List<string> words = new List<string>()
            {
                "olayinka",
                "leet",
                "omarion"
            };

            foreach (var word in words)
            {
                var response = FirstUniqueCharacter.GetFirstUniqChar(word);
                Console.WriteLine(response);
            }
        }

        private static void CallSortedStringByFrequency()
        {
            List<string> words = new List<string>()
            {
                "mootaMM",
            };

            foreach (var word in words)
            {
                var response = SortCharsByFrequency.GetSortedString(word);
                Console.WriteLine(response);
            }
        }
    }
}
