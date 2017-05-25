using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class ValidateBST
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public bool IsValidBST(TreeNode root)
        {
            return validateBST(root, long.MinValue, long.MaxValue);
        }
        public bool validateBST(TreeNode root, long min, long max) 
        {
            if (root == null) return true;
            if(root.val>= max||root.val<=min) return false;
            return validateBST(root.left, min, root.val) && validateBST(root.right, root.val, max);
        }
    }
}
