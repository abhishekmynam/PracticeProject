using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexDataTypes
{
    public class DataStructures
    {
        public class NodeLinkedList
        {
            public object data;
            public NodeLinkedList Next;

            public NodeLinkedList(object inData)
            {
                data = inData;
                Next = null;
            }

            public void AddNode(object inData)
            {
                if (Next == null)
                {
                    Next = new NodeLinkedList(inData);
                }
                else 
                {
                    Next.AddNode(inData);
                }
            }
        }

        public class Queue
        {
            public NodeLinkedList head;
            public Queue()
            {
                head = null;
            }

            public void AddToQueue(object data)
            {
                if (head == null)
                {
                    head = new NodeLinkedList(data);
                }
                else
                {
                    head.AddNode(data);
                }
            }

            public void DeleteFromQueue()
            {
                
                if (head != null)
                {
                    head = head.Next;
                }
            }

            
        }

        public class Stack
        {
            public NodeLinkedList head;
            public Stack()
            {
                head = null;
            }
            public void AddToStack(object data)
            {
                if (head == null)
                {
                    head = new NodeLinkedList(data);
                }
                else
                {
                    NodeLinkedList tempNode = new NodeLinkedList(data);
                    tempNode.Next = head;
                    head = tempNode;
                }
            }
            public void RemoveFromStack()
            {
                NodeLinkedList tempNode = new NodeLinkedList(head.data);
                
                while (head.Next != null)
                {
                    tempNode.Next = head.Next;
                    head = head.Next;
                }
                head = tempNode;
            }
        }

        public class NodeTree
        {
            public float value;
            public NodeTree left;
            public NodeTree right;

            public NodeTree(float initial)
            {
                value = initial;
                left = null;
                right = null;
            }
        }
        
        public class BinaryTree
        {
            NodeTree top;
            public BinaryTree()
            {
                top = null;
            }

            public void AddNode(float value)
            { 
                AddNodeInPos(ref top, value);
            }

            private void AddNodeInPos(ref NodeTree Node, float value)
            {
                if (Node == null)
                {
                    NodeTree newNode = new NodeTree(value);
                    Node = newNode;
                    return;
                }
                else if(value < Node.value)
                {
                    AddNodeInPos(ref Node.left, value);
                    return;
                }
                else if (value > Node.value)
                {
                    AddNodeInPos(ref Node.right, value);
                    return;
                }
            }

            //public void DeleteNodeWithValue(float value)
            //{
            //    NodeTree tempNode;

            //    NodeTree finalNode = new NodeTree(top.value);

            //    tempNode = new NodeTree(top.value);
            //    if (value > top.value)
            //    {
            //        tempNode.left = top.left;
            //        top = top.right;
            //    }
            //    else if (value < top.value)
            //    {
            //        tempNode.right = top.right;
            //        top = top.left;
            //    }

            //    if(tem)
                
            //}

            public bool SearchValue(float value)
            {
                NodeTree tempNode = top;
                while (tempNode.value != null)
                {
                    if (value == tempNode.value) { return true; }
                    else if (value > tempNode.value) { tempNode = tempNode.right; }
                    else if (value < tempNode.value) { tempNode = tempNode.left; }
                }
                return false;
            }

            public int HopsBetweenNodes(float val1, float val2)
            {
                int hop = 0;
                bool countFlag = false;
                if (val1 > val2)
                {
                    float temp = 0;
                    val1 = temp;
                    val1 = val2;
                    val2 = temp;
                }
                NodeTree tempNode = top;
                NodeTree rightNode = null;

                while (tempNode.value != null)
                {
                    if (tempNode.value > val1 && tempNode.value < val2 && !countFlag)
                    {
                        countFlag = true;
                        rightNode = tempNode.right;
                        tempNode = tempNode.left;
                    }
                    else if (tempNode.value > val1)
                    {
                        tempNode = tempNode.right;
                        if (countFlag)
                        {
                            hop++;
                        }
                    }
                    else if (tempNode.value < val1)
                    {
                        tempNode = tempNode.left;
                        if (countFlag)
                        {
                            hop++;
                        }
                    }
                }
                tempNode = rightNode;
                while (tempNode.value != null)
                {
                    if (tempNode.value > val1)
                    {
                        tempNode = tempNode.right;
                        hop++;

                    }
                    else if (tempNode.value < val1)
                    {
                        tempNode = tempNode.left;
                        hop++;
                    }
 
                }
                return hop;
            }
        }


    }
}
