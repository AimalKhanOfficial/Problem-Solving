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
            Console.Read();
        }

        public bool RotateString(string A, string B) {
        if (A == B)
            {
                return true;
            }

            for (var i = 0; i < A.Length - 1; i++)
            {
                A = A.Substring(1) + A[0].ToString();
                if (A.Equals(B))
                {
                    return true;
                }
            }
            return false;
    }
    }
}