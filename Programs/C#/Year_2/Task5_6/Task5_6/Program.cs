using System;

namespace Task5_6
{
    class Program
    {
        static Node<int> BuildReverseList(int n)
        {
            Console.Write($"Enter an integer: ");
            Node<int> list = new Node<int>(int.Parse(Console.ReadLine()));
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Enter an integer: ");
                list = new Node<int>(int.Parse(Console.ReadLine()), list);
            }
            return list;
        }

        static Node<int> BuildList(int n)
        {
            Console.Write($"Enter an integer: ");
            Node<int> last = new Node<int>(int.Parse(Console.ReadLine()));
            Node<int> startOfList = last;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Enter an integer: ");
                last.Next = new Node<int>(int.Parse(Console.ReadLine()));
                last = last.Next;
            }
            return startOfList;
        }


        static Node<int> BuildSortedList(int n)
        {
            Console.Write($"Enter an integer: ");
            Node<int> list = new Node<int>(int.Parse(Console.ReadLine()));
            Node<int> startOfList = list;
            for (int i = 1; i < n; i++)
            {
                Console.Write($"Enter an integer: ");
                int num = int.Parse(Console.ReadLine());
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
            }
            return startOfList;
        }
        static void Main(string[] args)
        {
            const int N = 7;
            Node<int> list = BuildReverseList(N);
            Console.WriteLine(list.ToString());
            list = BuildList(N);
            Console.WriteLine(list.ToString());
            list = BuildSortedList(N);
            Console.WriteLine(list.ToString());
        }
    }
}
