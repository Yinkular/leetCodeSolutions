using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.ListProblems
{
    public static class ListSum
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var root = new ListNode();
            var response = root;
            bool start = true;

            var queueForList1 = new Queue<int>();
            var stackFOrList2 = new Stack<int>();

            while(l1 != null || l2!=null)
            {
                if(l1 != null)
                {
                    queueForList1.Enqueue(l1.val);
                    l1 = l1.next;
                }

                if(l2 != null)
                {
                    stackFOrList2.Push(l2.val);
                    l2 = l2.next;
                }
            }

            int currentList1Number = 0;
            int currentList2Number = 0;
            int currentSum = 0;
            int remainder = 0;
            int div = 0;

            while(queueForList1.Count > 0 || stackFOrList2.Count>0 && remainder > 0)
            {
                currentList1Number = queueForList1.Count > 0 ? queueForList1.Dequeue() : 0;
                currentList2Number = stackFOrList2.Count>0 ? stackFOrList2.Pop() : 0;

                currentSum = currentList1Number + currentList2Number + remainder;

                var currentNode = new ListNode();

                if (currentSum > 10)
                {
                    div = currentSum / 10;
                    remainder = currentSum % 10;

                    currentNode.val = div;
                }
                else
                {
                    currentNode.val = currentSum;
                }
                
                if(start)
                {
                    response = currentNode;
                }
                else
                {
                    response.next = currentNode;
                }
            }

            return root;
        }

        private static ListNode AddTwoNumbersProper(ListNode l1, ListNode l2)
        {
            ListNode root = new ListNode();
            ListNode currentSumNode = root;

            int carry = 0;
            ListNode cl = l1;
            ListNode cr = l2;

            while (cl!=null || cr!=null)
            {
                int left = (cl != null) ? cl.val : 0;
                int right = (cr != null) ? cr.val : 0;

                int sum = left + right + carry;
                carry = sum / 10;
                currentSumNode.next = new ListNode(sum % 10);
                currentSumNode = currentSumNode.next;

                if(cl != null)
                {
                    cl = cl.next;
                }
                if(cr != null)
                {
                    cr = cr.next;
                }
            }

            if(carry>0)
            {
                currentSumNode.next = new ListNode(carry);
            }

            return root.next;
        }
    }
}
