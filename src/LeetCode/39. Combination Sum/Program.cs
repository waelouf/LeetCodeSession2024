// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] candidates = [2, 3, 5];
var target = 8;

var solution = new Solution();
var results = solution.CombinationSum(candidates, target);

for (int i = 0; i < results.Count; i++)
{
	Console.WriteLine(string.Join(", ", results[i]));
}


public class Solution
{
	public IList<IList<int>> CombinationSum(int[] candidates, int target)
	{
		var result = new List<IList<int>>();

		dfs(0, new Stack<int>(), 0);

		void dfs(int index, Stack<int> current, int total)
		{
			if(total == target)
			{
				var found = new int[current.Count];
				current.CopyTo(found, 0);
				result.Add(found);
				return;
			}

			if (total > target) return;
			if(index >= candidates.Length) return;

			current.Push(candidates[index]);
			dfs(index, current, total + candidates[index]);
			current.Pop();
			dfs(index + 1, current, total);

		}


		return result;
	}
}