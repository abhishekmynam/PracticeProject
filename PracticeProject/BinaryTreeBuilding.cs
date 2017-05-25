using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    public class BinaryTreeBuilding
    {
        public class Node
        {
            public int value;
            public Node left;
            public Node right;

            public Node(int initial) 
            {
                value = initial;
                left = null;
                right = null;
            }
        }

        public class Tree
        {
            Node top;
            public Tree()
            {
                top = null;
            }

            public Tree(int initial)
            {
                top = new Node(initial);
            }

            public bool searchValue(Tree thisTree, int value) 
            {
                bool found = false;
                Node thisNode = new Node(thisTree.top.value);
                thisNode = thisTree.top;
                
                do
                {
                    if (thisNode == null) return false;
                    if (value < thisNode.value)
                    {
                        thisNode = thisNode.left;
                    }
                    else if (value > thisNode.value)
                    {
                        thisNode = thisNode.right;
                    }
                    else if (value == thisNode.value)
                    {
                        found = true;
                    }
                } while (!found);
                return found;
            }


            public void AddNewNode(int value)
            {
                if (top == null) 
                {
                    Node newNode = new Node(value);
                    top = newNode;
                    return;
                }
                Node currentNode = top;
                bool added = false;
                do
                {
                    if (value < currentNode.value)
                    {
                        if (currentNode.left == null)
                        {
                            Node newNode = new Node(value);
                            currentNode.left = newNode;
                            added = true;
                        }
                        else 
                        {
                            currentNode = currentNode.left;
                        }
                    }
                    else if (value >= currentNode.value)
                    {
                        if (currentNode.right == null)
                        {
                            Node newNode = new Node(value);
                            currentNode.right = newNode;
                            added = true;
                        }
                        else 
                        {
                            currentNode = currentNode.right;
                        }
                    }
                } while (!added);
            }

            public void AddNewNodeInner(int value)
            { 
                AddInner(ref top, value);
            }

            private void AddInner(ref Node N, int value)
            {
                if (N == null)
                {
                    Node newNode = new Node(value);
                    N = newNode;
                    return;
                }

                if (value < N.value) 
                {
                    AddInner(ref N.left, value);
                    return;
                }
                else if (value >= N.value)
                {
                    AddInner(ref N.right, value);
                    return;
                }
            }
            public void print(Node N, ref string thisString)
            {
                if (N == null)
                {
                    N = top;
                }
                if (N.left != null)
                {
                    print(N.left, ref thisString);
                    thisString = thisString + N.value.ToString().PadLeft(3);
                }
                else 
                {
                    thisString = thisString + N.value.ToString().PadLeft(3);
                }
                if (N.right != null)
                {
                    print(N.right, ref thisString);
                }
            }
        }
       
    }

    public class treeOps
    {
        public BinaryTreeBuilding.Tree treeOperations() 
        {
            BinaryTreeBuilding.Tree myTree = new BinaryTreeBuilding.Tree(5);
            myTree.AddNewNodeInner(8);
            myTree.AddNewNodeInner(9);
            myTree.AddNewNodeInner(45);
            myTree.AddNewNodeInner(-1);
            myTree.AddNewNodeInner(-99);
            myTree.AddNewNodeInner(88);
            myTree.AddNewNodeInner(66);
            myTree.AddNewNodeInner(87);
            myTree.AddNewNodeInner(12);
            myTree.AddNewNodeInner(0);

            return myTree;
            /*

            string treeString = "";
            myTree.print(null, ref treeString);*/
        }
   

    }
}
