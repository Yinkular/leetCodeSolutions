using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.TreeProblems
{

    public static class TreeRepository
    {
        private static List<int> randomInts = new List<int>()
        {
            10,11,7,9,15,8,12
        };

        public static void InitTrees()
        {
            InitBT();
            InitBST();
        }

        public static void InitAllTreeProblems()
        {
            SumRangeBST();
            TwoSumBST();
        }

        private static void InitBT()
        {
            var BT = new BinaryTree();
            BT.BuildTree(randomInts);

            Console.WriteLine("==============");
            Console.WriteLine("BT InOrder");
            BT.PrintInOrder();
        }

        private static void InitBST()
        {
            var BST = new BinarySearchTree();
            BST.BuildTree(randomInts);

            Console.WriteLine("\n==============");
            Console.WriteLine("BST InOrder");
            BST.PrintInOrder();
        }

        private static void SumRangeBST()
        {
            var BST = new BinarySearchTree();
            BST.BuildTree(randomInts);

            var range = BST.SumRange(8, 12);
            Console.WriteLine("\nSum Range - " + range);
        }

        private static void TwoSumBST()
        {
            var BST = new BinarySearchTree();
            BST.BuildTree(randomInts);

            Console.WriteLine("\nSum 0f 10 present - " + BST.TwoSum(10));
            Console.WriteLine("\nSum 0f 20 present - " + BST.TwoSum(20));
        }
    }
}
