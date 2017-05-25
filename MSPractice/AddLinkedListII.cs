using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class AddLinkedListII
    {
        public void Addthis()
        {
            ListNode t1 = new ListNode(7);
            t1.next = new ListNode(2);
            t1.next.next = new ListNode(4);
            t1.next.next.next = new ListNode(3);
            ListNode t2 = new ListNode(5);
            t2.next = new ListNode(6);
            t2.next.next = new ListNode(4);
            var res = AddTwoNumbers(t1, t2);
        }
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode AddTwoNumbersNotCorrect(ListNode l1, ListNode l2)
        {
            ListNode resList =null;
            string s1 = null;
            string s2 = null;

            while (l1 != null)
            {
                s1 = s1 + l1.val;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                s2 = s2 + l2.val;
                l2 = l2.next;
            }
            Int64 sumRes = Convert.ToInt64(s1) + Convert.ToInt64(s2);
            
            while (sumRes != 0)
            {

                int val = Convert.ToInt32(sumRes % 10);
                if (resList == null) 
                {
                    resList = new ListNode(val);
                }
                else
                {
                    ListNode tempNode = new ListNode(val);
                    tempNode.next = resList;
                    resList = tempNode;
                }
                sumRes = sumRes / 10;
            }
            return resList;
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode resList = null;
            Stack<int> S1 = new Stack<int>();
            Stack<int> S2 = new Stack<int>();
            int carry = 0;
            while (l1 != null) 
            {
                S1.Push(l1.val);
                l1 = l1.next;
            }
            while (l2 != null)
            {
                S2.Push(l2.val);
                l2 = l2.next;
            }

            while (S1.Count() != 0 || S2.Count() != 0 || carry != 0)  
            {
                //l1 = (l1 == null) ? l1 : l1.next;
                int sum = ((S1.Count() > 0) ? S1.Pop() : 0 )+ ((S2.Count() > 0) ? S2.Pop() : 0) + carry;
                carry = sum / 10;
                int sum1 = sum % 10;

                if (resList == null)
                {
                    resList = new ListNode(sum1);
                }
                else
                {
                    ListNode tempNode = new ListNode(sum1);
                    tempNode.next = resList;
                    resList = tempNode;
                }
            }
            return resList;
        }
    }
}
