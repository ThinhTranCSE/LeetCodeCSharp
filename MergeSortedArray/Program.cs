namespace MergeSortedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m = 1;
            int[] nums1 = new int[] { 2, 0 };
            int n = 1;
            int[] nums2 = new int[] { 1 };
            Solution solution = new Solution();
            solution.Merge(nums1, m, nums2, n);
            Console.WriteLine(string.Join(",", nums1));
        }
    }


    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0)
            {
                for (int i = 0; i < n; i++)
                {
                    nums1[i] = nums2[i];
                }
                return;
            }
            int num1Index = m - 1;
            int num2Index = n - 1;
            int currentIndex = nums1.Length - 1;
            while (num1Index >= 0 || num2Index >= 0)
            {
                if (num2Index < 0)
                {
                    nums1[currentIndex] = nums1[num1Index];
                    num1Index--;
                    currentIndex--;
                    continue;
                }
                if (num1Index < 0)
                {
                    nums1[currentIndex] = nums2[num2Index];
                    num2Index--;
                    currentIndex--;
                    continue;
                }

                if (nums1[num1Index] >= nums2[num2Index])
                {
                    nums1[currentIndex] = nums1[num1Index];
                    num1Index--;
                }
                else
                {
                    nums1[currentIndex] = nums2[num2Index];
                    num2Index--;
                }
                currentIndex--;
            }
        }

    }
}