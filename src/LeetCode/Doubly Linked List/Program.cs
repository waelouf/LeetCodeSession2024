// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");



public class DoublyLinkedList<T>
{
    private int length;
    private Node<T> head;
    private Node<T> tail;

    public DoublyLinkedList()
    {
        this.length = 0;
    }

    public void Prepend(T item)
    {
        var node = new Node<T>(item);
        length++;

        if(head is null)
        {
            head = tail = node;
        }

		node.Next = head;
		head.Previous = node;
        
        head = node;
    }

    public void InsertAt(T item, int index)
    {
        if (index > length) throw new Exception();
        else if (index == 0) Prepend(item);
        else if (index == length) Append(item);

        this.length++;

        var current = head;
        for (int i = 0; current is not null && i < index; i++)
        {
            current = current.Next;
        }
        
        var node = new Node<T>(item);

        
        node.Next = current!;
		node.Previous = current!.Previous;
        current.Previous = node;
        current.Previous.Next = current;
	}

    public void Append(T item)
    {
        var node = new Node<T>(item);
        length++;

        if(tail is null)
        {
            head = tail = node;
            return;
        }

        node.Previous = tail;
        tail.Next = node;
        tail = node;
    }

    public T Remove(T item)
    {
        var current = head;
        for (int i = 0; current is not null && i < length; i++)
        {
            if(current!.Value!.Equals(item))
            {
                break;
            }
        }

        if(current is null)
        {
            return default(T);
        }

        this.length--;
        if(length== 0)
        {
            var ret = this.head.Value;
            this.head = this.tail = null;
            return ret;
		}

        if(current.Previous is not null)
        {
            current.Previous = current.Next;
        }

        if(current.Next is not null)
        {
            current.Next = current.Previous;
        }

        if(current== this.head)
        {
            this.head = current.Next;
        }

        if(current == this.tail)
        {
            this.tail = current.Previous;
        }

        current.Previous = current.Next = null;

        return current.Value;
    }

    //public T Get(int index)
    //{

    //}

    //public T RemoveAt(int index)
    //{

    //}

    //private Node<T> GetAtIndex(int index)
    //{

    //}
}

public class Node<T> 
{
    public Node(T value)
    {
        this.Value = value;
    }

    public T Value { get; set; }

    public Node<T> Next { get; set; }

    public Node<T> Previous { get; set; }

}