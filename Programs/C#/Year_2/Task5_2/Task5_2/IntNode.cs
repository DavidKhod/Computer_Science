﻿//The class IntNode presents a node with integers only
public class IntNode
{
    private int value;//The value
    private IntNode next;//points onto the next node

    /// <summary>
    /// The Function sets the this.value into the integer inputed and this.next into the IntNode inputed
    /// </summary>
    /// <param name="value">The value this.value is set to</param>
    /// <param name="next">The IntNode this.next becomes the pointer of</param>
    public IntNode(int value, IntNode next)
    {
        this.value = value;
        this.next = next;
    }

    /// <summary>
    /// Build Function that inputs only an integer and sets its value as this.value and this.next as null
    /// </summary>
    /// <param name="value">The integer inputed</param>
    public IntNode(int value)
    {
        this.value = value;
        this.next = null;
    }

    /// <summary>
    /// Returns the pointer of the next node
    /// </summary>
    /// <returns>The pointer of the next node</returns>
    public IntNode GetNext()
    {
        return this.next;
    }

    public int GetValue()
    {
        return this.value;
    }

    public void SetValue(int value)
    {
        this.value = value;
    }

    /// <summary>
    /// Changes to what node this.next points at
    /// </summary>
    /// <param name="next">To this.next is going to point at</param>
    public void SetNext(IntNode next)
    {
        this.next = next;
    }
    public bool HasNext()
    {
        return this.GetNext() != null;
    }

    public override string ToString()
    {
        return $"{this.value} -> {this.next}";
    }
}

