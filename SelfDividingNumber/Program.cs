using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfDividingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var selfDivNums in SelfDividingNumbers(1, 22))
            {
                Console.WriteLine(selfDivNums);
            }
            Console.ReadLine();
        }

        public static IList<int> SelfDividingNumbers(int left, int right)
        {
            IList<int> selfDividingNumbers = new List<int>();
            bool flag = false;
            for (var i = left; i <= right; i++)
            {
                if (i.ToString().Contains("0"))
                {
                    continue;
                }
                var eachNumber = i.ToString().ToCharArray();
                for (var j = 0; j < eachNumber.Length; j++)
                {
                    flag = false;
                    if (i % Convert.ToInt32(eachNumber[j].ToString()) != 0)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    selfDividingNumbers.Add(i);
                }
            }
            return selfDividingNumbers;
        }
    }
}
