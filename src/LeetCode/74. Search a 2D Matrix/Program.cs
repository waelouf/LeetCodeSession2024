// See https://aka.ms/new-console-template for more information

var sol = new Solution();
Console.WriteLine(sol.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13));
Console.WriteLine(sol.SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3));
Console.WriteLine(sol.SearchMatrix([[1, 3]], 3));

public class Solution
{
	public bool SearchMatrix(int[][] matrix, int target)
	{
		bool found = false;

		var top = 0;
		var btm = matrix.Length - 1;

		while (top <= btm)
		{
			var middle = (top + btm) / 2;
			var row = matrix[middle];
			if (row[0] > target)
			{
				btm = middle - 1;
			}
			else if (row[row.Length - 1] < target)
			{
				top = middle + 1;
			}
			else
				break;
		}


		BinarySearch(matrix[(top + btm) / 2]);




		void BinarySearch(int[] lst)
		{
			int left = 0;
			int right = lst.Length - 1;
			while (left <= right)
			{
				int middle = (left + right) / 2;
				if (lst[middle] == target)
				{
					found = true;
					break;
				}
				else if (lst[middle] > target)
				{
					right = middle - 1;
				}
				else
				{
					left = middle + 1;
				}
			}
		}

		return found;
	}
}