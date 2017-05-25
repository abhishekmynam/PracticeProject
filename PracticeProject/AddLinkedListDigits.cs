using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class AddLinkedListDigits
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public void Addthis ()
        {
            ListNode t1= new ListNode(2);
            t1.next = new ListNode(4);
           t1.next.next = new ListNode(3);
             ListNode t2= new ListNode(5);
            t2.next = new ListNode(6);
           t2.next.next = new ListNode(4);
           var res=  AddTwoNumbers(t1, t2);
        }
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resList = new ListNode(0);
            ListNode result = resList;
            int carry = 0;
            int sum = 0;
            while (l1 != null || l2 != null|| carry!=0)
            {
                sum = ((l2 == null) ? 0 : l2.val )+ ((l1 == null) ? 0 : l1.val)+ carry;
                int sum1 = sum % 10;
                carry = sum / 10;
                ListNode temp = new ListNode(sum1);
                resList.next = temp;
                resList = temp;

                l1 = (l1 == null) ? l1 : l1.next;
                l2 = (l2 == null) ? l2 : l2.next;
            }            
            return result.next;
        }
    }
}
