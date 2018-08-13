using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrieApplication
{
    internal class Trie
    {
        private List<String> _words = new List<string>();

        /** Initialize your data structure here. */

        public Trie()
        {
        }

        /** Inserts a word into the trie. */

        public void Insert(string word)
        {
            _words.Add(word);
        }

        /** Returns if the word is in the trie. */

        public bool Search(string word)
        {
            if (_words.Contains(word))
            {
                return true;
            }
            return false;
        }

        /** Returns if there is any word in the trie that starts with the given prefix. */

        public bool StartsWith(string prefix)
        {
            Char[] wordToLookFor = prefix.ToCharArray();
            int counterFinder = 0;
            Boolean wordFound = false;
            foreach (var word in _words)
            {
                if (word.Length < prefix.Length)
                {
                    return wordFound;
                }

                Char[] wordArr = word.ToCharArray();
                foreach (var alphabet in wordArr)
                {
                    if (counterFinder < wordToLookFor.Length)
                    {
                        if (alphabet == wordToLookFor[counterFinder])
                        {
                            wordFound = true;
                            counterFinder++;
                        }
                        else
                        {
                            wordFound = false;
                        }
                    }
                }
                
                if (wordFound)
                {
                    return wordFound;
                }
                counterFinder = 0;
            }
            return wordFound;
        }
    }
}