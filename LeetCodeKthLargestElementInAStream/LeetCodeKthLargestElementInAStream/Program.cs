using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeKthLargestElementInAStream
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {35, 33, 42, 10, 14, 19, 27, 44, 26, 31};
            int pivot = arr.Length - 1;
            int hi = 0;
            int low = 0;
            int temp = 0;
            hi = pivot - 1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[low] < arr[pivot])
                {
                    low++;
                }

                if (arr[hi] > arr[pivot])
                {
                    hi--;
                }

                temp = arr[low];
                arr[low] = arr[hi];
                arr[hi] = temp;
                low++;
                hi--;
            }
        }
    }
}
