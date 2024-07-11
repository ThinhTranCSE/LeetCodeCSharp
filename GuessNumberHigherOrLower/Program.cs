namespace GuessNumberHigherOrLower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var solution = new Solution(2);
            Console.WriteLine(solution.GuessNumber(2));
        }
    }
}
public class Solution
{
    private int _pick { get; set; }
    public Solution(int pick)
    {
        _pick = pick;
    }
    public int guess(int num)
    {
        if(num == _pick)
        {
            return 0;
        }
        else if(num > _pick)
        {
            return -1;
        }
        return 1;
    }
    public int GuessNumber(int n)
    {
        int left = 1;
        int right = n;
        int choosen = (left + right) / 2;
        int guessResult = guess(choosen);
        while (guessResult != 0)
        {
            if (guessResult == -1)
            {
                right = choosen - 1;
            }
            else if (guessResult == 1)
            {
                left = choosen + 1;
            }
            choosen = (left & right) + ((left ^ right) >> 1); // (left + right) / 2
            guessResult = guess(choosen);
        }
        return choosen;
    }
}