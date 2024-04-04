namespace IntSortedCollectionClass
{
    public class IntSortedCollection
    {
        private Node<int> list;

        public IntSortedCollection()
        {
            list = null;
        }

        public IntSortedCollection(Node<int> list)
        {
            this.list = list;
        }

        public void Insert(int x)
        {
            if (list == null)
            {
                list = new Node<int>(x);
                return;
            }
            if (x <= list.Value)
            {
                list = new Node<int>(x, list);
            }
            else
            {
                Node<int> temp = list;
                while (temp.HasNext() && x > temp.Next.Value)
                    temp = temp.Next;
                temp.Next = new Node<int>(x, temp.Next);
            }
        }

        public bool Exist(int x)
        {
            for (Node<int> pos = list; pos != null; pos = pos.Next)
                if (pos.Value == x)
                    return true;
            return false;
        }

        public void Delete(int num)
        {
            Node<int> previous;
            Node<int> pos;
            while (list != null && list.Value == num)
            {
                list = list.Next;
            }
            if (list == null)
                return;
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
        }

        public int[] GetAll()
        {
            int[] arr = new int[this.GetLength()];
            int i = 0;
            for (Node<int> pos = list; pos != null; pos = pos.Next, i++)
                arr[i] = pos.Value;
            return arr;
        }

        private int GetLength()
        {
            int cnt = 0;
            for (Node<int> pos = list; pos != null; pos = pos.Next)
                cnt++;
            return cnt;
        }

        public override string ToString()
        {
            return $"{list}";
        }
    }
}
