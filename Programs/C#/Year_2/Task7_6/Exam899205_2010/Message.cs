
public class Message
{
    public string sender { get; }
    public string content { get; }
    private static int ID;
    public int id { get; }
    public int bSize { get; }

    public Message(string sender, string content, int bSize)
    {
        this.sender = sender;
        this.content = content;
        this.bSize = bSize;
        id = ID++;
    }

    public override string ToString()
    {
        return $"Sender: {sender}\nId: {id}\nBit size: {bSize}\nContent: {content}";
    }
}

