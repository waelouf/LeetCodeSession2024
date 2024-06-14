var solution = new Solution();
var s1 = solution.GroupAnagrams(["eat", "tea", "tan", "ate", "nat", "bat"]);
var s2 = solution.GroupAnagrams([""]);
var s3 = solution.GroupAnagrams(["a"]);

foreach (var s in s3)
{
	foreach (var item in s)
	{
		Console.WriteLine(item);
	}

	Console.WriteLine();
}

public class Solution
{
	public IList<IList<string>> GroupAnagrams(string[] strs)
	{
		var indexOfA = (int)'a';
		var result = new List<IList<string>>();
		var dict = new Dictionary<string, List<string>>();

		for (int i = 0; i < strs.Length; i++)
		{
			var templateArr = new int[26];
			for (int j = 0; j < strs[i].Length; j++)
			{
				templateArr[((int)strs[i][j]) - indexOfA]++;
			}

			var key = string.Join("_", templateArr);
			if (!dict.ContainsKey(key))
			{
				dict.Add(key, new List<string>());
			}

			dict[key].Add(strs[i]);
		}

		foreach (var key in dict.Keys)
		{
			result.Add(dict[key]);
		}

		return result;
	}
}