using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class MinInRotatedSortedArray
    {
        public int findMin(int[] num)
        {
            if (num == null || num.Length == 0)
            {
                return 0;
            }
            if (num.Length == 1)
            {
                return num[0];
            }
            int start = 0, end = num.Length - 1;
            while (start < end)
            {
                int mid = (start + end) / 2;
                if (mid > 0 && num[mid] < num[mid - 1])
                {
                    return num[mid];
                }
                if (num[start] <= num[mid] && num[mid] > num[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
            }
            return num[start];
        }
    }
}
