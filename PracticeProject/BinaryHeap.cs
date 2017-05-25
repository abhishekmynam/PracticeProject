using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class BinaryHeap
    {
        public class Node
        {
            public int data;
            public Node parent;
            public Node left;
            public Node right;
            public Node(int d, Node p)
            {
                data = d;
                parent = p;
            }
            public Node(Node p)
            {
                parent = p;
            }
            public Node(int d)
            {
                data = d;
            }
            public Node()
            {

            }
        }﻿
        public class Heap
        {
            public Node root;
            public Node pointer;
            public int count;
            public Heap(Node[] nodes)
            {
                count = 0;
                for (int i = 0; i < nodes.Count(); i++)
                {
                    Add(nodes[i]);
                }
            }

            public void Add(Node node)
            {
                if (root == null)
                {
                    root = node;
                    count++;
                }
                else 
                {
                    pointer = root;
                    string bitCount = Convert.ToString(count + 1, 2);
                    for (int i = 1; i < bitCount.Length; i++)
                    {
                        if (bitCount[i] == '0')
                        {
                            if (pointer.left == null)
                            {
                                pointer.left = new Node(pointer);//emptynode creation
                            }
                            pointer = pointer.left;
                        }
                        else 
                        {
                            if (pointer.right == null)
                            {
                                pointer.right = new Node(pointer);
                            }
                            pointer = pointer.right;
                        }
                    }
                    pointer.data = node.data;

                    while (true)
                    {
                        if (pointer == root)
                        {
                            break;
                        }
                        if (pointer.data < pointer.parent.data)
                        {
                            int temp = pointer.data;
                            pointer.data = pointer.parent.data;
                            pointer.parent.data = temp;
                            pointer = pointer.parent;
                        }
                        else 
                        {
                            break;
                        }
                    }
                    count++;
                }
            }
            public void Remove()
            {
                int output = root.data;
                pointer = root;
                string bitcount = Convert.ToString(count, 2);
                for (int i = 0; i < count; i++)
                {
                    if (bitcount[i] == '0')
                    {
                        pointer = pointer.left;
                    }
                    else 
                    {
                        pointer = pointer.right;
                    }
                }
                root.data = pointer.data; //last filled node

                if (pointer.parent.left == pointer)
                {
                    pointer.parent.left = null;
                }
                else
                {
                    pointer.parent.right = null;
                }

                count--;
                Heapify();
            }
            public void Heapify()
            {
                Node compare;
                pointer = root;
                while (true) 
                {
                    if (pointer.left == null) break;
                    if (pointer.right == null)
                    {
                        compare = pointer.left;
                    }
                    else 
                    {
                        if (pointer.left.data <= pointer.right.data)
                        {
                            compare = pointer.left;
                        }
                        else
                        {
                            compare = pointer.right;
                        }
                    }
                    if (pointer.data > compare.data)
                    {
                        int temp = pointer.data;
                        pointer.data = compare.data;
                        compare.data = temp;
                        pointer = compare;
                    }
                    else 
                    {
                        break;
                    }
                }
            }
        }
    }
}
