using Datastruture;
using System.Collections.Immutable;

namespace ValidateBinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TreeNode root = TreeNode.CreateTreeFromBFSList(new Nullable<int>[] { 5, 1, 4, null, null, 3, 6 });
            TreeNode root = TreeNode.CreateTreeFromBFSList(new Nullable<int>[] { 1 ,1 });
            Console.WriteLine(new Solution().IsValidBST(root));
        }
    }
    public class Solution
    {
        public void TraverseTree(TreeNode node, ref Dictionary<TreeNode?, int[]> TraversedTreeNodes)
        {
            
            if (node == null)
            {
                return;
            }
            if(node.left == null && node.right == null)
            {
                TraversedTreeNodes.Add(node, new int[] { (int)node.val, (int)node.val });
                return;
            }
            if (node.left != null)
            {
                this.TraverseTree(node.left, ref TraversedTreeNodes);
            }
            if(node.right != null)
            {
                this.TraverseTree(node.right, ref TraversedTreeNodes);
            }
            int MinLeft, MaxLeft, MinRight, MaxRight;
            if (node.left != null)
            {
                MinLeft = TraversedTreeNodes[node.left][0];
                MaxLeft = TraversedTreeNodes[node.left][1];
            }
            else
            {
                MinLeft = Int32.MaxValue;
                MaxLeft = Int32.MinValue;
            }
            if (node.right != null)
            {
                MinRight = TraversedTreeNodes[node.right][0];
                MaxRight = TraversedTreeNodes[node.right][1];
            }
            else
            {
                MinRight = Int32.MaxValue;
                MaxRight = Int32.MinValue;
            }
            
            int MinValue = Math.Min((int)node.val, Math.Min(MinLeft, MinRight));
            int MaxValue = Math.Max((int)node.val, Math.Max(MaxLeft, MaxRight));
            TraversedTreeNodes.Add(node, new int[] { MinValue, MaxValue });
        }

        public bool IsValidBST(TreeNode root)
        {
            Dictionary<TreeNode, int[]> TraversedTreeNodes = new Dictionary<TreeNode, int[]>();
            this.TraverseTree(root, ref TraversedTreeNodes);
            Queue<TreeNode> WaitingQueue = new Queue<TreeNode>();
            WaitingQueue.Enqueue(root);
            while (WaitingQueue.Count > 0)
            {
                TreeNode VisitingNode = WaitingQueue.Dequeue();
                if (VisitingNode.left != null)
                {
                    if (TraversedTreeNodes[VisitingNode.left][1] >= VisitingNode.val)
                    {
                        return false;
                    }
                    WaitingQueue.Enqueue(VisitingNode.left);
                }
                if (VisitingNode.right != null)
                {
                    if (TraversedTreeNodes[VisitingNode.right][0] <= VisitingNode.val)
                    {
                        return false;
                    }
                    WaitingQueue.Enqueue(VisitingNode.right);
                }
            }
            return true;
        }
    }
}