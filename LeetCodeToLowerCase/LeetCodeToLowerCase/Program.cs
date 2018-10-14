using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(ToLowerCase("HeLLo"));
            Console.ReadLine();
        }

        public static string ToLowerCase(string str)
        {
            StringBuilder sb = new StringBuilder();
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 'A' && arr[i] <= 'Z')
                {
                    arr[i] = (char)(arr[i] + 32);
                }
                sb.Append(arr[i]);
            }
            return sb.ToString();
        }
    }
}
