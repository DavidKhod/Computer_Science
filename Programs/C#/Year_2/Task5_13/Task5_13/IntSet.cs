public class IntSet
{
    private Node<int> list;

    //Constructor
    public IntSet()
    {
        this.list = null;
    }

    //Constructor
    public IntSet(Node<int> list)
    {
        this.list = list;
    }

    public Node<int> GetList()
    {
        if (this.list == null)
            return null;
        Node<int> copyStart = new Node<int>(list.Value);
        Node<int> posOfList = list.Next;
        for (Node<int> pos = copyStart.Next; posOfList != null; posOfList = posOfList.Next, pos = pos.Next)
            pos =  new Node<int>(posOfList.Value);
        return copyStart;

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

    //Entry: The fucntion inputs a linked list, and an integer
    //Exit: The function returns a linked list with no appearances of the integer inputed
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

    //Entry: The function inputs an IntSet
    //Exit: The function returns an IntSet with a linked list of the numbers that only appear in one of the linked lists
    public IntSet Unify(IntSet list2)
    {
        if (this.list == null)
            return new IntSet(list2.GetList());
        Node<int> unifyList = this.list;
        Node<int> pos;
        for (pos = unifyList; pos.HasNext(); pos = pos.Next) { }//Goes to the end of list
        pos.Next = list2.GetList();
        for (pos = list; pos != null; pos = pos.Next)
        {
            if (list2.Exist(pos.Value))
            {
                unifyList = RemoveNum(unifyList, pos.Value);
            }
        }
        return new IntSet(unifyList);
    }

    //Entry: The function inputs an IntSet
    //Exit: The function returns an IntSet with a list of the numbers that are in both of the Lists
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
        return $"{list}";
    }
}

