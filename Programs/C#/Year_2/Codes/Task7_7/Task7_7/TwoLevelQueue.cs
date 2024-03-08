public class TwoLevelQueue<T>
{
    private Queue<T> q1;
    private Queue<T> q2;

    public TwoLevelQueue()
    {
        q1 = new Queue<T>();
        q2 = new Queue<T>();
    }

    public bool IsEmpty()
    {
        return q1.IsEmpty() && q2.IsEmpty();
    }

    public void Insert(T x, int type)
    {
        if (type == 1)
            q1.Insert(x);
        else
            q2.Insert(x);
    }

    public T Remove()
    {
        if (!q1.IsEmpty())
            return q1.Remove();
        else
            return q2.Remove();
    }

    private Queue<T> Duplicate(Queue<T> current)
    {
        Queue<T> copy = new Queue<T>();
        Queue<T> temp = new Queue<T>();
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

    private int Length(Queue<T> que)
    {
        int cnt = 0;
        Queue<T> copy = Duplicate(que);
        while (!copy.IsEmpty())
        {
            cnt++;
            copy.Remove();
        }
        return cnt;
    }


    public int Size(int type)
    {
        if (type == 1)
            return Length(q1);
        else
            return Length(q2);
    }

    public override string ToString()
    {
        return $"q1: {q1.ToString()}\nq2: {q2.ToString()}";
    }
}

