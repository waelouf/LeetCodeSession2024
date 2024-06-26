// See https://aka.ms/new-console-template for more information
var bs = new BinarySearch();


Console.WriteLine(bs.Find([1,2,3,4,5,6,7,8,9], 20));

public class BinarySearch
{
	public bool Find(int[] arr, int item)
	{
		int start = 0;
		int end = arr.Length - 1;

		while (start < end) 
		{
			int searchIndex = (start + end) / 2;
			if (arr[searchIndex] == item)
			{
				return true;
			}
			else if (arr[searchIndex] < item)
			{
				start = searchIndex + 1;
			}
			else
			{
				end = searchIndex;
			}
		}

		return false;
	}
}