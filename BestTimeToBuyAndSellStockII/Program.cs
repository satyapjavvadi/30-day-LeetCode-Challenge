using System;

namespace BestTimeToBuyAndSellStockII
{
    class Program
    {
        public static int MaxProfit(int[] prices)
        {
            int profit = 0;
            for(int i = 1; i < prices.Length; i++)
            {
                if(prices[i] > prices[i-1])
                {
                    profit += (prices[i] - prices[i - 1]);
                }
            }
            return profit;
        }
        static void Main(string[] args)
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };
            int profit = MaxProfit(prices);
            Console.WriteLine(profit);
        }
    }
}
