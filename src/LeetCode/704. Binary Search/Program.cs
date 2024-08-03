// See https://aka.ms/new-console-template for more information

var sol = new Solution();
 Console.WriteLine(sol.Search([-1, 0, 3, 5, 9, 12], 9));
 Console.WriteLine(sol.Search([-1, 0, 3, 5, 9, 12], 2));
Console.WriteLine(sol.Search([5], 5));
Console.WriteLine(sol.Search([2, 5], 5));


public class Solution
{
	public int Search(int[] nums, int target)
	{
		var foundIndex = -1;
		
		int start = 0;
		int end = nums.Length - 1;

		while (start <= end)
		{
			var middleIndex = (end + start) / 2;
			if (nums[middleIndex] == target)
			{
				return middleIndex;
			}

			if (nums[middleIndex] > target)
			{
				end = middleIndex - 1;
			}
			else
			{
				start = middleIndex + 1;
			}
			
		}

		return foundIndex;
	}
}