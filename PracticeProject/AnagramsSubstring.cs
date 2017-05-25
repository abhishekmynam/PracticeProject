using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class AnagramsSubstring
    {
        public IList<int> FindAnagrams(string p, string s)
        {
            List<int> resultList = new List<int>();

            int lenS = s.Length;
            int lenP = p.Length;
            char[] sStr = s.ToArray();
            Array.Sort(sStr);
            string thisS = new string(sStr);
            if (lenS > lenP) { return resultList; }

            else
            {
                for (int i=0; i<=lenP-lenS ; i++)
                {
                    char[] pStr = p.Substring(i, lenS).ToArray();
                    Array.Sort(pStr);
                    string thisP = new string(pStr);

                    if (thisP == thisS)
                    {
                        resultList.Add(i);
                    }
                }
 
            }

            return resultList;
        }

        public List<int> findAnagrams(string s, string p) {
            List<int> list = new List<int>();
            if (s == null || s.Count() == 0 || p == null || p.Count() == 0) return list;
            int[] hash = new int[256];
             char[] pArray = p.ToArray();
            foreach (char c in pArray) {
                hash[c]++;
            }
            int left = 0, right = 0, count = p.Count();
            while (right < s.Count()) {
                if (hash[s[right++]]-- >= 1) count--; 
        
                if (count == 0) list.Add(left);
    
                if (right - left == p.Count() && hash[s[left++]]++ >= 0) count++;
            }
            return list;
        }
    }
}
