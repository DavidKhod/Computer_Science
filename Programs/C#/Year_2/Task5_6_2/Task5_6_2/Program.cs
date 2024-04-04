using System;

namespace Task5_6_2
{
    class Program
    {
        static int ConvertToNum(Node<int> list)//Q32 helper
        {
            int num = list.Value;
            list = list.Next;
            while (list != null)
            {
                num *= 10;
                num += list.Value;
                list = list.Next;
            }
            return num;
        }

        static int WhosBigger(Node<int> list1, Node<int> list2)//Q32
        {
            int numOfList1 = ConvertToNum(list1);
            int numOfList2 = ConvertToNum(list2);
            if (numOfList1 > numOfList2)
                return 1;
            else if (numOfList1 < numOfList2)
                return 2;
            return 0;
        }

        static Node<int> DeleteNode(Node<int> list, Node<int> toDelete)//Q33
        {
            Node<int> pos = list;
            Node<int> startOfDelete = toDelete;
            if (list.Value == toDelete.Value)
            {
                bool found = true;
                while (pos != null && toDelete != null && found)
                {
                    pos = pos.Next;
                    toDelete = toDelete.Next;
                    if (pos != null && toDelete != null && found)
                        found = false;
                }
                if (found)
                {
                    list = pos;
                }
                toDelete = startOfDelete;
            }
            pos = pos.Next;
            Node<int> prev = list;
            while (pos != null)
            {
                if (pos.Value == toDelete.Value)
                {
                    bool found = true;
                    while (pos != null && toDelete != null && found)
                    {
                        pos = pos.Next;
                        toDelete = toDelete.Next;
                        if (pos != null && toDelete != null && pos.Value != toDelete.Value)
                            found = false;
                    }
                    if (found)
                    {
                        prev.Next = pos;
                        return list;
                    }
                    else
                    {
                        prev = pos;
                        pos = pos.Next;
                    }
                    toDelete = startOfDelete;
                }
                else
                {
                    prev = pos;
                    pos = pos.Next;
                }
            }
            return list;
        }

        static int SmallestNumThatIsCombined(Node<int> list1, Node<int> list2)//Q37
        {
            while (list1 != null && list2 != null)
            {
                if (list1.Value < list2.Value)
                    list1 = list1.Next;
                else if (list1.Value > list2.Value)
                    list2 = list2.Next;
                else if (list1.Value == list2.Value)
                    return list1.Value;
            }
            return -999;
        }

        static Node<int> MatchingNumbersSorted(Node<int> list1, Node<int> list2)//Q38
        {
            Node<int> dummy = new Node<int>(0);
            Node<int> pos = dummy.Next;
            while (list1 != null && list2 != null)
            {
                if (list1.Value < list2.Value)
                    list1 = list1.Next;
                else if (list1.Value > list2.Value)
                    list2 = list2.Next;
                else if (list1.Value == list2.Value)
                {
                    pos = new Node<int>(list1.Value);
                    pos = pos.Next;
                }
            }
            return dummy.Next;
        }


        static Node<int> SumOfNodes(Node<int> list1, Node<int> list2)
        {
            Node<int> startOfList = new Node<int>(list1.Value + list2.Value);
            Node<int> pos = startOfList;
            list1 = list1.Next;
            list2 = list2.Next;
            while (list1 != null && list2 != null)
            {
                pos.Next = new Node<int>(list1.Value + list2.Value);
                pos = pos.Next;
                list1 = list1.Next;
                list2 = list2.Next;
            }
            if (list1 == null && list2 != null)
            {
                while (list2 != null)
                {
                    pos.Next = new Node<int>(list2.Value);
                    pos = pos.Next;
                    list2 = list2.Next;
                }
            }
            else if (list1 != null && list2 == null)
            {
                while (list1 != null)
                {
                    pos.Next = new Node<int>(list1.Value);
                    pos = pos.Next;
                    list1 = list1.Next;
                }
            }
            return startOfList;
        }

        static Node<int> ConvertToSortedList(Node<int> chain)//Q36
        {
            Node<int> rtnList = null;
            while (chain != null)
            {
                rtnList = InputIntoSortedList(rtnList, chain.Value);
                chain = chain.Next;
            }
            return rtnList;
        }

        static Node<int> InputIntoSortedList(Node<int> list, int num)//Q36 helper
        {
            Node<int> startOfList = list;
            if (list == null)
            {
                list = new Node<int>(num);
                return list;
            }
            if (num <= startOfList.Value)
            {
                startOfList = new Node<int>(num, startOfList);
            }
            else
            {
                list = startOfList;
                while (list.HasNext() && num > list.Next.Value)
                {
                    list = list.Next;
                }
                list.Next = new Node<int>(num, list.Next);
            }
            return startOfList;
        }

        static void Main(string[] args)
        {
            Node<int> list = new Node<int>(4, new Node<int>(2, new Node<int>(8, new Node<int>(1, new Node<int>(3)))));
            Node<int> toDelete = new Node<int>(2, new Node<int>(8, new Node<int>(1)));
            Console.WriteLine();
            Console.WriteLine(list);
            Console.WriteLine(toDelete);
            Console.WriteLine(DeleteNode(list, toDelete));
            Node<int> list2 = new Node<int>(4, new Node<int>(2, new Node<int>(8, new Node<int>(1, new Node<int>(3)))));
            Console.WriteLine(ConvertToSortedList(list2));
        }
    }
}
