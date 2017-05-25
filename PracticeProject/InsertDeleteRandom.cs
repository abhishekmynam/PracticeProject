using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class RandomizedSet
    {
            /** Initialize your data structure here. */
        public List<int> RandomSet;
        public int randVal;
        public RandomizedSet() {
            RandomSet = new List<int>();
        }
    
        /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
        public bool Insert(int val) {
            if (RandomSet.Contains(val)){return false;}
            else { RandomSet.Add(val); return true; }
        }
    
        /** Removes a value from the set. Returns true if the set contained the specified element. */
        public bool Remove(int val) {
            if (RandomSet.Contains(val)) { RandomSet.Remove(val); return true; }
            else { return false; }
        }
    
        /** Get a random element from the set. */
        public int GetRandom() {
            if (randVal < RandomSet.Count()-1) { randVal++; }
            else { randVal = 0; }
            return RandomSet[randVal];
        }
    }
}
