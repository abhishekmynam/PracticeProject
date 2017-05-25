using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LargestPalindrome
    {
        public String longestPalindrome(String s)
        {
            int n = s.Count();
            String res = null;

            Boolean[,] dp = new Boolean[n, n];

            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = i; j < n; j++)
                {
                    dp[i, j] = s[i] == s[j] && (j - i < 3 || dp[i + 1, j - 1]);

                    if (dp[i, j] && (res == null || j - i + 1 > res.Count()))
                    {
                        res = s.Substring(i, j + 1-i);
                    }
                }
            }

            return res;
        }
    }
}
