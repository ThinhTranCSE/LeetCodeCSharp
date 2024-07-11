namespace _3Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Solution solution = new Solution();
            int[] nums = new int[] { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> result = solution.ThreeSum(nums);
            Console.WriteLine("Result:");
        }
    }

    public class Solution
    {
        public IList<IList<int>> ThreeSum(int[] nums) {

            Array.Sort(nums);
            var set = new HashSet<int>();
            IList<IList<int>> result = new List<IList<int>>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    continue;
                }
                IList<IList<int>> twoSum = TwoSum(nums, -nums[i], i + 1, nums.Length - 1);
                foreach(IList<int> pair in twoSum)
                {
                    pair.Add(nums[i]);
                    var triplet = pair.OrderBy(x => x).ToList();
                    result.Add(triplet);
                   
                }
                set.Add(nums[i]);
            }
            return result.ToList();
        }

        public IList<IList<int>> TwoSum(int[] nums, int target, int start, int end)
        {
            var resulted = new HashSet<int>();
            Dictionary<int, int> visited = new Dictionary<int, int>();
            IList<IList<int>> result = new List<IList<int>>();
            for(int i = end; i >= start; i--)
            {
                int complement = target - nums[i];
                if (visited.ContainsKey(complement))
                {
                    if(!resulted.Contains(complement) && !resulted.Contains(nums[i]))
                    {
                        result.Add(new List<int> { nums[i], complement });
                        visited.Remove(complement);
                        resulted.Add(complement);
                        resulted.Add(nums[i]);
                    }
                }
                if (!visited.ContainsKey(nums[i]))
                {
                    visited.Add(nums[i], i);
                }
            }
            return result;
        }
    }
}