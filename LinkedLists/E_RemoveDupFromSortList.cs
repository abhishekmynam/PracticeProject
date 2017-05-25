using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class E_RemoveDupFromSortList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode DeleteDuplicates(ListNode head)
        {
            ListNode LS = head;

            while (LS != null)
            {
                if (LS.next == null) break;
                if (LS.val == LS.next.val)
                {
                    LS.next = LS.next.next;
                }
                else LS = LS.next;
            }

            return head;
        }
    }
}
