using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var some in FindDisappearedNumbers(new int[] { 4, 3, 2, 7, 8, 2, 3, 1 }))
            {
                Console.WriteLine(some);
            }
            Console.Read();
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {

            var myList =  new List<int>();

            if (nums.Length == 0)
            {
                return myList;
            }

            for (var i = 1; i <= nums.Max() + 1; i++)
            {
                if (!nums.Contains(i))
                {
                    myList.Add(i);
                }
            }
            return myList;
        }
    }
}