var sol = new Solution();

Console.WriteLine(sol.IsAnagram("anagram", "nagaram")); // true
Console.WriteLine(sol.IsAnagram("rat", "car")); // false

Console.ReadKey();

public class Solution
{
	public bool IsAnagram(string s, string t)
	{
		if(s.Length != t.Length) return false;

		var dict = new Dictionary<char, int>();

		s = s.ToLower();
		t = t.ToLower();

		for (int i = 0; i < s.Length; i++)
		{
			if (dict.ContainsKey(s[i]))
			{
				dict[s[i]]++;
			}
			else
			{
				dict.Add(s[i], 1);
			}
		}

		for (int i = 0; i < t.Length; i++)
		{
			if (dict.ContainsKey(t[i]))
			{
				dict[t[i]]--;
			}
			else
			{
				return false;
			}
		}

		foreach (var key in dict.Keys)
		{
			if (dict[key] != 0) return false;
		}

		return true;
	}
}