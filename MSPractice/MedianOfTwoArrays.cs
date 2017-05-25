using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class MedianOfTwoArrays
    {
        public double findMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int m = nums1.Length;
            int n = nums2.Length;
            int k = (m + n) / 2;
            int i = 0, j = k;
            int lo = 0, hi = Math.Min(k, m);

            while (true)
            {
                i = lo + (hi - lo) / 2;
                j = k - i;
                if (get(nums1, i) >= get(nums2, j - 1))
                {
                    if (get(nums2, j) >= get(nums1, i - 1)) break;
                    else hi = i - 1;
                }
                else lo = i + 1;
            }
            if ((m + n) % 2 == 1) return Math.Min(get(nums1, i), get(nums2, j)); //odd
            return (double)(Math.Min(get(nums1, i), get(nums2, j)) + Math.Max(get(nums1, i - 1), get(nums2, j - 1))) / 2;//even
        }
        private int get(int[] nums, int i)
        {
            if (i < 0) return int.MinValue;
            if (i >= nums.Length) return int.MaxValue;
            return nums[i];
        }
    }
}
