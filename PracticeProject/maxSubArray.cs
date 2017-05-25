using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class maxSubArray
    {
        public int MaxSubArray(int[] nums)
        {
            int max = int.MinValue, sum = 0;
            for (int i = 0; i < nums.Count(); i++)
            {
                if (sum < 0) sum = nums[i];
                else sum += nums[i];
                if (sum > max) max = sum;
            }
            return max;
        }
    }
}
