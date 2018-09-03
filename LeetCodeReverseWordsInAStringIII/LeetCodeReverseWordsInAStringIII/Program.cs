using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeReverseWordsInAStringIII
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
             * Given a string, you need to reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.

                Example 1:

                Input: "Let's take LeetCode contest"
                Output: "s'teL ekat edoCteeL tsetnoc"
             * 
             */
            Console.WriteLine(ReverseWords("Let's take LeetCode contest"));
            Console.ReadLine();
        }

        public static string ReverseWords(string s)
        {
            string finalString = "";
            string[] words = s.Split(' ');
            finalString += ReverseWord(words[0]);
            for (int i = 1; i < words.Length; i++)
            {
                finalString += " " + ReverseWord(words[i]);
            }
            return finalString;
        }

        public static string ReverseWord(string word)
        {
            char[] arr = word.ToCharArray();
            string stringToReturn = "";
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                stringToReturn += arr[i];
            }
            return stringToReturn;
        }
    }
}