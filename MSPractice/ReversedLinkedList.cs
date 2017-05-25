using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class ReversedLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode ReverseList(ListNode head) // iterative
        {
            ListNode revList = null;
            while (head != null)
            {
                ListNode temp = head.next;
                head.next = revList;
                revList = head;
                head = temp;
            }
            return revList;
        }
        public ListNode reverseList(ListNode head)
        {
            return reverseListInt(head, null);
        }

        private ListNode reverseListInt(ListNode head, ListNode newHead)
        {
            if (head == null)
                return newHead;
            ListNode next = head.next;
            head.next = newHead;
            return reverseListInt(next, head);
        }
    }
}
