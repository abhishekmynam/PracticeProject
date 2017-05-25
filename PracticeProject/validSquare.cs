using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class validSquare
    {
        public bool ValidSquare(int[] p1, int[] p2, int[] p3, int[] p4)
        {
            if ((p1[0] == p2[0] && p1[1] == p2[1]) || 
                (p2[0] == p3[0] && p2[1] == p3[1]) || 
                (p3[0] == p4[0] && p3[1] == p4[1]) || 
                (p4[0] == p1[0] && p4[1] == p1[1]) || 
                (p1[0] == p3[0] && p1[1] == p3[1]) || 
                (p4[0] == p2[0] && p4[1] == p2[1])) { return false; }
            int d1 = length(p1, p2);
            int d2 = length(p2, p3);
            int d3 = length(p3, p4);
            int d4 = length(p4, p1);
            int d5 = length(p1, p3);
            int d6 = length(p2, p4);
            HashSet<int> lens = new HashSet<int>();
            lens.Add(d1);
            lens.Add(d2);
            lens.Add(d3);
            lens.Add(d4);
            lens.Add(d5);
            lens.Add(d6);
            if (lens.Count() == 2) return true;
            else return false;

        }

        private int length(int[] p1, int[] p2)
        {
            return (p2[1] - p1[1]) * (p2[1] - p1[1]) + (p2[0] - p1[0]) * (p2[0] - p1[0]);
        }
    }
}
