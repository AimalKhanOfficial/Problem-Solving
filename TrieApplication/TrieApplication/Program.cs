using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieApplication
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //            Implement a trie with insert, search, and startsWith methods.
            //                
            //            Example:
            //
            //            Trie trie = new Trie();
            //
            //            trie.insert("apple");
            //            trie.search("apple"); // returns true
            //            trie.search("app"); // returns false
            //            trie.startsWith("app"); // returns true
            //            trie.insert("app");
            //            trie.search("app"); // returns true
            //
            //            Note:
            //            You may assume that all inputs are consist of lowercase letters a - z.
            //            All inputs are guaranteed to be non - empty strings.


            Trie trie = new Trie();
            trie.Insert("hello");
            Console.WriteLine(trie.Search("hell")); // returns false
            Console.WriteLine(trie.Search("helloa")); // returns false
            Console.WriteLine(trie.Search("hello")); // returns true
            Console.WriteLine(trie.StartsWith("hell")); // returns true
            Console.WriteLine(trie.StartsWith("helloa")); // returns false
            Console.WriteLine(trie.StartsWith("hello"));


            Console.ReadLine();

        }
    }
}