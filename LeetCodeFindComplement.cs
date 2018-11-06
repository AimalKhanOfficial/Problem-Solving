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
            Console.WriteLine(FindComplement(2));
            Console.Read();
        }

        public static int FindComplement(int num)
        {
            string paramBinary = "";
            while (num > 0)
            {
                paramBinary += num % 2;
                num = num / 2;
            }
            num = 0;
            for (var i = 0; i < paramBinary.Length; i++)
            {
                int toMultiply = Convert.ToInt32(paramBinary[i].ToString() == "0" ? 1 : 0);
                if (toMultiply == 0 && i == 0) continue;
                num += (toMultiply) * 2;
            }

            return num;
        }
    }
}