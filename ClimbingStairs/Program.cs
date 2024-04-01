namespace ClimbingStairs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = new Solution().ClimbStairs(5);

            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int ClimbStairs(int n)
        {
            if (n <= 3) return n;
            int firstNum = 1;
            int secondNum = 2;
            int result = 0;
            for (int i = 3; i <= n; i++)
            {
                result = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = result;
            }

            return result;
        }
    }
}