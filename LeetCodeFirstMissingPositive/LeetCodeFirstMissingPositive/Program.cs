using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeFirstMissingPositive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FirstMissingPositive(new int[] { 7, 8, 9, 11, 12 }));
            Console.ReadLine();
        }

        public static int FirstMissingPositive(int[] nums)
        {
            //3, 4, -1, 1
            Array.Sort(nums);
            //-1, 1, 3, 4

            for (var i = 0; i < nums.Length; i++)
            {
                if (i + 1 == nums.Length)
                {
                    break;
                }

                if (nums[i] < 1)
                {
                    continue;
                }

                if (Math.Abs(nums[i] - nums[i + 1]) > 1)
                {
                    return nums[i] + 1;
                }
            }
            return 0;
        }
    }
}
