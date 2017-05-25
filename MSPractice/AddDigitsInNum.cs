using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class AddDigitsInNum
    {
        public int addDigits(int num)
        {

            return num == 0 ? 0 : (num % 9 == 0 ? 9 : (num % 9));

        }
    }
}
