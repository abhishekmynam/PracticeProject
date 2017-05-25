using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class MissingNumber
    {
        public int missingNumber(int[] nums)
        {
            int sum = 0;

            foreach (int i in nums)
            {
                sum += i;
            }

            return nums.Count() * (nums.Count() + 1) / 2 - sum;
        }
    }
}
