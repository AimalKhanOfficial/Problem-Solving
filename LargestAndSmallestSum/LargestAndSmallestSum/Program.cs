using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestAndSmallestSum
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int GivenFunction(int input1, int[] input2)
        {
            int max = 0;
            for (int i = 0; i < input1; i++)
            {
                if (input2[i] >= max)
                {
                    max = input2[i];
                }
            }

            int min = max;
            for (int i = 0; i < input1; i++)
            {
                if (input2[i] < min)
                {
                    min = input2[i];
                }
            }

            return max + min;
        }
    }
}
