// See https://aka.ms/new-console-template for more information
using System.Collections;

var root = new TreeNode<int>();

root.Value = 1;

var rootLeft = new TreeNode<int>();

rootLeft.Value = 2;
rootLeft.Left = new TreeNode<int> { Value = 4 };
rootLeft.Right = new TreeNode<int> { Value = 5 };

var rootRight = new TreeNode<int>();
rootRight.Value = 3;

rootRight.Left = new TreeNode<int> { Value = 6 };
rootRight.Right = new TreeNode<int> { Value = 7 };

root.Left = rootLeft;
root.Right = rootRight;

var tree = new Tree<int>();
tree.Root = root;

Console.WriteLine(string.Join(",", tree.BFS())); // 1,2,3,4,5,6,7

public class Tree<T>
{
	public TreeNode<T> Root { get; set; }

	public T[] BFS()
	{
		var q = new Queue<TreeNode<T>>();
		var path = new List<T>();
		q.Enqueue(Root);
		while (q.Count>0)
		{
			var node = q.Dequeue();
			path.Add(node.Value);
			if (node.Left != null)
			{
				q.Enqueue(node.Left);
			}

			if (node.Right != null)
			{
				q.Enqueue(node.Right);
			}
		}

		return path.ToArray();
	}
}

public class TreeNode<T>
{
	public T Value { get; set; }

	public TreeNode<T> Left { get; set; }
	public TreeNode<T> Right { get; set; }
}