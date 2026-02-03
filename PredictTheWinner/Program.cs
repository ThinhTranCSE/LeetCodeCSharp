namespace PredictTheWinner;

internal class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();
        int[] nums = [1, 5, 2];
        bool result = solution.PredictTheWinner(nums);
        Console.WriteLine(result);
    }
}


public class Solution
{
    public bool PredictTheWinner(int[] nums)
    {
        return Predict(nums, 0, nums.Length - 1, new Dictionary<(int, int), int>()) >= 0;
    }
    private int Predict(int[] nums, int start, int end, Dictionary<(int, int), int> cache)
    {
        if (start > end)
        {
            return 0;
        }

        if (start == end)
        {
            return nums[start];
        }

        if (cache.TryGetValue((start, end), out int value))
        {
            return value;
        }

        int chooseStart = nums[start] - Predict(nums, start + 1, end, cache);
        int chooseEnd = nums[end] - Predict(nums, start, end - 1, cache);

        int result = Math.Max(chooseStart, chooseEnd);

        cache.Add((start, end), result);

        return result;
    }
}