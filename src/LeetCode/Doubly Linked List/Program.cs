// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");



public class DoublyLinkedList<T>
{
    private int length;
    private Node<T> head;

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
            head = node;
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

        var current = head;
        for (int i = 0; current is not null && i < index; i++)
        {
            current = current.Next;
        }
        
        var node = new Node<T>(item);

        
        node.Next = current;
		node.Previous = current!;
	}

    public void Append(T item)
    {

    }

    public T? Remove(T item)
    {

    }


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