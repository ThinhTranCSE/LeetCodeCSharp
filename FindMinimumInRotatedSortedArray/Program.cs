using System.Security.Cryptography.X509Certificates;

namespace FindMinimumInRotatedSortedArray
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
        public int FindMin(int[] nums)
        {
            int Left = 0;
            int Right = nums.Length - 1;
            int MinValue = int.MaxValue;
            while(Left < Right)
            {
                MinValue = Math.Min(Math.Min(MinValue, nums[Left]), nums[Right]);
               
            }
        }
    }
}