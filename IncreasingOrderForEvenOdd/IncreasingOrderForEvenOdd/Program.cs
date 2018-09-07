using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingOrderForEvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //9, new int[] { 11, 6, 29, 2, 16, 18, 23, 47, 50 }
            //5, new int[] { 9, 12, 23, 8, 5 }
            foreach (var VARIABLE in arrange(5, new int[] { 9, 12, 23, 8, 5 }))
            {
                Console.WriteLine(VARIABLE);
            }
            Console.Read();
        }

        public static int[] arrange(int input1, int[] input2)
        {
            List<int> evens = new List<int>();
            List<int> odds = new List<int>();

            for (int i = 0; i < input2.Length; i++)
            {
                if (input2[i] % 2 == 0)
                {
                    evens.Add(input2[i]);
                }
                else
                {
                    odds.Add(input2[i]);
                }
            }

            evens.Sort();
            odds.Sort();

            int evenCounter = 0;
            int oddCounter = 0;
            int[] finalArr = new int[evens.Count + odds.Count];

            int genericCounter = 0;
            if (evens[0] < odds[0])
            {
                genericCounter = 0;
                for (int i = 0; i < evens.Count; i++)
                {
                    finalArr[genericCounter] = evens[evenCounter];
                    evenCounter++;
                    genericCounter = genericCounter + 2;
                }
                genericCounter = 1;
                for (int i = 1; i <= odds.Count; i++)
                {
                    finalArr[genericCounter] = odds[oddCounter];
                    oddCounter++;
                    genericCounter = genericCounter + 2;
                }
            }
            else
            {
                genericCounter = 0;
                for (int i = 1; i <= odds.Count; i++)
                {
                    finalArr[genericCounter] = odds[oddCounter];
                    oddCounter++;
                    genericCounter = genericCounter + 2;
                }
                genericCounter = 1;
                for (int i = 0; i < evens.Count; i++)
                {
                    finalArr[genericCounter] = evens[evenCounter];
                    evenCounter++;
                    genericCounter = genericCounter + 2;
                }
            }



//            int genericCounter = 0;
//            while (evenCounter < evens.Count || oddCounter < odds.Count)
//            {
//                if (odds.ElementAt(oddCounter) < evens[evenCounter])
//                {
//                    finalArr[genericCounter] = odds.ElementAt(oddCounter);
//                    oddCounter++;
//
//                    if (oddCounter == odds.Count)
//                    {
//                        oddDone = true;
//                    }
//                }
//                else
//                {
//                    finalArr[genericCounter] = evens.ElementAt(evenCounter);
//                    evenCounter++;
//
//                    if (evenCounter == evens.Count)
//                    {
//                        evenDone = true;
//                    }
//                }
//                genericCounter++;
//                if (evenDone)
//                {
//                    while (oddCounter < odds.Count)
//                    {
//                        finalArr[genericCounter] = odds.ElementAt(oddCounter);
//                        oddCounter++;
//                        genericCounter++;
//                    }
//                    break;
//                }
//                else if (oddDone)
//                {
//                    while (evenCounter < evens.Count)
//                    {
//                        finalArr[genericCounter] = evens.ElementAt(evenCounter);
//                        evenCounter++;
//                        genericCounter++;
//                    }
//                    break;
//                }
//            }


            return finalArr;
        }
    }
}
