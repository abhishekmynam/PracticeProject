using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class NumArray
    {
        public int[] arr = null;
        public NumArray()
        {
            int[] nums = new int[6] { -2, 0, 3, -5, 2, -1 };
            arr = new int[nums.Count()];
            if (nums.Count() > 0)
            {
                arr[0] = nums[0];
                for (int i = 1; i < nums.Count(); i++)
                {
                    arr[i] = arr[i - 1] + nums[i];
                }
            }
        }
    
        public int SumRange() {
            NumArray NM = new NumArray();
            
            int i = 0, j = 2;
            if (i == 0) return arr[j];
            return arr[j] - arr[i-1];
        }
    }
}
