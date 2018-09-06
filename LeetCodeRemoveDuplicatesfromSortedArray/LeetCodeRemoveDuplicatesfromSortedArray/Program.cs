using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRemoveDuplicatesfromSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Given a sorted array nums, remove the duplicates in-place such that each element appear only once and return the new length.
                Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.
                
                Example 1:
                Given nums = [1,1,2],
                
                Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.
                It doesn't matter what you leave beyond the returned length.
             */
            Console.WriteLine(RemoveDuplicates(new int[] { 1, 1,  2 }));
            Console.ReadLine();
        }

        public static int RemoveDuplicates(int[] nums)
        {
            int counter = nums.Length;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i+ 1 == nums.Length) break;                

                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                    {
                        counter--;
                        break;
                    }
                }
            }
            return counter;
        }
    }
}
