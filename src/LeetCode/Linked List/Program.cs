
// See https://aka.ms/new-console-template for more information

//var queue = new Queue<string>();
//queue.Enqueue("A");
//queue.Enqueue("B");
//queue.Enqueue("C");

//Console.WriteLine(queue.Peek());
//Console.WriteLine(queue.Deque());
//Console.WriteLine(queue.Peek());
//Console.WriteLine(queue.Count);

//Console.WriteLine(queue.Deque());


var stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());

Console.ReadLine();

public class Stack<T>
{
	private StackNode<T> head;
	private int count;
    public Stack()
    {
		head = null;
		count = 0;
    }

    public void Push(T item)
	{
		var node = new StackNode<T>(item);
		count++;

		if (head == null)
		{
			head = node;
			return;
		}

		node.Previous = head;
		head = node;
		
	}

	public T Pop()
	{
		var temp = head;

		head = head.Previous;
		count--;
		return temp.Value;
	}

	public T Peek()
	{
		return head.Value;
	}
}

public class StackNode<T>
{
    public T Value { get; set; }

    public StackNode<T> Previous { get; set; }

    public StackNode(T val)
    {
		this.Value = val;
		this.Previous = null;
    }
}

public class Queue<T>
{
	private Node<T>? head;
	private Node<T>? tail;
	private int count;

	public int Count => count;

	public Queue()
    {
		head = null;
		tail = null;
		count = 0;
    }

	public void Enqueue(T item)
	{
		var node = new Node<T>(item);
		if (tail == null)
		{
			tail = node;
		}

		tail.Next = node;
		tail = node;

		if(head == null)
		{
			head = tail;
		}

		count++;
	}

	public T Deque()
	{
		if (count == 0) throw new NullReferenceException();
		var temp = head;
		head = temp.Next;

		count--;
		return head.Value;
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