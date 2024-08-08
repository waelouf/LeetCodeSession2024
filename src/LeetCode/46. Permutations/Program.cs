// See https://aka.ms/new-console-template for more information

var sol = new Solution();
var results = sol.Permute([1]);

for (int i = 0; i < results.Count; i++)
{
	Console.WriteLine(string.Join(",", results[i]));
}

public class Solution
{
	public IList<IList<int>> Permute(int[] nums)
	{
		var results = new List<IList<int>>();
		if (nums.Length == 0)
		{
			results.Add(new List<int>());
			return results;
		}

		var tempNums = new int[nums.Length - 1];
		Array.Copy(nums, 1, tempNums,0, tempNums.Length);

		var perms = Permute(tempNums);
		
		foreach (var perm in perms)
		{
			var permCount = perm.Count;
			for (int i = 0; i <= permCount; i++)
			{
				var copy = new int[permCount];
				Array.Copy(perm.ToArray(), copy, permCount);
				var copyList = copy.ToList<int>();
				copyList.Insert(i, nums[0]);
				results.Add(copyList);
			}
		}

		return results;
	}
}