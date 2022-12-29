using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72_206_Reverse_List
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

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;

            ListNode prev = null;
            ListNode next = head.next;
            while (next != null)
            {
                head.next = prev;
                prev = head;
                head = next;
                next = head.next;
            }
            head.next = prev;
            return head;
        }

        public static void Main(string[] args)
        {
            ListNode re = new ListNode();
            re.val = 1;
            ListNode result = ReverseList(re);

        }
    }
}
