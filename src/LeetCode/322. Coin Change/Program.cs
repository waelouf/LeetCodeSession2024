// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

Console.WriteLine("Hello, World!");

var sol = new Solution();
Console.WriteLine(sol.CoinChange([1, 2, 5], 11));
Console.WriteLine(sol.CoinChange([2], 3));
Console.WriteLine(sol.CoinChange([1], 0));

public class Solution
{
	public int CoinChange(int[] coins, int amount)
	{
		var lst = coins.ToList();
		lst.Sort();

		int count = 0;



		return count;
	}
}