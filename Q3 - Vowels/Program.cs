using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace InfluenceHealth
{
    class Program
    {
        static void Main(string[] args)
        {
            countVowelWords("vowels.txt");
            Console.ReadLine();
        }

        public static void countVowelWords(string path)
        {
            try
            {
                IDictionary<string, int> words = new Dictionary<string, int>();
                string allWords = File.ReadAllText(@"C:\Users\Aimal\Desktop\InfluenceHealth\" + path);
                string[] arr = allWords.Split(' ');
                for (var i = 0; i < arr.Length; i++)
                {
                    if (arr[i].StartsWith("a") || arr[i].StartsWith("e")
                        || arr[i].StartsWith("i") || arr[i].StartsWith("o") || arr[i].StartsWith("u"))
                    {
                        if (words.Keys.Contains(arr[i]))
                        {
                            int counter = 0;
                            words.TryGetValue(arr[i], out counter);
                            words.Remove(arr[i]);
                            counter++;
                            words.Add(arr[i], counter);
                        }
                        else
                        {
                            words.Add(arr[i], 1);
                        }
                    }
                }


                foreach (KeyValuePair<string, int> pair in words)
                {
                    Console.WriteLine(pair.Value + " " + pair.Key);
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
