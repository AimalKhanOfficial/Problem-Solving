using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMajorityElement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
            Console.ReadLine();
        }
        public static int MajorityElement(int[] nums)
        {
            IDictionary<int, int> records = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (records.ContainsKey(nums[i]))
                {
                    int count;
                    records.TryGetValue(nums[i], out count);
                    records[nums[i]] = count + 1;
                }
                else
                {
                    records.Add(nums[i], 1);
                }
            }
            return records.FirstOrDefault(a => a.Value > Math.Floor(Convert.ToDecimal(nums.Length) / 2)).Key;
        }
    }
}
