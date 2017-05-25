using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class SerializeDeserializeTree
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        public List<TreeNode> lisOfTreeNode = new List<TreeNode>();
        public void SerializeBinaryTree(TreeNode root)
        {
            if (root == null)
            {
                lisOfTreeNode.Add(new TreeNode(-1));
            }
            else
            {
                lisOfTreeNode.Add(root);
                this.SerializeBinaryTree(root.left);
                this.SerializeBinaryTree(root.right);
            }
        }
        public TreeNode DeserializeBinaryTree(List<TreeNode> listofNodes)
        {
            if (listofNodes.Count <= 0)
            {
                return null;
            }

            var root = listofNodes[0];
            this.DeserializeBinaryTreeRecursion(listofNodes, root);

            return root;
        }

        private int start = 0;
        private void DeserializeBinaryTreeRecursion(List<TreeNode> listofNodes, TreeNode root)
        {
            if (listofNodes[start].val == -1)
            {
                return;
            }
            start++;

            this.DeserializeBinaryTreeRecursion(listofNodes, root.left);
            this.DeserializeBinaryTreeRecursion(listofNodes, root.right);
        }
    }
}
