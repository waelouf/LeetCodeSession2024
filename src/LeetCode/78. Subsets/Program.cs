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
		//var current = new Stack<int>();
		//bfs(0);
		//void bfs(int index)
		//{
		//	if (index >= nums.Length)
		//	{
		//		var lstCopy = new int[current.Count];
		//		current.CopyTo(lstCopy, 0);
		//		results.Add(lstCopy);
		//		return;
		//	}
		//	var lstCopy = new int[current.Count];
		//	current.CopyTo(lstCopy, 0);
		//	results.Add(lstCopy);

		//	current.Push(nums[index]);
		//	bfs(index + 1);
		//	current.Pop();
		//	bfs(index + 1);
		//}

		return results;
	}
}