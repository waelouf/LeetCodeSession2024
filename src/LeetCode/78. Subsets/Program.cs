// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] candidates = [1,2,3];

var solution = new Solution();
var results = solution.Subsets(candidates);

for (int i = 0; i < results.Count; i++)
{
	Console.WriteLine(string.Join(", ", results[i]));
}



public class Solution
{
	public IList<IList<int>> Subsets(int[] nums)
	{
		var results = new List<IList<int>>();
		var subset = new Stack<int>();		

		void bfs(int index)
		{
			if (index >= nums.Length)
			{
				var lstCopy = new int[subset.Count];
				subset.CopyTo(lstCopy, 0);
				results.Add(lstCopy);
				return;
			}


			subset.Push(nums[index]);
			bfs(index + 1);
			subset.Pop();
			bfs(index + 1);
		}

		bfs(0);
		return results;
	}
}