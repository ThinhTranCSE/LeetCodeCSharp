using System;
using System.Collections.Generic;


namespace Datastruture
{
    public class TreeNode
    {
        public int? val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int? val = 0, TreeNode? left = null, TreeNode? right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        public static TreeNode CreateTreeFromBFSList(Nullable<int>[] values)
        {
            Queue<TreeNode> LeavesQueue = new Queue<TreeNode>();
            TreeNode Root = null;
            int index = 0;
            while (LeavesQueue.Count > 0 || index == 0)
            {
                if (index == 0)
                {
                    Root = new TreeNode(values[index]);
                    LeavesQueue.Enqueue(Root);
                    index++;
                }
                TreeNode VisitingNode = LeavesQueue.Dequeue();
                if (index < values.Length)
                {
                    if (values[index] != null)
                    {

                        VisitingNode.left = new TreeNode(values[index]);
                        LeavesQueue.Enqueue(VisitingNode.left);
                    }
                    index++;
                }
                if (index < values.Length)
                {
                    if (values[index] != null)
                    {

                        VisitingNode.right = new TreeNode(values[index]);
                        LeavesQueue.Enqueue(VisitingNode.right);
                    }
                    index++;
                }
            }
            return Root;
        }

        public static String ToString(TreeNode Root)
        {
            if (Root is null)
            {
                return "[]";
            }
            Queue<TreeNode> WaitingQueue = new Queue<TreeNode>();
            WaitingQueue.Enqueue(Root);
            String result = "";
            while (WaitingQueue.Count > 0)
            {
                TreeNode VisitingNode = WaitingQueue.Dequeue();
                if (VisitingNode is null)
                {
                    result += "null,";
                    continue;
                }
                result += VisitingNode.val + ",";
                WaitingQueue.Enqueue(VisitingNode.left);
                WaitingQueue.Enqueue(VisitingNode.right);
            }
            return "[" + result + "]";
        }
    }

}
