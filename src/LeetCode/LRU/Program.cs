// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");


public class LRU<K,V>
{
    public LRU()
    {
        
    }

    public void Update(K key, V value)
    {

    }

    public V? GetV(K key)
    {
        throw new Exception();
    }
}

public class Node<V>
{
    public V Value { get; set; }

    public Node<V> Next { get; set; }

    public Node<V> Previous { get; set; }
}