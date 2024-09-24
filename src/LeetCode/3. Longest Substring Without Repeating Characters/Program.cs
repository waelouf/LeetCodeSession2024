// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;

var sol = new Solution();

Console.WriteLine(sol.LengthOfLongestSubstring("abcabcbb")); // 3
Console.WriteLine(sol.LengthOfLongestSubstring("bbbbb")); // 1
Console.WriteLine(sol.LengthOfLongestSubstring("au")); // 1


public class Solution
{
	public int LengthOfLongestSubstring(string s)
	{
		if(s.Length== 0) return 0;

		int maxlength = 1;
		int windowSize = 2;
		int startingIndex = 0;

		while (windowSize <= s.Length)
		{
			while (startingIndex < s.Length && startingIndex+windowSize <= s.Length)
			{
				if(!HasRepeats(startingIndex, startingIndex + windowSize - 1))
				{
					maxlength = windowSize;
					break;
				}
				else
				{
					startingIndex++;
				}
			}

			windowSize++;
		}

		bool HasRepeats(int startIndex, int endIndex)
		{
			var chars = new HashSet<char>();

			for (int i = startIndex; i <= endIndex; i++)
			{
				if (chars.Contains(s[i]))
				{
					return true;
				}
				else
				{
					chars.Add(s[i]);
				}
			}

			return false;

		}

		return maxlength;
	}
}