using Datastruture;

namespace MaximumDepthOfBinaryTree
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
        public int MaxDepth(TreeNode root)
        {
            if(root == null)
            {
                return 0;
            }
            int LeftDepth = this.MaxDepth(root.left); 
            int RightDepth = this.MaxDepth(root.right);

            return 1 + Math.Max(LeftDepth, RightDepth);
        }

        
    }
}