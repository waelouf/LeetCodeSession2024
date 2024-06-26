// See https://aka.ms/new-console-template for more information

var sol = new BubbleSort();
int[] arr = [1, 2, 7, 4, 5, 6, 8, 3];
Console.WriteLine(string.Join(",", arr));

sol.Sort(arr);

Console.WriteLine(string.Join(",", arr));


public class BubbleSort
{
	public void Sort(int[] arr)
	{
		int lastIndex = arr.Length - 1;

		while (lastIndex > 1)
		{
			for (int i = 0; i < lastIndex; i++)
			{
				if (arr[i] > arr[i+1])
				{
					var temp = arr[i];
					arr[i] = arr[i+1];
					arr[i+1] = temp;
				}
			}

			lastIndex--;
		}
	}
}