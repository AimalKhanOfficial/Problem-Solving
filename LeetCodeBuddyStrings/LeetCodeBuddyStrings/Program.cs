using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeBuddyStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BuddyStrings("aaaaaaabc", "aaaaaaacb"));
            Console.ReadLine();
        }

        public static bool BuddyStrings(string A, string B)
        {
            ArrayList arr2 = new ArrayList();
            char[] arr = A.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (j == arr.Length)
                    {
                        break;
                    }
                    int len = i - 1 < 0 ? 0 : (i - 1);
                    string word = A.Substring(0, len) + arr[j] + arr[i];
                    arr2.Add(word);
                    if (word == B)
                    {
                        //return true;
                    }
                }
            }
            foreach (var x in arr2)
            {
                Console.WriteLine(x);
            }
            return false;
        }
    }
}
