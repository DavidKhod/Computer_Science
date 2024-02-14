public class Client
{
    public string id { get; }

    public Client(string id)
    {
        this.id = id; 
    }

    public override string ToString()
    {
        return $"Id: {id}";
    }
}

