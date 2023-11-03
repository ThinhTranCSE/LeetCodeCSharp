namespace ValidParentheses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s = "()[]{}";
            Console.WriteLine(new Solution().IsValid(s));
        }
    }

    public class Solution
    {
        public bool IsValid(string s)
        {
            if(s.Length % 2 != 0) return false;
            Stack<Char> ParenthesesStack = new Stack<Char>();
            foreach (Char Parenthese in s)
            {
                if (Parenthese == '(' ||  Parenthese == '[' || Parenthese == '{')
                {
                    ParenthesesStack.Push(Parenthese);
                }
                else
                {
                    if (ParenthesesStack.Count == 0) return false;

                    Char OpenParentheses = ParenthesesStack.Pop();
                    if (OpenParentheses == '(' && Parenthese == ')')
                    {
                        continue;
                    }
                    else if (OpenParentheses == '[' &&  Parenthese == ']')
                    {
                        continue;
                    }
                    else if(OpenParentheses ==  '{' && Parenthese == '}')
                    {
                        continue;
                    }
                    return false;
                }
            }
            if (ParenthesesStack.Count != 0) return false;
            return true;
        }
    }
}