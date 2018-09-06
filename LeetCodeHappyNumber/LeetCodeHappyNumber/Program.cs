using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeHappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsHappy(12));
            Console.ReadLine();
        }

        public static bool IsHappy(int n)
        {
            HashSet<int> results = new HashSet<int>();
            int sum = 0;
            while (sum != 1)
            {
                sum = 0;
                char[] arr = n.ToString().ToCharArray();
                for (int i = 0; i < arr.Length; i++)
                {
                    sum = sum + (Convert.ToInt32(arr[i].ToString()) * Convert.ToInt32(arr[i].ToString()));
                }
                if (!results.Add(sum)) 
                    return false;
                n = sum;
            }
            return true;
        }
    }
}
