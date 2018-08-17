using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeSameTree
{
    class Program
    {
        private static bool flag = false;

        static void Main(string[] args)
        {
            TreeNode node1 = new TreeNode(1);
            node1.left = new TreeNode(2);
            //node1.right = new TreeNode(3);

            TreeNode node2 = new TreeNode(1);
            //node2.left = new TreeNode(2);
            node2.right = new TreeNode(2);

            Console.WriteLine(IsSameTree(node1, node2));
            Console.ReadLine();
        }

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (flag)
            {
                return false;
            }

            if (p != null && q != null)
            {

                Console.WriteLine("q: " + q.val + ", p: " + p.val);
                if (p.val != q.val)
                {
                    flag = true;
                }

                IsSameTree(p.left, q.left);
                IsSameTree(p.right, q.right);
            }
            else if ((p == null && q!=null) || (q==null && p!=null))
            {
                flag = true;
            }

            if (flag)
                return false;
            else
                return true;
        }
    }
}
