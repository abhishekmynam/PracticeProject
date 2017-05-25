using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LinkedListStackQueue
    {
        public class Node
        {
            public Node Next;
            public object Value;
        }
        public class LinkedList
        {
            public LinkedList()
            {
                head = new Node();
                current = head;
            }
            private Node head;
            private Node current;
            public int Count;
            public void AddAtLast(object data)
            {
                Node newNode = new Node();
                newNode.Value = data;
                current.Next = newNode;
                current = newNode;
                Count++;
            }

            public void AddAtStart(object data)
            {
                Node newNode = new Node() { Value = data };
                newNode.Next = head.Next;
                head.Next = newNode;
                Count++;
            }

            public void RemoveFromStart()
            {
                if (Count > 0)
                {
                    head.Next = head.Next.Next;
                    Count--;
                }
                else
                {
                    Console.WriteLine("No element exist in this linked list.");
                }
            }


            public void PrintAllNodes()
            {
                Node curr = head;
                while (curr.Next != null)
                {

                }
                Console.Write("NULL");
            }

        }

        public class LinkedListInbuildUsage
        {
            public void LinkedListInbuiltMethodUsage()
            {
                var listOffences = new LinkedList<string>();
                var firstNode = listOffences.AddFirst("aaa");
                var secondNode = listOffences.AddAfter(firstNode, "bbb");
                var thirdNode = listOffences.AddAfter(secondNode, "ccc");
                var fourthNode = listOffences.AddBefore(thirdNode, "ddd");
                int thisCount = listOffences.Count();
                string thisLoc = listOffences.ElementAt(2);
                listOffences.RemoveFirst();
                listOffences.RemoveLast();
                listOffences.Remove("bbb");

            }
            public struct randomObj
            {
                public int id;
                public string name;
                public double value;
            }

            public void LinkedListWithObjUsage()
            {
                LinkedList<randomObj> listObjs = new LinkedList<randomObj>();
                randomObj thisObj = new randomObj();
                thisObj.id = 1;
                thisObj.name = "Abhishek";
                thisObj.value = 77.5;

                var firstNode = listObjs.AddFirst(thisObj);

                thisObj.id = 2;
                thisObj.name = "Abhishek2";
                thisObj.value = 77.52;

                var secondNode = listObjs.AddAfter(firstNode, thisObj);
                thisObj.id = 3;
            }
        }
    }


}
