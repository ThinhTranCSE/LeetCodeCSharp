using Datastruture;

namespace KthSmallestElementInABST
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
        public int KthSmallest(TreeNode root, int k)
        {
            List<int> TraversedNode = new List<int>();
            PreOrderTraverse(root, k, ref TraversedNode);
            return TraversedNode[k - 1];
        }

        public void PreOrderTraverse(TreeNode VisitingNode, int k, ref List<int> TraversedNode)
        {
            if(VisitingNode == null)
            {
                return;
            }

            if(TraversedNode.Count == k)
            {
                return;
            }

            PreOrderTraverse(VisitingNode.left, k, ref TraversedNode);
            TraversedNode.Add(VisitingNode.val);
            PreOrderTraverse(VisitingNode.right, k, ref TraversedNode);
        }
    }

}