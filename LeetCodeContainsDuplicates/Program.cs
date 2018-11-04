using System;
using System.Collections;
using System.Collections.Generic;

namespace LeetCodeContainsDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }));
            Console.Read();
        }

        public static bool ContainsDuplicate(int[] nums)
        {
            var list = new List<int>();
            for (var i = 0; i < nums.Length; i++)
            {
                if (list.Contains(nums[i]))
                {
                    return true;
                }
                else
                {
                    list.Add(nums[i]);
                }
            }
            return false;
        }
    }
}