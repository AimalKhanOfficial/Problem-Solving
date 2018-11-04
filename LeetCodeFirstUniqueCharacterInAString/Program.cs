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
            Console.WriteLine(FirstUniqChar("dddccdbba"));
            Console.Read();
        }

        //https://leetcode.com/submissions/detail/187412465/
        //Run time beats almost 67% of total submissions
        public static int FirstUniqChar(string s)
        {
            if (s.Length == 1) return 0;
            var isDuplicate = false;
            for (var i = 0; i < s.Length; i++)
            {
                isDuplicate = false;
                for (var j = 0; j < s.Length; j++)
                {
                    if (i == j) continue;
                    if (s[j] == s[i])
                    {
                        isDuplicate = true;
                        break;
                    }
                }
                if (!isDuplicate) return i;
            }
            return -1;
        }
    }
}