using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class ClimbStairs
    {
        public int ClimbStairs(int n)
        {
            int a = 1, b = 1;
            while (n-- > 0)
            {
                b = a + b;
                a = b - a;
            }
            return a;
        }
    }
}
