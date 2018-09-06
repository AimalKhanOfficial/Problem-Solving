using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeIsomorphicStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsIsomorphic("ab", "aa"));
            Console.ReadLine();
        }

        public static bool IsIsomorphic(string s, string t)
        {
            IDictionary<string, string> list = new Dictionary<string, string>();
            char[] sArr = s.ToCharArray();
            char[] tArr = t.ToCharArray();
            for (int i = 0; i < sArr.Length; i++)
            {
                if (list.ContainsKey(sArr[i].ToString()))
                {
                    KeyValuePair<string, string> pair = list.First(a => a.Key == sArr[i].ToString());
                    if (pair.Value != tArr[i].ToString())
                    {
                        return false;
                    }
                }
                else
                {
                    list.Add(sArr[i].ToString(), tArr[i].ToString());
                }
            }

            return true;
        }
    }
}
