public class MessageBox
{
    public string owner { get; }
    private Queue<Message> messages;
    private Queue<Message> bin;
    public int max_capacity { get; set; }
    private int activeCap;
    private int binCap;
    private int currentCap;


    public MessageBox(string owner)
    {
        this.owner = owner;
        messages = new Queue<Message>();
        bin = new Queue<Message>();
        activeCap = 0;
        max_capacity = 100;
        currentCap = binCap + activeCap;
    }

    public bool AddMessage(Message m)
    {
        if (currentCap + m.bSize > max_capacity)
        {
            while (!bin.IsEmpty() && currentCap + m.bSize > max_capacity)
            {
                if (!bin.IsEmpty())
                {
                    binCap -= bin.Head().bSize;
                    UpdateCurrentSize();
                    bin.Remove();
                }
            }
            if (currentCap + m.bSize <= max_capacity)
            {
                messages.Insert(m);
                activeCap += m.bSize;
                UpdateCurrentSize();
                return true;
            }
            else
            {
                UpdateCurrentSize();
                return false;
            }
        }
        messages.Insert(m);
        activeCap += m.bSize;
        UpdateCurrentSize();
        return true;
    }

    public int RemoveFromBin()
    {
        if (!bin.IsEmpty())
            return bin.Remove().id;
        return -1;
    }

    public void EmptyBin()
    {
        bin = new Queue<Message>();
    }

    public int GetActiveSize()
    {
        return activeCap;
    }

    public int GetBinSize()
    {
        return binCap;
    }

    private void UpdateCurrentSize()
    {
        currentCap = binCap + activeCap;
    }

}

