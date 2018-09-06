using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeRemove_Element
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] arr = new[] { 3, 2, 2, 3 };
            int len = RemoveElement(arr, 2);
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Console.ReadLine();
        }
        //0, 1, 2, 2, 3, 0, 4, 2
        public static int RemoveElement(int[] nums, int val)
        {
            int newLength = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    if (i + 1 == nums.Length)
                    {
                        break;
                    }
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[j] != val)
                        {
                            nums[i] = nums[j];
                            nums[j] = val;
                            newLength++;
                            break;
                        }
                    }
                }
                else
                {
                    newLength++;
                }
            }
            return newLength;
        }
    }
}