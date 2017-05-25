using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class DeleteNodeInLinkedList
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public void DeleteNode(ListNode node, int val)
        {
            if(node.next.val == val){
                node.next = node.next.next;
            }

            //if (node.next != null)
            //{
            //    node.val = node.next.val;
            //    node.next = node.next.next;
            //}
        }
    }
}
