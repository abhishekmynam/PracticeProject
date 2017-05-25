using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    class E_CheckPalindromeLL
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public bool IsPalindrome(ListNode head)
        {
            if (head == null) return false;
            Stack<int> nodeStack = new Stack<int>();
            Queue<int> nodeQueue = new Queue<int>();

            while (head != null)
            {
                nodeStack.Push(head.val);
                nodeQueue.Enqueue(head.val);
                head = head.next;
            }

            while (nodeStack.Count()>0)
            {
                if (nodeStack.Pop() != nodeQueue.Dequeue()) return false;
            }
            return true;
        }
    }
}
