using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class E_IntersectionOfLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int LenA = LengthOfLL(headA);
            int LenB = LengthOfLL(headB);
            while (LenA > LenB)
            {
                headA = headA.next;
                LenA--;
            }
            while (LenA < LenB)
            {
                headB = headB.next;
                LenB--;
            }
            while (headB != headA)
            {
                headA = headA.next;
                headB = headB.next;
            }
            return headA;
        }

        private int LengthOfLL(ListNode node)
        {
            int i = 0;
            while (node != null)
            {
                node = node.next;
                i++;
            }
            return i;
        }
    }
}
