using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class FirstUniqueCharacter
    {
        public static int GetFirstUniqChar(string s)
        {
            if(string.IsNullOrEmpty(s))
            {
                return -1;
            }

            if(s.Length == 1)
            {
                return 0;
            }

            int[] strChars = new int[128];

            for (int i = 0; i < s.Length; i++)
            {
                strChars[s[i]]++;
            }

            for(int i=0;i < s.Length; i++)
            {
                if(strChars[s[i]] == 1)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
