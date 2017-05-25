using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class MergeSortedArrays
    {
        public void Merge()
        {
            //int[] nums1, int m, int[] nums2, int n
            int[] nums1 = new int[6] { 1,3,5,0,0, 0};
            int[] nums2 = new int[3] { 2,4,6 };
            int m = 0;
            int n = 1;
            int i = m - 1;
            int j = n - 1;
            int[] resList = new int[m + n];

            for (int k = m + n - 1; k >= 0; k--) 
            {
                if (i < 0) { resList[k] = nums2[j--]; }
                else if (j < 0) { resList[k] = nums1[i--]; }
                else if (nums1[i] < nums2[j]) { resList[k] = nums2[j--]; }
                else { resList[k] = nums1[i--]; }
            }
        }
    }
}
