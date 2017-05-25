using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class CompareVersions
    {
        public int compareVersion(String version1, String version2)
        {
            string[] v1 = version1.Split('.');
            string[] v2 = version2.Split('.');

            for (int i = 0; i < Math.Max(v1.Length, v2.Length); i++)
            {
                int num1 = i < v1.Length ? Convert.ToInt32(v1[i]) : 0;
                int num2 = i < v2.Length ? Convert.ToInt32(v2[i]) : 0;
                if (num1 < num2)
                {
                    return -1;
                }
                else if (num1 > num2)
                {
                    return +1;
                }
            }

            return 0;
        }
    }
}
