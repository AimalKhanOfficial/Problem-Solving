using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             You are given a data structure of employee information, which includes the employee's unique id, his importance value and his direct subordinates' id.

            For example, employee 1 is the leader of employee 2, and employee 2 is the leader of employee 3. They have importance value 15, 10 and 5, respectively. Then employee 1 has a data structure like [1, 15, [2]], and employee 2 has [2, 10, [3]], and employee 3 has [3, 5, []]. Note that although employee 3 is also a subordinate of employee 1, the relationship is not direct.

            Now given the employee information of a company, and an employee id, you need to return the total importance value of this employee and all his subordinates.
             */


            Employee emp1 = new Employee();
            emp1.ID = 1;
            emp1.Importance = 5;

            Employee emp2 = new Employee();
            emp2.ID = 2;
            emp2.Importance = 3;

            Employee emp3 = new Employee();
            emp3.ID = 3;
            emp3.Importance = 3;

            emp1.Subordinates = new List<Employee>();
            emp1.Subordinates.Add(emp2);
            emp1.Subordinates.Add(emp3);


            int totalImportance = emp1.Importance;
            for (int i = 0; i < emp1.Subordinates.Count; i++)
            {
                totalImportance += emp1.Subordinates[i].Importance;
            }
            Console.WriteLine(totalImportance);
            Console.Read();
        }
    }
}
