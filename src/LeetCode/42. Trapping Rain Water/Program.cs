// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new Solution();
Console.WriteLine(sol.Trap([0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]));

public class Solution
{
	public int Trap(int[] height)
	{
		if(height.Length == 0) return 0;

		int l = 0;
		int r = height.Length - 1;

		int maxLeft = height[l];
		int maxRight = height[r];

		int result = 0;

		while(l < r)
		{
			if (maxLeft <= maxRight)
			{
				l += 1;
				maxLeft = Math.Max(maxLeft, height[l]);
				result += maxLeft - height[l];
			}
			else
			{
				r -= 1;
				maxRight = Math.Max(maxRight, height[r]);
				result += maxRight - height[r];
			}
		}

		return result;
	}
}