public class Queue<T>
{
    private Node<T> head;
    private Node<T> tail;

    public Queue()
    {
        head = null;
        tail = null;
    }
    public T Head()
    {
        return head.Value;
    }

    public void Insert(T x)
    {
        if (IsEmpty())
        {
            head = new Node<T>(x);
            tail = head;
        }
        else
        {
            tail.Next = new Node<T>(x);
            tail = tail.Next;
        }
    }

    //Want to talk about why its not working

    //public void Insert2(T x)
    //{
    //    if (IsEmpty())
    //    {
    //        head = new Node<T>(x);
    //        head.Next = tail;
    //    }
    //    else
    //    {
    //        tail = new Node<T>(x, tail);
    //        tail = tail.Next;
    //    }
    //}

    public T Remove()
    {
        T value = head.Value;
        head = head.Next;
        return value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }


    public override string ToString()
    {
        if (IsEmpty())
            return "";
        return $"{head.ToString()}";
    }
}

