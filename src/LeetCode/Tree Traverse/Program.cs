// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");


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

Console.WriteLine(string.Join(",",tree.PreOrderTraverse()));	// 1,2,4,5,3,6,7
Console.WriteLine(string.Join(",", tree.InOrderTraverse()));	// 4,2,5,1,6,3,7
Console.WriteLine(string.Join(",", tree.PostOrderTraverse()));  // 4,5,2,6,7,3,1


public class Tree<T>
{
	public TreeNode<T> Root { get; set; }

	public T[] PreOrderTraverse()
	{
		var path = new List<T>();
		return PreOrderTraverse(Root, path).ToArray();
	}

	private List<T> PreOrderTraverse(TreeNode<T> node, List<T> path)
	{
		if (node == null)
		{
			return path;
		}

		path.Add(node.Value);
		PreOrderTraverse(node.Left, path);
		PreOrderTraverse(node.Right, path);

		return path;
	}

	public T[] InOrderTraverse()
	{
		var path = new List<T>();
		return InOrderTraverse(Root, path).ToArray();
	}

	private List<T> InOrderTraverse(TreeNode<T> node, List<T> path)
	{
		if (node == null)
		{
			return path;
		}

		InOrderTraverse(node.Left, path);
		path.Add(node.Value);
		InOrderTraverse(node.Right, path);

		return path;
	}

	public T[] PostOrderTraverse()
	{
		var path = new List<T>();
		return PostOrderTraverse(Root, path).ToArray();
	}

	private List<T> PostOrderTraverse(TreeNode<T> node, List<T> path)
	{
		if(node == null)
		{
			return path;
		}

		PostOrderTraverse(node.Left, path);
		PostOrderTraverse(node.Right, path);
		path.Add(node.Value);

		return path;
	}


}


public class TreeNode<T>
{
    public T Value { get; set; }

    public TreeNode<T> Left { get; set; }
	public TreeNode<T> Right { get; set; }
}