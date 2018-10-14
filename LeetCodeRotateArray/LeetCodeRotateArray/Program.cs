using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRotateArray
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new int[] { -1, -100, 3, 99 };

            Rotate(arr, 2);

            foreach (var x in arr)
            {
                Console.Write(x + "\t");
            }

            Console.ReadLine();
        }

        public static void Rotate(int[] nums, int k)
        {
            var tmp = 0;
            for (var i = 0; i < k; i++)
            {
                tmp = nums[i];
                nums[i] = nums[nums.Length - k + i];
                nums[nums.Length - k + i] = tmp;
            }
        }
    }
}