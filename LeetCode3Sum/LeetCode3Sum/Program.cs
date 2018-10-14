using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode3Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //-1, 0, 1, 2, -1, -4    -- [-1, 0, 1], [-1, -1, 2]
            //-2, 0, 1, 1, 2  -- [-2,0,2], [-2,1,1]

            foreach (var VARIABLE in ThreeSum(new int[] { -1, 0, 1, 2, -1, -4 }))
            {
                foreach (var x in VARIABLE)
                {
                   Console.Write(x + "\t"); 
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            List<string> recordCheck = new List<string>();
            IList<IList<int>> list = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (i + 1 == nums.Length)
                    {
                        break;
                    }
                    for (int k = j + 1; k < nums.Length; k++)
                    {

                        if (j + 1 == nums.Length)
                        {
                            break;
                        }

                        if (nums[i] + nums[j] + nums[k] == 0)
                        {
                            IList<int> newList = new List<int>();
                            newList.Add(nums[i]);
                            newList.Add(nums[j]);
                            newList.Add(nums[k]);
                            if (recordCheck.Exists(a => a.ToString().StartsWith(Math.Abs(nums[i]) + "")) || recordCheck.Exists(a => a.ToString().EndsWith(Math.Abs(nums[k]) + "")))
                            {
                                list.Add(newList);
                                recordCheck.Add(Math.Abs(nums[i]) + "" + Math.Abs(nums[j]) + "" + Math.Abs(nums[k]));
                            }
                        }
                    }
                }
            }
            return list;
        }
    }
}
