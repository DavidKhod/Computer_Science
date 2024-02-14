public class Carrier
{
    public string id { get; }
    public double capacity { get; }
    public Carrier(string id, double capacity)
    {
        this.id = id;
        this.capacity = capacity;
    }

    //public override string ToString()
    //{
    //    return $"Id: {id}, Capacity: {capacity}";
    //}
}

