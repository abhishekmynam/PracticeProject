using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class Permutation
    {
        public List<List<int>> permute(int[] num)
        {
            List<List<int>> res = new List<List<int>>();
            res.Add(new List<int>());
            foreach (int n in num)
            {
                int size = res.Count();
                for (; size > 0; size--)
                {
                    List<int> r = res.First();
                    res.RemoveAt(0);
                    for (int i = 0; i <= r.Count(); i++)
                    {
                        List<int> t = new List<int>(r);
                        t.Add(i);
                        res.Add(t);
                    }
                }
            }
            return res;
        }
    }
}
