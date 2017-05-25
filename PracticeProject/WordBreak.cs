using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class WordBreak
    {
        public bool wordBreak(String s, List<String> wordDict)
        {
            int len = s.Count();
            bool[] f = new bool[len + 1];
            f[0] = true;
            for (int i = 1; i < len + 1; i++)
                for (int j = 0; j < i; j++)
                    if (f[j] && wordDict.Contains(s.Substring(j, i-j)))
                    {
                        f[i] = true;
                        break;
                    }
            return f[len];
        }
    }
}
