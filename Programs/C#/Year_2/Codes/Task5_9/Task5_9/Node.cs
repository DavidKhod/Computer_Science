public class Node<T>
{
    private T value;
    private Node<T> next;

    /// <summary>
    /// Constructor for creating a Node with a specified value.
    /// </summary>
    /// <param name="value">The value to be stored in the Node.</param>
    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }

    public Node(T value, Node<T> next)
    {
        this.value = value;
        this.next = next;
    }

    /// <summary>
    /// Gets the pointer to the next Node.
    /// </summary>
    /// <returns>The pointer to the next Node.</returns>
    public Node<T> GetNext()
    {
        return this.next;
    }

    /// <summary>
    /// Gets the value stored in the Node.
    /// </summary>
    /// <returns>The value stored in the Node.</returns>
    public T GetValue()
    {
        return this.value;
    }

    /// <summary>
    /// Sets the pointer to the next Node.
    /// </summary>
    /// <param name="next">The Node to be set as the next Node.</param>
    public void SetNext(Node<T> next)
    {
        this.next = next;
    }

    /// <summary>
    /// Sets the value stored in the Node.
    /// </summary>
    /// <param name="value">The value to be stored in the Node.</param>
    public void SetValue(T value)
    {
        this.value = value;
    }

    /// <summary>
    /// Property to get or set the value stored in the Node.
    /// </summary>
    public T Value
    {
        get { return this.value; }
        set { this.value = value; }
    }

    /// <summary>
    /// Checks if the Node has a next Node linked to it.
    /// </summary>
    /// <returns>True if there is a next Node, otherwise false.</returns>
    public bool HasNext()
    {
        return this.next != null;
    }

    /// <summary>
    /// Property to get or set the reference to the next Node.
    /// </summary>
    public Node<T> Next
    {
        get { return this.next; }
        set { this.next = value; }
    }

    /// <summary>
    /// Overrides the ToString method to represent the Node's value and next pointer.
    /// </summary>
    /// <returns>A string representation of the Node.</returns>
    public override string ToString()
    {
        return $"{this.value} -> {this.next}";
    }
}