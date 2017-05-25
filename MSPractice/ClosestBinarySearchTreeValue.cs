using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class ClosestBinarySearchTreeValue
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public int closestValue(TreeNode root, double target)
        {
            int ret = root.val;
            while (root != null)
            {
                if (Math.Abs(target - root.val) < Math.Abs(target - ret))
                {
                    ret = root.val;
                }
                root = root.val > target ? root.left : root.right;
            }
            return ret;
        }
    }
}
