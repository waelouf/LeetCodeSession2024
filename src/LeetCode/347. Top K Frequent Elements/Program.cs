var solution = new Solution();

Console.WriteLine(string.Join(",", solution.TopKFrequent([1, 1, 1, 2, 2, 3], 2)));
Console.WriteLine(string.Join(",", solution.TopKFrequent([1], 1)));


public class Solution
{
	public int[] TopKFrequent(int[] nums, int k)
	{
		var result = new int[k];
		var dict = new Dictionary<int, int>();

		for (int i = 0; i < nums.Length; i++)
		{
			if (!dict.ContainsKey(nums[i]))
			{
				dict.Add(nums[i], 0);
			}

			dict[nums[i]]++;
		}

		var invertedDictionary = new List<int>[nums.Length + 1];
        foreach (var key in dict.Keys)
		{
			if(invertedDictionary[dict[key]] == null)
			{
				invertedDictionary[dict[key]] = new List<int>();
			}

			invertedDictionary[dict[key]].Add(key);
		}

		int resultIndex = 0;
		for (int i = invertedDictionary.Length - 1; i > 0; i--)
		{
			if (resultIndex == k) break;

			if (invertedDictionary[i]?.Count > 0)
			{
				foreach (var item in invertedDictionary[i])
				{
					result[resultIndex++] = item;
					if (resultIndex == k) break;
				}
			}
		}

		return result; 
	}
}