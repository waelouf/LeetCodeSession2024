// See https://aka.ms/new-console-template for more information
using System.Net.Http.Headers;

var sort = new QuickSort();


int[] arr = new int[] { 6, 4, 9, 34, 99, 2, 1, 0 };

Console.WriteLine(string.Join(",", arr));

sort.Sort(arr);
Console.WriteLine(string.Join(",", arr));




public class QuickSort
{
	public void QSort(int[] arr, int lo, int hi)
	{
		if(lo >= hi)
		{
			return;
		}

		var pivotIndex = Partition(arr, lo, hi);
		QSort(arr, lo, pivotIndex - 1);
		QSort(arr, pivotIndex + 1, hi);
	}

	public int Partition(int[] arr, int lo, int hi)
	{
		var pivot = arr[hi];
		var index = lo - 1;

		for (int i = lo; i < hi; i++)
		{
			if (arr[i] <= pivot)
			{
				index++;
				var temp = arr[i];
				arr[i] = arr[index];
				arr[index] = temp;
			}
		}

		index++;
		arr[hi] = arr[index];
		arr[index] = pivot;
		return index;
	}

	public void Sort(int[] arr)
	{
		QSort(arr, 0, arr.Length - 1);
	}
}