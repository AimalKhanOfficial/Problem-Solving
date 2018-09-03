using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSingleNumber
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            /*
                * Given a non-empty array of integers, every element appears twice except for one. Find that single one.
                Note:
                Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?

                Example 1:
                Input: [2,2,1]
                Output: 1

             */

            Console.WriteLine(SingleNumber(new int[] {2, 2, 1, 4, 4, 4, 6, 5, 5, 7, 7, 6}));
            Console.Read();
        }

        //Accepted - Solutions beats 58% of leetCode submissions - o(n)
        public static int SingleNumber(int[] nums)
        {
            var records = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (records.ContainsKey(nums[i]))
                {
                    int value = records[nums[i]];
                    value++;
                    records[nums[i]] = value;
                }
                else
                {
                    records.Add(nums[i], 1);
                }
            }
            return records.FirstOrDefault(a=> a.Value == 1).Key;
        }
    }
}