// See https://aka.ms/new-console-template for more information


var sol = new Solution();

Console.WriteLine(string.Join(Environment.NewLine, sol.FizzBuzz(3)));
Console.WriteLine();
Console.WriteLine(string.Join(Environment.NewLine, sol.FizzBuzz(5)));
Console.WriteLine();
Console.WriteLine(string.Join(Environment.NewLine, sol.FizzBuzz(15)));

public class Solution
{
	public IList<string> FizzBuzz(int n)
	{
		var result = new List<string>();

		for (int i = 1; i <= n; i++)
		{
			if(i%15 == 0)
			{
				result.Add("FizzBuzz");
			}
			else if (i%3 == 0)
			{
				result.Add("Fizz");
			}
			else if (i%5 == 0)
			{
				result.Add("Buzz");
			}
			else
			{
				result.Add(i.ToString());
			}
		}

		return result;
	}
}