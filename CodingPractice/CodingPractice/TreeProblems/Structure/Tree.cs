using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TreeProblems
{
    public class Tree : ITree
    {
        public TreeNode Root;

        public int Length { get; set; }

        public virtual void BuildTree(List<int> treeElements)
        {
        }

        public virtual int SumRange(int start, int end)
        {
            return 0;
        }

        public void PrintInOrder()
        {
            DoPrintInOrder(this.Root);
        }

        private void DoPrintInOrder(TreeNode node)
        {
            if(node == null)
            {
                return;
            }
            else
            {
                DoPrintInOrder(node.left);
                Console.Write(node.val + " ");
                DoPrintInOrder(node.right);
            }
        }

        public virtual bool TwoSum(int sum)
        {
            return false;
        }
    }
}
