// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var node = new Node()
{
    Value = 17,
    Left = new Node
    {
        Value = 10,
        Left = new Node { Value = 8 }
    },
    Right = new Node
    {
        Value = 30,
        Left = new Node { Value = 25 },
        Right = new Node { Value = 100 }
    }
};

var bst = new BSTSearch(node);
Console.WriteLine(bst.Find(90));
Console.WriteLine(bst.Find(100));
Console.WriteLine(bst.Find(35));
Console.WriteLine(bst.Find(17));
Console.WriteLine(bst.Find(10));
Console.WriteLine(bst.Find(8));
Console.WriteLine(bst.Find(9));
Console.WriteLine(bst.Find(25));

public class BSTSearch
{
    private Node root;

    public BSTSearch(Node node)
    {
        root = node;
    }

    public bool Find(int value)
    {
        return DFS(root, value);
    }

    public bool DFS(Node node, int value)
    {
        if(node == null)
        {
            return false;
        }

        if(node.Value == value)
        {
            return true;
        }

        if (node.Value >= value)
        {
            return DFS(node.Left, value);
        }

        return DFS(node.Right, value);
    }
}

public class Node
{
    public int Value { get; set; }
    public Node Left { get; set; }
	public Node Right { get; set; }
}