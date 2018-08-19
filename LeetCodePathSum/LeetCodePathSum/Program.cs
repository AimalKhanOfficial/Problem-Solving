using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodePathSum
{
    class Program
    {
        static void Main(string[] args)
        {
            TreeNode tree = new TreeNode(1);
            tree.left = new TreeNode(2);
            tree.left.left = new TreeNode(3);
            tree.left.left.left = new TreeNode(4);
            tree.left.left.left.left = new TreeNode(5);
            tree.left.left.left.left.left = new TreeNode(6);
            Console.WriteLine(HasPathSum(tree, 6));
            Console.ReadLine();
        }

        public static bool HasPathSum(TreeNode root, int sum)
        {
            TreeNode copy = root;
            int sumFinal = 0;
            bool isMultipleAdded = false;

            int nodeCounter = 0;

            while (copy != null)
            {
                nodeCounter++;
                sumFinal += copy.val;
                if (copy.left == null && copy.right == null && sumFinal != sum)
                {
                    sumFinal = 0;
                    copy = DeleteParticularNode(root, copy);
                    isMultipleAdded = false;

                    //Back to just one node (root)
                    if (copy == root && (copy.left == null && copy.right== null))
                    {
                        break;
                    }
                }
                else if (sumFinal == sum && isMultipleAdded && (copy.left == null && copy.right == null))
                {
                    return true;
                }
                else
                {
                    if (copy.left == null)
                    {
                        copy = copy.right;
                        isMultipleAdded = true;
                    }
                    else
                    {
                        copy = copy.left;
                        isMultipleAdded = true;
                    }
                }
            }

            if (nodeCounter == 1 && root.val == sum)
                return true;
            return false;
        }

        public static TreeNode DeleteParticularNode(TreeNode root, TreeNode toDelete)
        {
            if (root == null)
            {
                return null;
            }

            if (root.left == toDelete)
            {
                root.left = null;
            }
            else if (root.right == toDelete)
            {
                root.right = null;
            }

            DeleteParticularNode(root.left, toDelete);
            DeleteParticularNode(root.right, toDelete);
            return root;
        }
    }
}
