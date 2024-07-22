// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new Solution();
Console.WriteLine(sol.ClimbStairs(1));
Console.WriteLine(sol.ClimbStairs(2));
Console.WriteLine(sol.ClimbStairs(3));
Console.WriteLine(sol.ClimbStairs(4));
Console.WriteLine(sol.ClimbStairs(5));

public class Solution
{
	public int ClimbStairs(int n)
	{
		int one =1 , two = 1;

		for (int i = 0; i < n-1; i++)
		{
			var temp = one;
			one = one + two;
			two = temp;
		}

		return one;
	}
}