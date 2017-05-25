using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class MaxSumSubarray
    {
        public int MaxSubArray()
        {
            int[] nums = new int[9] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            int res = int.MinValue;
            int sum = 0;
            for (int i = 0; i < nums.Count(); i++) 
            {
                sum = Math.Max(sum, 0) + nums[i];
                res = Math.Max(res, sum);
            }
            return res;
        }
    }
}
