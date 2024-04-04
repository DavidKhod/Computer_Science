//The class StringNode presents a node with integers only
public class StringNode
{
    private string value;//The value
    private StringNode next;//points onto the next node

    public StringNode(string value, StringNode next)
    {
        this.value = value;
        this.next = next;
    }

    public StringNode(string value)
    {
        this.value = value;
        this.next = null;
    }

    public StringNode GetNext()
    {
        return this.next;
    }

    public string GetValue()
    {
        return this.value;
    }

    public void SetValue(string value)
    {
        this.value = value;
    }

    public void SetNext(StringNode next)
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

