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
            Console.WriteLine(lastUnique("kkhhaann"));
            Console.ReadLine();
        }

        public static int lastUnique(string myStr)
        {
            Dictionary<int, char> myChars = new Dictionary<int, char>();
            char[] allChars = myStr.ToCharArray();
            for (int i = 0; i < allChars.Length; i++)
            {
                myChars.Add(i, allChars[i]);
            }
            char lastChar;
            myChars.TryGetValue(myChars.Count - 1, out lastChar);
            int indexToLookFor = myChars.Count - 1;
            bool flag = true;
            bool found = false;
            for (int i = indexToLookFor; i >= 0; i--)
            {
                int counter = indexToLookFor - 1;
                while (flag && counter >= 0)
                {
                    char anotherChar;
                    myChars.TryGetValue(counter, out anotherChar);
                    if (lastChar == anotherChar)
                    {
                        flag = false;
                        found = true;
                    }
                    counter--;
                }

                if (!found)
                {
                    return indexToLookFor;
                }
            }
            return -1;
        }
    }
}
