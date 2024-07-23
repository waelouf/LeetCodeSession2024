// See https://aka.ms/new-console-template for more information

var sol = new Solution();

Console.WriteLine(sol.CountSubstrings("abc")); // 3
Console.WriteLine(sol.CountSubstrings("aaa")); // 6
Console.WriteLine(sol.CountSubstrings("a")); // 1
Console.WriteLine(sol.CountSubstrings("")); // 0
Console.WriteLine(sol.CountSubstrings("aba")); // 0


public class Solution
{
	public int CountSubstrings(string s)
	{
		if (s.Length <= 1) return s.Length ;
		int count = 0;

		for (int i = 0; i < s.Length; i++)
		{
			countPalendrome(i, i);

			countPalendrome(i, i+1);
		}

		void countPalendrome(int left, int right)
		{
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				count++;
				left--;
				right++;
			}
		}

		return count;
	}
}