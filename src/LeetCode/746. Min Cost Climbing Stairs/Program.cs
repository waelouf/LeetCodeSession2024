// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new Solution();
Console.WriteLine(sol.MinCostClimbingStairs([10, 15, 20]));
Console.WriteLine(sol.MinCostClimbingStairs([1, 100, 1, 1, 1, 100, 1, 1, 100, 1]));


public class Solution
{
	public int MinCostClimbingStairs(int[] cost)
	{
		if(cost.Length == 0) return 0;
		if(cost.Length == 1) return cost[0];
		if (cost.Length == 2) return Math.Min(cost[0], cost[1]);

		int left = cost[cost.Length - 1], right = 0;

		for (int i = cost.Length - 2; i >= 0; i--)
		{
			int minCost = Math.Min(cost[i] + left, cost[i] + right);
			right = left;
			left = minCost;

			cost[i] = minCost;
		}

		return Math.Min(cost[0], cost[1]);
	}
}