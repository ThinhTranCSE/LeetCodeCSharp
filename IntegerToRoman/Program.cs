namespace IntegerToRoman
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;
            Console.WriteLine(new Solution().IntToRoman(num));
        }
    }

    public class Solution
    {
        public string IntToRoman(int num)
        {
            Dictionary<int, char> RomanDictionary = new Dictionary<int, char>();
            RomanDictionary.Add(1, 'I');
            RomanDictionary.Add(5, 'V');
            RomanDictionary.Add(10, 'X');
            RomanDictionary.Add(50, 'L');
            RomanDictionary.Add(100, 'C');
            RomanDictionary.Add(500, 'D');
            RomanDictionary.Add(1000, 'M');



            int[] Weights = new int[] { 1000, 100, 10, 1 };

            string Result = "";
            int i = 0;
            while (num > 0 && i < Weights.Length)
            {
                int Weight = Weights[i];
                int Remnant = num / Weights[i];
                if (Remnant == 0)
                {
                    i++;
                    continue;
                }
                if (Weight < 1000)
                {
                    if (Remnant > 0 && Remnant < 4)
                    {
                        Result += new string(RomanDictionary[Weight], Remnant);
                    }
                    else if (Remnant == 4)
                    {
                        Result += new string(RomanDictionary[Weight], 1) + new string(RomanDictionary[Weight * 5], 1);
                    }
                    else if (Remnant > 4 && Remnant < 9)
                    {
                        Result += new string(RomanDictionary[Weight * 5], 1) + new string(RomanDictionary[Weight], Remnant - 5);
                    }
                    else
                    {
                        Result += new string(RomanDictionary[Weight], 1) + new string(RomanDictionary[Weight * 10], 1);
                    }
                }
                else
                {
                    Result += new string(RomanDictionary[Weight], Remnant);
                }
                num -= Weight * Remnant;

            }
            return Result;
        }
    }
}