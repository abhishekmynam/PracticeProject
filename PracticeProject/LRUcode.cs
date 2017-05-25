using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LRUcode
    {
        public class Node
        {
            public KeyValuePair<int, int> KeyValue { get; set; }

            public Node Next { get; set; }

            public Node Previous { get; set; }

            public Node(int key, int value)
            {
                this.KeyValue = new KeyValuePair<int, int>(key, value);
                Next = null;
                Previous = null;
            }
        }
        public class LRUCache
        {
            private readonly int capacity;

            private int count;
            private readonly Node head;
            private readonly Dictionary<int, Node> myDictionary;
            public LRUCache(int capacity)
            {
                head = new Node(-1, -1);
                head.Next = head;
                head.Previous = head;
                this.capacity = capacity;
                myDictionary = new Dictionary<int, Node>();
            }

            public int Get(int key)
            {
                Node node;
                myDictionary.TryGetValue(key, out node);
                if (node == null)
                {
                    return -1;
                }

                this.MoveItToFirstElementAfterHead(node);

                return node.KeyValue.Value;
            }

            public void Put(int key, int value)
            {
                Node node;
                myDictionary.TryGetValue(key, out node);
                if (node == null)
                {
                    if (this.count == this.capacity)
                    {
                        // remove the last element
                        myDictionary.Remove(head.Previous.KeyValue.Key);
                        head.Previous = head.Previous.Previous;
                        head.Previous.Next = head;

                        count--;
                    }

                    // create new node and add to dictionary
                    var newNode = new Node(key, value);
                    myDictionary[key] = newNode;

                    this.InsertAfterTheHead(newNode);

                    // increase count
                    count++;
                }
                else
                {
                    node.KeyValue = new KeyValuePair<int, int>(key, value);
                    this.MoveItToFirstElementAfterHead(node);
                }
            }

            private void MoveItToFirstElementAfterHead(Node node)
            {
                RemoveCurrentNode(node);

                this.InsertAfterTheHead(node);
            }

            private void InsertAfterTheHead(Node node)
            {
                // insert after the head
                node.Next = this.head.Next;
                node.Previous = this.head;
                this.head.Next.Previous = node;
                this.head.Next = node;
            }

            private static void RemoveCurrentNode(Node node)
            {
                // remove current node
                node.Previous.Next = node.Next;
                node.Next.Previous = node.Previous;
            }
        }
    }
}
