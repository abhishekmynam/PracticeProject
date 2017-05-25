using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class LFUCache
    {
        private Node head = null;
        private int cap = 0;
        private Dictionary<int, int> valueHash = null;
        private Dictionary<int, Node> nodeHash = null;

        public LFUCache(int capacity)
        {
            this.cap = capacity;
            valueHash = new Dictionary<int, int>();
            nodeHash = new Dictionary<int, Node>();
        }

        public int get(int key)
        {
            if (valueHash[key] != null)
            {
                increaseCount(key);
                return valueHash[key];
            }
            return -1;
        }

        public void set(int key, int value)
        {
            if (cap == 0) return;
            if (valueHash[key]!= null)
            {
                valueHash.Add(key, value);
            }
            else
            {
                if (valueHash.Count() < cap)
                {
                    valueHash.Add(key, value);
                }
                else
                {
                    removeOld();
                    valueHash.Add(key, value);
                }
                addToHead(key);
            }
            increaseCount(key);
        }

        private void addToHead(int key)
        {
            if (head == null)
            {
                head = new Node(0);
                head.keys.Add(key);
            }
            else if (head.count > 0)
            {
                Node node = new Node(0);
                node.keys.Add(key);
                node.next = head;
                head.prev = node;
                head = node;
            }
            else
            {
                head.keys.Add(key);
            }
            nodeHash.Add(key, head);
        }

        private void increaseCount(int key)
        {
            Node node = nodeHash[key];
            node.keys.Remove(key);

            if (node.next == null)
            {
                node.next = new Node(node.count + 1);
                node.next.prev = node;
                node.next.keys.Add(key);
            }
            else if (node.next.count == node.count + 1)
            {
                node.next.keys.Add(key);
            }
            else
            {
                Node tmp = new Node(node.count + 1);
                tmp.keys.Add(key);
                tmp.prev = node;
                tmp.next = node.next;
                node.next.prev = tmp;
                node.next = tmp;
            }

            nodeHash.Add(key, node.next);
            if (node.keys.Count() == 0) remove(node);
        }

        private void removeOld() {
        if (head == null) return;
        int old = 0;
        foreach (int n in head.keys) {
            old = n;
            break;
        }
        head.keys.Remove(old);
        if (head.keys.Count() == 0) remove(head);
        nodeHash.Remove(old);
        valueHash.Remove(old);
    }

        private void remove(Node node)
        {
            if (node.prev == null)
            {
                head = node.next;
            }
            else
            {
                node.prev.next = node.next;
            }
            if (node.next != null)
            {
                node.next.prev = node.prev;
            }
        }

        class Node
        {
            public int count = 0;
            public List<int> keys = null;
            public Node prev = null, next = null;

            public Node(int count)
            {
                this.count = count;
                keys = new List<int>();
                prev = next = null;
            }
        }
    }
}
