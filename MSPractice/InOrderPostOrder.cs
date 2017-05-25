using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class InOrderPostOrder
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public TreeNode BuildTree(int[] inorder, int[] postorder) 
        {
	        if (inorder == null || postorder == null || inorder.Length != postorder.Length)return null;
	        Dictionary<int, int> hm = new Dictionary<int,int>();
	        for (int i=0;i<inorder.Length;++i)hm.Add(inorder[i], i);
	        return buildTreePostIn(inorder, 0, inorder.Length-1, postorder, 0, postorder.Length-1,hm);
        }

        private TreeNode buildTreePostIn(int[] inorder, int ss, int se, int[] postorder, int ps, int pe,
                                 Dictionary<int, int> hm)
        {
            if (ps > pe || ss > se) return null;
            TreeNode root = new TreeNode(postorder[pe]);
            int ri = hm[postorder[pe]];
            TreeNode leftchild = buildTreePostIn(inorder, ss, ri - 1, postorder, ps, ps + ri - ss - 1, hm);
            TreeNode rightchild = buildTreePostIn(inorder, ri + 1, se, postorder, ps + ri - ss, pe - 1, hm);
            root.left = leftchild;
            root.right = rightchild;
            return root;
        }
    }
}
