using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class LongestIncreasingSubsequence
    {
        public int lengthOfLIS(int[] nums)
        {
            int[] tails = new int[nums.Length];
            int size = 0;
            foreach (int x in nums)
            {
                int i = 0, j = size;
                while (i != j)
                {
                    int m = (i + j) / 2;
                    if (tails[m] < x)
                        i = m + 1;
                    else
                        j = m;
                }
                tails[i] = x;
                if (i == size) ++size;
            }
            return size;
        }
    }
}
