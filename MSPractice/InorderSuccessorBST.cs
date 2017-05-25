using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class InorderSuccessorBST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode inorderSuccessor(TreeNode root, TreeNode p)
        {
            if (p != null && p.right != null)
            {
                TreeNode cur = p.right;
                while (cur.left != null)
                {
                    cur = cur.left;
                }
                return cur;
            }
            TreeNode next = findNext(root, p);
            return next;
        }

        public TreeNode findNext(TreeNode root, TreeNode p)
        {
            if (root == p)
            {
                return null;
            }
            if (root.val < p.val)
            {
                return findNext(root.right, p);
            }
            else
            {
                TreeNode left = findNext(root.left, p);
                return findNext(root.left, p) == null ? root : left;
            }
        }
    }
}
