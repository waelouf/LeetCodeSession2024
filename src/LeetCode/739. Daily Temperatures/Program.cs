// See https://aka.ms/new-console-template for more information

var sol = new Solution();
Console.WriteLine(string.Join(",", sol.DailyTemperatures([73, 74, 75, 71, 69, 72, 76, 73]))); // [1,1,4,2,1,1,0,0]
Console.WriteLine(string.Join(",", sol.DailyTemperatures([30, 40, 50, 60])));
Console.WriteLine(string.Join(",", sol.DailyTemperatures([30, 60, 90])));


public class Solution
{
	public int[] DailyTemperatures(int[] temperatures)
	{
		if (temperatures.Length == 0) return new int[0];
		if (temperatures.Length == 1) return [0];

		var result = new int[temperatures.Length];

		var stack = new Stack<(int, int)>();
		stack.Push((temperatures[0], 0));

		for (int i = 1; i < temperatures.Length; i++)
		{
			while (stack.Count > 0 && temperatures[i] > stack.Peek().Item1)
			{
				var temp = stack.Pop();
				result[temp.Item2] = i - temp.Item2;
			}

			stack.Push((temperatures[i], i));
		}
		

		return result;
	}
}