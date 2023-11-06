namespace MaximumSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
            Console.WriteLine(new Solution().MaxSubArray(nums));
        }
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int CurrentSum = nums[0];
            int MaxSum = nums[0];
            for(int i = 1; i < nums.Length; i++)
            {
                CurrentSum = Math.Max(nums[i], CurrentSum + nums[i]);
                MaxSum = Math.Max(MaxSum, CurrentSum);
            }
            return MaxSum;
        }
    }
}