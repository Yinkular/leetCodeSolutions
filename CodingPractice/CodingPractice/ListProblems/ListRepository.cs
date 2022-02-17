using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingPractice.ListProblems
{
    public class ListRepository
    {
        private static ListNode listnode1;
        private static ListNode listnode2;

        private static void initListNodes()
        {
            var listnode1Copy = listnode1;
            listnode1Copy = new ListNode(2);
            listnode1Copy = listnode1Copy.next;
            listnode1.next = new ListNode(4);

        }

    }
}
