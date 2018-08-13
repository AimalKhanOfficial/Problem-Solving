using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetCodeImplementstrStr
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Implement strStr().
            //Return the index of the first occurrence of needle in haystack, or - 1 if needle is not part of haystack.

            // Example 1:
            //Input: haystack = "hello", needle = "ll"

            //Output: 2


            //Example 2:
            //Input: haystack = "aaaaa", needle = "bba"
            //Output: -1

            //Clarification:
            //What should we return when needle is an empty string? This is a great question to ask during an interview.

            Console.WriteLine(StrStr("hello", "ll"));
            Console.ReadLine();
        }

        public static int StrStr(string haystack, string needle)
        {
            if (haystack.Contains(needle))
            {
                return haystack.IndexOf(needle, StringComparison.Ordinal);
            }
            return -1;
        }
    }
}