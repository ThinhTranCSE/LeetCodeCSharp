namespace FindFirstAndLastPositionOfElementInSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = [2, 2];
            int target = 2;

            Solution solution = new Solution();

            int[] result = solution.SearchRange(nums, target);

            Console.WriteLine($"[{result[0]},{result[1]}]");
        }
    }

    public class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int first = 0;
            int last = nums.Length - 1;

            return SearchRangeRecursive(nums, target, first, last);
        }

        public int[] SearchRangeRecursive(int[] nums, int target, int first, int last)
        {
            if (nums.Length == 1 && nums[0] == target)
            {
                return [0, 0];
            }

            if (first > last)
            {
                return [-1, -1];
            }

            int currentPosition = (first + last) / 2;
            int currentValue = nums[currentPosition];

            bool isFalse = false;
            if (currentValue > target)
            {
                last = currentPosition - 1;
                isFalse = true;
            }

            if (currentValue < target)
            {
                first = currentPosition + 1;
                isFalse = true;
            }

            if (isFalse)
            {
                return SearchRangeRecursive(nums, target, first, last);
            }



            if (currentValue == target)
            {
                for (int pos = currentPosition; pos >= 0 && nums[pos] == target; pos--)
                {
                    first = pos;
                }

                for (int pos = currentPosition; pos <= nums.Length - 1 && nums[pos] == target; pos++)
                {
                    last = pos;
                }

            }
            return [first, last];
        }
    }
}
