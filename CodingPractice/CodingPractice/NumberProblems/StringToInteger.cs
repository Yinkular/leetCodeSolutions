using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class StringToInteger
    {
        public static int MyAtoi(string s)
        {
            int number = 0;

            if(s.Length == 0)
            {
                return number;
            }

            bool positive = true;
            bool readNumbers = false;

            foreach(char c in s)
            {
                int currentNumber = 0;
                if(c != ' ' && int.TryParse(c.ToString(), out currentNumber))
                {
                    if (number > int.MaxValue / 10 || (number == int.MaxValue / 10 && currentNumber > 7))
                    {
                        return positive ? int.MaxValue : int.MinValue;
                    }


                    number = number * 10 + currentNumber;
                    readNumbers = true;
                }
                else if (c != ' ' && c == '-')
                {
                    if(readNumbers== true)
                    {
                        break;
                    }
                    positive = false;
                    readNumbers = true;
                }
                else if (c != ' ' && c == '+')
                {
                    if (readNumbers == true)
                    {
                        break;
                    }
                    readNumbers = true;
                    continue;
                }
                else if(readNumbers && (c == ' ' || !int.TryParse(c.ToString(), out currentNumber)))
                {
                    break;
                }
                else if(c != ' ' && (!int.TryParse(c.ToString(), out currentNumber)))
                {
                    break;
                }
            }

            return positive ? number : (number * -1);
        }
    }
}
