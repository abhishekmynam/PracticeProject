using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class ValidAnagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Count() != t.Count()) { return false; }
            else 
            {
                int[] alphaList = new int[26];
                for (int i = 0; i < s.Count(); i++)
                {
                    alphaList[s[i] - 'a']++;
                    alphaList[t[i] - 'a']--;
                }
                foreach (int i in alphaList)
                {
                    if (i != 0) { return false; }
                }
            }
            return true;
        }
    }
}
