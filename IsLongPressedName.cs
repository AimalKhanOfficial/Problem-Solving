using System;
using System.Collections.Generic;
using System.Linq;

namespace ProblemSolvingTemplateProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach (var num in genericSubsetInstance.FindAllPossibleCombinations("Alex"))
            //{
            //Console.WriteLine(num);
            //}
            Console.WriteLine(IsLongPressedName("pyplrz", "ppyypllr"));
            Console.Read();
        }

        //Runtime: 84 ms, faster than 47.62% of C# online submissions for Long Pressed Name.
        public static bool IsLongPressedName(string name, string typed)
        {
            //base condition 
            if (name.Equals(typed))
            {
                return true;
            }

            var counter = 0;
            var prevChar = '\0';
            var isCharFound = false;
            for (var i = 0; i < name.Length; i++)
            {
                isCharFound = false;
                while (counter < typed.Length)
                {
                    if (counter == 0) prevChar =  typed[counter];

                    //when the condition matches and alphabet has been found.
                    if (name[i] == typed[counter])
                    {
                        prevChar = typed[counter];
                        counter++;
                        isCharFound = true;
                        break;
                    }

                    //No char matched + the first char that we were looking for does not match.
                    //The char is now changed! We are missing our first letter
                    if (!isCharFound && prevChar != typed[counter])
                    {
                        return false;
                    }

                    //No match keep going
                    prevChar = typed[counter];
                    counter++;
                }

                if (!isCharFound)
                {
                    return false;
                }
            }
            return true;
        }
    }
}