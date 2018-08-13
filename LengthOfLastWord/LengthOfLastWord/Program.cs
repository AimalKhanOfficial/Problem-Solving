using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LengthOfLastWord("a "));
            Console.ReadLine();
        }

        public static int LengthOfLastWord(string s)
        {
            string[] array = s.Trim().Split(' ');
            return s.Trim().Split(' ')[array.Length - 1].Count();
        }
    }
}
