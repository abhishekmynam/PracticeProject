using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class ThreeSum
    {
        public IList<IList<int>> threeSum(int[] nums)
        {
            IList<IList<int>> result = new List<IList<int>>();
            if (nums.Length < 3) return result;
            Array.Sort(nums);
            int i = 0;
            while (i < nums.Length - 2)
            {
                if (nums[i] > 0) break;
                int j = i + 1;
                int k = nums.Length - 1;
                while (j < k)
                {
                    int sum = nums[i] + nums[j] + nums[k];
                    if (sum == 0) result.Add(new List<int>() { nums[i], nums[j], nums[k] });
                    if (sum <= 0) while (nums[j] == nums[++j] && j < k) ;
                    if (sum >= 0) while (nums[k--] == nums[k] && j < k) ;
                }
                while (nums[i] == nums[++i] && i < nums.Length - 2) ;
            }
            return result;
        }
    }
}
