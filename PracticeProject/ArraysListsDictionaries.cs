using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject
{
    class ArraysListsDictionaries
    {
        public void ArrayVSList()
        {
            thisObj[] array = new thisObj[6];
            List<thisObj> list = new List<thisObj>();


            int[] arrayInt = new int[6];
            arrayInt[0] = 5;
            arrayInt[1] = 7;
            Array.Resize<int>(ref arrayInt, 20);//resize takes more time
            int counts = arrayInt.Count();

            List<int> listInt = new List<int>();
            listInt.Add(5);
            listInt.Add(6);
            var values = listInt.Average();
            listInt.Sort();
            //Arraylist is nolonger available

        }
        public void dictionaries()
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            dictionary.Add("cat", 2);
            dictionary.Add("dog", 1);
            dictionary.Add("llama", 0);
            dictionary.Add("iguana", -1);

            Dictionary<string, thisObj> thisDict = new Dictionary<string, thisObj>();
            thisObj obj = new thisObj();
            obj.id = 1;
            obj.name = "name1";
            obj.value = 123;
            thisDict.Add("first", obj);

            obj.id = 2;
            obj.name = "name2";
            obj.value = 1232;
            thisDict.Add("sec", obj);

        }

        public void hashTableUsage()
        {
            Hashtable hashtable = new Hashtable();
            hashtable[1] = "One";
            hashtable[2] = "Two";
            hashtable[13] = "Thirteen";

            foreach (DictionaryEntry entry in hashtable)
            {
                Console.WriteLine("{0}, {1}", entry.Key, entry.Value);
            }
        }
    }
    public struct thisObj
    {
        public int id;
        public string name;
        public float value;
        public int[] reportees;
    }
}
/*

Differences between Hashtable and Dictionary

Dictionary:

Dictionary returns error if we try to find a key which does not exist.
Dictionary faster than a Hashtable because there is no boxing and unboxing.
Dictionary is a generic type which means we can use it with any data type.
Returns error when duplicate entered.


Hashtable:

Hashtable returns null if we try to find a key which does not exist.
Hashtable slower than dictionary because it requires boxing and unboxing.
Hashtable is not a generic type.
Not returns error if inserting duplicate.


Boxing
Implicit conversion of a value type (int, char etc.) to a reference type (object), is known as Boxing. 
In boxing process, a value type is being allocated on the heap rather than the stack.
Unboxing
Explicit conversion of same reference type (which is being created by boxing process); back to a value type is known as unboxing. 
In unboxing process, boxed value type is unboxed from the heap and assigned to a value type which is being allocated on the stack.


 HashSet is an unordered collection containing unique elements. 
 It has the standard collection operations Add, Remove, Contains, but since it uses a hash-based implementation, 
 these operations are O(1). (As opposed to List for example, which is O(n) for Contains and Remove.) 
 HashSet also provides standard set operations such as union, intersection, and symmetric difference


    
Hashtable

Hashtable is basically a data structure to retain values of key-value pair.

It does not allow null for both key and value. It will throw NullPointerException.
Hashtable does not maintain insertion order. The order is defined by the Hash function. So only use this if you do not need data in order.
It is synchronized. It is slow. Only one thread can access in one time.
HashTable rea thread safe.
HashTable uses Enumerator to iterate through elements.
Hashtable<Integer,String>; myTable= new Hashtable<Integer,String>();
myTable.put(1, "John");
myTable.put(2, "Cena");
myTable.put(3, null); /* NullPointerEcxeption at runtime


System.out.println(myTable.get(1));
System.out.println(myTable.get(2));
System.out.println(myTable.get(3));
HashMap

Like Hashtable it also accepts key value pair.

It allows null for both key and value.
HashMap does not maintain insertion order.The order is defined by the Hash function.
It is not synchronized. It will have better performance.
HashMap are not thread safe, but you can use Collections.synchronizedMap(new HashMap<K, V>())
HashMap<Integer, String> myMap = new HashMap<Integer, String>();
myMap.put(1, "First");
myMap.put(2,"Second");
myMap.put(3, null);
HashSet

HashSet does not allow duplicate values.

It provides add method rather put method.
You also use its contain method to check whether the object is already available in HashSet.HashSet can be used where you want to maintain a unique list.
HashSet<String> mySet= new HashSet<String>();
mySet.add("First");
mySet.add("Second");
mySet.add("Third");
 
if(mySet.contains("First")){
	System.out.println("The Set already contains First");
}
 */
