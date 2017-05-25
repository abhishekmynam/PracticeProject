using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class ExcelColumnNumber
    {
        public int TitleToNumber(string s)
        {
            string curS = new string(s.ToCharArray().Reverse().ToArray());
            int i = 0;
            int colNo = 0;
            foreach (char c in curS) 
            {
                int curChar = c - 'A' + 1;
                colNo = Convert.ToInt32(Math.Pow(26, i)) * curChar + colNo;
                i++;
            }
            return colNo;
        }
    }
}
