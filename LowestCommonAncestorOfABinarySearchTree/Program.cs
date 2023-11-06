using Datastruture;

namespace LowestCommonAncestorOfABinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int?[] nums = new int?[] { 6, 2, 8, 0, 4, 7, 9, null, null, 3, 5 };
            TreeNode root = TreeNode.CreateTreeFromBFSList(nums);
            TreeNode.ToString(root);
            Console.WriteLine(TreeNode.ToString(new Solution().LowestCommonAncestor(root, new TreeNode(2), new TreeNode(8))));
        }
    }
    public class Solution
    {
        public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q)
        {
            var PathToP = PathToNode(root, p.val.Value, 0, new Dictionary<int, int>());
            var PathToQ = PathToNode(root, q.val.Value, 0, new Dictionary<int, int>());
            HashSet<KeyValuePair<int, int>> SetNode = new HashSet<KeyValuePair<int, int>>();
            int LowestLevel = int.MinValue;
            int Result = int.MinValue;

            foreach(var Node in PathToP)
            {
                SetNode.Add(Node);
            }
            foreach(var NodeKVP in PathToQ)
            {
                if(SetNode.Contains(NodeKVP))
                {
                    if(NodeKVP.Value > LowestLevel)
                    {
                        Result = NodeKVP.Key;
                    }
                    continue;
                }
                SetNode.Add(NodeKVP);
            }
            return new TreeNode(Result);
        }

        public Dictionary<int, int> PathToNode(TreeNode VisitingNode, int SearchedValue, int Level, Dictionary<int, int> Path)
        {
            if(VisitingNode == null)
            {
                return null;
            }

            Path.Add(VisitingNode.val.Value, Level);
            if(VisitingNode.val == SearchedValue)
            {
                return Path;
            }

            var LeftTree = PathToNode(VisitingNode.left, SearchedValue, Level + 1, new Dictionary<int, int>(Path));
            var RightTree = PathToNode(VisitingNode.right, SearchedValue, Level + 1, new Dictionary<int, int>(Path));
            return LeftTree ?? RightTree;
        }   
    }

}