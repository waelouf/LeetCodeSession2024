// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var kthLarget = new KthLargest();


public class KthLargest
{
	PriorityQueue<int, int> pq;

	public KthLargest(int k, int[] nums)
	{
		 pq = new PriorityQueue<int, int>();
	}

	public int Add(int val)
	{
		pq.Enqueue(val, val);
		return 0;
	}
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */