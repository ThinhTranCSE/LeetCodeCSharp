namespace FindTheIndexOfTheFirstOccurrenceInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution();
            var result = solution.StrStr("abc", "c");
            Console.WriteLine(result);
        }
    }

    public class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            int start = 0;
            string currentString = haystack.Substring(start, needle.Length);


            while (start + needle.Length <= haystack.Length)
            {
                if (currentString == needle)
                {
                    return start;
                }

                start++;
                if (start + needle.Length - 1 < haystack.Length)
                {
                    currentString += haystack[start + needle.Length - 1];
                    currentString = currentString.Remove(0, 1);
                }
            }

            return -1;

        }
    }
}
