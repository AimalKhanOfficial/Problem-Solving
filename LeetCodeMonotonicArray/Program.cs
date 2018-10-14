using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMonotonicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsMonotonic(new int[] { 3, 2, 2 }));
            Console.ReadLine();
        }

        public static bool IsMonotonic(int[] A)
        {
            if (A.Length == 1)
            {
                return true;
            }

            //0 - Check for Monotonic in increasing order
            //1 - Check for Monotonic in decreasing order
            int pathToFollow = 0;


            for (var i = 0; i < A.Length; i++)
            {
                if (i + 1 == A.Length)
                {
                    break;
                }

                if (A[i] == A[i+1])
                {
                    continue;
                }
                else if (A[i] > A[i + 1])
                {
                    pathToFollow = 1;
                }
                else if (A[i] < A[i + 1])
                {
                    pathToFollow = 0;
                }
            }

            if (pathToFollow == 1)
            {
                for (var i = 0; i < A.Length; i++)
                {
                    if (i + 1 == A.Length)
                    {
                        break;
                    }

                    if (A[i] < A[i + 1] && A[i] != A[i + 1])
                    {
                        return false;
                    }    
                }
            }
            else
            {
                for (var i = 0; i < A.Length; i++)
                {
                    if (i + 1 == A.Length)
                    {
                        break;
                    }

                    if (A[i] > A[i + 1] && A[i] != A[i + 1])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
