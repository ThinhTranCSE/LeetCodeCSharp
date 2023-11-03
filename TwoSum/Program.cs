namespace TwoSum
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
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> Dict = new Dictionary<int, int>();
            
            for(int i = 0; i <nums.Length; i++)
            {
                if (Dict.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { Dict[nums[i]], i };
                    }
                    continue;
                }
                Dict.Add(nums[i], i);
            }
            for(int i = 0; i < nums.Length; i++)
            {
                int Complement = target - nums[i];
                if(Dict.ContainsKey(Complement) && Dict[Complement] != i)
                {
                    return new int[] { i, Dict[Complement] };
                }
            }
            return new int[] { };
        }
    }
}