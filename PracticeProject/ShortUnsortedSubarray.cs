using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class ShortUnsortedSubarray
    {
        public int FindUnsortedSubarray()
        {
            int[] nums = new int[5] { 1, 2, 5, 3, 4 };
            int firstIdx = 0, lastIdx = 0, firstNo = 0, equalIdx = 0, equalVal = 0;
            bool flag = false;
            for (int i = 1; i < nums.Count(); i++)
            {
                if (nums[i - 1] > nums[i])
                {
                    firstIdx = i - 1;
                    firstNo = nums[i];
                    flag = true;
                    break;
                }
            }
            if (!flag) { return 0; }
            for (int i = 0; i < nums.Count(); i++)
            {
                if (firstNo < nums[i]) { firstIdx = i; break; }
            }

            for (int j = nums.Count() - 2; j >= 0; j--) 
            {
                if (nums[j + 1] < nums[j])
                {
                    lastIdx = j + 2;
                    break;
                }
            }
            for (int j = nums.Count() - 1; j >= 0; j--) 
            {
                if (nums[lastIdx - 1] < nums[j]) { lastIdx = j+1; break; }

            }
            for (int k = 0; k < firstIdx; k++)
            {
                if (nums[k] > nums[lastIdx-1]) { firstIdx = k; }
            }
            return lastIdx - firstIdx;
        }
    }
}
