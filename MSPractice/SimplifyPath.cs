using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class SimplifyPath
    {
        public string SimplifyPath(string path)
        {
            Stack<string> stack = new Stack<string>();
            HashSet<string> skip = new HashSet<string>(new string[3] { "..", ".", "" });
            foreach (string dir in path.Trim().Split('/'))
            {
                if (dir == ".." && stack.Count() != 0) stack.Pop();
                else if (!skip.Contains(dir)) stack.Push(dir);
            }
            string res = "";
            foreach (string dir in stack) res = "/" + dir + res;
            return res.Count() == 0 ? "/" : res;
        }
    }
}
