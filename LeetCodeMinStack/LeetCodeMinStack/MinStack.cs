using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMinStack
{
    public class MinStack
    {
        private int pointer = -1;
        private List<int> list;

        /** initialize your data structure here. */
        public MinStack()
        {
            list = new List<int>();
        }

        public void Push(int x)
        {
            pointer++;
            list.Add(x);
        }

        public void Pop()
        {
            if (pointer != -1)
            {
                list.RemoveAt(pointer);
                pointer--;
            }
        }

        public int Top()
        {
            if (pointer != -1)
            {
                return list.ElementAt(pointer);
            }
            return 0;
        }

        public int GetMin()
        {
            return list.Count > 0 ? list.Min() : 0;
        }
    }
}
