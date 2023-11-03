namespace UniqueBinarySearchTrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            Console.WriteLine(new Solution().NumTrees(n));
        }
    }

    public class Solution
    {
        public int NumTrees(int n)
        {
            Dictionary<int, int> dict = new Dictionary<int, int>() { { -1, 1 }, { 0, 1 }, { 1, 1 } };
            return NumTreesOptimized(n, ref dict);
        }
        public int NumTreesOptimized(int n, ref Dictionary<int, int> CalculatedStates)
        {
            if (n <= 1) return 1;
            if (CalculatedStates.ContainsKey(n))
            {
                return CalculatedStates[n];
            }
            int total = 0;
            for (int root = 1; root <= n; root++)
            {
                int LeftTrees = NumTreesOptimized(root - 1, ref CalculatedStates);
                int RightTrees = NumTreesOptimized(n - root, ref CalculatedStates);
                total += LeftTrees * RightTrees;
            }

            CalculatedStates.Add(n, total);

            return total;
        }
    }
}