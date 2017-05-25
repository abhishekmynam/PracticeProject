using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class SortColors
    {
        public void sortColors(int[] nums)
        {

            int c0 = 0, c1 = 0, c2 = 0;
            foreach (int i in nums)
            {
                switch (i)
                {
                    case 0: c0++; break;
                    case 1: c1++; break;
                    case 2: c2++; break;
                }
            }
            for (int i = 0; i < c0; i++) { nums[i] = 0; }
            for (int i = c0; i < c0+c1; i++) { nums[i] = 1; }
            for (int i = c0+c1; i < c0+c1+c2; i++) { nums[i] = 2; }
        }
    }
}
