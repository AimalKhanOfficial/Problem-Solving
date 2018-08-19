using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeMaximumDepthofBinaryTree
{
    class Program
    {
        private static int counter = 0;
        private static List<int> totalValues = new List<int>();

        static void Main(string[] args)
        {
             /*
                Given a binary tree, find its maximum depth.
                The maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node.
                Note: A leaf is a node with no children.
             */
            TreeNode treeNode = new TreeNode(3);
            treeNode.left = new TreeNode(9);
            treeNode.right = new TreeNode(20);
            treeNode.right.right = new TreeNode(7);
            treeNode.right.left = new TreeNode(15);
            Console.WriteLine(MaxDepth(treeNode));
            Console.ReadLine();
        }

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else
            {
                totalValues.Add(root.val);
            }

            Console.WriteLine(root.val);
            MaxDepth(root.left);
            MaxDepth(root.right);

            if (totalValues.Count <= 2)
                return (int) totalValues.Count;
            else
                return (int) Math.Ceiling((double)totalValues.Count/2);
        }
    }
}
