using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class practicePuzzles
    {
        public class LRUCache
        {
            public struct cacheCell
            { 
                public int Key ;
                public int Value;
                public int Rank;
            }
            public int cap;
            public static int thisRank;
            public cacheCell[] cacheArrPub;
            public LRUCache(int capacity)
            {
                cacheCell[] cacheArr = new cacheCell[capacity];
                cacheArrPub = cacheArr;
                cap = capacity;
            }

            public int Get(int key)
            {
                foreach (cacheCell c in cacheArrPub)
                {
                    if (c.Key == key)
                    {
                        Put(key, c.Value);
                        return key;
                    }
                }
                return -1;
            }

            public void Put(int key, int value)
            {
                thisRank++;
                cacheCell CC = new cacheCell();
                CC.Key = key;
                CC.Value = value;
                CC.Rank = thisRank;
                bool updated = false;
                

                for (int i = 0 ; i < cacheArrPub.Length; i++) 
                {
                    if (cacheArrPub[i].Key == key)
                    {
                        cacheArrPub[i] = CC;
                        updated = true;
                        break;
                    }
                }

                if (!updated)
                {
                    if (cacheArrPub.Length == cap)
                    {
                        int removeRank = 999999;
                        int pos = 0;
                        for (int i = 0; i < cacheArrPub.Length; i++)
                        {
                            if (cacheArrPub[i].Rank < removeRank)
                            {
                                pos = i;
                                removeRank = cacheArrPub[i].Rank;
                            }

                        }
                        cacheArrPub[pos] = CC;

                    }
                    else
                    {
                        cacheArrPub[cacheArrPub.Length] = CC;
                    }
                }
                

            }
        }
    }
}
