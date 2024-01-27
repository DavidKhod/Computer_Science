public class IntSet
{
    private Node<int> list;

    public IntSet()
    {
        this.list = null;
    }

    public IntSet(Node<int> list)
    {
        this.list = list;
    }

    public Node<int> GetList
    {
        get
        {
            Node<int> copyStart = new Node<int>(list.Value);
            Node<int> posOfList = list.Next;
            for (Node<int> pos = copyStart.Next; posOfList != null; posOfList = posOfList.Next, pos = pos.Next)
                pos.Value = posOfList.Value;
            return copyStart;
        }
    }

    public void Add(int x)
    {
        if (!Exist(x))
        {
            list = new Node<int>(x, list);
        }
    }

    public void Delete(int x)
    {
        this.list = RemoveNum(this.list, x);
    }

    private Node<int> RemoveNum(Node<int> list, int num)
    {
        Node<int> previous;
        Node<int> pos;
        while (list != null && list.Value == num)
        {
            list = list.Next;
        }
        if (list == null)
            return list;
        previous = list;
        pos = list.Next;
        while (pos != null)
        {
            if (pos.Value == num)
            {
                pos = pos.Next;
                previous.Next = pos;
            }
            else
            {
                previous = pos;
                pos = pos.Next;
            }
        }
        return list;
    }


    public IntSet Unify(IntSet list2)
    {
        Node<int> unifyList = this.GetList;
        Node<int> pos;
        for (pos = unifyList; pos.HasNext(); pos = pos.Next) { }//Goes to the end of list
        pos.Next = list2.GetList;
        for (pos = list; pos != null; pos = pos.Next)
        {
            if (list2.Exist(pos.Value))
            {
                unifyList = RemoveNum(unifyList, pos.Value);
            }
        }
        return new IntSet(unifyList);
    }

    public IntSet Intersect(IntSet list2)
    {
        Node<int> unifyList = null;
        Node<int> unyPos = unifyList;
        for (Node<int> pos = list; pos != null; pos = pos.Next)
        {
            if (list2.Exist(pos.Value))
            {
                unyPos = new Node<int>(pos.Value);
                pos = pos.Next;
            }
        }
        return new IntSet(unifyList);
    }

    public bool Exist(int num)
    {
        for (Node<int> pos = list; pos != null; pos = pos.Next)
            if (pos.Value == num)
                return true; 
        return false;
    }

    public override string ToString()
    {
        return $"{list.ToString()}";
    }
}

