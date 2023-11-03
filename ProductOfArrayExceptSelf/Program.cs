namespace ProductOfArrayExceptSelf
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
        public int[] ProductExceptSelf(int[] nums)
        {
            int[] Answers = new int[nums.Length];
            int CurrentProduct = 1;
            for (int i = 0; i < nums.Length; i++)
            {
                Answers[i] = CurrentProduct;
                CurrentProduct *= nums[i];
            }
            CurrentProduct = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                Answers[i] *= CurrentProduct;
                CurrentProduct *= nums[i];
            }
            return Answers;
        }
    }
}