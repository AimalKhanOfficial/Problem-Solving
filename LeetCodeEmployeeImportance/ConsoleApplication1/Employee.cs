using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Employee
    {
        // It's the unique ID of each node.
        // unique id of this employee
        public int ID { get; set; }
        // the importance value of this employee
        public int Importance { get; set; }
        // the id of direct subordinates
        public List<Employee> Subordinates;
    }
}
