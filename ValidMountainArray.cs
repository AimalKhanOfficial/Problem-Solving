using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ValidMountainArray(new int[] { 1, 3, 2 }));
            Console.Read();
        }

        public static bool ValidMountainArray(int[] A)
        {
            if (A.Length < 3) return false;
            var foundOne = false;
            for (var i = 0; i < A.Length; i++)
            {
                if (i + 1 == A.Length) break;
                if (A[i] > 0 && A[i] < A.Length - 1 && A[i] > A[i + 1])
                {
                    foundOne = true;
                    break;
                }
            }
            return foundOne ? true : false;
        }
    }
}