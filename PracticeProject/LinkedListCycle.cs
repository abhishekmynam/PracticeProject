using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LinkedListCycle
    {
        public class ListNode {
            public int val;
            public ListNode next;
            public ListNode(int x) {
                val = x;
                next = null;
            }
    }

        public bool HasCycle(ListNode head)
        {
            if(head == null){return false;}
            ListNode slowHop = head;
            ListNode fastHop = head;
            while (slowHop.next != null && fastHop.next != null)
            {
                if (fastHop.next.next != null)
                {
                    slowHop = slowHop.next;
                    fastHop = fastHop.next.next;
                    if (slowHop == fastHop) { return true; }
                }
                else { return false; }
            }
            return false;
        }
    }
}
