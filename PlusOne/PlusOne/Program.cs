using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusOne
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            foreach (var d in PlusOne(new int[] {9, 8, 7, 6, 5, 4, 3, 2, 1, 0}))
            {
                Console.Write(d);
            }
            Console.ReadLine();
        }

        public static int[] PlusOne(int[] digits)
        {
            long sum = 0;
            long multiplier = 1;

            for (int i = digits.Length - 1 ; i >= 0; i--)
            {
                sum = sum + (digits[i]*multiplier);
                multiplier = multiplier*10;
            }

            sum++;
            long copyOfSum = sum;
            int counterArrayRequired = 0;

            //An estimate of required array length to return
            while (copyOfSum > 0)
            {
                counterArrayRequired++;
                copyOfSum = copyOfSum / 10;
            }

            int[] toReturn = new int[counterArrayRequired];
            int returnArrCounter = 0;
            long tmp;
            while (sum > 0)
            {
                tmp = sum%10;
                toReturn[returnArrCounter] = (int)tmp;
                returnArrCounter++;
                sum = sum/10;
            }


            int[] finalArray = new int[counterArrayRequired];
            int finalCounter = 0;
            for (int i = toReturn.Length -1 ; i >= 0; i--)
            {
                finalArray[finalCounter] = toReturn[i];
                finalCounter++;
            }

            return finalArray;
        }
    }
}