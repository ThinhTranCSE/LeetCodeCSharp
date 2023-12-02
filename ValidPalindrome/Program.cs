namespace ValidPalindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Solution().IsPalindrome("A man, a plan, a canal: Panama"));
        }
    }

    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            int Left = 0;
            s = s.ToLower();

            int Right = s.Length - 1;
            while (Left < Right)
            {
                int LeftCode = (int)s[Left];
                int RightCode = (int)s[Right];

                while (!(
                    (LeftCode >= (int)'a' && LeftCode <= (int)'z') ||
                    (LeftCode >= (int)'0' && LeftCode <= (int)'9')
                ))
                {
                    Left++;
                    if (Left > s.Length - 1) return true;
                    LeftCode = (int)s[Left];
                }

                while (!(
                    (RightCode >= (int)'a' && RightCode <= (int)'z') ||
                    (RightCode >= (int)'0' && RightCode <= (int)'9')

                ))
                {
                    Right--;
                    if (Right < 0) return true;
                    RightCode = (int)s[Right];
                }


                if (s[Left] != s[Right])
                {
                    return false;
                }
                Left++;
                Right--;
            }
            return true;
        }
    }
