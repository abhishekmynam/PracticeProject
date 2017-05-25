using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class StackOps
    {
        private NodeStack Head;
        private class NodeStack 
        {
            public int val;
            public int min;
            public NodeStack next;
            public NodeStack(int val, int minVal,NodeStack next)
            {
                this.val = val;
                this.min = minVal; 
                this.next = next;
            }
        }
        public void Push(int x)
        {
            int min;
            if (Head == null) { Head = new NodeStack(x, x,null); }
            else
            {
                if (Head.min < x) { min = Head.min; }
                else{min=x;}
                Head = new NodeStack(x,min, Head); 
            }
        }
        public void Pop()
        { Head = Head.next; }
        
        public int Top()
        {
            return Head.val;
        }

        public int GetMin()
        {
            return Head.min;
        }

    }
}
