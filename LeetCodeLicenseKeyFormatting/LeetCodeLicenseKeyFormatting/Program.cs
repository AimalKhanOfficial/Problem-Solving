using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeLicenseKeyFormatting
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * You are given a license key represented as a string S which consists only alphanumeric character and dashes. The string is separated into N+1 groups by N dashes.

                Given a number K, we would want to reformat the strings such that each group contains exactly K characters, except for the first group which could be shorter than K, but still must contain at least one character. Furthermore, there must be a dash inserted between two groups and all lowercase letters should be converted to uppercase.
                
                Given a non-empty string S and a number K, format the string according to the rules described above.
                
                Example 1:
                
                Input: S = "5F3Z-2e-9-w", K = 4
                
                Output: "5F3Z-2E9W"
                
                Explanation: The string S has been split into two parts, each part has 4 characters.
                Note that the two extra dashes are not needed and can be removed.

             */
             Console.WriteLine(LicenseKeyFormatting("2", 2));
            Console.ReadLine();
        }

        public static string LicenseKeyFormatting(string S, int K)
        {
            StringBuilder sb = new StringBuilder();
            char[] arr = S.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != '-')
                {
                    sb.Append(arr[i]);
                }
            }
            string finalString = "";
            char[] arr2 = sb.ToString().ToUpper().ToCharArray();
            if (arr2.Length%K == 0)
            {
                finalString = GetFinalString(arr2, 0, K);
            }
            else
            {
                int remainder = arr2.Length%K;
                for (int i = 0; i < remainder; i++)
                {
                    finalString += arr2[i];
                }
                if (arr2.Length > 1)
                {
                    finalString += "-";
                    finalString += GetFinalString(arr2, remainder, K);
                }
            }
            return finalString;
        }

        public static string GetFinalString(char[] arr, int startPoint, int K)
        {
            string finalString = "";
            int div = 0;
            for (int i = startPoint; i < arr.Length; i++)
            {
                if (div > 0 && div % K == 0)
                {
                    finalString += "-";
                    finalString += arr[i];
                }
                else
                {
                    finalString += arr[i];
                }
                div++;
            }
            return finalString;
        }
    }
}
