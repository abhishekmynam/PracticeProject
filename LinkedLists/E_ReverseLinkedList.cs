using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class E_ReverseLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode ReverseList(ListNode head)
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
    }
}
