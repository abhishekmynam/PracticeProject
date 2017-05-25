using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class SymmetricTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public bool isSymmetric(TreeNode root)
        {
            return root == null || isSymmetricHelp(root.left, root.right);
        }

        private bool isSymmetricHelp(TreeNode left, TreeNode right)
        {
            if (left == null || right == null)
                return left == right;
            if (left.val != right.val)
                return false;
            return isSymmetricHelp(left.left, right.right) && isSymmetricHelp(left.right, right.left);
        }
    }
}
