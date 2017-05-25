using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class IntersectionLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        private int LengthLL(ListNode node)
        {
            int length =0;
            while (node!= null)
            {
                node = node.next;
                length++;
            }
            return length;
        }

        public ListNode getIntersectionNode(ListNode headA, ListNode headB) 
        {
            int lenA = LengthLL(headA);
            int lenB = LengthLL(headB);
            while (lenA > lenB)
            {
                headA = headA.next;
                lenA--;
            }
            while (lenB > lenA)
            {
                headB = headB.next;
                lenB--;
            }
            while (headB != headA)
            {
                headA = headA.next;
                headB = headB.next;
            }
            return headA;
        }
    }
}
