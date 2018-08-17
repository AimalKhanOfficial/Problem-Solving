using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveDuplicatesfromSorted_List
{
    class Program
    {
        static void Main(string[] args)
        {

            //URL: https://leetcode.com/problems/remove-duplicates-from-sorted-list/description/

            ListNode p1 = new ListNode(1);
            ListNode p2 = new ListNode(1);
            ListNode p3 = new ListNode(2);
            ListNode p4 = new ListNode(3);
            ListNode p5 = new ListNode(3);
            p1.next = p2;
            p2.next = p3;
            p3.next = p4;
            p4.next = p5;
            ListNode res = DeleteDuplicates(p1);

            Console.ReadLine();
        }

        public static ListNode DeleteDuplicates(ListNode head)
        {
            List<int> values = new List<int>();
            while (head != null)
            {
                if (!values.Contains(head.val))
                {
                    values.Add(head.val);

                    if (head.next != null)
                    {
                        if (values.Contains(head.next.val))
                        {
                            head.next = head.next.next;
                        }
                    }
                }
                head = head.next;
            }

            ListNode headAgain = null;
            for (int i = 0; i < values.Count; i++)
            {
                if (headAgain == null)
                {
                    headAgain = new ListNode(values[i]);
                }
                else
                {
                    ListNode copy = headAgain;
                    while (copy.next != null)
                    {
                        copy = copy.next;
                    }
                    copy.next = new ListNode(values[i]);
                }
            }
            return headAgain;
        }
    }
}
