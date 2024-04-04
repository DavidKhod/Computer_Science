public class DoubleQueue
{
    private Queue<int> shortQ;
    private Queue<int> longQ;
    private int shortCnt = 0;//The amount of concurrent people in the short queue 

    public DoubleQueue()
    {
        shortQ = new Queue<int>();
        longQ = new Queue<int>();
    }

    private Queue<int> Duplicate(Queue<int> current)
    {
        Queue<int> copy = new Queue<int>();
        Queue<int> temp = new Queue<int>();
        while (!current.IsEmpty())
        {
            temp.Insert(current.Remove());
        }
        while (!temp.IsEmpty())
        {
            current.Insert(temp.Head());
            copy.Insert(temp.Remove());
        }
        return copy;
    }

    public Queue<int> ReturnByAct(int act)
    {
        if (act == 0)
            return Duplicate(longQ);
        return Duplicate(shortQ);
    }

    public void InsertClientToQueue(int num, int act)
    {
        if (act == 0)
            longQ.Insert(num);
        else
        {
            shortQ.Insert(num);
            shortCnt++;
        }
    }

    public int GetNextClient()
    {
        if (shortQ.IsEmpty() && !longQ.IsEmpty())
            return longQ.Remove();
        if(shortCnt < 5 && !shortQ.IsEmpty())
        {
            shortCnt--;
            return shortQ.Remove();
        }
        if (shortCnt % 5 == 0 && !longQ.IsEmpty())
            return longQ.Remove();
        shortCnt--;
        return shortQ.Remove();
    }

    public override string ToString()
    {
        string rtn = "";
        rtn += $"Short queue: {shortQ.ToString()}\n";
        rtn += $"Long queue: {longQ.ToString()}";
        return rtn;
    }
}

