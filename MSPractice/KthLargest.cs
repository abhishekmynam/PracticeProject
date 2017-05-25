using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class KthLargest
    {
        public int findKthLargest(int[] nums, int k)
        {
            return quickSelect(nums, 0, nums.Length - 1, k);
        }

        private int quickSelect(int[] nums, int start, int end, int k)
        {
            int pivot = end;
            int left = start;
            int right = end - 1;
            int tmp = 0;
            while (left <= right)
            {
                if (nums[left] > nums[pivot])
                {
                    
                    tmp = nums[left];
                    nums[left] = nums[right];
                    nums[right] = tmp;
                    right--;
                }
                else
                {
                    left++;
                }
            }
            tmp = nums[left];
            nums[left] = nums[pivot];
            nums[pivot] = tmp;

            int rank = nums.Length - left;
            if (rank == k) return nums[left];
            if (rank > k) return quickSelect(nums, left + 1, end, k);
            return quickSelect(nums, start, left - 1, k);
        }

        
    }
}
