using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class DeepCopy
    {
       public class RandomListNode {
       public int label;
       public RandomListNode next, random;
       public RandomListNode(int x) { this.label = x; }
       }
        
       public RandomListNode CopyRandomList(RandomListNode head)
       {

           if(head == null) {
            return null;
        }
          
        Dictionary<RandomListNode, RandomListNode> oldNew = new Dictionary<RandomListNode, RandomListNode>();
        
        RandomListNode cur = head;
        
        RandomListNode dummyNewHead = new RandomListNode(0);
        RandomListNode tail = dummyNewHead;
        while(cur != null) {
            RandomListNode newCopy = new RandomListNode(cur.label);
            tail.next = newCopy;
            tail = tail.next;
            
            oldNew.Add(cur, newCopy);
            cur = cur.next;
        }
        
        cur = head;
        while(cur != null) {
            if(cur.random != null) {
                RandomListNode newCur = oldNew[cur];
                newCur.random = oldNew[cur.random];
            }
            cur = cur.next;
        }
        return dummyNewHead.next;
            
        }
    }
}
