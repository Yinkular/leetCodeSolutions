using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class SortCharsByFrequency
    {
        public static string GetSortedString(string s)
        {
            if(s.Length == 1)
            {
                return s;
            }

            string sortedString = string.Empty;

            Dictionary<char, int> frequency = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if(!frequency.ContainsKey(s[i]))
                {
                    frequency[s[i]] = 0;
                }

                frequency[s[i]]++;
                
            }

            frequency = frequency.OrderByDescending(freq => freq.Value).ToDictionary(@char => @char.Key, fre => fre.Value);

            foreach( var key in frequency.Keys)
            {
                var freq = frequency[key];
                for (int i=0;i<freq;i++)
                {
                    sortedString += key;
                }
            }

            return sortedString;
        }
    }
}
