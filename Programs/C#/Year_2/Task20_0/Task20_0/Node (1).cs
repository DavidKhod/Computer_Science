
using System;

public class Node<T>
{
    private T value;//The value
    private Node<T> next;//points onto the next node

    /// <summary>
    /// The Function sets the this.value To the type and its value inputed and this.next into the T Node inputed
    /// </summary>
    /// <param name="value">The value this.value is set to</param>
    /// <param name="next">The T Node this.next becomes the pointer of</param>
    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }

    /// <summary>
    /// Build Function that inputs only a T and sets its value as this.value and this.next as null
    /// </summary>
    /// <param name="value">The value inputed</param>
    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }

    public T GetValue()
    {
        return this.value;
    }

    public void SetValue(T value)
    {
        this.value = value;
    }

    public bool HasNext()
    {
        return this.next != null;
    }
    
    public Node<T> GetNext()
    {
        return this.next;
    }

    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    public override string ToString()
    {
        return $"{this.value} -> {this.next}";
    }
}

