using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMergeSortedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Merge(new int[] {1, 2, 3, 0, 0, 0}, 3, new int[] {2, 5, 6}, 3);
            Console.ReadLine();
        }

        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            List<int> values = new List<int>();

            for (int i = 0; i < m; i++)
            {
                values.Add(nums1[i]);
            }

            for (int i = 0; i < n; i++)
            {
                values.Add(nums2[i]);
            }

            values.Sort();

            for (int i = 0; i < values.Count; i++)
            {
                nums1[i] = values[i];
            }
        }
    }
}
