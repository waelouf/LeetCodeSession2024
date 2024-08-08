// See https://aka.ms/new-console-template for more information
var sol = new Solution();

var results = sol.Subsets([1, 2, 3]);
for (int i = 0; i < results.Count; i++)
{
	Console.WriteLine(string.Join(",", results[i].ToArray()));
}
Console.WriteLine("---");

public class Solution
{
	public IList<IList<int>> Subsets(int[] nums)
	{
		var results = new List<IList<int>>();

		var subset  = new Stack<int>();

		BFS(0);

		void BFS(int index)
		{
			if(index > nums.Length - 1)
			{
				var arr = new int[subset.Count];
				subset.CopyTo(arr, 0);
				results.Add(arr);
				return;
			}

			subset.Push(nums[index]);
			BFS(index + 1);

			subset.Pop();
			BFS(index + 1);
		}

		return results;
	}
}