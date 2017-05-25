using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class ExcelSheetName
    {
        public string ConvertToTitle(int n)
        {
            string result = "";
            while (n > 0) 
            {
                n--;
                result = Convert.ToChar('A' + n % 26)+result;
                n = n / 26;
            }
            return result;
        }
    }
}
