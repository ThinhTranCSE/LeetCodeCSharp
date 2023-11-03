namespace BestTimeToBuyAndSellStock
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
        public int MaxProfit(int[] prices)
        {
            int MinBuyPrice = Int32.MaxValue;
            int MaxProfit = 0;
            foreach(int price in prices)
            {
                if(price < MinBuyPrice)
                {
                    MinBuyPrice = price;
                }
                int currentProfit = price - MinBuyPrice;
                if(currentProfit > MaxProfit)
                {
                    MaxProfit = currentProfit;
                }
            }
            return MaxProfit;
        }
    }
}