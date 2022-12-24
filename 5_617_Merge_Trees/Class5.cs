using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_617_Merge_Trees
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

    public class Solution
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            if (t1 != null && t2 == null)
                return t1;
            if (t1 == null && t2 != null)
                return t2;
            if (t1 == null && t2 == null)
                return null;
            MergeSubtree(t1, t2);
            return t1;
        }

        private void MergeSubtree(TreeNode d, TreeNode s)
        {
            d.val += s.val;
            if (s.left != null)
            {
                if (d.left != null)
                    MergeSubtree(d.left, s.left);
                else
                    d.left = s.left;
            }
            if (s.right != null)
            {
                if (d.right != null)
                    MergeSubtree(d.right, s.right);
                else
                    d.right = s.right;
            }
        }
    
        public static void Main(string[] args)
        {
        }
    }
}
