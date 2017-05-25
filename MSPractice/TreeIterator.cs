using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class TreeIterator
    {
        public class TreeNode {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }

         private Stack<TreeNode> stack;
         public void BSTIterator(TreeNode root)
         {
             stack = new Stack<TreeNode>();
             TreeNode cur = root;
             while (cur != null)
             {
                 stack.Push(cur);
                 if (cur.left != null)
                     cur = cur.left;
                 else
                     break;
             }
         }

    /** @return whether we have a next smallest number */
         public bool hasNext()
         {
             return stack.Count() != 0;
         }

    /** @return the next smallest number */
         public int next()
         {
             TreeNode node = stack.Pop();
             TreeNode cur = node;
             // traversal right branch
             if (cur.right != null)
             {
                 cur = cur.right;
                 while (cur != null)
                 {
                     stack.Push(cur);
                     if (cur.left != null)
                         cur = cur.left;
                     else
                         break;
                 }
             }
             return node.val;
         }
    }
}
