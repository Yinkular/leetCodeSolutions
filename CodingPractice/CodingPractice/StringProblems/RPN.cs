using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.StringProblems
{
    public static class RPN
    {
        public static int EvalRPN(string[] tokens)
        {
            Stack<int> stack = new Stack<int>();

            foreach (string token in tokens)
            {
                int number = 0;

                if(int.TryParse(token, out number))
                {
                    stack.Push(number);
                }
                else
                {
                    int rightSide = stack.Peek();
                    stack.Pop();
                    int leftSide = stack.Peek();
                    stack.Pop();

                    if(token =="+")
                    {
                        stack.Push(leftSide + rightSide);
                    }
                    else if(token =="-")
                    {
                        stack.Push(leftSide- rightSide);
                    }
                    else if (token == "*")
                    {
                        stack.Push(leftSide * rightSide);
                    }
                    else if (token == "/")
                    {
                        stack.Push(leftSide / rightSide);
                    }
                }
            }

            int result = stack.Peek();
            return result;
        }
    }
}
