using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class LargestHarmoniousSubsequence
    {
        public int FindLHS()
        {
            int[] nums = new int[8]{1,3,2,2,5,2,3,7};
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            foreach (int i in nums)
            {
                if (!dict.ContainsKey(i)) dict.Add(i, 1);
                else { dict[i]++; }
            }
            int max = 0;
            int prevDict = int.MinValue;
            int prevVal = int.MinValue;
            foreach(int i in dict.Keys)
            {
                if (prevDict != int.MinValue) 
                {
                    if(prevDict - i == 1|| prevDict - i == -1)
                    {
                        if (dict[i] + prevVal > max)
                        {
                            max = dict[i] + prevVal;
                        }
                    }
                    
                }
                prevDict = i; 
                prevVal = dict[i];
            }
            return max;
        }
    }
}
