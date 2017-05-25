using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class SwapNodesInPairsLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode swapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode current = dummy;
            while (current.next != null && current.next.next != null)
            {
                ListNode first = current.next;
                ListNode second = current.next.next;
                first.next = second.next;
                current.next = second;
                current.next.next = first;
                current = current.next.next;
            }
            return dummy.next;
        }
    }
}
