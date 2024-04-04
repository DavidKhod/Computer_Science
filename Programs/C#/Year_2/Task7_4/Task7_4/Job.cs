public class Job
{
    public string id { get;}
    public int duration { get; }

    public Job(string id, int duration)
    {
        this.id = id;
        this.duration = duration;
    }

    public override string ToString()
    {
        return $"Id: {id}, Duration: {duration}";
    }
}

