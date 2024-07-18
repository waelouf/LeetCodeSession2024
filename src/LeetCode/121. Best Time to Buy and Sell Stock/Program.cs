// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[] prices = [2, 1, 2, 1, 0, 1, 2];
var solutions = new Solution();
Console.Write(solutions.MaxProfit(prices));

public class Solution
{
	public int MaxProfit(int[] prices)
	{
		int maxPrice = 0;
		int buy = 0;
		int sell = 1;
		while (sell < prices.Length)
		{
			var profit = prices[sell] - prices[buy];
			maxPrice = Math.Max(maxPrice, profit);
			if(prices[sell] < prices[buy])
			{
				buy = sell;
			}

			sell++;
			
		}


		return maxPrice;
	}
}