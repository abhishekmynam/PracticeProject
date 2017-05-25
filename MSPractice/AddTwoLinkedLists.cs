using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class AddTwoLinkedLists
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resList = new ListNode(0);
            ListNode temp = null;
            int carry = 0;
            int sum = 0;

            while (l1 != null || l2!= null||carry!=0)
            {
                sum = ((l1 != null) ? l1.val : 0) + ((l2 != null) ? l2.val : 0) + carry;
                int sum1 = sum / 10;
                carry = sum % 10;
                temp = new ListNode(sum1);
                resList.next = temp;
                resList = temp;

                l1 = (l1 == null)?null:l1.next;
                l2 = (l2 == null)?null:l2.next;
            }
            return resList.next;
        }
    }
}
