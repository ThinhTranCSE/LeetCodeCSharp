namespace MaximumProductSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 3, -4 };
            Console.WriteLine(new Solution().MaxProduct(nums));
        }
    }

    public class Solution
    {
        public int MaxProduct(int[] nums)
        {
            int CurrentProduct = 1;
            int MaxProduct = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                CurrentProduct *= nums[i];
                MaxProduct = Math.Max(MaxProduct, CurrentProduct);

                if (CurrentProduct == 0)
                {
                    CurrentProduct = 1;
                }
            }

            CurrentProduct = 1;
            for (int i = nums.Length - 1; i >= 0; i--)
            {
                CurrentProduct *= nums[i];
                MaxProduct = Math.Max(MaxProduct, CurrentProduct);

                if (CurrentProduct == 0)
                {
                    CurrentProduct = 1;
                }
            }

            return MaxProduct;
        }
    }
}