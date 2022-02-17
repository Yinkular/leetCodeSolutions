using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class IntegerToRoman
    {
        public static string IntToRoman(int num)
        {
            string romanConversion = string.Empty;

            if(num ==0)
            {
                return romanConversion;
            }

            List<int> numbers = new List<int>() { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            List<string> romanRepresentation = new List<string>()
            {
                "M","CM","D","CD","C","XC","L","XL","X","IX","V","IV","I"
            };

            for(int i=0;i< numbers.Count && num >0;i++)
            {
                while(numbers[i] <= num)
                {
                    num -= numbers[i];
                    romanConversion += romanRepresentation[i];
                }
            }

            return romanConversion;

        }
    }
}
