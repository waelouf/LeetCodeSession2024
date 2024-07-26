// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

Console.WriteLine("Hello, World!");

var sol = new Solution();
Console.WriteLine(sol.IsValid("()"));
Console.WriteLine(sol.IsValid("()[]{}"));
Console.WriteLine(sol.IsValid("(]"));
Console.WriteLine(sol.IsValid(""));
Console.WriteLine(sol.IsValid("(("));
Console.WriteLine(sol.IsValid("([{}])"));

public class Solution
{
	public bool IsValid(string s)
	{
		if(s.Length==0) return false;
		if (s.Length % 2 == 1) return false;

		var openSet = new Dictionary<char, char>
		{
			{ '(', ')' },
			{ '[', ']' },
			{ '{', '}' }
		};


		var stack = new Stack<char>();

		for (int i = 0; i < s.Length; i++)
		{
			if (openSet.ContainsKey(s[i]))
			{
				stack.Push(s[i]);
			}
			else
			{
				if (stack.Count == 0) return false;
				var openParen = stack.Pop();
				if(s[i] != openSet[openParen]) return false;
			}
		}

		if (stack.Count > 0) return false;

		return true;
	}
}