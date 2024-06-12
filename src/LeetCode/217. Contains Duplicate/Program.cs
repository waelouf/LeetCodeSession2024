
var solution = new Solution();
var arr1 = new int[] { 1, 2, 3, 1 }; // true
var arr2 = new int[] { 1, 2, 3, 4 }; // false
var arr3 = new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }; // true

Console.WriteLine(solution.ContainsDuplicate(arr1));
Console.WriteLine(solution.ContainsDuplicate(arr2));
Console.WriteLine(solution.ContainsDuplicate(arr3));

Console.ReadKey();


public class Solution
{
	public bool ContainsDuplicate(int[] nums)
	{
		var hash = new HashSet<int>();
		foreach (int num in nums)
		{
			if(!hash.Contains(num))
			{
				hash.Add(num);
			}
			else
			{
				return true;
			}
		}

		return false;
	}
}