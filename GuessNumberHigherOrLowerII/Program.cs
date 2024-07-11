using System.Reflection.Metadata.Ecma335;

namespace GuessNumberHigherOrLowerII
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
        public int GetMoneyAmount(int n)
        {
            if(n == 1)
            {
                return 0;
            }
            if(n == 2)
            {
                return 1;
            }
            return 0;
        }
    }
}
