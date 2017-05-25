using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class GroupAnagrams
    {
        public IList<IList<string>> GroupAnagramss(string[] strs)
        {
            IList<IList<string>> innerList = new List<IList<string>>();
            List<string> temp = new List<string>();
            List<string> tempItem = null;
            foreach (string s in strs)
            {
                char[] c = s.ToArray();
                Array.Sort(c);

                if (!temp.Contains(new string(c)))
                { 
                    temp.Add((new string(c))); 
                    tempItem = new List<string>();
                    tempItem.Add( s);
                    innerList.Add(tempItem);
                }
                else
                {
                    int index = temp.IndexOf((new string(c)));
                    innerList[index].Add(s);
                }
            }
            return innerList;
        }
    }
}
