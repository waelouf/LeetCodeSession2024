// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var kthLarget = new KthLargest(3, [4, 5, 8, 2]);
Console.WriteLine(kthLarget.Add(3));
Console.WriteLine(kthLarget.Add(5));
Console.WriteLine(kthLarget.Add(10));
Console.WriteLine(kthLarget.Add(9));
Console.WriteLine(kthLarget.Add(4));


public class KthLargest
{
	PriorityQueue<int, int> pq;
	int k;

	public KthLargest(int k, int[] nums)
	{
		pq = new PriorityQueue<int, int>();
		this.k = k;
		foreach (var item in nums)
		{
			pq.Enqueue(item, item);
		}

		while (pq.Count > k)
		{
			pq.Dequeue();
		}
	}

	public int Add(int val)
	{
		this.pq.Enqueue(val, val);

		if(pq.Count > k)
		{
			pq.Dequeue();
		}

		return pq.Peek();
	}
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */