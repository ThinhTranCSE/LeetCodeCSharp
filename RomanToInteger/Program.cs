namespace RomanToInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().RomanToInt("MCMXCIV"));
        }
    }

    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<string, int> RomanDictionary = new Dictionary<string, int>();
            RomanDictionary.Add("I", 1);
            RomanDictionary.Add("V", 5);
            RomanDictionary.Add("X", 10);
            RomanDictionary.Add("L", 50);
            RomanDictionary.Add("C", 100);
            RomanDictionary.Add("D", 500);
            RomanDictionary.Add("M", 1000);
            RomanDictionary.Add("IV", 4);
            RomanDictionary.Add("IX", 9);
            RomanDictionary.Add("XL", 40);
            RomanDictionary.Add("XC", 90);
            RomanDictionary.Add("CD", 400);
            RomanDictionary.Add("CM", 900);

            int Result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                string TwoRomanLength = i < s.Length - 1 ? s.Substring(i, 2) : "";
                string OneRomanLength = s.Substring(i, 1);
                if(RomanDictionary.ContainsKey(TwoRomanLength))
                {
                    Result += RomanDictionary[TwoRomanLength];
                    i++;
                }
                else
                {
                    Result += RomanDictionary[OneRomanLength];
                }
            
            }
            return Result;
        }
    }
}