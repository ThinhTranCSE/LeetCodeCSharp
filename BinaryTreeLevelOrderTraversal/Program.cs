using Datastruture;
using System.Linq;

namespace BinaryTreeLevelOrderTraversal
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
        public IList<IList<int>> LevelOrder(TreeNode root)
        {
            Queue<KeyValuePair<TreeNode, int>> Queue = new Queue<KeyValuePair<TreeNode, int>>();
            List<List<int>> Result = new List<List<int>>();
            if (root == null)
            {
                return Result.ToArray();
            }
            Queue.Enqueue(new KeyValuePair<TreeNode, int>(root, 0)) ;

            while (Queue.Count > 0)
            {
                var VisitingPair = Queue.Dequeue();
                TreeNode VisitingNode = VisitingPair.Key;
                int CurrentLevel = VisitingPair.Value;

                if (Result.Count <= CurrentLevel)
                {
                    Result.Add(new List<int>());
                }
                Result[CurrentLevel].Add(VisitingNode.val.Value);

                if (VisitingNode.left != null)
                {
                    Queue.Enqueue(new KeyValuePair<TreeNode, int>(VisitingNode.left, CurrentLevel + 1));
                }


                if (VisitingNode.right != null)
                {
                    Queue.Enqueue(new KeyValuePair<TreeNode, int>(VisitingNode.right, CurrentLevel + 1));
                }
                 
            }

            return Result.ToArray();
        }
    }
}