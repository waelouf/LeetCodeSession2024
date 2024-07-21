// See https://aka.ms/new-console-template for more information
var lst1 = new ListNode
{
	val = 1,
	next = new ListNode
	{
		val = 2,
		next = new ListNode { val = 4 }
	}
};

var lst2 = new ListNode
{
	val = 1,
	next = new ListNode { val = 3, next = new ListNode { val = 4 } }
};

var sol = new Solution();
var res = sol.MergeTwoLists(lst1, lst2);

var curr = res;
while (curr!= null)
{
	Console.WriteLine(curr.val);
	curr = curr.next;
}


public class Solution
{
	public ListNode MergeTwoLists(ListNode list1, ListNode list2)
	{

		ListNode result = new ListNode();
		var head = result;

		while (list1 != null && list2 != null)
		{
			if(list1.val <= list2.val)
			{
				head.next = list1;
				list1 = list1.next;
			}
			else
			{
				head.next = list2;
				list2 = list2.next;
			}

			head = head.next;
		}

		if (list1 != null)
			head.next = list1;

		if (list2 != null)
			head.next = list2;

		

		return result.next;
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