// See https://aka.ms/new-console-template for more information

var tree1 = new Tree<int>()
{
	Root = new TreeNode<int>
	{
		Value = 1,
		Left = new TreeNode<int> { Value = 2 },
		Right = new TreeNode<int> { Value = 3 },
	}
};
var tree2 = new Tree<int>()
{
	Root = new TreeNode<int>
	{
		Value = 1,
		Left = new TreeNode<int> { Value = 2 },
		Right = new TreeNode<int> { Value = 3 },
	}
};
var tree3 = new Tree<int>()
{
	Root = new TreeNode<int>
	{
		Value = 1,
		Left = new TreeNode<int> { Value = 2, Left = new TreeNode<int> { Value = 3 } }
	}
};

var sol = new Solution<int>();
Console.WriteLine(sol.Compare(tree1.Root, tree2.Root));
Console.WriteLine(sol.Compare(tree1.Root, tree3.Root));
Console.WriteLine(sol.Compare(tree2.Root, tree3.Root));

Console.ReadLine();

public class Solution<T>
{
	public bool Compare(TreeNode<T> node1, TreeNode<T> node2)
	{
		if (node1 == null && node2 == null)
		{
			return true;
		} 

		if(node1 == null || node2 == null)
		{
			return false;
		}

		if(!node1.Value.Equals(node2.Value))
		{
			return false;
		}

		return Compare(node1.Left, node2.Left) && Compare(node1.Right, node2.Right);
	}
}

public class Tree<T>
{
	public TreeNode<T> Root { get; set; }
}

public class TreeNode<T>
{
	public T Value { get; set; }

	public TreeNode<T> Left { get; set; }
	public TreeNode<T> Right { get; set; }
}