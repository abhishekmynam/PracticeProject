using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    public class E_LinkedListCycle
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x)
            {
                val = x;
                next = null;
            }
        }
        public bool HasCycle(ListNode head)
        {
            if (head == null) return false;
            ListNode slowHop = head;
            ListNode fastHop = head;

            while (slowHop.next != null && fastHop.next != null)
            {
                if (fastHop.next.next != null)
                {
                    fastHop = fastHop.next.next;
                    slowHop = slowHop.next;
                    if (fastHop == slowHop) return true;
                }
                else return false;
            }
            return false;
        }
    }
}
