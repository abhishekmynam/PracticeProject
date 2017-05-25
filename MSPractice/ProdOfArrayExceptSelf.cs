using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class ProdOfArrayExceptSelf
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] resList = new int[nums.Count()];
            resList[0] = 1;
            //resList[1] = nums[1];
            for (int i = 1; i < nums.Count(); i++)
            {
                resList[i] = resList[i - 1] * nums[i-1];
            }
            int right = 1;
            for (int i = nums.Count() - 1; i >= 0; i--)
            {
                resList[i] = resList[i] * right;
                right = nums[i] * right;
            }
            return resList;
        }
    }
}
