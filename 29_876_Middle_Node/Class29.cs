using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29_876_Middle_Node
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
            
        }   

        public static ListNode MiddleNode(ListNode head)
        {
            ListNode faster = head; // head as slow runner
            while (faster != null && faster.next != null)
            {
                faster = faster.next.next;
                head = head.next;
            }
            return head;
        }
        public static void Main(string[] args)
        {
            ListNode list = new ListNode();

            ListNode result = MiddleNode(list);
        }
    }
}
