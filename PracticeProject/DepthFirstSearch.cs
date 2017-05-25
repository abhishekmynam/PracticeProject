using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class DepthFirstSearch
    {
        public class Person
        {
            public Person(string name)
            {
                this.name = name;
            }

            public string name { get; set; }
            public List<Person> Friends
            {
                get
                {
                    return FriendsList;
                }
            }

            public void isFriendOf(Person p)
            {
                FriendsList.Add(p);
            }

            List<Person> FriendsList = new List<Person>();

            public override string ToString()
            {
                return name;
            }
        }

        public class DepthFirstAlgorithm
        {
            public Person BuildFriendGraph()
            {
                Person Aaron = new Person("Aaron");
                Person Betty = new Person("Betty");
                Person Brian = new Person("Brian");
                Aaron.isFriendOf(Betty);
                Aaron.isFriendOf(Brian);

                Person Catherine = new Person("Catherine");
                Person Carson = new Person("Carson");
                Person Darian = new Person("Darian");
                Person Derek = new Person("Derek");
                Betty.isFriendOf(Catherine);
                Betty.isFriendOf(Darian);
                Brian.isFriendOf(Carson);
                Brian.isFriendOf(Derek);

                return Aaron;
            }

            public Person Search(Person root, string nameToSearchFor)
            {
                if (nameToSearchFor == root.name)
                    return root;

                Person personFound = null;
                for (int i = 0; i < root.Friends.Count; i++)
                {
                    personFound = Search(root.Friends[i], nameToSearchFor);
                    if (personFound != null)
                        break;
                }
                return personFound;
            }

            public void Traverse(Person root)
            {
                Console.WriteLine(root.name);
                for (int i = 0; i < root.Friends.Count; i++)
                {
                    Traverse(root.Friends[i]);
                }
            }
        }

        public void depthFirstSearch(string[] args)
        {
            DepthFirstAlgorithm b = new DepthFirstAlgorithm();
            Person root = b.BuildFriendGraph();
            Console.WriteLine("Traverse\n------");
            b.Traverse(root);

            Console.WriteLine("\nSearch\n------");
            Person p = b.Search(root, "Catherine");
            Console.WriteLine(p == null ? "Person not found" : p.name);
            p = b.Search(root, "Alex");
            Console.WriteLine(p == null ? "Person not found" : p.name);
        }
    }
}
