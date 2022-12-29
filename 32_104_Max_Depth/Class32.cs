using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32_104_Max_Depth
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

        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
                return 0;
            if (root.left == null && root.right == null)
                return 1;
            if (root.left == null)
                return 1 + MaxDepth(root.right);
            if (root.right == null)
                return 1 + MaxDepth(root.left);
            return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
        }

        public static void Main(string[] args)
        {
            TreeNode root = new TreeNode();

            int result = MaxDepth(root);
        }
    }
}
