using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class LowestCommonAncestorBST
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
            if(p.val >q.val)
            {
                var p1 = p;
                p = q;
                q= p1;
            }
            while (root != null) 
            {
                if ((root.val >= p.val && root.val < q.val) || (root.val > p.val && root.val <= q.val)) { return root; }
                else if (root.val < p.val && root.val < q.val) { root = root.right; } 
                else if (root.val > p.val && root.val > q.val) { root = root.left; } 
            }
            return null;
        }
    }
}
