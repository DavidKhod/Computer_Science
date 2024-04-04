using System;

namespace Task5_4
{
    class Program
    {
        static Node<int> BeginToLength(int beginer, int num)//Q1
        {
            Node<int> start = new Node<int>(beginer);
            Node<int> pos = start;
            for (int i = 1; i < num; i++)
            {
                pos.Next = new Node<int>(beginer + i);
                pos = pos.Next;
            }
            return start;
        }

        static Node<int> BuildReverseList()//Q2
        {
            Console.Write($"Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            Node<int> start = null;
            while (num != -999)
            {
                start = new Node<int>(num, start);
                Console.Write($"Enter an integer: ");
                num = int.Parse(Console.ReadLine());
            }
            return start;
        }
        static Node<int> BuildSortedList(int n)//Q3
        {
            Console.Write($"Enter an integer: ");
            Node<int> list = new Node<int>(int.Parse(Console.ReadLine()));
            Node<int> startOfList = list;
            Console.Write($"Enter an integer: ");
            int num = int.Parse(Console.ReadLine());
            while (num != -999)
            {
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
                Console.Write($"Enter an integer: ");
                num = int.Parse(Console.ReadLine());
            }
            return startOfList;
        }

        static Node<int> sumOfNodes(Node<int> list1, Node<int> list2)//Q4
        {
            Node<int> sums = new Node<int>(list1.Value + list2.Value);
            Node<int> pos = sums;
            list1 = list1.Next;
            list2 = list2.Next;
            int longest = Math.Max(GetLength(list1), GetLength(list2));
            for (int i = 1; i <= longest; i++)
            {
                if (list1 != null && list2 != null)
                {
                    pos.Next = new Node<int>(list1.Value + list2.Value);
                    pos = pos.Next;
                    list1 = list1.Next;
                    list2 = list2.Next;
                }
                else if (list1 == null)
                {
                    pos.Next = new Node<int>(list2.Value);
                    pos = pos.Next;
                    list2 = list2.Next;
                }
                else if (list2 == null)
                {
                    pos.Next = new Node<int>(list1.Value);
                    pos = pos.Next;
                    list1 = list1.Next;
                }
            }
            return sums;
        }

        static int GetLength(Node<int> list)
        {
            int count = 0;
            while (list != null)
            {
                count++;
                list = list.Next;
            }
            return count;
        }

        static Node<int> BuildNodeOfSmallNodesMinValue(Node<int> list)//Q5
        {
            int min;
            min = list.Value;
            list = list.Next;
            while (list != null && list.Value != 1)
            {
                min = Math.Min(min, list.Value);
                list = list.Next;
            }
            Node<int> startofMins = new Node<int>(min);
            Node<int> pos = startofMins;
            while (list != null)
            {
                list = list.Next;
                min = list.Value;
                list = list.Next;
                while (list != null && list.Value != 1)
                {
                    min = Math.Min(min, list.Value);
                    list = list.Next;
                }
                pos.Next = new Node<int>(min);
                pos = pos.Next;
            }
            return startofMins;
        }

        static Node<int> NotStartingZero(Node<int> list)//Q7
        {
            while (list.Value == 0)
            {
                list = list.Next;
            }
            return list;
        }

        static void RemoveNum(Node<int> list, int num)//Q6 Working but not if the list is full of num
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


        static Random rnd = new Random();
        static Node<int> RandomNodeWithNoDuplicates()//Q8
        {
            Node<int> start = new Node<int>(rnd.Next(10, 100));
            Node<int> pos = start;
            int random;
            for (int i = 1; i <= 50; i++)
            {
                random = rnd.Next(10, 100);
                if (!Exist(start, random))
                {
                    pos.Next = new Node<int>(random);
                    pos = pos.Next;
                }
            }
            return start;
        }

        static bool Exist(Node<int> list, int num)
        {
            while (list != null)
            {
                if (num == list.Value)
                    return true;
                list = list.Next;
            }
            return false;
        }

        static Node<int> AllDontAppear(Node<int> list)
        {
            int temp = 10;
            while (Exist(list, temp))
            {
                temp++;
            }
            Node<int> start = new Node<int>(temp);
            Node<int> pos = start;
            for (int i = temp + 1; i < 100; i++)
            {
                if (!Exist(list, i))
                {
                    pos.Next = new Node<int>(i);
                    pos = pos.Next;
                }
            }
            return start;
        }

        static Node<int> RemoveAllDuplicates(Node<int> list)//Q9
        {
            Node<int> start = list;
            while (list != null)
            {
                RemoveNum(list, list.Value);
                list = list.Next;
            }
            return start;
        }

        static void RemoveMidMaxIfEvenOrStartAndEndIfOdd(Node<int> list)//Q10
        {
            Node<int> start = list;
            Node<int> pos = list;
            if (GetLength(list) % 2 == 0)
            {
                for (int i = 1; i < (GetLength(list) / 2); i++)
                {
                    pos = pos.Next;
                }
                if (pos.Next.Value > pos.Next.Next.Value)
                    pos.Next = pos.Next.Next;
                else
                {
                    pos = pos.Next;
                    pos.Next = pos.Next.Next;
                }
            }
            else
            {
                start = start.Next;
                while (pos.Next.HasNext())
                    pos = pos.Next;
                pos.Next = null;
            }
        }

        static Node<int> RemoveFromBothAndAddAmountRemoved(Node<int> chain1, Node<int> chain2, int num)//Q11
        {
            num = 0;
            while (chain2 != null)
            {
                if (Exist(chain1, chain2.Value))
                {
                    RemoveNum(chain1, chain2.Value);
                    num++;
                }
                chain2 = chain2.Next;
            }
            Node<int> startOfChain1 = chain1;
            while (chain1.HasNext())
            {
                chain1 = chain1.Next;
            }
            chain1.Next = new Node<int>(num);
            return startOfChain1;
        }

        static void Main(string[] args)
        {
            //Q4
            Console.WriteLine("------------Q4------------");
            Node<int> list1 = new Node<int>(1,
                new Node<int>(2,
                new Node<int>(3,
                new Node<int>(4))));
            Node<int> list2 = new Node<int>(1, new Node<int>(2, new Node<int>(3, new Node<int>(4, new Node<int>(5, new Node<int>(6))))));
            Console.WriteLine($"List1: {list1.ToString()}");
            Console.WriteLine($"List2: {list2.ToString()}");
            Console.WriteLine($"Sum Of lists: {sumOfNodes(list1, list2)}");

            //Q5
            Console.WriteLine("------------Q5------------");
            Node<int> list = new Node<int>(2,
                  new Node<int>(2,
                  new Node<int>(1,
                  new Node<int>(4,
                  new Node<int>(5,
                  new Node<int>(6,
                  new Node<int>(1,
                new Node<int>(4, new Node<int>(3)))))))));
            Console.WriteLine($"List: {list.ToString()}");
            Console.WriteLine($"List of smalls list's min: {BuildNodeOfSmallNodesMinValue(list).ToString()}");

            //Q7
            Console.WriteLine($"------------Q7------------");
            list = new Node<int>(0, new Node<int>(0, new Node<int>(0, new Node<int>(2, new Node<int>(2, new Node<int>(1, new Node<int>(4, new Node<int>(5, new Node<int>(6, new Node<int>(1, new Node<int>(4, new Node<int>(3))))))))))));
            Console.WriteLine($"List: {list.ToString()}");
            Console.WriteLine($"List with no zeros: {NotStartingZero(list).ToString()}");

            //Q6
            Console.WriteLine("------------Q6------------");
            Node<int> list5 = new Node<int>(2,
                new Node<int>(2,
                new Node<int>(1,
                new Node<int>(2, new Node<int>(2)))));
            Console.WriteLine($"List: {list5.ToString()}");
            RemoveNum(list5, 2);
            Console.WriteLine($"List without 2: {list5.ToString()}");

            //Q8
            Console.WriteLine($"------------Q8------------");
            Node<int> list8 = RandomNodeWithNoDuplicates();
            Console.WriteLine($"Random list: {list8.ToString()}");
            Console.WriteLine($"list with all that don't appear: {AllDontAppear(list8).ToString()}");

            //Q9
            Console.WriteLine($"------------Q9------------");
            Node<int> list9 = new Node<int>(1,
                new Node<int>(1,
                new Node<int>(2,
                new Node<int>(3, new Node<int>(4, new Node<int>(2))))));
            Console.WriteLine($"List: {list9.ToString()}");
            Console.WriteLine($"With no Duplicates: {RemoveAllDuplicates(list9).ToString()}");

            //Q10
            Console.WriteLine($"------------Q10------------");
            Node<int> list10 = new Node<int>(2,
                  new Node<int>(2,
                  new Node<int>(1,
                  new Node<int>(4,
                  new Node<int>(5,
                  new Node<int>(6,
                  new Node<int>(1,
                new Node<int>(4, new Node<int>(3, new Node<int>(5))))))))));
            Console.WriteLine($"List: {list10.ToString()}");
            RemoveMidMaxIfEvenOrStartAndEndIfOdd(list10);
            Console.WriteLine($"List: {list10.ToString()}");

        }
    }
}
