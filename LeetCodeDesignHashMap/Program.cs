using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolving
{
    class Program
    {
        static void Main(string[] args)
        {
            MyHashMap hashMap = new MyHashMap();
            hashMap.Put(1, 1);
            hashMap.Put(2, 2);
            Console.WriteLine(hashMap.Get(1));            // returns 1
            Console.WriteLine(hashMap.Get(3));            // returns -1 (not found)
            hashMap.Put(2, 1);                            // update the existing value
            Console.WriteLine(hashMap.Get(2));            // returns 1 
            hashMap.Remove(2);                            // remove the mapping for 2
            Console.WriteLine(hashMap.Get(2));            // returns -1 (not found) 
            Console.Read();
        }
    }

    public class MyHashMap
    {
        /** Initialize your data structure here. */
        private int Key { get; set; }
        private int Value { get; set; }
        private IList MyListOfValues { get; set; }

        public MyHashMap()
        {
            this.MyListOfValues = new List<MyHashMap>();
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            if (MyListOfValues.Count != 0)
            {
                for (var i = 0; i < MyListOfValues.Count; i++)
                {
                    if ((MyListOfValues[i] as MyHashMap).Key == key)
                    {
                        (MyListOfValues[i] as MyHashMap).Value = value;
                        return;
                    }
                }
            }
            this.MyListOfValues.Add(new MyHashMap()
            {
                Key = key,
                Value = value
            });
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            if (MyListOfValues.Count != 0)
            {
                for (var i = 0; i < MyListOfValues.Count; i++)
                {
                    if ((MyListOfValues[i] as MyHashMap).Key == key)
                    {
                        return (MyListOfValues[i] as MyHashMap).Value;
                    }
                }
            }
            return -1;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            if (MyListOfValues.Count != 0)
            {
                for (var i = 0; i < MyListOfValues.Count; i++)
                {
                    if ((MyListOfValues[i] as MyHashMap).Key == key)
                    {
                        MyListOfValues.Remove(MyListOfValues[i]);
                    }
                }
            }
        }
    }
}