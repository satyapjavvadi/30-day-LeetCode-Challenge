using System;

namespace BSTreeFromPreOrder
{
    class Program
    {
        public class TreeNode
        {
         public int val;
         public TreeNode left;
         public TreeNode right;
         public TreeNode(int x) { val = x; }
        }
        public TreeNode BstFromPreorder(int[] preorder)
        {
            return BSTTree(preorder, 0, preorder.Length - 1);
        }
        public TreeNode BSTTree(int[] preorder, int l, int r)
        {

            if (l > r)
            {
                return null;
            }

            TreeNode root = new TreeNode(preorder[l]);
            if (l == r)
            {
                return root;
            }

            int nextEle = l + 1;
            while (nextEle <= r && preorder[nextEle] < preorder[l])
            {
                nextEle++;
            }

            root.left = BSTTree(preorder, l + 1, nextEle - 1);
            root.right = BSTTree(preorder, nextEle, r);

            return root;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
