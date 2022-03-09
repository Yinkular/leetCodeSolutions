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
            //CallFirstUniqChar();
            //CallSortedStringByFrequency();
            //CallReverseString();

            //JustifyText();

            CallRPN();
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

        private static void CallReverseString()
        {
            string s = "Let's take LeetCode contest";

            ReverseString.ReverseWordsInASentence(s);
        }

        private static void JustifyText()
        {
            string[] words = new string[] { "This", "is", "an", "example", "of", "text", "justification."};
            string[] words2 = new string[] { "What", "must", "be", "acknowledgment", "shall", "be" };

            TextJustification.FullJustify(words, 16);
        }

        private static void CallRPN()
        {
            string[] token1 = new string[] { "2", "1", "+", "3", "*" };
            string[] token2 = new string[] { "4", "13", "5", "/", "+" };
            string[] token3 = new string[] { "10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+" };

            RPN.EvalRPN(token3);
        }
    }
}
