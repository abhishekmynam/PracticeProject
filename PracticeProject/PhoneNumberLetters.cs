using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class PhoneNumberLetters
    {
        public List<string> LetterCombinations(string digits)
        {
            List<string> letterStr = new List<string>();
            int lenStr = digits.Count();
            string[] chars = new string[10]{"0","0","abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
            string curStr = null;
            DFS(digits, letterStr, curStr, 0, chars);
            return letterStr;
        }
        public static void DFS(string digits, List<string> letterStr, string curStr, int start, string[] chars)
        {
            if (start == digits.Count()) { letterStr.Add(curStr); }
            else {
                string temp = chars[digits[start]];
                for (int i = 0; i < temp.Count(); i++) 
                {
                    curStr = curStr + temp[i];
                    DFS(digits, letterStr, curStr, start + 1, chars);
                    //curStr.Remove[curStr.Count() - 1];
                }
            }
        }
    }
}
