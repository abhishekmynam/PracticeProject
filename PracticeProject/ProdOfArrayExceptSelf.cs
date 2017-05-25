using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class ProdOfArrayExceptSelf
    {
        public int[] productExceptSelf(int[] nums)
        {
            int n = nums.Count();
            int[] res = new int[n];
            res[0] = 1;
            for (int i = 1; i < n; i++)
            {
                res[i] = res[i - 1] * nums[i - 1];
            }
            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                res[i] = res[i] * right;
                right  = right * nums[i];
            }
            return res;

        }
    }
}
