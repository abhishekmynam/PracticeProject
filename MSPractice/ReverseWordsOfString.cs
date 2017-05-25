using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class ReverseWordsOfString
    {
        public string ReverseWords()//string s)
        {
            //both are correct *************************************
            string s = "a";
            Stack<string> divString = new Stack<string>();
            string tempStr ="";
            bool flag = false;
            s = s.Trim();
            foreach (char c in s)
            {
                if (c != ' ')
                {
                    tempStr = tempStr + c; 
                }
                else
                {
                    if (tempStr.Trim() != "")
                    {
                        divString.Push(tempStr.Trim());
                        tempStr = "";
                    }
                }
            }
            if (tempStr.Trim() != "")
            {
                divString.Push(tempStr.Trim());
            }
            if (divString.Count() == 0) { return ""; }
            else { tempStr = ""; }
            while (divString.Count() != 0)
            {
                if (flag) { tempStr = tempStr + ' '; }
                tempStr = tempStr + divString.Pop();
                flag = true;
            }
            return tempStr;

            //string[] tempStr = s.Trim().Split(' ');
            //string resStr = "";
            //for(int i=tempStr.Count()-1; i>=0;i--)
            //{
            //    if (tempStr[i] != "")
            //    {
            //        resStr += tempStr[i].Trim() + ' ';
            //    }
            //}
            //return resStr.Trim();

        }
    }
}
