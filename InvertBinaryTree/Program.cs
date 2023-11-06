using Datastruture;

namespace InvertBinaryTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Solution
    {
        public TreeNode InvertTree(TreeNode root)
        {
            if(root == null)
            {
                return null;
            }

            TreeNode Left = root.left;
            TreeNode Right = root.right;

            root.left = this.InvertTree(Right);
            root.right = this.InvertTree(Left);

            return root;

        }
    }
}