using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class ZigZagTreeTraverse
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
        IList<IList<int>> resList = new List<IList<int>>();
        public IList<IList<int>> ZigzagLevelOrder(TreeNode root)
        {
            zigZagTravel(root, resList, 0);
            return resList;
        }
        private void zigZagTravel(TreeNode cur, IList<IList<int>> resList, int level)
        {
            if (cur == null) return;
            if (resList.Count() <= level) { resList.Add(new List<int>()); }
            if ((level+1) % 2 != 0) resList[level].Add(cur.val);
            else
            {
                if (resList[level].Count() == 0) { resList[level].Add(cur.val); }
                else 
                {
                    int temp = resList[level][0];
                    resList[level][0]=cur.val;
                    resList[level].Add(temp);
                }
            }
            zigZagTravel(cur.left, resList, level+1);
            zigZagTravel(cur.right, resList, level+1);
        }
    }
}
