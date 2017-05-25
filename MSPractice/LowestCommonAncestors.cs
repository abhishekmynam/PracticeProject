using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class LowestCommonAncestors
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) 
        {

            if (root == null) return null;
            if (root == p || root == q) return root;
            TreeNode leftNode = LowestCommonAncestor(root.left, p, q);
            TreeNode rightNode = LowestCommonAncestor(root.right, p, q);

            if (leftNode != null && rightNode != null)
            {
                return root;
            }
            else 
            {
                if (leftNode == null) { return rightNode; } else { return leftNode; }
            }
        }
    }
}
