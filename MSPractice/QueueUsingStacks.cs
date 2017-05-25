using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPractice
{
    class QueueUsingStacks
    {
        Stack<int> stack1 = new Stack<int>();
        Stack<int> stack2 = new Stack<int>();
        // Push element x to the back of queue.
        public void push(int x)
        {
            while (stack1.Count() != 0) 
            {
                stack2.Push(stack1.Pop());
            }
            stack1.Push(x);
            while (stack2.Count() != 0)
            {
                stack1.Push(stack2.Pop());
            }
        }

        // Removes the element from in front of queue.
        public void pop()
        {
            stack1.Pop();
        }

        // Get the front element.
        public int peek()
        {
            return stack1.Peek();
        }

        // Return whether the queue is empty.
        public bool empty()
        {
            return stack1.Count()==0;
        }
    }
}
