using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class E_RemoveValFromLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head == null) return head;
            ListNode LN = head;
            while (LN.next != null)
            {
                if (LN.next == null) break;
                if (LN.next.val == val)
                {
                    LN.next = LN.next.next;
                }
                else LN = LN.next;
            }
            return head.val == val? head.next:head ;
        }
    }
}
