using System;

namespace CheckValidSequenceInBT
{
    public class TreeNode
    {
        public TreeNode left;
        public TreeNode right;
        public int val;

        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
    public class Program
    {
        public TreeNode CreateNewNode(int val)
        {
            TreeNode root = new TreeNode();
            root.val = val;
            root.left = null;
            root.right = null;
            return root;
        }
        
        public bool IsValidSequence(TreeNode root, int[] arr)
        {
            int pos = 0;

            return CheckValidSequence(root, arr, pos);

        }

        public bool CheckValidSequence(TreeNode root, int[] arr, int pos)
        {
            if (root == null)
            {
                return false;
            }

            if (pos >= arr.Length || root.val != arr[pos])
            {
                return false;
            }

            if (root.left == null && root.right == null && pos == arr.Length - 1)
            {
                return true;
            }

            return CheckValidSequence(root.left, arr, pos + 1) || CheckValidSequence(root.right, arr, pos + 1);

        }
        static void Main(string[] args)
        {
            Program a = new Program();

            TreeNode root = a.CreateNewNode(0);
            root.left = a.CreateNewNode(1);
            root.right = a.CreateNewNode(0);
            root.left.left = a.CreateNewNode(0);
            root.left.right = a.CreateNewNode(1);
            root.right.left = a.CreateNewNode(0);
            root.left.left.right = a.CreateNewNode(1);
            root.left.right.left = a.CreateNewNode(0);
            root.left.right.right = a.CreateNewNode(0);

            int[] arr = { 0, 1, 0, 1 };

            Console.WriteLine(a.IsValidSequence(root, arr));
        }
    }
}
