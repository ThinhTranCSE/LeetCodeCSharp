namespace LetterCombinationsOfAPhoneNumber
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
        public IList<string> LetterCombinations(string digits)
        {
            var phoneNumberToLetterDict = new Dictionary<char, string[]>();
            phoneNumberToLetterDict.Add('2', ["a", "b", "c"]);
            phoneNumberToLetterDict.Add('3', ["d", "e", "f"]);
            phoneNumberToLetterDict.Add('4', ["g", "h", "i"]);
            phoneNumberToLetterDict.Add('5', ["j", "k", "l"]);
            phoneNumberToLetterDict.Add('6', ["m", "n", "o"]);
            phoneNumberToLetterDict.Add('7', ["p", "q", "r", "s"]);
            phoneNumberToLetterDict.Add('8', ["t", "u", "v"]);
            phoneNumberToLetterDict.Add('9', ["w", "x", "y", "z"]);

            var queue = new Queue<string>();

            for (int i = 0; i < digits.Length; i++)
            {
                if (queue.Count == 0)
                {
                    foreach (var letter in phoneNumberToLetterDict[digits[i]])
                    {
                        queue.Enqueue(letter);
                    }
                    continue;
                }

                while (queue.Peek().Length == i)
                {
                    var currentString = queue.Dequeue();
                    foreach (var letter in phoneNumberToLetterDict[digits[i]])
                    {
                        queue.Enqueue(currentString + letter);
                    }
                }
            }

            return queue.ToList();
        }
    }
}
