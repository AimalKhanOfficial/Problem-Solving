using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfluenceHealth
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(isNotPrime(67));
            Console.ReadLine();
        }

        public static bool isNotPrime(int num)
        {
            for (var i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
