using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class TwoSum
    {
        public int[] TwoSums(int[] nums, int target)
        {
            
            int[] result = new int[2];
            bool found = false;
            for (int i = 0; i < nums.Length-2; i++)
            {
                //if (nums[i] <= target)
                //{
                    for (int j = i+1; j < nums.Length; j++)
                    {
                        if (nums[j]+nums[i] == target)
                        {
                            found = true;
                            result[0] = i;
                            result[1] = j;
                            break;
                        }
                    }
                    if(found)
                    {
                        break;
                    }
                //}
            }

            return result;
        }
    }
}
