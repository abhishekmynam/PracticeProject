using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class StrStr
    {
        public int strStr(String haystack, String needle)
        {
            for (int i = 0; ; i++)
            {
                for (int j = 0; ; j++)
                {
                    if (j == needle.Length) return i;
                    if (i + j == haystack.Length) return -1;
                    if (needle[j] != haystack[i + j]) break;
                }
            }
        }
    }
}
