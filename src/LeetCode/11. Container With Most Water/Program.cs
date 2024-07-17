// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] heights = [1, 8, 6, 2, 5, 4, 8, 3, 7];

var sol = new Solution();
Console.WriteLine(sol.MaxArea(heights));

public class Solution
{
	public int MaxArea(int[] height)
	{
		int l = 0;
		int r = height.Length - 1;

		int maxArea = -1;

		while(l < r)
		{
			int area = Math.Min(height[l], height[r]) * (r - l);
			maxArea = Math.Max(area, maxArea);
			if(height[l] <= height[r])
			{
				l++;
			}
			else
			{
				r--;
			}

		}

		return maxArea;
	}
}