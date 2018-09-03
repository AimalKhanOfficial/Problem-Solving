using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRankDiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] twoDeeArr = new int[3][] { new int[] {1, 2, 3}, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 }};
            Console.WriteLine(diagonalDifference(twoDeeArr));
            Console.ReadLine();

        }

        static int diagonalDifference(int[][] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; )
                {
                    j = j + 4;
                    Console.Write(arr[i][j] + "\t");
                }
                Console.WriteLine();
            }
            return 0;
        }
    }
}
