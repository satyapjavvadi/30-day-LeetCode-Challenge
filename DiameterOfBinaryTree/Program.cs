using System;

namespace DiameterOfBinaryTree
{
    public class TreeNode
    {
        int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x)
        {
            val = x;
        }
    }
    public class Solution
    {
        public static int max = 0;
        public int DiameterOfBinaryTree(TreeNode root)
        {
            max = 0;
            GetDiameter(root);
            return max;

        }
        public static int GetDiameter(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }

            else
            {
                int leftHeight = GetDiameter(root.left);
                int rightHeight = GetDiameter(root.right);

                int Diameter = leftHeight + rightHeight;

                max = Math.Max(max, Diameter);
                return Math.Max(leftHeight, rightHeight) + 1;
            }
        }

        static void Main(string[] args)
        {
            TreeNode root = null;

            root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.right = new TreeNode(4);
            root.right.left = new TreeNode(5);
            root.right.right = new TreeNode(6);
            root.right.left.left = new TreeNode(7);
            root.right.left.right = new TreeNode(8);

            Console.WriteLine(GetDiameter(root));

        }
    }
}
