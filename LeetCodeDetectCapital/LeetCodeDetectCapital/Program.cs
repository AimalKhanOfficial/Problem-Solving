using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeDetectCapital
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DetectCapitalUse("uSa"));
            Console.ReadLine();
        }

        public static bool DetectCapitalUse(string word)
        {
            char[] arr = word.ToCharArray();
            bool isAllCaps = true;
            bool isFirstWordCap = false;
            bool doesAnyCapAfterFirst = false;

            for (int i = 0; i < arr.Length; i++)
            {
                //Looking for the first word to be Capital
                if (i == 0 && !isFirstWordCap && char.IsUpper(arr[i]))
                {
                    isFirstWordCap = true;
                }

                //Not all of the characters in all caps after the first one
                else if (!char.IsUpper(arr[i]) && i > 0 && isAllCaps)
                {
                    isAllCaps = false;
                }

                //First letter was Cap, there's no small caps elem and then there comes an all cap elem *sighs*
                else if (isFirstWordCap && !isAllCaps && char.IsUpper(arr[i]))
                {
                    doesAnyCapAfterFirst = true;
                }

                //cases such as "leetcodE"
                else if (!isFirstWordCap && !isAllCaps && char.IsUpper(arr[i]))
                {
                    return false;
                }

                //
                else if (isFirstWordCap && isAllCaps && char.IsUpper(arr[i]))
                {
                    doesAnyCapAfterFirst = true;
                }
            }

            //Case for words like "USA"
            if (isFirstWordCap && isAllCaps)
                return true;

            //words like leetcode
            if (!isFirstWordCap && !isAllCaps)
                return true;
            
            //words like Google
            if (isFirstWordCap && !doesAnyCapAfterFirst)
                return true;

            return false;
        }
    }
}
