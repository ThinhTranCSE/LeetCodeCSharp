namespace GenerateParentheses
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
        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            GenerateParenthesisRecursive(n, 0, 0, "", result);
            return result;
        }

        public void GenerateParenthesisRecursive(int n, int open, int close, string currentString, IList<string> result)
        {
            if (open == close && open + close == n * 2)
            {
                result.Add(currentString);
            }

            if (open < n)
            {
                GenerateParenthesisRecursive(n, open + 1, close, currentString + "(", result);
            }

            if (close < open)
            {
                GenerateParenthesisRecursive(n, open, close + 1, currentString + ")", result);
            }
        }
    }
}
