using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaskPII("aimalkhan@abb.com"));
            Console.WriteLine(MaskPII("LeetCode@LeetCode.com"));
            Console.WriteLine(MaskPII("AB@qq.com"));
            Console.WriteLine(MaskPII("641 819 1517"));
            Console.WriteLine(MaskPII("1(234)567-890"));
            Console.WriteLine(MaskPII("86-(10)12345678"));
            Console.Read();
        }

        //https://leetcode.com/problems/masking-personal-information/
        public static string MaskPII(string S)
        {
            if (Regex.Match(S.Trim(), @"^\w+\@\w+\.\w{1,3}$").Success)
            {
                string[] emailAddr = S.ToString().ToLower().Split('@');
                return emailAddr[0][0] + "*****" + emailAddr[0][emailAddr[0].Length - 1] + "@" + emailAddr[1];
            }
            
            if (S.Length >= 10 && Regex.Match(S.Trim(), @"[+-,]?[\d+\s]{1,13}?").Success)
            {
                string number = S.Replace(" ", "").Replace("+", "").Replace("(", "").Replace(")", "").Replace("-", "");

                if (number.Length == 10)
                    return "***-***-" + number.Substring(number.Length - 4, 4);
                else if (number.Length == 12)
                    return "+**-***-***-" + number.Substring(number.Length - 4, 4);
            }
            return "";
        }
    }
}
