
// See https://aka.ms/new-console-template for more information

var queue = new Queue<string>();
queue.Enqueue("A");
queue.Enqueue("B");
queue.Enqueue("C");

Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Peek());
Console.WriteLine(queue.Count);
Console.WriteLine(queue.Dequeue());


public class Queue<T>
{
	private Node<T> head;
	private Node<T> tail;
	private int _count;

	public int Count
	{
		get
		{
			return _count;
		}
	}

    public Queue()
    {
		_count = 0;
    }

    public void Enqueue(T value)
	{
		var node = new Node<T>(value);
		if (tail != null)
		{
			tail.Next = node;
		}

		tail = node;

		if(head == null)
		{
			head = tail;
		}

		_count++;
	}

	public T Dequeue()
	{
		if (Count == 0) throw new IndexOutOfRangeException();
		var val = head.Value;
		head = head.Next;

		_count--;
		return val;
	}

	public T Peek()
	{
		return head.Value;
	}
}

public class LinkedList<T>
{
	private Node<T> root;
}

public class DoubleLinkedList<T>
{
	private DoubleNode<T> root;
}

public class Node<T>
{
    public T Value { get; set; }

	public Node<T> Next { get; set; }

	public Node(T value)
	{
		Value = value;
		Next = null;
	}

    public Node()
    {
        
    }
}

public class DoubleNode<T>
{
	public T Value { get; set; }

	public DoubleNode<T> Next { get; set; }

    public DoubleNode<T> Previous { get; set; }

    public DoubleNode(T value)
	{
		Value = value;
		Next = null;
	}
}