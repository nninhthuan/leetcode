using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_669_Trim_BST
{
    public class Solution
    {
        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }
        }
        public static TreeNode TrimBST(TreeNode root, int L, int R)
        {
            if (root == null) return null;
            else if (root.val <= R && root.val >= L)
            {
                root.left = TrimBST(root.left, L, R);
                root.right = TrimBST(root.right, L, R);
            }
            else if (root.val > R)
            {
                root = TrimBST(root.left, L, R);
            }
            else if (root.val < L)
            {
                root = TrimBST(root.right, L, R);
            }
            return root;
        }

        public static void Main(string[] args)
        {
            //TreeNode[] root = { 1, 0, 2 };
            TreeNode root = new TreeNode();
            root.val = 3;
            root.val = 0;
            root.val = 4;
            root.left = null;
            root.val = 2;
            root.right = null;
            root.right = null;
            root.val = 1;
            //[ 3, 0, 4, null, 2, null, null, 1 } ;
            int low = 1, high = 3;

            TreeNode result = TrimBST(root, low, high);
        }
    }
}
