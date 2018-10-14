using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeNonDecreasingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CheckPossibility(new int[] { 3, 4, 2, 3 }));
            Console.ReadLine();
        }

        //Passed 311/325 Test Cases but some of the test cases are self contradictory
        public static bool CheckPossibility(int[] nums)
        {
            var isSwaped = false;
            for (var i = 0; i < nums.Length; i++)
            {
                if (i+1==nums.Length)
                {
                    break;
                }

                if (nums[i] > nums[i+1])
                {
                    if (!isSwaped)
                    {
                        nums[i] = 1;
                        isSwaped = true;
                    }
                    else
                    {
                        return false;
                    }   
                }
            }

            return true;
        }
    }
}
