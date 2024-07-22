// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new Solution();
Console.WriteLine(sol.LongestPalindrome("babad"));
Console.WriteLine(sol.LongestPalindrome("cbbd"));
Console.WriteLine(sol.LongestPalindrome("a"));
Console.WriteLine(sol.LongestPalindrome("aacabdkacaa"));

public class Solution
{
	public string LongestPalindrome(string s)
	{
		var longestPalindrome = "";
		var longestPalindromeLength = 0;

		for (int i = 0; i < s.Length ; i++)
		{
			int left = i, right = i;
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				if(right - left +1 > longestPalindromeLength)
				{
					longestPalindrome = s.Substring(left, right - left + 1);
					longestPalindromeLength = right - left + 1;
				}

				left--;
				right++;
			}

			left = i;
			right = i + 1;
			while (left >= 0 && right < s.Length && s[left] == s[right])
			{
				if (right - left + 1 > longestPalindromeLength)
				{
					longestPalindrome = s.Substring(left, right - left + 1);
					longestPalindromeLength = right - left + 1;
				}

				left--;
				right++;
			}

		}

		return longestPalindrome;
	}
}




//bool oddString = true;
//bool evenString = true;
//for (int j = 0; j <= s.Length /2 ; j++)
//{
//	var leftIndex = i - j;
//	var rightIndex = i + j;
//	if (leftIndex < 0 || rightIndex >= s.Length) continue;

//	if (s[leftIndex] == s[rightIndex] && oddString)
//	{
//		var sb = s.Substring(leftIndex, rightIndex - leftIndex + 1);
//		if (sb.Length > longestPalindrome.Length)
//		{
//			longestPalindrome = sb;
//		}
//	}
//	else
//	{
//		oddString = false;
//	}

//	if (s.Length > i + 1 && s[i] != s[i + 1]) continue;
//	rightIndex = i + j + 1;
//	if (leftIndex < 0 || rightIndex >= s.Length) continue;

//	if (s[leftIndex] == s[rightIndex] && evenString)
//	{
//		var ss = s.Substring(leftIndex, rightIndex - leftIndex + 1);
//		if (ss.Length > longestPalindrome.Length)
//		{
//			longestPalindrome = ss;
//		}
//	}
//	else
//	{
//		evenString = true;
//	}
//}