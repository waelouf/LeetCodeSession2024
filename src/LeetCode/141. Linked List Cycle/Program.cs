// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var node3 = new ListNode(3);
var node2 = new ListNode(2);
var node0 = new ListNode(0);
var node_4 = new ListNode(-4);

node3.next = node2;
node2.next = node0;
node0.next = node_4;
node_4.next = node2;

var sol = new Solution();
Console.WriteLine(sol.HasCycle(node3));


public class Solution
{
	public bool HasCycle(ListNode head)
	{
		if (head == null) return false;
		var curr = head;
		var hashSet = new HashSet<ListNode>();

		while (curr.next != null)
		{
			if(hashSet.Contains(curr)) return true;
			hashSet.Add(curr);
			curr = curr.next;
		}

		return false;
	}
}
public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int x)
	{
		val = x;
		next = null;
	}
}