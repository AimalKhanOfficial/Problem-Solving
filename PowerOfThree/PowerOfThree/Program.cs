using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPowerOfThree(45));
            Console.ReadLine();
        }

        public static bool IsPowerOfThree(int n)
        {
            if (n < 3) return false;

            int result = n % 3;
            float res = n%3;
            if (result == 0) return true;

            return false;
        }
    }
}
