// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
var node1 = new TreeNode
{
	val = 1,
	left = new TreeNode { val = 2 }
};
var node2 = new TreeNode
{
	val = 1,
	left = new TreeNode { val = 2 }
};

var solution= new Solution();

Console.WriteLine(solution.IsSameTree(node1, node2));


public class Solution
{
	public bool IsSameTree(TreeNode p, TreeNode q)
	{
		if (p is null && q is null) return true;
		if(p is null || q is null) return false;
		if(p.val != q.val) return false;

		return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
	}

	public bool IsSameTree1(TreeNode p, TreeNode q)
	{
		if(p.val != q.val) return false;
		var queue1 = new Queue<TreeNode>();
		var queue2 = new Queue<TreeNode>();

		queue1.Enqueue(p);
		queue2.Enqueue(q);

		while (queue1.Count!= 0 || queue2.Count != 0)
		{
			var dp = queue1.Dequeue();
			var dq = queue2.Dequeue();
			if (dp is null && dq is not null) return false;
			if (dq is null && dp is not null) return false;
			if (dp is not null && dq is not null && dp.val != dq.val) return false;
			if (dp is not null)
			{
				queue1.Enqueue(dp.left);
				queue1.Enqueue(dp.right);
			}

			if (dq is not null)
			{
				queue2.Enqueue(dq.left);
				queue2.Enqueue(dq.right);
			}
		}

		if (queue1.Count != queue2.Count) return false;

		return true;
	}
}

public class TreeNode
{
	public int val;
	public TreeNode left;
	public TreeNode right;
	public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
	{
		this.val = val;
		this.left = left;
		this.right = right;
	}
}