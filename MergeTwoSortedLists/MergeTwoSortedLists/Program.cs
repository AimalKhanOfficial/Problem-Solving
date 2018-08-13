using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {

            //Merge two sorted linked lists and return it as a new list.
            //The new list should be made by splicing together the nodes of the first two lists.

            //Example:
            //Input: 1->2->4, 1->3->4
            //Output: 1->1->2->3->4->4

            ListNode l1 = new ListNode(1);
            ListNode l1Second = new ListNode(2);
            ListNode l1Third = new ListNode(4);

            l1.next = l1Second;
            l1Second.next = l1Third;

            ListNode l2 = new ListNode(1);
            ListNode l2Second = new ListNode(3);
            ListNode l2Third = new ListNode(4);

            l2.next = l2Second;
            l2Second.next = l2Third;

            MergeTwoLists(l1, l2);

            Console.WriteLine();
            Console.ReadLine();
        }


        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            List<int> totalValues = new List<int>();
            while (l1 != null)
            {
                totalValues.Add(l1.val);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                totalValues.Add(l2.val);
                l2 = l2.next;
            }

            totalValues.Sort();


            return new ListNode(1);
        }


    }
}
