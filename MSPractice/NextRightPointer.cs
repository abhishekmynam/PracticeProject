using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class NextRightPointer
    {
        public class TreeLinkNode
        {
            int val;
            TreeLinkNode left, right, next;
            TreeLinkNode(int x) { val = x; }
        }
        public void connect(TreeLinkNode root)
        {
            //if (root == null) { return; }
            //for (TreeLinkNode head = root; head.left != null; head = head.left)
            //{
            //    for (TreeLinkNode parent = head; parent != null; parent = parent.next)
            //    {
            //        parent.left.next = parent.right;
            //        if (parent.next != null) { parent.right.next = parent.next.left; }
            //    }
            //}

            //TreeLinkNode dummyHead = new TreeLinkNode(0);
            //TreeLinkNode pre = dummyHead;
            //while (root != null)
            //{
            //    if (root.left != null)
            //    {
            //        pre.next = root.left;
            //        pre = pre.next;
            //    }
            //    if (root.right != null)
            //    {
            //        pre.next = root.right;
            //        pre = pre.next;
            //    }
            //    root = root.next;
            //    if (root == null)
            //    {
            //        pre = dummyHead;
            //        root = dummyHead.next;
            //        dummyHead.next = null;
            //    }
            //}
        }
    }
}
