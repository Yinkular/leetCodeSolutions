using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class ReverseString
    {
        public static void ReverseArrayString(char[] s)
        {
            if(s.Length == 0 || s.Length == 1)
            {
                return;
            }

            int start = 0;
            int end = s.Length - 1;

            while(start < end)
            {
                char tmp = s[start];
                s[start] = s[end];
                s[end] = tmp;

                start++;
                end--;
            }
        }

        public static string ReverseWordsInASentence(string s)
        {
            var response = new StringBuilder();

            var currentWord = string.Empty;
            for (int i=0;i< s.Length;i++)
            {
                var currentChar = s[i].ToString();

                if(string.IsNullOrEmpty(currentChar))
                {
                    var reversedString = ReverseStringActualString(currentWord);

                    response.Append(reversedString);
                    response.Append(" ");

                    currentWord = string.Empty;
                }
                else
                {
                    currentWord += currentChar;
                }
            }

            var lastReversedString = ReverseStringActualString(currentWord);
            response.Append(lastReversedString);

            return response.ToString().TrimEnd();
        }

        private static string ReverseStringActualString(string s)
        {
            var response = string.Empty;

            if(s.Length==0)
            {
                return response;
            }
            if(s.Length ==1)
            {
                return s;
            }

            int start = 0;
            int end = s.Length - 1;

            StringBuilder outputString = new StringBuilder(s);

            while (start < end)
            {
                char tmp = outputString[start];
                outputString[start] = outputString[end];
                outputString[end] = tmp;

                start++;
                end--;
            }

            return outputString.ToString();
        }
    }
}
