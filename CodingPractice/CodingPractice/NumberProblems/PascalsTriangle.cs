using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.NumberProblems
{
    public static class PascalsTriangle
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            List<int>[] response = new List<int>[numRows];

             for (int i=0;i<numRows;i++)
             {
                var currentList = new List<int>((i+1));
                if(i==0)
                {
                    currentList.Add(1);
                }
                else
                {
                    currentList.Add(1);

                    for(int j=1;j<i;j++)
                    {
                        currentList.Add(response[i - 1][j - 1] + response[i - 1][j]);
                    }

                    currentList.Add(1);
                }
                response[i] = currentList;
             }

            return response;
        }
    }
}
