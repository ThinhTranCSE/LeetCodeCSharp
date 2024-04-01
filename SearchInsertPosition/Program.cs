namespace SearchInsertPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 3, 5, 6 };
            int target = 7;

            Solution solution = new Solution();
            int result = solution.SearchInsert(nums, target);
            Console.WriteLine(result);
        }

        public class Solution
        {
            public int SearchInsert(int[] nums, int target)
            {
                return SearchInsertRecursive(nums, target, 0, nums.Length);
            }
            public int SearchInsertRecursive(int[] nums, int target, int start, int end)
            {
                int mid = (start + end) / 2;
                if (start >= end)
                {
                    return start;
                }
                if (nums[mid] < target)
                {
                    return SearchInsertRecursive(nums, target, mid + 1, end);
                }
                if (nums[mid] > target)
                {
                    return SearchInsertRecursive(nums, target, start, mid);
                }
                return mid;
            }
        }
    }
}