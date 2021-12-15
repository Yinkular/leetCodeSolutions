using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TreeProblems
{
    public class BinarySearchTree : Tree
    {
        public BinarySearchTree()
        {
            this.Root = null;
        }

        public override void BuildTree(List<int> treeElements)
        {
            foreach(var element in treeElements)
            {
                this.AuxBuildTree(ref this.Root, element);
            }
        }

        public override int SumRange(int start, int end)
        {
            return DoSumRange(this.Root, start, end);
        }

        public override bool TwoSum(int sum)
        {
            return DoTwoSUm(this.Root, sum);
        }

        private void AuxBuildTree(ref TreeNode node, int val)
        {
            if(node == null)
            {
                node = new TreeNode(val);
            }
            else if(val > node.val)
            {
                AuxBuildTree(ref node.right, val);
            }
            else 
            {
                AuxBuildTree(ref node.left, val);
            }
        }

        private int DoSumRange(TreeNode node, int start, int end)
        {
            int sum = 0;

            if(node == null)
            {
                return 0;
            }
            
            if(node.val >= start && node.val <= end)
            {
                sum+= node.val;
            }


            sum+=DoSumRange(node.left, start, end);
            sum+=DoSumRange(node.right, start, end);


            return sum;
        }

        private bool DoTwoSUm(TreeNode root, int sum)
        {
            if(root == null)
            {
                return false;
            }

            HashSet<int> diff = new HashSet<int>();

            Queue<TreeNode> qnode = new Queue<TreeNode>();
            qnode.Enqueue(root);
            TreeNode currentNode;

            while(qnode.Count != 0)
            {
                currentNode = qnode.Peek();

                if(diff.Contains(currentNode.val))
                {
                    return true;
                }

                int diffVal = sum - currentNode.val;
                if(!diff.Contains(diffVal))
                {
                    diff.Add(diffVal);
                }

                if(currentNode.left!=null)
                {
                    qnode.Enqueue(currentNode.left);
                }
                if (currentNode.right != null)
                {
                    qnode.Enqueue(currentNode.right);
                }

                qnode.Dequeue();
            }


            return false;
        }
    }
}
