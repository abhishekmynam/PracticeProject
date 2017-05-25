using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class RemoveDuplicatesSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            int j = 0;
            for (int i = 0; i < nums.Length; i++)
                if (nums[i] != nums[j]) nums[++j] = nums[i];
            return ++j;
        }
    }
}
