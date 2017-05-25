using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class KillProcess
    {
        public IList<int> killProcess(IList<int> pid, IList<int> ppid, int kill)
        {
            int idx = 0;
            int pIdx = 0, ppIdx = 0;
            IList<int> killList = new List<int>();
            Dictionary<int, List<int>> DPset = new Dictionary<int, List<int>>();
            int killElem = kill;
            List<int> tempList = null;
            for (int i = 0; i < ppid.Count(); i++)
            {
                if (DPset.ContainsKey(ppid[i]))
                {
                    tempList = DPset[ppid[i]];
                    tempList.Add(pid[i]);
                    DPset[ppid[i]] = tempList;
                }
                else 
                {
                    tempList = new List<int>();
                    tempList.Add(pid[i]);
                    DPset.Add(ppid[i], tempList);
                }
            }

            tempList = new List<int>();
            tempList.Add(kill);

            for (int i = 0; i< ppid.Count();i++)
            {
                if (i < tempList.Count())
                {
                    killList.Add(tempList[i]);
                    if (DPset.ContainsKey(tempList[i]))
                    {
                        tempList.AddRange(DPset[tempList[i]]);
                        
                    }
                }
            }
            return killList;
        }

    }
}
