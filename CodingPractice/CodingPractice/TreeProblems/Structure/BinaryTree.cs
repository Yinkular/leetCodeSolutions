using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TreeProblems
{
    public class BinaryTree : Tree
    {
        public BinaryTree()
        {
            this.Root = null;
        }

        public override void BuildTree(List<int> treeElements)
        {
            for(int i=0;i< treeElements.Count;i++)
            {
                AuxBuildTree(ref this.Root, treeElements[i]);
            }
        }

        private void AuxBuildTree(ref TreeNode node, int val)
        {
            if(node == null)
            {
                node = new TreeNode(val);
                return;
            }

            Queue<TreeNode> q = new Queue<TreeNode>();
            q.Enqueue(node);
            TreeNode current;


            while(q.Count != 0)
            {
                current = q.Peek();
                q.Dequeue();

                if(current.left == null)
                {
                    current.left = new TreeNode(val);
                    break;
                }
                else
                {
                    q.Enqueue(current.left);
                }

                if (current.right == null)
                {
                    current.right = new TreeNode(val);
                    break;
                }
                else
                {
                    q.Enqueue(current.right);
                }
            }
        }
    }
}
