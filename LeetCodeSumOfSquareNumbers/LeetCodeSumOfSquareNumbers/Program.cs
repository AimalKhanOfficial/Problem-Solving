using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSumOfSquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(JudgeSquareSum(5));
            Console.ReadLine();
        }

        public static bool JudgeSquareSum(int c)
        {
            int counter = 1;
            int sum = 0;
            while (sum <= c)
            {
                if (sum == c)
                {
                    return true;
                }
                sum = (counter*counter) + ((counter + 1)*(counter + 1));
                counter++;
            }
            return false;
        }
    }
}
