using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestSubstring
{
    class Program
    {
        List<char> list = new List<char>();

        static void Main(string[] args)
        {

            //Finding the unique alphabets with in a String!! 

            Program program = new Program();
            int len = program.LengthOfLongestSubstring("pwwkew");
            Console.WriteLine("Length: " + len);
            Console.Read();
        }

        public void display(int start, int end, char[] arr)
        {    
            for (int i = start; i < end; i++)
            {
                if (!list.Contains(arr[i]))
                {
                    list.Add(arr[i]);
                }
            }
        }

        public int LengthOfLongestSubstring(String s)
        {
            char[] nameArr = s.ToCharArray();
            //string sequence = "";

            for (int i = 0; i < nameArr.Length; i++)
            {
                for (int j = i + 1; j <= nameArr.Length; j++)
                {
                    if (j == nameArr.Length)
                    {
                        break;
                    }
                   
                    display(i, j, nameArr);
                    Console.WriteLine();
                    //Console.WriteLine(nameArr[j]);
                }
                Console.WriteLine();
            }
            return nameArr.Length;
        }
    }
}
