using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class LongestSubstring
    {
        public static int LengthOfLongestSubstring(string s)
        {
            if(s.Length ==0)
            {
                return 0;
            }

            int currentMax = 0,
                i=0,
                j=0;

            HashSet<char> set = new HashSet<char>();

            while(j< s.Length)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    currentMax = Math.Max(currentMax, j - i);
                }
                else
                    set.Remove(s[i++]);
            }

            return currentMax;
        }

        // add chars to a map with index,
        // if character is found again increase start point to next index
        /**
         * public int lengthOfLongestSubstring(String s) {
        
        Map<Character, Integer> map= new HashMap<>();
        int start=0, len=0;
        
        // abba
        for(int i=0; i<s.length(); i++) {
            char c = s.charAt(i);
            if (map.containsKey(c)) {
                if (map.get(c) >= start) 
                    start = map.get(c) + 1;
            }
            len = Math.max(len, i-start+1);
            map.put(c, i);
        }
        
        return len;
    }
         * */
    }
}
