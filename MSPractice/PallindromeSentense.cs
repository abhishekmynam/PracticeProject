using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class PallindromeSentense
    {
        public bool isPalindrome(String s)
        {
            if (s.Count()==0)
            {
                return true;
            }
            int head = 0, tail = s.Length - 1;
            char cHead, cTail;
            while (head <= tail)
            {
                cHead = s[head];
                cTail = s[tail];
                if (!char.IsLetterOrDigit(cHead))
                {
                    head++;
                }
                else if (!char.IsLetterOrDigit(cTail))
                {
                    tail--;
                }
                else
                {
                    if (char.ToLower(cHead) != char.ToLower(cTail))
                    {
                        return false;
                    }
                    head++;
                    tail--;
                }
            }

            return true;
        }
    }
}
