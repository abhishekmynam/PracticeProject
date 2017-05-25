using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class RomanTo_Int
    {
        public int RomanToInt()
        {
            string s = "DCXII";
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = new string(arr);
            int curVal = 0, finalVal = 0;
            //bool flag =false;
            int prevVal = 0;
            foreach (char c in s)
            {
                switch (c)
                {
                    case 'I': curVal = 1; break;
                    case 'V': curVal = 5; break;
                    case 'X': curVal = 10; break;
                    case 'L': curVal = 50; break;
                    case 'C': curVal = 100; break;
                    case 'D': curVal = 500; break;
                    case 'M': curVal = 1000; break;
                }
                if (curVal < prevVal) curVal *= -1;
                prevVal = curVal;
                finalVal = finalVal + curVal;
            }
            return finalVal;
        }
    }
}
