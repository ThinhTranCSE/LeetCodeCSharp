using Datastruture;

namespace SymmetricTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = TreeNode.CreateTreeFromBFSList(new int?[] { 9, -42, -42, null, 76, 76, null, null, 13, null, 13 });
            Solution solution = new Solution();
            bool result = solution.IsSymmetric(root);
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public bool IsSymmetric(TreeNode root)
        {
            TreeNode leftRoot = root.left;
            TreeNode rightRoot = root.right;

            var leftQueue = new Queue<TreeNode>();
            var rightQueue = new Queue<TreeNode>();
            if (leftRoot == null && rightRoot == null)
            {
                return true;
            }
            else if (leftRoot == null || rightRoot == null)
            {
                return false;
            }


            leftQueue.Enqueue(leftRoot);


            rightQueue.Enqueue(rightRoot);


            while (leftQueue.Count > 0 && rightQueue.Count > 0)
            {
                var leftTreeNode = leftQueue.Dequeue();
                var rightTreeNode = rightQueue.Dequeue();

                if (leftTreeNode.val != rightTreeNode.val)
                {
                    return false;
                }

                if (leftTreeNode.left != null && rightTreeNode.right != null)
                {
                    leftQueue.Enqueue(leftTreeNode.left);
                    rightQueue.Enqueue(rightTreeNode.right);
                }
                else if (leftTreeNode.left == null && rightTreeNode.right == null)
                {
                    
                }
                else
                {
                    return false;
                }

                if (leftTreeNode.right != null && rightTreeNode.left != null)
                {
                    leftQueue.Enqueue(leftTreeNode.right);
                    rightQueue.Enqueue(rightTreeNode.left);
                }
                else if (leftTreeNode.right == null && rightTreeNode.left == null)
                {
                    
                }
                else
                {
                    return false;
                }
            }

            if (leftQueue.Count > 0 || rightQueue.Count > 0)
            {
                return false;
            }
            return true;

        }

    }
}