using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class NumberOfOneBits
    {
        public int HammingWeight(uint n)
        {

            int count = 0;
            for (int i = 0; i < 32; i++)
            {
                count += (n >> i & 1) == 1 ? 1 : 0;
            }
            return count;
        }
    }
}
