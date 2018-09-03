using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMinStack
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            /*
             *  Design a stack that supports push, pop, top, and retrieving the minimum element in constant time.

                push(x) -- Push element x onto stack.
                pop() -- Removes the element on top of the stack.
                top() -- Get the top element.
                getMin() -- Retrieve the minimum element in the stack.

             */


            // Your MinStack object will be instantiated and called as such:
            MinStack obj = new MinStack();
            obj.Push(1);
            obj.Push(2);
            obj.Push(3);
            obj.Pop();
            int param_3 = obj.Top();
            int param_4 = obj.GetMin();
            Console.WriteLine(param_4);
            Console.Read();
        }
    }
}