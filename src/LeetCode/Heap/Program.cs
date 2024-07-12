// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var heap = new Heap();

heap.Insert(100);
heap.Insert(90);
heap.Insert(80);
heap.Insert(1001);
heap.Insert(102);
heap.Insert(107);
Console.WriteLine(heap.Delete());
Console.WriteLine(heap.Delete());
Console.WriteLine(heap.Delete());
Console.WriteLine(heap.Delete());
Console.WriteLine(heap.Delete());
Console.WriteLine(heap.Delete());
Console.WriteLine(heap.Delete());

public class Heap
{
	int[] heap;
    int length;

    public Heap()
    {
        heap = new int[10];
        length = 0;
    }

    public void Insert(int value)
    {
        heap[length] = value;
        HeapifyUp(length);
        length++;
    }

    public int Delete()
    {
        if(length == 0)
        {
            
            throw new IndexOutOfRangeException();
        }

		var returnValue = heap[0];
		length--;

		if (length == 0)
        {
            length = 0;
            heap = new int[10];
            return returnValue;
        }
                
        heap[0] = heap[length];

        
        HeapifyDown(0);

        return returnValue;
    }

	private void HeapifyUp(int index)
	{
        if(index == 0)
        {
            return;
        }

        var parentIndex = Parent(index);
        var parentValue = heap[parentIndex];
        var value = heap[index];
        if(parentValue > value)
        {
            heap[index] = parentValue;
            heap[parentIndex] = value;
            HeapifyUp(parentIndex);
        }
	}

    private void HeapifyDown(int index)
    {
        var leftIndex = LeftChild(index);
        var rightIndex = RightChild(index);

        if (index >= length || leftIndex >= length)
        {
            return;
        }

        var leftValue = heap[leftIndex];
        var rightValue = heap[rightIndex];
        var value = heap[index];

        if(leftValue > rightValue && value > rightValue)
        {
            heap[index] = rightValue;
            heap[rightIndex] = value;
            HeapifyDown(rightIndex);
        }
        else if(rightValue > leftValue && value > leftValue)
        {
            heap[index] = leftValue;
            heap[leftIndex] = value;
            HeapifyDown(leftIndex);
        }

    }

    private int Parent(int i)
    {
        return (i - 1) / 2;
    }

    private int LeftChild(int i)
    {
        return (i * 2) + 1;
    }

	private int RightChild(int i)
	{
		return (i * 2) + 2;
	}

	private void ExpandCapacity()
    {

    }
}