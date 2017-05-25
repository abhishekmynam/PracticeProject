using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    public class AtoIConverter
    {
        public int MyAtoi(string str)
        {
            if (str.Count()==0)
                return 0;
            str = str.Trim();
            int i = 0, ans = 0, sign = 1, len = str.Length;
            if (str[i] == '-' || str[i] == '+')
                sign = str[i++] == '+' ? 1 : -1;
            for (; i < len; ++i)
            {
                int tmp = str[i] - '0';
                if (tmp < 0 || tmp > 9)
                    break;
                if (ans > int.MaxValue / 10
                        || (ans == int.MaxValue / 10 && int.MinValue% 10 < tmp))
                    return sign == 1 ? int.MaxValue: int.MinValue;
                else
                    ans = ans * 10 + tmp;
            }
            return sign * ans;
        }
    }
}
