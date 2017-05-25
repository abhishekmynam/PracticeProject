using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LinkedListPalindrome
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public bool isPalindrome(ListNode head)
        {
            ListNode fast = head;
            ListNode slow = head;

            while (fast != null && fast.next != null)
            {
                fast = fast.next.next;
                slow = slow.next;
            }
            if (fast != null) slow = slow.next;

            ListNode temp = null;
            while (slow != null)
            {
                ListNode next = slow.next;
                slow.next = temp;
                temp = slow;
                slow = next;
            }
            slow = temp;
            while (slow != null && head.val == slow.val)
            {
                head = head.next;
                slow = slow.next;
            }
            return slow == null;
        }

    }
}
