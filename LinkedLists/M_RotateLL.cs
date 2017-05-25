using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class M_RotateLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode RotateRight(ListNode head, int k)
        {
            if (head == null)return head;

            ListNode copyHead = head;

            int len = 1;
            while (copyHead.next != null)
            {
                copyHead = copyHead.next;
                len++;
            }

            copyHead.next = head; //last element pointing the head

            for (int i = len - k % len; i > 1; i--)
                head = head.next;

            copyHead = head.next;
            head.next = null;

            return copyHead;
            
        }
    }
}
