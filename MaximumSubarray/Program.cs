namespace MaximumSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 2, -3, 1, 3, -3, 2, 2, 1 };
            Console.WriteLine(new Solution().MaxSubArray(nums));
        }
    }

    public class Solution
    {
        public int MaxSubArray(int[] nums)
        {
            int Start = 0;
            int End = 0;
            int CurrentValue = nums[0];
            int Max = CurrentValue;
            while (End < nums.Length)
            {
                if (Start == End)
                {
                    End++;
                    if(End < nums.Length)
                    { 
                        if (nums[End] < 0)
                        {
                            Max = Math.Max(Max, CurrentValue);
                        }
                        CurrentValue += nums[End];
                    }
                }
                else
                {
                    int ForwardStart = CurrentValue - nums[Start];
                    int ForwardEnd = End + 1 < nums.Length ? CurrentValue + nums[End + 1] : Int32.MinValue;  
                    if(ForwardStart > ForwardEnd )
                    {
                        Start++;
                        CurrentValue = ForwardStart;
                    }
                    else
                    {
                        End++;
                        CurrentValue = ForwardEnd;
                    }
                }
                Max = Math.Max(Max, CurrentValue);
            }
            return Max;
        }
    }
}