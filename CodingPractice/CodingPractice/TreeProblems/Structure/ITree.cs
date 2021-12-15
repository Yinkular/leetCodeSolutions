using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TreeProblems
{
    public interface ITree
    {
        void BuildTree(List<int> treeElements);

        void PrintInOrder();

        int SumRange(int start, int end);

        bool TwoSum(int sum);
    }
}
