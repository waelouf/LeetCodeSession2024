// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Hello, World!");

var head = new ListNode
{
	val = 1,
	next = new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5))))
};

var head2 = new ListNode(1);
var head3 = new	ListNode(1, new ListNode(2));


var sol = new Solution();
var res = sol.RemoveNthFromEnd(head, 2);
//var res = sol.RemoveNthFromEnd(head2, 1);
//var res = sol.RemoveNthFromEnd(head3, 2);

var curr = res;
while (curr != null)
{
	Console.WriteLine(curr.val);
	curr = curr.next;
}


public class Solution
{
	public ListNode RemoveNthFromEnd(ListNode head, int n)
	{
		var tailPointer = head;
		for (int i = 0; i < n; i++)
		{
			tailPointer = tailPointer.next;
		}

		var dummy = new ListNode
		{
			val = int.MinValue,
			next = head
		};


		var nthPoint = dummy;

		while (tailPointer != null)
		{
			tailPointer = tailPointer.next;
			nthPoint = nthPoint.next;
		}


		nthPoint.next = nthPoint.next.next;
		
		return dummy.next;
	}
}

public class ListNode
{
	public int val;
	public ListNode next;
	public ListNode(int val = 0, ListNode next = null)
	{
		this.val = val;
		this.next = next;
	}
}