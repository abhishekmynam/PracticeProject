using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class FirstUniqueChar
    {
        public int FirstUniqChar(string s)
        {
            if (s.Count() == 0) { return -1; }
            int[] charCounts = new int[26];
            int min = -1;
            bool first = true;
            foreach (char c in s)
            {
                int charPos =Convert.ToInt32(c )-97;
                charCounts[charPos]++;
            }
            for(int i=0 ; i<26;i++)
            {
                if (charCounts[i] == 1) 
                {
                    char curChar =Convert.ToChar( 97 + i);

                    if (s.IndexOf(curChar) < min || first) { min = s.IndexOf(curChar); first = false; }
                }
            }
            return min;
        }
    }
}
