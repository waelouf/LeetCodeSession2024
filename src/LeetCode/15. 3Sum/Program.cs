// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var sol = new Solution();

var result = sol.ThreeSum([-1, 0, 1, 2, -1, -4]);
//var result = sol.ThreeSum([-3, 3, 4, -3, 1, 2]);
foreach (var item in result)
{
	Console.WriteLine(string.Join(",", item));
}

public class Solution
{
	public IList<IList<int>> ThreeSum(int[] nums)
	{
		var result = new List<IList<int>>();
		var sorted = nums.Order().ToArray();
		for (int i = 0; i < sorted.Length; i++)
		{
			if (i > 0 && sorted[i] == sorted[i - 1]) continue;
			int left = i + 1;
			int right = sorted.Length - 1;
			while (left < right)
			{
				if (sorted[left] + sorted[right] + sorted[i] == 0)
				{
					result.Add(new List<int>
					{
						sorted[i],
						sorted[left],
						sorted[right]
					});
					left++;
					while (sorted[left] == sorted[left - 1] && left<right)
					{
						left++;
					}
				} 
				else if (sorted[left] + sorted[right] + sorted[i] > 0)
				{
					right--;
				}
				else
				{
					left++;
				}
			}

		}



		return result;
	}
}