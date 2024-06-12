var sol = new Solution();

sol.TwoSum([2, 7, 11, 15], 9).
	ToList().ForEach(e => Console.WriteLine(e)); // 0,1

sol.TwoSum([3, 2, 4], 6).
	ToList().ForEach(e => Console.WriteLine(e)); // 1,2

sol.TwoSum([3, 3], 6).
	ToList().ForEach(e => Console.WriteLine(e)); // 0,1

sol.TwoSum([1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1], 11).
	ToList().ForEach(e => Console.WriteLine(e)); // 0,1

Console.ReadKey();

public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		var result = new int[2];

		var dict = new Dictionary<int, int>();
		for (int i = 0; i < nums.Length; i++)
		{
			if (dict.ContainsKey(nums[i]))
			{
				result[0] = dict[nums[i]];
				result[1] = i;
			}
			else
			{
				var key = target - nums[i];
				if (!dict.ContainsKey(key))
				{
					dict.Add(key, i);
				}
			}
		}

		return result;
	}
}