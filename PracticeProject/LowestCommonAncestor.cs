﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LowestCommonAncestor
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

        //public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        //{
        //    if (root == null || p == root || q == root)
        //    {
        //        return root;
        //    }

        //    TreeNode left = LowestCommonAncestor(root.left, p, q);
        //    TreeNode right = LowestCommonAncestor(root.right, p, q);

        //    if (left != null && right != null)
        //    { return root; }
        //    return left != null ? left : right;
        //}
    }
}
