using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class LargestCommonSubsequence
    {
        public int MinDistance()//string word1, string word2)
        {
            string word1 = "TRESART";
            string word2 = "RS";
            int[,] trackArr = new int[word1.Count()+1,word2.Count()+1];

            for (int i = 0; i <= word1.Count(); i++)
            {
                for (int j = 0; j <= word2.Count(); j++)
                {
                    if (i == 0 || j == 0) { trackArr[i, j] = 0; }
                    else 
                    {
                        trackArr[i, j] = word1[i-1] == word2[j-1] ? trackArr[i - 1, j - 1]+1 : Math.Max(trackArr[i - 1, j], trackArr[i, j - 1]);
                    }
                }
            }
            int val = trackArr[word1.Count(), word2.Count()];
            return word1.Count() - val + word2.Count() - val;
        }
    }
}
